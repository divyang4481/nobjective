//
// Copyright (C) 2009 Eugeny Grishul
//
// See license in License.txt
//

namespace NObjective.Proxies {
	using System;
	using System.Runtime.InteropServices;
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( _NSCFString ) )]
	public struct NSCFString : IEquatable<NSCFString> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSCFString;
		public static implicit operator _NSCFString( NSCFString value ) {
			return new _NSCFString( value.Handle );
		}
		public static implicit operator NSMutableString( NSCFString value ) {
			return new NSMutableString( value.Handle );
		}
		public static implicit operator NSString( NSCFString value ) {
			return new NSString( value.Handle );
		}
		public static implicit operator NSObject( NSCFString value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSCFString value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSCFString value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSCFString?;
			return compareTo != null && Handle == compareTo.Value.Handle;
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
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( _NSCFType ) )]
	public struct NSCFType : IEquatable<NSCFType> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSCFType;
		public static implicit operator _NSCFType( NSCFType value ) {
			return new _NSCFType( value.Handle );
		}
		public static implicit operator NSObject( NSCFType value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSCFType value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSCFType value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSCFType?;
			return compareTo != null && Handle == compareTo.Value.Handle;
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
