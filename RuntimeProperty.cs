//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NObjective
{
	/// <summary>
	/// Represents Objective-C class property.
	/// </summary>
	public struct RuntimeProperty : IEquatable<RuntimeProperty>
	{
		/// <summary>
		/// Internal pointer to raw Objective-C property object.
		/// </summary>
		private readonly IntPtr _handle;

		/// <summary>
		/// Initializes new instance of RuntimeProperty struct instance with specified raw pointer to Objective-C property.
		/// </summary>
		/// <param name="handle">Raw pointer to Objective-C property.</param>
		public RuntimeProperty( IntPtr handle )
		{
			_handle = handle;
		}

		/// <summary>
		/// Initializes new instance of RuntimeProperty struct instance with specified raw pointer to Objective-C property.
		/// </summary>
		/// <param name="pointer">Raw pointer to Objective-C property.</param>
		public unsafe RuntimeProperty( void* pointer )
		{
			_handle = new IntPtr( pointer );
		}

		/// <summary>
		/// Initializes new instance of RuntimeProperty struct instance with specified class and property name.
		/// </summary>
		/// <param name="class">Class to inspect.</param>
		/// <param name="name">Property name to find.</param>
		public RuntimeProperty( RuntimeClass @class, string name )
		{
			_handle = Runtime.NativeMethods.class_getProperty( @class, name );
		}

		/// <summary>
		/// Initializes new instance of RuntimeProperty struct instance with specified protocol and property name.
		/// </summary>
		/// <param name="protocol">Protocol to inspect.</param>
		/// <param name="name">Property name to find.</param>
		/// <param name="isRequiredProperty">A value that indicates whether <paramref name="name"/> is a required property.</param>
		/// <param name="isInstanceProperty">A value that indicates whether <paramref name="name"/> is a instance property.</param>
		public RuntimeProperty( RuntimeProtocol protocol, string name, bool isRequiredProperty, bool isInstanceProperty )
		{
			_handle = Runtime.NativeMethods.protocol_getProperty( protocol, name, isRequiredProperty, isInstanceProperty );
		}

		/// <summary>
		/// Attributes string that describes property type.
		/// </summary>
		public string Attributes
		{
			get { return Runtime.NativeMethods.property_getAttributes( this ); }
		}

		/// <summary>
		/// Name of this Objective-C property.
		/// </summary>
		public string Name
		{
			get { return Runtime.NativeMethods.property_getName( this ); }
		}

		/// <summary>
		/// Returns printable pointer value.
		/// </summary>
		public string Address
		{
			get { return _handle.ToString( "X8" ); }
		}

		/// <summary>
		/// Returns string representation of this property.
		/// </summary>
		/// <returns>String representation of this property</returns>
		public override string ToString()
		{
			return string.Format( "{{ Name={0}, Attributes={1} }}", Name, Attributes );
		}

		#region IEquatable<RuntimeProperty> Members

		/// <summary>
		/// Indicates whether the current RuntimeProperty instance is equal to another RuntimeProperty instance.
		/// </summary>
		/// <param name="other">An RuntimeProperty to compare with this ivar.</param>
		/// <returns>True if the current instance points to same raw Objective-C property object as <paramref name="other"/> parameter; otherwise, false.</returns>
		public bool Equals( RuntimeProperty other )
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
