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
using System.Diagnostics;
using System.Reflection;

namespace MObjc
{
	public static class ObjectExtensions
	{
		// These are provided so Call expressions can be chained.
		public static object Call(this object instance, string selector, params object[] args)
		{
			return ObjectExtensions.Call(instance, new Selector(selector), args);
		}
	
		public static object Call(this object instance, Selector selector, params object[] args)
		{			
			Trace.Assert(selector != null, "selector is null");
			Trace.Assert(args != null, "args is null");
			
			object result = new NSObject(IntPtr.Zero);
			
			if (instance != null)
			{
				IntPtr ptr;
				if (instance.GetType() == typeof(IntPtr))							
					ptr = (IntPtr) instance;
				else
					ptr = (IntPtr) (NSObject) instance;

				if (selector.Name == "init" && args.Length == 0)
				{
					IntPtr exception = IntPtr.Zero;
					IntPtr ip = DirectCalls.Callp(ptr, Selector.Init, ref exception);
					if (exception != IntPtr.Zero)
						CocoaException.Raise(exception);
						
					result = NSObject.Lookup(ip);
				}
				else
				{
					Native invoke = new Native(ptr, selector);
					invoke.SetArgs(args);			
					result = invoke.Invoke();
				}
			}
			
			return result;
		}
		
		// This works just like a cast from value to T except that if the cast
		// fails an exception with a reasonable message is thrown. (You can
		// also use mono --debug=casts but that doesn't work on all platforms).
		// TODO: might want to remove this when and if --debug=casts works on
		// more platforms.
		public static T To<T>(this object value)
		{
			// If the value is null then return some form of null.
			if (value == null || value.Equals(IntPtr.Zero))
				if (typeof(T).IsValueType)
					throw new InvalidCastException("Value is null");

				else if (typeof(T) == typeof(NSObject))
					return (T) (object) new NSObject(IntPtr.Zero);

				else if (typeof(NSObject).IsAssignableFrom(typeof(T)))
					return (T) Activator.CreateInstance(typeof(T), BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public, null, 
						new object[]{IntPtr.Zero}, null);

				else
					return default(T);
				
			// If T matches the value type then just cast value to that type.
			Type type = value.GetType();
			if (type == typeof(T))							
				return (T) value;
				
			// If T is bool then allow value to be an sbyte.
			if (typeof(T) == typeof(bool) && type == typeof(sbyte))
				return (T) (object) ((sbyte) value != 0);
			
			// If T is NSObject, a derived class, or IntPtr then do a lookup and
			// return the correct managed class.
			if (type == typeof(IntPtr) || typeof(NSObject).IsAssignableFrom(typeof(T)))
			{
				IntPtr instance = IntPtr.Zero;
				if (type == typeof(IntPtr))							
					instance = (IntPtr) value;
				else
					instance = (IntPtr) (NSObject) value;
					
				NSObject obj = NSObject.Lookup(instance);
				if (obj == null)
					return default(T);
				else if (typeof(T).IsAssignableFrom(obj.GetType()))
					return (T) (object) obj;
				else
					throw new InvalidCastException("Can't cast from " + obj.class_().Name + " to " + typeof(T) + ".");
			}
			
			throw new InvalidCastException("Can't cast from " + type + " to " + typeof(T) + ".");
		}
	}
}
