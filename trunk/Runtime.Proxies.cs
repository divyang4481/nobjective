//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

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
	public static partial class Runtime
	{
		/// <summary>
		/// Creates string proxy around System.String object that responds to some NSString's selectors.
		/// </summary>
		/// <param name="string">String to create proxy from</param>
		/// <returns>NSString proxy</returns>
		public unsafe static IntPtr CreateStringProxy( string @string )
		{
			var result = ( StringProxy* ) NativeMethods.class_createInstance( StringProxy.Class, 0 );
			result->_managedHandle = GCHandle.Alloc( @string );
			return new IntPtr( result );
		}

		/// <summary>
		/// Used for marshaling .NET strings into Objective-C runtime.
		/// </summary>
		[BaseClass( "NSString" )]
		[ClassName( "NOStringProxy" )]
		internal struct StringProxy
		{
			public static RuntimeClass Class;

#pragma warning disable 649
			public RuntimeClass _isa;
#pragma warning restore 649

			public GCHandle _managedHandle;

			public string ManagedString { get { return ( ( string ) _managedHandle.Target ); } }

			public void dealloc()
			{
				_managedHandle.Free();
			}

			public int length()
			{
				return ManagedString.Length;
			}

			public unsafe StringProxy* description()
			{
				fixed( StringProxy* @this = &this )
					return @this;
			}

			public short characterAtIndex( int index )
			{
				return ( short ) ManagedString[index];
			}

			public unsafe void getCharacters( char* buffer )
			{
				int length = ManagedString.Length;

				fixed( char* chars = ManagedString )
					for( int i = 0; i < length; i++ )
						buffer[i] = chars[i];
			}

#pragma warning disable 649
			public struct _NSRange
			{
				public int location;
				public int length;
			}
#pragma warning restore 649

			public unsafe void getCharacters( char* buffer, _NSRange range )
			{
				int length = Math.Min( ManagedString.Length, range.location + range.length );

				fixed( char* chars = ManagedString )
					for( int i = range.location; i < length; i++ )
						buffer[i] = chars[i];
			}
		}

		/// <summary>
		/// Creates NSException from .NET exception.
		/// </summary>
		/// <param name="exception">Source .NET exception to create proxy from</param>
		/// <returns>NSException</returns>
		public unsafe static IntPtr CreateExceptionProxy( object exception )
		{
			var exceptionObject = ( ExceptionProxy* ) NativeMethods.class_createInstance( ExceptionProxy.Class, 0 );
			//var exceptionObject = ( ExceptionProxy* ) ( IntPtr ) ExceptionProxy.Class.CreateInstance();

			exceptionObject->_managedHandle = GCHandle.Alloc( exception );

			return new RuntimeObject( exceptionObject );
		}

		/// <summary>
		/// Used to pass .NET exceptions over Objective-C runtime via Objective-C exceptions.
		/// </summary>
		[ClassName( "NOExceptionProxy" )]
		internal struct ExceptionProxy
		{
			/// <summary>
			/// Registered class for this proxy.
			/// </summary>
			public static RuntimeClass Class;

#pragma warning disable 649
			/// <summary>
			/// Pointer to class.
			/// </summary>
			public RuntimeClass _isa;
#pragma warning restore 649

			/// <summary>
			/// Handle to .NET exception.
			/// </summary>
			public GCHandle _managedHandle;

			/// <summary>
			/// Managed exception.
			/// </summary>
			public Exception ManagedException { get { return ( ( Exception ) _managedHandle.Target ); } }

			public void dealloc()
			{
				_managedHandle.Free();
			}

			public string description()
			{
				return ManagedException.Message;
			}

			public string stackTrace()
			{
				return ManagedException.StackTrace;
			}

			public string type()
			{
				return ManagedException.GetType().FullName;
			}
		}

		/// <summary>
		/// Checks that specified class is internally used by bridge.
		/// </summary>
		/// <param name="class">Class to check.</param>
		/// <returns>True if specified class is internally used by bridge, False otherwise.</returns>
		public static bool IsInternalProxyClass( RuntimeClass @class )
		{
			if( @class == ExceptionProxy.Class )
				return true;

			if( @class == StringProxy.Class )
				return true;

			return false;
		}
	}
}