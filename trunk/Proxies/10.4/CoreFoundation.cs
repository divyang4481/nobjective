//
// Copyright (C) 2009 Eugeny Grishul
//
// See license in License.txt
//

namespace NObjective.Proxies {
	using System;
	using System.Runtime.InteropServices;
	[ProxyBaseClass(typeof( _NSCFString ))]
	public struct NSCFString : IEquatable<NSCFString> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSCFString;
		public static implicit operator IntPtr( NSCFString value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSCFString value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is NSCFString ) ) return false; 
			return Handle == ( ( NSCFString )value ).Handle;
		}
		public bool Equals( NSCFString value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSCFString value1, NSCFString value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSCFString value1, NSCFString value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSCFString( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSCFString alloc() {
			return new NSCFString( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[ProxyBaseClass(typeof( _NSCFType ))]
	public struct NSCFType : IEquatable<NSCFType> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSCFType;
		public static implicit operator IntPtr( NSCFType value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSCFType value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is NSCFType ) ) return false; 
			return Handle == ( ( NSCFType )value ).Handle;
		}
		public bool Equals( NSCFType value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSCFType value1, NSCFType value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSCFType value1, NSCFType value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSCFType( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSCFType alloc() {
			return new NSCFType( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	static internal class CoreFoundationCachedClasses {
		static internal int ___lazyLoad = Platform.NativeMethods.dlopen( "/System/Library/Frameworks/CoreFoundation.framework/Versions/A/CoreFoundation" );
		public static readonly RuntimeClass NSCFString = "NSCFString";
		public static readonly RuntimeClass NSCFType = "NSCFType";
	}
}
