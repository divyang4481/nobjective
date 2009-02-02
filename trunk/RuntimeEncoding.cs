//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;

namespace NObjective
{
	/// <summary>
	/// Each instance of RuntimeMethodEncoding class represents parsed method encoding string.
	/// </summary>
	public sealed class RuntimeMethodEncoding
	{
		/// <summary>
		/// Original Objective-C method encoding.
		/// </summary>
		public readonly string Encoding;

		/// <summary>
		/// Types in encoding.
		/// First is return type.
		/// Second always RuntimeObject and third always Selector.
		/// </summary>
		public readonly Type[] Types;

		/// <summary>
		/// Stack offsets for each parameter.
		/// </summary>
		public readonly int[] Offsets;

		/// <summary>
		/// Sizes for each parameter.
		/// </summary>
		public readonly int[] Sizes;

		/// <summary>
		/// Used to debug encodings.
		/// </summary>
		internal static readonly NObjective.Tracing.TraceSource Tracer = new NObjective.Tracing.TraceSource( "Runtime encoding tracer" );

		/// <summary>
		/// Initializes new instance of RuntimeMethodEncoding class with specified Objective-C method encoding.
		/// </summary>
		/// <param name="encoding">Objective-C method encoding to parse.</param>
		public RuntimeMethodEncoding( string encoding )
		{
			Tracer.Information( "Try to parse encoding: {0}", encoding );

			Encoding = encoding;
			bool foundOffset = false, isDigit = false;
			int totalTypes = 0;

			int index = 0;

			while( index < encoding.Length )
			{
				if( encoding[index] == '{' )
				{
					while( index < encoding.Length && encoding[index] != '}' )
						index++;

					if( index == encoding.Length )
						break;
				}
				isDigit = char.IsDigit( encoding[index] );

				if( !foundOffset && isDigit )
				{
					foundOffset = true;
					totalTypes++;
				}
				else if( foundOffset && !isDigit )
					foundOffset = false;

				index++;
			}

			Types = new Type[totalTypes];
			Offsets = new int[totalTypes];

			int currentElement = 0;
			int currentOffset = 0;
			Type currentType = null;

			index = -1;
			foundOffset = false;

			bool makePointer = false;
			do
			{
				index++;

				if( index >= encoding.Length || ( !( isDigit = char.IsDigit( encoding[index] ) ) && foundOffset ) )
				{
					Types[currentElement] = currentType;
					Offsets[currentElement] = currentOffset;

					if( makePointer && Types[currentElement] != null )
						Types[currentElement] = Types[currentElement].MakePointerType();

					foundOffset = false;
					currentOffset = 0;
					makePointer = false;

					currentElement++;

					if( index == encoding.Length )
						break;
				}
				else if( !foundOffset && isDigit )
					foundOffset = true;

				// skip modifiers
				if( encoding[index] == 'r' || encoding[index] == 'n' || encoding[index] == 'N' || encoding[index] == 'o' || encoding[index] == 'O' || encoding[index] == 'R' || encoding[index] == 'V' )
					continue;

				if( encoding[index] == '^' )
				{
					makePointer = true;
					continue;
				}

				// handle structure information
				if( encoding[index] == '{' )
				{
					int stacked = 1;

					while( stacked > 0 && ++index < encoding.Length )
					{
						if( encoding[index] == '{' )
							stacked++;
						else if( encoding[index] == '}' )
							stacked--;
					}

					currentType = null;
					continue;
				}

				// handle array information
				if( encoding[index] == '[' )
				{
					int stacked = 1;

					while( stacked > 0 && ++index < encoding.Length )
					{
						if( encoding[index] == '[' )
							stacked++;
						else if( encoding[index] == ']' )
							stacked--;
					}

					currentType = null;
					continue;
				}

				if( !foundOffset && !isDigit )
				{
					currentType = DecodeType( encoding[index] );
				}

				if( isDigit )
				{
					currentOffset *= 10;
					currentOffset += encoding[index] - '0';
				}
			} while( true );

			Sizes = new int[Types.Length];
			for( int i = 1; i < Types.Length - 1; i++ )
				Sizes[i] = Offsets[i + 1] - Offsets[i];

			Sizes[Sizes.Length - 1] = Offsets[0] - Offsets[Offsets.Length - 1];
			Sizes[0] = GetTypeStackSize( Types[0] );

			Tracer.Information( "\tTypes: {0}", string.Join( ", ", Types.Select( x => x != null ? x.Name : "null" ).ToArray() ) );
			Tracer.Information( "\tSizes: {0}", string.Join( ", ", Sizes.Select( x => x + "" ).ToArray() ) );
			Tracer.Information( "\tOffsets: {0}", string.Join( ", ", Offsets.Select( x => x + "" ).ToArray() ) );
		}

		/// <summary>
		/// Initializes new instance of RuntimeMethodEncoding class with specified array of types that represents return value, hidden parameters and actual arguments.
		/// </summary>
		/// <param name="types">Array of types to construct Objective-C method encoding.</param>
		public RuntimeMethodEncoding( Type[] types )
		{
			var encoding = new StringBuilder( 32 );
			int currentOffset = 0;

			Types = types;
			Sizes = new int[types.Length];
			Offsets = new int[types.Length];

			for( int i = 1; i < types.Length; i++ )
			{
				Offsets[i] = currentOffset;
				Sizes[i] = GetTypeStackSize( types[i] );
				currentOffset = Offsets[i] + Sizes[i];
			}

			Sizes[0] = GetTypeStackSize( types[0] );
			Offsets[0] = currentOffset;

			for( int i = 0; i < types.Length; i++ )
			{
				encoding.Append( EncodeType( types[i] ) );
				encoding.Append( Offsets[i] );
			}

			Encoding = encoding.ToString();
		}

		/// <summary>
		/// Initializes new instance of RuntimeMethodEncoding class with specified method signature information.
		/// </summary>
		/// <param name="method">Method signature to generate encoding from.</param>
		/// <param name="options">Encoding generation options.</param>
		public RuntimeMethodEncoding( MethodBase method, Options options )
			: this( GetEncoding( method, options ) )
		{
		}

		/// <summary>
		/// Initializes new instance of RuntimeMethodEncoding class with specified method signature information.
		/// </summary>
		/// <param name="method">Method signature to generate encoding from.</param>
		public RuntimeMethodEncoding( MethodBase method )
			: this( GetEncoding( method, Options.None ) )
		{
		}

		/// <summary>
		/// Computes size in bytes that will occupy instance of specified class in native stack.
		/// </summary>
		/// <param name="type">Type to compute size from.</param>
		/// <returns>Padded size of <paramref name="type"/> instance.</returns>
		public static int GetTypeStackSize( Type type )
		{
			if( type == null )
				return 0;

			if( type == typeof( string ) )
				return IntPtr.Size;

			var rawLength = type.IsByRef || type.IsPointer || type.IsArray ? IntPtr.Size : Marshal.SizeOf( type );

			if( BitConverter.IsLittleEndian )
				return ( rawLength + IntPtr.Size - 1 ) / IntPtr.Size * IntPtr.Size;

			return rawLength;
		}

		/// <summary>
		/// Implicit conversion from System.String to RuntimeMethodEncoding.
		/// </summary>
		/// <param name="value">Objective-C method encoding to create RuntimeMethodEncoding from.</param>
		/// <returns>RuntimeMethodEncoding initialized with <paramref name="value"/>.</returns>
		public static implicit operator RuntimeMethodEncoding( string value )
		{
			return new RuntimeMethodEncoding( value );
		}

		/// <summary>
		/// Returns string representation of current Objective-C method encoding.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return Encoding;
		}

		/// <summary>
		/// Adds <paramref name="listener"/> to EncodingTraceSource
		/// </summary>
		/// <param name="listener">Listener to add</param>
		public static void AddListener( NObjective.Tracing.TraceListener listener )
		{
			Tracer.AddListener( listener );
		}

		/// <summary>
		/// Removes <paramref name="listener"/> from EncodingTraceSource
		/// </summary>
		/// <param name="listener">Listener to remove</param>
		public static void RemoveListener( NObjective.Tracing.TraceListener listener )
		{
			Tracer.RemoveListener( listener );
		}

		/// <summary>
		/// Encoding creation options.
		/// </summary>
		[Flags]
		public enum Options
		{
			/// <summary>
			/// Normal
			/// </summary>
			None = 0,

			/// <summary>
			/// Is that method callable from unmanaged code
			/// </summary>
			TransitionMethod = 1,

			/// <summary>
			/// Strip IA32 exception parameters. For internal use only.
			/// </summary>
			StripExceptionParameters = 2
		}

		/// <summary>
		/// Creates encoding for exported method or constructor.
		/// </summary>
		/// <param name="method">MethodInfo or ConstructorInfo to get signature from</param>
		/// <param name="options">Options to produce encoding</param>
		/// <returns>String representation of encoding.</returns>
		public static string GetEncoding( MethodBase method, Options options )
		{
			IEnumerable<Type> parameters = new[] { method is MethodInfo ? ( ( MethodInfo ) method ).ReturnType : typeof( RuntimeObject ) };

			var actualArguments = method.GetParameters().Select( x => x.ParameterType );

			if( ( options & Options.StripExceptionParameters ) != 0 )
				actualArguments = actualArguments.Skip( 4 );

			if( ( options & Options.TransitionMethod ) == 0 )
				parameters = parameters.Concat( new[] { typeof( RuntimeObject ), typeof( Selector ) } );

			parameters = parameters.Concat( actualArguments );

			var result = new RuntimeMethodEncoding( parameters.ToArray() ).Encoding;

			Tracer.Information( "Generate encoding {0} for {1}", result, method );

			return result;
		}

		/// <summary>
		/// Encodes .NET type using Objective-C encoding scheme.
		/// from runtime.h:
		///  #define _C_ID       '@'
		///  #define _C_CLASS    '#'
		///  #define _C_SEL      ':'
		///  #define _C_CHR      'c'
		///  #define _C_UCHR     'C'
		///  #define _C_SHT      's'
		///  #define _C_USHT     'S'
		///  #define _C_INT      'i'
		///  #define _C_UINT     'I'
		///  #define _C_LNG      'l'
		///  #define _C_ULNG     'L'
		///  #define _C_LNG_LNG  'q'
		///  #define _C_ULNG_LNG 'Q'
		///  #define _C_FLT      'f'
		///  #define _C_DBL      'd'
		///  #define _C_BFLD     'b'
		///  #define _C_BOOL     'B'
		///  #define _C_VOID     'v'
		///  #define _C_UNDEF    '?'
		///  #define _C_PTR      '^'
		///  #define _C_CHARPTR  '*'
		///  #define _C_ATOM     '%'
		///  #define _C_ARY_B    '['
		///  #define _C_ARY_E    ']'
		///  #define _C_UNION_B  '('
		///  #define _C_UNION_E  ')'
		///  #define _C_STRUCT_B '{'
		///  #define _C_STRUCT_E '}'
		///  #define _C_VECTOR   '!'
		///  #define _C_CONST    'r'
		///  
		/// Additional modifiers:
		///  r	const
		///  n	in
		///  N	inout
		///  o	out
		///  O	bycopy
		///  R	byref
		///  V	oneway
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public unsafe static string EncodeType( Type type )
		{
			if( type == typeof( Runtime.StringProxy* ) || type == typeof( Runtime.ExceptionProxy* ) || type == typeof( Runtime.ObjectMark* ) )
				return "@";

			if( type == typeof( byte* ) )
				return "*";

			if( type.IsPointer )
				return "^" + EncodeType( type.GetElementType() );

			if( type == typeof( sbyte ) )
				return "c";
			if( type == typeof( byte ) )
				return "C";

			if( type == typeof( short ) )
				return "s";
			if( type == typeof( ushort ) )
				return "S";

			if( type == typeof( char ) )
				return "s";

			if( type == typeof( int ) )
				return "i";
			if( type == typeof( uint ) )
				return "I";

			if( type == typeof( long ) )
				return "q";
			if( type == typeof( ulong ) )
				return "Q";

			if( type == typeof( float ) )
				return "f";
			if( type == typeof( double ) )
				return "d";

			if( type == typeof( bool ) )
				return "B";

			if( type == typeof( void ) )
				return "v";

			if( type == typeof( Selector ) )
				return ":";
			if( type == typeof( IntPtr ) )
				return "^l";
			if( type.IsEnum )
				return "i";
			if( type == typeof( RuntimeObject ) )
				return "@";
			if( type == typeof( RuntimeClass ) )
				return "#";
			if( type.Namespace == "NObjective.Proxies" )
				return "@";
			if( type.IsValueType )
			{
				var structName = new StringBuilder();
				structName.AppendFormat( "{{{0}=", type.Name );

				foreach( var fieldInfo in type.GetFields( BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic ) )
					structName.Append( EncodeType( fieldInfo.FieldType ) );

				structName.Append( '}' );

				return structName.ToString();
			}
			return "@";
		}

		/// <summary>
		/// Transforms encoding identifier to .NET type.
		/// </summary>
		/// <param name="value">System.Char that represents encoded type.</param>
		/// <returns>.NET type corresponded to <paramref name="value"/>.</returns>
		public unsafe static Type DecodeType( char value )
		{
			switch( value )
			{
				case ':': return typeof( Selector );
				case 'c': return typeof( char );
				case 'C': return typeof( char );
				case 'i': return typeof( int );
				case 'I': return typeof( uint );
				case 's': return typeof( short );
				case 'S': return typeof( ushort );
				case 'l': return typeof( int );
				case 'L': return typeof( uint );
				case 'q': return typeof( long );
				case 'Q': return typeof( ulong );
				case 'd': return typeof( double );
				case 'f': return typeof( float );
				case 'B': return typeof( bool );
				case '*': return typeof( byte* );
				case 'v': return typeof( void );
				case '@': return typeof( RuntimeObject );
				case '^': return typeof( IntPtr );
				case 'r': return typeof( FormatException );
				case '#': return typeof( RuntimeClass );
				case '?': return null;
			}
			throw new ArgumentException( "Cannot decode " + value, "value" );
		}

		/// <summary>
		/// Create instance RuntimeMethodEncoding class from instance of Objective-C NSMethodSignature class.
		/// </summary>
		/// <param name="methodSignature">Objective-C NSMethodSignature class instance.</param>
		/// <returns>RuntimeMethodEncoding intialized from NSMethodSignature encoding.</returns>
		public static RuntimeMethodEncoding FromNSMethodSignature( RuntimeObject methodSignature )
		{
			if( methodSignature == RuntimeObject.Null )
				return null;

			var argumentsCount = methodSignature.InvokeUInt32( "numberOfArguments" );
			var signatureTypes = new Type[argumentsCount + 1];

			signatureTypes[0] = DecodeType( ( char ) Marshal.ReadByte( methodSignature.InvokeIntPtr( "methodReturnType" ) ) );

			for( int i = 0; i < argumentsCount; i++ )
				signatureTypes[i + 1] = DecodeType( ( char ) Marshal.ReadByte( methodSignature.InvokeIntPtr( "getArgumentTypeAtIndex:", i ) ) );

			var result = new RuntimeMethodEncoding( signatureTypes );

			Tracer.Information( "Generate encoding from NSSignature: {0}", result );

			return result;
		}
	}

	/// <summary>
	/// Each instance of RuntimeMethodEncoding class represents parsed property encoding string.
	/// </summary>
	public class RuntimePropertyEncoding
	{
		/// <summary>
		/// Initializes new instance of RuntimePropertyEncoding class with Objective-C property encoding.
		/// </summary>
		/// <param name="encoding">Objective-C property encoding</param>
		public RuntimePropertyEncoding( string encoding )
		{
			int index = 0;
			var buffer = new StringBuilder();

			while( index < encoding.Length )
			{
				while( encoding[index] == ' ' )
					index++;

				switch( encoding[index] )
				{
					case 'T':
						{
							var isQuoted = false;

							index++;

							if( encoding[index] == '{' )
							{
								index++;
								int bracesCount = 1;

								while( index < encoding.Length && bracesCount > 0 )
								{
									if( encoding[index] == '{' )
										bracesCount++;
									else if( encoding[index] == '}' )
										bracesCount--;

									index++;
								}

								break;
							}
							else
								PropertyType = RuntimeMethodEncoding.DecodeType( encoding[index++] );

							if( index < encoding.Length && encoding[index] == '"' )
							{
								isQuoted = true;
								index++;
							}

							buffer.Length = 0;
							while( index < encoding.Length && encoding[index] != ',' )
							{
								buffer.Append( encoding[index++] );

								if( isQuoted && encoding[index] == '"' )
								{
									index++;
									break;
								}
							}
						}
						break;

					case 'G':
						index++;

						buffer.Length = 0;
						while( index < encoding.Length && encoding[index] != ',' )
							buffer.Append( encoding[index++] );

						Getter = buffer.ToString();

						break;

					case 'S':
						index++;

						buffer.Length = 0;
						while( index < encoding.Length && encoding[index] != ',' )
							buffer.Append( encoding[index++] );

						Setter = buffer.ToString();

						break;

					case 'V':
						index++;

						buffer.Length = 0;
						while( index < encoding.Length && encoding[index] != ',' )
							buffer.Append( encoding[index++] );

						break;

					case 'P':
						index++;
						break;

					case 'D':
						index++;
						break;

					case 'C':
						IsCopy = true;
						index++;
						break;

					case 'R':
						IsReadonly = true;
						index++;
						break;

					case '&':
						IsRetain = true;
						index++;
						break;
				}

				if( index == encoding.Length )
					break;

				if( encoding[index] == ',' )
				{
					index++;
					continue;
				}

				Debugger.Break();
			}
		}

		/// <summary>
		/// Name of get method.
		/// </summary>
		public readonly string Getter;

		/// <summary>
		/// Name of set method.
		/// </summary>
		public readonly string Setter;

		/// <summary>
		/// Original encoding.
		/// </summary>
		public readonly string Encoding;

		/// <summary>
		/// Type of property.
		/// </summary>
		public readonly Type PropertyType;

		/// <summary>
		/// Is property readonly.
		/// </summary>
		public readonly bool IsReadonly;

		/// <summary>
		/// Is property copy.
		/// </summary>
		public readonly bool IsCopy;

		/// <summary>
		/// Is property retain.
		/// </summary>
		public readonly bool IsRetain;
	}
}
