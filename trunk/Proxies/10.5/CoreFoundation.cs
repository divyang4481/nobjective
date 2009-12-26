//
// Copyright (C) 2009 Eugeny Grishul
//
// See license in License.txt
//

namespace NObjective.Proxies {
	using System;
	using System.Runtime.InteropServices;
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSEnumerator ) )]
	public struct __NSArrayReverseEnumerator : IEquatable<__NSArrayReverseEnumerator> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.__NSArrayReverseEnumerator;
		public static implicit operator NSEnumerator( __NSArrayReverseEnumerator value ) {
			return new NSEnumerator( value.Handle );
		}
		public static implicit operator NSObject( __NSArrayReverseEnumerator value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( __NSArrayReverseEnumerator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( __NSArrayReverseEnumerator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as __NSArrayReverseEnumerator?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( __NSArrayReverseEnumerator value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( __NSArrayReverseEnumerator value1, __NSArrayReverseEnumerator value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( __NSArrayReverseEnumerator value1, __NSArrayReverseEnumerator value2 ) {
			return value1.Handle != value2.Handle;
		}
		public __NSArrayReverseEnumerator( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static __NSArrayReverseEnumerator alloc() {
			return new __NSArrayReverseEnumerator( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject initWithObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithObject_( Handle, CachedSelectors.initWithObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithObject_ = "initWithObject:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSMutableArray ) )]
	public struct __NSCFArray : IEquatable<__NSCFArray> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.__NSCFArray;
		public static implicit operator NSMutableArray( __NSCFArray value ) {
			return new NSMutableArray( value.Handle );
		}
		public static implicit operator NSArray( __NSCFArray value ) {
			return new NSArray( value.Handle );
		}
		public static implicit operator NSObject( __NSCFArray value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( __NSCFArray value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( __NSCFArray value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as __NSCFArray?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( __NSCFArray value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( __NSCFArray value1, __NSCFArray value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( __NSCFArray value1, __NSCFArray value2 ) {
			return value1.Handle != value2.Handle;
		}
		public __NSCFArray( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static __NSCFArray alloc() {
			return new __NSCFArray( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSDate ) )]
	public struct __NSCFDate : IEquatable<__NSCFDate> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.__NSCFDate;
		public static implicit operator NSDate( __NSCFDate value ) {
			return new NSDate( value.Handle );
		}
		public static implicit operator NSObject( __NSCFDate value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( __NSCFDate value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( __NSCFDate value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as __NSCFDate?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( __NSCFDate value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( __NSCFDate value1, __NSCFDate value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( __NSCFDate value1, __NSCFDate value2 ) {
			return value1.Handle != value2.Handle;
		}
		public __NSCFDate( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static __NSCFDate alloc() {
			return new __NSCFDate( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static char automaticallyNotifiesObserversForKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.automaticallyNotifiesObserversForKey_( ClassHandle, CachedSelectors.automaticallyNotifiesObserversForKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char automaticallyNotifiesObserversForKey_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
		}
		static internal class CachedSelectors {
			public static readonly Selector automaticallyNotifiesObserversForKey_ = "automaticallyNotifiesObserversForKey:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSMutableDictionary ) )]
	public struct __NSCFDictionary : IEquatable<__NSCFDictionary> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.__NSCFDictionary;
		public static implicit operator NSMutableDictionary( __NSCFDictionary value ) {
			return new NSMutableDictionary( value.Handle );
		}
		public static implicit operator NSDictionary( __NSCFDictionary value ) {
			return new NSDictionary( value.Handle );
		}
		public static implicit operator NSObject( __NSCFDictionary value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( __NSCFDictionary value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( __NSCFDictionary value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as __NSCFDictionary?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( __NSCFDictionary value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( __NSCFDictionary value1, __NSCFDictionary value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( __NSCFDictionary value1, __NSCFDictionary value2 ) {
			return value1.Handle != value2.Handle;
		}
		public __NSCFDictionary( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static __NSCFDictionary alloc() {
			return new __NSCFDictionary( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSMutableOrderedSet ) )]
	public struct __NSCFOrderedSet : IEquatable<__NSCFOrderedSet> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.__NSCFOrderedSet;
		public static implicit operator NSMutableOrderedSet( __NSCFOrderedSet value ) {
			return new NSMutableOrderedSet( value.Handle );
		}
		public static implicit operator NSOrderedSet( __NSCFOrderedSet value ) {
			return new NSOrderedSet( value.Handle );
		}
		public static implicit operator NSObject( __NSCFOrderedSet value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( __NSCFOrderedSet value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( __NSCFOrderedSet value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as __NSCFOrderedSet?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( __NSCFOrderedSet value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( __NSCFOrderedSet value1, __NSCFOrderedSet value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( __NSCFOrderedSet value1, __NSCFOrderedSet value2 ) {
			return value1.Handle != value2.Handle;
		}
		public __NSCFOrderedSet( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static __NSCFOrderedSet alloc() {
			return new __NSCFOrderedSet( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSMutableSet ) )]
	public struct __NSCFSet : IEquatable<__NSCFSet> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.__NSCFSet;
		public static implicit operator NSMutableSet( __NSCFSet value ) {
			return new NSMutableSet( value.Handle );
		}
		public static implicit operator NSSet( __NSCFSet value ) {
			return new NSSet( value.Handle );
		}
		public static implicit operator NSObject( __NSCFSet value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( __NSCFSet value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( __NSCFSet value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as __NSCFSet?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( __NSCFSet value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( __NSCFSet value1, __NSCFSet value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( __NSCFSet value1, __NSCFSet value2 ) {
			return value1.Handle != value2.Handle;
		}
		public __NSCFSet( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static __NSCFSet alloc() {
			return new __NSCFSet( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( __NSFastEnumerationEnumerator ) )]
	public struct __NSDictionaryObjectEnumerator : IEquatable<__NSDictionaryObjectEnumerator> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.__NSDictionaryObjectEnumerator;
		public static implicit operator __NSFastEnumerationEnumerator( __NSDictionaryObjectEnumerator value ) {
			return new __NSFastEnumerationEnumerator( value.Handle );
		}
		public static implicit operator NSEnumerator( __NSDictionaryObjectEnumerator value ) {
			return new NSEnumerator( value.Handle );
		}
		public static implicit operator NSObject( __NSDictionaryObjectEnumerator value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( __NSDictionaryObjectEnumerator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( __NSDictionaryObjectEnumerator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as __NSDictionaryObjectEnumerator?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( __NSDictionaryObjectEnumerator value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( __NSDictionaryObjectEnumerator value1, __NSDictionaryObjectEnumerator value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( __NSDictionaryObjectEnumerator value1, __NSDictionaryObjectEnumerator value2 ) {
			return value1.Handle != value2.Handle;
		}
		public __NSDictionaryObjectEnumerator( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static __NSDictionaryObjectEnumerator alloc() {
			return new __NSDictionaryObjectEnumerator( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSEnumerator ) )]
	public struct __NSFastEnumerationEnumerator : IEquatable<__NSFastEnumerationEnumerator> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.__NSFastEnumerationEnumerator;
		public static implicit operator NSEnumerator( __NSFastEnumerationEnumerator value ) {
			return new NSEnumerator( value.Handle );
		}
		public static implicit operator NSObject( __NSFastEnumerationEnumerator value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( __NSFastEnumerationEnumerator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( __NSFastEnumerationEnumerator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as __NSFastEnumerationEnumerator?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( __NSFastEnumerationEnumerator value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( __NSFastEnumerationEnumerator value1, __NSFastEnumerationEnumerator value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( __NSFastEnumerationEnumerator value1, __NSFastEnumerationEnumerator value2 ) {
			return value1.Handle != value2.Handle;
		}
		public __NSFastEnumerationEnumerator( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static __NSFastEnumerationEnumerator alloc() {
			return new __NSFastEnumerationEnumerator( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject initWithObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithObject_( Handle, CachedSelectors.initWithObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithObject_ = "initWithObject:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSEnumerator ) )]
	public struct __NSOrderedSetReverseEnumerator : IEquatable<__NSOrderedSetReverseEnumerator> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.__NSOrderedSetReverseEnumerator;
		public static implicit operator NSEnumerator( __NSOrderedSetReverseEnumerator value ) {
			return new NSEnumerator( value.Handle );
		}
		public static implicit operator NSObject( __NSOrderedSetReverseEnumerator value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( __NSOrderedSetReverseEnumerator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( __NSOrderedSetReverseEnumerator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as __NSOrderedSetReverseEnumerator?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( __NSOrderedSetReverseEnumerator value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( __NSOrderedSetReverseEnumerator value1, __NSOrderedSetReverseEnumerator value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( __NSOrderedSetReverseEnumerator value1, __NSOrderedSetReverseEnumerator value2 ) {
			return value1.Handle != value2.Handle;
		}
		public __NSOrderedSetReverseEnumerator( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static __NSOrderedSetReverseEnumerator alloc() {
			return new __NSOrderedSetReverseEnumerator( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject initWithObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithObject_( Handle, CachedSelectors.initWithObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithObject_ = "initWithObject:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSMutableArray ) )]
	public struct __NSPlaceholderArray : IEquatable<__NSPlaceholderArray> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.__NSPlaceholderArray;
		public static implicit operator NSMutableArray( __NSPlaceholderArray value ) {
			return new NSMutableArray( value.Handle );
		}
		public static implicit operator NSArray( __NSPlaceholderArray value ) {
			return new NSArray( value.Handle );
		}
		public static implicit operator NSObject( __NSPlaceholderArray value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( __NSPlaceholderArray value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( __NSPlaceholderArray value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as __NSPlaceholderArray?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( __NSPlaceholderArray value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( __NSPlaceholderArray value1, __NSPlaceholderArray value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( __NSPlaceholderArray value1, __NSPlaceholderArray value2 ) {
			return value1.Handle != value2.Handle;
		}
		public __NSPlaceholderArray( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static __NSPlaceholderArray alloc() {
			return new __NSPlaceholderArray( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject immutablePlaceholder() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.immutablePlaceholder( ClassHandle, CachedSelectors.immutablePlaceholder, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static void initialize() {
			RuntimeObject ___occuredException;
			NativeMethods.initialize( ClassHandle, CachedSelectors.initialize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static NObjective.RuntimeObject mutablePlaceholder() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mutablePlaceholder( ClassHandle, CachedSelectors.mutablePlaceholder, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithContentsOfFile_( NObjective.RuntimeObject file ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithContentsOfFile_( Handle, CachedSelectors.initWithContentsOfFile_, out ___occuredException, sizeof( NObjective.RuntimeObject ), file );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithContentsOfURL_( NObjective.RuntimeObject url ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithContentsOfURL_( Handle, CachedSelectors.initWithContentsOfURL_, out ___occuredException, sizeof( NObjective.RuntimeObject ), url );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void release() {
			RuntimeObject ___occuredException;
			NativeMethods.release( Handle, CachedSelectors.release, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr immutablePlaceholder( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void initialize( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithContentsOfFile_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithContentsOfURL_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject url );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr mutablePlaceholder( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void release( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector immutablePlaceholder = "immutablePlaceholder";
			public static readonly Selector initialize = "initialize";
			public static readonly Selector initWithContentsOfFile_ = "initWithContentsOfFile:";
			public static readonly Selector initWithContentsOfURL_ = "initWithContentsOfURL:";
			public static readonly Selector mutablePlaceholder = "mutablePlaceholder";
			public static readonly Selector release = "release";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSDate ) )]
	public struct __NSPlaceholderDate : IEquatable<__NSPlaceholderDate> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.__NSPlaceholderDate;
		public static implicit operator NSDate( __NSPlaceholderDate value ) {
			return new NSDate( value.Handle );
		}
		public static implicit operator NSObject( __NSPlaceholderDate value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( __NSPlaceholderDate value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( __NSPlaceholderDate value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as __NSPlaceholderDate?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( __NSPlaceholderDate value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( __NSPlaceholderDate value1, __NSPlaceholderDate value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( __NSPlaceholderDate value1, __NSPlaceholderDate value2 ) {
			return value1.Handle != value2.Handle;
		}
		public __NSPlaceholderDate( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static __NSPlaceholderDate alloc() {
			return new __NSPlaceholderDate( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject immutablePlaceholder() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.immutablePlaceholder( ClassHandle, CachedSelectors.immutablePlaceholder, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static void initialize() {
			RuntimeObject ___occuredException;
			NativeMethods.initialize( ClassHandle, CachedSelectors.initialize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void release() {
			RuntimeObject ___occuredException;
			NativeMethods.release( Handle, CachedSelectors.release, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr immutablePlaceholder( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void initialize( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void release( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector immutablePlaceholder = "immutablePlaceholder";
			public static readonly Selector initialize = "initialize";
			public static readonly Selector release = "release";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSMutableDictionary ) )]
	public struct __NSPlaceholderDictionary : IEquatable<__NSPlaceholderDictionary> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.__NSPlaceholderDictionary;
		public static implicit operator NSMutableDictionary( __NSPlaceholderDictionary value ) {
			return new NSMutableDictionary( value.Handle );
		}
		public static implicit operator NSDictionary( __NSPlaceholderDictionary value ) {
			return new NSDictionary( value.Handle );
		}
		public static implicit operator NSObject( __NSPlaceholderDictionary value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( __NSPlaceholderDictionary value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( __NSPlaceholderDictionary value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as __NSPlaceholderDictionary?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( __NSPlaceholderDictionary value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( __NSPlaceholderDictionary value1, __NSPlaceholderDictionary value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( __NSPlaceholderDictionary value1, __NSPlaceholderDictionary value2 ) {
			return value1.Handle != value2.Handle;
		}
		public __NSPlaceholderDictionary( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static __NSPlaceholderDictionary alloc() {
			return new __NSPlaceholderDictionary( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject immutablePlaceholder() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.immutablePlaceholder( ClassHandle, CachedSelectors.immutablePlaceholder, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static void initialize() {
			RuntimeObject ___occuredException;
			NativeMethods.initialize( ClassHandle, CachedSelectors.initialize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static NObjective.RuntimeObject mutablePlaceholder() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mutablePlaceholder( ClassHandle, CachedSelectors.mutablePlaceholder, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithContentsOfFile_( NObjective.RuntimeObject file ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithContentsOfFile_( Handle, CachedSelectors.initWithContentsOfFile_, out ___occuredException, sizeof( NObjective.RuntimeObject ), file );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithContentsOfURL_( NObjective.RuntimeObject url ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithContentsOfURL_( Handle, CachedSelectors.initWithContentsOfURL_, out ___occuredException, sizeof( NObjective.RuntimeObject ), url );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void release() {
			RuntimeObject ___occuredException;
			NativeMethods.release( Handle, CachedSelectors.release, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr immutablePlaceholder( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void initialize( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithContentsOfFile_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithContentsOfURL_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject url );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr mutablePlaceholder( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void release( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector immutablePlaceholder = "immutablePlaceholder";
			public static readonly Selector initialize = "initialize";
			public static readonly Selector initWithContentsOfFile_ = "initWithContentsOfFile:";
			public static readonly Selector initWithContentsOfURL_ = "initWithContentsOfURL:";
			public static readonly Selector mutablePlaceholder = "mutablePlaceholder";
			public static readonly Selector release = "release";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSMutableOrderedSet ) )]
	public struct __NSPlaceholderOrderedSet : IEquatable<__NSPlaceholderOrderedSet> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.__NSPlaceholderOrderedSet;
		public static implicit operator NSMutableOrderedSet( __NSPlaceholderOrderedSet value ) {
			return new NSMutableOrderedSet( value.Handle );
		}
		public static implicit operator NSOrderedSet( __NSPlaceholderOrderedSet value ) {
			return new NSOrderedSet( value.Handle );
		}
		public static implicit operator NSObject( __NSPlaceholderOrderedSet value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( __NSPlaceholderOrderedSet value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( __NSPlaceholderOrderedSet value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as __NSPlaceholderOrderedSet?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( __NSPlaceholderOrderedSet value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( __NSPlaceholderOrderedSet value1, __NSPlaceholderOrderedSet value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( __NSPlaceholderOrderedSet value1, __NSPlaceholderOrderedSet value2 ) {
			return value1.Handle != value2.Handle;
		}
		public __NSPlaceholderOrderedSet( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static __NSPlaceholderOrderedSet alloc() {
			return new __NSPlaceholderOrderedSet( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject immutablePlaceholder() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.immutablePlaceholder( ClassHandle, CachedSelectors.immutablePlaceholder, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static void initialize() {
			RuntimeObject ___occuredException;
			NativeMethods.initialize( ClassHandle, CachedSelectors.initialize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static NObjective.RuntimeObject mutablePlaceholder() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mutablePlaceholder( ClassHandle, CachedSelectors.mutablePlaceholder, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void release() {
			RuntimeObject ___occuredException;
			NativeMethods.release( Handle, CachedSelectors.release, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr immutablePlaceholder( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void initialize( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr mutablePlaceholder( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void release( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector immutablePlaceholder = "immutablePlaceholder";
			public static readonly Selector initialize = "initialize";
			public static readonly Selector mutablePlaceholder = "mutablePlaceholder";
			public static readonly Selector release = "release";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSMutableSet ) )]
	public struct __NSPlaceholderSet : IEquatable<__NSPlaceholderSet> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.__NSPlaceholderSet;
		public static implicit operator NSMutableSet( __NSPlaceholderSet value ) {
			return new NSMutableSet( value.Handle );
		}
		public static implicit operator NSSet( __NSPlaceholderSet value ) {
			return new NSSet( value.Handle );
		}
		public static implicit operator NSObject( __NSPlaceholderSet value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( __NSPlaceholderSet value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( __NSPlaceholderSet value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as __NSPlaceholderSet?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( __NSPlaceholderSet value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( __NSPlaceholderSet value1, __NSPlaceholderSet value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( __NSPlaceholderSet value1, __NSPlaceholderSet value2 ) {
			return value1.Handle != value2.Handle;
		}
		public __NSPlaceholderSet( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static __NSPlaceholderSet alloc() {
			return new __NSPlaceholderSet( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject immutablePlaceholder() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.immutablePlaceholder( ClassHandle, CachedSelectors.immutablePlaceholder, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static void initialize() {
			RuntimeObject ___occuredException;
			NativeMethods.initialize( ClassHandle, CachedSelectors.initialize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static NObjective.RuntimeObject mutablePlaceholder() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mutablePlaceholder( ClassHandle, CachedSelectors.mutablePlaceholder, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void release() {
			RuntimeObject ___occuredException;
			NativeMethods.release( Handle, CachedSelectors.release, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr immutablePlaceholder( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void initialize( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr mutablePlaceholder( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void release( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector immutablePlaceholder = "immutablePlaceholder";
			public static readonly Selector initialize = "initialize";
			public static readonly Selector mutablePlaceholder = "mutablePlaceholder";
			public static readonly Selector release = "release";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	public struct _NSZombie_ : IEquatable<_NSZombie_> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses._NSZombie_;
		public override int GetHashCode() {
			return Handle.GetHashCode();
		}
		public static implicit operator IntPtr( _NSZombie_ value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( _NSZombie_ value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as _NSZombie_?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( _NSZombie_ value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( _NSZombie_ value1, _NSZombie_ value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( _NSZombie_ value1, _NSZombie_ value2 ) {
			return value1.Handle != value2.Handle;
		}
		public _NSZombie_( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static _NSZombie_ alloc() {
			return new _NSZombie_( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		public override string ToString() {
			return Handle.InvokeString( Selectors.description );
		}
		unsafe public static void initialize() {
			RuntimeObject ___occuredException;
			NativeMethods.initialize( ClassHandle, CachedSelectors.initialize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void initialize( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector initialize = "initialize";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CFXPreferencesSource ) )]
	public struct CFXPreferencesCompatibilitySource : IEquatable<CFXPreferencesCompatibilitySource> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.CFXPreferencesCompatibilitySource;
		public static implicit operator CFXPreferencesSource( CFXPreferencesCompatibilitySource value ) {
			return new CFXPreferencesSource( value.Handle );
		}
		public static implicit operator NSObject( CFXPreferencesCompatibilitySource value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CFXPreferencesCompatibilitySource value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CFXPreferencesCompatibilitySource value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CFXPreferencesCompatibilitySource?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CFXPreferencesCompatibilitySource value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CFXPreferencesCompatibilitySource value1, CFXPreferencesCompatibilitySource value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CFXPreferencesCompatibilitySource value1, CFXPreferencesCompatibilitySource value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CFXPreferencesCompatibilitySource( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CFXPreferencesCompatibilitySource alloc() {
			return new CFXPreferencesCompatibilitySource( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CFXPreferencesPropertyListSource ) )]
	public struct CFXPreferencesManagedSource : IEquatable<CFXPreferencesManagedSource> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.CFXPreferencesManagedSource;
		public static implicit operator CFXPreferencesPropertyListSource( CFXPreferencesManagedSource value ) {
			return new CFXPreferencesPropertyListSource( value.Handle );
		}
		public static implicit operator CFXPreferencesSource( CFXPreferencesManagedSource value ) {
			return new CFXPreferencesSource( value.Handle );
		}
		public static implicit operator NSObject( CFXPreferencesManagedSource value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CFXPreferencesManagedSource value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CFXPreferencesManagedSource value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CFXPreferencesManagedSource?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CFXPreferencesManagedSource value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CFXPreferencesManagedSource value1, CFXPreferencesManagedSource value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CFXPreferencesManagedSource value1, CFXPreferencesManagedSource value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CFXPreferencesManagedSource( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CFXPreferencesManagedSource alloc() {
			return new CFXPreferencesManagedSource( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CFXPreferencesSource ) )]
	public struct CFXPreferencesPropertyListSource : IEquatable<CFXPreferencesPropertyListSource> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.CFXPreferencesPropertyListSource;
		public static implicit operator CFXPreferencesSource( CFXPreferencesPropertyListSource value ) {
			return new CFXPreferencesSource( value.Handle );
		}
		public static implicit operator NSObject( CFXPreferencesPropertyListSource value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CFXPreferencesPropertyListSource value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CFXPreferencesPropertyListSource value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CFXPreferencesPropertyListSource?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CFXPreferencesPropertyListSource value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CFXPreferencesPropertyListSource value1, CFXPreferencesPropertyListSource value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CFXPreferencesPropertyListSource value1, CFXPreferencesPropertyListSource value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CFXPreferencesPropertyListSource( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CFXPreferencesPropertyListSource alloc() {
			return new CFXPreferencesPropertyListSource( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CFXPreferencesSource ) )]
	public struct CFXPreferencesSearchListSource : IEquatable<CFXPreferencesSearchListSource> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.CFXPreferencesSearchListSource;
		public static implicit operator CFXPreferencesSource( CFXPreferencesSearchListSource value ) {
			return new CFXPreferencesSource( value.Handle );
		}
		public static implicit operator NSObject( CFXPreferencesSearchListSource value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CFXPreferencesSearchListSource value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CFXPreferencesSearchListSource value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CFXPreferencesSearchListSource?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CFXPreferencesSearchListSource value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CFXPreferencesSearchListSource value1, CFXPreferencesSearchListSource value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CFXPreferencesSearchListSource value1, CFXPreferencesSearchListSource value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CFXPreferencesSearchListSource( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CFXPreferencesSearchListSource alloc() {
			return new CFXPreferencesSearchListSource( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void addSource_( NObjective.RuntimeObject source ) {
			RuntimeObject ___occuredException;
			NativeMethods.addSource_( Handle, CachedSelectors.addSource_, out ___occuredException, sizeof( NObjective.RuntimeObject ), source );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeSource_( NObjective.RuntimeObject source ) {
			RuntimeObject ___occuredException;
			NativeMethods.removeSource_( Handle, CachedSelectors.removeSource_, out ___occuredException, sizeof( NObjective.RuntimeObject ), source );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void addSource_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject source );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void removeSource_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject source );
		}
		static internal class CachedSelectors {
			public static readonly Selector addSource_ = "addSource:";
			public static readonly Selector removeSource_ = "removeSource:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct CFXPreferencesSource : IEquatable<CFXPreferencesSource> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.CFXPreferencesSource;
		public static implicit operator NSObject( CFXPreferencesSource value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CFXPreferencesSource value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CFXPreferencesSource value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CFXPreferencesSource?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CFXPreferencesSource value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CFXPreferencesSource value1, CFXPreferencesSource value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CFXPreferencesSource value1, CFXPreferencesSource value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CFXPreferencesSource( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CFXPreferencesSource alloc() {
			return new CFXPreferencesSource( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public int generationCount() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.generationCount( Handle, CachedSelectors.generationCount, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char synchronize() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.synchronize( Handle, CachedSelectors.synchronize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int generationCount( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char synchronize( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector generationCount = "generationCount";
			public static readonly Selector synchronize = "synchronize";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSArray : IEquatable<NSArray> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSArray;
		public static implicit operator NSObject( NSArray value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSArray value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSArray value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSArray?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSArray value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSArray value1, NSArray value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSArray value1, NSArray value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSArray( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSArray alloc() {
			return new NSArray( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject array() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.array( ClassHandle, CachedSelectors.array, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NSArray arrayWithArray_( NSArray array ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.arrayWithArray_( ClassHandle, CachedSelectors.arrayWithArray_, out ___occuredException, sizeof( NSArray ), array );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public static NSArray arrayWithArray_copyItems_( NObjective.RuntimeObject array, char copyItems ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.arrayWithArray_copyItems_( ClassHandle, CachedSelectors.arrayWithArray_copyItems_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( char ), array, copyItems );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public static NSArray arrayWithObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.arrayWithObject_( ClassHandle, CachedSelectors.arrayWithObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		public static NSArray arrayWithObjects_( NObjective.RuntimeObject objects ) {
			return new NSArray( ClassHandle.InvokeIntPtrFast( CachedSelectors.arrayWithObjects_, CachedEncodings.__6F587D11, objects ) );
		}
		unsafe public static NSArray arrayWithObjects_count_( IntPtr objects, uint count ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.arrayWithObjects_count_( ClassHandle, CachedSelectors.arrayWithObjects_count_, out ___occuredException, sizeof( IntPtr ) + sizeof( uint ), objects, count );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public NSArray arrayByAddingObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.arrayByAddingObject_( Handle, CachedSelectors.arrayByAddingObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public NObjective.RuntimeObject arrayByAddingObjects_count_( System.IntPtr objects, uint count ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.arrayByAddingObjects_count_( Handle, CachedSelectors.arrayByAddingObjects_count_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( uint ), objects, count );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSArray arrayByAddingObjectsFromArray_( NSArray array ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.arrayByAddingObjectsFromArray_( Handle, CachedSelectors.arrayByAddingObjectsFromArray_, out ___occuredException, sizeof( NSArray ), array );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public NObjective.RuntimeObject arrayByApplyingSelector_( NObjective.Selector selector ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.arrayByApplyingSelector_( Handle, CachedSelectors.arrayByApplyingSelector_, out ___occuredException, sizeof( NObjective.Selector ), selector );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject arrayByExcludingObjectsInArray_( NObjective.RuntimeObject array ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.arrayByExcludingObjectsInArray_( Handle, CachedSelectors.arrayByExcludingObjectsInArray_, out ___occuredException, sizeof( NObjective.RuntimeObject ), array );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject arrayByExcludingToObjectsInArray_( NObjective.RuntimeObject array ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.arrayByExcludingToObjectsInArray_( Handle, CachedSelectors.arrayByExcludingToObjectsInArray_, out ___occuredException, sizeof( NObjective.RuntimeObject ), array );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public string componentsJoinedByString_( string @string ) {
			RuntimeObject ___occuredException;
			var ___wrappedstring = Runtime.CreateStringProxy( @string );
			var ___result = NativeMethods.componentsJoinedByString_( Handle, CachedSelectors.componentsJoinedByString_, out ___occuredException, sizeof( IntPtr ), ___wrappedstring );
			Runtime.ReleaseNativeObject( ___wrappedstring );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public bool containsObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.containsObject_( Handle, CachedSelectors.containsObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char containsObjectIdenticalTo_( NObjective.RuntimeObject to ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.containsObjectIdenticalTo_( Handle, CachedSelectors.containsObjectIdenticalTo_, out ___occuredException, sizeof( NObjective.RuntimeObject ), to );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public uint count() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.count( Handle, CachedSelectors.count, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public uint countOccurrences_( NObjective.RuntimeObject occurrences ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.countOccurrences_( Handle, CachedSelectors.countOccurrences_, out ___occuredException, sizeof( NObjective.RuntimeObject ), occurrences );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public string descriptionWithLocale_( NObjective.RuntimeObject locale ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.descriptionWithLocale_( Handle, CachedSelectors.descriptionWithLocale_, out ___occuredException, sizeof( NObjective.RuntimeObject ), locale );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public string descriptionWithLocale_indent_( NObjective.RuntimeObject locale, uint indent ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.descriptionWithLocale_indent_( Handle, CachedSelectors.descriptionWithLocale_indent_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ), locale, indent );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public NObjective.RuntimeObject firstObjectCommonWithArray_( NSArray array ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.firstObjectCommonWithArray_( Handle, CachedSelectors.firstObjectCommonWithArray_, out ___occuredException, sizeof( NSArray ), array );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char getObject_atIndex_( System.IntPtr @object, uint atIndex ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getObject_atIndex_( Handle, CachedSelectors.getObject_atIndex_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( uint ), @object, atIndex );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void getObjects_( IntPtr objects ) {
			RuntimeObject ___occuredException;
			NativeMethods.getObjects_( Handle, CachedSelectors.getObjects_, out ___occuredException, sizeof( IntPtr ), objects );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void getObjects_range_( IntPtr objects, _NSRange range ) {
			RuntimeObject ___occuredException;
			NativeMethods.getObjects_range_( Handle, CachedSelectors.getObjects_range_, out ___occuredException, sizeof( IntPtr ) + sizeof( _NSRange ), objects, range );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public uint indexOf___( NObjective.RuntimeObject of, uint unnamedParameter, char unnamedParameter2 ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.indexOf___( Handle, CachedSelectors.indexOf___, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ) + sizeof( char ), of, unnamedParameter, unnamedParameter2 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public uint indexOfAttributeBySelector_equalToObject_( NObjective.Selector selector, NObjective.RuntimeObject equalToObject ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.indexOfAttributeBySelector_equalToObject_( Handle, CachedSelectors.indexOfAttributeBySelector_equalToObject_, out ___occuredException, sizeof( NObjective.Selector ) + sizeof( NObjective.RuntimeObject ), selector, equalToObject );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public uint indexOfObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.indexOfObject_( Handle, CachedSelectors.indexOfObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public uint indexOfObject_inRange_( NObjective.RuntimeObject @object, _NSRange inRange ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.indexOfObject_inRange_( Handle, CachedSelectors.indexOfObject_inRange_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( _NSRange ), @object, inRange );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public uint indexOfObjectIdenticalTo_( NObjective.RuntimeObject to ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.indexOfObjectIdenticalTo_( Handle, CachedSelectors.indexOfObjectIdenticalTo_, out ___occuredException, sizeof( NObjective.RuntimeObject ), to );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public uint indexOfObjectIdenticalTo_inRange_( NObjective.RuntimeObject to, _NSRange inRange ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.indexOfObjectIdenticalTo_inRange_( Handle, CachedSelectors.indexOfObjectIdenticalTo_inRange_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( _NSRange ), to, inRange );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public NSArray initWithArray_( NSArray array ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithArray_( Handle, CachedSelectors.initWithArray_, out ___occuredException, sizeof( NSArray ), array );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public NSArray initWithArray_copyItems_( NSArray array, bool copyItems ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithArray_copyItems_( Handle, CachedSelectors.initWithArray_copyItems_, out ___occuredException, sizeof( NSArray ) + sizeof( bool ), array, copyItems );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		public NSArray initWithObjects_( NObjective.RuntimeObject objects ) {
			return new NSArray( Handle.InvokeIntPtrFast( CachedSelectors.initWithObjects_, CachedEncodings.__6F587D11, objects ) );
		}
		unsafe public NSArray initWithObjects_count_( IntPtr objects, uint count ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithObjects_count_( Handle, CachedSelectors.initWithObjects_count_, out ___occuredException, sizeof( IntPtr ) + sizeof( uint ), objects, count );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public bool isEqualToArray_( NSArray array ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isEqualToArray_( Handle, CachedSelectors.isEqualToArray_, out ___occuredException, sizeof( NSArray ), array );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject lastObject() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.lastObject( Handle, CachedSelectors.lastObject, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void makeObjectsPerformSelector_( NObjective.Selector selector ) {
			RuntimeObject ___occuredException;
			NativeMethods.makeObjectsPerformSelector_( Handle, CachedSelectors.makeObjectsPerformSelector_, out ___occuredException, sizeof( NObjective.Selector ), selector );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void makeObjectsPerformSelector_withObject_( NObjective.Selector selector, NObjective.RuntimeObject withObject ) {
			RuntimeObject ___occuredException;
			NativeMethods.makeObjectsPerformSelector_withObject_( Handle, CachedSelectors.makeObjectsPerformSelector_withObject_, out ___occuredException, sizeof( NObjective.Selector ) + sizeof( NObjective.RuntimeObject ), selector, withObject );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject objectAtIndex_( uint index ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectAtIndex_( Handle, CachedSelectors.objectAtIndex_, out ___occuredException, sizeof( uint ), index );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSEnumerator objectEnumerator() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectEnumerator( Handle, CachedSelectors.objectEnumerator, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSEnumerator( ___result );
		}
		unsafe public NSEnumerator reverseObjectEnumerator() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.reverseObjectEnumerator( Handle, CachedSelectors.reverseObjectEnumerator, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSEnumerator( ___result );
		}
		unsafe public NSArray subarrayWithRange_( _NSRange range ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.subarrayWithRange_( Handle, CachedSelectors.subarrayWithRange_, out ___occuredException, sizeof( _NSRange ), range );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr array( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr arrayByAddingObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr arrayByAddingObjects_count_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr objects, uint count );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr arrayByAddingObjectsFromArray_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray array );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr arrayByApplyingSelector_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr arrayByExcludingObjectsInArray_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject array );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr arrayByExcludingToObjectsInArray_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject array );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr arrayWithArray_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray array );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr arrayWithArray_copyItems_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject array, char copyItems );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr arrayWithObject_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr arrayWithObjects_count_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr objects, uint count );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr componentsJoinedByString_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr @string );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool containsObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char containsObjectIdenticalTo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject to );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint count( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint countOccurrences_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject occurrences );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr descriptionWithLocale_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject locale );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr descriptionWithLocale_indent_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject locale, uint indent );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr firstObjectCommonWithArray_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray array );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char getObject_atIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr @object, uint atIndex );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void getObjects_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr objects );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void getObjects_range_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr objects, _NSRange range );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint indexOf___( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject of, uint unnamedParameter, char unnamedParameter2 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint indexOfAttributeBySelector_equalToObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector, NObjective.RuntimeObject equalToObject );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint indexOfObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint indexOfObject_inRange_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, _NSRange inRange );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint indexOfObjectIdenticalTo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject to );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint indexOfObjectIdenticalTo_inRange_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject to, _NSRange inRange );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithArray_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray array );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithArray_copyItems_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray array, bool copyItems );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithObjects_count_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr objects, uint count );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isEqualToArray_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray array );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr lastObject( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void makeObjectsPerformSelector_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void makeObjectsPerformSelector_withObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector, NObjective.RuntimeObject withObject );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr objectAtIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint index );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr objectEnumerator( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr reverseObjectEnumerator( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr subarrayWithRange_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, _NSRange range );
		}
		static internal class CachedEncodings {
			public static readonly RuntimeMethodEncoding __6F587D11 = "@12@0:4@8";
		}
		static internal class CachedSelectors {
			public static readonly Selector array = "array";
			public static readonly Selector arrayByAddingObject_ = "arrayByAddingObject:";
			public static readonly Selector arrayByAddingObjects_count_ = "arrayByAddingObjects:count:";
			public static readonly Selector arrayByAddingObjectsFromArray_ = "arrayByAddingObjectsFromArray:";
			public static readonly Selector arrayByApplyingSelector_ = "arrayByApplyingSelector:";
			public static readonly Selector arrayByExcludingObjectsInArray_ = "arrayByExcludingObjectsInArray:";
			public static readonly Selector arrayByExcludingToObjectsInArray_ = "arrayByExcludingToObjectsInArray:";
			public static readonly Selector arrayWithArray_ = "arrayWithArray:";
			public static readonly Selector arrayWithArray_copyItems_ = "arrayWithArray:copyItems:";
			public static readonly Selector arrayWithObject_ = "arrayWithObject:";
			public static readonly Selector arrayWithObjects_ = "arrayWithObjects:";
			public static readonly Selector arrayWithObjects_count_ = "arrayWithObjects:count:";
			public static readonly Selector componentsJoinedByString_ = "componentsJoinedByString:";
			public static readonly Selector containsObject_ = "containsObject:";
			public static readonly Selector containsObjectIdenticalTo_ = "containsObjectIdenticalTo:";
			public static readonly Selector count = "count";
			public static readonly Selector countOccurrences_ = "countOccurrences:";
			public static readonly Selector descriptionWithLocale_ = "descriptionWithLocale:";
			public static readonly Selector descriptionWithLocale_indent_ = "descriptionWithLocale:indent:";
			public static readonly Selector firstObjectCommonWithArray_ = "firstObjectCommonWithArray:";
			public static readonly Selector getObject_atIndex_ = "getObject:atIndex:";
			public static readonly Selector getObjects_ = "getObjects:";
			public static readonly Selector getObjects_range_ = "getObjects:range:";
			public static readonly Selector indexOf___ = "indexOf:::";
			public static readonly Selector indexOfAttributeBySelector_equalToObject_ = "indexOfAttributeBySelector:equalToObject:";
			public static readonly Selector indexOfObject_ = "indexOfObject:";
			public static readonly Selector indexOfObject_inRange_ = "indexOfObject:inRange:";
			public static readonly Selector indexOfObjectIdenticalTo_ = "indexOfObjectIdenticalTo:";
			public static readonly Selector indexOfObjectIdenticalTo_inRange_ = "indexOfObjectIdenticalTo:inRange:";
			public static readonly Selector initWithArray_ = "initWithArray:";
			public static readonly Selector initWithArray_copyItems_ = "initWithArray:copyItems:";
			public static readonly Selector initWithObjects_ = "initWithObjects:";
			public static readonly Selector initWithObjects_count_ = "initWithObjects:count:";
			public static readonly Selector isEqualToArray_ = "isEqualToArray:";
			public static readonly Selector lastObject = "lastObject";
			public static readonly Selector makeObjectsPerformSelector_ = "makeObjectsPerformSelector:";
			public static readonly Selector makeObjectsPerformSelector_withObject_ = "makeObjectsPerformSelector:withObject:";
			public static readonly Selector objectAtIndex_ = "objectAtIndex:";
			public static readonly Selector objectEnumerator = "objectEnumerator";
			public static readonly Selector reverseObjectEnumerator = "reverseObjectEnumerator";
			public static readonly Selector subarrayWithRange_ = "subarrayWithRange:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSCalendar : IEquatable<NSCalendar> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSCalendar;
		public static implicit operator NSObject( NSCalendar value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSCalendar value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSCalendar value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSCalendar?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSCalendar value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSCalendar value1, NSCalendar value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSCalendar value1, NSCalendar value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSCalendar( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSCalendar alloc() {
			return new NSCalendar( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSMutableString ) )]
	public struct NSCFString : IEquatable<NSCFString> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSCFString;
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
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSData : IEquatable<NSData> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSData;
		public static implicit operator NSObject( NSData value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSData value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSData value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSData?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSData value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSData value1, NSData value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSData value1, NSData value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSData( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSData alloc() {
			return new NSData( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSDate : IEquatable<NSDate> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSDate;
		public static implicit operator NSObject( NSDate value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSDate value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSDate value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSDate?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSDate value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSDate value1, NSDate value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSDate value1, NSDate value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSDate( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSDate alloc() {
			return new NSDate( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject date() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.date( ClassHandle, CachedSelectors.date, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NSDate dateWithDate_( NObjective.RuntimeObject date ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dateWithDate_( ClassHandle, CachedSelectors.dateWithDate_, out ___occuredException, sizeof( NObjective.RuntimeObject ), date );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDate( ___result );
		}
		unsafe public static NSDate dateWithTimeInterval_sinceDate_( double interval, NObjective.RuntimeObject sinceDate ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dateWithTimeInterval_sinceDate_( ClassHandle, CachedSelectors.dateWithTimeInterval_sinceDate_, out ___occuredException, sizeof( double ) + sizeof( NObjective.RuntimeObject ), interval, sinceDate );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDate( ___result );
		}
		unsafe public static NSDate dateWithTimeIntervalSince1970_( double since1970 ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dateWithTimeIntervalSince1970_( ClassHandle, CachedSelectors.dateWithTimeIntervalSince1970_, out ___occuredException, sizeof( double ), since1970 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDate( ___result );
		}
		unsafe public static NSDate dateWithTimeIntervalSinceNow_( double now ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dateWithTimeIntervalSinceNow_( ClassHandle, CachedSelectors.dateWithTimeIntervalSinceNow_, out ___occuredException, sizeof( double ), now );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDate( ___result );
		}
		unsafe public static NSDate dateWithTimeIntervalSinceReferenceDate_( double date ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dateWithTimeIntervalSinceReferenceDate_( ClassHandle, CachedSelectors.dateWithTimeIntervalSinceReferenceDate_, out ___occuredException, sizeof( double ), date );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDate( ___result );
		}
		unsafe public static NObjective.RuntimeObject distantFuture() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.distantFuture( ClassHandle, CachedSelectors.distantFuture, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject distantPast() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.distantPast( ClassHandle, CachedSelectors.distantPast, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static double __timeIntervalSinceReferenceDate() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__timeIntervalSinceReferenceDate( ClassHandle, CachedSelectors.__timeIntervalSinceReferenceDate, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject addTimeInterval_( double interval ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.addTimeInterval_( Handle, CachedSelectors.addTimeInterval_, out ___occuredException, sizeof( double ), interval );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public int compare_( NSDate compare ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.compare_( Handle, CachedSelectors.compare_, out ___occuredException, sizeof( NSDate ), compare );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject dateByAddingTimeInterval_( double interval ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dateByAddingTimeInterval_( Handle, CachedSelectors.dateByAddingTimeInterval_, out ___occuredException, sizeof( double ), interval );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public string descriptionWithLocale_( NObjective.RuntimeObject locale ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.descriptionWithLocale_( Handle, CachedSelectors.descriptionWithLocale_, out ___occuredException, sizeof( NObjective.RuntimeObject ), locale );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public NSDate earlierDate_( NSDate date ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.earlierDate_( Handle, CachedSelectors.earlierDate_, out ___occuredException, sizeof( NSDate ), date );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDate( ___result );
		}
		unsafe public NSDate initWithDate_( NObjective.RuntimeObject date ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithDate_( Handle, CachedSelectors.initWithDate_, out ___occuredException, sizeof( NObjective.RuntimeObject ), date );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDate( ___result );
		}
		unsafe public NSDate initWithTimeInterval_sinceDate_( double interval, NSDate sinceDate ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithTimeInterval_sinceDate_( Handle, CachedSelectors.initWithTimeInterval_sinceDate_, out ___occuredException, sizeof( double ) + sizeof( NSDate ), interval, sinceDate );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDate( ___result );
		}
		unsafe public NSDate initWithTimeIntervalSince1970_( double since1970 ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithTimeIntervalSince1970_( Handle, CachedSelectors.initWithTimeIntervalSince1970_, out ___occuredException, sizeof( double ), since1970 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDate( ___result );
		}
		unsafe public NSDate initWithTimeIntervalSinceNow_( double now ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithTimeIntervalSinceNow_( Handle, CachedSelectors.initWithTimeIntervalSinceNow_, out ___occuredException, sizeof( double ), now );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDate( ___result );
		}
		unsafe public NSDate initWithTimeIntervalSinceReferenceDate_( double date ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithTimeIntervalSinceReferenceDate_( Handle, CachedSelectors.initWithTimeIntervalSinceReferenceDate_, out ___occuredException, sizeof( double ), date );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDate( ___result );
		}
		unsafe public bool isEqualToDate_( NSDate date ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isEqualToDate_( Handle, CachedSelectors.isEqualToDate_, out ___occuredException, sizeof( NSDate ), date );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NSDate laterDate_( NSDate date ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.laterDate_( Handle, CachedSelectors.laterDate_, out ___occuredException, sizeof( NSDate ), date );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDate( ___result );
		}
		unsafe public double timeIntervalSince1970() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.timeIntervalSince1970( Handle, CachedSelectors.timeIntervalSince1970, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public double timeIntervalSinceDate_( NSDate date ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.timeIntervalSinceDate_( Handle, CachedSelectors.timeIntervalSinceDate_, out ___occuredException, sizeof( NSDate ), date );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public double timeIntervalSinceNow() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.timeIntervalSinceNow( Handle, CachedSelectors.timeIntervalSinceNow, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public double timeIntervalSinceReferenceDate() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.timeIntervalSinceReferenceDate( Handle, CachedSelectors.timeIntervalSinceReferenceDate, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern double __timeIntervalSinceReferenceDate( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr addTimeInterval_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, double interval );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int compare_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDate compare );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr date( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr dateByAddingTimeInterval_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, double interval );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr dateWithDate_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject date );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr dateWithTimeInterval_sinceDate_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, double interval, NObjective.RuntimeObject sinceDate );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr dateWithTimeIntervalSince1970_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, double since1970 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr dateWithTimeIntervalSinceNow_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, double now );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr dateWithTimeIntervalSinceReferenceDate_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, double date );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr descriptionWithLocale_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject locale );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr distantFuture( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr distantPast( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr earlierDate_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDate date );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithDate_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject date );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithTimeInterval_sinceDate_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, double interval, NSDate sinceDate );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithTimeIntervalSince1970_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, double since1970 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithTimeIntervalSinceNow_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, double now );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithTimeIntervalSinceReferenceDate_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, double date );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isEqualToDate_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDate date );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr laterDate_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDate date );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern double timeIntervalSince1970( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern double timeIntervalSinceDate_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDate date );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern double timeIntervalSinceNow( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern double timeIntervalSinceReferenceDate( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector __timeIntervalSinceReferenceDate = "__timeIntervalSinceReferenceDate";
			public static readonly Selector addTimeInterval_ = "addTimeInterval:";
			public static readonly Selector compare_ = "compare:";
			public static readonly Selector date = "date";
			public static readonly Selector dateByAddingTimeInterval_ = "dateByAddingTimeInterval:";
			public static readonly Selector dateWithDate_ = "dateWithDate:";
			public static readonly Selector dateWithTimeInterval_sinceDate_ = "dateWithTimeInterval:sinceDate:";
			public static readonly Selector dateWithTimeIntervalSince1970_ = "dateWithTimeIntervalSince1970:";
			public static readonly Selector dateWithTimeIntervalSinceNow_ = "dateWithTimeIntervalSinceNow:";
			public static readonly Selector dateWithTimeIntervalSinceReferenceDate_ = "dateWithTimeIntervalSinceReferenceDate:";
			public static readonly Selector descriptionWithLocale_ = "descriptionWithLocale:";
			public static readonly Selector distantFuture = "distantFuture";
			public static readonly Selector distantPast = "distantPast";
			public static readonly Selector earlierDate_ = "earlierDate:";
			public static readonly Selector initWithDate_ = "initWithDate:";
			public static readonly Selector initWithTimeInterval_sinceDate_ = "initWithTimeInterval:sinceDate:";
			public static readonly Selector initWithTimeIntervalSince1970_ = "initWithTimeIntervalSince1970:";
			public static readonly Selector initWithTimeIntervalSinceNow_ = "initWithTimeIntervalSinceNow:";
			public static readonly Selector initWithTimeIntervalSinceReferenceDate_ = "initWithTimeIntervalSinceReferenceDate:";
			public static readonly Selector isEqualToDate_ = "isEqualToDate:";
			public static readonly Selector laterDate_ = "laterDate:";
			public static readonly Selector timeIntervalSince1970 = "timeIntervalSince1970";
			public static readonly Selector timeIntervalSinceDate_ = "timeIntervalSinceDate:";
			public static readonly Selector timeIntervalSinceNow = "timeIntervalSinceNow";
			public static readonly Selector timeIntervalSinceReferenceDate = "timeIntervalSinceReferenceDate";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSDateComponents : IEquatable<NSDateComponents> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSDateComponents;
		public static implicit operator NSObject( NSDateComponents value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSDateComponents value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSDateComponents value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSDateComponents?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSDateComponents value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSDateComponents value1, NSDateComponents value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSDateComponents value1, NSDateComponents value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSDateComponents( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSDateComponents alloc() {
			return new NSDateComponents( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSDictionary : IEquatable<NSDictionary> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSDictionary;
		public static implicit operator NSObject( NSDictionary value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSDictionary value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSDictionary value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSDictionary?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSDictionary value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSDictionary value1, NSDictionary value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSDictionary value1, NSDictionary value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSDictionary( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSDictionary alloc() {
			return new NSDictionary( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject dictionary() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dictionary( ClassHandle, CachedSelectors.dictionary, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NSDictionary dictionaryWithDictionary_( NSDictionary dictionary ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dictionaryWithDictionary_( ClassHandle, CachedSelectors.dictionaryWithDictionary_, out ___occuredException, sizeof( NSDictionary ), dictionary );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public static NSDictionary dictionaryWithObject_forKey_( NObjective.RuntimeObject @object, NObjective.RuntimeObject forKey ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dictionaryWithObject_forKey_( ClassHandle, CachedSelectors.dictionaryWithObject_forKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), @object, forKey );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public static NSDictionary dictionaryWithObjects_forKeys_( NSArray objects, NSArray forKeys ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dictionaryWithObjects_forKeys_( ClassHandle, CachedSelectors.dictionaryWithObjects_forKeys_, out ___occuredException, sizeof( NSArray ) + sizeof( NSArray ), objects, forKeys );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public static NSDictionary dictionaryWithObjects_forKeys_count_( IntPtr objects, IntPtr forKeys, uint count ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dictionaryWithObjects_forKeys_count_( ClassHandle, CachedSelectors.dictionaryWithObjects_forKeys_count_, out ___occuredException, sizeof( IntPtr ) + sizeof( IntPtr ) + sizeof( uint ), objects, forKeys, count );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		public static NSDictionary dictionaryWithObjectsAndKeys_( NObjective.RuntimeObject keys ) {
			return new NSDictionary( ClassHandle.InvokeIntPtrFast( CachedSelectors.dictionaryWithObjectsAndKeys_, CachedEncodings.__6F587D11, keys ) );
		}
		unsafe public NSArray allKeys() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.allKeys( Handle, CachedSelectors.allKeys, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public NSArray allKeysForObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.allKeysForObject_( Handle, CachedSelectors.allKeysForObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public NSArray allValues() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.allValues( Handle, CachedSelectors.allValues, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public char containsKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.containsKey_( Handle, CachedSelectors.containsKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char containsObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.containsObject_( Handle, CachedSelectors.containsObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public uint count() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.count( Handle, CachedSelectors.count, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public uint countForKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.countForKey_( Handle, CachedSelectors.countForKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public uint countForObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.countForObject_( Handle, CachedSelectors.countForObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public string descriptionWithLocale_( NObjective.RuntimeObject locale ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.descriptionWithLocale_( Handle, CachedSelectors.descriptionWithLocale_, out ___occuredException, sizeof( NObjective.RuntimeObject ), locale );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public string descriptionWithLocale_indent_( NObjective.RuntimeObject locale, uint indent ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.descriptionWithLocale_indent_( Handle, CachedSelectors.descriptionWithLocale_indent_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ), locale, indent );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public NObjective.RuntimeObject dictionaryByAddingObject_forKey_( NObjective.RuntimeObject @object, NObjective.RuntimeObject forKey ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dictionaryByAddingObject_forKey_( Handle, CachedSelectors.dictionaryByAddingObject_forKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), @object, forKey );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject dictionaryByAddingObjectsFromArray_forKeys_( NObjective.RuntimeObject array, NObjective.RuntimeObject forKeys ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dictionaryByAddingObjectsFromArray_forKeys_( Handle, CachedSelectors.dictionaryByAddingObjectsFromArray_forKeys_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), array, forKeys );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void getKeys_( System.IntPtr keys ) {
			RuntimeObject ___occuredException;
			NativeMethods.getKeys_( Handle, CachedSelectors.getKeys_, out ___occuredException, sizeof( System.IntPtr ), keys );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void getObjects_( System.IntPtr objects ) {
			RuntimeObject ___occuredException;
			NativeMethods.getObjects_( Handle, CachedSelectors.getObjects_, out ___occuredException, sizeof( System.IntPtr ), objects );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void getObjects_andKeys_( IntPtr objects, IntPtr andKeys ) {
			RuntimeObject ___occuredException;
			NativeMethods.getObjects_andKeys_( Handle, CachedSelectors.getObjects_andKeys_, out ___occuredException, sizeof( IntPtr ) + sizeof( IntPtr ), objects, andKeys );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSDictionary initWithDictionary_( NSDictionary dictionary ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithDictionary_( Handle, CachedSelectors.initWithDictionary_, out ___occuredException, sizeof( NSDictionary ), dictionary );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public NSDictionary initWithDictionary_copyItems_( NSDictionary dictionary, bool copyItems ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithDictionary_copyItems_( Handle, CachedSelectors.initWithDictionary_copyItems_, out ___occuredException, sizeof( NSDictionary ) + sizeof( bool ), dictionary, copyItems );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public NSDictionary initWithObjects_forKeys_( NSArray objects, NSArray forKeys ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithObjects_forKeys_( Handle, CachedSelectors.initWithObjects_forKeys_, out ___occuredException, sizeof( NSArray ) + sizeof( NSArray ), objects, forKeys );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public NSDictionary initWithObjects_forKeys_count_( IntPtr objects, IntPtr forKeys, uint count ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithObjects_forKeys_count_( Handle, CachedSelectors.initWithObjects_forKeys_count_, out ___occuredException, sizeof( IntPtr ) + sizeof( IntPtr ) + sizeof( uint ), objects, forKeys, count );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		public NSDictionary initWithObjectsAndKeys_( NObjective.RuntimeObject keys ) {
			return new NSDictionary( Handle.InvokeIntPtrFast( CachedSelectors.initWithObjectsAndKeys_, CachedEncodings.__6F587D11, keys ) );
		}
		unsafe public NObjective.RuntimeObject invertedDictionary() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.invertedDictionary( Handle, CachedSelectors.invertedDictionary, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public bool isEqualToDictionary_( NSDictionary dictionary ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isEqualToDictionary_( Handle, CachedSelectors.isEqualToDictionary_, out ___occuredException, sizeof( NSDictionary ), dictionary );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NSEnumerator keyEnumerator() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.keyEnumerator( Handle, CachedSelectors.keyEnumerator, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSEnumerator( ___result );
		}
		unsafe public NSEnumerator objectEnumerator() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectEnumerator( Handle, CachedSelectors.objectEnumerator, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSEnumerator( ___result );
		}
		unsafe public NObjective.RuntimeObject objectForKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectForKey_( Handle, CachedSelectors.objectForKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSArray objectsForKeys_notFoundMarker_( NSArray keys, NObjective.RuntimeObject notFoundMarker ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectsForKeys_notFoundMarker_( Handle, CachedSelectors.objectsForKeys_notFoundMarker_, out ___occuredException, sizeof( NSArray ) + sizeof( NObjective.RuntimeObject ), keys, notFoundMarker );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr allKeys( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr allKeysForObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr allValues( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char containsKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char containsObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint count( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint countForKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint countForObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr descriptionWithLocale_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject locale );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr descriptionWithLocale_indent_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject locale, uint indent );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr dictionary( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr dictionaryByAddingObject_forKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, NObjective.RuntimeObject forKey );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr dictionaryByAddingObjectsFromArray_forKeys_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject array, NObjective.RuntimeObject forKeys );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr dictionaryWithDictionary_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDictionary dictionary );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr dictionaryWithObject_forKey_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, NObjective.RuntimeObject forKey );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr dictionaryWithObjects_forKeys_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray objects, NSArray forKeys );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr dictionaryWithObjects_forKeys_count_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr objects, IntPtr forKeys, uint count );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void getKeys_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr keys );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void getObjects_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr objects );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void getObjects_andKeys_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr objects, IntPtr andKeys );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithDictionary_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDictionary dictionary );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithDictionary_copyItems_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDictionary dictionary, bool copyItems );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithObjects_forKeys_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray objects, NSArray forKeys );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithObjects_forKeys_count_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr objects, IntPtr forKeys, uint count );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr invertedDictionary( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isEqualToDictionary_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDictionary dictionary );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr keyEnumerator( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr objectEnumerator( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr objectForKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr objectsForKeys_notFoundMarker_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray keys, NObjective.RuntimeObject notFoundMarker );
		}
		static internal class CachedEncodings {
			public static readonly RuntimeMethodEncoding __6F587D11 = "@12@0:4@8";
		}
		static internal class CachedSelectors {
			public static readonly Selector allKeys = "allKeys";
			public static readonly Selector allKeysForObject_ = "allKeysForObject:";
			public static readonly Selector allValues = "allValues";
			public static readonly Selector containsKey_ = "containsKey:";
			public static readonly Selector containsObject_ = "containsObject:";
			public static readonly Selector count = "count";
			public static readonly Selector countForKey_ = "countForKey:";
			public static readonly Selector countForObject_ = "countForObject:";
			public static readonly Selector descriptionWithLocale_ = "descriptionWithLocale:";
			public static readonly Selector descriptionWithLocale_indent_ = "descriptionWithLocale:indent:";
			public static readonly Selector dictionary = "dictionary";
			public static readonly Selector dictionaryByAddingObject_forKey_ = "dictionaryByAddingObject:forKey:";
			public static readonly Selector dictionaryByAddingObjectsFromArray_forKeys_ = "dictionaryByAddingObjectsFromArray:forKeys:";
			public static readonly Selector dictionaryWithDictionary_ = "dictionaryWithDictionary:";
			public static readonly Selector dictionaryWithObject_forKey_ = "dictionaryWithObject:forKey:";
			public static readonly Selector dictionaryWithObjects_forKeys_ = "dictionaryWithObjects:forKeys:";
			public static readonly Selector dictionaryWithObjects_forKeys_count_ = "dictionaryWithObjects:forKeys:count:";
			public static readonly Selector dictionaryWithObjectsAndKeys_ = "dictionaryWithObjectsAndKeys:";
			public static readonly Selector getKeys_ = "getKeys:";
			public static readonly Selector getObjects_ = "getObjects:";
			public static readonly Selector getObjects_andKeys_ = "getObjects:andKeys:";
			public static readonly Selector initWithDictionary_ = "initWithDictionary:";
			public static readonly Selector initWithDictionary_copyItems_ = "initWithDictionary:copyItems:";
			public static readonly Selector initWithObjects_forKeys_ = "initWithObjects:forKeys:";
			public static readonly Selector initWithObjects_forKeys_count_ = "initWithObjects:forKeys:count:";
			public static readonly Selector initWithObjectsAndKeys_ = "initWithObjectsAndKeys:";
			public static readonly Selector invertedDictionary = "invertedDictionary";
			public static readonly Selector isEqualToDictionary_ = "isEqualToDictionary:";
			public static readonly Selector keyEnumerator = "keyEnumerator";
			public static readonly Selector objectEnumerator = "objectEnumerator";
			public static readonly Selector objectForKey_ = "objectForKey:";
			public static readonly Selector objectsForKeys_notFoundMarker_ = "objectsForKeys:notFoundMarker:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSEnumerator : IEquatable<NSEnumerator> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSEnumerator;
		public static implicit operator NSObject( NSEnumerator value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSEnumerator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSEnumerator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSEnumerator?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSEnumerator value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSEnumerator value1, NSEnumerator value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSEnumerator value1, NSEnumerator value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSEnumerator( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSEnumerator alloc() {
			return new NSEnumerator( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NSArray allObjects() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.allObjects( Handle, CachedSelectors.allObjects, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public NObjective.RuntimeObject nextObject() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.nextObject( Handle, CachedSelectors.nextObject, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr allObjects( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr nextObject( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector allObjects = "allObjects";
			public static readonly Selector nextObject = "nextObject";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSException : IEquatable<NSException> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSException;
		public static implicit operator NSObject( NSException value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSException value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSException value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSException?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSException value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSException value1, NSException value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSException value1, NSException value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSException( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSException alloc() {
			return new NSException( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NSException exceptionWithName_reason_userInfo_( string name, string reason, NSDictionary userInfo ) {
			RuntimeObject ___occuredException;
			var ___wrappedname = Runtime.CreateStringProxy( name );
			var ___wrappedreason = Runtime.CreateStringProxy( reason );
			var ___result = NativeMethods.exceptionWithName_reason_userInfo_( ClassHandle, CachedSelectors.exceptionWithName_reason_userInfo_, out ___occuredException, sizeof( IntPtr ) + sizeof( IntPtr ) + sizeof( NSDictionary ), ___wrappedname, ___wrappedreason, userInfo );
			Runtime.ReleaseNativeObject( ___wrappedname );
			Runtime.ReleaseNativeObject( ___wrappedreason );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSException( ___result );
		}
		public static void raise_format_( string raise, string format, params object[] variableArguments ) {
			ClassHandle.InvokeVoidFast( CachedSelectors.raise_format_, CachedEncodings.__E967B394, raise, format, variableArguments );
		}
		unsafe public static void raise_format_arguments_( string raise, string format, System.IntPtr arguments ) {
			RuntimeObject ___occuredException;
			var ___wrappedraise = Runtime.CreateStringProxy( raise );
			var ___wrappedformat = Runtime.CreateStringProxy( format );
			NativeMethods.raise_format_arguments_( ClassHandle, CachedSelectors.raise_format_arguments_, out ___occuredException, sizeof( IntPtr ) + sizeof( IntPtr ) + sizeof( System.IntPtr ), ___wrappedraise, ___wrappedformat, arguments );
			Runtime.ReleaseNativeObject( ___wrappedraise );
			Runtime.ReleaseNativeObject( ___wrappedformat );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSArray callStackReturnAddresses() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.callStackReturnAddresses( Handle, CachedSelectors.callStackReturnAddresses, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public NSException initWithName_reason_userInfo_( string name, string reason, NSDictionary userInfo ) {
			RuntimeObject ___occuredException;
			var ___wrappedname = Runtime.CreateStringProxy( name );
			var ___wrappedreason = Runtime.CreateStringProxy( reason );
			var ___result = NativeMethods.initWithName_reason_userInfo_( Handle, CachedSelectors.initWithName_reason_userInfo_, out ___occuredException, sizeof( IntPtr ) + sizeof( IntPtr ) + sizeof( NSDictionary ), ___wrappedname, ___wrappedreason, userInfo );
			Runtime.ReleaseNativeObject( ___wrappedname );
			Runtime.ReleaseNativeObject( ___wrappedreason );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSException( ___result );
		}
		unsafe public string name() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.name( Handle, CachedSelectors.name, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public void raise() {
			RuntimeObject ___occuredException;
			NativeMethods.raise( Handle, CachedSelectors.raise, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public string reason() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.reason( Handle, CachedSelectors.reason, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public NSDictionary userInfo() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.userInfo( Handle, CachedSelectors.userInfo, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr callStackReturnAddresses( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr exceptionWithName_reason_userInfo_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name, IntPtr reason, NSDictionary userInfo );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithName_reason_userInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name, IntPtr reason, NSDictionary userInfo );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr name( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void raise( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void raise_format_arguments_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr raise, IntPtr format, System.IntPtr arguments );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr reason( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr userInfo( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedEncodings {
			public static readonly RuntimeMethodEncoding __E967B394 = "v16@0:4@8@12";
		}
		static internal class CachedSelectors {
			public static readonly Selector callStackReturnAddresses = "callStackReturnAddresses";
			public static readonly Selector exceptionWithName_reason_userInfo_ = "exceptionWithName:reason:userInfo:";
			public static readonly Selector initWithName_reason_userInfo_ = "initWithName:reason:userInfo:";
			public static readonly Selector name = "name";
			public static readonly Selector raise = "raise";
			public static readonly Selector raise_format_ = "raise:format:";
			public static readonly Selector raise_format_arguments_ = "raise:format:arguments:";
			public static readonly Selector reason = "reason";
			public static readonly Selector userInfo = "userInfo";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSStream ) )]
	public struct NSInputStream : IEquatable<NSInputStream> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSInputStream;
		public static implicit operator NSStream( NSInputStream value ) {
			return new NSStream( value.Handle );
		}
		public static implicit operator NSObject( NSInputStream value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSInputStream value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSInputStream value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSInputStream?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSInputStream value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSInputStream value1, NSInputStream value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSInputStream value1, NSInputStream value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSInputStream( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSInputStream alloc() {
			return new NSInputStream( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSInvocation : IEquatable<NSInvocation> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSInvocation;
		public static implicit operator NSObject( NSInvocation value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSInvocation value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSInvocation value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSInvocation?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSInvocation value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSInvocation value1, NSInvocation value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSInvocation value1, NSInvocation value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSInvocation( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSInvocation alloc() {
			return new NSInvocation( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NSInvocation invocationWithMethodSignature_( NSMethodSignature signature ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.invocationWithMethodSignature_( ClassHandle, CachedSelectors.invocationWithMethodSignature_, out ___occuredException, sizeof( NSMethodSignature ), signature );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSInvocation( ___result );
		}
		unsafe public bool argumentsRetained() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.argumentsRetained( Handle, CachedSelectors.argumentsRetained, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void getArgument_atIndex_( IntPtr argument, int atIndex ) {
			RuntimeObject ___occuredException;
			NativeMethods.getArgument_atIndex_( Handle, CachedSelectors.getArgument_atIndex_, out ___occuredException, sizeof( IntPtr ) + sizeof( int ), argument, atIndex );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void getReturnValue_( IntPtr value ) {
			RuntimeObject ___occuredException;
			NativeMethods.getReturnValue_( Handle, CachedSelectors.getReturnValue_, out ___occuredException, sizeof( IntPtr ), value );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void invoke() {
			RuntimeObject ___occuredException;
			NativeMethods.invoke( Handle, CachedSelectors.invoke, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void invokeWithTarget_( NObjective.RuntimeObject target ) {
			RuntimeObject ___occuredException;
			NativeMethods.invokeWithTarget_( Handle, CachedSelectors.invokeWithTarget_, out ___occuredException, sizeof( NObjective.RuntimeObject ), target );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSMethodSignature methodSignature() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.methodSignature( Handle, CachedSelectors.methodSignature, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSMethodSignature( ___result );
		}
		unsafe public void retainArguments() {
			RuntimeObject ___occuredException;
			NativeMethods.retainArguments( Handle, CachedSelectors.retainArguments, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.Selector selector() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.selector( Handle, CachedSelectors.selector, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void setArgument_atIndex_( IntPtr argument, int atIndex ) {
			RuntimeObject ___occuredException;
			NativeMethods.setArgument_atIndex_( Handle, CachedSelectors.setArgument_atIndex_, out ___occuredException, sizeof( IntPtr ) + sizeof( int ), argument, atIndex );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setReturnValue_( IntPtr value ) {
			RuntimeObject ___occuredException;
			NativeMethods.setReturnValue_( Handle, CachedSelectors.setReturnValue_, out ___occuredException, sizeof( IntPtr ), value );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setSelector_( NObjective.Selector selector ) {
			RuntimeObject ___occuredException;
			NativeMethods.setSelector_( Handle, CachedSelectors.setSelector_, out ___occuredException, sizeof( NObjective.Selector ), selector );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setTarget_( NObjective.RuntimeObject target ) {
			RuntimeObject ___occuredException;
			NativeMethods.setTarget_( Handle, CachedSelectors.setTarget_, out ___occuredException, sizeof( NObjective.RuntimeObject ), target );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject target() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.target( Handle, CachedSelectors.target, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool argumentsRetained( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void getArgument_atIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr argument, int atIndex );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void getReturnValue_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr value );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr invocationWithMethodSignature_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSMethodSignature signature );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void invoke( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void invokeWithTarget_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject target );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr methodSignature( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void retainArguments( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern NObjective.Selector selector( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setArgument_atIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr argument, int atIndex );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setReturnValue_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr value );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setSelector_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setTarget_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject target );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr target( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector argumentsRetained = "argumentsRetained";
			public static readonly Selector getArgument_atIndex_ = "getArgument:atIndex:";
			public static readonly Selector getReturnValue_ = "getReturnValue:";
			public static readonly Selector invocationWithMethodSignature_ = "invocationWithMethodSignature:";
			public static readonly Selector invoke = "invoke";
			public static readonly Selector invokeWithTarget_ = "invokeWithTarget:";
			public static readonly Selector methodSignature = "methodSignature";
			public static readonly Selector retainArguments = "retainArguments";
			public static readonly Selector selector = "selector";
			public static readonly Selector setArgument_atIndex_ = "setArgument:atIndex:";
			public static readonly Selector setReturnValue_ = "setReturnValue:";
			public static readonly Selector setSelector_ = "setSelector:";
			public static readonly Selector setTarget_ = "setTarget:";
			public static readonly Selector target = "target";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSLocale : IEquatable<NSLocale> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSLocale;
		public static implicit operator NSObject( NSLocale value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSLocale value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSLocale value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSLocale?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSLocale value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSLocale value1, NSLocale value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSLocale value1, NSLocale value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSLocale( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSLocale alloc() {
			return new NSLocale( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	public struct NSMessageBuilder : IEquatable<NSMessageBuilder> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSMessageBuilder;
		public override int GetHashCode() {
			return Handle.GetHashCode();
		}
		public static implicit operator IntPtr( NSMessageBuilder value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSMessageBuilder value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSMessageBuilder?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSMessageBuilder value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSMessageBuilder value1, NSMessageBuilder value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSMessageBuilder value1, NSMessageBuilder value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSMessageBuilder( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSMessageBuilder alloc() {
			return new NSMessageBuilder( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		public override string ToString() {
			return Handle.InvokeString( Selectors.description );
		}
		unsafe public static void initialize() {
			RuntimeObject ___occuredException;
			NativeMethods.initialize( ClassHandle, CachedSelectors.initialize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void initialize( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector initialize = "initialize";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSMethodSignature : IEquatable<NSMethodSignature> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSMethodSignature;
		public static implicit operator NSObject( NSMethodSignature value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSMethodSignature value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSMethodSignature value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSMethodSignature?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSMethodSignature value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSMethodSignature value1, NSMethodSignature value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSMethodSignature value1, NSMethodSignature value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSMethodSignature( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSMethodSignature alloc() {
			return new NSMethodSignature( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NSMethodSignature signatureWithObjCTypes_( IntPtr types ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.signatureWithObjCTypes_( ClassHandle, CachedSelectors.signatureWithObjCTypes_, out ___occuredException, sizeof( IntPtr ), types );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSMethodSignature( ___result );
		}
		unsafe public uint frameLength() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.frameLength( Handle, CachedSelectors.frameLength, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public IntPtr getArgumentTypeAtIndex_( uint index ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getArgumentTypeAtIndex_( Handle, CachedSelectors.getArgumentTypeAtIndex_, out ___occuredException, sizeof( uint ), index );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isOneway() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isOneway( Handle, CachedSelectors.isOneway, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public uint methodReturnLength() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.methodReturnLength( Handle, CachedSelectors.methodReturnLength, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public IntPtr methodReturnType() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.methodReturnType( Handle, CachedSelectors.methodReturnType, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public uint numberOfArguments() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.numberOfArguments( Handle, CachedSelectors.numberOfArguments, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint frameLength( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern System.IntPtr getArgumentTypeAtIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint index );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isOneway( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint methodReturnLength( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern System.IntPtr methodReturnType( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint numberOfArguments( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr signatureWithObjCTypes_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr types );
		}
		static internal class CachedSelectors {
			public static readonly Selector frameLength = "frameLength";
			public static readonly Selector getArgumentTypeAtIndex_ = "getArgumentTypeAtIndex:";
			public static readonly Selector isOneway = "isOneway";
			public static readonly Selector methodReturnLength = "methodReturnLength";
			public static readonly Selector methodReturnType = "methodReturnType";
			public static readonly Selector numberOfArguments = "numberOfArguments";
			public static readonly Selector signatureWithObjCTypes_ = "signatureWithObjCTypes:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSArray ) )]
	public struct NSMutableArray : IEquatable<NSMutableArray> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSMutableArray;
		public static implicit operator NSArray( NSMutableArray value ) {
			return new NSArray( value.Handle );
		}
		public static implicit operator NSObject( NSMutableArray value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSMutableArray value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSMutableArray value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSMutableArray?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSMutableArray value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSMutableArray value1, NSMutableArray value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSMutableArray value1, NSMutableArray value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSMutableArray( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSMutableArray alloc() {
			return new NSMutableArray( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject arrayWithCapacity_( uint capacity ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.arrayWithCapacity_( ClassHandle, CachedSelectors.arrayWithCapacity_, out ___occuredException, sizeof( uint ), capacity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void addObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			NativeMethods.addObject_( Handle, CachedSelectors.addObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void addObjectsFromArray_( NSArray array ) {
			RuntimeObject ___occuredException;
			NativeMethods.addObjectsFromArray_( Handle, CachedSelectors.addObjectsFromArray_, out ___occuredException, sizeof( NSArray ), array );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void exchange__( uint exchange, uint unnamedParameter ) {
			RuntimeObject ___occuredException;
			NativeMethods.exchange__( Handle, CachedSelectors.exchange__, out ___occuredException, sizeof( uint ) + sizeof( uint ), exchange, unnamedParameter );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void exchangeObjectAtIndex_withObjectAtIndex_( uint index, uint withObjectAtIndex ) {
			RuntimeObject ___occuredException;
			NativeMethods.exchangeObjectAtIndex_withObjectAtIndex_( Handle, CachedSelectors.exchangeObjectAtIndex_withObjectAtIndex_, out ___occuredException, sizeof( uint ) + sizeof( uint ), index, withObjectAtIndex );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSMutableArray initWithCapacity_( uint capacity ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCapacity_( Handle, CachedSelectors.initWithCapacity_, out ___occuredException, sizeof( uint ), capacity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSMutableArray( ___result );
		}
		unsafe public void insertObject_atIndex_( NObjective.RuntimeObject @object, uint atIndex ) {
			RuntimeObject ___occuredException;
			NativeMethods.insertObject_atIndex_( Handle, CachedSelectors.insertObject_atIndex_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ), @object, atIndex );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeAllObjects() {
			RuntimeObject ___occuredException;
			NativeMethods.removeAllObjects( Handle, CachedSelectors.removeAllObjects, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeLastObject() {
			RuntimeObject ___occuredException;
			NativeMethods.removeLastObject( Handle, CachedSelectors.removeLastObject, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			NativeMethods.removeObject_( Handle, CachedSelectors.removeObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeObject_inRange_( NObjective.RuntimeObject @object, _NSRange inRange ) {
			RuntimeObject ___occuredException;
			NativeMethods.removeObject_inRange_( Handle, CachedSelectors.removeObject_inRange_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( _NSRange ), @object, inRange );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeObjectAtIndex_( uint index ) {
			RuntimeObject ___occuredException;
			NativeMethods.removeObjectAtIndex_( Handle, CachedSelectors.removeObjectAtIndex_, out ___occuredException, sizeof( uint ), index );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeObjectIdenticalTo_( NObjective.RuntimeObject to ) {
			RuntimeObject ___occuredException;
			NativeMethods.removeObjectIdenticalTo_( Handle, CachedSelectors.removeObjectIdenticalTo_, out ___occuredException, sizeof( NObjective.RuntimeObject ), to );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeObjectIdenticalTo_inRange_( NObjective.RuntimeObject to, _NSRange inRange ) {
			RuntimeObject ___occuredException;
			NativeMethods.removeObjectIdenticalTo_inRange_( Handle, CachedSelectors.removeObjectIdenticalTo_inRange_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( _NSRange ), to, inRange );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeObjectsInArray_( NSArray array ) {
			RuntimeObject ___occuredException;
			NativeMethods.removeObjectsInArray_( Handle, CachedSelectors.removeObjectsInArray_, out ___occuredException, sizeof( NSArray ), array );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeObjectsInRange_( _NSRange range ) {
			RuntimeObject ___occuredException;
			NativeMethods.removeObjectsInRange_( Handle, CachedSelectors.removeObjectsInRange_, out ___occuredException, sizeof( _NSRange ), range );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void replaceObjectAtIndex_withObject_( uint index, NObjective.RuntimeObject withObject ) {
			RuntimeObject ___occuredException;
			NativeMethods.replaceObjectAtIndex_withObject_( Handle, CachedSelectors.replaceObjectAtIndex_withObject_, out ___occuredException, sizeof( uint ) + sizeof( NObjective.RuntimeObject ), index, withObject );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void replaceObjectsInRange_withObjectsFromArray_( _NSRange range, NSArray withObjectsFromArray ) {
			RuntimeObject ___occuredException;
			NativeMethods.replaceObjectsInRange_withObjectsFromArray_( Handle, CachedSelectors.replaceObjectsInRange_withObjectsFromArray_, out ___occuredException, sizeof( _NSRange ) + sizeof( NSArray ), range, withObjectsFromArray );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void replaceObjectsInRange_withObjectsFromArray_range_( _NSRange range, NSArray withObjectsFromArray, _NSRange range2 ) {
			RuntimeObject ___occuredException;
			NativeMethods.replaceObjectsInRange_withObjectsFromArray_range_( Handle, CachedSelectors.replaceObjectsInRange_withObjectsFromArray_range_, out ___occuredException, sizeof( _NSRange ) + sizeof( NSArray ) + sizeof( _NSRange ), range, withObjectsFromArray, range2 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setArray_( NSArray array ) {
			RuntimeObject ___occuredException;
			NativeMethods.setArray_( Handle, CachedSelectors.setArray_, out ___occuredException, sizeof( NSArray ), array );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setObject_atIndex_( NObjective.RuntimeObject @object, uint atIndex ) {
			RuntimeObject ___occuredException;
			NativeMethods.setObject_atIndex_( Handle, CachedSelectors.setObject_atIndex_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ), @object, atIndex );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void addObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void addObjectsFromArray_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray array );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr arrayWithCapacity_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint capacity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void exchange__( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint exchange, uint unnamedParameter );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void exchangeObjectAtIndex_withObjectAtIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint index, uint withObjectAtIndex );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCapacity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint capacity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void insertObject_atIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, uint atIndex );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void removeAllObjects( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void removeLastObject( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void removeObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void removeObject_inRange_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, _NSRange inRange );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void removeObjectAtIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint index );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void removeObjectIdenticalTo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject to );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void removeObjectIdenticalTo_inRange_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject to, _NSRange inRange );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void removeObjectsInArray_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray array );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void removeObjectsInRange_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, _NSRange range );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void replaceObjectAtIndex_withObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint index, NObjective.RuntimeObject withObject );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void replaceObjectsInRange_withObjectsFromArray_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, _NSRange range, NSArray withObjectsFromArray );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void replaceObjectsInRange_withObjectsFromArray_range_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, _NSRange range, NSArray withObjectsFromArray, _NSRange range2 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setArray_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray array );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setObject_atIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, uint atIndex );
		}
		static internal class CachedSelectors {
			public static readonly Selector addObject_ = "addObject:";
			public static readonly Selector addObjectsFromArray_ = "addObjectsFromArray:";
			public static readonly Selector arrayWithCapacity_ = "arrayWithCapacity:";
			public static readonly Selector exchange__ = "exchange::";
			public static readonly Selector exchangeObjectAtIndex_withObjectAtIndex_ = "exchangeObjectAtIndex:withObjectAtIndex:";
			public static readonly Selector initWithCapacity_ = "initWithCapacity:";
			public static readonly Selector insertObject_atIndex_ = "insertObject:atIndex:";
			public static readonly Selector removeAllObjects = "removeAllObjects";
			public static readonly Selector removeLastObject = "removeLastObject";
			public static readonly Selector removeObject_ = "removeObject:";
			public static readonly Selector removeObject_inRange_ = "removeObject:inRange:";
			public static readonly Selector removeObjectAtIndex_ = "removeObjectAtIndex:";
			public static readonly Selector removeObjectIdenticalTo_ = "removeObjectIdenticalTo:";
			public static readonly Selector removeObjectIdenticalTo_inRange_ = "removeObjectIdenticalTo:inRange:";
			public static readonly Selector removeObjectsInArray_ = "removeObjectsInArray:";
			public static readonly Selector removeObjectsInRange_ = "removeObjectsInRange:";
			public static readonly Selector replaceObjectAtIndex_withObject_ = "replaceObjectAtIndex:withObject:";
			public static readonly Selector replaceObjectsInRange_withObjectsFromArray_ = "replaceObjectsInRange:withObjectsFromArray:";
			public static readonly Selector replaceObjectsInRange_withObjectsFromArray_range_ = "replaceObjectsInRange:withObjectsFromArray:range:";
			public static readonly Selector setArray_ = "setArray:";
			public static readonly Selector setObject_atIndex_ = "setObject:atIndex:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSData ) )]
	public struct NSMutableData : IEquatable<NSMutableData> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSMutableData;
		public static implicit operator NSData( NSMutableData value ) {
			return new NSData( value.Handle );
		}
		public static implicit operator NSObject( NSMutableData value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSMutableData value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSMutableData value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSMutableData?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSMutableData value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSMutableData value1, NSMutableData value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSMutableData value1, NSMutableData value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSMutableData( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSMutableData alloc() {
			return new NSMutableData( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSDictionary ) )]
	public struct NSMutableDictionary : IEquatable<NSMutableDictionary> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSMutableDictionary;
		public static implicit operator NSDictionary( NSMutableDictionary value ) {
			return new NSDictionary( value.Handle );
		}
		public static implicit operator NSObject( NSMutableDictionary value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSMutableDictionary value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSMutableDictionary value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSMutableDictionary?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSMutableDictionary value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSMutableDictionary value1, NSMutableDictionary value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSMutableDictionary value1, NSMutableDictionary value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSMutableDictionary( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSMutableDictionary alloc() {
			return new NSMutableDictionary( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject dictionaryWithCapacity_( uint capacity ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dictionaryWithCapacity_( ClassHandle, CachedSelectors.dictionaryWithCapacity_, out ___occuredException, sizeof( uint ), capacity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void addEntriesFromDictionary_( NSDictionary dictionary ) {
			RuntimeObject ___occuredException;
			NativeMethods.addEntriesFromDictionary_( Handle, CachedSelectors.addEntriesFromDictionary_, out ___occuredException, sizeof( NSDictionary ), dictionary );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSMutableDictionary initWithCapacity_( uint capacity ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCapacity_( Handle, CachedSelectors.initWithCapacity_, out ___occuredException, sizeof( uint ), capacity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSMutableDictionary( ___result );
		}
		unsafe public void invert() {
			RuntimeObject ___occuredException;
			NativeMethods.invert( Handle, CachedSelectors.invert, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeAllObjects() {
			RuntimeObject ___occuredException;
			NativeMethods.removeAllObjects( Handle, CachedSelectors.removeAllObjects, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeKeysForObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			NativeMethods.removeKeysForObject_( Handle, CachedSelectors.removeKeysForObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeObjectForKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			NativeMethods.removeObjectForKey_( Handle, CachedSelectors.removeObjectForKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeObjectsForKeys_( NSArray keys ) {
			RuntimeObject ___occuredException;
			NativeMethods.removeObjectsForKeys_( Handle, CachedSelectors.removeObjectsForKeys_, out ___occuredException, sizeof( NSArray ), keys );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setDictionary_( NSDictionary dictionary ) {
			RuntimeObject ___occuredException;
			NativeMethods.setDictionary_( Handle, CachedSelectors.setDictionary_, out ___occuredException, sizeof( NSDictionary ), dictionary );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setObject_forKey_( NObjective.RuntimeObject @object, NObjective.RuntimeObject forKey ) {
			RuntimeObject ___occuredException;
			NativeMethods.setObject_forKey_( Handle, CachedSelectors.setObject_forKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), @object, forKey );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void addEntriesFromDictionary_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDictionary dictionary );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr dictionaryWithCapacity_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint capacity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCapacity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint capacity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void invert( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void removeAllObjects( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void removeKeysForObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void removeObjectForKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void removeObjectsForKeys_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray keys );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setDictionary_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDictionary dictionary );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setObject_forKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, NObjective.RuntimeObject forKey );
		}
		static internal class CachedSelectors {
			public static readonly Selector addEntriesFromDictionary_ = "addEntriesFromDictionary:";
			public static readonly Selector dictionaryWithCapacity_ = "dictionaryWithCapacity:";
			public static readonly Selector initWithCapacity_ = "initWithCapacity:";
			public static readonly Selector invert = "invert";
			public static readonly Selector removeAllObjects = "removeAllObjects";
			public static readonly Selector removeKeysForObject_ = "removeKeysForObject:";
			public static readonly Selector removeObjectForKey_ = "removeObjectForKey:";
			public static readonly Selector removeObjectsForKeys_ = "removeObjectsForKeys:";
			public static readonly Selector setDictionary_ = "setDictionary:";
			public static readonly Selector setObject_forKey_ = "setObject:forKey:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSOrderedSet ) )]
	public struct NSMutableOrderedSet : IEquatable<NSMutableOrderedSet> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSMutableOrderedSet;
		public static implicit operator NSOrderedSet( NSMutableOrderedSet value ) {
			return new NSOrderedSet( value.Handle );
		}
		public static implicit operator NSObject( NSMutableOrderedSet value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSMutableOrderedSet value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSMutableOrderedSet value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSMutableOrderedSet?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSMutableOrderedSet value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSMutableOrderedSet value1, NSMutableOrderedSet value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSMutableOrderedSet value1, NSMutableOrderedSet value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSMutableOrderedSet( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSMutableOrderedSet alloc() {
			return new NSMutableOrderedSet( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject orderedSetWithCapacity_( uint capacity ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.orderedSetWithCapacity_( ClassHandle, CachedSelectors.orderedSetWithCapacity_, out ___occuredException, sizeof( uint ), capacity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void addObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			NativeMethods.addObject_( Handle, CachedSelectors.addObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void addObjectsFromArray_( NObjective.RuntimeObject array ) {
			RuntimeObject ___occuredException;
			NativeMethods.addObjectsFromArray_( Handle, CachedSelectors.addObjectsFromArray_, out ___occuredException, sizeof( NObjective.RuntimeObject ), array );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void addObjectsFromOrderedSet_( NObjective.RuntimeObject @set ) {
			RuntimeObject ___occuredException;
			NativeMethods.addObjectsFromOrderedSet_( Handle, CachedSelectors.addObjectsFromOrderedSet_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void exchangeObjectAtIndex_withObjectAtIndex_( uint index, uint withObjectAtIndex ) {
			RuntimeObject ___occuredException;
			NativeMethods.exchangeObjectAtIndex_withObjectAtIndex_( Handle, CachedSelectors.exchangeObjectAtIndex_withObjectAtIndex_, out ___occuredException, sizeof( uint ) + sizeof( uint ), index, withObjectAtIndex );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSMutableOrderedSet initWithCapacity_( uint capacity ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCapacity_( Handle, CachedSelectors.initWithCapacity_, out ___occuredException, sizeof( uint ), capacity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSMutableOrderedSet( ___result );
		}
		unsafe public void insertObject_atIndex_( NObjective.RuntimeObject @object, uint atIndex ) {
			RuntimeObject ___occuredException;
			NativeMethods.insertObject_atIndex_( Handle, CachedSelectors.insertObject_atIndex_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ), @object, atIndex );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void intersectOrderedSet_( NObjective.RuntimeObject @set ) {
			RuntimeObject ___occuredException;
			NativeMethods.intersectOrderedSet_( Handle, CachedSelectors.intersectOrderedSet_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void intersectSet_( NObjective.RuntimeObject @set ) {
			RuntimeObject ___occuredException;
			NativeMethods.intersectSet_( Handle, CachedSelectors.intersectSet_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void minusOrderedSSet_( NObjective.RuntimeObject @set ) {
			RuntimeObject ___occuredException;
			NativeMethods.minusOrderedSSet_( Handle, CachedSelectors.minusOrderedSSet_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void minusSet_( NObjective.RuntimeObject @set ) {
			RuntimeObject ___occuredException;
			NativeMethods.minusSet_( Handle, CachedSelectors.minusSet_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeAllObjects() {
			RuntimeObject ___occuredException;
			NativeMethods.removeAllObjects( Handle, CachedSelectors.removeAllObjects, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			NativeMethods.removeObject_( Handle, CachedSelectors.removeObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeObjectAtIndex_( uint index ) {
			RuntimeObject ___occuredException;
			NativeMethods.removeObjectAtIndex_( Handle, CachedSelectors.removeObjectAtIndex_, out ___occuredException, sizeof( uint ), index );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void replaceObjectAtIndex_withObject_( uint index, NObjective.RuntimeObject withObject ) {
			RuntimeObject ___occuredException;
			NativeMethods.replaceObjectAtIndex_withObject_( Handle, CachedSelectors.replaceObjectAtIndex_withObject_, out ___occuredException, sizeof( uint ) + sizeof( NObjective.RuntimeObject ), index, withObject );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setObject_atIndex_( NObjective.RuntimeObject @object, uint atIndex ) {
			RuntimeObject ___occuredException;
			NativeMethods.setObject_atIndex_( Handle, CachedSelectors.setObject_atIndex_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ), @object, atIndex );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void unionOrderedSSet_( NObjective.RuntimeObject @set ) {
			RuntimeObject ___occuredException;
			NativeMethods.unionOrderedSSet_( Handle, CachedSelectors.unionOrderedSSet_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void unionSet_( NObjective.RuntimeObject @set ) {
			RuntimeObject ___occuredException;
			NativeMethods.unionSet_( Handle, CachedSelectors.unionSet_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void addObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void addObjectsFromArray_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject array );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void addObjectsFromOrderedSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @set );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void exchangeObjectAtIndex_withObjectAtIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint index, uint withObjectAtIndex );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCapacity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint capacity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void insertObject_atIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, uint atIndex );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void intersectOrderedSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @set );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void intersectSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @set );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void minusOrderedSSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @set );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void minusSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @set );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr orderedSetWithCapacity_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint capacity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void removeAllObjects( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void removeObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void removeObjectAtIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint index );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void replaceObjectAtIndex_withObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint index, NObjective.RuntimeObject withObject );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setObject_atIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, uint atIndex );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void unionOrderedSSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @set );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void unionSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @set );
		}
		static internal class CachedSelectors {
			public static readonly Selector addObject_ = "addObject:";
			public static readonly Selector addObjectsFromArray_ = "addObjectsFromArray:";
			public static readonly Selector addObjectsFromOrderedSet_ = "addObjectsFromOrderedSet:";
			public static readonly Selector exchangeObjectAtIndex_withObjectAtIndex_ = "exchangeObjectAtIndex:withObjectAtIndex:";
			public static readonly Selector initWithCapacity_ = "initWithCapacity:";
			public static readonly Selector insertObject_atIndex_ = "insertObject:atIndex:";
			public static readonly Selector intersectOrderedSet_ = "intersectOrderedSet:";
			public static readonly Selector intersectSet_ = "intersectSet:";
			public static readonly Selector minusOrderedSSet_ = "minusOrderedSSet:";
			public static readonly Selector minusSet_ = "minusSet:";
			public static readonly Selector orderedSetWithCapacity_ = "orderedSetWithCapacity:";
			public static readonly Selector removeAllObjects = "removeAllObjects";
			public static readonly Selector removeObject_ = "removeObject:";
			public static readonly Selector removeObjectAtIndex_ = "removeObjectAtIndex:";
			public static readonly Selector replaceObjectAtIndex_withObject_ = "replaceObjectAtIndex:withObject:";
			public static readonly Selector setObject_atIndex_ = "setObject:atIndex:";
			public static readonly Selector unionOrderedSSet_ = "unionOrderedSSet:";
			public static readonly Selector unionSet_ = "unionSet:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSSet ) )]
	public struct NSMutableSet : IEquatable<NSMutableSet> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSMutableSet;
		public static implicit operator NSSet( NSMutableSet value ) {
			return new NSSet( value.Handle );
		}
		public static implicit operator NSObject( NSMutableSet value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSMutableSet value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSMutableSet value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSMutableSet?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSMutableSet value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSMutableSet value1, NSMutableSet value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSMutableSet value1, NSMutableSet value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSMutableSet( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSMutableSet alloc() {
			return new NSMutableSet( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject setWithCapacity_( uint capacity ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.setWithCapacity_( ClassHandle, CachedSelectors.setWithCapacity_, out ___occuredException, sizeof( uint ), capacity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void addObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			NativeMethods.addObject_( Handle, CachedSelectors.addObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void addObjectsFromArray_( NSArray array ) {
			RuntimeObject ___occuredException;
			NativeMethods.addObjectsFromArray_( Handle, CachedSelectors.addObjectsFromArray_, out ___occuredException, sizeof( NSArray ), array );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSMutableSet initWithCapacity_( uint capacity ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCapacity_( Handle, CachedSelectors.initWithCapacity_, out ___occuredException, sizeof( uint ), capacity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSMutableSet( ___result );
		}
		unsafe public void intersectSet_( NSSet @set ) {
			RuntimeObject ___occuredException;
			NativeMethods.intersectSet_( Handle, CachedSelectors.intersectSet_, out ___occuredException, sizeof( NSSet ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void minusSet_( NSSet @set ) {
			RuntimeObject ___occuredException;
			NativeMethods.minusSet_( Handle, CachedSelectors.minusSet_, out ___occuredException, sizeof( NSSet ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeAllObjects() {
			RuntimeObject ___occuredException;
			NativeMethods.removeAllObjects( Handle, CachedSelectors.removeAllObjects, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			NativeMethods.removeObject_( Handle, CachedSelectors.removeObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setSet_( NSSet @set ) {
			RuntimeObject ___occuredException;
			NativeMethods.setSet_( Handle, CachedSelectors.setSet_, out ___occuredException, sizeof( NSSet ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void unionSet_( NSSet @set ) {
			RuntimeObject ___occuredException;
			NativeMethods.unionSet_( Handle, CachedSelectors.unionSet_, out ___occuredException, sizeof( NSSet ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void addObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void addObjectsFromArray_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray array );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCapacity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint capacity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void intersectSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSSet @set );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void minusSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSSet @set );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void removeAllObjects( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void removeObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSSet @set );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr setWithCapacity_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint capacity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void unionSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSSet @set );
		}
		static internal class CachedSelectors {
			public static readonly Selector addObject_ = "addObject:";
			public static readonly Selector addObjectsFromArray_ = "addObjectsFromArray:";
			public static readonly Selector initWithCapacity_ = "initWithCapacity:";
			public static readonly Selector intersectSet_ = "intersectSet:";
			public static readonly Selector minusSet_ = "minusSet:";
			public static readonly Selector removeAllObjects = "removeAllObjects";
			public static readonly Selector removeObject_ = "removeObject:";
			public static readonly Selector setSet_ = "setSet:";
			public static readonly Selector setWithCapacity_ = "setWithCapacity:";
			public static readonly Selector unionSet_ = "unionSet:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSNull : IEquatable<NSNull> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSNull;
		public static implicit operator NSObject( NSNull value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSNull value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSNull value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSNull?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSNull value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSNull value1, NSNull value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSNull value1, NSNull value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSNull( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSNull alloc() {
			return new NSNull( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NSNull @null() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.@null( ClassHandle, CachedSelectors.@null, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSNull( ___result );
		}
		unsafe public void release() {
			RuntimeObject ___occuredException;
			NativeMethods.release( Handle, CachedSelectors.release, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr @null( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void release( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector @null = "null";
			public static readonly Selector release = "release";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	public struct NSObject : IEquatable<NSObject> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSObject;
		public override int GetHashCode() {
			return Handle.GetHashCode();
		}
		public static implicit operator IntPtr( NSObject value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSObject value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSObject?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSObject value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSObject value1, NSObject value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSObject value1, NSObject value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSObject( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSObject alloc() {
			return new NSObject( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		public override string ToString() {
			return Handle.InvokeString( Selectors.description );
		}
		unsafe public static NObjective.RuntimeObject autorelease() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.autorelease( ClassHandle, CachedSelectors.autorelease, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeClass __class() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__class( ClassHandle, CachedSelectors.__class, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static bool __conformsToProtocol_( Protocol protocol ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__conformsToProtocol_( ClassHandle, CachedSelectors.__conformsToProtocol_, out ___occuredException, sizeof( Protocol ), protocol );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static NObjective.RuntimeObject __copy() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__copy( ClassHandle, CachedSelectors.__copy, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject __debugDescription() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__debugDescription( ClassHandle, CachedSelectors.__debugDescription, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static string __description() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__description( ClassHandle, CachedSelectors.__description, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public static void __doesNotRecognizeSelector_( NObjective.Selector selector ) {
			RuntimeObject ___occuredException;
			NativeMethods.__doesNotRecognizeSelector_( ClassHandle, CachedSelectors.__doesNotRecognizeSelector_, out ___occuredException, sizeof( NObjective.Selector ), selector );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static NObjective.RuntimeObject __forwardingTargetForSelector_( NObjective.Selector selector ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__forwardingTargetForSelector_( ClassHandle, CachedSelectors.__forwardingTargetForSelector_, out ___occuredException, sizeof( NObjective.Selector ), selector );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static void __forwardInvocation_( NObjective.RuntimeObject invocation ) {
			RuntimeObject ___occuredException;
			NativeMethods.__forwardInvocation_( ClassHandle, CachedSelectors.__forwardInvocation_, out ___occuredException, sizeof( NObjective.RuntimeObject ), invocation );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static uint __hash() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__hash( ClassHandle, CachedSelectors.__hash, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public static NSMethodSignature instanceMethodSignatureForSelector_( NObjective.Selector selector ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.instanceMethodSignatureForSelector_( ClassHandle, CachedSelectors.instanceMethodSignatureForSelector_, out ___occuredException, sizeof( NObjective.Selector ), selector );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSMethodSignature( ___result );
		}
		unsafe public static bool instancesRespondToSelector_( NObjective.Selector selector ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.instancesRespondToSelector_( ClassHandle, CachedSelectors.instancesRespondToSelector_, out ___occuredException, sizeof( NObjective.Selector ), selector );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static bool isAncestorOfObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isAncestorOfObject_( ClassHandle, CachedSelectors.isAncestorOfObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static char __isEqual_( NObjective.RuntimeObject equal ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__isEqual_( ClassHandle, CachedSelectors.__isEqual_, out ___occuredException, sizeof( NObjective.RuntimeObject ), equal );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static char __isFault() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__isFault( ClassHandle, CachedSelectors.__isFault, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static char __isKindOfClass_( NObjective.RuntimeClass @class ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__isKindOfClass_( ClassHandle, CachedSelectors.__isKindOfClass_, out ___occuredException, sizeof( NObjective.RuntimeClass ), @class );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static char __isMemberOfClass_( NObjective.RuntimeClass @class ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__isMemberOfClass_( ClassHandle, CachedSelectors.__isMemberOfClass_, out ___occuredException, sizeof( NObjective.RuntimeClass ), @class );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static char __isProxy() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__isProxy( ClassHandle, CachedSelectors.__isProxy, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static bool isSubclassOfClass_( NObjective.RuntimeClass @class ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isSubclassOfClass_( ClassHandle, CachedSelectors.isSubclassOfClass_, out ___occuredException, sizeof( NObjective.RuntimeClass ), @class );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static NObjective.RuntimeObject __methodSignatureForSelector_( NObjective.Selector selector ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__methodSignatureForSelector_( ClassHandle, CachedSelectors.__methodSignatureForSelector_, out ___occuredException, sizeof( NObjective.Selector ), selector );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject __mutableCopy() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__mutableCopy( ClassHandle, CachedSelectors.__mutableCopy, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject mutableCopyWithZone_( IntPtr zone ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mutableCopyWithZone_( ClassHandle, CachedSelectors.mutableCopyWithZone_, out ___occuredException, sizeof( IntPtr ), zone );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject @new() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.@new( ClassHandle, CachedSelectors.@new, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject __performSelector_( NObjective.Selector selector ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__performSelector_( ClassHandle, CachedSelectors.__performSelector_, out ___occuredException, sizeof( NObjective.Selector ), selector );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject __performSelector_withObject_( NObjective.Selector selector, NObjective.RuntimeObject withObject ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__performSelector_withObject_( ClassHandle, CachedSelectors.__performSelector_withObject_, out ___occuredException, sizeof( NObjective.Selector ) + sizeof( NObjective.RuntimeObject ), selector, withObject );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject __performSelector_withObject_withObject_( NObjective.Selector selector, NObjective.RuntimeObject withObject, NObjective.RuntimeObject withObject2 ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__performSelector_withObject_withObject_( ClassHandle, CachedSelectors.__performSelector_withObject_withObject_, out ___occuredException, sizeof( NObjective.Selector ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), selector, withObject, withObject2 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static void __release() {
			RuntimeObject ___occuredException;
			NativeMethods.__release( ClassHandle, CachedSelectors.__release, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static bool resolveClassMethod_( NObjective.Selector method ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.resolveClassMethod_( ClassHandle, CachedSelectors.resolveClassMethod_, out ___occuredException, sizeof( NObjective.Selector ), method );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static bool resolveInstanceMethod_( NObjective.Selector method ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.resolveInstanceMethod_( ClassHandle, CachedSelectors.resolveInstanceMethod_, out ___occuredException, sizeof( NObjective.Selector ), method );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static char __respondsToSelector_( NObjective.Selector selector ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__respondsToSelector_( ClassHandle, CachedSelectors.__respondsToSelector_, out ___occuredException, sizeof( NObjective.Selector ), selector );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static NObjective.RuntimeObject __retain() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__retain( ClassHandle, CachedSelectors.__retain, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static uint __retainCount() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__retainCount( ClassHandle, CachedSelectors.__retainCount, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public static NObjective.RuntimeObject __self() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__self( ClassHandle, CachedSelectors.__self, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeClass __superclass() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__superclass( ClassHandle, CachedSelectors.__superclass, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeClass @class() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.@class( Handle, CachedSelectors.@class, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool conformsToProtocol_( Protocol protocol ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.conformsToProtocol_( Handle, CachedSelectors.conformsToProtocol_, out ___occuredException, sizeof( Protocol ), protocol );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject copy() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.copy( Handle, CachedSelectors.copy, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject debugDescription() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.debugDescription( Handle, CachedSelectors.debugDescription, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public string description() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.description( Handle, CachedSelectors.description, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public void doesNotRecognizeSelector_( NObjective.Selector selector ) {
			RuntimeObject ___occuredException;
			NativeMethods.doesNotRecognizeSelector_( Handle, CachedSelectors.doesNotRecognizeSelector_, out ___occuredException, sizeof( NObjective.Selector ), selector );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject forwardingTargetForSelector_( NObjective.Selector selector ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.forwardingTargetForSelector_( Handle, CachedSelectors.forwardingTargetForSelector_, out ___occuredException, sizeof( NObjective.Selector ), selector );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void forwardInvocation_( NSInvocation invocation ) {
			RuntimeObject ___occuredException;
			NativeMethods.forwardInvocation_( Handle, CachedSelectors.forwardInvocation_, out ___occuredException, sizeof( NSInvocation ), invocation );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public uint hash() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.hash( Handle, CachedSelectors.hash, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public NSObject init() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.init( Handle, CachedSelectors.init, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSObject( ___result );
		}
		unsafe public bool isEqual_( NObjective.RuntimeObject equal ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isEqual_( Handle, CachedSelectors.isEqual_, out ___occuredException, sizeof( NObjective.RuntimeObject ), equal );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isFault() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isFault( Handle, CachedSelectors.isFault, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isKindOfClass_( NObjective.RuntimeClass @class ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isKindOfClass_( Handle, CachedSelectors.isKindOfClass_, out ___occuredException, sizeof( NObjective.RuntimeClass ), @class );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isMemberOfClass_( NObjective.RuntimeClass @class ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isMemberOfClass_( Handle, CachedSelectors.isMemberOfClass_, out ___occuredException, sizeof( NObjective.RuntimeClass ), @class );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isProxy() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isProxy( Handle, CachedSelectors.isProxy, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NSMethodSignature methodSignatureForSelector_( NObjective.Selector selector ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.methodSignatureForSelector_( Handle, CachedSelectors.methodSignatureForSelector_, out ___occuredException, sizeof( NObjective.Selector ), selector );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSMethodSignature( ___result );
		}
		unsafe public NObjective.RuntimeObject mutableCopy() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mutableCopy( Handle, CachedSelectors.mutableCopy, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject performSelector_( NObjective.Selector selector ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.performSelector_( Handle, CachedSelectors.performSelector_, out ___occuredException, sizeof( NObjective.Selector ), selector );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject performSelector_withObject_( NObjective.Selector selector, NObjective.RuntimeObject withObject ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.performSelector_withObject_( Handle, CachedSelectors.performSelector_withObject_, out ___occuredException, sizeof( NObjective.Selector ) + sizeof( NObjective.RuntimeObject ), selector, withObject );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject performSelector_withObject_withObject_( NObjective.Selector selector, NObjective.RuntimeObject withObject, NObjective.RuntimeObject withObject2 ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.performSelector_withObject_withObject_( Handle, CachedSelectors.performSelector_withObject_withObject_, out ___occuredException, sizeof( NObjective.Selector ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), selector, withObject, withObject2 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void release() {
			RuntimeObject ___occuredException;
			NativeMethods.release( Handle, CachedSelectors.release, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public bool respondsToSelector_( NObjective.Selector selector ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.respondsToSelector_( Handle, CachedSelectors.respondsToSelector_, out ___occuredException, sizeof( NObjective.Selector ), selector );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject retain() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.retain( Handle, CachedSelectors.retain, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public uint retainCount() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.retainCount( Handle, CachedSelectors.retainCount, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public NObjective.RuntimeObject self() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.self( Handle, CachedSelectors.self, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeClass superclass() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.superclass( Handle, CachedSelectors.superclass, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern NObjective.RuntimeClass __class( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool __conformsToProtocol_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, Protocol protocol );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr __copy( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr __debugDescription( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr __description( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void __doesNotRecognizeSelector_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr __forwardingTargetForSelector_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void __forwardInvocation_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject invocation );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint __hash( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char __isEqual_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject equal );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char __isFault( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char __isKindOfClass_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeClass @class );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char __isMemberOfClass_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeClass @class );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char __isProxy( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr __methodSignatureForSelector_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr __mutableCopy( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr __performSelector_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr __performSelector_withObject_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector, NObjective.RuntimeObject withObject );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr __performSelector_withObject_withObject_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector, NObjective.RuntimeObject withObject, NObjective.RuntimeObject withObject2 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void __release( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char __respondsToSelector_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr __retain( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint __retainCount( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr __self( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern NObjective.RuntimeClass __superclass( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr autorelease( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern NObjective.RuntimeClass @class( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool conformsToProtocol_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, Protocol protocol );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr copy( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr debugDescription( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr description( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void doesNotRecognizeSelector_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr forwardingTargetForSelector_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void forwardInvocation_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSInvocation invocation );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint hash( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr init( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr instanceMethodSignatureForSelector_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool instancesRespondToSelector_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isAncestorOfObject_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isEqual_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject equal );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isFault( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isKindOfClass_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeClass @class );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isMemberOfClass_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeClass @class );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isProxy( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isSubclassOfClass_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeClass @class );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr methodSignatureForSelector_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr mutableCopy( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr mutableCopyWithZone_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr zone );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr @new( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr performSelector_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr performSelector_withObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector, NObjective.RuntimeObject withObject );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr performSelector_withObject_withObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector, NObjective.RuntimeObject withObject, NObjective.RuntimeObject withObject2 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void release( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool resolveClassMethod_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector method );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool resolveInstanceMethod_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector method );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool respondsToSelector_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr retain( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint retainCount( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr self( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern NObjective.RuntimeClass superclass( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector __class = "__class";
			public static readonly Selector __conformsToProtocol_ = "__conformsToProtocol:";
			public static readonly Selector __copy = "__copy";
			public static readonly Selector __debugDescription = "__debugDescription";
			public static readonly Selector __description = "__description";
			public static readonly Selector __doesNotRecognizeSelector_ = "__doesNotRecognizeSelector:";
			public static readonly Selector __forwardingTargetForSelector_ = "__forwardingTargetForSelector:";
			public static readonly Selector __forwardInvocation_ = "__forwardInvocation:";
			public static readonly Selector __hash = "__hash";
			public static readonly Selector __isEqual_ = "__isEqual:";
			public static readonly Selector __isFault = "__isFault";
			public static readonly Selector __isKindOfClass_ = "__isKindOfClass:";
			public static readonly Selector __isMemberOfClass_ = "__isMemberOfClass:";
			public static readonly Selector __isProxy = "__isProxy";
			public static readonly Selector __methodSignatureForSelector_ = "__methodSignatureForSelector:";
			public static readonly Selector __mutableCopy = "__mutableCopy";
			public static readonly Selector __performSelector_ = "__performSelector:";
			public static readonly Selector __performSelector_withObject_ = "__performSelector:withObject:";
			public static readonly Selector __performSelector_withObject_withObject_ = "__performSelector:withObject:withObject:";
			public static readonly Selector __release = "__release";
			public static readonly Selector __respondsToSelector_ = "__respondsToSelector:";
			public static readonly Selector __retain = "__retain";
			public static readonly Selector __retainCount = "__retainCount";
			public static readonly Selector __self = "__self";
			public static readonly Selector __superclass = "__superclass";
			public static readonly Selector autorelease = "autorelease";
			public static readonly Selector @class = "class";
			public static readonly Selector conformsToProtocol_ = "conformsToProtocol:";
			public static readonly Selector copy = "copy";
			public static readonly Selector debugDescription = "debugDescription";
			public static readonly Selector description = "description";
			public static readonly Selector doesNotRecognizeSelector_ = "doesNotRecognizeSelector:";
			public static readonly Selector forwardingTargetForSelector_ = "forwardingTargetForSelector:";
			public static readonly Selector forwardInvocation_ = "forwardInvocation:";
			public static readonly Selector hash = "hash";
			public static readonly Selector init = "init";
			public static readonly Selector instanceMethodSignatureForSelector_ = "instanceMethodSignatureForSelector:";
			public static readonly Selector instancesRespondToSelector_ = "instancesRespondToSelector:";
			public static readonly Selector isAncestorOfObject_ = "isAncestorOfObject:";
			public static readonly Selector isEqual_ = "isEqual:";
			public static readonly Selector isFault = "isFault";
			public static readonly Selector isKindOfClass_ = "isKindOfClass:";
			public static readonly Selector isMemberOfClass_ = "isMemberOfClass:";
			public static readonly Selector isProxy = "isProxy";
			public static readonly Selector isSubclassOfClass_ = "isSubclassOfClass:";
			public static readonly Selector methodSignatureForSelector_ = "methodSignatureForSelector:";
			public static readonly Selector mutableCopy = "mutableCopy";
			public static readonly Selector mutableCopyWithZone_ = "mutableCopyWithZone:";
			public static readonly Selector @new = "new";
			public static readonly Selector performSelector_ = "performSelector:";
			public static readonly Selector performSelector_withObject_ = "performSelector:withObject:";
			public static readonly Selector performSelector_withObject_withObject_ = "performSelector:withObject:withObject:";
			public static readonly Selector release = "release";
			public static readonly Selector resolveClassMethod_ = "resolveClassMethod:";
			public static readonly Selector resolveInstanceMethod_ = "resolveInstanceMethod:";
			public static readonly Selector respondsToSelector_ = "respondsToSelector:";
			public static readonly Selector retain = "retain";
			public static readonly Selector retainCount = "retainCount";
			public static readonly Selector self = "self";
			public static readonly Selector superclass = "superclass";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSOrderedSet : IEquatable<NSOrderedSet> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSOrderedSet;
		public static implicit operator NSObject( NSOrderedSet value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSOrderedSet value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSOrderedSet value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSOrderedSet?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSOrderedSet value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSOrderedSet value1, NSOrderedSet value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSOrderedSet value1, NSOrderedSet value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSOrderedSet( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSOrderedSet alloc() {
			return new NSOrderedSet( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject orderedSet() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.orderedSet( ClassHandle, CachedSelectors.orderedSet, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NSOrderedSet orderedSetWithArray_( NObjective.RuntimeObject array ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.orderedSetWithArray_( ClassHandle, CachedSelectors.orderedSetWithArray_, out ___occuredException, sizeof( NObjective.RuntimeObject ), array );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSOrderedSet( ___result );
		}
		unsafe public static NSOrderedSet orderedSetWithObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.orderedSetWithObject_( ClassHandle, CachedSelectors.orderedSetWithObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSOrderedSet( ___result );
		}
		unsafe public static NSOrderedSet orderedSetWithObjects_( NObjective.RuntimeObject objects ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.orderedSetWithObjects_( ClassHandle, CachedSelectors.orderedSetWithObjects_, out ___occuredException, sizeof( NObjective.RuntimeObject ), objects );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSOrderedSet( ___result );
		}
		unsafe public static NSOrderedSet orderedSetWithObjects_count_( System.IntPtr objects, uint count ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.orderedSetWithObjects_count_( ClassHandle, CachedSelectors.orderedSetWithObjects_count_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( uint ), objects, count );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSOrderedSet( ___result );
		}
		unsafe public static NSOrderedSet orderedSetWithOrderedSet_( NObjective.RuntimeObject @set ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.orderedSetWithOrderedSet_( ClassHandle, CachedSelectors.orderedSetWithOrderedSet_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSOrderedSet( ___result );
		}
		unsafe public static NSOrderedSet orderedSetWithSet_( NObjective.RuntimeObject @set ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.orderedSetWithSet_( ClassHandle, CachedSelectors.orderedSetWithSet_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSOrderedSet( ___result );
		}
		unsafe public NObjective.RuntimeObject allObjects() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.allObjects( Handle, CachedSelectors.allObjects, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char containsObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.containsObject_( Handle, CachedSelectors.containsObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public uint count() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.count( Handle, CachedSelectors.count, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public uint countForObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.countForObject_( Handle, CachedSelectors.countForObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public NObjective.RuntimeObject descriptionWithLocale_( NObjective.RuntimeObject locale ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.descriptionWithLocale_( Handle, CachedSelectors.descriptionWithLocale_, out ___occuredException, sizeof( NObjective.RuntimeObject ), locale );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject descriptionWithLocale_indent_( NObjective.RuntimeObject locale, uint indent ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.descriptionWithLocale_indent_( Handle, CachedSelectors.descriptionWithLocale_indent_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ), locale, indent );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void encodeWithCoder_( NSCoder coder ) {
			RuntimeObject ___occuredException;
			NativeMethods.encodeWithCoder_( Handle, CachedSelectors.encodeWithCoder_, out ___occuredException, sizeof( NSCoder ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void getObjects_( System.IntPtr objects ) {
			RuntimeObject ___occuredException;
			NativeMethods.getObjects_( Handle, CachedSelectors.getObjects_, out ___occuredException, sizeof( System.IntPtr ), objects );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public uint indexOfObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.indexOfObject_( Handle, CachedSelectors.indexOfObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public NSOrderedSet initWithArray_( NObjective.RuntimeObject array ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithArray_( Handle, CachedSelectors.initWithArray_, out ___occuredException, sizeof( NObjective.RuntimeObject ), array );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSOrderedSet( ___result );
		}
		unsafe public NSOrderedSet initWithCoder_( NObjective.RuntimeObject coder ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCoder_( Handle, CachedSelectors.initWithCoder_, out ___occuredException, sizeof( NObjective.RuntimeObject ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSOrderedSet( ___result );
		}
		unsafe public NSOrderedSet initWithObjects_( NObjective.RuntimeObject objects ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithObjects_( Handle, CachedSelectors.initWithObjects_, out ___occuredException, sizeof( NObjective.RuntimeObject ), objects );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSOrderedSet( ___result );
		}
		unsafe public NSOrderedSet initWithObjects_count_( System.IntPtr objects, uint count ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithObjects_count_( Handle, CachedSelectors.initWithObjects_count_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( uint ), objects, count );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSOrderedSet( ___result );
		}
		unsafe public NSOrderedSet initWithOrderedSet_( NObjective.RuntimeObject @set ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithOrderedSet_( Handle, CachedSelectors.initWithOrderedSet_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSOrderedSet( ___result );
		}
		unsafe public NSOrderedSet initWithOrderedSet_copyItems_( NObjective.RuntimeObject @set, char copyItems ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithOrderedSet_copyItems_( Handle, CachedSelectors.initWithOrderedSet_copyItems_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( char ), @set, copyItems );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSOrderedSet( ___result );
		}
		unsafe public NSOrderedSet initWithSet_( NObjective.RuntimeObject @set ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithSet_( Handle, CachedSelectors.initWithSet_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSOrderedSet( ___result );
		}
		unsafe public char intersectsOrderedSet_( NObjective.RuntimeObject @set ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.intersectsOrderedSet_( Handle, CachedSelectors.intersectsOrderedSet_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char intersectsSet_( NObjective.RuntimeObject @set ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.intersectsSet_( Handle, CachedSelectors.intersectsSet_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isEqualToOrderedSet_( NObjective.RuntimeObject @set ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isEqualToOrderedSet_( Handle, CachedSelectors.isEqualToOrderedSet_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isNSOrderedSet__() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isNSOrderedSet__( Handle, CachedSelectors.isNSOrderedSet__, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isSubsetOfOrderedSet_( NObjective.RuntimeObject @set ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isSubsetOfOrderedSet_( Handle, CachedSelectors.isSubsetOfOrderedSet_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isSubsetOfSet_( NObjective.RuntimeObject @set ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isSubsetOfSet_( Handle, CachedSelectors.isSubsetOfSet_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject member_( NObjective.RuntimeObject member ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.member_( Handle, CachedSelectors.member_, out ___occuredException, sizeof( NObjective.RuntimeObject ), member );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject members_notFoundMarker_( NObjective.RuntimeObject members, NObjective.RuntimeObject notFoundMarker ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.members_notFoundMarker_( Handle, CachedSelectors.members_notFoundMarker_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), members, notFoundMarker );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject objectAtIndex_( uint index ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectAtIndex_( Handle, CachedSelectors.objectAtIndex_, out ___occuredException, sizeof( uint ), index );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject objectEnumerator() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectEnumerator( Handle, CachedSelectors.objectEnumerator, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject orderedSetByAddingObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.orderedSetByAddingObject_( Handle, CachedSelectors.orderedSetByAddingObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject orderedSetByAddingObjects_count_( System.IntPtr objects, uint count ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.orderedSetByAddingObjects_count_( Handle, CachedSelectors.orderedSetByAddingObjects_count_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( uint ), objects, count );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject orderedSetByAddingObjectsFromArray_( NObjective.RuntimeObject array ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.orderedSetByAddingObjectsFromArray_( Handle, CachedSelectors.orderedSetByAddingObjectsFromArray_, out ___occuredException, sizeof( NObjective.RuntimeObject ), array );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject orderedSetByAddingObjectsFromOrderedSet_( NObjective.RuntimeObject @set ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.orderedSetByAddingObjectsFromOrderedSet_( Handle, CachedSelectors.orderedSetByAddingObjectsFromOrderedSet_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject orderedSetByAddingObjectsFromSet_( NObjective.RuntimeObject @set ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.orderedSetByAddingObjectsFromSet_( Handle, CachedSelectors.orderedSetByAddingObjectsFromSet_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject reverseObjectEnumerator() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.reverseObjectEnumerator( Handle, CachedSelectors.reverseObjectEnumerator, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr allObjects( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char containsObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint count( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint countForObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr descriptionWithLocale_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject locale );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr descriptionWithLocale_indent_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject locale, uint indent );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void encodeWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSCoder coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void getObjects_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr objects );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint indexOfObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithArray_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject array );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithObjects_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject objects );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithObjects_count_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr objects, uint count );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithOrderedSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @set );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithOrderedSet_copyItems_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @set, char copyItems );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @set );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char intersectsOrderedSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @set );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char intersectsSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @set );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isEqualToOrderedSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @set );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isNSOrderedSet__( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isSubsetOfOrderedSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @set );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isSubsetOfSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @set );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr member_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject member );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr members_notFoundMarker_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject members, NObjective.RuntimeObject notFoundMarker );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr objectAtIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint index );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr objectEnumerator( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr orderedSet( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr orderedSetByAddingObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr orderedSetByAddingObjects_count_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr objects, uint count );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr orderedSetByAddingObjectsFromArray_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject array );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr orderedSetByAddingObjectsFromOrderedSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @set );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr orderedSetByAddingObjectsFromSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @set );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr orderedSetWithArray_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject array );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr orderedSetWithObject_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr orderedSetWithObjects_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject objects );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr orderedSetWithObjects_count_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr objects, uint count );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr orderedSetWithOrderedSet_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @set );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr orderedSetWithSet_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @set );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr reverseObjectEnumerator( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector allObjects = "allObjects";
			public static readonly Selector containsObject_ = "containsObject:";
			public static readonly Selector count = "count";
			public static readonly Selector countForObject_ = "countForObject:";
			public static readonly Selector descriptionWithLocale_ = "descriptionWithLocale:";
			public static readonly Selector descriptionWithLocale_indent_ = "descriptionWithLocale:indent:";
			public static readonly Selector encodeWithCoder_ = "encodeWithCoder:";
			public static readonly Selector getObjects_ = "getObjects:";
			public static readonly Selector indexOfObject_ = "indexOfObject:";
			public static readonly Selector initWithArray_ = "initWithArray:";
			public static readonly Selector initWithCoder_ = "initWithCoder:";
			public static readonly Selector initWithObjects_ = "initWithObjects:";
			public static readonly Selector initWithObjects_count_ = "initWithObjects:count:";
			public static readonly Selector initWithOrderedSet_ = "initWithOrderedSet:";
			public static readonly Selector initWithOrderedSet_copyItems_ = "initWithOrderedSet:copyItems:";
			public static readonly Selector initWithSet_ = "initWithSet:";
			public static readonly Selector intersectsOrderedSet_ = "intersectsOrderedSet:";
			public static readonly Selector intersectsSet_ = "intersectsSet:";
			public static readonly Selector isEqualToOrderedSet_ = "isEqualToOrderedSet:";
			public static readonly Selector isNSOrderedSet__ = "isNSOrderedSet__";
			public static readonly Selector isSubsetOfOrderedSet_ = "isSubsetOfOrderedSet:";
			public static readonly Selector isSubsetOfSet_ = "isSubsetOfSet:";
			public static readonly Selector member_ = "member:";
			public static readonly Selector members_notFoundMarker_ = "members:notFoundMarker:";
			public static readonly Selector objectAtIndex_ = "objectAtIndex:";
			public static readonly Selector objectEnumerator = "objectEnumerator";
			public static readonly Selector orderedSet = "orderedSet";
			public static readonly Selector orderedSetByAddingObject_ = "orderedSetByAddingObject:";
			public static readonly Selector orderedSetByAddingObjects_count_ = "orderedSetByAddingObjects:count:";
			public static readonly Selector orderedSetByAddingObjectsFromArray_ = "orderedSetByAddingObjectsFromArray:";
			public static readonly Selector orderedSetByAddingObjectsFromOrderedSet_ = "orderedSetByAddingObjectsFromOrderedSet:";
			public static readonly Selector orderedSetByAddingObjectsFromSet_ = "orderedSetByAddingObjectsFromSet:";
			public static readonly Selector orderedSetWithArray_ = "orderedSetWithArray:";
			public static readonly Selector orderedSetWithObject_ = "orderedSetWithObject:";
			public static readonly Selector orderedSetWithObjects_ = "orderedSetWithObjects:";
			public static readonly Selector orderedSetWithObjects_count_ = "orderedSetWithObjects:count:";
			public static readonly Selector orderedSetWithOrderedSet_ = "orderedSetWithOrderedSet:";
			public static readonly Selector orderedSetWithSet_ = "orderedSetWithSet:";
			public static readonly Selector reverseObjectEnumerator = "reverseObjectEnumerator";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSStream ) )]
	public struct NSOutputStream : IEquatable<NSOutputStream> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSOutputStream;
		public static implicit operator NSStream( NSOutputStream value ) {
			return new NSStream( value.Handle );
		}
		public static implicit operator NSObject( NSOutputStream value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSOutputStream value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSOutputStream value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSOutputStream?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSOutputStream value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSOutputStream value1, NSOutputStream value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSOutputStream value1, NSOutputStream value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSOutputStream( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSOutputStream alloc() {
			return new NSOutputStream( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSRunLoop : IEquatable<NSRunLoop> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSRunLoop;
		public static implicit operator NSObject( NSRunLoop value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSRunLoop value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSRunLoop value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSRunLoop?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSRunLoop value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSRunLoop value1, NSRunLoop value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSRunLoop value1, NSRunLoop value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSRunLoop( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSRunLoop alloc() {
			return new NSRunLoop( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSSet : IEquatable<NSSet> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSSet;
		public static implicit operator NSObject( NSSet value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSSet value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSet value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSet?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSet value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSet value1, NSSet value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSet value1, NSSet value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSet( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSet alloc() {
			return new NSSet( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject @set() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.@set( ClassHandle, CachedSelectors.@set, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NSSet setWithArray_( NSArray array ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.setWithArray_( ClassHandle, CachedSelectors.setWithArray_, out ___occuredException, sizeof( NSArray ), array );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSet( ___result );
		}
		unsafe public static NSSet setWithObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.setWithObject_( ClassHandle, CachedSelectors.setWithObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSet( ___result );
		}
		public static NSSet setWithObjects_( NObjective.RuntimeObject objects ) {
			return new NSSet( ClassHandle.InvokeIntPtrFast( CachedSelectors.setWithObjects_, CachedEncodings.__6F587D11, objects ) );
		}
		unsafe public static NSSet setWithObjects_count_( IntPtr objects, uint count ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.setWithObjects_count_( ClassHandle, CachedSelectors.setWithObjects_count_, out ___occuredException, sizeof( IntPtr ) + sizeof( uint ), objects, count );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSet( ___result );
		}
		unsafe public static NSSet setWithSet_( NSSet @set ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.setWithSet_( ClassHandle, CachedSelectors.setWithSet_, out ___occuredException, sizeof( NSSet ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSet( ___result );
		}
		unsafe public NSArray allObjects() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.allObjects( Handle, CachedSelectors.allObjects, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public NObjective.RuntimeObject anyObject() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.anyObject( Handle, CachedSelectors.anyObject, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public bool containsObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.containsObject_( Handle, CachedSelectors.containsObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public uint count() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.count( Handle, CachedSelectors.count, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public uint countForObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.countForObject_( Handle, CachedSelectors.countForObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public string descriptionWithLocale_( NObjective.RuntimeObject locale ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.descriptionWithLocale_( Handle, CachedSelectors.descriptionWithLocale_, out ___occuredException, sizeof( NObjective.RuntimeObject ), locale );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public NObjective.RuntimeObject descriptionWithLocale_indent_( NObjective.RuntimeObject locale, uint indent ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.descriptionWithLocale_indent_( Handle, CachedSelectors.descriptionWithLocale_indent_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ), locale, indent );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void getObjects_( System.IntPtr objects ) {
			RuntimeObject ___occuredException;
			NativeMethods.getObjects_( Handle, CachedSelectors.getObjects_, out ___occuredException, sizeof( System.IntPtr ), objects );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSSet initWithArray_( NSArray array ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithArray_( Handle, CachedSelectors.initWithArray_, out ___occuredException, sizeof( NSArray ), array );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSet( ___result );
		}
		public NSSet initWithObjects_( NObjective.RuntimeObject objects ) {
			return new NSSet( Handle.InvokeIntPtrFast( CachedSelectors.initWithObjects_, CachedEncodings.__6F587D11, objects ) );
		}
		unsafe public NSSet initWithObjects_count_( IntPtr objects, uint count ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithObjects_count_( Handle, CachedSelectors.initWithObjects_count_, out ___occuredException, sizeof( IntPtr ) + sizeof( uint ), objects, count );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSet( ___result );
		}
		unsafe public NSSet initWithSet_( NSSet @set ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithSet_( Handle, CachedSelectors.initWithSet_, out ___occuredException, sizeof( NSSet ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSet( ___result );
		}
		unsafe public NSSet initWithSet_copyItems_( NSSet @set, bool copyItems ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithSet_copyItems_( Handle, CachedSelectors.initWithSet_copyItems_, out ___occuredException, sizeof( NSSet ) + sizeof( bool ), @set, copyItems );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSet( ___result );
		}
		unsafe public bool intersectsSet_( NSSet @set ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.intersectsSet_( Handle, CachedSelectors.intersectsSet_, out ___occuredException, sizeof( NSSet ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isEqualToSet_( NSSet @set ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isEqualToSet_( Handle, CachedSelectors.isEqualToSet_, out ___occuredException, sizeof( NSSet ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isSubsetOfSet_( NSSet @set ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isSubsetOfSet_( Handle, CachedSelectors.isSubsetOfSet_, out ___occuredException, sizeof( NSSet ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void makeObjectsPerformSelector_( NObjective.Selector selector ) {
			RuntimeObject ___occuredException;
			NativeMethods.makeObjectsPerformSelector_( Handle, CachedSelectors.makeObjectsPerformSelector_, out ___occuredException, sizeof( NObjective.Selector ), selector );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void makeObjectsPerformSelector_withObject_( NObjective.Selector selector, NObjective.RuntimeObject withObject ) {
			RuntimeObject ___occuredException;
			NativeMethods.makeObjectsPerformSelector_withObject_( Handle, CachedSelectors.makeObjectsPerformSelector_withObject_, out ___occuredException, sizeof( NObjective.Selector ) + sizeof( NObjective.RuntimeObject ), selector, withObject );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject member_( NObjective.RuntimeObject member ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.member_( Handle, CachedSelectors.member_, out ___occuredException, sizeof( NObjective.RuntimeObject ), member );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject members_notFoundMarker_( NObjective.RuntimeObject members, NObjective.RuntimeObject notFoundMarker ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.members_notFoundMarker_( Handle, CachedSelectors.members_notFoundMarker_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), members, notFoundMarker );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSEnumerator objectEnumerator() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectEnumerator( Handle, CachedSelectors.objectEnumerator, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSEnumerator( ___result );
		}
		unsafe public NSSet setByAddingObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.setByAddingObject_( Handle, CachedSelectors.setByAddingObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSet( ___result );
		}
		unsafe public NSSet setByAddingObjectsFromArray_( NSArray array ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.setByAddingObjectsFromArray_( Handle, CachedSelectors.setByAddingObjectsFromArray_, out ___occuredException, sizeof( NSArray ), array );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSet( ___result );
		}
		unsafe public NSSet setByAddingObjectsFromSet_( NSSet @set ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.setByAddingObjectsFromSet_( Handle, CachedSelectors.setByAddingObjectsFromSet_, out ___occuredException, sizeof( NSSet ), @set );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSet( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr allObjects( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr anyObject( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool containsObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint count( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint countForObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr descriptionWithLocale_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject locale );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr descriptionWithLocale_indent_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject locale, uint indent );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void getObjects_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr objects );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithArray_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray array );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithObjects_count_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr objects, uint count );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSSet @set );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithSet_copyItems_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSSet @set, bool copyItems );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool intersectsSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSSet @set );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isEqualToSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSSet @set );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isSubsetOfSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSSet @set );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void makeObjectsPerformSelector_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void makeObjectsPerformSelector_withObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector, NObjective.RuntimeObject withObject );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr member_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject member );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr members_notFoundMarker_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject members, NObjective.RuntimeObject notFoundMarker );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr objectEnumerator( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr @set( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr setByAddingObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr setByAddingObjectsFromArray_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray array );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr setByAddingObjectsFromSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSSet @set );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr setWithArray_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray array );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr setWithObject_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr setWithObjects_count_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr objects, uint count );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr setWithSet_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSSet @set );
		}
		static internal class CachedEncodings {
			public static readonly RuntimeMethodEncoding __6F587D11 = "@12@0:4@8";
		}
		static internal class CachedSelectors {
			public static readonly Selector allObjects = "allObjects";
			public static readonly Selector anyObject = "anyObject";
			public static readonly Selector containsObject_ = "containsObject:";
			public static readonly Selector count = "count";
			public static readonly Selector countForObject_ = "countForObject:";
			public static readonly Selector descriptionWithLocale_ = "descriptionWithLocale:";
			public static readonly Selector descriptionWithLocale_indent_ = "descriptionWithLocale:indent:";
			public static readonly Selector getObjects_ = "getObjects:";
			public static readonly Selector initWithArray_ = "initWithArray:";
			public static readonly Selector initWithObjects_ = "initWithObjects:";
			public static readonly Selector initWithObjects_count_ = "initWithObjects:count:";
			public static readonly Selector initWithSet_ = "initWithSet:";
			public static readonly Selector initWithSet_copyItems_ = "initWithSet:copyItems:";
			public static readonly Selector intersectsSet_ = "intersectsSet:";
			public static readonly Selector isEqualToSet_ = "isEqualToSet:";
			public static readonly Selector isSubsetOfSet_ = "isSubsetOfSet:";
			public static readonly Selector makeObjectsPerformSelector_ = "makeObjectsPerformSelector:";
			public static readonly Selector makeObjectsPerformSelector_withObject_ = "makeObjectsPerformSelector:withObject:";
			public static readonly Selector member_ = "member:";
			public static readonly Selector members_notFoundMarker_ = "members:notFoundMarker:";
			public static readonly Selector objectEnumerator = "objectEnumerator";
			public static readonly Selector @set = "set";
			public static readonly Selector setByAddingObject_ = "setByAddingObject:";
			public static readonly Selector setByAddingObjectsFromArray_ = "setByAddingObjectsFromArray:";
			public static readonly Selector setByAddingObjectsFromSet_ = "setByAddingObjectsFromSet:";
			public static readonly Selector setWithArray_ = "setWithArray:";
			public static readonly Selector setWithObject_ = "setWithObject:";
			public static readonly Selector setWithObjects_ = "setWithObjects:";
			public static readonly Selector setWithObjects_count_ = "setWithObjects:count:";
			public static readonly Selector setWithSet_ = "setWithSet:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSStream : IEquatable<NSStream> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSStream;
		public static implicit operator NSObject( NSStream value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSStream value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSStream value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSStream?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSStream value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSStream value1, NSStream value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSStream value1, NSStream value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSStream( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSStream alloc() {
			return new NSStream( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSTimer : IEquatable<NSTimer> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSTimer;
		public static implicit operator NSObject( NSTimer value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSTimer value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSTimer value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSTimer?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSTimer value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSTimer value1, NSTimer value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSTimer value1, NSTimer value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSTimer( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSTimer alloc() {
			return new NSTimer( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSTimeZone : IEquatable<NSTimeZone> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSTimeZone;
		public static implicit operator NSObject( NSTimeZone value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSTimeZone value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSTimeZone value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSTimeZone?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSTimeZone value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSTimeZone value1, NSTimeZone value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSTimeZone value1, NSTimeZone value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSTimeZone( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSTimeZone alloc() {
			return new NSTimeZone( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSUserDefaults : IEquatable<NSUserDefaults> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreFoundationCachedClasses.NSUserDefaults;
		public static implicit operator NSObject( NSUserDefaults value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( NSUserDefaults value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSUserDefaults value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSUserDefaults?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSUserDefaults value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSUserDefaults value1, NSUserDefaults value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSUserDefaults value1, NSUserDefaults value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSUserDefaults( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSUserDefaults alloc() {
			return new NSUserDefaults( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	public static class CoreFoundationExtensionsOfProtocol {
		private static int ___lazyLoad = CoreFoundationCachedClasses.___lazyLoad;
		unsafe public static NObjective.RuntimeObject autorelease() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.autorelease( Protocol.ClassHandle, CachedSelectors.autorelease, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeClass __class() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__class( Protocol.ClassHandle, CachedSelectors.__class, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static char __conformsToProtocol_( NObjective.RuntimeObject protocol ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__conformsToProtocol_( Protocol.ClassHandle, CachedSelectors.__conformsToProtocol_, out ___occuredException, sizeof( NObjective.RuntimeObject ), protocol );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static NObjective.RuntimeObject __description() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__description( Protocol.ClassHandle, CachedSelectors.__description, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static uint __hash() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__hash( Protocol.ClassHandle, CachedSelectors.__hash, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public static char __isEqual_( NObjective.RuntimeObject equal ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__isEqual_( Protocol.ClassHandle, CachedSelectors.__isEqual_, out ___occuredException, sizeof( NObjective.RuntimeObject ), equal );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static char __isKindOfClass_( NObjective.RuntimeClass @class ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__isKindOfClass_( Protocol.ClassHandle, CachedSelectors.__isKindOfClass_, out ___occuredException, sizeof( NObjective.RuntimeClass ), @class );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static char __isMemberOfClass_( NObjective.RuntimeClass @class ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__isMemberOfClass_( Protocol.ClassHandle, CachedSelectors.__isMemberOfClass_, out ___occuredException, sizeof( NObjective.RuntimeClass ), @class );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static char __isProxy() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__isProxy( Protocol.ClassHandle, CachedSelectors.__isProxy, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static NObjective.RuntimeObject __performSelector_( NObjective.Selector selector ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__performSelector_( Protocol.ClassHandle, CachedSelectors.__performSelector_, out ___occuredException, sizeof( NObjective.Selector ), selector );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject __performSelector_withObject_( NObjective.Selector selector, NObjective.RuntimeObject withObject ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__performSelector_withObject_( Protocol.ClassHandle, CachedSelectors.__performSelector_withObject_, out ___occuredException, sizeof( NObjective.Selector ) + sizeof( NObjective.RuntimeObject ), selector, withObject );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject __performSelector_withObject_withObject_( NObjective.Selector selector, NObjective.RuntimeObject withObject, NObjective.RuntimeObject withObject2 ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__performSelector_withObject_withObject_( Protocol.ClassHandle, CachedSelectors.__performSelector_withObject_withObject_, out ___occuredException, sizeof( NObjective.Selector ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), selector, withObject, withObject2 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static void __release() {
			RuntimeObject ___occuredException;
			NativeMethods.__release( Protocol.ClassHandle, CachedSelectors.__release, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static char __respondsToSelector_( NObjective.Selector selector ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__respondsToSelector_( Protocol.ClassHandle, CachedSelectors.__respondsToSelector_, out ___occuredException, sizeof( NObjective.Selector ), selector );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static NObjective.RuntimeObject __retain() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__retain( Protocol.ClassHandle, CachedSelectors.__retain, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static uint __retainCount() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__retainCount( Protocol.ClassHandle, CachedSelectors.__retainCount, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public static NObjective.RuntimeObject __self() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__self( Protocol.ClassHandle, CachedSelectors.__self, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeClass __superclass() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__superclass( Protocol.ClassHandle, CachedSelectors.__superclass, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static NObjective.RuntimeClass @class( this Protocol ___this ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.@class( ___this, CachedSelectors.@class, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static char conformsToProtocol_( this Protocol ___this, NObjective.RuntimeObject protocol ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.conformsToProtocol_( ___this, CachedSelectors.conformsToProtocol_, out ___occuredException, sizeof( NObjective.RuntimeObject ), protocol );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static string description( this Protocol ___this ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.description( ___this, CachedSelectors.description, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public static uint hash( this Protocol ___this ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.hash( ___this, CachedSelectors.hash, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public static bool isEqual_( this Protocol ___this, NObjective.RuntimeObject equal ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isEqual_( ___this, CachedSelectors.isEqual_, out ___occuredException, sizeof( NObjective.RuntimeObject ), equal );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static bool isKindOfClass_( this Protocol ___this, NObjective.RuntimeClass @class ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isKindOfClass_( ___this, CachedSelectors.isKindOfClass_, out ___occuredException, sizeof( NObjective.RuntimeClass ), @class );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static bool isMemberOfClass_( this Protocol ___this, NObjective.RuntimeClass @class ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isMemberOfClass_( ___this, CachedSelectors.isMemberOfClass_, out ___occuredException, sizeof( NObjective.RuntimeClass ), @class );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static bool isProxy( this Protocol ___this ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isProxy( ___this, CachedSelectors.isProxy, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static NObjective.RuntimeObject performSelector_( this Protocol ___this, NObjective.Selector selector ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.performSelector_( ___this, CachedSelectors.performSelector_, out ___occuredException, sizeof( NObjective.Selector ), selector );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject performSelector_withObject_( this Protocol ___this, NObjective.Selector selector, NObjective.RuntimeObject withObject ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.performSelector_withObject_( ___this, CachedSelectors.performSelector_withObject_, out ___occuredException, sizeof( NObjective.Selector ) + sizeof( NObjective.RuntimeObject ), selector, withObject );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject performSelector_withObject_withObject_( this Protocol ___this, NObjective.Selector selector, NObjective.RuntimeObject withObject, NObjective.RuntimeObject withObject2 ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.performSelector_withObject_withObject_( ___this, CachedSelectors.performSelector_withObject_withObject_, out ___occuredException, sizeof( NObjective.Selector ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), selector, withObject, withObject2 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static void release( this Protocol ___this ) {
			RuntimeObject ___occuredException;
			NativeMethods.release( ___this, CachedSelectors.release, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static char respondsToSelector_( this Protocol ___this, NObjective.Selector selector ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.respondsToSelector_( ___this, CachedSelectors.respondsToSelector_, out ___occuredException, sizeof( NObjective.Selector ), selector );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static NObjective.RuntimeObject retain( this Protocol ___this ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.retain( ___this, CachedSelectors.retain, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static uint retainCount( this Protocol ___this ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.retainCount( ___this, CachedSelectors.retainCount, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public static NObjective.RuntimeObject self( this Protocol ___this ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.self( ___this, CachedSelectors.self, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeClass superclass( this Protocol ___this ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.superclass( ___this, CachedSelectors.superclass, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern NObjective.RuntimeClass __class( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char __conformsToProtocol_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject protocol );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr __description( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint __hash( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char __isEqual_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject equal );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char __isKindOfClass_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeClass @class );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char __isMemberOfClass_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeClass @class );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char __isProxy( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr __performSelector_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr __performSelector_withObject_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector, NObjective.RuntimeObject withObject );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr __performSelector_withObject_withObject_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector, NObjective.RuntimeObject withObject, NObjective.RuntimeObject withObject2 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void __release( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char __respondsToSelector_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr __retain( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint __retainCount( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr __self( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern NObjective.RuntimeClass __superclass( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr autorelease( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern NObjective.RuntimeClass @class( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char conformsToProtocol_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject protocol );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr description( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint hash( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isEqual_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject equal );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isKindOfClass_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeClass @class );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isMemberOfClass_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeClass @class );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isProxy( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr performSelector_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr performSelector_withObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector, NObjective.RuntimeObject withObject );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr performSelector_withObject_withObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector, NObjective.RuntimeObject withObject, NObjective.RuntimeObject withObject2 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void release( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char respondsToSelector_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr retain( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint retainCount( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr self( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern NObjective.RuntimeClass superclass( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector __class = "__class";
			public static readonly Selector __conformsToProtocol_ = "__conformsToProtocol:";
			public static readonly Selector __description = "__description";
			public static readonly Selector __hash = "__hash";
			public static readonly Selector __isEqual_ = "__isEqual:";
			public static readonly Selector __isKindOfClass_ = "__isKindOfClass:";
			public static readonly Selector __isMemberOfClass_ = "__isMemberOfClass:";
			public static readonly Selector __isProxy = "__isProxy";
			public static readonly Selector __performSelector_ = "__performSelector:";
			public static readonly Selector __performSelector_withObject_ = "__performSelector:withObject:";
			public static readonly Selector __performSelector_withObject_withObject_ = "__performSelector:withObject:withObject:";
			public static readonly Selector __release = "__release";
			public static readonly Selector __respondsToSelector_ = "__respondsToSelector:";
			public static readonly Selector __retain = "__retain";
			public static readonly Selector __retainCount = "__retainCount";
			public static readonly Selector __self = "__self";
			public static readonly Selector __superclass = "__superclass";
			public static readonly Selector autorelease = "autorelease";
			public static readonly Selector @class = "class";
			public static readonly Selector conformsToProtocol_ = "conformsToProtocol:";
			public static readonly Selector description = "description";
			public static readonly Selector hash = "hash";
			public static readonly Selector isEqual_ = "isEqual:";
			public static readonly Selector isKindOfClass_ = "isKindOfClass:";
			public static readonly Selector isMemberOfClass_ = "isMemberOfClass:";
			public static readonly Selector isProxy = "isProxy";
			public static readonly Selector performSelector_ = "performSelector:";
			public static readonly Selector performSelector_withObject_ = "performSelector:withObject:";
			public static readonly Selector performSelector_withObject_withObject_ = "performSelector:withObject:withObject:";
			public static readonly Selector release = "release";
			public static readonly Selector respondsToSelector_ = "respondsToSelector:";
			public static readonly Selector retain = "retain";
			public static readonly Selector retainCount = "retainCount";
			public static readonly Selector self = "self";
			public static readonly Selector superclass = "superclass";
		}
	}
	static internal class CoreFoundationCachedClasses {
		static internal int ___lazyLoad = Platform.NativeMethods.dlopen( "/System/Library/Frameworks/CoreFoundation.framework/Versions/A/CoreFoundation" );
		public static readonly RuntimeClass __NSArrayReverseEnumerator = "__NSArrayReverseEnumerator";
		public static readonly RuntimeClass __NSCFArray = "__NSCFArray";
		public static readonly RuntimeClass __NSCFDate = "__NSCFDate";
		public static readonly RuntimeClass __NSCFDictionary = "__NSCFDictionary";
		public static readonly RuntimeClass __NSCFOrderedSet = "__NSCFOrderedSet";
		public static readonly RuntimeClass __NSCFSet = "__NSCFSet";
		public static readonly RuntimeClass __NSDictionaryObjectEnumerator = "__NSDictionaryObjectEnumerator";
		public static readonly RuntimeClass __NSFastEnumerationEnumerator = "__NSFastEnumerationEnumerator";
		public static readonly RuntimeClass __NSOrderedSetReverseEnumerator = "__NSOrderedSetReverseEnumerator";
		public static readonly RuntimeClass __NSPlaceholderArray = "__NSPlaceholderArray";
		public static readonly RuntimeClass __NSPlaceholderDate = "__NSPlaceholderDate";
		public static readonly RuntimeClass __NSPlaceholderDictionary = "__NSPlaceholderDictionary";
		public static readonly RuntimeClass __NSPlaceholderOrderedSet = "__NSPlaceholderOrderedSet";
		public static readonly RuntimeClass __NSPlaceholderSet = "__NSPlaceholderSet";
		public static readonly RuntimeClass _NSZombie_ = "_NSZombie_";
		public static readonly RuntimeClass CFXPreferencesCompatibilitySource = "CFXPreferencesCompatibilitySource";
		public static readonly RuntimeClass CFXPreferencesManagedSource = "CFXPreferencesManagedSource";
		public static readonly RuntimeClass CFXPreferencesPropertyListSource = "CFXPreferencesPropertyListSource";
		public static readonly RuntimeClass CFXPreferencesSearchListSource = "CFXPreferencesSearchListSource";
		public static readonly RuntimeClass CFXPreferencesSource = "CFXPreferencesSource";
		public static readonly RuntimeClass NSArray = "NSArray";
		public static readonly RuntimeClass NSCalendar = "NSCalendar";
		public static readonly RuntimeClass NSCFString = "NSCFString";
		public static readonly RuntimeClass NSData = "NSData";
		public static readonly RuntimeClass NSDate = "NSDate";
		public static readonly RuntimeClass NSDateComponents = "NSDateComponents";
		public static readonly RuntimeClass NSDictionary = "NSDictionary";
		public static readonly RuntimeClass NSEnumerator = "NSEnumerator";
		public static readonly RuntimeClass NSException = "NSException";
		public static readonly RuntimeClass NSInputStream = "NSInputStream";
		public static readonly RuntimeClass NSInvocation = "NSInvocation";
		public static readonly RuntimeClass NSLocale = "NSLocale";
		public static readonly RuntimeClass NSMessageBuilder = "NSMessageBuilder";
		public static readonly RuntimeClass NSMethodSignature = "NSMethodSignature";
		public static readonly RuntimeClass NSMutableArray = "NSMutableArray";
		public static readonly RuntimeClass NSMutableData = "NSMutableData";
		public static readonly RuntimeClass NSMutableDictionary = "NSMutableDictionary";
		public static readonly RuntimeClass NSMutableOrderedSet = "NSMutableOrderedSet";
		public static readonly RuntimeClass NSMutableSet = "NSMutableSet";
		public static readonly RuntimeClass NSNull = "NSNull";
		public static readonly RuntimeClass NSObject = "NSObject";
		public static readonly RuntimeClass NSOrderedSet = "NSOrderedSet";
		public static readonly RuntimeClass NSOutputStream = "NSOutputStream";
		public static readonly RuntimeClass NSRunLoop = "NSRunLoop";
		public static readonly RuntimeClass NSSet = "NSSet";
		public static readonly RuntimeClass NSStream = "NSStream";
		public static readonly RuntimeClass NSTimer = "NSTimer";
		public static readonly RuntimeClass NSTimeZone = "NSTimeZone";
		public static readonly RuntimeClass NSUserDefaults = "NSUserDefaults";
		public static readonly RuntimeClass Protocol = "Protocol";
	}
}
