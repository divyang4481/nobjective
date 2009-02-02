//
// Copyright (C) 2009 Eugeny Grishul
//
// See license in License.txt
//

namespace NObjective.Proxies {
	using System;
	using System.Runtime.InteropServices;
	[ProxyBaseClass(typeof( NSObject ))]
	public struct NSHIObject : IEquatable<NSHIObject> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = HIToolboxCachedClasses.NSHIObject;
		public static implicit operator IntPtr( NSHIObject value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSHIObject value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is NSHIObject ) ) return false; 
			return Handle == ( ( NSHIObject )value ).Handle;
		}
		public bool Equals( NSHIObject value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSHIObject value1, NSHIObject value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSHIObject value1, NSHIObject value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSHIObject( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSHIObject alloc() {
			return new NSHIObject( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void encodeWithCoder_( NSCoder coder ) {
			RuntimeObject ___occuredException;
			NativeMethods.encodeWithCoder_( Handle, CachedSelectors.encodeWithCoder_, out ___occuredException, sizeof( NSCoder ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSHIObject initWithCoder_( NObjective.RuntimeObject coder ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCoder_( Handle, CachedSelectors.initWithCoder_, out ___occuredException, sizeof( NObjective.RuntimeObject ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSHIObject( ___result );
		}
		unsafe public void release() {
			RuntimeObject ___occuredException;
			NativeMethods.release( Handle, CachedSelectors.release, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void encodeWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSCoder coder );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject coder );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void release( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector encodeWithCoder_ = "encodeWithCoder:";
			public static readonly Selector initWithCoder_ = "initWithCoder:";
			public static readonly Selector release = "release";
		}
	}
	[ProxyBaseClass(typeof( NSHIObject ))]
	public struct NSHIObjectSubclass : IEquatable<NSHIObjectSubclass> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = HIToolboxCachedClasses.NSHIObjectSubclass;
		public static implicit operator IntPtr( NSHIObjectSubclass value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSHIObjectSubclass value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is NSHIObjectSubclass ) ) return false; 
			return Handle == ( ( NSHIObjectSubclass )value ).Handle;
		}
		public bool Equals( NSHIObjectSubclass value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSHIObjectSubclass value1, NSHIObjectSubclass value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSHIObjectSubclass value1, NSHIObjectSubclass value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSHIObjectSubclass( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSHIObjectSubclass alloc() {
			return new NSHIObjectSubclass( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[ProxyBaseClass(typeof( NSKeyedArchiver ))]
	public struct NSKeyedArchiverWrapper : IEquatable<NSKeyedArchiverWrapper> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = HIToolboxCachedClasses.NSKeyedArchiverWrapper;
		public static implicit operator IntPtr( NSKeyedArchiverWrapper value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSKeyedArchiverWrapper value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is NSKeyedArchiverWrapper ) ) return false; 
			return Handle == ( ( NSKeyedArchiverWrapper )value ).Handle;
		}
		public bool Equals( NSKeyedArchiverWrapper value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSKeyedArchiverWrapper value1, NSKeyedArchiverWrapper value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSKeyedArchiverWrapper value1, NSKeyedArchiverWrapper value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSKeyedArchiverWrapper( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSKeyedArchiverWrapper alloc() {
			return new NSKeyedArchiverWrapper( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[ProxyBaseClass(typeof( NSKeyedUnarchiver ))]
	public struct NSKeyedUnarchiverWrapper : IEquatable<NSKeyedUnarchiverWrapper> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = HIToolboxCachedClasses.NSKeyedUnarchiverWrapper;
		public static implicit operator IntPtr( NSKeyedUnarchiverWrapper value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSKeyedUnarchiverWrapper value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is NSKeyedUnarchiverWrapper ) ) return false; 
			return Handle == ( ( NSKeyedUnarchiverWrapper )value ).Handle;
		}
		public bool Equals( NSKeyedUnarchiverWrapper value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSKeyedUnarchiverWrapper value1, NSKeyedUnarchiverWrapper value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSKeyedUnarchiverWrapper value1, NSKeyedUnarchiverWrapper value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSKeyedUnarchiverWrapper( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSKeyedUnarchiverWrapper alloc() {
			return new NSKeyedUnarchiverWrapper( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	static internal class HIToolboxCachedClasses {
		static internal int ___lazyLoad = Platform.NativeMethods.dlopen( "/System/Library/Frameworks/Carbon.framework/Versions/A/Frameworks/HIToolbox.framework/Versions/A/HIToolbox" );
		public static readonly RuntimeClass NSHIObject = "NSHIObject";
		public static readonly RuntimeClass NSHIObjectSubclass = "NSHIObjectSubclass";
		public static readonly RuntimeClass NSKeyedArchiverWrapper = "NSKeyedArchiverWrapper";
		public static readonly RuntimeClass NSKeyedUnarchiverWrapper = "NSKeyedUnarchiverWrapper";
	}
}
