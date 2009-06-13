//
// Copyright (C) 2009 Eugeny Grishul
//
// See license in License.txt
//

namespace NObjective.Proxies {
	using System;
	using System.Runtime.InteropServices;
	[ProxyBaseClass(typeof( NSObject ))]
	public struct IMKClient : IEquatable<IMKClient> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = HIToolboxCachedClasses.IMKClient;
		public static implicit operator IntPtr( IMKClient value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( IMKClient value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as IMKClient?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( IMKClient value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( IMKClient value1, IMKClient value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( IMKClient value1, IMKClient value2 ) {
			return value1.Handle != value2.Handle;
		}
		public IMKClient( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static IMKClient alloc() {
			return new IMKClient( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject bundleIdentifier() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.bundleIdentifier( Handle, CachedSelectors.bundleIdentifier, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject currentSession() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.currentSession( Handle, CachedSelectors.currentSession, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject imageFileForName_( NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.imageFileForName_( Handle, CachedSelectors.imageFileForName_, out ___occuredException, sizeof( NObjective.RuntimeObject ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithBundleIdentifier_( NObjective.RuntimeObject identifier ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithBundleIdentifier_( Handle, CachedSelectors.initWithBundleIdentifier_, out ___occuredException, sizeof( NObjective.RuntimeObject ), identifier );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject localizedStringForKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.localizedStringForKey_( Handle, CachedSelectors.localizedStringForKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject modes() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.modes( Handle, CachedSelectors.modes, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject server() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.server( Handle, CachedSelectors.server, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setCurrentSession_( NObjective.RuntimeObject session ) {
			RuntimeObject ___occuredException;
			NativeMethods.setCurrentSession_( Handle, CachedSelectors.setCurrentSession_, out ___occuredException, sizeof( NObjective.RuntimeObject ), session );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr bundleIdentifier( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr currentSession( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr imageFileForName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithBundleIdentifier_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject identifier );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr localizedStringForKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr modes( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr server( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setCurrentSession_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject session );
		}
		static internal class CachedSelectors {
			public static readonly Selector bundleIdentifier = "bundleIdentifier";
			public static readonly Selector currentSession = "currentSession";
			public static readonly Selector imageFileForName_ = "imageFileForName:";
			public static readonly Selector initWithBundleIdentifier_ = "initWithBundleIdentifier:";
			public static readonly Selector localizedStringForKey_ = "localizedStringForKey:";
			public static readonly Selector modes = "modes";
			public static readonly Selector server = "server";
			public static readonly Selector setCurrentSession_ = "setCurrentSession:";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct IMKEvent : IEquatable<IMKEvent> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = HIToolboxCachedClasses.IMKEvent;
		public static implicit operator IntPtr( IMKEvent value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( IMKEvent value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as IMKEvent?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( IMKEvent value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( IMKEvent value1, IMKEvent value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( IMKEvent value1, IMKEvent value2 ) {
			return value1.Handle != value2.Handle;
		}
		public IMKEvent( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static IMKEvent alloc() {
			return new IMKEvent( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static void initialize() {
			RuntimeObject ___occuredException;
			NativeMethods.initialize( ClassHandle, CachedSelectors.initialize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void addData_withName_paramType_size_( System.IntPtr data, NObjective.RuntimeObject withName, uint paramType, uint size ) {
			RuntimeObject ___occuredException;
			NativeMethods.addData_withName_paramType_size_( Handle, CachedSelectors.addData_withName_paramType_size_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ) + sizeof( uint ) + sizeof( uint ), data, withName, paramType, size );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public System.IntPtr bytesForName_size_( NObjective.RuntimeObject name, System.IntPtr size ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.bytesForName_size_( Handle, CachedSelectors.bytesForName_size_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), name, size );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeClass classForKeyedArchiver() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.classForKeyedArchiver( Handle, CachedSelectors.classForKeyedArchiver, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject dataAndNames() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dataAndNames( Handle, CachedSelectors.dataAndNames, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void encodeWithCoder_( NSCoder coder ) {
			RuntimeObject ___occuredException;
			NativeMethods.encodeWithCoder_( Handle, CachedSelectors.encodeWithCoder_, out ___occuredException, sizeof( NSCoder ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public uint eventClass() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.eventClass( Handle, CachedSelectors.eventClass, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public uint eventKind() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.eventKind( Handle, CachedSelectors.eventKind, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public double eventTime() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.eventTime( Handle, CachedSelectors.eventTime, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject initWithCoder_( NObjective.RuntimeObject coder ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCoder_( Handle, CachedSelectors.initWithCoder_, out ___occuredException, sizeof( NObjective.RuntimeObject ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject names() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.names( Handle, CachedSelectors.names, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject replacementObjectForPortCoder_( NObjective.RuntimeObject coder ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.replacementObjectForPortCoder_( Handle, CachedSelectors.replacementObjectForPortCoder_, out ___occuredException, sizeof( NObjective.RuntimeObject ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setEventClass_( uint @class ) {
			RuntimeObject ___occuredException;
			NativeMethods.setEventClass_( Handle, CachedSelectors.setEventClass_, out ___occuredException, sizeof( uint ), @class );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setEventKind_( uint kind ) {
			RuntimeObject ___occuredException;
			NativeMethods.setEventKind_( Handle, CachedSelectors.setEventKind_, out ___occuredException, sizeof( uint ), kind );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setEventTime_( double time ) {
			RuntimeObject ___occuredException;
			NativeMethods.setEventTime_( Handle, CachedSelectors.setEventTime_, out ___occuredException, sizeof( double ), time );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void addData_withName_paramType_size_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr data, NObjective.RuntimeObject withName, uint paramType, uint size );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern System.IntPtr bytesForName_size_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name, System.IntPtr size );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern NObjective.RuntimeClass classForKeyedArchiver( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr dataAndNames( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void encodeWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSCoder coder );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint eventClass( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint eventKind( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2")]
			public static extern double eventTime( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void initialize( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject coder );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr names( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr replacementObjectForPortCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject coder );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setEventClass_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint @class );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setEventKind_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint kind );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setEventTime_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, double time );
		}
		static internal class CachedSelectors {
			public static readonly Selector addData_withName_paramType_size_ = "addData:withName:paramType:size:";
			public static readonly Selector bytesForName_size_ = "bytesForName:size:";
			public static readonly Selector classForKeyedArchiver = "classForKeyedArchiver";
			public static readonly Selector dataAndNames = "dataAndNames";
			public static readonly Selector encodeWithCoder_ = "encodeWithCoder:";
			public static readonly Selector eventClass = "eventClass";
			public static readonly Selector eventKind = "eventKind";
			public static readonly Selector eventTime = "eventTime";
			public static readonly Selector initialize = "initialize";
			public static readonly Selector initWithCoder_ = "initWithCoder:";
			public static readonly Selector names = "names";
			public static readonly Selector replacementObjectForPortCoder_ = "replacementObjectForPortCoder:";
			public static readonly Selector setEventClass_ = "setEventClass:";
			public static readonly Selector setEventKind_ = "setEventKind:";
			public static readonly Selector setEventTime_ = "setEventTime:";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct IMKInputSession : IEquatable<IMKInputSession> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = HIToolboxCachedClasses.IMKInputSession;
		public static implicit operator IntPtr( IMKInputSession value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( IMKInputSession value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as IMKInputSession?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( IMKInputSession value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( IMKInputSession value1, IMKInputSession value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( IMKInputSession value1, IMKInputSession value2 ) {
			return value1.Handle != value2.Handle;
		}
		public IMKInputSession( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static IMKInputSession alloc() {
			return new IMKInputSession( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void activate() {
			RuntimeObject ___occuredException;
			NativeMethods.activate( Handle, CachedSelectors.activate, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject attributesForCharacterIndex_( uint index ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.attributesForCharacterIndex_( Handle, CachedSelectors.attributesForCharacterIndex_, out ___occuredException, sizeof( uint ), index );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject bundleIdentifier() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.bundleIdentifier( Handle, CachedSelectors.bundleIdentifier, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void commitComposition() {
			RuntimeObject ___occuredException;
			NativeMethods.commitComposition( Handle, CachedSelectors.commitComposition, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject currentInputSourceBundleID() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.currentInputSourceBundleID( Handle, CachedSelectors.currentInputSourceBundleID, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void deactivate() {
			RuntimeObject ___occuredException;
			NativeMethods.deactivate( Handle, CachedSelectors.deactivate, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public uint deadKeyState() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.deadKeyState( Handle, CachedSelectors.deadKeyState, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public char didCommandBySelector_( NObjective.Selector selector ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.didCommandBySelector_( Handle, CachedSelectors.didCommandBySelector_, out ___occuredException, sizeof( NObjective.Selector ), selector );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void doCommandBySelector_commandDictionary_( NObjective.Selector selector, NObjective.RuntimeObject commandDictionary ) {
			RuntimeObject ___occuredException;
			NativeMethods.doCommandBySelector_commandDictionary_( Handle, CachedSelectors.doCommandBySelector_commandDictionary_, out ___occuredException, sizeof( NObjective.Selector ) + sizeof( NObjective.RuntimeObject ), selector, commandDictionary );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void finishSession() {
			RuntimeObject ___occuredException;
			NativeMethods.finishSession( Handle, CachedSelectors.finishSession, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void hidePalettes() {
			RuntimeObject ___occuredException;
			NativeMethods.hidePalettes( Handle, CachedSelectors.hidePalettes, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void insertText_( NObjective.RuntimeObject text ) {
			RuntimeObject ___occuredException;
			NativeMethods.insertText_( Handle, CachedSelectors.insertText_, out ___occuredException, sizeof( NObjective.RuntimeObject ), text );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public int length() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.length( Handle, CachedSelectors.length, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void overrideKeyboardWithKeyboardNamed_( NObjective.RuntimeObject named ) {
			RuntimeObject ___occuredException;
			NativeMethods.overrideKeyboardWithKeyboardNamed_( Handle, CachedSelectors.overrideKeyboardWithKeyboardNamed_, out ___occuredException, sizeof( NObjective.RuntimeObject ), named );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void selectInputMode_( NObjective.RuntimeObject mode ) {
			RuntimeObject ___occuredException;
			NativeMethods.selectInputMode_( Handle, CachedSelectors.selectInputMode_, out ___occuredException, sizeof( NObjective.RuntimeObject ), mode );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setValue_forTag_( NObjective.RuntimeObject value, uint forTag ) {
			RuntimeObject ___occuredException;
			NativeMethods.setValue_forTag_( Handle, CachedSelectors.setValue_forTag_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ), value, forTag );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public char supportsProperty_( uint property ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.supportsProperty_( Handle, CachedSelectors.supportsProperty_, out ___occuredException, sizeof( uint ), property );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char supportsUnicode() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.supportsUnicode( Handle, CachedSelectors.supportsUnicode, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject validAttributesForMarkedText() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.validAttributesForMarkedText( Handle, CachedSelectors.validAttributesForMarkedText, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject valueForTag_( uint tag ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.valueForTag_( Handle, CachedSelectors.valueForTag_, out ___occuredException, sizeof( uint ), tag );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public int windowLevel() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.windowLevel( Handle, CachedSelectors.windowLevel, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void activate( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr attributesForCharacterIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint index );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr bundleIdentifier( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void commitComposition( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr currentInputSourceBundleID( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void deactivate( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint deadKeyState( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char didCommandBySelector_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void doCommandBySelector_commandDictionary_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector, NObjective.RuntimeObject commandDictionary );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void finishSession( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void hidePalettes( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void insertText_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject text );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern int length( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void overrideKeyboardWithKeyboardNamed_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject named );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void selectInputMode_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject mode );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setValue_forTag_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject value, uint forTag );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char supportsProperty_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint property );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char supportsUnicode( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr validAttributesForMarkedText( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr valueForTag_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint tag );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern int windowLevel( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector activate = "activate";
			public static readonly Selector attributesForCharacterIndex_ = "attributesForCharacterIndex:";
			public static readonly Selector bundleIdentifier = "bundleIdentifier";
			public static readonly Selector commitComposition = "commitComposition";
			public static readonly Selector currentInputSourceBundleID = "currentInputSourceBundleID";
			public static readonly Selector deactivate = "deactivate";
			public static readonly Selector deadKeyState = "deadKeyState";
			public static readonly Selector didCommandBySelector_ = "didCommandBySelector:";
			public static readonly Selector doCommandBySelector_commandDictionary_ = "doCommandBySelector:commandDictionary:";
			public static readonly Selector finishSession = "finishSession";
			public static readonly Selector hidePalettes = "hidePalettes";
			public static readonly Selector insertText_ = "insertText:";
			public static readonly Selector length = "length";
			public static readonly Selector overrideKeyboardWithKeyboardNamed_ = "overrideKeyboardWithKeyboardNamed:";
			public static readonly Selector selectInputMode_ = "selectInputMode:";
			public static readonly Selector setValue_forTag_ = "setValue:forTag:";
			public static readonly Selector supportsProperty_ = "supportsProperty:";
			public static readonly Selector supportsUnicode = "supportsUnicode";
			public static readonly Selector validAttributesForMarkedText = "validAttributesForMarkedText";
			public static readonly Selector valueForTag_ = "valueForTag:";
			public static readonly Selector windowLevel = "windowLevel";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct IPMDEventParameter : IEquatable<IPMDEventParameter> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = HIToolboxCachedClasses.IPMDEventParameter;
		public static implicit operator IntPtr( IPMDEventParameter value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( IPMDEventParameter value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as IPMDEventParameter?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( IPMDEventParameter value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( IPMDEventParameter value1, IPMDEventParameter value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( IPMDEventParameter value1, IPMDEventParameter value2 ) {
			return value1.Handle != value2.Handle;
		}
		public IPMDEventParameter( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static IPMDEventParameter alloc() {
			return new IPMDEventParameter( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject eventParameterWithData_type_size_( System.IntPtr data, uint type, uint size ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.eventParameterWithData_type_size_( ClassHandle, CachedSelectors.eventParameterWithData_type_size_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( uint ) + sizeof( uint ), data, type, size );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static void initialize() {
			RuntimeObject ___occuredException;
			NativeMethods.initialize( ClassHandle, CachedSelectors.initialize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static bool isPIDNative() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isPIDNative( ClassHandle, CachedSelectors.isPIDNative, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void addObjectToArray_( NObjective.RuntimeObject array ) {
			RuntimeObject ___occuredException;
			NativeMethods.addObjectToArray_( Handle, CachedSelectors.addObjectToArray_, out ___occuredException, sizeof( NObjective.RuntimeObject ), array );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeClass classForKeyedArchiver() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.classForKeyedArchiver( Handle, CachedSelectors.classForKeyedArchiver, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject dataObject() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dataObject( Handle, CachedSelectors.dataObject, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public System.IntPtr dataPtr() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dataPtr( Handle, CachedSelectors.dataPtr, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void encodeWithCoder_( NSCoder coder ) {
			RuntimeObject ___occuredException;
			NativeMethods.encodeWithCoder_( Handle, CachedSelectors.encodeWithCoder_, out ___occuredException, sizeof( NSCoder ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public uint eventSize() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.eventSize( Handle, CachedSelectors.eventSize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public uint eventType() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.eventType( Handle, CachedSelectors.eventType, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public NObjective.RuntimeObject initWithCoder_( NObjective.RuntimeObject coder ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCoder_( Handle, CachedSelectors.initWithCoder_, out ___occuredException, sizeof( NObjective.RuntimeObject ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithData_type_size_( System.IntPtr data, uint type, uint size ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithData_type_size_( Handle, CachedSelectors.initWithData_type_size_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( uint ) + sizeof( uint ), data, type, size );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithNSData_type_size_( NObjective.RuntimeObject data, uint type, uint size ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithNSData_type_size_( Handle, CachedSelectors.initWithNSData_type_size_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ) + sizeof( uint ), data, type, size );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject replacementObjectForPortCoder_( NObjective.RuntimeObject coder ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.replacementObjectForPortCoder_( Handle, CachedSelectors.replacementObjectForPortCoder_, out ___occuredException, sizeof( NObjective.RuntimeObject ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void addObjectToArray_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject array );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern NObjective.RuntimeClass classForKeyedArchiver( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr dataObject( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern System.IntPtr dataPtr( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void encodeWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSCoder coder );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr eventParameterWithData_type_size_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr data, uint type, uint size );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint eventSize( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint eventType( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void initialize( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject coder );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithData_type_size_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr data, uint type, uint size );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithNSData_type_size_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject data, uint type, uint size );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool isPIDNative( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr replacementObjectForPortCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject coder );
		}
		static internal class CachedSelectors {
			public static readonly Selector addObjectToArray_ = "addObjectToArray:";
			public static readonly Selector classForKeyedArchiver = "classForKeyedArchiver";
			public static readonly Selector dataObject = "dataObject";
			public static readonly Selector dataPtr = "dataPtr";
			public static readonly Selector encodeWithCoder_ = "encodeWithCoder:";
			public static readonly Selector eventParameterWithData_type_size_ = "eventParameterWithData:type:size:";
			public static readonly Selector eventSize = "eventSize";
			public static readonly Selector eventType = "eventType";
			public static readonly Selector initialize = "initialize";
			public static readonly Selector initWithCoder_ = "initWithCoder:";
			public static readonly Selector initWithData_type_size_ = "initWithData:type:size:";
			public static readonly Selector initWithNSData_type_size_ = "initWithNSData:type:size:";
			public static readonly Selector isPIDNative = "isPIDNative";
			public static readonly Selector replacementObjectForPortCoder_ = "replacementObjectForPortCoder:";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct IPMDFontRange : IEquatable<IPMDFontRange> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = HIToolboxCachedClasses.IPMDFontRange;
		public static implicit operator IntPtr( IPMDFontRange value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( IPMDFontRange value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as IPMDFontRange?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( IPMDFontRange value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( IPMDFontRange value1, IPMDFontRange value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( IPMDFontRange value1, IPMDFontRange value2 ) {
			return value1.Handle != value2.Handle;
		}
		public IPMDFontRange( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static IPMDFontRange alloc() {
			return new IPMDFontRange( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
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
			var compareTo = value as NSHIObject?;
			return compareTo != null && Handle == compareTo.Value.Handle;
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
		unsafe public void undoWithObject_( NObjective.RuntimeObject @object ) {
			RuntimeObject ___occuredException;
			NativeMethods.undoWithObject_( Handle, CachedSelectors.undoWithObject_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @object );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void encodeWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSCoder coder );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject coder );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void undoWithObject_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object );
		}
		static internal class CachedSelectors {
			public static readonly Selector encodeWithCoder_ = "encodeWithCoder:";
			public static readonly Selector initWithCoder_ = "initWithCoder:";
			public static readonly Selector undoWithObject_ = "undoWithObject:";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct NSHIUndoObject : IEquatable<NSHIUndoObject> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = HIToolboxCachedClasses.NSHIUndoObject;
		public static implicit operator IntPtr( NSHIUndoObject value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( NSHIUndoObject value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as NSHIUndoObject?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( NSHIUndoObject value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( NSHIUndoObject value1, NSHIUndoObject value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( NSHIUndoObject value1, NSHIUndoObject value2 ) {
			return value1.Handle != value2.Handle;
		}
		public NSHIUndoObject( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static NSHIUndoObject alloc() {
			return new NSHIUndoObject( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
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
			var compareTo = value as NSKeyedArchiverWrapper?;
			return compareTo != null && Handle == compareTo.Value.Handle;
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
			var compareTo = value as NSKeyedUnarchiverWrapper?;
			return compareTo != null && Handle == compareTo.Value.Handle;
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
	[ProxyBaseClass(typeof( NSObject ))]
	public struct PluginParser : IEquatable<PluginParser> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = HIToolboxCachedClasses.PluginParser;
		public static implicit operator IntPtr( PluginParser value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( PluginParser value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as PluginParser?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( PluginParser value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( PluginParser value1, PluginParser value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( PluginParser value1, PluginParser value2 ) {
			return value1.Handle != value2.Handle;
		}
		public PluginParser( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static PluginParser alloc() {
			return new PluginParser( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void addEntries_forKey_( NObjective.RuntimeObject entries, NObjective.RuntimeObject forKey ) {
			RuntimeObject ___occuredException;
			NativeMethods.addEntries_forKey_( Handle, CachedSelectors.addEntries_forKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), entries, forKey );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void addEntry_forKey_( NObjective.RuntimeObject entry, NObjective.RuntimeObject forKey ) {
			RuntimeObject ___occuredException;
			NativeMethods.addEntry_forKey_( Handle, CachedSelectors.addEntry_forKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), entry, forKey );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject data_( NObjective.RuntimeObject data ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.data_( Handle, CachedSelectors.data_, out ___occuredException, sizeof( NObjective.RuntimeObject ), data );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject dictionary() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dictionary( Handle, CachedSelectors.dictionary, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public bool isComment_delimiter_( NObjective.RuntimeObject comment, NObjective.RuntimeObject delimiter ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isComment_delimiter_( Handle, CachedSelectors.isComment_delimiter_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), comment, delimiter );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject key_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.key_( Handle, CachedSelectors.key_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject keyForIndex_( int index ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.keyForIndex_( Handle, CachedSelectors.keyForIndex_, out ___occuredException, sizeof( int ), index );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public int keyToIndex_( NObjective.RuntimeObject index ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.keyToIndex_( Handle, CachedSelectors.keyToIndex_, out ___occuredException, sizeof( NObjective.RuntimeObject ), index );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject linesOfFile() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.linesOfFile( Handle, CachedSelectors.linesOfFile, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char openCodeFile_withEncoding_( NObjective.RuntimeObject file, uint withEncoding ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.openCodeFile_withEncoding_( Handle, CachedSelectors.openCodeFile_withEncoding_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ), file, withEncoding );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void setKeysAndEncoding_( NObjective.RuntimeObject encoding ) {
			RuntimeObject ___occuredException;
			NativeMethods.setKeysAndEncoding_( Handle, CachedSelectors.setKeysAndEncoding_, out ___occuredException, sizeof( NObjective.RuntimeObject ), encoding );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject tokens_( NObjective.RuntimeObject tokens ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.tokens_( Handle, CachedSelectors.tokens_, out ___occuredException, sizeof( NObjective.RuntimeObject ), tokens );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void addEntries_forKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entries, NObjective.RuntimeObject forKey );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void addEntry_forKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject entry, NObjective.RuntimeObject forKey );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr data_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject data );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr dictionary( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool isComment_delimiter_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject comment, NObjective.RuntimeObject delimiter );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr key_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr keyForIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int index );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern int keyToIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject index );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr linesOfFile( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char openCodeFile_withEncoding_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file, uint withEncoding );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setKeysAndEncoding_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject encoding );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr tokens_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject tokens );
		}
		static internal class CachedSelectors {
			public static readonly Selector addEntries_forKey_ = "addEntries:forKey:";
			public static readonly Selector addEntry_forKey_ = "addEntry:forKey:";
			public static readonly Selector data_ = "data:";
			public static readonly Selector dictionary = "dictionary";
			public static readonly Selector isComment_delimiter_ = "isComment:delimiter:";
			public static readonly Selector key_ = "key:";
			public static readonly Selector keyForIndex_ = "keyForIndex:";
			public static readonly Selector keyToIndex_ = "keyToIndex:";
			public static readonly Selector linesOfFile = "linesOfFile";
			public static readonly Selector openCodeFile_withEncoding_ = "openCodeFile:withEncoding:";
			public static readonly Selector setKeysAndEncoding_ = "setKeysAndEncoding:";
			public static readonly Selector tokens_ = "tokens:";
		}
	}
	[ProxyBaseClass(typeof( PluginReaderGenericModule ))]
	public struct PluginReaderDATFileModule : IEquatable<PluginReaderDATFileModule> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = HIToolboxCachedClasses.PluginReaderDATFileModule;
		public static implicit operator IntPtr( PluginReaderDATFileModule value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( PluginReaderDATFileModule value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as PluginReaderDATFileModule?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( PluginReaderDATFileModule value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( PluginReaderDATFileModule value1, PluginReaderDATFileModule value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( PluginReaderDATFileModule value1, PluginReaderDATFileModule value2 ) {
			return value1.Handle != value2.Handle;
		}
		public PluginReaderDATFileModule( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static PluginReaderDATFileModule alloc() {
			return new PluginReaderDATFileModule( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject initForBasicPropertiesWithFile_( NObjective.RuntimeObject file ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initForBasicPropertiesWithFile_( Handle, CachedSelectors.initForBasicPropertiesWithFile_, out ___occuredException, sizeof( NObjective.RuntimeObject ), file );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithFileName_( NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithFileName_( Handle, CachedSelectors.initWithFileName_, out ___occuredException, sizeof( NObjective.RuntimeObject ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void writePluginInformationIntoDictionary() {
			RuntimeObject ___occuredException;
			NativeMethods.writePluginInformationIntoDictionary( Handle, CachedSelectors.writePluginInformationIntoDictionary, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initForBasicPropertiesWithFile_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithFileName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void writePluginInformationIntoDictionary( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector initForBasicPropertiesWithFile_ = "initForBasicPropertiesWithFile:";
			public static readonly Selector initWithFileName_ = "initWithFileName:";
			public static readonly Selector writePluginInformationIntoDictionary = "writePluginInformationIntoDictionary";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct PluginReaderGenericModule : IEquatable<PluginReaderGenericModule> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = HIToolboxCachedClasses.PluginReaderGenericModule;
		public static implicit operator IntPtr( PluginReaderGenericModule value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( PluginReaderGenericModule value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as PluginReaderGenericModule?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( PluginReaderGenericModule value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( PluginReaderGenericModule value1, PluginReaderGenericModule value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( PluginReaderGenericModule value1, PluginReaderGenericModule value2 ) {
			return value1.Handle != value2.Handle;
		}
		public PluginReaderGenericModule( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static PluginReaderGenericModule alloc() {
			return new PluginReaderGenericModule( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject dictionary() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dictionary( Handle, CachedSelectors.dictionary, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initForBasicProperties() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initForBasicProperties( Handle, CachedSelectors.initForBasicProperties, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject inputMethodInformation() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.inputMethodInformation( Handle, CachedSelectors.inputMethodInformation, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char parse() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.parse( Handle, CachedSelectors.parse, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char parseForBasicProperties() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.parseForBasicProperties( Handle, CachedSelectors.parseForBasicProperties, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void setInputModeID_( NObjective.RuntimeObject id ) {
			RuntimeObject ___occuredException;
			NativeMethods.setInputModeID_( Handle, CachedSelectors.setInputModeID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setInputSourceID_( NObjective.RuntimeObject id ) {
			RuntimeObject ___occuredException;
			NativeMethods.setInputSourceID_( Handle, CachedSelectors.setInputSourceID_, out ___occuredException, sizeof( NObjective.RuntimeObject ), id );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setIntendedLanguage_( NObjective.RuntimeObject language ) {
			RuntimeObject ___occuredException;
			NativeMethods.setIntendedLanguage_( Handle, CachedSelectors.setIntendedLanguage_, out ___occuredException, sizeof( NObjective.RuntimeObject ), language );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setLocalizedName_( NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			NativeMethods.setLocalizedName_( Handle, CachedSelectors.setLocalizedName_, out ___occuredException, sizeof( NObjective.RuntimeObject ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr dictionary( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initForBasicProperties( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr inputMethodInformation( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char parse( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char parseForBasicProperties( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setInputModeID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setInputSourceID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject id );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setIntendedLanguage_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject language );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setLocalizedName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name );
		}
		static internal class CachedSelectors {
			public static readonly Selector dictionary = "dictionary";
			public static readonly Selector initForBasicProperties = "initForBasicProperties";
			public static readonly Selector inputMethodInformation = "inputMethodInformation";
			public static readonly Selector parse = "parse";
			public static readonly Selector parseForBasicProperties = "parseForBasicProperties";
			public static readonly Selector setInputModeID_ = "setInputModeID:";
			public static readonly Selector setInputSourceID_ = "setInputSourceID:";
			public static readonly Selector setIntendedLanguage_ = "setIntendedLanguage:";
			public static readonly Selector setLocalizedName_ = "setLocalizedName:";
		}
	}
	[ProxyBaseClass(typeof( PluginReaderGenericModule ))]
	public struct PluginReaderNativeFileModule : IEquatable<PluginReaderNativeFileModule> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = HIToolboxCachedClasses.PluginReaderNativeFileModule;
		public static implicit operator IntPtr( PluginReaderNativeFileModule value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( PluginReaderNativeFileModule value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as PluginReaderNativeFileModule?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( PluginReaderNativeFileModule value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( PluginReaderNativeFileModule value1, PluginReaderNativeFileModule value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( PluginReaderNativeFileModule value1, PluginReaderNativeFileModule value2 ) {
			return value1.Handle != value2.Handle;
		}
		public PluginReaderNativeFileModule( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static PluginReaderNativeFileModule alloc() {
			return new PluginReaderNativeFileModule( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject initForBasicPropertiesWithFile_( NObjective.RuntimeObject file ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initForBasicPropertiesWithFile_( Handle, CachedSelectors.initForBasicPropertiesWithFile_, out ___occuredException, sizeof( NObjective.RuntimeObject ), file );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithFile_( NObjective.RuntimeObject file ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithFile_( Handle, CachedSelectors.initWithFile_, out ___occuredException, sizeof( NObjective.RuntimeObject ), file );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char parseBody_( NObjective.RuntimeObject body ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.parseBody_( Handle, CachedSelectors.parseBody_, out ___occuredException, sizeof( NObjective.RuntimeObject ), body );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char parseForBasicPropertiesWithByteOrder_( int order ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.parseForBasicPropertiesWithByteOrder_( Handle, CachedSelectors.parseForBasicPropertiesWithByteOrder_, out ___occuredException, sizeof( int ), order );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject parseHeader() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.parseHeader( Handle, CachedSelectors.parseHeader, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setEncoding_( int encoding ) {
			RuntimeObject ___occuredException;
			NativeMethods.setEncoding_( Handle, CachedSelectors.setEncoding_, out ___occuredException, sizeof( int ), encoding );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setIMChineseName_( NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			NativeMethods.setIMChineseName_( Handle, CachedSelectors.setIMChineseName_, out ___occuredException, sizeof( NObjective.RuntimeObject ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setKeyPrompt_( NObjective.RuntimeObject prompt ) {
			RuntimeObject ___occuredException;
			NativeMethods.setKeyPrompt_( Handle, CachedSelectors.setKeyPrompt_, out ___occuredException, sizeof( NObjective.RuntimeObject ), prompt );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setMaxCode_( NObjective.RuntimeObject code ) {
			RuntimeObject ___occuredException;
			NativeMethods.setMaxCode_( Handle, CachedSelectors.setMaxCode_, out ___occuredException, sizeof( NObjective.RuntimeObject ), code );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setSeparator_( NObjective.RuntimeObject separator ) {
			RuntimeObject ___occuredException;
			NativeMethods.setSeparator_( Handle, CachedSelectors.setSeparator_, out ___occuredException, sizeof( NObjective.RuntimeObject ), separator );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setValidInputKeys_( NObjective.RuntimeObject keys ) {
			RuntimeObject ___occuredException;
			NativeMethods.setValidInputKeys_( Handle, CachedSelectors.setValidInputKeys_, out ___occuredException, sizeof( NObjective.RuntimeObject ), keys );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setVersion_( NObjective.RuntimeObject version ) {
			RuntimeObject ___occuredException;
			NativeMethods.setVersion_( Handle, CachedSelectors.setVersion_, out ___occuredException, sizeof( NObjective.RuntimeObject ), version );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void writePluginInformationIntoDictionary() {
			RuntimeObject ___occuredException;
			NativeMethods.writePluginInformationIntoDictionary( Handle, CachedSelectors.writePluginInformationIntoDictionary, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initForBasicPropertiesWithFile_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithFile_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char parseBody_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject body );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char parseForBasicPropertiesWithByteOrder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int order );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr parseHeader( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setEncoding_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int encoding );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setIMChineseName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setKeyPrompt_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject prompt );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setMaxCode_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject code );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setSeparator_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject separator );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setValidInputKeys_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject keys );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setVersion_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject version );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void writePluginInformationIntoDictionary( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector initForBasicPropertiesWithFile_ = "initForBasicPropertiesWithFile:";
			public static readonly Selector initWithFile_ = "initWithFile:";
			public static readonly Selector parseBody_ = "parseBody:";
			public static readonly Selector parseForBasicPropertiesWithByteOrder_ = "parseForBasicPropertiesWithByteOrder:";
			public static readonly Selector parseHeader = "parseHeader";
			public static readonly Selector setEncoding_ = "setEncoding:";
			public static readonly Selector setIMChineseName_ = "setIMChineseName:";
			public static readonly Selector setKeyPrompt_ = "setKeyPrompt:";
			public static readonly Selector setMaxCode_ = "setMaxCode:";
			public static readonly Selector setSeparator_ = "setSeparator:";
			public static readonly Selector setValidInputKeys_ = "setValidInputKeys:";
			public static readonly Selector setVersion_ = "setVersion:";
			public static readonly Selector writePluginInformationIntoDictionary = "writePluginInformationIntoDictionary";
		}
	}
	[ProxyBaseClass(typeof( PluginReaderGenericModule ))]
	public struct PluginReaderOpenVanillaFileModule : IEquatable<PluginReaderOpenVanillaFileModule> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = HIToolboxCachedClasses.PluginReaderOpenVanillaFileModule;
		public static implicit operator IntPtr( PluginReaderOpenVanillaFileModule value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( PluginReaderOpenVanillaFileModule value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as PluginReaderOpenVanillaFileModule?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( PluginReaderOpenVanillaFileModule value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( PluginReaderOpenVanillaFileModule value1, PluginReaderOpenVanillaFileModule value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( PluginReaderOpenVanillaFileModule value1, PluginReaderOpenVanillaFileModule value2 ) {
			return value1.Handle != value2.Handle;
		}
		public PluginReaderOpenVanillaFileModule( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static PluginReaderOpenVanillaFileModule alloc() {
			return new PluginReaderOpenVanillaFileModule( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject initForBasicPropertiesWithFile_( NObjective.RuntimeObject file ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initForBasicPropertiesWithFile_( Handle, CachedSelectors.initForBasicPropertiesWithFile_, out ___occuredException, sizeof( NObjective.RuntimeObject ), file );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithFile_( NObjective.RuntimeObject file ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithFile_( Handle, CachedSelectors.initWithFile_, out ___occuredException, sizeof( NObjective.RuntimeObject ), file );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char parseCharDef_( NObjective.RuntimeObject def ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.parseCharDef_( Handle, CachedSelectors.parseCharDef_, out ___occuredException, sizeof( NObjective.RuntimeObject ), def );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void parseKeyName_( NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			NativeMethods.parseKeyName_( Handle, CachedSelectors.parseKeyName_, out ___occuredException, sizeof( NObjective.RuntimeObject ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setIMChineseName_( NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			NativeMethods.setIMChineseName_( Handle, CachedSelectors.setIMChineseName_, out ___occuredException, sizeof( NObjective.RuntimeObject ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setIMEnglishName_( NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			NativeMethods.setIMEnglishName_( Handle, CachedSelectors.setIMEnglishName_, out ___occuredException, sizeof( NObjective.RuntimeObject ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setKeyPrompt_( NObjective.RuntimeObject prompt ) {
			RuntimeObject ___occuredException;
			NativeMethods.setKeyPrompt_( Handle, CachedSelectors.setKeyPrompt_, out ___occuredException, sizeof( NObjective.RuntimeObject ), prompt );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setSelectionKeys_( NObjective.RuntimeObject keys ) {
			RuntimeObject ___occuredException;
			NativeMethods.setSelectionKeys_( Handle, CachedSelectors.setSelectionKeys_, out ___occuredException, sizeof( NObjective.RuntimeObject ), keys );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setValidInputKeys_( NObjective.RuntimeObject keys ) {
			RuntimeObject ___occuredException;
			NativeMethods.setValidInputKeys_( Handle, CachedSelectors.setValidInputKeys_, out ___occuredException, sizeof( NObjective.RuntimeObject ), keys );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void writePluginInformationIntoDictionary() {
			RuntimeObject ___occuredException;
			NativeMethods.writePluginInformationIntoDictionary( Handle, CachedSelectors.writePluginInformationIntoDictionary, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initForBasicPropertiesWithFile_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithFile_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char parseCharDef_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject def );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void parseKeyName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setIMChineseName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setIMEnglishName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setKeyPrompt_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject prompt );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setSelectionKeys_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject keys );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setValidInputKeys_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject keys );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void writePluginInformationIntoDictionary( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector initForBasicPropertiesWithFile_ = "initForBasicPropertiesWithFile:";
			public static readonly Selector initWithFile_ = "initWithFile:";
			public static readonly Selector parseCharDef_ = "parseCharDef:";
			public static readonly Selector parseKeyName_ = "parseKeyName:";
			public static readonly Selector setIMChineseName_ = "setIMChineseName:";
			public static readonly Selector setIMEnglishName_ = "setIMEnglishName:";
			public static readonly Selector setKeyPrompt_ = "setKeyPrompt:";
			public static readonly Selector setSelectionKeys_ = "setSelectionKeys:";
			public static readonly Selector setValidInputKeys_ = "setValidInputKeys:";
			public static readonly Selector writePluginInformationIntoDictionary = "writePluginInformationIntoDictionary";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct TISInputMethodDataFileLoader : IEquatable<TISInputMethodDataFileLoader> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = HIToolboxCachedClasses.TISInputMethodDataFileLoader;
		public static implicit operator IntPtr( TISInputMethodDataFileLoader value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( TISInputMethodDataFileLoader value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as TISInputMethodDataFileLoader?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( TISInputMethodDataFileLoader value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( TISInputMethodDataFileLoader value1, TISInputMethodDataFileLoader value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( TISInputMethodDataFileLoader value1, TISInputMethodDataFileLoader value2 ) {
			return value1.Handle != value2.Handle;
		}
		public TISInputMethodDataFileLoader( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static TISInputMethodDataFileLoader alloc() {
			return new TISInputMethodDataFileLoader( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void chooseFormat_( NObjective.RuntimeObject format ) {
			RuntimeObject ___occuredException;
			NativeMethods.chooseFormat_( Handle, CachedSelectors.chooseFormat_, out ___occuredException, sizeof( NObjective.RuntimeObject ), format );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject initForBasicPropertiesWithFile_( NObjective.RuntimeObject file ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initForBasicPropertiesWithFile_( Handle, CachedSelectors.initForBasicPropertiesWithFile_, out ___occuredException, sizeof( NObjective.RuntimeObject ), file );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithFile_( NObjective.RuntimeObject file ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithFile_( Handle, CachedSelectors.initWithFile_, out ___occuredException, sizeof( NObjective.RuntimeObject ), file );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char parse() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.parse( Handle, CachedSelectors.parse, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char parseForBasicProperties() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.parseForBasicProperties( Handle, CachedSelectors.parseForBasicProperties, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void chooseFormat_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject format );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initForBasicPropertiesWithFile_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithFile_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char parse( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char parseForBasicProperties( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector chooseFormat_ = "chooseFormat:";
			public static readonly Selector initForBasicPropertiesWithFile_ = "initForBasicPropertiesWithFile:";
			public static readonly Selector initWithFile_ = "initWithFile:";
			public static readonly Selector parse = "parse";
			public static readonly Selector parseForBasicProperties = "parseForBasicProperties";
		}
	}
	static internal class HIToolboxCachedClasses {
		static internal int ___lazyLoad = Platform.NativeMethods.dlopen( "/System/Library/Frameworks/Carbon.framework/Versions/A/Frameworks/HIToolbox.framework/Versions/A/HIToolbox" );
		public static readonly RuntimeClass IMKClient = "IMKClient";
		public static readonly RuntimeClass IMKEvent = "IMKEvent";
		public static readonly RuntimeClass IMKInputSession = "IMKInputSession";
		public static readonly RuntimeClass IPMDEventParameter = "IPMDEventParameter";
		public static readonly RuntimeClass IPMDFontRange = "IPMDFontRange";
		public static readonly RuntimeClass NSHIObject = "NSHIObject";
		public static readonly RuntimeClass NSHIUndoObject = "NSHIUndoObject";
		public static readonly RuntimeClass NSKeyedArchiverWrapper = "NSKeyedArchiverWrapper";
		public static readonly RuntimeClass NSKeyedUnarchiverWrapper = "NSKeyedUnarchiverWrapper";
		public static readonly RuntimeClass PluginParser = "PluginParser";
		public static readonly RuntimeClass PluginReaderDATFileModule = "PluginReaderDATFileModule";
		public static readonly RuntimeClass PluginReaderGenericModule = "PluginReaderGenericModule";
		public static readonly RuntimeClass PluginReaderNativeFileModule = "PluginReaderNativeFileModule";
		public static readonly RuntimeClass PluginReaderOpenVanillaFileModule = "PluginReaderOpenVanillaFileModule";
		public static readonly RuntimeClass TISInputMethodDataFileLoader = "TISInputMethodDataFileLoader";
	}
}
