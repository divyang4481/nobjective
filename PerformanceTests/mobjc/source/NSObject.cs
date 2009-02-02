// Copyright (C) 2008 Jesse Jones
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace MObjc
{	
	// http://developer.apple.com/documentation/Cocoa/Reference/Foundation/Protocols/NSObject_Protocol/Reference/NSObject.html#//apple_ref/doc/uid/20000052-BBCEBEIC
	[DisableRuleAttribute("S1003", "KeepAlive")]
	[DisableRuleAttribute("P1014", "InlineStaticInit")]
	[DisableRuleAttribute("D1035", "ImplicitCast")]
	[DisableRuleAttribute("P1012", "NotInstantiated")]
	[DisableRuleAttribute("C1026", "NoStaticRemove")]
	[DisableRuleAttribute("D1041", "CircularReference")]
	[DisableRule("D1007", "UseBaseTypes")]
	public partial class NSObject : IFormattable, IEquatable<NSObject>
	{		
		[DisableRuleAttribute("D1038", "DontExit2")]
		static NSObject()
		{
			try
			{
				Registrar.Init();
			}
			catch (Exception e)
			{
				// This is a fatal error and the nunit which ships with mono does a poor
				// job printing inner exceptions. So, we'll print the exception ourself
				// and shutdown the app.
				Console.Error.WriteLine("Registrar.Init raised an exception:");
				Exception ee = e;
				while (ee != null)
				{
					if (e.InnerException != null)
						Console.Error.WriteLine("--------- {0} Exception{1}", ee == e ? "Outer" : "Inner", Environment.NewLine);
					Console.Error.WriteLine("{0}", ee.Message + Environment.NewLine);
					Console.Error.WriteLine("{0}", ee.StackTrace + Environment.NewLine);

					ee = ee.InnerException;
				}
				Console.Out.Flush();
				Console.Error.Flush();
				Environment.Exit(13);
			}
		}
				
		// Constructs a new managed instance using a native id. Note that there
		// may be an arbitrary number of managed instances wrapping the same native
		// id, except for the exported classes. For the exported classes NSObject
		// enforces a constraint that requires that each exported class id is
		// wrapped by no more than one managed instance.
		[DisableRuleAttribute("D1032", "UnusedMethod")]
		public NSObject(IntPtr instance)
		{
			m_instance = instance;				// note that it's legal to send messages to nil
			m_class = IntPtr.Zero;

			if (m_instance != IntPtr.Zero)
			{
				// It's a little inefficient to always grab this information, but it makes
				// dumping objects much easier because we can safely do it even when ref
				// counts are zero.
				IntPtr exception = IntPtr.Zero;
				m_class = DirectCalls.Callp(m_instance, Selector.Class, ref exception);
				if (exception != IntPtr.Zero)
					CocoaException.Raise(exception);
	
				m_baseClass = DirectCalls.Callp(m_class, Selector.SuperClass, ref exception);
				if (exception != IntPtr.Zero)
					CocoaException.Raise(exception);
	
				lock (ms_instancesLock)
				{
					bool exported;
					Type type = GetType();
					if (!ms_exports.TryGetValue(type, out exported))	// GetCustomAttribute turns out to be very slow
					{
						ExportClassAttribute attr = Attribute.GetCustomAttribute(type, typeof(ExportClassAttribute)) as ExportClassAttribute;
						exported = attr != null;
						ms_exports.Add(type, exported);
					}
					
					if (exported)
					{
						if (ms_instances.ContainsKey(instance))
							throw new InvalidOperationException(type + " is being constructed twice with the same id.");
					
						ms_instances.Add(instance, this);
					}
				}
#if DEBUG
				ms_refs.Add(this);
#endif
			}
		}
		
		public static IntPtr AllocNative(string name)
		{
			Class klass = new Class(name);

			IntPtr exception = IntPtr.Zero;
			IntPtr instance = DirectCalls.Callp(klass, Selector.Alloc, ref exception);
			if (exception != IntPtr.Zero)
				CocoaException.Raise(exception);
			
			instance = DirectCalls.Callp(instance, Selector.Init, ref exception);
			if (exception != IntPtr.Zero)
				CocoaException.Raise(exception);
			
			return instance;
		}

		// It's quite handy to have a retain method that returns the correct type
		// but we don't want to call it retain because it will be registered as an
		// override for exported classes which tends to cause problems.
		public NSObject Retain()
		{
			Unused.Value = retain();
			return this;
		}

		// Note that this is the static NSObject class type. To get the dynamic type
		// of an instance use the class_() method.
		public static Class Class
		{
			get {return ms_class;}
		}

		public static NSObject Lookup(IntPtr instance)	// thread safe
		{
			NSObject managed = null;
			
			lock (ms_instancesLock)
			{
				if (!ms_instances.TryGetValue(instance, out managed))
				{
					// Nil is tricky to handle because we want to do things like convert
					// id's to NSObject subclasses when marshaling from native to managed
					// code. But we can't do this with nil because it has no class info.
					// So, rather than returning an NSObject which will break marshaling
					// we simply return null.
					if (instance == IntPtr.Zero)		
						return null;
											
					// If we land here then we have a native instance with no associated
					// managed instance. This will happen if the native instance isn't
					// an exported type, or it is exported and it's calling a managed
					// method for the first time.

					// First try to create an NSObject derived instance using the types
					// which were registered or exported.
					Type type = DoGetManagedClass(object_getClass(instance));
					if (type != null)
					{
						Func<IntPtr, NSObject> factory;
						if (!ms_factories.TryGetValue(type, out factory))	// Activator.CreateInstance is also a bottleneck
						{
							ConstructorInfo info = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, ms_factoryArgTypes, null);
							if (info == null)
								throw new InvalidOperationException("Couldn't find an (IntPtr) ctor for " + type);
							factory = i => (NSObject) info.Invoke(new object[]{i});
							ms_factories.Add(type, factory);
						}
						managed = factory(instance);
					}
					// If we can't create a subclass then just create an NSObject.
					else
						managed = new NSObject(instance);
				}
			}
			
			return managed;
		}
				
		public static implicit operator IntPtr(NSObject value) 
		{							
			return value != null ? value.m_instance : IntPtr.Zero;
		}
		
		// Need this for languages like VB that don't support operator overloading.
		public static IntPtr ToIntPtrType(NSObject value)
		{				
			return value != null ? value.m_instance : IntPtr.Zero;
		}
    
		public static bool IsNullOrNil(NSObject o)
		{				
			return o == null || o.m_instance == IntPtr.Zero;
		}
		
		public bool IsNil()
		{				
			return m_instance == IntPtr.Zero;
		}
		
		// This should only be used for debugging and testing. It will be set
		// correctly for types exported with ExportClassAttribute and for instances
		// released using the managed release method, but will not be set for
		// non-exported instances released from unmanaged code.
		public bool IsDeallocated()
		{
			return m_deallocated;
		}
		
		public object Call(string name, params object[] args)	// thread safe
		{
			Trace.Assert(name != null, "name is null");
			Trace.Assert(!m_deallocated, "ref count is zero");
			
			object result;

			if (m_instance != IntPtr.Zero)
				result = Native.Call(m_instance, name, args);
			else
				result = new NSObject(IntPtr.Zero);
			
			return result;
		}
		
		public object SuperCall(string name, params object[] args)
		{
			Trace.Assert(name != null, "name is null");
			Trace.Assert(!m_deallocated, "ref count is zero");
				
			object result = IntPtr.Zero;

			if (m_instance != IntPtr.Zero)
			{
				Native native = new Native(m_instance, new Selector(name), class_().BaseClass);
				native.SetArgs(args);			
				result = native.Invoke();
			}
			
			return result;
		}
				
		public NSObject this[string ivarName]
		{
			get
			{
				Trace.Assert(!string.IsNullOrEmpty(ivarName), "ivarName is null or empty");
				Trace.Assert(!m_deallocated, "ref count is zero");
				
				NSObject result;
				
				if (m_instance != IntPtr.Zero)
				{					
					IntPtr value = IntPtr.Zero;
					IntPtr ivar = object_getInstanceVariable(m_instance, ivarName, ref value);
				
					if (ivar == IntPtr.Zero)
						throw new ArgumentException(ivarName + " isn't a valid instance variable");
						
					result = Lookup(value);
				}
				else
					result = new NSObject(IntPtr.Zero);
					
				return result;
			}
			
			set
			{
				Trace.Assert(!string.IsNullOrEmpty(ivarName), "ivarName is null or empty");
				Trace.Assert(!m_deallocated, "ref count is zero");
				
				if (m_instance != IntPtr.Zero)
				{
					// Retain the new value (if any).
					IntPtr exception = IntPtr.Zero, dummy = IntPtr.Zero;
					if (!NSObject.IsNullOrNil(value))
					{
						Unused.Value = DirectCalls.Callp(value, Selector.Retain, ref exception);
						if (exception != IntPtr.Zero)
							CocoaException.Raise(exception);
					}

					// Release the old value (if any).
					IntPtr oldValue = IntPtr.Zero;
					IntPtr ivar = object_getInstanceVariable(m_instance, ivarName, ref oldValue);				
					if (ivar == IntPtr.Zero)
					{
						Unused.Value = DirectCalls.Callp(value, Selector.Release, ref dummy);
						throw new ArgumentException(ivarName + " isn't a valid instance variable");
					}

					if (oldValue != IntPtr.Zero)
					{
						Unused.Value = DirectCalls.Callp(oldValue, Selector.Release, ref exception);
						if (exception != IntPtr.Zero)
						{
							Unused.Value = DirectCalls.Callp(value, Selector.Release, ref dummy);
							CocoaException.Raise(exception);
						}
					}
		
					// Set the value.
					ivar = object_setInstanceVariable(m_instance, ivarName, value);
				}
			}
		}
		
#if DEBUG
		// Returns a list of all NSObject's which are still alive. Note that some
		// of these may be deallocated.
		public static NSObject[] Snapshot()
		{
			return ms_refs.Snapshot();
		}
#endif
		
		public override bool Equals(object rhsObj)
		{
			if (rhsObj == null)           
				return false;
			
			NSObject rhs = rhsObj as NSObject;
			return this == rhs;
		}
			
		public bool Equals(NSObject rhs)   
		{
			return this == rhs;
		}
	
		[DisableRule("D1007", "UseBaseTypes")]
		public static bool operator==(NSObject lhs, NSObject rhs)
		{
			if (object.ReferenceEquals(lhs, rhs))
				return true;
			
			if ((object) lhs == null || (object) rhs == null)
				return false;
				
			if (lhs.IsDeallocated() && rhs.IsDeallocated())
				return object.ReferenceEquals(lhs, rhs);
			else if (lhs.IsDeallocated())
				return false;
			else if (rhs.IsDeallocated())
				return false;
			
			return lhs.isEqual(rhs);
		}
		
		public static bool operator!=(NSObject lhs, NSObject rhs)
		{
			return !(lhs == rhs);
		}
		
		public override int GetHashCode()
		{
			return hash();
		}
    
		internal static void Register(Type klass, string nativeName)
		{
			if (!ms_registeredClasses.ContainsKey(nativeName))
				ms_registeredClasses.Add(nativeName, klass);
			else
				throw new InvalidOperationException(nativeName + " has already been registered.");
		}
		
		internal IntPtr GetBaseClass()
		{
			return m_baseClass;
		}
		 						
		#region Protected Methods ---------------------------------------------
		// Only called for exported types. Derived classes must call the base class 
		// implementation.
		protected virtual void OnDealloc()
		{
			bool removed = ms_instances.Remove(m_instance);
			Trace.Assert(removed, "dealloc was called but the instance is not in ms_instances");

			Unused.Value = SuperCall("dealloc");
			m_deallocated = true;
		}
		#endregion
				
		#region Private Methods -----------------------------------------------
		private static Type DoGetManagedClass(IntPtr klass)
		{
			while (klass != IntPtr.Zero)
			{
				IntPtr ptr = class_getName(klass);
				string name = Marshal.PtrToStringAnsi(ptr);
			
				Type type;
				if (Registrar.TryGetType(name, out type))
					return type;
				else if (ms_registeredClasses.TryGetValue(name, out type))
					return type;
					
				klass = class_getSuperclass(klass);
			}
			
			return null;
		}												
		#endregion
						
		#region P/Invokes -----------------------------------------------------
		[DllImport("/usr/lib/libobjc.dylib")]
		private extern static IntPtr object_getClass(IntPtr obj);

		[DllImport("/usr/lib/libobjc.dylib")]
		private extern static IntPtr class_getName(IntPtr klass);

		[DllImport("/usr/lib/libobjc.dylib")]
		private extern static IntPtr class_getSuperclass(IntPtr klass);

		[DllImport("/usr/lib/libobjc.dylib")]
		private extern static IntPtr object_getInstanceVariable(IntPtr obj, string name, ref IntPtr outValue);

		[DllImport("/usr/lib/libobjc.dylib")]
		private extern static IntPtr object_setInstanceVariable(IntPtr obj, string name, IntPtr value);
		#endregion
					
		#region Fields --------------------------------------------------------
		private IntPtr m_instance;
		private IntPtr m_class;
		private IntPtr m_baseClass;
		private bool m_deallocated;

		private static Dictionary<IntPtr, NSObject> ms_instances = new Dictionary<IntPtr, NSObject>();
		private static object ms_instancesLock = new object();
		private static Dictionary<string, Type> ms_registeredClasses = new Dictionary<string, Type>();
		private static Dictionary<Type, bool> ms_exports = new Dictionary<Type, bool>();
		private static Dictionary<Type, Func<IntPtr, NSObject>> ms_factories = new Dictionary<Type, Func<IntPtr, NSObject>>();
		private static Type[] ms_factoryArgTypes = new Type[]{typeof(IntPtr)};
		
#if DEBUG
		private static WeakList<NSObject> ms_refs = new WeakList<NSObject>(64);
#endif
		#endregion
	}
}
