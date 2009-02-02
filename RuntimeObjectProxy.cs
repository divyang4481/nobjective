//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System;

namespace NObjective
{
	/// <summary>
	/// RuntimeObjectProxy retains object refcount and releases it while collected by GC. 
	/// Also can be used for IDisposable pattern. 
	/// </summary>
	public sealed class RuntimeObjectProxy : IDisposable, IEquatable<RuntimeObjectProxy>
	{
		/// <summary>
		/// Internal object handle.
		/// </summary>
		private RuntimeObject _handle;

		/// <summary>
		/// Initializes new instance of RuntimeObjectProxy and attaches it to existing Objective-C object retaining it's refcount.
		/// </summary>
		/// <param name="object">Objective-C object to attach.</param>
		public RuntimeObjectProxy( RuntimeObject @object )
			: this( @object, true )
		{
		}

		/// <summary>
		/// Initializes new instance of RuntimeObjectProxy and attaches it to existing Objective-C object.
		/// </summary>
		/// <param name="object">Objective-C object to attach.</param>
		/// <param name="increaseReferencesCount">True if object's reference count should be retained; False otherwise.</param>
		public RuntimeObjectProxy( RuntimeObject @object, bool increaseReferencesCount )
		{
			_handle = @object;

			if( increaseReferencesCount )
				Runtime.RetainNativeObject( _handle );
		}

		/// <summary>
		/// 
		/// </summary>
		~RuntimeObjectProxy()
		{
			Dispose();
		}

		/// <summary>
		/// Retrieves internal object handle
		/// </summary>
		public RuntimeObject Handle
		{
			get { return _handle; }
			set { SoftAttach( value, true ); }
		}

		/// <summary>
		/// Attaches current proxy to to existing Objective-C object using following steps:
		/// 1) send "release" to old object.
		/// 2) send "retain" to new object.
		/// </summary>
		/// <param name="object">Object to attach</param>
		/// <param name="increaseReferencesCount">True if object's reference count should be retained; False otherwise.</param>
		public void Attach( RuntimeObject @object, bool increaseReferencesCount )
		{
			if( @object == _handle )
				throw new ArgumentException( "@object", "Can't attach to already attached object." );

			Runtime.ReleaseNativeObject( _handle );
			_handle = @object;

			if( increaseReferencesCount )
				Runtime.RetainNativeObject( _handle );
		}

		/// <summary>
		/// Attaches current proxy to to existing Objective-C object using following steps:
		/// 1) send "autorelease" to old object.
		/// 2) send "retain" to new object.
		/// </summary>
		/// <param name="object">Object to attach</param>
		/// <param name="increaseReferencesCount">True if object's reference count should be retained; False otherwise.</param>
		public void SoftAttach( RuntimeObject @object, bool increaseReferencesCount )
		{
			if( @object == _handle )
				throw new ArgumentException( "@object", "Can't attach to already attached object." );

			Runtime.AutoreleaseNativeObject( _handle );
			_handle = @object;

			if( increaseReferencesCount )
				Runtime.RetainNativeObject( _handle );
		}

		/// <summary>
		/// Returns class for current object.
		/// </summary>
		public RuntimeClass Class { get { return _handle.Class; } }

		/// <summary>
		/// Checks that object can responds to specified selector.
		/// </summary>
		/// <param name="selector">Selector to check.</param>
		/// <returns>True if object able to responds to specified selector, False otherwise.</returns>
		public bool IsRespondsTo( Selector selector )
		{
			return _handle.IsRespondsTo( selector );
		}

		/// <summary>
		/// Sends vararg message to receiver.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>Deserialized result of objc_msgSend</returns>
		public object Invoke( Selector selector, params object[] arguments )
		{
			return _handle.Invoke( selector, arguments );
		}

		/// <summary>
		/// Returns printable pointer value.
		/// </summary>
		public string Address
		{
			get { return _handle.Address; }
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
			return _handle.InvokeFast( selector, encoding, arguments );
		}

		/// <summary>
		/// Sends vararg message to receiver returning raw value from objc_msgSend.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>Raw value from objc_msgSend</returns>
		public long InvokeRaw( Selector selector, params object[] arguments )
		{
			return _handle.InvokeRaw( selector, arguments );
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
			return _handle.InvokeRawFast( selector, encoding, arguments );
		}

		/// <summary>
		/// Sends vararg message to receiver using superclass dispatch table to find method implementation.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>Deserialized result of objc_msgSendSuper</returns>
		public object SuperInvoke( Selector selector, params object[] arguments )
		{
			return _handle.SuperInvoke( selector, arguments );
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
			return _handle.SuperInvokeFast( selector, encoding, arguments );
		}

		/// <summary>
		/// Sends vararg message to receiver using superclass dispatch table to find method implementation.
		/// </summary>
		/// <param name="selector">Selector of method to invoke.</param>
		/// <param name="arguments">Arguments to pass.</param>
		/// <returns>Raw value from objc_msgSendSuper</returns>
		public long SuperInvokeRaw( Selector selector, params object[] arguments )
		{
			return _handle.SuperInvokeRaw( selector, arguments );
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
			return _handle.SuperInvokeRawFast( selector, encoding, arguments );
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
			return _handle.InvokeStruct<T>( selector, arguments );
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
			return _handle.SuperInvokeStruct<T>( selector, arguments );
		}

		/// <summary>
		/// Implicit conversion to IntPtr.
		/// </summary>
		/// <param name="value">RuntimeObjectProxy to convert.</param>
		/// <returns>IntPtr that represents raw pointer to Objective-C object.</returns>
		public static implicit operator IntPtr( RuntimeObjectProxy value ) { return value.Handle; }

		/// <summary>
		/// Implicit conversion to RuntimeObject.
		/// </summary>
		/// <param name="value">RuntimeObjectProxy to convert.</param>
		/// <returns>Value of Handle property.</returns>
		public static implicit operator RuntimeObject( RuntimeObjectProxy value ) { return value.Handle; }

		/// <summary>
		/// Retrieves string representation of object using "description" selector.
		/// </summary>
		/// <returns>[object description]</returns>
		public override string ToString() { return Handle.ToString(); }

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

		#region IDisposable Members

		/// <summary>
		/// 
		/// </summary>
		public void Dispose()
		{
			Runtime.ReleaseNativeObject( _handle );

			_handle = RuntimeObject.Null;
			GC.SuppressFinalize( this );
		}

		#endregion

		#region IEquatable<RuntimeObjectProxy> Members

		/// <summary>
		/// 
		/// </summary>
		/// <param name="other"></param>
		/// <returns></returns>
		public bool Equals( RuntimeObjectProxy other )
		{
			return Handle == other.Handle;
		}

		#endregion
	}
}
