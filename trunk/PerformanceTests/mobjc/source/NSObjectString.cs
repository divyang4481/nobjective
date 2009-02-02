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
using System.Runtime.InteropServices;
using System.Text;

namespace MObjc
{
	// There's a lot of this string goo so we'll tuck it away into its own file.
	public partial class NSObject : IFormattable
	{ 
		public override string ToString()
		{
			return ToString("G", null);
		}
		
		// {0} or {0:G} returns something like "MyView : NSView (imp = 0xA08E7468)".
		// {0:D} returns the result of calling the description method.
		// {0:I} returns the instance methods. 
		// {0:C} returns the class methods. 
		// {0:V} returns the instance variables.	
		// {0:P} returns the properties.	
		// A "P" can be appended to the C, I, and V formats to force private members (those
		// starting with an underscore) to be included.
		public string ToString(string format, IFormatProvider provider)
		{				
			if (provider != null)
			{
				ICustomFormatter formatter = provider.GetFormat(GetType()) as ICustomFormatter;
				if (formatter != null)
					return formatter.Format(format, this, provider);
			}
						
			StringBuilder builder = new StringBuilder(20);
			if (m_instance != IntPtr.Zero)		
			{
				switch (format)
				{    
					case "":            
					case null:
					case "G":
						DoGetDefaultString(builder);
						break;
																										
					case "I":
						DoGetInstanceMethodsString(builder, false);
						break;
													
					case "IP":
						DoGetInstanceMethodsString(builder, true);
						break;
													
					case "C":
						DoGetClassMethodsString(builder, false);
						break;
													
					case "CP":
						DoGetClassMethodsString(builder, true);
						break;
													
					case "D":
						DoGetDescString(builder);
						break;
													
					case "V":
						DoGetIvarString(builder, false);
						break;
													
					case "VP":
						DoGetIvarString(builder, true);
						break;
													
					case "P":
						DoGetPropsString(builder);
						break;
													
					default:
						throw new ArgumentException(format + " isn't a valid NSObject format string");
				}
			}
			else
				builder.AppendFormat("{0} [nil]", GetType());
				
			return builder.ToString();
		}
		
		#region Private Methods
		private void DoGetDefaultString(StringBuilder builder)
		{
			if (m_instance == m_class)
				builder.Append("class ");
			else
				builder.Append("instance ");

			IntPtr ptr = class_getName(m_class);
			builder.Append(Marshal.PtrToStringAnsi(ptr));
			
			if (m_baseClass != IntPtr.Zero)
			{
				ptr = class_getName(m_baseClass);
				builder.Append(" : ");
				builder.Append(Marshal.PtrToStringAnsi(ptr));
			}
			
			builder.Append(" (id = ");
			builder.Append(m_instance.ToInt32().ToString("X", null));
			builder.Append(")");

			if (m_deallocated)
				builder.Append(" [deallocated]");
		}
				
		private void DoGetClassMethodsString(StringBuilder builder, bool includePrivate)
		{
			Class klass = new Class(object_getClass(m_class));

			bool needNewLine = false;
			while (klass != null && (IntPtr) klass != IntPtr.Zero)
			{
				List<List<string>> table = new List<List<string>>();
				DoAddMethods(klass, table, includePrivate);
	
				if (table.Count > 0)
				{
					if (needNewLine)
					{
						builder.AppendLine();				
						needNewLine = false;
					}
					
					table.Sort((lhs, rhs) => lhs[0].CompareTo(rhs[0]));
					DoAlign(table);
		
					builder.Append(klass.Name);				
					builder.AppendLine(" class methods:");				
					for (int i = 0; i < table.Count; ++i)
					{
						foreach (string entry in table[i])
						{
							builder.Append(entry);				
							builder.Append(" ");				
						}
		
						builder.AppendLine();				
					}
					
					needNewLine = true;
				}
				
				if (klass.Name == "NSObject")
					break;

				klass = klass.BaseClass;
			}
		}
		
		private void DoGetIvarString(StringBuilder builder, bool includePrivate)
		{
			Class klass = class_();
			while (klass != null && (IntPtr) klass != IntPtr.Zero)
			{
				int count = 0;
				IntPtr buffer = class_copyIvarList((IntPtr) klass, ref count);
				
				if (count > 0)
				{
					PtrArray ivars = new PtrArray(buffer, count);
			
					for (int i = 0; i < count; ++i)	
					{
						IntPtr name = ivar_getName(ivars[i]);
						string s = Marshal.PtrToStringAnsi(name);
						if (includePrivate || (s.Length > 0 && s[0] != '_'))
							builder.AppendLine(s);
					}
				}
	
				Marshal.FreeHGlobal(buffer);

				klass = klass.BaseClass;
			}
		}
		
		private void DoGetPropsString(StringBuilder builder)
		{
			Class klass = class_();
			while (klass != null && (IntPtr) klass != IntPtr.Zero)
			{
				int count = 0;
				IntPtr buffer = class_copyPropertyList((IntPtr) klass, ref count);
				
				if (count > 0)
				{
					PtrArray ivars = new PtrArray(buffer, count);
			
					for (int i = 0; i < count; ++i)	
					{
						IntPtr name = property_getName(ivars[i]);	// property_getAttributes?
						string s = Marshal.PtrToStringAnsi(name);
						builder.AppendLine(s);
					}
				}
	
				Marshal.FreeHGlobal(buffer);

				klass = klass.BaseClass;
			}
		}
		
		private void DoGetInstanceMethodsString(StringBuilder builder, bool includePrivate)
		{
			Class klass = class_();
			bool needNewLine = false;
			while (klass != null && (IntPtr) klass != IntPtr.Zero)
			{
				List<List<string>> table = new List<List<string>>();
				DoAddMethods(klass, table, includePrivate);
	
				if (table.Count > 0)
				{
					if (needNewLine)
					{
						builder.AppendLine();				
						needNewLine = false;
					}
					
					table.Sort((lhs, rhs) => lhs[0].CompareTo(rhs[0]));
					DoAlign(table);
		
					builder.Append(klass.Name);				
					builder.AppendLine(" instance methods:");				
					for (int i = 0; i < table.Count; ++i)
					{
						foreach (string entry in table[i])
						{
							builder.Append(entry);				
							builder.Append(" ");				
						}
		
						builder.AppendLine();				
					}
					
					needNewLine = true;
				}

				klass = klass.BaseClass;
			}
		}
		
		private void DoAddMethods(Class klass, List<List<string>> table, bool includePrivate)
		{
			int count = 0;
			IntPtr buffer = class_copyMethodList((IntPtr) klass, ref count);
			
			if (count > 0)
			{
				PtrArray methods = new PtrArray(buffer, count);
		
				for (int i = 0; i < count; ++i)	
				{
					Selector sel = new Selector(method_getName(methods[i]));
					if (includePrivate || (sel.Name.Length > 0 && sel.Name[0] != '_'))
					{
						List<string> row = new List<string>();					
						row.Add(sel.Name);
	
						IntPtr imp = method_getImplementation(methods[i]);
						row.Add(imp.ToInt32().ToString("X"));
		
						table.Add(row);
					}
				}
			}

			Marshal.FreeHGlobal(buffer);
		}
		
		private void DoGetDescString(StringBuilder builder)
		{
			string s = description();
			builder.Append(s);
		}
		
		private void DoAlign(List<List<string>> table)
		{
			List<int> widths = new List<int>(table[0].Count);
			for (int j = 0; j < table[0].Count; ++j)
				widths.Add(table[0][j].Length + 1);

			for (int i = 1; i < table.Count; ++i)
			{
				for (int j = 0; j < table[i].Count; ++j)
				{
					widths[j] = Math.Max(table[i][j].Length + 1, widths[j]);
				}
			}

			for (int i = 0; i < table.Count; ++i)
			{
				for (int j = 0; j < table[i].Count; ++j)
				{
					table[i][j] = table[i][j].PadRight(widths[j]);
				}
			}
		}
		#endregion
				
		#region P/Invokes
		[DllImport("/usr/lib/libobjc.dylib")]
		private extern static IntPtr class_copyPropertyList(IntPtr klass, ref int count);

		[DllImport("/usr/lib/libobjc.dylib")]
		private extern static IntPtr property_getName(IntPtr prop);

//		[DllImport("/usr/lib/libobjc.dylib")]
//		private extern static IntPtr property_getAttributes(IntPtr prop);

		[DllImport("/usr/lib/libobjc.dylib")]
		private extern static IntPtr ivar_getName(IntPtr iv);

		[DllImport("/usr/lib/libobjc.dylib")]
		private extern static IntPtr class_copyIvarList(IntPtr obj, ref int count);

		[DllImport("/usr/lib/libobjc.dylib")]
		private extern static IntPtr method_getImplementation(IntPtr method);

		[DllImport("/usr/lib/libobjc.dylib")]
		private extern static IntPtr method_getName(IntPtr method);

		[DllImport("/usr/lib/libobjc.dylib")]
		private extern static IntPtr class_copyMethodList(IntPtr klass, ref int count);
		#endregion
	}
}
