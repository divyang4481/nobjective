//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

//#define DUMP_EXPORTED_CLASSES_ASSEMBLY

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.IO;

namespace NObjective
{
	/// <summary>
	/// Provides relatively safe and flexible way to dynamically invoke objc methods. Contains all low-level operations like marshaling etc.
	/// Also provides ability to export .NET classes to objective-c runtime.
	/// See IA32 ABI at http://developer.apple.com/documentation/DeveloperTools/Conceptual/LowLevelABI/130-IA-32_Function_Calling_Conventions/IA32.html
	/// Also see PowerPC ABI at http://developer.apple.com/documentation/DeveloperTools/Conceptual/LowLevelABI/100-32-bit_PowerPC_Function_Calling_Conventions/32bitPowerPC.html
	/// </summary>
	[SuppressUnmanagedCodeSecurityAttribute]
	public static partial class Runtime
	{
		internal static readonly IRuntimeImplementation CompatibilityLayer;

		/// <summary>
		/// Objective-C runtime library.
		/// </summary>
		public const string RuntimeLibrary = "/usr/lib/libobjc.dylib";

		/// <summary>
		/// Library that handles setjmp/longjmp implementation of @try/@catch to prevent exception propagation from unmanaged code.
		/// </summary>
		public const string InteropLibrary = "NObjective.dylib";

		private static readonly AssemblyName _interopAssemblyName = new AssemblyName( "NObjective.Exported.dll" );
		private static readonly ModuleBuilder _interopModuleBuilder;

		internal static IntPtr TruncateUnnecessaryAddressBits( long value )
		{
			if( IntPtr.Size == 4 )
				return new IntPtr( ( int ) value );

			return new IntPtr( value );
		}

		/// <summary>
		/// Used to debug vararg calls and view some status messages.
		/// </summary>
		internal static readonly NObjective.Tracing.TraceSource Tracer = new NObjective.Tracing.TraceSource( "Objective-C runtime tracer" );

		static Runtime()
		{
#if TRACE
			AddListener( new Tracing.TextWriterTraceListener( "Runtime.log" ) );
#endif
			if( Version < MacOSVersion.Tiger )
				throw new InteropException( "{0} OS is not supported by underlying runtime", Version );

#if DUMP_EXPORTED_CLASSES_ASSEMBLY
			var interopAssemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly( _interopAssemblyName, AssemblyBuilderAccess.RunAndSave );
#else
			var interopAssemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly( _interopAssemblyName, AssemblyBuilderAccess.Run );
#endif

			_interopModuleBuilder = interopAssemblyBuilder.DefineDynamicModule( _interopAssemblyName.Name );

			if( Version == MacOSVersion.Tiger )
				CompatibilityLayer = new RuntimeV1Implementation();
			else
				CompatibilityLayer = new RuntimeV2Implementation();

			// create global autorelease pool
			SendMessage( NativeMethods.class_createInstance( NativeMethods.objc_getClass( "NSAutoreleasePool" ), 0 ), Selectors.init );

			try
			{
				StringProxy.Class = ExportStructure( typeof( StringProxy ) );
				ExceptionProxy.Class = ExportStructure( typeof( ExceptionProxy ) );

				ExportAllClasses();

#if DUMP_EXPORTED_CLASSES_ASSEMBLY
				interopAssemblyBuilder.Save( "NObjective.Exported.dll" );
#endif
			}
			catch( Exception excpt ) { Console.WriteLine( "Exception occured while automatic class exporting: {0}", excpt ); }
		}

		/// <summary>
		/// Adds <paramref name="listener"/> to RuntimeTraceSource
		/// </summary>
		/// <param name="listener">Listener to add</param>
		public static void AddListener( NObjective.Tracing.TraceListener listener )
		{
			Tracer.AddListener( listener );
		}

		/// <summary>
		/// Removes <paramref name="listener"/> from RuntimeTraceSource
		/// </summary>
		/// <param name="listener">Listener to remove</param>
		public static void RemoveListener( NObjective.Tracing.TraceListener listener )
		{
			Tracer.RemoveListener( listener );
		}

		/// <summary>
		/// Sends "retain" selector to <paramref name="@object"/>
		/// </summary>
		/// <param name="object">Message receiver.</param>
		public static void RetainNativeObject( IntPtr @object )
		{
			SendMessage( @object, Selectors.retain );
		}

		/// <summary>
		/// Sends "release" selector to <paramref name="@object"/>
		/// </summary>
		/// <param name="object">Message receiver</param>
		public static void ReleaseNativeObject( IntPtr @object )
		{
			SendMessage( @object, Selectors.release );
		}

		/// <summary>
		/// Sends "autorelease" selector to <paramref name="@object"/>
		/// </summary>
		/// <param name="object">Message receiver</param>
		/// <returns>[@object autorelease]</returns>
		public static IntPtr AutoreleaseNativeObject( IntPtr @object )
		{
			return SendMessage( @object, Selectors.autorelease );
		}

		private static readonly object[] _emptyParams = new object[] { };

		#region invocations for classes/instances
		internal static object Invoke( RuntimeObject receiver, Selector selector, params object[] arguments )
		{
			return InvokeFast( receiver, selector, null, arguments );
		}

		internal static object Invoke( RuntimeClass receiver, Selector selector, params object[] arguments )
		{
			return InvokeFast( receiver, selector, null, arguments );
		}

		internal static long InvokeRaw( RuntimeObject receiver, Selector selector, params object[] arguments )
		{
			return InvokeRawFast( receiver, selector, null, arguments );
		}

		internal static long InvokeRaw( RuntimeClass receiver, Selector selector, params object[] arguments )
		{
			return InvokeRawFast( receiver, selector, null, arguments );
		}

		internal static object InvokeFast( RuntimeObject receiver, Selector selector, RuntimeMethodEncoding encoding, params object[] arguments )
		{
			return DeserializeResult( SendObjectiveCMessage( MessageSendingOptions.SendToInstance, receiver, selector, ref encoding, IntPtr.Zero, 0, arguments ), encoding );
		}

		internal static object InvokeFast( RuntimeClass receiver, Selector selector, RuntimeMethodEncoding encoding, params object[] arguments )
		{
			return DeserializeResult( SendObjectiveCMessage( MessageSendingOptions.SendToClass, receiver, selector, ref encoding, IntPtr.Zero, 0, arguments ), encoding );
		}

		internal static long InvokeRawFast( RuntimeObject receiver, Selector selector, RuntimeMethodEncoding encoding, params object[] arguments )
		{
			return SendObjectiveCMessage( MessageSendingOptions.SendToInstance, receiver, selector, ref encoding, IntPtr.Zero, 0, arguments );
		}

		internal static long InvokeRawFast( RuntimeClass receiver, Selector selector, RuntimeMethodEncoding encoding, params object[] arguments )
		{
			return SendObjectiveCMessage( MessageSendingOptions.SendToClass, receiver, selector, ref encoding, IntPtr.Zero, 0, arguments );
		}

		internal static unsafe T InvokeStruct<T>( RuntimeObject receiver, Selector selector, params object[] arguments ) where T : struct
		{
			var resultSize = Marshal.SizeOf( typeof( T ) );
			var result = stackalloc byte[resultSize];
			var resultPtr = new IntPtr( &result[0] );

			InvokeStructFast( receiver, selector, null, resultPtr, resultSize, arguments );

			return ( T ) Marshal.PtrToStructure( resultPtr, typeof( T ) );
		}

		internal static unsafe T InvokeStruct<T>( RuntimeClass receiver, Selector selector, params object[] arguments ) where T : struct
		{
			var resultSize = Marshal.SizeOf( typeof( T ) );
			var result = stackalloc byte[resultSize];
			var resultPtr = new IntPtr( &result[0] );

			InvokeStructFast( receiver, selector, null, resultPtr, resultSize, arguments );

			return ( T ) Marshal.PtrToStructure( resultPtr, typeof( T ) );
		}

		internal static long InvokeStructFast( RuntimeObject receiver, Selector selector, RuntimeMethodEncoding encoding, IntPtr structAddress, int structSize, params object[] arguments )
		{
			return SendObjectiveCMessage( MessageSendingOptions.SendToInstance, receiver, selector, ref encoding, structAddress, structSize, arguments );
		}

		internal static long InvokeStructFast( RuntimeClass receiver, Selector selector, RuntimeMethodEncoding encoding, IntPtr structAddress, int structSize, params object[] arguments )
		{
			return SendObjectiveCMessage( MessageSendingOptions.SendToClass, receiver, selector, ref encoding, structAddress, structSize, arguments );
		}
		#endregion

		#region same staff for super calls
		internal static object SuperInvoke( RuntimeObject receiver, Selector selector, params object[] arguments )
		{
			return SuperInvokeFast( receiver, selector, null, arguments );
		}

		internal static object SuperInvoke( RuntimeClass receiver, Selector selector, params object[] arguments )
		{
			return SuperInvokeFast( receiver, selector, null, arguments );
		}

		internal static long SuperInvokeRaw( RuntimeObject receiver, Selector selector, params object[] arguments )
		{
			return SuperInvokeRawFast( receiver, selector, null, arguments );
		}

		internal static long SuperInvokeRaw( RuntimeClass receiver, Selector selector, params object[] arguments )
		{
			return SuperInvokeRawFast( receiver, selector, null, arguments );
		}

		internal static object SuperInvokeFast( RuntimeObject receiver, Selector selector, RuntimeMethodEncoding encoding, params object[] arguments )
		{
			return DeserializeResult( SendObjectiveCMessage( MessageSendingOptions.SendToInstance | MessageSendingOptions.SendToSuperclass, receiver, selector, ref encoding, IntPtr.Zero, 0, arguments ), encoding );
		}

		internal static object SuperInvokeFast( RuntimeClass receiver, Selector selector, RuntimeMethodEncoding encoding, params object[] arguments )
		{
			return DeserializeResult( SendObjectiveCMessage( MessageSendingOptions.SendToClass | MessageSendingOptions.SendToSuperclass, receiver, selector, ref encoding, IntPtr.Zero, 0, arguments ), encoding );
		}

		internal static long SuperInvokeRawFast( RuntimeObject receiver, Selector selector, RuntimeMethodEncoding encoding, params object[] arguments )
		{
			return SendObjectiveCMessage( MessageSendingOptions.SendToInstance | MessageSendingOptions.SendToSuperclass, receiver, selector, ref encoding, IntPtr.Zero, 0, arguments );
		}

		internal static long SuperInvokeRawFast( RuntimeClass receiver, Selector selector, RuntimeMethodEncoding encoding, params object[] arguments )
		{
			return SendObjectiveCMessage( MessageSendingOptions.SendToClass | MessageSendingOptions.SendToSuperclass, receiver, selector, ref encoding, IntPtr.Zero, 0, arguments );
		}

		internal static unsafe T SuperInvokeStruct<T>( RuntimeObject receiver, Selector selector, params object[] arguments ) where T : struct
		{
			var resultSize = Marshal.SizeOf( typeof( T ) );
			var result = stackalloc byte[resultSize];
			var resultPtr = new IntPtr( &result[0] );

			SuperInvokeStructFast( receiver, selector, null, resultPtr, resultSize, arguments );

			return ( T ) Marshal.PtrToStructure( resultPtr, typeof( T ) );
		}

		internal static long SuperInvokeStructFast( RuntimeObject receiver, Selector selector, RuntimeMethodEncoding encoding, IntPtr structAddress, int structSize, params object[] arguments )
		{
			return SendObjectiveCMessage( MessageSendingOptions.SendToInstance | MessageSendingOptions.SendToSuperclass, receiver, selector, ref encoding, structAddress, structSize, arguments );
		}
		#endregion

		[Flags]
		private enum MessageSendingOptions
		{
			SendToInstance = 0,
			SendToClass = 1,
			SendToSuperclass = 2
		}

		private unsafe static long SendObjectiveCMessage( MessageSendingOptions sendingOptions, IntPtr receiver, Selector selector, ref RuntimeMethodEncoding encoding, IntPtr structAddress, int structSize, params object[] arguments )
		{
			if( arguments == null )
				arguments = _emptyParams;

			// gmcs currenly still generate code for lambdas inside conditional call
#if TRACE
			Tracer.Information( "Perform selector {0} on {1} {2} ({3})", selector, ( sendingOptions & MessageSendingOptions.SendToClass ) == 0 ? "object" : "class", receiver == IntPtr.Zero ? "" : RuntimeClass.GetAllClasses().Select( x => ( sendingOptions & MessageSendingOptions.SendToClass ) == 0 ? x : x.MetaClass ).Where( x => x == new RuntimeObject( receiver ).Class ).FirstOrDefault().Name, receiver.ToString( "X8" ) );
#endif
			if( receiver == IntPtr.Zero )
				return 0;

			if( encoding == null )
			{
				var nativeMethod = new RuntimeMethod( new RuntimeObject( receiver ).Class, selector );

				if( nativeMethod == RuntimeMethod.Null )
				{
					// if method is fowarded then acquire it's encoding
					encoding = RuntimeMethodEncoding.FromNSMethodSignature( new RuntimeObject( TruncateUnnecessaryAddressBits( SendObjectiveCMessage( 0, receiver, Selectors.methodSignatureForSelector_, ref encoding, IntPtr.Zero, 0 ) ) ) );

					if( encoding == null )
						throw new InteropException( "Can't find signature for " + selector );
				}
				else
					encoding = CompatibilityLayer.method_getTypeEncoding( nativeMethod );
			}

			Tracer.IncreaseLevel();
			Tracer.Information( "Encoding = {0}, result = {1}", encoding.Encoding, encoding.Types[0] != null ? encoding.Types[0].Name : "?" );

			var totalArguments = arguments.Length;

			object[] expandLastArgument = null;
			if( arguments.Length > 0 )
				expandLastArgument = arguments[arguments.Length - 1] as object[];

			if( expandLastArgument != null )
			{
				var lastArgument = expandLastArgument;

				while( lastArgument != null && lastArgument.Length != 0 )
				{
					totalArguments += expandLastArgument.Length - 1;
					lastArgument = expandLastArgument[expandLastArgument.Length - 1] as object[];
				}
			}

			try
			{
				// wrapped objects
				var wrappedArguments = stackalloc IntPtr[totalArguments];
				var wrappedArgument = wrappedArguments;

				// pinned arrays
				var pinnedArguments = stackalloc GCHandle[totalArguments];
				var pinnedArgument = pinnedArguments;

				var nativeStack = new Runtime.ArgumentsStack();
				var stackStart = ( IntPtr* ) &nativeStack;
				var stackEnd = ( IntPtr* ) ( ( ( byte* ) &nativeStack ) + sizeof( Runtime.ArgumentsStack ) );
				var stackFiller = ( IntPtr* ) &nativeStack;

				int argumentBase = 0;

				// used for passing float parameters in fr1-fr13 registers on ppc
				double* ppcFloatingRegisters1_13 = stackalloc double[13];
				int frRegistersPassedParametersCount = 0;
				const int frRegistersPassedParametersMax = 13;

				for( int i = 0; i < arguments.Length; i++ )
				{
					if( stackFiller >= stackEnd - 1 )
						throw new InteropException( "Stack is too small to hold all arguments!" );

					var encodingArgumentIndex = argumentBase + i + 3;
					var encodingArgumentRealIndex = argumentBase + i;

					if( arguments[i] == null )
					{
						*stackFiller++ = IntPtr.Zero;
						Tracer.Information( "param {0} is null", encodingArgumentRealIndex, arguments[i] );
						continue;
					}

					var argumentType = arguments[i].GetType();

					if( argumentType == typeof( string ) )
					{
						if( encoding.Types.Length > encodingArgumentIndex && ( encoding.Types[encodingArgumentIndex] == typeof( byte* ) ) )
						{
							var @string = ( string ) arguments[i];
							var convertedBytes = new byte[@string.Length + 1];
							Encoding.Default.GetBytes( @string, 0, @string.Length, convertedBytes, 0 );

							*pinnedArgument = GCHandle.Alloc( convertedBytes, GCHandleType.Pinned );
							*stackFiller++ = pinnedArgument->AddrOfPinnedObject();
							Tracer.Information( "param {0} serialized as byte*, pinned at {1}", encodingArgumentRealIndex, pinnedArgument->AddrOfPinnedObject().ToString( "X8" ) );
							pinnedArgument++;
						}
						else
						{
							*wrappedArgument = CreateStringProxy( ( string ) arguments[i] );
							*stackFiller++ = *wrappedArgument++;
							Tracer.Information( "param {0} with value {1} serialized as NSString proxy", encodingArgumentRealIndex, arguments[i] );
						}
					}
					else if( argumentType.IsValueType )
					{
						// intel
						if( BitConverter.IsLittleEndian )
						{
							// vararg case
							if( encodingArgumentIndex >= encoding.Sizes.Length )
							{
								int actualSize = RuntimeMethodEncoding.GetTypeStackSize( argumentType ) / IntPtr.Size;

								if( stackFiller + actualSize > stackEnd )
									throw new InteropException( "Stack is too small to hold all arguments!" );

								Marshal.StructureToPtr( arguments[i], ( IntPtr ) stackFiller, false );
								stackFiller += actualSize;

								Tracer.Information( "param {0} with value {1} serialized as structure with actual size {2} without encoding assistance so be careful!", encodingArgumentRealIndex, arguments[i], actualSize * IntPtr.Size );
							}
							else
							{
								var expectedSize = encoding.Sizes[encodingArgumentIndex] / IntPtr.Size;
								var actualSize = RuntimeMethodEncoding.GetTypeStackSize( argumentType ) / IntPtr.Size;

								if( stackFiller + expectedSize > stackEnd )
									throw new InteropException( "Stack is too small to hold all arguments!" );

								Marshal.StructureToPtr( arguments[i], ( IntPtr ) stackFiller, false );
								stackFiller += actualSize;

								Tracer.Information( "param {0} with value {1} serialized as structure with expected size {2} and actual size {3}", encodingArgumentRealIndex, arguments[i], expectedSize * IntPtr.Size, actualSize * IntPtr.Size );

								while( actualSize < expectedSize )
								{
									Marshal.WriteIntPtr( new IntPtr( stackFiller++ ), IntPtr.Zero );
									actualSize++;
								}
							}
						}
						// ppc
						else
						{
							var stackByteFiller = ( byte* ) stackFiller;

							// vararg case
							if( encodingArgumentIndex >= encoding.Sizes.Length )
							{
								int actualSize = RuntimeMethodEncoding.GetTypeStackSize( argumentType );

								if( stackByteFiller + actualSize > stackEnd )
									throw new InteropException( "Stack is too small to hold all arguments!" );

								Marshal.StructureToPtr( arguments[i], ( IntPtr ) stackByteFiller, false );
								stackByteFiller += actualSize;

								Tracer.Information( "param {0} with value {1} serialized as structure with actual size {2} without encoding assistance so be careful!", encodingArgumentRealIndex, arguments[i], actualSize * IntPtr.Size );
							}
							else
							{
								var expectedSize = encoding.Sizes[encodingArgumentIndex];
								var actualSize = RuntimeMethodEncoding.GetTypeStackSize( argumentType );

								if( frRegistersPassedParametersCount < frRegistersPassedParametersMax )
								{
									if( argumentType == typeof( float ) )
										ppcFloatingRegisters1_13[frRegistersPassedParametersCount++] = ( float ) arguments[i];
									else if( argumentType == typeof( double ) )
										ppcFloatingRegisters1_13[frRegistersPassedParametersCount++] = ( double ) arguments[i];
								}

								var endWriteLocation = stackByteFiller + ( expectedSize + IntPtr.Size - 1 ) / IntPtr.Size * IntPtr.Size;

								if( endWriteLocation > stackEnd )
									throw new InteropException( "Stack is too small to hold all arguments!" );

								Marshal.StructureToPtr( arguments[i], ( IntPtr ) ( endWriteLocation - actualSize ), false );

								Tracer.Information( "param {0} with value {1} serialized as structure with expected size {2} and actual size {3}", encodingArgumentRealIndex, arguments[i], expectedSize, actualSize );

								while( actualSize < expectedSize )
								{
									*stackByteFiller++ = 0;
									actualSize++;
								}

								stackByteFiller = endWriteLocation;
							}

							stackFiller = ( IntPtr* ) stackByteFiller;
						}
					}
					else if( argumentType.IsArray && argumentType.GetElementType().IsValueType )
					{
						*pinnedArgument = GCHandle.Alloc( arguments[i], GCHandleType.Pinned );
						*stackFiller++ = pinnedArgument->AddrOfPinnedObject();
						Tracer.Information( "param {0} serialized as {2}*, pinned at {1}", encodingArgumentRealIndex, pinnedArgument->AddrOfPinnedObject().ToString( "X8" ), argumentType.GetElementType().Name );
						pinnedArgument++;
					}
					// special case - last argument expanded as params
					else if( i == arguments.Length - 1 && expandLastArgument != null )
					{
						Tracer.Information( "expanding last argument to {0} arguments..", expandLastArgument.Length );

						argumentBase += arguments.Length;
						arguments = expandLastArgument;
						expandLastArgument = arguments[arguments.Length - 1] as object[];
						i = -1;
						continue;
					}
					else
						throw new Exception( string.Format( "Serialize {0} of type {1} not supported!", i, arguments[i].GetType() ) );
				}

				Tracer.Information( "--SEND START--" );
				Tracer.IncreaseLevel();

				long result;
				var resultIsFloating = encoding.Types[0] == typeof( float ) || encoding.Types[0] == typeof( double );
				var resultIsStruct = structAddress != IntPtr.Zero;

				var occuredException = IntPtr.Zero;

				var stackSize = ( int ) ( ( byte* ) stackFiller - ( byte* ) stackStart );

				// use encoding to determine cases when some parameters are missed
				if( stackSize + IntPtr.Size * 2 < encoding.Offsets[0] )
				{
					var newSize = encoding.Offsets[0] - IntPtr.Size * 2; ;

					Tracer.Information( "use encoding-assisted argument stack fitting from {0} to {1}", stackSize, newSize );

					stackSize = newSize;
				}

				if( ( sendingOptions & MessageSendingOptions.SendToSuperclass ) != 0 )
				{
					var destinationPair = new NativeMethods.objc_super { _object = receiver, _class = new RuntimeObject( receiver ).Class.BaseClass };

					if( resultIsStruct )
					{
						Tracer.Information( "native call objc_msgSendSuper_stret_eh with stackSize = {0}", stackSize );
						Tracer.Flush();

						// ppc floating pass hack
						if( !BitConverter.IsLittleEndian && frRegistersPassedParametersCount > 0 )
							NativeMethods.objc_msgSendSuper_stret_eh_frpass( structAddress, structSize, ref destinationPair, selector, out occuredException, stackSize, ref nativeStack, ppcFloatingRegisters1_13[0], ppcFloatingRegisters1_13[1], ppcFloatingRegisters1_13[2], ppcFloatingRegisters1_13[3], ppcFloatingRegisters1_13[4], ppcFloatingRegisters1_13[5], ppcFloatingRegisters1_13[6], ppcFloatingRegisters1_13[7], ppcFloatingRegisters1_13[8], ppcFloatingRegisters1_13[9], ppcFloatingRegisters1_13[10], ppcFloatingRegisters1_13[11], ppcFloatingRegisters1_13[12] );
						else
							NativeMethods.objc_msgSendSuper_stret_eh( structAddress, structSize, ref destinationPair, selector, out occuredException, stackSize, ref nativeStack );

						result = 0;
					}
					else if( resultIsFloating )
					{
						Tracer.Information( "native call objc_msgSendSuper_fpret_eh with stackSize = {0}", stackSize );
						Tracer.Flush();

						// ppc floating pass hack
						if( !BitConverter.IsLittleEndian && frRegistersPassedParametersCount > 0 )
							*( double* ) &result = NativeMethods.objc_msgSendSuper_fpret_eh_frpass( ref destinationPair, selector, out occuredException, stackSize, ref nativeStack, ppcFloatingRegisters1_13[0], ppcFloatingRegisters1_13[1], ppcFloatingRegisters1_13[2], ppcFloatingRegisters1_13[3], ppcFloatingRegisters1_13[4], ppcFloatingRegisters1_13[5], ppcFloatingRegisters1_13[6], ppcFloatingRegisters1_13[7], ppcFloatingRegisters1_13[8], ppcFloatingRegisters1_13[9], ppcFloatingRegisters1_13[10], ppcFloatingRegisters1_13[11], ppcFloatingRegisters1_13[12] );
						else
							*( double* ) &result = NativeMethods.objc_msgSendSuper_fpret_eh( ref destinationPair, selector, out occuredException, stackSize, ref nativeStack );
					}
					else
					{
						Tracer.Information( "native call objc_msgSendSuper_eh with stackSize = {0}", stackSize );
						Tracer.Flush();

						if( !BitConverter.IsLittleEndian && frRegistersPassedParametersCount > 0 )
							result = NativeMethods.objc_msgSendSuper_eh_frpass( ref destinationPair, selector, out occuredException, stackSize, ref nativeStack, ppcFloatingRegisters1_13[0], ppcFloatingRegisters1_13[1], ppcFloatingRegisters1_13[2], ppcFloatingRegisters1_13[3], ppcFloatingRegisters1_13[4], ppcFloatingRegisters1_13[5], ppcFloatingRegisters1_13[6], ppcFloatingRegisters1_13[7], ppcFloatingRegisters1_13[8], ppcFloatingRegisters1_13[9], ppcFloatingRegisters1_13[10], ppcFloatingRegisters1_13[11], ppcFloatingRegisters1_13[12] );
						else
							result = NativeMethods.objc_msgSendSuper_eh( ref destinationPair, selector, out occuredException, stackSize, ref nativeStack );
					}
				}
				else
				{
					if( resultIsStruct )
					{
						Tracer.Information( "native call objc_msgSend_stret_eh with stackSize = {0}", stackSize );
						Tracer.Flush();

						// ppc floating pass hack
						if( !BitConverter.IsLittleEndian && frRegistersPassedParametersCount > 0 )
							NativeMethods.objc_msgSend_stret_eh_frpass( structAddress, structSize, receiver, selector, out occuredException, stackSize, ref nativeStack, ppcFloatingRegisters1_13[0], ppcFloatingRegisters1_13[1], ppcFloatingRegisters1_13[2], ppcFloatingRegisters1_13[3], ppcFloatingRegisters1_13[4], ppcFloatingRegisters1_13[5], ppcFloatingRegisters1_13[6], ppcFloatingRegisters1_13[7], ppcFloatingRegisters1_13[8], ppcFloatingRegisters1_13[9], ppcFloatingRegisters1_13[10], ppcFloatingRegisters1_13[11], ppcFloatingRegisters1_13[12] );
						else
							NativeMethods.objc_msgSend_stret_eh( structAddress, structSize, receiver, selector, out occuredException, stackSize, ref nativeStack );

						result = 0;
					}
					else if( resultIsFloating )
					{
						Tracer.Information( "native call objc_msgSend_fpret_eh with stackSize = {0}", stackSize );
						Tracer.Flush();

						// ppc floating pass hack
						if( !BitConverter.IsLittleEndian && frRegistersPassedParametersCount > 0 )
							*( double* ) &result = NativeMethods.objc_msgSend_fpret_eh_frpass( receiver, selector, out occuredException, stackSize, ref nativeStack, ppcFloatingRegisters1_13[0], ppcFloatingRegisters1_13[1], ppcFloatingRegisters1_13[2], ppcFloatingRegisters1_13[3], ppcFloatingRegisters1_13[4], ppcFloatingRegisters1_13[5], ppcFloatingRegisters1_13[6], ppcFloatingRegisters1_13[7], ppcFloatingRegisters1_13[8], ppcFloatingRegisters1_13[9], ppcFloatingRegisters1_13[10], ppcFloatingRegisters1_13[11], ppcFloatingRegisters1_13[12] );
						else
							*( double* ) &result = NativeMethods.objc_msgSend_fpret_eh( receiver, selector, out occuredException, stackSize, ref nativeStack );
					}
					else
					{
						Tracer.Information( "native call objc_msgSend_eh with stackSize = {0}", stackSize );
						Tracer.Flush();

						if( !BitConverter.IsLittleEndian && frRegistersPassedParametersCount > 0 )
							result = NativeMethods.objc_msgSend_eh_frpass( receiver, selector, out occuredException, stackSize, ref nativeStack, ppcFloatingRegisters1_13[0], ppcFloatingRegisters1_13[1], ppcFloatingRegisters1_13[2], ppcFloatingRegisters1_13[3], ppcFloatingRegisters1_13[4], ppcFloatingRegisters1_13[5], ppcFloatingRegisters1_13[6], ppcFloatingRegisters1_13[7], ppcFloatingRegisters1_13[8], ppcFloatingRegisters1_13[9], ppcFloatingRegisters1_13[10], ppcFloatingRegisters1_13[11], ppcFloatingRegisters1_13[12] );
						else
							result = NativeMethods.objc_msgSend_eh( receiver, selector, out occuredException, stackSize, ref nativeStack );
					}
				}

				Tracer.DecreaseLevel();
				Tracer.Information( "--SEND END--" );

				Tracer.Information( "Returned: {0:X16}", result );
				Tracer.Flush();

				while( wrappedArgument > wrappedArguments )
					SendMessage( *--wrappedArgument, Selectors.release );

				while( pinnedArgument > pinnedArguments )
					( --pinnedArgument )->Free();

				if( occuredException != IntPtr.Zero )
					throw RuntimeException.Create( new RuntimeObject( occuredException ) );

				if( BitConverter.IsLittleEndian )
					return result;

				if( encoding.Types[0] != typeof( ulong ) && encoding.Types[0] != typeof( long ) && encoding.Types[0] != typeof( double ) && encoding.Types[0] != typeof( float ) )
					return result >> 32;

				return result;
			}
			// remove try/finally in future
			finally
			{
				Tracer.DecreaseLevel();
			}
		}

		internal static unsafe object DeserializeResult( long result, RuntimeMethodEncoding encoding )
		{
			// dynamic call with null receiver
			if( encoding == null )
				return null;

			Tracer.Information( "Deserialize invocation result.." );
			Tracer.IncreaseLevel();
			try
			{
				var convertToType = encoding.Types[0];

				if( convertToType == typeof( void ) )
				{
					Tracer.Information( "Deserialize {0} as void", result );
					return null;
				}
				else if( convertToType == typeof( float ) )
				{
					Tracer.Information( "Deserialize {0} as float", ( float ) *( double* ) &result );
					return ( float ) *( double* ) &result;
				}
				else if( convertToType == typeof( double ) )
				{
					Tracer.Information( "Deserialize {0} as double", *( double* ) &result );
					return *( double* ) &result;
				}
				else if( convertToType == typeof( long ) )
				{
					Tracer.Information( "Deserialize {0} as long", result );
					return result;
				}
				else if( convertToType == typeof( int ) )
				{
					Tracer.Information( "Deserialize {0} as int", ( int ) result );
					return ( int ) result;
				}
				else if( convertToType == typeof( uint ) )
				{
					Tracer.Information( "Deserialize {0} as uint", ( uint ) result );
					return ( uint ) result;
				}
				else if( convertToType == typeof( char ) )
				{
					Tracer.Information( "Deserialize {0} as char", ( char ) result );
					return ( char ) result;
				}
				else if( convertToType == typeof( short ) )
				{
					Tracer.Information( "Deserialize {0} as short", ( short ) result );
					return ( short ) result;
				}
				else if( convertToType == typeof( ushort ) )
				{
					Tracer.Information( "Deserialize {0} as ushort", ( ushort ) result );
					return ( ushort ) result;
				}
				else if( convertToType == typeof( long ) )
				{
					Tracer.Information( "Deserialize {0} as long", result );
					return result;
				}
				else if( convertToType == typeof( ulong ) )
				{
					Tracer.Information( "Deserialize {0} as ulong", ( ulong ) result );
					return ( ulong ) result;
				}
				else if( convertToType == typeof( RuntimeObject ) )
				{
					var resultPtr = TruncateUnnecessaryAddressBits( result );

					if( resultPtr == IntPtr.Zero )
					{
						Tracer.Information( "Return null" );
						return null;
					}

					var objectReturn = new RuntimeObject( resultPtr );
					// same situation as above
#if TRACE
					Tracer.Information( "Return type hierarchy: {0}", string.Join( " <-- ", objectReturn.Class.BaseHierarchy.Select( x => x.Name ).ToArray() ) );
#endif
					string unwrappedString = UnwrapNSString( objectReturn );
					if( unwrappedString != null )
					{
						Tracer.Information( @"Deserialize ""{0}"" as string", unwrappedString );

						return unwrappedString;
					}

					return result;
				}

				Tracer.Information( "Deserialize {0} as IntPtr", ( ( IntPtr ) ( int ) result ).ToString( "X8" ) );
			}
			finally
			{
				Tracer.DecreaseLevel();
			}
			return ( IntPtr ) ( int ) result;
		}

		/// <summary>
		/// Used to retrieve characters from Objective-C string.
		/// </summary>
		/// <param name="object">NSString</param>
		/// <returns>Unwrapped string value</returns>
		public unsafe static string UnwrapNSString( IntPtr @object )
		{
			var objectReturn = new RuntimeObject( @object );
			var objectClass = objectReturn.Class;

			if( !objectClass.IsSubclassOf( RuntimeClasses.NSString ) )
				return null;

			if( objectClass == StringProxy.Class )
				return ( ( StringProxy* ) @object )->ManagedString;

			string resultString;
			var length = ( int ) SendMessage( objectReturn, Selectors.length );

			if( length < 1024 )
			{
				var buffer = stackalloc char[length];
				SendMessage( objectReturn, Selectors.getCharacters_, ( IntPtr ) buffer );
				resultString = new string( buffer, 0, length );
			}
			else
				fixed( char* buffer = new char[length] )
				{
					SendMessage( objectReturn, Selectors.getCharacters_, ( IntPtr ) buffer );
					resultString = new string( buffer, 0, length );
				}

			return resultString;
		}

		/// <summary>
		/// Version of Mac OS
		/// </summary>
		public enum MacOSVersion
		{
			/// <summary>
			/// Invalid version
			/// </summary>
			Invalid,

			/// <summary>
			/// http://en.wikipedia.org/wiki/Mac_OS_X_v10.0
			/// </summary>
			Cheetah,

			/// <summary>
			/// http://en.wikipedia.org/wiki/Mac_OS_X_v10.1
			/// </summary>
			Puma,

			/// <summary>
			/// http://en.wikipedia.org/wiki/Mac_OS_X_v10.2
			/// </summary>
			Jaguar,

			/// <summary>
			/// http://en.wikipedia.org/wiki/Mac_OS_X_v10.3
			/// </summary>
			Panther,

			/// <summary>
			/// http://en.wikipedia.org/wiki/Mac_OS_X_v10.4
			/// </summary>
			Tiger,

			/// <summary>
			/// http://en.wikipedia.org/wiki/Mac_OS_X_v10.5
			/// </summary>
			Leopard,

			/// <summary>
			/// http://en.wikipedia.org/wiki/Mac_OS_X_v10.6
			/// </summary>
			SnowLeopard,

			/// <summary>
			/// Reserved for future
			/// </summary>
			Future,

			/// <summary>
			/// http://en.wikipedia.org/wiki/IPhone
			/// </summary>
			IPhone
		}

		/// <summary>
		/// There is no normal function to determine OS version.
		/// See http://cocoadevcentral.com/articles/000067.php for details
		/// </summary>
		public static MacOSVersion Version
		{
			get
			{
				if( _version != null )
					return _version.Value;

				int response;
				NativeMethods.Gestalt( 0x73797376, out response );

				if( response < 0x1000 )
					_version = MacOSVersion.Invalid;
				else if( response < 0x1010 )
					_version = MacOSVersion.Cheetah;
				else if( response < 0x1020 )
					_version = MacOSVersion.Puma;
				else if( response < 0x1030 )
					_version = MacOSVersion.Jaguar;
				else if( response < 0x1040 )
					_version = MacOSVersion.Panther;
				else if( response < 0x1050 )
					_version = MacOSVersion.Tiger;
				else if( response < 0x1060 )
					_version = MacOSVersion.Leopard;
				else if( response < 0x1070 )
					_version = MacOSVersion.SnowLeopard;

				return _version.Value;
			}
		}
		private static MacOSVersion? _version;

		/// <summary>
		/// Performs guarded Objective-C message send.
		/// </summary>
		/// <param name="object">Message receiver.</param>
		/// <param name="selector">Method selector.</param>
		/// <returns></returns>
		public static IntPtr SendMessage( IntPtr @object, Selector selector )
		{
			RuntimeObject occuredException;
			var result = Runtime.NativeMethods.SendMessage( @object, selector, out occuredException, 0 );

			if( occuredException != RuntimeObject.Null )
				throw RuntimeException.Create( occuredException );

			return result;
		}

		/// <summary>
		/// Performs guarded Objective-C message send.
		/// </summary>
		/// <param name="object">Message receiver.</param>
		/// <param name="selector">Method selector.</param>
		/// <param name="parameter1"></param>
		/// <returns></returns>
		public static IntPtr SendMessage( IntPtr @object, Selector selector, IntPtr parameter1 )
		{
			RuntimeObject occuredException;
			var result = Runtime.NativeMethods.SendMessage( @object, selector, out occuredException, IntPtr.Size, parameter1 );

			if( occuredException != RuntimeObject.Null )
				throw RuntimeException.Create( occuredException );

			return result;
		}

		/// <summary>
		/// Performs guarded Objective-C message send to superclass.
		/// </summary>
		/// <param name="object">Message receiver.</param>
		/// <param name="base">Class to find method from.</param>
		/// <param name="selector">Method selector.</param>
		/// <returns></returns>
		public static IntPtr SendMessageToBase( IntPtr @object, RuntimeClass @base, Selector selector )
		{
			RuntimeObject occuredException;
			var destinationPair = new NativeMethods.objc_super { _object = @object, _class = @base };

			var result = NativeMethods.SendMessageToBase( ref destinationPair, selector, out occuredException, 0 );
			if( occuredException != RuntimeObject.Null )
				throw RuntimeException.Create( occuredException );

			return result;
		}

		#region P\Invoke

		internal static unsafe class NativeMethods
		{
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr SendMessage( IntPtr @object, Selector selector, out RuntimeObject occuredException, int stackSize );

			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr SendMessage( IntPtr @object, Selector selector, out RuntimeObject occuredException, int stackSize, IntPtr parameter1 );

			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSendSuper_eh2" )]
			public static extern IntPtr SendMessageToBase( ref objc_super receiver, Selector selector, out RuntimeObject occuredException, int stackSize );

			/// <summary>
			/// Used for calling method from superclass.
			/// [super method:10]
			/// </summary>
			internal struct objc_super
			{
				public IntPtr _object;
				public RuntimeClass _class;
			}

			/// <summary>
			/// http://en.wikipedia.org/wiki/Gestalt_(Mac_OS)
			/// </summary>
			/// <param name="selector">what to obtain</param>
			/// <param name="response"></param>
			/// <returns></returns>
			[DllImport( "/System/Library/Frameworks/CoreServices.framework/CoreServices" )]
			public static extern short Gestalt( int selector, out int response );

			/// <summary>
			/// Returns a property with a given name of a given class.
			/// </summary>
			/// <param name="class">Class to find property in.</param>
			/// <param name="name">Name of property.</param>
			/// <returns></returns>
			[DllImport( RuntimeLibrary )]
			public static extern IntPtr class_getProperty( RuntimeClass @class, string name );

			/// <summary>
			/// Returns a specified instance method for a given class.
			/// </summary>
			/// <param name="class">The class you want to inspect.</param>
			/// <param name="selector">The selector of the method you want to retrieve.</param>
			/// <returns>The method that corresponds to the implementation of the _selector specified by aSelector for the class specified by aClass, or NULL if the specified class or its superclasses do not contain an instance method with the specified _selector.</returns>
			[DllImport( RuntimeLibrary )]
			internal static extern IntPtr class_getInstanceMethod( RuntimeClass @class, Selector selector );

			[DllImport( RuntimeLibrary )]
			internal static extern IntPtr objc_getMetaClass( string name );

			[DllImport( RuntimeLibrary )]
			internal static extern bool class_respondsToSelector( RuntimeClass @class, Selector selector );

			// <summary>
			// Mono JIT programmers not implemented p/invoke vararg yet coz like C and don't like refactoring
			// </summary>
			// <param name="receiver"></param>
			// <param name="selector"></param>
			// <returns></returns>
			//[DllImport( RuntimeLibrary )]
			//internal static extern IntPtr objc_msgSend( IntPtr receiver, Selector selector, __arglist );

			/// <summary>
			/// Sends a message with a long return value to an instance of a class. Call is guarded by @try/@catch barrier.
			/// </summary>
			/// <param name="receiver">A pointer that points to the instance of the class that is to receive the message.</param>
			/// <param name="selector">The selector of the method that handles the message.</param>
			/// <param name="occuredException">If objective-c exception is occured occuredException will represent native handle to it.</param>
			/// <param name="stackSize">Length of serialized parameters array. Used to prevent unnecessary data copy.</param>
			/// <param name="arguments">A pointer to serialized parameters.</param>
			/// <returns>result of message sending</returns>
			[DllImport( InteropLibrary )]
			internal static extern long objc_msgSend_eh( IntPtr receiver, Selector selector, out IntPtr occuredException, int stackSize, ref ArgumentsStack arguments );

			[DllImport( InteropLibrary )]
			internal static extern void objc_msgSend_stret_eh( IntPtr resultAddress, int resultSize, IntPtr receiver, Selector selector, out IntPtr occuredException, int stackSize, ref ArgumentsStack arguments );

			/// <summary>
			/// Used to setup floating-point registers on PPC
			/// </summary>
			[DllImport( InteropLibrary, EntryPoint = "objc_msgSend_eh" )]
			internal static extern long objc_msgSend_eh_frpass( IntPtr receiver, Selector selector, out IntPtr occuredException, int stackSize, ref ArgumentsStack arguments, double fr1, double fr2, double fr3, double fr4, double fr5, double fr6, double fr7, double fr8, double fr9, double fr10, double fr11, double fr12, double fr13 );

			[DllImport( InteropLibrary, EntryPoint = "objc_msgSend_stret_eh" )]
			internal static extern void objc_msgSend_stret_eh_frpass( IntPtr resultAddress, int resultSize, IntPtr receiver, Selector selector, out IntPtr occuredException, int stackSize, ref ArgumentsStack arguments, double fr1, double fr2, double fr3, double fr4, double fr5, double fr6, double fr7, double fr8, double fr9, double fr10, double fr11, double fr12, double fr13 );

			[DllImport( InteropLibrary )]
			internal static extern long objc_msgSendSuper_eh( ref objc_super receiver, Selector selector, out IntPtr occuredException, int stackSize, ref ArgumentsStack arguments );

			[DllImport( InteropLibrary )]
			internal static extern void objc_msgSendSuper_stret_eh( IntPtr resultAddress, int resultSize, ref objc_super receiver, Selector selector, out IntPtr occuredException, int stackSize, ref ArgumentsStack arguments );

			[DllImport( InteropLibrary, EntryPoint = "objc_msgSendSuper_eh" )]
			internal static extern long objc_msgSendSuper_eh_frpass( ref objc_super receiver, Selector selector, out IntPtr occuredException, int stackSize, ref ArgumentsStack arguments, double fr1, double fr2, double fr3, double fr4, double fr5, double fr6, double fr7, double fr8, double fr9, double fr10, double fr11, double fr12, double fr13 );

			[DllImport( InteropLibrary, EntryPoint = "objc_msgSendSuper_stret_eh" )]
			internal static extern void objc_msgSendSuper_stret_eh_frpass( IntPtr resultAddress, int resultSize, ref objc_super receiver, Selector selector, out IntPtr occuredException, int stackSize, ref ArgumentsStack arguments, double fr1, double fr2, double fr3, double fr4, double fr5, double fr6, double fr7, double fr8, double fr9, double fr10, double fr11, double fr12, double fr13 );

			/// <summary>
			/// Sends a message with a floating-point return value to an instance of a class. Call is guarded by @try/@catch barrier.
			/// </summary>
			/// <param name="receiver">A pointer that points to the instance of the class that is to receive the message.</param>
			/// <param name="selector">The selector of the method that handles the message.</param>
			/// <param name="occuredException">If objective-c exception is occured occuredException will represent native handle to it.</param>
			/// <param name="stackSize">Length of serialized parameters array. Used to prevent unnecessary data copy.</param>
			/// <param name="arguments">A pointer to serialized parameters.</param>
			/// <returns></returns>
			[DllImport( InteropLibrary )]
			internal static extern double objc_msgSend_fpret_eh( IntPtr receiver, Selector selector, out IntPtr occuredException, int stackSize, ref ArgumentsStack arguments );

			/// <summary>
			/// Used to setup floating-point registers on PPC
			/// </summary>
			[DllImport( InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh" )]
			internal static extern double objc_msgSend_fpret_eh_frpass( IntPtr receiver, Selector selector, out IntPtr occuredException, int stackSize, ref ArgumentsStack arguments, double fr1, double fr2, double fr3, double fr4, double fr5, double fr6, double fr7, double fr8, double fr9, double fr10, double fr11, double fr12, double fr13 );

			[DllImport( InteropLibrary )]
			internal static extern double objc_msgSendSuper_fpret_eh( ref objc_super receiver, Selector selector, out IntPtr occuredException, int stackSize, ref ArgumentsStack arguments );

			[DllImport( InteropLibrary, EntryPoint = "objc_msgSendSuper_fpret_eh" )]
			internal static extern double objc_msgSendSuper_fpret_eh_frpass( ref objc_super receiver, Selector selector, out IntPtr occuredException, int stackSize, ref ArgumentsStack arguments, double fr1, double fr2, double fr3, double fr4, double fr5, double fr6, double fr7, double fr8, double fr9, double fr10, double fr11, double fr12, double fr13 );

			[DllImport( RuntimeLibrary )]
			internal static extern IntPtr objc_getClass( string name );

			/// <summary>
			/// Creates an instance of a class, allocating memory for the class in the default malloc memory zone.
			/// </summary>
			/// <param name="class">The class that you wish to allocate an instance of.</param>
			/// <param name="extraBytes">An integer indicating the number of extra bytes to allocate. The additional bytes can be used to store additional instance variables beyond those defined in the class definition.</param>
			/// <returns>An instance of the class <paramref name="class"/>.</returns>
			[DllImport( RuntimeLibrary )]
			internal static extern IntPtr class_createInstance( IntPtr @class, int extraBytes );

			/// <summary>
			/// Obtains the list of registered class definitions.
			/// </summary>
			/// <param name="buffer">An array of RuntimeClass values. On output, each RunimeClass value points to one class definition, up to either bufferLen or the total number of registered classes, whichever is less. You can pass NULL to obtain the total number of registered class definitions without actually retrieving any class definitions.</param>
			/// <param name="count">An integer value. Pass the number of pointers for which you have allocated space in buffer. On return, this function fills in only this number of elements. If this number is less than the number of registered classes, this function returns an arbitrary subset of the registered classes.</param>
			/// <returns>An integer value indicating the total number of registered classes.</returns>
			[DllImport( RuntimeLibrary )]
			internal static extern int objc_getClassList( IntPtr* buffer, int count );

			/// <summary>
			/// Registers a method with the Objective-C runtime system, maps the method name to a selector, and returns the selector value.
			/// </summary>
			/// <param name="selectorName">A pointer to string. Pass the name of the method you wish to register.</param>
			/// <returns>A pointer of type SEL specifying the selector for the named method.</returns>
			[DllImport( RuntimeLibrary )]
			internal static extern IntPtr sel_registerName( string selectorName );

			/// <summary>
			/// Changes the value of an instance variable of a class instance.
			/// </summary>
			/// <param name="object">A pointer to an instance of a class. Pass the object containing the instance variable whose value you wish to modify.</param>
			/// <param name="name">the name of the instance variable whose value you wish to modify.</param>
			/// <param name="value">a pointer to the new value for the instance variable.</param>
			/// <returns>A pointer to the Ivar data structure that defines the type and name of the instance variable specified by name.</returns>
			[DllImport( RuntimeLibrary )]
			internal static extern IntPtr object_setInstanceVariable( RuntimeObject @object, string name, IntPtr value );

			public static string sel_getName( Selector handle )
			{
				return Marshal.PtrToStringAnsi( Runtime.UnsafeNativeMethods.sel_getName( handle ) );
			}

			/// <summary>
			/// Sets the version number of a class definition.
			/// You can use the version number of the class definition to provide versioning of the interface that your class represents to other classes.
			/// This is especially useful for object serialization (that is, archiving of the object in a flattened form), where it is important to recognize changes to the layout of the instance variables in different class-definition versions.
			/// </summary>
			/// <param name="class">the class definition for which you wish to set the version.</param>
			/// <param name="version">new version number of the class definition</param>
			[DllImport( RuntimeLibrary )]
			public static extern void class_setVersion( IntPtr @class, int version );

			/// <summary>
			/// Returns the version number of a class definition.
			/// </summary>
			/// <param name="class">the class definition for which you wish to obtain the version</param>
			/// <returns></returns>
			[DllImport( RuntimeLibrary )]
			public static extern int class_getVersion( RuntimeClass @class );

			/// <summary>
			/// Returns a Boolean value that indicates whether one protocol conforms to another protocol.
			/// </summary>
			/// <param name="first">a protocol</param>
			/// <param name="second">a protocol</param>
			/// <returns>true if proto conforms to other, otherwise false</returns>
			[DllImport( RuntimeLibrary )]
			public static extern bool protocol_conformsToProtocol( RuntimeProtocol first, RuntimeProtocol second );

			/// <summary>
			/// Returns a value that indicates whether a class conforms to a given protocol
			/// </summary>
			/// <param name="class">The class you want to inspect</param>
			/// <param name="protocol">a protocol</param>
			/// <returns>true if cls conforms to protocol, otherwise false</returns>
			[DllImport( RuntimeLibrary )]
			public static extern bool class_conformsToProtocol( RuntimeClass @class, RuntimeProtocol protocol );

			/// <summary>
			/// Returns attributes of specified property.
			/// </summary>
			/// <param name="property">Property to inspect.</param>
			/// <returns>Attributes string. See http://developer.apple.com/DOCUMENTATION/Cocoa/Conceptual/ObjCRuntimeGuide/Articles/chapter_8_section_3.html#//apple_ref/doc/uid/TP40008048-CH101-SW6 </returns>
			public static string property_getAttributes( RuntimeProperty property )
			{
				return Marshal.PtrToStringAnsi( Runtime.UnsafeNativeMethods.property_getAttributes( property ) );
			}

			/// <summary>
			/// Returns the specified property of a given protocol.
			/// </summary>
			/// <param name="protocol">A protocol to inspect.</param>
			/// <param name="name">The name of a property to find.</param>
			/// <param name="isRequiredProperty">A value that indicates whether <paramref name="name"/> is a required property.</param>
			/// <param name="isInstanceProperty">A value that indicates whether <paramref name="name"/> is a instance property.</param>
			/// <returns>Appropriate property found in <paramref name="protocol"/> or null.</returns>
			[DllImport( InteropLibrary )]
			public static extern IntPtr protocol_getProperty( RuntimeProtocol protocol, string name, bool isRequiredProperty, bool isInstanceProperty );


			/// <summary>
			/// Returns the name of a property.
			/// </summary>
			/// <param name="property">Property to inspect.</param>
			/// <returns>Property name.</returns>
			public static string property_getName( RuntimeProperty property )
			{
				return Marshal.PtrToStringAnsi( Runtime.UnsafeNativeMethods.property_getName( property ) );
			}
		}

		/// <summary>
		/// Methods that need additional marshaling.
		/// </summary>
		private static unsafe class UnsafeNativeMethods
		{
			/// <summary>
			/// Returns the name of a property.
			/// </summary>
			/// <param name="property">Property to inspect.</param>
			/// <returns>Property name.</returns>
			[DllImport( InteropLibrary )]
			public static extern IntPtr property_getName( RuntimeProperty property );

			/// <summary>
			/// Returns attributes of specified property.
			/// </summary>
			/// <param name="property">Property to inspect.</param>
			/// <returns>Attributes string. See http://developer.apple.com/DOCUMENTATION/Cocoa/Conceptual/ObjCRuntimeGuide/Articles/chapter_8_section_3.html#//apple_ref/doc/uid/TP40008048-CH101-SW6 </returns>
			[DllImport( InteropLibrary )]
			public static extern IntPtr property_getAttributes( RuntimeProperty property );

			[DllImport( RuntimeLibrary )]
			public static extern IntPtr sel_getName( Selector handle );
		}

		internal unsafe struct ArgumentsStack
		{
			public fixed byte Contents[128];
		}

		/// <summary>
		/// Used to mark return type as "@".
		/// </summary>
		internal struct ObjectMark
		{
		}

		#endregion
	}
}
