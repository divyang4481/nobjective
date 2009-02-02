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
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Permissions;

namespace MObjc
{
	// This will be thrown if the unmanaged code throws an exception.
	[Serializable]
	[DisableRuleAttribute("R1000", "DisposableFields")]
	public sealed class CocoaException : Exception
	{
		// This should not normally be used but is present so the class
		// works with XML serialization.
		public CocoaException()
		{
			m_instance = new NSObject(IntPtr.Zero);
		}

		public CocoaException(NSObject instance, Exception innerException) : base(DoGetMessage(instance), innerException)
		{
			m_instance = instance;
		}
		
		private CocoaException(NSObject instance) : base(DoGetMessage(instance))
		{
			m_instance = instance;
		}
		
		private CocoaException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			long value = info.GetInt64("NSObject");
			m_instance = new NSObject(new IntPtr(value));
		}

		[SecurityPermission(SecurityAction.LinkDemand, SerializationFormatter = true)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
				throw new ArgumentException("info is null");
				
			base.GetObjectData(info, context);
			
			info.AddValue("NSObject", ((IntPtr) m_instance).ToInt64());
		}

		public static void Raise(IntPtr p)
		{
			NSObject instance = new NSObject(p);
			
			if (instance.isMemberOfClass(new Class("NSException")))
			{
				// See if the userInfo contains a .NET exception.
				NSObject userInfo = (NSObject) instance.Call("userInfo");

				if (userInfo != null && (IntPtr) userInfo != IntPtr.Zero)
				{
					IntPtr keyBuffer = Marshal.StringToHGlobalAuto(".NET exception");
					NSObject key = (NSObject) new Class("NSString").Call("alloc").Call("initWithUTF8String:", keyBuffer);					
					Marshal.FreeHGlobal(keyBuffer);

					NSObject data = (NSObject) userInfo.Call("objectForKey:", key);
					if (data != null && !data.IsNil())
					{
						// If it does then get the serialized exception bytes,
						IntPtr ptr = (IntPtr) data.Call("bytes");
						uint bytes = (uint) data.Call("length");
						
						// copy them into a managed buffer,
						byte[] buffer = new byte[bytes];
						Marshal.Copy(ptr, buffer, 0, (int) bytes);
	
						// and raise the original exception.
						using (MemoryStream stream = new MemoryStream(buffer))
						{
							BinaryFormatter formatter = new BinaryFormatter();
							Exception e = (Exception) formatter.Deserialize(stream);
	
							throw new TargetInvocationException("Exception has been thrown by the target of an Objective-C method call.", e);	// yes TargetInvocationException sucks, but it preserves the original stack crawl...
						}
					}
				}
			}
			
			throw new CocoaException(instance);
		}
		
		// Will usually be a NSException.
		public NSObject NSObject
		{
			get {return m_instance;}
		}
		
		private static string DoGetMessage(NSObject instance)
		{
			string text;
			
			if (instance.isMemberOfClass(new Class("NSException")))
			{
				text = Marshal.PtrToStringAuto((IntPtr) instance.Call("name").Call("UTF8String"));
				text += ". ";
				text += Marshal.PtrToStringAuto((IntPtr) instance.Call("reason").Call("UTF8String"));
			}
			else
				text = Marshal.PtrToStringAuto((IntPtr) instance.Call("description").Call("UTF8String"));
				
			return text;
		}
				
		private NSObject m_instance;
	}
}
