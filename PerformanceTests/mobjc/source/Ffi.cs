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

// See <http://developer.apple.com/documentation/Cocoa/Conceptual/ObjectiveC/Articles/chapter_13_section_9.html#//apple_ref/doc/uid/TP30001163-CH9-TPXREF165>.
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace MObjc
{	
	[DisableRuleAttribute("C1026", "NoStaticRemove")]
	internal static class Ffi 	
	{					
		// Return an ffi_type* which will be used when values of the encoding
		// type are marshaled through libffi.
		public static IntPtr GetFfiType(string encoding)
		{			
			return DoGetFfiType(encoding);
		}

		// Return an ffi_type* which will be used when values of the encoding
		// type are marshaled through libffi.
		public static IntPtr GetFfiType(Type type)
		{
			string encoding = TypeEncoder.Encode(type);
			return DoGetFfiType(encoding);
		}
		
		// Use ffi_type*'s to create an ffi_cif*. Note that libffi will save the atypes
		// pointer so we can't free it (and we can't use an IntPtr[] without explicity
		// saving the array).
		public static IntPtr AllocCif(IntPtr rtype, PtrArray atypes)
		{						
			if (atypes[atypes.Length - 1] != IntPtr.Zero)
				throw new ArgumentException("atypes should be null terminated");
				
			IntPtr cif = AllocCif(atypes.Length - 1, rtype, (IntPtr) atypes);
			
			if (cif.ToInt32() == 1)
				throw new ArgumentException("FFI_BAD_TYPEDEF");
			else if (cif.ToInt32() == 2)
				throw new ArgumentException("FFI_BAD_ABI");
							
			return cif;
		}
		
		[DllImport("mobjc-glue.dylib")]
		internal extern static void FreeCif(IntPtr cif);
		
		// Create a buffer large enough to hold a value of the specified type
		// as marshaled through libffi. Free these with Marshal.FreeHGlobal.
		public static IntPtr CreateBuffer(string encoding)
		{
			IntPtr buffer = DoCreateBuffer(encoding);
			
			return buffer;
		}
		
		// Copy value into the buffer according to the specified encoding.
		public static void FillBuffer(IntPtr buffer, object value, string encoding)
		{
			DoFillBuffer(buffer, value, encoding);
		}
	
		// Call imp where args points to buffers containing the arguments and result
		// is a buffer where the result will be written. 
		public static void Call(IntPtr cif, IntPtr imp, IntPtr result, PtrArray args)
		{
			IntPtr exception = IntPtr.Zero;

			FfiCall(cif, imp, result, (IntPtr) args, ref exception);

			if (exception != IntPtr.Zero)
				CocoaException.Raise(exception);				
		}
	
		// Reads and returns the value stored in buffer according to encoding.
		public static object DrainBuffer(IntPtr buffer, string encoding)
		{
			object r = DoDrainArgBuffer(buffer, encoding);

			return r;
		}
		
		// Reads and returns the value stored in a return buffer according to encoding.
		// Unlike argument buffers these are a minimum of 4 bytes and the value is at
		// the end.
		public static object DrainReturnBuffer(IntPtr buffer, string encoding)
		{
			object r = DoDrainReturnBuffer(buffer, encoding);

			return r;
		}
		
		#region Private Methods -----------------------------------------------
		[DisableRuleAttribute("P1003", "AvoidBoxing")]
		private static object DoDrainBuffer(IntPtr buffer, string encoding)
		{
			object result;
						
			switch (encoding)
			{
				case "i":
					result = Marshal.ReadInt32(buffer);
					break;
					
				case "l":
					result = Marshal.ReadInt32(buffer);
					break;
					
				case "q":
					result = Marshal.ReadInt64(buffer);
					break;
					
				case "I":
					result = unchecked((UInt32) Marshal.ReadInt32(buffer));
					break;
					
				case "L":
					result = unchecked((UInt32) Marshal.ReadInt32(buffer));
					break;
					
				case "Q":
					result = unchecked((UInt64) Marshal.ReadInt64(buffer));
					break;
					
				case "f":
					result = Marshal.PtrToStructure(buffer, typeof(float));
					break;
					
				case "d":
					result = Marshal.PtrToStructure(buffer, typeof(double));
					break;
					
				case "v":
				case "Vv":
					result = null;
					break;
										
				case "@":
					IntPtr ip = Marshal.ReadIntPtr(buffer);
					result = NSObject.Lookup(ip);
					break;

				case "#":
					result = new Class(Marshal.ReadIntPtr(buffer));
					break;

				case ":":
					result = new Selector(Marshal.ReadIntPtr(buffer));
					break;

				default:
					result = DoDrainPtrBuffer(buffer, encoding);

					if (result == null)
						result = DoDrainStructBuffer(buffer, encoding);
	
					if (result == null)
						throw new ArgumentException("Don't know how to read buffer of: " + encoding);
					break;
			}
						
			return result;
		}
		
		// Values always appear at the start of the buffer.
		[DisableRuleAttribute("P1003", "AvoidBoxing")]
		private static object DoDrainArgBuffer(IntPtr buffer, string encoding)
		{
			object result;
						
			switch (encoding)
			{
				case "c":
					byte b = Marshal.ReadByte(buffer);
					result = b == 0 ? false : true;
					break;
										
				case "s":
					result = Marshal.ReadInt16(buffer);
					break;
										
				case "C":
					result = Marshal.ReadByte(buffer);
					break;
										
				case "S":
					result = unchecked((UInt16) Marshal.ReadInt16(buffer));
					break;
										
				default:
					result = DoDrainBuffer(buffer, encoding);
					break;
			}
						
			return result;
		}
		
		// Small values appear at the end of the 4-byte buffer.
		[DisableRuleAttribute("P1003", "AvoidBoxing")]
		private static object DoDrainReturnBuffer(IntPtr buffer, string encoding)
		{
			object result;
						
			switch (encoding)
			{
				case "c":
					result = unchecked((sbyte) Marshal.ReadInt32(buffer));
					break;
										
				case "s":
					result = unchecked((Int16) Marshal.ReadInt32(buffer));
					break;
										
				case "C":
					result = unchecked((byte) Marshal.ReadInt32(buffer));
					break;
										
				case "S":
					result = unchecked((UInt16) Marshal.ReadInt32(buffer));
					break;
										
				default:
					result = DoDrainBuffer(buffer, encoding);
					break;
			}
						
			return result;
		}
		
		private static char DoGetEncodingType(string encoding)
		{
			char type = encoding[0];

			int i = 0;
			while (i < encoding.Length && "rnNoORV".IndexOf(type) >= 0)
				type = encoding[++i];
				
			return type;
		}

		private static object DoDrainPtrBuffer(IntPtr buffer, string encoding)
		{
			object result = null;
			
			char type = DoGetEncodingType(encoding);			
			if (type == '^' || type == '*' || type == '[' || type == '(')	// xxx*, char*, array, union
			{
				result = Marshal.ReadIntPtr(buffer);
			}
			
			return result;
		}
		
		private static object DoDrainStructBuffer(IntPtr buffer, string encoding)
		{
			object result = null;
			
			char type = DoGetEncodingType(encoding);			
			if (type == '{')
			{
				int i = encoding.IndexOf('=');
				if (i >= 0)
				{
					string sname = encoding.Substring(1, i - 1);	
					Type stype;
					if (TypeEncoder.TryGetStruct(sname, out stype))
						result = Marshal.PtrToStructure(buffer, stype);
					else
						throw new InvalidCallException("Don't know how to marshal " + sname + " from a native buffer. Is it marked with RegisterAttribute?");
				}
			}
			
			return result;
		}
		
		[DisableRuleAttribute("D1002", "MethodTooComplex")]
		private static void DoFillBuffer(IntPtr buffer, object value, string encoding)
		{
			Type type = value != null ? value.GetType() : null;
			switch (encoding)	
			{
				case "c":
					if (type == typeof(bool))				
						Marshal.WriteByte(buffer, ((bool) value) ? (byte) 1 : (byte) 0);
					else if (type == typeof(sbyte))				
						Marshal.WriteByte(buffer, unchecked((byte) (sbyte) value));
					else
						throw new InvalidCallException(string.Format("Expected a Boolean or SByte but got a {0}.", type));
					break;
					
				case "C":
					if (type == typeof(byte))
						Marshal.WriteByte(buffer, (byte) value);
					else
						throw new InvalidCallException(string.Format("Expected a Byte but got a {0}.", type));
					break;
					
				case "s":
					if (type == typeof(Int16))				
						Marshal.WriteInt16(buffer, (Int16) value);
					else
						throw new InvalidCallException(string.Format("Expected an Int16 but got a {0}.", type));
					break;
					
				case "S":
					if (type == typeof(UInt16))
						Marshal.WriteInt16(buffer, unchecked((Int16) (UInt16) value));
					else if (type == typeof(Char))
						Marshal.WriteInt16(buffer, unchecked((Int16) (Char) value));
					else
						throw new InvalidCallException(string.Format("Expected a UInt16 or Char but got a {0}.", type));
					break;
					
				case "i":
				case "l":
					if (type == typeof(Int32))				
						Marshal.WriteInt32(buffer, (Int32) value);
					else
						throw new InvalidCallException(string.Format("Expected an Int32 but got a {0}.", type));
					break;
					
				case "I":
				case "L":
					if (type == typeof(UInt32))
						Marshal.WriteInt32(buffer, unchecked((Int32) (UInt32) value));
					else
						throw new InvalidCallException(string.Format("Expected a UInt32 but got a {0}.", type));
					break;
										
				case "q":
					if (type == typeof(Int64))
						Marshal.WriteInt64(buffer, (Int64) value);
					else
						throw new InvalidCallException(string.Format("Expected an Int64 but got a {0}.", type));
					break;
					
				case "Q":
					if (type == typeof(UInt64))				
						Marshal.WriteInt64(buffer, unchecked((Int64) (UInt64) value));
					else
						throw new InvalidCallException(string.Format("Expected a UInt64 but got a {0}.", type));
					break;
										
				case "f":
					float f = 0.0f;
					if (type == typeof(float))
						f = (float) value;
					else
						throw new InvalidCallException(string.Format("Expected a float but got a {0}.", type));

					Marshal.StructureToPtr(f, buffer, false);
					break;
					
				case "d":
					double d = 0.0;
					if (type == typeof(float))
						d = (double) (float) value;
					else if (type == typeof(double))
						d = (double) value;
					else
						throw new InvalidCallException(string.Format("Expected a float or double but got a {0}.", type));

					Marshal.StructureToPtr(d, buffer, false);
					break;
										
				case "@":
					if (value == null)
					{
						Marshal.WriteIntPtr(buffer, IntPtr.Zero);
					}
					else
					{
						NSObject i = value as NSObject;
						if (i != null)
							Marshal.WriteIntPtr(buffer, (IntPtr) i);
						else
							if (value.GetType() == typeof(IntPtr))
								Marshal.WriteIntPtr(buffer, (IntPtr) value);
							else
								throw new InvalidCallException(string.Format("Expected an NSObject or IntPtr but got a {0}.", type));
					}
					break;
					
				case "#":
					Class k = value as Class;
					if (k != null)
						Marshal.WriteIntPtr(buffer, (IntPtr) k);
					else if (value == null)
						Marshal.WriteIntPtr(buffer, IntPtr.Zero);
					else if (value.GetType() == typeof(IntPtr))
						Marshal.WriteIntPtr(buffer, (IntPtr) value);
					else
						throw new InvalidCallException(string.Format("Expected a Class but got a {0}.", type));
					break;
					
				case ":":
					Selector sel = value as Selector;
					if (sel != null)
						Marshal.WriteIntPtr(buffer, (IntPtr) sel);
					else if (value == null)
						Marshal.WriteIntPtr(buffer, IntPtr.Zero);
					else if (value.GetType() == typeof(IntPtr))
						Marshal.WriteIntPtr(buffer, (IntPtr) value);
					else
						throw new InvalidCallException(string.Format("Expected a Selector but got a {0}.", type));
					break;
			
				default:
					if (!DoFillPtrBuffer(encoding, value, buffer) && !DoFillStructBuffer(encoding, value, buffer))
						throw new InvalidCallException("Don't know how to marshal " + encoding + " to a native type.");
					break;
			}
		}

		private static bool DoFillPtrBuffer(string encoding, object value, IntPtr buffer)
		{
			bool done = false;
			
			char type = DoGetEncodingType(encoding);			
			if (type == '^' || type == '*' || type == '[' || type == '(')	// xxx*, char*, array, union
 			{
 				if (value == null)
 				{
 					Marshal.WriteIntPtr(buffer, IntPtr.Zero);
					done = true;
 				}
 				else if (value.GetType() == typeof(IntPtr))
 				{
 					Marshal.WriteIntPtr(buffer, (IntPtr) value);
					done = true;
 				}
 				else
					// For r^S use Marshal.StringToHGlobalUni(str) or GCHandle.Alloc(value, GCHandleType.Pinned).
					// For r* use Marshal.StringToHGlobalAuto(str).
					// For the others you can usually use GCHandle.Alloc(value, GCHandleType.Pinned).
 					throw new InvalidCallException("Don't know how to marshal " + value.GetType() + " to " + encoding + ".");
 			}
			
			return done;
		}

		private static bool DoFillStructBuffer(string encoding, object value, IntPtr buffer)
		{
			bool done = false;
			
			char type = DoGetEncodingType(encoding);			
			if (type == '{')
			{
				if (value == null)
					throw new InvalidCallException("Can't marshal null to a struct type.");
				
				int i = encoding.IndexOf('=');
				if (i >= 0)
				{
					string sname = encoding.Substring(1, i - 1);	
					Type stype;
					if (TypeEncoder.TryGetStruct(sname, out stype))
					{
						if (value.GetType() == stype)
						{
							Marshal.StructureToPtr(value, buffer, false);
							done = true;
						}
						else
							throw new InvalidCallException("Can't marshal " + value.GetType() + " to " + stype + ".");
					}
					else
						throw new InvalidCallException("Don't know how to marshal " + sname + " from a native buffer. Is it marked with RegisterAttribute?");
				}
			}
			
			return done;
		}

		private static IntPtr DoGetFfiType(string encoding)
		{
			char code = DoGetCode(encoding);

			if (code == '\x0')
			{
				char t = DoGetEncodingType(encoding);			
				if (t == '{')
					return DoGetStructFfiType(encoding);
				else
					throw new ArgumentException("Don't know how to get ffi type for: " + encoding);
			}
			
			IntPtr type = GetFfiType(code);
			if (type == IntPtr.Zero)
				throw new ArgumentException("Couldn't find an ffi type for: " + encoding);	// this shouldn't happen
			
			return type;
		}

		private static IntPtr DoGetStructFfiType(string encoding)
		{
			IntPtr result;
                                            
			int i = encoding.IndexOf('=');	
			if (i >= 0)
			{
				string sname = encoding.Substring(1, i - 1);
				string pencoding = encoding.Substring(i + 1, encoding.Length - i - 2);
				
				lock (ms_lock)
				{
					if (!ms_structs.TryGetValue(sname, out result))
					{
						result = DoAllocStructFfiType(sname, pencoding);
						ms_structs.Add(sname, result);
					}
				}
			}
			else
				throw new InvalidCallException("'" + encoding + "' doesn't have a struct name.");
			
			return result;
		}

		private static IntPtr DoAllocStructFfiType(string sname, string pencoding)
		{			
			List<IntPtr> fieldTypes = new List<IntPtr>();
	
			int index = 0;
			while (index < pencoding.Length)
			{										
				if (pencoding[index] == '{')		
				{
					int i = pencoding.IndexOf('=', index);	
					int j = pencoding.IndexOf('}', index);	
					string sname2 = pencoding.Substring(index + 1, i - index - 1);
					string pencoding2 = pencoding.Substring(i + 1, j - i - 1);
					fieldTypes.Add(DoAllocStructFfiType(sname2, pencoding2));

					index = j + 1;
				}
				else
				{
					char code = DoGetCode(pencoding[index++].ToString());
					if (code == '\x0')
						throw new InvalidCallException("Can only marshal structs whose fields are primitive types or structs with primitive types and " + sname + " isn't.");
			
					fieldTypes.Add(GetFfiType(code));
				}
			}
			
			fieldTypes.Add(IntPtr.Zero);
						
			// Note that we don't free these, but that should be OK since
			// there should only be a limited number of structs we marshal
			// and it doesn't hurt to cache the ffi_type* anyway.
			PtrArray ft = new PtrArray(fieldTypes.Count);
			for (int i = 0; i < ft.Length; ++i)
				ft[i] = fieldTypes[i];
				
			IntPtr result = AllocStructFfiType((IntPtr) ft);

			return result;
		}

		private static char DoGetCode(string encoding)
		{
			char code = '\x0';
			
			switch (encoding)
			{
				case "c":			
				case "C":			
				case "d":			
				case "f":			
				case "i":			
				case "I":			
				case "l":			
				case "L":			
				case "q":			
				case "Q":			
				case "s":
				case "S":
				case "v":
					code = encoding[0];
					break;
														
				case "@":
				case "#":
				case ":":
					code = 'p';
					break;
															
				case "Vv":
					code = 'v';
					break;
													
				default:
					char type = DoGetEncodingType(encoding);			
					if (type == '^' || type == '*' || type == '[' || type == '(')	// xxx*, char*, array, union
						code = 'p';
					break;
			}
			
			return code;
		}

		[DisableRule("D1002", "MethodTooComplex")]
		private static IntPtr DoCreateBuffer(string encoding)
		{
			IntPtr buffer;

			switch (encoding)	
			{
				case "c":
				case "C":
					buffer = Marshal.AllocHGlobal(4);	// note that libffi expects buffers to be at least as big as a word
					break;
										
				case "s":
				case "S":
					buffer = Marshal.AllocHGlobal(4);
					break;
										
				case "i":
				case "I":
				case "l":
				case "L":
					buffer = Marshal.AllocHGlobal(4);
					break;
															
				case "q":
				case "Q":
					buffer = Marshal.AllocHGlobal(8);
					break;
															
				case "f":
					buffer = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(float)));
					break;
					
				case "d":
					buffer = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(double)));
					break;
					
				case "v":
				case "Vv":
					buffer = IntPtr.Zero;
					break;
					
				case "@":
				case "#":
				case ":":
					buffer = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IntPtr)));
					break;
					
				default:
					char type = DoGetEncodingType(encoding);			
					if (type == '^' || type == '*' || type == '[' || type == '(')	// xxx*, char*, array, union
					{
						buffer = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IntPtr)));
					}
					else if (type == '{')
					{
						int i = encoding.IndexOf('=');
						if (i >= 0)
						{
							string sname = encoding.Substring(1, i - 1);	
							Type stype;
							if (TypeEncoder.TryGetStruct(sname, out stype))
							{
								int bytes = Marshal.SizeOf(stype);
								buffer = Marshal.AllocHGlobal(bytes);
							}
							else
								throw new InvalidCallException("Don't know how to marshal " + sname + " to a native type. Is it marked with RegisterAttribute?");
						}
						else
							throw new InvalidCallException("'" + encoding + "' doesn't have a struct name.");
					}
					else
						throw new InvalidCallException("Don't know how to marshal " + encoding + " to a native type.");
					break;
			}
						
			return buffer;
		}
		#endregion	
		
		#region P/Invokes -----------------------------------------------------
		[DllImport("mobjc-glue.dylib")]
		internal extern static IntPtr GetFfiType([MarshalAs(UnmanagedType.U1)] char code);

		[DllImport("mobjc-glue.dylib")]
		internal extern static IntPtr AllocStructFfiType(IntPtr fieldTypes);

		[DllImport("mobjc-glue.dylib")]
		internal extern static IntPtr AllocCif(int numArgs, IntPtr rtype, IntPtr atypes);

		[DllImport("mobjc-glue.dylib")]
		internal extern static void FfiCall(IntPtr cif, IntPtr imp, IntPtr result, IntPtr args, ref IntPtr exception);

//		[DllImport("mobjc-glue.dylib")]
//		internal extern static void FreeStructType(IntPtr type);
		#endregion

		#region Fields --------------------------------------------------------
		private static Dictionary<string, IntPtr> ms_structs = new Dictionary<string, IntPtr>();
		private static object ms_lock = new object();
		#endregion
	}
}
