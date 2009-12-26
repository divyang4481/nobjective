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
	public struct DRBurn : IEquatable<DRBurn> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingEngineCachedClasses.DRBurn;
		public static implicit operator NSObject( DRBurn value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( DRBurn value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRBurn value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as DRBurn?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( DRBurn value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRBurn value1, DRBurn value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRBurn value1, DRBurn value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRBurn( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRBurn alloc() {
			return new DRBurn( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static DRBurn burnForDevice_( DRDevice device ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.burnForDevice_( ClassHandle, CachedSelectors.burnForDevice_, out ___occuredException, sizeof( DRDevice ), device );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRBurn( ___result );
		}
		unsafe public void abort() {
			RuntimeObject ___occuredException;
			NativeMethods.abort( Handle, CachedSelectors.abort, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public bool appendable() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.appendable( Handle, CachedSelectors.appendable, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char burnUnderrunProtection() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.burnUnderrunProtection( Handle, CachedSelectors.burnUnderrunProtection, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public string completionAction() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.completionAction( Handle, CachedSelectors.completionAction, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public DRDevice device() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.device( Handle, CachedSelectors.device, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRDevice( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithDevice_( DRDevice device ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithDevice_( Handle, CachedSelectors.initWithDevice_, out ___occuredException, sizeof( DRDevice ), device );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSDictionary properties() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.properties( Handle, CachedSelectors.properties, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public float requestedBurnSpeed() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.requestedBurnSpeed( Handle, CachedSelectors.requestedBurnSpeed, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void setAppendable_( bool appendable ) {
			RuntimeObject ___occuredException;
			NativeMethods.setAppendable_( Handle, CachedSelectors.setAppendable_, out ___occuredException, sizeof( bool ), appendable );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setBurnUnderrunProtection_( char protection ) {
			RuntimeObject ___occuredException;
			NativeMethods.setBurnUnderrunProtection_( Handle, CachedSelectors.setBurnUnderrunProtection_, out ___occuredException, sizeof( char ), protection );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setCompletionAction_( string action ) {
			RuntimeObject ___occuredException;
			var ___wrappedaction = Runtime.CreateStringProxy( action );
			NativeMethods.setCompletionAction_( Handle, CachedSelectors.setCompletionAction_, out ___occuredException, sizeof( IntPtr ), ___wrappedaction );
			Runtime.ReleaseNativeObject( ___wrappedaction );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setProperties_( NSDictionary properties ) {
			RuntimeObject ___occuredException;
			NativeMethods.setProperties_( Handle, CachedSelectors.setProperties_, out ___occuredException, sizeof( NSDictionary ), properties );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setRequestedBurnSpeed_( float speed ) {
			RuntimeObject ___occuredException;
			NativeMethods.setRequestedBurnSpeed_( Handle, CachedSelectors.setRequestedBurnSpeed_, out ___occuredException, sizeof( float ), speed );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setTestBurn_( char burn ) {
			RuntimeObject ___occuredException;
			NativeMethods.setTestBurn_( Handle, CachedSelectors.setTestBurn_, out ___occuredException, sizeof( char ), burn );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setVerifyDisc_( bool disc ) {
			RuntimeObject ___occuredException;
			NativeMethods.setVerifyDisc_( Handle, CachedSelectors.setVerifyDisc_, out ___occuredException, sizeof( bool ), disc );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSDictionary status() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.status( Handle, CachedSelectors.status, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public char testBurn() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.testBurn( Handle, CachedSelectors.testBurn, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool verifyDisc() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.verifyDisc( Handle, CachedSelectors.verifyDisc, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void writeLayout_( NObjective.RuntimeObject layout ) {
			RuntimeObject ___occuredException;
			NativeMethods.writeLayout_( Handle, CachedSelectors.writeLayout_, out ___occuredException, sizeof( NObjective.RuntimeObject ), layout );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void abort( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool appendable( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr burnForDevice_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRDevice device );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char burnUnderrunProtection( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr completionAction( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr device( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithDevice_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRDevice device );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr properties( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern float requestedBurnSpeed( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setAppendable_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, bool appendable );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setBurnUnderrunProtection_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, char protection );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setCompletionAction_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr action );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setProperties_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDictionary properties );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setRequestedBurnSpeed_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, float speed );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setTestBurn_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, char burn );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setVerifyDisc_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, bool disc );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr status( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char testBurn( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool verifyDisc( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void writeLayout_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject layout );
		}
		static internal class CachedSelectors {
			public static readonly Selector abort = "abort";
			public static readonly Selector appendable = "appendable";
			public static readonly Selector burnForDevice_ = "burnForDevice:";
			public static readonly Selector burnUnderrunProtection = "burnUnderrunProtection";
			public static readonly Selector completionAction = "completionAction";
			public static readonly Selector device = "device";
			public static readonly Selector initWithDevice_ = "initWithDevice:";
			public static readonly Selector properties = "properties";
			public static readonly Selector requestedBurnSpeed = "requestedBurnSpeed";
			public static readonly Selector setAppendable_ = "setAppendable:";
			public static readonly Selector setBurnUnderrunProtection_ = "setBurnUnderrunProtection:";
			public static readonly Selector setCompletionAction_ = "setCompletionAction:";
			public static readonly Selector setProperties_ = "setProperties:";
			public static readonly Selector setRequestedBurnSpeed_ = "setRequestedBurnSpeed:";
			public static readonly Selector setTestBurn_ = "setTestBurn:";
			public static readonly Selector setVerifyDisc_ = "setVerifyDisc:";
			public static readonly Selector status = "status";
			public static readonly Selector testBurn = "testBurn";
			public static readonly Selector verifyDisc = "verifyDisc";
			public static readonly Selector writeLayout_ = "writeLayout:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( DRDevice ) )]
	public struct DRCallbackDevice : IEquatable<DRCallbackDevice> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingEngineCachedClasses.DRCallbackDevice;
		public static implicit operator DRDevice( DRCallbackDevice value ) {
			return new DRDevice( value.Handle );
		}
		public static implicit operator NSObject( DRCallbackDevice value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( DRCallbackDevice value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRCallbackDevice value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as DRCallbackDevice?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( DRCallbackDevice value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRCallbackDevice value1, DRCallbackDevice value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRCallbackDevice value1, DRCallbackDevice value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRCallbackDevice( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRCallbackDevice alloc() {
			return new DRCallbackDevice( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject initWithConsumer_( NObjective.RuntimeObject consumer ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithConsumer_( Handle, CachedSelectors.initWithConsumer_, out ___occuredException, sizeof( NObjective.RuntimeObject ), consumer );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithConsumer_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject consumer );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithConsumer_ = "initWithConsumer:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct DRCDTextBlock : IEquatable<DRCDTextBlock> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingEngineCachedClasses.DRCDTextBlock;
		public static implicit operator NSObject( DRCDTextBlock value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( DRCDTextBlock value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRCDTextBlock value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as DRCDTextBlock?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( DRCDTextBlock value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRCDTextBlock value1, DRCDTextBlock value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRCDTextBlock value1, DRCDTextBlock value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRCDTextBlock( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRCDTextBlock alloc() {
			return new DRCDTextBlock( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NSArray arrayOfCDTextBlocksFromPacks_( NSData packs ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.arrayOfCDTextBlocksFromPacks_( ClassHandle, CachedSelectors.arrayOfCDTextBlocksFromPacks_, out ___occuredException, sizeof( NSData ), packs );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public static DRCDTextBlock cdTextBlockWithLanguage_encoding_( string language, uint encoding ) {
			RuntimeObject ___occuredException;
			var ___wrappedlanguage = Runtime.CreateStringProxy( language );
			var ___result = NativeMethods.cdTextBlockWithLanguage_encoding_( ClassHandle, CachedSelectors.cdTextBlockWithLanguage_encoding_, out ___occuredException, sizeof( IntPtr ) + sizeof( uint ), ___wrappedlanguage, encoding );
			Runtime.ReleaseNativeObject( ___wrappedlanguage );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRCDTextBlock( ___result );
		}
		unsafe public uint encoding() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.encoding( Handle, CachedSelectors.encoding, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public uint flatten() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.flatten( Handle, CachedSelectors.flatten, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public NObjective.RuntimeObject initWithLanguage_encoding_( string language, uint encoding ) {
			RuntimeObject ___occuredException;
			var ___wrappedlanguage = Runtime.CreateStringProxy( language );
			var ___result = NativeMethods.initWithLanguage_encoding_( Handle, CachedSelectors.initWithLanguage_encoding_, out ___occuredException, sizeof( IntPtr ) + sizeof( uint ), ___wrappedlanguage, encoding );
			Runtime.ReleaseNativeObject( ___wrappedlanguage );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public string language() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.language( Handle, CachedSelectors.language, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public NObjective.RuntimeObject objectForKey_ofTrack_( string key, uint ofTrack ) {
			RuntimeObject ___occuredException;
			var ___wrappedkey = Runtime.CreateStringProxy( key );
			var ___result = NativeMethods.objectForKey_ofTrack_( Handle, CachedSelectors.objectForKey_ofTrack_, out ___occuredException, sizeof( IntPtr ) + sizeof( uint ), ___wrappedkey, ofTrack );
			Runtime.ReleaseNativeObject( ___wrappedkey );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSDictionary properties() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.properties( Handle, CachedSelectors.properties, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public void setObject_forKey_ofTrack_( NObjective.RuntimeObject @object, string forKey, uint ofTrack ) {
			RuntimeObject ___occuredException;
			var ___wrappedforKey = Runtime.CreateStringProxy( forKey );
			NativeMethods.setObject_forKey_ofTrack_( Handle, CachedSelectors.setObject_forKey_ofTrack_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( IntPtr ) + sizeof( uint ), @object, ___wrappedforKey, ofTrack );
			Runtime.ReleaseNativeObject( ___wrappedforKey );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setProperties_( NSDictionary properties ) {
			RuntimeObject ___occuredException;
			NativeMethods.setProperties_( Handle, CachedSelectors.setProperties_, out ___occuredException, sizeof( NSDictionary ), properties );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setTrackDictionaries_( NSArray dictionaries ) {
			RuntimeObject ___occuredException;
			NativeMethods.setTrackDictionaries_( Handle, CachedSelectors.setTrackDictionaries_, out ___occuredException, sizeof( NSArray ), dictionaries );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSArray trackDictionaries() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.trackDictionaries( Handle, CachedSelectors.trackDictionaries, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr arrayOfCDTextBlocksFromPacks_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSData packs );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr cdTextBlockWithLanguage_encoding_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr language, uint encoding );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint encoding( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint flatten( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithLanguage_encoding_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr language, uint encoding );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr language( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr objectForKey_ofTrack_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr key, uint ofTrack );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr properties( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setObject_forKey_ofTrack_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, IntPtr forKey, uint ofTrack );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setProperties_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDictionary properties );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setTrackDictionaries_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray dictionaries );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr trackDictionaries( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector arrayOfCDTextBlocksFromPacks_ = "arrayOfCDTextBlocksFromPacks:";
			public static readonly Selector cdTextBlockWithLanguage_encoding_ = "cdTextBlockWithLanguage:encoding:";
			public static readonly Selector encoding = "encoding";
			public static readonly Selector flatten = "flatten";
			public static readonly Selector initWithLanguage_encoding_ = "initWithLanguage:encoding:";
			public static readonly Selector language = "language";
			public static readonly Selector objectForKey_ofTrack_ = "objectForKey:ofTrack:";
			public static readonly Selector properties = "properties";
			public static readonly Selector setObject_forKey_ofTrack_ = "setObject:forKey:ofTrack:";
			public static readonly Selector setProperties_ = "setProperties:";
			public static readonly Selector setTrackDictionaries_ = "setTrackDictionaries:";
			public static readonly Selector trackDictionaries = "trackDictionaries";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct DRDevice : IEquatable<DRDevice> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingEngineCachedClasses.DRDevice;
		public static implicit operator NSObject( DRDevice value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( DRDevice value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRDevice value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as DRDevice?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( DRDevice value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRDevice value1, DRDevice value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRDevice value1, DRDevice value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRDevice( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRDevice alloc() {
			return new DRDevice( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static DRDevice deviceForBSDName_( string name ) {
			RuntimeObject ___occuredException;
			var ___wrappedname = Runtime.CreateStringProxy( name );
			var ___result = NativeMethods.deviceForBSDName_( ClassHandle, CachedSelectors.deviceForBSDName_, out ___occuredException, sizeof( IntPtr ), ___wrappedname );
			Runtime.ReleaseNativeObject( ___wrappedname );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRDevice( ___result );
		}
		unsafe public static DRDevice deviceForIORegistryEntryPath_( string path ) {
			RuntimeObject ___occuredException;
			var ___wrappedpath = Runtime.CreateStringProxy( path );
			var ___result = NativeMethods.deviceForIORegistryEntryPath_( ClassHandle, CachedSelectors.deviceForIORegistryEntryPath_, out ___occuredException, sizeof( IntPtr ), ___wrappedpath );
			Runtime.ReleaseNativeObject( ___wrappedpath );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRDevice( ___result );
		}
		unsafe public static NSArray devices() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.devices( ClassHandle, CachedSelectors.devices, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public static void XMLAddComplianceDTDToDTD_( NObjective.RuntimeObject dtd ) {
			RuntimeObject ___occuredException;
			NativeMethods.XMLAddComplianceDTDToDTD_( ClassHandle, CachedSelectors.XMLAddComplianceDTDToDTD_, out ___occuredException, sizeof( NObjective.RuntimeObject ), dtd );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static void XMLAddComplianceListDTDToDTD_( NObjective.RuntimeObject dtd ) {
			RuntimeObject ___occuredException;
			NativeMethods.XMLAddComplianceListDTDToDTD_( ClassHandle, CachedSelectors.XMLAddComplianceListDTDToDTD_, out ___occuredException, sizeof( NObjective.RuntimeObject ), dtd );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static void XMLAddDeviceDTDToDTD_( NObjective.RuntimeObject dtd ) {
			RuntimeObject ___occuredException;
			NativeMethods.XMLAddDeviceDTDToDTD_( ClassHandle, CachedSelectors.XMLAddDeviceDTDToDTD_, out ___occuredException, sizeof( NObjective.RuntimeObject ), dtd );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static void XMLAddDeviceInfoDTDToDTD_( NObjective.RuntimeObject dtd ) {
			RuntimeObject ___occuredException;
			NativeMethods.XMLAddDeviceInfoDTDToDTD_( ClassHandle, CachedSelectors.XMLAddDeviceInfoDTDToDTD_, out ___occuredException, sizeof( NObjective.RuntimeObject ), dtd );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static void XMLAddDeviceListDTDToDTD_( NObjective.RuntimeObject dtd ) {
			RuntimeObject ___occuredException;
			NativeMethods.XMLAddDeviceListDTDToDTD_( ClassHandle, CachedSelectors.XMLAddDeviceListDTDToDTD_, out ___occuredException, sizeof( NObjective.RuntimeObject ), dtd );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static void XMLAddDeviceStatusDTDToDTD_( NObjective.RuntimeObject dtd ) {
			RuntimeObject ___occuredException;
			NativeMethods.XMLAddDeviceStatusDTDToDTD_( ClassHandle, CachedSelectors.XMLAddDeviceStatusDTDToDTD_, out ___occuredException, sizeof( NObjective.RuntimeObject ), dtd );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static void XMLAddDiscInfoDTDToDTD_( NObjective.RuntimeObject dtd ) {
			RuntimeObject ___occuredException;
			NativeMethods.XMLAddDiscInfoDTDToDTD_( ClassHandle, CachedSelectors.XMLAddDiscInfoDTDToDTD_, out ___occuredException, sizeof( NObjective.RuntimeObject ), dtd );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static void XMLAddFirmwareDTDToDTD_( NObjective.RuntimeObject dtd ) {
			RuntimeObject ___occuredException;
			NativeMethods.XMLAddFirmwareDTDToDTD_( ClassHandle, CachedSelectors.XMLAddFirmwareDTDToDTD_, out ___occuredException, sizeof( NObjective.RuntimeObject ), dtd );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static void XMLAddInquiryDTDToDTD_( NObjective.RuntimeObject dtd ) {
			RuntimeObject ___occuredException;
			NativeMethods.XMLAddInquiryDTDToDTD_( ClassHandle, CachedSelectors.XMLAddInquiryDTDToDTD_, out ___occuredException, sizeof( NObjective.RuntimeObject ), dtd );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static void XMLAddInterconnectDTDToDTD_( NObjective.RuntimeObject dtd ) {
			RuntimeObject ___occuredException;
			NativeMethods.XMLAddInterconnectDTDToDTD_( ClassHandle, CachedSelectors.XMLAddInterconnectDTDToDTD_, out ___occuredException, sizeof( NObjective.RuntimeObject ), dtd );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static void XMLAddMediaInfoDTDToDTD_( NObjective.RuntimeObject dtd ) {
			RuntimeObject ___occuredException;
			NativeMethods.XMLAddMediaInfoDTDToDTD_( ClassHandle, CachedSelectors.XMLAddMediaInfoDTDToDTD_, out ___occuredException, sizeof( NObjective.RuntimeObject ), dtd );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static void XMLAddProductDTDToDTD_( NObjective.RuntimeObject dtd ) {
			RuntimeObject ___occuredException;
			NativeMethods.XMLAddProductDTDToDTD_( ClassHandle, CachedSelectors.XMLAddProductDTDToDTD_, out ___occuredException, sizeof( NObjective.RuntimeObject ), dtd );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static void XMLAddProfileListDTDToDTD_( NObjective.RuntimeObject dtd ) {
			RuntimeObject ___occuredException;
			NativeMethods.XMLAddProfileListDTDToDTD_( ClassHandle, CachedSelectors.XMLAddProfileListDTDToDTD_, out ___occuredException, sizeof( NObjective.RuntimeObject ), dtd );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static void XMLAddProfilePathDTDToDTD_( NObjective.RuntimeObject dtd ) {
			RuntimeObject ___occuredException;
			NativeMethods.XMLAddProfilePathDTDToDTD_( ClassHandle, CachedSelectors.XMLAddProfilePathDTDToDTD_, out ___occuredException, sizeof( NObjective.RuntimeObject ), dtd );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static void XMLAddRawDataDTDToDTD_( NObjective.RuntimeObject dtd ) {
			RuntimeObject ___occuredException;
			NativeMethods.XMLAddRawDataDTDToDTD_( ClassHandle, CachedSelectors.XMLAddRawDataDTDToDTD_, out ___occuredException, sizeof( NObjective.RuntimeObject ), dtd );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static void XMLAddSupportDTDToDTD_( NObjective.RuntimeObject dtd ) {
			RuntimeObject ___occuredException;
			NativeMethods.XMLAddSupportDTDToDTD_( ClassHandle, CachedSelectors.XMLAddSupportDTDToDTD_, out ___occuredException, sizeof( NObjective.RuntimeObject ), dtd );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static void XMLAddTrackInfoListDTDToDTD_( NObjective.RuntimeObject dtd ) {
			RuntimeObject ___occuredException;
			NativeMethods.XMLAddTrackInfoListDTDToDTD_( ClassHandle, CachedSelectors.XMLAddTrackInfoListDTDToDTD_, out ___occuredException, sizeof( NObjective.RuntimeObject ), dtd );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static void XMLAddVendorDTDToDTD_( NObjective.RuntimeObject dtd ) {
			RuntimeObject ___occuredException;
			NativeMethods.XMLAddVendorDTDToDTD_( ClassHandle, CachedSelectors.XMLAddVendorDTDToDTD_, out ___occuredException, sizeof( NObjective.RuntimeObject ), dtd );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static NObjective.RuntimeObject XMLComplianceElementWithNumber_( NObjective.RuntimeObject number ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.XMLComplianceElementWithNumber_( ClassHandle, CachedSelectors.XMLComplianceElementWithNumber_, out ___occuredException, sizeof( NObjective.RuntimeObject ), number );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject XMLComplianceListElementWithArray_( NObjective.RuntimeObject array ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.XMLComplianceListElementWithArray_( ClassHandle, CachedSelectors.XMLComplianceListElementWithArray_, out ___occuredException, sizeof( NObjective.RuntimeObject ), array );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject XMLDeviceListElement() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.XMLDeviceListElement( ClassHandle, CachedSelectors.XMLDeviceListElement, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject XMLRawDataElementWithData_( NObjective.RuntimeObject data ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.XMLRawDataElementWithData_( ClassHandle, CachedSelectors.XMLRawDataElementWithData_, out ___occuredException, sizeof( NObjective.RuntimeObject ), data );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public bool acquireExclusiveAccess() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.acquireExclusiveAccess( Handle, CachedSelectors.acquireExclusiveAccess, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void acquireMediaReservation() {
			RuntimeObject ___occuredException;
			NativeMethods.acquireMediaReservation( Handle, CachedSelectors.acquireMediaReservation, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public char appleShipping() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.appleShipping( Handle, CachedSelectors.appleShipping, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char appleSupported() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.appleSupported( Handle, CachedSelectors.appleSupported, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public string bsdName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.bsdName( Handle, CachedSelectors.bsdName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public NObjective.RuntimeObject cdText() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.cdText( Handle, CachedSelectors.cdText, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public bool closeTray() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.closeTray( Handle, CachedSelectors.closeTray, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public float currentWriteSpeed() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.currentWriteSpeed( Handle, CachedSelectors.currentWriteSpeed, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public string displayName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.displayName( Handle, CachedSelectors.displayName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public bool ejectMedia() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.ejectMedia( Handle, CachedSelectors.ejectMedia, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject firmwareString() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.firmwareString( Handle, CachedSelectors.firmwareString, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSDictionary info() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.info( Handle, CachedSelectors.info, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithRegistryPath_forGUID_( NObjective.RuntimeObject path, NObjective.RuntimeObject forGUID ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithRegistryPath_forGUID_( Handle, CachedSelectors.initWithRegistryPath_forGUID_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), path, forGUID );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithRegistryPath_forGUID_usingProfile_( NObjective.RuntimeObject path, NObjective.RuntimeObject forGUID, NObjective.RuntimeObject usingProfile ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithRegistryPath_forGUID_usingProfile_( Handle, CachedSelectors.initWithRegistryPath_forGUID_usingProfile_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), path, forGUID, usingProfile );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject interconnectString() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.interconnectString( Handle, CachedSelectors.interconnectString, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public string ioRegistryEntryPath() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.ioRegistryEntryPath( Handle, CachedSelectors.ioRegistryEntryPath, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public bool isEqualToDevice_( DRDevice device ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isEqualToDevice_( Handle, CachedSelectors.isEqualToDevice_, out ___occuredException, sizeof( DRDevice ), device );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isSupported() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isSupported( Handle, CachedSelectors.isSupported, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool isValid() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isValid( Handle, CachedSelectors.isValid, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public float maximumWriteSpeed() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.maximumWriteSpeed( Handle, CachedSelectors.maximumWriteSpeed, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool mediaIsAppendable() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mediaIsAppendable( Handle, CachedSelectors.mediaIsAppendable, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool mediaIsBlank() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mediaIsBlank( Handle, CachedSelectors.mediaIsBlank, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool mediaIsBusy() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mediaIsBusy( Handle, CachedSelectors.mediaIsBusy, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool mediaIsErasable() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mediaIsErasable( Handle, CachedSelectors.mediaIsErasable, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool mediaIsOverwritable() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mediaIsOverwritable( Handle, CachedSelectors.mediaIsOverwritable, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool mediaIsPresent() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mediaIsPresent( Handle, CachedSelectors.mediaIsPresent, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool mediaIsReserved() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mediaIsReserved( Handle, CachedSelectors.mediaIsReserved, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool mediaIsTransitioning() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mediaIsTransitioning( Handle, CachedSelectors.mediaIsTransitioning, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public uint mediaSessionCount() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mediaSessionCount( Handle, CachedSelectors.mediaSessionCount, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public DRMSF mediaSpaceFree() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mediaSpaceFree( Handle, CachedSelectors.mediaSpaceFree, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRMSF( ___result );
		}
		unsafe public DRMSF mediaSpaceOverwritable() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mediaSpaceOverwritable( Handle, CachedSelectors.mediaSpaceOverwritable, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRMSF( ___result );
		}
		unsafe public DRMSF mediaSpaceUsed() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mediaSpaceUsed( Handle, CachedSelectors.mediaSpaceUsed, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRMSF( ___result );
		}
		unsafe public uint mediaTrackCount() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mediaTrackCount( Handle, CachedSelectors.mediaTrackCount, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public string mediaType() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mediaType( Handle, CachedSelectors.mediaType, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public bool openTray() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.openTray( Handle, CachedSelectors.openTray, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject productString() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.productString( Handle, CachedSelectors.productString, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void releaseExclusiveAccess() {
			RuntimeObject ___occuredException;
			NativeMethods.releaseExclusiveAccess( Handle, CachedSelectors.releaseExclusiveAccess, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void releaseMediaReservation() {
			RuntimeObject ___occuredException;
			NativeMethods.releaseMediaReservation( Handle, CachedSelectors.releaseMediaReservation, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSDictionary status() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.status( Handle, CachedSelectors.status, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public bool trayIsOpen() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.trayIsOpen( Handle, CachedSelectors.trayIsOpen, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject vendorString() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.vendorString( Handle, CachedSelectors.vendorString, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char vendorSupported() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.vendorSupported( Handle, CachedSelectors.vendorSupported, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool writesCD() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.writesCD( Handle, CachedSelectors.writesCD, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char writesCDR() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.writesCDR( Handle, CachedSelectors.writesCDR, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char writesCDRW() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.writesCDRW( Handle, CachedSelectors.writesCDRW, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char writesCDText() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.writesCDText( Handle, CachedSelectors.writesCDText, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool writesDVD() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.writesDVD( Handle, CachedSelectors.writesDVD, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char writesDVDR() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.writesDVDR( Handle, CachedSelectors.writesDVDR, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char writesDVDRAM() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.writesDVDRAM( Handle, CachedSelectors.writesDVDRAM, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject XMLDeviceElement() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.XMLDeviceElement( Handle, CachedSelectors.XMLDeviceElement, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject XMLDeviceInfoElement() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.XMLDeviceInfoElement( Handle, CachedSelectors.XMLDeviceInfoElement, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject XMLDeviceStatusElement() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.XMLDeviceStatusElement( Handle, CachedSelectors.XMLDeviceStatusElement, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject XMLDiscInfoElement() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.XMLDiscInfoElement( Handle, CachedSelectors.XMLDiscInfoElement, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject XMLFirmwareElement() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.XMLFirmwareElement( Handle, CachedSelectors.XMLFirmwareElement, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject XMLInquiryElement() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.XMLInquiryElement( Handle, CachedSelectors.XMLInquiryElement, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject XMLInterconnectElement() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.XMLInterconnectElement( Handle, CachedSelectors.XMLInterconnectElement, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject XMLMediaInfoElement() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.XMLMediaInfoElement( Handle, CachedSelectors.XMLMediaInfoElement, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject XMLProductElement() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.XMLProductElement( Handle, CachedSelectors.XMLProductElement, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject XMLProfileListElement() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.XMLProfileListElement( Handle, CachedSelectors.XMLProfileListElement, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject XMLProfilePathElement() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.XMLProfilePathElement( Handle, CachedSelectors.XMLProfilePathElement, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject XMLSupportElement() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.XMLSupportElement( Handle, CachedSelectors.XMLSupportElement, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject XMLTrackInfoListElement() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.XMLTrackInfoListElement( Handle, CachedSelectors.XMLTrackInfoListElement, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject XMLVendorElement() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.XMLVendorElement( Handle, CachedSelectors.XMLVendorElement, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool acquireExclusiveAccess( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void acquireMediaReservation( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char appleShipping( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char appleSupported( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr bsdName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr cdText( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool closeTray( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern float currentWriteSpeed( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr deviceForBSDName_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr deviceForIORegistryEntryPath_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr path );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr devices( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr displayName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool ejectMedia( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr firmwareString( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr info( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithRegistryPath_forGUID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject path, NObjective.RuntimeObject forGUID );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithRegistryPath_forGUID_usingProfile_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject path, NObjective.RuntimeObject forGUID, NObjective.RuntimeObject usingProfile );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr interconnectString( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr ioRegistryEntryPath( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isEqualToDevice_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRDevice device );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isSupported( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isValid( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern float maximumWriteSpeed( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool mediaIsAppendable( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool mediaIsBlank( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool mediaIsBusy( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool mediaIsErasable( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool mediaIsOverwritable( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool mediaIsPresent( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool mediaIsReserved( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool mediaIsTransitioning( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint mediaSessionCount( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr mediaSpaceFree( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr mediaSpaceOverwritable( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr mediaSpaceUsed( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint mediaTrackCount( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr mediaType( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool openTray( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr productString( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void releaseExclusiveAccess( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void releaseMediaReservation( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr status( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool trayIsOpen( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr vendorString( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char vendorSupported( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool writesCD( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char writesCDR( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char writesCDRW( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char writesCDText( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool writesDVD( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char writesDVDR( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char writesDVDRAM( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void XMLAddComplianceDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void XMLAddComplianceListDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void XMLAddDeviceDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void XMLAddDeviceInfoDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void XMLAddDeviceListDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void XMLAddDeviceStatusDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void XMLAddDiscInfoDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void XMLAddFirmwareDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void XMLAddInquiryDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void XMLAddInterconnectDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void XMLAddMediaInfoDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void XMLAddProductDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void XMLAddProfileListDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void XMLAddProfilePathDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void XMLAddRawDataDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void XMLAddSupportDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void XMLAddTrackInfoListDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void XMLAddVendorDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr XMLComplianceElementWithNumber_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject number );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr XMLComplianceListElementWithArray_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject array );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr XMLDeviceElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr XMLDeviceInfoElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr XMLDeviceListElement( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr XMLDeviceStatusElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr XMLDiscInfoElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr XMLFirmwareElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr XMLInquiryElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr XMLInterconnectElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr XMLMediaInfoElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr XMLProductElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr XMLProfileListElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr XMLProfilePathElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr XMLRawDataElementWithData_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject data );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr XMLSupportElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr XMLTrackInfoListElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr XMLVendorElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector acquireExclusiveAccess = "acquireExclusiveAccess";
			public static readonly Selector acquireMediaReservation = "acquireMediaReservation";
			public static readonly Selector appleShipping = "appleShipping";
			public static readonly Selector appleSupported = "appleSupported";
			public static readonly Selector bsdName = "bsdName";
			public static readonly Selector cdText = "cdText";
			public static readonly Selector closeTray = "closeTray";
			public static readonly Selector currentWriteSpeed = "currentWriteSpeed";
			public static readonly Selector deviceForBSDName_ = "deviceForBSDName:";
			public static readonly Selector deviceForIORegistryEntryPath_ = "deviceForIORegistryEntryPath:";
			public static readonly Selector devices = "devices";
			public static readonly Selector displayName = "displayName";
			public static readonly Selector ejectMedia = "ejectMedia";
			public static readonly Selector firmwareString = "firmwareString";
			public static readonly Selector info = "info";
			public static readonly Selector initWithRegistryPath_forGUID_ = "initWithRegistryPath:forGUID:";
			public static readonly Selector initWithRegistryPath_forGUID_usingProfile_ = "initWithRegistryPath:forGUID:usingProfile:";
			public static readonly Selector interconnectString = "interconnectString";
			public static readonly Selector ioRegistryEntryPath = "ioRegistryEntryPath";
			public static readonly Selector isEqualToDevice_ = "isEqualToDevice:";
			public static readonly Selector isSupported = "isSupported";
			public static readonly Selector isValid = "isValid";
			public static readonly Selector maximumWriteSpeed = "maximumWriteSpeed";
			public static readonly Selector mediaIsAppendable = "mediaIsAppendable";
			public static readonly Selector mediaIsBlank = "mediaIsBlank";
			public static readonly Selector mediaIsBusy = "mediaIsBusy";
			public static readonly Selector mediaIsErasable = "mediaIsErasable";
			public static readonly Selector mediaIsOverwritable = "mediaIsOverwritable";
			public static readonly Selector mediaIsPresent = "mediaIsPresent";
			public static readonly Selector mediaIsReserved = "mediaIsReserved";
			public static readonly Selector mediaIsTransitioning = "mediaIsTransitioning";
			public static readonly Selector mediaSessionCount = "mediaSessionCount";
			public static readonly Selector mediaSpaceFree = "mediaSpaceFree";
			public static readonly Selector mediaSpaceOverwritable = "mediaSpaceOverwritable";
			public static readonly Selector mediaSpaceUsed = "mediaSpaceUsed";
			public static readonly Selector mediaTrackCount = "mediaTrackCount";
			public static readonly Selector mediaType = "mediaType";
			public static readonly Selector openTray = "openTray";
			public static readonly Selector productString = "productString";
			public static readonly Selector releaseExclusiveAccess = "releaseExclusiveAccess";
			public static readonly Selector releaseMediaReservation = "releaseMediaReservation";
			public static readonly Selector status = "status";
			public static readonly Selector trayIsOpen = "trayIsOpen";
			public static readonly Selector vendorString = "vendorString";
			public static readonly Selector vendorSupported = "vendorSupported";
			public static readonly Selector writesCD = "writesCD";
			public static readonly Selector writesCDR = "writesCDR";
			public static readonly Selector writesCDRW = "writesCDRW";
			public static readonly Selector writesCDText = "writesCDText";
			public static readonly Selector writesDVD = "writesDVD";
			public static readonly Selector writesDVDR = "writesDVDR";
			public static readonly Selector writesDVDRAM = "writesDVDRAM";
			public static readonly Selector XMLAddComplianceDTDToDTD_ = "XMLAddComplianceDTDToDTD:";
			public static readonly Selector XMLAddComplianceListDTDToDTD_ = "XMLAddComplianceListDTDToDTD:";
			public static readonly Selector XMLAddDeviceDTDToDTD_ = "XMLAddDeviceDTDToDTD:";
			public static readonly Selector XMLAddDeviceInfoDTDToDTD_ = "XMLAddDeviceInfoDTDToDTD:";
			public static readonly Selector XMLAddDeviceListDTDToDTD_ = "XMLAddDeviceListDTDToDTD:";
			public static readonly Selector XMLAddDeviceStatusDTDToDTD_ = "XMLAddDeviceStatusDTDToDTD:";
			public static readonly Selector XMLAddDiscInfoDTDToDTD_ = "XMLAddDiscInfoDTDToDTD:";
			public static readonly Selector XMLAddFirmwareDTDToDTD_ = "XMLAddFirmwareDTDToDTD:";
			public static readonly Selector XMLAddInquiryDTDToDTD_ = "XMLAddInquiryDTDToDTD:";
			public static readonly Selector XMLAddInterconnectDTDToDTD_ = "XMLAddInterconnectDTDToDTD:";
			public static readonly Selector XMLAddMediaInfoDTDToDTD_ = "XMLAddMediaInfoDTDToDTD:";
			public static readonly Selector XMLAddProductDTDToDTD_ = "XMLAddProductDTDToDTD:";
			public static readonly Selector XMLAddProfileListDTDToDTD_ = "XMLAddProfileListDTDToDTD:";
			public static readonly Selector XMLAddProfilePathDTDToDTD_ = "XMLAddProfilePathDTDToDTD:";
			public static readonly Selector XMLAddRawDataDTDToDTD_ = "XMLAddRawDataDTDToDTD:";
			public static readonly Selector XMLAddSupportDTDToDTD_ = "XMLAddSupportDTDToDTD:";
			public static readonly Selector XMLAddTrackInfoListDTDToDTD_ = "XMLAddTrackInfoListDTDToDTD:";
			public static readonly Selector XMLAddVendorDTDToDTD_ = "XMLAddVendorDTDToDTD:";
			public static readonly Selector XMLComplianceElementWithNumber_ = "XMLComplianceElementWithNumber:";
			public static readonly Selector XMLComplianceListElementWithArray_ = "XMLComplianceListElementWithArray:";
			public static readonly Selector XMLDeviceElement = "XMLDeviceElement";
			public static readonly Selector XMLDeviceInfoElement = "XMLDeviceInfoElement";
			public static readonly Selector XMLDeviceListElement = "XMLDeviceListElement";
			public static readonly Selector XMLDeviceStatusElement = "XMLDeviceStatusElement";
			public static readonly Selector XMLDiscInfoElement = "XMLDiscInfoElement";
			public static readonly Selector XMLFirmwareElement = "XMLFirmwareElement";
			public static readonly Selector XMLInquiryElement = "XMLInquiryElement";
			public static readonly Selector XMLInterconnectElement = "XMLInterconnectElement";
			public static readonly Selector XMLMediaInfoElement = "XMLMediaInfoElement";
			public static readonly Selector XMLProductElement = "XMLProductElement";
			public static readonly Selector XMLProfileListElement = "XMLProfileListElement";
			public static readonly Selector XMLProfilePathElement = "XMLProfilePathElement";
			public static readonly Selector XMLRawDataElementWithData_ = "XMLRawDataElementWithData:";
			public static readonly Selector XMLSupportElement = "XMLSupportElement";
			public static readonly Selector XMLTrackInfoListElement = "XMLTrackInfoListElement";
			public static readonly Selector XMLVendorElement = "XMLVendorElement";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct DRErase : IEquatable<DRErase> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingEngineCachedClasses.DRErase;
		public static implicit operator NSObject( DRErase value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( DRErase value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRErase value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as DRErase?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( DRErase value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRErase value1, DRErase value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRErase value1, DRErase value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRErase( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRErase alloc() {
			return new DRErase( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static DRErase eraseForDevice_( DRDevice device ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.eraseForDevice_( ClassHandle, CachedSelectors.eraseForDevice_, out ___occuredException, sizeof( DRDevice ), device );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRErase( ___result );
		}
		unsafe public DRDevice device() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.device( Handle, CachedSelectors.device, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRDevice( ___result );
		}
		unsafe public string eraseType() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.eraseType( Handle, CachedSelectors.eraseType, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithDevice_( DRDevice device ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithDevice_( Handle, CachedSelectors.initWithDevice_, out ___occuredException, sizeof( DRDevice ), device );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSDictionary properties() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.properties( Handle, CachedSelectors.properties, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public void setEraseType_( string type ) {
			RuntimeObject ___occuredException;
			var ___wrappedtype = Runtime.CreateStringProxy( type );
			NativeMethods.setEraseType_( Handle, CachedSelectors.setEraseType_, out ___occuredException, sizeof( IntPtr ), ___wrappedtype );
			Runtime.ReleaseNativeObject( ___wrappedtype );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setProperties_( NSDictionary properties ) {
			RuntimeObject ___occuredException;
			NativeMethods.setProperties_( Handle, CachedSelectors.setProperties_, out ___occuredException, sizeof( NSDictionary ), properties );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void start() {
			RuntimeObject ___occuredException;
			NativeMethods.start( Handle, CachedSelectors.start, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSDictionary status() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.status( Handle, CachedSelectors.status, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr device( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr eraseForDevice_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRDevice device );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr eraseType( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithDevice_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRDevice device );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr properties( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setEraseType_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr type );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setProperties_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDictionary properties );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void start( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr status( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector device = "device";
			public static readonly Selector eraseForDevice_ = "eraseForDevice:";
			public static readonly Selector eraseType = "eraseType";
			public static readonly Selector initWithDevice_ = "initWithDevice:";
			public static readonly Selector properties = "properties";
			public static readonly Selector setEraseType_ = "setEraseType:";
			public static readonly Selector setProperties_ = "setProperties:";
			public static readonly Selector start = "start";
			public static readonly Selector status = "status";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSNumber ) )]
	public struct DRMSF : IEquatable<DRMSF> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingEngineCachedClasses.DRMSF;
		public static implicit operator NSNumber( DRMSF value ) {
			return new NSNumber( value.Handle );
		}
		public static implicit operator NSValue( DRMSF value ) {
			return new NSValue( value.Handle );
		}
		public static implicit operator NSObject( DRMSF value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( DRMSF value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRMSF value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as DRMSF?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( DRMSF value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRMSF value1, DRMSF value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRMSF value1, DRMSF value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRMSF( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRMSF alloc() {
			return new DRMSF( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static DRMSF msf() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.msf( ClassHandle, CachedSelectors.msf, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRMSF( ___result );
		}
		unsafe public static DRMSF msfWithFrames_( uint frames ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.msfWithFrames_( ClassHandle, CachedSelectors.msfWithFrames_, out ___occuredException, sizeof( uint ), frames );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRMSF( ___result );
		}
		unsafe public static DRMSF msfWithString_( string @string ) {
			RuntimeObject ___occuredException;
			var ___wrappedstring = Runtime.CreateStringProxy( @string );
			var ___result = NativeMethods.msfWithString_( ClassHandle, CachedSelectors.msfWithString_, out ___occuredException, sizeof( IntPtr ), ___wrappedstring );
			Runtime.ReleaseNativeObject( ___wrappedstring );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRMSF( ___result );
		}
		unsafe public string descriptionWithFormat_( string format ) {
			RuntimeObject ___occuredException;
			var ___wrappedformat = Runtime.CreateStringProxy( format );
			var ___result = NativeMethods.descriptionWithFormat_( Handle, CachedSelectors.descriptionWithFormat_, out ___occuredException, sizeof( IntPtr ), ___wrappedformat );
			Runtime.ReleaseNativeObject( ___wrappedformat );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public uint frames() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.frames( Handle, CachedSelectors.frames, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public NObjective.RuntimeObject initWithFrames_( uint frames ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithFrames_( Handle, CachedSelectors.initWithFrames_, out ___occuredException, sizeof( uint ), frames );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithString_( string @string ) {
			RuntimeObject ___occuredException;
			var ___wrappedstring = Runtime.CreateStringProxy( @string );
			var ___result = NativeMethods.initWithString_( Handle, CachedSelectors.initWithString_, out ___occuredException, sizeof( IntPtr ), ___wrappedstring );
			Runtime.ReleaseNativeObject( ___wrappedstring );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public bool isEqualToMSF_( DRMSF msf ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isEqualToMSF_( Handle, CachedSelectors.isEqualToMSF_, out ___occuredException, sizeof( DRMSF ), msf );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public uint minutes() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.minutes( Handle, CachedSelectors.minutes, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public DRMSF msfByAdding_( DRMSF adding ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.msfByAdding_( Handle, CachedSelectors.msfByAdding_, out ___occuredException, sizeof( DRMSF ), adding );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRMSF( ___result );
		}
		unsafe public DRMSF msfBySubtracting_( DRMSF subtracting ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.msfBySubtracting_( Handle, CachedSelectors.msfBySubtracting_, out ___occuredException, sizeof( DRMSF ), subtracting );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRMSF( ___result );
		}
		unsafe public uint seconds() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.seconds( Handle, CachedSelectors.seconds, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public uint sectors() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sectors( Handle, CachedSelectors.sectors, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr descriptionWithFormat_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr format );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint frames( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithFrames_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint frames );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithString_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr @string );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isEqualToMSF_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRMSF msf );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint minutes( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr msf( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr msfByAdding_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRMSF adding );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr msfBySubtracting_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRMSF subtracting );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr msfWithFrames_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint frames );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr msfWithString_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr @string );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint seconds( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint sectors( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector descriptionWithFormat_ = "descriptionWithFormat:";
			public static readonly Selector frames = "frames";
			public static readonly Selector initWithFrames_ = "initWithFrames:";
			public static readonly Selector initWithString_ = "initWithString:";
			public static readonly Selector isEqualToMSF_ = "isEqualToMSF:";
			public static readonly Selector minutes = "minutes";
			public static readonly Selector msf = "msf";
			public static readonly Selector msfByAdding_ = "msfByAdding:";
			public static readonly Selector msfBySubtracting_ = "msfBySubtracting:";
			public static readonly Selector msfWithFrames_ = "msfWithFrames:";
			public static readonly Selector msfWithString_ = "msfWithString:";
			public static readonly Selector seconds = "seconds";
			public static readonly Selector sectors = "sectors";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSFormatter ) )]
	public struct DRMSFFormatter : IEquatable<DRMSFFormatter> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingEngineCachedClasses.DRMSFFormatter;
		public static implicit operator NSFormatter( DRMSFFormatter value ) {
			return new NSFormatter( value.Handle );
		}
		public static implicit operator NSObject( DRMSFFormatter value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( DRMSFFormatter value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRMSFFormatter value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as DRMSFFormatter?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( DRMSFFormatter value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRMSFFormatter value1, DRMSFFormatter value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRMSFFormatter value1, DRMSFFormatter value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRMSFFormatter( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRMSFFormatter alloc() {
			return new DRMSFFormatter( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public string format() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.format( Handle, CachedSelectors.format, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithFormat_( string format ) {
			RuntimeObject ___occuredException;
			var ___wrappedformat = Runtime.CreateStringProxy( format );
			var ___result = NativeMethods.initWithFormat_( Handle, CachedSelectors.initWithFormat_, out ___occuredException, sizeof( IntPtr ), ___wrappedformat );
			Runtime.ReleaseNativeObject( ___wrappedformat );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setFormat_( string format ) {
			RuntimeObject ___occuredException;
			var ___wrappedformat = Runtime.CreateStringProxy( format );
			NativeMethods.setFormat_( Handle, CachedSelectors.setFormat_, out ___occuredException, sizeof( IntPtr ), ___wrappedformat );
			Runtime.ReleaseNativeObject( ___wrappedformat );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr format( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithFormat_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr format );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setFormat_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr format );
		}
		static internal class CachedSelectors {
			public static readonly Selector format = "format";
			public static readonly Selector initWithFormat_ = "initWithFormat:";
			public static readonly Selector setFormat_ = "setFormat:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct DRNotificationCenter : IEquatable<DRNotificationCenter> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingEngineCachedClasses.DRNotificationCenter;
		public static implicit operator NSObject( DRNotificationCenter value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( DRNotificationCenter value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRNotificationCenter value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as DRNotificationCenter?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( DRNotificationCenter value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRNotificationCenter value1, DRNotificationCenter value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRNotificationCenter value1, DRNotificationCenter value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRNotificationCenter( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRNotificationCenter alloc() {
			return new DRNotificationCenter( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static DRNotificationCenter currentRunLoopCenter() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.currentRunLoopCenter( ClassHandle, CachedSelectors.currentRunLoopCenter, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRNotificationCenter( ___result );
		}
		unsafe public void addObserver_selector_name_object_( NObjective.RuntimeObject observer, NObjective.Selector selector, string name, NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___wrappedname = Runtime.CreateStringProxy( name );
			NativeMethods.addObserver_selector_name_object_( Handle, CachedSelectors.addObserver_selector_name_object_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.Selector ) + sizeof( IntPtr ) + sizeof( NObjective.RuntimeObject ), observer, selector, ___wrappedname, @object );
			Runtime.ReleaseNativeObject( ___wrappedname );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public char notificationNeedsImmediatePosting_( NObjective.RuntimeObject posting ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.notificationNeedsImmediatePosting_( Handle, CachedSelectors.notificationNeedsImmediatePosting_, out ___occuredException, sizeof( NObjective.RuntimeObject ), posting );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void removeObserver_name_object_( NObjective.RuntimeObject observer, string name, NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			var ___wrappedname = Runtime.CreateStringProxy( name );
			NativeMethods.removeObserver_name_object_( Handle, CachedSelectors.removeObserver_name_object_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( IntPtr ) + sizeof( NObjective.RuntimeObject ), observer, ___wrappedname, @object );
			Runtime.ReleaseNativeObject( ___wrappedname );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void addObserver_selector_name_object_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject observer, NObjective.Selector selector, IntPtr name, NObjective.RuntimeObject @object );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr currentRunLoopCenter( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char notificationNeedsImmediatePosting_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject posting );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void removeObserver_name_object_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject observer, IntPtr name, NObjective.RuntimeObject @object );
		}
		static internal class CachedSelectors {
			public static readonly Selector addObserver_selector_name_object_ = "addObserver:selector:name:object:";
			public static readonly Selector currentRunLoopCenter = "currentRunLoopCenter";
			public static readonly Selector notificationNeedsImmediatePosting_ = "notificationNeedsImmediatePosting:";
			public static readonly Selector removeObserver_name_object_ = "removeObserver:name:object:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct DRTask : IEquatable<DRTask> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingEngineCachedClasses.DRTask;
		public static implicit operator NSObject( DRTask value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( DRTask value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRTask value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as DRTask?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( DRTask value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRTask value1, DRTask value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRTask value1, DRTask value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRTask( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRTask alloc() {
			return new DRTask( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject info() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.info( Handle, CachedSelectors.info, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithPid_forTask_( int pid, uint forTask ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithPid_forTask_( Handle, CachedSelectors.initWithPid_forTask_, out ___occuredException, sizeof( int ) + sizeof( uint ), pid, forTask );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public bool isValid() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isValid( Handle, CachedSelectors.isValid, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr info( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithPid_forTask_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int pid, uint forTask );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isValid( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector info = "info";
			public static readonly Selector initWithPid_forTask_ = "initWithPid:forTask:";
			public static readonly Selector isValid = "isValid";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct DRTrack : IEquatable<DRTrack> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingEngineCachedClasses.DRTrack;
		public static implicit operator NSObject( DRTrack value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( DRTrack value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRTrack value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as DRTrack?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( DRTrack value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRTrack value1, DRTrack value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRTrack value1, DRTrack value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRTrack( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRTrack alloc() {
			return new DRTrack( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public ushort blockSize() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.blockSize( Handle, CachedSelectors.blockSize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public int blockType() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.blockType( Handle, CachedSelectors.blockType, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public int dataForm() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dataForm( Handle, CachedSelectors.dataForm, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject dvdCopyrightInfo() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dvdCopyrightInfo( Handle, CachedSelectors.dvdCopyrightInfo, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject dvdTimestamp() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dvdTimestamp( Handle, CachedSelectors.dvdTimestamp, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public ulong estimateLength() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.estimateLength( Handle, CachedSelectors.estimateLength, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject initWithProducer_( NObjective.RuntimeObject producer ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithProducer_( Handle, CachedSelectors.initWithProducer_, out ___occuredException, sizeof( NObjective.RuntimeObject ), producer );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public DRMSF length() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.length( Handle, CachedSelectors.length, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRMSF( ___result );
		}
		unsafe public float maximumBurnSpeed() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.maximumBurnSpeed( Handle, CachedSelectors.maximumBurnSpeed, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public DRMSF preGap() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.preGap( Handle, CachedSelectors.preGap, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRMSF( ___result );
		}
		unsafe public NSDictionary properties() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.properties( Handle, CachedSelectors.properties, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public int sessionFormat() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sessionFormat( Handle, CachedSelectors.sessionFormat, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void setBlockSize_( ushort size ) {
			RuntimeObject ___occuredException;
			NativeMethods.setBlockSize_( Handle, CachedSelectors.setBlockSize_, out ___occuredException, sizeof( ushort ), size );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setBlockType_( int type ) {
			RuntimeObject ___occuredException;
			NativeMethods.setBlockType_( Handle, CachedSelectors.setBlockType_, out ___occuredException, sizeof( int ), type );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setDataForm_( int form ) {
			RuntimeObject ___occuredException;
			NativeMethods.setDataForm_( Handle, CachedSelectors.setDataForm_, out ___occuredException, sizeof( int ), form );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setDVDCopyrightInfo_( NObjective.RuntimeObject info ) {
			RuntimeObject ___occuredException;
			NativeMethods.setDVDCopyrightInfo_( Handle, CachedSelectors.setDVDCopyrightInfo_, out ___occuredException, sizeof( NObjective.RuntimeObject ), info );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setDVDTimestamp_( NObjective.RuntimeObject timestamp ) {
			RuntimeObject ___occuredException;
			NativeMethods.setDVDTimestamp_( Handle, CachedSelectors.setDVDTimestamp_, out ___occuredException, sizeof( NObjective.RuntimeObject ), timestamp );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setLength_( NObjective.RuntimeObject length ) {
			RuntimeObject ___occuredException;
			NativeMethods.setLength_( Handle, CachedSelectors.setLength_, out ___occuredException, sizeof( NObjective.RuntimeObject ), length );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setMaximumBurnSpeed_( float speed ) {
			RuntimeObject ___occuredException;
			NativeMethods.setMaximumBurnSpeed_( Handle, CachedSelectors.setMaximumBurnSpeed_, out ___occuredException, sizeof( float ), speed );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setPreGap_( DRMSF gap ) {
			RuntimeObject ___occuredException;
			NativeMethods.setPreGap_( Handle, CachedSelectors.setPreGap_, out ___occuredException, sizeof( DRMSF ), gap );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setProperties_( NSDictionary properties ) {
			RuntimeObject ___occuredException;
			NativeMethods.setProperties_( Handle, CachedSelectors.setProperties_, out ___occuredException, sizeof( NSDictionary ), properties );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setSessionFormat_( int format ) {
			RuntimeObject ___occuredException;
			NativeMethods.setSessionFormat_( Handle, CachedSelectors.setSessionFormat_, out ___occuredException, sizeof( int ), format );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setTrackMode_( int mode ) {
			RuntimeObject ___occuredException;
			NativeMethods.setTrackMode_( Handle, CachedSelectors.setTrackMode_, out ___occuredException, sizeof( int ), mode );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setVerificationType_( NObjective.RuntimeObject type ) {
			RuntimeObject ___occuredException;
			NativeMethods.setVerificationType_( Handle, CachedSelectors.setVerificationType_, out ___occuredException, sizeof( NObjective.RuntimeObject ), type );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public float testProductionSpeedForInterval_( double interval ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.testProductionSpeedForInterval_( Handle, CachedSelectors.testProductionSpeedForInterval_, out ___occuredException, sizeof( double ), interval );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public float testProductionSpeedForLength_( uint length ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.testProductionSpeedForLength_( Handle, CachedSelectors.testProductionSpeedForLength_, out ___occuredException, sizeof( uint ), length );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public int trackMode() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.trackMode( Handle, CachedSelectors.trackMode, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject verificationType() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.verificationType( Handle, CachedSelectors.verificationType, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern ushort blockSize( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int blockType( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int dataForm( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr dvdCopyrightInfo( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr dvdTimestamp( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern ulong estimateLength( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithProducer_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject producer );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr length( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern float maximumBurnSpeed( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr preGap( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr properties( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int sessionFormat( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setBlockSize_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, ushort size );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setBlockType_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int type );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setDataForm_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int form );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setDVDCopyrightInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject info );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setDVDTimestamp_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject timestamp );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setLength_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject length );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setMaximumBurnSpeed_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, float speed );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setPreGap_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRMSF gap );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setProperties_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDictionary properties );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setSessionFormat_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int format );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setTrackMode_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int mode );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setVerificationType_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject type );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern float testProductionSpeedForInterval_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, double interval );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern float testProductionSpeedForLength_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint length );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int trackMode( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr verificationType( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector blockSize = "blockSize";
			public static readonly Selector blockType = "blockType";
			public static readonly Selector dataForm = "dataForm";
			public static readonly Selector dvdCopyrightInfo = "dvdCopyrightInfo";
			public static readonly Selector dvdTimestamp = "dvdTimestamp";
			public static readonly Selector estimateLength = "estimateLength";
			public static readonly Selector initWithProducer_ = "initWithProducer:";
			public static readonly Selector length = "length";
			public static readonly Selector maximumBurnSpeed = "maximumBurnSpeed";
			public static readonly Selector preGap = "preGap";
			public static readonly Selector properties = "properties";
			public static readonly Selector sessionFormat = "sessionFormat";
			public static readonly Selector setBlockSize_ = "setBlockSize:";
			public static readonly Selector setBlockType_ = "setBlockType:";
			public static readonly Selector setDataForm_ = "setDataForm:";
			public static readonly Selector setDVDCopyrightInfo_ = "setDVDCopyrightInfo:";
			public static readonly Selector setDVDTimestamp_ = "setDVDTimestamp:";
			public static readonly Selector setLength_ = "setLength:";
			public static readonly Selector setMaximumBurnSpeed_ = "setMaximumBurnSpeed:";
			public static readonly Selector setPreGap_ = "setPreGap:";
			public static readonly Selector setProperties_ = "setProperties:";
			public static readonly Selector setSessionFormat_ = "setSessionFormat:";
			public static readonly Selector setTrackMode_ = "setTrackMode:";
			public static readonly Selector setVerificationType_ = "setVerificationType:";
			public static readonly Selector testProductionSpeedForInterval_ = "testProductionSpeedForInterval:";
			public static readonly Selector testProductionSpeedForLength_ = "testProductionSpeedForLength:";
			public static readonly Selector trackMode = "trackMode";
			public static readonly Selector verificationType = "verificationType";
		}
	}
	static internal class DiscRecordingEngineCachedClasses {
		static internal int ___lazyLoad = Platform.NativeMethods.dlopen( "/System/Library/Frameworks/DiscRecording.framework/Versions/A/Frameworks/DiscRecordingEngine.framework/Versions/A/DiscRecordingEngine" );
		public static readonly RuntimeClass DRBurn = "DRBurn";
		public static readonly RuntimeClass DRCallbackDevice = "DRCallbackDevice";
		public static readonly RuntimeClass DRCDTextBlock = "DRCDTextBlock";
		public static readonly RuntimeClass DRDevice = "DRDevice";
		public static readonly RuntimeClass DRErase = "DRErase";
		public static readonly RuntimeClass DRMSF = "DRMSF";
		public static readonly RuntimeClass DRMSFFormatter = "DRMSFFormatter";
		public static readonly RuntimeClass DRNotificationCenter = "DRNotificationCenter";
		public static readonly RuntimeClass DRTask = "DRTask";
		public static readonly RuntimeClass DRTrack = "DRTrack";
	}
}
