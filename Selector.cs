//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Reflection;
using System.Text;
using System.Collections.Generic;

namespace NObjective
{
	/// <summary>
	/// Represents a Objective-C message selector.
	/// </summary>
	public struct Selector : IEquatable<Selector>
	{
		/// <summary>
		/// Null selector.
		/// </summary>
		public static readonly Selector Null = new Selector( IntPtr.Zero );

		/// <summary>
		/// Internal pointer to Objective-C selector.
		/// </summary>
		private readonly IntPtr _handle;

		/// <summary>
		/// Initializes a new instance of Selector class with specified name.
		/// If selector name was already registered in Objective-C runtime than Selector will points to that registered object.
		/// </summary>
		/// <param name="name">Name of selector.</param>
		public Selector( string name )
		{
			_handle = Runtime.NativeMethods.sel_registerName( name );
		}

		/// <summary>
		/// Initializes a new instance of Selector class with specified raw Objective-C selector.
		/// </summary>
		/// <param name="handle">Raw Objective-C selector.</param>
		public Selector( IntPtr handle )
		{
			_handle = handle;
		}

		/// <summary>
		/// Initializes a new instance of Selector class with specified raw Objective-C selector.
		/// </summary>
		/// <param name="pointer">Raw Objective-C selector.</param>
		public unsafe Selector( void* pointer )
		{
			_handle = new IntPtr( pointer );
		}

		/// <summary>
		/// Initializes a new instance of Selector class with name generated from .NET method signature.
		/// </summary>
		/// <param name="method">Method signature to generate selector from.</param>
		/// <param name="options">Name generation options.</param>
		public Selector( MethodInfo method, Options options )
			: this( GetSelector( method, options ) )
		{
		}

		/// <summary>
		/// Initializes a new instance of Selector class with name generated from .NET method signature.
		/// </summary>
		/// <param name="method">Method signature to generate selector from.</param>
		public Selector( MethodInfo method )
			: this( GetSelector( method, Options.None ) )
		{
		}

		/// <summary>
		/// Returns name of selector.
		/// </summary>
		public String Name { get { return Runtime.NativeMethods.sel_getName( this ); } }

		/// <summary>
		/// Indicates that selectors points to same raw object.
		/// </summary>
		/// <param name="first"></param>
		/// <param name="second"></param>
		/// <returns></returns>
		public static bool operator ==( Selector first, Selector second )
		{
			return first._handle == second._handle;
		}

		/// <summary>
		/// Indicates that selectors points to different raw objects.
		/// </summary>
		/// <param name="first"></param>
		/// <param name="second"></param>
		/// <returns></returns>
		public static bool operator !=( Selector first, Selector second )
		{
			return !( first == second );
		}

		/// <summary>
		/// Indicates whether the current object is equal to another object.
		/// </summary>
		/// <param name="other">A boxed instance of Selector to compare with this one.</param>
		/// <returns>True if the current object reference is equal to the <paramref name="other"/> parameter; otherwise, false.</returns>
		public override bool Equals( object other )
		{
			if( other is Selector )
				return this == ( Selector ) other;

			return false;
		}

		/// <summary>
		/// Implicit conversion from string to Selector.
		/// </summary>
		/// <param name="value">String to convert.</param>
		/// <returns>Selector</returns>
		public static implicit operator Selector( string value ) { return new Selector( value ); }

		/// <summary>
		/// Returns string representation of current selector.
		/// </summary>
		/// <returns>System.String that represents current selector.</returns>
		public override string ToString() { return Name; }

		/// <summary>
		/// Returns the hash code for this object. 
		/// </summary>
		/// <returns>A System.Int32 hash code.</returns>
		public override int GetHashCode() { return ( int ) _handle; }

		/// <summary>
		/// Implicit conversion to SEL.
		/// </summary>
		/// <param name="selector">Selector to convert.</param>
		/// <returns>Raw pointer to Objective-C class object</returns>
		public static implicit operator IntPtr( Selector selector ) { return selector._handle; }

		/// <summary>
		/// Returns minimal number of parameters that can be passed to method.
		/// </summary>
		public int ParametersCount
		{
			get
			{
				var result = 0;
				var selector = Name;

				for( var i = 0; i < selector.Length; i++ )
					if( selector[i] == ':' )
						result++;

				return result;
			}
		}

		/// <summary>
		/// Selector generation options.
		/// </summary>
		[Flags]
		public enum Options
		{
			/// <summary>
			/// 
			/// </summary>
			None = 0,

			/// <summary>
			/// 
			/// </summary>
			Constructor = 1,

			/// <summary>
			/// 
			/// </summary>
			Transition = 2,

			/// <summary>
			/// 
			/// </summary>
			StripExceptionParameters = 4
		}

		/// <summary>
		/// Used to generate objective-c selector for method.
		/// </summary>
		/// <param name="method">Method signature to generate Selector from.</param>
		/// <param name="options">Selector naming options.</param>
		/// <returns>String representation of resulting selector.</returns>
		public static string GetSelector( MethodInfo method, Options options )
		{
			var registerAttribute = method.GetCustomAttribute<SelectorAttribute>( false );
			if( registerAttribute != null )
				return registerAttribute.Selector;

			var result = new StringBuilder( ( options & Options.Constructor ) != 0 ? "init" : method.Name );
			IEnumerable<ParameterInfo> actualParameters = method.GetParameters();

			if( ( options & Options.StripExceptionParameters ) != 0 )
				actualParameters = actualParameters.Skip( 4 );

			if( ( options & Options.Transition ) != 0 )
				actualParameters = actualParameters.Skip( 2 );

			if( actualParameters.Count() > 0 )
				result.Append( ":" );

			foreach( var parameter in actualParameters.Skip( 1 ) )
			{
				var renameAttribute = parameter.GetCustomAttribute<ParameterNameAttribute>( true );
				var parameterName = renameAttribute != null ? renameAttribute.Name : parameter.Name;

				result.Append( parameterName );
				result.Append( ':' );
			}

			return result.ToString();
		}

		/// <summary>
		/// Returns printable pointer value.
		/// </summary>
		public string Address
		{
			get { return _handle.ToString( "X8" ); }
		}

		#region IEquatable<Selector> Members

		/// <summary>
		/// Indicates whether the current object reference is equal to another object reference.
		/// </summary>
		/// <param name="other">Another Selector to compare with.</param>
		/// <returns>True if Selectors are equal; False otherwise.</returns>
		public bool Equals( Selector other )
		{
			return _handle == other._handle;
		}

		#endregion
	}
}
