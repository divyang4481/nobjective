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
	/// Represents Objective-C method.
	/// </summary>
	public struct RuntimeMethod : IEquatable<RuntimeMethod>
	{
		/// <summary>
		/// Null-pointed RuntimeMethod class instance.
		/// </summary>
		public static readonly RuntimeMethod Null = new RuntimeMethod( IntPtr.Zero );

		/// <summary>
		/// Internal raw pointer to Objective-C method object.
		/// </summary>
		private readonly IntPtr _handle;

		/// <summary>
		/// Initializes new RuntimeMethod class instance with specified raw pointer to Objective-C method.
		/// </summary>
		/// <param name="handle">Raw pointer to Objective-C method</param>
		public RuntimeMethod( IntPtr handle )
		{
			_handle = handle;
		}

		/// <summary>
		/// Initializes new RuntimeMethod class instance with specified raw pointer to Objective-C method.
		/// </summary>
		/// <param name="pointer">Raw pointer to Objective-C method</param>
		public unsafe RuntimeMethod( void* pointer )
		{
			_handle = new IntPtr( pointer );
		}

		/// <summary>
		/// Initializes new RuntimeMethod class instance with specified method name.
		/// </summary>
		/// <param name="class">Class to search method in.</param>
		/// <param name="selector">Selector of method to search.</param>
		public RuntimeMethod( RuntimeClass @class, Selector selector )
		{
			_handle = Runtime.NativeMethods.class_getInstanceMethod( @class, selector );
		}
		
		/// <summary>
		/// Initializes new RuntimeMethod class instance with specified method name.
		/// </summary>
		/// <param name="object">Object to search method in.</param>
		/// <param name="selector">Selector of method to search.</param>
		public RuntimeMethod( RuntimeObject @object, Selector selector )
			: this( @object.Class, selector )
		{
		}

		/// <summary>
		/// Raw pointer to Objective-C method object.
		/// </summary>
		public IntPtr Handle
		{
			get { return _handle; }
		}

		/// <summary>
		/// Name of method.
		/// </summary>
		public string Name
		{
			get { return Runtime.CompatibilityLayer.method_getName( this ).Name; }
		}

		/// <summary>
		/// Appropriate selector.
		/// </summary>
		public Selector Selector
		{
			get { return Runtime.CompatibilityLayer.method_getName( this ); }
		}

		/// <summary>
		/// String that encodes all parameter types and their stack layout and return type.
		/// </summary>
		public string Encoding
		{
			get { return Runtime.CompatibilityLayer.method_getTypeEncoding( this ); }
		}

		/// <summary>
		/// Indicates that two instances of RuntimeMethod class points to same raw Objective-C method.
		/// </summary>
		/// <param name="value1">First value to compare.</param>
		/// <param name="value2">Second value to compare.</param>
		/// <returns>True if <paramref name="value1"/> and <paramref name="value2"/> points to same raw Objective-C method; False otherwise.</returns>
		public static bool operator ==( RuntimeMethod value1, RuntimeMethod value2 )
		{
			return value1._handle == value2._handle;
		}

		/// <summary>
		/// Indicates that two instances of RuntimeMethod class points to different raw Objective-C methods.
		/// </summary>
		/// <param name="value1">First value to compare.</param>
		/// <param name="value2">Second value to compare.</param>
		/// <returns>True if <paramref name="value1"/> and <paramref name="value2"/> points to different raw Objective-C methods; False otherwise.</returns>
		public static bool operator !=( RuntimeMethod value1, RuntimeMethod value2 )
		{
			return !( value1 == value2 );
		}

		/// <summary>
		/// Implicit conversion to raw pointer to Objective-C method.
		/// </summary>
		/// <param name="method">RuntimeMethod to convert.</param>
		/// <returns>Raw pointer to Objective-C class object</returns>
		public static implicit operator IntPtr( RuntimeMethod method ) { return method._handle; }

		/// <summary>
		/// Pointer to actual method's implementation.
		/// </summary>
		public IntPtr Implementation
		{
			get { return Runtime.CompatibilityLayer.method_getImplementation( this ); }
		}

		/// <summary>
		/// Name of image where method was defined.
		/// </summary>
		public string DeclaringImage
		{
			get
			{
				Platform.Dl_info info;
				Platform.NativeMethods.dladdr( Implementation, out info );

				return Marshal.PtrToStringAnsi( info.dli_fname );
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
		/// Determines whether this instance of RuntimeMethod and a specified object, which must also be a RuntimeMethod object, points to the same raw Objective-C object.
		/// </summary>
		/// <param name="value">A boxed instance of RuntimeMethod to compare with this method.</param>
		/// <returns>True if <paramref name="value"/> is a RuntimeMethod and it points to the same raw Objective-C object as this instance; False otherwise.</returns>
		public override bool Equals( object value )
		{
			var compareTo = value as RuntimeMethod?;
			return compareTo != null && _handle == compareTo.Value._handle;
		}

		/// <summary>
		/// Returns the hash code for this method.
		/// </summary>
		/// <returns>A System.Int32 hash code.</returns>
		public override int GetHashCode()
		{
			return _handle.ToInt32();
		}

		#region IEquatable<RuntimeMethod> Members

		/// <summary>
		/// Indicates whether the current object reference is equal to another object reference.
		/// </summary>
		/// <param name="other">An Objective-C object to compare with this object.</param>
		/// <returns>True if the current object reference is equal to the <paramref name="other"/> parameter; otherwise, false.</returns>
		public bool Equals( RuntimeMethod other )
		{
			return _handle == other._handle;

		}

		#endregion
	}
}
