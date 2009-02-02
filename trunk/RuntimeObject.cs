//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System;
using System.Runtime.InteropServices;

namespace NObjective
{
	/// <summary>
	/// Transparent proxy for Objective-C instances. It's analogous of Objective-C pointer to object (id).
	/// Refcount scheme should be avoided in favor of RuntimeObjectProxy. But if you need more performance with less overhead use that class.
	/// Refcount in such case can be performed manually:
	/// <code>
	/// private RuntimeObject _someProperty = RuntimeObject.Null;
	/// public RuntimeObject SomeProperty {
	///		get {
	///			return _someProperty;
	///		}
	///		set {
	///			Runtime.AutoreleseNativeObject( _someProperty );	// or Runtime.ReleaseNativeObject( _someProperty );
	///			_someProperty = value;
	///			Runtime.RetainNativeObject( _someProperty );
	///		}
	/// }
	/// </code>
	/// </summary>
	public struct RuntimeObject : IEquatable<RuntimeObject>
	{
		/// <summary>
		/// Null-pointer to object.
		/// </summary>
		public static readonly RuntimeObject Null = new RuntimeObject( IntPtr.Zero );

		/// <summary>
		/// Internal pointer to object.
		/// </summary>
		private readonly IntPtr _handle;

		/// <summary>
		/// Initializes new instance of RuntimeObject class with specified raw pointer to Objective-C object.
		/// </summary>
		/// <param name="handle">Pointer to Objective-C object.</param>
		public RuntimeObject( IntPtr handle )
		{
			_handle = handle;
		}

		/// <summary>
		/// Initializes new instance of RuntimeObject class with specified raw pointer to Objective-C object.
		/// </summary>
		/// <param name="pointer">Pointer to Objective-C object.</param>
		public unsafe RuntimeObject( void* pointer )
		{
			_handle = new IntPtr( pointer );
		}

		/// <summary>
		/// Returns class for current object.
		/// </summary>
		public unsafe RuntimeClass Class { get { return new RuntimeClass( ( IntPtr ) ( ( RuntimeV1Implementation.objc_class* ) _handle )->isa ); } }

		/// <summary>
		/// Implicit conversion to IntPtr.
		/// </summary>
		/// <param name="handle">RuntimeObject to convert.</param>
		/// <returns>IntPtr that represents raw pointer to Objective-C object.</returns>
		public static implicit operator IntPtr( RuntimeObject handle ) { return handle._handle; }

		/// <summary>
		/// Implicit conversion from System.String to RuntimeObject.
		/// </summary>
		/// <param name="string">String to convert.</param>
		/// <returns>Objective-C object that responds to some NSString's selectors.</returns>
		public static implicit operator RuntimeObject( string @string ) { return new RuntimeObject( Runtime.AutoreleaseNativeObject( Runtime.CreateStringProxy( @string ) ) ); }

		/// <summary>
		/// Indicates whether the current object reference is equal to another object reference.
		/// </summary>
		/// <param name="value1"></param>
		/// <param name="value2"></param>
		/// <returns></returns>
		public static bool operator ==( RuntimeObject value1, RuntimeObject value2 )
		{
			return value1._handle == value2._handle;
		}

		/// <summary>
		/// Indicates whether the current object reference is not equal to another object reference.
		/// </summary>
		/// <param name="value1"></param>
		/// <param name="value2"></param>
		/// <returns></returns>
		public static bool operator !=( RuntimeObject value1, RuntimeObject value2 )
		{
			return !( value1 == value2 );
		}

		/// <summary>
		/// Sends "retainCount" selector to this object. 
		/// </summary>
		public int RetainCount
		{
			get { return Runtime.SendMessage( this, Selectors.retainCount ).ToInt32(); }
		}

		/// <summary>
		/// Returns the hash code for this object. 
		/// </summary>
		/// <returns>A System.Int32 hash code.</returns>
		public override int GetHashCode() { return Runtime.SendMessage( _handle, Selectors.hash ).ToInt32(); }

		/// <summary>
		/// Determines whether this instance of RuntimeObject and a specified object, which must also be a RuntimeObject object, points to the same raw Objective-C object.
		/// </summary>
		/// <param name="value">A boxed instance of RuntimeObject to compare with this class.</param>
		/// <returns>True if <paramref name="value"/> is a RuntimeObject and it points to the same raw Objective-C object as this instance; False otherwise.</returns>
		public override bool Equals( object value )
		{
			var comapareTo = value as RuntimeObject?;

			if( comapareTo == null )
				return false;

			return _handle == comapareTo.Value._handle;
		}

		/// <summary>
		/// Checks that object can responds to specified selector.
		/// </summary>
		/// <param name="selector">Selector to check.</param>
		/// <returns>True if object able to responds to specified selector, False otherwise.</returns>
		public bool IsRespondsTo( Selector selector )
		{
			return Runtime.NativeMethods.class_respondsToSelector( Class, selector );
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
		/// Sends vararg message to receiver using superclass dispatch table to find method implementation.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>Deserialized result of objc_msgSendSuper</returns>
		public object SuperInvoke( Selector selector, params object[] arguments )
		{
			return Runtime.SuperInvoke( this, selector, arguments );
		}

		/// <summary>
		/// Sends vararg message to receiver using superclass dispatch table to find method implementation.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>Deserialized result of objc_msgSendSuper</returns>
		public object SuperInvokeFast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments )
		{
			return Runtime.SuperInvokeFast( this, selector, encoding, arguments );
		}

		/// <summary>
		/// Sends vararg message to receiver using superclass dispatch table to find method implementation.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>Raw value from objc_msgSendSuper</returns>
		public long SuperInvokeRaw( Selector selector, params object[] arguments )
		{
			return Runtime.SuperInvokeRaw( this, selector, arguments );
		}

		/// <summary>
		/// Sends vararg message to receiver using superclass dispatch table to find method implementation.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>Raw value from objc_msgSendSuper</returns>
		public long SuperInvokeRawFast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments )
		{
			return Runtime.SuperInvokeRawFast( this, selector, encoding, arguments );
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

		/// <summary>
		/// Sends vararg message to receiver using superclass dispatch table to find method implementation that returns structure.
		/// </summary>
		/// <typeparam name="T">Type of structure to retrieve.</typeparam>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>Structure filled by objc_msgSend_stret.</returns>
		public unsafe T SuperInvokeStruct<T>( Selector selector, params object[] arguments ) where T : struct
		{
			return Runtime.SuperInvokeStruct<T>( this, selector, arguments );
		}

		/// <summary>
		/// Retrieves string representation of object using "description" selector.
		/// </summary>
		/// <returns>[object description]</returns>
		public override string ToString() { return InvokeString( Selectors.description ); }

		/// <summary>
		/// Returns printable pointer value.
		/// </summary>
		public string Address
		{
			get { return _handle.ToString( "X8" ); }
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

		#region invocations with common return types for supercalls

		/// <summary>
		/// Sends vararg message to receiver and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.Int8 result</returns>
		public sbyte SuperInvokeInt8( Selector selector, params object[] arguments ) { return ( sbyte ) SuperInvokeRaw( selector, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		public sbyte SuperInvokeInt8Fast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return ( sbyte ) SuperInvokeRawFast( selector, encoding, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.Int16 result</returns>
		public short SuperInvokeInt16( Selector selector, params object[] arguments ) { return ( short ) SuperInvokeRaw( selector, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		public short SuperInvokeInt16Fast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return ( short ) SuperInvokeRawFast( selector, encoding, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.Int32 result</returns>
		public int SuperInvokeInt32( Selector selector, params object[] arguments ) { return ( int ) SuperInvokeRaw( selector, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		public int SuperInvokeInt32Fast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return ( int ) SuperInvokeRawFast( selector, encoding, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.Int64 result</returns>
		public long SuperInvokeInt64( Selector selector, params object[] arguments ) { return SuperInvokeRaw( selector, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		public long SuperInvokeInt64Fast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return SuperInvokeRawFast( selector, encoding, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.UInt8 result</returns>
		public byte SuperInvokeUInt8( Selector selector, params object[] arguments ) { return ( byte ) SuperInvokeRaw( selector, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		public byte SuperInvokeUInt8Fast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return ( byte ) SuperInvokeRawFast( selector, encoding, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.UInt16 result</returns>
		public ushort SuperInvokeUInt16( Selector selector, params object[] arguments ) { return ( ushort ) SuperInvokeRaw( selector, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		public ushort SuperInvokeUInt16Fast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return ( ushort ) SuperInvokeRawFast( selector, encoding, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.UInt32 result</returns>
		public uint SuperInvokeUInt32( Selector selector, params object[] arguments ) { return ( uint ) SuperInvokeRaw( selector, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		public uint SuperInvokeUInt32Fast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return ( uint ) SuperInvokeRawFast( selector, encoding, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.UInt64 result</returns>
		public ulong SuperInvokeUInt64( Selector selector, params object[] arguments ) { return ( ulong ) SuperInvokeRaw( selector, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		public ulong SuperInvokeUInt64Fast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return ( ulong ) SuperInvokeRawFast( selector, encoding, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.Char result</returns>
		public char SuperInvokeChar( Selector selector, params object[] arguments ) { return ( char ) SuperInvokeRaw( selector, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		public char SuperInvokeCharFast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return ( char ) SuperInvokeRawFast( selector, encoding, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.Single result</returns>
		public float SuperInvokeFloat( Selector selector, params object[] arguments ) { return ( float ) Convert.ToDouble( SuperInvoke( selector, arguments ) ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		public float SuperInvokeFloatFast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return ( float ) Convert.ToDouble( SuperInvokeFast( selector, encoding, arguments ) ); }

		/// <summary>
		/// Sends vararg message to receiver and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.Double result</returns>
		public double SuperInvokeDouble( Selector selector, params object[] arguments ) { return Convert.ToDouble( SuperInvoke( selector, arguments ) ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		public double SuperInvokeDoubleFast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return Convert.ToDouble( SuperInvokeFast( selector, encoding, arguments ) ); }

		/// <summary>
		/// Sends vararg message to receiver and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.Boolean result</returns>
		public bool SuperInvokeBool( Selector selector, params object[] arguments ) { return ( ( int ) SuperInvokeRaw( selector, arguments ) ) == 0 ? false : true; }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		public bool SuperInvokeBoolFast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return ( ( int ) SuperInvokeRawFast( selector, encoding, arguments ) ) == 0 ? false : true; }

		/// <summary>
		/// Sends vararg message to receiver and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>Selector result</returns>
		public Selector SuperInvokeSelector( Selector selector, params object[] arguments ) { return new Selector( Runtime.TruncateUnnecessaryAddressBits( SuperInvokeRaw( selector, arguments ) ) ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		public Selector SuperInvokeSelectorFast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return new Selector( Runtime.TruncateUnnecessaryAddressBits( SuperInvokeRawFast( selector, encoding, arguments ) ) ); }

		/// <summary>
		/// Sends vararg message to receiver and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.String result</returns>
		public string SuperInvokeString( Selector selector, params object[] arguments ) { return ( string ) SuperInvoke( selector, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		public string SuperInvokeStringFast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return ( string ) SuperInvokeFast( selector, encoding, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>System.Int8 result</returns>
		public IntPtr SuperInvokeIntPtr( Selector selector, params object[] arguments ) { return Runtime.TruncateUnnecessaryAddressBits( SuperInvokeRaw( selector, arguments ) ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		public IntPtr SuperInvokeIntPtrFast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return Runtime.TruncateUnnecessaryAddressBits( SuperInvokeRawFast( selector, encoding, arguments ) ); }

		/// <summary>
		/// Sends vararg message to receiver and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>RuntimeClass result</returns>
		public RuntimeClass SuperInvokeClass( Selector selector, params object[] arguments ) { return new RuntimeClass( SuperInvokeIntPtr( selector, arguments ) ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		public RuntimeClass SuperInvokeClassFast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return new RuntimeClass( SuperInvokeIntPtrFast( selector, encoding, arguments ) ); }

		/// <summary>
		/// Sends vararg message to receiver and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>RuntimeObject result</returns>
		public RuntimeObject SuperInvokeObject( Selector selector, params object[] arguments ) { return new RuntimeObject( SuperInvokeIntPtr( selector, arguments ) ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		public RuntimeObject SuperInvokeObjectFast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { return new RuntimeObject( SuperInvokeIntPtrFast( selector, encoding, arguments ) ); }

		/// <summary>
		/// Sends vararg message to receiver and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		public void SuperInvokeVoid( Selector selector, params object[] arguments ) { SuperInvokeIntPtr( selector, arguments ); }

		/// <summary>
		/// Sends vararg message to receiver using cached method's encoding to perform better and forcing to find method implementation in superclass dispatch table.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="encoding">Parsed encoding string used to properly convert/marshal primitive types.</param>
		/// <param name="arguments">Arguments to pass.</param>
		public void SuperInvokeVoidFast( Selector selector, RuntimeMethodEncoding encoding, params object[] arguments ) { SuperInvokeIntPtrFast( selector, encoding, arguments ); }

		#endregion

		#region IEquatable<RuntimeObject> Members

		/// <summary>
		/// Indicates whether the current object reference is equal to another object reference.
		/// </summary>
		/// <param name="other">An Objective-C object to compare with this object.</param>
		/// <returns>True if the current object reference is equal to the <paramref name="other"/> parameter; otherwise, false.</returns>
		public bool Equals( RuntimeObject other )
		{
			return _handle == other._handle;
		}

		#endregion
	}
}
