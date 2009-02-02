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

namespace MObjc
{	
	// http://developer.apple.com/documentation/Cocoa/Reference/Foundation/Protocols/NSObject_Protocol/Reference/NSObject.html#//apple_ref/doc/uid/20000052-BBCEBEIC
	public partial class NSObject : IFormattable
	{		
		#region Protocol
		public void autorelease()
		{
			Trace.Assert(!m_deallocated, "ref count is zero");
				
			if (m_instance != IntPtr.Zero)
			{
				IntPtr exception = IntPtr.Zero;
				Unused.Value = DirectCalls.Callp(this, Selector.Autorelease, ref exception);
				if (exception != IntPtr.Zero)
					CocoaException.Raise(exception);
			}
		}
				
		public static NSObject alloc()
		{
			if (ms_class == null)
				ms_class = new Class("NSObject");
				
			return ms_class.Alloc();
		}

		public NSObject init()
		{
			IntPtr exception = IntPtr.Zero;
			IntPtr instance = DirectCalls.Callp(this, Selector.Init, ref exception);
			if (exception != IntPtr.Zero)
				CocoaException.Raise(exception);

			return NSObject.Lookup(instance);
		}

		public bool conformsToProtocol(IntPtr protocol)
		{
			Trace.Assert(protocol != IntPtr.Zero, "protocol is nil");
			Trace.Assert(!m_deallocated, "ref count is zero");
				
			if (m_instance != IntPtr.Zero)
				return (sbyte) Call("conformsToProtocol:", protocol) != 0;
			else
				return false;
		}
		
		public string description()
		{
			Trace.Assert(!m_deallocated, "ref count is zero");
				
			if (m_instance != IntPtr.Zero)
			{
				IntPtr exception = IntPtr.Zero;
				IntPtr str = DirectCalls.Callp(this, Selector.Description, ref exception);
				if (exception != IntPtr.Zero)
					CocoaException.Raise(exception);

				IntPtr utf8 = DirectCalls.Callp(str, Selector.UTF8String, ref exception);
				if (exception != IntPtr.Zero)
					CocoaException.Raise(exception);
					
				return Marshal.PtrToStringAuto(utf8);
			}
			else
				return "nil";
		}
		
		public int hash()
		{
			Trace.Assert(!m_deallocated, "ref count is zero");
			
			int hash = 0;
				
			if (m_instance != IntPtr.Zero)
			{
				IntPtr exception = IntPtr.Zero;
				hash = DirectCalls.Calli(this, Selector.Hash, ref exception);
				if (exception != IntPtr.Zero)
					CocoaException.Raise(exception);
			}

			return hash;
		}
		
		public bool isEqual(NSObject rhs)
		{
			Trace.Assert(!m_deallocated, "ref count is zero");
			
			bool equal = m_instance == (IntPtr) rhs;
			
			if (!equal && m_instance != IntPtr.Zero)
			{
				IntPtr exception = IntPtr.Zero;
				byte result = DirectCalls.CallCp(this, Selector.IsEqual, rhs, ref exception);
				if (exception != IntPtr.Zero)
					CocoaException.Raise(exception);
					
				equal = result != 0;
			}
			
			return equal;
		}
		
		public bool isKindOfClass(NSObject rhs)
		{
			Trace.Assert(!NSObject.IsNullOrNil(rhs), "rhs is null or nil");
			Trace.Assert(!m_deallocated, "ref count is zero");
				
			if (m_instance != IntPtr.Zero)
				return (sbyte) Call("isKindOfClass:", rhs) != 0;
			else
				return false;
		}
										
		public bool isMemberOfClass(NSObject klass)
		{
			Trace.Assert(!NSObject.IsNullOrNil(klass), "klass is null or nil");
			Trace.Assert(!m_deallocated, "ref count is zero");
				
			if (m_instance != IntPtr.Zero)
				return (sbyte) Call("isMemberOfClass:", klass) != 0;
			else
				return false;
		}
										
		public bool isProxy()
		{
			Trace.Assert(!m_deallocated, "ref count is zero");
				
			if (m_instance != IntPtr.Zero)
				return (sbyte) Call("isProxy") != 0;
			else
				return false;
		}
				
		// Retain counts work exactly like in native code. In particular code that
		// creates a native object using a managed constructor does not have an
		// ownership stake in the object unless it explicitly calls Retain. See
		// <http://developer.apple.com/documentation/Cocoa/Conceptual/MemoryMgmt/Tasks/MemoryManagementRules.html#//apple_ref/doc/uid/20000994>
		// for details on the memory management rules.
		public void release()
		{
			Trace.Assert(!m_deallocated, "ref count is zero");
				
			uint oldCount = retainCount();
				
			IntPtr exception = IntPtr.Zero;
			Unused.Value = DirectCalls.Callp(m_instance, Selector.Release, ref exception);
			if (exception != IntPtr.Zero)
				CocoaException.Raise(exception);
				
			if (oldCount == 1)
				m_deallocated = true;		// OnDealloc won't be called for registered types so we'll go ahead and set dealloced here
		}
						
		public bool respondsToSelector(string selector)
		{
			return respondsToSelector(new Selector(selector));
		}
				
		public bool respondsToSelector(Selector selector)
		{
			Trace.Assert(selector != null, "selector is null");
			Trace.Assert(!m_deallocated, "ref count is zero");
				
			if (m_instance != IntPtr.Zero)
				return (sbyte) Call("respondsToSelector:", selector) != 0;
			else
				return false;
		}
				
		public NSObject retain()
		{
			Trace.Assert(!m_deallocated, "ref count is zero");
				
			IntPtr exception = IntPtr.Zero;
			Unused.Value = DirectCalls.Callp(m_instance, Selector.Retain, ref exception);
			if (exception != IntPtr.Zero)
				CocoaException.Raise(exception);
				
			return this;
		}
		
		public uint retainCount()
		{
			Trace.Assert(!m_deallocated, "ref count is zero");
				
			uint count = uint.MaxValue;
			
			if (m_instance != IntPtr.Zero)
			{
				IntPtr exception = IntPtr.Zero;
				count = unchecked((uint) DirectCalls.Calli(m_instance, Selector.RetainCount, ref exception));
				if (exception != IntPtr.Zero)
					CocoaException.Raise(exception);
			}

			return count;
		}
		
		public Class class_()
		{
			return new Class(m_class);
		}
		
		public Class superclass()
		{
			Trace.Assert(!m_deallocated, "ref count is zero");
				
			if (m_instance != IntPtr.Zero)
				return (Class) Call("superclass");
			else
				return new Class(IntPtr.Zero);
		}
		
		public IntPtr zone()
		{
			Trace.Assert(!m_deallocated, "ref count is zero");
				
			return (IntPtr) Call("zone");
		}
		#endregion
		
		#region Instance Methods
		public NSObject copy()
		{
			Trace.Assert(!m_deallocated, "ref count is zero");
				
			if (m_instance != IntPtr.Zero)
				return NSObject.Lookup((IntPtr) Call("copy"));
			else
				return new NSObject(IntPtr.Zero);
		}

		public NSObject mutableCopy()
		{
			Trace.Assert(!m_deallocated, "ref count is zero");
				
			if (m_instance != IntPtr.Zero)
				return NSObject.Lookup((IntPtr) Call("mutableCopy"));
			else
				return new NSObject(IntPtr.Zero);
		}

		public void performSelectorOnMainThreadWithObjectWaitUntilDone(Selector selector, NSObject arg, bool wait)
		{
			Trace.Assert(selector != null, "selector is null");
			Trace.Assert(!m_deallocated, "ref count is zero");
				
			if (m_instance != IntPtr.Zero)
			{
				Unused.Value = Call("performSelectorOnMainThread:withObject:waitUntilDone:",
					selector, arg, wait);
			}
		}
		#endregion

		private static Class ms_class;
	}
}
