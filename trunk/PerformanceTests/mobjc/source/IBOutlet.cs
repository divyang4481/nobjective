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

namespace MObjc
{			
	public sealed class IBOutlet<T> : IEquatable<IBOutlet<T>> where T : NSObject	
	{
		public IBOutlet(NSObject owner, string name)
		{
			Trace.Assert(!NSObject.IsNullOrNil(owner), "owner is null or nil");
			Trace.Assert(!string.IsNullOrEmpty(name), "name is null or empty");

			m_owner = owner;
			m_name = name;
		}
		
		public T Value
		{
			get {NSObject o = m_owner[m_name]; return NSObject.IsNullOrNil(o) ? null : (T) o;}
			set {m_owner[m_name] = value;}
		}
		
		public override bool Equals(object rhsObj)
		{
			if (rhsObj == null)          
				return false;
			
			IBOutlet<T> rhs = rhsObj as IBOutlet<T>;
			return this == rhs;
		}
			
		public bool Equals(IBOutlet<T> rhs)  
		{
			return this == rhs;
		}
	
		public static bool operator==(IBOutlet<T> lhs, IBOutlet<T> rhs)
		{
			if (object.ReferenceEquals(lhs, rhs))
				return true;
			
			if ((object) lhs == null || (object) rhs == null)
				return false;
			
			return lhs.m_owner.Equals(rhs.m_owner) && lhs.m_name == rhs.m_name;
		}
		
		public static bool operator!=(IBOutlet<T> lhs, IBOutlet<T> rhs)
		{
			return !(lhs == rhs);
		}
		
		public override int GetHashCode()
		{
			int hash = 47;
			
			unchecked
			{
				hash += 23*m_owner.GetHashCode();
				hash += 23*m_name.GetHashCode();
			}
			
			return hash;
		}
    
		private NSObject m_owner;
		private string m_name;
	}
}
