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

namespace MObjc
{	
	// http://developer.apple.com/documentation/Cocoa/Conceptual/ObjCRuntimeGuide/Articles/chapter_7_section_1.html
	[DisableRuleAttribute("C1026", "NoStaticRemove")]
	internal static class TypeEncoder
	{
		public static void Register(Type type, string name)
		{
			ms_structs.Add(name, type);		// this is the only ms_structs mutator and is only called by Registrar so we don't have to worry about synchronization
		}
		
		public static bool TryGetStruct(string name, out Type type)
		{
			Trace.Assert(!string.IsNullOrEmpty(name), "name is null or empty");
			
			return ms_structs.TryGetValue(name, out type);
		}
		
		public static string Encode(Type type)
		{
			Trace.Assert(type != null, "type is null");
			
			if (type == typeof(bool))
				return "c";
			
			else if (type == typeof(byte))
				return "C";
			
			else if (type == typeof(Int16))
				return "s";
			
			else if (type == typeof(UInt16) || type == typeof(char))
				return "S";
			
			else if (type == typeof(Int32))
				return "i";
			
			else if (type == typeof(UInt32))
				return "I";
			
			else if (type == typeof(Int64))
				return "q";
			
			else if (type == typeof(UInt64))
				return "Q";
			
			else if (type == typeof(float))
				return "f";
			
			else if (type == typeof(double))
				return "d";
			
			else if (type == typeof(string))
				throw new ArgumentException("Use NSString instead of string.");
			
			else if (type == typeof(void))
				return "v";
				
			else if (type == typeof(IntPtr))
				return "r^v";
				
			else if (type == typeof(Class))
				return "#";
				
			else if (type == typeof(Selector))
				return ":";
				
			else if (type == typeof(NSObject) || type.IsSubclassOf(typeof(NSObject)))
				return "@";
				
			else if (type.IsValueType)
				if (((ICollection<Type>)ms_structs.Values).Contains(type))
					return DoGetStructEncoding(type);
				else
					throw new ArgumentException("Don't know how to translate " + type + ". Has it been registered?");
				
			throw new ArgumentException("Don't know how to translate " + type);
		}
								
		#region Private Methods	-----------------------------------------------
		private static string DoGetStructEncoding(Type type)
		{
			string encoding = "{"; 
			
			RegisterAttribute attr = Attribute.GetCustomAttribute(type, typeof(RegisterAttribute)) as RegisterAttribute;
			encoding += attr.Name;
			encoding += "=";

			FieldInfo[] fields = type.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			foreach (FieldInfo info in fields)		
			{
				encoding += Encode(info.FieldType);
			}
			
			return encoding + "}";
		}
		#endregion
		
		#region Fields --------------------------------------------------------		
		private static Dictionary<string, Type> ms_structs = new Dictionary<string, Type>();
		#endregion
	}
}
