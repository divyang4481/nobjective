//
// Copyright (C) 2009 Eugeny Grishul
//
// See license in License.txt
//

namespace NObjective.Proxies {
	using System;
	using System.Runtime.InteropServices;
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DRAudioGenerator : IEquatable<DRAudioGenerator> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRAudioGenerator;
		public static implicit operator IntPtr( DRAudioGenerator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRAudioGenerator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRAudioGenerator ) ) return false; 
			return Handle == ( ( DRAudioGenerator )value ).Handle;
		}
		public bool Equals( DRAudioGenerator value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRAudioGenerator value1, DRAudioGenerator value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRAudioGenerator value1, DRAudioGenerator value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRAudioGenerator( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRAudioGenerator alloc() {
			return new DRAudioGenerator( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public char completed() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.completed( Handle, CachedSelectors.completed, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject initWithGeneratorInfo_( NObjective.RuntimeObject info ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithGeneratorInfo_( Handle, CachedSelectors.initWithGeneratorInfo_, out ___occuredException, sizeof( NObjective.RuntimeObject ), info );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public uint produceIntoBuffer_length_blockSize_( System.IntPtr buffer, uint length, uint blockSize ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.produceIntoBuffer_length_blockSize_( Handle, CachedSelectors.produceIntoBuffer_length_blockSize_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( uint ) + sizeof( uint ), buffer, length, blockSize );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char completed( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithGeneratorInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject info );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint produceIntoBuffer_length_blockSize_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr buffer, uint length, uint blockSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector completed = "completed";
			public static readonly Selector initWithGeneratorInfo_ = "initWithGeneratorInfo:";
			public static readonly Selector produceIntoBuffer_length_blockSize_ = "produceIntoBuffer:length:blockSize:";
		}
	}
	[ProxyBaseClass(typeof( DRTrack ))]
	public struct DRAudioTrack : IEquatable<DRAudioTrack> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRAudioTrack;
		public static implicit operator IntPtr( DRAudioTrack value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRAudioTrack value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRAudioTrack ) ) return false; 
			return Handle == ( ( DRAudioTrack )value ).Handle;
		}
		public bool Equals( DRAudioTrack value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRAudioTrack value1, DRAudioTrack value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRAudioTrack value1, DRAudioTrack value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRAudioTrack( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRAudioTrack alloc() {
			return new DRAudioTrack( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject initWithPath_( NObjective.RuntimeObject path ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithPath_( Handle, CachedSelectors.initWithPath_, out ___occuredException, sizeof( NObjective.RuntimeObject ), path );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithPath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject path );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithPath_ = "initWithPath:";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DRBINFileProducer : IEquatable<DRBINFileProducer> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRBINFileProducer;
		public static implicit operator IntPtr( DRBINFileProducer value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRBINFileProducer value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRBINFileProducer ) ) return false; 
			return Handle == ( ( DRBINFileProducer )value ).Handle;
		}
		public bool Equals( DRBINFileProducer value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRBINFileProducer value1, DRBINFileProducer value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRBINFileProducer value1, DRBINFileProducer value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRBINFileProducer( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRBINFileProducer alloc() {
			return new DRBINFileProducer( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject producer() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.producer( ClassHandle, CachedSelectors.producer, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void cleanupTrackAfterBurn_( NObjective.RuntimeObject burn ) {
			RuntimeObject ___occuredException;
			NativeMethods.cleanupTrackAfterBurn_( Handle, CachedSelectors.cleanupTrackAfterBurn_, out ___occuredException, sizeof( NObjective.RuntimeObject ), burn );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public char prepareTrack_forBurn_toMedia_( NObjective.RuntimeObject track, NObjective.RuntimeObject forBurn, NObjective.RuntimeObject toMedia ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.prepareTrack_forBurn_toMedia_( Handle, CachedSelectors.prepareTrack_forBurn_toMedia_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), track, forBurn, toMedia );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public uint produceDataForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( NObjective.RuntimeObject track, System.IntPtr intoBuffer, uint length, ulong atAddress, uint blockSize, System.IntPtr ioFlags ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.produceDataForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( Handle, CachedSelectors.produceDataForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( uint ) + sizeof( ulong ) + sizeof( uint ) + sizeof( System.IntPtr ), track, intoBuffer, length, atAddress, blockSize, ioFlags
			 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public uint produceDataIntoBuffer_length_blockSize_( System.IntPtr buffer, uint length, uint blockSize ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.produceDataIntoBuffer_length_blockSize_( Handle, CachedSelectors.produceDataIntoBuffer_length_blockSize_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( uint ) + sizeof( uint ), buffer, length, blockSize );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public uint producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( NObjective.RuntimeObject track, System.IntPtr intoBuffer, uint length, ulong atAddress, uint blockSize, System.IntPtr ioFlags ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( Handle, CachedSelectors.producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( uint ) + sizeof( ulong ) + sizeof( uint ) + sizeof( System.IntPtr ), track, intoBuffer, length, atAddress, blockSize, ioFlags
			 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void cleanupTrackAfterBurn_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject burn );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char prepareTrack_forBurn_toMedia_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject track, NObjective.RuntimeObject forBurn, NObjective.RuntimeObject toMedia );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint produceDataForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject track, System.IntPtr intoBuffer, uint length, ulong atAddress, uint blockSize, System.IntPtr ioFlags
			 );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint produceDataIntoBuffer_length_blockSize_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr buffer, uint length, uint blockSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject track, System.IntPtr intoBuffer, uint length, ulong atAddress, uint blockSize, System.IntPtr ioFlags
			 );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr producer( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector cleanupTrackAfterBurn_ = "cleanupTrackAfterBurn:";
			public static readonly Selector prepareTrack_forBurn_toMedia_ = "prepareTrack:forBurn:toMedia:";
			public static readonly Selector produceDataForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_ = "produceDataForTrack:intoBuffer:length:atAddress:blockSize:ioFlags:";
			public static readonly Selector produceDataIntoBuffer_length_blockSize_ = "produceDataIntoBuffer:length:blockSize:";
			public static readonly Selector producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_ = "producePreGapForTrack:intoBuffer:length:atAddress:blockSize:ioFlags:";
			public static readonly Selector producer = "producer";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DRBurn : IEquatable<DRBurn> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRBurn;
		public static implicit operator IntPtr( DRBurn value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRBurn value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRBurn ) ) return false; 
			return Handle == ( ( DRBurn )value ).Handle;
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
		unsafe public static void initialize() {
			RuntimeObject ___occuredException;
			NativeMethods.initialize( ClassHandle, CachedSelectors.initialize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static bool isPropertyKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isPropertyKey_( ClassHandle, CachedSelectors.isPropertyKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static NObjective.RuntimeObject layoutForImageFile_( string file ) {
			RuntimeObject ___occuredException;
			var ___wrappedfile = Runtime.CreateStringProxy( file );
			var ___result = NativeMethods.layoutForImageFile_( ClassHandle, CachedSelectors.layoutForImageFile_, out ___occuredException, sizeof( IntPtr ), ___wrappedfile );
			Runtime.ReleaseNativeObject( ___wrappedfile );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static void setupBindings() {
			RuntimeObject ___occuredException;
			NativeMethods.setupBindings( ClassHandle, CachedSelectors.setupBindings, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
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
		unsafe public void setValue_forUndefinedKey_( NObjective.RuntimeObject value, NObjective.RuntimeObject forUndefinedKey ) {
			RuntimeObject ___occuredException;
			NativeMethods.setValue_forUndefinedKey_( Handle, CachedSelectors.setValue_forUndefinedKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), value, forUndefinedKey );
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
		unsafe public NObjective.RuntimeObject valueForUndefinedKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.valueForUndefinedKey_( Handle, CachedSelectors.valueForUndefinedKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
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
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void abort( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool appendable( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr burnForDevice_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRDevice device );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char burnUnderrunProtection( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr completionAction( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr device( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void initialize( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithDevice_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRDevice device );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool isPropertyKey_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr layoutForImageFile_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr file );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr properties( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2")]
			public static extern float requestedBurnSpeed( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setAppendable_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, bool appendable );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setBurnUnderrunProtection_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, char protection );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setCompletionAction_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr action );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setProperties_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDictionary properties );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setRequestedBurnSpeed_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, float speed );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setTestBurn_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, char burn );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setupBindings( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setValue_forUndefinedKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject value, NObjective.RuntimeObject forUndefinedKey );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setVerifyDisc_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, bool disc );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr status( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char testBurn( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr valueForUndefinedKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool verifyDisc( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void writeLayout_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject layout );
		}
		static internal class CachedSelectors {
			public static readonly Selector abort = "abort";
			public static readonly Selector appendable = "appendable";
			public static readonly Selector burnForDevice_ = "burnForDevice:";
			public static readonly Selector burnUnderrunProtection = "burnUnderrunProtection";
			public static readonly Selector completionAction = "completionAction";
			public static readonly Selector device = "device";
			public static readonly Selector initialize = "initialize";
			public static readonly Selector initWithDevice_ = "initWithDevice:";
			public static readonly Selector isPropertyKey_ = "isPropertyKey:";
			public static readonly Selector layoutForImageFile_ = "layoutForImageFile:";
			public static readonly Selector properties = "properties";
			public static readonly Selector requestedBurnSpeed = "requestedBurnSpeed";
			public static readonly Selector setAppendable_ = "setAppendable:";
			public static readonly Selector setBurnUnderrunProtection_ = "setBurnUnderrunProtection:";
			public static readonly Selector setCompletionAction_ = "setCompletionAction:";
			public static readonly Selector setProperties_ = "setProperties:";
			public static readonly Selector setRequestedBurnSpeed_ = "setRequestedBurnSpeed:";
			public static readonly Selector setTestBurn_ = "setTestBurn:";
			public static readonly Selector setupBindings = "setupBindings";
			public static readonly Selector setValue_forUndefinedKey_ = "setValue:forUndefinedKey:";
			public static readonly Selector setVerifyDisc_ = "setVerifyDisc:";
			public static readonly Selector status = "status";
			public static readonly Selector testBurn = "testBurn";
			public static readonly Selector valueForUndefinedKey_ = "valueForUndefinedKey:";
			public static readonly Selector verifyDisc = "verifyDisc";
			public static readonly Selector writeLayout_ = "writeLayout:";
		}
	}
	[ProxyBaseClass(typeof( DRDevice ))]
	public struct DRCallbackDevice : IEquatable<DRCallbackDevice> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRCallbackDevice;
		public static implicit operator IntPtr( DRCallbackDevice value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRCallbackDevice value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRCallbackDevice ) ) return false; 
			return Handle == ( ( DRCallbackDevice )value ).Handle;
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
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithConsumer_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject consumer );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithConsumer_ = "initWithConsumer:";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DRCDTextBlock : IEquatable<DRCDTextBlock> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRCDTextBlock;
		public static implicit operator IntPtr( DRCDTextBlock value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRCDTextBlock value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRCDTextBlock ) ) return false; 
			return Handle == ( ( DRCDTextBlock )value ).Handle;
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
		unsafe public static DRCDTextBlock cdTextBlockWithLanguage_encoding_( string language, NSStringEncoding encoding ) {
			RuntimeObject ___occuredException;
			var ___wrappedlanguage = Runtime.CreateStringProxy( language );
			var ___result = NativeMethods.cdTextBlockWithLanguage_encoding_( ClassHandle, CachedSelectors.cdTextBlockWithLanguage_encoding_, out ___occuredException, sizeof( IntPtr ) + sizeof( NSStringEncoding ), ___wrappedlanguage, encoding );
			Runtime.ReleaseNativeObject( ___wrappedlanguage );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRCDTextBlock( ___result );
		}
		unsafe public static void initialize() {
			RuntimeObject ___occuredException;
			NativeMethods.initialize( ClassHandle, CachedSelectors.initialize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static bool isPropertyKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isPropertyKey_( ClassHandle, CachedSelectors.isPropertyKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static void setupBindings() {
			RuntimeObject ___occuredException;
			NativeMethods.setupBindings( ClassHandle, CachedSelectors.setupBindings, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSStringEncoding encoding() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.encoding( Handle, CachedSelectors.encoding, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( NSStringEncoding )___result;
		}
		unsafe public uint flatten() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.flatten( Handle, CachedSelectors.flatten, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public NObjective.RuntimeObject initWithLanguage_encoding_( string language, NSStringEncoding encoding ) {
			RuntimeObject ___occuredException;
			var ___wrappedlanguage = Runtime.CreateStringProxy( language );
			var ___result = NativeMethods.initWithLanguage_encoding_( Handle, CachedSelectors.initWithLanguage_encoding_, out ___occuredException, sizeof( IntPtr ) + sizeof( NSStringEncoding ), ___wrappedlanguage, encoding );
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
		unsafe public void setValue_forUndefinedKey_( NObjective.RuntimeObject value, NObjective.RuntimeObject forUndefinedKey ) {
			RuntimeObject ___occuredException;
			NativeMethods.setValue_forUndefinedKey_( Handle, CachedSelectors.setValue_forUndefinedKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), value, forUndefinedKey );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSArray trackDictionaries() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.trackDictionaries( Handle, CachedSelectors.trackDictionaries, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public char validateValue_forKey_error_( System.IntPtr value, NObjective.RuntimeObject forKey, System.IntPtr error ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.validateValue_forKey_error_( Handle, CachedSelectors.validateValue_forKey_error_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), value, forKey, error );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject valueForUndefinedKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.valueForUndefinedKey_( Handle, CachedSelectors.valueForUndefinedKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr arrayOfCDTextBlocksFromPacks_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSData packs );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr cdTextBlockWithLanguage_encoding_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr language, NSStringEncoding encoding );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint encoding( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint flatten( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void initialize( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithLanguage_encoding_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr language, NSStringEncoding encoding );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool isPropertyKey_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr language( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr objectForKey_ofTrack_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr key, uint ofTrack );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr properties( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setObject_forKey_ofTrack_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, IntPtr forKey, uint ofTrack );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setProperties_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDictionary properties );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setTrackDictionaries_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray dictionaries );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setupBindings( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setValue_forUndefinedKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject value, NObjective.RuntimeObject forUndefinedKey );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr trackDictionaries( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char validateValue_forKey_error_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr value, NObjective.RuntimeObject forKey, System.IntPtr error );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr valueForUndefinedKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
		}
		static internal class CachedSelectors {
			public static readonly Selector arrayOfCDTextBlocksFromPacks_ = "arrayOfCDTextBlocksFromPacks:";
			public static readonly Selector cdTextBlockWithLanguage_encoding_ = "cdTextBlockWithLanguage:encoding:";
			public static readonly Selector encoding = "encoding";
			public static readonly Selector flatten = "flatten";
			public static readonly Selector initialize = "initialize";
			public static readonly Selector initWithLanguage_encoding_ = "initWithLanguage:encoding:";
			public static readonly Selector isPropertyKey_ = "isPropertyKey:";
			public static readonly Selector language = "language";
			public static readonly Selector objectForKey_ofTrack_ = "objectForKey:ofTrack:";
			public static readonly Selector properties = "properties";
			public static readonly Selector setObject_forKey_ofTrack_ = "setObject:forKey:ofTrack:";
			public static readonly Selector setProperties_ = "setProperties:";
			public static readonly Selector setTrackDictionaries_ = "setTrackDictionaries:";
			public static readonly Selector setupBindings = "setupBindings";
			public static readonly Selector setValue_forUndefinedKey_ = "setValue:forUndefinedKey:";
			public static readonly Selector trackDictionaries = "trackDictionaries";
			public static readonly Selector validateValue_forKey_error_ = "validateValue:forKey:error:";
			public static readonly Selector valueForUndefinedKey_ = "valueForUndefinedKey:";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DRCueFileParser : IEquatable<DRCueFileParser> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRCueFileParser;
		public static implicit operator IntPtr( DRCueFileParser value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRCueFileParser value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRCueFileParser ) ) return false; 
			return Handle == ( ( DRCueFileParser )value ).Handle;
		}
		public bool Equals( DRCueFileParser value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRCueFileParser value1, DRCueFileParser value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRCueFileParser value1, DRCueFileParser value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRCueFileParser( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRCueFileParser alloc() {
			return new DRCueFileParser( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject burnProperties() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.burnProperties( Handle, CachedSelectors.burnProperties, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject cdText() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.cdText( Handle, CachedSelectors.cdText, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject decodeDatatype_( NObjective.RuntimeObject datatype ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.decodeDatatype_( Handle, CachedSelectors.decodeDatatype_, out ___occuredException, sizeof( NObjective.RuntimeObject ), datatype );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject extractString_( NObjective.RuntimeObject @string ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.extractString_( Handle, CachedSelectors.extractString_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @string );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject fullPathForAuxFile_( NObjective.RuntimeObject file ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.fullPathForAuxFile_( Handle, CachedSelectors.fullPathForAuxFile_, out ___occuredException, sizeof( NObjective.RuntimeObject ), file );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithPath_( NObjective.RuntimeObject path ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithPath_( Handle, CachedSelectors.initWithPath_, out ___occuredException, sizeof( NObjective.RuntimeObject ), path );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char parse() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.parse( Handle, CachedSelectors.parse, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void parseFlags_trackInfo_( NObjective.RuntimeObject flags, NObjective.RuntimeObject trackInfo ) {
			RuntimeObject ___occuredException;
			NativeMethods.parseFlags_trackInfo_( Handle, CachedSelectors.parseFlags_trackInfo_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), flags, trackInfo );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void parseIndexData_trackInfo_( NObjective.RuntimeObject data, NObjective.RuntimeObject trackInfo ) {
			RuntimeObject ___occuredException;
			NativeMethods.parseIndexData_trackInfo_( Handle, CachedSelectors.parseIndexData_trackInfo_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), data, trackInfo );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void parsePropertiesData_trackInfo_( NObjective.RuntimeObject data, NObjective.RuntimeObject trackInfo ) {
			RuntimeObject ___occuredException;
			NativeMethods.parsePropertiesData_trackInfo_( Handle, CachedSelectors.parsePropertiesData_trackInfo_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), data, trackInfo );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public int parseSourceFile_( NObjective.RuntimeObject file ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.parseSourceFile_( Handle, CachedSelectors.parseSourceFile_, out ___occuredException, sizeof( NObjective.RuntimeObject ), file );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject trackInfoForIndex_( int index ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.trackInfoForIndex_( Handle, CachedSelectors.trackInfoForIndex_, out ___occuredException, sizeof( int ), index );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject trackLayout() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.trackLayout( Handle, CachedSelectors.trackLayout, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr burnProperties( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr cdText( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr decodeDatatype_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject datatype );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr extractString_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @string );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr fullPathForAuxFile_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithPath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject path );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char parse( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void parseFlags_trackInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject flags, NObjective.RuntimeObject trackInfo );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void parseIndexData_trackInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject data, NObjective.RuntimeObject trackInfo );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void parsePropertiesData_trackInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject data, NObjective.RuntimeObject trackInfo );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern int parseSourceFile_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr trackInfoForIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int index );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr trackLayout( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector burnProperties = "burnProperties";
			public static readonly Selector cdText = "cdText";
			public static readonly Selector decodeDatatype_ = "decodeDatatype:";
			public static readonly Selector extractString_ = "extractString:";
			public static readonly Selector fullPathForAuxFile_ = "fullPathForAuxFile:";
			public static readonly Selector initWithPath_ = "initWithPath:";
			public static readonly Selector parse = "parse";
			public static readonly Selector parseFlags_trackInfo_ = "parseFlags:trackInfo:";
			public static readonly Selector parseIndexData_trackInfo_ = "parseIndexData:trackInfo:";
			public static readonly Selector parsePropertiesData_trackInfo_ = "parsePropertiesData:trackInfo:";
			public static readonly Selector parseSourceFile_ = "parseSourceFile:";
			public static readonly Selector trackInfoForIndex_ = "trackInfoForIndex:";
			public static readonly Selector trackLayout = "trackLayout";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DRDataGenerator : IEquatable<DRDataGenerator> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRDataGenerator;
		public static implicit operator IntPtr( DRDataGenerator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRDataGenerator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRDataGenerator ) ) return false; 
			return Handle == ( ( DRDataGenerator )value ).Handle;
		}
		public bool Equals( DRDataGenerator value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRDataGenerator value1, DRDataGenerator value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRDataGenerator value1, DRDataGenerator value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRDataGenerator( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRDataGenerator alloc() {
			return new DRDataGenerator( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public char completed() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.completed( Handle, CachedSelectors.completed, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject initWithGeneratorInfo_( NObjective.RuntimeObject info ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithGeneratorInfo_( Handle, CachedSelectors.initWithGeneratorInfo_, out ___occuredException, sizeof( NObjective.RuntimeObject ), info );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public uint produceIntoBuffer_length_blockSize_( System.IntPtr buffer, uint length, uint blockSize ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.produceIntoBuffer_length_blockSize_( Handle, CachedSelectors.produceIntoBuffer_length_blockSize_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( uint ) + sizeof( uint ), buffer, length, blockSize );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char completed( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithGeneratorInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject info );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint produceIntoBuffer_length_blockSize_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr buffer, uint length, uint blockSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector completed = "completed";
			public static readonly Selector initWithGeneratorInfo_ = "initWithGeneratorInfo:";
			public static readonly Selector produceIntoBuffer_length_blockSize_ = "produceIntoBuffer:length:blockSize:";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DRDevice : IEquatable<DRDevice> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRDevice;
		public static implicit operator IntPtr( DRDevice value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRDevice value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRDevice ) ) return false; 
			return Handle == ( ( DRDevice )value ).Handle;
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
		unsafe public static void initialize() {
			RuntimeObject ___occuredException;
			NativeMethods.initialize( ClassHandle, CachedSelectors.initialize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static bool isPropertyKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isPropertyKey_( ClassHandle, CachedSelectors.isPropertyKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static void setupBindings() {
			RuntimeObject ___occuredException;
			NativeMethods.setupBindings( ClassHandle, CachedSelectors.setupBindings, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
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
		unsafe public static void XMLAddDiscInfoBlockDTDToDTD_( NObjective.RuntimeObject dtd ) {
			RuntimeObject ___occuredException;
			NativeMethods.XMLAddDiscInfoBlockDTDToDTD_( ClassHandle, CachedSelectors.XMLAddDiscInfoBlockDTDToDTD_, out ___occuredException, sizeof( NObjective.RuntimeObject ), dtd );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static void XMLAddDiscInfoDTDToDTD_( NObjective.RuntimeObject dtd ) {
			RuntimeObject ___occuredException;
			NativeMethods.XMLAddDiscInfoDTDToDTD_( ClassHandle, CachedSelectors.XMLAddDiscInfoDTDToDTD_, out ___occuredException, sizeof( NObjective.RuntimeObject ), dtd );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static void XMLAddDiscInfoPOWResourcesBlockDTDToDTD_( NObjective.RuntimeObject dtd ) {
			RuntimeObject ___occuredException;
			NativeMethods.XMLAddDiscInfoPOWResourcesBlockDTDToDTD_( ClassHandle, CachedSelectors.XMLAddDiscInfoPOWResourcesBlockDTDToDTD_, out ___occuredException, sizeof( NObjective.RuntimeObject ), dtd );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static void XMLAddDiscInfoTrackResourcesBlockDTDToDTD_( NObjective.RuntimeObject dtd ) {
			RuntimeObject ___occuredException;
			NativeMethods.XMLAddDiscInfoTrackResourcesBlockDTDToDTD_( ClassHandle, CachedSelectors.XMLAddDiscInfoTrackResourcesBlockDTDToDTD_, out ___occuredException, sizeof( NObjective.RuntimeObject ), dtd );
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
			return ( uint )___result;
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
			return ( uint )___result;
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
		unsafe public NObjective.RuntimeObject valueForKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.valueForKey_( Handle, CachedSelectors.valueForKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject valueForUndefinedKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.valueForUndefinedKey_( Handle, CachedSelectors.valueForUndefinedKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
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
		unsafe public NObjective.RuntimeObject XMLFeatureElement_( NObjective.RuntimeObject element ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.XMLFeatureElement_( Handle, CachedSelectors.XMLFeatureElement_, out ___occuredException, sizeof( NObjective.RuntimeObject ), element );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject XMLFirmwareElement() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.XMLFirmwareElement( Handle, CachedSelectors.XMLFirmwareElement, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject XMLFormatCapacitiesElement() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.XMLFormatCapacitiesElement( Handle, CachedSelectors.XMLFormatCapacitiesElement, out ___occuredException, 0 );
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
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool acquireExclusiveAccess( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void acquireMediaReservation( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char appleShipping( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char appleSupported( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr bsdName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr cdText( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool closeTray( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2")]
			public static extern float currentWriteSpeed( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr deviceForBSDName_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr deviceForIORegistryEntryPath_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr path );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr devices( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr displayName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool ejectMedia( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr firmwareString( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr info( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void initialize( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithRegistryPath_forGUID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject path, NObjective.RuntimeObject forGUID );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithRegistryPath_forGUID_usingProfile_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject path, NObjective.RuntimeObject forGUID, NObjective.RuntimeObject usingProfile );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr interconnectString( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr ioRegistryEntryPath( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool isEqualToDevice_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRDevice device );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool isPropertyKey_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool isSupported( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool isValid( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2")]
			public static extern float maximumWriteSpeed( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool mediaIsAppendable( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool mediaIsBlank( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool mediaIsBusy( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool mediaIsErasable( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool mediaIsOverwritable( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool mediaIsPresent( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool mediaIsReserved( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool mediaIsTransitioning( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint mediaSessionCount( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr mediaSpaceFree( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr mediaSpaceOverwritable( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr mediaSpaceUsed( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint mediaTrackCount( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr mediaType( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool openTray( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr productString( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void releaseExclusiveAccess( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void releaseMediaReservation( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setupBindings( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr status( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool trayIsOpen( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr valueForKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr valueForUndefinedKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr vendorString( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char vendorSupported( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool writesCD( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char writesCDR( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char writesCDRW( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char writesCDText( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool writesDVD( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char writesDVDR( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char writesDVDRAM( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void XMLAddComplianceDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void XMLAddComplianceListDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void XMLAddDeviceDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void XMLAddDeviceInfoDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void XMLAddDeviceListDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void XMLAddDeviceStatusDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void XMLAddDiscInfoBlockDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void XMLAddDiscInfoDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void XMLAddDiscInfoPOWResourcesBlockDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void XMLAddDiscInfoTrackResourcesBlockDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void XMLAddFirmwareDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void XMLAddInquiryDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void XMLAddInterconnectDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void XMLAddMediaInfoDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void XMLAddProductDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void XMLAddProfileListDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void XMLAddProfilePathDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void XMLAddRawDataDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void XMLAddSupportDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void XMLAddTrackInfoListDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void XMLAddVendorDTDToDTD_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dtd );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr XMLComplianceElementWithNumber_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject number );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr XMLComplianceListElementWithArray_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject array );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr XMLDeviceElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr XMLDeviceInfoElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr XMLDeviceListElement( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr XMLDeviceStatusElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr XMLDiscInfoElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr XMLFeatureElement_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject element );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr XMLFirmwareElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr XMLFormatCapacitiesElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr XMLInquiryElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr XMLInterconnectElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr XMLMediaInfoElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr XMLProductElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr XMLProfileListElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr XMLProfilePathElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr XMLRawDataElementWithData_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject data );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr XMLSupportElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr XMLTrackInfoListElement( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
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
			public static readonly Selector initialize = "initialize";
			public static readonly Selector initWithRegistryPath_forGUID_ = "initWithRegistryPath:forGUID:";
			public static readonly Selector initWithRegistryPath_forGUID_usingProfile_ = "initWithRegistryPath:forGUID:usingProfile:";
			public static readonly Selector interconnectString = "interconnectString";
			public static readonly Selector ioRegistryEntryPath = "ioRegistryEntryPath";
			public static readonly Selector isEqualToDevice_ = "isEqualToDevice:";
			public static readonly Selector isPropertyKey_ = "isPropertyKey:";
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
			public static readonly Selector setupBindings = "setupBindings";
			public static readonly Selector status = "status";
			public static readonly Selector trayIsOpen = "trayIsOpen";
			public static readonly Selector valueForKey_ = "valueForKey:";
			public static readonly Selector valueForUndefinedKey_ = "valueForUndefinedKey:";
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
			public static readonly Selector XMLAddDiscInfoBlockDTDToDTD_ = "XMLAddDiscInfoBlockDTDToDTD:";
			public static readonly Selector XMLAddDiscInfoDTDToDTD_ = "XMLAddDiscInfoDTDToDTD:";
			public static readonly Selector XMLAddDiscInfoPOWResourcesBlockDTDToDTD_ = "XMLAddDiscInfoPOWResourcesBlockDTDToDTD:";
			public static readonly Selector XMLAddDiscInfoTrackResourcesBlockDTDToDTD_ = "XMLAddDiscInfoTrackResourcesBlockDTDToDTD:";
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
			public static readonly Selector XMLFeatureElement_ = "XMLFeatureElement:";
			public static readonly Selector XMLFirmwareElement = "XMLFirmwareElement";
			public static readonly Selector XMLFormatCapacitiesElement = "XMLFormatCapacitiesElement";
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
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DRErase : IEquatable<DRErase> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRErase;
		public static implicit operator IntPtr( DRErase value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRErase value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRErase ) ) return false; 
			return Handle == ( ( DRErase )value ).Handle;
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
		unsafe public static void initialize() {
			RuntimeObject ___occuredException;
			NativeMethods.initialize( ClassHandle, CachedSelectors.initialize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static bool isPropertyKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isPropertyKey_( ClassHandle, CachedSelectors.isPropertyKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static void setupBindings() {
			RuntimeObject ___occuredException;
			NativeMethods.setupBindings( ClassHandle, CachedSelectors.setupBindings, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
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
		unsafe public void setValue_forUndefinedKey_( NObjective.RuntimeObject value, NObjective.RuntimeObject forUndefinedKey ) {
			RuntimeObject ___occuredException;
			NativeMethods.setValue_forUndefinedKey_( Handle, CachedSelectors.setValue_forUndefinedKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), value, forUndefinedKey );
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
		unsafe public NObjective.RuntimeObject valueForUndefinedKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.valueForUndefinedKey_( Handle, CachedSelectors.valueForUndefinedKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr device( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr eraseForDevice_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRDevice device );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr eraseType( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void initialize( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithDevice_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRDevice device );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool isPropertyKey_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr properties( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setEraseType_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr type );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setProperties_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDictionary properties );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setupBindings( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setValue_forUndefinedKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject value, NObjective.RuntimeObject forUndefinedKey );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void start( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr status( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr valueForUndefinedKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
		}
		static internal class CachedSelectors {
			public static readonly Selector device = "device";
			public static readonly Selector eraseForDevice_ = "eraseForDevice:";
			public static readonly Selector eraseType = "eraseType";
			public static readonly Selector initialize = "initialize";
			public static readonly Selector initWithDevice_ = "initWithDevice:";
			public static readonly Selector isPropertyKey_ = "isPropertyKey:";
			public static readonly Selector properties = "properties";
			public static readonly Selector setEraseType_ = "setEraseType:";
			public static readonly Selector setProperties_ = "setProperties:";
			public static readonly Selector setupBindings = "setupBindings";
			public static readonly Selector setValue_forUndefinedKey_ = "setValue:forUndefinedKey:";
			public static readonly Selector start = "start";
			public static readonly Selector status = "status";
			public static readonly Selector valueForUndefinedKey_ = "valueForUndefinedKey:";
		}
	}
	[ProxyBaseClass(typeof( DRFSObject ))]
	public struct DRFile : IEquatable<DRFile> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRFile;
		public static implicit operator IntPtr( DRFile value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRFile value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRFile ) ) return false; 
			return Handle == ( ( DRFile )value ).Handle;
		}
		public bool Equals( DRFile value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRFile value1, DRFile value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRFile value1, DRFile value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRFile( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRFile alloc() {
			return new DRFile( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static DRFile fileWithPath_( string path ) {
			RuntimeObject ___occuredException;
			var ___wrappedpath = Runtime.CreateStringProxy( path );
			var ___result = NativeMethods.fileWithPath_( ClassHandle, CachedSelectors.fileWithPath_, out ___occuredException, sizeof( IntPtr ), ___wrappedpath );
			Runtime.ReleaseNativeObject( ___wrappedpath );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRFile( ___result );
		}
		unsafe public static DRFile finderAliasPointingTo_inFilesystem_( DRFSObject to, string inFilesystem ) {
			RuntimeObject ___occuredException;
			var ___wrappedinFilesystem = Runtime.CreateStringProxy( inFilesystem );
			var ___result = NativeMethods.finderAliasPointingTo_inFilesystem_( ClassHandle, CachedSelectors.finderAliasPointingTo_inFilesystem_, out ___occuredException, sizeof( DRFSObject ) + sizeof( IntPtr ), to, ___wrappedinFilesystem );
			Runtime.ReleaseNativeObject( ___wrappedinFilesystem );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRFile( ___result );
		}
		unsafe public static DRFile hardLinkPointingTo_inFilesystem_( DRFile to, string inFilesystem ) {
			RuntimeObject ___occuredException;
			var ___wrappedinFilesystem = Runtime.CreateStringProxy( inFilesystem );
			var ___result = NativeMethods.hardLinkPointingTo_inFilesystem_( ClassHandle, CachedSelectors.hardLinkPointingTo_inFilesystem_, out ___occuredException, sizeof( DRFile ) + sizeof( IntPtr ), to, ___wrappedinFilesystem );
			Runtime.ReleaseNativeObject( ___wrappedinFilesystem );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRFile( ___result );
		}
		unsafe public static DRFile symLinkPointingTo_inFilesystem_( DRFSObject to, string inFilesystem ) {
			RuntimeObject ___occuredException;
			var ___wrappedinFilesystem = Runtime.CreateStringProxy( inFilesystem );
			var ___result = NativeMethods.symLinkPointingTo_inFilesystem_( ClassHandle, CachedSelectors.symLinkPointingTo_inFilesystem_, out ___occuredException, sizeof( DRFSObject ) + sizeof( IntPtr ), to, ___wrappedinFilesystem );
			Runtime.ReleaseNativeObject( ___wrappedinFilesystem );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRFile( ___result );
		}
		unsafe public static DRFile virtualFileWithName_data_( string name, NSData data ) {
			RuntimeObject ___occuredException;
			var ___wrappedname = Runtime.CreateStringProxy( name );
			var ___result = NativeMethods.virtualFileWithName_data_( ClassHandle, CachedSelectors.virtualFileWithName_data_, out ___occuredException, sizeof( IntPtr ) + sizeof( NSData ), ___wrappedname, data );
			Runtime.ReleaseNativeObject( ___wrappedname );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRFile( ___result );
		}
		unsafe public static DRFile virtualFileWithName_dataProducer_( string name, NObjective.RuntimeObject dataProducer ) {
			RuntimeObject ___occuredException;
			var ___wrappedname = Runtime.CreateStringProxy( name );
			var ___result = NativeMethods.virtualFileWithName_dataProducer_( ClassHandle, CachedSelectors.virtualFileWithName_dataProducer_, out ___occuredException, sizeof( IntPtr ) + sizeof( NObjective.RuntimeObject ), ___wrappedname, dataProducer );
			Runtime.ReleaseNativeObject( ___wrappedname );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRFile( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithLinkType_pointingTo_inFilesystem_( string type, DRFSObject pointingTo, string inFilesystem ) {
			RuntimeObject ___occuredException;
			var ___wrappedtype = Runtime.CreateStringProxy( type );
			var ___wrappedinFilesystem = Runtime.CreateStringProxy( inFilesystem );
			var ___result = NativeMethods.initWithLinkType_pointingTo_inFilesystem_( Handle, CachedSelectors.initWithLinkType_pointingTo_inFilesystem_, out ___occuredException, sizeof( IntPtr ) + sizeof( DRFSObject ) + sizeof( IntPtr ), ___wrappedtype, pointingTo, ___wrappedinFilesystem );
			Runtime.ReleaseNativeObject( ___wrappedtype );
			Runtime.ReleaseNativeObject( ___wrappedinFilesystem );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithName_bytes_length_( NObjective.RuntimeObject name, System.IntPtr bytes, uint length ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithName_bytes_length_( Handle, CachedSelectors.initWithName_bytes_length_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( uint ), name, bytes, length );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithName_data_( string name, NSData data ) {
			RuntimeObject ___occuredException;
			var ___wrappedname = Runtime.CreateStringProxy( name );
			var ___result = NativeMethods.initWithName_data_( Handle, CachedSelectors.initWithName_data_, out ___occuredException, sizeof( IntPtr ) + sizeof( NSData ), ___wrappedname, data );
			Runtime.ReleaseNativeObject( ___wrappedname );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithName_dataProducer_( string name, NObjective.RuntimeObject dataProducer ) {
			RuntimeObject ___occuredException;
			var ___wrappedname = Runtime.CreateStringProxy( name );
			var ___result = NativeMethods.initWithName_dataProducer_( Handle, CachedSelectors.initWithName_dataProducer_, out ___occuredException, sizeof( IntPtr ) + sizeof( NObjective.RuntimeObject ), ___wrappedname, dataProducer );
			Runtime.ReleaseNativeObject( ___wrappedname );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithPath_( string path ) {
			RuntimeObject ___occuredException;
			var ___wrappedpath = Runtime.CreateStringProxy( path );
			var ___result = NativeMethods.initWithPath_( Handle, CachedSelectors.initWithPath_, out ___occuredException, sizeof( IntPtr ), ___wrappedpath );
			Runtime.ReleaseNativeObject( ___wrappedpath );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr fileWithPath_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr path );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr finderAliasPointingTo_inFilesystem_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRFSObject to, IntPtr inFilesystem );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr hardLinkPointingTo_inFilesystem_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRFile to, IntPtr inFilesystem );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithLinkType_pointingTo_inFilesystem_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr type, DRFSObject pointingTo, IntPtr inFilesystem );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithName_bytes_length_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name, System.IntPtr bytes, uint length );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithName_data_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name, NSData data );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithName_dataProducer_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name, NObjective.RuntimeObject dataProducer );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithPath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr path );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr symLinkPointingTo_inFilesystem_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRFSObject to, IntPtr inFilesystem );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr virtualFileWithName_data_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name, NSData data );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr virtualFileWithName_dataProducer_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name, NObjective.RuntimeObject dataProducer );
		}
		static internal class CachedSelectors {
			public static readonly Selector fileWithPath_ = "fileWithPath:";
			public static readonly Selector finderAliasPointingTo_inFilesystem_ = "finderAliasPointingTo:inFilesystem:";
			public static readonly Selector hardLinkPointingTo_inFilesystem_ = "hardLinkPointingTo:inFilesystem:";
			public static readonly Selector initWithLinkType_pointingTo_inFilesystem_ = "initWithLinkType:pointingTo:inFilesystem:";
			public static readonly Selector initWithName_bytes_length_ = "initWithName:bytes:length:";
			public static readonly Selector initWithName_data_ = "initWithName:data:";
			public static readonly Selector initWithName_dataProducer_ = "initWithName:dataProducer:";
			public static readonly Selector initWithPath_ = "initWithPath:";
			public static readonly Selector symLinkPointingTo_inFilesystem_ = "symLinkPointingTo:inFilesystem:";
			public static readonly Selector virtualFileWithName_data_ = "virtualFileWithName:data:";
			public static readonly Selector virtualFileWithName_dataProducer_ = "virtualFileWithName:dataProducer:";
		}
	}
	[ProxyBaseClass(typeof( DRTrack ))]
	public struct DRFilesystemTrack : IEquatable<DRFilesystemTrack> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRFilesystemTrack;
		public static implicit operator IntPtr( DRFilesystemTrack value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRFilesystemTrack value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRFilesystemTrack ) ) return false; 
			return Handle == ( ( DRFilesystemTrack )value ).Handle;
		}
		public bool Equals( DRFilesystemTrack value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRFilesystemTrack value1, DRFilesystemTrack value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRFilesystemTrack value1, DRFilesystemTrack value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRFilesystemTrack( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRFilesystemTrack alloc() {
			return new DRFilesystemTrack( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject initWithRootFolder_( NObjective.RuntimeObject folder ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithRootFolder_( Handle, CachedSelectors.initWithRootFolder_, out ___occuredException, sizeof( NObjective.RuntimeObject ), folder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithRootFolder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject folder );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithRootFolder_ = "initWithRootFolder:";
		}
	}
	[ProxyBaseClass(typeof( DRFSObject ))]
	public struct DRFolder : IEquatable<DRFolder> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRFolder;
		public static implicit operator IntPtr( DRFolder value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRFolder value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRFolder ) ) return false; 
			return Handle == ( ( DRFolder )value ).Handle;
		}
		public bool Equals( DRFolder value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRFolder value1, DRFolder value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRFolder value1, DRFolder value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRFolder( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRFolder alloc() {
			return new DRFolder( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static DRFolder folderWithPath_( string path ) {
			RuntimeObject ___occuredException;
			var ___wrappedpath = Runtime.CreateStringProxy( path );
			var ___result = NativeMethods.folderWithPath_( ClassHandle, CachedSelectors.folderWithPath_, out ___occuredException, sizeof( IntPtr ), ___wrappedpath );
			Runtime.ReleaseNativeObject( ___wrappedpath );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRFolder( ___result );
		}
		unsafe public static DRFolder virtualFolderWithName_( string name ) {
			RuntimeObject ___occuredException;
			var ___wrappedname = Runtime.CreateStringProxy( name );
			var ___result = NativeMethods.virtualFolderWithName_( ClassHandle, CachedSelectors.virtualFolderWithName_, out ___occuredException, sizeof( IntPtr ), ___wrappedname );
			Runtime.ReleaseNativeObject( ___wrappedname );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRFolder( ___result );
		}
		unsafe public void addChild_( DRFSObject child ) {
			RuntimeObject ___occuredException;
			NativeMethods.addChild_( Handle, CachedSelectors.addChild_, out ___occuredException, sizeof( DRFSObject ), child );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NSArray children() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.children( Handle, CachedSelectors.children, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public uint count() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.count( Handle, CachedSelectors.count, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public NObjective.RuntimeObject initWithName_( string name ) {
			RuntimeObject ___occuredException;
			var ___wrappedname = Runtime.CreateStringProxy( name );
			var ___result = NativeMethods.initWithName_( Handle, CachedSelectors.initWithName_, out ___occuredException, sizeof( IntPtr ), ___wrappedname );
			Runtime.ReleaseNativeObject( ___wrappedname );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithPath_( string path ) {
			RuntimeObject ___occuredException;
			var ___wrappedpath = Runtime.CreateStringProxy( path );
			var ___result = NativeMethods.initWithPath_( Handle, CachedSelectors.initWithPath_, out ___occuredException, sizeof( IntPtr ), ___wrappedpath );
			Runtime.ReleaseNativeObject( ___wrappedpath );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void insertObject_inChildrenAtIndex_( NObjective.RuntimeObject @object, uint inChildrenAtIndex ) {
			RuntimeObject ___occuredException;
			NativeMethods.insertObject_inChildrenAtIndex_( Handle, CachedSelectors.insertObject_inChildrenAtIndex_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ), @object, inChildrenAtIndex );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void makeVirtual() {
			RuntimeObject ___occuredException;
			NativeMethods.makeVirtual( Handle, CachedSelectors.makeVirtual, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeChild_( DRFSObject child ) {
			RuntimeObject ___occuredException;
			NativeMethods.removeChild_( Handle, CachedSelectors.removeChild_, out ___occuredException, sizeof( DRFSObject ), child );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeObjectFromChildrenAtIndex_( uint index ) {
			RuntimeObject ___occuredException;
			NativeMethods.removeObjectFromChildrenAtIndex_( Handle, CachedSelectors.removeObjectFromChildrenAtIndex_, out ___occuredException, sizeof( uint ), index );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void addChild_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRFSObject child );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr children( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint count( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr folderWithPath_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr path );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithPath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr path );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void insertObject_inChildrenAtIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, uint inChildrenAtIndex );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void makeVirtual( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void removeChild_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRFSObject child );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void removeObjectFromChildrenAtIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint index );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr virtualFolderWithName_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name );
		}
		static internal class CachedSelectors {
			public static readonly Selector addChild_ = "addChild:";
			public static readonly Selector children = "children";
			public static readonly Selector count = "count";
			public static readonly Selector folderWithPath_ = "folderWithPath:";
			public static readonly Selector initWithName_ = "initWithName:";
			public static readonly Selector initWithPath_ = "initWithPath:";
			public static readonly Selector insertObject_inChildrenAtIndex_ = "insertObject:inChildrenAtIndex:";
			public static readonly Selector makeVirtual = "makeVirtual";
			public static readonly Selector removeChild_ = "removeChild:";
			public static readonly Selector removeObjectFromChildrenAtIndex_ = "removeObjectFromChildrenAtIndex:";
			public static readonly Selector virtualFolderWithName_ = "virtualFolderWithName:";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DRFSObject : IEquatable<DRFSObject> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRFSObject;
		public static implicit operator IntPtr( DRFSObject value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRFSObject value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRFSObject ) ) return false; 
			return Handle == ( ( DRFSObject )value ).Handle;
		}
		public bool Equals( DRFSObject value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRFSObject value1, DRFSObject value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRFSObject value1, DRFSObject value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRFSObject( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRFSObject alloc() {
			return new DRFSObject( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static void initialize() {
			RuntimeObject ___occuredException;
			NativeMethods.initialize( ClassHandle, CachedSelectors.initialize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static void setupBindings() {
			RuntimeObject ___occuredException;
			NativeMethods.setupBindings( ClassHandle, CachedSelectors.setupBindings, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject allFilesystemsProperties() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.allFilesystemsProperties( Handle, CachedSelectors.allFilesystemsProperties, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public string baseName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.baseName( Handle, CachedSelectors.baseName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public uint effectiveFilesystemMask() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.effectiveFilesystemMask( Handle, CachedSelectors.effectiveFilesystemMask, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public uint explicitFilesystemMask() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.explicitFilesystemMask( Handle, CachedSelectors.explicitFilesystemMask, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public NObjective.RuntimeObject HFSPlusProperties() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.HFSPlusProperties( Handle, CachedSelectors.HFSPlusProperties, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject ISO9660Properties() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.ISO9660Properties( Handle, CachedSelectors.ISO9660Properties, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public bool isVirtual() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isVirtual( Handle, CachedSelectors.isVirtual, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject jolietProperties() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.jolietProperties( Handle, CachedSelectors.jolietProperties, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public string mangledNameForFilesystem_( string filesystem ) {
			RuntimeObject ___occuredException;
			var ___wrappedfilesystem = Runtime.CreateStringProxy( filesystem );
			var ___result = NativeMethods.mangledNameForFilesystem_( Handle, CachedSelectors.mangledNameForFilesystem_, out ___occuredException, sizeof( IntPtr ), ___wrappedfilesystem );
			Runtime.ReleaseNativeObject( ___wrappedfilesystem );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public NObjective.RuntimeObject mangledNameForFileSystem_( NObjective.RuntimeObject system ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mangledNameForFileSystem_( Handle, CachedSelectors.mangledNameForFileSystem_, out ___occuredException, sizeof( NObjective.RuntimeObject ), system );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSDictionary mangledNames() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.mangledNames( Handle, CachedSelectors.mangledNames, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public DRFolder parent() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.parent( Handle, CachedSelectors.parent, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRFolder( ___result );
		}
		unsafe public NSDictionary propertiesForFilesystem_mergeWithOtherFilesystems_( string filesystem, bool mergeWithOtherFilesystems ) {
			RuntimeObject ___occuredException;
			var ___wrappedfilesystem = Runtime.CreateStringProxy( filesystem );
			var ___result = NativeMethods.propertiesForFilesystem_mergeWithOtherFilesystems_( Handle, CachedSelectors.propertiesForFilesystem_mergeWithOtherFilesystems_, out ___occuredException, sizeof( IntPtr ) + sizeof( bool ), ___wrappedfilesystem, mergeWithOtherFilesystems );
			Runtime.ReleaseNativeObject( ___wrappedfilesystem );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public NObjective.RuntimeObject propertyForKey_inFilesystem_mergeWithOtherFilesystems_( string key, string inFilesystem, bool mergeWithOtherFilesystems ) {
			RuntimeObject ___occuredException;
			var ___wrappedkey = Runtime.CreateStringProxy( key );
			var ___wrappedinFilesystem = Runtime.CreateStringProxy( inFilesystem );
			var ___result = NativeMethods.propertyForKey_inFilesystem_mergeWithOtherFilesystems_( Handle, CachedSelectors.propertyForKey_inFilesystem_mergeWithOtherFilesystems_, out ___occuredException, sizeof( IntPtr ) + sizeof( IntPtr ) + sizeof( bool ), ___wrappedkey, ___wrappedinFilesystem, mergeWithOtherFilesystems );
			Runtime.ReleaseNativeObject( ___wrappedkey );
			Runtime.ReleaseNativeObject( ___wrappedinFilesystem );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setBaseName_( string name ) {
			RuntimeObject ___occuredException;
			var ___wrappedname = Runtime.CreateStringProxy( name );
			NativeMethods.setBaseName_( Handle, CachedSelectors.setBaseName_, out ___occuredException, sizeof( IntPtr ), ___wrappedname );
			Runtime.ReleaseNativeObject( ___wrappedname );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setEffectiveFilesystemMask_( uint mask ) {
			RuntimeObject ___occuredException;
			NativeMethods.setEffectiveFilesystemMask_( Handle, CachedSelectors.setEffectiveFilesystemMask_, out ___occuredException, sizeof( uint ), mask );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setExplicitFilesystemMask_( uint mask ) {
			RuntimeObject ___occuredException;
			NativeMethods.setExplicitFilesystemMask_( Handle, CachedSelectors.setExplicitFilesystemMask_, out ___occuredException, sizeof( uint ), mask );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setMangledNames_( NObjective.RuntimeObject names ) {
			RuntimeObject ___occuredException;
			NativeMethods.setMangledNames_( Handle, CachedSelectors.setMangledNames_, out ___occuredException, sizeof( NObjective.RuntimeObject ), names );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setParent_( NObjective.RuntimeObject parent ) {
			RuntimeObject ___occuredException;
			NativeMethods.setParent_( Handle, CachedSelectors.setParent_, out ___occuredException, sizeof( NObjective.RuntimeObject ), parent );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setProperties_inFilesystem_( NSDictionary properties, string inFilesystem ) {
			RuntimeObject ___occuredException;
			var ___wrappedinFilesystem = Runtime.CreateStringProxy( inFilesystem );
			NativeMethods.setProperties_inFilesystem_( Handle, CachedSelectors.setProperties_inFilesystem_, out ___occuredException, sizeof( NSDictionary ) + sizeof( IntPtr ), properties, ___wrappedinFilesystem );
			Runtime.ReleaseNativeObject( ___wrappedinFilesystem );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setProperty_forKey_inFilesystem_( NObjective.RuntimeObject property, string forKey, string inFilesystem ) {
			RuntimeObject ___occuredException;
			var ___wrappedforKey = Runtime.CreateStringProxy( forKey );
			var ___wrappedinFilesystem = Runtime.CreateStringProxy( inFilesystem );
			NativeMethods.setProperty_forKey_inFilesystem_( Handle, CachedSelectors.setProperty_forKey_inFilesystem_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( IntPtr ) + sizeof( IntPtr ), property, ___wrappedforKey, ___wrappedinFilesystem );
			Runtime.ReleaseNativeObject( ___wrappedforKey );
			Runtime.ReleaseNativeObject( ___wrappedinFilesystem );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setSourcePath_( NObjective.RuntimeObject path ) {
			RuntimeObject ___occuredException;
			NativeMethods.setSourcePath_( Handle, CachedSelectors.setSourcePath_, out ___occuredException, sizeof( NObjective.RuntimeObject ), path );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setSpecificName_forFilesystem_( string name, string forFilesystem ) {
			RuntimeObject ___occuredException;
			var ___wrappedname = Runtime.CreateStringProxy( name );
			var ___wrappedforFilesystem = Runtime.CreateStringProxy( forFilesystem );
			NativeMethods.setSpecificName_forFilesystem_( Handle, CachedSelectors.setSpecificName_forFilesystem_, out ___occuredException, sizeof( IntPtr ) + sizeof( IntPtr ), ___wrappedname, ___wrappedforFilesystem );
			Runtime.ReleaseNativeObject( ___wrappedname );
			Runtime.ReleaseNativeObject( ___wrappedforFilesystem );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setSpecificNames_( NSDictionary names ) {
			RuntimeObject ___occuredException;
			NativeMethods.setSpecificNames_( Handle, CachedSelectors.setSpecificNames_, out ___occuredException, sizeof( NSDictionary ), names );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setSpecifiedHFSPlusName_( NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			NativeMethods.setSpecifiedHFSPlusName_( Handle, CachedSelectors.setSpecifiedHFSPlusName_, out ___occuredException, sizeof( NObjective.RuntimeObject ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setSpecifiedISO9660Level1Name_( NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			NativeMethods.setSpecifiedISO9660Level1Name_( Handle, CachedSelectors.setSpecifiedISO9660Level1Name_, out ___occuredException, sizeof( NObjective.RuntimeObject ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setSpecifiedISO9660Level2Name_( NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			NativeMethods.setSpecifiedISO9660Level2Name_( Handle, CachedSelectors.setSpecifiedISO9660Level2Name_, out ___occuredException, sizeof( NObjective.RuntimeObject ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setSpecifiedJolietName_( NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			NativeMethods.setSpecifiedJolietName_( Handle, CachedSelectors.setSpecifiedJolietName_, out ___occuredException, sizeof( NObjective.RuntimeObject ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setSpecifiedUDFName_( NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			NativeMethods.setSpecifiedUDFName_( Handle, CachedSelectors.setSpecifiedUDFName_, out ___occuredException, sizeof( NObjective.RuntimeObject ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setValue_forKeyPath_( NObjective.RuntimeObject value, NObjective.RuntimeObject forKeyPath ) {
			RuntimeObject ___occuredException;
			NativeMethods.setValue_forKeyPath_( Handle, CachedSelectors.setValue_forKeyPath_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), value, forKeyPath );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setVirtual_( char @virtual ) {
			RuntimeObject ___occuredException;
			NativeMethods.setVirtual_( Handle, CachedSelectors.setVirtual_, out ___occuredException, sizeof( char ), @virtual );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public string sourcePath() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sourcePath( Handle, CachedSelectors.sourcePath, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public string specificNameForFilesystem_( string filesystem ) {
			RuntimeObject ___occuredException;
			var ___wrappedfilesystem = Runtime.CreateStringProxy( filesystem );
			var ___result = NativeMethods.specificNameForFilesystem_( Handle, CachedSelectors.specificNameForFilesystem_, out ___occuredException, sizeof( IntPtr ), ___wrappedfilesystem );
			Runtime.ReleaseNativeObject( ___wrappedfilesystem );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public NSDictionary specificNames() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.specificNames( Handle, CachedSelectors.specificNames, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public NObjective.RuntimeObject specifiedHFSPlusName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.specifiedHFSPlusName( Handle, CachedSelectors.specifiedHFSPlusName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject specifiedISO9660Level1Name() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.specifiedISO9660Level1Name( Handle, CachedSelectors.specifiedISO9660Level1Name, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject specifiedISO9660Level2Name() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.specifiedISO9660Level2Name( Handle, CachedSelectors.specifiedISO9660Level2Name, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject specifiedJolietName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.specifiedJolietName( Handle, CachedSelectors.specifiedJolietName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject specifiedUDFName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.specifiedUDFName( Handle, CachedSelectors.specifiedUDFName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject UDFProperties() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.UDFProperties( Handle, CachedSelectors.UDFProperties, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char validateValue_forKey_error_( System.IntPtr value, NObjective.RuntimeObject forKey, System.IntPtr error ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.validateValue_forKey_error_( Handle, CachedSelectors.validateValue_forKey_error_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), value, forKey, error );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void willChangeValueForKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			NativeMethods.willChangeValueForKey_( Handle, CachedSelectors.willChangeValueForKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr allFilesystemsProperties( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr baseName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint effectiveFilesystemMask( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint explicitFilesystemMask( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr HFSPlusProperties( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void initialize( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr ISO9660Properties( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool isVirtual( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr jolietProperties( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr mangledNameForFilesystem_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr filesystem );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr mangledNameForFileSystem_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject system );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr mangledNames( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr parent( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr propertiesForFilesystem_mergeWithOtherFilesystems_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr filesystem, bool mergeWithOtherFilesystems );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr propertyForKey_inFilesystem_mergeWithOtherFilesystems_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr key, IntPtr inFilesystem, bool mergeWithOtherFilesystems );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setBaseName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setEffectiveFilesystemMask_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint mask );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setExplicitFilesystemMask_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint mask );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setMangledNames_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject names );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setParent_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject parent );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setProperties_inFilesystem_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDictionary properties, IntPtr inFilesystem );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setProperty_forKey_inFilesystem_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject property, IntPtr forKey, IntPtr inFilesystem );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setSourcePath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject path );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setSpecificName_forFilesystem_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name, IntPtr forFilesystem );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setSpecificNames_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDictionary names );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setSpecifiedHFSPlusName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setSpecifiedISO9660Level1Name_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setSpecifiedISO9660Level2Name_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setSpecifiedJolietName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setSpecifiedUDFName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setupBindings( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setValue_forKeyPath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject value, NObjective.RuntimeObject forKeyPath );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setVirtual_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, char @virtual );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr sourcePath( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr specificNameForFilesystem_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr filesystem );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr specificNames( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr specifiedHFSPlusName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr specifiedISO9660Level1Name( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr specifiedISO9660Level2Name( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr specifiedJolietName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr specifiedUDFName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr UDFProperties( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char validateValue_forKey_error_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr value, NObjective.RuntimeObject forKey, System.IntPtr error );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void willChangeValueForKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
		}
		static internal class CachedSelectors {
			public static readonly Selector allFilesystemsProperties = "allFilesystemsProperties";
			public static readonly Selector baseName = "baseName";
			public static readonly Selector effectiveFilesystemMask = "effectiveFilesystemMask";
			public static readonly Selector explicitFilesystemMask = "explicitFilesystemMask";
			public static readonly Selector HFSPlusProperties = "HFSPlusProperties";
			public static readonly Selector initialize = "initialize";
			public static readonly Selector ISO9660Properties = "ISO9660Properties";
			public static readonly Selector isVirtual = "isVirtual";
			public static readonly Selector jolietProperties = "jolietProperties";
			public static readonly Selector mangledNameForFilesystem_ = "mangledNameForFilesystem:";
			public static readonly Selector mangledNameForFileSystem_ = "mangledNameForFileSystem:";
			public static readonly Selector mangledNames = "mangledNames";
			public static readonly Selector parent = "parent";
			public static readonly Selector propertiesForFilesystem_mergeWithOtherFilesystems_ = "propertiesForFilesystem:mergeWithOtherFilesystems:";
			public static readonly Selector propertyForKey_inFilesystem_mergeWithOtherFilesystems_ = "propertyForKey:inFilesystem:mergeWithOtherFilesystems:";
			public static readonly Selector setBaseName_ = "setBaseName:";
			public static readonly Selector setEffectiveFilesystemMask_ = "setEffectiveFilesystemMask:";
			public static readonly Selector setExplicitFilesystemMask_ = "setExplicitFilesystemMask:";
			public static readonly Selector setMangledNames_ = "setMangledNames:";
			public static readonly Selector setParent_ = "setParent:";
			public static readonly Selector setProperties_inFilesystem_ = "setProperties:inFilesystem:";
			public static readonly Selector setProperty_forKey_inFilesystem_ = "setProperty:forKey:inFilesystem:";
			public static readonly Selector setSourcePath_ = "setSourcePath:";
			public static readonly Selector setSpecificName_forFilesystem_ = "setSpecificName:forFilesystem:";
			public static readonly Selector setSpecificNames_ = "setSpecificNames:";
			public static readonly Selector setSpecifiedHFSPlusName_ = "setSpecifiedHFSPlusName:";
			public static readonly Selector setSpecifiedISO9660Level1Name_ = "setSpecifiedISO9660Level1Name:";
			public static readonly Selector setSpecifiedISO9660Level2Name_ = "setSpecifiedISO9660Level2Name:";
			public static readonly Selector setSpecifiedJolietName_ = "setSpecifiedJolietName:";
			public static readonly Selector setSpecifiedUDFName_ = "setSpecifiedUDFName:";
			public static readonly Selector setupBindings = "setupBindings";
			public static readonly Selector setValue_forKeyPath_ = "setValue:forKeyPath:";
			public static readonly Selector setVirtual_ = "setVirtual:";
			public static readonly Selector sourcePath = "sourcePath";
			public static readonly Selector specificNameForFilesystem_ = "specificNameForFilesystem:";
			public static readonly Selector specificNames = "specificNames";
			public static readonly Selector specifiedHFSPlusName = "specifiedHFSPlusName";
			public static readonly Selector specifiedISO9660Level1Name = "specifiedISO9660Level1Name";
			public static readonly Selector specifiedISO9660Level2Name = "specifiedISO9660Level2Name";
			public static readonly Selector specifiedJolietName = "specifiedJolietName";
			public static readonly Selector specifiedUDFName = "specifiedUDFName";
			public static readonly Selector UDFProperties = "UDFProperties";
			public static readonly Selector validateValue_forKey_error_ = "validateValue:forKey:error:";
			public static readonly Selector willChangeValueForKey_ = "willChangeValueForKey:";
		}
	}
	[ProxyBaseClass(typeof( NSNumber ))]
	public struct DRMSF : IEquatable<DRMSF> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRMSF;
		public static implicit operator IntPtr( DRMSF value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRMSF value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRMSF ) ) return false; 
			return Handle == ( ( DRMSF )value ).Handle;
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
		unsafe public static void initialize() {
			RuntimeObject ___occuredException;
			NativeMethods.initialize( ClassHandle, CachedSelectors.initialize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static DRMSF msf() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.msf( ClassHandle, CachedSelectors.msf, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRMSF( ___result );
		}
		unsafe public static NObjective.RuntimeObject msfFromString_couldBeByteLength_( NObjective.RuntimeObject @string, char couldBeByteLength ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.msfFromString_couldBeByteLength_( ClassHandle, CachedSelectors.msfFromString_couldBeByteLength_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( char ), @string, couldBeByteLength );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
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
			return ( uint )___result;
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
			return ( uint )___result;
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
			return ( uint )___result;
		}
		unsafe public uint sectors() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sectors( Handle, CachedSelectors.sectors, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr descriptionWithFormat_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr format );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint frames( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void initialize( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithFrames_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint frames );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithString_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr @string );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool isEqualToMSF_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRMSF msf );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint minutes( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr msf( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr msfByAdding_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRMSF adding );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr msfBySubtracting_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRMSF subtracting );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr msfFromString_couldBeByteLength_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @string, char couldBeByteLength );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr msfWithFrames_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint frames );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr msfWithString_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr @string );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint seconds( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint sectors( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector descriptionWithFormat_ = "descriptionWithFormat:";
			public static readonly Selector frames = "frames";
			public static readonly Selector initialize = "initialize";
			public static readonly Selector initWithFrames_ = "initWithFrames:";
			public static readonly Selector initWithString_ = "initWithString:";
			public static readonly Selector isEqualToMSF_ = "isEqualToMSF:";
			public static readonly Selector minutes = "minutes";
			public static readonly Selector msf = "msf";
			public static readonly Selector msfByAdding_ = "msfByAdding:";
			public static readonly Selector msfBySubtracting_ = "msfBySubtracting:";
			public static readonly Selector msfFromString_couldBeByteLength_ = "msfFromString:couldBeByteLength:";
			public static readonly Selector msfWithFrames_ = "msfWithFrames:";
			public static readonly Selector msfWithString_ = "msfWithString:";
			public static readonly Selector seconds = "seconds";
			public static readonly Selector sectors = "sectors";
		}
	}
	[ProxyBaseClass(typeof( NSFormatter ))]
	public struct DRMSFFormatter : IEquatable<DRMSFFormatter> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRMSFFormatter;
		public static implicit operator IntPtr( DRMSFFormatter value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRMSFFormatter value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRMSFFormatter ) ) return false; 
			return Handle == ( ( DRMSFFormatter )value ).Handle;
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
		unsafe public static void initialize() {
			RuntimeObject ___occuredException;
			NativeMethods.initialize( ClassHandle, CachedSelectors.initialize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
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
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr format( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void initialize( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithFormat_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr format );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setFormat_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr format );
		}
		static internal class CachedSelectors {
			public static readonly Selector format = "format";
			public static readonly Selector initialize = "initialize";
			public static readonly Selector initWithFormat_ = "initWithFormat:";
			public static readonly Selector setFormat_ = "setFormat:";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DRNotificationCenter : IEquatable<DRNotificationCenter> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRNotificationCenter;
		public static implicit operator IntPtr( DRNotificationCenter value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRNotificationCenter value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRNotificationCenter ) ) return false; 
			return Handle == ( ( DRNotificationCenter )value ).Handle;
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
		unsafe public static void initialize() {
			RuntimeObject ___occuredException;
			NativeMethods.initialize( ClassHandle, CachedSelectors.initialize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
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
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void addObserver_selector_name_object_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject observer, NObjective.Selector selector, IntPtr name, NObjective.RuntimeObject @object );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr currentRunLoopCenter( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void initialize( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char notificationNeedsImmediatePosting_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject posting );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void removeObserver_name_object_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject observer, IntPtr name, NObjective.RuntimeObject @object );
		}
		static internal class CachedSelectors {
			public static readonly Selector addObserver_selector_name_object_ = "addObserver:selector:name:object:";
			public static readonly Selector currentRunLoopCenter = "currentRunLoopCenter";
			public static readonly Selector initialize = "initialize";
			public static readonly Selector notificationNeedsImmediatePosting_ = "notificationNeedsImmediatePosting:";
			public static readonly Selector removeObserver_name_object_ = "removeObserver:name:object:";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DRPartialFileAudioProducer : IEquatable<DRPartialFileAudioProducer> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRPartialFileAudioProducer;
		public static implicit operator IntPtr( DRPartialFileAudioProducer value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRPartialFileAudioProducer value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRPartialFileAudioProducer ) ) return false; 
			return Handle == ( ( DRPartialFileAudioProducer )value ).Handle;
		}
		public bool Equals( DRPartialFileAudioProducer value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRPartialFileAudioProducer value1, DRPartialFileAudioProducer value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRPartialFileAudioProducer value1, DRPartialFileAudioProducer value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRPartialFileAudioProducer( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRPartialFileAudioProducer alloc() {
			return new DRPartialFileAudioProducer( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject blockLengthOfFile_( NObjective.RuntimeObject file ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.blockLengthOfFile_( ClassHandle, CachedSelectors.blockLengthOfFile_, out ___occuredException, sizeof( NObjective.RuntimeObject ), file );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject producer() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.producer( ClassHandle, CachedSelectors.producer, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void cleanupTrackAfterBurn_( NObjective.RuntimeObject burn ) {
			RuntimeObject ___occuredException;
			NativeMethods.cleanupTrackAfterBurn_( Handle, CachedSelectors.cleanupTrackAfterBurn_, out ___occuredException, sizeof( NObjective.RuntimeObject ), burn );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public char prepareTrack_forBurn_toMedia_( NObjective.RuntimeObject track, NObjective.RuntimeObject forBurn, NObjective.RuntimeObject toMedia ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.prepareTrack_forBurn_toMedia_( Handle, CachedSelectors.prepareTrack_forBurn_toMedia_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), track, forBurn, toMedia );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public uint produceDataForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( NObjective.RuntimeObject track, System.IntPtr intoBuffer, uint length, ulong atAddress, uint blockSize, System.IntPtr ioFlags ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.produceDataForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( Handle, CachedSelectors.produceDataForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( uint ) + sizeof( ulong ) + sizeof( uint ) + sizeof( System.IntPtr ), track, intoBuffer, length, atAddress, blockSize, ioFlags
			 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public uint produceDataIntoBuffer_length_blockSize_( System.IntPtr buffer, uint length, uint blockSize ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.produceDataIntoBuffer_length_blockSize_( Handle, CachedSelectors.produceDataIntoBuffer_length_blockSize_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( uint ) + sizeof( uint ), buffer, length, blockSize );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public uint producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( NObjective.RuntimeObject track, System.IntPtr intoBuffer, uint length, ulong atAddress, uint blockSize, System.IntPtr ioFlags ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( Handle, CachedSelectors.producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( uint ) + sizeof( ulong ) + sizeof( uint ) + sizeof( System.IntPtr ), track, intoBuffer, length, atAddress, blockSize, ioFlags
			 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr blockLengthOfFile_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void cleanupTrackAfterBurn_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject burn );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char prepareTrack_forBurn_toMedia_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject track, NObjective.RuntimeObject forBurn, NObjective.RuntimeObject toMedia );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint produceDataForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject track, System.IntPtr intoBuffer, uint length, ulong atAddress, uint blockSize, System.IntPtr ioFlags
			 );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint produceDataIntoBuffer_length_blockSize_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr buffer, uint length, uint blockSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject track, System.IntPtr intoBuffer, uint length, ulong atAddress, uint blockSize, System.IntPtr ioFlags
			 );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr producer( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector blockLengthOfFile_ = "blockLengthOfFile:";
			public static readonly Selector cleanupTrackAfterBurn_ = "cleanupTrackAfterBurn:";
			public static readonly Selector prepareTrack_forBurn_toMedia_ = "prepareTrack:forBurn:toMedia:";
			public static readonly Selector produceDataForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_ = "produceDataForTrack:intoBuffer:length:atAddress:blockSize:ioFlags:";
			public static readonly Selector produceDataIntoBuffer_length_blockSize_ = "produceDataIntoBuffer:length:blockSize:";
			public static readonly Selector producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_ = "producePreGapForTrack:intoBuffer:length:atAddress:blockSize:ioFlags:";
			public static readonly Selector producer = "producer";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DRPrepare : IEquatable<DRPrepare> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRPrepare;
		public static implicit operator IntPtr( DRPrepare value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRPrepare value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRPrepare ) ) return false; 
			return Handle == ( ( DRPrepare )value ).Handle;
		}
		public bool Equals( DRPrepare value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRPrepare value1, DRPrepare value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRPrepare value1, DRPrepare value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRPrepare( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRPrepare alloc() {
			return new DRPrepare( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static void initialize() {
			RuntimeObject ___occuredException;
			NativeMethods.initialize( ClassHandle, CachedSelectors.initialize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static bool isPropertyKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isPropertyKey_( ClassHandle, CachedSelectors.isPropertyKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static NObjective.RuntimeObject prepareForDevice_properties_( NObjective.RuntimeObject device, NObjective.RuntimeObject properties ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.prepareForDevice_properties_( ClassHandle, CachedSelectors.prepareForDevice_properties_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), device, properties );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static void setupBindings() {
			RuntimeObject ___occuredException;
			NativeMethods.setupBindings( ClassHandle, CachedSelectors.setupBindings, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject device() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.device( Handle, CachedSelectors.device, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithDevice_properties_( NObjective.RuntimeObject device, NObjective.RuntimeObject properties ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithDevice_properties_( Handle, CachedSelectors.initWithDevice_properties_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), device, properties );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setValue_forUndefinedKey_( NObjective.RuntimeObject value, NObjective.RuntimeObject forUndefinedKey ) {
			RuntimeObject ___occuredException;
			NativeMethods.setValue_forUndefinedKey_( Handle, CachedSelectors.setValue_forUndefinedKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), value, forUndefinedKey );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void start() {
			RuntimeObject ___occuredException;
			NativeMethods.start( Handle, CachedSelectors.start, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject status() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.status( Handle, CachedSelectors.status, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject valueForUndefinedKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.valueForUndefinedKey_( Handle, CachedSelectors.valueForUndefinedKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr device( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void initialize( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithDevice_properties_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject device, NObjective.RuntimeObject properties );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool isPropertyKey_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr prepareForDevice_properties_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject device, NObjective.RuntimeObject properties );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setupBindings( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setValue_forUndefinedKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject value, NObjective.RuntimeObject forUndefinedKey );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void start( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr status( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr valueForUndefinedKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
		}
		static internal class CachedSelectors {
			public static readonly Selector device = "device";
			public static readonly Selector initialize = "initialize";
			public static readonly Selector initWithDevice_properties_ = "initWithDevice:properties:";
			public static readonly Selector isPropertyKey_ = "isPropertyKey:";
			public static readonly Selector prepareForDevice_properties_ = "prepareForDevice:properties:";
			public static readonly Selector setupBindings = "setupBindings";
			public static readonly Selector setValue_forUndefinedKey_ = "setValue:forUndefinedKey:";
			public static readonly Selector start = "start";
			public static readonly Selector status = "status";
			public static readonly Selector valueForUndefinedKey_ = "valueForUndefinedKey:";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DRSession : IEquatable<DRSession> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRSession;
		public static implicit operator IntPtr( DRSession value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRSession value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRSession ) ) return false; 
			return Handle == ( ( DRSession )value ).Handle;
		}
		public bool Equals( DRSession value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRSession value1, DRSession value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRSession value1, DRSession value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRSession( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRSession alloc() {
			return new DRSession( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static void initialize() {
			RuntimeObject ___occuredException;
			NativeMethods.initialize( ClassHandle, CachedSelectors.initialize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static bool isPropertyKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isPropertyKey_( ClassHandle, CachedSelectors.isPropertyKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static void setupBindings() {
			RuntimeObject ___occuredException;
			NativeMethods.setupBindings( ClassHandle, CachedSelectors.setupBindings, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject initWithCDText_( NObjective.RuntimeObject text ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCDText_( Handle, CachedSelectors.initWithCDText_, out ___occuredException, sizeof( NObjective.RuntimeObject ), text );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithProperties_producer_( NObjective.RuntimeObject properties, NObjective.RuntimeObject producer ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithProperties_producer_( Handle, CachedSelectors.initWithProperties_producer_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), properties, producer );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject properties() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.properties( Handle, CachedSelectors.properties, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setProperties_( NObjective.RuntimeObject properties ) {
			RuntimeObject ___occuredException;
			NativeMethods.setProperties_( Handle, CachedSelectors.setProperties_, out ___occuredException, sizeof( NObjective.RuntimeObject ), properties );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setTracks_( NObjective.RuntimeObject tracks ) {
			RuntimeObject ___occuredException;
			NativeMethods.setTracks_( Handle, CachedSelectors.setTracks_, out ___occuredException, sizeof( NObjective.RuntimeObject ), tracks );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setValue_forUndefinedKey_( NObjective.RuntimeObject value, NObjective.RuntimeObject forUndefinedKey ) {
			RuntimeObject ___occuredException;
			NativeMethods.setValue_forUndefinedKey_( Handle, CachedSelectors.setValue_forUndefinedKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), value, forUndefinedKey );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject tracks() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.tracks( Handle, CachedSelectors.tracks, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject valueForUndefinedKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.valueForUndefinedKey_( Handle, CachedSelectors.valueForUndefinedKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void initialize( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithCDText_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject text );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithProperties_producer_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject properties, NObjective.RuntimeObject producer );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool isPropertyKey_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr properties( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setProperties_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject properties );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setTracks_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject tracks );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setupBindings( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setValue_forUndefinedKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject value, NObjective.RuntimeObject forUndefinedKey );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr tracks( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr valueForUndefinedKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
		}
		static internal class CachedSelectors {
			public static readonly Selector initialize = "initialize";
			public static readonly Selector initWithCDText_ = "initWithCDText:";
			public static readonly Selector initWithProperties_producer_ = "initWithProperties:producer:";
			public static readonly Selector isPropertyKey_ = "isPropertyKey:";
			public static readonly Selector properties = "properties";
			public static readonly Selector setProperties_ = "setProperties:";
			public static readonly Selector setTracks_ = "setTracks:";
			public static readonly Selector setupBindings = "setupBindings";
			public static readonly Selector setValue_forUndefinedKey_ = "setValue:forUndefinedKey:";
			public static readonly Selector tracks = "tracks";
			public static readonly Selector valueForUndefinedKey_ = "valueForUndefinedKey:";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DRSessionCDTextProducer : IEquatable<DRSessionCDTextProducer> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRSessionCDTextProducer;
		public static implicit operator IntPtr( DRSessionCDTextProducer value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRSessionCDTextProducer value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRSessionCDTextProducer ) ) return false; 
			return Handle == ( ( DRSessionCDTextProducer )value ).Handle;
		}
		public bool Equals( DRSessionCDTextProducer value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRSessionCDTextProducer value1, DRSessionCDTextProducer value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRSessionCDTextProducer value1, DRSessionCDTextProducer value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRSessionCDTextProducer( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRSessionCDTextProducer alloc() {
			return new DRSessionCDTextProducer( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void cleanupSessionAfterBurn_( NObjective.RuntimeObject burn ) {
			RuntimeObject ___occuredException;
			NativeMethods.cleanupSessionAfterBurn_( Handle, CachedSelectors.cleanupSessionAfterBurn_, out ___occuredException, sizeof( NObjective.RuntimeObject ), burn );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void expandPackData() {
			RuntimeObject ___occuredException;
			NativeMethods.expandPackData( Handle, CachedSelectors.expandPackData, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject initWithCDText_( NObjective.RuntimeObject text ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCDText_( Handle, CachedSelectors.initWithCDText_, out ___occuredException, sizeof( NObjective.RuntimeObject ), text );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char prepareSession_forBurn_toMedia_( NObjective.RuntimeObject session, NObjective.RuntimeObject forBurn, NObjective.RuntimeObject toMedia ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.prepareSession_forBurn_toMedia_( Handle, CachedSelectors.prepareSession_forBurn_toMedia_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), session, forBurn, toMedia );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public uint produceLeadInForSession_intoBuffer_length_atAddress_ioFlags_( NObjective.RuntimeObject session, System.IntPtr intoBuffer, uint length, ulong atAddress, System.IntPtr ioFlags ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.produceLeadInForSession_intoBuffer_length_atAddress_ioFlags_( Handle, CachedSelectors.produceLeadInForSession_intoBuffer_length_atAddress_ioFlags_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( uint ) + sizeof( ulong ) + sizeof( System.IntPtr ), session, intoBuffer, length, atAddress, ioFlags );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void cleanupSessionAfterBurn_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject burn );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void expandPackData( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithCDText_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject text );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char prepareSession_forBurn_toMedia_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject session, NObjective.RuntimeObject forBurn, NObjective.RuntimeObject toMedia );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint produceLeadInForSession_intoBuffer_length_atAddress_ioFlags_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject session, System.IntPtr intoBuffer, uint length, ulong atAddress, System.IntPtr ioFlags );
		}
		static internal class CachedSelectors {
			public static readonly Selector cleanupSessionAfterBurn_ = "cleanupSessionAfterBurn:";
			public static readonly Selector expandPackData = "expandPackData";
			public static readonly Selector initWithCDText_ = "initWithCDText:";
			public static readonly Selector prepareSession_forBurn_toMedia_ = "prepareSession:forBurn:toMedia:";
			public static readonly Selector produceLeadInForSession_intoBuffer_length_atAddress_ioFlags_ = "produceLeadInForSession:intoBuffer:length:atAddress:ioFlags:";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DRSessionProducerPlaceholder : IEquatable<DRSessionProducerPlaceholder> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRSessionProducerPlaceholder;
		public static implicit operator IntPtr( DRSessionProducerPlaceholder value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRSessionProducerPlaceholder value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRSessionProducerPlaceholder ) ) return false; 
			return Handle == ( ( DRSessionProducerPlaceholder )value ).Handle;
		}
		public bool Equals( DRSessionProducerPlaceholder value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRSessionProducerPlaceholder value1, DRSessionProducerPlaceholder value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRSessionProducerPlaceholder value1, DRSessionProducerPlaceholder value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRSessionProducerPlaceholder( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRSessionProducerPlaceholder alloc() {
			return new DRSessionProducerPlaceholder( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public uint produceLeadInForSession_intoBuffer_length_atAddress_ioFlags_( NObjective.RuntimeObject session, System.IntPtr intoBuffer, uint length, ulong atAddress, System.IntPtr ioFlags ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.produceLeadInForSession_intoBuffer_length_atAddress_ioFlags_( Handle, CachedSelectors.produceLeadInForSession_intoBuffer_length_atAddress_ioFlags_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( uint ) + sizeof( ulong ) + sizeof( System.IntPtr ), session, intoBuffer, length, atAddress, ioFlags );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint produceLeadInForSession_intoBuffer_length_atAddress_ioFlags_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject session, System.IntPtr intoBuffer, uint length, ulong atAddress, System.IntPtr ioFlags );
		}
		static internal class CachedSelectors {
			public static readonly Selector produceLeadInForSession_intoBuffer_length_atAddress_ioFlags_ = "produceLeadInForSession:intoBuffer:length:atAddress:ioFlags:";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DRSilenceGenerator : IEquatable<DRSilenceGenerator> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRSilenceGenerator;
		public static implicit operator IntPtr( DRSilenceGenerator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRSilenceGenerator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRSilenceGenerator ) ) return false; 
			return Handle == ( ( DRSilenceGenerator )value ).Handle;
		}
		public bool Equals( DRSilenceGenerator value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRSilenceGenerator value1, DRSilenceGenerator value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRSilenceGenerator value1, DRSilenceGenerator value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRSilenceGenerator( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRSilenceGenerator alloc() {
			return new DRSilenceGenerator( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public char completed() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.completed( Handle, CachedSelectors.completed, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject initWithGeneratorInfo_( NObjective.RuntimeObject info ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithGeneratorInfo_( Handle, CachedSelectors.initWithGeneratorInfo_, out ___occuredException, sizeof( NObjective.RuntimeObject ), info );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public uint produceIntoBuffer_length_blockSize_( System.IntPtr buffer, uint length, uint blockSize ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.produceIntoBuffer_length_blockSize_( Handle, CachedSelectors.produceIntoBuffer_length_blockSize_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( uint ) + sizeof( uint ), buffer, length, blockSize );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char completed( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithGeneratorInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject info );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint produceIntoBuffer_length_blockSize_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr buffer, uint length, uint blockSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector completed = "completed";
			public static readonly Selector initWithGeneratorInfo_ = "initWithGeneratorInfo:";
			public static readonly Selector produceIntoBuffer_length_blockSize_ = "produceIntoBuffer:length:blockSize:";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DRTask : IEquatable<DRTask> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRTask;
		public static implicit operator IntPtr( DRTask value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRTask value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRTask ) ) return false; 
			return Handle == ( ( DRTask )value ).Handle;
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
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr info( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithPid_forTask_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int pid, uint forTask );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool isValid( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector info = "info";
			public static readonly Selector initWithPid_forTask_ = "initWithPid:forTask:";
			public static readonly Selector isValid = "isValid";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DRTOCFileParser : IEquatable<DRTOCFileParser> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRTOCFileParser;
		public static implicit operator IntPtr( DRTOCFileParser value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRTOCFileParser value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRTOCFileParser ) ) return false; 
			return Handle == ( ( DRTOCFileParser )value ).Handle;
		}
		public bool Equals( DRTOCFileParser value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRTOCFileParser value1, DRTOCFileParser value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRTOCFileParser value1, DRTOCFileParser value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRTOCFileParser( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRTOCFileParser alloc() {
			return new DRTOCFileParser( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject burnProperties() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.burnProperties( Handle, CachedSelectors.burnProperties, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject cdText() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.cdText( Handle, CachedSelectors.cdText, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject extractOptionalString_( NObjective.RuntimeObject @string ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.extractOptionalString_( Handle, CachedSelectors.extractOptionalString_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @string );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject extractRequiredString_( NObjective.RuntimeObject @string ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.extractRequiredString_( Handle, CachedSelectors.extractRequiredString_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @string );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject fullPathForAuxFile_( NObjective.RuntimeObject file ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.fullPathForAuxFile_( Handle, CachedSelectors.fullPathForAuxFile_, out ___occuredException, sizeof( NObjective.RuntimeObject ), file );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithPath_( NObjective.RuntimeObject path ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithPath_( Handle, CachedSelectors.initWithPath_, out ___occuredException, sizeof( NObjective.RuntimeObject ), path );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char parse() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.parse( Handle, CachedSelectors.parse, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void parseCDText_forDisc_( NObjective.RuntimeObject text, char forDisc ) {
			RuntimeObject ___occuredException;
			NativeMethods.parseCDText_forDisc_( Handle, CachedSelectors.parseCDText_forDisc_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( char ), text, forDisc );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject parseTrack_( NObjective.RuntimeObject track ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.parseTrack_( Handle, CachedSelectors.parseTrack_, out ___occuredException, sizeof( NObjective.RuntimeObject ), track );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject parseTrackModes_isAudioTrack_( NObjective.RuntimeObject modes, System.IntPtr isAudioTrack ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.parseTrackModes_isAudioTrack_( Handle, CachedSelectors.parseTrackModes_isAudioTrack_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), modes, isAudioTrack );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setCDTextString_forKey_ofTrack_inLanguage_( NObjective.RuntimeObject @string, NObjective.RuntimeObject forKey, int ofTrack, int inLanguage ) {
			RuntimeObject ___occuredException;
			NativeMethods.setCDTextString_forKey_ofTrack_inLanguage_( Handle, CachedSelectors.setCDTextString_forKey_ofTrack_inLanguage_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( int ) + sizeof( int ), @string, forKey, ofTrack, inLanguage );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject trackLayout() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.trackLayout( Handle, CachedSelectors.trackLayout, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr burnProperties( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr cdText( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr extractOptionalString_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @string );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr extractRequiredString_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @string );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr fullPathForAuxFile_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithPath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject path );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char parse( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void parseCDText_forDisc_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject text, char forDisc );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr parseTrack_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject track );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr parseTrackModes_isAudioTrack_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject modes, System.IntPtr isAudioTrack );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setCDTextString_forKey_ofTrack_inLanguage_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @string, NObjective.RuntimeObject forKey, int ofTrack, int inLanguage );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr trackLayout( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector burnProperties = "burnProperties";
			public static readonly Selector cdText = "cdText";
			public static readonly Selector extractOptionalString_ = "extractOptionalString:";
			public static readonly Selector extractRequiredString_ = "extractRequiredString:";
			public static readonly Selector fullPathForAuxFile_ = "fullPathForAuxFile:";
			public static readonly Selector initWithPath_ = "initWithPath:";
			public static readonly Selector parse = "parse";
			public static readonly Selector parseCDText_forDisc_ = "parseCDText:forDisc:";
			public static readonly Selector parseTrack_ = "parseTrack:";
			public static readonly Selector parseTrackModes_isAudioTrack_ = "parseTrackModes:isAudioTrack:";
			public static readonly Selector setCDTextString_forKey_ofTrack_inLanguage_ = "setCDTextString:forKey:ofTrack:inLanguage:";
			public static readonly Selector trackLayout = "trackLayout";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DRTOCProducer : IEquatable<DRTOCProducer> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRTOCProducer;
		public static implicit operator IntPtr( DRTOCProducer value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRTOCProducer value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRTOCProducer ) ) return false; 
			return Handle == ( ( DRTOCProducer )value ).Handle;
		}
		public bool Equals( DRTOCProducer value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DRTOCProducer value1, DRTOCProducer value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DRTOCProducer value1, DRTOCProducer value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DRTOCProducer( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DRTOCProducer alloc() {
			return new DRTOCProducer( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject producer() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.producer( ClassHandle, CachedSelectors.producer, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void cleanupTrackAfterBurn_( NObjective.RuntimeObject burn ) {
			RuntimeObject ___occuredException;
			NativeMethods.cleanupTrackAfterBurn_( Handle, CachedSelectors.cleanupTrackAfterBurn_, out ___occuredException, sizeof( NObjective.RuntimeObject ), burn );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public char prepareTrack_forBurn_toMedia_( NObjective.RuntimeObject track, NObjective.RuntimeObject forBurn, NObjective.RuntimeObject toMedia ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.prepareTrack_forBurn_toMedia_( Handle, CachedSelectors.prepareTrack_forBurn_toMedia_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), track, forBurn, toMedia );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public uint produceDataForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( NObjective.RuntimeObject track, System.IntPtr intoBuffer, uint length, ulong atAddress, uint blockSize, System.IntPtr ioFlags ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.produceDataForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( Handle, CachedSelectors.produceDataForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( uint ) + sizeof( ulong ) + sizeof( uint ) + sizeof( System.IntPtr ), track, intoBuffer, length, atAddress, blockSize, ioFlags
			 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public uint producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( NObjective.RuntimeObject track, System.IntPtr intoBuffer, uint length, ulong atAddress, uint blockSize, System.IntPtr ioFlags ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( Handle, CachedSelectors.producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( uint ) + sizeof( ulong ) + sizeof( uint ) + sizeof( System.IntPtr ), track, intoBuffer, length, atAddress, blockSize, ioFlags
			 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void cleanupTrackAfterBurn_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject burn );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char prepareTrack_forBurn_toMedia_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject track, NObjective.RuntimeObject forBurn, NObjective.RuntimeObject toMedia );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint produceDataForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject track, System.IntPtr intoBuffer, uint length, ulong atAddress, uint blockSize, System.IntPtr ioFlags
			 );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject track, System.IntPtr intoBuffer, uint length, ulong atAddress, uint blockSize, System.IntPtr ioFlags
			 );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr producer( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector cleanupTrackAfterBurn_ = "cleanupTrackAfterBurn:";
			public static readonly Selector prepareTrack_forBurn_toMedia_ = "prepareTrack:forBurn:toMedia:";
			public static readonly Selector produceDataForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_ = "produceDataForTrack:intoBuffer:length:atAddress:blockSize:ioFlags:";
			public static readonly Selector producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_ = "producePreGapForTrack:intoBuffer:length:atAddress:blockSize:ioFlags:";
			public static readonly Selector producer = "producer";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DRTrack : IEquatable<DRTrack> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingCachedClasses.DRTrack;
		public static implicit operator IntPtr( DRTrack value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRTrack value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DRTrack ) ) return false; 
			return Handle == ( ( DRTrack )value ).Handle;
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
		unsafe public static void initialize() {
			RuntimeObject ___occuredException;
			NativeMethods.initialize( ClassHandle, CachedSelectors.initialize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static bool isPropertyKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isPropertyKey_( ClassHandle, CachedSelectors.isPropertyKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static void setupBindings() {
			RuntimeObject ___occuredException;
			NativeMethods.setupBindings( ClassHandle, CachedSelectors.setupBindings, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static DRTrack trackForAudioFile_( string file ) {
			RuntimeObject ___occuredException;
			var ___wrappedfile = Runtime.CreateStringProxy( file );
			var ___result = NativeMethods.trackForAudioFile_( ClassHandle, CachedSelectors.trackForAudioFile_, out ___occuredException, sizeof( IntPtr ), ___wrappedfile );
			Runtime.ReleaseNativeObject( ___wrappedfile );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRTrack( ___result );
		}
		unsafe public static DRTrack trackForAudioOfLength_producer_( DRMSF length, NObjective.RuntimeObject producer ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.trackForAudioOfLength_producer_( ClassHandle, CachedSelectors.trackForAudioOfLength_producer_, out ___occuredException, sizeof( DRMSF ) + sizeof( NObjective.RuntimeObject ), length, producer );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRTrack( ___result );
		}
		unsafe public static DRTrack trackForRootFolder_( DRFolder folder ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.trackForRootFolder_( ClassHandle, CachedSelectors.trackForRootFolder_, out ___occuredException, sizeof( DRFolder ), folder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRTrack( ___result );
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
		unsafe public void setValue_forUndefinedKey_( NObjective.RuntimeObject value, NObjective.RuntimeObject forUndefinedKey ) {
			RuntimeObject ___occuredException;
			NativeMethods.setValue_forUndefinedKey_( Handle, CachedSelectors.setValue_forUndefinedKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), value, forUndefinedKey );
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
		unsafe public NObjective.RuntimeObject valueForUndefinedKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.valueForUndefinedKey_( Handle, CachedSelectors.valueForUndefinedKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject verificationType() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.verificationType( Handle, CachedSelectors.verificationType, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern ushort blockSize( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern int blockType( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern int dataForm( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr dvdCopyrightInfo( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr dvdTimestamp( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern ulong estimateLength( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void initialize( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithProducer_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject producer );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool isPropertyKey_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr length( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2")]
			public static extern float maximumBurnSpeed( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr preGap( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr properties( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern int sessionFormat( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setBlockSize_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, ushort size );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setBlockType_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int type );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setDataForm_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int form );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setDVDCopyrightInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject info );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setDVDTimestamp_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject timestamp );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setLength_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject length );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setMaximumBurnSpeed_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, float speed );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setPreGap_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRMSF gap );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setProperties_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDictionary properties );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setSessionFormat_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int format );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setTrackMode_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int mode );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setupBindings( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setValue_forUndefinedKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject value, NObjective.RuntimeObject forUndefinedKey );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setVerificationType_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject type );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2")]
			public static extern float testProductionSpeedForInterval_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, double interval );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2")]
			public static extern float testProductionSpeedForLength_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint length );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr trackForAudioFile_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr file );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr trackForAudioOfLength_producer_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRMSF length, NObjective.RuntimeObject producer );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr trackForRootFolder_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRFolder folder );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern int trackMode( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr valueForUndefinedKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr verificationType( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector blockSize = "blockSize";
			public static readonly Selector blockType = "blockType";
			public static readonly Selector dataForm = "dataForm";
			public static readonly Selector dvdCopyrightInfo = "dvdCopyrightInfo";
			public static readonly Selector dvdTimestamp = "dvdTimestamp";
			public static readonly Selector estimateLength = "estimateLength";
			public static readonly Selector initialize = "initialize";
			public static readonly Selector initWithProducer_ = "initWithProducer:";
			public static readonly Selector isPropertyKey_ = "isPropertyKey:";
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
			public static readonly Selector setupBindings = "setupBindings";
			public static readonly Selector setValue_forUndefinedKey_ = "setValue:forUndefinedKey:";
			public static readonly Selector setVerificationType_ = "setVerificationType:";
			public static readonly Selector testProductionSpeedForInterval_ = "testProductionSpeedForInterval:";
			public static readonly Selector testProductionSpeedForLength_ = "testProductionSpeedForLength:";
			public static readonly Selector trackForAudioFile_ = "trackForAudioFile:";
			public static readonly Selector trackForAudioOfLength_producer_ = "trackForAudioOfLength:producer:";
			public static readonly Selector trackForRootFolder_ = "trackForRootFolder:";
			public static readonly Selector trackMode = "trackMode";
			public static readonly Selector valueForUndefinedKey_ = "valueForUndefinedKey:";
			public static readonly Selector verificationType = "verificationType";
		}
	}
	public static class DiscRecordingExtensionsOfNSCharacterSet {
		private static int ___lazyLoad = DiscRecordingCachedClasses.___lazyLoad;
		unsafe public static NObjective.RuntimeObject countryCodeEndingSet() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.countryCodeEndingSet( NSCharacterSet.ClassHandle, CachedSelectors.countryCodeEndingSet, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject eolSet() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.eolSet( NSCharacterSet.ClassHandle, CachedSelectors.eolSet, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr countryCodeEndingSet( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr eolSet( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector countryCodeEndingSet = "countryCodeEndingSet";
			public static readonly Selector eolSet = "eolSet";
		}
	}
	public static class DiscRecordingExtensionsOfNSMutableDictionary {
		private static int ___lazyLoad = DiscRecordingCachedClasses.___lazyLoad;
		unsafe public static NObjective.RuntimeObject cueFileCDTextItems( this NSMutableDictionary ___this ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.cueFileCDTextItems( ___this, CachedSelectors.cueFileCDTextItems, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr cueFileCDTextItems( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector cueFileCDTextItems = "cueFileCDTextItems";
		}
	}
	static internal class DiscRecordingCachedClasses {
		static internal int ___lazyLoad = Platform.NativeMethods.dlopen( "/System/Library/Frameworks/DiscRecording.framework/DiscRecording" );
		public static readonly RuntimeClass DRAudioGenerator = "DRAudioGenerator";
		public static readonly RuntimeClass DRAudioTrack = "DRAudioTrack";
		public static readonly RuntimeClass DRBINFileProducer = "DRBINFileProducer";
		public static readonly RuntimeClass DRBurn = "DRBurn";
		public static readonly RuntimeClass DRCallbackDevice = "DRCallbackDevice";
		public static readonly RuntimeClass DRCDTextBlock = "DRCDTextBlock";
		public static readonly RuntimeClass DRCueFileParser = "DRCueFileParser";
		public static readonly RuntimeClass DRDataGenerator = "DRDataGenerator";
		public static readonly RuntimeClass DRDevice = "DRDevice";
		public static readonly RuntimeClass DRErase = "DRErase";
		public static readonly RuntimeClass DRFile = "DRFile";
		public static readonly RuntimeClass DRFilesystemTrack = "DRFilesystemTrack";
		public static readonly RuntimeClass DRFolder = "DRFolder";
		public static readonly RuntimeClass DRFSObject = "DRFSObject";
		public static readonly RuntimeClass DRMSF = "DRMSF";
		public static readonly RuntimeClass DRMSFFormatter = "DRMSFFormatter";
		public static readonly RuntimeClass DRNotificationCenter = "DRNotificationCenter";
		public static readonly RuntimeClass DRPartialFileAudioProducer = "DRPartialFileAudioProducer";
		public static readonly RuntimeClass DRPrepare = "DRPrepare";
		public static readonly RuntimeClass DRSession = "DRSession";
		public static readonly RuntimeClass DRSessionCDTextProducer = "DRSessionCDTextProducer";
		public static readonly RuntimeClass DRSessionProducerPlaceholder = "DRSessionProducerPlaceholder";
		public static readonly RuntimeClass DRSilenceGenerator = "DRSilenceGenerator";
		public static readonly RuntimeClass DRTask = "DRTask";
		public static readonly RuntimeClass DRTOCFileParser = "DRTOCFileParser";
		public static readonly RuntimeClass DRTOCProducer = "DRTOCProducer";
		public static readonly RuntimeClass DRTrack = "DRTrack";
		public static readonly RuntimeClass NSCharacterSet = "NSCharacterSet";
		public static readonly RuntimeClass NSMutableDictionary = "NSMutableDictionary";
	}
}
