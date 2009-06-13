//
// Copyright (C) 2009 Eugeny Grishul
//
// See license in License.txt
//

namespace NObjective.Proxies {
	using System;
	using System.Runtime.InteropServices;
	[ProxyBaseClass(typeof( NObjective.Proxies.Object ))]
	public struct List : IEquatable<List> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = libobjc_A_dylibCachedClasses.List;
		public static implicit operator IntPtr( List value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( List value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as List?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( List value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( List value1, List value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( List value1, List value2 ) {
			return value1.Handle != value2.Handle;
		}
		public List( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static List alloc() {
			return new List( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject newCount_( uint count ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newCount_( ClassHandle, CachedSelectors.newCount_, out ___occuredException, sizeof( uint ), count );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject addObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.addObject_( Handle, CachedSelectors.addObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject addObjectIfAbsent_( NObjective.RuntimeObject absent ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.addObjectIfAbsent_( Handle, CachedSelectors.addObjectIfAbsent_, out ___occuredException, sizeof( NObjective.RuntimeObject ), absent );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject appendList_( NObjective.RuntimeObject list ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.appendList_( Handle, CachedSelectors.appendList_, out ___occuredException, sizeof( NObjective.RuntimeObject ), list );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public uint capacity() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.capacity( Handle, CachedSelectors.capacity, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public uint count() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.count( Handle, CachedSelectors.count, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public NObjective.RuntimeObject empty() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.empty( Handle, CachedSelectors.empty, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject freeObjects() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.freeObjects( Handle, CachedSelectors.freeObjects, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public uint indexOf_( NObjective.RuntimeObject of ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.indexOf_( Handle, CachedSelectors.indexOf_, out ___occuredException, sizeof( NObjective.RuntimeObject ), of );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public NObjective.RuntimeObject initCount_( uint count ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initCount_( Handle, CachedSelectors.initCount_, out ___occuredException, sizeof( uint ), count );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject insertObject_at_( NObjective.RuntimeObject @object, uint at ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.insertObject_at_( Handle, CachedSelectors.insertObject_at_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ), @object, at );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject lastObject() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.lastObject( Handle, CachedSelectors.lastObject, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject makeObjectsPerform_( NObjective.Selector perform ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.makeObjectsPerform_( Handle, CachedSelectors.makeObjectsPerform_, out ___occuredException, sizeof( NObjective.Selector ), perform );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject makeObjectsPerform_with_( NObjective.Selector perform, NObjective.RuntimeObject with ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.makeObjectsPerform_with_( Handle, CachedSelectors.makeObjectsPerform_with_, out ___occuredException, sizeof( NObjective.Selector ) + sizeof( NObjective.RuntimeObject ), perform, with );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject objectAt_( uint at ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectAt_( Handle, CachedSelectors.objectAt_, out ___occuredException, sizeof( uint ), at );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject removeLastObject() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.removeLastObject( Handle, CachedSelectors.removeLastObject, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject removeObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.removeObject_( Handle, CachedSelectors.removeObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject removeObjectAt_( uint at ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.removeObjectAt_( Handle, CachedSelectors.removeObjectAt_, out ___occuredException, sizeof( uint ), at );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject replaceObject_with_( NObjective.RuntimeObject @object, NObjective.RuntimeObject with ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.replaceObject_with_( Handle, CachedSelectors.replaceObject_with_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), @object, with );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject replaceObjectAt_with_( uint at, NObjective.RuntimeObject with ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.replaceObjectAt_with_( Handle, CachedSelectors.replaceObjectAt_with_, out ___occuredException, sizeof( uint ) + sizeof( NObjective.RuntimeObject ), at, with );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject setAvailableCapacity_( uint capacity ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.setAvailableCapacity_( Handle, CachedSelectors.setAvailableCapacity_, out ___occuredException, sizeof( uint ), capacity );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr addObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr addObjectIfAbsent_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject absent );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr appendList_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject list );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint capacity( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint count( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr empty( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr freeObjects( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint indexOf_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject of );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initCount_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint count );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr insertObject_at_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, uint at );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr lastObject( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr makeObjectsPerform_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector perform );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr makeObjectsPerform_with_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector perform, NObjective.RuntimeObject with );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr newCount_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint count );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr objectAt_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint at );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr removeLastObject( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr removeObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr removeObjectAt_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint at );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr replaceObject_with_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, NObjective.RuntimeObject with );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr replaceObjectAt_with_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint at, NObjective.RuntimeObject with );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr setAvailableCapacity_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint capacity );
		}
		static internal class CachedSelectors {
			public static readonly Selector addObject_ = "addObject:";
			public static readonly Selector addObjectIfAbsent_ = "addObjectIfAbsent:";
			public static readonly Selector appendList_ = "appendList:";
			public static readonly Selector capacity = "capacity";
			public static readonly Selector count = "count";
			public static readonly Selector empty = "empty";
			public static readonly Selector freeObjects = "freeObjects";
			public static readonly Selector indexOf_ = "indexOf:";
			public static readonly Selector initCount_ = "initCount:";
			public static readonly Selector insertObject_at_ = "insertObject:at:";
			public static readonly Selector lastObject = "lastObject";
			public static readonly Selector makeObjectsPerform_ = "makeObjectsPerform:";
			public static readonly Selector makeObjectsPerform_with_ = "makeObjectsPerform:with:";
			public static readonly Selector newCount_ = "newCount:";
			public static readonly Selector objectAt_ = "objectAt:";
			public static readonly Selector removeLastObject = "removeLastObject";
			public static readonly Selector removeObject_ = "removeObject:";
			public static readonly Selector removeObjectAt_ = "removeObjectAt:";
			public static readonly Selector replaceObject_with_ = "replaceObject:with:";
			public static readonly Selector replaceObjectAt_with_ = "replaceObjectAt:with:";
			public static readonly Selector setAvailableCapacity_ = "setAvailableCapacity:";
		}
	}
	public struct Object : IEquatable<object> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = libobjc_A_dylibCachedClasses.Object;
		public override int GetHashCode() {
			return Handle.GetHashCode();
		}
		public static implicit operator IntPtr( NObjective.Proxies.Object value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NObjective.Proxies.Object value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NObjective.Proxies.Object?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NObjective.Proxies.Object value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NObjective.Proxies.Object value1, NObjective.Proxies.Object value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NObjective.Proxies.Object value1, NObjective.Proxies.Object value2 ) {
			return value1.Handle != value2.Handle;
		}
		public Object( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static object alloc() {
			return new NObjective.Proxies.Object( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		public override string ToString() {
			return Handle.InvokeString( Selectors.description );
		}
		unsafe public static NObjective.RuntimeObject allocFromZone_( System.IntPtr zone ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.allocFromZone_( ClassHandle, CachedSelectors.allocFromZone_, out ___occuredException, sizeof( System.IntPtr ), zone );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject __class() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__class( ClassHandle, CachedSelectors.__class, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static char __conformsTo_( NObjective.RuntimeObject to ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__conformsTo_( ClassHandle, CachedSelectors.__conformsTo_, out ___occuredException, sizeof( NObjective.RuntimeObject ), to );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static NObjective.RuntimeObject __free() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__free( ClassHandle, CachedSelectors.__free, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject initialize() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initialize( ClassHandle, CachedSelectors.initialize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static char instancesRespondTo_( NObjective.Selector to ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.instancesRespondTo_( ClassHandle, CachedSelectors.instancesRespondTo_, out ___occuredException, sizeof( NObjective.Selector ), to );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static System.IntPtr __name() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__name( ClassHandle, CachedSelectors.__name, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static NObjective.RuntimeObject @new() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.@new( ClassHandle, CachedSelectors.@new, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject poseAs_( NObjective.RuntimeObject @as ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.poseAs_( ClassHandle, CachedSelectors.poseAs_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @as );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject setVersion_( int version ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.setVersion_( ClassHandle, CachedSelectors.setVersion_, out ___occuredException, sizeof( int ), version );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject __superclass() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__superclass( ClassHandle, CachedSelectors.__superclass, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject __superClass() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.__superClass( ClassHandle, CachedSelectors.__superClass, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static int version() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.version( ClassHandle, CachedSelectors.version, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject awake() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.awake( Handle, CachedSelectors.awake, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject @class() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.@class( Handle, CachedSelectors.@class, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char conformsTo_( NObjective.RuntimeObject to ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.conformsTo_( Handle, CachedSelectors.conformsTo_, out ___occuredException, sizeof( NObjective.RuntimeObject ), to );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject copy() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.copy( Handle, CachedSelectors.copy, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject copyFromZone_( System.IntPtr zone ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.copyFromZone_( Handle, CachedSelectors.copyFromZone_, out ___occuredException, sizeof( System.IntPtr ), zone );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject doesNotRecognize_( NObjective.Selector recognize ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.doesNotRecognize_( Handle, CachedSelectors.doesNotRecognize_, out ___occuredException, sizeof( NObjective.Selector ), recognize );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject error_( System.IntPtr error ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.error_( Handle, CachedSelectors.error_, out ___occuredException, sizeof( System.IntPtr ), error );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject findClass_( System.IntPtr @class ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.findClass_( Handle, CachedSelectors.findClass_, out ___occuredException, sizeof( System.IntPtr ), @class );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject forward__( NObjective.Selector forward, System.IntPtr unnamedParameter ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.forward__( Handle, CachedSelectors.forward__, out ___occuredException, sizeof( NObjective.Selector ) + sizeof( System.IntPtr ), forward, unnamedParameter );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject free() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.free( Handle, CachedSelectors.free, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public uint hash() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.hash( Handle, CachedSelectors.hash, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public NObjective.RuntimeObject init() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.init( Handle, CachedSelectors.init, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public bool isEqual_( NObjective.RuntimeObject equal ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isEqual_( Handle, CachedSelectors.isEqual_, out ___occuredException, sizeof( NObjective.RuntimeObject ), equal );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isKindOf_( NObjective.RuntimeObject of ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isKindOf_( Handle, CachedSelectors.isKindOf_, out ___occuredException, sizeof( NObjective.RuntimeObject ), of );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isKindOfClassNamed_( System.IntPtr named ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isKindOfClassNamed_( Handle, CachedSelectors.isKindOfClassNamed_, out ___occuredException, sizeof( System.IntPtr ), named );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isKindOfGivenName_( System.IntPtr name ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isKindOfGivenName_( Handle, CachedSelectors.isKindOfGivenName_, out ___occuredException, sizeof( System.IntPtr ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isMemberOf_( NObjective.RuntimeObject of ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isMemberOf_( Handle, CachedSelectors.isMemberOf_, out ___occuredException, sizeof( NObjective.RuntimeObject ), of );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isMemberOfClassNamed_( System.IntPtr named ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isMemberOfClassNamed_( Handle, CachedSelectors.isMemberOfClassNamed_, out ___occuredException, sizeof( System.IntPtr ), named );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isMemberOfGivenName_( System.IntPtr name ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isMemberOfGivenName_( Handle, CachedSelectors.isMemberOfGivenName_, out ___occuredException, sizeof( System.IntPtr ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public uint methodArgSize_( NObjective.Selector size ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.methodArgSize_( Handle, CachedSelectors.methodArgSize_, out ___occuredException, sizeof( NObjective.Selector ), size );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public System.IntPtr name() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.name( Handle, CachedSelectors.name, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject notImplemented_( NObjective.Selector implemented ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.notImplemented_( Handle, CachedSelectors.notImplemented_, out ___occuredException, sizeof( NObjective.Selector ), implemented );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject perform_( NObjective.Selector perform ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.perform_( Handle, CachedSelectors.perform_, out ___occuredException, sizeof( NObjective.Selector ), perform );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject perform_with_( NObjective.Selector perform, NObjective.RuntimeObject with ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.perform_with_( Handle, CachedSelectors.perform_with_, out ___occuredException, sizeof( NObjective.Selector ) + sizeof( NObjective.RuntimeObject ), perform, with );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject perform_with_with_( NObjective.Selector perform, NObjective.RuntimeObject with, NObjective.RuntimeObject with2 ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.perform_with_with_( Handle, CachedSelectors.perform_with_with_, out ___occuredException, sizeof( NObjective.Selector ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), perform, with, with2 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject performv__( NObjective.Selector performv, System.IntPtr unnamedParameter ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.performv__( Handle, CachedSelectors.performv__, out ___occuredException, sizeof( NObjective.Selector ) + sizeof( System.IntPtr ), performv, unnamedParameter );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void printForDebugger_( System.IntPtr debugger ) {
			RuntimeObject ___occuredException;
			NativeMethods.printForDebugger_( Handle, CachedSelectors.printForDebugger_, out ___occuredException, sizeof( System.IntPtr ), debugger );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject read_( System.IntPtr read ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.read_( Handle, CachedSelectors.read_, out ___occuredException, sizeof( System.IntPtr ), read );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char respondsTo_( NObjective.Selector to ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.respondsTo_( Handle, CachedSelectors.respondsTo_, out ___occuredException, sizeof( NObjective.Selector ), to );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject self() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.self( Handle, CachedSelectors.self, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject shouldNotImplement_( NObjective.Selector implement ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.shouldNotImplement_( Handle, CachedSelectors.shouldNotImplement_, out ___occuredException, sizeof( NObjective.Selector ), implement );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject subclassResponsibility_( NObjective.Selector responsibility ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.subclassResponsibility_( Handle, CachedSelectors.subclassResponsibility_, out ___occuredException, sizeof( NObjective.Selector ), responsibility );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject superclass() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.superclass( Handle, CachedSelectors.superclass, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject superClass() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.superClass( Handle, CachedSelectors.superClass, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject write_( System.IntPtr write ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.write_( Handle, CachedSelectors.write_, out ___occuredException, sizeof( System.IntPtr ), write );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public System.IntPtr zone() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.zone( Handle, CachedSelectors.zone, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr __class( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char __conformsTo_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject to );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr __free( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern System.IntPtr __name( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr __superclass( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr __superClass( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr allocFromZone_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr zone );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr awake( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr @class( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char conformsTo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject to );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr copy( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr copyFromZone_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr zone );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr doesNotRecognize_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector recognize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr error_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr error );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr findClass_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr @class );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr forward__( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector forward, System.IntPtr unnamedParameter );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr free( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint hash( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr init( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initialize( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char instancesRespondTo_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector to );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool isEqual_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject equal );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool isKindOf_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject of );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool isKindOfClassNamed_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr named );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool isKindOfGivenName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr name );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool isMemberOf_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject of );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool isMemberOfClassNamed_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr named );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool isMemberOfGivenName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr name );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint methodArgSize_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector size );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern System.IntPtr name( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr @new( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr notImplemented_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector implemented );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr perform_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector perform );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr perform_with_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector perform, NObjective.RuntimeObject with );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr perform_with_with_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector perform, NObjective.RuntimeObject with, NObjective.RuntimeObject with2 );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr performv__( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector performv, System.IntPtr unnamedParameter );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr poseAs_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @as );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void printForDebugger_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr debugger );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr read_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr read );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char respondsTo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector to );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr self( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr setVersion_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int version );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr shouldNotImplement_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector implement );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr subclassResponsibility_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector responsibility );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr superclass( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr superClass( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern int version( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr write_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr write );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern System.IntPtr zone( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector __class = "__class";
			public static readonly Selector __conformsTo_ = "__conformsTo:";
			public static readonly Selector __free = "__free";
			public static readonly Selector __name = "__name";
			public static readonly Selector __superclass = "__superclass";
			public static readonly Selector __superClass = "__superClass";
			public static readonly Selector allocFromZone_ = "allocFromZone:";
			public static readonly Selector awake = "awake";
			public static readonly Selector @class = "class";
			public static readonly Selector conformsTo_ = "conformsTo:";
			public static readonly Selector copy = "copy";
			public static readonly Selector copyFromZone_ = "copyFromZone:";
			public static readonly Selector doesNotRecognize_ = "doesNotRecognize:";
			public static readonly Selector error_ = "error:";
			public static readonly Selector findClass_ = "findClass:";
			public static readonly Selector forward__ = "forward::";
			public static readonly Selector free = "free";
			public static readonly Selector hash = "hash";
			public static readonly Selector init = "init";
			public static readonly Selector initialize = "initialize";
			public static readonly Selector instancesRespondTo_ = "instancesRespondTo:";
			public static readonly Selector isEqual_ = "isEqual:";
			public static readonly Selector isKindOf_ = "isKindOf:";
			public static readonly Selector isKindOfClassNamed_ = "isKindOfClassNamed:";
			public static readonly Selector isKindOfGivenName_ = "isKindOfGivenName:";
			public static readonly Selector isMemberOf_ = "isMemberOf:";
			public static readonly Selector isMemberOfClassNamed_ = "isMemberOfClassNamed:";
			public static readonly Selector isMemberOfGivenName_ = "isMemberOfGivenName:";
			public static readonly Selector methodArgSize_ = "methodArgSize:";
			public static readonly Selector name = "name";
			public static readonly Selector @new = "new";
			public static readonly Selector notImplemented_ = "notImplemented:";
			public static readonly Selector perform_ = "perform:";
			public static readonly Selector perform_with_ = "perform:with:";
			public static readonly Selector perform_with_with_ = "perform:with:with:";
			public static readonly Selector performv__ = "performv::";
			public static readonly Selector poseAs_ = "poseAs:";
			public static readonly Selector printForDebugger_ = "printForDebugger:";
			public static readonly Selector read_ = "read:";
			public static readonly Selector respondsTo_ = "respondsTo:";
			public static readonly Selector self = "self";
			public static readonly Selector setVersion_ = "setVersion:";
			public static readonly Selector shouldNotImplement_ = "shouldNotImplement:";
			public static readonly Selector subclassResponsibility_ = "subclassResponsibility:";
			public static readonly Selector superclass = "superclass";
			public static readonly Selector superClass = "superClass";
			public static readonly Selector version = "version";
			public static readonly Selector write_ = "write:";
			public static readonly Selector zone = "zone";
		}
	}
	[ProxyBaseClass(typeof( NObjective.Proxies.Object ))]
	public struct Protocol : IEquatable<Protocol> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = libobjc_A_dylibCachedClasses.Protocol;
		public static implicit operator IntPtr( Protocol value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( Protocol value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as Protocol?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( Protocol value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( Protocol value1, Protocol value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( Protocol value1, Protocol value2 ) {
			return value1.Handle != value2.Handle;
		}
		public Protocol( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static Protocol alloc() {
			return new Protocol( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	static internal class libobjc_A_dylibCachedClasses {
		static internal int ___lazyLoad = Platform.NativeMethods.dlopen( "/usr/lib/libobjc.A.dylib" );
		public static readonly RuntimeClass List = "List";
		public static readonly RuntimeClass Object = "Object";
		public static readonly RuntimeClass Protocol = "Protocol";
	}
}
