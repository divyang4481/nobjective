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

namespace MObjc
{			
	// Compacting list of System.WeakReference<T>.
	public sealed class WeakList<T> where T : class		// thread safe
	{
		public WeakList(int capacity)
		{
			Trace.Assert(capacity > 0, "capacity is not positive");
			
			m_capacity = capacity;
			m_list = new List<WeakReference>(capacity);			
		}
		
		public void Add(T o)
		{
			if (o != null)
			{
				lock (m_lock)
				{
					if (m_list.Count >= m_capacity)
						DoCompact();

					m_list.Add(new WeakReference(o));
				}
			}
		}
		
		public T[] Snapshot()
		{
			List<T> elements;
			
			lock (m_lock)
			{
				elements = new List<T>(m_list.Count);

				foreach (WeakReference wr in m_list)
				{
					T o = (T) wr.Target;
					if (o != null && !elements.Exists(e => ReferenceEquals(e, o)))
						elements.Add(o);
				}
			}
			
			return elements.ToArray();
		}
		
		private void DoCompact()
		{
			List<WeakReference> compacted = new List<WeakReference>(m_capacity);
			
			// Copy the elements in use to our new list.
			for (int i = 0; i < m_list.Count; ++i)
			{
				if (m_list[i].Target != null)
					compacted.Add(m_list[i]);
			}
		
			// If we couldn't find any free elements then we need to allow
			// our list to grow.
			if (compacted.Count >= m_capacity)
			{
				m_capacity = 2 * m_capacity;
			}
			
			// Switch to our new list.
			m_list = compacted;
		}
		
		private int m_capacity;
		private List<WeakReference> m_list;
		private object m_lock = new object();
	}
}
