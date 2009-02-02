//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System;

namespace NObjective
{
	/// <summary>
	/// Represents single ivar.
	/// </summary>
	public struct RuntimeVariable : IEquatable<RuntimeVariable>
	{
		/// <summary>
		/// Null-pointed RuntimeVariable class instance.
		/// </summary>
		public static readonly RuntimeVariable Null = new RuntimeVariable( IntPtr.Zero );

		/// <summary>
		/// Internal pointer to raw Objective-C ivar object.
		/// </summary>
		private readonly IntPtr _handle;

		/// <summary>
		/// Initializes instance of RuntimeVariable class with specified pointer to Objective-C ivar object.
		/// </summary>
		/// <param name="handle">Pointer to Objective-C ivar object</param>
		public RuntimeVariable( IntPtr handle )
		{
			_handle = handle;
		}

		/// <summary>
		/// Initializes instance of RuntimeVariable class with specified pointer to Objective-C ivar object.
		/// </summary>
		/// <param name="pointer">Pointer to Objective-C ivar object</param>
		public unsafe RuntimeVariable( void* pointer )
		{
			_handle = new IntPtr( pointer );
		}

		/// <summary>
		/// Initializes instance of RuntimeVariable class with specified object to search and variable name.
		/// </summary>
		/// <param name="object">Object which Class will be used to find corresponding ivar.</param>
		/// <param name="name">Name of ivar to find.</param>
		public RuntimeVariable( RuntimeObject @object, string name )
		{
			_handle = Runtime.CompatibilityLayer.class_getClassVariable( @object, name );
		}

		/// <summary>
		/// Initializes instance of RuntimeVariable class with specified class to search and variable name.
		/// </summary>
		/// <param name="class">Class that will be used to find corresponding ivar.</param>
		/// <param name="name">Name of ivar to find.</param>
		public RuntimeVariable( RuntimeClass @class, string name )
		{
			_handle = Runtime.CompatibilityLayer.class_getInstanceVariable( @class, name );
		}

		/// <summary>
		/// Raw pointer to Objective-C ivar object.
		/// </summary>
		public IntPtr Handle
		{
			get { return _handle; }
		}

		/// <summary>
		/// Name of this instance variable.
		/// </summary>
		public string Name
		{
			get { return Runtime.CompatibilityLayer.ivar_getName( this ); }
		}

		/// <summary>
		/// Raw offset of this instance variable from object start address.
		/// </summary>
		public int Offset
		{
			get { return Runtime.CompatibilityLayer.ivar_getOffset( this ); }
		}

		/// <summary>
		/// Type encoding.
		/// </summary>
		public string TypeEncoding
		{
			get { return Runtime.CompatibilityLayer.ivar_getTypeEncoding( this ); }
		}

		/// <summary>
		/// Returns string representation of this instance variable.
		/// </summary>
		/// <returns>System.String  that represents this instance variable.</returns>
		public override string ToString()
		{
			return string.Format( "{{ Name={0}, TypeEncoding={1}, Offset={2} }}", Name, TypeEncoding, Offset );
		}

		/// <summary>
		/// Indicates that two RuntimeVariable class instances points to same raw Objective-C objects.
		/// </summary>
		/// <param name="value1">First value to compare.</param>
		/// <param name="value2">Second value to compare.</param>
		/// <returns>True if <paramref name="value1"/> and <paramref name="value2"/> points to same raw object; False otherwise.</returns>
		public static bool operator ==( RuntimeVariable value1, RuntimeVariable value2 )
		{
			return value1._handle == value2._handle;
		}

		/// <summary>
		/// Indicates that two RuntimeVariable class instances points to different raw Objective-C objects.
		/// </summary>
		/// <param name="value1">First value to compare.</param>
		/// <param name="value2">Second value to compare.</param>
		/// <returns>True if <paramref name="value1"/> and <paramref name="value2"/> points to different raw objects; False otherwise.</returns>
		public static bool operator !=( RuntimeVariable value1, RuntimeVariable value2 )
		{
			return !( value1 == value2 );
		}

		/// <summary>
		/// Implicit conversion to raw pointer to Objective-C ivar.
		/// </summary>
		/// <param name="class">RuntimeClass to convert.</param>
		/// <returns>Raw pointer to Objective-C class object</returns>
		public static implicit operator IntPtr( RuntimeVariable @class ) { return @class._handle; }

		/// <summary>
		/// Determines whether this instance of RuntimeVariable and a specified object, which must also be a RuntimeClass object, points to the same raw Objective-C ivar object.
		/// </summary>
		/// <param name="value">An System.Object to compare.</param>
		/// <returns>True if <paramref name="value"/> is a RuntimeClass and it points to the same raw Objective-C ivar object as this instance; False otherwise.</returns>
		public override bool Equals( object value )
		{
			var comapareTo = value as RuntimeVariable?;

			if( comapareTo == null )
				return false;

			return _handle == comapareTo.Value._handle;
		}

		/// <summary>
		/// Returns printable pointer value.
		/// </summary>
		public string Address
		{
			get { return _handle.ToString( "X8" ); }
		}

		/// <summary>
		/// Returns the hash code for this class.
		/// </summary>
		/// <returns>A System.Int32 hash code.</returns>
		public override int GetHashCode()
		{
			return _handle.ToInt32();
		}

		#region IEquatable<RuntimeVariable> Members

		/// <summary>
		/// Indicates whether the current RuntimeVariable instance is equal to another RuntimeVariable instance.
		/// </summary>
		/// <param name="other">An RuntimeVariable to compare with this ivar.</param>
		/// <returns>True if the current instance points to same raw Objective-C ivar object as <paramref name="other"/> parameter; otherwise, false.</returns>
		public bool Equals( RuntimeVariable other )
		{
			return _handle == other._handle;
		}

		#endregion
	}
}
