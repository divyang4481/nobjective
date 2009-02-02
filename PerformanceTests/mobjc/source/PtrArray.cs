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
using System.Runtime.InteropServices;

namespace MObjc
{
	// Manages a pointer to an array of pointers.
	[DisableRuleAttribute("R1001", "DisposeNativeResources")]
	internal sealed class PtrArray
	{
		public PtrArray(int count)
		{
			Trace.Assert(count >= 0, "count is negative");
				
			m_array = Marshal.AllocHGlobal(count * Marshal.SizeOf(typeof(IntPtr)));
			m_count = count;
		}
		
		public PtrArray(IntPtr array, int count)
		{
			Trace.Assert(count >= 0, "count is negative");
			Trace.Assert(array != IntPtr.Zero, "array is nil");	// always require an array (simplifies error checking)
				
			m_array = array;
			m_count = count;
		}
		
		public int Length
		{
			get {return m_count;}
		}
		
		public IntPtr this[int index]
		{
			get
			{
				Trace.Assert(index >= 0 && index < m_count, string.Format("bad index: {0}", index));
					
				return Marshal.ReadIntPtr(m_array, index * Marshal.SizeOf(typeof(IntPtr)));
			}
			
			set
			{
				Trace.Assert(index >= 0 && index < m_count, string.Format("bad index: {0}", index));
					
				Marshal.WriteIntPtr(m_array, index * Marshal.SizeOf(typeof(IntPtr)), value);
			}
		}
 
 		public static explicit operator IntPtr(PtrArray value) 
		{
			if (value.m_array == IntPtr.Zero)							
				throw new ArgumentException("array is null");

			return value.m_array;
		}
		
		public void Free()
		{
			if (m_array != IntPtr.Zero)							
			{
				for (int i = 0; i < m_count; ++i)
					Marshal.FreeHGlobal(this[i]);
				
				Marshal.FreeHGlobal(m_array);
				m_array = IntPtr.Zero;
			}
		}
												
		public void FreeBuffer()
		{
			if (m_array != IntPtr.Zero)							
			{				
				Marshal.FreeHGlobal(m_array);
				m_array = IntPtr.Zero;
			}
		}
												
		private IntPtr m_array;
		private int m_count;
	}
}
