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
	public struct DRAudioGenerator : IEquatable<DRAudioGenerator> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingContentCachedClasses.DRAudioGenerator;
		public static implicit operator IntPtr( DRAudioGenerator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRAudioGenerator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as DRAudioGenerator?;
			return compareTo != null && Handle == compareTo.Value.Handle;
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
			return ( uint ) ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char completed( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithGeneratorInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject info );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint produceIntoBuffer_length_blockSize_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr buffer, uint length, uint blockSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector completed = "completed";
			public static readonly Selector initWithGeneratorInfo_ = "initWithGeneratorInfo:";
			public static readonly Selector produceIntoBuffer_length_blockSize_ = "produceIntoBuffer:length:blockSize:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( DRTrack ) )]
	public struct DRAudioTrack : IEquatable<DRAudioTrack> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingContentCachedClasses.DRAudioTrack;
		public static implicit operator IntPtr( DRAudioTrack value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRAudioTrack value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as DRAudioTrack?;
			return compareTo != null && Handle == compareTo.Value.Handle;
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
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithPath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject path );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithPath_ = "initWithPath:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct DRBINFileProducer : IEquatable<DRBINFileProducer> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingContentCachedClasses.DRBINFileProducer;
		public static implicit operator IntPtr( DRBINFileProducer value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRBINFileProducer value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as DRBINFileProducer?;
			return compareTo != null && Handle == compareTo.Value.Handle;
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
			return ( uint ) ___result;
		}
		unsafe public uint produceDataIntoBuffer_length_blockSize_( System.IntPtr buffer, uint length, uint blockSize ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.produceDataIntoBuffer_length_blockSize_( Handle, CachedSelectors.produceDataIntoBuffer_length_blockSize_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( uint ) + sizeof( uint ), buffer, length, blockSize );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public uint producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( NObjective.RuntimeObject track, System.IntPtr intoBuffer, uint length, ulong atAddress, uint blockSize, System.IntPtr ioFlags ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( Handle, CachedSelectors.producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( uint ) + sizeof( ulong ) + sizeof( uint ) + sizeof( System.IntPtr ), track, intoBuffer, length, atAddress, blockSize, ioFlags
			 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void cleanupTrackAfterBurn_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject burn );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char prepareTrack_forBurn_toMedia_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject track, NObjective.RuntimeObject forBurn, NObjective.RuntimeObject toMedia );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint produceDataForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject track, System.IntPtr intoBuffer, uint length, ulong atAddress, uint blockSize, System.IntPtr ioFlags
			 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint produceDataIntoBuffer_length_blockSize_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr buffer, uint length, uint blockSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject track, System.IntPtr intoBuffer, uint length, ulong atAddress, uint blockSize, System.IntPtr ioFlags
			 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
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
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct DRCueFileParser : IEquatable<DRCueFileParser> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingContentCachedClasses.DRCueFileParser;
		public static implicit operator IntPtr( DRCueFileParser value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRCueFileParser value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as DRCueFileParser?;
			return compareTo != null && Handle == compareTo.Value.Handle;
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
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr burnProperties( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr cdText( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr decodeDatatype_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject datatype );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr extractString_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @string );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr fullPathForAuxFile_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithPath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject path );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char parse( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void parseFlags_trackInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject flags, NObjective.RuntimeObject trackInfo );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void parseIndexData_trackInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject data, NObjective.RuntimeObject trackInfo );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void parsePropertiesData_trackInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject data, NObjective.RuntimeObject trackInfo );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int parseSourceFile_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr trackInfoForIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int index );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
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
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct DRDataGenerator : IEquatable<DRDataGenerator> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingContentCachedClasses.DRDataGenerator;
		public static implicit operator IntPtr( DRDataGenerator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRDataGenerator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as DRDataGenerator?;
			return compareTo != null && Handle == compareTo.Value.Handle;
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
			return ( uint ) ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char completed( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithGeneratorInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject info );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint produceIntoBuffer_length_blockSize_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr buffer, uint length, uint blockSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector completed = "completed";
			public static readonly Selector initWithGeneratorInfo_ = "initWithGeneratorInfo:";
			public static readonly Selector produceIntoBuffer_length_blockSize_ = "produceIntoBuffer:length:blockSize:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( DRFSObject ) )]
	public struct DRFile : IEquatable<DRFile> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingContentCachedClasses.DRFile;
		public static implicit operator IntPtr( DRFile value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRFile value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as DRFile?;
			return compareTo != null && Handle == compareTo.Value.Handle;
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
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr fileWithPath_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr path );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr finderAliasPointingTo_inFilesystem_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRFSObject to, IntPtr inFilesystem );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr hardLinkPointingTo_inFilesystem_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRFile to, IntPtr inFilesystem );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithLinkType_pointingTo_inFilesystem_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr type, DRFSObject pointingTo, IntPtr inFilesystem );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithName_bytes_length_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name, System.IntPtr bytes, uint length );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithName_data_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name, NSData data );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithName_dataProducer_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name, NObjective.RuntimeObject dataProducer );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithPath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr path );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr symLinkPointingTo_inFilesystem_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRFSObject to, IntPtr inFilesystem );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr virtualFileWithName_data_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name, NSData data );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
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
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( DRTrack ) )]
	public struct DRFilesystemTrack : IEquatable<DRFilesystemTrack> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingContentCachedClasses.DRFilesystemTrack;
		public static implicit operator IntPtr( DRFilesystemTrack value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRFilesystemTrack value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as DRFilesystemTrack?;
			return compareTo != null && Handle == compareTo.Value.Handle;
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
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithRootFolder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject folder );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithRootFolder_ = "initWithRootFolder:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( DRFSObject ) )]
	public struct DRFolder : IEquatable<DRFolder> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingContentCachedClasses.DRFolder;
		public static implicit operator IntPtr( DRFolder value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRFolder value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as DRFolder?;
			return compareTo != null && Handle == compareTo.Value.Handle;
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
			return ( uint ) ___result;
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
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void addChild_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRFSObject child );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr children( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint count( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr folderWithPath_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr path );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithPath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr path );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void makeVirtual( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void removeChild_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRFSObject child );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr virtualFolderWithName_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name );
		}
		static internal class CachedSelectors {
			public static readonly Selector addChild_ = "addChild:";
			public static readonly Selector children = "children";
			public static readonly Selector count = "count";
			public static readonly Selector folderWithPath_ = "folderWithPath:";
			public static readonly Selector initWithName_ = "initWithName:";
			public static readonly Selector initWithPath_ = "initWithPath:";
			public static readonly Selector makeVirtual = "makeVirtual";
			public static readonly Selector removeChild_ = "removeChild:";
			public static readonly Selector virtualFolderWithName_ = "virtualFolderWithName:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct DRFSObject : IEquatable<DRFSObject> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingContentCachedClasses.DRFSObject;
		public static implicit operator IntPtr( DRFSObject value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRFSObject value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as DRFSObject?;
			return compareTo != null && Handle == compareTo.Value.Handle;
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
			return ( uint ) ___result;
		}
		unsafe public uint explicitFilesystemMask() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.explicitFilesystemMask( Handle, CachedSelectors.explicitFilesystemMask, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public bool isVirtual() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isVirtual( Handle, CachedSelectors.isVirtual, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
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
		unsafe public void setExplicitFilesystemMask_( uint mask ) {
			RuntimeObject ___occuredException;
			NativeMethods.setExplicitFilesystemMask_( Handle, CachedSelectors.setExplicitFilesystemMask_, out ___occuredException, sizeof( uint ), mask );
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
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr baseName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint effectiveFilesystemMask( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint explicitFilesystemMask( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isVirtual( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr mangledNameForFilesystem_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr filesystem );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr mangledNameForFileSystem_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject system );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr mangledNames( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr parent( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr propertiesForFilesystem_mergeWithOtherFilesystems_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr filesystem, bool mergeWithOtherFilesystems );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr propertyForKey_inFilesystem_mergeWithOtherFilesystems_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr key, IntPtr inFilesystem, bool mergeWithOtherFilesystems );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setBaseName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setExplicitFilesystemMask_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint mask );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setProperties_inFilesystem_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDictionary properties, IntPtr inFilesystem );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setProperty_forKey_inFilesystem_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject property, IntPtr forKey, IntPtr inFilesystem );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setSpecificName_forFilesystem_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name, IntPtr forFilesystem );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setSpecificNames_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSDictionary names );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr sourcePath( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr specificNameForFilesystem_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr filesystem );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr specificNames( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector baseName = "baseName";
			public static readonly Selector effectiveFilesystemMask = "effectiveFilesystemMask";
			public static readonly Selector explicitFilesystemMask = "explicitFilesystemMask";
			public static readonly Selector isVirtual = "isVirtual";
			public static readonly Selector mangledNameForFilesystem_ = "mangledNameForFilesystem:";
			public static readonly Selector mangledNameForFileSystem_ = "mangledNameForFileSystem:";
			public static readonly Selector mangledNames = "mangledNames";
			public static readonly Selector parent = "parent";
			public static readonly Selector propertiesForFilesystem_mergeWithOtherFilesystems_ = "propertiesForFilesystem:mergeWithOtherFilesystems:";
			public static readonly Selector propertyForKey_inFilesystem_mergeWithOtherFilesystems_ = "propertyForKey:inFilesystem:mergeWithOtherFilesystems:";
			public static readonly Selector setBaseName_ = "setBaseName:";
			public static readonly Selector setExplicitFilesystemMask_ = "setExplicitFilesystemMask:";
			public static readonly Selector setProperties_inFilesystem_ = "setProperties:inFilesystem:";
			public static readonly Selector setProperty_forKey_inFilesystem_ = "setProperty:forKey:inFilesystem:";
			public static readonly Selector setSpecificName_forFilesystem_ = "setSpecificName:forFilesystem:";
			public static readonly Selector setSpecificNames_ = "setSpecificNames:";
			public static readonly Selector sourcePath = "sourcePath";
			public static readonly Selector specificNameForFilesystem_ = "specificNameForFilesystem:";
			public static readonly Selector specificNames = "specificNames";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct DRPartialFileAudioProducer : IEquatable<DRPartialFileAudioProducer> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingContentCachedClasses.DRPartialFileAudioProducer;
		public static implicit operator IntPtr( DRPartialFileAudioProducer value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRPartialFileAudioProducer value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as DRPartialFileAudioProducer?;
			return compareTo != null && Handle == compareTo.Value.Handle;
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
			return ( uint ) ___result;
		}
		unsafe public uint produceDataIntoBuffer_length_blockSize_( System.IntPtr buffer, uint length, uint blockSize ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.produceDataIntoBuffer_length_blockSize_( Handle, CachedSelectors.produceDataIntoBuffer_length_blockSize_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( uint ) + sizeof( uint ), buffer, length, blockSize );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public uint producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( NObjective.RuntimeObject track, System.IntPtr intoBuffer, uint length, ulong atAddress, uint blockSize, System.IntPtr ioFlags ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( Handle, CachedSelectors.producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( uint ) + sizeof( ulong ) + sizeof( uint ) + sizeof( System.IntPtr ), track, intoBuffer, length, atAddress, blockSize, ioFlags
			 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr blockLengthOfFile_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void cleanupTrackAfterBurn_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject burn );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char prepareTrack_forBurn_toMedia_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject track, NObjective.RuntimeObject forBurn, NObjective.RuntimeObject toMedia );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint produceDataForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject track, System.IntPtr intoBuffer, uint length, ulong atAddress, uint blockSize, System.IntPtr ioFlags
			 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint produceDataIntoBuffer_length_blockSize_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr buffer, uint length, uint blockSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject track, System.IntPtr intoBuffer, uint length, ulong atAddress, uint blockSize, System.IntPtr ioFlags
			 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
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
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct DRSilenceGenerator : IEquatable<DRSilenceGenerator> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingContentCachedClasses.DRSilenceGenerator;
		public static implicit operator IntPtr( DRSilenceGenerator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRSilenceGenerator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as DRSilenceGenerator?;
			return compareTo != null && Handle == compareTo.Value.Handle;
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
			return ( uint ) ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char completed( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithGeneratorInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject info );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint produceIntoBuffer_length_blockSize_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr buffer, uint length, uint blockSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector completed = "completed";
			public static readonly Selector initWithGeneratorInfo_ = "initWithGeneratorInfo:";
			public static readonly Selector produceIntoBuffer_length_blockSize_ = "produceIntoBuffer:length:blockSize:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct DRTOCFileParser : IEquatable<DRTOCFileParser> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingContentCachedClasses.DRTOCFileParser;
		public static implicit operator IntPtr( DRTOCFileParser value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRTOCFileParser value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as DRTOCFileParser?;
			return compareTo != null && Handle == compareTo.Value.Handle;
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
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr burnProperties( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr cdText( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr extractOptionalString_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @string );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr extractRequiredString_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @string );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr fullPathForAuxFile_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithPath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject path );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char parse( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void parseCDText_forDisc_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject text, char forDisc );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr parseTrack_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject track );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr parseTrackModes_isAudioTrack_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject modes, System.IntPtr isAudioTrack );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setCDTextString_forKey_ofTrack_inLanguage_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @string, NObjective.RuntimeObject forKey, int ofTrack, int inLanguage );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
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
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct DRTOCProducer : IEquatable<DRTOCProducer> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DiscRecordingContentCachedClasses.DRTOCProducer;
		public static implicit operator IntPtr( DRTOCProducer value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DRTOCProducer value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as DRTOCProducer?;
			return compareTo != null && Handle == compareTo.Value.Handle;
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
			return ( uint ) ___result;
		}
		unsafe public uint producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( NObjective.RuntimeObject track, System.IntPtr intoBuffer, uint length, ulong atAddress, uint blockSize, System.IntPtr ioFlags ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( Handle, CachedSelectors.producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( uint ) + sizeof( ulong ) + sizeof( uint ) + sizeof( System.IntPtr ), track, intoBuffer, length, atAddress, blockSize, ioFlags
			 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void cleanupTrackAfterBurn_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject burn );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char prepareTrack_forBurn_toMedia_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject track, NObjective.RuntimeObject forBurn, NObjective.RuntimeObject toMedia );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint produceDataForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject track, System.IntPtr intoBuffer, uint length, ulong atAddress, uint blockSize, System.IntPtr ioFlags
			 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint producePreGapForTrack_intoBuffer_length_atAddress_blockSize_ioFlags_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject track, System.IntPtr intoBuffer, uint length, ulong atAddress, uint blockSize, System.IntPtr ioFlags
			 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
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
	[StructLayoutAttribute( LayoutKind.Explicit )]
	public static class DiscRecordingContentExtensionsOfNSCharacterSet {
		private static int ___lazyLoad = DiscRecordingContentCachedClasses.___lazyLoad;
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
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr countryCodeEndingSet( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr eolSet( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector countryCodeEndingSet = "countryCodeEndingSet";
			public static readonly Selector eolSet = "eolSet";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	public static class DiscRecordingContentExtensionsOfDRBurn {
		private static int ___lazyLoad = DiscRecordingContentCachedClasses.___lazyLoad;
		unsafe public static NObjective.RuntimeObject layoutForImageFile_( string file ) {
			RuntimeObject ___occuredException;
			var ___wrappedfile = Runtime.CreateStringProxy( file );
			var ___result = NativeMethods.layoutForImageFile_( DRBurn.ClassHandle, CachedSelectors.layoutForImageFile_, out ___occuredException, sizeof( IntPtr ), ___wrappedfile );
			Runtime.ReleaseNativeObject( ___wrappedfile );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr layoutForImageFile_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr file );
		}
		static internal class CachedSelectors {
			public static readonly Selector layoutForImageFile_ = "layoutForImageFile:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	public static class DiscRecordingContentExtensionsOfDRTrack {
		private static int ___lazyLoad = DiscRecordingContentCachedClasses.___lazyLoad;
		unsafe public static DRTrack trackForAudioFile_( string file ) {
			RuntimeObject ___occuredException;
			var ___wrappedfile = Runtime.CreateStringProxy( file );
			var ___result = NativeMethods.trackForAudioFile_( DRTrack.ClassHandle, CachedSelectors.trackForAudioFile_, out ___occuredException, sizeof( IntPtr ), ___wrappedfile );
			Runtime.ReleaseNativeObject( ___wrappedfile );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRTrack( ___result );
		}
		unsafe public static DRTrack trackForAudioOfLength_producer_( DRMSF length, NObjective.RuntimeObject producer ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.trackForAudioOfLength_producer_( DRTrack.ClassHandle, CachedSelectors.trackForAudioOfLength_producer_, out ___occuredException, sizeof( DRMSF ) + sizeof( NObjective.RuntimeObject ), length, producer );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRTrack( ___result );
		}
		unsafe public static DRTrack trackForRootFolder_( DRFolder folder ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.trackForRootFolder_( DRTrack.ClassHandle, CachedSelectors.trackForRootFolder_, out ___occuredException, sizeof( DRFolder ), folder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new DRTrack( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr trackForAudioFile_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr file );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr trackForAudioOfLength_producer_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRMSF length, NObjective.RuntimeObject producer );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr trackForRootFolder_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, DRFolder folder );
		}
		static internal class CachedSelectors {
			public static readonly Selector trackForAudioFile_ = "trackForAudioFile:";
			public static readonly Selector trackForAudioOfLength_producer_ = "trackForAudioOfLength:producer:";
			public static readonly Selector trackForRootFolder_ = "trackForRootFolder:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	public static class DiscRecordingContentExtensionsOfDRMSF {
		private static int ___lazyLoad = DiscRecordingContentCachedClasses.___lazyLoad;
		unsafe public static NObjective.RuntimeObject msfFromString_couldBeByteLength_( NObjective.RuntimeObject @string, char couldBeByteLength ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.msfFromString_couldBeByteLength_( DRMSF.ClassHandle, CachedSelectors.msfFromString_couldBeByteLength_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( char ), @string, couldBeByteLength );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr msfFromString_couldBeByteLength_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @string, char couldBeByteLength );
		}
		static internal class CachedSelectors {
			public static readonly Selector msfFromString_couldBeByteLength_ = "msfFromString:couldBeByteLength:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	public static class DiscRecordingContentExtensionsOfNSMutableDictionary {
		private static int ___lazyLoad = DiscRecordingContentCachedClasses.___lazyLoad;
		unsafe public static NObjective.RuntimeObject cueFileCDTextItems( this NSMutableDictionary ___this ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.cueFileCDTextItems( ___this, CachedSelectors.cueFileCDTextItems, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr cueFileCDTextItems( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector cueFileCDTextItems = "cueFileCDTextItems";
		}
	}
	static internal class DiscRecordingContentCachedClasses {
		static internal int ___lazyLoad = Platform.NativeMethods.dlopen( "/System/Library/Frameworks/DiscRecording.framework/Versions/A/Frameworks/DiscRecordingContent.framework/Versions/A/DiscRecordingContent" );
		public static readonly RuntimeClass DRAudioGenerator = "DRAudioGenerator";
		public static readonly RuntimeClass DRAudioTrack = "DRAudioTrack";
		public static readonly RuntimeClass DRBINFileProducer = "DRBINFileProducer";
		public static readonly RuntimeClass DRCueFileParser = "DRCueFileParser";
		public static readonly RuntimeClass DRDataGenerator = "DRDataGenerator";
		public static readonly RuntimeClass DRFile = "DRFile";
		public static readonly RuntimeClass DRFilesystemTrack = "DRFilesystemTrack";
		public static readonly RuntimeClass DRFolder = "DRFolder";
		public static readonly RuntimeClass DRFSObject = "DRFSObject";
		public static readonly RuntimeClass DRPartialFileAudioProducer = "DRPartialFileAudioProducer";
		public static readonly RuntimeClass DRSilenceGenerator = "DRSilenceGenerator";
		public static readonly RuntimeClass DRTOCFileParser = "DRTOCFileParser";
		public static readonly RuntimeClass DRTOCProducer = "DRTOCProducer";
		public static readonly RuntimeClass NSCharacterSet = "NSCharacterSet";
		public static readonly RuntimeClass DRBurn = "DRBurn";
		public static readonly RuntimeClass DRTrack = "DRTrack";
		public static readonly RuntimeClass DRMSF = "DRMSF";
		public static readonly RuntimeClass NSMutableDictionary = "NSMutableDictionary";
	}
}
