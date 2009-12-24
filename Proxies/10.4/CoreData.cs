//
// Copyright (C) 2009 Eugeny Grishul
//
// See license in License.txt
//

namespace NObjective.Proxies {
	using System;
	using System.Runtime.InteropServices;
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct _NS128bitWrapper : IEquatable<_NS128bitWrapper> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses._NS128bitWrapper;
		public static implicit operator IntPtr( _NS128bitWrapper value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( _NS128bitWrapper value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as _NS128bitWrapper?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( _NS128bitWrapper value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( _NS128bitWrapper value1, _NS128bitWrapper value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( _NS128bitWrapper value1, _NS128bitWrapper value2 ) {
			return value1.Handle != value2.Handle;
		}
		public _NS128bitWrapper( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static _NS128bitWrapper alloc() {
			return new _NS128bitWrapper( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject initWithBytes_( System.IntPtr bytes ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithBytes_( Handle, CachedSelectors.initWithBytes_, out ___occuredException, sizeof( System.IntPtr ), bytes );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithBytes_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr bytes );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithBytes_ = "initWithBytes:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSException ) )]
	public struct _NSCoreDataException : IEquatable<_NSCoreDataException> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses._NSCoreDataException;
		public static implicit operator IntPtr( _NSCoreDataException value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( _NSCoreDataException value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as _NSCoreDataException?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( _NSCoreDataException value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( _NSCoreDataException value1, _NSCoreDataException value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( _NSCoreDataException value1, _NSCoreDataException value2 ) {
			return value1.Handle != value2.Handle;
		}
		public _NSCoreDataException( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static _NSCoreDataException alloc() {
			return new _NSCoreDataException( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject exceptionWithName_code_reason_userInfo_( NObjective.RuntimeObject name, int code, NObjective.RuntimeObject reason, NObjective.RuntimeObject userInfo ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.exceptionWithName_code_reason_userInfo_( ClassHandle, CachedSelectors.exceptionWithName_code_reason_userInfo_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( int ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), name, code, reason, userInfo );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public int code() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.code( Handle, CachedSelectors.code, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject initWithName_code_reason_userInfo_( NObjective.RuntimeObject name, int code, NObjective.RuntimeObject reason, NObjective.RuntimeObject userInfo ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithName_code_reason_userInfo_( Handle, CachedSelectors.initWithName_code_reason_userInfo_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( int ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), name, code, reason, userInfo );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int code( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr exceptionWithName_code_reason_userInfo_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name, int code, NObjective.RuntimeObject reason, NObjective.RuntimeObject userInfo );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithName_code_reason_userInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name, int code, NObjective.RuntimeObject reason, NObjective.RuntimeObject userInfo );
		}
		static internal class CachedSelectors {
			public static readonly Selector code = "code";
			public static readonly Selector exceptionWithName_code_reason_userInfo_ = "exceptionWithName:code:reason:userInfo:";
			public static readonly Selector initWithName_code_reason_userInfo_ = "initWithName:code:reason:userInfo:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSException ) )]
	public struct _NSCoreDataOptimisticLockingException : IEquatable<_NSCoreDataOptimisticLockingException> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses._NSCoreDataOptimisticLockingException;
		public static implicit operator IntPtr( _NSCoreDataOptimisticLockingException value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( _NSCoreDataOptimisticLockingException value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as _NSCoreDataOptimisticLockingException?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( _NSCoreDataOptimisticLockingException value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( _NSCoreDataOptimisticLockingException value1, _NSCoreDataOptimisticLockingException value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( _NSCoreDataOptimisticLockingException value1, _NSCoreDataOptimisticLockingException value2 ) {
			return value1.Handle != value2.Handle;
		}
		public _NSCoreDataOptimisticLockingException( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static _NSCoreDataOptimisticLockingException alloc() {
			return new _NSCoreDataOptimisticLockingException( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSMutableArray ) )]
	public struct _NSFaultingMutableArray : IEquatable<_NSFaultingMutableArray> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses._NSFaultingMutableArray;
		public static implicit operator IntPtr( _NSFaultingMutableArray value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( _NSFaultingMutableArray value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as _NSFaultingMutableArray?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( _NSFaultingMutableArray value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( _NSFaultingMutableArray value1, _NSFaultingMutableArray value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( _NSFaultingMutableArray value1, _NSFaultingMutableArray value2 ) {
			return value1.Handle != value2.Handle;
		}
		public _NSFaultingMutableArray( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static _NSFaultingMutableArray alloc() {
			return new _NSFaultingMutableArray( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject initWithSource_forRelationship_asFault_( NObjective.RuntimeObject source, NObjective.RuntimeObject forRelationship, char asFault ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithSource_forRelationship_asFault_( Handle, CachedSelectors.initWithSource_forRelationship_asFault_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( char ), source, forRelationship, asFault );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject relationship() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.relationship( Handle, CachedSelectors.relationship, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject source() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.source( Handle, CachedSelectors.source, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void turnIntoFault() {
			RuntimeObject ___occuredException;
			NativeMethods.turnIntoFault( Handle, CachedSelectors.turnIntoFault, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void willRead() {
			RuntimeObject ___occuredException;
			NativeMethods.willRead( Handle, CachedSelectors.willRead, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithSource_forRelationship_asFault_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject source, NObjective.RuntimeObject forRelationship, char asFault );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr relationship( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr source( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void turnIntoFault( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void willRead( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithSource_forRelationship_asFault_ = "initWithSource:forRelationship:asFault:";
			public static readonly Selector relationship = "relationship";
			public static readonly Selector source = "source";
			public static readonly Selector turnIntoFault = "turnIntoFault";
			public static readonly Selector willRead = "willRead";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSMutableSet ) )]
	public struct _NSFaultingMutableSet : IEquatable<_NSFaultingMutableSet> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses._NSFaultingMutableSet;
		public static implicit operator IntPtr( _NSFaultingMutableSet value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( _NSFaultingMutableSet value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as _NSFaultingMutableSet?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( _NSFaultingMutableSet value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( _NSFaultingMutableSet value1, _NSFaultingMutableSet value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( _NSFaultingMutableSet value1, _NSFaultingMutableSet value2 ) {
			return value1.Handle != value2.Handle;
		}
		public _NSFaultingMutableSet( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static _NSFaultingMutableSet alloc() {
			return new _NSFaultingMutableSet( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject initWithSource_forRelationship_asFault_( NObjective.RuntimeObject source, NObjective.RuntimeObject forRelationship, char asFault ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithSource_forRelationship_asFault_( Handle, CachedSelectors.initWithSource_forRelationship_asFault_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( char ), source, forRelationship, asFault );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject relationship() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.relationship( Handle, CachedSelectors.relationship, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject source() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.source( Handle, CachedSelectors.source, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void turnIntoFault() {
			RuntimeObject ___occuredException;
			NativeMethods.turnIntoFault( Handle, CachedSelectors.turnIntoFault, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void willRead() {
			RuntimeObject ___occuredException;
			NativeMethods.willRead( Handle, CachedSelectors.willRead, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithSource_forRelationship_asFault_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject source, NObjective.RuntimeObject forRelationship, char asFault );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr relationship( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr source( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void turnIntoFault( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void willRead( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithSource_forRelationship_asFault_ = "initWithSource:forRelationship:asFault:";
			public static readonly Selector relationship = "relationship";
			public static readonly Selector source = "source";
			public static readonly Selector turnIntoFault = "turnIntoFault";
			public static readonly Selector willRead = "willRead";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct _NSFaultingMutableSetMutationMethods : IEquatable<_NSFaultingMutableSetMutationMethods> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses._NSFaultingMutableSetMutationMethods;
		public static implicit operator IntPtr( _NSFaultingMutableSetMutationMethods value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( _NSFaultingMutableSetMutationMethods value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as _NSFaultingMutableSetMutationMethods?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( _NSFaultingMutableSetMutationMethods value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( _NSFaultingMutableSetMutationMethods value1, _NSFaultingMutableSetMutationMethods value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( _NSFaultingMutableSetMutationMethods value1, _NSFaultingMutableSetMutationMethods value2 ) {
			return value1.Handle != value2.Handle;
		}
		public _NSFaultingMutableSetMutationMethods( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static _NSFaultingMutableSetMutationMethods alloc() {
			return new _NSFaultingMutableSetMutationMethods( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSFaultHandler ) )]
	public struct _NSInvalidationFaultHandler : IEquatable<_NSInvalidationFaultHandler> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses._NSInvalidationFaultHandler;
		public static implicit operator IntPtr( _NSInvalidationFaultHandler value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( _NSInvalidationFaultHandler value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as _NSInvalidationFaultHandler?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( _NSInvalidationFaultHandler value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( _NSInvalidationFaultHandler value1, _NSInvalidationFaultHandler value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( _NSInvalidationFaultHandler value1, _NSInvalidationFaultHandler value2 ) {
			return value1.Handle != value2.Handle;
		}
		public _NSInvalidationFaultHandler( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static _NSInvalidationFaultHandler alloc() {
			return new _NSInvalidationFaultHandler( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject defaultHandler() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.defaultHandler( ClassHandle, CachedSelectors.defaultHandler, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject fulfillAggregateFaultForObject_andRelationship_withContext_( NObjective.RuntimeObject @object, NObjective.RuntimeObject andRelationship, NObjective.RuntimeObject withContext ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.fulfillAggregateFaultForObject_andRelationship_withContext_( Handle, CachedSelectors.fulfillAggregateFaultForObject_andRelationship_withContext_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), @object, andRelationship, withContext );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr defaultHandler( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr fulfillAggregateFaultForObject_andRelationship_withContext_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, NObjective.RuntimeObject andRelationship, NObjective.RuntimeObject withContext );
		}
		static internal class CachedSelectors {
			public static readonly Selector defaultHandler = "defaultHandler";
			public static readonly Selector fulfillAggregateFaultForObject_andRelationship_withContext_ = "fulfillAggregateFaultForObject:andRelationship:withContext:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSMutableDictionary ) )]
	public struct _NSKnownKeysDictionary : IEquatable<_NSKnownKeysDictionary> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses._NSKnownKeysDictionary;
		public static implicit operator IntPtr( _NSKnownKeysDictionary value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( _NSKnownKeysDictionary value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as _NSKnownKeysDictionary?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( _NSKnownKeysDictionary value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( _NSKnownKeysDictionary value1, _NSKnownKeysDictionary value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( _NSKnownKeysDictionary value1, _NSKnownKeysDictionary value2 ) {
			return value1.Handle != value2.Handle;
		}
		public _NSKnownKeysDictionary( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static _NSKnownKeysDictionary alloc() {
			return new _NSKnownKeysDictionary( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject initForKeys_( NObjective.RuntimeObject keys ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initForKeys_( Handle, CachedSelectors.initForKeys_, out ___occuredException, sizeof( NObjective.RuntimeObject ), keys );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithSearchStrategy_( NObjective.RuntimeObject strategy ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithSearchStrategy_( Handle, CachedSelectors.initWithSearchStrategy_, out ___occuredException, sizeof( NObjective.RuntimeObject ), strategy );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject mapping() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mapping( Handle, CachedSelectors.mapping, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public System.IntPtr values() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.values( Handle, CachedSelectors.values, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initForKeys_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject keys );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithSearchStrategy_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject strategy );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr mapping( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern System.IntPtr values( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector initForKeys_ = "initForKeys:";
			public static readonly Selector initWithSearchStrategy_ = "initWithSearchStrategy:";
			public static readonly Selector mapping = "mapping";
			public static readonly Selector values = "values";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSEnumerator ) )]
	public struct _NSKnownKeysEnumerator : IEquatable<_NSKnownKeysEnumerator> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses._NSKnownKeysEnumerator;
		public static implicit operator IntPtr( _NSKnownKeysEnumerator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( _NSKnownKeysEnumerator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as _NSKnownKeysEnumerator?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( _NSKnownKeysEnumerator value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( _NSKnownKeysEnumerator value1, _NSKnownKeysEnumerator value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( _NSKnownKeysEnumerator value1, _NSKnownKeysEnumerator value2 ) {
			return value1.Handle != value2.Handle;
		}
		public _NSKnownKeysEnumerator( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static _NSKnownKeysEnumerator alloc() {
			return new _NSKnownKeysEnumerator( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct _NSKnownKeysMappingStrategy : IEquatable<_NSKnownKeysMappingStrategy> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses._NSKnownKeysMappingStrategy;
		public static implicit operator IntPtr( _NSKnownKeysMappingStrategy value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( _NSKnownKeysMappingStrategy value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as _NSKnownKeysMappingStrategy?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( _NSKnownKeysMappingStrategy value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( _NSKnownKeysMappingStrategy value1, _NSKnownKeysMappingStrategy value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( _NSKnownKeysMappingStrategy value1, _NSKnownKeysMappingStrategy value2 ) {
			return value1.Handle != value2.Handle;
		}
		public _NSKnownKeysMappingStrategy( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static _NSKnownKeysMappingStrategy alloc() {
			return new _NSKnownKeysMappingStrategy( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void encodeWithCoder_( NSCoder coder ) {
			RuntimeObject ___occuredException;
			NativeMethods.encodeWithCoder_( Handle, CachedSelectors.encodeWithCoder_, out ___occuredException, sizeof( NSCoder ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public uint fastIndexForKnownKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.fastIndexForKnownKey_( Handle, CachedSelectors.fastIndexForKnownKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public uint indexForKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.indexForKey_( Handle, CachedSelectors.indexForKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public NObjective.RuntimeObject initForKeys_( NObjective.RuntimeObject keys ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initForKeys_( Handle, CachedSelectors.initForKeys_, out ___occuredException, sizeof( NObjective.RuntimeObject ), keys );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initForKeys_count_( System.IntPtr keys, uint count ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initForKeys_count_( Handle, CachedSelectors.initForKeys_count_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( uint ), keys, count );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithCoder_( NObjective.RuntimeObject coder ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCoder_( Handle, CachedSelectors.initWithCoder_, out ___occuredException, sizeof( NObjective.RuntimeObject ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public System.IntPtr keys() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.keys( Handle, CachedSelectors.keys, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public uint length() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.length( Handle, CachedSelectors.length, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void encodeWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSCoder coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint fastIndexForKnownKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint indexForKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initForKeys_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject keys );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initForKeys_count_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr keys, uint count );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern System.IntPtr keys( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint length( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector encodeWithCoder_ = "encodeWithCoder:";
			public static readonly Selector fastIndexForKnownKey_ = "fastIndexForKnownKey:";
			public static readonly Selector indexForKey_ = "indexForKey:";
			public static readonly Selector initForKeys_ = "initForKeys:";
			public static readonly Selector initForKeys_count_ = "initForKeys:count:";
			public static readonly Selector initWithCoder_ = "initWithCoder:";
			public static readonly Selector keys = "keys";
			public static readonly Selector length = "length";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct _NSMemoryStorePredicateRemapper : IEquatable<_NSMemoryStorePredicateRemapper> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses._NSMemoryStorePredicateRemapper;
		public static implicit operator IntPtr( _NSMemoryStorePredicateRemapper value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( _NSMemoryStorePredicateRemapper value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as _NSMemoryStorePredicateRemapper?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( _NSMemoryStorePredicateRemapper value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( _NSMemoryStorePredicateRemapper value1, _NSMemoryStorePredicateRemapper value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( _NSMemoryStorePredicateRemapper value1, _NSMemoryStorePredicateRemapper value2 ) {
			return value1.Handle != value2.Handle;
		}
		public _NSMemoryStorePredicateRemapper( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static _NSMemoryStorePredicateRemapper alloc() {
			return new _NSMemoryStorePredicateRemapper( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject defaultInstance() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.defaultInstance( ClassHandle, CachedSelectors.defaultInstance, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject createPredicateForFetchFromPredicate_( NObjective.RuntimeObject predicate ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.createPredicateForFetchFromPredicate_( Handle, CachedSelectors.createPredicateForFetchFromPredicate_, out ___occuredException, sizeof( NObjective.RuntimeObject ), predicate );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void visitPredicate_( NObjective.RuntimeObject predicate ) {
			RuntimeObject ___occuredException;
			NativeMethods.visitPredicate_( Handle, CachedSelectors.visitPredicate_, out ___occuredException, sizeof( NObjective.RuntimeObject ), predicate );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void visitPredicateExpression_( NObjective.RuntimeObject expression ) {
			RuntimeObject ___occuredException;
			NativeMethods.visitPredicateExpression_( Handle, CachedSelectors.visitPredicateExpression_, out ___occuredException, sizeof( NObjective.RuntimeObject ), expression );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr createPredicateForFetchFromPredicate_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject predicate );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr defaultInstance( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void visitPredicate_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject predicate );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void visitPredicateExpression_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject expression );
		}
		static internal class CachedSelectors {
			public static readonly Selector createPredicateForFetchFromPredicate_ = "createPredicateForFetchFromPredicate:";
			public static readonly Selector defaultInstance = "defaultInstance";
			public static readonly Selector visitPredicate_ = "visitPredicate:";
			public static readonly Selector visitPredicateExpression_ = "visitPredicateExpression:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSMutableSet ) )]
	public struct _NSNotifyingWrapperMutableSet : IEquatable<_NSNotifyingWrapperMutableSet> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses._NSNotifyingWrapperMutableSet;
		public static implicit operator IntPtr( _NSNotifyingWrapperMutableSet value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( _NSNotifyingWrapperMutableSet value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as _NSNotifyingWrapperMutableSet?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( _NSNotifyingWrapperMutableSet value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( _NSNotifyingWrapperMutableSet value1, _NSNotifyingWrapperMutableSet value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( _NSNotifyingWrapperMutableSet value1, _NSNotifyingWrapperMutableSet value2 ) {
			return value1.Handle != value2.Handle;
		}
		public _NSNotifyingWrapperMutableSet( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static _NSNotifyingWrapperMutableSet alloc() {
			return new _NSNotifyingWrapperMutableSet( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject initWithContainer_key_mutableSet_( NObjective.RuntimeObject container, NObjective.RuntimeObject key, NObjective.RuntimeObject mutableSet ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithContainer_key_mutableSet_( Handle, CachedSelectors.initWithContainer_key_mutableSet_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), container, key, mutableSet );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithContainer_key_mutableSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject container, NObjective.RuntimeObject key, NObjective.RuntimeObject mutableSet );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithContainer_key_mutableSet_ = "initWithContainer:key:mutableSet:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct _NSPersistenceUtilities : IEquatable<_NSPersistenceUtilities> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses._NSPersistenceUtilities;
		public static implicit operator IntPtr( _NSPersistenceUtilities value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( _NSPersistenceUtilities value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as _NSPersistenceUtilities?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( _NSPersistenceUtilities value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( _NSPersistenceUtilities value1, _NSPersistenceUtilities value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( _NSPersistenceUtilities value1, _NSPersistenceUtilities value2 ) {
			return value1.Handle != value2.Handle;
		}
		public _NSPersistenceUtilities( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static _NSPersistenceUtilities alloc() {
			return new _NSPersistenceUtilities( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static int attributeTypeForXMLInfo_( NObjective.RuntimeObject info ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.attributeTypeForXMLInfo_( ClassHandle, CachedSelectors.attributeTypeForXMLInfo_, out ___occuredException, sizeof( NObjective.RuntimeObject ), info );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static NObjective.RuntimeObject reverseEngineerModelFromXMLDataAt_( NObjective.RuntimeObject at ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.reverseEngineerModelFromXMLDataAt_( ClassHandle, CachedSelectors.reverseEngineerModelFromXMLDataAt_, out ___occuredException, sizeof( NObjective.RuntimeObject ), at );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int attributeTypeForXMLInfo_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject info );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr reverseEngineerModelFromXMLDataAt_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject at );
		}
		static internal class CachedSelectors {
			public static readonly Selector attributeTypeForXMLInfo_ = "attributeTypeForXMLInfo:";
			public static readonly Selector reverseEngineerModelFromXMLDataAt_ = "reverseEngineerModelFromXMLDataAt:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( _NSNotifyingWrapperMutableSet ) )]
	public struct _NSProxyWrapperMutableSet : IEquatable<_NSProxyWrapperMutableSet> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses._NSProxyWrapperMutableSet;
		public static implicit operator IntPtr( _NSProxyWrapperMutableSet value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( _NSProxyWrapperMutableSet value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as _NSProxyWrapperMutableSet?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( _NSProxyWrapperMutableSet value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( _NSProxyWrapperMutableSet value1, _NSProxyWrapperMutableSet value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( _NSProxyWrapperMutableSet value1, _NSProxyWrapperMutableSet value2 ) {
			return value1.Handle != value2.Handle;
		}
		public _NSProxyWrapperMutableSet( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static _NSProxyWrapperMutableSet alloc() {
			return new _NSProxyWrapperMutableSet( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject initWithContainer_key_mutableSet_mutationMethods_( NObjective.RuntimeObject container, NObjective.RuntimeObject key, NObjective.RuntimeObject mutableSet, NObjective.RuntimeObject mutationMethods ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithContainer_key_mutableSet_mutationMethods_( Handle, CachedSelectors.initWithContainer_key_mutableSet_mutationMethods_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), container, key, mutableSet, mutationMethods );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithContainer_key_mutableSet_mutationMethods_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject container, NObjective.RuntimeObject key, NObjective.RuntimeObject mutableSet, NObjective.RuntimeObject mutationMethods );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithContainer_key_mutableSet_mutationMethods_ = "initWithContainer:key:mutableSet:mutationMethods:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct _PFRoutines : IEquatable<_PFRoutines> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses._PFRoutines;
		public static implicit operator IntPtr( _PFRoutines value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( _PFRoutines value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as _PFRoutines?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( _PFRoutines value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( _PFRoutines value1, _PFRoutines value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( _PFRoutines value1, _PFRoutines value2 ) {
			return value1.Handle != value2.Handle;
		}
		public _PFRoutines( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static _PFRoutines alloc() {
			return new _PFRoutines( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static System.IntPtr allocateVirtualMemory_( uint memory ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.allocateVirtualMemory_( ClassHandle, CachedSelectors.allocateVirtualMemory_, out ___occuredException, sizeof( uint ), memory );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static char convertCString_toUnsignedInt64_withBase_( System.IntPtr @string, System.IntPtr toUnsignedInt64, int withBase ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.convertCString_toUnsignedInt64_withBase_( ClassHandle, CachedSelectors.convertCString_toUnsignedInt64_withBase_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( System.IntPtr ) + sizeof( int ), @string, toUnsignedInt64, withBase );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static NObjective.RuntimeObject escapeInvalidXMLCharactersInString_( NObjective.RuntimeObject @string ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.escapeInvalidXMLCharactersInString_( ClassHandle, CachedSelectors.escapeInvalidXMLCharactersInString_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @string );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static void freeVirtualMemory_forSize_( System.IntPtr memory, uint forSize ) {
			RuntimeObject ___occuredException;
			NativeMethods.freeVirtualMemory_forSize_( ClassHandle, CachedSelectors.freeVirtualMemory_forSize_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( uint ), memory, forSize );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static NObjective.RuntimeObject invalidXMLCharacterSet() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.invalidXMLCharacterSet( ClassHandle, CachedSelectors.invalidXMLCharacterSet, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static bool isInvalidXMLCharacter_( ushort character ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isInvalidXMLCharacter_( ClassHandle, CachedSelectors.isInvalidXMLCharacter_, out ___occuredException, sizeof( ushort ), character );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static NObjective.RuntimeObject revertInvalidXMLEscapedString_( NObjective.RuntimeObject @string ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.revertInvalidXMLEscapedString_( ClassHandle, CachedSelectors.revertInvalidXMLEscapedString_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @string );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern System.IntPtr allocateVirtualMemory_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint memory );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char convertCString_toUnsignedInt64_withBase_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr @string, System.IntPtr toUnsignedInt64, int withBase );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr escapeInvalidXMLCharactersInString_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @string );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void freeVirtualMemory_forSize_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr memory, uint forSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr invalidXMLCharacterSet( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isInvalidXMLCharacter_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, ushort character );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr revertInvalidXMLEscapedString_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @string );
		}
		static internal class CachedSelectors {
			public static readonly Selector allocateVirtualMemory_ = "allocateVirtualMemory:";
			public static readonly Selector convertCString_toUnsignedInt64_withBase_ = "convertCString:toUnsignedInt64:withBase:";
			public static readonly Selector escapeInvalidXMLCharactersInString_ = "escapeInvalidXMLCharactersInString:";
			public static readonly Selector freeVirtualMemory_forSize_ = "freeVirtualMemory:forSize:";
			public static readonly Selector invalidXMLCharacterSet = "invalidXMLCharacterSet";
			public static readonly Selector isInvalidXMLCharacter_ = "isInvalidXMLCharacter:";
			public static readonly Selector revertInvalidXMLEscapedString_ = "revertInvalidXMLEscapedString:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSPropertyDescription ) )]
	public struct NSAttributeDescription : IEquatable<NSAttributeDescription> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSAttributeDescription;
		public static implicit operator IntPtr( NSAttributeDescription value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSAttributeDescription value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSAttributeDescription?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSAttributeDescription value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSAttributeDescription value1, NSAttributeDescription value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSAttributeDescription value1, NSAttributeDescription value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSAttributeDescription( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSAttributeDescription alloc() {
			return new NSAttributeDescription( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NSAttributeType attributeType() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.attributeType( Handle, CachedSelectors.attributeType, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( NSAttributeType ) ___result;
		}
		unsafe public string attributeValueClassName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.attributeValueClassName( Handle, CachedSelectors.attributeValueClassName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public NObjective.RuntimeObject defaultValue() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.defaultValue( Handle, CachedSelectors.defaultValue, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setAttributeType_( NSAttributeType type ) {
			RuntimeObject ___occuredException;
			NativeMethods.setAttributeType_( Handle, CachedSelectors.setAttributeType_, out ___occuredException, sizeof( NSAttributeType ), type );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setDefaultValue_( NObjective.RuntimeObject value ) {
			RuntimeObject ___occuredException;
			NativeMethods.setDefaultValue_( Handle, CachedSelectors.setDefaultValue_, out ___occuredException, sizeof( NObjective.RuntimeObject ), value );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int attributeType( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr attributeValueClassName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr defaultValue( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setAttributeType_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSAttributeType type );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setDefaultValue_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject value );
		}
		static internal class CachedSelectors {
			public static readonly Selector attributeType = "attributeType";
			public static readonly Selector attributeValueClassName = "attributeValueClassName";
			public static readonly Selector defaultValue = "defaultValue";
			public static readonly Selector setAttributeType_ = "setAttributeType:";
			public static readonly Selector setDefaultValue_ = "setDefaultValue:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSPropertyMapping ) )]
	public struct NSAttributeMapping : IEquatable<NSAttributeMapping> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSAttributeMapping;
		public static implicit operator IntPtr( NSAttributeMapping value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSAttributeMapping value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSAttributeMapping?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSAttributeMapping value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSAttributeMapping value1, NSAttributeMapping value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSAttributeMapping value1, NSAttributeMapping value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSAttributeMapping( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSAttributeMapping alloc() {
			return new NSAttributeMapping( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject attribute() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.attribute( Handle, CachedSelectors.attribute, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject columnDefinition() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.columnDefinition( Handle, CachedSelectors.columnDefinition, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public uint externalPrecision() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.externalPrecision( Handle, CachedSelectors.externalPrecision, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public int externalScale() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.externalScale( Handle, CachedSelectors.externalScale, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public int externalType() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.externalType( Handle, CachedSelectors.externalType, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void setExternalPrecision_( uint precision ) {
			RuntimeObject ___occuredException;
			NativeMethods.setExternalPrecision_( Handle, CachedSelectors.setExternalPrecision_, out ___occuredException, sizeof( uint ), precision );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setExternalScale_( int scale ) {
			RuntimeObject ___occuredException;
			NativeMethods.setExternalScale_( Handle, CachedSelectors.setExternalScale_, out ___occuredException, sizeof( int ), scale );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setExternalType_( int type ) {
			RuntimeObject ___occuredException;
			NativeMethods.setExternalType_( Handle, CachedSelectors.setExternalType_, out ___occuredException, sizeof( int ), type );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject sqlType() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sqlType( Handle, CachedSelectors.sqlType, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr attribute( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr columnDefinition( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint externalPrecision( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int externalScale( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int externalType( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setExternalPrecision_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint precision );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setExternalScale_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int scale );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setExternalType_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int type );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr sqlType( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector attribute = "attribute";
			public static readonly Selector columnDefinition = "columnDefinition";
			public static readonly Selector externalPrecision = "externalPrecision";
			public static readonly Selector externalScale = "externalScale";
			public static readonly Selector externalType = "externalType";
			public static readonly Selector setExternalPrecision_ = "setExternalPrecision:";
			public static readonly Selector setExternalScale_ = "setExternalScale:";
			public static readonly Selector setExternalType_ = "setExternalType:";
			public static readonly Selector sqlType = "sqlType";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSManagedObjectID ) )]
	public struct NSBasicObjectID : IEquatable<NSBasicObjectID> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSBasicObjectID;
		public static implicit operator IntPtr( NSBasicObjectID value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSBasicObjectID value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSBasicObjectID?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSBasicObjectID value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSBasicObjectID value1, NSBasicObjectID value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSBasicObjectID value1, NSBasicObjectID value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSBasicObjectID( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSBasicObjectID alloc() {
			return new NSBasicObjectID( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NSBasicObjectID initWithFactory_( NObjective.RuntimeObject factory ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithFactory_( Handle, CachedSelectors.initWithFactory_, out ___occuredException, sizeof( NObjective.RuntimeObject ), factory );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSBasicObjectID( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithFactory_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject factory );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithFactory_ = "initWithFactory:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSMappedObjectStore ) )]
	public struct NSBinaryObjectStore : IEquatable<NSBinaryObjectStore> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSBinaryObjectStore;
		public static implicit operator IntPtr( NSBinaryObjectStore value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSBinaryObjectStore value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSBinaryObjectStore?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSBinaryObjectStore value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSBinaryObjectStore value1, NSBinaryObjectStore value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSBinaryObjectStore value1, NSBinaryObjectStore value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSBinaryObjectStore( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSBinaryObjectStore alloc() {
			return new NSBinaryObjectStore( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSBinaryObjectStoreFile : IEquatable<NSBinaryObjectStoreFile> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSBinaryObjectStoreFile;
		public static implicit operator IntPtr( NSBinaryObjectStoreFile value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSBinaryObjectStoreFile value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSBinaryObjectStoreFile?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSBinaryObjectStoreFile value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSBinaryObjectStoreFile value1, NSBinaryObjectStoreFile value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSBinaryObjectStoreFile value1, NSBinaryObjectStoreFile value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSBinaryObjectStoreFile( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSBinaryObjectStoreFile alloc() {
			return new NSBinaryObjectStoreFile( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void clearCurrentValues() {
			RuntimeObject ___occuredException;
			NativeMethods.clearCurrentValues( Handle, CachedSelectors.clearCurrentValues, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public int databaseVersion() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.databaseVersion( Handle, CachedSelectors.databaseVersion, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject fullMetadata() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.fullMetadata( Handle, CachedSelectors.fullMetadata, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject mapData() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mapData( Handle, CachedSelectors.mapData, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public ulong primaryKeyGeneration() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.primaryKeyGeneration( Handle, CachedSelectors.primaryKeyGeneration, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char readBinaryStoreFromData_originalPath_error_( NObjective.RuntimeObject data, NObjective.RuntimeObject originalPath, System.IntPtr error ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.readBinaryStoreFromData_originalPath_error_( Handle, CachedSelectors.readBinaryStoreFromData_originalPath_error_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), data, originalPath, error );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char readFromFile_error_( NObjective.RuntimeObject file, System.IntPtr error ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.readFromFile_error_( Handle, CachedSelectors.readFromFile_error_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), file, error );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char readMetadataFromFile_error_( NObjective.RuntimeObject file, System.IntPtr error ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.readMetadataFromFile_error_( Handle, CachedSelectors.readMetadataFromFile_error_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), file, error );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void setDatabaseVersion_( int version ) {
			RuntimeObject ___occuredException;
			NativeMethods.setDatabaseVersion_( Handle, CachedSelectors.setDatabaseVersion_, out ___occuredException, sizeof( int ), version );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setFullMetadata_( NObjective.RuntimeObject metadata ) {
			RuntimeObject ___occuredException;
			NativeMethods.setFullMetadata_( Handle, CachedSelectors.setFullMetadata_, out ___occuredException, sizeof( NObjective.RuntimeObject ), metadata );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setMapData_( NObjective.RuntimeObject data ) {
			RuntimeObject ___occuredException;
			NativeMethods.setMapData_( Handle, CachedSelectors.setMapData_, out ___occuredException, sizeof( NObjective.RuntimeObject ), data );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setPrimaryKeyGeneration_( ulong generation ) {
			RuntimeObject ___occuredException;
			NativeMethods.setPrimaryKeyGeneration_( Handle, CachedSelectors.setPrimaryKeyGeneration_, out ___occuredException, sizeof( ulong ), generation );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public char writeToFile_error_( NObjective.RuntimeObject file, System.IntPtr error ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.writeToFile_error_( Handle, CachedSelectors.writeToFile_error_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), file, error );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void clearCurrentValues( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int databaseVersion( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr fullMetadata( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr mapData( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern ulong primaryKeyGeneration( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char readBinaryStoreFromData_originalPath_error_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject data, NObjective.RuntimeObject originalPath, System.IntPtr error );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char readFromFile_error_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file, System.IntPtr error );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char readMetadataFromFile_error_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file, System.IntPtr error );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setDatabaseVersion_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int version );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setFullMetadata_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject metadata );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setMapData_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject data );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setPrimaryKeyGeneration_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, ulong generation );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char writeToFile_error_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file, System.IntPtr error );
		}
		static internal class CachedSelectors {
			public static readonly Selector clearCurrentValues = "clearCurrentValues";
			public static readonly Selector databaseVersion = "databaseVersion";
			public static readonly Selector fullMetadata = "fullMetadata";
			public static readonly Selector mapData = "mapData";
			public static readonly Selector primaryKeyGeneration = "primaryKeyGeneration";
			public static readonly Selector readBinaryStoreFromData_originalPath_error_ = "readBinaryStoreFromData:originalPath:error:";
			public static readonly Selector readFromFile_error_ = "readFromFile:error:";
			public static readonly Selector readMetadataFromFile_error_ = "readMetadataFromFile:error:";
			public static readonly Selector setDatabaseVersion_ = "setDatabaseVersion:";
			public static readonly Selector setFullMetadata_ = "setFullMetadata:";
			public static readonly Selector setMapData_ = "setMapData:";
			public static readonly Selector setPrimaryKeyGeneration_ = "setPrimaryKeyGeneration:";
			public static readonly Selector writeToFile_error_ = "writeToFile:error:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObjectStoreRequest ) )]
	public struct NSCountRequest : IEquatable<NSCountRequest> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSCountRequest;
		public static implicit operator IntPtr( NSCountRequest value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSCountRequest value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSCountRequest?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSCountRequest value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSCountRequest value1, NSCountRequest value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSCountRequest value1, NSCountRequest value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSCountRequest( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSCountRequest alloc() {
			return new NSCountRequest( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject fetchRequest() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.fetchRequest( Handle, CachedSelectors.fetchRequest, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSCountRequest initWithFetchRequest_( NObjective.RuntimeObject request ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithFetchRequest_( Handle, CachedSelectors.initWithFetchRequest_, out ___occuredException, sizeof( NObjective.RuntimeObject ), request );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSCountRequest( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr fetchRequest( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithFetchRequest_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject request );
		}
		static internal class CachedSelectors {
			public static readonly Selector fetchRequest = "fetchRequest";
			public static readonly Selector initWithFetchRequest_ = "initWithFetchRequest:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSStoreMapNode ) )]
	public struct NSDictionaryMapNode : IEquatable<NSDictionaryMapNode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSDictionaryMapNode;
		public static implicit operator IntPtr( NSDictionaryMapNode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSDictionaryMapNode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSDictionaryMapNode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSDictionaryMapNode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSDictionaryMapNode value1, NSDictionaryMapNode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSDictionaryMapNode value1, NSDictionaryMapNode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSDictionaryMapNode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSDictionaryMapNode alloc() {
			return new NSDictionaryMapNode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public System.IntPtr attributeValues() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.attributeValues( Handle, CachedSelectors.attributeValues, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NSDictionaryMapNode initWithValues_objectID_( System.IntPtr values, NObjective.RuntimeObject objectID ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithValues_objectID_( Handle, CachedSelectors.initWithValues_objectID_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ), values, objectID );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionaryMapNode( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern System.IntPtr attributeValues( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithValues_objectID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr values, NObjective.RuntimeObject objectID );
		}
		static internal class CachedSelectors {
			public static readonly Selector attributeValues = "attributeValues";
			public static readonly Selector initWithValues_objectID_ = "initWithValues:objectID:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObjectStoreMap ) )]
	public struct NSDictionaryStoreMap : IEquatable<NSDictionaryStoreMap> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSDictionaryStoreMap;
		public static implicit operator IntPtr( NSDictionaryStoreMap value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSDictionaryStoreMap value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSDictionaryStoreMap?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSDictionaryStoreMap value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSDictionaryStoreMap value1, NSDictionaryStoreMap value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSDictionaryStoreMap value1, NSDictionaryStoreMap value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSDictionaryStoreMap( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSDictionaryStoreMap alloc() {
			return new NSDictionaryStoreMap( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NSDictionaryStoreMap initWithStore_fromArchivedData_( NObjective.RuntimeObject store, NObjective.RuntimeObject fromArchivedData ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithStore_fromArchivedData_( Handle, CachedSelectors.initWithStore_fromArchivedData_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), store, fromArchivedData );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionaryStoreMap( ___result );
		}
		unsafe public NSDictionaryStoreMap initWithStore_fromPath_( NObjective.RuntimeObject store, NObjective.RuntimeObject fromPath ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithStore_fromPath_( Handle, CachedSelectors.initWithStore_fromPath_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), store, fromPath );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionaryStoreMap( ___result );
		}
		unsafe public void saveToPath_( NObjective.RuntimeObject path ) {
			RuntimeObject ___occuredException;
			NativeMethods.saveToPath_( Handle, CachedSelectors.saveToPath_, out ___occuredException, sizeof( NObjective.RuntimeObject ), path );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithStore_fromArchivedData_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject store, NObjective.RuntimeObject fromArchivedData );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithStore_fromPath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject store, NObjective.RuntimeObject fromPath );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void saveToPath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject path );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithStore_fromArchivedData_ = "initWithStore:fromArchivedData:";
			public static readonly Selector initWithStore_fromPath_ = "initWithStore:fromPath:";
			public static readonly Selector saveToPath_ = "saveToPath:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSEntityDescription : IEquatable<NSEntityDescription> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSEntityDescription;
		public static implicit operator IntPtr( NSEntityDescription value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSEntityDescription value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSEntityDescription?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSEntityDescription value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSEntityDescription value1, NSEntityDescription value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSEntityDescription value1, NSEntityDescription value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSEntityDescription( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSEntityDescription alloc() {
			return new NSEntityDescription( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NSEntityDescription entityForName_inManagedObjectContext_( string name, NSManagedObjectContext inManagedObjectContext ) {
			RuntimeObject ___occuredException;
			var ___wrappedname = Runtime.CreateStringProxy( name );
			var ___result = NativeMethods.entityForName_inManagedObjectContext_( ClassHandle, CachedSelectors.entityForName_inManagedObjectContext_, out ___occuredException, sizeof( IntPtr ) + sizeof( NSManagedObjectContext ), ___wrappedname, inManagedObjectContext );
			Runtime.ReleaseNativeObject( ___wrappedname );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSEntityDescription( ___result );
		}
		unsafe public static NObjective.RuntimeObject insertNewObjectForEntityForName_inManagedObjectContext_( string name, NSManagedObjectContext inManagedObjectContext ) {
			RuntimeObject ___occuredException;
			var ___wrappedname = Runtime.CreateStringProxy( name );
			var ___result = NativeMethods.insertNewObjectForEntityForName_inManagedObjectContext_( ClassHandle, CachedSelectors.insertNewObjectForEntityForName_inManagedObjectContext_, out ___occuredException, sizeof( IntPtr ) + sizeof( NSManagedObjectContext ), ___wrappedname, inManagedObjectContext );
			Runtime.ReleaseNativeObject( ___wrappedname );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSDictionary attributesByName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.attributesByName( Handle, CachedSelectors.attributesByName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public void encodeWithCoder_( NSCoder coder ) {
			RuntimeObject ___occuredException;
			NativeMethods.encodeWithCoder_( Handle, CachedSelectors.encodeWithCoder_, out ___occuredException, sizeof( NSCoder ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSEntityDescription initWithCoder_( NObjective.RuntimeObject coder ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCoder_( Handle, CachedSelectors.initWithCoder_, out ___occuredException, sizeof( NObjective.RuntimeObject ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSEntityDescription( ___result );
		}
		unsafe public bool isAbstract() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isAbstract( Handle, CachedSelectors.isAbstract, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public string managedObjectClassName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.managedObjectClassName( Handle, CachedSelectors.managedObjectClassName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public NSManagedObjectModel managedObjectModel() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.managedObjectModel( Handle, CachedSelectors.managedObjectModel, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSManagedObjectModel( ___result );
		}
		unsafe public string name() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.name( Handle, CachedSelectors.name, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public NSArray properties() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.properties( Handle, CachedSelectors.properties, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public NSDictionary propertiesByName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.propertiesByName( Handle, CachedSelectors.propertiesByName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public NSDictionary relationshipsByName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.relationshipsByName( Handle, CachedSelectors.relationshipsByName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public NSArray relationshipsWithDestinationEntity_( NSEntityDescription entity ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.relationshipsWithDestinationEntity_( Handle, CachedSelectors.relationshipsWithDestinationEntity_, out ___occuredException, sizeof( NSEntityDescription ), entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public void setAbstract_( bool @abstract ) {
			RuntimeObject ___occuredException;
			NativeMethods.setAbstract_( Handle, CachedSelectors.setAbstract_, out ___occuredException, sizeof( bool ), @abstract );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setManagedObjectClassName_( string name ) {
			RuntimeObject ___occuredException;
			var ___wrappedname = Runtime.CreateStringProxy( name );
			NativeMethods.setManagedObjectClassName_( Handle, CachedSelectors.setManagedObjectClassName_, out ___occuredException, sizeof( IntPtr ), ___wrappedname );
			Runtime.ReleaseNativeObject( ___wrappedname );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setName_( string name ) {
			RuntimeObject ___occuredException;
			var ___wrappedname = Runtime.CreateStringProxy( name );
			NativeMethods.setName_( Handle, CachedSelectors.setName_, out ___occuredException, sizeof( IntPtr ), ___wrappedname );
			Runtime.ReleaseNativeObject( ___wrappedname );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setProperties_( NSArray properties ) {
			RuntimeObject ___occuredException;
			NativeMethods.setProperties_( Handle, CachedSelectors.setProperties_, out ___occuredException, sizeof( NSArray ), properties );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setSubentities_( NSArray subentities ) {
			RuntimeObject ___occuredException;
			NativeMethods.setSubentities_( Handle, CachedSelectors.setSubentities_, out ___occuredException, sizeof( NSArray ), subentities );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setUserInfo_( NSDictionary info ) {
			RuntimeObject ___occuredException;
			NativeMethods.setUserInfo_( Handle, CachedSelectors.setUserInfo_, out ___occuredException, sizeof( NSDictionary ), info );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSArray subentities() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.subentities( Handle, CachedSelectors.subentities, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public NSDictionary subentitiesByName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.subentitiesByName( Handle, CachedSelectors.subentitiesByName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public NSEntityDescription superentity() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.superentity( Handle, CachedSelectors.superentity, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSEntityDescription( ___result );
		}
		unsafe public NSDictionary userInfo() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.userInfo( Handle, CachedSelectors.userInfo, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr attributesByName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void encodeWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSCoder coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr entityForName_inManagedObjectContext_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name, NSManagedObjectContext inManagedObjectContext );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr insertNewObjectForEntityForName_inManagedObjectContext_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name, NSManagedObjectContext inManagedObjectContext );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isAbstract( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr managedObjectClassName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr managedObjectModel( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr name( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr properties( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr propertiesByName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr relationshipsByName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr relationshipsWithDestinationEntity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSEntityDescription entity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setAbstract_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, bool @abstract );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setManagedObjectClassName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setProperties_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray properties );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setSubentities_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray subentities );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setUserInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDictionary info );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr subentities( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr subentitiesByName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr superentity( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr userInfo( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector attributesByName = "attributesByName";
			public static readonly Selector encodeWithCoder_ = "encodeWithCoder:";
			public static readonly Selector entityForName_inManagedObjectContext_ = "entityForName:inManagedObjectContext:";
			public static readonly Selector initWithCoder_ = "initWithCoder:";
			public static readonly Selector insertNewObjectForEntityForName_inManagedObjectContext_ = "insertNewObjectForEntityForName:inManagedObjectContext:";
			public static readonly Selector isAbstract = "isAbstract";
			public static readonly Selector managedObjectClassName = "managedObjectClassName";
			public static readonly Selector managedObjectModel = "managedObjectModel";
			public static readonly Selector name = "name";
			public static readonly Selector properties = "properties";
			public static readonly Selector propertiesByName = "propertiesByName";
			public static readonly Selector relationshipsByName = "relationshipsByName";
			public static readonly Selector relationshipsWithDestinationEntity_ = "relationshipsWithDestinationEntity:";
			public static readonly Selector setAbstract_ = "setAbstract:";
			public static readonly Selector setManagedObjectClassName_ = "setManagedObjectClassName:";
			public static readonly Selector setName_ = "setName:";
			public static readonly Selector setProperties_ = "setProperties:";
			public static readonly Selector setSubentities_ = "setSubentities:";
			public static readonly Selector setUserInfo_ = "setUserInfo:";
			public static readonly Selector subentities = "subentities";
			public static readonly Selector subentitiesByName = "subentitiesByName";
			public static readonly Selector superentity = "superentity";
			public static readonly Selector userInfo = "userInfo";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSMapping ) )]
	public struct NSEntityMapping : IEquatable<NSEntityMapping> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSEntityMapping;
		public static implicit operator IntPtr( NSEntityMapping value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSEntityMapping value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSEntityMapping?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSEntityMapping value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSEntityMapping value1, NSEntityMapping value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSEntityMapping value1, NSEntityMapping value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSEntityMapping( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSEntityMapping alloc() {
			return new NSEntityMapping( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject attributeColumnDefinitions() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.attributeColumnDefinitions( Handle, CachedSelectors.attributeColumnDefinitions, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject attributeMappings() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.attributeMappings( Handle, CachedSelectors.attributeMappings, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject createTableStatement() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.createTableStatement( Handle, CachedSelectors.createTableStatement, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject entity() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entity( Handle, CachedSelectors.entity, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject foreignKeyColumnDefinitions() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.foreignKeyColumnDefinitions( Handle, CachedSelectors.foreignKeyColumnDefinitions, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject foreignKeyConstraintDefinitions() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.foreignKeyConstraintDefinitions( Handle, CachedSelectors.foreignKeyConstraintDefinitions, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSEntityMapping initWithEntity_( NObjective.RuntimeObject entity ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithEntity_( Handle, CachedSelectors.initWithEntity_, out ___occuredException, sizeof( NObjective.RuntimeObject ), entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSEntityMapping( ___result );
		}
		unsafe public bool isSingleTableEntity() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isSingleTableEntity( Handle, CachedSelectors.isSingleTableEntity, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject primaryKeyColumnDefinitions() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.primaryKeyColumnDefinitions( Handle, CachedSelectors.primaryKeyColumnDefinitions, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject primaryKeys() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.primaryKeys( Handle, CachedSelectors.primaryKeys, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject propertyMappings() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.propertyMappings( Handle, CachedSelectors.propertyMappings, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject relationshipMappings() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.relationshipMappings( Handle, CachedSelectors.relationshipMappings, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setEntity_( NObjective.RuntimeObject entity ) {
			RuntimeObject ___occuredException;
			NativeMethods.setEntity_( Handle, CachedSelectors.setEntity_, out ___occuredException, sizeof( NObjective.RuntimeObject ), entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setPrimaryKeys_( NObjective.RuntimeObject keys ) {
			RuntimeObject ___occuredException;
			NativeMethods.setPrimaryKeys_( Handle, CachedSelectors.setPrimaryKeys_, out ___occuredException, sizeof( NObjective.RuntimeObject ), keys );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setPropertyMappings_( NObjective.RuntimeObject mappings ) {
			RuntimeObject ___occuredException;
			NativeMethods.setPropertyMappings_( Handle, CachedSelectors.setPropertyMappings_, out ___occuredException, sizeof( NObjective.RuntimeObject ), mappings );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setSingleTableEntity_( char entity ) {
			RuntimeObject ___occuredException;
			NativeMethods.setSingleTableEntity_( Handle, CachedSelectors.setSingleTableEntity_, out ___occuredException, sizeof( char ), entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setSubentityColumn_( NObjective.RuntimeObject column ) {
			RuntimeObject ___occuredException;
			NativeMethods.setSubentityColumn_( Handle, CachedSelectors.setSubentityColumn_, out ___occuredException, sizeof( NObjective.RuntimeObject ), column );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setSubentityID_( uint id ) {
			RuntimeObject ___occuredException;
			NativeMethods.setSubentityID_( Handle, CachedSelectors.setSubentityID_, out ___occuredException, sizeof( uint ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject subentityColumn() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.subentityColumn( Handle, CachedSelectors.subentityColumn, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public uint subentityID() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.subentityID( Handle, CachedSelectors.subentityID, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr attributeColumnDefinitions( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr attributeMappings( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr createTableStatement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr entity( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr foreignKeyColumnDefinitions( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr foreignKeyConstraintDefinitions( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithEntity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isSingleTableEntity( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr primaryKeyColumnDefinitions( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr primaryKeys( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr propertyMappings( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr relationshipMappings( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setEntity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setPrimaryKeys_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject keys );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setPropertyMappings_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject mappings );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setSingleTableEntity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, char entity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setSubentityColumn_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject column );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setSubentityID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint id );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr subentityColumn( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint subentityID( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector attributeColumnDefinitions = "attributeColumnDefinitions";
			public static readonly Selector attributeMappings = "attributeMappings";
			public static readonly Selector createTableStatement = "createTableStatement";
			public static readonly Selector entity = "entity";
			public static readonly Selector foreignKeyColumnDefinitions = "foreignKeyColumnDefinitions";
			public static readonly Selector foreignKeyConstraintDefinitions = "foreignKeyConstraintDefinitions";
			public static readonly Selector initWithEntity_ = "initWithEntity:";
			public static readonly Selector isSingleTableEntity = "isSingleTableEntity";
			public static readonly Selector primaryKeyColumnDefinitions = "primaryKeyColumnDefinitions";
			public static readonly Selector primaryKeys = "primaryKeys";
			public static readonly Selector propertyMappings = "propertyMappings";
			public static readonly Selector relationshipMappings = "relationshipMappings";
			public static readonly Selector setEntity_ = "setEntity:";
			public static readonly Selector setPrimaryKeys_ = "setPrimaryKeys:";
			public static readonly Selector setPropertyMappings_ = "setPropertyMappings:";
			public static readonly Selector setSingleTableEntity_ = "setSingleTableEntity:";
			public static readonly Selector setSubentityColumn_ = "setSubentityColumn:";
			public static readonly Selector setSubentityID_ = "setSubentityID:";
			public static readonly Selector subentityColumn = "subentityColumn";
			public static readonly Selector subentityID = "subentityID";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSEntityObjectIDFactory : IEquatable<NSEntityObjectIDFactory> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSEntityObjectIDFactory;
		public static implicit operator IntPtr( NSEntityObjectIDFactory value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSEntityObjectIDFactory value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSEntityObjectIDFactory?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSEntityObjectIDFactory value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSEntityObjectIDFactory value1, NSEntityObjectIDFactory value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSEntityObjectIDFactory value1, NSEntityObjectIDFactory value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSEntityObjectIDFactory( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSEntityObjectIDFactory alloc() {
			return new NSEntityObjectIDFactory( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject allocateObjectIDForPayload_withType_( uint payload, int withType ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.allocateObjectIDForPayload_withType_( Handle, CachedSelectors.allocateObjectIDForPayload_withType_, out ___occuredException, sizeof( uint ) + sizeof( int ), payload, withType );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void deallocatePayloadForObjectID_( NObjective.RuntimeObject id ) {
			RuntimeObject ___occuredException;
			NativeMethods.deallocatePayloadForObjectID_( Handle, CachedSelectors.deallocatePayloadForObjectID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject entity() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entity( Handle, CachedSelectors.entity, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public uint hashForID_( NObjective.RuntimeObject id ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.hashForID_( Handle, CachedSelectors.hashForID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public NSEntityObjectIDFactory initWithObjectStore_andClass_forEntity_withType_( NObjective.RuntimeObject store, NObjective.RuntimeClass andClass, NObjective.RuntimeObject forEntity, int withType ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithObjectStore_andClass_forEntity_withType_( Handle, CachedSelectors.initWithObjectStore_andClass_forEntity_withType_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeClass ) + sizeof( NObjective.RuntimeObject ) + sizeof( int ), store, andClass, forEntity, withType );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSEntityObjectIDFactory( ___result );
		}
		unsafe public bool isObjectID_equalTo_( NObjective.RuntimeObject id, NObjective.RuntimeObject equalTo ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isObjectID_equalTo_( Handle, CachedSelectors.isObjectID_equalTo_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), id, equalTo );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject managedObjectIDFromURIRepresentation_( NObjective.RuntimeObject representation ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.managedObjectIDFromURIRepresentation_( Handle, CachedSelectors.managedObjectIDFromURIRepresentation_, out ___occuredException, sizeof( NObjective.RuntimeObject ), representation );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeClass objectIDClass() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectIDClass( Handle, CachedSelectors.objectIDClass, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public uint objectIDDataSize() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectIDDataSize( Handle, CachedSelectors.objectIDDataSize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public NObjective.RuntimeObject objectIDWithInteger32_( uint integer32 ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectIDWithInteger32_( Handle, CachedSelectors.objectIDWithInteger32_, out ___occuredException, sizeof( uint ), integer32 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject objectIDWithInteger64_( ulong integer64 ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectIDWithInteger64_( Handle, CachedSelectors.objectIDWithInteger64_, out ___occuredException, sizeof( ulong ), integer64 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject objectIDWithObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectIDWithObject_( Handle, CachedSelectors.objectIDWithObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject objectIDWithPtr_( System.IntPtr ptr ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectIDWithPtr_( Handle, CachedSelectors.objectIDWithPtr_, out ___occuredException, sizeof( System.IntPtr ), ptr );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject objectStore() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectStore( Handle, CachedSelectors.objectStore, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject URIRepresentationForID_( NObjective.RuntimeObject id ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.URIRepresentationForID_( Handle, CachedSelectors.URIRepresentationForID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr allocateObjectIDForPayload_withType_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint payload, int withType );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void deallocatePayloadForObjectID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr entity( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint hashForID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithObjectStore_andClass_forEntity_withType_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject store, NObjective.RuntimeClass andClass, NObjective.RuntimeObject forEntity, int withType );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isObjectID_equalTo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id, NObjective.RuntimeObject equalTo );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr managedObjectIDFromURIRepresentation_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject representation );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern NObjective.RuntimeClass objectIDClass( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint objectIDDataSize( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr objectIDWithInteger32_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint integer32 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr objectIDWithInteger64_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, ulong integer64 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr objectIDWithObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr objectIDWithPtr_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr ptr );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr objectStore( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr URIRepresentationForID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id );
		}
		static internal class CachedSelectors {
			public static readonly Selector allocateObjectIDForPayload_withType_ = "allocateObjectIDForPayload:withType:";
			public static readonly Selector deallocatePayloadForObjectID_ = "deallocatePayloadForObjectID:";
			public static readonly Selector entity = "entity";
			public static readonly Selector hashForID_ = "hashForID:";
			public static readonly Selector initWithObjectStore_andClass_forEntity_withType_ = "initWithObjectStore:andClass:forEntity:withType:";
			public static readonly Selector isObjectID_equalTo_ = "isObjectID:equalTo:";
			public static readonly Selector managedObjectIDFromURIRepresentation_ = "managedObjectIDFromURIRepresentation:";
			public static readonly Selector objectIDClass = "objectIDClass";
			public static readonly Selector objectIDDataSize = "objectIDDataSize";
			public static readonly Selector objectIDWithInteger32_ = "objectIDWithInteger32:";
			public static readonly Selector objectIDWithInteger64_ = "objectIDWithInteger64:";
			public static readonly Selector objectIDWithObject_ = "objectIDWithObject:";
			public static readonly Selector objectIDWithPtr_ = "objectIDWithPtr:";
			public static readonly Selector objectStore = "objectStore";
			public static readonly Selector URIRepresentationForID_ = "URIRepresentationForID:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSExternalData : IEquatable<NSExternalData> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSExternalData;
		public static implicit operator IntPtr( NSExternalData value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSExternalData value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSExternalData?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSExternalData value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSExternalData value1, NSExternalData value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSExternalData value1, NSExternalData value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSExternalData( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSExternalData alloc() {
			return new NSExternalData( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NSExternalData initWith_options_( NObjective.RuntimeObject with, uint options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWith_options_( Handle, CachedSelectors.initWith_options_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ), with, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSExternalData( ___result );
		}
		unsafe public uint options() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.options( Handle, CachedSelectors.options, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public NObjective.RuntimeObject rawData() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.rawData( Handle, CachedSelectors.rawData, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setRawData_( NObjective.RuntimeObject data ) {
			RuntimeObject ___occuredException;
			NativeMethods.setRawData_( Handle, CachedSelectors.setRawData_, out ___occuredException, sizeof( NObjective.RuntimeObject ), data );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public bool shouldPersist() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.shouldPersist( Handle, CachedSelectors.shouldPersist, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool shouldRefresh() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.shouldRefresh( Handle, CachedSelectors.shouldRefresh, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public double timestamp() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.timestamp( Handle, CachedSelectors.timestamp, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWith_options_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject with, uint options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint options( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr rawData( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setRawData_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject data );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool shouldPersist( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool shouldRefresh( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern double timestamp( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWith_options_ = "initWith:options:";
			public static readonly Selector options = "options";
			public static readonly Selector rawData = "rawData";
			public static readonly Selector setRawData_ = "setRawData:";
			public static readonly Selector shouldPersist = "shouldPersist";
			public static readonly Selector shouldRefresh = "shouldRefresh";
			public static readonly Selector timestamp = "timestamp";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSExternalData ) )]
	public struct NSExternalRefCountedData : IEquatable<NSExternalRefCountedData> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSExternalRefCountedData;
		public static implicit operator IntPtr( NSExternalRefCountedData value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSExternalRefCountedData value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSExternalRefCountedData?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSExternalRefCountedData value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSExternalRefCountedData value1, NSExternalRefCountedData value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSExternalRefCountedData value1, NSExternalRefCountedData value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSExternalRefCountedData( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSExternalRefCountedData alloc() {
			return new NSExternalRefCountedData( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void decrementRefCount() {
			RuntimeObject ___occuredException;
			NativeMethods.decrementRefCount( Handle, CachedSelectors.decrementRefCount, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void incrementRefCount() {
			RuntimeObject ___occuredException;
			NativeMethods.incrementRefCount( Handle, CachedSelectors.incrementRefCount, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSExternalRefCountedData initFromData_( NObjective.RuntimeObject data ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initFromData_( Handle, CachedSelectors.initFromData_, out ___occuredException, sizeof( NObjective.RuntimeObject ), data );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSExternalRefCountedData( ___result );
		}
		unsafe public uint optionsForKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.optionsForKey_( Handle, CachedSelectors.optionsForKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public int refCount() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.refCount( Handle, CachedSelectors.refCount, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject relatedIDsForKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.relatedIDsForKey_( Handle, CachedSelectors.relatedIDsForKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setRelatedIDs_forKey_options_( NObjective.RuntimeObject ds, NObjective.RuntimeObject forKey, uint options ) {
			RuntimeObject ___occuredException;
			NativeMethods.setRelatedIDs_forKey_options_( Handle, CachedSelectors.setRelatedIDs_forKey_options_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( uint ), ds, forKey, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public double timestampForKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.timestampForKey_( Handle, CachedSelectors.timestampForKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void decrementRefCount( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void incrementRefCount( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initFromData_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject data );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint optionsForKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int refCount( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr relatedIDsForKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setRelatedIDs_forKey_options_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject ds, NObjective.RuntimeObject forKey, uint options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern double timestampForKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
		}
		static internal class CachedSelectors {
			public static readonly Selector decrementRefCount = "decrementRefCount";
			public static readonly Selector incrementRefCount = "incrementRefCount";
			public static readonly Selector initFromData_ = "initFromData:";
			public static readonly Selector optionsForKey_ = "optionsForKey:";
			public static readonly Selector refCount = "refCount";
			public static readonly Selector relatedIDsForKey_ = "relatedIDsForKey:";
			public static readonly Selector setRelatedIDs_forKey_options_ = "setRelatedIDs:forKey:options:";
			public static readonly Selector timestampForKey_ = "timestampForKey:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSFaultHandler : IEquatable<NSFaultHandler> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSFaultHandler;
		public static implicit operator IntPtr( NSFaultHandler value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSFaultHandler value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSFaultHandler?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSFaultHandler value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSFaultHandler value1, NSFaultHandler value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSFaultHandler value1, NSFaultHandler value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSFaultHandler( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSFaultHandler alloc() {
			return new NSFaultHandler( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void fulfillFault_withContext_( NObjective.RuntimeObject fault, NObjective.RuntimeObject withContext ) {
			RuntimeObject ___occuredException;
			NativeMethods.fulfillFault_withContext_( Handle, CachedSelectors.fulfillFault_withContext_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), fault, withContext );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSFaultHandler initWithPersistenceStore_( NObjective.RuntimeObject store ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithPersistenceStore_( Handle, CachedSelectors.initWithPersistenceStore_, out ___occuredException, sizeof( NObjective.RuntimeObject ), store );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSFaultHandler( ___result );
		}
		unsafe public NObjective.RuntimeObject persistenceStore() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.persistenceStore( Handle, CachedSelectors.persistenceStore, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject retainedFulfillAggregateFaultForObject_andRelationship_withContext_( NObjective.RuntimeObject @object, NObjective.RuntimeObject andRelationship, NObjective.RuntimeObject withContext ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.retainedFulfillAggregateFaultForObject_andRelationship_withContext_( Handle, CachedSelectors.retainedFulfillAggregateFaultForObject_andRelationship_withContext_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), @object, andRelationship, withContext );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void turnObject_intoFaultWithContext_( NObjective.RuntimeObject @object, NObjective.RuntimeObject intoFaultWithContext ) {
			RuntimeObject ___occuredException;
			NativeMethods.turnObject_intoFaultWithContext_( Handle, CachedSelectors.turnObject_intoFaultWithContext_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), @object, intoFaultWithContext );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void fulfillFault_withContext_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject fault, NObjective.RuntimeObject withContext );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithPersistenceStore_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject store );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr persistenceStore( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr retainedFulfillAggregateFaultForObject_andRelationship_withContext_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, NObjective.RuntimeObject andRelationship, NObjective.RuntimeObject withContext );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void turnObject_intoFaultWithContext_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, NObjective.RuntimeObject intoFaultWithContext );
		}
		static internal class CachedSelectors {
			public static readonly Selector fulfillFault_withContext_ = "fulfillFault:withContext:";
			public static readonly Selector initWithPersistenceStore_ = "initWithPersistenceStore:";
			public static readonly Selector persistenceStore = "persistenceStore";
			public static readonly Selector retainedFulfillAggregateFaultForObject_andRelationship_withContext_ = "retainedFulfillAggregateFaultForObject:andRelationship:withContext:";
			public static readonly Selector turnObject_intoFaultWithContext_ = "turnObject:intoFaultWithContext:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSPropertyDescription ) )]
	public struct NSFetchedPropertyDescription : IEquatable<NSFetchedPropertyDescription> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSFetchedPropertyDescription;
		public static implicit operator IntPtr( NSFetchedPropertyDescription value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSFetchedPropertyDescription value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSFetchedPropertyDescription?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSFetchedPropertyDescription value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSFetchedPropertyDescription value1, NSFetchedPropertyDescription value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSFetchedPropertyDescription value1, NSFetchedPropertyDescription value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSFetchedPropertyDescription( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSFetchedPropertyDescription alloc() {
			return new NSFetchedPropertyDescription( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NSFetchRequest fetchRequest() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.fetchRequest( Handle, CachedSelectors.fetchRequest, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSFetchRequest( ___result );
		}
		unsafe public void setFetchRequest_( NSFetchRequest request ) {
			RuntimeObject ___occuredException;
			NativeMethods.setFetchRequest_( Handle, CachedSelectors.setFetchRequest_, out ___occuredException, sizeof( NSFetchRequest ), request );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr fetchRequest( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setFetchRequest_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSFetchRequest request );
		}
		static internal class CachedSelectors {
			public static readonly Selector fetchRequest = "fetchRequest";
			public static readonly Selector setFetchRequest_ = "setFetchRequest:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSFetchRequest : IEquatable<NSFetchRequest> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSFetchRequest;
		public static implicit operator IntPtr( NSFetchRequest value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSFetchRequest value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSFetchRequest?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSFetchRequest value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSFetchRequest value1, NSFetchRequest value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSFetchRequest value1, NSFetchRequest value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSFetchRequest( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSFetchRequest alloc() {
			return new NSFetchRequest( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NSArray affectedStores() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.affectedStores( Handle, CachedSelectors.affectedStores, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public char autoDistinct() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.autoDistinct( Handle, CachedSelectors.autoDistinct, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void encodeWithCoder_( NSCoder coder ) {
			RuntimeObject ___occuredException;
			NativeMethods.encodeWithCoder_( Handle, CachedSelectors.encodeWithCoder_, out ___occuredException, sizeof( NSCoder ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSEntityDescription entity() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entity( Handle, CachedSelectors.entity, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSEntityDescription( ___result );
		}
		unsafe public uint fetchLimit() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.fetchLimit( Handle, CachedSelectors.fetchLimit, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public char includeRowData() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.includeRowData( Handle, CachedSelectors.includeRowData, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NSFetchRequest initWithCoder_( NObjective.RuntimeObject coder ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCoder_( Handle, CachedSelectors.initWithCoder_, out ___occuredException, sizeof( NObjective.RuntimeObject ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSFetchRequest( ___result );
		}
		unsafe public NSPredicate predicate() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.predicate( Handle, CachedSelectors.predicate, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSPredicate( ___result );
		}
		unsafe public NObjective.RuntimeObject prefetchRelationshipKeys() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.prefetchRelationshipKeys( Handle, CachedSelectors.prefetchRelationshipKeys, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public int requestType() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.requestType( Handle, CachedSelectors.requestType, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char resultsAsObjectIDs() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.resultsAsObjectIDs( Handle, CachedSelectors.resultsAsObjectIDs, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void setAffectedStores_( NSArray stores ) {
			RuntimeObject ___occuredException;
			NativeMethods.setAffectedStores_( Handle, CachedSelectors.setAffectedStores_, out ___occuredException, sizeof( NSArray ), stores );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setAutoDistinct_( char distinct ) {
			RuntimeObject ___occuredException;
			NativeMethods.setAutoDistinct_( Handle, CachedSelectors.setAutoDistinct_, out ___occuredException, sizeof( char ), distinct );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setEntity_( NSEntityDescription entity ) {
			RuntimeObject ___occuredException;
			NativeMethods.setEntity_( Handle, CachedSelectors.setEntity_, out ___occuredException, sizeof( NSEntityDescription ), entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setFetchLimit_( uint limit ) {
			RuntimeObject ___occuredException;
			NativeMethods.setFetchLimit_( Handle, CachedSelectors.setFetchLimit_, out ___occuredException, sizeof( uint ), limit );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setIncludeRowData_( char data ) {
			RuntimeObject ___occuredException;
			NativeMethods.setIncludeRowData_( Handle, CachedSelectors.setIncludeRowData_, out ___occuredException, sizeof( char ), data );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setPredicate_( NSPredicate predicate ) {
			RuntimeObject ___occuredException;
			NativeMethods.setPredicate_( Handle, CachedSelectors.setPredicate_, out ___occuredException, sizeof( NSPredicate ), predicate );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setPrefetchRelationshipKeys_( NObjective.RuntimeObject keys ) {
			RuntimeObject ___occuredException;
			NativeMethods.setPrefetchRelationshipKeys_( Handle, CachedSelectors.setPrefetchRelationshipKeys_, out ___occuredException, sizeof( NObjective.RuntimeObject ), keys );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setResultsAsObjectIDs_( char ds ) {
			RuntimeObject ___occuredException;
			NativeMethods.setResultsAsObjectIDs_( Handle, CachedSelectors.setResultsAsObjectIDs_, out ___occuredException, sizeof( char ), ds );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setShallowInheritance_( char inheritance ) {
			RuntimeObject ___occuredException;
			NativeMethods.setShallowInheritance_( Handle, CachedSelectors.setShallowInheritance_, out ___occuredException, sizeof( char ), inheritance );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setSortDescriptors_( NSArray descriptors ) {
			RuntimeObject ___occuredException;
			NativeMethods.setSortDescriptors_( Handle, CachedSelectors.setSortDescriptors_, out ___occuredException, sizeof( NSArray ), descriptors );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public char shallowInheritance() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.shallowInheritance( Handle, CachedSelectors.shallowInheritance, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NSArray sortDescriptors() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sortDescriptors( Handle, CachedSelectors.sortDescriptors, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public NObjective.RuntimeObject stores() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.stores( Handle, CachedSelectors.stores, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr affectedStores( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char autoDistinct( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void encodeWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSCoder coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr entity( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint fetchLimit( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char includeRowData( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr predicate( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr prefetchRelationshipKeys( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int requestType( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char resultsAsObjectIDs( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setAffectedStores_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray stores );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setAutoDistinct_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, char distinct );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setEntity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSEntityDescription entity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setFetchLimit_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint limit );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setIncludeRowData_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, char data );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setPredicate_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSPredicate predicate );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setPrefetchRelationshipKeys_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject keys );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setResultsAsObjectIDs_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, char ds );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setShallowInheritance_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, char inheritance );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setSortDescriptors_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray descriptors );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char shallowInheritance( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr sortDescriptors( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr stores( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector affectedStores = "affectedStores";
			public static readonly Selector autoDistinct = "autoDistinct";
			public static readonly Selector encodeWithCoder_ = "encodeWithCoder:";
			public static readonly Selector entity = "entity";
			public static readonly Selector fetchLimit = "fetchLimit";
			public static readonly Selector includeRowData = "includeRowData";
			public static readonly Selector initWithCoder_ = "initWithCoder:";
			public static readonly Selector predicate = "predicate";
			public static readonly Selector prefetchRelationshipKeys = "prefetchRelationshipKeys";
			public static readonly Selector requestType = "requestType";
			public static readonly Selector resultsAsObjectIDs = "resultsAsObjectIDs";
			public static readonly Selector setAffectedStores_ = "setAffectedStores:";
			public static readonly Selector setAutoDistinct_ = "setAutoDistinct:";
			public static readonly Selector setEntity_ = "setEntity:";
			public static readonly Selector setFetchLimit_ = "setFetchLimit:";
			public static readonly Selector setIncludeRowData_ = "setIncludeRowData:";
			public static readonly Selector setPredicate_ = "setPredicate:";
			public static readonly Selector setPrefetchRelationshipKeys_ = "setPrefetchRelationshipKeys:";
			public static readonly Selector setResultsAsObjectIDs_ = "setResultsAsObjectIDs:";
			public static readonly Selector setShallowInheritance_ = "setShallowInheritance:";
			public static readonly Selector setSortDescriptors_ = "setSortDescriptors:";
			public static readonly Selector shallowInheritance = "shallowInheritance";
			public static readonly Selector sortDescriptors = "sortDescriptors";
			public static readonly Selector stores = "stores";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSJoin : IEquatable<NSJoin> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSJoin;
		public static implicit operator IntPtr( NSJoin value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSJoin value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSJoin?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSJoin value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSJoin value1, NSJoin value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSJoin value1, NSJoin value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSJoin( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSJoin alloc() {
			return new NSJoin( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NSJoin joinWithSourceAttributeName_destinationAttributeName_( NObjective.RuntimeObject name, NObjective.RuntimeObject destinationAttributeName ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.joinWithSourceAttributeName_destinationAttributeName_( ClassHandle, CachedSelectors.joinWithSourceAttributeName_destinationAttributeName_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), name, destinationAttributeName );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSJoin( ___result );
		}
		unsafe public NObjective.RuntimeObject destinationAttributeName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.destinationAttributeName( Handle, CachedSelectors.destinationAttributeName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void encodeWithCoder_( NSCoder coder ) {
			RuntimeObject ___occuredException;
			NativeMethods.encodeWithCoder_( Handle, CachedSelectors.encodeWithCoder_, out ___occuredException, sizeof( NSCoder ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSJoin initWithCoder_( NObjective.RuntimeObject coder ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCoder_( Handle, CachedSelectors.initWithCoder_, out ___occuredException, sizeof( NObjective.RuntimeObject ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSJoin( ___result );
		}
		unsafe public NSJoin initWithSourceAttributeName_destinationAttributeName_( NObjective.RuntimeObject name, NObjective.RuntimeObject destinationAttributeName ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithSourceAttributeName_destinationAttributeName_( Handle, CachedSelectors.initWithSourceAttributeName_destinationAttributeName_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), name, destinationAttributeName );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSJoin( ___result );
		}
		unsafe public NObjective.RuntimeObject sourceAttributeName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sourceAttributeName( Handle, CachedSelectors.sourceAttributeName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr destinationAttributeName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void encodeWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSCoder coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithSourceAttributeName_destinationAttributeName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name, NObjective.RuntimeObject destinationAttributeName );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr joinWithSourceAttributeName_destinationAttributeName_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name, NObjective.RuntimeObject destinationAttributeName );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr sourceAttributeName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector destinationAttributeName = "destinationAttributeName";
			public static readonly Selector encodeWithCoder_ = "encodeWithCoder:";
			public static readonly Selector initWithCoder_ = "initWithCoder:";
			public static readonly Selector initWithSourceAttributeName_destinationAttributeName_ = "initWithSourceAttributeName:destinationAttributeName:";
			public static readonly Selector joinWithSourceAttributeName_destinationAttributeName_ = "joinWithSourceAttributeName:destinationAttributeName:";
			public static readonly Selector sourceAttributeName = "sourceAttributeName";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSManagedObject : IEquatable<NSManagedObject> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSManagedObject;
		public static implicit operator IntPtr( NSManagedObject value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSManagedObject value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSManagedObject?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSManagedObject value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSManagedObject value1, NSManagedObject value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSManagedObject value1, NSManagedObject value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSManagedObject( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSManagedObject alloc() {
			return new NSManagedObject( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void awakeFromFetch() {
			RuntimeObject ___occuredException;
			NativeMethods.awakeFromFetch( Handle, CachedSelectors.awakeFromFetch, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void awakeFromInsert() {
			RuntimeObject ___occuredException;
			NativeMethods.awakeFromInsert( Handle, CachedSelectors.awakeFromInsert, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSDictionary changedValues() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.changedValues( Handle, CachedSelectors.changedValues, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public NSDictionary committedValuesForKeys_( NSArray keys ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.committedValuesForKeys_( Handle, CachedSelectors.committedValuesForKeys_, out ___occuredException, sizeof( NSArray ), keys );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public void didAccessValueForKey_( string key ) {
			RuntimeObject ___occuredException;
			var ___wrappedkey = Runtime.CreateStringProxy( key );
			NativeMethods.didAccessValueForKey_( Handle, CachedSelectors.didAccessValueForKey_, out ___occuredException, sizeof( IntPtr ), ___wrappedkey );
			Runtime.ReleaseNativeObject( ___wrappedkey );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void didSave() {
			RuntimeObject ___occuredException;
			NativeMethods.didSave( Handle, CachedSelectors.didSave, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void didTurnIntoFault() {
			RuntimeObject ___occuredException;
			NativeMethods.didTurnIntoFault( Handle, CachedSelectors.didTurnIntoFault, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSEntityDescription entity() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entity( Handle, CachedSelectors.entity, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSEntityDescription( ___result );
		}
		unsafe public NSManagedObject initWithEntity_insertIntoManagedObjectContext_( NSEntityDescription entity, NSManagedObjectContext insertIntoManagedObjectContext ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithEntity_insertIntoManagedObjectContext_( Handle, CachedSelectors.initWithEntity_insertIntoManagedObjectContext_, out ___occuredException, sizeof( NSEntityDescription ) + sizeof( NSManagedObjectContext ), entity, insertIntoManagedObjectContext );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSManagedObject( ___result );
		}
		unsafe public bool isDeleted() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isDeleted( Handle, CachedSelectors.isDeleted, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isInserted() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isInserted( Handle, CachedSelectors.isInserted, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isRelationshipForKeyFault_( NObjective.RuntimeObject fault ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isRelationshipForKeyFault_( Handle, CachedSelectors.isRelationshipForKeyFault_, out ___occuredException, sizeof( NObjective.RuntimeObject ), fault );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isUpdated() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isUpdated( Handle, CachedSelectors.isUpdated, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NSManagedObjectContext managedObjectContext() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.managedObjectContext( Handle, CachedSelectors.managedObjectContext, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSManagedObjectContext( ___result );
		}
		unsafe public NSManagedObjectID objectID() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectID( Handle, CachedSelectors.objectID, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSManagedObjectID( ___result );
		}
		unsafe public NObjective.RuntimeObject primitiveValueForKey_( string key ) {
			RuntimeObject ___occuredException;
			var ___wrappedkey = Runtime.CreateStringProxy( key );
			var ___result = NativeMethods.primitiveValueForKey_( Handle, CachedSelectors.primitiveValueForKey_, out ___occuredException, sizeof( IntPtr ), ___wrappedkey );
			Runtime.ReleaseNativeObject( ___wrappedkey );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setPrimitiveValue_forKey_( NObjective.RuntimeObject value, string forKey ) {
			RuntimeObject ___occuredException;
			var ___wrappedforKey = Runtime.CreateStringProxy( forKey );
			NativeMethods.setPrimitiveValue_forKey_( Handle, CachedSelectors.setPrimitiveValue_forKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( IntPtr ), value, ___wrappedforKey );
			Runtime.ReleaseNativeObject( ___wrappedforKey );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public bool validateForDelete_( ref NSError delete ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.validateForDelete_( Handle, CachedSelectors.validateForDelete_, out ___occuredException, sizeof( IntPtr ), ref delete );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool validateForInsert_( ref NSError insert ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.validateForInsert_( Handle, CachedSelectors.validateForInsert_, out ___occuredException, sizeof( IntPtr ), ref insert );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool validateForUpdate_( ref NSError update ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.validateForUpdate_( Handle, CachedSelectors.validateForUpdate_, out ___occuredException, sizeof( IntPtr ), ref update );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void willAccessValueForKey_( string key ) {
			RuntimeObject ___occuredException;
			var ___wrappedkey = Runtime.CreateStringProxy( key );
			NativeMethods.willAccessValueForKey_( Handle, CachedSelectors.willAccessValueForKey_, out ___occuredException, sizeof( IntPtr ), ___wrappedkey );
			Runtime.ReleaseNativeObject( ___wrappedkey );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void willSave() {
			RuntimeObject ___occuredException;
			NativeMethods.willSave( Handle, CachedSelectors.willSave, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void willTurnIntoFault() {
			RuntimeObject ___occuredException;
			NativeMethods.willTurnIntoFault( Handle, CachedSelectors.willTurnIntoFault, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void awakeFromFetch( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void awakeFromInsert( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr changedValues( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr committedValuesForKeys_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray keys );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void didAccessValueForKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr key );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void didSave( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void didTurnIntoFault( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr entity( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithEntity_insertIntoManagedObjectContext_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSEntityDescription entity, NSManagedObjectContext insertIntoManagedObjectContext );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isDeleted( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isInserted( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isRelationshipForKeyFault_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject fault );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isUpdated( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr managedObjectContext( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr objectID( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr primitiveValueForKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr key );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setPrimitiveValue_forKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject value, IntPtr forKey );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool validateForDelete_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, ref NSError delete );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool validateForInsert_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, ref NSError insert );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool validateForUpdate_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, ref NSError update );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void willAccessValueForKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr key );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void willSave( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void willTurnIntoFault( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector awakeFromFetch = "awakeFromFetch";
			public static readonly Selector awakeFromInsert = "awakeFromInsert";
			public static readonly Selector changedValues = "changedValues";
			public static readonly Selector committedValuesForKeys_ = "committedValuesForKeys:";
			public static readonly Selector didAccessValueForKey_ = "didAccessValueForKey:";
			public static readonly Selector didSave = "didSave";
			public static readonly Selector didTurnIntoFault = "didTurnIntoFault";
			public static readonly Selector entity = "entity";
			public static readonly Selector initWithEntity_insertIntoManagedObjectContext_ = "initWithEntity:insertIntoManagedObjectContext:";
			public static readonly Selector isDeleted = "isDeleted";
			public static readonly Selector isInserted = "isInserted";
			public static readonly Selector isRelationshipForKeyFault_ = "isRelationshipForKeyFault:";
			public static readonly Selector isUpdated = "isUpdated";
			public static readonly Selector managedObjectContext = "managedObjectContext";
			public static readonly Selector objectID = "objectID";
			public static readonly Selector primitiveValueForKey_ = "primitiveValueForKey:";
			public static readonly Selector setPrimitiveValue_forKey_ = "setPrimitiveValue:forKey:";
			public static readonly Selector validateForDelete_ = "validateForDelete:";
			public static readonly Selector validateForInsert_ = "validateForInsert:";
			public static readonly Selector validateForUpdate_ = "validateForUpdate:";
			public static readonly Selector willAccessValueForKey_ = "willAccessValueForKey:";
			public static readonly Selector willSave = "willSave";
			public static readonly Selector willTurnIntoFault = "willTurnIntoFault";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSManagedObjectContext : IEquatable<NSManagedObjectContext> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSManagedObjectContext;
		public static implicit operator IntPtr( NSManagedObjectContext value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSManagedObjectContext value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSManagedObjectContext?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSManagedObjectContext value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSManagedObjectContext value1, NSManagedObjectContext value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSManagedObjectContext value1, NSManagedObjectContext value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSManagedObjectContext( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSManagedObjectContext alloc() {
			return new NSManagedObjectContext( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void assignObject_toPersistentStore_( NObjective.RuntimeObject @object, NObjective.RuntimeObject toPersistentStore ) {
			RuntimeObject ___occuredException;
			NativeMethods.assignObject_toPersistentStore_( Handle, CachedSelectors.assignObject_toPersistentStore_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), @object, toPersistentStore );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public char commitEditing() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.commitEditing( Handle, CachedSelectors.commitEditing, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void commitEditingWithDelegate_didCommitSelector_contextInfo_( NObjective.RuntimeObject @delegate, NObjective.Selector didCommitSelector, System.IntPtr contextInfo ) {
			RuntimeObject ___occuredException;
			NativeMethods.commitEditingWithDelegate_didCommitSelector_contextInfo_( Handle, CachedSelectors.commitEditingWithDelegate_didCommitSelector_contextInfo_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.Selector ) + sizeof( System.IntPtr ), @delegate, didCommitSelector, contextInfo );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public uint countForFetchRequest_error_( NObjective.RuntimeObject request, System.IntPtr error ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.countForFetchRequest_error_( Handle, CachedSelectors.countForFetchRequest_error_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), request, error );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public NSSet deletedObjects() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.deletedObjects( Handle, CachedSelectors.deletedObjects, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSet( ___result );
		}
		unsafe public void deleteObject_( NSManagedObject @object ) {
			RuntimeObject ___occuredException;
			NativeMethods.deleteObject_( Handle, CachedSelectors.deleteObject_, out ___occuredException, sizeof( NSManagedObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void detectConflictsForObject_( NSManagedObject @object ) {
			RuntimeObject ___occuredException;
			NativeMethods.detectConflictsForObject_( Handle, CachedSelectors.detectConflictsForObject_, out ___occuredException, sizeof( NSManagedObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void discardEditing() {
			RuntimeObject ___occuredException;
			NativeMethods.discardEditing( Handle, CachedSelectors.discardEditing, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void encodeWithCoder_( NSCoder coder ) {
			RuntimeObject ___occuredException;
			NativeMethods.encodeWithCoder_( Handle, CachedSelectors.encodeWithCoder_, out ___occuredException, sizeof( NSCoder ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSArray executeFetchRequest_error_( NSFetchRequest request, ref NSError error ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.executeFetchRequest_error_( Handle, CachedSelectors.executeFetchRequest_error_, out ___occuredException, sizeof( NSFetchRequest ) + sizeof( IntPtr ), request, ref error );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public bool hasChanges() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.hasChanges( Handle, CachedSelectors.hasChanges, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NSManagedObjectContext initWithCoder_( NObjective.RuntimeObject coder ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCoder_( Handle, CachedSelectors.initWithCoder_, out ___occuredException, sizeof( NObjective.RuntimeObject ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSManagedObjectContext( ___result );
		}
		unsafe public NSSet insertedObjects() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.insertedObjects( Handle, CachedSelectors.insertedObjects, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSet( ___result );
		}
		unsafe public void insertObject_( NSManagedObject @object ) {
			RuntimeObject ___occuredException;
			NativeMethods.insertObject_( Handle, CachedSelectors.insertObject_, out ___occuredException, sizeof( NSManagedObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public bool isEditing() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isEditing( Handle, CachedSelectors.isEditing, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void @lock() {
			RuntimeObject ___occuredException;
			NativeMethods.@lock( Handle, CachedSelectors.@lock, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void lockObjectStore() {
			RuntimeObject ___occuredException;
			NativeMethods.lockObjectStore( Handle, CachedSelectors.lockObjectStore, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject mergePolicy() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mergePolicy( Handle, CachedSelectors.mergePolicy, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void objectDidBeginEditing_( NObjective.RuntimeObject editing ) {
			RuntimeObject ___occuredException;
			NativeMethods.objectDidBeginEditing_( Handle, CachedSelectors.objectDidBeginEditing_, out ___occuredException, sizeof( NObjective.RuntimeObject ), editing );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void objectDidEndEditing_( NObjective.RuntimeObject editing ) {
			RuntimeObject ___occuredException;
			NativeMethods.objectDidEndEditing_( Handle, CachedSelectors.objectDidEndEditing_, out ___occuredException, sizeof( NObjective.RuntimeObject ), editing );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSManagedObject objectRegisteredForID_( NSManagedObjectID id ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectRegisteredForID_( Handle, CachedSelectors.objectRegisteredForID_, out ___occuredException, sizeof( NSManagedObjectID ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSManagedObject( ___result );
		}
		unsafe public NSManagedObject objectWithID_( NSManagedObjectID id ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectWithID_( Handle, CachedSelectors.objectWithID_, out ___occuredException, sizeof( NSManagedObjectID ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSManagedObject( ___result );
		}
		unsafe public NSPersistentStoreCoordinator persistentStoreCoordinator() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.persistentStoreCoordinator( Handle, CachedSelectors.persistentStoreCoordinator, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSPersistentStoreCoordinator( ___result );
		}
		unsafe public void processPendingChanges() {
			RuntimeObject ___occuredException;
			NativeMethods.processPendingChanges( Handle, CachedSelectors.processPendingChanges, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public bool propagatesDeletesAtEndOfEvent() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.propagatesDeletesAtEndOfEvent( Handle, CachedSelectors.propagatesDeletesAtEndOfEvent, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void redo() {
			RuntimeObject ___occuredException;
			NativeMethods.redo( Handle, CachedSelectors.redo, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void refreshObject_mergeChanges_( NSManagedObject @object, bool mergeChanges ) {
			RuntimeObject ___occuredException;
			NativeMethods.refreshObject_mergeChanges_( Handle, CachedSelectors.refreshObject_mergeChanges_, out ___occuredException, sizeof( NSManagedObject ) + sizeof( bool ), @object, mergeChanges );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSSet registeredObjects() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.registeredObjects( Handle, CachedSelectors.registeredObjects, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSet( ___result );
		}
		unsafe public void reset() {
			RuntimeObject ___occuredException;
			NativeMethods.reset( Handle, CachedSelectors.reset, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public bool retainsRegisteredObjects() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.retainsRegisteredObjects( Handle, CachedSelectors.retainsRegisteredObjects, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void rollback() {
			RuntimeObject ___occuredException;
			NativeMethods.rollback( Handle, CachedSelectors.rollback, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public bool save_( ref NSError save ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.save_( Handle, CachedSelectors.save_, out ___occuredException, sizeof( IntPtr ), ref save );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void setMergePolicy_( NObjective.RuntimeObject policy ) {
			RuntimeObject ___occuredException;
			NativeMethods.setMergePolicy_( Handle, CachedSelectors.setMergePolicy_, out ___occuredException, sizeof( NObjective.RuntimeObject ), policy );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setPersistentStoreCoordinator_( NSPersistentStoreCoordinator coordinator ) {
			RuntimeObject ___occuredException;
			NativeMethods.setPersistentStoreCoordinator_( Handle, CachedSelectors.setPersistentStoreCoordinator_, out ___occuredException, sizeof( NSPersistentStoreCoordinator ), coordinator );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setPropagatesDeletesAtEndOfEvent_( bool @event ) {
			RuntimeObject ___occuredException;
			NativeMethods.setPropagatesDeletesAtEndOfEvent_( Handle, CachedSelectors.setPropagatesDeletesAtEndOfEvent_, out ___occuredException, sizeof( bool ), @event );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setRetainsRegisteredObjects_( bool objects ) {
			RuntimeObject ___occuredException;
			NativeMethods.setRetainsRegisteredObjects_( Handle, CachedSelectors.setRetainsRegisteredObjects_, out ___occuredException, sizeof( bool ), objects );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setStalenessInterval_( double interval ) {
			RuntimeObject ___occuredException;
			NativeMethods.setStalenessInterval_( Handle, CachedSelectors.setStalenessInterval_, out ___occuredException, sizeof( double ), interval );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setUndoManager_( NSUndoManager manager ) {
			RuntimeObject ___occuredException;
			NativeMethods.setUndoManager_( Handle, CachedSelectors.setUndoManager_, out ___occuredException, sizeof( NSUndoManager ), manager );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public double stalenessInterval() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.stalenessInterval( Handle, CachedSelectors.stalenessInterval, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool tryLock() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.tryLock( Handle, CachedSelectors.tryLock, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void undo() {
			RuntimeObject ___occuredException;
			NativeMethods.undo( Handle, CachedSelectors.undo, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSUndoManager undoManager() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.undoManager( Handle, CachedSelectors.undoManager, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSUndoManager( ___result );
		}
		unsafe public void unlock() {
			RuntimeObject ___occuredException;
			NativeMethods.unlock( Handle, CachedSelectors.unlock, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void unlockObjectStore() {
			RuntimeObject ___occuredException;
			NativeMethods.unlockObjectStore( Handle, CachedSelectors.unlockObjectStore, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSSet updatedObjects() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.updatedObjects( Handle, CachedSelectors.updatedObjects, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSet( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void assignObject_toPersistentStore_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, NObjective.RuntimeObject toPersistentStore );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char commitEditing( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void commitEditingWithDelegate_didCommitSelector_contextInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @delegate, NObjective.Selector didCommitSelector, System.IntPtr contextInfo );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint countForFetchRequest_error_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject request, System.IntPtr error );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr deletedObjects( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void deleteObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSManagedObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void detectConflictsForObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSManagedObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void discardEditing( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void encodeWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSCoder coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr executeFetchRequest_error_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSFetchRequest request, ref NSError error );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool hasChanges( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr insertedObjects( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void insertObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSManagedObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isEditing( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void @lock( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void lockObjectStore( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr mergePolicy( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void objectDidBeginEditing_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject editing );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void objectDidEndEditing_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject editing );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr objectRegisteredForID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSManagedObjectID id );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr objectWithID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSManagedObjectID id );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr persistentStoreCoordinator( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void processPendingChanges( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool propagatesDeletesAtEndOfEvent( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void redo( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void refreshObject_mergeChanges_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSManagedObject @object, bool mergeChanges );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr registeredObjects( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void reset( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool retainsRegisteredObjects( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void rollback( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool save_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, ref NSError save );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setMergePolicy_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject policy );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setPersistentStoreCoordinator_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSPersistentStoreCoordinator coordinator );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setPropagatesDeletesAtEndOfEvent_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, bool @event );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setRetainsRegisteredObjects_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, bool objects );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setStalenessInterval_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, double interval );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setUndoManager_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSUndoManager manager );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern double stalenessInterval( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool tryLock( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void undo( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr undoManager( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void unlock( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void unlockObjectStore( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr updatedObjects( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector assignObject_toPersistentStore_ = "assignObject:toPersistentStore:";
			public static readonly Selector commitEditing = "commitEditing";
			public static readonly Selector commitEditingWithDelegate_didCommitSelector_contextInfo_ = "commitEditingWithDelegate:didCommitSelector:contextInfo:";
			public static readonly Selector countForFetchRequest_error_ = "countForFetchRequest:error:";
			public static readonly Selector deletedObjects = "deletedObjects";
			public static readonly Selector deleteObject_ = "deleteObject:";
			public static readonly Selector detectConflictsForObject_ = "detectConflictsForObject:";
			public static readonly Selector discardEditing = "discardEditing";
			public static readonly Selector encodeWithCoder_ = "encodeWithCoder:";
			public static readonly Selector executeFetchRequest_error_ = "executeFetchRequest:error:";
			public static readonly Selector hasChanges = "hasChanges";
			public static readonly Selector initWithCoder_ = "initWithCoder:";
			public static readonly Selector insertedObjects = "insertedObjects";
			public static readonly Selector insertObject_ = "insertObject:";
			public static readonly Selector isEditing = "isEditing";
			public static readonly Selector @lock = "lock";
			public static readonly Selector lockObjectStore = "lockObjectStore";
			public static readonly Selector mergePolicy = "mergePolicy";
			public static readonly Selector objectDidBeginEditing_ = "objectDidBeginEditing:";
			public static readonly Selector objectDidEndEditing_ = "objectDidEndEditing:";
			public static readonly Selector objectRegisteredForID_ = "objectRegisteredForID:";
			public static readonly Selector objectWithID_ = "objectWithID:";
			public static readonly Selector persistentStoreCoordinator = "persistentStoreCoordinator";
			public static readonly Selector processPendingChanges = "processPendingChanges";
			public static readonly Selector propagatesDeletesAtEndOfEvent = "propagatesDeletesAtEndOfEvent";
			public static readonly Selector redo = "redo";
			public static readonly Selector refreshObject_mergeChanges_ = "refreshObject:mergeChanges:";
			public static readonly Selector registeredObjects = "registeredObjects";
			public static readonly Selector reset = "reset";
			public static readonly Selector retainsRegisteredObjects = "retainsRegisteredObjects";
			public static readonly Selector rollback = "rollback";
			public static readonly Selector save_ = "save:";
			public static readonly Selector setMergePolicy_ = "setMergePolicy:";
			public static readonly Selector setPersistentStoreCoordinator_ = "setPersistentStoreCoordinator:";
			public static readonly Selector setPropagatesDeletesAtEndOfEvent_ = "setPropagatesDeletesAtEndOfEvent:";
			public static readonly Selector setRetainsRegisteredObjects_ = "setRetainsRegisteredObjects:";
			public static readonly Selector setStalenessInterval_ = "setStalenessInterval:";
			public static readonly Selector setUndoManager_ = "setUndoManager:";
			public static readonly Selector stalenessInterval = "stalenessInterval";
			public static readonly Selector tryLock = "tryLock";
			public static readonly Selector undo = "undo";
			public static readonly Selector undoManager = "undoManager";
			public static readonly Selector unlock = "unlock";
			public static readonly Selector unlockObjectStore = "unlockObjectStore";
			public static readonly Selector updatedObjects = "updatedObjects";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSManagedObjectID : IEquatable<NSManagedObjectID> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSManagedObjectID;
		public static implicit operator IntPtr( NSManagedObjectID value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSManagedObjectID value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSManagedObjectID?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSManagedObjectID value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSManagedObjectID value1, NSManagedObjectID value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSManagedObjectID value1, NSManagedObjectID value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSManagedObjectID( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSManagedObjectID alloc() {
			return new NSManagedObjectID( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NSEntityDescription entity() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entity( Handle, CachedSelectors.entity, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSEntityDescription( ___result );
		}
		unsafe public bool isTemporaryID() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isTemporaryID( Handle, CachedSelectors.isTemporaryID, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject persistentStore() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.persistentStore( Handle, CachedSelectors.persistentStore, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSURL URIRepresentation() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.URIRepresentation( Handle, CachedSelectors.URIRepresentation, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSURL( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr entity( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isTemporaryID( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr persistentStore( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr URIRepresentation( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector entity = "entity";
			public static readonly Selector isTemporaryID = "isTemporaryID";
			public static readonly Selector persistentStore = "persistentStore";
			public static readonly Selector URIRepresentation = "URIRepresentation";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSManagedObjectModel : IEquatable<NSManagedObjectModel> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSManagedObjectModel;
		public static implicit operator IntPtr( NSManagedObjectModel value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSManagedObjectModel value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSManagedObjectModel?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSManagedObjectModel value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSManagedObjectModel value1, NSManagedObjectModel value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSManagedObjectModel value1, NSManagedObjectModel value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSManagedObjectModel( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSManagedObjectModel alloc() {
			return new NSManagedObjectModel( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NSManagedObjectModel mergedModelFromBundles_( NSArray bundles ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mergedModelFromBundles_( ClassHandle, CachedSelectors.mergedModelFromBundles_, out ___occuredException, sizeof( NSArray ), bundles );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSManagedObjectModel( ___result );
		}
		unsafe public static NSManagedObjectModel modelByMergingModels_( NSArray models ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.modelByMergingModels_( ClassHandle, CachedSelectors.modelByMergingModels_, out ___occuredException, sizeof( NSArray ), models );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSManagedObjectModel( ___result );
		}
		unsafe public NSArray configurations() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.configurations( Handle, CachedSelectors.configurations, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public void encodeWithCoder_( NSCoder coder ) {
			RuntimeObject ___occuredException;
			NativeMethods.encodeWithCoder_( Handle, CachedSelectors.encodeWithCoder_, out ___occuredException, sizeof( NSCoder ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSArray entities() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entities( Handle, CachedSelectors.entities, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public NSDictionary entitiesByName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entitiesByName( Handle, CachedSelectors.entitiesByName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public NSArray entitiesForConfiguration_( string configuration ) {
			RuntimeObject ___occuredException;
			var ___wrappedconfiguration = Runtime.CreateStringProxy( configuration );
			var ___result = NativeMethods.entitiesForConfiguration_( Handle, CachedSelectors.entitiesForConfiguration_, out ___occuredException, sizeof( IntPtr ), ___wrappedconfiguration );
			Runtime.ReleaseNativeObject( ___wrappedconfiguration );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public NSFetchRequest fetchRequestFromTemplateWithName_substitutionVariables_( string name, NSDictionary substitutionVariables ) {
			RuntimeObject ___occuredException;
			var ___wrappedname = Runtime.CreateStringProxy( name );
			var ___result = NativeMethods.fetchRequestFromTemplateWithName_substitutionVariables_( Handle, CachedSelectors.fetchRequestFromTemplateWithName_substitutionVariables_, out ___occuredException, sizeof( IntPtr ) + sizeof( NSDictionary ), ___wrappedname, substitutionVariables );
			Runtime.ReleaseNativeObject( ___wrappedname );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSFetchRequest( ___result );
		}
		unsafe public NSFetchRequest fetchRequestTemplateForName_( string name ) {
			RuntimeObject ___occuredException;
			var ___wrappedname = Runtime.CreateStringProxy( name );
			var ___result = NativeMethods.fetchRequestTemplateForName_( Handle, CachedSelectors.fetchRequestTemplateForName_, out ___occuredException, sizeof( IntPtr ), ___wrappedname );
			Runtime.ReleaseNativeObject( ___wrappedname );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSFetchRequest( ___result );
		}
		unsafe public NSManagedObjectModel initWithCoder_( NObjective.RuntimeObject coder ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCoder_( Handle, CachedSelectors.initWithCoder_, out ___occuredException, sizeof( NObjective.RuntimeObject ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSManagedObjectModel( ___result );
		}
		unsafe public NSManagedObjectModel initWithContentsOfURL_( NSURL url ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithContentsOfURL_( Handle, CachedSelectors.initWithContentsOfURL_, out ___occuredException, sizeof( NSURL ), url );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSManagedObjectModel( ___result );
		}
		unsafe public bool isEditable() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isEditable( Handle, CachedSelectors.isEditable, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NSDictionary localizationDictionary() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.localizationDictionary( Handle, CachedSelectors.localizationDictionary, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public void setEntities_( NSArray entities ) {
			RuntimeObject ___occuredException;
			NativeMethods.setEntities_( Handle, CachedSelectors.setEntities_, out ___occuredException, sizeof( NSArray ), entities );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setEntities_forConfiguration_( NSArray entities, string forConfiguration ) {
			RuntimeObject ___occuredException;
			var ___wrappedforConfiguration = Runtime.CreateStringProxy( forConfiguration );
			NativeMethods.setEntities_forConfiguration_( Handle, CachedSelectors.setEntities_forConfiguration_, out ___occuredException, sizeof( NSArray ) + sizeof( IntPtr ), entities, ___wrappedforConfiguration );
			Runtime.ReleaseNativeObject( ___wrappedforConfiguration );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setFetchRequestTemplate_forName_( NSFetchRequest template, string forName ) {
			RuntimeObject ___occuredException;
			var ___wrappedforName = Runtime.CreateStringProxy( forName );
			NativeMethods.setFetchRequestTemplate_forName_( Handle, CachedSelectors.setFetchRequestTemplate_forName_, out ___occuredException, sizeof( NSFetchRequest ) + sizeof( IntPtr ), template, ___wrappedforName );
			Runtime.ReleaseNativeObject( ___wrappedforName );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setLocalizationDictionary_( NSDictionary dictionary ) {
			RuntimeObject ___occuredException;
			NativeMethods.setLocalizationDictionary_( Handle, CachedSelectors.setLocalizationDictionary_, out ___occuredException, sizeof( NSDictionary ), dictionary );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr configurations( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void encodeWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSCoder coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr entities( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr entitiesByName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr entitiesForConfiguration_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr configuration );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr fetchRequestFromTemplateWithName_substitutionVariables_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name, NSDictionary substitutionVariables );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr fetchRequestTemplateForName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithContentsOfURL_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSURL url );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isEditable( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr localizationDictionary( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr mergedModelFromBundles_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray bundles );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr modelByMergingModels_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray models );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setEntities_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray entities );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setEntities_forConfiguration_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray entities, IntPtr forConfiguration );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setFetchRequestTemplate_forName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSFetchRequest template, IntPtr forName );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setLocalizationDictionary_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDictionary dictionary );
		}
		static internal class CachedSelectors {
			public static readonly Selector configurations = "configurations";
			public static readonly Selector encodeWithCoder_ = "encodeWithCoder:";
			public static readonly Selector entities = "entities";
			public static readonly Selector entitiesByName = "entitiesByName";
			public static readonly Selector entitiesForConfiguration_ = "entitiesForConfiguration:";
			public static readonly Selector fetchRequestFromTemplateWithName_substitutionVariables_ = "fetchRequestFromTemplateWithName:substitutionVariables:";
			public static readonly Selector fetchRequestTemplateForName_ = "fetchRequestTemplateForName:";
			public static readonly Selector initWithCoder_ = "initWithCoder:";
			public static readonly Selector initWithContentsOfURL_ = "initWithContentsOfURL:";
			public static readonly Selector isEditable = "isEditable";
			public static readonly Selector localizationDictionary = "localizationDictionary";
			public static readonly Selector mergedModelFromBundles_ = "mergedModelFromBundles:";
			public static readonly Selector modelByMergingModels_ = "modelByMergingModels:";
			public static readonly Selector setEntities_ = "setEntities:";
			public static readonly Selector setEntities_forConfiguration_ = "setEntities:forConfiguration:";
			public static readonly Selector setFetchRequestTemplate_forName_ = "setFetchRequestTemplate:forName:";
			public static readonly Selector setLocalizationDictionary_ = "setLocalizationDictionary:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObjectStore ) )]
	public struct NSMappedObjectStore : IEquatable<NSMappedObjectStore> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSMappedObjectStore;
		public static implicit operator IntPtr( NSMappedObjectStore value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSMappedObjectStore value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSMappedObjectStore?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSMappedObjectStore value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSMappedObjectStore value1, NSMappedObjectStore value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSMappedObjectStore value1, NSMappedObjectStore value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSMappedObjectStore( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSMappedObjectStore alloc() {
			return new NSMappedObjectStore( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject dataForKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dataForKey_( Handle, CachedSelectors.dataForKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject executeCountRequest_withContext_( NObjective.RuntimeObject request, NObjective.RuntimeObject withContext ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.executeCountRequest_withContext_( Handle, CachedSelectors.executeCountRequest_withContext_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), request, withContext );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject executeFetchRequest_withContext_( NObjective.RuntimeObject request, NObjective.RuntimeObject withContext ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.executeFetchRequest_withContext_( Handle, CachedSelectors.executeFetchRequest_withContext_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), request, withContext );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject executeSaveChangesRequest_withContext_( NObjective.RuntimeObject request, NObjective.RuntimeObject withContext ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.executeSaveChangesRequest_withContext_( Handle, CachedSelectors.executeSaveChangesRequest_withContext_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), request, withContext );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject getNewIDForObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getNewIDForObject_( Handle, CachedSelectors.getNewIDForObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void save() {
			RuntimeObject ___occuredException;
			NativeMethods.save( Handle, CachedSelectors.save, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void saveDocumentToPath_( NObjective.RuntimeObject path ) {
			RuntimeObject ___occuredException;
			NativeMethods.saveDocumentToPath_( Handle, CachedSelectors.saveDocumentToPath_, out ___occuredException, sizeof( NObjective.RuntimeObject ), path );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr dataForKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr executeCountRequest_withContext_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject request, NObjective.RuntimeObject withContext );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr executeFetchRequest_withContext_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject request, NObjective.RuntimeObject withContext );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr executeSaveChangesRequest_withContext_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject request, NObjective.RuntimeObject withContext );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr getNewIDForObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void save( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void saveDocumentToPath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject path );
		}
		static internal class CachedSelectors {
			public static readonly Selector dataForKey_ = "dataForKey:";
			public static readonly Selector executeCountRequest_withContext_ = "executeCountRequest:withContext:";
			public static readonly Selector executeFetchRequest_withContext_ = "executeFetchRequest:withContext:";
			public static readonly Selector executeSaveChangesRequest_withContext_ = "executeSaveChangesRequest:withContext:";
			public static readonly Selector getNewIDForObject_ = "getNewIDForObject:";
			public static readonly Selector save = "save";
			public static readonly Selector saveDocumentToPath_ = "saveDocumentToPath:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSMapping : IEquatable<NSMapping> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSMapping;
		public static implicit operator IntPtr( NSMapping value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSMapping value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSMapping?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSMapping value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSMapping value1, NSMapping value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSMapping value1, NSMapping value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSMapping( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSMapping alloc() {
			return new NSMapping( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject externalName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.externalName( Handle, CachedSelectors.externalName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSMapping initWithExternalName_( NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithExternalName_( Handle, CachedSelectors.initWithExternalName_, out ___occuredException, sizeof( NObjective.RuntimeObject ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSMapping( ___result );
		}
		unsafe public void setExternalName_( NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			NativeMethods.setExternalName_( Handle, CachedSelectors.setExternalName_, out ___occuredException, sizeof( NObjective.RuntimeObject ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr externalName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithExternalName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setExternalName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name );
		}
		static internal class CachedSelectors {
			public static readonly Selector externalName = "externalName";
			public static readonly Selector initWithExternalName_ = "initWithExternalName:";
			public static readonly Selector setExternalName_ = "setExternalName:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSMappingGenerator : IEquatable<NSMappingGenerator> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSMappingGenerator;
		public static implicit operator IntPtr( NSMappingGenerator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSMappingGenerator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSMappingGenerator?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSMappingGenerator value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSMappingGenerator value1, NSMappingGenerator value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSMappingGenerator value1, NSMappingGenerator value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSMappingGenerator( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSMappingGenerator alloc() {
			return new NSMappingGenerator( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject defaultMappingGenerator() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.defaultMappingGenerator( ClassHandle, CachedSelectors.defaultMappingGenerator, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject externalNameForEntityName_( NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.externalNameForEntityName_( Handle, CachedSelectors.externalNameForEntityName_, out ___occuredException, sizeof( NObjective.RuntimeObject ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject externalNameForPropertyName_( NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.externalNameForPropertyName_( Handle, CachedSelectors.externalNameForPropertyName_, out ___occuredException, sizeof( NObjective.RuntimeObject ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject internalNameForEntityName_version_( NObjective.RuntimeObject name, int version ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.internalNameForEntityName_version_( Handle, CachedSelectors.internalNameForEntityName_version_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( int ), name, version );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject internalNameForPropertyName_version_( NObjective.RuntimeObject name, int version ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.internalNameForPropertyName_version_( Handle, CachedSelectors.internalNameForPropertyName_version_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( int ), name, version );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject joinsForRelationship_( NObjective.RuntimeObject relationship ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.joinsForRelationship_( Handle, CachedSelectors.joinsForRelationship_, out ___occuredException, sizeof( NObjective.RuntimeObject ), relationship );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject mappingForAttribute_forConfigurationWithName_( NObjective.RuntimeObject attribute, NObjective.RuntimeObject forConfigurationWithName ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mappingForAttribute_forConfigurationWithName_( Handle, CachedSelectors.mappingForAttribute_forConfigurationWithName_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), attribute, forConfigurationWithName );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject mappingForEntity_forConfigurationWithName_( NObjective.RuntimeObject entity, NObjective.RuntimeObject forConfigurationWithName ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mappingForEntity_forConfigurationWithName_( Handle, CachedSelectors.mappingForEntity_forConfigurationWithName_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), entity, forConfigurationWithName );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject mappingForRelationship_forConfigurationWithName_( NObjective.RuntimeObject relationship, NObjective.RuntimeObject forConfigurationWithName ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mappingForRelationship_forConfigurationWithName_( Handle, CachedSelectors.mappingForRelationship_forConfigurationWithName_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), relationship, forConfigurationWithName );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject mappingsForConfigurationWithName_inModel_( NObjective.RuntimeObject name, NObjective.RuntimeObject inModel ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mappingsForConfigurationWithName_inModel_( Handle, CachedSelectors.mappingsForConfigurationWithName_inModel_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), name, inModel );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject primaryKeyForEntity_( NObjective.RuntimeObject entity ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.primaryKeyForEntity_( Handle, CachedSelectors.primaryKeyForEntity_, out ___occuredException, sizeof( NObjective.RuntimeObject ), entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr defaultMappingGenerator( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr externalNameForEntityName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr externalNameForPropertyName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr internalNameForEntityName_version_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name, int version );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr internalNameForPropertyName_version_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name, int version );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr joinsForRelationship_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject relationship );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr mappingForAttribute_forConfigurationWithName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject attribute, NObjective.RuntimeObject forConfigurationWithName );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr mappingForEntity_forConfigurationWithName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity, NObjective.RuntimeObject forConfigurationWithName );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr mappingForRelationship_forConfigurationWithName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject relationship, NObjective.RuntimeObject forConfigurationWithName );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr mappingsForConfigurationWithName_inModel_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name, NObjective.RuntimeObject inModel );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr primaryKeyForEntity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity );
		}
		static internal class CachedSelectors {
			public static readonly Selector defaultMappingGenerator = "defaultMappingGenerator";
			public static readonly Selector externalNameForEntityName_ = "externalNameForEntityName:";
			public static readonly Selector externalNameForPropertyName_ = "externalNameForPropertyName:";
			public static readonly Selector internalNameForEntityName_version_ = "internalNameForEntityName:version:";
			public static readonly Selector internalNameForPropertyName_version_ = "internalNameForPropertyName:version:";
			public static readonly Selector joinsForRelationship_ = "joinsForRelationship:";
			public static readonly Selector mappingForAttribute_forConfigurationWithName_ = "mappingForAttribute:forConfigurationWithName:";
			public static readonly Selector mappingForEntity_forConfigurationWithName_ = "mappingForEntity:forConfigurationWithName:";
			public static readonly Selector mappingForRelationship_forConfigurationWithName_ = "mappingForRelationship:forConfigurationWithName:";
			public static readonly Selector mappingsForConfigurationWithName_inModel_ = "mappingsForConfigurationWithName:inModel:";
			public static readonly Selector primaryKeyForEntity_ = "primaryKeyForEntity:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSMappedObjectStore ) )]
	public struct NSMemoryObjectStore : IEquatable<NSMemoryObjectStore> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSMemoryObjectStore;
		public static implicit operator IntPtr( NSMemoryObjectStore value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSMemoryObjectStore value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSMemoryObjectStore?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSMemoryObjectStore value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSMemoryObjectStore value1, NSMemoryObjectStore value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSMemoryObjectStore value1, NSMemoryObjectStore value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSMemoryObjectStore( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSMemoryObjectStore alloc() {
			return new NSMemoryObjectStore( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSEqualityPredicateOperator ) )]
	public struct NSMemoryStoreEqualityPredicateOperator : IEquatable<NSMemoryStoreEqualityPredicateOperator> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSMemoryStoreEqualityPredicateOperator;
		public static implicit operator IntPtr( NSMemoryStoreEqualityPredicateOperator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSMemoryStoreEqualityPredicateOperator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSMemoryStoreEqualityPredicateOperator?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSMemoryStoreEqualityPredicateOperator value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSMemoryStoreEqualityPredicateOperator value1, NSMemoryStoreEqualityPredicateOperator value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSMemoryStoreEqualityPredicateOperator value1, NSMemoryStoreEqualityPredicateOperator value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSMemoryStoreEqualityPredicateOperator( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSMemoryStoreEqualityPredicateOperator alloc() {
			return new NSMemoryStoreEqualityPredicateOperator( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSInPredicateOperator ) )]
	public struct NSMemoryStoreInPredicateOperator : IEquatable<NSMemoryStoreInPredicateOperator> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSMemoryStoreInPredicateOperator;
		public static implicit operator IntPtr( NSMemoryStoreInPredicateOperator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSMemoryStoreInPredicateOperator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSMemoryStoreInPredicateOperator?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSMemoryStoreInPredicateOperator value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSMemoryStoreInPredicateOperator value1, NSMemoryStoreInPredicateOperator value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSMemoryStoreInPredicateOperator value1, NSMemoryStoreInPredicateOperator value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSMemoryStoreInPredicateOperator( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSMemoryStoreInPredicateOperator alloc() {
			return new NSMemoryStoreInPredicateOperator( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSValidationErrorLocalizationPolicy ) )]
	public struct NSMergedPolicyLocalizationPolicy : IEquatable<NSMergedPolicyLocalizationPolicy> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSMergedPolicyLocalizationPolicy;
		public static implicit operator IntPtr( NSMergedPolicyLocalizationPolicy value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSMergedPolicyLocalizationPolicy value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSMergedPolicyLocalizationPolicy?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSMergedPolicyLocalizationPolicy value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSMergedPolicyLocalizationPolicy value1, NSMergedPolicyLocalizationPolicy value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSMergedPolicyLocalizationPolicy value1, NSMergedPolicyLocalizationPolicy value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSMergedPolicyLocalizationPolicy( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSMergedPolicyLocalizationPolicy alloc() {
			return new NSMergedPolicyLocalizationPolicy( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void addPolicy_( NObjective.RuntimeObject policy ) {
			RuntimeObject ___occuredException;
			NativeMethods.addPolicy_( Handle, CachedSelectors.addPolicy_, out ___occuredException, sizeof( NObjective.RuntimeObject ), policy );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void addPolicy_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject policy );
		}
		static internal class CachedSelectors {
			public static readonly Selector addPolicy_ = "addPolicy:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSMergePolicy : IEquatable<NSMergePolicy> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSMergePolicy;
		public static implicit operator IntPtr( NSMergePolicy value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSMergePolicy value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSMergePolicy?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSMergePolicy value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSMergePolicy value1, NSMergePolicy value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSMergePolicy value1, NSMergePolicy value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSMergePolicy( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSMergePolicy alloc() {
			return new NSMergePolicy( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void encodeWithCoder_( NSCoder coder ) {
			RuntimeObject ___occuredException;
			NativeMethods.encodeWithCoder_( Handle, CachedSelectors.encodeWithCoder_, out ___occuredException, sizeof( NSCoder ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSMergePolicy initWithCoder_( NObjective.RuntimeObject coder ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCoder_( Handle, CachedSelectors.initWithCoder_, out ___occuredException, sizeof( NObjective.RuntimeObject ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSMergePolicy( ___result );
		}
		unsafe public NSMergePolicy initWithTypeCode_( int code ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithTypeCode_( Handle, CachedSelectors.initWithTypeCode_, out ___occuredException, sizeof( int ), code );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSMergePolicy( ___result );
		}
		unsafe public char resolveConflict_( NObjective.RuntimeObject conflict ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.resolveConflict_( Handle, CachedSelectors.resolveConflict_, out ___occuredException, sizeof( NObjective.RuntimeObject ), conflict );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char resolveConflicts_( NObjective.RuntimeObject conflicts ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.resolveConflicts_( Handle, CachedSelectors.resolveConflicts_, out ___occuredException, sizeof( NObjective.RuntimeObject ), conflicts );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void encodeWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSCoder coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithTypeCode_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int code );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char resolveConflict_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject conflict );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char resolveConflicts_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject conflicts );
		}
		static internal class CachedSelectors {
			public static readonly Selector encodeWithCoder_ = "encodeWithCoder:";
			public static readonly Selector initWithCoder_ = "initWithCoder:";
			public static readonly Selector initWithTypeCode_ = "initWithTypeCode:";
			public static readonly Selector resolveConflict_ = "resolveConflict:";
			public static readonly Selector resolveConflicts_ = "resolveConflicts:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSObjectStore : IEquatable<NSObjectStore> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSObjectStore;
		public static implicit operator IntPtr( NSObjectStore value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSObjectStore value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSObjectStore?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSObjectStore value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSObjectStore value1, NSObjectStore value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSObjectStore value1, NSObjectStore value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSObjectStore( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSObjectStore alloc() {
			return new NSObjectStore( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject metadataForPersistentStoreWithURL_error_( NObjective.RuntimeObject url, System.IntPtr error ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.metadataForPersistentStoreWithURL_error_( ClassHandle, CachedSelectors.metadataForPersistentStoreWithURL_error_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), url, error );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void childStore_didForgetObjectsWithObjectIDs_( NObjective.RuntimeObject store, NObjective.RuntimeObject didForgetObjectsWithObjectIDs ) {
			RuntimeObject ___occuredException;
			NativeMethods.childStore_didForgetObjectsWithObjectIDs_( Handle, CachedSelectors.childStore_didForgetObjectsWithObjectIDs_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), store, didForgetObjectsWithObjectIDs );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void childStore_didRememberObjectsWithObjectIDs_( NObjective.RuntimeObject store, NObjective.RuntimeObject didRememberObjectsWithObjectIDs ) {
			RuntimeObject ___occuredException;
			NativeMethods.childStore_didRememberObjectsWithObjectIDs_( Handle, CachedSelectors.childStore_didRememberObjectsWithObjectIDs_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), store, didRememberObjectsWithObjectIDs );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject childStores() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.childStores( Handle, CachedSelectors.childStores, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject configurationName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.configurationName( Handle, CachedSelectors.configurationName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void doFilesystemCleanupOnDealloc_( char dealloc ) {
			RuntimeObject ___occuredException;
			NativeMethods.doFilesystemCleanupOnDealloc_( Handle, CachedSelectors.doFilesystemCleanupOnDealloc_, out ___occuredException, sizeof( char ), dealloc );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject executeRequest_withContext_( NObjective.RuntimeObject request, NObjective.RuntimeObject withContext ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.executeRequest_withContext_( Handle, CachedSelectors.executeRequest_withContext_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), request, withContext );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject faultHandler() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.faultHandler( Handle, CachedSelectors.faultHandler, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeClass faultHandlerClass() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.faultHandlerClass( Handle, CachedSelectors.faultHandlerClass, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char handlesObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.handlesObject_( Handle, CachedSelectors.handlesObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char handlesRequest_( NObjective.RuntimeObject request ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.handlesRequest_( Handle, CachedSelectors.handlesRequest_, out ___occuredException, sizeof( NObjective.RuntimeObject ), request );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject identifier() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.identifier( Handle, CachedSelectors.identifier, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSObjectStore initWithRootStore_configurationName_options_url_( NObjective.RuntimeObject store, NObjective.RuntimeObject configurationName, NObjective.RuntimeObject options, NObjective.RuntimeObject url ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithRootStore_configurationName_options_url_( Handle, CachedSelectors.initWithRootStore_configurationName_options_url_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), store, configurationName, options, url );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSObjectStore( ___result );
		}
		unsafe public bool isReadOnly() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isReadOnly( Handle, CachedSelectors.isReadOnly, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public System.IntPtr knownKeyValuesForObjectID_withContext_( NObjective.RuntimeObject id, NObjective.RuntimeObject withContext ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.knownKeyValuesForObjectID_withContext_( Handle, CachedSelectors.knownKeyValuesForObjectID_withContext_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), id, withContext );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void @lock() {
			RuntimeObject ___occuredException;
			NativeMethods.@lock( Handle, CachedSelectors.@lock, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void lockParentStore() {
			RuntimeObject ___occuredException;
			NativeMethods.lockParentStore( Handle, CachedSelectors.lockParentStore, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeClass objectIDClassForEntity_( NObjective.RuntimeObject entity ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectIDClassForEntity_( Handle, CachedSelectors.objectIDClassForEntity_, out ___occuredException, sizeof( NObjective.RuntimeObject ), entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public int objectIDDataType() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectIDDataType( Handle, CachedSelectors.objectIDDataType, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject objectIDFactoryForEntity_( NObjective.RuntimeObject entity ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectIDFactoryForEntity_( Handle, CachedSelectors.objectIDFactoryForEntity_, out ___occuredException, sizeof( NObjective.RuntimeObject ), entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject parentStore() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.parentStore( Handle, CachedSelectors.parentStore, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject retainedDataForObjectID_withContext_( NObjective.RuntimeObject id, NObjective.RuntimeObject withContext ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.retainedDataForObjectID_withContext_( Handle, CachedSelectors.retainedDataForObjectID_withContext_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), id, withContext );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject retainedRelationshipDataWithSourceID_forRelationship_withContext_( NObjective.RuntimeObject id, NObjective.RuntimeObject forRelationship, NObjective.RuntimeObject withContext ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.retainedRelationshipDataWithSourceID_forRelationship_withContext_( Handle, CachedSelectors.retainedRelationshipDataWithSourceID_forRelationship_withContext_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), id, forRelationship, withContext );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject rootObjectStore() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.rootObjectStore( Handle, CachedSelectors.rootObjectStore, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setConfiguratioName_( NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			NativeMethods.setConfiguratioName_( Handle, CachedSelectors.setConfiguratioName_, out ___occuredException, sizeof( NObjective.RuntimeObject ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setParentStore_( NObjective.RuntimeObject store ) {
			RuntimeObject ___occuredException;
			NativeMethods.setParentStore_( Handle, CachedSelectors.setParentStore_, out ___occuredException, sizeof( NObjective.RuntimeObject ), store );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setReadOnly_( char only ) {
			RuntimeObject ___occuredException;
			NativeMethods.setReadOnly_( Handle, CachedSelectors.setReadOnly_, out ___occuredException, sizeof( char ), only );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setRootObjectStore_( NObjective.RuntimeObject store ) {
			RuntimeObject ___occuredException;
			NativeMethods.setRootObjectStore_( Handle, CachedSelectors.setRootObjectStore_, out ___occuredException, sizeof( NObjective.RuntimeObject ), store );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setStoreMetadata_( NObjective.RuntimeObject metadata ) {
			RuntimeObject ___occuredException;
			NativeMethods.setStoreMetadata_( Handle, CachedSelectors.setStoreMetadata_, out ___occuredException, sizeof( NObjective.RuntimeObject ), metadata );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setURL_( NObjective.RuntimeObject url ) {
			RuntimeObject ___occuredException;
			NativeMethods.setURL_( Handle, CachedSelectors.setURL_, out ___occuredException, sizeof( NObjective.RuntimeObject ), url );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public bool shouldRemoveFromParentObjectStore_error_( NObjective.RuntimeObject store, System.IntPtr error ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.shouldRemoveFromParentObjectStore_error_( Handle, CachedSelectors.shouldRemoveFromParentObjectStore_error_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), store, error );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject storeMetadata() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.storeMetadata( Handle, CachedSelectors.storeMetadata, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject storeOptions() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.storeOptions( Handle, CachedSelectors.storeOptions, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject storeType() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.storeType( Handle, CachedSelectors.storeType, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char tryLock() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.tryLock( Handle, CachedSelectors.tryLock, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void unlock() {
			RuntimeObject ___occuredException;
			NativeMethods.unlock( Handle, CachedSelectors.unlock, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void unlockParentStore() {
			RuntimeObject ___occuredException;
			NativeMethods.unlockParentStore( Handle, CachedSelectors.unlockParentStore, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject url() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.url( Handle, CachedSelectors.url, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void willRemoveFromParentObjectStore_( NObjective.RuntimeObject store ) {
			RuntimeObject ___occuredException;
			NativeMethods.willRemoveFromParentObjectStore_( Handle, CachedSelectors.willRemoveFromParentObjectStore_, out ___occuredException, sizeof( NObjective.RuntimeObject ), store );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void childStore_didForgetObjectsWithObjectIDs_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject store, NObjective.RuntimeObject didForgetObjectsWithObjectIDs );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void childStore_didRememberObjectsWithObjectIDs_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject store, NObjective.RuntimeObject didRememberObjectsWithObjectIDs );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr childStores( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr configurationName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void doFilesystemCleanupOnDealloc_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, char dealloc );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr executeRequest_withContext_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject request, NObjective.RuntimeObject withContext );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr faultHandler( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern NObjective.RuntimeClass faultHandlerClass( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char handlesObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char handlesRequest_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject request );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr identifier( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithRootStore_configurationName_options_url_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject store, NObjective.RuntimeObject configurationName, NObjective.RuntimeObject options, NObjective.RuntimeObject url );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isReadOnly( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern System.IntPtr knownKeyValuesForObjectID_withContext_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id, NObjective.RuntimeObject withContext );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void @lock( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void lockParentStore( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr metadataForPersistentStoreWithURL_error_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject url, System.IntPtr error );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern NObjective.RuntimeClass objectIDClassForEntity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int objectIDDataType( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr objectIDFactoryForEntity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr parentStore( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr retainedDataForObjectID_withContext_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id, NObjective.RuntimeObject withContext );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr retainedRelationshipDataWithSourceID_forRelationship_withContext_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id, NObjective.RuntimeObject forRelationship, NObjective.RuntimeObject withContext );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr rootObjectStore( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setConfiguratioName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setParentStore_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject store );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setReadOnly_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, char only );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setRootObjectStore_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject store );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setStoreMetadata_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject metadata );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setURL_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject url );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool shouldRemoveFromParentObjectStore_error_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject store, System.IntPtr error );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr storeMetadata( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr storeOptions( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr storeType( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char tryLock( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void unlock( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void unlockParentStore( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr url( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void willRemoveFromParentObjectStore_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject store );
		}
		static internal class CachedSelectors {
			public static readonly Selector childStore_didForgetObjectsWithObjectIDs_ = "childStore:didForgetObjectsWithObjectIDs:";
			public static readonly Selector childStore_didRememberObjectsWithObjectIDs_ = "childStore:didRememberObjectsWithObjectIDs:";
			public static readonly Selector childStores = "childStores";
			public static readonly Selector configurationName = "configurationName";
			public static readonly Selector doFilesystemCleanupOnDealloc_ = "doFilesystemCleanupOnDealloc:";
			public static readonly Selector executeRequest_withContext_ = "executeRequest:withContext:";
			public static readonly Selector faultHandler = "faultHandler";
			public static readonly Selector faultHandlerClass = "faultHandlerClass";
			public static readonly Selector handlesObject_ = "handlesObject:";
			public static readonly Selector handlesRequest_ = "handlesRequest:";
			public static readonly Selector identifier = "identifier";
			public static readonly Selector initWithRootStore_configurationName_options_url_ = "initWithRootStore:configurationName:options:url:";
			public static readonly Selector isReadOnly = "isReadOnly";
			public static readonly Selector knownKeyValuesForObjectID_withContext_ = "knownKeyValuesForObjectID:withContext:";
			public static readonly Selector @lock = "lock";
			public static readonly Selector lockParentStore = "lockParentStore";
			public static readonly Selector metadataForPersistentStoreWithURL_error_ = "metadataForPersistentStoreWithURL:error:";
			public static readonly Selector objectIDClassForEntity_ = "objectIDClassForEntity:";
			public static readonly Selector objectIDDataType = "objectIDDataType";
			public static readonly Selector objectIDFactoryForEntity_ = "objectIDFactoryForEntity:";
			public static readonly Selector parentStore = "parentStore";
			public static readonly Selector retainedDataForObjectID_withContext_ = "retainedDataForObjectID:withContext:";
			public static readonly Selector retainedRelationshipDataWithSourceID_forRelationship_withContext_ = "retainedRelationshipDataWithSourceID:forRelationship:withContext:";
			public static readonly Selector rootObjectStore = "rootObjectStore";
			public static readonly Selector setConfiguratioName_ = "setConfiguratioName:";
			public static readonly Selector setParentStore_ = "setParentStore:";
			public static readonly Selector setReadOnly_ = "setReadOnly:";
			public static readonly Selector setRootObjectStore_ = "setRootObjectStore:";
			public static readonly Selector setStoreMetadata_ = "setStoreMetadata:";
			public static readonly Selector setURL_ = "setURL:";
			public static readonly Selector shouldRemoveFromParentObjectStore_error_ = "shouldRemoveFromParentObjectStore:error:";
			public static readonly Selector storeMetadata = "storeMetadata";
			public static readonly Selector storeOptions = "storeOptions";
			public static readonly Selector storeType = "storeType";
			public static readonly Selector tryLock = "tryLock";
			public static readonly Selector unlock = "unlock";
			public static readonly Selector unlockParentStore = "unlockParentStore";
			public static readonly Selector url = "url";
			public static readonly Selector willRemoveFromParentObjectStore_ = "willRemoveFromParentObjectStore:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSObjectStoreCache : IEquatable<NSObjectStoreCache> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSObjectStoreCache;
		public static implicit operator IntPtr( NSObjectStoreCache value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSObjectStoreCache value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSObjectStoreCache?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSObjectStoreCache value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSObjectStoreCache value1, NSObjectStoreCache value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSObjectStoreCache value1, NSObjectStoreCache value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSObjectStoreCache( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSObjectStoreCache alloc() {
			return new NSObjectStoreCache( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void decrementRefCountForObjectID_( NObjective.RuntimeObject id ) {
			RuntimeObject ___occuredException;
			NativeMethods.decrementRefCountForObjectID_( Handle, CachedSelectors.decrementRefCountForObjectID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject externalDataForObjectID_timestamp_( NObjective.RuntimeObject id, double timestamp ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.externalDataForObjectID_timestamp_( Handle, CachedSelectors.externalDataForObjectID_timestamp_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( double ), id, timestamp );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject externalDataForSourceObjectID_key_timestamp_( NObjective.RuntimeObject id, NObjective.RuntimeObject key, double timestamp ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.externalDataForSourceObjectID_key_timestamp_( Handle, CachedSelectors.externalDataForSourceObjectID_key_timestamp_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( double ), id, key, timestamp );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void forgetAllExternalData() {
			RuntimeObject ___occuredException;
			NativeMethods.forgetAllExternalData( Handle, CachedSelectors.forgetAllExternalData, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void forgetExternalDataForObjectID_( NObjective.RuntimeObject id ) {
			RuntimeObject ___occuredException;
			NativeMethods.forgetExternalDataForObjectID_( Handle, CachedSelectors.forgetExternalDataForObjectID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void incrementRefCountForObjectID_( NObjective.RuntimeObject id ) {
			RuntimeObject ___occuredException;
			NativeMethods.incrementRefCountForObjectID_( Handle, CachedSelectors.incrementRefCountForObjectID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public uint optionsForObjectID_( NObjective.RuntimeObject id ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.optionsForObjectID_( Handle, CachedSelectors.optionsForObjectID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public int refCountForObjectID_( NObjective.RuntimeObject id ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.refCountForObjectID_( Handle, CachedSelectors.refCountForObjectID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void registerExternalData_forObjectID_options_( NObjective.RuntimeObject data, NObjective.RuntimeObject forObjectID, uint options ) {
			RuntimeObject ___occuredException;
			NativeMethods.registerExternalData_forObjectID_options_( Handle, CachedSelectors.registerExternalData_forObjectID_options_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( uint ), data, forObjectID, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void registerExternalData_forSourceObjectID_key_options_( NObjective.RuntimeObject data, NObjective.RuntimeObject forSourceObjectID, NObjective.RuntimeObject key, uint options ) {
			RuntimeObject ___occuredException;
			NativeMethods.registerExternalData_forSourceObjectID_key_options_( Handle, CachedSelectors.registerExternalData_forSourceObjectID_key_options_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( uint ), data, forSourceObjectID, key, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public bool shouldPersistObjectForObjectID_( NObjective.RuntimeObject id ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.shouldPersistObjectForObjectID_( Handle, CachedSelectors.shouldPersistObjectForObjectID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool shouldRefreshObjectForObjectID_( NObjective.RuntimeObject id ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.shouldRefreshObjectForObjectID_( Handle, CachedSelectors.shouldRefreshObjectForObjectID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void decrementRefCountForObjectID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr externalDataForObjectID_timestamp_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id, double timestamp );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr externalDataForSourceObjectID_key_timestamp_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id, NObjective.RuntimeObject key, double timestamp );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void forgetAllExternalData( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void forgetExternalDataForObjectID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void incrementRefCountForObjectID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint optionsForObjectID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int refCountForObjectID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void registerExternalData_forObjectID_options_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject data, NObjective.RuntimeObject forObjectID, uint options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void registerExternalData_forSourceObjectID_key_options_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject data, NObjective.RuntimeObject forSourceObjectID, NObjective.RuntimeObject key, uint options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool shouldPersistObjectForObjectID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool shouldRefreshObjectForObjectID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id );
		}
		static internal class CachedSelectors {
			public static readonly Selector decrementRefCountForObjectID_ = "decrementRefCountForObjectID:";
			public static readonly Selector externalDataForObjectID_timestamp_ = "externalDataForObjectID:timestamp:";
			public static readonly Selector externalDataForSourceObjectID_key_timestamp_ = "externalDataForSourceObjectID:key:timestamp:";
			public static readonly Selector forgetAllExternalData = "forgetAllExternalData";
			public static readonly Selector forgetExternalDataForObjectID_ = "forgetExternalDataForObjectID:";
			public static readonly Selector incrementRefCountForObjectID_ = "incrementRefCountForObjectID:";
			public static readonly Selector optionsForObjectID_ = "optionsForObjectID:";
			public static readonly Selector refCountForObjectID_ = "refCountForObjectID:";
			public static readonly Selector registerExternalData_forObjectID_options_ = "registerExternalData:forObjectID:options:";
			public static readonly Selector registerExternalData_forSourceObjectID_key_options_ = "registerExternalData:forSourceObjectID:key:options:";
			public static readonly Selector shouldPersistObjectForObjectID_ = "shouldPersistObjectForObjectID:";
			public static readonly Selector shouldRefreshObjectForObjectID_ = "shouldRefreshObjectForObjectID:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSObjectStoreMap : IEquatable<NSObjectStoreMap> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSObjectStoreMap;
		public static implicit operator IntPtr( NSObjectStoreMap value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSObjectStoreMap value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSObjectStoreMap?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSObjectStoreMap value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSObjectStoreMap value1, NSObjectStoreMap value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSObjectStoreMap value1, NSObjectStoreMap value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSObjectStoreMap( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSObjectStoreMap alloc() {
			return new NSObjectStoreMap( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void addObject_objectIDMap_( NObjective.RuntimeObject @object, NObjective.RuntimeObject objectIDMap ) {
			RuntimeObject ___occuredException;
			NativeMethods.addObject_objectIDMap_( Handle, CachedSelectors.addObject_objectIDMap_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), @object, objectIDMap );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject configurationName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.configurationName( Handle, CachedSelectors.configurationName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char containsObjectWithID_( NObjective.RuntimeObject id ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.containsObjectWithID_( Handle, CachedSelectors.containsObjectWithID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject databaseUUID() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.databaseUUID( Handle, CachedSelectors.databaseUUID, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject dataForKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dataForKey_( Handle, CachedSelectors.dataForKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject handleFetchRequest_( NObjective.RuntimeObject request ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.handleFetchRequest_( Handle, CachedSelectors.handleFetchRequest_, out ___occuredException, sizeof( NObjective.RuntimeObject ), request );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSObjectStoreMap initWithStore_( NObjective.RuntimeObject store ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithStore_( Handle, CachedSelectors.initWithStore_, out ___occuredException, sizeof( NObjective.RuntimeObject ), store );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSObjectStoreMap( ___result );
		}
		unsafe public ulong nextPK64() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.nextPK64( Handle, CachedSelectors.nextPK64, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void removeObject_objectIDMap_( NObjective.RuntimeObject @object, NObjective.RuntimeObject objectIDMap ) {
			RuntimeObject ___occuredException;
			NativeMethods.removeObject_objectIDMap_( Handle, CachedSelectors.removeObject_objectIDMap_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), @object, objectIDMap );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject retainedObjectIDsForRelationship_forObjectID_( NObjective.RuntimeObject relationship, NObjective.RuntimeObject forObjectID ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.retainedObjectIDsForRelationship_forObjectID_( Handle, CachedSelectors.retainedObjectIDsForRelationship_forObjectID_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), relationship, forObjectID );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setDatabaseUUID_( NObjective.RuntimeObject uuid ) {
			RuntimeObject ___occuredException;
			NativeMethods.setDatabaseUUID_( Handle, CachedSelectors.setDatabaseUUID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), uuid );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setStoreMetadata_( NObjective.RuntimeObject metadata ) {
			RuntimeObject ___occuredException;
			NativeMethods.setStoreMetadata_( Handle, CachedSelectors.setStoreMetadata_, out ___occuredException, sizeof( NObjective.RuntimeObject ), metadata );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject store() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.store( Handle, CachedSelectors.store, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject storeMetadata() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.storeMetadata( Handle, CachedSelectors.storeMetadata, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void updateObject_objectIDMap_( NObjective.RuntimeObject @object, NObjective.RuntimeObject objectIDMap ) {
			RuntimeObject ___occuredException;
			NativeMethods.updateObject_objectIDMap_( Handle, CachedSelectors.updateObject_objectIDMap_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), @object, objectIDMap );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void addObject_objectIDMap_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, NObjective.RuntimeObject objectIDMap );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr configurationName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char containsObjectWithID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr databaseUUID( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr dataForKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr handleFetchRequest_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject request );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithStore_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject store );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern ulong nextPK64( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void removeObject_objectIDMap_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, NObjective.RuntimeObject objectIDMap );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr retainedObjectIDsForRelationship_forObjectID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject relationship, NObjective.RuntimeObject forObjectID );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setDatabaseUUID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject uuid );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setStoreMetadata_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject metadata );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr store( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr storeMetadata( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void updateObject_objectIDMap_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, NObjective.RuntimeObject objectIDMap );
		}
		static internal class CachedSelectors {
			public static readonly Selector addObject_objectIDMap_ = "addObject:objectIDMap:";
			public static readonly Selector configurationName = "configurationName";
			public static readonly Selector containsObjectWithID_ = "containsObjectWithID:";
			public static readonly Selector databaseUUID = "databaseUUID";
			public static readonly Selector dataForKey_ = "dataForKey:";
			public static readonly Selector handleFetchRequest_ = "handleFetchRequest:";
			public static readonly Selector initWithStore_ = "initWithStore:";
			public static readonly Selector nextPK64 = "nextPK64";
			public static readonly Selector removeObject_objectIDMap_ = "removeObject:objectIDMap:";
			public static readonly Selector retainedObjectIDsForRelationship_forObjectID_ = "retainedObjectIDsForRelationship:forObjectID:";
			public static readonly Selector setDatabaseUUID_ = "setDatabaseUUID:";
			public static readonly Selector setStoreMetadata_ = "setStoreMetadata:";
			public static readonly Selector store = "store";
			public static readonly Selector storeMetadata = "storeMetadata";
			public static readonly Selector updateObject_objectIDMap_ = "updateObject:objectIDMap:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSObjectStoreRequest : IEquatable<NSObjectStoreRequest> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSObjectStoreRequest;
		public static implicit operator IntPtr( NSObjectStoreRequest value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSObjectStoreRequest value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSObjectStoreRequest?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSObjectStoreRequest value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSObjectStoreRequest value1, NSObjectStoreRequest value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSObjectStoreRequest value1, NSObjectStoreRequest value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSObjectStoreRequest( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSObjectStoreRequest alloc() {
			return new NSObjectStoreRequest( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NSObjectStoreRequest initForManagedObjectContext_( NObjective.RuntimeObject context ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initForManagedObjectContext_( Handle, CachedSelectors.initForManagedObjectContext_, out ___occuredException, sizeof( NObjective.RuntimeObject ), context );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSObjectStoreRequest( ___result );
		}
		unsafe public NObjective.RuntimeObject managedObjectContext() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.managedObjectContext( Handle, CachedSelectors.managedObjectContext, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject requestError() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.requestError( Handle, CachedSelectors.requestError, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char requestSuccessful() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.requestSuccessful( Handle, CachedSelectors.requestSuccessful, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public int requestType() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.requestType( Handle, CachedSelectors.requestType, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void setRequestError_( NObjective.RuntimeObject error ) {
			RuntimeObject ___occuredException;
			NativeMethods.setRequestError_( Handle, CachedSelectors.setRequestError_, out ___occuredException, sizeof( NObjective.RuntimeObject ), error );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setRequestSuccessful_( char successful ) {
			RuntimeObject ___occuredException;
			NativeMethods.setRequestSuccessful_( Handle, CachedSelectors.setRequestSuccessful_, out ___occuredException, sizeof( char ), successful );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject stores() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.stores( Handle, CachedSelectors.stores, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initForManagedObjectContext_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject context );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr managedObjectContext( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr requestError( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char requestSuccessful( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int requestType( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setRequestError_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject error );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setRequestSuccessful_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, char successful );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr stores( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector initForManagedObjectContext_ = "initForManagedObjectContext:";
			public static readonly Selector managedObjectContext = "managedObjectContext";
			public static readonly Selector requestError = "requestError";
			public static readonly Selector requestSuccessful = "requestSuccessful";
			public static readonly Selector requestType = "requestType";
			public static readonly Selector setRequestError_ = "setRequestError:";
			public static readonly Selector setRequestSuccessful_ = "setRequestSuccessful:";
			public static readonly Selector stores = "stores";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSPersistentStoreCoordinator : IEquatable<NSPersistentStoreCoordinator> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSPersistentStoreCoordinator;
		public static implicit operator IntPtr( NSPersistentStoreCoordinator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSPersistentStoreCoordinator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSPersistentStoreCoordinator?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSPersistentStoreCoordinator value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSPersistentStoreCoordinator value1, NSPersistentStoreCoordinator value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSPersistentStoreCoordinator value1, NSPersistentStoreCoordinator value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSPersistentStoreCoordinator( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSPersistentStoreCoordinator alloc() {
			return new NSPersistentStoreCoordinator( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NSDictionary metadataForPersistentStoreWithURL_error_( NSURL url, ref NSError error ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.metadataForPersistentStoreWithURL_error_( ClassHandle, CachedSelectors.metadataForPersistentStoreWithURL_error_, out ___occuredException, sizeof( NSURL ) + sizeof( IntPtr ), url, ref error );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public NObjective.RuntimeObject addPersistentStoreWithType_configuration_URL_options_error_( string type, string configuration, NSURL URL, NSDictionary options, ref NSError error ) {
			RuntimeObject ___occuredException;
			var ___wrappedtype = Runtime.CreateStringProxy( type );
			var ___wrappedconfiguration = Runtime.CreateStringProxy( configuration );
			var ___result = NativeMethods.addPersistentStoreWithType_configuration_URL_options_error_( Handle, CachedSelectors.addPersistentStoreWithType_configuration_URL_options_error_, out ___occuredException, sizeof( IntPtr ) + sizeof( IntPtr ) + sizeof( NSURL ) + sizeof( NSDictionary ) + sizeof( IntPtr ), ___wrappedtype, ___wrappedconfiguration, URL, options, ref error );
			Runtime.ReleaseNativeObject( ___wrappedtype );
			Runtime.ReleaseNativeObject( ___wrappedconfiguration );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void childStore_didForgetObjectsWithObjectIDs_( NObjective.RuntimeObject store, NObjective.RuntimeObject didForgetObjectsWithObjectIDs ) {
			RuntimeObject ___occuredException;
			NativeMethods.childStore_didForgetObjectsWithObjectIDs_( Handle, CachedSelectors.childStore_didForgetObjectsWithObjectIDs_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), store, didForgetObjectsWithObjectIDs );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void childStore_didRememberObjectsWithObjectIDs_( NObjective.RuntimeObject store, NObjective.RuntimeObject didRememberObjectsWithObjectIDs ) {
			RuntimeObject ___occuredException;
			NativeMethods.childStore_didRememberObjectsWithObjectIDs_( Handle, CachedSelectors.childStore_didRememberObjectsWithObjectIDs_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), store, didRememberObjectsWithObjectIDs );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject childStores() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.childStores( Handle, CachedSelectors.childStores, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject executeRequest_withContext_( NObjective.RuntimeObject request, NObjective.RuntimeObject withContext ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.executeRequest_withContext_( Handle, CachedSelectors.executeRequest_withContext_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), request, withContext );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char handlesObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.handlesObject_( Handle, CachedSelectors.handlesObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char handlesRequest_( NObjective.RuntimeObject request ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.handlesRequest_( Handle, CachedSelectors.handlesRequest_, out ___occuredException, sizeof( NObjective.RuntimeObject ), request );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NSPersistentStoreCoordinator initWithManagedObjectModel_( NSManagedObjectModel model ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithManagedObjectModel_( Handle, CachedSelectors.initWithManagedObjectModel_, out ___occuredException, sizeof( NSManagedObjectModel ), model );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSPersistentStoreCoordinator( ___result );
		}
		unsafe public System.IntPtr knownKeyValuesForObjectID_withContext_( NObjective.RuntimeObject id, NObjective.RuntimeObject withContext ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.knownKeyValuesForObjectID_withContext_( Handle, CachedSelectors.knownKeyValuesForObjectID_withContext_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), id, withContext );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void @lock() {
			RuntimeObject ___occuredException;
			NativeMethods.@lock( Handle, CachedSelectors.@lock, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void lockParentStore() {
			RuntimeObject ___occuredException;
			NativeMethods.lockParentStore( Handle, CachedSelectors.lockParentStore, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSManagedObjectID managedObjectIDForURIRepresentation_( NSURL representation ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.managedObjectIDForURIRepresentation_( Handle, CachedSelectors.managedObjectIDForURIRepresentation_, out ___occuredException, sizeof( NSURL ), representation );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSManagedObjectID( ___result );
		}
		unsafe public NSManagedObjectModel managedObjectModel() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.managedObjectModel( Handle, CachedSelectors.managedObjectModel, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSManagedObjectModel( ___result );
		}
		unsafe public NSDictionary metadataForPersistentStore_( NObjective.RuntimeObject store ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.metadataForPersistentStore_( Handle, CachedSelectors.metadataForPersistentStore_, out ___occuredException, sizeof( NObjective.RuntimeObject ), store );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public NObjective.RuntimeObject migratePersistentStore_toURL_options_withType_error_( NObjective.RuntimeObject store, NSURL toURL, NSDictionary options, string withType, ref NSError error ) {
			RuntimeObject ___occuredException;
			var ___wrappedwithType = Runtime.CreateStringProxy( withType );
			var ___result = NativeMethods.migratePersistentStore_toURL_options_withType_error_( Handle, CachedSelectors.migratePersistentStore_toURL_options_withType_error_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NSURL ) + sizeof( NSDictionary ) + sizeof( IntPtr ) + sizeof( IntPtr ), store, toURL, options, ___wrappedwithType, ref error );
			Runtime.ReleaseNativeObject( ___wrappedwithType );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject parentStore() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.parentStore( Handle, CachedSelectors.parentStore, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject persistentStoreForURL_( NSURL url ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.persistentStoreForURL_( Handle, CachedSelectors.persistentStoreForURL_, out ___occuredException, sizeof( NSURL ), url );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSArray persistentStores() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.persistentStores( Handle, CachedSelectors.persistentStores, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public bool removePersistentStore_error_( NObjective.RuntimeObject store, ref NSError error ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.removePersistentStore_error_( Handle, CachedSelectors.removePersistentStore_error_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( IntPtr ), store, ref error );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject retainedDataForObjectID_withContext_( NObjective.RuntimeObject id, NObjective.RuntimeObject withContext ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.retainedDataForObjectID_withContext_( Handle, CachedSelectors.retainedDataForObjectID_withContext_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), id, withContext );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject retainedRelationshipDataWithSourceID_forRelationship_withContext_( NObjective.RuntimeObject id, NObjective.RuntimeObject forRelationship, NObjective.RuntimeObject withContext ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.retainedRelationshipDataWithSourceID_forRelationship_withContext_( Handle, CachedSelectors.retainedRelationshipDataWithSourceID_forRelationship_withContext_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), id, forRelationship, withContext );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject rootObjectStore() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.rootObjectStore( Handle, CachedSelectors.rootObjectStore, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setMetadata_forPersistentStore_( NSDictionary metadata, NObjective.RuntimeObject forPersistentStore ) {
			RuntimeObject ___occuredException;
			NativeMethods.setMetadata_forPersistentStore_( Handle, CachedSelectors.setMetadata_forPersistentStore_, out ___occuredException, sizeof( NSDictionary ) + sizeof( NObjective.RuntimeObject ), metadata, forPersistentStore );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public bool tryLock() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.tryLock( Handle, CachedSelectors.tryLock, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void unlock() {
			RuntimeObject ___occuredException;
			NativeMethods.unlock( Handle, CachedSelectors.unlock, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void unlockParentStore() {
			RuntimeObject ___occuredException;
			NativeMethods.unlockParentStore( Handle, CachedSelectors.unlockParentStore, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSURL URLForPersistentStore_( NObjective.RuntimeObject store ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.URLForPersistentStore_( Handle, CachedSelectors.URLForPersistentStore_, out ___occuredException, sizeof( NObjective.RuntimeObject ), store );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSURL( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr addPersistentStoreWithType_configuration_URL_options_error_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr type, IntPtr configuration, NSURL URL, NSDictionary options, ref NSError error );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void childStore_didForgetObjectsWithObjectIDs_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject store, NObjective.RuntimeObject didForgetObjectsWithObjectIDs );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void childStore_didRememberObjectsWithObjectIDs_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject store, NObjective.RuntimeObject didRememberObjectsWithObjectIDs );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr childStores( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr executeRequest_withContext_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject request, NObjective.RuntimeObject withContext );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char handlesObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char handlesRequest_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject request );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithManagedObjectModel_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSManagedObjectModel model );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern System.IntPtr knownKeyValuesForObjectID_withContext_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id, NObjective.RuntimeObject withContext );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void @lock( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void lockParentStore( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr managedObjectIDForURIRepresentation_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSURL representation );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr managedObjectModel( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr metadataForPersistentStore_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject store );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr metadataForPersistentStoreWithURL_error_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSURL url, ref NSError error );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr migratePersistentStore_toURL_options_withType_error_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject store, NSURL toURL, NSDictionary options, IntPtr withType, ref NSError error );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr parentStore( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr persistentStoreForURL_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSURL url );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr persistentStores( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool removePersistentStore_error_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject store, ref NSError error );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr retainedDataForObjectID_withContext_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id, NObjective.RuntimeObject withContext );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr retainedRelationshipDataWithSourceID_forRelationship_withContext_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id, NObjective.RuntimeObject forRelationship, NObjective.RuntimeObject withContext );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr rootObjectStore( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setMetadata_forPersistentStore_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDictionary metadata, NObjective.RuntimeObject forPersistentStore );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool tryLock( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void unlock( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void unlockParentStore( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr URLForPersistentStore_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject store );
		}
		static internal class CachedSelectors {
			public static readonly Selector addPersistentStoreWithType_configuration_URL_options_error_ = "addPersistentStoreWithType:configuration:URL:options:error:";
			public static readonly Selector childStore_didForgetObjectsWithObjectIDs_ = "childStore:didForgetObjectsWithObjectIDs:";
			public static readonly Selector childStore_didRememberObjectsWithObjectIDs_ = "childStore:didRememberObjectsWithObjectIDs:";
			public static readonly Selector childStores = "childStores";
			public static readonly Selector executeRequest_withContext_ = "executeRequest:withContext:";
			public static readonly Selector handlesObject_ = "handlesObject:";
			public static readonly Selector handlesRequest_ = "handlesRequest:";
			public static readonly Selector initWithManagedObjectModel_ = "initWithManagedObjectModel:";
			public static readonly Selector knownKeyValuesForObjectID_withContext_ = "knownKeyValuesForObjectID:withContext:";
			public static readonly Selector @lock = "lock";
			public static readonly Selector lockParentStore = "lockParentStore";
			public static readonly Selector managedObjectIDForURIRepresentation_ = "managedObjectIDForURIRepresentation:";
			public static readonly Selector managedObjectModel = "managedObjectModel";
			public static readonly Selector metadataForPersistentStore_ = "metadataForPersistentStore:";
			public static readonly Selector metadataForPersistentStoreWithURL_error_ = "metadataForPersistentStoreWithURL:error:";
			public static readonly Selector migratePersistentStore_toURL_options_withType_error_ = "migratePersistentStore:toURL:options:withType:error:";
			public static readonly Selector parentStore = "parentStore";
			public static readonly Selector persistentStoreForURL_ = "persistentStoreForURL:";
			public static readonly Selector persistentStores = "persistentStores";
			public static readonly Selector removePersistentStore_error_ = "removePersistentStore:error:";
			public static readonly Selector retainedDataForObjectID_withContext_ = "retainedDataForObjectID:withContext:";
			public static readonly Selector retainedRelationshipDataWithSourceID_forRelationship_withContext_ = "retainedRelationshipDataWithSourceID:forRelationship:withContext:";
			public static readonly Selector rootObjectStore = "rootObjectStore";
			public static readonly Selector setMetadata_forPersistentStore_ = "setMetadata:forPersistentStore:";
			public static readonly Selector tryLock = "tryLock";
			public static readonly Selector unlock = "unlock";
			public static readonly Selector unlockParentStore = "unlockParentStore";
			public static readonly Selector URLForPersistentStore_ = "URLForPersistentStore:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSPrivateCoreDataClassForFindingBundle : IEquatable<NSPrivateCoreDataClassForFindingBundle> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSPrivateCoreDataClassForFindingBundle;
		public static implicit operator IntPtr( NSPrivateCoreDataClassForFindingBundle value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSPrivateCoreDataClassForFindingBundle value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSPrivateCoreDataClassForFindingBundle?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSPrivateCoreDataClassForFindingBundle value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSPrivateCoreDataClassForFindingBundle value1, NSPrivateCoreDataClassForFindingBundle value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSPrivateCoreDataClassForFindingBundle value1, NSPrivateCoreDataClassForFindingBundle value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSPrivateCoreDataClassForFindingBundle( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSPrivateCoreDataClassForFindingBundle alloc() {
			return new NSPrivateCoreDataClassForFindingBundle( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSPropertyDescription : IEquatable<NSPropertyDescription> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSPropertyDescription;
		public static implicit operator IntPtr( NSPropertyDescription value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSPropertyDescription value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSPropertyDescription?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSPropertyDescription value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSPropertyDescription value1, NSPropertyDescription value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSPropertyDescription value1, NSPropertyDescription value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSPropertyDescription( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSPropertyDescription alloc() {
			return new NSPropertyDescription( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void encodeWithCoder_( NSCoder coder ) {
			RuntimeObject ___occuredException;
			NativeMethods.encodeWithCoder_( Handle, CachedSelectors.encodeWithCoder_, out ___occuredException, sizeof( NSCoder ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSEntityDescription entity() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entity( Handle, CachedSelectors.entity, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSEntityDescription( ___result );
		}
		unsafe public NSPropertyDescription initWithCoder_( NObjective.RuntimeObject coder ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCoder_( Handle, CachedSelectors.initWithCoder_, out ___occuredException, sizeof( NObjective.RuntimeObject ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSPropertyDescription( ___result );
		}
		unsafe public bool isOptional() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isOptional( Handle, CachedSelectors.isOptional, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isReadOnly() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isReadOnly( Handle, CachedSelectors.isReadOnly, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isTransient() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isTransient( Handle, CachedSelectors.isTransient, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public string name() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.name( Handle, CachedSelectors.name, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public void setName_( string name ) {
			RuntimeObject ___occuredException;
			var ___wrappedname = Runtime.CreateStringProxy( name );
			NativeMethods.setName_( Handle, CachedSelectors.setName_, out ___occuredException, sizeof( IntPtr ), ___wrappedname );
			Runtime.ReleaseNativeObject( ___wrappedname );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setOptional_( bool optional ) {
			RuntimeObject ___occuredException;
			NativeMethods.setOptional_( Handle, CachedSelectors.setOptional_, out ___occuredException, sizeof( bool ), optional );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setReadOnly_( char only ) {
			RuntimeObject ___occuredException;
			NativeMethods.setReadOnly_( Handle, CachedSelectors.setReadOnly_, out ___occuredException, sizeof( char ), only );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setTransient_( bool transient ) {
			RuntimeObject ___occuredException;
			NativeMethods.setTransient_( Handle, CachedSelectors.setTransient_, out ___occuredException, sizeof( bool ), transient );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setUserInfo_( NSDictionary info ) {
			RuntimeObject ___occuredException;
			NativeMethods.setUserInfo_( Handle, CachedSelectors.setUserInfo_, out ___occuredException, sizeof( NSDictionary ), info );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setValidationPredicates_withValidationWarnings_( NSArray predicates, NSArray withValidationWarnings ) {
			RuntimeObject ___occuredException;
			NativeMethods.setValidationPredicates_withValidationWarnings_( Handle, CachedSelectors.setValidationPredicates_withValidationWarnings_, out ___occuredException, sizeof( NSArray ) + sizeof( NSArray ), predicates, withValidationWarnings );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSDictionary userInfo() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.userInfo( Handle, CachedSelectors.userInfo, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public NSArray validationPredicates() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.validationPredicates( Handle, CachedSelectors.validationPredicates, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public NSArray validationWarnings() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.validationWarnings( Handle, CachedSelectors.validationWarnings, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void encodeWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSCoder coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr entity( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isOptional( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isReadOnly( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isTransient( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr name( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setOptional_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, bool optional );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setReadOnly_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, char only );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setTransient_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, bool transient );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setUserInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDictionary info );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setValidationPredicates_withValidationWarnings_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray predicates, NSArray withValidationWarnings );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr userInfo( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr validationPredicates( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr validationWarnings( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector encodeWithCoder_ = "encodeWithCoder:";
			public static readonly Selector entity = "entity";
			public static readonly Selector initWithCoder_ = "initWithCoder:";
			public static readonly Selector isOptional = "isOptional";
			public static readonly Selector isReadOnly = "isReadOnly";
			public static readonly Selector isTransient = "isTransient";
			public static readonly Selector name = "name";
			public static readonly Selector setName_ = "setName:";
			public static readonly Selector setOptional_ = "setOptional:";
			public static readonly Selector setReadOnly_ = "setReadOnly:";
			public static readonly Selector setTransient_ = "setTransient:";
			public static readonly Selector setUserInfo_ = "setUserInfo:";
			public static readonly Selector setValidationPredicates_withValidationWarnings_ = "setValidationPredicates:withValidationWarnings:";
			public static readonly Selector userInfo = "userInfo";
			public static readonly Selector validationPredicates = "validationPredicates";
			public static readonly Selector validationWarnings = "validationWarnings";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSMapping ) )]
	public struct NSPropertyMapping : IEquatable<NSPropertyMapping> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSPropertyMapping;
		public static implicit operator IntPtr( NSPropertyMapping value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSPropertyMapping value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSPropertyMapping?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSPropertyMapping value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSPropertyMapping value1, NSPropertyMapping value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSPropertyMapping value1, NSPropertyMapping value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSPropertyMapping( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSPropertyMapping alloc() {
			return new NSPropertyMapping( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NSPropertyMapping initWithProperty_( NObjective.RuntimeObject property ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithProperty_( Handle, CachedSelectors.initWithProperty_, out ___occuredException, sizeof( NObjective.RuntimeObject ), property );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSPropertyMapping( ___result );
		}
		unsafe public NObjective.RuntimeObject property() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.property( Handle, CachedSelectors.property, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setProperty_( NObjective.RuntimeObject property ) {
			RuntimeObject ___occuredException;
			NativeMethods.setProperty_( Handle, CachedSelectors.setProperty_, out ___occuredException, sizeof( NObjective.RuntimeObject ), property );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithProperty_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject property );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr property( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setProperty_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject property );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithProperty_ = "initWithProperty:";
			public static readonly Selector property = "property";
			public static readonly Selector setProperty_ = "setProperty:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObjectStoreRequest ) )]
	public struct NSRefreshRequest : IEquatable<NSRefreshRequest> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSRefreshRequest;
		public static implicit operator IntPtr( NSRefreshRequest value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSRefreshRequest value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSRefreshRequest?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSRefreshRequest value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSRefreshRequest value1, NSRefreshRequest value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSRefreshRequest value1, NSRefreshRequest value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSRefreshRequest( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSRefreshRequest alloc() {
			return new NSRefreshRequest( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject refreshObjects() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.refreshObjects( Handle, CachedSelectors.refreshObjects, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public int refreshType() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.refreshType( Handle, CachedSelectors.refreshType, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void setRefreshObjects_( NObjective.RuntimeObject objects ) {
			RuntimeObject ___occuredException;
			NativeMethods.setRefreshObjects_( Handle, CachedSelectors.setRefreshObjects_, out ___occuredException, sizeof( NObjective.RuntimeObject ), objects );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setRefreshType_( int type ) {
			RuntimeObject ___occuredException;
			NativeMethods.setRefreshType_( Handle, CachedSelectors.setRefreshType_, out ___occuredException, sizeof( int ), type );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr refreshObjects( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int refreshType( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setRefreshObjects_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject objects );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setRefreshType_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int type );
		}
		static internal class CachedSelectors {
			public static readonly Selector refreshObjects = "refreshObjects";
			public static readonly Selector refreshType = "refreshType";
			public static readonly Selector setRefreshObjects_ = "setRefreshObjects:";
			public static readonly Selector setRefreshType_ = "setRefreshType:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSPropertyDescription ) )]
	public struct NSRelationshipDescription : IEquatable<NSRelationshipDescription> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSRelationshipDescription;
		public static implicit operator IntPtr( NSRelationshipDescription value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSRelationshipDescription value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSRelationshipDescription?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSRelationshipDescription value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSRelationshipDescription value1, NSRelationshipDescription value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSRelationshipDescription value1, NSRelationshipDescription value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSRelationshipDescription( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSRelationshipDescription alloc() {
			return new NSRelationshipDescription( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NSDeleteRule deleteRule() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.deleteRule( Handle, CachedSelectors.deleteRule, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( NSDeleteRule ) ___result;
		}
		unsafe public NSEntityDescription destinationEntity() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.destinationEntity( Handle, CachedSelectors.destinationEntity, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSEntityDescription( ___result );
		}
		unsafe public NSRelationshipDescription inverseRelationship() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.inverseRelationship( Handle, CachedSelectors.inverseRelationship, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSRelationshipDescription( ___result );
		}
		unsafe public bool isToMany() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isToMany( Handle, CachedSelectors.isToMany, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public uint maxCount() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.maxCount( Handle, CachedSelectors.maxCount, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public uint minCount() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.minCount( Handle, CachedSelectors.minCount, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public void setDeleteRule_( NSDeleteRule rule ) {
			RuntimeObject ___occuredException;
			NativeMethods.setDeleteRule_( Handle, CachedSelectors.setDeleteRule_, out ___occuredException, sizeof( NSDeleteRule ), rule );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setDestinationEntity_( NSEntityDescription entity ) {
			RuntimeObject ___occuredException;
			NativeMethods.setDestinationEntity_( Handle, CachedSelectors.setDestinationEntity_, out ___occuredException, sizeof( NSEntityDescription ), entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setInverseRelationship_( NSRelationshipDescription relationship ) {
			RuntimeObject ___occuredException;
			NativeMethods.setInverseRelationship_( Handle, CachedSelectors.setInverseRelationship_, out ___occuredException, sizeof( NSRelationshipDescription ), relationship );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setMaxCount_( uint count ) {
			RuntimeObject ___occuredException;
			NativeMethods.setMaxCount_( Handle, CachedSelectors.setMaxCount_, out ___occuredException, sizeof( uint ), count );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setMinCount_( uint count ) {
			RuntimeObject ___occuredException;
			NativeMethods.setMinCount_( Handle, CachedSelectors.setMinCount_, out ___occuredException, sizeof( uint ), count );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int deleteRule( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr destinationEntity( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr inverseRelationship( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isToMany( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint maxCount( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint minCount( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setDeleteRule_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDeleteRule rule );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setDestinationEntity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSEntityDescription entity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setInverseRelationship_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSRelationshipDescription relationship );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setMaxCount_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint count );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setMinCount_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint count );
		}
		static internal class CachedSelectors {
			public static readonly Selector deleteRule = "deleteRule";
			public static readonly Selector destinationEntity = "destinationEntity";
			public static readonly Selector inverseRelationship = "inverseRelationship";
			public static readonly Selector isToMany = "isToMany";
			public static readonly Selector maxCount = "maxCount";
			public static readonly Selector minCount = "minCount";
			public static readonly Selector setDeleteRule_ = "setDeleteRule:";
			public static readonly Selector setDestinationEntity_ = "setDestinationEntity:";
			public static readonly Selector setInverseRelationship_ = "setInverseRelationship:";
			public static readonly Selector setMaxCount_ = "setMaxCount:";
			public static readonly Selector setMinCount_ = "setMinCount:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSPropertyMapping ) )]
	public struct NSRelationshipMapping : IEquatable<NSRelationshipMapping> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSRelationshipMapping;
		public static implicit operator IntPtr( NSRelationshipMapping value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSRelationshipMapping value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSRelationshipMapping?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSRelationshipMapping value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSRelationshipMapping value1, NSRelationshipMapping value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSRelationshipMapping value1, NSRelationshipMapping value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSRelationshipMapping( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSRelationshipMapping alloc() {
			return new NSRelationshipMapping( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject columnDefinitions() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.columnDefinitions( Handle, CachedSelectors.columnDefinitions, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject constraintDefinitions() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.constraintDefinitions( Handle, CachedSelectors.constraintDefinitions, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject destinationEntityExternalName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.destinationEntityExternalName( Handle, CachedSelectors.destinationEntityExternalName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject foreignKeys() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.foreignKeys( Handle, CachedSelectors.foreignKeys, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject joins() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.joins( Handle, CachedSelectors.joins, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public int joinSemantic() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.joinSemantic( Handle, CachedSelectors.joinSemantic, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject relationship() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.relationship( Handle, CachedSelectors.relationship, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setDestinationEntityExternalName_( NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			NativeMethods.setDestinationEntityExternalName_( Handle, CachedSelectors.setDestinationEntityExternalName_, out ___occuredException, sizeof( NObjective.RuntimeObject ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setForeignKeys_( NObjective.RuntimeObject keys ) {
			RuntimeObject ___occuredException;
			NativeMethods.setForeignKeys_( Handle, CachedSelectors.setForeignKeys_, out ___occuredException, sizeof( NObjective.RuntimeObject ), keys );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setJoins_( NObjective.RuntimeObject joins ) {
			RuntimeObject ___occuredException;
			NativeMethods.setJoins_( Handle, CachedSelectors.setJoins_, out ___occuredException, sizeof( NObjective.RuntimeObject ), joins );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setJoinSemantic_( int semantic ) {
			RuntimeObject ___occuredException;
			NativeMethods.setJoinSemantic_( Handle, CachedSelectors.setJoinSemantic_, out ___occuredException, sizeof( int ), semantic );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr columnDefinitions( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr constraintDefinitions( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr destinationEntityExternalName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr foreignKeys( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr joins( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int joinSemantic( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr relationship( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setDestinationEntityExternalName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setForeignKeys_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject keys );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setJoins_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject joins );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setJoinSemantic_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int semantic );
		}
		static internal class CachedSelectors {
			public static readonly Selector columnDefinitions = "columnDefinitions";
			public static readonly Selector constraintDefinitions = "constraintDefinitions";
			public static readonly Selector destinationEntityExternalName = "destinationEntityExternalName";
			public static readonly Selector foreignKeys = "foreignKeys";
			public static readonly Selector joins = "joins";
			public static readonly Selector joinSemantic = "joinSemantic";
			public static readonly Selector relationship = "relationship";
			public static readonly Selector setDestinationEntityExternalName_ = "setDestinationEntityExternalName:";
			public static readonly Selector setForeignKeys_ = "setForeignKeys:";
			public static readonly Selector setJoins_ = "setJoins:";
			public static readonly Selector setJoinSemantic_ = "setJoinSemantic:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObjectStoreRequest ) )]
	public struct NSSaveChangesRequest : IEquatable<NSSaveChangesRequest> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSaveChangesRequest;
		public static implicit operator IntPtr( NSSaveChangesRequest value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSaveChangesRequest value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSaveChangesRequest?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSaveChangesRequest value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSaveChangesRequest value1, NSSaveChangesRequest value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSaveChangesRequest value1, NSSaveChangesRequest value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSaveChangesRequest( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSaveChangesRequest alloc() {
			return new NSSaveChangesRequest( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject deletedObjects() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.deletedObjects( Handle, CachedSelectors.deletedObjects, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject insertedObjects() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.insertedObjects( Handle, CachedSelectors.insertedObjects, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject lockedObjects() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.lockedObjects( Handle, CachedSelectors.lockedObjects, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setDeletedObjects_( NObjective.RuntimeObject objects ) {
			RuntimeObject ___occuredException;
			NativeMethods.setDeletedObjects_( Handle, CachedSelectors.setDeletedObjects_, out ___occuredException, sizeof( NObjective.RuntimeObject ), objects );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setInsertedObjects_( NObjective.RuntimeObject objects ) {
			RuntimeObject ___occuredException;
			NativeMethods.setInsertedObjects_( Handle, CachedSelectors.setInsertedObjects_, out ___occuredException, sizeof( NObjective.RuntimeObject ), objects );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setLockedObjects_( NObjective.RuntimeObject objects ) {
			RuntimeObject ___occuredException;
			NativeMethods.setLockedObjects_( Handle, CachedSelectors.setLockedObjects_, out ___occuredException, sizeof( NObjective.RuntimeObject ), objects );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setUpdatedObjects_( NObjective.RuntimeObject objects ) {
			RuntimeObject ___occuredException;
			NativeMethods.setUpdatedObjects_( Handle, CachedSelectors.setUpdatedObjects_, out ___occuredException, sizeof( NObjective.RuntimeObject ), objects );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject updatedObjects() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.updatedObjects( Handle, CachedSelectors.updatedObjects, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr deletedObjects( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr insertedObjects( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr lockedObjects( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setDeletedObjects_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject objects );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setInsertedObjects_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject objects );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setLockedObjects_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject objects );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setUpdatedObjects_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject objects );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr updatedObjects( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector deletedObjects = "deletedObjects";
			public static readonly Selector insertedObjects = "insertedObjects";
			public static readonly Selector lockedObjects = "lockedObjects";
			public static readonly Selector setDeletedObjects_ = "setDeletedObjects:";
			public static readonly Selector setInsertedObjects_ = "setInsertedObjects:";
			public static readonly Selector setLockedObjects_ = "setLockedObjects:";
			public static readonly Selector setUpdatedObjects_ = "setUpdatedObjects:";
			public static readonly Selector updatedObjects = "updatedObjects";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSSQLAdapter : IEquatable<NSSQLAdapter> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLAdapter;
		public static implicit operator IntPtr( NSSQLAdapter value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLAdapter value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLAdapter?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLAdapter value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLAdapter value1, NSSQLAdapter value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLAdapter value1, NSSQLAdapter value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLAdapter( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLAdapter alloc() {
			return new NSSQLAdapter( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject connections() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.connections( Handle, CachedSelectors.connections, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject createConnection() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.createConnection( Handle, CachedSelectors.createConnection, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject fetchedValueForDataValue_attribute_( NObjective.RuntimeObject value, NObjective.RuntimeObject attribute ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.fetchedValueForDataValue_attribute_( Handle, CachedSelectors.fetchedValueForDataValue_attribute_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), value, attribute );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject fetchedValueForDateValue_attribute_( NObjective.RuntimeObject value, NObjective.RuntimeObject attribute ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.fetchedValueForDateValue_attribute_( Handle, CachedSelectors.fetchedValueForDateValue_attribute_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), value, attribute );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject fetchedValueForNumberValue_attribute_( NObjective.RuntimeObject value, NObjective.RuntimeObject attribute ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.fetchedValueForNumberValue_attribute_( Handle, CachedSelectors.fetchedValueForNumberValue_attribute_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), value, attribute );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject fetchedValueForStringValue_attribute_( NObjective.RuntimeObject value, NObjective.RuntimeObject attribute ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.fetchedValueForStringValue_attribute_( Handle, CachedSelectors.fetchedValueForStringValue_attribute_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), value, attribute );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject fetchedValueForValue_attribute_( NObjective.RuntimeObject value, NObjective.RuntimeObject attribute ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.fetchedValueForValue_attribute_( Handle, CachedSelectors.fetchedValueForValue_attribute_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), value, attribute );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeClass generatorClass() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.generatorClass( Handle, CachedSelectors.generatorClass, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char hasOpenConnections() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.hasOpenConnections( Handle, CachedSelectors.hasOpenConnections, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NSSQLAdapter initWithSQLCore_( NObjective.RuntimeObject core ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithSQLCore_( Handle, CachedSelectors.initWithSQLCore_, out ___occuredException, sizeof( NObjective.RuntimeObject ), core );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSQLAdapter( ___result );
		}
		unsafe public NObjective.RuntimeObject newCountStatementWithFetchRequest_( NObjective.RuntimeObject request ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newCountStatementWithFetchRequest_( Handle, CachedSelectors.newCountStatementWithFetchRequest_, out ___occuredException, sizeof( NObjective.RuntimeObject ), request );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newCreateIndexStatementForColumn_( NObjective.RuntimeObject column ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newCreateIndexStatementForColumn_( Handle, CachedSelectors.newCreateIndexStatementForColumn_, out ___occuredException, sizeof( NObjective.RuntimeObject ), column );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newCreateIndexStatementForColumnWithName_inTableWithName_( NObjective.RuntimeObject name, NObjective.RuntimeObject inTableWithName ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newCreateIndexStatementForColumnWithName_inTableWithName_( Handle, CachedSelectors.newCreateIndexStatementForColumnWithName_inTableWithName_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), name, inTableWithName );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newCreateIndexStatementsForManyToMany_( NObjective.RuntimeObject many ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newCreateIndexStatementsForManyToMany_( Handle, CachedSelectors.newCreateIndexStatementsForManyToMany_, out ___occuredException, sizeof( NObjective.RuntimeObject ), many );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newCreatePrimaryKeyTableStatement() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newCreatePrimaryKeyTableStatement( Handle, CachedSelectors.newCreatePrimaryKeyTableStatement, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newCreateTableStatementForEntity_( NObjective.RuntimeObject entity ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newCreateTableStatementForEntity_( Handle, CachedSelectors.newCreateTableStatementForEntity_, out ___occuredException, sizeof( NObjective.RuntimeObject ), entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newCreateTableStatementForManyToMany_( NObjective.RuntimeObject many ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newCreateTableStatementForManyToMany_( Handle, CachedSelectors.newCreateTableStatementForManyToMany_, out ___occuredException, sizeof( NObjective.RuntimeObject ), many );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newDeleteStatementWithCorrelation_( NObjective.RuntimeObject correlation ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newDeleteStatementWithCorrelation_( Handle, CachedSelectors.newDeleteStatementWithCorrelation_, out ___occuredException, sizeof( NObjective.RuntimeObject ), correlation );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newDeleteStatementWithRow_( NObjective.RuntimeObject row ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newDeleteStatementWithRow_( Handle, CachedSelectors.newDeleteStatementWithRow_, out ___occuredException, sizeof( NObjective.RuntimeObject ), row );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newGeneratorWithStatement_( NObjective.RuntimeObject statement ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newGeneratorWithStatement_( Handle, CachedSelectors.newGeneratorWithStatement_, out ___occuredException, sizeof( NObjective.RuntimeObject ), statement );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newInsertStatementWithCorrelation_( NObjective.RuntimeObject correlation ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newInsertStatementWithCorrelation_( Handle, CachedSelectors.newInsertStatementWithCorrelation_, out ___occuredException, sizeof( NObjective.RuntimeObject ), correlation );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newInsertStatementWithRow_( NObjective.RuntimeObject row ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newInsertStatementWithRow_( Handle, CachedSelectors.newInsertStatementWithRow_, out ___occuredException, sizeof( NObjective.RuntimeObject ), row );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newPrimaryKeyInitializeStatementForEntity_withInitialMaxPK_( NObjective.RuntimeObject entity, long withInitialMaxPK ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newPrimaryKeyInitializeStatementForEntity_withInitialMaxPK_( Handle, CachedSelectors.newPrimaryKeyInitializeStatementForEntity_withInitialMaxPK_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( long ), entity, withInitialMaxPK );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newSelectStatementWithFetchRequest_( NObjective.RuntimeObject request ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newSelectStatementWithFetchRequest_( Handle, CachedSelectors.newSelectStatementWithFetchRequest_, out ___occuredException, sizeof( NObjective.RuntimeObject ), request );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newStatementWithEntity_( NObjective.RuntimeObject entity ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newStatementWithEntity_( Handle, CachedSelectors.newStatementWithEntity_, out ___occuredException, sizeof( NObjective.RuntimeObject ), entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newStatementWithoutEntity() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newStatementWithoutEntity( Handle, CachedSelectors.newStatementWithoutEntity, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newStatementWithSQLString_( NObjective.RuntimeObject @string ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newStatementWithSQLString_( Handle, CachedSelectors.newStatementWithSQLString_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @string );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newUpdateStatementWithRow_( NObjective.RuntimeObject row ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newUpdateStatementWithRow_( Handle, CachedSelectors.newUpdateStatementWithRow_, out ___occuredException, sizeof( NObjective.RuntimeObject ), row );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void registerConnection_( NObjective.RuntimeObject connection ) {
			RuntimeObject ___occuredException;
			NativeMethods.registerConnection_( Handle, CachedSelectors.registerConnection_, out ___occuredException, sizeof( NObjective.RuntimeObject ), connection );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject sqlCore() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sqlCore( Handle, CachedSelectors.sqlCore, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeClass statementClass() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.statementClass( Handle, CachedSelectors.statementClass, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject statementWithSQLString_( NObjective.RuntimeObject @string ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.statementWithSQLString_( Handle, CachedSelectors.statementWithSQLString_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @string );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject storeType() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.storeType( Handle, CachedSelectors.storeType, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char supportsCorrelatedSubqueries() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.supportsCorrelatedSubqueries( Handle, CachedSelectors.supportsCorrelatedSubqueries, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject typeStringForColumn_( NObjective.RuntimeObject column ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.typeStringForColumn_( Handle, CachedSelectors.typeStringForColumn_, out ___occuredException, sizeof( NObjective.RuntimeObject ), column );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void unregisterConnection_( NObjective.RuntimeObject connection ) {
			RuntimeObject ___occuredException;
			NativeMethods.unregisterConnection_( Handle, CachedSelectors.unregisterConnection_, out ___occuredException, sizeof( NObjective.RuntimeObject ), connection );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject url() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.url( Handle, CachedSelectors.url, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr connections( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr createConnection( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr fetchedValueForDataValue_attribute_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject value, NObjective.RuntimeObject attribute );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr fetchedValueForDateValue_attribute_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject value, NObjective.RuntimeObject attribute );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr fetchedValueForNumberValue_attribute_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject value, NObjective.RuntimeObject attribute );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr fetchedValueForStringValue_attribute_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject value, NObjective.RuntimeObject attribute );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr fetchedValueForValue_attribute_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject value, NObjective.RuntimeObject attribute );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern NObjective.RuntimeClass generatorClass( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char hasOpenConnections( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithSQLCore_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject core );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newCountStatementWithFetchRequest_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject request );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newCreateIndexStatementForColumn_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject column );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newCreateIndexStatementForColumnWithName_inTableWithName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name, NObjective.RuntimeObject inTableWithName );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newCreateIndexStatementsForManyToMany_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject many );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newCreatePrimaryKeyTableStatement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newCreateTableStatementForEntity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newCreateTableStatementForManyToMany_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject many );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newDeleteStatementWithCorrelation_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject correlation );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newDeleteStatementWithRow_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject row );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newGeneratorWithStatement_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject statement );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newInsertStatementWithCorrelation_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject correlation );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newInsertStatementWithRow_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject row );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newPrimaryKeyInitializeStatementForEntity_withInitialMaxPK_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity, long withInitialMaxPK );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newSelectStatementWithFetchRequest_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject request );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newStatementWithEntity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newStatementWithoutEntity( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newStatementWithSQLString_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @string );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newUpdateStatementWithRow_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject row );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void registerConnection_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject connection );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr sqlCore( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern NObjective.RuntimeClass statementClass( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr statementWithSQLString_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @string );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr storeType( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char supportsCorrelatedSubqueries( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr typeStringForColumn_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject column );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void unregisterConnection_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject connection );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr url( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector connections = "connections";
			public static readonly Selector createConnection = "createConnection";
			public static readonly Selector fetchedValueForDataValue_attribute_ = "fetchedValueForDataValue:attribute:";
			public static readonly Selector fetchedValueForDateValue_attribute_ = "fetchedValueForDateValue:attribute:";
			public static readonly Selector fetchedValueForNumberValue_attribute_ = "fetchedValueForNumberValue:attribute:";
			public static readonly Selector fetchedValueForStringValue_attribute_ = "fetchedValueForStringValue:attribute:";
			public static readonly Selector fetchedValueForValue_attribute_ = "fetchedValueForValue:attribute:";
			public static readonly Selector generatorClass = "generatorClass";
			public static readonly Selector hasOpenConnections = "hasOpenConnections";
			public static readonly Selector initWithSQLCore_ = "initWithSQLCore:";
			public static readonly Selector newCountStatementWithFetchRequest_ = "newCountStatementWithFetchRequest:";
			public static readonly Selector newCreateIndexStatementForColumn_ = "newCreateIndexStatementForColumn:";
			public static readonly Selector newCreateIndexStatementForColumnWithName_inTableWithName_ = "newCreateIndexStatementForColumnWithName:inTableWithName:";
			public static readonly Selector newCreateIndexStatementsForManyToMany_ = "newCreateIndexStatementsForManyToMany:";
			public static readonly Selector newCreatePrimaryKeyTableStatement = "newCreatePrimaryKeyTableStatement";
			public static readonly Selector newCreateTableStatementForEntity_ = "newCreateTableStatementForEntity:";
			public static readonly Selector newCreateTableStatementForManyToMany_ = "newCreateTableStatementForManyToMany:";
			public static readonly Selector newDeleteStatementWithCorrelation_ = "newDeleteStatementWithCorrelation:";
			public static readonly Selector newDeleteStatementWithRow_ = "newDeleteStatementWithRow:";
			public static readonly Selector newGeneratorWithStatement_ = "newGeneratorWithStatement:";
			public static readonly Selector newInsertStatementWithCorrelation_ = "newInsertStatementWithCorrelation:";
			public static readonly Selector newInsertStatementWithRow_ = "newInsertStatementWithRow:";
			public static readonly Selector newPrimaryKeyInitializeStatementForEntity_withInitialMaxPK_ = "newPrimaryKeyInitializeStatementForEntity:withInitialMaxPK:";
			public static readonly Selector newSelectStatementWithFetchRequest_ = "newSelectStatementWithFetchRequest:";
			public static readonly Selector newStatementWithEntity_ = "newStatementWithEntity:";
			public static readonly Selector newStatementWithoutEntity = "newStatementWithoutEntity";
			public static readonly Selector newStatementWithSQLString_ = "newStatementWithSQLString:";
			public static readonly Selector newUpdateStatementWithRow_ = "newUpdateStatementWithRow:";
			public static readonly Selector registerConnection_ = "registerConnection:";
			public static readonly Selector sqlCore = "sqlCore";
			public static readonly Selector statementClass = "statementClass";
			public static readonly Selector statementWithSQLString_ = "statementWithSQLString:";
			public static readonly Selector storeType = "storeType";
			public static readonly Selector supportsCorrelatedSubqueries = "supportsCorrelatedSubqueries";
			public static readonly Selector typeStringForColumn_ = "typeStringForColumn:";
			public static readonly Selector unregisterConnection_ = "unregisterConnection:";
			public static readonly Selector url = "url";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSSQLAdapterOperation : IEquatable<NSSQLAdapterOperation> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLAdapterOperation;
		public static implicit operator IntPtr( NSSQLAdapterOperation value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLAdapterOperation value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLAdapterOperation?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLAdapterOperation value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLAdapterOperation value1, NSSQLAdapterOperation value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLAdapterOperation value1, NSSQLAdapterOperation value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLAdapterOperation( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLAdapterOperation alloc() {
			return new NSSQLAdapterOperation( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public int adapterOperator() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.adapterOperator( Handle, CachedSelectors.adapterOperator, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public int compareAdapterOperation_( NObjective.RuntimeObject operation ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.compareAdapterOperation_( Handle, CachedSelectors.compareAdapterOperation_, out ___occuredException, sizeof( NObjective.RuntimeObject ), operation );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject correlation() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.correlation( Handle, CachedSelectors.correlation, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject entity() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entity( Handle, CachedSelectors.entity, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject exception() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.exception( Handle, CachedSelectors.exception, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSSQLAdapterOperation initWithAdapterOperator_correlation_( int @operator, NObjective.RuntimeObject correlation ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithAdapterOperator_correlation_( Handle, CachedSelectors.initWithAdapterOperator_correlation_, out ___occuredException, sizeof( int ) + sizeof( NObjective.RuntimeObject ), @operator, correlation );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSQLAdapterOperation( ___result );
		}
		unsafe public NSSQLAdapterOperation initWithAdapterOperator_row_( int @operator, NObjective.RuntimeObject row ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithAdapterOperator_row_( Handle, CachedSelectors.initWithAdapterOperator_row_, out ___occuredException, sizeof( int ) + sizeof( NObjective.RuntimeObject ), @operator, row );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSQLAdapterOperation( ___result );
		}
		unsafe public NObjective.RuntimeObject row() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.row( Handle, CachedSelectors.row, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setAdapterOperator_( int @operator ) {
			RuntimeObject ___occuredException;
			NativeMethods.setAdapterOperator_( Handle, CachedSelectors.setAdapterOperator_, out ___occuredException, sizeof( int ), @operator );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setException_( NObjective.RuntimeObject exception ) {
			RuntimeObject ___occuredException;
			NativeMethods.setException_( Handle, CachedSelectors.setException_, out ___occuredException, sizeof( NObjective.RuntimeObject ), exception );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int adapterOperator( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int compareAdapterOperation_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject operation );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr correlation( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr entity( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr exception( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithAdapterOperator_correlation_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int @operator, NObjective.RuntimeObject correlation );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithAdapterOperator_row_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int @operator, NObjective.RuntimeObject row );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr row( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setAdapterOperator_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int @operator );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setException_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject exception );
		}
		static internal class CachedSelectors {
			public static readonly Selector adapterOperator = "adapterOperator";
			public static readonly Selector compareAdapterOperation_ = "compareAdapterOperation:";
			public static readonly Selector correlation = "correlation";
			public static readonly Selector entity = "entity";
			public static readonly Selector exception = "exception";
			public static readonly Selector initWithAdapterOperator_correlation_ = "initWithAdapterOperator:correlation:";
			public static readonly Selector initWithAdapterOperator_row_ = "initWithAdapterOperator:row:";
			public static readonly Selector row = "row";
			public static readonly Selector setAdapterOperator_ = "setAdapterOperator:";
			public static readonly Selector setException_ = "setException:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSSQLColumn ) )]
	public struct NSSQLAttribute : IEquatable<NSSQLAttribute> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLAttribute;
		public static implicit operator IntPtr( NSSQLAttribute value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLAttribute value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLAttribute?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLAttribute value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLAttribute value1, NSSQLAttribute value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLAttribute value1, NSSQLAttribute value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLAttribute( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLAttribute alloc() {
			return new NSSQLAttribute( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject attributeDescription() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.attributeDescription( Handle, CachedSelectors.attributeDescription, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public bool shouldIndex() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.shouldIndex( Handle, CachedSelectors.shouldIndex, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr attributeDescription( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool shouldIndex( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector attributeDescription = "attributeDescription";
			public static readonly Selector shouldIndex = "shouldIndex";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSSQLBindVariable : IEquatable<NSSQLBindVariable> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLBindVariable;
		public static implicit operator IntPtr( NSSQLBindVariable value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLBindVariable value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLBindVariable?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLBindVariable value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLBindVariable value1, NSSQLBindVariable value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLBindVariable value1, NSSQLBindVariable value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLBindVariable( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLBindVariable alloc() {
			return new NSSQLBindVariable( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public char hasObjectValue() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.hasObjectValue( Handle, CachedSelectors.hasObjectValue, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public uint index() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.index( Handle, CachedSelectors.index, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public NSSQLBindVariable initWithInt64_sqlType_( long int64, int sqlType ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithInt64_sqlType_( Handle, CachedSelectors.initWithInt64_sqlType_, out ___occuredException, sizeof( long ) + sizeof( int ), int64, sqlType );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSQLBindVariable( ___result );
		}
		unsafe public NSSQLBindVariable initWithUnsignedInt_sqlType_( uint @int, int sqlType ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithUnsignedInt_sqlType_( Handle, CachedSelectors.initWithUnsignedInt_sqlType_, out ___occuredException, sizeof( uint ) + sizeof( int ), @int, sqlType );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSQLBindVariable( ___result );
		}
		unsafe public NSSQLBindVariable initWithValue_sqlType_( NObjective.RuntimeObject value, int sqlType ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithValue_sqlType_( Handle, CachedSelectors.initWithValue_sqlType_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( int ), value, sqlType );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSQLBindVariable( ___result );
		}
		unsafe public long int64() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.int64( Handle, CachedSelectors.int64, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void setIndex_( uint index ) {
			RuntimeObject ___occuredException;
			NativeMethods.setIndex_( Handle, CachedSelectors.setIndex_, out ___occuredException, sizeof( uint ), index );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setInt64_( long int64 ) {
			RuntimeObject ___occuredException;
			NativeMethods.setInt64_( Handle, CachedSelectors.setInt64_, out ___occuredException, sizeof( long ), int64 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setUnsignedInt_( uint @int ) {
			RuntimeObject ___occuredException;
			NativeMethods.setUnsignedInt_( Handle, CachedSelectors.setUnsignedInt_, out ___occuredException, sizeof( uint ), @int );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setValue_( NObjective.RuntimeObject value ) {
			RuntimeObject ___occuredException;
			NativeMethods.setValue_( Handle, CachedSelectors.setValue_, out ___occuredException, sizeof( NObjective.RuntimeObject ), value );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public int sqlType() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sqlType( Handle, CachedSelectors.sqlType, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public uint unsignedInt() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.unsignedInt( Handle, CachedSelectors.unsignedInt, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public NObjective.RuntimeObject value() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.value( Handle, CachedSelectors.value, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char hasObjectValue( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint index( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithInt64_sqlType_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, long int64, int sqlType );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithUnsignedInt_sqlType_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint @int, int sqlType );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithValue_sqlType_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject value, int sqlType );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern long int64( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint index );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setInt64_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, long int64 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setUnsignedInt_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint @int );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setValue_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject value );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int sqlType( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint unsignedInt( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr value( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector hasObjectValue = "hasObjectValue";
			public static readonly Selector index = "index";
			public static readonly Selector initWithInt64_sqlType_ = "initWithInt64:sqlType:";
			public static readonly Selector initWithUnsignedInt_sqlType_ = "initWithUnsignedInt:sqlType:";
			public static readonly Selector initWithValue_sqlType_ = "initWithValue:sqlType:";
			public static readonly Selector int64 = "int64";
			public static readonly Selector setIndex_ = "setIndex:";
			public static readonly Selector setInt64_ = "setInt64:";
			public static readonly Selector setUnsignedInt_ = "setUnsignedInt:";
			public static readonly Selector setValue_ = "setValue:";
			public static readonly Selector sqlType = "sqlType";
			public static readonly Selector unsignedInt = "unsignedInt";
			public static readonly Selector value = "value";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSSQLChannel : IEquatable<NSSQLChannel> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLChannel;
		public static implicit operator IntPtr( NSSQLChannel value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLChannel value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLChannel?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLChannel value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLChannel value1, NSSQLChannel value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLChannel value1, NSSQLChannel value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLChannel( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLChannel alloc() {
			return new NSSQLChannel( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject connection() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.connection( Handle, CachedSelectors.connection, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject currentContext() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.currentContext( Handle, CachedSelectors.currentContext, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void endFetch() {
			RuntimeObject ___occuredException;
			NativeMethods.endFetch( Handle, CachedSelectors.endFetch, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSSQLChannel initWithSQLCore_( NObjective.RuntimeObject core ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithSQLCore_( Handle, CachedSelectors.initWithSQLCore_, out ___occuredException, sizeof( NObjective.RuntimeObject ), core );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSQLChannel( ___result );
		}
		unsafe public bool isFetchInProgress() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isFetchInProgress( Handle, CachedSelectors.isFetchInProgress, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject newFetchedRowObjectIDsOnly_( char only ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newFetchedRowObjectIDsOnly_( Handle, CachedSelectors.newFetchedRowObjectIDsOnly_, out ___occuredException, sizeof( char ), only );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void selectCountWithFetchRequest_( NObjective.RuntimeObject request ) {
			RuntimeObject ___occuredException;
			NativeMethods.selectCountWithFetchRequest_( Handle, CachedSelectors.selectCountWithFetchRequest_, out ___occuredException, sizeof( NObjective.RuntimeObject ), request );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void selectRowsWithFetchRequest_( NObjective.RuntimeObject request ) {
			RuntimeObject ___occuredException;
			NativeMethods.selectRowsWithFetchRequest_( Handle, CachedSelectors.selectRowsWithFetchRequest_, out ___occuredException, sizeof( NObjective.RuntimeObject ), request );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void selectRowsWithStatement_( NObjective.RuntimeObject statement ) {
			RuntimeObject ___occuredException;
			NativeMethods.selectRowsWithStatement_( Handle, CachedSelectors.selectRowsWithStatement_, out ___occuredException, sizeof( NObjective.RuntimeObject ), statement );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setCurrentContext_( NObjective.RuntimeObject context ) {
			RuntimeObject ___occuredException;
			NativeMethods.setCurrentContext_( Handle, CachedSelectors.setCurrentContext_, out ___occuredException, sizeof( NObjective.RuntimeObject ), context );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setCurrentEntity_( NObjective.RuntimeObject entity ) {
			RuntimeObject ___occuredException;
			NativeMethods.setCurrentEntity_( Handle, CachedSelectors.setCurrentEntity_, out ___occuredException, sizeof( NObjective.RuntimeObject ), entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject sqlCore() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sqlCore( Handle, CachedSelectors.sqlCore, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr connection( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr currentContext( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void endFetch( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithSQLCore_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject core );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isFetchInProgress( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newFetchedRowObjectIDsOnly_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, char only );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void selectCountWithFetchRequest_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject request );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void selectRowsWithFetchRequest_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject request );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void selectRowsWithStatement_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject statement );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setCurrentContext_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject context );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setCurrentEntity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr sqlCore( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector connection = "connection";
			public static readonly Selector currentContext = "currentContext";
			public static readonly Selector endFetch = "endFetch";
			public static readonly Selector initWithSQLCore_ = "initWithSQLCore:";
			public static readonly Selector isFetchInProgress = "isFetchInProgress";
			public static readonly Selector newFetchedRowObjectIDsOnly_ = "newFetchedRowObjectIDsOnly:";
			public static readonly Selector selectCountWithFetchRequest_ = "selectCountWithFetchRequest:";
			public static readonly Selector selectRowsWithFetchRequest_ = "selectRowsWithFetchRequest:";
			public static readonly Selector selectRowsWithStatement_ = "selectRowsWithStatement:";
			public static readonly Selector setCurrentContext_ = "setCurrentContext:";
			public static readonly Selector setCurrentEntity_ = "setCurrentEntity:";
			public static readonly Selector sqlCore = "sqlCore";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSSQLProperty ) )]
	public struct NSSQLColumn : IEquatable<NSSQLColumn> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLColumn;
		public static implicit operator IntPtr( NSSQLColumn value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLColumn value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLColumn?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLColumn value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLColumn value1, NSSQLColumn value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLColumn value1, NSSQLColumn value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLColumn( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLColumn alloc() {
			return new NSSQLColumn( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public char allowAliasing() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.allowAliasing( Handle, CachedSelectors.allowAliasing, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public uint fetchIndex() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.fetchIndex( Handle, CachedSelectors.fetchIndex, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public NSSQLColumn initWithColumnName_sqlType_( NObjective.RuntimeObject name, int sqlType ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithColumnName_sqlType_( Handle, CachedSelectors.initWithColumnName_sqlType_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( int ), name, sqlType );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSQLColumn( ___result );
		}
		unsafe public uint precision() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.precision( Handle, CachedSelectors.precision, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public int scale() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.scale( Handle, CachedSelectors.scale, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void setAllowsAliasing_( char aliasing ) {
			RuntimeObject ___occuredException;
			NativeMethods.setAllowsAliasing_( Handle, CachedSelectors.setAllowsAliasing_, out ___occuredException, sizeof( char ), aliasing );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setPrecision_( uint precision ) {
			RuntimeObject ___occuredException;
			NativeMethods.setPrecision_( Handle, CachedSelectors.setPrecision_, out ___occuredException, sizeof( uint ), precision );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setScale_( int scale ) {
			RuntimeObject ___occuredException;
			NativeMethods.setScale_( Handle, CachedSelectors.setScale_, out ___occuredException, sizeof( int ), scale );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public int sqlType() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sqlType( Handle, CachedSelectors.sqlType, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char allowAliasing( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint fetchIndex( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithColumnName_sqlType_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name, int sqlType );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint precision( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int scale( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setAllowsAliasing_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, char aliasing );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setPrecision_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint precision );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setScale_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int scale );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int sqlType( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector allowAliasing = "allowAliasing";
			public static readonly Selector fetchIndex = "fetchIndex";
			public static readonly Selector initWithColumnName_sqlType_ = "initWithColumnName:sqlType:";
			public static readonly Selector precision = "precision";
			public static readonly Selector scale = "scale";
			public static readonly Selector setAllowsAliasing_ = "setAllowsAliasing:";
			public static readonly Selector setPrecision_ = "setPrecision:";
			public static readonly Selector setScale_ = "setScale:";
			public static readonly Selector sqlType = "sqlType";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSSQLConnection : IEquatable<NSSQLConnection> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLConnection;
		public static implicit operator IntPtr( NSSQLConnection value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLConnection value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLConnection?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLConnection value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLConnection value1, NSSQLConnection value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLConnection value1, NSSQLConnection value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLConnection( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLConnection alloc() {
			return new NSSQLConnection( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject adapter() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.adapter( Handle, CachedSelectors.adapter, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void awake() {
			RuntimeObject ___occuredException;
			NativeMethods.awake( Handle, CachedSelectors.awake, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void beginTransaction() {
			RuntimeObject ___occuredException;
			NativeMethods.beginTransaction( Handle, CachedSelectors.beginTransaction, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public char canConnect() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.canConnect( Handle, CachedSelectors.canConnect, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject columnsToFetch() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.columnsToFetch( Handle, CachedSelectors.columnsToFetch, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void commitTransaction() {
			RuntimeObject ___occuredException;
			NativeMethods.commitTransaction( Handle, CachedSelectors.commitTransaction, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void connect() {
			RuntimeObject ___occuredException;
			NativeMethods.connect( Handle, CachedSelectors.connect, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void createIndexesForAttributesOfEntity_( NObjective.RuntimeObject entity ) {
			RuntimeObject ___occuredException;
			NativeMethods.createIndexesForAttributesOfEntity_( Handle, CachedSelectors.createIndexesForAttributesOfEntity_, out ___occuredException, sizeof( NObjective.RuntimeObject ), entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void createIndexesForEntity_( NObjective.RuntimeObject entity ) {
			RuntimeObject ___occuredException;
			NativeMethods.createIndexesForEntity_( Handle, CachedSelectors.createIndexesForEntity_, out ___occuredException, sizeof( NObjective.RuntimeObject ), entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void createIndexesForForeignKeysOfEntity_( NObjective.RuntimeObject entity ) {
			RuntimeObject ___occuredException;
			NativeMethods.createIndexesForForeignKeysOfEntity_( Handle, CachedSelectors.createIndexesForForeignKeysOfEntity_, out ___occuredException, sizeof( NObjective.RuntimeObject ), entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void createManyToManyTablesForEntity_( NObjective.RuntimeObject entity ) {
			RuntimeObject ___occuredException;
			NativeMethods.createManyToManyTablesForEntity_( Handle, CachedSelectors.createManyToManyTablesForEntity_, out ___occuredException, sizeof( NObjective.RuntimeObject ), entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void createMetadata() {
			RuntimeObject ___occuredException;
			NativeMethods.createMetadata( Handle, CachedSelectors.createMetadata, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void createPrimaryKeyTableForModel_knownEmpty_( NObjective.RuntimeObject model, char knownEmpty ) {
			RuntimeObject ___occuredException;
			NativeMethods.createPrimaryKeyTableForModel_knownEmpty_( Handle, CachedSelectors.createPrimaryKeyTableForModel_knownEmpty_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( char ), model, knownEmpty );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void createSchema() {
			RuntimeObject ___occuredException;
			NativeMethods.createSchema( Handle, CachedSelectors.createSchema, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void createTableForEntity_( NObjective.RuntimeObject entity ) {
			RuntimeObject ___occuredException;
			NativeMethods.createTableForEntity_( Handle, CachedSelectors.createTableForEntity_, out ___occuredException, sizeof( NObjective.RuntimeObject ), entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void createTablesForEntities_( NObjective.RuntimeObject entities ) {
			RuntimeObject ___occuredException;
			NativeMethods.createTablesForEntities_( Handle, CachedSelectors.createTablesForEntities_, out ___occuredException, sizeof( NObjective.RuntimeObject ), entities );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public char databaseIsEmpty() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.databaseIsEmpty( Handle, CachedSelectors.databaseIsEmpty, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void deleteCorrelation_( NObjective.RuntimeObject correlation ) {
			RuntimeObject ___occuredException;
			NativeMethods.deleteCorrelation_( Handle, CachedSelectors.deleteCorrelation_, out ___occuredException, sizeof( NObjective.RuntimeObject ), correlation );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void deleteRow_( NObjective.RuntimeObject row ) {
			RuntimeObject ___occuredException;
			NativeMethods.deleteRow_( Handle, CachedSelectors.deleteRow_, out ___occuredException, sizeof( NObjective.RuntimeObject ), row );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject describeResults() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.describeResults( Handle, CachedSelectors.describeResults, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void didCreateSchema() {
			RuntimeObject ___occuredException;
			NativeMethods.didCreateSchema( Handle, CachedSelectors.didCreateSchema, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void disconnect() {
			RuntimeObject ___occuredException;
			NativeMethods.disconnect( Handle, CachedSelectors.disconnect, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void endFetch() {
			RuntimeObject ___occuredException;
			NativeMethods.endFetch( Handle, CachedSelectors.endFetch, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void endPrimaryKeyGeneration() {
			RuntimeObject ___occuredException;
			NativeMethods.endPrimaryKeyGeneration( Handle, CachedSelectors.endPrimaryKeyGeneration, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void execute() {
			RuntimeObject ___occuredException;
			NativeMethods.execute( Handle, CachedSelectors.execute, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public long fetchMaxPrimaryKeyForEntity_( NObjective.RuntimeObject entity ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.fetchMaxPrimaryKeyForEntity_( Handle, CachedSelectors.fetchMaxPrimaryKeyForEntity_, out ___occuredException, sizeof( NObjective.RuntimeObject ), entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject fetchMetadata() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.fetchMetadata( Handle, CachedSelectors.fetchMetadata, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject fetchTableNames() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.fetchTableNames( Handle, CachedSelectors.fetchTableNames, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void forceTransactionClosed() {
			RuntimeObject ___occuredException;
			NativeMethods.forceTransactionClosed( Handle, CachedSelectors.forceTransactionClosed, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public long generatePrimaryKeysForEntity_batch_( NObjective.RuntimeObject entity, uint batch ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.generatePrimaryKeysForEntity_batch_( Handle, CachedSelectors.generatePrimaryKeysForEntity_batch_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ), entity, batch );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char hasMetadataTable() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.hasMetadataTable( Handle, CachedSelectors.hasMetadataTable, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char hasOpenTransaction() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.hasOpenTransaction( Handle, CachedSelectors.hasOpenTransaction, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char hasPrimaryKeyTable() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.hasPrimaryKeyTable( Handle, CachedSelectors.hasPrimaryKeyTable, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NSSQLConnection initWithAdapter_( NObjective.RuntimeObject adapter ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithAdapter_( Handle, CachedSelectors.initWithAdapter_, out ___occuredException, sizeof( NObjective.RuntimeObject ), adapter );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSQLConnection( ___result );
		}
		unsafe public void insertCorrelation_( NObjective.RuntimeObject correlation ) {
			RuntimeObject ___occuredException;
			NativeMethods.insertCorrelation_( Handle, CachedSelectors.insertCorrelation_, out ___occuredException, sizeof( NObjective.RuntimeObject ), correlation );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void insertRow_( NObjective.RuntimeObject row ) {
			RuntimeObject ___occuredException;
			NativeMethods.insertRow_( Handle, CachedSelectors.insertRow_, out ___occuredException, sizeof( NObjective.RuntimeObject ), row );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public bool isFetchInProgress() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isFetchInProgress( Handle, CachedSelectors.isFetchInProgress, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isOpen() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isOpen( Handle, CachedSelectors.isOpen, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject metadataColumns() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.metadataColumns( Handle, CachedSelectors.metadataColumns, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newFetchedArray() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newFetchedArray( Handle, CachedSelectors.newFetchedArray, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newFetchedRowObjectIDOnly_( char only ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newFetchedRowObjectIDOnly_( Handle, CachedSelectors.newFetchedRowObjectIDOnly_, out ___occuredException, sizeof( char ), only );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void performAdapterOperation_( NObjective.RuntimeObject operation ) {
			RuntimeObject ___occuredException;
			NativeMethods.performAdapterOperation_( Handle, CachedSelectors.performAdapterOperation_, out ___occuredException, sizeof( NObjective.RuntimeObject ), operation );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void performAdapterOperations_( NObjective.RuntimeObject operations ) {
			RuntimeObject ___occuredException;
			NativeMethods.performAdapterOperations_( Handle, CachedSelectors.performAdapterOperations_, out ___occuredException, sizeof( NObjective.RuntimeObject ), operations );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void prepareAndExecuteSQLStatement_( NObjective.RuntimeObject statement ) {
			RuntimeObject ___occuredException;
			NativeMethods.prepareAndExecuteSQLStatement_( Handle, CachedSelectors.prepareAndExecuteSQLStatement_, out ___occuredException, sizeof( NObjective.RuntimeObject ), statement );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void prepareForPrimaryKeyGeneration() {
			RuntimeObject ___occuredException;
			NativeMethods.prepareForPrimaryKeyGeneration( Handle, CachedSelectors.prepareForPrimaryKeyGeneration, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void prepareSQLStatement_( NObjective.RuntimeObject statement ) {
			RuntimeObject ___occuredException;
			NativeMethods.prepareSQLStatement_( Handle, CachedSelectors.prepareSQLStatement_, out ___occuredException, sizeof( NObjective.RuntimeObject ), statement );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void releaseSQLStatement() {
			RuntimeObject ___occuredException;
			NativeMethods.releaseSQLStatement( Handle, CachedSelectors.releaseSQLStatement, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void resetSQLStatement() {
			RuntimeObject ___occuredException;
			NativeMethods.resetSQLStatement( Handle, CachedSelectors.resetSQLStatement, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void rollbackTransaction() {
			RuntimeObject ___occuredException;
			NativeMethods.rollbackTransaction( Handle, CachedSelectors.rollbackTransaction, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void saveMetadata_( NObjective.RuntimeObject metadata ) {
			RuntimeObject ___occuredException;
			NativeMethods.saveMetadata_( Handle, CachedSelectors.saveMetadata_, out ___occuredException, sizeof( NObjective.RuntimeObject ), metadata );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void selectAttributes_fetchRequest_lock_entity_( NObjective.RuntimeObject attributes, NObjective.RuntimeObject fetchRequest, char @lock, NObjective.RuntimeObject entity ) {
			RuntimeObject ___occuredException;
			NativeMethods.selectAttributes_fetchRequest_lock_entity_( Handle, CachedSelectors.selectAttributes_fetchRequest_lock_entity_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( char ) + sizeof( NObjective.RuntimeObject ), attributes, fetchRequest, @lock, entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setColumnsToFetch_( NObjective.RuntimeObject fetch ) {
			RuntimeObject ___occuredException;
			NativeMethods.setColumnsToFetch_( Handle, CachedSelectors.setColumnsToFetch_, out ___occuredException, sizeof( NObjective.RuntimeObject ), fetch );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void sleep() {
			RuntimeObject ___occuredException;
			NativeMethods.sleep( Handle, CachedSelectors.sleep, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject sqlStatement() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sqlStatement( Handle, CachedSelectors.sqlStatement, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void transactionDidBegin() {
			RuntimeObject ___occuredException;
			NativeMethods.transactionDidBegin( Handle, CachedSelectors.transactionDidBegin, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void transactionDidCommit() {
			RuntimeObject ___occuredException;
			NativeMethods.transactionDidCommit( Handle, CachedSelectors.transactionDidCommit, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void transactionDidRollback() {
			RuntimeObject ___occuredException;
			NativeMethods.transactionDidRollback( Handle, CachedSelectors.transactionDidRollback, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void updateRow_( NObjective.RuntimeObject row ) {
			RuntimeObject ___occuredException;
			NativeMethods.updateRow_( Handle, CachedSelectors.updateRow_, out ___occuredException, sizeof( NObjective.RuntimeObject ), row );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void willCreateSchema() {
			RuntimeObject ___occuredException;
			NativeMethods.willCreateSchema( Handle, CachedSelectors.willCreateSchema, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr adapter( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void awake( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void beginTransaction( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char canConnect( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr columnsToFetch( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void commitTransaction( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void connect( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void createIndexesForAttributesOfEntity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void createIndexesForEntity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void createIndexesForForeignKeysOfEntity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void createManyToManyTablesForEntity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void createMetadata( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void createPrimaryKeyTableForModel_knownEmpty_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject model, char knownEmpty );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void createSchema( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void createTableForEntity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void createTablesForEntities_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entities );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char databaseIsEmpty( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void deleteCorrelation_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject correlation );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void deleteRow_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject row );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr describeResults( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void didCreateSchema( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void disconnect( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void endFetch( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void endPrimaryKeyGeneration( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void execute( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern long fetchMaxPrimaryKeyForEntity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr fetchMetadata( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr fetchTableNames( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void forceTransactionClosed( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern long generatePrimaryKeysForEntity_batch_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity, uint batch );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char hasMetadataTable( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char hasOpenTransaction( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char hasPrimaryKeyTable( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithAdapter_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject adapter );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void insertCorrelation_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject correlation );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void insertRow_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject row );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isFetchInProgress( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isOpen( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr metadataColumns( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newFetchedArray( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newFetchedRowObjectIDOnly_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, char only );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void performAdapterOperation_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject operation );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void performAdapterOperations_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject operations );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void prepareAndExecuteSQLStatement_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject statement );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void prepareForPrimaryKeyGeneration( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void prepareSQLStatement_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject statement );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void releaseSQLStatement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void resetSQLStatement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void rollbackTransaction( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void saveMetadata_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject metadata );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void selectAttributes_fetchRequest_lock_entity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject attributes, NObjective.RuntimeObject fetchRequest, char @lock, NObjective.RuntimeObject entity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setColumnsToFetch_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject fetch );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void sleep( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr sqlStatement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void transactionDidBegin( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void transactionDidCommit( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void transactionDidRollback( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void updateRow_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject row );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void willCreateSchema( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector adapter = "adapter";
			public static readonly Selector awake = "awake";
			public static readonly Selector beginTransaction = "beginTransaction";
			public static readonly Selector canConnect = "canConnect";
			public static readonly Selector columnsToFetch = "columnsToFetch";
			public static readonly Selector commitTransaction = "commitTransaction";
			public static readonly Selector connect = "connect";
			public static readonly Selector createIndexesForAttributesOfEntity_ = "createIndexesForAttributesOfEntity:";
			public static readonly Selector createIndexesForEntity_ = "createIndexesForEntity:";
			public static readonly Selector createIndexesForForeignKeysOfEntity_ = "createIndexesForForeignKeysOfEntity:";
			public static readonly Selector createManyToManyTablesForEntity_ = "createManyToManyTablesForEntity:";
			public static readonly Selector createMetadata = "createMetadata";
			public static readonly Selector createPrimaryKeyTableForModel_knownEmpty_ = "createPrimaryKeyTableForModel:knownEmpty:";
			public static readonly Selector createSchema = "createSchema";
			public static readonly Selector createTableForEntity_ = "createTableForEntity:";
			public static readonly Selector createTablesForEntities_ = "createTablesForEntities:";
			public static readonly Selector databaseIsEmpty = "databaseIsEmpty";
			public static readonly Selector deleteCorrelation_ = "deleteCorrelation:";
			public static readonly Selector deleteRow_ = "deleteRow:";
			public static readonly Selector describeResults = "describeResults";
			public static readonly Selector didCreateSchema = "didCreateSchema";
			public static readonly Selector disconnect = "disconnect";
			public static readonly Selector endFetch = "endFetch";
			public static readonly Selector endPrimaryKeyGeneration = "endPrimaryKeyGeneration";
			public static readonly Selector execute = "execute";
			public static readonly Selector fetchMaxPrimaryKeyForEntity_ = "fetchMaxPrimaryKeyForEntity:";
			public static readonly Selector fetchMetadata = "fetchMetadata";
			public static readonly Selector fetchTableNames = "fetchTableNames";
			public static readonly Selector forceTransactionClosed = "forceTransactionClosed";
			public static readonly Selector generatePrimaryKeysForEntity_batch_ = "generatePrimaryKeysForEntity:batch:";
			public static readonly Selector hasMetadataTable = "hasMetadataTable";
			public static readonly Selector hasOpenTransaction = "hasOpenTransaction";
			public static readonly Selector hasPrimaryKeyTable = "hasPrimaryKeyTable";
			public static readonly Selector initWithAdapter_ = "initWithAdapter:";
			public static readonly Selector insertCorrelation_ = "insertCorrelation:";
			public static readonly Selector insertRow_ = "insertRow:";
			public static readonly Selector isFetchInProgress = "isFetchInProgress";
			public static readonly Selector isOpen = "isOpen";
			public static readonly Selector metadataColumns = "metadataColumns";
			public static readonly Selector newFetchedArray = "newFetchedArray";
			public static readonly Selector newFetchedRowObjectIDOnly_ = "newFetchedRowObjectIDOnly:";
			public static readonly Selector performAdapterOperation_ = "performAdapterOperation:";
			public static readonly Selector performAdapterOperations_ = "performAdapterOperations:";
			public static readonly Selector prepareAndExecuteSQLStatement_ = "prepareAndExecuteSQLStatement:";
			public static readonly Selector prepareForPrimaryKeyGeneration = "prepareForPrimaryKeyGeneration";
			public static readonly Selector prepareSQLStatement_ = "prepareSQLStatement:";
			public static readonly Selector releaseSQLStatement = "releaseSQLStatement";
			public static readonly Selector resetSQLStatement = "resetSQLStatement";
			public static readonly Selector rollbackTransaction = "rollbackTransaction";
			public static readonly Selector saveMetadata_ = "saveMetadata:";
			public static readonly Selector selectAttributes_fetchRequest_lock_entity_ = "selectAttributes:fetchRequest:lock:entity:";
			public static readonly Selector setColumnsToFetch_ = "setColumnsToFetch:";
			public static readonly Selector sleep = "sleep";
			public static readonly Selector sqlStatement = "sqlStatement";
			public static readonly Selector transactionDidBegin = "transactionDidBegin";
			public static readonly Selector transactionDidCommit = "transactionDidCommit";
			public static readonly Selector transactionDidRollback = "transactionDidRollback";
			public static readonly Selector updateRow_ = "updateRow:";
			public static readonly Selector willCreateSchema = "willCreateSchema";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObjectStore ) )]
	public struct NSSQLCore : IEquatable<NSSQLCore> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLCore;
		public static implicit operator IntPtr( NSSQLCore value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLCore value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLCore?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLCore value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLCore value1, NSSQLCore value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLCore value1, NSSQLCore value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLCore( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLCore alloc() {
			return new NSSQLCore( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static char coloredLoggingDefault() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.coloredLoggingDefault( ClassHandle, CachedSelectors.coloredLoggingDefault, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static int debugDefault() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.debugDefault( ClassHandle, CachedSelectors.debugDefault, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static void setColoredLoggingDefault_( char @default ) {
			RuntimeObject ___occuredException;
			NativeMethods.setColoredLoggingDefault_( ClassHandle, CachedSelectors.setColoredLoggingDefault_, out ___occuredException, sizeof( char ), @default );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static void setDebugDefault_( int @default ) {
			RuntimeObject ___occuredException;
			NativeMethods.setDebugDefault_( ClassHandle, CachedSelectors.setDebugDefault_, out ___occuredException, sizeof( int ), @default );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject adapter() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.adapter( Handle, CachedSelectors.adapter, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject availableChannel() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.availableChannel( Handle, CachedSelectors.availableChannel, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void beginTransaction() {
			RuntimeObject ___occuredException;
			NativeMethods.beginTransaction( Handle, CachedSelectors.beginTransaction, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject channels() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.channels( Handle, CachedSelectors.channels, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void commitChanges_( NObjective.RuntimeObject changes ) {
			RuntimeObject ___occuredException;
			NativeMethods.commitChanges_( Handle, CachedSelectors.commitChanges_, out ___occuredException, sizeof( NObjective.RuntimeObject ), changes );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void commitTransaction() {
			RuntimeObject ___occuredException;
			NativeMethods.commitTransaction( Handle, CachedSelectors.commitTransaction, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject connection() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.connection( Handle, CachedSelectors.connection, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject coordinator() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.coordinator( Handle, CachedSelectors.coordinator, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject countForFetchRequest_inContext_( NObjective.RuntimeObject request, NObjective.RuntimeObject inContext ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.countForFetchRequest_inContext_( Handle, CachedSelectors.countForFetchRequest_inContext_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), request, inContext );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void createAdapterOperationsForDatabaseOperation_( NObjective.RuntimeObject operation ) {
			RuntimeObject ___occuredException;
			NativeMethods.createAdapterOperationsForDatabaseOperation_( Handle, CachedSelectors.createAdapterOperationsForDatabaseOperation_, out ___occuredException, sizeof( NObjective.RuntimeObject ), operation );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject createChannel() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.createChannel( Handle, CachedSelectors.createChannel, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject currentContext() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.currentContext( Handle, CachedSelectors.currentContext, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject databaseOperationForGlobalID_( NObjective.RuntimeObject id ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.databaseOperationForGlobalID_( Handle, CachedSelectors.databaseOperationForGlobalID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject databaseOperationForObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.databaseOperationForObject_( Handle, CachedSelectors.databaseOperationForObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject databaseUUID() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.databaseUUID( Handle, CachedSelectors.databaseUUID, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public int debugLevel() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.debugLevel( Handle, CachedSelectors.debugLevel, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject entityForEntityDescription_( NObjective.RuntimeObject description ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entityForEntityDescription_( Handle, CachedSelectors.entityForEntityDescription_, out ___occuredException, sizeof( NObjective.RuntimeObject ), description );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject entityForFetchRequest_( NObjective.RuntimeObject request ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entityForFetchRequest_( Handle, CachedSelectors.entityForFetchRequest_, out ___occuredException, sizeof( NObjective.RuntimeObject ), request );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject entityForGlobalID_( NObjective.RuntimeObject id ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entityForGlobalID_( Handle, CachedSelectors.entityForGlobalID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject entityForObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entityForObject_( Handle, CachedSelectors.entityForObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject entityNameOrderingArrayForEntities_( NObjective.RuntimeObject entities ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entityNameOrderingArrayForEntities_( Handle, CachedSelectors.entityNameOrderingArrayForEntities_, out ___occuredException, sizeof( NObjective.RuntimeObject ), entities );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject fetchRowForObjectID_( NObjective.RuntimeObject id ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.fetchRowForObjectID_( Handle, CachedSelectors.fetchRowForObjectID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void forgetSnapshotForGlobalID_( NObjective.RuntimeObject id ) {
			RuntimeObject ___occuredException;
			NativeMethods.forgetSnapshotForGlobalID_( Handle, CachedSelectors.forgetSnapshotForGlobalID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void forgetSnapshotsForGlobalIDs_( NObjective.RuntimeObject ds ) {
			RuntimeObject ___occuredException;
			NativeMethods.forgetSnapshotsForGlobalIDs_( Handle, CachedSelectors.forgetSnapshotsForGlobalIDs_, out ___occuredException, sizeof( NObjective.RuntimeObject ), ds );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void generatePrimaryKeysForEntity_( NObjective.RuntimeObject entity ) {
			RuntimeObject ___occuredException;
			NativeMethods.generatePrimaryKeysForEntity_( Handle, CachedSelectors.generatePrimaryKeysForEntity_, out ___occuredException, sizeof( NObjective.RuntimeObject ), entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject hackQueryForManyToManyPrefetching_andSourceObjectIDs_( NObjective.RuntimeObject prefetching, NObjective.RuntimeObject andSourceObjectIDs ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.hackQueryForManyToManyPrefetching_andSourceObjectIDs_( Handle, CachedSelectors.hackQueryForManyToManyPrefetching_andSourceObjectIDs_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), prefetching, andSourceObjectIDs );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char handlesFetchRequest_( NObjective.RuntimeObject request ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.handlesFetchRequest_( Handle, CachedSelectors.handlesFetchRequest_, out ___occuredException, sizeof( NObjective.RuntimeObject ), request );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void insertEntity_intoOrderingArray_withDependencies_processingSet_( NObjective.RuntimeObject entity, NObjective.RuntimeObject intoOrderingArray, NObjective.RuntimeObject withDependencies, NObjective.RuntimeObject processingSet ) {
			RuntimeObject ___occuredException;
			NativeMethods.insertEntity_intoOrderingArray_withDependencies_processingSet_( Handle, CachedSelectors.insertEntity_intoOrderingArray_withDependencies_processingSet_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), entity, intoOrderingArray, withDependencies, processingSet );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void invalidateObjectsWithGlobalIDs_( NObjective.RuntimeObject ds ) {
			RuntimeObject ___occuredException;
			NativeMethods.invalidateObjectsWithGlobalIDs_( Handle, CachedSelectors.invalidateObjectsWithGlobalIDs_, out ___occuredException, sizeof( NObjective.RuntimeObject ), ds );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject localSnapshotForGlobalID_( NObjective.RuntimeObject id ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.localSnapshotForGlobalID_( Handle, CachedSelectors.localSnapshotForGlobalID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject missingObjectGlobalIDs() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.missingObjectGlobalIDs( Handle, CachedSelectors.missingObjectGlobalIDs, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject model() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.model( Handle, CachedSelectors.model, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newAdapterForModel_( NObjective.RuntimeObject model ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newAdapterForModel_( Handle, CachedSelectors.newAdapterForModel_, out ___occuredException, sizeof( NObjective.RuntimeObject ), model );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newFetchedPKsForObjectID_forManyToMany_( NObjective.RuntimeObject id, NObjective.RuntimeObject forManyToMany ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newFetchedPKsForObjectID_forManyToMany_( Handle, CachedSelectors.newFetchedPKsForObjectID_forManyToMany_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), id, forManyToMany );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newFetchedPKsForObjectID_forToMany_( NObjective.RuntimeObject id, NObjective.RuntimeObject forToMany ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newFetchedPKsForObjectID_forToMany_( Handle, CachedSelectors.newFetchedPKsForObjectID_forToMany_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), id, forToMany );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newForeignKeyID_entity_( long id, NObjective.RuntimeObject entity ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newForeignKeyID_entity_( Handle, CachedSelectors.newForeignKeyID_entity_, out ___occuredException, sizeof( long ) + sizeof( NObjective.RuntimeObject ), id, entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newObjectIDForEntity_pk_( NObjective.RuntimeObject entity, long pk ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newObjectIDForEntity_pk_( Handle, CachedSelectors.newObjectIDForEntity_pk_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( long ), entity, pk );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newObjectIDSetsForToManyPrefetchingRequest_andSourceObjectIDs_( NObjective.RuntimeObject request, NObjective.RuntimeObject andSourceObjectIDs ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newObjectIDSetsForToManyPrefetchingRequest_andSourceObjectIDs_( Handle, CachedSelectors.newObjectIDSetsForToManyPrefetchingRequest_andSourceObjectIDs_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), request, andSourceObjectIDs );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newObjectIDsForToManyFaultRequest_( NObjective.RuntimeObject request ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newObjectIDsForToManyFaultRequest_( Handle, CachedSelectors.newObjectIDsForToManyFaultRequest_, out ___occuredException, sizeof( NObjective.RuntimeObject ), request );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newRowsForFetchRequest_( NObjective.RuntimeObject request ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newRowsForFetchRequest_( Handle, CachedSelectors.newRowsForFetchRequest_, out ___occuredException, sizeof( NObjective.RuntimeObject ), request );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newRowsForStatment_( NObjective.RuntimeObject statment ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newRowsForStatment_( Handle, CachedSelectors.newRowsForStatment_, out ___occuredException, sizeof( NObjective.RuntimeObject ), statment );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject objectIDFactoryForSQLEntity_( NObjective.RuntimeObject entity ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectIDFactoryForSQLEntity_( Handle, CachedSelectors.objectIDFactoryForSQLEntity_, out ___occuredException, sizeof( NObjective.RuntimeObject ), entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject objectsForFetchRequest_inContext_( NObjective.RuntimeObject request, NObjective.RuntimeObject inContext ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectsForFetchRequest_inContext_( Handle, CachedSelectors.objectsForFetchRequest_inContext_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), request, inContext );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject orderAdapterOperations() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.orderAdapterOperations( Handle, CachedSelectors.orderAdapterOperations, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char ownsGlobalID_( NObjective.RuntimeObject id ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.ownsGlobalID_( Handle, CachedSelectors.ownsGlobalID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char ownsObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.ownsObject_( Handle, CachedSelectors.ownsObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void performChanges() {
			RuntimeObject ___occuredException;
			NativeMethods.performChanges( Handle, CachedSelectors.performChanges, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void prepareForSave_( NObjective.RuntimeObject save ) {
			RuntimeObject ___occuredException;
			NativeMethods.prepareForSave_( Handle, CachedSelectors.prepareForSave_, out ___occuredException, sizeof( NObjective.RuntimeObject ), save );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void processSnapshotForDatabaseOperation_( NObjective.RuntimeObject operation ) {
			RuntimeObject ___occuredException;
			NativeMethods.processSnapshotForDatabaseOperation_( Handle, CachedSelectors.processSnapshotForDatabaseOperation_, out ___occuredException, sizeof( NObjective.RuntimeObject ), operation );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject rawSQLTextForToManyFaultStatement_( NObjective.RuntimeObject statement ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.rawSQLTextForToManyFaultStatement_( Handle, CachedSelectors.rawSQLTextForToManyFaultStatement_, out ___occuredException, sizeof( NObjective.RuntimeObject ), statement );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void recordChangesInContext_( NObjective.RuntimeObject context ) {
			RuntimeObject ___occuredException;
			NativeMethods.recordChangesInContext_( Handle, CachedSelectors.recordChangesInContext_, out ___occuredException, sizeof( NObjective.RuntimeObject ), context );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void recordDatabaseOperation_( NObjective.RuntimeObject operation ) {
			RuntimeObject ___occuredException;
			NativeMethods.recordDatabaseOperation_( Handle, CachedSelectors.recordDatabaseOperation_, out ___occuredException, sizeof( NObjective.RuntimeObject ), operation );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void recordDeleteForObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			NativeMethods.recordDeleteForObject_( Handle, CachedSelectors.recordDeleteForObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void recordPrimaryKey_forInsertedObject_( long key, NObjective.RuntimeObject forInsertedObject ) {
			RuntimeObject ___occuredException;
			NativeMethods.recordPrimaryKey_forInsertedObject_( Handle, CachedSelectors.recordPrimaryKey_forInsertedObject_, out ___occuredException, sizeof( long ) + sizeof( NObjective.RuntimeObject ), key, forInsertedObject );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void recordSnapshot_forObjectID_( NObjective.RuntimeObject snapshot, NObjective.RuntimeObject forObjectID ) {
			RuntimeObject ___occuredException;
			NativeMethods.recordSnapshot_forObjectID_( Handle, CachedSelectors.recordSnapshot_forObjectID_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), snapshot, forObjectID );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void recordSnapshots_( NObjective.RuntimeObject snapshots ) {
			RuntimeObject ___occuredException;
			NativeMethods.recordSnapshots_( Handle, CachedSelectors.recordSnapshots_, out ___occuredException, sizeof( NObjective.RuntimeObject ), snapshots );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void recordToMany_forSourceObjectID_relationshipName_( NObjective.RuntimeObject many, NObjective.RuntimeObject forSourceObjectID, NObjective.RuntimeObject relationshipName ) {
			RuntimeObject ___occuredException;
			NativeMethods.recordToMany_forSourceObjectID_relationshipName_( Handle, CachedSelectors.recordToMany_forSourceObjectID_relationshipName_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), many, forSourceObjectID, relationshipName );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void recordToManyInsertsForObject_withOperation_( NObjective.RuntimeObject @object, NObjective.RuntimeObject withOperation ) {
			RuntimeObject ___occuredException;
			NativeMethods.recordToManyInsertsForObject_withOperation_( Handle, CachedSelectors.recordToManyInsertsForObject_withOperation_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), @object, withOperation );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void recordToManyUpdatesForObject_withOperation_( NObjective.RuntimeObject @object, NObjective.RuntimeObject withOperation ) {
			RuntimeObject ___occuredException;
			NativeMethods.recordToManyUpdatesForObject_withOperation_( Handle, CachedSelectors.recordToManyUpdatesForObject_withOperation_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), @object, withOperation );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void recordUpdateForObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			NativeMethods.recordUpdateForObject_( Handle, CachedSelectors.recordUpdateForObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void recordValuesForInsertedObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			NativeMethods.recordValuesForInsertedObject_( Handle, CachedSelectors.recordValuesForInsertedObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject refreshObjects_( NObjective.RuntimeObject objects ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.refreshObjects_( Handle, CachedSelectors.refreshObjects_, out ___occuredException, sizeof( NObjective.RuntimeObject ), objects );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void registerChannel_( NObjective.RuntimeObject channel ) {
			RuntimeObject ___occuredException;
			NativeMethods.registerChannel_( Handle, CachedSelectors.registerChannel_, out ___occuredException, sizeof( NObjective.RuntimeObject ), channel );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void rollbackChanges() {
			RuntimeObject ___occuredException;
			NativeMethods.rollbackChanges( Handle, CachedSelectors.rollbackChanges, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void rollbackTransaction() {
			RuntimeObject ___occuredException;
			NativeMethods.rollbackTransaction( Handle, CachedSelectors.rollbackTransaction, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject rowCache() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.rowCache( Handle, CachedSelectors.rowCache, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject rowForObjectID_( NObjective.RuntimeObject id ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.rowForObjectID_( Handle, CachedSelectors.rowForObjectID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject rowForObjectID_after_( NObjective.RuntimeObject id, double after ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.rowForObjectID_after_( Handle, CachedSelectors.rowForObjectID_after_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( double ), id, after );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject saveChanges_( NObjective.RuntimeObject changes ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.saveChanges_( Handle, CachedSelectors.saveChanges_, out ___occuredException, sizeof( NObjective.RuntimeObject ), changes );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setCurrentContext_( NObjective.RuntimeObject context ) {
			RuntimeObject ___occuredException;
			NativeMethods.setCurrentContext_( Handle, CachedSelectors.setCurrentContext_, out ___occuredException, sizeof( NObjective.RuntimeObject ), context );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setDatabaseUUID_( NObjective.RuntimeObject uuid ) {
			RuntimeObject ___occuredException;
			NativeMethods.setDatabaseUUID_( Handle, CachedSelectors.setDatabaseUUID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), uuid );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setDebugLevel_( int level ) {
			RuntimeObject ___occuredException;
			NativeMethods.setDebugLevel_( Handle, CachedSelectors.setDebugLevel_, out ___occuredException, sizeof( int ), level );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void unregisterChannel_( NObjective.RuntimeObject channel ) {
			RuntimeObject ___occuredException;
			NativeMethods.unregisterChannel_( Handle, CachedSelectors.unregisterChannel_, out ___occuredException, sizeof( NObjective.RuntimeObject ), channel );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr adapter( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr availableChannel( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void beginTransaction( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr channels( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char coloredLoggingDefault( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void commitChanges_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject changes );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void commitTransaction( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr connection( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr coordinator( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr countForFetchRequest_inContext_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject request, NObjective.RuntimeObject inContext );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void createAdapterOperationsForDatabaseOperation_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject operation );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr createChannel( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr currentContext( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr databaseOperationForGlobalID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr databaseOperationForObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr databaseUUID( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int debugDefault( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int debugLevel( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr entityForEntityDescription_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject description );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr entityForFetchRequest_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject request );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr entityForGlobalID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr entityForObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr entityNameOrderingArrayForEntities_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entities );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr fetchRowForObjectID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void forgetSnapshotForGlobalID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void forgetSnapshotsForGlobalIDs_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject ds );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void generatePrimaryKeysForEntity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr hackQueryForManyToManyPrefetching_andSourceObjectIDs_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject prefetching, NObjective.RuntimeObject andSourceObjectIDs );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char handlesFetchRequest_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject request );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void insertEntity_intoOrderingArray_withDependencies_processingSet_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity, NObjective.RuntimeObject intoOrderingArray, NObjective.RuntimeObject withDependencies, NObjective.RuntimeObject processingSet );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void invalidateObjectsWithGlobalIDs_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject ds );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr localSnapshotForGlobalID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr missingObjectGlobalIDs( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr model( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newAdapterForModel_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject model );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newFetchedPKsForObjectID_forManyToMany_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id, NObjective.RuntimeObject forManyToMany );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newFetchedPKsForObjectID_forToMany_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id, NObjective.RuntimeObject forToMany );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newForeignKeyID_entity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, long id, NObjective.RuntimeObject entity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newObjectIDForEntity_pk_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity, long pk );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newObjectIDSetsForToManyPrefetchingRequest_andSourceObjectIDs_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject request, NObjective.RuntimeObject andSourceObjectIDs );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newObjectIDsForToManyFaultRequest_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject request );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newRowsForFetchRequest_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject request );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newRowsForStatment_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject statment );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr objectIDFactoryForSQLEntity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr objectsForFetchRequest_inContext_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject request, NObjective.RuntimeObject inContext );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr orderAdapterOperations( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char ownsGlobalID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char ownsObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void performChanges( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void prepareForSave_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject save );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void processSnapshotForDatabaseOperation_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject operation );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr rawSQLTextForToManyFaultStatement_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject statement );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void recordChangesInContext_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject context );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void recordDatabaseOperation_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject operation );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void recordDeleteForObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void recordPrimaryKey_forInsertedObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, long key, NObjective.RuntimeObject forInsertedObject );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void recordSnapshot_forObjectID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject snapshot, NObjective.RuntimeObject forObjectID );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void recordSnapshots_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject snapshots );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void recordToMany_forSourceObjectID_relationshipName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject many, NObjective.RuntimeObject forSourceObjectID, NObjective.RuntimeObject relationshipName );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void recordToManyInsertsForObject_withOperation_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, NObjective.RuntimeObject withOperation );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void recordToManyUpdatesForObject_withOperation_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, NObjective.RuntimeObject withOperation );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void recordUpdateForObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void recordValuesForInsertedObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr refreshObjects_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject objects );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void registerChannel_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject channel );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void rollbackChanges( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void rollbackTransaction( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr rowCache( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr rowForObjectID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr rowForObjectID_after_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id, double after );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr saveChanges_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject changes );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setColoredLoggingDefault_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, char @default );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setCurrentContext_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject context );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setDatabaseUUID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject uuid );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setDebugDefault_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int @default );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setDebugLevel_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int level );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void unregisterChannel_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject channel );
		}
		static internal class CachedSelectors {
			public static readonly Selector adapter = "adapter";
			public static readonly Selector availableChannel = "availableChannel";
			public static readonly Selector beginTransaction = "beginTransaction";
			public static readonly Selector channels = "channels";
			public static readonly Selector coloredLoggingDefault = "coloredLoggingDefault";
			public static readonly Selector commitChanges_ = "commitChanges:";
			public static readonly Selector commitTransaction = "commitTransaction";
			public static readonly Selector connection = "connection";
			public static readonly Selector coordinator = "coordinator";
			public static readonly Selector countForFetchRequest_inContext_ = "countForFetchRequest:inContext:";
			public static readonly Selector createAdapterOperationsForDatabaseOperation_ = "createAdapterOperationsForDatabaseOperation:";
			public static readonly Selector createChannel = "createChannel";
			public static readonly Selector currentContext = "currentContext";
			public static readonly Selector databaseOperationForGlobalID_ = "databaseOperationForGlobalID:";
			public static readonly Selector databaseOperationForObject_ = "databaseOperationForObject:";
			public static readonly Selector databaseUUID = "databaseUUID";
			public static readonly Selector debugDefault = "debugDefault";
			public static readonly Selector debugLevel = "debugLevel";
			public static readonly Selector entityForEntityDescription_ = "entityForEntityDescription:";
			public static readonly Selector entityForFetchRequest_ = "entityForFetchRequest:";
			public static readonly Selector entityForGlobalID_ = "entityForGlobalID:";
			public static readonly Selector entityForObject_ = "entityForObject:";
			public static readonly Selector entityNameOrderingArrayForEntities_ = "entityNameOrderingArrayForEntities:";
			public static readonly Selector fetchRowForObjectID_ = "fetchRowForObjectID:";
			public static readonly Selector forgetSnapshotForGlobalID_ = "forgetSnapshotForGlobalID:";
			public static readonly Selector forgetSnapshotsForGlobalIDs_ = "forgetSnapshotsForGlobalIDs:";
			public static readonly Selector generatePrimaryKeysForEntity_ = "generatePrimaryKeysForEntity:";
			public static readonly Selector hackQueryForManyToManyPrefetching_andSourceObjectIDs_ = "hackQueryForManyToManyPrefetching:andSourceObjectIDs:";
			public static readonly Selector handlesFetchRequest_ = "handlesFetchRequest:";
			public static readonly Selector insertEntity_intoOrderingArray_withDependencies_processingSet_ = "insertEntity:intoOrderingArray:withDependencies:processingSet:";
			public static readonly Selector invalidateObjectsWithGlobalIDs_ = "invalidateObjectsWithGlobalIDs:";
			public static readonly Selector localSnapshotForGlobalID_ = "localSnapshotForGlobalID:";
			public static readonly Selector missingObjectGlobalIDs = "missingObjectGlobalIDs";
			public static readonly Selector model = "model";
			public static readonly Selector newAdapterForModel_ = "newAdapterForModel:";
			public static readonly Selector newFetchedPKsForObjectID_forManyToMany_ = "newFetchedPKsForObjectID:forManyToMany:";
			public static readonly Selector newFetchedPKsForObjectID_forToMany_ = "newFetchedPKsForObjectID:forToMany:";
			public static readonly Selector newForeignKeyID_entity_ = "newForeignKeyID:entity:";
			public static readonly Selector newObjectIDForEntity_pk_ = "newObjectIDForEntity:pk:";
			public static readonly Selector newObjectIDSetsForToManyPrefetchingRequest_andSourceObjectIDs_ = "newObjectIDSetsForToManyPrefetchingRequest:andSourceObjectIDs:";
			public static readonly Selector newObjectIDsForToManyFaultRequest_ = "newObjectIDsForToManyFaultRequest:";
			public static readonly Selector newRowsForFetchRequest_ = "newRowsForFetchRequest:";
			public static readonly Selector newRowsForStatment_ = "newRowsForStatment:";
			public static readonly Selector objectIDFactoryForSQLEntity_ = "objectIDFactoryForSQLEntity:";
			public static readonly Selector objectsForFetchRequest_inContext_ = "objectsForFetchRequest:inContext:";
			public static readonly Selector orderAdapterOperations = "orderAdapterOperations";
			public static readonly Selector ownsGlobalID_ = "ownsGlobalID:";
			public static readonly Selector ownsObject_ = "ownsObject:";
			public static readonly Selector performChanges = "performChanges";
			public static readonly Selector prepareForSave_ = "prepareForSave:";
			public static readonly Selector processSnapshotForDatabaseOperation_ = "processSnapshotForDatabaseOperation:";
			public static readonly Selector rawSQLTextForToManyFaultStatement_ = "rawSQLTextForToManyFaultStatement:";
			public static readonly Selector recordChangesInContext_ = "recordChangesInContext:";
			public static readonly Selector recordDatabaseOperation_ = "recordDatabaseOperation:";
			public static readonly Selector recordDeleteForObject_ = "recordDeleteForObject:";
			public static readonly Selector recordPrimaryKey_forInsertedObject_ = "recordPrimaryKey:forInsertedObject:";
			public static readonly Selector recordSnapshot_forObjectID_ = "recordSnapshot:forObjectID:";
			public static readonly Selector recordSnapshots_ = "recordSnapshots:";
			public static readonly Selector recordToMany_forSourceObjectID_relationshipName_ = "recordToMany:forSourceObjectID:relationshipName:";
			public static readonly Selector recordToManyInsertsForObject_withOperation_ = "recordToManyInsertsForObject:withOperation:";
			public static readonly Selector recordToManyUpdatesForObject_withOperation_ = "recordToManyUpdatesForObject:withOperation:";
			public static readonly Selector recordUpdateForObject_ = "recordUpdateForObject:";
			public static readonly Selector recordValuesForInsertedObject_ = "recordValuesForInsertedObject:";
			public static readonly Selector refreshObjects_ = "refreshObjects:";
			public static readonly Selector registerChannel_ = "registerChannel:";
			public static readonly Selector rollbackChanges = "rollbackChanges";
			public static readonly Selector rollbackTransaction = "rollbackTransaction";
			public static readonly Selector rowCache = "rowCache";
			public static readonly Selector rowForObjectID_ = "rowForObjectID:";
			public static readonly Selector rowForObjectID_after_ = "rowForObjectID:after:";
			public static readonly Selector saveChanges_ = "saveChanges:";
			public static readonly Selector setColoredLoggingDefault_ = "setColoredLoggingDefault:";
			public static readonly Selector setCurrentContext_ = "setCurrentContext:";
			public static readonly Selector setDatabaseUUID_ = "setDatabaseUUID:";
			public static readonly Selector setDebugDefault_ = "setDebugDefault:";
			public static readonly Selector setDebugLevel_ = "setDebugLevel:";
			public static readonly Selector unregisterChannel_ = "unregisterChannel:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSSQLCorrelation : IEquatable<NSSQLCorrelation> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLCorrelation;
		public static implicit operator IntPtr( NSSQLCorrelation value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLCorrelation value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLCorrelation?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLCorrelation value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLCorrelation value1, NSSQLCorrelation value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLCorrelation value1, NSSQLCorrelation value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLCorrelation( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLCorrelation alloc() {
			return new NSSQLCorrelation( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public long fk() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.fk( Handle, CachedSelectors.fk, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NSSQLCorrelation initWithManyToMany_fk_invfk_( NObjective.RuntimeObject many, long fk, long invfk ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithManyToMany_fk_invfk_( Handle, CachedSelectors.initWithManyToMany_fk_invfk_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( long ) + sizeof( long ), many, fk, invfk );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSQLCorrelation( ___result );
		}
		unsafe public long invfk() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.invfk( Handle, CachedSelectors.invfk, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject manyToMany() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.manyToMany( Handle, CachedSelectors.manyToMany, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern long fk( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithManyToMany_fk_invfk_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject many, long fk, long invfk );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern long invfk( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr manyToMany( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector fk = "fk";
			public static readonly Selector initWithManyToMany_fk_invfk_ = "initWithManyToMany:fk:invfk:";
			public static readonly Selector invfk = "invfk";
			public static readonly Selector manyToMany = "manyToMany";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSMapping ) )]
	public struct NSSQLEntity : IEquatable<NSSQLEntity> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLEntity;
		public static implicit operator IntPtr( NSSQLEntity value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLEntity value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLEntity?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLEntity value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLEntity value1, NSSQLEntity value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLEntity value1, NSSQLEntity value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLEntity( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLEntity alloc() {
			return new NSSQLEntity( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void addInsertedObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			NativeMethods.addInsertedObject_( Handle, CachedSelectors.addInsertedObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject attributeColumns() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.attributeColumns( Handle, CachedSelectors.attributeColumns, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject attributeNamed_( NObjective.RuntimeObject named ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.attributeNamed_( Handle, CachedSelectors.attributeNamed_, out ___occuredException, sizeof( NObjective.RuntimeObject ), named );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject attributes() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.attributes( Handle, CachedSelectors.attributes, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void cacheDeletionStatement_( NObjective.RuntimeObject statement ) {
			RuntimeObject ___occuredException;
			NativeMethods.cacheDeletionStatement_( Handle, CachedSelectors.cacheDeletionStatement_, out ___occuredException, sizeof( NObjective.RuntimeObject ), statement );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void cacheInsertStatement_( NObjective.RuntimeObject statement ) {
			RuntimeObject ___occuredException;
			NativeMethods.cacheInsertStatement_( Handle, CachedSelectors.cacheInsertStatement_, out ___occuredException, sizeof( NObjective.RuntimeObject ), statement );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void clearCachedStatements() {
			RuntimeObject ___occuredException;
			NativeMethods.clearCachedStatements( Handle, CachedSelectors.clearCachedStatements, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void clearInsertedObjects() {
			RuntimeObject ___occuredException;
			NativeMethods.clearInsertedObjects( Handle, CachedSelectors.clearInsertedObjects, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject columnsToFetch() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.columnsToFetch( Handle, CachedSelectors.columnsToFetch, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject deletionStatement() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.deletionStatement( Handle, CachedSelectors.deletionStatement, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject entityDescription() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entityDescription( Handle, CachedSelectors.entityDescription, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public uint entityID() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entityID( Handle, CachedSelectors.entityID, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public uint fetchIndexForKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.fetchIndexForKey_( Handle, CachedSelectors.fetchIndexForKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public NObjective.RuntimeObject foreignEntityKeyColumns() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.foreignEntityKeyColumns( Handle, CachedSelectors.foreignEntityKeyColumns, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject foreignKeyColumns() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.foreignKeyColumns( Handle, CachedSelectors.foreignKeyColumns, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char hasInheritance() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.hasInheritance( Handle, CachedSelectors.hasInheritance, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char hasSubentities() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.hasSubentities( Handle, CachedSelectors.hasSubentities, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NSSQLEntity initWithModel_entityDescription_( NObjective.RuntimeObject model, NObjective.RuntimeObject entityDescription ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithModel_entityDescription_( Handle, CachedSelectors.initWithModel_entityDescription_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), model, entityDescription );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSQLEntity( ___result );
		}
		unsafe public NObjective.RuntimeObject insertedObjects() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.insertedObjects( Handle, CachedSelectors.insertedObjects, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject insertStatement() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.insertStatement( Handle, CachedSelectors.insertStatement, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public bool isRootEntity() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isRootEntity( Handle, CachedSelectors.isRootEntity, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject manyToManyRelationships() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.manyToManyRelationships( Handle, CachedSelectors.manyToManyRelationships, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject mappingGenerator() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mappingGenerator( Handle, CachedSelectors.mappingGenerator, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject model() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.model( Handle, CachedSelectors.model, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject name() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.name( Handle, CachedSelectors.name, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public long nextPrimaryKey64() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.nextPrimaryKey64( Handle, CachedSelectors.nextPrimaryKey64, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject optLockKey() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.optLockKey( Handle, CachedSelectors.optLockKey, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject primaryKey() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.primaryKey( Handle, CachedSelectors.primaryKey, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject properties() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.properties( Handle, CachedSelectors.properties, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject propertiesByName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.propertiesByName( Handle, CachedSelectors.propertiesByName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject propertyNamed_( NObjective.RuntimeObject named ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.propertyNamed_( Handle, CachedSelectors.propertyNamed_, out ___occuredException, sizeof( NObjective.RuntimeObject ), named );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject relationshipNamed_( NObjective.RuntimeObject named ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.relationshipNamed_( Handle, CachedSelectors.relationshipNamed_, out ___occuredException, sizeof( NObjective.RuntimeObject ), named );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject rootEntity() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.rootEntity( Handle, CachedSelectors.rootEntity, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void seedPrimaryKey64_batch_( long key64, uint batch ) {
			RuntimeObject ___occuredException;
			NativeMethods.seedPrimaryKey64_batch_( Handle, CachedSelectors.seedPrimaryKey64_batch_, out ___occuredException, sizeof( long ) + sizeof( uint ), key64, batch );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setSubentities_( NObjective.RuntimeObject subentities ) {
			RuntimeObject ___occuredException;
			NativeMethods.setSubentities_( Handle, CachedSelectors.setSubentities_, out ___occuredException, sizeof( NObjective.RuntimeObject ), subentities );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setSuperentity_( NObjective.RuntimeObject superentity ) {
			RuntimeObject ___occuredException;
			NativeMethods.setSuperentity_( Handle, CachedSelectors.setSuperentity_, out ___occuredException, sizeof( NObjective.RuntimeObject ), superentity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject subentities() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.subentities( Handle, CachedSelectors.subentities, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject subentityKey() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.subentityKey( Handle, CachedSelectors.subentityKey, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public uint subentityMaxID() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.subentityMaxID( Handle, CachedSelectors.subentityMaxID, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public NObjective.RuntimeObject superentity() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.superentity( Handle, CachedSelectors.superentity, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject tableName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.tableName( Handle, CachedSelectors.tableName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject toManyRelationships() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.toManyRelationships( Handle, CachedSelectors.toManyRelationships, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void addInsertedObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr attributeColumns( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr attributeNamed_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject named );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr attributes( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void cacheDeletionStatement_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject statement );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void cacheInsertStatement_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject statement );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void clearCachedStatements( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void clearInsertedObjects( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr columnsToFetch( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr deletionStatement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr entityDescription( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint entityID( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint fetchIndexForKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr foreignEntityKeyColumns( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr foreignKeyColumns( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char hasInheritance( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char hasSubentities( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithModel_entityDescription_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject model, NObjective.RuntimeObject entityDescription );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr insertedObjects( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr insertStatement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isRootEntity( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr manyToManyRelationships( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr mappingGenerator( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr model( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr name( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern long nextPrimaryKey64( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr optLockKey( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr primaryKey( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr properties( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr propertiesByName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr propertyNamed_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject named );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr relationshipNamed_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject named );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr rootEntity( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void seedPrimaryKey64_batch_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, long key64, uint batch );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setSubentities_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject subentities );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setSuperentity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject superentity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr subentities( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr subentityKey( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint subentityMaxID( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr superentity( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr tableName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr toManyRelationships( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector addInsertedObject_ = "addInsertedObject:";
			public static readonly Selector attributeColumns = "attributeColumns";
			public static readonly Selector attributeNamed_ = "attributeNamed:";
			public static readonly Selector attributes = "attributes";
			public static readonly Selector cacheDeletionStatement_ = "cacheDeletionStatement:";
			public static readonly Selector cacheInsertStatement_ = "cacheInsertStatement:";
			public static readonly Selector clearCachedStatements = "clearCachedStatements";
			public static readonly Selector clearInsertedObjects = "clearInsertedObjects";
			public static readonly Selector columnsToFetch = "columnsToFetch";
			public static readonly Selector deletionStatement = "deletionStatement";
			public static readonly Selector entityDescription = "entityDescription";
			public static readonly Selector entityID = "entityID";
			public static readonly Selector fetchIndexForKey_ = "fetchIndexForKey:";
			public static readonly Selector foreignEntityKeyColumns = "foreignEntityKeyColumns";
			public static readonly Selector foreignKeyColumns = "foreignKeyColumns";
			public static readonly Selector hasInheritance = "hasInheritance";
			public static readonly Selector hasSubentities = "hasSubentities";
			public static readonly Selector initWithModel_entityDescription_ = "initWithModel:entityDescription:";
			public static readonly Selector insertedObjects = "insertedObjects";
			public static readonly Selector insertStatement = "insertStatement";
			public static readonly Selector isRootEntity = "isRootEntity";
			public static readonly Selector manyToManyRelationships = "manyToManyRelationships";
			public static readonly Selector mappingGenerator = "mappingGenerator";
			public static readonly Selector model = "model";
			public static readonly Selector name = "name";
			public static readonly Selector nextPrimaryKey64 = "nextPrimaryKey64";
			public static readonly Selector optLockKey = "optLockKey";
			public static readonly Selector primaryKey = "primaryKey";
			public static readonly Selector properties = "properties";
			public static readonly Selector propertiesByName = "propertiesByName";
			public static readonly Selector propertyNamed_ = "propertyNamed:";
			public static readonly Selector relationshipNamed_ = "relationshipNamed:";
			public static readonly Selector rootEntity = "rootEntity";
			public static readonly Selector seedPrimaryKey64_batch_ = "seedPrimaryKey64:batch:";
			public static readonly Selector setSubentities_ = "setSubentities:";
			public static readonly Selector setSuperentity_ = "setSuperentity:";
			public static readonly Selector subentities = "subentities";
			public static readonly Selector subentityKey = "subentityKey";
			public static readonly Selector subentityMaxID = "subentityMaxID";
			public static readonly Selector superentity = "superentity";
			public static readonly Selector tableName = "tableName";
			public static readonly Selector toManyRelationships = "toManyRelationships";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSSQLColumn ) )]
	public struct NSSQLEntityKey : IEquatable<NSSQLEntityKey> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLEntityKey;
		public static implicit operator IntPtr( NSSQLEntityKey value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLEntityKey value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLEntityKey?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLEntityKey value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLEntityKey value1, NSSQLEntityKey value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLEntityKey value1, NSSQLEntityKey value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLEntityKey( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLEntityKey alloc() {
			return new NSSQLEntityKey( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSSQLColumn ) )]
	public struct NSSQLForeignEntityKey : IEquatable<NSSQLForeignEntityKey> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLForeignEntityKey;
		public static implicit operator IntPtr( NSSQLForeignEntityKey value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLForeignEntityKey value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLForeignEntityKey?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLForeignEntityKey value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLForeignEntityKey value1, NSSQLForeignEntityKey value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLForeignEntityKey value1, NSSQLForeignEntityKey value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLForeignEntityKey( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLForeignEntityKey alloc() {
			return new NSSQLForeignEntityKey( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject foreignKey() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.foreignKey( Handle, CachedSelectors.foreignKey, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSSQLForeignEntityKey initWithEntity_foreignKey_( NObjective.RuntimeObject entity, NObjective.RuntimeObject foreignKey ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithEntity_foreignKey_( Handle, CachedSelectors.initWithEntity_foreignKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), entity, foreignKey );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSQLForeignEntityKey( ___result );
		}
		unsafe public NObjective.RuntimeObject toOneRelationship() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.toOneRelationship( Handle, CachedSelectors.toOneRelationship, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr foreignKey( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithEntity_foreignKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity, NObjective.RuntimeObject foreignKey );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr toOneRelationship( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector foreignKey = "foreignKey";
			public static readonly Selector initWithEntity_foreignKey_ = "initWithEntity:foreignKey:";
			public static readonly Selector toOneRelationship = "toOneRelationship";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSSQLColumn ) )]
	public struct NSSQLForeignKey : IEquatable<NSSQLForeignKey> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLForeignKey;
		public static implicit operator IntPtr( NSSQLForeignKey value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLForeignKey value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLForeignKey?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLForeignKey value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLForeignKey value1, NSSQLForeignKey value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLForeignKey value1, NSSQLForeignKey value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLForeignKey( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLForeignKey alloc() {
			return new NSSQLForeignKey( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NSSQLForeignKey initWithEntity_toOneRelationship_( NObjective.RuntimeObject entity, NObjective.RuntimeObject toOneRelationship ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithEntity_toOneRelationship_( Handle, CachedSelectors.initWithEntity_toOneRelationship_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), entity, toOneRelationship );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSQLForeignKey( ___result );
		}
		unsafe public NObjective.RuntimeObject toOneRelationship() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.toOneRelationship( Handle, CachedSelectors.toOneRelationship, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithEntity_toOneRelationship_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity, NObjective.RuntimeObject toOneRelationship );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr toOneRelationship( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithEntity_toOneRelationship_ = "initWithEntity:toOneRelationship:";
			public static readonly Selector toOneRelationship = "toOneRelationship";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSSQLGenerator : IEquatable<NSSQLGenerator> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLGenerator;
		public static implicit operator IntPtr( NSSQLGenerator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLGenerator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLGenerator?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLGenerator value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLGenerator value1, NSSQLGenerator value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLGenerator value1, NSSQLGenerator value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLGenerator( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLGenerator alloc() {
			return new NSSQLGenerator( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void addJoinForDirectToManyToMany_( NObjective.RuntimeObject many ) {
			RuntimeObject ___occuredException;
			NativeMethods.addJoinForDirectToManyToMany_( Handle, CachedSelectors.addJoinForDirectToManyToMany_, out ___occuredException, sizeof( NObjective.RuntimeObject ), many );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void addJoinForManyToManyRelationship_sourcePath_destinationPath_( NObjective.RuntimeObject relationship, NObjective.RuntimeObject sourcePath, NObjective.RuntimeObject destinationPath ) {
			RuntimeObject ___occuredException;
			NativeMethods.addJoinForManyToManyRelationship_sourcePath_destinationPath_( Handle, CachedSelectors.addJoinForManyToManyRelationship_sourcePath_destinationPath_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), relationship, sourcePath, destinationPath );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void addJoinForToManyRelationship_sourcePath_destinationPath_( NObjective.RuntimeObject relationship, NObjective.RuntimeObject sourcePath, NObjective.RuntimeObject destinationPath ) {
			RuntimeObject ___occuredException;
			NativeMethods.addJoinForToManyRelationship_sourcePath_destinationPath_( Handle, CachedSelectors.addJoinForToManyRelationship_sourcePath_destinationPath_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), relationship, sourcePath, destinationPath );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void addJoinForToOneRelationship_sourcePath_destinationPath_( NObjective.RuntimeObject relationship, NObjective.RuntimeObject sourcePath, NObjective.RuntimeObject destinationPath ) {
			RuntimeObject ___occuredException;
			NativeMethods.addJoinForToOneRelationship_sourcePath_destinationPath_( Handle, CachedSelectors.addJoinForToOneRelationship_sourcePath_destinationPath_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), relationship, sourcePath, destinationPath );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void appendClause_forKeyPath_allowToMany_( NObjective.RuntimeObject clause, NObjective.RuntimeObject forKeyPath, char allowToMany ) {
			RuntimeObject ___occuredException;
			NativeMethods.appendClause_forKeyPath_allowToMany_( Handle, CachedSelectors.appendClause_forKeyPath_allowToMany_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( char ), clause, forKeyPath, allowToMany );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void appendClause_forKeyPathExpression_allowToMany_( NObjective.RuntimeObject clause, NObjective.RuntimeObject forKeyPathExpression, char allowToMany ) {
			RuntimeObject ___occuredException;
			NativeMethods.appendClause_forKeyPathExpression_allowToMany_( Handle, CachedSelectors.appendClause_forKeyPathExpression_allowToMany_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( char ), clause, forKeyPathExpression, allowToMany );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void appendClause_forProperty_keypath_( NObjective.RuntimeObject clause, NObjective.RuntimeObject forProperty, NObjective.RuntimeObject keypath ) {
			RuntimeObject ___occuredException;
			NativeMethods.appendClause_forProperty_keypath_( Handle, CachedSelectors.appendClause_forProperty_keypath_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), clause, forProperty, keypath );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void appendCountClause_forToManyKeyPath_( NObjective.RuntimeObject clause, NObjective.RuntimeObject forToManyKeyPath ) {
			RuntimeObject ___occuredException;
			NativeMethods.appendCountClause_forToManyKeyPath_( Handle, CachedSelectors.appendCountClause_forToManyKeyPath_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), clause, forToManyKeyPath );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void appendJoinClauseToSQL() {
			RuntimeObject ___occuredException;
			NativeMethods.appendJoinClauseToSQL( Handle, CachedSelectors.appendJoinClauseToSQL, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void appendLimitClauseToSQL_( uint sql ) {
			RuntimeObject ___occuredException;
			NativeMethods.appendLimitClauseToSQL_( Handle, CachedSelectors.appendLimitClauseToSQL_, out ___occuredException, sizeof( uint ), sql );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void appendOrderByClauseToSQL() {
			RuntimeObject ___occuredException;
			NativeMethods.appendOrderByClauseToSQL( Handle, CachedSelectors.appendOrderByClauseToSQL, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void appendSelectListToSQLForRequest_( NObjective.RuntimeObject request ) {
			RuntimeObject ___occuredException;
			NativeMethods.appendSelectListToSQLForRequest_( Handle, CachedSelectors.appendSelectListToSQLForRequest_, out ___occuredException, sizeof( NObjective.RuntimeObject ), request );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void appendSQL_( NObjective.RuntimeObject sql ) {
			RuntimeObject ___occuredException;
			NativeMethods.appendSQL_( Handle, CachedSelectors.appendSQL_, out ___occuredException, sizeof( NObjective.RuntimeObject ), sql );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void appendWhereClause_( NObjective.RuntimeObject clause ) {
			RuntimeObject ___occuredException;
			NativeMethods.appendWhereClause_( Handle, CachedSelectors.appendWhereClause_, out ___occuredException, sizeof( NObjective.RuntimeObject ), clause );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void appendWhereClauseToSQL() {
			RuntimeObject ___occuredException;
			NativeMethods.appendWhereClauseToSQL( Handle, CachedSelectors.appendWhereClauseToSQL, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public char autoDistinct() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.autoDistinct( Handle, CachedSelectors.autoDistinct, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void buildOrderByClauseWithSortDescriptors_( NObjective.RuntimeObject descriptors ) {
			RuntimeObject ___occuredException;
			NativeMethods.buildOrderByClauseWithSortDescriptors_( Handle, CachedSelectors.buildOrderByClauseWithSortDescriptors_, out ___occuredException, sizeof( NObjective.RuntimeObject ), descriptors );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void buildWhereClauseForRow_optLock_( NObjective.RuntimeObject row, long optLock ) {
			RuntimeObject ___occuredException;
			NativeMethods.buildWhereClauseForRow_optLock_( Handle, CachedSelectors.buildWhereClauseForRow_optLock_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( long ), row, optLock );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void buildWhereClauseWithSelectPredicate_( NObjective.RuntimeObject predicate ) {
			RuntimeObject ___occuredException;
			NativeMethods.buildWhereClauseWithSelectPredicate_( Handle, CachedSelectors.buildWhereClauseWithSelectPredicate_, out ___occuredException, sizeof( NObjective.RuntimeObject ), predicate );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void buildWhereClauseWithSimplePredicate_( NObjective.RuntimeObject predicate ) {
			RuntimeObject ___occuredException;
			NativeMethods.buildWhereClauseWithSimplePredicate_( Handle, CachedSelectors.buildWhereClauseWithSimplePredicate_, out ___occuredException, sizeof( NObjective.RuntimeObject ), predicate );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public char foldComparisonPredicate_( NObjective.RuntimeObject predicate ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.foldComparisonPredicate_( Handle, CachedSelectors.foldComparisonPredicate_, out ___occuredException, sizeof( NObjective.RuntimeObject ), predicate );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NSSQLGenerator initWithStatement_forAdapter_( NObjective.RuntimeObject statement, NObjective.RuntimeObject forAdapter ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithStatement_forAdapter_( Handle, CachedSelectors.initWithStatement_forAdapter_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), statement, forAdapter );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSQLGenerator( ___result );
		}
		unsafe public bool isToManyCountKeyPath_( NObjective.RuntimeObject path ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isToManyCountKeyPath_( Handle, CachedSelectors.isToManyCountKeyPath_, out ___occuredException, sizeof( NObjective.RuntimeObject ), path );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void prepareBeginsWith_( NObjective.RuntimeObject with ) {
			RuntimeObject ___occuredException;
			NativeMethods.prepareBeginsWith_( Handle, CachedSelectors.prepareBeginsWith_, out ___occuredException, sizeof( NObjective.RuntimeObject ), with );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void prepareComparisonPredicate_( NObjective.RuntimeObject predicate ) {
			RuntimeObject ___occuredException;
			NativeMethods.prepareComparisonPredicate_( Handle, CachedSelectors.prepareComparisonPredicate_, out ___occuredException, sizeof( NObjective.RuntimeObject ), predicate );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void prepareCountStatementWithFetchRequest_( NObjective.RuntimeObject request ) {
			RuntimeObject ___occuredException;
			NativeMethods.prepareCountStatementWithFetchRequest_( Handle, CachedSelectors.prepareCountStatementWithFetchRequest_, out ___occuredException, sizeof( NObjective.RuntimeObject ), request );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void prepareDeleteStatementWithCorrelation_( NObjective.RuntimeObject correlation ) {
			RuntimeObject ___occuredException;
			NativeMethods.prepareDeleteStatementWithCorrelation_( Handle, CachedSelectors.prepareDeleteStatementWithCorrelation_, out ___occuredException, sizeof( NObjective.RuntimeObject ), correlation );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void prepareDeleteStatementWithRow_( NObjective.RuntimeObject row ) {
			RuntimeObject ___occuredException;
			NativeMethods.prepareDeleteStatementWithRow_( Handle, CachedSelectors.prepareDeleteStatementWithRow_, out ___occuredException, sizeof( NObjective.RuntimeObject ), row );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void prepareEndsWith_( NObjective.RuntimeObject with ) {
			RuntimeObject ___occuredException;
			NativeMethods.prepareEndsWith_( Handle, CachedSelectors.prepareEndsWith_, out ___occuredException, sizeof( NObjective.RuntimeObject ), with );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void prepareIn_( NObjective.RuntimeObject @in ) {
			RuntimeObject ___occuredException;
			NativeMethods.prepareIn_( Handle, CachedSelectors.prepareIn_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @in );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void prepareInsertStatementWithCorrelation_( NObjective.RuntimeObject correlation ) {
			RuntimeObject ___occuredException;
			NativeMethods.prepareInsertStatementWithCorrelation_( Handle, CachedSelectors.prepareInsertStatementWithCorrelation_, out ___occuredException, sizeof( NObjective.RuntimeObject ), correlation );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void prepareInsertStatementWithRow_( NObjective.RuntimeObject row ) {
			RuntimeObject ___occuredException;
			NativeMethods.prepareInsertStatementWithRow_( Handle, CachedSelectors.prepareInsertStatementWithRow_, out ___occuredException, sizeof( NObjective.RuntimeObject ), row );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void prepareLike_( NObjective.RuntimeObject like ) {
			RuntimeObject ___occuredException;
			NativeMethods.prepareLike_( Handle, CachedSelectors.prepareLike_, out ___occuredException, sizeof( NObjective.RuntimeObject ), like );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void prepareMatches_( NObjective.RuntimeObject matches ) {
			RuntimeObject ___occuredException;
			NativeMethods.prepareMatches_( Handle, CachedSelectors.prepareMatches_, out ___occuredException, sizeof( NObjective.RuntimeObject ), matches );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void prepareSelectStatementWithFetchRequest_( NObjective.RuntimeObject request ) {
			RuntimeObject ___occuredException;
			NativeMethods.prepareSelectStatementWithFetchRequest_( Handle, CachedSelectors.prepareSelectStatementWithFetchRequest_, out ___occuredException, sizeof( NObjective.RuntimeObject ), request );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void prepareUpdateStatementWithRow_originalRow_( NObjective.RuntimeObject row, NObjective.RuntimeObject originalRow ) {
			RuntimeObject ___occuredException;
			NativeMethods.prepareUpdateStatementWithRow_originalRow_( Handle, CachedSelectors.prepareUpdateStatementWithRow_originalRow_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), row, originalRow );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setAutoDistinct_( char distinct ) {
			RuntimeObject ___occuredException;
			NativeMethods.setAutoDistinct_( Handle, CachedSelectors.setAutoDistinct_, out ___occuredException, sizeof( char ), distinct );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject sqlString() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sqlString( Handle, CachedSelectors.sqlString, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public int sqlTypeForExpressionConstantValue_( NObjective.RuntimeObject value ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sqlTypeForExpressionConstantValue_( Handle, CachedSelectors.sqlTypeForExpressionConstantValue_, out ___occuredException, sizeof( NObjective.RuntimeObject ), value );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject whereClause() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.whereClause( Handle, CachedSelectors.whereClause, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void addJoinForDirectToManyToMany_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject many );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void addJoinForManyToManyRelationship_sourcePath_destinationPath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject relationship, NObjective.RuntimeObject sourcePath, NObjective.RuntimeObject destinationPath );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void addJoinForToManyRelationship_sourcePath_destinationPath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject relationship, NObjective.RuntimeObject sourcePath, NObjective.RuntimeObject destinationPath );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void addJoinForToOneRelationship_sourcePath_destinationPath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject relationship, NObjective.RuntimeObject sourcePath, NObjective.RuntimeObject destinationPath );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void appendClause_forKeyPath_allowToMany_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject clause, NObjective.RuntimeObject forKeyPath, char allowToMany );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void appendClause_forKeyPathExpression_allowToMany_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject clause, NObjective.RuntimeObject forKeyPathExpression, char allowToMany );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void appendClause_forProperty_keypath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject clause, NObjective.RuntimeObject forProperty, NObjective.RuntimeObject keypath );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void appendCountClause_forToManyKeyPath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject clause, NObjective.RuntimeObject forToManyKeyPath );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void appendJoinClauseToSQL( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void appendLimitClauseToSQL_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint sql );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void appendOrderByClauseToSQL( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void appendSelectListToSQLForRequest_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject request );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void appendSQL_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject sql );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void appendWhereClause_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject clause );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void appendWhereClauseToSQL( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char autoDistinct( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void buildOrderByClauseWithSortDescriptors_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject descriptors );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void buildWhereClauseForRow_optLock_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject row, long optLock );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void buildWhereClauseWithSelectPredicate_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject predicate );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void buildWhereClauseWithSimplePredicate_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject predicate );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char foldComparisonPredicate_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject predicate );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithStatement_forAdapter_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject statement, NObjective.RuntimeObject forAdapter );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isToManyCountKeyPath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject path );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void prepareBeginsWith_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject with );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void prepareComparisonPredicate_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject predicate );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void prepareCountStatementWithFetchRequest_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject request );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void prepareDeleteStatementWithCorrelation_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject correlation );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void prepareDeleteStatementWithRow_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject row );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void prepareEndsWith_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject with );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void prepareIn_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @in );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void prepareInsertStatementWithCorrelation_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject correlation );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void prepareInsertStatementWithRow_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject row );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void prepareLike_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject like );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void prepareMatches_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject matches );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void prepareSelectStatementWithFetchRequest_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject request );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void prepareUpdateStatementWithRow_originalRow_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject row, NObjective.RuntimeObject originalRow );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setAutoDistinct_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, char distinct );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr sqlString( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int sqlTypeForExpressionConstantValue_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject value );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr whereClause( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector addJoinForDirectToManyToMany_ = "addJoinForDirectToManyToMany:";
			public static readonly Selector addJoinForManyToManyRelationship_sourcePath_destinationPath_ = "addJoinForManyToManyRelationship:sourcePath:destinationPath:";
			public static readonly Selector addJoinForToManyRelationship_sourcePath_destinationPath_ = "addJoinForToManyRelationship:sourcePath:destinationPath:";
			public static readonly Selector addJoinForToOneRelationship_sourcePath_destinationPath_ = "addJoinForToOneRelationship:sourcePath:destinationPath:";
			public static readonly Selector appendClause_forKeyPath_allowToMany_ = "appendClause:forKeyPath:allowToMany:";
			public static readonly Selector appendClause_forKeyPathExpression_allowToMany_ = "appendClause:forKeyPathExpression:allowToMany:";
			public static readonly Selector appendClause_forProperty_keypath_ = "appendClause:forProperty:keypath:";
			public static readonly Selector appendCountClause_forToManyKeyPath_ = "appendCountClause:forToManyKeyPath:";
			public static readonly Selector appendJoinClauseToSQL = "appendJoinClauseToSQL";
			public static readonly Selector appendLimitClauseToSQL_ = "appendLimitClauseToSQL:";
			public static readonly Selector appendOrderByClauseToSQL = "appendOrderByClauseToSQL";
			public static readonly Selector appendSelectListToSQLForRequest_ = "appendSelectListToSQLForRequest:";
			public static readonly Selector appendSQL_ = "appendSQL:";
			public static readonly Selector appendWhereClause_ = "appendWhereClause:";
			public static readonly Selector appendWhereClauseToSQL = "appendWhereClauseToSQL";
			public static readonly Selector autoDistinct = "autoDistinct";
			public static readonly Selector buildOrderByClauseWithSortDescriptors_ = "buildOrderByClauseWithSortDescriptors:";
			public static readonly Selector buildWhereClauseForRow_optLock_ = "buildWhereClauseForRow:optLock:";
			public static readonly Selector buildWhereClauseWithSelectPredicate_ = "buildWhereClauseWithSelectPredicate:";
			public static readonly Selector buildWhereClauseWithSimplePredicate_ = "buildWhereClauseWithSimplePredicate:";
			public static readonly Selector foldComparisonPredicate_ = "foldComparisonPredicate:";
			public static readonly Selector initWithStatement_forAdapter_ = "initWithStatement:forAdapter:";
			public static readonly Selector isToManyCountKeyPath_ = "isToManyCountKeyPath:";
			public static readonly Selector prepareBeginsWith_ = "prepareBeginsWith:";
			public static readonly Selector prepareComparisonPredicate_ = "prepareComparisonPredicate:";
			public static readonly Selector prepareCountStatementWithFetchRequest_ = "prepareCountStatementWithFetchRequest:";
			public static readonly Selector prepareDeleteStatementWithCorrelation_ = "prepareDeleteStatementWithCorrelation:";
			public static readonly Selector prepareDeleteStatementWithRow_ = "prepareDeleteStatementWithRow:";
			public static readonly Selector prepareEndsWith_ = "prepareEndsWith:";
			public static readonly Selector prepareIn_ = "prepareIn:";
			public static readonly Selector prepareInsertStatementWithCorrelation_ = "prepareInsertStatementWithCorrelation:";
			public static readonly Selector prepareInsertStatementWithRow_ = "prepareInsertStatementWithRow:";
			public static readonly Selector prepareLike_ = "prepareLike:";
			public static readonly Selector prepareMatches_ = "prepareMatches:";
			public static readonly Selector prepareSelectStatementWithFetchRequest_ = "prepareSelectStatementWithFetchRequest:";
			public static readonly Selector prepareUpdateStatementWithRow_originalRow_ = "prepareUpdateStatementWithRow:originalRow:";
			public static readonly Selector setAutoDistinct_ = "setAutoDistinct:";
			public static readonly Selector sqlString = "sqlString";
			public static readonly Selector sqlTypeForExpressionConstantValue_ = "sqlTypeForExpressionConstantValue:";
			public static readonly Selector whereClause = "whereClause";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSSQLAdapter ) )]
	public struct NSSQLiteAdapter : IEquatable<NSSQLiteAdapter> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLiteAdapter;
		public static implicit operator IntPtr( NSSQLiteAdapter value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLiteAdapter value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLiteAdapter?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLiteAdapter value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLiteAdapter value1, NSSQLiteAdapter value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLiteAdapter value1, NSSQLiteAdapter value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLiteAdapter( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLiteAdapter alloc() {
			return new NSSQLiteAdapter( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject pathnameForDatabase() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.pathnameForDatabase( Handle, CachedSelectors.pathnameForDatabase, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject sqliteVersion() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sqliteVersion( Handle, CachedSelectors.sqliteVersion, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr pathnameForDatabase( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr sqliteVersion( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector pathnameForDatabase = "pathnameForDatabase";
			public static readonly Selector sqliteVersion = "sqliteVersion";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSSQLConnection ) )]
	public struct NSSQLiteConnection : IEquatable<NSSQLiteConnection> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLiteConnection;
		public static implicit operator IntPtr( NSSQLiteConnection value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLiteConnection value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLiteConnection?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLiteConnection value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLiteConnection value1, NSSQLiteConnection value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLiteConnection value1, NSSQLiteConnection value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLiteConnection( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLiteConnection alloc() {
			return new NSSQLiteConnection( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSSQLStatement ) )]
	public struct NSSQLiteStatement : IEquatable<NSSQLiteStatement> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLiteStatement;
		public static implicit operator IntPtr( NSSQLiteStatement value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLiteStatement value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLiteStatement?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLiteStatement value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLiteStatement value1, NSSQLiteStatement value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLiteStatement value1, NSSQLiteStatement value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLiteStatement( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLiteStatement alloc() {
			return new NSSQLiteStatement( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSSQLRelationship ) )]
	public struct NSSQLManyToMany : IEquatable<NSSQLManyToMany> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLManyToMany;
		public static implicit operator IntPtr( NSSQLManyToMany value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLManyToMany value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLManyToMany?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLManyToMany value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLManyToMany value1, NSSQLManyToMany value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLManyToMany value1, NSSQLManyToMany value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLManyToMany( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLManyToMany alloc() {
			return new NSSQLManyToMany( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject inverseColumnName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.inverseColumnName( Handle, CachedSelectors.inverseColumnName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject inverseManyToMany() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.inverseManyToMany( Handle, CachedSelectors.inverseManyToMany, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public bool isMaster() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isMaster( Handle, CachedSelectors.isMaster, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isReflexive() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isReflexive( Handle, CachedSelectors.isReflexive, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr inverseColumnName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr inverseManyToMany( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isMaster( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isReflexive( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector inverseColumnName = "inverseColumnName";
			public static readonly Selector inverseManyToMany = "inverseManyToMany";
			public static readonly Selector isMaster = "isMaster";
			public static readonly Selector isReflexive = "isReflexive";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSSQLMappingGenerator : IEquatable<NSSQLMappingGenerator> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLMappingGenerator;
		public static implicit operator IntPtr( NSSQLMappingGenerator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLMappingGenerator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLMappingGenerator?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLMappingGenerator value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLMappingGenerator value1, NSSQLMappingGenerator value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLMappingGenerator value1, NSSQLMappingGenerator value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLMappingGenerator( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLMappingGenerator alloc() {
			return new NSSQLMappingGenerator( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject defaultMappingGenerator() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.defaultMappingGenerator( ClassHandle, CachedSelectors.defaultMappingGenerator, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject generatePropertyName_( NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.generatePropertyName_( Handle, CachedSelectors.generatePropertyName_, out ___occuredException, sizeof( NObjective.RuntimeObject ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject generateTableName_( NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.generateTableName_( Handle, CachedSelectors.generateTableName_, out ___occuredException, sizeof( NObjective.RuntimeObject ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject uniqueNameWithBase_( NObjective.RuntimeObject @base ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.uniqueNameWithBase_( Handle, CachedSelectors.uniqueNameWithBase_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @base );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr defaultMappingGenerator( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr generatePropertyName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr generateTableName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr uniqueNameWithBase_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @base );
		}
		static internal class CachedSelectors {
			public static readonly Selector defaultMappingGenerator = "defaultMappingGenerator";
			public static readonly Selector generatePropertyName_ = "generatePropertyName:";
			public static readonly Selector generateTableName_ = "generateTableName:";
			public static readonly Selector uniqueNameWithBase_ = "uniqueNameWithBase:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSMapping ) )]
	public struct NSSQLModel : IEquatable<NSSQLModel> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLModel;
		public static implicit operator IntPtr( NSSQLModel value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLModel value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLModel?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLModel value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLModel value1, NSSQLModel value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLModel value1, NSSQLModel value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLModel( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLModel alloc() {
			return new NSSQLModel( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject configurationName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.configurationName( Handle, CachedSelectors.configurationName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject entities() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entities( Handle, CachedSelectors.entities, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject entityForID_( uint id ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entityForID_( Handle, CachedSelectors.entityForID_, out ___occuredException, sizeof( uint ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public uint entityIDForName_( NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entityIDForName_( Handle, CachedSelectors.entityIDForName_, out ___occuredException, sizeof( NObjective.RuntimeObject ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public NObjective.RuntimeObject entityNamed_( NObjective.RuntimeObject named ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entityNamed_( Handle, CachedSelectors.entityNamed_, out ___occuredException, sizeof( NObjective.RuntimeObject ), named );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSSQLModel initWithManagedObjectModel_configurationName_( NObjective.RuntimeObject model, NObjective.RuntimeObject configurationName ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithManagedObjectModel_configurationName_( Handle, CachedSelectors.initWithManagedObjectModel_configurationName_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), model, configurationName );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSQLModel( ___result );
		}
		unsafe public NObjective.RuntimeObject managedObjectModel() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.managedObjectModel( Handle, CachedSelectors.managedObjectModel, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr configurationName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr entities( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr entityForID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint id );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint entityIDForName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr entityNamed_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject named );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithManagedObjectModel_configurationName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject model, NObjective.RuntimeObject configurationName );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr managedObjectModel( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector configurationName = "configurationName";
			public static readonly Selector entities = "entities";
			public static readonly Selector entityForID_ = "entityForID:";
			public static readonly Selector entityIDForName_ = "entityIDForName:";
			public static readonly Selector entityNamed_ = "entityNamed:";
			public static readonly Selector initWithManagedObjectModel_configurationName_ = "initWithManagedObjectModel:configurationName:";
			public static readonly Selector managedObjectModel = "managedObjectModel";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSBasicObjectID ) )]
	public struct NSSQLObjectID : IEquatable<NSSQLObjectID> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLObjectID;
		public static implicit operator IntPtr( NSSQLObjectID value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLObjectID value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLObjectID?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLObjectID value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLObjectID value1, NSSQLObjectID value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLObjectID value1, NSSQLObjectID value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLObjectID( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLObjectID alloc() {
			return new NSSQLObjectID( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSSQLCore ) )]
	public struct NSSQLObjectStore : IEquatable<NSSQLObjectStore> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLObjectStore;
		public static implicit operator IntPtr( NSSQLObjectStore value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLObjectStore value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLObjectStore?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLObjectStore value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLObjectStore value1, NSSQLObjectStore value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLObjectStore value1, NSSQLObjectStore value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLObjectStore( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLObjectStore alloc() {
			return new NSSQLObjectStore( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject mappingGenerator() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mappingGenerator( Handle, CachedSelectors.mappingGenerator, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr mappingGenerator( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector mappingGenerator = "mappingGenerator";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSSQLOperation : IEquatable<NSSQLOperation> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLOperation;
		public static implicit operator IntPtr( NSSQLOperation value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLOperation value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLOperation?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLOperation value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLOperation value1, NSSQLOperation value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLOperation value1, NSSQLOperation value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLOperation( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLOperation alloc() {
			return new NSSQLOperation( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject adapterOperations() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.adapterOperations( Handle, CachedSelectors.adapterOperations, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void addAdapterOperation_( NObjective.RuntimeObject operation ) {
			RuntimeObject ___occuredException;
			NativeMethods.addAdapterOperation_( Handle, CachedSelectors.addAdapterOperation_, out ___occuredException, sizeof( NObjective.RuntimeObject ), operation );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void addDelta_forManyToManyKey_( NObjective.RuntimeObject delta, NObjective.RuntimeObject forManyToManyKey ) {
			RuntimeObject ___occuredException;
			NativeMethods.addDelta_forManyToManyKey_( Handle, CachedSelectors.addDelta_forManyToManyKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), delta, forManyToManyKey );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public int databaseOperator() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.databaseOperator( Handle, CachedSelectors.databaseOperator, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject dbSnapshot() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dbSnapshot( Handle, CachedSelectors.dbSnapshot, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject entity() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entity( Handle, CachedSelectors.entity, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSSQLOperation initWithObject_entity_( NObjective.RuntimeObject @object, NObjective.RuntimeObject entity ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithObject_entity_( Handle, CachedSelectors.initWithObject_entity_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), @object, entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSQLOperation( ___result );
		}
		unsafe public NObjective.RuntimeObject manyToManyDeltas() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.manyToManyDeltas( Handle, CachedSelectors.manyToManyDeltas, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject @object() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.@object( Handle, CachedSelectors.@object, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject objectID() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectID( Handle, CachedSelectors.objectID, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void removeAdapterOperation_( NObjective.RuntimeObject operation ) {
			RuntimeObject ___occuredException;
			NativeMethods.removeAdapterOperation_( Handle, CachedSelectors.removeAdapterOperation_, out ___occuredException, sizeof( NObjective.RuntimeObject ), operation );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject rowForUpdate() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.rowForUpdate( Handle, CachedSelectors.rowForUpdate, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setDatabaseOperator_( int @operator ) {
			RuntimeObject ___occuredException;
			NativeMethods.setDatabaseOperator_( Handle, CachedSelectors.setDatabaseOperator_, out ___occuredException, sizeof( int ), @operator );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setDBSnapshot_( NObjective.RuntimeObject snapshot ) {
			RuntimeObject ___occuredException;
			NativeMethods.setDBSnapshot_( Handle, CachedSelectors.setDBSnapshot_, out ___occuredException, sizeof( NObjective.RuntimeObject ), snapshot );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setRowForUpdate_( NObjective.RuntimeObject update ) {
			RuntimeObject ___occuredException;
			NativeMethods.setRowForUpdate_( Handle, CachedSelectors.setRowForUpdate_, out ___occuredException, sizeof( NObjective.RuntimeObject ), update );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr adapterOperations( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void addAdapterOperation_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject operation );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void addDelta_forManyToManyKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject delta, NObjective.RuntimeObject forManyToManyKey );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int databaseOperator( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr dbSnapshot( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr entity( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithObject_entity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, NObjective.RuntimeObject entity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr manyToManyDeltas( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr @object( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr objectID( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void removeAdapterOperation_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject operation );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr rowForUpdate( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setDatabaseOperator_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int @operator );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setDBSnapshot_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject snapshot );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setRowForUpdate_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject update );
		}
		static internal class CachedSelectors {
			public static readonly Selector adapterOperations = "adapterOperations";
			public static readonly Selector addAdapterOperation_ = "addAdapterOperation:";
			public static readonly Selector addDelta_forManyToManyKey_ = "addDelta:forManyToManyKey:";
			public static readonly Selector databaseOperator = "databaseOperator";
			public static readonly Selector dbSnapshot = "dbSnapshot";
			public static readonly Selector entity = "entity";
			public static readonly Selector initWithObject_entity_ = "initWithObject:entity:";
			public static readonly Selector manyToManyDeltas = "manyToManyDeltas";
			public static readonly Selector @object = "object";
			public static readonly Selector objectID = "objectID";
			public static readonly Selector removeAdapterOperation_ = "removeAdapterOperation:";
			public static readonly Selector rowForUpdate = "rowForUpdate";
			public static readonly Selector setDatabaseOperator_ = "setDatabaseOperator:";
			public static readonly Selector setDBSnapshot_ = "setDBSnapshot:";
			public static readonly Selector setRowForUpdate_ = "setRowForUpdate:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSSQLColumn ) )]
	public struct NSSQLOptLockKey : IEquatable<NSSQLOptLockKey> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLOptLockKey;
		public static implicit operator IntPtr( NSSQLOptLockKey value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLOptLockKey value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLOptLockKey?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLOptLockKey value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLOptLockKey value1, NSSQLOptLockKey value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLOptLockKey value1, NSSQLOptLockKey value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLOptLockKey( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLOptLockKey alloc() {
			return new NSSQLOptLockKey( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSSQLColumn ) )]
	public struct NSSQLPrimaryKey : IEquatable<NSSQLPrimaryKey> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLPrimaryKey;
		public static implicit operator IntPtr( NSSQLPrimaryKey value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLPrimaryKey value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLPrimaryKey?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLPrimaryKey value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLPrimaryKey value1, NSSQLPrimaryKey value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLPrimaryKey value1, NSSQLPrimaryKey value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLPrimaryKey( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLPrimaryKey alloc() {
			return new NSSQLPrimaryKey( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject sqlTypeString() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sqlTypeString( Handle, CachedSelectors.sqlTypeString, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr sqlTypeString( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector sqlTypeString = "sqlTypeString";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSMapping ) )]
	public struct NSSQLProperty : IEquatable<NSSQLProperty> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLProperty;
		public static implicit operator IntPtr( NSSQLProperty value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLProperty value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLProperty?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLProperty value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLProperty value1, NSSQLProperty value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLProperty value1, NSSQLProperty value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLProperty( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLProperty alloc() {
			return new NSSQLProperty( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject columnName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.columnName( Handle, CachedSelectors.columnName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject entity() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entity( Handle, CachedSelectors.entity, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSSQLProperty initWithEntity_propertyDescription_( NObjective.RuntimeObject entity, NObjective.RuntimeObject propertyDescription ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithEntity_propertyDescription_( Handle, CachedSelectors.initWithEntity_propertyDescription_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), entity, propertyDescription );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSQLProperty( ___result );
		}
		unsafe public bool isAttribute() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isAttribute( Handle, CachedSelectors.isAttribute, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isColumn() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isColumn( Handle, CachedSelectors.isColumn, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isEntityKey() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isEntityKey( Handle, CachedSelectors.isEntityKey, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isForeignEntityKey() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isForeignEntityKey( Handle, CachedSelectors.isForeignEntityKey, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isForeignKey() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isForeignKey( Handle, CachedSelectors.isForeignKey, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isManyToMany() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isManyToMany( Handle, CachedSelectors.isManyToMany, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isOptLockKey() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isOptLockKey( Handle, CachedSelectors.isOptLockKey, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isPrimaryKey() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isPrimaryKey( Handle, CachedSelectors.isPrimaryKey, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isRelationship() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isRelationship( Handle, CachedSelectors.isRelationship, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isToMany() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isToMany( Handle, CachedSelectors.isToMany, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isToOne() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isToOne( Handle, CachedSelectors.isToOne, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject name() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.name( Handle, CachedSelectors.name, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject propertyDescription() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.propertyDescription( Handle, CachedSelectors.propertyDescription, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public int propertyType() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.propertyType( Handle, CachedSelectors.propertyType, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public uint slot() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.slot( Handle, CachedSelectors.slot, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr columnName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr entity( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithEntity_propertyDescription_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity, NObjective.RuntimeObject propertyDescription );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isAttribute( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isColumn( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isEntityKey( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isForeignEntityKey( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isForeignKey( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isManyToMany( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isOptLockKey( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isPrimaryKey( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isRelationship( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isToMany( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isToOne( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr name( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr propertyDescription( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int propertyType( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint slot( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector columnName = "columnName";
			public static readonly Selector entity = "entity";
			public static readonly Selector initWithEntity_propertyDescription_ = "initWithEntity:propertyDescription:";
			public static readonly Selector isAttribute = "isAttribute";
			public static readonly Selector isColumn = "isColumn";
			public static readonly Selector isEntityKey = "isEntityKey";
			public static readonly Selector isForeignEntityKey = "isForeignEntityKey";
			public static readonly Selector isForeignKey = "isForeignKey";
			public static readonly Selector isManyToMany = "isManyToMany";
			public static readonly Selector isOptLockKey = "isOptLockKey";
			public static readonly Selector isPrimaryKey = "isPrimaryKey";
			public static readonly Selector isRelationship = "isRelationship";
			public static readonly Selector isToMany = "isToMany";
			public static readonly Selector isToOne = "isToOne";
			public static readonly Selector name = "name";
			public static readonly Selector propertyDescription = "propertyDescription";
			public static readonly Selector propertyType = "propertyType";
			public static readonly Selector slot = "slot";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSSQLProperty ) )]
	public struct NSSQLRelationship : IEquatable<NSSQLRelationship> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLRelationship;
		public static implicit operator IntPtr( NSSQLRelationship value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLRelationship value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLRelationship?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLRelationship value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLRelationship value1, NSSQLRelationship value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLRelationship value1, NSSQLRelationship value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLRelationship( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLRelationship alloc() {
			return new NSSQLRelationship( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject correlationTableName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.correlationTableName( Handle, CachedSelectors.correlationTableName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject destinationEntity() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.destinationEntity( Handle, CachedSelectors.destinationEntity, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject foreignKey() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.foreignKey( Handle, CachedSelectors.foreignKey, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject inverseRelationship() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.inverseRelationship( Handle, CachedSelectors.inverseRelationship, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject relationshipDescription() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.relationshipDescription( Handle, CachedSelectors.relationshipDescription, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject sourceEntity() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sourceEntity( Handle, CachedSelectors.sourceEntity, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr correlationTableName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr destinationEntity( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr foreignKey( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr inverseRelationship( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr relationshipDescription( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr sourceEntity( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector correlationTableName = "correlationTableName";
			public static readonly Selector destinationEntity = "destinationEntity";
			public static readonly Selector foreignKey = "foreignKey";
			public static readonly Selector inverseRelationship = "inverseRelationship";
			public static readonly Selector relationshipDescription = "relationshipDescription";
			public static readonly Selector sourceEntity = "sourceEntity";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSSQLRow : IEquatable<NSSQLRow> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLRow;
		public static implicit operator IntPtr( NSSQLRow value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLRow value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLRow?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLRow value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLRow value1, NSSQLRow value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLRow value1, NSSQLRow value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLRow( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLRow alloc() {
			return new NSSQLRow( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject attributeValueForSlot_( uint slot ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.attributeValueForSlot_( Handle, CachedSelectors.attributeValueForSlot_, out ___occuredException, sizeof( uint ), slot );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject entity() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entity( Handle, CachedSelectors.entity, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public uint entityID() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entityID( Handle, CachedSelectors.entityID, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public uint foreignEntityKeyForSlot_( uint slot ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.foreignEntityKeyForSlot_( Handle, CachedSelectors.foreignEntityKeyForSlot_, out ___occuredException, sizeof( uint ), slot );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public long foreignKeyForSlot_( uint slot ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.foreignKeyForSlot_( Handle, CachedSelectors.foreignKeyForSlot_, out ___occuredException, sizeof( uint ), slot );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NSSQLRow initWithSQLEntity_objectID_( NObjective.RuntimeObject entity, NObjective.RuntimeObject objectID ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithSQLEntity_objectID_( Handle, CachedSelectors.initWithSQLEntity_objectID_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), entity, objectID );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSQLRow( ___result );
		}
		unsafe public System.IntPtr knownKeyValuesPointer() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.knownKeyValuesPointer( Handle, CachedSelectors.knownKeyValuesPointer, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool matchesFetchedRow_( NObjective.RuntimeObject row ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.matchesFetchedRow_( Handle, CachedSelectors.matchesFetchedRow_, out ___occuredException, sizeof( NObjective.RuntimeObject ), row );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject newObjectIDForToOne_( NObjective.RuntimeObject one ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newObjectIDForToOne_( Handle, CachedSelectors.newObjectIDForToOne_, out ___occuredException, sizeof( NObjective.RuntimeObject ), one );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject objectID() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectID( Handle, CachedSelectors.objectID, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public long optLock() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.optLock( Handle, CachedSelectors.optLock, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public long pk64() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.pk64( Handle, CachedSelectors.pk64, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void setAttributeSlotNoRetain_withObject_( uint retain, NObjective.RuntimeObject withObject ) {
			RuntimeObject ___occuredException;
			NativeMethods.setAttributeSlotNoRetain_withObject_( Handle, CachedSelectors.setAttributeSlotNoRetain_withObject_, out ___occuredException, sizeof( uint ) + sizeof( NObjective.RuntimeObject ), retain, withObject );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setForeignEntityKeySlot_unsigned_( uint slot, uint unsigned ) {
			RuntimeObject ___occuredException;
			NativeMethods.setForeignEntityKeySlot_unsigned_( Handle, CachedSelectors.setForeignEntityKeySlot_unsigned_, out ___occuredException, sizeof( uint ) + sizeof( uint ), slot, unsigned );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setForeignKeySlot_int64_( uint slot, long int64 ) {
			RuntimeObject ___occuredException;
			NativeMethods.setForeignKeySlot_int64_( Handle, CachedSelectors.setForeignKeySlot_int64_, out ___occuredException, sizeof( uint ) + sizeof( long ), slot, int64 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setObjectID_( NObjective.RuntimeObject id ) {
			RuntimeObject ___occuredException;
			NativeMethods.setObjectID_( Handle, CachedSelectors.setObjectID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setOptLock_( long @lock ) {
			RuntimeObject ___occuredException;
			NativeMethods.setOptLock_( Handle, CachedSelectors.setOptLock_, out ___occuredException, sizeof( long ), @lock );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setTemporaryID_( NObjective.RuntimeObject id ) {
			RuntimeObject ___occuredException;
			NativeMethods.setTemporaryID_( Handle, CachedSelectors.setTemporaryID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject temporaryID() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.temporaryID( Handle, CachedSelectors.temporaryID, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public uint versionNumber() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.versionNumber( Handle, CachedSelectors.versionNumber, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr attributeValueForSlot_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint slot );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr entity( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint entityID( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint foreignEntityKeyForSlot_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint slot );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern long foreignKeyForSlot_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint slot );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithSQLEntity_objectID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity, NObjective.RuntimeObject objectID );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern System.IntPtr knownKeyValuesPointer( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool matchesFetchedRow_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject row );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr newObjectIDForToOne_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject one );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr objectID( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern long optLock( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern long pk64( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setAttributeSlotNoRetain_withObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint retain, NObjective.RuntimeObject withObject );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setForeignEntityKeySlot_unsigned_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint slot, uint unsigned );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setForeignKeySlot_int64_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint slot, long int64 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setObjectID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setOptLock_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, long @lock );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setTemporaryID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr temporaryID( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint versionNumber( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector attributeValueForSlot_ = "attributeValueForSlot:";
			public static readonly Selector entity = "entity";
			public static readonly Selector entityID = "entityID";
			public static readonly Selector foreignEntityKeyForSlot_ = "foreignEntityKeyForSlot:";
			public static readonly Selector foreignKeyForSlot_ = "foreignKeyForSlot:";
			public static readonly Selector initWithSQLEntity_objectID_ = "initWithSQLEntity:objectID:";
			public static readonly Selector knownKeyValuesPointer = "knownKeyValuesPointer";
			public static readonly Selector matchesFetchedRow_ = "matchesFetchedRow:";
			public static readonly Selector newObjectIDForToOne_ = "newObjectIDForToOne:";
			public static readonly Selector objectID = "objectID";
			public static readonly Selector optLock = "optLock";
			public static readonly Selector pk64 = "pk64";
			public static readonly Selector setAttributeSlotNoRetain_withObject_ = "setAttributeSlotNoRetain:withObject:";
			public static readonly Selector setForeignEntityKeySlot_unsigned_ = "setForeignEntityKeySlot:unsigned:";
			public static readonly Selector setForeignKeySlot_int64_ = "setForeignKeySlot:int64:";
			public static readonly Selector setObjectID_ = "setObjectID:";
			public static readonly Selector setOptLock_ = "setOptLock:";
			public static readonly Selector setTemporaryID_ = "setTemporaryID:";
			public static readonly Selector temporaryID = "temporaryID";
			public static readonly Selector versionNumber = "versionNumber";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObjectStoreCache ) )]
	public struct NSSQLRowCache : IEquatable<NSSQLRowCache> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLRowCache;
		public static implicit operator IntPtr( NSSQLRowCache value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLRowCache value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLRowCache?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLRowCache value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLRowCache value1, NSSQLRowCache value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLRowCache value1, NSSQLRowCache value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLRowCache( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLRowCache alloc() {
			return new NSSQLRowCache( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject adapter() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.adapter( Handle, CachedSelectors.adapter, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public int debugLevel() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.debugLevel( Handle, CachedSelectors.debugLevel, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void forgetRowForObjectID_( NObjective.RuntimeObject id ) {
			RuntimeObject ___occuredException;
			NativeMethods.forgetRowForObjectID_( Handle, CachedSelectors.forgetRowForObjectID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSSQLRowCache initWithSQLCore_( NObjective.RuntimeObject core ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithSQLCore_( Handle, CachedSelectors.initWithSQLCore_, out ___occuredException, sizeof( NObjective.RuntimeObject ), core );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSQLRowCache( ___result );
		}
		unsafe public void registerRow_forObjectID_( NObjective.RuntimeObject row, NObjective.RuntimeObject forObjectID ) {
			RuntimeObject ___occuredException;
			NativeMethods.registerRow_forObjectID_( Handle, CachedSelectors.registerRow_forObjectID_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), row, forObjectID );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void registerSnapshots_( NObjective.RuntimeObject snapshots ) {
			RuntimeObject ___occuredException;
			NativeMethods.registerSnapshots_( Handle, CachedSelectors.registerSnapshots_, out ___occuredException, sizeof( NObjective.RuntimeObject ), snapshots );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void registerToMany_forSourceObjectID_relationshipName_( NObjective.RuntimeObject many, NObjective.RuntimeObject forSourceObjectID, NObjective.RuntimeObject relationshipName ) {
			RuntimeObject ___occuredException;
			NativeMethods.registerToMany_forSourceObjectID_relationshipName_( Handle, CachedSelectors.registerToMany_forSourceObjectID_relationshipName_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), many, forSourceObjectID, relationshipName );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject rowForObjectID_( NObjective.RuntimeObject id ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.rowForObjectID_( Handle, CachedSelectors.rowForObjectID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject rowForObjectID_after_( NObjective.RuntimeObject id, double after ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.rowForObjectID_after_( Handle, CachedSelectors.rowForObjectID_after_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( double ), id, after );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setDebugLevel_( int level ) {
			RuntimeObject ___occuredException;
			NativeMethods.setDebugLevel_( Handle, CachedSelectors.setDebugLevel_, out ___occuredException, sizeof( int ), level );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject toManyForSourceObjectID_relationshipName_( NObjective.RuntimeObject id, NObjective.RuntimeObject relationshipName ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.toManyForSourceObjectID_relationshipName_( Handle, CachedSelectors.toManyForSourceObjectID_relationshipName_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), id, relationshipName );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject toManyForSourceObjectID_relationshipName_after_( NObjective.RuntimeObject id, NObjective.RuntimeObject relationshipName, double after ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.toManyForSourceObjectID_relationshipName_after_( Handle, CachedSelectors.toManyForSourceObjectID_relationshipName_after_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( double ), id, relationshipName, after );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr adapter( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int debugLevel( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void forgetRowForObjectID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithSQLCore_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject core );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void registerRow_forObjectID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject row, NObjective.RuntimeObject forObjectID );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void registerSnapshots_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject snapshots );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void registerToMany_forSourceObjectID_relationshipName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject many, NObjective.RuntimeObject forSourceObjectID, NObjective.RuntimeObject relationshipName );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr rowForObjectID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr rowForObjectID_after_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id, double after );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setDebugLevel_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int level );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr toManyForSourceObjectID_relationshipName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id, NObjective.RuntimeObject relationshipName );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr toManyForSourceObjectID_relationshipName_after_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id, NObjective.RuntimeObject relationshipName, double after );
		}
		static internal class CachedSelectors {
			public static readonly Selector adapter = "adapter";
			public static readonly Selector debugLevel = "debugLevel";
			public static readonly Selector forgetRowForObjectID_ = "forgetRowForObjectID:";
			public static readonly Selector initWithSQLCore_ = "initWithSQLCore:";
			public static readonly Selector registerRow_forObjectID_ = "registerRow:forObjectID:";
			public static readonly Selector registerSnapshots_ = "registerSnapshots:";
			public static readonly Selector registerToMany_forSourceObjectID_relationshipName_ = "registerToMany:forSourceObjectID:relationshipName:";
			public static readonly Selector rowForObjectID_ = "rowForObjectID:";
			public static readonly Selector rowForObjectID_after_ = "rowForObjectID:after:";
			public static readonly Selector setDebugLevel_ = "setDebugLevel:";
			public static readonly Selector toManyForSourceObjectID_relationshipName_ = "toManyForSourceObjectID:relationshipName:";
			public static readonly Selector toManyForSourceObjectID_relationshipName_after_ = "toManyForSourceObjectID:relationshipName:after:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSSQLStatement : IEquatable<NSSQLStatement> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLStatement;
		public static implicit operator IntPtr( NSSQLStatement value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLStatement value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLStatement?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLStatement value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLStatement value1, NSSQLStatement value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLStatement value1, NSSQLStatement value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLStatement( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLStatement alloc() {
			return new NSSQLStatement( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public uint addBindVariable_( NObjective.RuntimeObject variable ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.addBindVariable_( Handle, CachedSelectors.addBindVariable_, out ___occuredException, sizeof( NObjective.RuntimeObject ), variable );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public NObjective.RuntimeObject bindVariables() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.bindVariables( Handle, CachedSelectors.bindVariables, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void clearCaches() {
			RuntimeObject ___occuredException;
			NativeMethods.clearCaches( Handle, CachedSelectors.clearCaches, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject entity() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entity( Handle, CachedSelectors.entity, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSSQLStatement initWithEntity_( NObjective.RuntimeObject entity ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithEntity_( Handle, CachedSelectors.initWithEntity_, out ___occuredException, sizeof( NObjective.RuntimeObject ), entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSQLStatement( ___result );
		}
		unsafe public NSSQLStatement initWithEntity_sqlString_( NObjective.RuntimeObject entity, NObjective.RuntimeObject sqlString ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithEntity_sqlString_( Handle, CachedSelectors.initWithEntity_sqlString_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), entity, sqlString );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSQLStatement( ___result );
		}
		unsafe public void removeAllBindVariables() {
			RuntimeObject ___occuredException;
			NativeMethods.removeAllBindVariables( Handle, CachedSelectors.removeAllBindVariables, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setSQLString_( NObjective.RuntimeObject @string ) {
			RuntimeObject ___occuredException;
			NativeMethods.setSQLString_( Handle, CachedSelectors.setSQLString_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @string );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject sqlString() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sqlString( Handle, CachedSelectors.sqlString, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint addBindVariable_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject variable );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr bindVariables( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void clearCaches( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr entity( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithEntity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithEntity_sqlString_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity, NObjective.RuntimeObject sqlString );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void removeAllBindVariables( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setSQLString_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @string );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr sqlString( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector addBindVariable_ = "addBindVariable:";
			public static readonly Selector bindVariables = "bindVariables";
			public static readonly Selector clearCaches = "clearCaches";
			public static readonly Selector entity = "entity";
			public static readonly Selector initWithEntity_ = "initWithEntity:";
			public static readonly Selector initWithEntity_sqlString_ = "initWithEntity:sqlString:";
			public static readonly Selector removeAllBindVariables = "removeAllBindVariables";
			public static readonly Selector setSQLString_ = "setSQLString:";
			public static readonly Selector sqlString = "sqlString";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSSQLRelationship ) )]
	public struct NSSQLToMany : IEquatable<NSSQLToMany> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLToMany;
		public static implicit operator IntPtr( NSSQLToMany value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLToMany value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLToMany?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLToMany value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLToMany value1, NSSQLToMany value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLToMany value1, NSSQLToMany value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLToMany( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLToMany alloc() {
			return new NSSQLToMany( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject inverseToOne() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.inverseToOne( Handle, CachedSelectors.inverseToOne, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr inverseToOne( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector inverseToOne = "inverseToOne";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSSQLRelationship ) )]
	public struct NSSQLToOne : IEquatable<NSSQLToOne> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSSQLToOne;
		public static implicit operator IntPtr( NSSQLToOne value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSSQLToOne value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSSQLToOne?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSSQLToOne value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSSQLToOne value1, NSSQLToOne value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSSQLToOne value1, NSSQLToOne value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSSQLToOne( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSSQLToOne alloc() {
			return new NSSQLToOne( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject foreignEntityKey() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.foreignEntityKey( Handle, CachedSelectors.foreignEntityKey, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSSQLToOne initWithEntity_inverseToMany_( NObjective.RuntimeObject entity, NObjective.RuntimeObject inverseToMany ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithEntity_inverseToMany_( Handle, CachedSelectors.initWithEntity_inverseToMany_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), entity, inverseToMany );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSQLToOne( ___result );
		}
		unsafe public NSSQLToOne initWithEntity_propertyDescription_virtualForToMany_( NObjective.RuntimeObject entity, NObjective.RuntimeObject propertyDescription, NObjective.RuntimeObject virtualForToMany ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithEntity_propertyDescription_virtualForToMany_( Handle, CachedSelectors.initWithEntity_propertyDescription_virtualForToMany_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), entity, propertyDescription, virtualForToMany );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSSQLToOne( ___result );
		}
		unsafe public bool isOptional() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isOptional( Handle, CachedSelectors.isOptional, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isVirtual() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isVirtual( Handle, CachedSelectors.isVirtual, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr foreignEntityKey( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithEntity_inverseToMany_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity, NObjective.RuntimeObject inverseToMany );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithEntity_propertyDescription_virtualForToMany_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity, NObjective.RuntimeObject propertyDescription, NObjective.RuntimeObject virtualForToMany );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isOptional( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isVirtual( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector foreignEntityKey = "foreignEntityKey";
			public static readonly Selector initWithEntity_inverseToMany_ = "initWithEntity:inverseToMany:";
			public static readonly Selector initWithEntity_propertyDescription_virtualForToMany_ = "initWithEntity:propertyDescription:virtualForToMany:";
			public static readonly Selector isOptional = "isOptional";
			public static readonly Selector isVirtual = "isVirtual";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSStoreMapNode : IEquatable<NSStoreMapNode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSStoreMapNode;
		public static implicit operator IntPtr( NSStoreMapNode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSStoreMapNode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSStoreMapNode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSStoreMapNode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSStoreMapNode value1, NSStoreMapNode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSStoreMapNode value1, NSStoreMapNode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSStoreMapNode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSStoreMapNode alloc() {
			return new NSStoreMapNode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject configurationName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.configurationName( Handle, CachedSelectors.configurationName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject destinationsForRelationship_( NObjective.RuntimeObject relationship ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.destinationsForRelationship_( Handle, CachedSelectors.destinationsForRelationship_, out ___occuredException, sizeof( NObjective.RuntimeObject ), relationship );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void encodeWithCoder_( NSCoder coder ) {
			RuntimeObject ___occuredException;
			NativeMethods.encodeWithCoder_( Handle, CachedSelectors.encodeWithCoder_, out ___occuredException, sizeof( NSCoder ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject entity() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.entity( Handle, CachedSelectors.entity, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSStoreMapNode initWithCoder_( NObjective.RuntimeObject coder ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCoder_( Handle, CachedSelectors.initWithCoder_, out ___occuredException, sizeof( NObjective.RuntimeObject ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSStoreMapNode( ___result );
		}
		unsafe public NSStoreMapNode initWithObjectID_( NObjective.RuntimeObject id ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithObjectID_( Handle, CachedSelectors.initWithObjectID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSStoreMapNode( ___result );
		}
		unsafe public NObjective.RuntimeObject key() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.key( Handle, CachedSelectors.key, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public System.IntPtr knownKeyValuesPointer() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.knownKeyValuesPointer( Handle, CachedSelectors.knownKeyValuesPointer, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject objectID() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectID( Handle, CachedSelectors.objectID, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setDestinations_forRelationship_( NObjective.RuntimeObject destinations, NObjective.RuntimeObject forRelationship ) {
			RuntimeObject ___occuredException;
			NativeMethods.setDestinations_forRelationship_( Handle, CachedSelectors.setDestinations_forRelationship_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), destinations, forRelationship );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setVersionNumber_( uint number ) {
			RuntimeObject ___occuredException;
			NativeMethods.setVersionNumber_( Handle, CachedSelectors.setVersionNumber_, out ___occuredException, sizeof( uint ), number );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public uint versionNumber() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.versionNumber( Handle, CachedSelectors.versionNumber, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr configurationName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr destinationsForRelationship_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject relationship );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void encodeWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSCoder coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr entity( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithObjectID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr key( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern System.IntPtr knownKeyValuesPointer( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr objectID( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setDestinations_forRelationship_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject destinations, NObjective.RuntimeObject forRelationship );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setVersionNumber_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint number );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint versionNumber( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector configurationName = "configurationName";
			public static readonly Selector destinationsForRelationship_ = "destinationsForRelationship:";
			public static readonly Selector encodeWithCoder_ = "encodeWithCoder:";
			public static readonly Selector entity = "entity";
			public static readonly Selector initWithCoder_ = "initWithCoder:";
			public static readonly Selector initWithObjectID_ = "initWithObjectID:";
			public static readonly Selector key = "key";
			public static readonly Selector knownKeyValuesPointer = "knownKeyValuesPointer";
			public static readonly Selector objectID = "objectID";
			public static readonly Selector setDestinations_forRelationship_ = "setDestinations:forRelationship:";
			public static readonly Selector setVersionNumber_ = "setVersionNumber:";
			public static readonly Selector versionNumber = "versionNumber";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSManagedObjectID ) )]
	public struct NSTemporaryObjectID : IEquatable<NSTemporaryObjectID> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSTemporaryObjectID;
		public static implicit operator IntPtr( NSTemporaryObjectID value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSTemporaryObjectID value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSTemporaryObjectID?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSTemporaryObjectID value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSTemporaryObjectID value1, NSTemporaryObjectID value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSTemporaryObjectID value1, NSTemporaryObjectID value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSTemporaryObjectID( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSTemporaryObjectID alloc() {
			return new NSTemporaryObjectID( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NSTemporaryObjectID temporaryObjectIDWithEntity_( NObjective.RuntimeObject entity ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.temporaryObjectIDWithEntity_( ClassHandle, CachedSelectors.temporaryObjectIDWithEntity_, out ___occuredException, sizeof( NObjective.RuntimeObject ), entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSTemporaryObjectID( ___result );
		}
		unsafe public NSTemporaryObjectID initWithEntity_( NObjective.RuntimeObject entity ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithEntity_( Handle, CachedSelectors.initWithEntity_, out ___occuredException, sizeof( NObjective.RuntimeObject ), entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSTemporaryObjectID( ___result );
		}
		unsafe public NSTemporaryObjectID initWithEntity_andUUIDString_( NObjective.RuntimeObject entity, NObjective.RuntimeObject andUUIDString ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithEntity_andUUIDString_( Handle, CachedSelectors.initWithEntity_andUUIDString_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), entity, andUUIDString );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSTemporaryObjectID( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithEntity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithEntity_andUUIDString_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity, NObjective.RuntimeObject andUUIDString );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr temporaryObjectIDWithEntity_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithEntity_ = "initWithEntity:";
			public static readonly Selector initWithEntity_andUUIDString_ = "initWithEntity:andUUIDString:";
			public static readonly Selector temporaryObjectIDWithEntity_ = "temporaryObjectIDWithEntity:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct NSValidationErrorLocalizationPolicy : IEquatable<NSValidationErrorLocalizationPolicy> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSValidationErrorLocalizationPolicy;
		public static implicit operator IntPtr( NSValidationErrorLocalizationPolicy value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSValidationErrorLocalizationPolicy value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSValidationErrorLocalizationPolicy?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSValidationErrorLocalizationPolicy value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSValidationErrorLocalizationPolicy value1, NSValidationErrorLocalizationPolicy value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSValidationErrorLocalizationPolicy value1, NSValidationErrorLocalizationPolicy value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSValidationErrorLocalizationPolicy( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSValidationErrorLocalizationPolicy alloc() {
			return new NSValidationErrorLocalizationPolicy( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NSValidationErrorLocalizationPolicy initWithURL_( NObjective.RuntimeObject url ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithURL_( Handle, CachedSelectors.initWithURL_, out ___occuredException, sizeof( NObjective.RuntimeObject ), url );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSValidationErrorLocalizationPolicy( ___result );
		}
		unsafe public NObjective.RuntimeObject localizationDictionary() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.localizationDictionary( Handle, CachedSelectors.localizationDictionary, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject localizedEntityNameForEntity_( NObjective.RuntimeObject entity ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.localizedEntityNameForEntity_( Handle, CachedSelectors.localizedEntityNameForEntity_, out ___occuredException, sizeof( NObjective.RuntimeObject ), entity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject localizedModelStringForKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.localizedModelStringForKey_( Handle, CachedSelectors.localizedModelStringForKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject localizedPropertyNameForProperty_( NObjective.RuntimeObject property ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.localizedPropertyNameForProperty_( Handle, CachedSelectors.localizedPropertyNameForProperty_, out ___occuredException, sizeof( NObjective.RuntimeObject ), property );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setLocalizationDictionary_( NObjective.RuntimeObject dictionary ) {
			RuntimeObject ___occuredException;
			NativeMethods.setLocalizationDictionary_( Handle, CachedSelectors.setLocalizationDictionary_, out ___occuredException, sizeof( NObjective.RuntimeObject ), dictionary );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithURL_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject url );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr localizationDictionary( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr localizedEntityNameForEntity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entity );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr localizedModelStringForKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr localizedPropertyNameForProperty_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject property );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setLocalizationDictionary_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dictionary );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithURL_ = "initWithURL:";
			public static readonly Selector localizationDictionary = "localizationDictionary";
			public static readonly Selector localizedEntityNameForEntity_ = "localizedEntityNameForEntity:";
			public static readonly Selector localizedModelStringForKey_ = "localizedModelStringForKey:";
			public static readonly Selector localizedPropertyNameForProperty_ = "localizedPropertyNameForProperty:";
			public static readonly Selector setLocalizationDictionary_ = "setLocalizationDictionary:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObjectStoreMap ) )]
	public struct NSXMLDocumentMap : IEquatable<NSXMLDocumentMap> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSXMLDocumentMap;
		public static implicit operator IntPtr( NSXMLDocumentMap value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSXMLDocumentMap value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSXMLDocumentMap?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSXMLDocumentMap value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSXMLDocumentMap value1, NSXMLDocumentMap value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSXMLDocumentMap value1, NSXMLDocumentMap value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSXMLDocumentMap( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSXMLDocumentMap alloc() {
			return new NSXMLDocumentMap( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject document() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.document( Handle, CachedSelectors.document, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSXMLDocumentMap initWithDocument_forStore_( NObjective.RuntimeObject document, NObjective.RuntimeObject forStore ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithDocument_forStore_( Handle, CachedSelectors.initWithDocument_forStore_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), document, forStore );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSXMLDocumentMap( ___result );
		}
		unsafe public NObjective.RuntimeObject nodeFromManagedObject_objectIDMap_( NObjective.RuntimeObject @object, NObjective.RuntimeObject objectIDMap ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.nodeFromManagedObject_objectIDMap_( Handle, CachedSelectors.nodeFromManagedObject_objectIDMap_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), @object, objectIDMap );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void prepareForSave() {
			RuntimeObject ___occuredException;
			NativeMethods.prepareForSave( Handle, CachedSelectors.prepareForSave, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject retainedXmlInfoForRelationship_( NObjective.RuntimeObject relationship ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.retainedXmlInfoForRelationship_( Handle, CachedSelectors.retainedXmlInfoForRelationship_, out ___occuredException, sizeof( NObjective.RuntimeObject ), relationship );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject xmlInfoForAttribute_( NObjective.RuntimeObject attribute ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.xmlInfoForAttribute_( Handle, CachedSelectors.xmlInfoForAttribute_, out ___occuredException, sizeof( NObjective.RuntimeObject ), attribute );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr document( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithDocument_forStore_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject document, NObjective.RuntimeObject forStore );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr nodeFromManagedObject_objectIDMap_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, NObjective.RuntimeObject objectIDMap );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void prepareForSave( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr retainedXmlInfoForRelationship_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject relationship );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr xmlInfoForAttribute_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject attribute );
		}
		static internal class CachedSelectors {
			public static readonly Selector document = "document";
			public static readonly Selector initWithDocument_forStore_ = "initWithDocument:forStore:";
			public static readonly Selector nodeFromManagedObject_objectIDMap_ = "nodeFromManagedObject:objectIDMap:";
			public static readonly Selector prepareForSave = "prepareForSave";
			public static readonly Selector retainedXmlInfoForRelationship_ = "retainedXmlInfoForRelationship:";
			public static readonly Selector xmlInfoForAttribute_ = "xmlInfoForAttribute:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSStoreMapNode ) )]
	public struct NSXMLDocumentMapNode : IEquatable<NSXMLDocumentMapNode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSXMLDocumentMapNode;
		public static implicit operator IntPtr( NSXMLDocumentMapNode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSXMLDocumentMapNode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSXMLDocumentMapNode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSXMLDocumentMapNode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSXMLDocumentMapNode value1, NSXMLDocumentMapNode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSXMLDocumentMapNode value1, NSXMLDocumentMapNode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSXMLDocumentMapNode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSXMLDocumentMapNode alloc() {
			return new NSXMLDocumentMapNode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NSXMLDocumentMapNode initWithXMLNode_objectID_( NObjective.RuntimeObject node, NObjective.RuntimeObject objectID ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithXMLNode_objectID_( Handle, CachedSelectors.initWithXMLNode_objectID_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), node, objectID );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSXMLDocumentMapNode( ___result );
		}
		unsafe public void setAllDestinations_( NObjective.RuntimeObject destinations ) {
			RuntimeObject ___occuredException;
			NativeMethods.setAllDestinations_( Handle, CachedSelectors.setAllDestinations_, out ___occuredException, sizeof( NObjective.RuntimeObject ), destinations );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject xmlNode() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.xmlNode( Handle, CachedSelectors.xmlNode, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithXMLNode_objectID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject node, NObjective.RuntimeObject objectID );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setAllDestinations_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject destinations );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr xmlNode( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithXMLNode_objectID_ = "initWithXMLNode:objectID:";
			public static readonly Selector setAllDestinations_ = "setAllDestinations:";
			public static readonly Selector xmlNode = "xmlNode";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSMappedObjectStore ) )]
	public struct NSXMLObjectStore : IEquatable<NSXMLObjectStore> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreDataCachedClasses.NSXMLObjectStore;
		public static implicit operator IntPtr( NSXMLObjectStore value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSXMLObjectStore value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSXMLObjectStore?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSXMLObjectStore value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSXMLObjectStore value1, NSXMLObjectStore value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSXMLObjectStore value1, NSXMLObjectStore value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSXMLObjectStore( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSXMLObjectStore alloc() {
			return new NSXMLObjectStore( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	public static class CoreDataExtensionsOfNSString {
		private static int ___lazyLoad = CoreDataCachedClasses.___lazyLoad;
		unsafe public static NObjective.RuntimeObject sqlString( this NSString ___this ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sqlString( ___this, CachedSelectors.sqlString, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr sqlString( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector sqlString = "sqlString";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	public static class CoreDataExtensionsOfNSNumber {
		private static int ___lazyLoad = CoreDataCachedClasses.___lazyLoad;
		unsafe public static NObjective.RuntimeObject sqlString( this NSNumber ___this ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sqlString( ___this, CachedSelectors.sqlString, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr sqlString( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector sqlString = "sqlString";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	public static class CoreDataExtensionsOfNSData {
		private static int ___lazyLoad = CoreDataCachedClasses.___lazyLoad;
		unsafe public static NObjective.RuntimeObject hexString( this NSData ___this ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.hexString( ___this, CachedSelectors.hexString, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject sqlString( this NSData ___this ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sqlString( ___this, CachedSelectors.sqlString, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr hexString( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr sqlString( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector hexString = "hexString";
			public static readonly Selector sqlString = "sqlString";
		}
	}
	static internal class CoreDataCachedClasses {
		static internal int ___lazyLoad = Platform.NativeMethods.dlopen( "/System/Library/Frameworks/CoreData.framework/Versions/A/CoreData" );
		public static readonly RuntimeClass _NS128bitWrapper = "_NS128bitWrapper";
		public static readonly RuntimeClass _NSCoreDataException = "_NSCoreDataException";
		public static readonly RuntimeClass _NSCoreDataOptimisticLockingException = "_NSCoreDataOptimisticLockingException";
		public static readonly RuntimeClass _NSFaultingMutableArray = "_NSFaultingMutableArray";
		public static readonly RuntimeClass _NSFaultingMutableSet = "_NSFaultingMutableSet";
		public static readonly RuntimeClass _NSFaultingMutableSetMutationMethods = "_NSFaultingMutableSetMutationMethods";
		public static readonly RuntimeClass _NSInvalidationFaultHandler = "_NSInvalidationFaultHandler";
		public static readonly RuntimeClass _NSKnownKeysDictionary = "_NSKnownKeysDictionary";
		public static readonly RuntimeClass _NSKnownKeysEnumerator = "_NSKnownKeysEnumerator";
		public static readonly RuntimeClass _NSKnownKeysMappingStrategy = "_NSKnownKeysMappingStrategy";
		public static readonly RuntimeClass _NSMemoryStorePredicateRemapper = "_NSMemoryStorePredicateRemapper";
		public static readonly RuntimeClass _NSNotifyingWrapperMutableSet = "_NSNotifyingWrapperMutableSet";
		public static readonly RuntimeClass _NSPersistenceUtilities = "_NSPersistenceUtilities";
		public static readonly RuntimeClass _NSProxyWrapperMutableSet = "_NSProxyWrapperMutableSet";
		public static readonly RuntimeClass _PFRoutines = "_PFRoutines";
		public static readonly RuntimeClass NSAttributeDescription = "NSAttributeDescription";
		public static readonly RuntimeClass NSAttributeMapping = "NSAttributeMapping";
		public static readonly RuntimeClass NSBasicObjectID = "NSBasicObjectID";
		public static readonly RuntimeClass NSBinaryObjectStore = "NSBinaryObjectStore";
		public static readonly RuntimeClass NSBinaryObjectStoreFile = "NSBinaryObjectStoreFile";
		public static readonly RuntimeClass NSCountRequest = "NSCountRequest";
		public static readonly RuntimeClass NSDictionaryMapNode = "NSDictionaryMapNode";
		public static readonly RuntimeClass NSDictionaryStoreMap = "NSDictionaryStoreMap";
		public static readonly RuntimeClass NSEntityDescription = "NSEntityDescription";
		public static readonly RuntimeClass NSEntityMapping = "NSEntityMapping";
		public static readonly RuntimeClass NSEntityObjectIDFactory = "NSEntityObjectIDFactory";
		public static readonly RuntimeClass NSExternalData = "NSExternalData";
		public static readonly RuntimeClass NSExternalRefCountedData = "NSExternalRefCountedData";
		public static readonly RuntimeClass NSFaultHandler = "NSFaultHandler";
		public static readonly RuntimeClass NSFetchedPropertyDescription = "NSFetchedPropertyDescription";
		public static readonly RuntimeClass NSFetchRequest = "NSFetchRequest";
		public static readonly RuntimeClass NSJoin = "NSJoin";
		public static readonly RuntimeClass NSManagedObject = "NSManagedObject";
		public static readonly RuntimeClass NSManagedObjectContext = "NSManagedObjectContext";
		public static readonly RuntimeClass NSManagedObjectID = "NSManagedObjectID";
		public static readonly RuntimeClass NSManagedObjectModel = "NSManagedObjectModel";
		public static readonly RuntimeClass NSMappedObjectStore = "NSMappedObjectStore";
		public static readonly RuntimeClass NSMapping = "NSMapping";
		public static readonly RuntimeClass NSMappingGenerator = "NSMappingGenerator";
		public static readonly RuntimeClass NSMemoryObjectStore = "NSMemoryObjectStore";
		public static readonly RuntimeClass NSMemoryStoreEqualityPredicateOperator = "NSMemoryStoreEqualityPredicateOperator";
		public static readonly RuntimeClass NSMemoryStoreInPredicateOperator = "NSMemoryStoreInPredicateOperator";
		public static readonly RuntimeClass NSMergedPolicyLocalizationPolicy = "NSMergedPolicyLocalizationPolicy";
		public static readonly RuntimeClass NSMergePolicy = "NSMergePolicy";
		public static readonly RuntimeClass NSObjectStore = "NSObjectStore";
		public static readonly RuntimeClass NSObjectStoreCache = "NSObjectStoreCache";
		public static readonly RuntimeClass NSObjectStoreMap = "NSObjectStoreMap";
		public static readonly RuntimeClass NSObjectStoreRequest = "NSObjectStoreRequest";
		public static readonly RuntimeClass NSPersistentStoreCoordinator = "NSPersistentStoreCoordinator";
		public static readonly RuntimeClass NSPrivateCoreDataClassForFindingBundle = "NSPrivateCoreDataClassForFindingBundle";
		public static readonly RuntimeClass NSPropertyDescription = "NSPropertyDescription";
		public static readonly RuntimeClass NSPropertyMapping = "NSPropertyMapping";
		public static readonly RuntimeClass NSRefreshRequest = "NSRefreshRequest";
		public static readonly RuntimeClass NSRelationshipDescription = "NSRelationshipDescription";
		public static readonly RuntimeClass NSRelationshipMapping = "NSRelationshipMapping";
		public static readonly RuntimeClass NSSaveChangesRequest = "NSSaveChangesRequest";
		public static readonly RuntimeClass NSSQLAdapter = "NSSQLAdapter";
		public static readonly RuntimeClass NSSQLAdapterOperation = "NSSQLAdapterOperation";
		public static readonly RuntimeClass NSSQLAttribute = "NSSQLAttribute";
		public static readonly RuntimeClass NSSQLBindVariable = "NSSQLBindVariable";
		public static readonly RuntimeClass NSSQLChannel = "NSSQLChannel";
		public static readonly RuntimeClass NSSQLColumn = "NSSQLColumn";
		public static readonly RuntimeClass NSSQLConnection = "NSSQLConnection";
		public static readonly RuntimeClass NSSQLCore = "NSSQLCore";
		public static readonly RuntimeClass NSSQLCorrelation = "NSSQLCorrelation";
		public static readonly RuntimeClass NSSQLEntity = "NSSQLEntity";
		public static readonly RuntimeClass NSSQLEntityKey = "NSSQLEntityKey";
		public static readonly RuntimeClass NSSQLForeignEntityKey = "NSSQLForeignEntityKey";
		public static readonly RuntimeClass NSSQLForeignKey = "NSSQLForeignKey";
		public static readonly RuntimeClass NSSQLGenerator = "NSSQLGenerator";
		public static readonly RuntimeClass NSSQLiteAdapter = "NSSQLiteAdapter";
		public static readonly RuntimeClass NSSQLiteConnection = "NSSQLiteConnection";
		public static readonly RuntimeClass NSSQLiteStatement = "NSSQLiteStatement";
		public static readonly RuntimeClass NSSQLManyToMany = "NSSQLManyToMany";
		public static readonly RuntimeClass NSSQLMappingGenerator = "NSSQLMappingGenerator";
		public static readonly RuntimeClass NSSQLModel = "NSSQLModel";
		public static readonly RuntimeClass NSSQLObjectID = "NSSQLObjectID";
		public static readonly RuntimeClass NSSQLObjectStore = "NSSQLObjectStore";
		public static readonly RuntimeClass NSSQLOperation = "NSSQLOperation";
		public static readonly RuntimeClass NSSQLOptLockKey = "NSSQLOptLockKey";
		public static readonly RuntimeClass NSSQLPrimaryKey = "NSSQLPrimaryKey";
		public static readonly RuntimeClass NSSQLProperty = "NSSQLProperty";
		public static readonly RuntimeClass NSSQLRelationship = "NSSQLRelationship";
		public static readonly RuntimeClass NSSQLRow = "NSSQLRow";
		public static readonly RuntimeClass NSSQLRowCache = "NSSQLRowCache";
		public static readonly RuntimeClass NSSQLStatement = "NSSQLStatement";
		public static readonly RuntimeClass NSSQLToMany = "NSSQLToMany";
		public static readonly RuntimeClass NSSQLToOne = "NSSQLToOne";
		public static readonly RuntimeClass NSStoreMapNode = "NSStoreMapNode";
		public static readonly RuntimeClass NSTemporaryObjectID = "NSTemporaryObjectID";
		public static readonly RuntimeClass NSValidationErrorLocalizationPolicy = "NSValidationErrorLocalizationPolicy";
		public static readonly RuntimeClass NSXMLDocumentMap = "NSXMLDocumentMap";
		public static readonly RuntimeClass NSXMLDocumentMapNode = "NSXMLDocumentMapNode";
		public static readonly RuntimeClass NSXMLObjectStore = "NSXMLObjectStore";
		public static readonly RuntimeClass NSString = "NSString";
		public static readonly RuntimeClass NSNumber = "NSNumber";
		public static readonly RuntimeClass NSData = "NSData";
	}
}
