//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;

namespace NObjective
{
	/// <summary>
	/// Transparent proxy for Objective-C classes. It's analogous of Objective-C pointer to class.
	/// </summary>
	public struct RuntimeClass : IEquatable<RuntimeClass>
	{
		/// <summary>
		/// Null-pointed instance of RuntimeClass class.
		/// </summary>
		public static readonly RuntimeClass Null = new RuntimeClass( IntPtr.Zero );

		/// <summary>
		/// Internal raw pointer to Objective-C class object.
		/// </summary>
		private readonly IntPtr _handle;

		/// <summary>
		/// Load Runtime to ensure that all autoregistered classes will be exported
		/// </summary>
		private static readonly string RuntimeLibrary = Runtime.RuntimeLibrary;

		/// <summary>
		/// Initializes new instance of RuntimeClass struct with specified pointer to Objective-C class object.
		/// </summary>
		/// <param name="handle">Pointer to Objective-C class.</param>
		public RuntimeClass( IntPtr handle )
		{
			_handle = handle;
		}

		/// <summary>
		/// Initializes new instance of RuntimeClass struct with specified pointer to Objective-C class object.
		/// </summary>
		/// <param name="pointer">Pointer to Objective-C class.</param>
		public unsafe RuntimeClass( void* pointer )
		{
			_handle = new IntPtr( pointer );
		}

		/// <summary>
		/// Initializes new instance of RuntimeClass struct with specified Objective-C class name.
		/// </summary>
		/// <param name="name">Class name.</param>
		public RuntimeClass( string name )
		{
			_handle = Runtime.NativeMethods.objc_getClass( name );
		}

		/// <summary>
		/// Retrieves hierarchy of base classes for current class.
		/// </summary>
		public IEnumerable<RuntimeClass> BaseHierarchy
		{
			get
			{
				var current = this;

				while( current != RuntimeClass.Null )
				{
					yield return current;

					current = current.BaseClass;
				}
			}
		}

		/// <summary>
		/// Checks that current class is <paramref name="baseClass"/> or derived from it.
		/// </summary>
		/// <param name="baseClass">Base class to check.</param>
		/// <returns>True if baseClass equals current or appears in base hierarchy.</returns>
		public bool IsSubclassOf( RuntimeClass baseClass )
		{
			var current = this;

			while( current != RuntimeClass.Null )
			{
				if( current == baseClass )
					return true;

				current = current.BaseClass;
			}

			return false;
		}

		/// <summary>
		/// Retrieves all Objective-C classes that registered in Objective-C runtime.
		/// </summary>
		/// <returns>Registered classes</returns>
		public unsafe static RuntimeClass[] GetAllClasses()
		{
			var classesCount = Runtime.NativeMethods.objc_getClassList( null, 0 );
			var handles = new RuntimeClass[classesCount];

			fixed( RuntimeClass* nativeHandles = &handles[0] )
				Runtime.NativeMethods.objc_getClassList( ( IntPtr* ) nativeHandles, classesCount );

			return handles;
		}

		/// <summary>
		/// Implicit conversion to raw pointer to Objective-C class object.
		/// </summary>
		/// <param name="class">RuntimeClass to convert.</param>
		/// <returns>Raw pointer to Objective-C class object</returns>
		public static implicit operator IntPtr( RuntimeClass @class ) { return @class._handle; }

		/// <summary>
		/// Implicit conversion from string to RuntimeClass.
		/// </summary>
		/// <param name="class">Class name to create.</param>
		/// <returns>Registered RuntimeClass with <paramref name="class"/> name.</returns>
		public static implicit operator RuntimeClass( string @class ) { return new RuntimeClass( @class ); }

		/// <summary>
		/// Indicates that two RuntimeClass instances points to same raw object.
		/// </summary>
		/// <param name="class1">First value to compare.</param>
		/// <param name="class2">Second value to compare.</param>
		/// <returns>True if <paramref name="class1"/> and <paramref name="class2"/> points to same object; False otherwise.</returns>
		public static bool operator ==( RuntimeClass class1, RuntimeClass class2 ) { return class1._handle == class2._handle; }

		/// <summary>
		/// Indicates that two RuntimeClass instances points to different raw objects.
		/// </summary>
		/// <param name="class1">First value to compare.</param>
		/// <param name="class2">Second value to compare.</param>
		/// <returns>True if <paramref name="class1"/> and <paramref name="class2"/> points to different objects; False otherwise.</returns>
		public static bool operator !=( RuntimeClass class1, RuntimeClass class2 ) { return class1._handle != class2._handle; }

		/// <summary>
		/// Determines whether this instance of RuntimeClass and a specified object, which must also be a RuntimeClass object, points to the same raw Objective-C class object.
		/// </summary>
		/// <param name="value">An System.Object to compare.</param>
		/// <returns>True if <paramref name="value"/> is a RuntimeClass and it points to the same raw Objective-C class object as this instance; False otherwise.</returns>
		public override bool Equals( object value )
		{
			var comapareTo = value as RuntimeClass?;

			if( comapareTo == null )
				return false;

			return _handle == comapareTo.Value._handle;
		}

		/// <summary>
		/// Returns the hash code for this class.
		/// </summary>
		/// <returns>A System.Int32 hash code.</returns>
		public override int GetHashCode() { return ( int ) _handle; }

		/// <summary>
		/// Retieves all metadata that describes that class.
		/// </summary>
		/// <returns>The string representation of the value of this instance.</returns>
		public override string ToString()
		{
			var result = new StringBuilder();
			var adoptedProtocols = GetAdoptedProtocols();

			result.AppendFormat( "{0} {1} : {2}{5}, size {3}, at {4}", IsMetaClass ? "metaclass" : "class", Name, BaseClass.Name, Size, Path.GetFileName( DeclaringImage ) ?? "$dynamically_generated$", adoptedProtocols.Length != 0 ? " <" + string.Join( ", ", adoptedProtocols.Select( x => x.Name ).ToArray() ) + ">" : "" );
			result.AppendLine();
			result.AppendLine( "\tMethods:" );

			foreach( var method in Methods )
			{
				result.AppendFormat( "\t\t{0}, TypeEncoding = {1}, at {2}", method.Name, method.Encoding, Path.GetFileName( method.DeclaringImage ) ?? "$dynamically_generated$" );
				result.AppendLine();
			}

			result.AppendLine( "\tVariables:" );
			foreach( var variable in Variables )
			{
				result.AppendFormat( "\t\t{0}", variable );
				result.AppendLine();
			}

			result.AppendLine( "\tProperties:" );
			foreach( var property in Properties )
			{
				result.AppendFormat( "\t\t{0}", property );
				result.AppendLine();
			}

			return result.ToString();
		}

		/// <summary>
		/// Returns the name of a class.
		/// </summary>
		public string Name
		{
			get { return Runtime.CompatibilityLayer.class_getName( this ); }
		}

		/// <summary>
		/// Returns the version number of a class definition.
		/// You can use the version number of the class definition to provide versioning of the interface that your class represents to other classes.
		/// This is especially useful for object serialization, where it is important to recognize changes to the layout of the instance variables in different class-definition versions.
		/// </summary>
		public int Version
		{
			get { return Runtime.NativeMethods.class_getVersion( this ); }
		}

		/// <summary>
		/// Returns the superclass of this class.
		/// </summary>
		public unsafe RuntimeClass BaseClass
		{
			get { return new RuntimeClass( ( IntPtr ) ( ( RuntimeV1Implementation.objc_class* ) _handle )->super_class ); }
		}

		/// <summary>
		/// Returns the metaclass of this class.
		/// </summary>
		public unsafe RuntimeClass MetaClass
		{
			get { return new RuntimeClass( ( IntPtr ) ( ( RuntimeV1Implementation.objc_class* ) _handle )->isa ); }
		}

		/// <summary>
		/// Checks that class is arbitrary class or metaclass.
		/// </summary>
		public bool IsMetaClass
		{
			get { return Runtime.CompatibilityLayer.class_isMetaClass( this ); }
		}

		/// <summary>
		/// Checks that class adopted specified protocol.
		/// </summary>
		/// <param name="protocol">Protocol to check.</param>
		/// <returns>True if class adopted specified protocol, False otherwise.</returns>
		public bool IsConformsTo( RuntimeProtocol protocol )
		{
			return Runtime.NativeMethods.class_conformsToProtocol( this, protocol );
		}

		/// <summary>
		/// Name of image where class was defined.
		/// </summary>
		public string DeclaringImage
		{
			get { return Runtime.CompatibilityLayer.class_getImageName( this ); }
		}

		/// <summary>
		/// Retrieves all protocols adopted by that class.
		/// </summary>
		/// <returns>Adopted protocols</returns>
		public unsafe RuntimeProtocol[] GetAdoptedProtocols()
		{
			return Runtime.CompatibilityLayer.class_copyProtocolList( this );
		}

		/// <summary>
		/// Creates object which contains in autorelease pool.
		/// </summary>
		/// <returns>[[class alloc] autorelease]</returns>
		public RuntimeObject CreateInstance()
		{
			return new RuntimeObject( Runtime.SendMessage( CreateRawInstance(), Selectors.autorelease ) );
		}

		/// <summary>
		/// Creates object which must be manually released.
		/// </summary>
		/// <returns>[class alloc]</returns>
		public RuntimeObject CreateRawInstance()
		{
			var handle = Runtime.SendMessage( _handle, Selectors.alloc );

			Runtime.Tracer.Information( "Create instance of {0}: {1}", Name, handle.ToString( "X8" ) );

			return new RuntimeObject( handle );
		}

		/// <summary>
		/// Creates object which will be released using IDisposable.Dispose.
		/// </summary>
		/// <returns></returns>
		public RuntimeObjectProxy CreateProxyInstance()
		{
			return new RuntimeObjectProxy( CreateRawInstance(), false );
		}

		/// <summary>
		/// Creates object which contains in autorelease pool.
		/// </summary>
		/// <param name="selector"></param>
		/// <param name="parameters"></param>
		/// <returns>[[[class alloc] selector:parameters] autorelease]</returns>
		public RuntimeObject CreateInstance( Selector selector, params object[] parameters )
		{
			var result = CreateRawInstance().InvokeObject( selector, parameters );

			Runtime.SendMessage( result, Selectors.autorelease );

			return result;
		}

		/// <summary>
		/// Creates object which must be manually released.
		/// </summary>
		/// <param name="selector"></param>
		/// <param name="parameters"></param>
		/// <returns>[[class alloc] selector:parameters]</returns>
		public RuntimeObject CreateRawInstance( Selector selector, params object[] parameters )
		{
			return CreateRawInstance().InvokeObject( selector, parameters );
		}

		/// <summary>
		/// Creates object which will be released using IDisposable.Dispose.
		/// </summary>
		/// <param name="selector"></param>
		/// <param name="parameters"></param>
		/// <returns></returns>
		public RuntimeObjectProxy CreateProxyInstance( Selector selector, params object[] parameters )
		{
			return new RuntimeObjectProxy( CreateRawInstance( selector, parameters ), false );
		}

		/// <summary>
		/// Retirieves all methods.
		/// </summary>
		public RuntimeMethod[] Methods
		{
			get
			{
				return Runtime.CompatibilityLayer.class_copyMethodList( this );
			}
		}

		/// <summary>
		/// Retrieves all ivars.
		/// </summary>
		public RuntimeVariable[] Variables
		{
			get
			{
				return Runtime.CompatibilityLayer.class_copyIvarList( this );
			}
		}

		/// <summary>
		/// Retrieves all properties.
		/// </summary>
		public RuntimeProperty[] Properties
		{
			get
			{
				return Runtime.CompatibilityLayer.class_copyPropertyList( this );
			}
		}

		/// <summary>
		/// Returns printable pointer value.
		/// </summary>
		public string Address
		{
			get { return _handle.ToString( "X8" ); }
		}

		/// <summary>
		/// Returns instance size.
		/// </summary>
		public uint Size { get { return Runtime.CompatibilityLayer.class_getInstanceSize( this ); } }

		/// <summary>
		/// Checks that class can responds to specified selector.
		/// </summary>
		/// <param name="selector">Selector to check.</param>
		/// <returns>True if class able to responds to specified selector, False otherwise.</returns>
		public bool IsRespondsTo( Selector selector )
		{
			return Runtime.NativeMethods.class_respondsToSelector( MetaClass, selector );
		}

		/// <summary>
		/// Sends vararg message to receiver.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>Deserialized result of objc_msgSend</returns>
		public object Invoke( Selector selector, params object[] arguments )
		{
			return Runtime.Invoke( this, selector, arguments );
		}

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>Deserialized result of objc_msgSend</returns>
		public object InvokeFast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments )
		{
			return Runtime.InvokeFast( this, selector, encoding, arguments );
		}

		/// <summary>
		/// Sends vararg message to receiver returning raw value from objc_msgSend.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>Raw value from objc_msgSend</returns>
		public long InvokeRaw( Selector selector, params object[] arguments )
		{
			return Runtime.InvokeRaw( this, selector, arguments );
		}

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better returning raw value from objc_msgSend.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>Raw value from objc_msgSend</returns>
		public long InvokeRawFast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments )
		{
			return Runtime.InvokeRawFast( this, selector, encoding, arguments );
		}

		/// <summary>
		/// Sends vararg message to receiver that returns structure.
		/// </summary>
		/// <typeparam name="T">Type of structure to retrieve.</typeparam>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>Structure filled by objc_msgSend_stret.</returns>
		public unsafe T InvokeStruct<T>( Selector selector, params object[] arguments ) where T : struct
		{
			return Runtime.InvokeStruct<T>( this, selector, arguments );
		}

		#region invocations with common return types

		/// <summary>
		/// Sends vararg message to receiver.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.Int8 result</returns>
		public sbyte InvokeInt8( Selector selector, params object[] arguments ) { return ( sbyte ) InvokeRaw( selector, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.Int8 result</returns>
		public sbyte InvokeInt8Fast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return ( sbyte ) InvokeRawFast( selector, encoding, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.Int16 result</returns>
		public short InvokeInt16( Selector selector, params object[] arguments ) { return ( short ) InvokeRaw( selector, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.Int16 result</returns>
		public short InvokeInt16Fast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return ( short ) InvokeRawFast( selector, encoding, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.Int32 result</returns>
		public int InvokeInt32( Selector selector, params object[] arguments ) { return ( int ) InvokeRaw( selector, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.Int32 result</returns>
		public int InvokeInt32Fast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return ( int ) InvokeRawFast( selector, encoding, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.Int64 result</returns>
		public long InvokeInt64( Selector selector, params object[] arguments ) { return InvokeRaw( selector, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.Int64 result</returns>
		public long InvokeInt64Fast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return InvokeRawFast( selector, encoding, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.UInt8 result</returns>
		public byte InvokeUInt8( Selector selector, params object[] arguments ) { return ( byte ) InvokeRaw( selector, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.UInt8 result</returns>
		public byte InvokeUInt8Fast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return ( byte ) InvokeRawFast( selector, encoding, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.UInt16 result</returns>
		public ushort InvokeUInt16( Selector selector, params object[] arguments ) { return ( ushort ) InvokeRaw( selector, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.UInt16 result</returns>
		public ushort InvokeUInt16Fast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return ( ushort ) InvokeRawFast( selector, encoding, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.UInt32 result</returns>
		public uint InvokeUInt32( Selector selector, params object[] arguments ) { return ( uint ) InvokeRaw( selector, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.UInt32 result</returns>
		public uint InvokeUInt32Fast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return ( uint ) InvokeRawFast( selector, encoding, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.UInt64 result</returns>
		public ulong InvokeUInt64( Selector selector, params object[] arguments ) { return ( ulong ) InvokeRaw( selector, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.UInt64 result</returns>
		public ulong InvokeUInt64Fast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return ( ulong ) InvokeRawFast( selector, encoding, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.Char result</returns>
		public char InvokeChar( Selector selector, params object[] arguments ) { return ( char ) InvokeRaw( selector, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.Char result</returns>
		public char InvokeCharFast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return ( char ) InvokeRawFast( selector, encoding, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.Single result</returns>
		public float InvokeFloat( Selector selector, params object[] arguments ) { return ( float ) Convert.ToDouble( Invoke( selector, arguments ) ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.Single result</returns>
		public float InvokeFloatFast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return ( float ) Convert.ToDouble( InvokeFast( selector, encoding, arguments ) ); }

		/// <summary>
		/// Sends vararg message to receiver.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.Double result</returns>
		public double InvokeDouble( Selector selector, params object[] arguments ) { return Convert.ToDouble( Invoke( selector, arguments ) ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.Double result</returns>
		public double InvokeDoubleFast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return Convert.ToDouble( InvokeFast( selector, encoding, arguments ) ); }

		/// <summary>
		/// Sends vararg message to receiver.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.Boolean result</returns>
		public bool InvokeBool( Selector selector, params object[] arguments ) { return ( ( int ) InvokeRaw( selector, arguments ) ) == 0 ? false : true; }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.Boolean result</returns>
		public bool InvokeBoolFast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return ( ( int ) InvokeRawFast( selector, encoding, arguments ) ) == 0 ? false : true; }

		/// <summary>
		/// Sends vararg message to receiver.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>Selector result</returns>
		public Selector InvokeSelector( Selector selector, params object[] arguments ) { return new Selector( Runtime.TruncateUnnecessaryAddressBits( InvokeRaw( selector, arguments ) ) ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>Selector result</returns>
		public Selector InvokeSelectorFast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return new Selector( Runtime.TruncateUnnecessaryAddressBits( InvokeRawFast( selector, encoding, arguments ) ) ); }

		/// <summary>
		/// Sends vararg message to receiver.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.String result</returns>
		public string InvokeString( Selector selector, params object[] arguments ) { return ( string ) Invoke( selector, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.String result</returns>
		public string InvokeStringFast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return ( string ) InvokeFast( selector, encoding, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.IntPtr result</returns>
		public IntPtr InvokeIntPtr( Selector selector, params object[] arguments ) { return Runtime.TruncateUnnecessaryAddressBits( InvokeRaw( selector, arguments ) ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>IntPtr result</returns>
		public IntPtr InvokeIntPtrFast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return Runtime.TruncateUnnecessaryAddressBits( InvokeRawFast( selector, encoding, arguments ) ); }

		/// <summary>
		/// Sends vararg message to receiver.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>RuntimeClass result</returns>
		public RuntimeClass InvokeClass( Selector selector, params object[] arguments ) { return new RuntimeClass( InvokeIntPtr( selector, arguments ) ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>RuntimeClass result</returns>
		public RuntimeClass InvokeClassFast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return new RuntimeClass( InvokeIntPtrFast( selector, encoding, arguments ) ); }

		/// <summary>
		/// Sends vararg message to receiver.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>RuntimeObject result</returns>
		public RuntimeObject InvokeObject( Selector selector, params object[] arguments ) { return new RuntimeObject( InvokeIntPtr( selector, arguments ) ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>RuntimeObject result</returns>
		public RuntimeObject InvokeObjectFast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return new RuntimeObject( InvokeIntPtrFast( selector, encoding, arguments ) ); }

		/// <summary>
		/// Sends vararg message to receiver.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		public void InvokeVoid( Selector selector, params object[] arguments ) { InvokeIntPtr( selector, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		public void InvokeVoidFast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { InvokeIntPtrFast( selector, encoding, arguments ); }

		#endregion

		#region IEquatable<RuntimeClass> Members

		/// <summary>
		/// Indicates whether the current RuntimeClass instance is equal to another RuntimeClass instance.
		/// </summary>
		/// <param name="other">An Objective-C class to compare with this class.</param>
		/// <returns>True if the current class is equal to the <paramref name="other"/> parameter; otherwise, false.</returns>
		public bool Equals( RuntimeClass other )
		{
			return _handle == other._handle;
		}

		#endregion
	}
}
