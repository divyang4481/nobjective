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
using System.Text;

namespace MObjc
{
	internal sealed class SignatureInfo
	{
		public SignatureInfo(IntPtr sig) 
		{
			Trace.Assert(sig != IntPtr.Zero, "sig is nil");
			
			// Get the return encoding.
			IntPtr exception = IntPtr.Zero;
			IntPtr buffer = DirectCalls.Callp(sig, methodReturnType, ref exception);
			if (exception != IntPtr.Zero)
				CocoaException.Raise(exception);

			m_return = Marshal.PtrToStringAnsi(buffer);
			
			// Get the number of arguments.
			int count = DirectCalls.Calli(sig, numberOfArguments, ref exception);
			if (exception != IntPtr.Zero)
				CocoaException.Raise(exception);
				
			// Get the encodings for each argument.
			m_args = new string[count];
			for (int i = 0; i < count; ++i)
			{
				buffer = DirectCalls.Callpi(sig, getArgumentTypeAtIndex, i, ref exception);
				if (exception != IntPtr.Zero)
					CocoaException.Raise(exception);
	
				m_args[i] = Marshal.PtrToStringAnsi(buffer);
			}
		}
				
		public string GetReturnEncoding()
		{
			return m_return;
		}
		
		public int GetNumArgs()
		{
			return m_args.Length;
		}
		
		public string GetArgEncoding(int index)	
		{			
			return m_args[index];
		}
		
		public override string ToString()
		{
			StringBuilder result = new StringBuilder();
			
			result.Append(m_return);
			
			foreach (string arg in m_args)
				result.Append(arg);
								
			return result.ToString();
		}
						
		private static readonly Selector getArgumentTypeAtIndex = new Selector("getArgumentTypeAtIndex:");
		private static readonly Selector methodReturnType = new Selector("methodReturnType");
		private static readonly Selector numberOfArguments = new Selector("numberOfArguments");

		private string m_return;
		private string[] m_args;
	}

	[DisableRule("C1026", "NoStaticRemove")] 
	internal sealed class MethodSignature : IEquatable<MethodSignature>
	{
		public MethodSignature(string encoding) 
		{		
			Trace.Assert(!string.IsNullOrEmpty(encoding), "encoding is null or empty");
			m_info = DoEncodingToSig(encoding);	
		}
				
		public MethodSignature(IntPtr target, IntPtr selector) 
		{
			Trace.Assert(target != IntPtr.Zero, "target is nil");
			Trace.Assert(selector != IntPtr.Zero, "selector is nil");
			
			m_info = DoClassSelectorToSig(target, selector);	
			if (m_info == null)
				m_info = DoInstanceSelectorToSig(target, selector);	
		}
				
		public string GetReturnEncoding()
		{
			return m_info.GetReturnEncoding();
		}
		
		// Will always be at least two.
		public int GetNumArgs()
		{
			return m_info.GetNumArgs();
		}
		
		public string GetArgEncoding(int index)	
		{					
			return m_info.GetArgEncoding(index);
		}
		
		public override string ToString()
		{
			return m_info.ToString();
		}
				
		public override bool Equals(object rhsObj)
		{
			if (rhsObj == null)         
				return false;
			
			MethodSignature rhs = rhsObj as MethodSignature;
			return this == rhs;
		}
			
		public bool Equals(MethodSignature rhs)   
		{
			return this == rhs;
		}
	
		public static bool operator==(MethodSignature lhs, MethodSignature rhs)
		{
			if (object.ReferenceEquals(lhs, rhs))
				return true;
			
			if ((object) lhs == null || (object) rhs == null)
				return false;
				
			if (lhs.GetReturnEncoding() != rhs.GetReturnEncoding())
				return false;
			
			if (lhs.GetNumArgs() != rhs.GetNumArgs())
				return false;
				
			for (int i = 0; i < lhs.GetNumArgs(); ++i)
				if (lhs.GetArgEncoding(i) != rhs.GetArgEncoding(i))
					return false;
			
			return true;
		}
		
		public static bool operator!=(MethodSignature lhs, MethodSignature rhs)
		{
			return !(lhs == rhs);
		}
		
		public override int GetHashCode()
		{
			int hash = 47;
			
			unchecked
			{
				hash += GetReturnEncoding().GetHashCode();
				for (int i = 0; i < GetNumArgs(); ++i)
					hash += GetArgEncoding(i).GetHashCode();
			}
			
			return hash;
		}
    
		private static SignatureInfo DoEncodingToSig(string encoding)
		{		
			SignatureInfo info;
			
			lock (ms_lock)
			{
				if (!ms_encodedTable.TryGetValue(encoding, out info))	
				{
					Class klass = new Class("NSMethodSignature");

					IntPtr exception = IntPtr.Zero;
					IntPtr instance = DirectCalls.Callpp(klass, signatureWithObjCTypes, Marshal.StringToHGlobalAnsi(encoding), ref exception);
					if (exception != IntPtr.Zero)
						CocoaException.Raise(exception);
					
					if (instance == IntPtr.Zero)
						throw new InvalidCallException(string.Format("Couldn't find the method signature for {0}", encoding));
				
					info = new SignatureInfo(instance);
					ms_encodedTable.Add(encoding, info);
					klass.release();
				}
			}
			
			return info;
		}
		
		// Note that if we don't do all of this caching the memory tests fail.
		private static SignatureInfo DoClassSelectorToSig(IntPtr target, IntPtr selector)
		{
			SignatureInfo info = null;
			
			IntPtr exception = IntPtr.Zero;
			IntPtr id = DirectCalls.Callp(target, klass, ref exception);
			if (exception != IntPtr.Zero)
				CocoaException.Raise(exception);
					
			lock (ms_lock)
			{
				KeyValuePair<IntPtr, IntPtr> key = new KeyValuePair<IntPtr, IntPtr>(id, selector);
				if (!ms_selectorTable.TryGetValue(key, out info))
				{
					// If target's class is itself then target is a class and we need to use
					// methodSignatureForSelector to get the class method. Otherwise we'll use
					// instanceMethodSignatureForSelector to see if the class has an instance
					// method. If that fails we'll fall back on DoInstanceSelectorToSig to see
					// if the instance has the method.
					IntPtr instance;
					if (id == target)
						instance = DirectCalls.Callpp(id, methodSignatureForSelector, selector, ref exception);
					else
						instance = DirectCalls.Callpp(id, instanceMethodSignatureForSelector, selector, ref exception);
					
					if (exception != IntPtr.Zero)
						CocoaException.Raise(exception);
						
					if (instance != IntPtr.Zero)
					{
						info = new SignatureInfo(instance);
						ms_selectorTable.Add(key, info);
					}
				}
			}
			
			return info;
		}

		private static SignatureInfo DoInstanceSelectorToSig(IntPtr target, IntPtr selector)
		{			
			IntPtr exception = IntPtr.Zero;
			IntPtr instance = DirectCalls.Callpp(target, methodSignatureForSelector, selector, ref exception);
			if (exception != IntPtr.Zero)
				CocoaException.Raise(exception);
				
			if (instance == IntPtr.Zero)
			{
				string cn = new NSObject(target).class_().Name;
				string sn = new Selector(selector).Name;
				throw new InvalidCallException(string.Format("Couldn't find the method signature for {0} {1}", cn, sn));
			}				
			
			return new SignatureInfo(instance);
		}
		
		private SignatureInfo m_info;
		private static Dictionary<string, SignatureInfo> ms_encodedTable = new Dictionary<string, SignatureInfo>();
		private static Dictionary<KeyValuePair<IntPtr, IntPtr>, SignatureInfo> ms_selectorTable = new Dictionary<KeyValuePair<IntPtr, IntPtr>, SignatureInfo>();
		private static object ms_lock = new object();

		private static readonly Selector klass = new Selector("class");
		private static readonly Selector instanceMethodSignatureForSelector = new Selector("instanceMethodSignatureForSelector:");
		private static readonly Selector signatureWithObjCTypes = new Selector("signatureWithObjCTypes:");
		private static readonly Selector methodSignatureForSelector = new Selector("methodSignatureForSelector:");
	}
}
