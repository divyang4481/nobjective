//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace NObjective
{
	/// <summary>
	/// Opaque handle for objective-c protocols.
	/// </summary>
	public struct RuntimeProtocol : IEquatable<RuntimeProtocol>
	{
		/// <summary>
		/// Null-pointed instance of RuntimeProtocol class.
		/// </summary>
		public static readonly RuntimeProtocol Null = new RuntimeProtocol( IntPtr.Zero );

		/// <summary>
		/// Internal raw pointer to Objective-C protocol object.
		/// </summary>
		private readonly IntPtr _handle;

		/// <summary>
		/// Initializes new instance of RuntimeProtocol class with specified raw Objective-C pointer to protocol object.
		/// </summary>
		/// <param name="handle">Raw Objective-C pointer to protocol object.</param>
		public RuntimeProtocol( IntPtr handle )
		{
			_handle = handle;
		}

		/// <summary>
		/// Initializes new instance of RuntimeProtocol class with specified raw Objective-C pointer to protocol object.
		/// </summary>
		/// <param name="pointer">Raw Objective-C pointer to protocol object.</param>
		public unsafe RuntimeProtocol( void* pointer )
		{
			_handle = new IntPtr( pointer );
		}

		/// <summary>
		/// Initializes new instance of RuntimeProtocol class with specified name.
		/// </summary>
		/// <param name="name">Raw Objective-C pointer to protocol object.</param>
		public RuntimeProtocol( string name )
		{
			_handle = Runtime.CompatibilityLayer.objc_getProtocol( name );
		}

		/// <summary>
		/// Impicit conversion to raw Objective-C pointer to protocol object.
		/// </summary>
		/// <param name="handle">RuntimeProtocol to produce pointer from.</param>
		/// <returns>Raw Objective-C pointer to protocol object</returns>
		public static implicit operator IntPtr( RuntimeProtocol handle ) { return handle._handle; }

		/// <summary>
		/// Indicates that two instances of RuntimeProtocol class points to same raw Objective-C protocol object.
		/// </summary>
		/// <param name="value1">First value to compare.</param>
		/// <param name="value2">Second value to compare.</param>
		/// <returns>True if <paramref name="value1"/> and <paramref name="value2"/> points to same raw Objective-C protocol object; False otherwise.</returns>
		public static bool operator ==( RuntimeProtocol value1, RuntimeProtocol value2 )
		{
			return value1._handle == value2._handle;
		}

		/// <summary>
		/// Indicates that two instances of RuntimeProtocol class points to different raw Objective-C protocol objects.
		/// </summary>
		/// <param name="value1">First value to compare.</param>
		/// <param name="value2">Second value to compare.</param>
		/// <returns>True if <paramref name="value1"/> and <paramref name="value2"/> points to different raw Objective-C protocol objects; False otherwise.</returns>
		public static bool operator !=( RuntimeProtocol value1, RuntimeProtocol value2 )
		{
			return !( value1 == value2 );
		}

		/// <summary>
		/// Returns the hash code for this ivar.
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode() { return _handle.GetHashCode(); }

		/// <summary>
		/// Determines whether this instance of RuntimeProtocol and a specified object, which must also be a RuntimeProtocol object, points to the same raw Objective-C protocol object.
		/// </summary>
		/// <param name="value">An System.Object to compare.</param>
		/// <returns>True if <paramref name="value"/> is a RuntimeProtocol and it points to the same raw Objective-C protocol object as this instance; False otherwise.</returns>
		public override bool Equals( object value )
		{
			var comapareTo = value as RuntimeProtocol?;

			if( comapareTo == null )
				return false;

			return _handle == comapareTo.Value._handle;
		}

		/// <summary>
		/// Retrieves all Objective-C protocols registered in Objective-C runtime.
		/// </summary>
		/// <returns>Registered protocols</returns>
		public static RuntimeProtocol[] GetAllProtocols()
		{
			return Runtime.CompatibilityLayer.objc_copyProtocolList();
		}

		/// <summary>
		/// Name of protocol.
		/// </summary>
		public string Name
		{
			get { return Runtime.CompatibilityLayer.protocol_getName( this ); }
		}

		/// <summary>
		/// Name of image where protocol was defined.
		/// </summary>
		public string DeclaringImage
		{
			get
			{
				Platform.Dl_info info;
				Platform.NativeMethods.dladdr( _handle, out info );

				return Marshal.PtrToStringAnsi( info.dli_fname );
			}
		}

		/// <summary>
		/// Retrieves all protocols adopted by that protocol.
		/// </summary>
		/// <returns>Adopted protocols</returns>
		public unsafe RuntimeProtocol[] GetAdoptedProtocols()
		{
			return Runtime.CompatibilityLayer.protocol_copyProtocolList( this );
		}

		/// <summary>
		/// Returns name of protocol.
		/// </summary>
		/// <returns>Protocol's name</returns>
		public override string ToString()
		{
			return Name;
		}

		/// <summary>
		/// Returns printable pointer value.
		/// </summary>
		public string Address
		{
			get { return _handle.ToString( "X8" ); }
		}

		/// <summary>
		/// Indicates that current protocol conforms to another protocol.
		/// </summary>
		/// <param name="value">An instance of RuntimeProtocol class to check.</param>
		/// <returns>True if current protocols conforms to <paramref name="value"/> parameter; False otherwise.</returns>
		public bool IsConformsTo( RuntimeProtocol value )
		{
			return Runtime.NativeMethods.protocol_conformsToProtocol( this, value );
		}

		#region IEquatable<RuntimeProtocol> Members

		/// <summary>
		/// Indicates whether the current RuntimeProtocol instance is equal to another RuntimeProtocol instance.
		/// </summary>
		/// <param name="other">An RuntimeProtocol to compare with this protocol.</param>
		/// <returns>True if the current instance points to same raw Objective-C protocol object as <paramref name="other"/> parameter; otherwise, false.</returns>
		public bool Equals( RuntimeProtocol other )
		{
			return _handle == other._handle;
		}

		#endregion
	}
}
