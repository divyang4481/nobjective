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
using System.Runtime.InteropServices;

namespace MObjc
{
	[DisableRuleAttribute("R1001", "DisposeNativeResources")]
	[DisableRuleAttribute("D1035", "ImplicitCast")]
	public sealed class Selector : IEquatable<Selector>	// thread safe
	{
		// Name should be something like "stringWithCharacters:length:".
		public Selector(string name)
		{
			Trace.Assert(!string.IsNullOrEmpty(name), "name is null or empty");
				
			m_selector = sel_registerName(name);
			m_name = name;

			if (m_selector == IntPtr.Zero)
				throw new ArgumentException(name + " is not a known selector");
		}
		
		public Selector(IntPtr selector)
		{
			Trace.Assert(selector != IntPtr.Zero, "selector is nil");
			
			m_selector = selector;

			IntPtr ptr = sel_getName(m_selector);
			m_name = Marshal.PtrToStringAnsi(ptr);
		}
				
		public string Name
		{
			get {return m_name;}
		}
		
		public static implicit operator IntPtr(Selector value) 
		{
			return value != null ? value.m_selector : IntPtr.Zero;
		}
	
		// Need this for languages like VB that don't support operator overloading.
		public static IntPtr ToIntPtrType(Selector value)
		{
			return value != null ? value.m_selector : IntPtr.Zero;
		}
    
 		public override string ToString()
		{
			return m_name;
		}
						
		public override bool Equals(object rhsObj)
		{
			if (rhsObj == null)    
				return false;
			
			Selector rhs = rhsObj as Selector;
			return this == rhs;
		}
			
		public bool Equals(Selector rhs)  
		{
			return this == rhs;
		}
	
		public static bool operator==(Selector lhs, Selector rhs)
		{
			if (object.ReferenceEquals(lhs, rhs))
				return true;
			
			if ((object) lhs == null || (object) rhs == null)
				return false;
			
			return lhs.m_name == rhs.m_name;
		}
		
		public static bool operator!=(Selector lhs, Selector rhs)
		{
			return !(lhs == rhs);
		}
		
		public override int GetHashCode()
		{
			return m_name.GetHashCode();
		}

		#region Selectors -----------------------------------------------------
		internal static readonly Selector Alloc = new Selector("alloc");
		internal static readonly Selector Autorelease = new Selector("autorelease");
		internal static readonly Selector Class = new Selector("class");
		internal static readonly Selector Description = new Selector("description");
		internal static readonly Selector Hash = new Selector("hash");
		internal static readonly Selector Init = new Selector("init");
		internal static readonly Selector IsEqual = new Selector("isEqual:");
		internal static readonly Selector Release = new Selector("release");
		internal static readonly Selector Retain = new Selector("retain");
		internal static readonly Selector RetainCount = new Selector("retainCount");
		internal static readonly Selector SuperClass = new Selector("superclass");
		internal static readonly Selector UTF8String = new Selector("UTF8String");
		#endregion

		#region P/Invokes -----------------------------------------------------
 		[DllImport("/usr/lib/libobjc.dylib")]
		private extern static IntPtr sel_registerName(string name);

   		[DllImport("/usr/lib/libobjc.dylib")]
		private extern static IntPtr sel_getName(IntPtr selector);
		#endregion
		
		#region Fields --------------------------------------------------------
		private IntPtr m_selector;
		private string m_name;
		#endregion
	}
}
