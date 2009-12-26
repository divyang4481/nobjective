//
// Copyright (C) 2009 Eugeny Grishul
//
// See license in License.txt
//

namespace NObjective.Proxies {
	using System;
	using System.Runtime.InteropServices;
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIAddBlendMode : IEquatable<CIAddBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIAddBlendMode;
		public static implicit operator CIFilter( CIAddBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIAddBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIAddBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIAddBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIAddBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIAddBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIAddBlendMode value1, CIAddBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIAddBlendMode value1, CIAddBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIAddBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIAddBlendMode alloc() {
			return new CIAddBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIAdditionCompositing : IEquatable<CIAdditionCompositing> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIAdditionCompositing;
		public static implicit operator CIFilter( CIAdditionCompositing value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIAdditionCompositing value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIAdditionCompositing value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIAdditionCompositing value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIAdditionCompositing?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIAdditionCompositing value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIAdditionCompositing value1, CIAdditionCompositing value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIAdditionCompositing value1, CIAdditionCompositing value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIAdditionCompositing( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIAdditionCompositing alloc() {
			return new CIAdditionCompositing( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIAffineClamp : IEquatable<CIAffineClamp> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIAffineClamp;
		public static implicit operator CIFilter( CIAffineClamp value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIAffineClamp value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIAffineClamp value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIAffineClamp value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIAffineClamp?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIAffineClamp value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIAffineClamp value1, CIAffineClamp value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIAffineClamp value1, CIAffineClamp value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIAffineClamp( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIAffineClamp alloc() {
			return new CIAffineClamp( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIAffineTile : IEquatable<CIAffineTile> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIAffineTile;
		public static implicit operator CIFilter( CIAffineTile value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIAffineTile value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIAffineTile value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIAffineTile value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIAffineTile?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIAffineTile value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIAffineTile value1, CIAffineTile value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIAffineTile value1, CIAffineTile value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIAffineTile( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIAffineTile alloc() {
			return new CIAffineTile( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIAffineTransform : IEquatable<CIAffineTransform> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIAffineTransform;
		public static implicit operator CIFilter( CIAffineTransform value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIAffineTransform value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIAffineTransform value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIAffineTransform value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIAffineTransform?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIAffineTransform value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIAffineTransform value1, CIAffineTransform value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIAffineTransform value1, CIAffineTransform value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIAffineTransform( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIAffineTransform alloc() {
			return new CIAffineTransform( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIAlphaAddBlendMode : IEquatable<CIAlphaAddBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIAlphaAddBlendMode;
		public static implicit operator CIFilter( CIAlphaAddBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIAlphaAddBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIAlphaAddBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIAlphaAddBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIAlphaAddBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIAlphaAddBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIAlphaAddBlendMode value1, CIAlphaAddBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIAlphaAddBlendMode value1, CIAlphaAddBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIAlphaAddBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIAlphaAddBlendMode alloc() {
			return new CIAlphaAddBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIAutoBlackPointWhitePoint : IEquatable<CIAutoBlackPointWhitePoint> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIAutoBlackPointWhitePoint;
		public static implicit operator CIFilter( CIAutoBlackPointWhitePoint value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIAutoBlackPointWhitePoint value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIAutoBlackPointWhitePoint value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIAutoBlackPointWhitePoint value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIAutoBlackPointWhitePoint?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIAutoBlackPointWhitePoint value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIAutoBlackPointWhitePoint value1, CIAutoBlackPointWhitePoint value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIAutoBlackPointWhitePoint value1, CIAutoBlackPointWhitePoint value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIAutoBlackPointWhitePoint( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIAutoBlackPointWhitePoint alloc() {
			return new CIAutoBlackPointWhitePoint( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject forcePromise_( NObjective.RuntimeObject promise ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.forcePromise_( Handle, CachedSelectors.forcePromise_, out ___occuredException, sizeof( NObjective.RuntimeObject ), promise );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr forcePromise_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject promise );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector forcePromise_ = "forcePromise:";
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIBackground : IEquatable<CIBackground> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIBackground;
		public static implicit operator CIFilter( CIBackground value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIBackground value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIBackground value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIBackground value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIBackground?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIBackground value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIBackground value1, CIBackground value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIBackground value1, CIBackground value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIBackground( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIBackground alloc() {
			return new CIBackground( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIBayerReconstruction : IEquatable<CIBayerReconstruction> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIBayerReconstruction;
		public static implicit operator CIFilter( CIBayerReconstruction value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIBayerReconstruction value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIBayerReconstruction value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIBayerReconstruction value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIBayerReconstruction?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIBayerReconstruction value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIBayerReconstruction value1, CIBayerReconstruction value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIBayerReconstruction value1, CIBayerReconstruction value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIBayerReconstruction( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIBayerReconstruction alloc() {
			return new CIBayerReconstruction( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject antiAliasingFilter_phase_greenAmount_redBlueAmount_( NObjective.RuntimeObject filter, NObjective.RuntimeObject phase, NObjective.RuntimeObject greenAmount, NObjective.RuntimeObject redBlueAmount ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.antiAliasingFilter_phase_greenAmount_redBlueAmount_( Handle, CachedSelectors.antiAliasingFilter_phase_greenAmount_redBlueAmount_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), filter, phase, greenAmount, redBlueAmount );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject blackSubtractAndPremultiply_pattern_factors_blackLevels_image_( NObjective.RuntimeObject premultiply, uint pattern, System.IntPtr factors, NObjective.RuntimeObject blackLevels, System.IntPtr image ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.blackSubtractAndPremultiply_pattern_factors_blackLevels_image_( Handle, CachedSelectors.blackSubtractAndPremultiply_pattern_factors_blackLevels_image_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ) + sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), premultiply, pattern, factors, blackLevels, image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject blueReconstruction_green_phase_image_( NObjective.RuntimeObject reconstruction, NObjective.RuntimeObject green, NObjective.RuntimeObject phase, System.IntPtr image ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.blueReconstruction_green_phase_image_( Handle, CachedSelectors.blueReconstruction_green_phase_image_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), reconstruction, green, phase, image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject blurHalfSizeImage_sampler_radius_image_kind_( NObjective.RuntimeObject image, NObjective.RuntimeObject sampler, NObjective.RuntimeObject radius, System.IntPtr image2, int kind ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.blurHalfSizeImage_sampler_radius_image_kind_( Handle, CachedSelectors.blurHalfSizeImage_sampler_radius_image_kind_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( int ), image, sampler, radius, image2, kind );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject fullNoiseReduction_pattern_radius_slope_( NObjective.RuntimeObject reduction, uint pattern, NObjective.RuntimeObject radius, NObjective.RuntimeObject slope ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.fullNoiseReduction_pattern_radius_slope_( Handle, CachedSelectors.fullNoiseReduction_pattern_radius_slope_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), reduction, pattern, radius, slope );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject greenReconstruction_edges_phase_scale1_scale2_decisions_votedDecisions_image_decisionImage_votingImage_( NObjective.RuntimeObject reconstruction, NObjective.RuntimeObject edges, NObjective.RuntimeObject phase, NObjective.RuntimeObject scale1, NObjective.RuntimeObject scale2, System.IntPtr decisions, System.IntPtr votedDecisions, System.IntPtr image, System.IntPtr decisionImage, System.IntPtr votingImage
		 ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.greenReconstruction_edges_phase_scale1_scale2_decisions_votedDecisions_image_decisionImage_votingImage_( Handle, CachedSelectors.greenReconstruction_edges_phase_scale1_scale2_decisions_votedDecisions_image_decisionImage_votingImage_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( System.IntPtr ) + sizeof( System.IntPtr ) + sizeof( System.IntPtr ) + sizeof( System.IntPtr ), reconstruction, edges, phase, scale1, scale2, decisions, 
			votedDecisions, image, decisionImage, votingImage );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject halfSizePicture_pattern_image_( NObjective.RuntimeObject picture, uint pattern, System.IntPtr image ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.halfSizePicture_pattern_image_( Handle, CachedSelectors.halfSizePicture_pattern_image_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ) + sizeof( System.IntPtr ), picture, pattern, image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject halfSizePictureEdges_scale_image_( NObjective.RuntimeObject edges, NObjective.RuntimeObject scale, System.IntPtr image ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.halfSizePictureEdges_scale_image_( Handle, CachedSelectors.halfSizePictureEdges_scale_image_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), edges, scale, image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject highlightRecovery_pattern_clipLevels_redPhase_greenPhase_bluePhase_redBlueSwap_image_( NObjective.RuntimeObject recovery, uint pattern, System.IntPtr clipLevels, NObjective.RuntimeObject redPhase, NObjective.RuntimeObject greenPhase, NObjective.RuntimeObject bluePhase, char redBlueSwap, System.IntPtr image ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.highlightRecovery_pattern_clipLevels_redPhase_greenPhase_bluePhase_redBlueSwap_image_( Handle, CachedSelectors.highlightRecovery_pattern_clipLevels_redPhase_greenPhase_bluePhase_redBlueSwap_image_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ) + sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( char ) + sizeof( System.IntPtr ), recovery, pattern, clipLevels, redPhase, greenPhase, bluePhase, 
			redBlueSwap, image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject redNoiseReduction_pattern_radius_slope_( NObjective.RuntimeObject reduction, uint pattern, NObjective.RuntimeObject radius, NObjective.RuntimeObject slope ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.redNoiseReduction_pattern_radius_slope_( Handle, CachedSelectors.redNoiseReduction_pattern_radius_slope_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), reduction, pattern, radius, slope );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject redReconstruction_green_phase_image_( NObjective.RuntimeObject reconstruction, NObjective.RuntimeObject green, NObjective.RuntimeObject phase, System.IntPtr image ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.redReconstruction_green_phase_image_( Handle, CachedSelectors.redReconstruction_green_phase_image_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), reconstruction, green, phase, image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject sharpenReconstructedGreenEdges_radius_intensity_edgeIntensity_edgeThreshold_edgeMaskRadius_edgeMask_image_( NObjective.RuntimeObject edges, NObjective.RuntimeObject radius, NObjective.RuntimeObject intensity, NObjective.RuntimeObject edgeIntensity, NObjective.RuntimeObject edgeThreshold, NObjective.RuntimeObject edgeMaskRadius, System.IntPtr edgeMask, System.IntPtr image ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sharpenReconstructedGreenEdges_radius_intensity_edgeIntensity_edgeThreshold_edgeMaskRadius_edgeMask_image_( Handle, CachedSelectors.sharpenReconstructedGreenEdges_radius_intensity_edgeIntensity_edgeThreshold_edgeMaskRadius_edgeMask_image_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( System.IntPtr ), edges, radius, intensity, edgeIntensity, edgeThreshold, edgeMaskRadius, 
			edgeMask, image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject standardCrop_original_( NObjective.RuntimeObject crop, NObjective.RuntimeObject original ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.standardCrop_original_( Handle, CachedSelectors.standardCrop_original_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), crop, original );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject stuckPixelElimination_threshold_phase_( NObjective.RuntimeObject elimination, NObjective.RuntimeObject threshold, NObjective.RuntimeObject phase ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.stuckPixelElimination_threshold_phase_( Handle, CachedSelectors.stuckPixelElimination_threshold_phase_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), elimination, threshold, phase );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr antiAliasingFilter_phase_greenAmount_redBlueAmount_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject filter, NObjective.RuntimeObject phase, NObjective.RuntimeObject greenAmount, NObjective.RuntimeObject redBlueAmount );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr blackSubtractAndPremultiply_pattern_factors_blackLevels_image_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject premultiply, uint pattern, System.IntPtr factors, NObjective.RuntimeObject blackLevels, System.IntPtr image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr blueReconstruction_green_phase_image_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject reconstruction, NObjective.RuntimeObject green, NObjective.RuntimeObject phase, System.IntPtr image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr blurHalfSizeImage_sampler_radius_image_kind_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject image, NObjective.RuntimeObject sampler, NObjective.RuntimeObject radius, System.IntPtr image2, int kind );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr fullNoiseReduction_pattern_radius_slope_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject reduction, uint pattern, NObjective.RuntimeObject radius, NObjective.RuntimeObject slope );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr greenReconstruction_edges_phase_scale1_scale2_decisions_votedDecisions_image_decisionImage_votingImage_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject reconstruction, NObjective.RuntimeObject edges, NObjective.RuntimeObject phase, NObjective.RuntimeObject scale1, NObjective.RuntimeObject scale2, System.IntPtr decisions, 
			System.IntPtr votedDecisions, System.IntPtr image, System.IntPtr decisionImage, System.IntPtr votingImage );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr halfSizePicture_pattern_image_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject picture, uint pattern, System.IntPtr image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr halfSizePictureEdges_scale_image_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject edges, NObjective.RuntimeObject scale, System.IntPtr image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr highlightRecovery_pattern_clipLevels_redPhase_greenPhase_bluePhase_redBlueSwap_image_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject recovery, uint pattern, System.IntPtr clipLevels, NObjective.RuntimeObject redPhase, NObjective.RuntimeObject greenPhase, NObjective.RuntimeObject bluePhase, 
			char redBlueSwap, System.IntPtr image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr redNoiseReduction_pattern_radius_slope_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject reduction, uint pattern, NObjective.RuntimeObject radius, NObjective.RuntimeObject slope );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr redReconstruction_green_phase_image_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject reconstruction, NObjective.RuntimeObject green, NObjective.RuntimeObject phase, System.IntPtr image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr sharpenReconstructedGreenEdges_radius_intensity_edgeIntensity_edgeThreshold_edgeMaskRadius_edgeMask_image_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject edges, NObjective.RuntimeObject radius, NObjective.RuntimeObject intensity, NObjective.RuntimeObject edgeIntensity, NObjective.RuntimeObject edgeThreshold, NObjective.RuntimeObject edgeMaskRadius, 
			System.IntPtr edgeMask, System.IntPtr image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr standardCrop_original_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject crop, NObjective.RuntimeObject original );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr stuckPixelElimination_threshold_phase_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject elimination, NObjective.RuntimeObject threshold, NObjective.RuntimeObject phase );
		}
		static internal class CachedSelectors {
			public static readonly Selector antiAliasingFilter_phase_greenAmount_redBlueAmount_ = "antiAliasingFilter:phase:greenAmount:redBlueAmount:";
			public static readonly Selector blackSubtractAndPremultiply_pattern_factors_blackLevels_image_ = "blackSubtractAndPremultiply:pattern:factors:blackLevels:image:";
			public static readonly Selector blueReconstruction_green_phase_image_ = "blueReconstruction:green:phase:image:";
			public static readonly Selector blurHalfSizeImage_sampler_radius_image_kind_ = "blurHalfSizeImage:sampler:radius:image:kind:";
			public static readonly Selector fullNoiseReduction_pattern_radius_slope_ = "fullNoiseReduction:pattern:radius:slope:";
			public static readonly Selector greenReconstruction_edges_phase_scale1_scale2_decisions_votedDecisions_image_decisionImage_votingImage_ = "greenReconstruction:edges:phase:scale1:scale2:decisions:votedDecisions:image:decisionImage:votingImage:";
			public static readonly Selector halfSizePicture_pattern_image_ = "halfSizePicture:pattern:image:";
			public static readonly Selector halfSizePictureEdges_scale_image_ = "halfSizePictureEdges:scale:image:";
			public static readonly Selector highlightRecovery_pattern_clipLevels_redPhase_greenPhase_bluePhase_redBlueSwap_image_ = "highlightRecovery:pattern:clipLevels:redPhase:greenPhase:bluePhase:redBlueSwap:image:";
			public static readonly Selector outputImage = "outputImage";
			public static readonly Selector redNoiseReduction_pattern_radius_slope_ = "redNoiseReduction:pattern:radius:slope:";
			public static readonly Selector redReconstruction_green_phase_image_ = "redReconstruction:green:phase:image:";
			public static readonly Selector sharpenReconstructedGreenEdges_radius_intensity_edgeIntensity_edgeThreshold_edgeMaskRadius_edgeMask_image_ = "sharpenReconstructedGreenEdges:radius:intensity:edgeIntensity:edgeThreshold:edgeMaskRadius:edgeMask:image:";
			public static readonly Selector standardCrop_original_ = "standardCrop:original:";
			public static readonly Selector stuckPixelElimination_threshold_phase_ = "stuckPixelElimination:threshold:phase:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIBayerReconstructionFuji : IEquatable<CIBayerReconstructionFuji> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIBayerReconstructionFuji;
		public static implicit operator CIFilter( CIBayerReconstructionFuji value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIBayerReconstructionFuji value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIBayerReconstructionFuji value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIBayerReconstructionFuji value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIBayerReconstructionFuji?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIBayerReconstructionFuji value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIBayerReconstructionFuji value1, CIBayerReconstructionFuji value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIBayerReconstructionFuji value1, CIBayerReconstructionFuji value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIBayerReconstructionFuji( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIBayerReconstructionFuji alloc() {
			return new CIBayerReconstructionFuji( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject blackSubtract_pattern_factors_blackLevels_image_( NObjective.RuntimeObject subtract, uint pattern, System.IntPtr factors, NObjective.RuntimeObject blackLevels, System.IntPtr image ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.blackSubtract_pattern_factors_blackLevels_image_( Handle, CachedSelectors.blackSubtract_pattern_factors_blackLevels_image_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ) + sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), subtract, pattern, factors, blackLevels, image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject blueRecon_green_pattern_( NObjective.RuntimeObject recon, NObjective.RuntimeObject green, uint pattern ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.blueRecon_green_pattern_( Handle, CachedSelectors.blueRecon_green_pattern_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( uint ), recon, green, pattern );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject blurHalf_radius_image_kind_( NObjective.RuntimeObject half, NObjective.RuntimeObject radius, System.IntPtr image, int kind ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.blurHalf_radius_image_kind_( Handle, CachedSelectors.blurHalf_radius_image_kind_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( int ), half, radius, image, kind );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject edges_scale_image_( NObjective.RuntimeObject edges, NObjective.RuntimeObject scale, System.IntPtr image ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.edges_scale_image_( Handle, CachedSelectors.edges_scale_image_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), edges, scale, image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject greenRecon_edges_pattern_scale1_scale2_decisions_votedDecisions_( NObjective.RuntimeObject recon, NObjective.RuntimeObject edges, uint pattern, NObjective.RuntimeObject scale1, NObjective.RuntimeObject scale2, System.IntPtr decisions, System.IntPtr votedDecisions ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.greenRecon_edges_pattern_scale1_scale2_decisions_votedDecisions_( Handle, CachedSelectors.greenRecon_edges_pattern_scale1_scale2_decisions_votedDecisions_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( uint ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( System.IntPtr ), recon, edges, pattern, scale1, scale2, decisions, 
			votedDecisions );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject greenSharpen_radius_intensity_edgeIntensity_edgeThreshold_edgeMaskRadius_edgeMask_( NObjective.RuntimeObject sharpen, NObjective.RuntimeObject radius, NObjective.RuntimeObject intensity, NObjective.RuntimeObject edgeIntensity, NObjective.RuntimeObject edgeThreshold, NObjective.RuntimeObject edgeMaskRadius, System.IntPtr edgeMask ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.greenSharpen_radius_intensity_edgeIntensity_edgeThreshold_edgeMaskRadius_edgeMask_( Handle, CachedSelectors.greenSharpen_radius_intensity_edgeIntensity_edgeThreshold_edgeMaskRadius_edgeMask_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), sharpen, radius, intensity, edgeIntensity, edgeThreshold, edgeMaskRadius, 
			edgeMask );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject halfSize_pattern_image_( NObjective.RuntimeObject size, uint pattern, System.IntPtr image ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.halfSize_pattern_image_( Handle, CachedSelectors.halfSize_pattern_image_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ) + sizeof( System.IntPtr ), size, pattern, image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject highlight_pattern_clipLevels_image_( NObjective.RuntimeObject highlight, uint pattern, System.IntPtr clipLevels, System.IntPtr image ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.highlight_pattern_clipLevels_image_( Handle, CachedSelectors.highlight_pattern_clipLevels_image_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ) + sizeof( System.IntPtr ) + sizeof( System.IntPtr ), highlight, pattern, clipLevels, image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject redRecon_green_pattern_( NObjective.RuntimeObject recon, NObjective.RuntimeObject green, uint pattern ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.redRecon_green_pattern_( Handle, CachedSelectors.redRecon_green_pattern_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( uint ), recon, green, pattern );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject standardCrop_original_( NObjective.RuntimeObject crop, NObjective.RuntimeObject original ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.standardCrop_original_( Handle, CachedSelectors.standardCrop_original_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), crop, original );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject stuckPixel_threshold_pattern_( NObjective.RuntimeObject pixel, NObjective.RuntimeObject threshold, uint pattern ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.stuckPixel_threshold_pattern_( Handle, CachedSelectors.stuckPixel_threshold_pattern_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( uint ), pixel, threshold, pattern );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr blackSubtract_pattern_factors_blackLevels_image_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject subtract, uint pattern, System.IntPtr factors, NObjective.RuntimeObject blackLevels, System.IntPtr image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr blueRecon_green_pattern_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject recon, NObjective.RuntimeObject green, uint pattern );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr blurHalf_radius_image_kind_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject half, NObjective.RuntimeObject radius, System.IntPtr image, int kind );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr edges_scale_image_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject edges, NObjective.RuntimeObject scale, System.IntPtr image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr greenRecon_edges_pattern_scale1_scale2_decisions_votedDecisions_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject recon, NObjective.RuntimeObject edges, uint pattern, NObjective.RuntimeObject scale1, NObjective.RuntimeObject scale2, System.IntPtr decisions, 
			System.IntPtr votedDecisions );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr greenSharpen_radius_intensity_edgeIntensity_edgeThreshold_edgeMaskRadius_edgeMask_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject sharpen, NObjective.RuntimeObject radius, NObjective.RuntimeObject intensity, NObjective.RuntimeObject edgeIntensity, NObjective.RuntimeObject edgeThreshold, NObjective.RuntimeObject edgeMaskRadius, 
			System.IntPtr edgeMask );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr halfSize_pattern_image_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject size, uint pattern, System.IntPtr image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr highlight_pattern_clipLevels_image_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject highlight, uint pattern, System.IntPtr clipLevels, System.IntPtr image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr redRecon_green_pattern_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject recon, NObjective.RuntimeObject green, uint pattern );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr standardCrop_original_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject crop, NObjective.RuntimeObject original );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr stuckPixel_threshold_pattern_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject pixel, NObjective.RuntimeObject threshold, uint pattern );
		}
		static internal class CachedSelectors {
			public static readonly Selector blackSubtract_pattern_factors_blackLevels_image_ = "blackSubtract:pattern:factors:blackLevels:image:";
			public static readonly Selector blueRecon_green_pattern_ = "blueRecon:green:pattern:";
			public static readonly Selector blurHalf_radius_image_kind_ = "blurHalf:radius:image:kind:";
			public static readonly Selector edges_scale_image_ = "edges:scale:image:";
			public static readonly Selector greenRecon_edges_pattern_scale1_scale2_decisions_votedDecisions_ = "greenRecon:edges:pattern:scale1:scale2:decisions:votedDecisions:";
			public static readonly Selector greenSharpen_radius_intensity_edgeIntensity_edgeThreshold_edgeMaskRadius_edgeMask_ = "greenSharpen:radius:intensity:edgeIntensity:edgeThreshold:edgeMaskRadius:edgeMask:";
			public static readonly Selector halfSize_pattern_image_ = "halfSize:pattern:image:";
			public static readonly Selector highlight_pattern_clipLevels_image_ = "highlight:pattern:clipLevels:image:";
			public static readonly Selector outputImage = "outputImage";
			public static readonly Selector redRecon_green_pattern_ = "redRecon:green:pattern:";
			public static readonly Selector standardCrop_original_ = "standardCrop:original:";
			public static readonly Selector stuckPixel_threshold_pattern_ = "stuckPixel:threshold:pattern:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIBayerReconstructionV0 : IEquatable<CIBayerReconstructionV0> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIBayerReconstructionV0;
		public static implicit operator CIFilter( CIBayerReconstructionV0 value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIBayerReconstructionV0 value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIBayerReconstructionV0 value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIBayerReconstructionV0 value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIBayerReconstructionV0?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIBayerReconstructionV0 value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIBayerReconstructionV0 value1, CIBayerReconstructionV0 value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIBayerReconstructionV0 value1, CIBayerReconstructionV0 value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIBayerReconstructionV0( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIBayerReconstructionV0 alloc() {
			return new CIBayerReconstructionV0( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject blackSubtractAndPremultiply_pattern_factors_blackLevels_image_( NObjective.RuntimeObject premultiply, uint pattern, System.IntPtr factors, NObjective.RuntimeObject blackLevels, System.IntPtr image ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.blackSubtractAndPremultiply_pattern_factors_blackLevels_image_( Handle, CachedSelectors.blackSubtractAndPremultiply_pattern_factors_blackLevels_image_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ) + sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), premultiply, pattern, factors, blackLevels, image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject blueReconstruction_green_phase_image_( NObjective.RuntimeObject reconstruction, NObjective.RuntimeObject green, NObjective.RuntimeObject phase, System.IntPtr image ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.blueReconstruction_green_phase_image_( Handle, CachedSelectors.blueReconstruction_green_phase_image_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), reconstruction, green, phase, image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject blurHalfSizeImage_radius_image_( NObjective.RuntimeObject image, NObjective.RuntimeObject radius, System.IntPtr image2 ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.blurHalfSizeImage_radius_image_( Handle, CachedSelectors.blurHalfSizeImage_radius_image_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), image, radius, image2 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject greenReconstruction_edges_phase_scale1_scale2_decisions_votedDecisions_image_decisionImage_votingImage_( NObjective.RuntimeObject reconstruction, NObjective.RuntimeObject edges, NObjective.RuntimeObject phase, NObjective.RuntimeObject scale1, NObjective.RuntimeObject scale2, System.IntPtr decisions, System.IntPtr votedDecisions, System.IntPtr image, System.IntPtr decisionImage, System.IntPtr votingImage
		 ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.greenReconstruction_edges_phase_scale1_scale2_decisions_votedDecisions_image_decisionImage_votingImage_( Handle, CachedSelectors.greenReconstruction_edges_phase_scale1_scale2_decisions_votedDecisions_image_decisionImage_votingImage_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( System.IntPtr ) + sizeof( System.IntPtr ) + sizeof( System.IntPtr ) + sizeof( System.IntPtr ), reconstruction, edges, phase, scale1, scale2, decisions, 
			votedDecisions, image, decisionImage, votingImage );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject halfSizePicture_pattern_image_( NObjective.RuntimeObject picture, uint pattern, System.IntPtr image ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.halfSizePicture_pattern_image_( Handle, CachedSelectors.halfSizePicture_pattern_image_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ) + sizeof( System.IntPtr ), picture, pattern, image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject halfSizePictureEdges_scale_image_( NObjective.RuntimeObject edges, NObjective.RuntimeObject scale, System.IntPtr image ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.halfSizePictureEdges_scale_image_( Handle, CachedSelectors.halfSizePictureEdges_scale_image_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), edges, scale, image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject highlightRecovery_pattern_clipLevels_redPhase_greenPhase_bluePhase_redBlueSwap_image_( NObjective.RuntimeObject recovery, uint pattern, System.IntPtr clipLevels, NObjective.RuntimeObject redPhase, NObjective.RuntimeObject greenPhase, NObjective.RuntimeObject bluePhase, char redBlueSwap, System.IntPtr image ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.highlightRecovery_pattern_clipLevels_redPhase_greenPhase_bluePhase_redBlueSwap_image_( Handle, CachedSelectors.highlightRecovery_pattern_clipLevels_redPhase_greenPhase_bluePhase_redBlueSwap_image_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ) + sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( char ) + sizeof( System.IntPtr ), recovery, pattern, clipLevels, redPhase, greenPhase, bluePhase, 
			redBlueSwap, image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject redNoiseReduction_pattern_radius_slope_( NObjective.RuntimeObject reduction, uint pattern, NObjective.RuntimeObject radius, NObjective.RuntimeObject slope ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.redNoiseReduction_pattern_radius_slope_( Handle, CachedSelectors.redNoiseReduction_pattern_radius_slope_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), reduction, pattern, radius, slope );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject redReconstruction_green_phase_image_( NObjective.RuntimeObject reconstruction, NObjective.RuntimeObject green, NObjective.RuntimeObject phase, System.IntPtr image ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.redReconstruction_green_phase_image_( Handle, CachedSelectors.redReconstruction_green_phase_image_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), reconstruction, green, phase, image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject sharpenReconstructedGreenEdges_radius_intensity_edgeIntensity_edgeThreshold_perceptual_blurred_image_( NObjective.RuntimeObject edges, NObjective.RuntimeObject radius, NObjective.RuntimeObject intensity, NObjective.RuntimeObject edgeIntensity, NObjective.RuntimeObject edgeThreshold, System.IntPtr perceptual, System.IntPtr blurred, System.IntPtr image ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sharpenReconstructedGreenEdges_radius_intensity_edgeIntensity_edgeThreshold_perceptual_blurred_image_( Handle, CachedSelectors.sharpenReconstructedGreenEdges_radius_intensity_edgeIntensity_edgeThreshold_perceptual_blurred_image_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( System.IntPtr ) + sizeof( System.IntPtr ), edges, radius, intensity, edgeIntensity, edgeThreshold, perceptual, 
			blurred, image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject standardCrop_original_( NObjective.RuntimeObject crop, NObjective.RuntimeObject original ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.standardCrop_original_( Handle, CachedSelectors.standardCrop_original_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), crop, original );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject stuckPixelElimination_threshold_phase_( NObjective.RuntimeObject elimination, NObjective.RuntimeObject threshold, NObjective.RuntimeObject phase ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.stuckPixelElimination_threshold_phase_( Handle, CachedSelectors.stuckPixelElimination_threshold_phase_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), elimination, threshold, phase );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr blackSubtractAndPremultiply_pattern_factors_blackLevels_image_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject premultiply, uint pattern, System.IntPtr factors, NObjective.RuntimeObject blackLevels, System.IntPtr image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr blueReconstruction_green_phase_image_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject reconstruction, NObjective.RuntimeObject green, NObjective.RuntimeObject phase, System.IntPtr image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr blurHalfSizeImage_radius_image_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject image, NObjective.RuntimeObject radius, System.IntPtr image2 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr greenReconstruction_edges_phase_scale1_scale2_decisions_votedDecisions_image_decisionImage_votingImage_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject reconstruction, NObjective.RuntimeObject edges, NObjective.RuntimeObject phase, NObjective.RuntimeObject scale1, NObjective.RuntimeObject scale2, System.IntPtr decisions, 
			System.IntPtr votedDecisions, System.IntPtr image, System.IntPtr decisionImage, System.IntPtr votingImage );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr halfSizePicture_pattern_image_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject picture, uint pattern, System.IntPtr image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr halfSizePictureEdges_scale_image_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject edges, NObjective.RuntimeObject scale, System.IntPtr image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr highlightRecovery_pattern_clipLevels_redPhase_greenPhase_bluePhase_redBlueSwap_image_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject recovery, uint pattern, System.IntPtr clipLevels, NObjective.RuntimeObject redPhase, NObjective.RuntimeObject greenPhase, NObjective.RuntimeObject bluePhase, 
			char redBlueSwap, System.IntPtr image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr redNoiseReduction_pattern_radius_slope_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject reduction, uint pattern, NObjective.RuntimeObject radius, NObjective.RuntimeObject slope );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr redReconstruction_green_phase_image_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject reconstruction, NObjective.RuntimeObject green, NObjective.RuntimeObject phase, System.IntPtr image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr sharpenReconstructedGreenEdges_radius_intensity_edgeIntensity_edgeThreshold_perceptual_blurred_image_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject edges, NObjective.RuntimeObject radius, NObjective.RuntimeObject intensity, NObjective.RuntimeObject edgeIntensity, NObjective.RuntimeObject edgeThreshold, System.IntPtr perceptual, 
			System.IntPtr blurred, System.IntPtr image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr standardCrop_original_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject crop, NObjective.RuntimeObject original );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr stuckPixelElimination_threshold_phase_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject elimination, NObjective.RuntimeObject threshold, NObjective.RuntimeObject phase );
		}
		static internal class CachedSelectors {
			public static readonly Selector blackSubtractAndPremultiply_pattern_factors_blackLevels_image_ = "blackSubtractAndPremultiply:pattern:factors:blackLevels:image:";
			public static readonly Selector blueReconstruction_green_phase_image_ = "blueReconstruction:green:phase:image:";
			public static readonly Selector blurHalfSizeImage_radius_image_ = "blurHalfSizeImage:radius:image:";
			public static readonly Selector greenReconstruction_edges_phase_scale1_scale2_decisions_votedDecisions_image_decisionImage_votingImage_ = "greenReconstruction:edges:phase:scale1:scale2:decisions:votedDecisions:image:decisionImage:votingImage:";
			public static readonly Selector halfSizePicture_pattern_image_ = "halfSizePicture:pattern:image:";
			public static readonly Selector halfSizePictureEdges_scale_image_ = "halfSizePictureEdges:scale:image:";
			public static readonly Selector highlightRecovery_pattern_clipLevels_redPhase_greenPhase_bluePhase_redBlueSwap_image_ = "highlightRecovery:pattern:clipLevels:redPhase:greenPhase:bluePhase:redBlueSwap:image:";
			public static readonly Selector outputImage = "outputImage";
			public static readonly Selector redNoiseReduction_pattern_radius_slope_ = "redNoiseReduction:pattern:radius:slope:";
			public static readonly Selector redReconstruction_green_phase_image_ = "redReconstruction:green:phase:image:";
			public static readonly Selector sharpenReconstructedGreenEdges_radius_intensity_edgeIntensity_edgeThreshold_perceptual_blurred_image_ = "sharpenReconstructedGreenEdges:radius:intensity:edgeIntensity:edgeThreshold:perceptual:blurred:image:";
			public static readonly Selector standardCrop_original_ = "standardCrop:original:";
			public static readonly Selector stuckPixelElimination_threshold_phase_ = "stuckPixelElimination:threshold:phase:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIBehindBlendMode : IEquatable<CIBehindBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIBehindBlendMode;
		public static implicit operator CIFilter( CIBehindBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIBehindBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIBehindBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIBehindBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIBehindBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIBehindBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIBehindBlendMode value1, CIBehindBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIBehindBlendMode value1, CIBehindBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIBehindBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIBehindBlendMode alloc() {
			return new CIBehindBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CISampleAreaOperation ) )]
	public struct CIBilateralConvolution : IEquatable<CIBilateralConvolution> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIBilateralConvolution;
		public static implicit operator CISampleAreaOperation( CIBilateralConvolution value ) {
			return new CISampleAreaOperation( value.Handle );
		}
		public static implicit operator CIFilter( CIBilateralConvolution value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIBilateralConvolution value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIBilateralConvolution value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIBilateralConvolution value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIBilateralConvolution?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIBilateralConvolution value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIBilateralConvolution value1, CIBilateralConvolution value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIBilateralConvolution value1, CIBilateralConvolution value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIBilateralConvolution( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIBilateralConvolution alloc() {
			return new CIBilateralConvolution( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject doBilateralPass_points_weights_sums_slope_( NObjective.RuntimeObject pass, NObjective.RuntimeObject points, NObjective.RuntimeObject weights, NObjective.RuntimeObject sums, NObjective.RuntimeObject slope ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.doBilateralPass_points_weights_sums_slope_( Handle, CachedSelectors.doBilateralPass_points_weights_sums_slope_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), pass, points, weights, sums, slope );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr doBilateralPass_points_weights_sums_slope_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject pass, NObjective.RuntimeObject points, NObjective.RuntimeObject weights, NObjective.RuntimeObject sums, NObjective.RuntimeObject slope );
		}
		static internal class CachedSelectors {
			public static readonly Selector doBilateralPass_points_weights_sums_slope_ = "doBilateralPass:points:weights:sums:slope:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIBilateralFilter : IEquatable<CIBilateralFilter> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIBilateralFilter;
		public static implicit operator CIFilter( CIBilateralFilter value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIBilateralFilter value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIBilateralFilter value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIBilateralFilter value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIBilateralFilter?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIBilateralFilter value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIBilateralFilter value1, CIBilateralFilter value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIBilateralFilter value1, CIBilateralFilter value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIBilateralFilter( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIBilateralFilter alloc() {
			return new CIBilateralFilter( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIContext ) )]
	public struct CIBitmapContext : IEquatable<CIBitmapContext> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIBitmapContext;
		public static implicit operator CIContext( CIBitmapContext value ) {
			return new CIContext( value.Handle );
		}
		public static implicit operator NSObject( CIBitmapContext value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIBitmapContext value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIBitmapContext value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIBitmapContext?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIBitmapContext value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIBitmapContext value1, CIBitmapContext value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIBitmapContext value1, CIBitmapContext value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIBitmapContext( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIBitmapContext alloc() {
			return new CIBitmapContext( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject initWithOptions_( NObjective.RuntimeObject options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithOptions_( Handle, CachedSelectors.initWithOptions_, out ___occuredException, sizeof( NObjective.RuntimeObject ), options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithOptions_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject options );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithOptions_ = "initWithOptions:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIContextImpl ) )]
	public struct CIBitmapContextImpl : IEquatable<CIBitmapContextImpl> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIBitmapContextImpl;
		public static implicit operator CIContextImpl( CIBitmapContextImpl value ) {
			return new CIContextImpl( value.Handle );
		}
		public static implicit operator NSObject( CIBitmapContextImpl value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIBitmapContextImpl value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIBitmapContextImpl value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIBitmapContextImpl?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIBitmapContextImpl value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIBitmapContextImpl value1, CIBitmapContextImpl value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIBitmapContextImpl value1, CIBitmapContextImpl value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIBitmapContextImpl( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIBitmapContextImpl alloc() {
			return new CIBitmapContextImpl( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIBlendWithMask : IEquatable<CIBlendWithMask> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIBlendWithMask;
		public static implicit operator CIFilter( CIBlendWithMask value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIBlendWithMask value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIBlendWithMask value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIBlendWithMask value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIBlendWithMask?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIBlendWithMask value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIBlendWithMask value1, CIBlendWithMask value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIBlendWithMask value1, CIBlendWithMask value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIBlendWithMask( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIBlendWithMask alloc() {
			return new CIBlendWithMask( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIBloom : IEquatable<CIBloom> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIBloom;
		public static implicit operator CIFilter( CIBloom value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIBloom value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIBloom value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIBloom value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIBloom?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIBloom value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIBloom value1, CIBloom value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIBloom value1, CIBloom value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIBloom( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIBloom alloc() {
			return new CIBloom( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIBumpDistortion : IEquatable<CIBumpDistortion> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIBumpDistortion;
		public static implicit operator CIFilter( CIBumpDistortion value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIBumpDistortion value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIBumpDistortion value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIBumpDistortion value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIBumpDistortion?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIBumpDistortion value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIBumpDistortion value1, CIBumpDistortion value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIBumpDistortion value1, CIBumpDistortion value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIBumpDistortion( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIBumpDistortion alloc() {
			return new CIBumpDistortion( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIContext ) )]
	public struct CICGContext : IEquatable<CICGContext> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CICGContext;
		public static implicit operator CIContext( CICGContext value ) {
			return new CIContext( value.Handle );
		}
		public static implicit operator NSObject( CICGContext value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CICGContext value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CICGContext value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CICGContext?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CICGContext value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CICGContext value1, CICGContext value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CICGContext value1, CICGContext value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CICGContext( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CICGContext alloc() {
			return new CICGContext( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject initWithOptions_( NObjective.RuntimeObject options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithOptions_( Handle, CachedSelectors.initWithOptions_, out ___occuredException, sizeof( NObjective.RuntimeObject ), options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithOptions_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject options );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithOptions_ = "initWithOptions:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIContextImpl ) )]
	public struct CICGContextImpl : IEquatable<CICGContextImpl> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CICGContextImpl;
		public static implicit operator CIContextImpl( CICGContextImpl value ) {
			return new CIContextImpl( value.Handle );
		}
		public static implicit operator NSObject( CICGContextImpl value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CICGContextImpl value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CICGContextImpl value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CICGContextImpl?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CICGContextImpl value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CICGContextImpl value1, CICGContextImpl value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CICGContextImpl value1, CICGContextImpl value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CICGContextImpl( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CICGContextImpl alloc() {
			return new CICGContextImpl( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct CICGSFilter : IEquatable<CICGSFilter> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CICGSFilter;
		public static implicit operator NSObject( CICGSFilter value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CICGSFilter value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CICGSFilter value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CICGSFilter?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CICGSFilter value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CICGSFilter value1, CICGSFilter value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CICGSFilter value1, CICGSFilter value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CICGSFilter( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CICGSFilter alloc() {
			return new CICGSFilter( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject filterWithFilter_connectionID_( NObjective.RuntimeObject filter, System.IntPtr connectionID ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.filterWithFilter_connectionID_( ClassHandle, CachedSelectors.filterWithFilter_connectionID_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), filter, connectionID );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public int addToWindow_flags_( System.IntPtr window, uint flags ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.addToWindow_flags_( Handle, CachedSelectors.addToWindow_flags_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( uint ), window, flags );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject initWithFilter_connectionID_( NObjective.RuntimeObject filter, System.IntPtr connectionID ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithFilter_connectionID_( Handle, CachedSelectors.initWithFilter_connectionID_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), filter, connectionID );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public int removeFromWindow_( System.IntPtr window ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.removeFromWindow_( Handle, CachedSelectors.removeFromWindow_, out ___occuredException, sizeof( System.IntPtr ), window );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int addToWindow_flags_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr window, uint flags );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr filterWithFilter_connectionID_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject filter, System.IntPtr connectionID );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithFilter_connectionID_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject filter, System.IntPtr connectionID );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int removeFromWindow_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr window );
		}
		static internal class CachedSelectors {
			public static readonly Selector addToWindow_flags_ = "addToWindow:flags:";
			public static readonly Selector filterWithFilter_connectionID_ = "filterWithFilter:connectionID:";
			public static readonly Selector initWithFilter_connectionID_ = "initWithFilter:connectionID:";
			public static readonly Selector removeFromWindow_ = "removeFromWindow:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CICheapBlur : IEquatable<CICheapBlur> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CICheapBlur;
		public static implicit operator CIFilter( CICheapBlur value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CICheapBlur value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CICheapBlur value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CICheapBlur value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CICheapBlur?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CICheapBlur value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CICheapBlur value1, CICheapBlur value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CICheapBlur value1, CICheapBlur value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CICheapBlur( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CICheapBlur alloc() {
			return new CICheapBlur( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CICheckerboardGenerator : IEquatable<CICheckerboardGenerator> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CICheckerboardGenerator;
		public static implicit operator CIFilter( CICheckerboardGenerator value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CICheckerboardGenerator value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CICheckerboardGenerator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CICheckerboardGenerator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CICheckerboardGenerator?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CICheckerboardGenerator value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CICheckerboardGenerator value1, CICheckerboardGenerator value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CICheckerboardGenerator value1, CICheckerboardGenerator value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CICheckerboardGenerator( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CICheckerboardGenerator alloc() {
			return new CICheckerboardGenerator( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIChopLines : IEquatable<CIChopLines> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIChopLines;
		public static implicit operator CIFilter( CIChopLines value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIChopLines value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIChopLines value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIChopLines value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIChopLines?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIChopLines value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIChopLines value1, CIChopLines value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIChopLines value1, CIChopLines value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIChopLines( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIChopLines alloc() {
			return new CIChopLines( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CICircleSplashDistortion : IEquatable<CICircleSplashDistortion> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CICircleSplashDistortion;
		public static implicit operator CIFilter( CICircleSplashDistortion value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CICircleSplashDistortion value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CICircleSplashDistortion value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CICircleSplashDistortion value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CICircleSplashDistortion?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CICircleSplashDistortion value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CICircleSplashDistortion value1, CICircleSplashDistortion value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CICircleSplashDistortion value1, CICircleSplashDistortion value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CICircleSplashDistortion( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CICircleSplashDistortion alloc() {
			return new CICircleSplashDistortion( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CICircularScreen : IEquatable<CICircularScreen> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CICircularScreen;
		public static implicit operator CIFilter( CICircularScreen value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CICircularScreen value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CICircularScreen value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CICircularScreen value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CICircularScreen?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CICircularScreen value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CICircularScreen value1, CICircularScreen value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CICircularScreen value1, CICircularScreen value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CICircularScreen( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CICircularScreen alloc() {
			return new CICircularScreen( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CICircularWrap : IEquatable<CICircularWrap> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CICircularWrap;
		public static implicit operator CIFilter( CICircularWrap value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CICircularWrap value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CICircularWrap value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CICircularWrap value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CICircularWrap?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CICircularWrap value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CICircularWrap value1, CICircularWrap value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CICircularWrap value1, CICircularWrap value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CICircularWrap( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CICircularWrap alloc() {
			return new CICircularWrap( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CICMYKHalftone : IEquatable<CICMYKHalftone> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CICMYKHalftone;
		public static implicit operator CIFilter( CICMYKHalftone value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CICMYKHalftone value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CICMYKHalftone value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CICMYKHalftone value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CICMYKHalftone?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CICMYKHalftone value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CICMYKHalftone value1, CICMYKHalftone value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CICMYKHalftone value1, CICMYKHalftone value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CICMYKHalftone( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CICMYKHalftone alloc() {
			return new CICMYKHalftone( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct CIColor : IEquatable<CIColor> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIColor;
		public static implicit operator NSObject( CIColor value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIColor value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIColor value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIColor?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIColor value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIColor value1, CIColor value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIColor value1, CIColor value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIColor( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIColor alloc() {
			return new CIColor( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static CIColor colorWithCGColor_( IntPtr color ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.colorWithCGColor_( ClassHandle, CachedSelectors.colorWithCGColor_, out ___occuredException, sizeof( IntPtr ), color );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIColor( ___result );
		}
		unsafe public static CIColor colorWithRed_green_blue_( float red, float green, float blue ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.colorWithRed_green_blue_( ClassHandle, CachedSelectors.colorWithRed_green_blue_, out ___occuredException, sizeof( float ) + sizeof( float ) + sizeof( float ), red, green, blue );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIColor( ___result );
		}
		unsafe public static CIColor colorWithRed_green_blue_alpha_( float red, float green, float blue, float alpha ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.colorWithRed_green_blue_alpha_( ClassHandle, CachedSelectors.colorWithRed_green_blue_alpha_, out ___occuredException, sizeof( float ) + sizeof( float ) + sizeof( float ) + sizeof( float ), red, green, blue, alpha );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIColor( ___result );
		}
		unsafe public static CIColor colorWithString_( string @string ) {
			RuntimeObject ___occuredException;
			var ___wrappedstring = Runtime.CreateStringProxy( @string );
			var ___result = NativeMethods.colorWithString_( ClassHandle, CachedSelectors.colorWithString_, out ___occuredException, sizeof( IntPtr ), ___wrappedstring );
			Runtime.ReleaseNativeObject( ___wrappedstring );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIColor( ___result );
		}
		unsafe public float alpha() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.alpha( Handle, CachedSelectors.alpha, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public float blue() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.blue( Handle, CachedSelectors.blue, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public IntPtr components() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.components( Handle, CachedSelectors.components, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void convertToRGBA_( System.IntPtr rgba ) {
			RuntimeObject ___occuredException;
			NativeMethods.convertToRGBA_( Handle, CachedSelectors.convertToRGBA_, out ___occuredException, sizeof( System.IntPtr ), rgba );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void encodeWithCoder_( NSCoder coder ) {
			RuntimeObject ___occuredException;
			NativeMethods.encodeWithCoder_( Handle, CachedSelectors.encodeWithCoder_, out ___occuredException, sizeof( NSCoder ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public float green() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.green( Handle, CachedSelectors.green, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject initWithCGColor_( IntPtr color ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCGColor_( Handle, CachedSelectors.initWithCGColor_, out ___occuredException, sizeof( IntPtr ), color );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithCoder_( NObjective.RuntimeObject coder ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCoder_( Handle, CachedSelectors.initWithCoder_, out ___occuredException, sizeof( NObjective.RuntimeObject ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithRed_green_blue_alpha_( float red, float green, float blue, float alpha ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithRed_green_blue_alpha_( Handle, CachedSelectors.initWithRed_green_blue_alpha_, out ___occuredException, sizeof( float ) + sizeof( float ) + sizeof( float ) + sizeof( float ), red, green, blue, alpha );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithString_( NObjective.RuntimeObject @string ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithString_( Handle, CachedSelectors.initWithString_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @string );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public uint numberOfComponents() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.numberOfComponents( Handle, CachedSelectors.numberOfComponents, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public float red() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.red( Handle, CachedSelectors.red, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public string stringRepresentation() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.stringRepresentation( Handle, CachedSelectors.stringRepresentation, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern float alpha( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern float blue( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr colorWithCGColor_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr color );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr colorWithRed_green_blue_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, float red, float green, float blue );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr colorWithRed_green_blue_alpha_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, float red, float green, float blue, float alpha );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr colorWithString_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr @string );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern System.IntPtr components( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void convertToRGBA_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr rgba );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void encodeWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSCoder coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern float green( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCGColor_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr color );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithRed_green_blue_alpha_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, float red, float green, float blue, float alpha );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithString_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @string );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint numberOfComponents( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern float red( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr stringRepresentation( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector alpha = "alpha";
			public static readonly Selector blue = "blue";
			public static readonly Selector colorWithCGColor_ = "colorWithCGColor:";
			public static readonly Selector colorWithRed_green_blue_ = "colorWithRed:green:blue:";
			public static readonly Selector colorWithRed_green_blue_alpha_ = "colorWithRed:green:blue:alpha:";
			public static readonly Selector colorWithString_ = "colorWithString:";
			public static readonly Selector components = "components";
			public static readonly Selector convertToRGBA_ = "convertToRGBA:";
			public static readonly Selector encodeWithCoder_ = "encodeWithCoder:";
			public static readonly Selector green = "green";
			public static readonly Selector initWithCGColor_ = "initWithCGColor:";
			public static readonly Selector initWithCoder_ = "initWithCoder:";
			public static readonly Selector initWithRed_green_blue_alpha_ = "initWithRed:green:blue:alpha:";
			public static readonly Selector initWithString_ = "initWithString:";
			public static readonly Selector numberOfComponents = "numberOfComponents";
			public static readonly Selector red = "red";
			public static readonly Selector stringRepresentation = "stringRepresentation";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIColorBlendMode : IEquatable<CIColorBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIColorBlendMode;
		public static implicit operator CIFilter( CIColorBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIColorBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIColorBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIColorBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIColorBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIColorBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIColorBlendMode value1, CIColorBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIColorBlendMode value1, CIColorBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIColorBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIColorBlendMode alloc() {
			return new CIColorBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIColorBurnBlendMode : IEquatable<CIColorBurnBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIColorBurnBlendMode;
		public static implicit operator CIFilter( CIColorBurnBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIColorBurnBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIColorBurnBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIColorBurnBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIColorBurnBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIColorBurnBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIColorBurnBlendMode value1, CIColorBurnBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIColorBurnBlendMode value1, CIColorBurnBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIColorBurnBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIColorBurnBlendMode alloc() {
			return new CIColorBurnBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIColorControls : IEquatable<CIColorControls> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIColorControls;
		public static implicit operator CIFilter( CIColorControls value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIColorControls value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIColorControls value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIColorControls value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIColorControls?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIColorControls value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIColorControls value1, CIColorControls value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIColorControls value1, CIColorControls value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIColorControls( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIColorControls alloc() {
			return new CIColorControls( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIColorCube : IEquatable<CIColorCube> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIColorCube;
		public static implicit operator CIFilter( CIColorCube value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIColorCube value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIColorCube value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIColorCube value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIColorCube?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIColorCube value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIColorCube value1, CIColorCube value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIColorCube value1, CIColorCube value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIColorCube( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIColorCube alloc() {
			return new CIColorCube( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject cubeImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.cubeImage( Handle, CachedSelectors.cubeImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr cubeImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector cubeImage = "cubeImage";
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIColorDodgeBlendMode : IEquatable<CIColorDodgeBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIColorDodgeBlendMode;
		public static implicit operator CIFilter( CIColorDodgeBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIColorDodgeBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIColorDodgeBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIColorDodgeBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIColorDodgeBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIColorDodgeBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIColorDodgeBlendMode value1, CIColorDodgeBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIColorDodgeBlendMode value1, CIColorDodgeBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIColorDodgeBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIColorDodgeBlendMode alloc() {
			return new CIColorDodgeBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIColorInvert : IEquatable<CIColorInvert> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIColorInvert;
		public static implicit operator CIFilter( CIColorInvert value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIColorInvert value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIColorInvert value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIColorInvert value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIColorInvert?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIColorInvert value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIColorInvert value1, CIColorInvert value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIColorInvert value1, CIColorInvert value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIColorInvert( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIColorInvert alloc() {
			return new CIColorInvert( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIColorMap : IEquatable<CIColorMap> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIColorMap;
		public static implicit operator CIFilter( CIColorMap value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIColorMap value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIColorMap value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIColorMap value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIColorMap?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIColorMap value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIColorMap value1, CIColorMap value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIColorMap value1, CIColorMap value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIColorMap( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIColorMap alloc() {
			return new CIColorMap( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIColorMatrix : IEquatable<CIColorMatrix> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIColorMatrix;
		public static implicit operator CIFilter( CIColorMatrix value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIColorMatrix value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIColorMatrix value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIColorMatrix value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIColorMatrix?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIColorMatrix value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIColorMatrix value1, CIColorMatrix value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIColorMatrix value1, CIColorMatrix value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIColorMatrix( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIColorMatrix alloc() {
			return new CIColorMatrix( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIColorMonochrome : IEquatable<CIColorMonochrome> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIColorMonochrome;
		public static implicit operator CIFilter( CIColorMonochrome value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIColorMonochrome value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIColorMonochrome value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIColorMonochrome value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIColorMonochrome?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIColorMonochrome value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIColorMonochrome value1, CIColorMonochrome value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIColorMonochrome value1, CIColorMonochrome value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIColorMonochrome( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIColorMonochrome alloc() {
			return new CIColorMonochrome( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIColorPosterize : IEquatable<CIColorPosterize> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIColorPosterize;
		public static implicit operator CIFilter( CIColorPosterize value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIColorPosterize value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIColorPosterize value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIColorPosterize value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIColorPosterize?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIColorPosterize value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIColorPosterize value1, CIColorPosterize value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIColorPosterize value1, CIColorPosterize value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIColorPosterize( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIColorPosterize alloc() {
			return new CIColorPosterize( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIColorWheelGenerator : IEquatable<CIColorWheelGenerator> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIColorWheelGenerator;
		public static implicit operator CIFilter( CIColorWheelGenerator value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIColorWheelGenerator value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIColorWheelGenerator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIColorWheelGenerator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIColorWheelGenerator?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIColorWheelGenerator value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIColorWheelGenerator value1, CIColorWheelGenerator value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIColorWheelGenerator value1, CIColorWheelGenerator value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIColorWheelGenerator( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIColorWheelGenerator alloc() {
			return new CIColorWheelGenerator( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIImage ) )]
	public struct CIConcreteImage : IEquatable<CIConcreteImage> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIConcreteImage;
		public static implicit operator CIImage( CIConcreteImage value ) {
			return new CIImage( value.Handle );
		}
		public static implicit operator NSObject( CIConcreteImage value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIConcreteImage value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIConcreteImage value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIConcreteImage?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIConcreteImage value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIConcreteImage value1, CIConcreteImage value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIConcreteImage value1, CIConcreteImage value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIConcreteImage( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIConcreteImage alloc() {
			return new CIConcreteImage( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIKernel ) )]
	public struct CIConcreteKernel : IEquatable<CIConcreteKernel> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIConcreteKernel;
		public static implicit operator CIKernel( CIConcreteKernel value ) {
			return new CIKernel( value.Handle );
		}
		public static implicit operator NSObject( CIConcreteKernel value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIConcreteKernel value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIConcreteKernel value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIConcreteKernel?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIConcreteKernel value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIConcreteKernel value1, CIConcreteKernel value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIConcreteKernel value1, CIConcreteKernel value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIConcreteKernel( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIConcreteKernel alloc() {
			return new CIConcreteKernel( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIPromise ) )]
	public struct CIConcretePromise : IEquatable<CIConcretePromise> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIConcretePromise;
		public static implicit operator CIPromise( CIConcretePromise value ) {
			return new CIPromise( value.Handle );
		}
		public static implicit operator CIImage( CIConcretePromise value ) {
			return new CIImage( value.Handle );
		}
		public static implicit operator NSObject( CIConcretePromise value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIConcretePromise value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIConcretePromise value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIConcretePromise?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIConcretePromise value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIConcretePromise value1, CIConcretePromise value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIConcretePromise value1, CIConcretePromise value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIConcretePromise( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIConcretePromise alloc() {
			return new CIConcretePromise( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CISampler ) )]
	public struct CIConcreteSampler : IEquatable<CIConcreteSampler> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIConcreteSampler;
		public static implicit operator CISampler( CIConcreteSampler value ) {
			return new CISampler( value.Handle );
		}
		public static implicit operator NSObject( CIConcreteSampler value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIConcreteSampler value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIConcreteSampler value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIConcreteSampler?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIConcreteSampler value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIConcreteSampler value1, CIConcreteSampler value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIConcreteSampler value1, CIConcreteSampler value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIConcreteSampler( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIConcreteSampler alloc() {
			return new CIConcreteSampler( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIConstantColorGenerator : IEquatable<CIConstantColorGenerator> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIConstantColorGenerator;
		public static implicit operator CIFilter( CIConstantColorGenerator value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIConstantColorGenerator value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIConstantColorGenerator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIConstantColorGenerator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIConstantColorGenerator?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIConstantColorGenerator value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIConstantColorGenerator value1, CIConstantColorGenerator value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIConstantColorGenerator value1, CIConstantColorGenerator value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIConstantColorGenerator( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIConstantColorGenerator alloc() {
			return new CIConstantColorGenerator( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct CIContext : IEquatable<CIContext> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIContext;
		public static implicit operator NSObject( CIContext value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIContext value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIContext value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIContext?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIContext value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIContext value1, CIContext value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIContext value1, CIContext value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIContext( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIContext alloc() {
			return new CIContext( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject context() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.context( ClassHandle, CachedSelectors.context, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static CIContext contextWithCGContext_options_( IntPtr context, NSDictionary options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.contextWithCGContext_options_( ClassHandle, CachedSelectors.contextWithCGContext_options_, out ___occuredException, sizeof( IntPtr ) + sizeof( NSDictionary ), context, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIContext( ___result );
		}
		unsafe public static CIContext contextWithCGLContext_pixelFormat_options_( IntPtr context, IntPtr pixelFormat, NSDictionary options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.contextWithCGLContext_pixelFormat_options_( ClassHandle, CachedSelectors.contextWithCGLContext_pixelFormat_options_, out ___occuredException, sizeof( IntPtr ) + sizeof( IntPtr ) + sizeof( NSDictionary ), context, pixelFormat, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIContext( ___result );
		}
		unsafe public static NObjective.RuntimeObject contextWithOptions_( NObjective.RuntimeObject options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.contextWithOptions_( ClassHandle, CachedSelectors.contextWithOptions_, out ___occuredException, sizeof( NObjective.RuntimeObject ), options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static uint currentVersion() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.currentVersion( ClassHandle, CachedSelectors.currentVersion, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public void abort() {
			RuntimeObject ___occuredException;
			NativeMethods.abort( Handle, CachedSelectors.abort, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void clearCaches() {
			RuntimeObject ___occuredException;
			NativeMethods.clearCaches( Handle, CachedSelectors.clearCaches, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void drawImage_atPoint_fromRect_( CIImage image, CGPoint atPoint, CGRect fromRect ) {
			RuntimeObject ___occuredException;
			NativeMethods.drawImage_atPoint_fromRect_( Handle, CachedSelectors.drawImage_atPoint_fromRect_, out ___occuredException, sizeof( CIImage ) + sizeof( CGPoint ) + sizeof( CGRect ), image, atPoint, fromRect );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void drawImage_inRect_fromRect_( CIImage image, CGRect inRect, CGRect fromRect ) {
			RuntimeObject ___occuredException;
			NativeMethods.drawImage_inRect_fromRect_( Handle, CachedSelectors.drawImage_inRect_fromRect_, out ___occuredException, sizeof( CIImage ) + sizeof( CGRect ) + sizeof( CGRect ), image, inRect, fromRect );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void invalidate() {
			RuntimeObject ___occuredException;
			NativeMethods.invalidate( Handle, CachedSelectors.invalidate, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject objectForKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectForKey_( Handle, CachedSelectors.objectForKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public uint passes() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.passes( Handle, CachedSelectors.passes, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public float progress() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.progress( Handle, CachedSelectors.progress, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void reclaimResources() {
			RuntimeObject ___occuredException;
			NativeMethods.reclaimResources( Handle, CachedSelectors.reclaimResources, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void releaseAllResources() {
			RuntimeObject ___occuredException;
			NativeMethods.releaseAllResources( Handle, CachedSelectors.releaseAllResources, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void render_( NObjective.RuntimeObject render ) {
			RuntimeObject ___occuredException;
			NativeMethods.render_( Handle, CachedSelectors.render_, out ___occuredException, sizeof( NObjective.RuntimeObject ), render );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setObject_forKey_( NObjective.RuntimeObject @object, NObjective.RuntimeObject forKey ) {
			RuntimeObject ___occuredException;
			NativeMethods.setObject_forKey_( Handle, CachedSelectors.setObject_forKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), @object, forKey );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setUserInfo_( NObjective.RuntimeObject info ) {
			RuntimeObject ___occuredException;
			NativeMethods.setUserInfo_( Handle, CachedSelectors.setUserInfo_, out ___occuredException, sizeof( NObjective.RuntimeObject ), info );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public bool testImage_( NObjective.RuntimeObject image ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.testImage_( Handle, CachedSelectors.testImage_, out ___occuredException, sizeof( NObjective.RuntimeObject ), image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject userInfo() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.userInfo( Handle, CachedSelectors.userInfo, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void waitImage_( NObjective.RuntimeObject image ) {
			RuntimeObject ___occuredException;
			NativeMethods.waitImage_( Handle, CachedSelectors.waitImage_, out ___occuredException, sizeof( NObjective.RuntimeObject ), image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void abort( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void clearCaches( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr context( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr contextWithCGContext_options_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr context, NSDictionary options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr contextWithCGLContext_pixelFormat_options_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr context, IntPtr pixelFormat, NSDictionary options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr contextWithOptions_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint currentVersion( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void drawImage_atPoint_fromRect_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, CIImage image, CGPoint atPoint, CGRect fromRect );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void drawImage_inRect_fromRect_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, CIImage image, CGRect inRect, CGRect fromRect );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void invalidate( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr objectForKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint passes( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern float progress( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void reclaimResources( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void releaseAllResources( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void render_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject render );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setObject_forKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, NObjective.RuntimeObject forKey );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setUserInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject info );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool testImage_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr userInfo( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void waitImage_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject image );
		}
		static internal class CachedSelectors {
			public static readonly Selector abort = "abort";
			public static readonly Selector clearCaches = "clearCaches";
			public static readonly Selector context = "context";
			public static readonly Selector contextWithCGContext_options_ = "contextWithCGContext:options:";
			public static readonly Selector contextWithCGLContext_pixelFormat_options_ = "contextWithCGLContext:pixelFormat:options:";
			public static readonly Selector contextWithOptions_ = "contextWithOptions:";
			public static readonly Selector currentVersion = "currentVersion";
			public static readonly Selector drawImage_atPoint_fromRect_ = "drawImage:atPoint:fromRect:";
			public static readonly Selector drawImage_inRect_fromRect_ = "drawImage:inRect:fromRect:";
			public static readonly Selector invalidate = "invalidate";
			public static readonly Selector objectForKey_ = "objectForKey:";
			public static readonly Selector passes = "passes";
			public static readonly Selector progress = "progress";
			public static readonly Selector reclaimResources = "reclaimResources";
			public static readonly Selector releaseAllResources = "releaseAllResources";
			public static readonly Selector render_ = "render:";
			public static readonly Selector setObject_forKey_ = "setObject:forKey:";
			public static readonly Selector setUserInfo_ = "setUserInfo:";
			public static readonly Selector testImage_ = "testImage:";
			public static readonly Selector userInfo = "userInfo";
			public static readonly Selector waitImage_ = "waitImage:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct CIContextImpl : IEquatable<CIContextImpl> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIContextImpl;
		public static implicit operator NSObject( CIContextImpl value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIContextImpl value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIContextImpl value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIContextImpl?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIContextImpl value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIContextImpl value1, CIContextImpl value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIContextImpl value1, CIContextImpl value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIContextImpl( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIContextImpl alloc() {
			return new CIContextImpl( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void abort() {
			RuntimeObject ___occuredException;
			NativeMethods.abort( Handle, CachedSelectors.abort, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void collect_( char collect ) {
			RuntimeObject ___occuredException;
			NativeMethods.collect_( Handle, CachedSelectors.collect_, out ___occuredException, sizeof( char ), collect );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject initWithOptions_( NObjective.RuntimeObject options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithOptions_( Handle, CachedSelectors.initWithOptions_, out ___occuredException, sizeof( NObjective.RuntimeObject ), options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject objectForKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectForKey_( Handle, CachedSelectors.objectForKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject optionsDictionary() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.optionsDictionary( Handle, CachedSelectors.optionsDictionary, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject owner() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.owner( Handle, CachedSelectors.owner, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public uint passes() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.passes( Handle, CachedSelectors.passes, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public float progress() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.progress( Handle, CachedSelectors.progress, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void render_( NObjective.RuntimeObject render ) {
			RuntimeObject ___occuredException;
			NativeMethods.render_( Handle, CachedSelectors.render_, out ___occuredException, sizeof( NObjective.RuntimeObject ), render );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setObject_forKey_( NObjective.RuntimeObject @object, NObjective.RuntimeObject forKey ) {
			RuntimeObject ___occuredException;
			NativeMethods.setObject_forKey_( Handle, CachedSelectors.setObject_forKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), @object, forKey );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setOwner_( NObjective.RuntimeObject owner ) {
			RuntimeObject ___occuredException;
			NativeMethods.setOwner_( Handle, CachedSelectors.setOwner_, out ___occuredException, sizeof( NObjective.RuntimeObject ), owner );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setUserInfo_( NObjective.RuntimeObject info ) {
			RuntimeObject ___occuredException;
			NativeMethods.setUserInfo_( Handle, CachedSelectors.setUserInfo_, out ___occuredException, sizeof( NObjective.RuntimeObject ), info );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject userInfo() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.userInfo( Handle, CachedSelectors.userInfo, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void abort( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void collect_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, char collect );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithOptions_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr objectForKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr optionsDictionary( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr owner( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint passes( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern float progress( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void render_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject render );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setObject_forKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @object, NObjective.RuntimeObject forKey );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setOwner_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject owner );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setUserInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject info );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr userInfo( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector abort = "abort";
			public static readonly Selector collect_ = "collect:";
			public static readonly Selector initWithOptions_ = "initWithOptions:";
			public static readonly Selector objectForKey_ = "objectForKey:";
			public static readonly Selector optionsDictionary = "optionsDictionary";
			public static readonly Selector owner = "owner";
			public static readonly Selector passes = "passes";
			public static readonly Selector progress = "progress";
			public static readonly Selector render_ = "render:";
			public static readonly Selector setObject_forKey_ = "setObject:forKey:";
			public static readonly Selector setOwner_ = "setOwner:";
			public static readonly Selector setUserInfo_ = "setUserInfo:";
			public static readonly Selector userInfo = "userInfo";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CICopyMachineTransition : IEquatable<CICopyMachineTransition> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CICopyMachineTransition;
		public static implicit operator CIFilter( CICopyMachineTransition value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CICopyMachineTransition value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CICopyMachineTransition value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CICopyMachineTransition value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CICopyMachineTransition?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CICopyMachineTransition value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CICopyMachineTransition value1, CICopyMachineTransition value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CICopyMachineTransition value1, CICopyMachineTransition value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CICopyMachineTransition( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CICopyMachineTransition alloc() {
			return new CICopyMachineTransition( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CICrop : IEquatable<CICrop> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CICrop;
		public static implicit operator CIFilter( CICrop value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CICrop value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CICrop value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CICrop value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CICrop?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CICrop value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CICrop value1, CICrop value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CICrop value1, CICrop value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CICrop( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CICrop alloc() {
			return new CICrop( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CICrystallize : IEquatable<CICrystallize> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CICrystallize;
		public static implicit operator CIFilter( CICrystallize value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CICrystallize value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CICrystallize value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CICrystallize value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CICrystallize?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CICrystallize value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CICrystallize value1, CICrystallize value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CICrystallize value1, CICrystallize value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CICrystallize( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CICrystallize alloc() {
			return new CICrystallize( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct CICVImageProviderDelegate : IEquatable<CICVImageProviderDelegate> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CICVImageProviderDelegate;
		public static implicit operator NSObject( CICVImageProviderDelegate value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CICVImageProviderDelegate value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CICVImageProviderDelegate value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CICVImageProviderDelegate?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CICVImageProviderDelegate value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CICVImageProviderDelegate value1, CICVImageProviderDelegate value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CICVImageProviderDelegate value1, CICVImageProviderDelegate value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CICVImageProviderDelegate( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CICVImageProviderDelegate alloc() {
			return new CICVImageProviderDelegate( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void provideImageData_bytesPerRow_origin__size__userInfo_( System.IntPtr data, uint bytesPerRow, uint origin, uint unnamedParameter, uint size, uint unnamedParameter2, NObjective.RuntimeObject userInfo ) {
			RuntimeObject ___occuredException;
			NativeMethods.provideImageData_bytesPerRow_origin__size__userInfo_( Handle, CachedSelectors.provideImageData_bytesPerRow_origin__size__userInfo_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( uint ) + sizeof( uint ) + sizeof( uint ) + sizeof( uint ) + sizeof( uint ) + sizeof( NObjective.RuntimeObject ), data, bytesPerRow, origin, unnamedParameter, size, unnamedParameter2, 
			userInfo );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void provideImageData_bytesPerRow_origin__size__userInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr data, uint bytesPerRow, uint origin, uint unnamedParameter, uint size, uint unnamedParameter2, 
			NObjective.RuntimeObject userInfo );
		}
		static internal class CachedSelectors {
			public static readonly Selector provideImageData_bytesPerRow_origin__size__userInfo_ = "provideImageData:bytesPerRow:origin::size::userInfo:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIDarkenBlendMode : IEquatable<CIDarkenBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIDarkenBlendMode;
		public static implicit operator CIFilter( CIDarkenBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIDarkenBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIDarkenBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIDarkenBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIDarkenBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIDarkenBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIDarkenBlendMode value1, CIDarkenBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIDarkenBlendMode value1, CIDarkenBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIDarkenBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIDarkenBlendMode alloc() {
			return new CIDarkenBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIDeBayer : IEquatable<CIDeBayer> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIDeBayer;
		public static implicit operator CIFilter( CIDeBayer value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIDeBayer value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIDeBayer value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIDeBayer value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIDeBayer?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIDeBayer value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIDeBayer value1, CIDeBayer value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIDeBayer value1, CIDeBayer value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIDeBayer( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIDeBayer alloc() {
			return new CIDeBayer( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIDesaturateGamutMapping : IEquatable<CIDesaturateGamutMapping> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIDesaturateGamutMapping;
		public static implicit operator CIFilter( CIDesaturateGamutMapping value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIDesaturateGamutMapping value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIDesaturateGamutMapping value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIDesaturateGamutMapping value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIDesaturateGamutMapping?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIDesaturateGamutMapping value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIDesaturateGamutMapping value1, CIDesaturateGamutMapping value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIDesaturateGamutMapping value1, CIDesaturateGamutMapping value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIDesaturateGamutMapping( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIDesaturateGamutMapping alloc() {
			return new CIDesaturateGamutMapping( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIDifferenceBlendMode : IEquatable<CIDifferenceBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIDifferenceBlendMode;
		public static implicit operator CIFilter( CIDifferenceBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIDifferenceBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIDifferenceBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIDifferenceBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIDifferenceBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIDifferenceBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIDifferenceBlendMode value1, CIDifferenceBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIDifferenceBlendMode value1, CIDifferenceBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIDifferenceBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIDifferenceBlendMode alloc() {
			return new CIDifferenceBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIDisintegrateWithMaskTransition : IEquatable<CIDisintegrateWithMaskTransition> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIDisintegrateWithMaskTransition;
		public static implicit operator CIFilter( CIDisintegrateWithMaskTransition value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIDisintegrateWithMaskTransition value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIDisintegrateWithMaskTransition value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIDisintegrateWithMaskTransition value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIDisintegrateWithMaskTransition?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIDisintegrateWithMaskTransition value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIDisintegrateWithMaskTransition value1, CIDisintegrateWithMaskTransition value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIDisintegrateWithMaskTransition value1, CIDisintegrateWithMaskTransition value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIDisintegrateWithMaskTransition( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIDisintegrateWithMaskTransition alloc() {
			return new CIDisintegrateWithMaskTransition( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIDisplacementDistortion : IEquatable<CIDisplacementDistortion> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIDisplacementDistortion;
		public static implicit operator CIFilter( CIDisplacementDistortion value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIDisplacementDistortion value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIDisplacementDistortion value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIDisplacementDistortion value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIDisplacementDistortion?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIDisplacementDistortion value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIDisplacementDistortion value1, CIDisplacementDistortion value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIDisplacementDistortion value1, CIDisplacementDistortion value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIDisplacementDistortion( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIDisplacementDistortion alloc() {
			return new CIDisplacementDistortion( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIDisplaceWithNoise : IEquatable<CIDisplaceWithNoise> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIDisplaceWithNoise;
		public static implicit operator CIFilter( CIDisplaceWithNoise value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIDisplaceWithNoise value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIDisplaceWithNoise value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIDisplaceWithNoise value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIDisplaceWithNoise?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIDisplaceWithNoise value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIDisplaceWithNoise value1, CIDisplaceWithNoise value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIDisplaceWithNoise value1, CIDisplaceWithNoise value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIDisplaceWithNoise( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIDisplaceWithNoise alloc() {
			return new CIDisplaceWithNoise( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIDissolveTransition : IEquatable<CIDissolveTransition> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIDissolveTransition;
		public static implicit operator CIFilter( CIDissolveTransition value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIDissolveTransition value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIDissolveTransition value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIDissolveTransition value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIDissolveTransition?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIDissolveTransition value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIDissolveTransition value1, CIDissolveTransition value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIDissolveTransition value1, CIDissolveTransition value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIDissolveTransition( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIDissolveTransition alloc() {
			return new CIDissolveTransition( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIDistanceFieldFromMask : IEquatable<CIDistanceFieldFromMask> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIDistanceFieldFromMask;
		public static implicit operator CIFilter( CIDistanceFieldFromMask value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIDistanceFieldFromMask value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIDistanceFieldFromMask value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIDistanceFieldFromMask value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIDistanceFieldFromMask?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIDistanceFieldFromMask value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIDistanceFieldFromMask value1, CIDistanceFieldFromMask value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIDistanceFieldFromMask value1, CIDistanceFieldFromMask value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIDistanceFieldFromMask( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIDistanceFieldFromMask alloc() {
			return new CIDistanceFieldFromMask( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIDotScreen : IEquatable<CIDotScreen> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIDotScreen;
		public static implicit operator CIFilter( CIDotScreen value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIDotScreen value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIDotScreen value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIDotScreen value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIDotScreen?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIDotScreen value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIDotScreen value1, CIDotScreen value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIDotScreen value1, CIDotScreen value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIDotScreen( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIDotScreen alloc() {
			return new CIDotScreen( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct CIEdge : IEquatable<CIEdge> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIEdge;
		public static implicit operator NSObject( CIEdge value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIEdge value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIEdge value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIEdge?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIEdge value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIEdge value1, CIEdge value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIEdge value1, CIEdge value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIEdge( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIEdge alloc() {
			return new CIEdge( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject edgeWithSource__dest__( NObjective.RuntimeObject source, NObjective.RuntimeObject unnamedParameter, NObjective.RuntimeObject dest, NObjective.RuntimeObject unnamedParameter2 ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.edgeWithSource__dest__( ClassHandle, CachedSelectors.edgeWithSource__dest__, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), source, unnamedParameter, dest, unnamedParameter2 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject destKey() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.destKey( Handle, CachedSelectors.destKey, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject destNode() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.destNode( Handle, CachedSelectors.destNode, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void encodeWithCoder_( NSCoder coder ) {
			RuntimeObject ___occuredException;
			NativeMethods.encodeWithCoder_( Handle, CachedSelectors.encodeWithCoder_, out ___occuredException, sizeof( NSCoder ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject initWithCoder_( NObjective.RuntimeObject coder ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCoder_( Handle, CachedSelectors.initWithCoder_, out ___occuredException, sizeof( NObjective.RuntimeObject ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithSource__dest__( NObjective.RuntimeObject source, NObjective.RuntimeObject unnamedParameter, NObjective.RuntimeObject dest, NObjective.RuntimeObject unnamedParameter2 ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithSource__dest__( Handle, CachedSelectors.initWithSource__dest__, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), source, unnamedParameter, dest, unnamedParameter2 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject sourceKey() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sourceKey( Handle, CachedSelectors.sourceKey, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject sourceNode() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sourceNode( Handle, CachedSelectors.sourceNode, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr destKey( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr destNode( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr edgeWithSource__dest__( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject source, NObjective.RuntimeObject unnamedParameter, NObjective.RuntimeObject dest, NObjective.RuntimeObject unnamedParameter2 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void encodeWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSCoder coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithSource__dest__( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject source, NObjective.RuntimeObject unnamedParameter, NObjective.RuntimeObject dest, NObjective.RuntimeObject unnamedParameter2 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr sourceKey( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr sourceNode( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector destKey = "destKey";
			public static readonly Selector destNode = "destNode";
			public static readonly Selector edgeWithSource__dest__ = "edgeWithSource::dest::";
			public static readonly Selector encodeWithCoder_ = "encodeWithCoder:";
			public static readonly Selector initWithCoder_ = "initWithCoder:";
			public static readonly Selector initWithSource__dest__ = "initWithSource::dest::";
			public static readonly Selector sourceKey = "sourceKey";
			public static readonly Selector sourceNode = "sourceNode";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIEdges : IEquatable<CIEdges> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIEdges;
		public static implicit operator CIFilter( CIEdges value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIEdges value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIEdges value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIEdges value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIEdges?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIEdges value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIEdges value1, CIEdges value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIEdges value1, CIEdges value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIEdges( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIEdges alloc() {
			return new CIEdges( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIEdgeWork : IEquatable<CIEdgeWork> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIEdgeWork;
		public static implicit operator CIFilter( CIEdgeWork value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIEdgeWork value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIEdgeWork value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIEdgeWork value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIEdgeWork?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIEdgeWork value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIEdgeWork value1, CIEdgeWork value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIEdgeWork value1, CIEdgeWork value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIEdgeWork( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIEdgeWork alloc() {
			return new CIEdgeWork( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIEmboss : IEquatable<CIEmboss> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIEmboss;
		public static implicit operator CIFilter( CIEmboss value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIEmboss value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIEmboss value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIEmboss value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIEmboss?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIEmboss value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIEmboss value1, CIEmboss value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIEmboss value1, CIEmboss value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIEmboss( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIEmboss alloc() {
			return new CIEmboss( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIExclusionBlendMode : IEquatable<CIExclusionBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIExclusionBlendMode;
		public static implicit operator CIFilter( CIExclusionBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIExclusionBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIExclusionBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIExclusionBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIExclusionBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIExclusionBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIExclusionBlendMode value1, CIExclusionBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIExclusionBlendMode value1, CIExclusionBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIExclusionBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIExclusionBlendMode alloc() {
			return new CIExclusionBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIExposureAdjust : IEquatable<CIExposureAdjust> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIExposureAdjust;
		public static implicit operator CIFilter( CIExposureAdjust value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIExposureAdjust value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIExposureAdjust value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIExposureAdjust value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIExposureAdjust?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIExposureAdjust value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIExposureAdjust value1, CIExposureAdjust value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIExposureAdjust value1, CIExposureAdjust value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIExposureAdjust( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIExposureAdjust alloc() {
			return new CIExposureAdjust( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIFalseColor : IEquatable<CIFalseColor> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIFalseColor;
		public static implicit operator CIFilter( CIFalseColor value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIFalseColor value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIFalseColor value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIFalseColor value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIFalseColor?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIFalseColor value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIFalseColor value1, CIFalseColor value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIFalseColor value1, CIFalseColor value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIFalseColor( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIFalseColor alloc() {
			return new CIFalseColor( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct CIFilter : IEquatable<CIFilter> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIFilter;
		public static implicit operator NSObject( CIFilter value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIFilter value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIFilter value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIFilter?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIFilter value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIFilter value1, CIFilter value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIFilter value1, CIFilter value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIFilter( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIFilter alloc() {
			return new CIFilter( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject filter() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.filter( ClassHandle, CachedSelectors.filter, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NSArray filterNamesInCategories_( NSArray categories ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.filterNamesInCategories_( ClassHandle, CachedSelectors.filterNamesInCategories_, out ___occuredException, sizeof( NSArray ), categories );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public static NSArray filterNamesInCategory_( string category ) {
			RuntimeObject ___occuredException;
			var ___wrappedcategory = Runtime.CreateStringProxy( category );
			var ___result = NativeMethods.filterNamesInCategory_( ClassHandle, CachedSelectors.filterNamesInCategory_, out ___occuredException, sizeof( IntPtr ), ___wrappedcategory );
			Runtime.ReleaseNativeObject( ___wrappedcategory );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public static CIFilter filterWithName_( string name ) {
			RuntimeObject ___occuredException;
			var ___wrappedname = Runtime.CreateStringProxy( name );
			var ___result = NativeMethods.filterWithName_( ClassHandle, CachedSelectors.filterWithName_, out ___occuredException, sizeof( IntPtr ), ___wrappedname );
			Runtime.ReleaseNativeObject( ___wrappedname );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIFilter( ___result );
		}
		unsafe public static NObjective.RuntimeObject filterWithName_compatibilityVersion_( NObjective.RuntimeObject name, int compatibilityVersion ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.filterWithName_compatibilityVersion_( ClassHandle, CachedSelectors.filterWithName_compatibilityVersion_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( int ), name, compatibilityVersion );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject filterWithName_compatibilityVersion_keysAndValues_( NObjective.RuntimeObject name, int compatibilityVersion, NObjective.RuntimeObject keysAndValues ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.filterWithName_compatibilityVersion_keysAndValues_( ClassHandle, CachedSelectors.filterWithName_compatibilityVersion_keysAndValues_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( int ) + sizeof( NObjective.RuntimeObject ), name, compatibilityVersion, keysAndValues );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		public static CIFilter filterWithName_keysAndValues_( string name, NObjective.RuntimeObject keysAndValues, params object[] variableArguments ) {
			return new CIFilter( ClassHandle.InvokeObjectFast( CachedSelectors.filterWithName_keysAndValues_, CachedEncodings.__19F8A84A, name, keysAndValues, variableArguments ) );
		}
		unsafe public static string localizedNameForCategory_( string category ) {
			RuntimeObject ___occuredException;
			var ___wrappedcategory = Runtime.CreateStringProxy( category );
			var ___result = NativeMethods.localizedNameForCategory_( ClassHandle, CachedSelectors.localizedNameForCategory_, out ___occuredException, sizeof( IntPtr ), ___wrappedcategory );
			Runtime.ReleaseNativeObject( ___wrappedcategory );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public static string localizedNameForFilterName_( string name ) {
			RuntimeObject ___occuredException;
			var ___wrappedname = Runtime.CreateStringProxy( name );
			var ___result = NativeMethods.localizedNameForFilterName_( ClassHandle, CachedSelectors.localizedNameForFilterName_, out ___occuredException, sizeof( IntPtr ), ___wrappedname );
			Runtime.ReleaseNativeObject( ___wrappedname );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public static void registerFilterName_constructor_classAttributes_( string name, NObjective.RuntimeObject constructor, NSDictionary classAttributes ) {
			RuntimeObject ___occuredException;
			var ___wrappedname = Runtime.CreateStringProxy( name );
			NativeMethods.registerFilterName_constructor_classAttributes_( ClassHandle, CachedSelectors.registerFilterName_constructor_classAttributes_, out ___occuredException, sizeof( IntPtr ) + sizeof( NObjective.RuntimeObject ) + sizeof( NSDictionary ), ___wrappedname, constructor, classAttributes );
			Runtime.ReleaseNativeObject( ___wrappedname );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		public CIImage apply_( CIKernel apply, params object[] variableArguments ) {
			return new CIImage( Handle.InvokeObjectFast( CachedSelectors.apply_, CachedEncodings.__6F587D11, apply, variableArguments ) );
		}
		unsafe public CIImage apply_arguments_options_( CIKernel apply, NSArray arguments, NSDictionary options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.apply_arguments_options_( Handle, CachedSelectors.apply_arguments_options_, out ___occuredException, sizeof( CIKernel ) + sizeof( NSArray ) + sizeof( NSDictionary ), apply, arguments, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIImage( ___result );
		}
		unsafe public NSDictionary attributes() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.attributes( Handle, CachedSelectors.attributes, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSDictionary( ___result );
		}
		unsafe public int compatibilityVersion() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.compatibilityVersion( Handle, CachedSelectors.compatibilityVersion, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject customAttributes() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.customAttributes( Handle, CachedSelectors.customAttributes, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void encodeWithCoder_( NSCoder coder ) {
			RuntimeObject ___occuredException;
			NativeMethods.encodeWithCoder_( Handle, CachedSelectors.encodeWithCoder_, out ___occuredException, sizeof( NSCoder ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject exposedBindings() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.exposedBindings( Handle, CachedSelectors.exposedBindings, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject filterClassDescription() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.filterClassDescription( Handle, CachedSelectors.filterClassDescription, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithCoder_( NObjective.RuntimeObject coder ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCoder_( Handle, CachedSelectors.initWithCoder_, out ___occuredException, sizeof( NObjective.RuntimeObject ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithCompatibilityVersion_( int version ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCompatibilityVersion_( Handle, CachedSelectors.initWithCompatibilityVersion_, out ___occuredException, sizeof( int ), version );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSArray inputKeys() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.inputKeys( Handle, CachedSelectors.inputKeys, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public NObjective.RuntimeObject localizedNameForKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.localizedNameForKey_( Handle, CachedSelectors.localizedNameForKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NSArray outputKeys() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputKeys( Handle, CachedSelectors.outputKeys, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public void setDefaults() {
			RuntimeObject ___occuredException;
			NativeMethods.setDefaults( Handle, CachedSelectors.setDefaults, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setIdentity() {
			RuntimeObject ___occuredException;
			NativeMethods.setIdentity( Handle, CachedSelectors.setIdentity, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setOption_forKey_( NObjective.RuntimeObject option, NObjective.RuntimeObject forKey ) {
			RuntimeObject ___occuredException;
			NativeMethods.setOption_forKey_( Handle, CachedSelectors.setOption_forKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), option, forKey );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setUserInfo_( NObjective.RuntimeObject info ) {
			RuntimeObject ___occuredException;
			NativeMethods.setUserInfo_( Handle, CachedSelectors.setUserInfo_, out ___occuredException, sizeof( NObjective.RuntimeObject ), info );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject userInfo() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.userInfo( Handle, CachedSelectors.userInfo, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr apply_arguments_options_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, CIKernel apply, NSArray arguments, NSDictionary options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr attributes( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int compatibilityVersion( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr customAttributes( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void encodeWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSCoder coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr exposedBindings( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr filter( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr filterClassDescription( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr filterNamesInCategories_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSArray categories );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr filterNamesInCategory_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr category );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr filterWithName_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr filterWithName_compatibilityVersion_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name, int compatibilityVersion );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr filterWithName_compatibilityVersion_keysAndValues_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name, int compatibilityVersion, NObjective.RuntimeObject keysAndValues );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCompatibilityVersion_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int version );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr inputKeys( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr localizedNameForCategory_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr category );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr localizedNameForFilterName_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr localizedNameForKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputKeys( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void registerFilterName_constructor_classAttributes_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr name, NObjective.RuntimeObject constructor, NSDictionary classAttributes );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setDefaults( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setIdentity( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setOption_forKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject option, NObjective.RuntimeObject forKey );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setUserInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject info );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr userInfo( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedEncodings {
			public static readonly RuntimeMethodEncoding __19F8A84A = "@16@0:4@8@12";
			public static readonly RuntimeMethodEncoding __6F587D11 = "@12@0:4@8";
		}
		static internal class CachedSelectors {
			public static readonly Selector apply_ = "apply:";
			public static readonly Selector apply_arguments_options_ = "apply:arguments:options:";
			public static readonly Selector attributes = "attributes";
			public static readonly Selector compatibilityVersion = "compatibilityVersion";
			public static readonly Selector customAttributes = "customAttributes";
			public static readonly Selector encodeWithCoder_ = "encodeWithCoder:";
			public static readonly Selector exposedBindings = "exposedBindings";
			public static readonly Selector filter = "filter";
			public static readonly Selector filterClassDescription = "filterClassDescription";
			public static readonly Selector filterNamesInCategories_ = "filterNamesInCategories:";
			public static readonly Selector filterNamesInCategory_ = "filterNamesInCategory:";
			public static readonly Selector filterWithName_ = "filterWithName:";
			public static readonly Selector filterWithName_compatibilityVersion_ = "filterWithName:compatibilityVersion:";
			public static readonly Selector filterWithName_compatibilityVersion_keysAndValues_ = "filterWithName:compatibilityVersion:keysAndValues:";
			public static readonly Selector filterWithName_keysAndValues_ = "filterWithName:keysAndValues:";
			public static readonly Selector initWithCoder_ = "initWithCoder:";
			public static readonly Selector initWithCompatibilityVersion_ = "initWithCompatibilityVersion:";
			public static readonly Selector inputKeys = "inputKeys";
			public static readonly Selector localizedNameForCategory_ = "localizedNameForCategory:";
			public static readonly Selector localizedNameForFilterName_ = "localizedNameForFilterName:";
			public static readonly Selector localizedNameForKey_ = "localizedNameForKey:";
			public static readonly Selector outputKeys = "outputKeys";
			public static readonly Selector registerFilterName_constructor_classAttributes_ = "registerFilterName:constructor:classAttributes:";
			public static readonly Selector setDefaults = "setDefaults";
			public static readonly Selector setIdentity = "setIdentity";
			public static readonly Selector setOption_forKey_ = "setOption:forKey:";
			public static readonly Selector setUserInfo_ = "setUserInfo:";
			public static readonly Selector userInfo = "userInfo";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct CIFilterClassDescription : IEquatable<CIFilterClassDescription> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIFilterClassDescription;
		public static implicit operator NSObject( CIFilterClassDescription value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIFilterClassDescription value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIFilterClassDescription value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIFilterClassDescription?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIFilterClassDescription value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIFilterClassDescription value1, CIFilterClassDescription value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIFilterClassDescription value1, CIFilterClassDescription value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIFilterClassDescription( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIFilterClassDescription alloc() {
			return new CIFilterClassDescription( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject classDescriptionForClass_( NObjective.RuntimeClass @class ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.classDescriptionForClass_( ClassHandle, CachedSelectors.classDescriptionForClass_, out ___occuredException, sizeof( NObjective.RuntimeClass ), @class );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject attributes() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.attributes( Handle, CachedSelectors.attributes, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithClass_( NObjective.RuntimeClass @class ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithClass_( Handle, CachedSelectors.initWithClass_, out ___occuredException, sizeof( NObjective.RuntimeClass ), @class );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject inputKeys() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.inputKeys( Handle, CachedSelectors.inputKeys, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject outputKeys() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputKeys( Handle, CachedSelectors.outputKeys, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr attributes( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr classDescriptionForClass_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeClass @class );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithClass_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeClass @class );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr inputKeys( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputKeys( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector attributes = "attributes";
			public static readonly Selector classDescriptionForClass_ = "classDescriptionForClass:";
			public static readonly Selector initWithClass_ = "initWithClass:";
			public static readonly Selector inputKeys = "inputKeys";
			public static readonly Selector outputKeys = "outputKeys";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIFilterGraph : IEquatable<CIFilterGraph> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIFilterGraph;
		public static implicit operator CIFilter( CIFilterGraph value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIFilterGraph value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIFilterGraph value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIFilterGraph value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIFilterGraph?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIFilterGraph value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIFilterGraph value1, CIFilterGraph value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIFilterGraph value1, CIFilterGraph value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIFilterGraph( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIFilterGraph alloc() {
			return new CIFilterGraph( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject initWithGraph_( NObjective.RuntimeObject graph ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithGraph_( Handle, CachedSelectors.initWithGraph_, out ___occuredException, sizeof( NObjective.RuntimeObject ), graph );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithGraph_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject graph );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithGraph_ = "initWithGraph:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIPlugIn ) )]
	public struct CIFilterPlugIn : IEquatable<CIFilterPlugIn> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIFilterPlugIn;
		public static implicit operator CIPlugIn( CIFilterPlugIn value ) {
			return new CIPlugIn( value.Handle );
		}
		public static implicit operator NSObject( CIFilterPlugIn value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIFilterPlugIn value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIFilterPlugIn value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIFilterPlugIn?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIFilterPlugIn value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIFilterPlugIn value1, CIFilterPlugIn value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIFilterPlugIn value1, CIFilterPlugIn value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIFilterPlugIn( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIFilterPlugIn alloc() {
			return new CIFilterPlugIn( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject filterWithName_( NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.filterWithName_( Handle, CachedSelectors.filterWithName_, out ___occuredException, sizeof( NObjective.RuntimeObject ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject filterWithName_compatibilityVersion_( NObjective.RuntimeObject name, int compatibilityVersion ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.filterWithName_compatibilityVersion_( Handle, CachedSelectors.filterWithName_compatibilityVersion_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( int ), name, compatibilityVersion );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject filterWithName_compatibilityVersion_keysAndValues_( NObjective.RuntimeObject name, int compatibilityVersion, NObjective.RuntimeObject keysAndValues ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.filterWithName_compatibilityVersion_keysAndValues_( Handle, CachedSelectors.filterWithName_compatibilityVersion_keysAndValues_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( int ) + sizeof( NObjective.RuntimeObject ), name, compatibilityVersion, keysAndValues );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject filterWithName_keysAndValues_( NObjective.RuntimeObject name, NObjective.RuntimeObject keysAndValues ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.filterWithName_keysAndValues_( Handle, CachedSelectors.filterWithName_keysAndValues_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), name, keysAndValues );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void registerFilters() {
			RuntimeObject ___occuredException;
			NativeMethods.registerFilters( Handle, CachedSelectors.registerFilters, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr filterWithName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr filterWithName_compatibilityVersion_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name, int compatibilityVersion );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr filterWithName_compatibilityVersion_keysAndValues_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name, int compatibilityVersion, NObjective.RuntimeObject keysAndValues );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr filterWithName_keysAndValues_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name, NObjective.RuntimeObject keysAndValues );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void registerFilters( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector filterWithName_ = "filterWithName:";
			public static readonly Selector filterWithName_compatibilityVersion_ = "filterWithName:compatibilityVersion:";
			public static readonly Selector filterWithName_compatibilityVersion_keysAndValues_ = "filterWithName:compatibilityVersion:keysAndValues:";
			public static readonly Selector filterWithName_keysAndValues_ = "filterWithName:keysAndValues:";
			public static readonly Selector registerFilters = "registerFilters";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct CIFilterShape : IEquatable<CIFilterShape> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIFilterShape;
		public static implicit operator NSObject( CIFilterShape value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIFilterShape value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIFilterShape value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIFilterShape?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIFilterShape value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIFilterShape value1, CIFilterShape value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIFilterShape value1, CIFilterShape value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIFilterShape( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIFilterShape alloc() {
			return new CIFilterShape( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject shapeWithCGSRegion_( System.IntPtr region ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.shapeWithCGSRegion_( ClassHandle, CachedSelectors.shapeWithCGSRegion_, out ___occuredException, sizeof( System.IntPtr ), region );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject shapeWithRect_( CGRect rect ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.shapeWithRect_( ClassHandle, CachedSelectors.shapeWithRect_, out ___occuredException, sizeof( CGRect ), rect );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public System.IntPtr CGSRegion() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.CGSRegion( Handle, CachedSelectors.CGSRegion, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject initWithCGSRegion_( System.IntPtr region ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCGSRegion_( Handle, CachedSelectors.initWithCGSRegion_, out ___occuredException, sizeof( System.IntPtr ), region );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithRect_( CGRect rect ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithRect_( Handle, CachedSelectors.initWithRect_, out ___occuredException, sizeof( CGRect ), rect );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public CIFilterShape insetByX_Y_( int x, int Y ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.insetByX_Y_( Handle, CachedSelectors.insetByX_Y_, out ___occuredException, sizeof( int ) + sizeof( int ), x, Y );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIFilterShape( ___result );
		}
		unsafe public CIFilterShape intersectWith_( CIFilterShape with ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.intersectWith_( Handle, CachedSelectors.intersectWith_, out ___occuredException, sizeof( CIFilterShape ), with );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIFilterShape( ___result );
		}
		unsafe public CIFilterShape intersectWithRect_( CGRect rect ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.intersectWithRect_( Handle, CachedSelectors.intersectWithRect_, out ___occuredException, sizeof( CGRect ), rect );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIFilterShape( ___result );
		}
		unsafe public CIFilterShape transformBy_interior_( CGAffineTransform @by, bool interior ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.transformBy_interior_( Handle, CachedSelectors.transformBy_interior_, out ___occuredException, sizeof( CGAffineTransform ) + sizeof( bool ), @by, interior );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIFilterShape( ___result );
		}
		unsafe public CIFilterShape unionWith_( CIFilterShape with ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.unionWith_( Handle, CachedSelectors.unionWith_, out ___occuredException, sizeof( CIFilterShape ), with );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIFilterShape( ___result );
		}
		unsafe public CIFilterShape unionWithRect_( CGRect rect ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.unionWithRect_( Handle, CachedSelectors.unionWithRect_, out ___occuredException, sizeof( CGRect ), rect );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIFilterShape( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern System.IntPtr CGSRegion( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCGSRegion_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr region );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithRect_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, CGRect rect );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr insetByX_Y_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int x, int Y );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr intersectWith_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, CIFilterShape with );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr intersectWithRect_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, CGRect rect );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr shapeWithCGSRegion_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr region );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr shapeWithRect_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, CGRect rect );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr transformBy_interior_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, CGAffineTransform @by, bool interior );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr unionWith_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, CIFilterShape with );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr unionWithRect_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, CGRect rect );
		}
		static internal class CachedSelectors {
			public static readonly Selector CGSRegion = "CGSRegion";
			public static readonly Selector initWithCGSRegion_ = "initWithCGSRegion:";
			public static readonly Selector initWithRect_ = "initWithRect:";
			public static readonly Selector insetByX_Y_ = "insetByX:Y:";
			public static readonly Selector intersectWith_ = "intersectWith:";
			public static readonly Selector intersectWithRect_ = "intersectWithRect:";
			public static readonly Selector shapeWithCGSRegion_ = "shapeWithCGSRegion:";
			public static readonly Selector shapeWithRect_ = "shapeWithRect:";
			public static readonly Selector transformBy_interior_ = "transformBy:interior:";
			public static readonly Selector unionWith_ = "unionWith:";
			public static readonly Selector unionWithRect_ = "unionWithRect:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIFlashTransition : IEquatable<CIFlashTransition> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIFlashTransition;
		public static implicit operator CIFilter( CIFlashTransition value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIFlashTransition value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIFlashTransition value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIFlashTransition value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIFlashTransition?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIFlashTransition value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIFlashTransition value1, CIFlashTransition value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIFlashTransition value1, CIFlashTransition value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIFlashTransition( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIFlashTransition alloc() {
			return new CIFlashTransition( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIFullButton : IEquatable<CIFullButton> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIFullButton;
		public static implicit operator CIFilter( CIFullButton value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIFullButton value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIFullButton value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIFullButton value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIFullButton?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIFullButton value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIFullButton value1, CIFullButton value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIFullButton value1, CIFullButton value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIFullButton( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIFullButton alloc() {
			return new CIFullButton( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject computeButton() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.computeButton( Handle, CachedSelectors.computeButton, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject computeHighlight() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.computeHighlight( Handle, CachedSelectors.computeHighlight, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject computeInlay() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.computeInlay( Handle, CachedSelectors.computeInlay, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject computeInsideShadow() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.computeInsideShadow( Handle, CachedSelectors.computeInsideShadow, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject computeOutline() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.computeOutline( Handle, CachedSelectors.computeOutline, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject computeOutsideShadow() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.computeOutsideShadow( Handle, CachedSelectors.computeOutsideShadow, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr computeButton( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr computeHighlight( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr computeInlay( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr computeInsideShadow( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr computeOutline( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr computeOutsideShadow( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector computeButton = "computeButton";
			public static readonly Selector computeHighlight = "computeHighlight";
			public static readonly Selector computeInlay = "computeInlay";
			public static readonly Selector computeInsideShadow = "computeInsideShadow";
			public static readonly Selector computeOutline = "computeOutline";
			public static readonly Selector computeOutsideShadow = "computeOutsideShadow";
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIGammaAdjust : IEquatable<CIGammaAdjust> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIGammaAdjust;
		public static implicit operator CIFilter( CIGammaAdjust value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIGammaAdjust value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIGammaAdjust value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIGammaAdjust value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIGammaAdjust?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIGammaAdjust value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIGammaAdjust value1, CIGammaAdjust value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIGammaAdjust value1, CIGammaAdjust value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIGammaAdjust( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIGammaAdjust alloc() {
			return new CIGammaAdjust( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIGamutAlarm : IEquatable<CIGamutAlarm> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIGamutAlarm;
		public static implicit operator CIFilter( CIGamutAlarm value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIGamutAlarm value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIGamutAlarm value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIGamutAlarm value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIGamutAlarm?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIGamutAlarm value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIGamutAlarm value1, CIGamutAlarm value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIGamutAlarm value1, CIGamutAlarm value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIGamutAlarm( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIGamutAlarm alloc() {
			return new CIGamutAlarm( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIGamutClamp : IEquatable<CIGamutClamp> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIGamutClamp;
		public static implicit operator CIFilter( CIGamutClamp value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIGamutClamp value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIGamutClamp value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIGamutClamp value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIGamutClamp?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIGamutClamp value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIGamutClamp value1, CIGamutClamp value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIGamutClamp value1, CIGamutClamp value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIGamutClamp( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIGamutClamp alloc() {
			return new CIGamutClamp( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIGamutRollOff : IEquatable<CIGamutRollOff> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIGamutRollOff;
		public static implicit operator CIFilter( CIGamutRollOff value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIGamutRollOff value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIGamutRollOff value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIGamutRollOff value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIGamutRollOff?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIGamutRollOff value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIGamutRollOff value1, CIGamutRollOff value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIGamutRollOff value1, CIGamutRollOff value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIGamutRollOff( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIGamutRollOff alloc() {
			return new CIGamutRollOff( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIGaussianBlur : IEquatable<CIGaussianBlur> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIGaussianBlur;
		public static implicit operator CIFilter( CIGaussianBlur value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIGaussianBlur value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIGaussianBlur value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIGaussianBlur value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIGaussianBlur?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIGaussianBlur value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIGaussianBlur value1, CIGaussianBlur value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIGaussianBlur value1, CIGaussianBlur value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIGaussianBlur( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIGaussianBlur alloc() {
			return new CIGaussianBlur( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject cheapBlur() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.cheapBlur( Handle, CachedSelectors.cheapBlur, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject forcePromise_( NObjective.RuntimeObject promise ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.forcePromise_( Handle, CachedSelectors.forcePromise_, out ___occuredException, sizeof( NObjective.RuntimeObject ), promise );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject gaussianBlur() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.gaussianBlur( Handle, CachedSelectors.gaussianBlur, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr cheapBlur( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr forcePromise_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject promise );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr gaussianBlur( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector cheapBlur = "cheapBlur";
			public static readonly Selector forcePromise_ = "forcePromise:";
			public static readonly Selector gaussianBlur = "gaussianBlur";
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIGaussianGradient : IEquatable<CIGaussianGradient> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIGaussianGradient;
		public static implicit operator CIFilter( CIGaussianGradient value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIGaussianGradient value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIGaussianGradient value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIGaussianGradient value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIGaussianGradient?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIGaussianGradient value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIGaussianGradient value1, CIGaussianGradient value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIGaussianGradient value1, CIGaussianGradient value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIGaussianGradient( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIGaussianGradient alloc() {
			return new CIGaussianGradient( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIGaussianPyramid : IEquatable<CIGaussianPyramid> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIGaussianPyramid;
		public static implicit operator CIFilter( CIGaussianPyramid value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIGaussianPyramid value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIGaussianPyramid value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIGaussianPyramid value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIGaussianPyramid?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIGaussianPyramid value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIGaussianPyramid value1, CIGaussianPyramid value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIGaussianPyramid value1, CIGaussianPyramid value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIGaussianPyramid( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIGaussianPyramid alloc() {
			return new CIGaussianPyramid( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIGlassDistortion : IEquatable<CIGlassDistortion> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIGlassDistortion;
		public static implicit operator CIFilter( CIGlassDistortion value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIGlassDistortion value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIGlassDistortion value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIGlassDistortion value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIGlassDistortion?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIGlassDistortion value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIGlassDistortion value1, CIGlassDistortion value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIGlassDistortion value1, CIGlassDistortion value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIGlassDistortion( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIGlassDistortion alloc() {
			return new CIGlassDistortion( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIGlassLozenge : IEquatable<CIGlassLozenge> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIGlassLozenge;
		public static implicit operator CIFilter( CIGlassLozenge value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIGlassLozenge value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIGlassLozenge value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIGlassLozenge value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIGlassLozenge?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIGlassLozenge value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIGlassLozenge value1, CIGlassLozenge value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIGlassLozenge value1, CIGlassLozenge value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIGlassLozenge( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIGlassLozenge alloc() {
			return new CIGlassLozenge( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIGloom : IEquatable<CIGloom> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIGloom;
		public static implicit operator CIFilter( CIGloom value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIGloom value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIGloom value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIGloom value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIGloom?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIGloom value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIGloom value1, CIGloom value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIGloom value1, CIGloom value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIGloom( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIGloom alloc() {
			return new CIGloom( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct CIGraph : IEquatable<CIGraph> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIGraph;
		public static implicit operator NSObject( CIGraph value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIGraph value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIGraph value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIGraph?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIGraph value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIGraph value1, CIGraph value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIGraph value1, CIGraph value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIGraph( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIGraph alloc() {
			return new CIGraph( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject graph() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.graph( ClassHandle, CachedSelectors.graph, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void addEdge_( NObjective.RuntimeObject edge ) {
			RuntimeObject ___occuredException;
			NativeMethods.addEdge_( Handle, CachedSelectors.addEdge_, out ___occuredException, sizeof( NObjective.RuntimeObject ), edge );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject attributes() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.attributes( Handle, CachedSelectors.attributes, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject edgeEnumerator() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.edgeEnumerator( Handle, CachedSelectors.edgeEnumerator, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject edgeEnumeratorForNode_direction_( NObjective.RuntimeObject node, int direction ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.edgeEnumeratorForNode_direction_( Handle, CachedSelectors.edgeEnumeratorForNode_direction_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( int ), node, direction );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void encodeWithCoder_( NSCoder coder ) {
			RuntimeObject ___occuredException;
			NativeMethods.encodeWithCoder_( Handle, CachedSelectors.encodeWithCoder_, out ___occuredException, sizeof( NSCoder ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject filter() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.filter( Handle, CachedSelectors.filter, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject filterWithName_( NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.filterWithName_( Handle, CachedSelectors.filterWithName_, out ___occuredException, sizeof( NObjective.RuntimeObject ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject immutableCopy() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.immutableCopy( Handle, CachedSelectors.immutableCopy, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithCoder_( NObjective.RuntimeObject coder ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCoder_( Handle, CachedSelectors.initWithCoder_, out ___occuredException, sizeof( NObjective.RuntimeObject ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject inputKeys() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.inputKeys( Handle, CachedSelectors.inputKeys, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject outputKeys() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputKeys( Handle, CachedSelectors.outputKeys, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void registerFilterName_classAttributes_( NObjective.RuntimeObject name, NObjective.RuntimeObject classAttributes ) {
			RuntimeObject ___occuredException;
			NativeMethods.registerFilterName_classAttributes_( Handle, CachedSelectors.registerFilterName_classAttributes_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), name, classAttributes );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeEdge_( NObjective.RuntimeObject edge ) {
			RuntimeObject ___occuredException;
			NativeMethods.removeEdge_( Handle, CachedSelectors.removeEdge_, out ___occuredException, sizeof( NObjective.RuntimeObject ), edge );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setUserInfo_( NObjective.RuntimeObject info ) {
			RuntimeObject ___occuredException;
			NativeMethods.setUserInfo_( Handle, CachedSelectors.setUserInfo_, out ___occuredException, sizeof( NObjective.RuntimeObject ), info );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject userInfo() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.userInfo( Handle, CachedSelectors.userInfo, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject valueForKey_withInputs_( NObjective.RuntimeObject key, NObjective.RuntimeObject withInputs ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.valueForKey_withInputs_( Handle, CachedSelectors.valueForKey_withInputs_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), key, withInputs );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject valuesForKeys_withInputs_( NObjective.RuntimeObject keys, NObjective.RuntimeObject withInputs ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.valuesForKeys_withInputs_( Handle, CachedSelectors.valuesForKeys_withInputs_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), keys, withInputs );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void addEdge_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject edge );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr attributes( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr edgeEnumerator( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr edgeEnumeratorForNode_direction_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject node, int direction );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void encodeWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSCoder coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr filter( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr filterWithName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr graph( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr immutableCopy( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr inputKeys( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputKeys( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void registerFilterName_classAttributes_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name, NObjective.RuntimeObject classAttributes );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void removeEdge_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject edge );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setUserInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject info );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr userInfo( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr valueForKey_withInputs_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key, NObjective.RuntimeObject withInputs );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr valuesForKeys_withInputs_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject keys, NObjective.RuntimeObject withInputs );
		}
		static internal class CachedSelectors {
			public static readonly Selector addEdge_ = "addEdge:";
			public static readonly Selector attributes = "attributes";
			public static readonly Selector edgeEnumerator = "edgeEnumerator";
			public static readonly Selector edgeEnumeratorForNode_direction_ = "edgeEnumeratorForNode:direction:";
			public static readonly Selector encodeWithCoder_ = "encodeWithCoder:";
			public static readonly Selector filter = "filter";
			public static readonly Selector filterWithName_ = "filterWithName:";
			public static readonly Selector graph = "graph";
			public static readonly Selector immutableCopy = "immutableCopy";
			public static readonly Selector initWithCoder_ = "initWithCoder:";
			public static readonly Selector inputKeys = "inputKeys";
			public static readonly Selector outputKeys = "outputKeys";
			public static readonly Selector registerFilterName_classAttributes_ = "registerFilterName:classAttributes:";
			public static readonly Selector removeEdge_ = "removeEdge:";
			public static readonly Selector setUserInfo_ = "setUserInfo:";
			public static readonly Selector userInfo = "userInfo";
			public static readonly Selector valueForKey_withInputs_ = "valueForKey:withInputs:";
			public static readonly Selector valuesForKeys_withInputs_ = "valuesForKeys:withInputs:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIHardLightBlendMode : IEquatable<CIHardLightBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIHardLightBlendMode;
		public static implicit operator CIFilter( CIHardLightBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIHardLightBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIHardLightBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIHardLightBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIHardLightBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIHardLightBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIHardLightBlendMode value1, CIHardLightBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIHardLightBlendMode value1, CIHardLightBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIHardLightBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIHardLightBlendMode alloc() {
			return new CIHardLightBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIHardMixBlendMode : IEquatable<CIHardMixBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIHardMixBlendMode;
		public static implicit operator CIFilter( CIHardMixBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIHardMixBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIHardMixBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIHardMixBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIHardMixBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIHardMixBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIHardMixBlendMode value1, CIHardMixBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIHardMixBlendMode value1, CIHardMixBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIHardMixBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIHardMixBlendMode alloc() {
			return new CIHardMixBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIHatchedScreen : IEquatable<CIHatchedScreen> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIHatchedScreen;
		public static implicit operator CIFilter( CIHatchedScreen value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIHatchedScreen value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIHatchedScreen value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIHatchedScreen value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIHatchedScreen?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIHatchedScreen value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIHatchedScreen value1, CIHatchedScreen value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIHatchedScreen value1, CIHatchedScreen value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIHatchedScreen( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIHatchedScreen alloc() {
			return new CIHatchedScreen( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIHeightFieldFromConstraints : IEquatable<CIHeightFieldFromConstraints> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIHeightFieldFromConstraints;
		public static implicit operator CIFilter( CIHeightFieldFromConstraints value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIHeightFieldFromConstraints value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIHeightFieldFromConstraints value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIHeightFieldFromConstraints value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIHeightFieldFromConstraints?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIHeightFieldFromConstraints value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIHeightFieldFromConstraints value1, CIHeightFieldFromConstraints value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIHeightFieldFromConstraints value1, CIHeightFieldFromConstraints value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIHeightFieldFromConstraints( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIHeightFieldFromConstraints alloc() {
			return new CIHeightFieldFromConstraints( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIHeightFieldFromMask : IEquatable<CIHeightFieldFromMask> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIHeightFieldFromMask;
		public static implicit operator CIFilter( CIHeightFieldFromMask value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIHeightFieldFromMask value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIHeightFieldFromMask value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIHeightFieldFromMask value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIHeightFieldFromMask?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIHeightFieldFromMask value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIHeightFieldFromMask value1, CIHeightFieldFromMask value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIHeightFieldFromMask value1, CIHeightFieldFromMask value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIHeightFieldFromMask( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIHeightFieldFromMask alloc() {
			return new CIHeightFieldFromMask( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIHistogram : IEquatable<CIHistogram> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIHistogram;
		public static implicit operator CIFilter( CIHistogram value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIHistogram value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIHistogram value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIHistogram value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIHistogram?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIHistogram value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIHistogram value1, CIHistogram value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIHistogram value1, CIHistogram value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIHistogram( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIHistogram alloc() {
			return new CIHistogram( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject forcePromise_( NObjective.RuntimeObject promise ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.forcePromise_( Handle, CachedSelectors.forcePromise_, out ___occuredException, sizeof( NObjective.RuntimeObject ), promise );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr forcePromise_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject promise );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector forcePromise_ = "forcePromise:";
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIHoleDistortion : IEquatable<CIHoleDistortion> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIHoleDistortion;
		public static implicit operator CIFilter( CIHoleDistortion value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIHoleDistortion value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIHoleDistortion value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIHoleDistortion value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIHoleDistortion?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIHoleDistortion value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIHoleDistortion value1, CIHoleDistortion value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIHoleDistortion value1, CIHoleDistortion value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIHoleDistortion( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIHoleDistortion alloc() {
			return new CIHoleDistortion( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIHueAdjust : IEquatable<CIHueAdjust> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIHueAdjust;
		public static implicit operator CIFilter( CIHueAdjust value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIHueAdjust value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIHueAdjust value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIHueAdjust value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIHueAdjust?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIHueAdjust value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIHueAdjust value1, CIHueAdjust value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIHueAdjust value1, CIHueAdjust value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIHueAdjust( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIHueAdjust alloc() {
			return new CIHueAdjust( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIHueBlendMode : IEquatable<CIHueBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIHueBlendMode;
		public static implicit operator CIFilter( CIHueBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIHueBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIHueBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIHueBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIHueBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIHueBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIHueBlendMode value1, CIHueBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIHueBlendMode value1, CIHueBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIHueBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIHueBlendMode alloc() {
			return new CIHueBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct CIImage : IEquatable<CIImage> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIImage;
		public static implicit operator NSObject( CIImage value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIImage value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIImage value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIImage?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIImage value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIImage value1, CIImage value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIImage value1, CIImage value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIImage( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIImage alloc() {
			return new CIImage( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static CIImage imageWithBitmapData_bytesPerRow_size_format_colorSpace_( NSData data, uint bytesPerRow, CGSize size, int format, IntPtr colorSpace ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.imageWithBitmapData_bytesPerRow_size_format_colorSpace_( ClassHandle, CachedSelectors.imageWithBitmapData_bytesPerRow_size_format_colorSpace_, out ___occuredException, sizeof( NSData ) + sizeof( uint ) + sizeof( CGSize ) + sizeof( int ) + sizeof( IntPtr ), data, bytesPerRow, size, format, colorSpace );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIImage( ___result );
		}
		unsafe public static CIImage imageWithCGImage_( IntPtr image ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.imageWithCGImage_( ClassHandle, CachedSelectors.imageWithCGImage_, out ___occuredException, sizeof( IntPtr ), image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIImage( ___result );
		}
		unsafe public static CIImage imageWithCGImage_options_( IntPtr image, NSDictionary options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.imageWithCGImage_options_( ClassHandle, CachedSelectors.imageWithCGImage_options_, out ___occuredException, sizeof( IntPtr ) + sizeof( NSDictionary ), image, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIImage( ___result );
		}
		unsafe public static CIImage imageWithCGLayer_( IntPtr layer ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.imageWithCGLayer_( ClassHandle, CachedSelectors.imageWithCGLayer_, out ___occuredException, sizeof( IntPtr ), layer );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIImage( ___result );
		}
		unsafe public static CIImage imageWithCGLayer_options_( IntPtr layer, NSDictionary options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.imageWithCGLayer_options_( ClassHandle, CachedSelectors.imageWithCGLayer_options_, out ___occuredException, sizeof( IntPtr ) + sizeof( NSDictionary ), layer, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIImage( ___result );
		}
		unsafe public static NObjective.RuntimeObject imageWithColor_( NObjective.RuntimeObject color ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.imageWithColor_( ClassHandle, CachedSelectors.imageWithColor_, out ___occuredException, sizeof( NObjective.RuntimeObject ), color );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static CIImage imageWithContentsOfURL_( NSURL url ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.imageWithContentsOfURL_( ClassHandle, CachedSelectors.imageWithContentsOfURL_, out ___occuredException, sizeof( NSURL ), url );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIImage( ___result );
		}
		unsafe public static CIImage imageWithContentsOfURL_options_( NSURL url, NSDictionary options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.imageWithContentsOfURL_options_( ClassHandle, CachedSelectors.imageWithContentsOfURL_options_, out ___occuredException, sizeof( NSURL ) + sizeof( NSDictionary ), url, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIImage( ___result );
		}
		unsafe public static CIImage imageWithCVImageBuffer_( IntPtr buffer ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.imageWithCVImageBuffer_( ClassHandle, CachedSelectors.imageWithCVImageBuffer_, out ___occuredException, sizeof( IntPtr ), buffer );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIImage( ___result );
		}
		unsafe public static CIImage imageWithCVImageBuffer_options_( IntPtr buffer, NSDictionary options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.imageWithCVImageBuffer_options_( ClassHandle, CachedSelectors.imageWithCVImageBuffer_options_, out ___occuredException, sizeof( IntPtr ) + sizeof( NSDictionary ), buffer, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIImage( ___result );
		}
		unsafe public static CIImage imageWithData_( NSData data ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.imageWithData_( ClassHandle, CachedSelectors.imageWithData_, out ___occuredException, sizeof( NSData ), data );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIImage( ___result );
		}
		unsafe public static CIImage imageWithData_options_( NSData data, NSDictionary options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.imageWithData_options_( ClassHandle, CachedSelectors.imageWithData_options_, out ___occuredException, sizeof( NSData ) + sizeof( NSDictionary ), data, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIImage( ___result );
		}
		unsafe public static CIImage imageWithImageProvider_size__format_colorSpace_options_( NObjective.RuntimeObject provider, uint size, uint unnamedParameter, int format, IntPtr colorSpace, NSDictionary options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.imageWithImageProvider_size__format_colorSpace_options_( ClassHandle, CachedSelectors.imageWithImageProvider_size__format_colorSpace_options_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ) + sizeof( uint ) + sizeof( int ) + sizeof( IntPtr ) + sizeof( NSDictionary ), provider, size, unnamedParameter, format, colorSpace, options
			 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIImage( ___result );
		}
		unsafe public static NObjective.RuntimeObject imageWithJPEGFile_( NObjective.RuntimeObject file ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.imageWithJPEGFile_( ClassHandle, CachedSelectors.imageWithJPEGFile_, out ___occuredException, sizeof( NObjective.RuntimeObject ), file );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject imageWithPNGFile_( NObjective.RuntimeObject file ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.imageWithPNGFile_( ClassHandle, CachedSelectors.imageWithPNGFile_, out ___occuredException, sizeof( NObjective.RuntimeObject ), file );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static CIImage imageWithTexture_size_flipped_colorSpace_( uint texture, CGSize size, bool flipped, IntPtr colorSpace ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.imageWithTexture_size_flipped_colorSpace_( ClassHandle, CachedSelectors.imageWithTexture_size_flipped_colorSpace_, out ___occuredException, sizeof( uint ) + sizeof( CGSize ) + sizeof( bool ) + sizeof( IntPtr ), texture, size, flipped, colorSpace );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIImage( ___result );
		}
		unsafe public static NObjective.RuntimeObject imageWithURL_( NObjective.RuntimeObject url ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.imageWithURL_( ClassHandle, CachedSelectors.imageWithURL_, out ___occuredException, sizeof( NObjective.RuntimeObject ), url );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject noiseImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.noiseImage( ClassHandle, CachedSelectors.noiseImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject nullImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.nullImage( ClassHandle, CachedSelectors.nullImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char cacheHint() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.cacheHint( Handle, CachedSelectors.cacheHint, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public CIFilterShape definition() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.definition( Handle, CachedSelectors.definition, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIFilterShape( ___result );
		}
		unsafe public void encodeWithCoder_( NSCoder coder ) {
			RuntimeObject ___occuredException;
			NativeMethods.encodeWithCoder_( Handle, CachedSelectors.encodeWithCoder_, out ___occuredException, sizeof( NSCoder ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public CGRect extent() {
			CGRect ___result;
			RuntimeObject ___occuredException;
			NativeMethods.extent( out ___result, sizeof( CGRect ), Handle, CachedSelectors.extent, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject filteredImage_keysAndValues_( NObjective.RuntimeObject image, NObjective.RuntimeObject keysAndValues ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.filteredImage_keysAndValues_( Handle, CachedSelectors.filteredImage_keysAndValues_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), image, keysAndValues );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public CIImage imageByApplyingTransform_( CGAffineTransform transform ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.imageByApplyingTransform_( Handle, CachedSelectors.imageByApplyingTransform_, out ___occuredException, sizeof( CGAffineTransform ), transform );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIImage( ___result );
		}
		unsafe public NObjective.RuntimeObject imageByCompositingOverImage_( NObjective.RuntimeObject image ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.imageByCompositingOverImage_( Handle, CachedSelectors.imageByCompositingOverImage_, out ___occuredException, sizeof( NObjective.RuntimeObject ), image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject imageByCroppingToShape_( NObjective.RuntimeObject shape ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.imageByCroppingToShape_( Handle, CachedSelectors.imageByCroppingToShape_, out ___occuredException, sizeof( NObjective.RuntimeObject ), shape );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithBitmapData_bytesPerRow_size_format_colorSpace_( NSData data, uint bytesPerRow, CGSize size, int format, IntPtr colorSpace ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithBitmapData_bytesPerRow_size_format_colorSpace_( Handle, CachedSelectors.initWithBitmapData_bytesPerRow_size_format_colorSpace_, out ___occuredException, sizeof( NSData ) + sizeof( uint ) + sizeof( CGSize ) + sizeof( int ) + sizeof( IntPtr ), data, bytesPerRow, size, format, colorSpace );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithCGImage_( IntPtr image ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCGImage_( Handle, CachedSelectors.initWithCGImage_, out ___occuredException, sizeof( IntPtr ), image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithCGImage_options_( IntPtr image, NSDictionary options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCGImage_options_( Handle, CachedSelectors.initWithCGImage_options_, out ___occuredException, sizeof( IntPtr ) + sizeof( NSDictionary ), image, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithCGLayer_( IntPtr layer ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCGLayer_( Handle, CachedSelectors.initWithCGLayer_, out ___occuredException, sizeof( IntPtr ), layer );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithCGLayer_options_( IntPtr layer, NSDictionary options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCGLayer_options_( Handle, CachedSelectors.initWithCGLayer_options_, out ___occuredException, sizeof( IntPtr ) + sizeof( NSDictionary ), layer, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithCoder_( NObjective.RuntimeObject coder ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCoder_( Handle, CachedSelectors.initWithCoder_, out ___occuredException, sizeof( NObjective.RuntimeObject ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithColor_( NObjective.RuntimeObject color ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithColor_( Handle, CachedSelectors.initWithColor_, out ___occuredException, sizeof( NObjective.RuntimeObject ), color );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithContentsOfURL_( NSURL url ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithContentsOfURL_( Handle, CachedSelectors.initWithContentsOfURL_, out ___occuredException, sizeof( NSURL ), url );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithContentsOfURL_options_( NSURL url, NSDictionary options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithContentsOfURL_options_( Handle, CachedSelectors.initWithContentsOfURL_options_, out ___occuredException, sizeof( NSURL ) + sizeof( NSDictionary ), url, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithCVImageBuffer_( IntPtr buffer ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCVImageBuffer_( Handle, CachedSelectors.initWithCVImageBuffer_, out ___occuredException, sizeof( IntPtr ), buffer );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithCVImageBuffer_options_( IntPtr buffer, NSDictionary options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCVImageBuffer_options_( Handle, CachedSelectors.initWithCVImageBuffer_options_, out ___occuredException, sizeof( IntPtr ) + sizeof( NSDictionary ), buffer, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithData_( NSData data ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithData_( Handle, CachedSelectors.initWithData_, out ___occuredException, sizeof( NSData ), data );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithData_options_( NSData data, NSDictionary options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithData_options_( Handle, CachedSelectors.initWithData_options_, out ___occuredException, sizeof( NSData ) + sizeof( NSDictionary ), data, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithImageProvider_size__format_colorSpace_options_( NObjective.RuntimeObject provider, uint size, uint unnamedParameter, int format, IntPtr colorSpace, NSDictionary options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithImageProvider_size__format_colorSpace_options_( Handle, CachedSelectors.initWithImageProvider_size__format_colorSpace_options_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ) + sizeof( uint ) + sizeof( int ) + sizeof( IntPtr ) + sizeof( NSDictionary ), provider, size, unnamedParameter, format, colorSpace, options
			 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithJPEGFile_( NObjective.RuntimeObject file ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithJPEGFile_( Handle, CachedSelectors.initWithJPEGFile_, out ___occuredException, sizeof( NObjective.RuntimeObject ), file );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithJPEGFile_options_( NObjective.RuntimeObject file, NObjective.RuntimeObject options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithJPEGFile_options_( Handle, CachedSelectors.initWithJPEGFile_options_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), file, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithPNGFile_( NObjective.RuntimeObject file ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithPNGFile_( Handle, CachedSelectors.initWithPNGFile_, out ___occuredException, sizeof( NObjective.RuntimeObject ), file );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithPNGFile_options_( NObjective.RuntimeObject file, NObjective.RuntimeObject options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithPNGFile_options_( Handle, CachedSelectors.initWithPNGFile_options_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), file, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithTexture_size_flipped_colorSpace_( uint texture, CGSize size, bool flipped, IntPtr colorSpace ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithTexture_size_flipped_colorSpace_( Handle, CachedSelectors.initWithTexture_size_flipped_colorSpace_, out ___occuredException, sizeof( uint ) + sizeof( CGSize ) + sizeof( bool ) + sizeof( IntPtr ), texture, size, flipped, colorSpace );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithURL_( NObjective.RuntimeObject url ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithURL_( Handle, CachedSelectors.initWithURL_, out ___occuredException, sizeof( NObjective.RuntimeObject ), url );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject opaqueShape() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.opaqueShape( Handle, CachedSelectors.opaqueShape, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject promotedImage_( int image ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.promotedImage_( Handle, CachedSelectors.promotedImage_, out ___occuredException, sizeof( int ), image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setCacheHint_( char hint ) {
			RuntimeObject ___occuredException;
			NativeMethods.setCacheHint_( Handle, CachedSelectors.setCacheHint_, out ___occuredException, sizeof( char ), hint );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setUserInfo_( NObjective.RuntimeObject info ) {
			RuntimeObject ___occuredException;
			NativeMethods.setUserInfo_( Handle, CachedSelectors.setUserInfo_, out ___occuredException, sizeof( NObjective.RuntimeObject ), info );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject userInfo() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.userInfo( Handle, CachedSelectors.userInfo, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char cacheHint( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr definition( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void encodeWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSCoder coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_stret_eh2" )]
			public static extern void extent( out CGRect ___structAddress, int ___structSize, RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr filteredImage_keysAndValues_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject image, NObjective.RuntimeObject keysAndValues );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr imageByApplyingTransform_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, CGAffineTransform transform );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr imageByCompositingOverImage_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr imageByCroppingToShape_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject shape );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr imageWithBitmapData_bytesPerRow_size_format_colorSpace_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSData data, uint bytesPerRow, CGSize size, int format, IntPtr colorSpace );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr imageWithCGImage_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr imageWithCGImage_options_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr image, NSDictionary options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr imageWithCGLayer_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr layer );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr imageWithCGLayer_options_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr layer, NSDictionary options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr imageWithColor_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject color );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr imageWithContentsOfURL_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSURL url );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr imageWithContentsOfURL_options_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSURL url, NSDictionary options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr imageWithCVImageBuffer_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr buffer );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr imageWithCVImageBuffer_options_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr buffer, NSDictionary options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr imageWithData_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSData data );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr imageWithData_options_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSData data, NSDictionary options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr imageWithImageProvider_size__format_colorSpace_options_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject provider, uint size, uint unnamedParameter, int format, IntPtr colorSpace, NSDictionary options
			 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr imageWithJPEGFile_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr imageWithPNGFile_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr imageWithTexture_size_flipped_colorSpace_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint texture, CGSize size, bool flipped, IntPtr colorSpace );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr imageWithURL_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject url );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithBitmapData_bytesPerRow_size_format_colorSpace_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSData data, uint bytesPerRow, CGSize size, int format, IntPtr colorSpace );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCGImage_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCGImage_options_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr image, NSDictionary options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCGLayer_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr layer );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCGLayer_options_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr layer, NSDictionary options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithColor_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject color );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithContentsOfURL_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSURL url );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithContentsOfURL_options_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSURL url, NSDictionary options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCVImageBuffer_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr buffer );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCVImageBuffer_options_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr buffer, NSDictionary options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithData_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSData data );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithData_options_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSData data, NSDictionary options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithImageProvider_size__format_colorSpace_options_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject provider, uint size, uint unnamedParameter, int format, IntPtr colorSpace, NSDictionary options
			 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithJPEGFile_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithJPEGFile_options_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file, NObjective.RuntimeObject options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithPNGFile_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithPNGFile_options_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file, NObjective.RuntimeObject options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithTexture_size_flipped_colorSpace_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint texture, CGSize size, bool flipped, IntPtr colorSpace );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithURL_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject url );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr noiseImage( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr nullImage( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr opaqueShape( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr promotedImage_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setCacheHint_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, char hint );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setUserInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject info );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr userInfo( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector cacheHint = "cacheHint";
			public static readonly Selector definition = "definition";
			public static readonly Selector encodeWithCoder_ = "encodeWithCoder:";
			public static readonly Selector extent = "extent";
			public static readonly Selector filteredImage_keysAndValues_ = "filteredImage:keysAndValues:";
			public static readonly Selector imageByApplyingTransform_ = "imageByApplyingTransform:";
			public static readonly Selector imageByCompositingOverImage_ = "imageByCompositingOverImage:";
			public static readonly Selector imageByCroppingToShape_ = "imageByCroppingToShape:";
			public static readonly Selector imageWithBitmapData_bytesPerRow_size_format_colorSpace_ = "imageWithBitmapData:bytesPerRow:size:format:colorSpace:";
			public static readonly Selector imageWithCGImage_ = "imageWithCGImage:";
			public static readonly Selector imageWithCGImage_options_ = "imageWithCGImage:options:";
			public static readonly Selector imageWithCGLayer_ = "imageWithCGLayer:";
			public static readonly Selector imageWithCGLayer_options_ = "imageWithCGLayer:options:";
			public static readonly Selector imageWithColor_ = "imageWithColor:";
			public static readonly Selector imageWithContentsOfURL_ = "imageWithContentsOfURL:";
			public static readonly Selector imageWithContentsOfURL_options_ = "imageWithContentsOfURL:options:";
			public static readonly Selector imageWithCVImageBuffer_ = "imageWithCVImageBuffer:";
			public static readonly Selector imageWithCVImageBuffer_options_ = "imageWithCVImageBuffer:options:";
			public static readonly Selector imageWithData_ = "imageWithData:";
			public static readonly Selector imageWithData_options_ = "imageWithData:options:";
			public static readonly Selector imageWithImageProvider_size__format_colorSpace_options_ = "imageWithImageProvider:size::format:colorSpace:options:";
			public static readonly Selector imageWithJPEGFile_ = "imageWithJPEGFile:";
			public static readonly Selector imageWithPNGFile_ = "imageWithPNGFile:";
			public static readonly Selector imageWithTexture_size_flipped_colorSpace_ = "imageWithTexture:size:flipped:colorSpace:";
			public static readonly Selector imageWithURL_ = "imageWithURL:";
			public static readonly Selector initWithBitmapData_bytesPerRow_size_format_colorSpace_ = "initWithBitmapData:bytesPerRow:size:format:colorSpace:";
			public static readonly Selector initWithCGImage_ = "initWithCGImage:";
			public static readonly Selector initWithCGImage_options_ = "initWithCGImage:options:";
			public static readonly Selector initWithCGLayer_ = "initWithCGLayer:";
			public static readonly Selector initWithCGLayer_options_ = "initWithCGLayer:options:";
			public static readonly Selector initWithCoder_ = "initWithCoder:";
			public static readonly Selector initWithColor_ = "initWithColor:";
			public static readonly Selector initWithContentsOfURL_ = "initWithContentsOfURL:";
			public static readonly Selector initWithContentsOfURL_options_ = "initWithContentsOfURL:options:";
			public static readonly Selector initWithCVImageBuffer_ = "initWithCVImageBuffer:";
			public static readonly Selector initWithCVImageBuffer_options_ = "initWithCVImageBuffer:options:";
			public static readonly Selector initWithData_ = "initWithData:";
			public static readonly Selector initWithData_options_ = "initWithData:options:";
			public static readonly Selector initWithImageProvider_size__format_colorSpace_options_ = "initWithImageProvider:size::format:colorSpace:options:";
			public static readonly Selector initWithJPEGFile_ = "initWithJPEGFile:";
			public static readonly Selector initWithJPEGFile_options_ = "initWithJPEGFile:options:";
			public static readonly Selector initWithPNGFile_ = "initWithPNGFile:";
			public static readonly Selector initWithPNGFile_options_ = "initWithPNGFile:options:";
			public static readonly Selector initWithTexture_size_flipped_colorSpace_ = "initWithTexture:size:flipped:colorSpace:";
			public static readonly Selector initWithURL_ = "initWithURL:";
			public static readonly Selector noiseImage = "noiseImage";
			public static readonly Selector nullImage = "nullImage";
			public static readonly Selector opaqueShape = "opaqueShape";
			public static readonly Selector promotedImage_ = "promotedImage:";
			public static readonly Selector setCacheHint_ = "setCacheHint:";
			public static readonly Selector setUserInfo_ = "setUserInfo:";
			public static readonly Selector userInfo = "userInfo";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct CIImageAccumulator : IEquatable<CIImageAccumulator> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIImageAccumulator;
		public static implicit operator NSObject( CIImageAccumulator value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIImageAccumulator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIImageAccumulator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIImageAccumulator?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIImageAccumulator value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIImageAccumulator value1, CIImageAccumulator value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIImageAccumulator value1, CIImageAccumulator value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIImageAccumulator( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIImageAccumulator alloc() {
			return new CIImageAccumulator( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static CIImageAccumulator imageAccumulatorWithExtent_format_( CGRect extent, int format ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.imageAccumulatorWithExtent_format_( ClassHandle, CachedSelectors.imageAccumulatorWithExtent_format_, out ___occuredException, sizeof( CGRect ) + sizeof( int ), extent, format );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIImageAccumulator( ___result );
		}
		unsafe public void commitUpdates_( NObjective.RuntimeObject updates ) {
			RuntimeObject ___occuredException;
			NativeMethods.commitUpdates_( Handle, CachedSelectors.commitUpdates_, out ___occuredException, sizeof( NObjective.RuntimeObject ), updates );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public CGRect extent() {
			CGRect ___result;
			RuntimeObject ___occuredException;
			NativeMethods.extent( out ___result, sizeof( CGRect ), Handle, CachedSelectors.extent, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public int format() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.format( Handle, CachedSelectors.format, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public CIImage image() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.image( Handle, CachedSelectors.image, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIImage( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithExtent_format_( CGRect extent, int format ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithExtent_format_( Handle, CachedSelectors.initWithExtent_format_, out ___occuredException, sizeof( CGRect ) + sizeof( int ), extent, format );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setImage_( CIImage image ) {
			RuntimeObject ___occuredException;
			NativeMethods.setImage_( Handle, CachedSelectors.setImage_, out ___occuredException, sizeof( CIImage ), image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setImage_dirtyRect_( CIImage image, CGRect dirtyRect ) {
			RuntimeObject ___occuredException;
			NativeMethods.setImage_dirtyRect_( Handle, CachedSelectors.setImage_dirtyRect_, out ___occuredException, sizeof( CIImage ) + sizeof( CGRect ), image, dirtyRect );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void commitUpdates_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject updates );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_stret_eh2" )]
			public static extern void extent( out CGRect ___structAddress, int ___structSize, RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int format( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr image( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr imageAccumulatorWithExtent_format_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, CGRect extent, int format );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithExtent_format_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, CGRect extent, int format );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setImage_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, CIImage image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setImage_dirtyRect_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, CIImage image, CGRect dirtyRect );
		}
		static internal class CachedSelectors {
			public static readonly Selector commitUpdates_ = "commitUpdates:";
			public static readonly Selector extent = "extent";
			public static readonly Selector format = "format";
			public static readonly Selector image = "image";
			public static readonly Selector imageAccumulatorWithExtent_format_ = "imageAccumulatorWithExtent:format:";
			public static readonly Selector initWithExtent_format_ = "initWithExtent:format:";
			public static readonly Selector setImage_ = "setImage:";
			public static readonly Selector setImage_dirtyRect_ = "setImage:dirtyRect:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIKaleidoscope : IEquatable<CIKaleidoscope> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIKaleidoscope;
		public static implicit operator CIFilter( CIKaleidoscope value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIKaleidoscope value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIKaleidoscope value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIKaleidoscope value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIKaleidoscope?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIKaleidoscope value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIKaleidoscope value1, CIKaleidoscope value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIKaleidoscope value1, CIKaleidoscope value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIKaleidoscope( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIKaleidoscope alloc() {
			return new CIKaleidoscope( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void foldPolys_aboutCenterX_Y_atAngle_up_( NObjective.RuntimeObject polys, float aboutCenterX, float Y, float atAngle, char up ) {
			RuntimeObject ___occuredException;
			NativeMethods.foldPolys_aboutCenterX_Y_atAngle_up_( Handle, CachedSelectors.foldPolys_aboutCenterX_Y_atAngle_up_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( float ) + sizeof( float ) + sizeof( float ) + sizeof( char ), polys, aboutCenterX, Y, atAngle, up );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject genFold_aboutAngle_( NObjective.RuntimeObject fold, float aboutAngle ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.genFold_aboutAngle_( Handle, CachedSelectors.genFold_aboutAngle_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( float ), fold, aboutAngle );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void foldPolys_aboutCenterX_Y_atAngle_up_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject polys, float aboutCenterX, float Y, float atAngle, char up );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr genFold_aboutAngle_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject fold, float aboutAngle );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector foldPolys_aboutCenterX_Y_atAngle_up_ = "foldPolys:aboutCenterX:Y:atAngle:up:";
			public static readonly Selector genFold_aboutAngle_ = "genFold:aboutAngle:";
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct CIKernel : IEquatable<CIKernel> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIKernel;
		public static implicit operator NSObject( CIKernel value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIKernel value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIKernel value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIKernel?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIKernel value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIKernel value1, CIKernel value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIKernel value1, CIKernel value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIKernel( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIKernel alloc() {
			return new CIKernel( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject colorMatrixBiasKernel() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.colorMatrixBiasKernel( ClassHandle, CachedSelectors.colorMatrixBiasKernel, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject internCString_pointer_( System.IntPtr @string, System.IntPtr pointer ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.internCString_pointer_( ClassHandle, CachedSelectors.internCString_pointer_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( System.IntPtr ), @string, pointer );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NSArray kernelsWithString_( string @string ) {
			RuntimeObject ___occuredException;
			var ___wrappedstring = Runtime.CreateStringProxy( @string );
			var ___result = NativeMethods.kernelsWithString_( ClassHandle, CachedSelectors.kernelsWithString_, out ___occuredException, sizeof( IntPtr ), ___wrappedstring );
			Runtime.ReleaseNativeObject( ___wrappedstring );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NSArray( ___result );
		}
		unsafe public static NObjective.RuntimeObject kernelsWithString_messageLog_( NObjective.RuntimeObject @string, NObjective.RuntimeObject messageLog ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.kernelsWithString_messageLog_( ClassHandle, CachedSelectors.kernelsWithString_messageLog_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), @string, messageLog );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject apply_to_( NObjective.RuntimeObject apply, System.IntPtr to ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.apply_to_( Handle, CachedSelectors.apply_to_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), apply, to );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject apply_to_options_( NObjective.RuntimeObject apply, System.IntPtr to, NObjective.RuntimeObject options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.apply_to_options_( Handle, CachedSelectors.apply_to_options_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ), apply, to, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject apply_to_options1_options2_( NObjective.RuntimeObject apply, NObjective.RuntimeObject to, NObjective.RuntimeObject options1, NObjective.RuntimeObject options2 ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.apply_to_options1_options2_( Handle, CachedSelectors.apply_to_options1_options2_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), apply, to, options1, options2 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithCString_noCopy_( System.IntPtr @string, char noCopy ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCString_noCopy_( Handle, CachedSelectors.initWithCString_noCopy_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( char ), @string, noCopy );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public string name() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.name( Handle, CachedSelectors.name, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public NObjective.RuntimeObject parameters() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.parameters( Handle, CachedSelectors.parameters, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setROISelector_( NObjective.Selector selector ) {
			RuntimeObject ___occuredException;
			NativeMethods.setROISelector_( Handle, CachedSelectors.setROISelector_, out ___occuredException, sizeof( NObjective.Selector ), selector );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr apply_to_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject apply, System.IntPtr to );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr apply_to_options_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject apply, System.IntPtr to, NObjective.RuntimeObject options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr apply_to_options1_options2_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject apply, NObjective.RuntimeObject to, NObjective.RuntimeObject options1, NObjective.RuntimeObject options2 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr colorMatrixBiasKernel( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCString_noCopy_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr @string, char noCopy );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr internCString_pointer_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr @string, System.IntPtr pointer );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr kernelsWithString_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr @string );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr kernelsWithString_messageLog_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @string, NObjective.RuntimeObject messageLog );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr name( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr parameters( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setROISelector_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector );
		}
		static internal class CachedSelectors {
			public static readonly Selector apply_to_ = "apply:to:";
			public static readonly Selector apply_to_options_ = "apply:to:options:";
			public static readonly Selector apply_to_options1_options2_ = "apply:to:options1:options2:";
			public static readonly Selector colorMatrixBiasKernel = "colorMatrixBiasKernel";
			public static readonly Selector initWithCString_noCopy_ = "initWithCString:noCopy:";
			public static readonly Selector internCString_pointer_ = "internCString:pointer:";
			public static readonly Selector kernelsWithString_ = "kernelsWithString:";
			public static readonly Selector kernelsWithString_messageLog_ = "kernelsWithString:messageLog:";
			public static readonly Selector name = "name";
			public static readonly Selector parameters = "parameters";
			public static readonly Selector setROISelector_ = "setROISelector:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CILanczosBayerReconstruction : IEquatable<CILanczosBayerReconstruction> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CILanczosBayerReconstruction;
		public static implicit operator CIFilter( CILanczosBayerReconstruction value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CILanczosBayerReconstruction value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CILanczosBayerReconstruction value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CILanczosBayerReconstruction value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CILanczosBayerReconstruction?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CILanczosBayerReconstruction value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CILanczosBayerReconstruction value1, CILanczosBayerReconstruction value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CILanczosBayerReconstruction value1, CILanczosBayerReconstruction value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CILanczosBayerReconstruction( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CILanczosBayerReconstruction alloc() {
			return new CILanczosBayerReconstruction( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CILanczosResize : IEquatable<CILanczosResize> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CILanczosResize;
		public static implicit operator CIFilter( CILanczosResize value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CILanczosResize value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CILanczosResize value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CILanczosResize value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CILanczosResize?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CILanczosResize value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CILanczosResize value1, CILanczosResize value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CILanczosResize value1, CILanczosResize value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CILanczosResize( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CILanczosResize alloc() {
			return new CILanczosResize( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject lanczosTable() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.lanczosTable( Handle, CachedSelectors.lanczosTable, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr lanczosTable( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector lanczosTable = "lanczosTable";
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CILanczosScaleTransform : IEquatable<CILanczosScaleTransform> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CILanczosScaleTransform;
		public static implicit operator CIFilter( CILanczosScaleTransform value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CILanczosScaleTransform value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CILanczosScaleTransform value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CILanczosScaleTransform value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CILanczosScaleTransform?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CILanczosScaleTransform value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CILanczosScaleTransform value1, CILanczosScaleTransform value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CILanczosScaleTransform value1, CILanczosScaleTransform value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CILanczosScaleTransform( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CILanczosScaleTransform alloc() {
			return new CILanczosScaleTransform( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject lanczosTable() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.lanczosTable( Handle, CachedSelectors.lanczosTable, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr lanczosTable( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector lanczosTable = "lanczosTable";
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CILenticularHaloGenerator : IEquatable<CILenticularHaloGenerator> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CILenticularHaloGenerator;
		public static implicit operator CIFilter( CILenticularHaloGenerator value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CILenticularHaloGenerator value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CILenticularHaloGenerator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CILenticularHaloGenerator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CILenticularHaloGenerator?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CILenticularHaloGenerator value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CILenticularHaloGenerator value1, CILenticularHaloGenerator value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CILenticularHaloGenerator value1, CILenticularHaloGenerator value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CILenticularHaloGenerator( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CILenticularHaloGenerator alloc() {
			return new CILenticularHaloGenerator( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CILightenBlendMode : IEquatable<CILightenBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CILightenBlendMode;
		public static implicit operator CIFilter( CILightenBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CILightenBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CILightenBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CILightenBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CILightenBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CILightenBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CILightenBlendMode value1, CILightenBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CILightenBlendMode value1, CILightenBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CILightenBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CILightenBlendMode alloc() {
			return new CILightenBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CILinearBurnBlendMode : IEquatable<CILinearBurnBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CILinearBurnBlendMode;
		public static implicit operator CIFilter( CILinearBurnBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CILinearBurnBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CILinearBurnBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CILinearBurnBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CILinearBurnBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CILinearBurnBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CILinearBurnBlendMode value1, CILinearBurnBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CILinearBurnBlendMode value1, CILinearBurnBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CILinearBurnBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CILinearBurnBlendMode alloc() {
			return new CILinearBurnBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CILinearDodgeBlendMode : IEquatable<CILinearDodgeBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CILinearDodgeBlendMode;
		public static implicit operator CIFilter( CILinearDodgeBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CILinearDodgeBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CILinearDodgeBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CILinearDodgeBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CILinearDodgeBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CILinearDodgeBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CILinearDodgeBlendMode value1, CILinearDodgeBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CILinearDodgeBlendMode value1, CILinearDodgeBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CILinearDodgeBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CILinearDodgeBlendMode alloc() {
			return new CILinearDodgeBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CILinearGradient : IEquatable<CILinearGradient> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CILinearGradient;
		public static implicit operator CIFilter( CILinearGradient value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CILinearGradient value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CILinearGradient value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CILinearGradient value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CILinearGradient?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CILinearGradient value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CILinearGradient value1, CILinearGradient value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CILinearGradient value1, CILinearGradient value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CILinearGradient( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CILinearGradient alloc() {
			return new CILinearGradient( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CILinearLightBlendMode : IEquatable<CILinearLightBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CILinearLightBlendMode;
		public static implicit operator CIFilter( CILinearLightBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CILinearLightBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CILinearLightBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CILinearLightBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CILinearLightBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CILinearLightBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CILinearLightBlendMode value1, CILinearLightBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CILinearLightBlendMode value1, CILinearLightBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CILinearLightBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CILinearLightBlendMode alloc() {
			return new CILinearLightBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CILineScreen : IEquatable<CILineScreen> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CILineScreen;
		public static implicit operator CIFilter( CILineScreen value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CILineScreen value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CILineScreen value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CILineScreen value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CILineScreen?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CILineScreen value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CILineScreen value1, CILineScreen value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CILineScreen value1, CILineScreen value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CILineScreen( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CILineScreen alloc() {
			return new CILineScreen( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CILuminanceGamutMapping : IEquatable<CILuminanceGamutMapping> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CILuminanceGamutMapping;
		public static implicit operator CIFilter( CILuminanceGamutMapping value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CILuminanceGamutMapping value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CILuminanceGamutMapping value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CILuminanceGamutMapping value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CILuminanceGamutMapping?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CILuminanceGamutMapping value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CILuminanceGamutMapping value1, CILuminanceGamutMapping value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CILuminanceGamutMapping value1, CILuminanceGamutMapping value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CILuminanceGamutMapping( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CILuminanceGamutMapping alloc() {
			return new CILuminanceGamutMapping( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CILuminescentPremultiplyBlendMode : IEquatable<CILuminescentPremultiplyBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CILuminescentPremultiplyBlendMode;
		public static implicit operator CIFilter( CILuminescentPremultiplyBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CILuminescentPremultiplyBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CILuminescentPremultiplyBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CILuminescentPremultiplyBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CILuminescentPremultiplyBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CILuminescentPremultiplyBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CILuminescentPremultiplyBlendMode value1, CILuminescentPremultiplyBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CILuminescentPremultiplyBlendMode value1, CILuminescentPremultiplyBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CILuminescentPremultiplyBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CILuminescentPremultiplyBlendMode alloc() {
			return new CILuminescentPremultiplyBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CILuminosityBlendMode : IEquatable<CILuminosityBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CILuminosityBlendMode;
		public static implicit operator CIFilter( CILuminosityBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CILuminosityBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CILuminosityBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CILuminosityBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CILuminosityBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CILuminosityBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CILuminosityBlendMode value1, CILuminosityBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CILuminosityBlendMode value1, CILuminosityBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CILuminosityBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CILuminosityBlendMode alloc() {
			return new CILuminosityBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIMaskToAlpha : IEquatable<CIMaskToAlpha> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIMaskToAlpha;
		public static implicit operator CIFilter( CIMaskToAlpha value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIMaskToAlpha value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIMaskToAlpha value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIMaskToAlpha value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIMaskToAlpha?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIMaskToAlpha value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIMaskToAlpha value1, CIMaskToAlpha value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIMaskToAlpha value1, CIMaskToAlpha value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIMaskToAlpha( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIMaskToAlpha alloc() {
			return new CIMaskToAlpha( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIMaterialMap : IEquatable<CIMaterialMap> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIMaterialMap;
		public static implicit operator CIFilter( CIMaterialMap value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIMaterialMap value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIMaterialMap value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIMaterialMap value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIMaterialMap?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIMaterialMap value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIMaterialMap value1, CIMaterialMap value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIMaterialMap value1, CIMaterialMap value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIMaterialMap( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIMaterialMap alloc() {
			return new CIMaterialMap( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIMaximumCompositing : IEquatable<CIMaximumCompositing> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIMaximumCompositing;
		public static implicit operator CIFilter( CIMaximumCompositing value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIMaximumCompositing value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIMaximumCompositing value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIMaximumCompositing value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIMaximumCompositing?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIMaximumCompositing value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIMaximumCompositing value1, CIMaximumCompositing value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIMaximumCompositing value1, CIMaximumCompositing value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIMaximumCompositing( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIMaximumCompositing alloc() {
			return new CIMaximumCompositing( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIMedianFilter : IEquatable<CIMedianFilter> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIMedianFilter;
		public static implicit operator CIFilter( CIMedianFilter value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIMedianFilter value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIMedianFilter value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIMedianFilter value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIMedianFilter?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIMedianFilter value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIMedianFilter value1, CIMedianFilter value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIMedianFilter value1, CIMedianFilter value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIMedianFilter( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIMedianFilter alloc() {
			return new CIMedianFilter( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIMinimumCompositing : IEquatable<CIMinimumCompositing> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIMinimumCompositing;
		public static implicit operator CIFilter( CIMinimumCompositing value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIMinimumCompositing value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIMinimumCompositing value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIMinimumCompositing value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIMinimumCompositing?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIMinimumCompositing value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIMinimumCompositing value1, CIMinimumCompositing value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIMinimumCompositing value1, CIMinimumCompositing value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIMinimumCompositing( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIMinimumCompositing alloc() {
			return new CIMinimumCompositing( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIMixOver : IEquatable<CIMixOver> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIMixOver;
		public static implicit operator CIFilter( CIMixOver value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIMixOver value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIMixOver value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIMixOver value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIMixOver?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIMixOver value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIMixOver value1, CIMixOver value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIMixOver value1, CIMixOver value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIMixOver( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIMixOver alloc() {
			return new CIMixOver( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIModTransition : IEquatable<CIModTransition> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIModTransition;
		public static implicit operator CIFilter( CIModTransition value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIModTransition value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIModTransition value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIModTransition value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIModTransition?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIModTransition value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIModTransition value1, CIModTransition value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIModTransition value1, CIModTransition value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIModTransition( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIModTransition alloc() {
			return new CIModTransition( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIMotionBlur : IEquatable<CIMotionBlur> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIMotionBlur;
		public static implicit operator CIFilter( CIMotionBlur value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIMotionBlur value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIMotionBlur value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIMotionBlur value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIMotionBlur?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIMotionBlur value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIMotionBlur value1, CIMotionBlur value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIMotionBlur value1, CIMotionBlur value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIMotionBlur( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIMotionBlur alloc() {
			return new CIMotionBlur( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject blur_pass_( NObjective.RuntimeObject blur, int pass ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.blur_pass_( Handle, CachedSelectors.blur_pass_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( int ), blur, pass );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr blur_pass_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject blur, int pass );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector blur_pass_ = "blur:pass:";
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIMultiplyBlendMode : IEquatable<CIMultiplyBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIMultiplyBlendMode;
		public static implicit operator CIFilter( CIMultiplyBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIMultiplyBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIMultiplyBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIMultiplyBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIMultiplyBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIMultiplyBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIMultiplyBlendMode value1, CIMultiplyBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIMultiplyBlendMode value1, CIMultiplyBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIMultiplyBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIMultiplyBlendMode alloc() {
			return new CIMultiplyBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIMultiplyCompositing : IEquatable<CIMultiplyCompositing> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIMultiplyCompositing;
		public static implicit operator CIFilter( CIMultiplyCompositing value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIMultiplyCompositing value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIMultiplyCompositing value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIMultiplyCompositing value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIMultiplyCompositing?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIMultiplyCompositing value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIMultiplyCompositing value1, CIMultiplyCompositing value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIMultiplyCompositing value1, CIMultiplyCompositing value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIMultiplyCompositing( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIMultiplyCompositing alloc() {
			return new CIMultiplyCompositing( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilterShape ) )]
	public struct CIMutableFilterShape : IEquatable<CIMutableFilterShape> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIMutableFilterShape;
		public static implicit operator CIFilterShape( CIMutableFilterShape value ) {
			return new CIFilterShape( value.Handle );
		}
		public static implicit operator NSObject( CIMutableFilterShape value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIMutableFilterShape value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIMutableFilterShape value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIMutableFilterShape?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIMutableFilterShape value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIMutableFilterShape value1, CIMutableFilterShape value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIMutableFilterShape value1, CIMutableFilterShape value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIMutableFilterShape( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIMutableFilterShape alloc() {
			return new CIMutableFilterShape( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void insetByX_Y_( int x, int Y ) {
			RuntimeObject ___occuredException;
			NativeMethods.insetByX_Y_( Handle, CachedSelectors.insetByX_Y_, out ___occuredException, sizeof( int ) + sizeof( int ), x, Y );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void intersect_( NObjective.RuntimeObject intersect ) {
			RuntimeObject ___occuredException;
			NativeMethods.intersect_( Handle, CachedSelectors.intersect_, out ___occuredException, sizeof( NObjective.RuntimeObject ), intersect );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void subtract_( NObjective.RuntimeObject subtract ) {
			RuntimeObject ___occuredException;
			NativeMethods.subtract_( Handle, CachedSelectors.subtract_, out ___occuredException, sizeof( NObjective.RuntimeObject ), subtract );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void union_( NObjective.RuntimeObject union ) {
			RuntimeObject ___occuredException;
			NativeMethods.union_( Handle, CachedSelectors.union_, out ___occuredException, sizeof( NObjective.RuntimeObject ), union );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void insetByX_Y_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int x, int Y );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void intersect_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject intersect );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void subtract_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject subtract );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void union_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject union );
		}
		static internal class CachedSelectors {
			public static readonly Selector insetByX_Y_ = "insetByX:Y:";
			public static readonly Selector intersect_ = "intersect:";
			public static readonly Selector subtract_ = "subtract:";
			public static readonly Selector union_ = "union:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIUIBundle ) )]
	public struct CIMutableUIBundle : IEquatable<CIMutableUIBundle> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIMutableUIBundle;
		public static implicit operator CIUIBundle( CIMutableUIBundle value ) {
			return new CIUIBundle( value.Handle );
		}
		public static implicit operator NSObject( CIMutableUIBundle value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIMutableUIBundle value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIMutableUIBundle value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIMutableUIBundle?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIMutableUIBundle value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIMutableUIBundle value1, CIMutableUIBundle value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIMutableUIBundle value1, CIMutableUIBundle value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIMutableUIBundle( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIMutableUIBundle alloc() {
			return new CIMutableUIBundle( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static void differenceParameter_new_old_into_( int parameter, NObjective.RuntimeObject @new, NObjective.RuntimeObject old, NObjective.RuntimeObject @into ) {
			RuntimeObject ___occuredException;
			NativeMethods.differenceParameter_new_old_into_( ClassHandle, CachedSelectors.differenceParameter_new_old_into_, out ___occuredException, sizeof( int ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), parameter, @new, old, @into );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static char parameter_differs_from_( int parameter, NObjective.RuntimeObject differs, NObjective.RuntimeObject @from ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.parameter_differs_from_( ClassHandle, CachedSelectors.parameter_differs_from_, out ___occuredException, sizeof( int ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), parameter, differs, @from );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static NObjective.RuntimeObject recipeDifference_with_( NObjective.RuntimeObject difference, NObjective.RuntimeObject with ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.recipeDifference_with_( ClassHandle, CachedSelectors.recipeDifference_with_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), difference, with );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static char recipeDiffers_from_( NObjective.RuntimeObject differs, NObjective.RuntimeObject @from ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.recipeDiffers_from_( ClassHandle, CachedSelectors.recipeDiffers_from_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), differs, @from );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static void simplifyFloatString_to_( System.IntPtr @string, System.IntPtr to ) {
			RuntimeObject ___occuredException;
			NativeMethods.simplifyFloatString_to_( ClassHandle, CachedSelectors.simplifyFloatString_to_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( System.IntPtr ), @string, to );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void addSubnode_( NObjective.RuntimeObject subnode ) {
			RuntimeObject ___occuredException;
			NativeMethods.addSubnode_( Handle, CachedSelectors.addSubnode_, out ___occuredException, sizeof( NObjective.RuntimeObject ), subnode );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public char changes() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.changes( Handle, CachedSelectors.changes, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void closeRoot() {
			RuntimeObject ___occuredException;
			NativeMethods.closeRoot( Handle, CachedSelectors.closeRoot, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject copySubtreePattern() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.copySubtreePattern( Handle, CachedSelectors.copySubtreePattern, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject deepNodeCopy_( NObjective.RuntimeObject copy ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.deepNodeCopy_( Handle, CachedSelectors.deepNodeCopy_, out ___occuredException, sizeof( NObjective.RuntimeObject ), copy );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject deepPropertiesCopy_( NObjective.RuntimeObject copy ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.deepPropertiesCopy_( Handle, CachedSelectors.deepPropertiesCopy_, out ___occuredException, sizeof( NObjective.RuntimeObject ), copy );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject deepSubnodeCopy_( NObjective.RuntimeObject copy ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.deepSubnodeCopy_( Handle, CachedSelectors.deepSubnodeCopy_, out ___occuredException, sizeof( NObjective.RuntimeObject ), copy );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void deleteNode() {
			RuntimeObject ___occuredException;
			NativeMethods.deleteNode( Handle, CachedSelectors.deleteNode, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void initializeButtonStructureAtX_y_forResolution_( float x, float y, int forResolution ) {
			RuntimeObject ___occuredException;
			NativeMethods.initializeButtonStructureAtX_y_forResolution_( Handle, CachedSelectors.initializeButtonStructureAtX_y_forResolution_, out ___occuredException, sizeof( float ) + sizeof( float ) + sizeof( int ), x, y, forResolution );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public bool isSubtree() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isSubtree( Handle, CachedSelectors.isSubtree, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void pasteSubtreePattern_( NObjective.RuntimeObject pattern ) {
			RuntimeObject ___occuredException;
			NativeMethods.pasteSubtreePattern_( Handle, CachedSelectors.pasteSubtreePattern_, out ___occuredException, sizeof( NObjective.RuntimeObject ), pattern );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void popSubnode() {
			RuntimeObject ___occuredException;
			NativeMethods.popSubnode( Handle, CachedSelectors.popSubnode, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject recipe() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.recipe( Handle, CachedSelectors.recipe, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void renameNode_( NObjective.RuntimeObject node ) {
			RuntimeObject ___occuredException;
			NativeMethods.renameNode_( Handle, CachedSelectors.renameNode_, out ___occuredException, sizeof( NObjective.RuntimeObject ), node );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void restorePreviousParameterValue_( NObjective.RuntimeObject value ) {
			RuntimeObject ___occuredException;
			NativeMethods.restorePreviousParameterValue_( Handle, CachedSelectors.restorePreviousParameterValue_, out ___occuredException, sizeof( NObjective.RuntimeObject ), value );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void saveParameter_to_( int parameter, NObjective.RuntimeObject to ) {
			RuntimeObject ___occuredException;
			NativeMethods.saveParameter_to_( Handle, CachedSelectors.saveParameter_to_, out ___occuredException, sizeof( int ) + sizeof( NObjective.RuntimeObject ), parameter, to );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void saveRecipeChanges() {
			RuntimeObject ___occuredException;
			NativeMethods.saveRecipeChanges( Handle, CachedSelectors.saveRecipeChanges, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void saveRoot() {
			RuntimeObject ___occuredException;
			NativeMethods.saveRoot( Handle, CachedSelectors.saveRoot, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setButtonEMap_( NObjective.RuntimeObject map ) {
			RuntimeObject ___occuredException;
			NativeMethods.setButtonEMap_( Handle, CachedSelectors.setButtonEMap_, out ___occuredException, sizeof( NObjective.RuntimeObject ), map );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setFigure_( NObjective.RuntimeObject figure ) {
			RuntimeObject ___occuredException;
			NativeMethods.setFigure_( Handle, CachedSelectors.setFigure_, out ___occuredException, sizeof( NObjective.RuntimeObject ), figure );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setHighlightEMap_( NObjective.RuntimeObject map ) {
			RuntimeObject ___occuredException;
			NativeMethods.setHighlightEMap_( Handle, CachedSelectors.setHighlightEMap_, out ___occuredException, sizeof( NObjective.RuntimeObject ), map );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setInlayEMap_( NObjective.RuntimeObject map ) {
			RuntimeObject ___occuredException;
			NativeMethods.setInlayEMap_( Handle, CachedSelectors.setInlayEMap_, out ___occuredException, sizeof( NObjective.RuntimeObject ), map );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setStripeGradient_( NObjective.RuntimeObject gradient ) {
			RuntimeObject ___occuredException;
			NativeMethods.setStripeGradient_( Handle, CachedSelectors.setStripeGradient_, out ___occuredException, sizeof( NObjective.RuntimeObject ), gradient );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void updateRoot() {
			RuntimeObject ___occuredException;
			NativeMethods.updateRoot( Handle, CachedSelectors.updateRoot, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void addSubnode_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject subnode );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char changes( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void closeRoot( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr copySubtreePattern( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr deepNodeCopy_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject copy );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr deepPropertiesCopy_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject copy );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr deepSubnodeCopy_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject copy );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void deleteNode( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void differenceParameter_new_old_into_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int parameter, NObjective.RuntimeObject @new, NObjective.RuntimeObject old, NObjective.RuntimeObject @into );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void initializeButtonStructureAtX_y_forResolution_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, float x, float y, int forResolution );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isSubtree( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char parameter_differs_from_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int parameter, NObjective.RuntimeObject differs, NObjective.RuntimeObject @from );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void pasteSubtreePattern_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject pattern );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void popSubnode( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr recipe( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr recipeDifference_with_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject difference, NObjective.RuntimeObject with );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern char recipeDiffers_from_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject differs, NObjective.RuntimeObject @from );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void renameNode_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject node );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void restorePreviousParameterValue_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject value );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void saveParameter_to_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int parameter, NObjective.RuntimeObject to );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void saveRecipeChanges( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void saveRoot( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setButtonEMap_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject map );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setFigure_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject figure );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setHighlightEMap_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject map );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setInlayEMap_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject map );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setStripeGradient_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject gradient );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void simplifyFloatString_to_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr @string, System.IntPtr to );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void updateRoot( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector addSubnode_ = "addSubnode:";
			public static readonly Selector changes = "changes";
			public static readonly Selector closeRoot = "closeRoot";
			public static readonly Selector copySubtreePattern = "copySubtreePattern";
			public static readonly Selector deepNodeCopy_ = "deepNodeCopy:";
			public static readonly Selector deepPropertiesCopy_ = "deepPropertiesCopy:";
			public static readonly Selector deepSubnodeCopy_ = "deepSubnodeCopy:";
			public static readonly Selector deleteNode = "deleteNode";
			public static readonly Selector differenceParameter_new_old_into_ = "differenceParameter:new:old:into:";
			public static readonly Selector initializeButtonStructureAtX_y_forResolution_ = "initializeButtonStructureAtX:y:forResolution:";
			public static readonly Selector isSubtree = "isSubtree";
			public static readonly Selector parameter_differs_from_ = "parameter:differs:from:";
			public static readonly Selector pasteSubtreePattern_ = "pasteSubtreePattern:";
			public static readonly Selector popSubnode = "popSubnode";
			public static readonly Selector recipe = "recipe";
			public static readonly Selector recipeDifference_with_ = "recipeDifference:with:";
			public static readonly Selector recipeDiffers_from_ = "recipeDiffers:from:";
			public static readonly Selector renameNode_ = "renameNode:";
			public static readonly Selector restorePreviousParameterValue_ = "restorePreviousParameterValue:";
			public static readonly Selector saveParameter_to_ = "saveParameter:to:";
			public static readonly Selector saveRecipeChanges = "saveRecipeChanges";
			public static readonly Selector saveRoot = "saveRoot";
			public static readonly Selector setButtonEMap_ = "setButtonEMap:";
			public static readonly Selector setFigure_ = "setFigure:";
			public static readonly Selector setHighlightEMap_ = "setHighlightEMap:";
			public static readonly Selector setInlayEMap_ = "setInlayEMap:";
			public static readonly Selector setStripeGradient_ = "setStripeGradient:";
			public static readonly Selector simplifyFloatString_to_ = "simplifyFloatString:to:";
			public static readonly Selector updateRoot = "updateRoot";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CINoiseReduction : IEquatable<CINoiseReduction> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CINoiseReduction;
		public static implicit operator CIFilter( CINoiseReduction value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CINoiseReduction value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CINoiseReduction value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CINoiseReduction value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CINoiseReduction?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CINoiseReduction value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CINoiseReduction value1, CINoiseReduction value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CINoiseReduction value1, CINoiseReduction value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CINoiseReduction( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CINoiseReduction alloc() {
			return new CINoiseReduction( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIOpacity : IEquatable<CIOpacity> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIOpacity;
		public static implicit operator CIFilter( CIOpacity value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIOpacity value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIOpacity value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIOpacity value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIOpacity?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIOpacity value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIOpacity value1, CIOpacity value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIOpacity value1, CIOpacity value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIOpacity( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIOpacity alloc() {
			return new CIOpacity( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIContext ) )]
	public struct CIOpenGLContext : IEquatable<CIOpenGLContext> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIOpenGLContext;
		public static implicit operator CIContext( CIOpenGLContext value ) {
			return new CIContext( value.Handle );
		}
		public static implicit operator NSObject( CIOpenGLContext value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIOpenGLContext value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIOpenGLContext value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIOpenGLContext?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIOpenGLContext value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIOpenGLContext value1, CIOpenGLContext value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIOpenGLContext value1, CIOpenGLContext value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIOpenGLContext( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIOpenGLContext alloc() {
			return new CIOpenGLContext( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject contextWithCGLSContext_pixelFormat_( System.IntPtr context, System.IntPtr pixelFormat ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.contextWithCGLSContext_pixelFormat_( ClassHandle, CachedSelectors.contextWithCGLSContext_pixelFormat_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( System.IntPtr ), context, pixelFormat );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject contextWithCGLSContext_pixelFormat_options_( System.IntPtr context, System.IntPtr pixelFormat, NObjective.RuntimeObject options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.contextWithCGLSContext_pixelFormat_options_( ClassHandle, CachedSelectors.contextWithCGLSContext_pixelFormat_options_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ), context, pixelFormat, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithCGLSContext_pixelFormat_( System.IntPtr context, System.IntPtr pixelFormat ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCGLSContext_pixelFormat_( Handle, CachedSelectors.initWithCGLSContext_pixelFormat_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( System.IntPtr ), context, pixelFormat );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithCGLSContext_pixelFormat_options_( System.IntPtr context, System.IntPtr pixelFormat, NObjective.RuntimeObject options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCGLSContext_pixelFormat_options_( Handle, CachedSelectors.initWithCGLSContext_pixelFormat_options_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ), context, pixelFormat, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithOptions_( NObjective.RuntimeObject options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithOptions_( Handle, CachedSelectors.initWithOptions_, out ___occuredException, sizeof( NObjective.RuntimeObject ), options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr contextWithCGLSContext_pixelFormat_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr context, System.IntPtr pixelFormat );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr contextWithCGLSContext_pixelFormat_options_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr context, System.IntPtr pixelFormat, NObjective.RuntimeObject options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCGLSContext_pixelFormat_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr context, System.IntPtr pixelFormat );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCGLSContext_pixelFormat_options_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr context, System.IntPtr pixelFormat, NObjective.RuntimeObject options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithOptions_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject options );
		}
		static internal class CachedSelectors {
			public static readonly Selector contextWithCGLSContext_pixelFormat_ = "contextWithCGLSContext:pixelFormat:";
			public static readonly Selector contextWithCGLSContext_pixelFormat_options_ = "contextWithCGLSContext:pixelFormat:options:";
			public static readonly Selector initWithCGLSContext_pixelFormat_ = "initWithCGLSContext:pixelFormat:";
			public static readonly Selector initWithCGLSContext_pixelFormat_options_ = "initWithCGLSContext:pixelFormat:options:";
			public static readonly Selector initWithOptions_ = "initWithOptions:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIContextImpl ) )]
	public struct CIOpenGLContextImpl : IEquatable<CIOpenGLContextImpl> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIOpenGLContextImpl;
		public static implicit operator CIContextImpl( CIOpenGLContextImpl value ) {
			return new CIContextImpl( value.Handle );
		}
		public static implicit operator NSObject( CIOpenGLContextImpl value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIOpenGLContextImpl value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIOpenGLContextImpl value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIOpenGLContextImpl?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIOpenGLContextImpl value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIOpenGLContextImpl value1, CIOpenGLContextImpl value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIOpenGLContextImpl value1, CIOpenGLContextImpl value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIOpenGLContextImpl( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIOpenGLContextImpl alloc() {
			return new CIOpenGLContextImpl( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject initWithCGLSContext_pixelFormat_options_( System.IntPtr context, System.IntPtr pixelFormat, NObjective.RuntimeObject options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCGLSContext_pixelFormat_options_( Handle, CachedSelectors.initWithCGLSContext_pixelFormat_options_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ), context, pixelFormat, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithGLContext_pixelFormat_vtable_options_( System.IntPtr context, System.IntPtr pixelFormat, System.IntPtr vtable, NObjective.RuntimeObject options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithGLContext_pixelFormat_vtable_options_( Handle, CachedSelectors.initWithGLContext_pixelFormat_vtable_options_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( System.IntPtr ) + sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ), context, pixelFormat, vtable, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void invalidate() {
			RuntimeObject ___occuredException;
			NativeMethods.invalidate( Handle, CachedSelectors.invalidate, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void updateContext() {
			RuntimeObject ___occuredException;
			NativeMethods.updateContext( Handle, CachedSelectors.updateContext, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCGLSContext_pixelFormat_options_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr context, System.IntPtr pixelFormat, NObjective.RuntimeObject options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithGLContext_pixelFormat_vtable_options_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr context, System.IntPtr pixelFormat, System.IntPtr vtable, NObjective.RuntimeObject options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void invalidate( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void updateContext( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithCGLSContext_pixelFormat_options_ = "initWithCGLSContext:pixelFormat:options:";
			public static readonly Selector initWithGLContext_pixelFormat_vtable_options_ = "initWithGLContext:pixelFormat:vtable:options:";
			public static readonly Selector invalidate = "invalidate";
			public static readonly Selector updateContext = "updateContext";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIOpTile : IEquatable<CIOpTile> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIOpTile;
		public static implicit operator CIFilter( CIOpTile value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIOpTile value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIOpTile value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIOpTile value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIOpTile?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIOpTile value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIOpTile value1, CIOpTile value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIOpTile value1, CIOpTile value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIOpTile( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIOpTile alloc() {
			return new CIOpTile( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIOverlayBlendMode : IEquatable<CIOverlayBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIOverlayBlendMode;
		public static implicit operator CIFilter( CIOverlayBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIOverlayBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIOverlayBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIOverlayBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIOverlayBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIOverlayBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIOverlayBlendMode value1, CIOverlayBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIOverlayBlendMode value1, CIOverlayBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIOverlayBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIOverlayBlendMode alloc() {
			return new CIOverlayBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIPageCurlTransition : IEquatable<CIPageCurlTransition> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIPageCurlTransition;
		public static implicit operator CIFilter( CIPageCurlTransition value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIPageCurlTransition value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIPageCurlTransition value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIPageCurlTransition value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIPageCurlTransition?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIPageCurlTransition value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIPageCurlTransition value1, CIPageCurlTransition value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIPageCurlTransition value1, CIPageCurlTransition value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIPageCurlTransition( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIPageCurlTransition alloc() {
			return new CIPageCurlTransition( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIParallelogramTile : IEquatable<CIParallelogramTile> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIParallelogramTile;
		public static implicit operator CIFilter( CIParallelogramTile value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIParallelogramTile value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIParallelogramTile value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIParallelogramTile value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIParallelogramTile?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIParallelogramTile value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIParallelogramTile value1, CIParallelogramTile value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIParallelogramTile value1, CIParallelogramTile value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIParallelogramTile( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIParallelogramTile alloc() {
			return new CIParallelogramTile( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIPerspectiveTile : IEquatable<CIPerspectiveTile> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIPerspectiveTile;
		public static implicit operator CIFilter( CIPerspectiveTile value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIPerspectiveTile value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIPerspectiveTile value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIPerspectiveTile value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIPerspectiveTile?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIPerspectiveTile value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIPerspectiveTile value1, CIPerspectiveTile value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIPerspectiveTile value1, CIPerspectiveTile value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIPerspectiveTile( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIPerspectiveTile alloc() {
			return new CIPerspectiveTile( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIPerspectiveTransform : IEquatable<CIPerspectiveTransform> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIPerspectiveTransform;
		public static implicit operator CIFilter( CIPerspectiveTransform value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIPerspectiveTransform value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIPerspectiveTransform value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIPerspectiveTransform value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIPerspectiveTransform?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIPerspectiveTransform value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIPerspectiveTransform value1, CIPerspectiveTransform value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIPerspectiveTransform value1, CIPerspectiveTransform value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIPerspectiveTransform( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIPerspectiveTransform alloc() {
			return new CIPerspectiveTransform( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIPinchDistortion : IEquatable<CIPinchDistortion> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIPinchDistortion;
		public static implicit operator CIFilter( CIPinchDistortion value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIPinchDistortion value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIPinchDistortion value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIPinchDistortion value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIPinchDistortion?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIPinchDistortion value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIPinchDistortion value1, CIPinchDistortion value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIPinchDistortion value1, CIPinchDistortion value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIPinchDistortion( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIPinchDistortion alloc() {
			return new CIPinchDistortion( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIPinLightBlendMode : IEquatable<CIPinLightBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIPinLightBlendMode;
		public static implicit operator CIFilter( CIPinLightBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIPinLightBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIPinLightBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIPinLightBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIPinLightBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIPinLightBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIPinLightBlendMode value1, CIPinLightBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIPinLightBlendMode value1, CIPinLightBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIPinLightBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIPinLightBlendMode alloc() {
			return new CIPinLightBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIPixellate : IEquatable<CIPixellate> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIPixellate;
		public static implicit operator CIFilter( CIPixellate value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIPixellate value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIPixellate value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIPixellate value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIPixellate?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIPixellate value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIPixellate value1, CIPixellate value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIPixellate value1, CIPixellate value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIPixellate( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIPixellate alloc() {
			return new CIPixellate( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIPixelZoom : IEquatable<CIPixelZoom> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIPixelZoom;
		public static implicit operator CIFilter( CIPixelZoom value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIPixelZoom value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIPixelZoom value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIPixelZoom value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIPixelZoom?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIPixelZoom value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIPixelZoom value1, CIPixelZoom value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIPixelZoom value1, CIPixelZoom value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIPixelZoom( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIPixelZoom alloc() {
			return new CIPixelZoom( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct CIPlugIn : IEquatable<CIPlugIn> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIPlugIn;
		public static implicit operator NSObject( CIPlugIn value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIPlugIn value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIPlugIn value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIPlugIn?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIPlugIn value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIPlugIn value1, CIPlugIn value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIPlugIn value1, CIPlugIn value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIPlugIn( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIPlugIn alloc() {
			return new CIPlugIn( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static void loadAllPlugIns() {
			RuntimeObject ___occuredException;
			NativeMethods.loadAllPlugIns( ClassHandle, CachedSelectors.loadAllPlugIns, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static void loadNonExecutablePlugIns() {
			RuntimeObject ___occuredException;
			NativeMethods.loadNonExecutablePlugIns( ClassHandle, CachedSelectors.loadNonExecutablePlugIns, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static void loadPlugIn_allowNonExecutable_( NSURL @in, bool allowNonExecutable ) {
			RuntimeObject ___occuredException;
			NativeMethods.loadPlugIn_allowNonExecutable_( ClassHandle, CachedSelectors.loadPlugIn_allowNonExecutable_, out ___occuredException, sizeof( NSURL ) + sizeof( bool ), @in, allowNonExecutable );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject initWithURL_allowNonExecutable_( NObjective.RuntimeObject url, char allowNonExecutable ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithURL_allowNonExecutable_( Handle, CachedSelectors.initWithURL_allowNonExecutable_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( char ), url, allowNonExecutable );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public int loadPlugIn() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.loadPlugIn( Handle, CachedSelectors.loadPlugIn, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithURL_allowNonExecutable_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject url, char allowNonExecutable );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void loadAllPlugIns( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void loadNonExecutablePlugIns( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int loadPlugIn( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void loadPlugIn_allowNonExecutable_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSURL @in, bool allowNonExecutable );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithURL_allowNonExecutable_ = "initWithURL:allowNonExecutable:";
			public static readonly Selector loadAllPlugIns = "loadAllPlugIns";
			public static readonly Selector loadNonExecutablePlugIns = "loadNonExecutablePlugIns";
			public static readonly Selector loadPlugIn = "loadPlugIn";
			public static readonly Selector loadPlugIn_allowNonExecutable_ = "loadPlugIn:allowNonExecutable:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIPlugInStandardFilter : IEquatable<CIPlugInStandardFilter> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIPlugInStandardFilter;
		public static implicit operator CIFilter( CIPlugInStandardFilter value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIPlugInStandardFilter value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIPlugInStandardFilter value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIPlugInStandardFilter value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIPlugInStandardFilter?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIPlugInStandardFilter value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIPlugInStandardFilter value1, CIPlugInStandardFilter value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIPlugInStandardFilter value1, CIPlugInStandardFilter value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIPlugInStandardFilter( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIPlugInStandardFilter alloc() {
			return new CIPlugInStandardFilter( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject initWithDescription_kernelFile_filterBundle_( NObjective.RuntimeObject description, NObjective.RuntimeObject kernelFile, NObjective.RuntimeObject filterBundle ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithDescription_kernelFile_filterBundle_( Handle, CachedSelectors.initWithDescription_kernelFile_filterBundle_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), description, kernelFile, filterBundle );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void loadKernel() {
			RuntimeObject ___occuredException;
			NativeMethods.loadKernel( Handle, CachedSelectors.loadKernel, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithDescription_kernelFile_filterBundle_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject description, NObjective.RuntimeObject kernelFile, NObjective.RuntimeObject filterBundle );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void loadKernel( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithDescription_kernelFile_filterBundle_ = "initWithDescription:kernelFile:filterBundle:";
			public static readonly Selector loadKernel = "loadKernel";
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIPointillize : IEquatable<CIPointillize> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIPointillize;
		public static implicit operator CIFilter( CIPointillize value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIPointillize value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIPointillize value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIPointillize value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIPointillize?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIPointillize value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIPointillize value1, CIPointillize value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIPointillize value1, CIPointillize value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIPointillize( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIPointillize alloc() {
			return new CIPointillize( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIImage ) )]
	public struct CIPromise : IEquatable<CIPromise> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIPromise;
		public static implicit operator CIImage( CIPromise value ) {
			return new CIImage( value.Handle );
		}
		public static implicit operator NSObject( CIPromise value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIPromise value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIPromise value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIPromise?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIPromise value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIPromise value1, CIPromise value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIPromise value1, CIPromise value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIPromise( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIPromise alloc() {
			return new CIPromise( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject promise_keysAndValues_( NObjective.RuntimeObject promise, NObjective.RuntimeObject keysAndValues ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.promise_keysAndValues_( ClassHandle, CachedSelectors.promise_keysAndValues_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), promise, keysAndValues );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithFilter_options__( NObjective.RuntimeObject filter, NObjective.RuntimeObject options, System.IntPtr unnamedParameter ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithFilter_options__( Handle, CachedSelectors.initWithFilter_options__, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), filter, options, unnamedParameter );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setSelector_( NObjective.Selector selector ) {
			RuntimeObject ___occuredException;
			NativeMethods.setSelector_( Handle, CachedSelectors.setSelector_, out ___occuredException, sizeof( NObjective.Selector ), selector );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithFilter_options__( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject filter, NObjective.RuntimeObject options, System.IntPtr unnamedParameter );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr promise_keysAndValues_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject promise, NObjective.RuntimeObject keysAndValues );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setSelector_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.Selector selector );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithFilter_options__ = "initWithFilter:options::";
			public static readonly Selector promise_keysAndValues_ = "promise:keysAndValues:";
			public static readonly Selector setSelector_ = "setSelector:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct CIPromiseInvocation : IEquatable<CIPromiseInvocation> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIPromiseInvocation;
		public static implicit operator NSObject( CIPromiseInvocation value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIPromiseInvocation value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIPromiseInvocation value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIPromiseInvocation?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIPromiseInvocation value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIPromiseInvocation value1, CIPromiseInvocation value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIPromiseInvocation value1, CIPromiseInvocation value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIPromiseInvocation( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIPromiseInvocation alloc() {
			return new CIPromiseInvocation( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject context() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.context( Handle, CachedSelectors.context, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject contextObjectForKey_( NObjective.RuntimeObject key ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.contextObjectForKey_( Handle, CachedSelectors.contextObjectForKey_, out ___occuredException, sizeof( NObjective.RuntimeObject ), key );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr context( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr contextObjectForKey_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject key );
		}
		static internal class CachedSelectors {
			public static readonly Selector context = "context";
			public static readonly Selector contextObjectForKey_ = "contextObjectForKey:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIRadialGradient : IEquatable<CIRadialGradient> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIRadialGradient;
		public static implicit operator CIFilter( CIRadialGradient value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIRadialGradient value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIRadialGradient value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIRadialGradient value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIRadialGradient?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIRadialGradient value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIRadialGradient value1, CIRadialGradient value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIRadialGradient value1, CIRadialGradient value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIRadialGradient( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIRadialGradient alloc() {
			return new CIRadialGradient( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIRandomGenerator : IEquatable<CIRandomGenerator> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIRandomGenerator;
		public static implicit operator CIFilter( CIRandomGenerator value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIRandomGenerator value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIRandomGenerator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIRandomGenerator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIRandomGenerator?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIRandomGenerator value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIRandomGenerator value1, CIRandomGenerator value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIRandomGenerator value1, CIRandomGenerator value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIRandomGenerator( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIRandomGenerator alloc() {
			return new CIRandomGenerator( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIRAWGamutMapping : IEquatable<CIRAWGamutMapping> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIRAWGamutMapping;
		public static implicit operator CIFilter( CIRAWGamutMapping value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIRAWGamutMapping value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIRAWGamutMapping value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIRAWGamutMapping value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIRAWGamutMapping?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIRAWGamutMapping value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIRAWGamutMapping value1, CIRAWGamutMapping value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIRAWGamutMapping value1, CIRAWGamutMapping value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIRAWGamutMapping( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIRAWGamutMapping alloc() {
			return new CIRAWGamutMapping( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIRAWSharpen : IEquatable<CIRAWSharpen> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIRAWSharpen;
		public static implicit operator CIFilter( CIRAWSharpen value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIRAWSharpen value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIRAWSharpen value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIRAWSharpen value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIRAWSharpen?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIRAWSharpen value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIRAWSharpen value1, CIRAWSharpen value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIRAWSharpen value1, CIRAWSharpen value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIRAWSharpen( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIRAWSharpen alloc() {
			return new CIRAWSharpen( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIRAWTemperatureAdjust : IEquatable<CIRAWTemperatureAdjust> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIRAWTemperatureAdjust;
		public static implicit operator CIFilter( CIRAWTemperatureAdjust value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIRAWTemperatureAdjust value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIRAWTemperatureAdjust value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIRAWTemperatureAdjust value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIRAWTemperatureAdjust?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIRAWTemperatureAdjust value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIRAWTemperatureAdjust value1, CIRAWTemperatureAdjust value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIRAWTemperatureAdjust value1, CIRAWTemperatureAdjust value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIRAWTemperatureAdjust( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIRAWTemperatureAdjust alloc() {
			return new CIRAWTemperatureAdjust( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIContext ) )]
	public struct CIRecordingContext : IEquatable<CIRecordingContext> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIRecordingContext;
		public static implicit operator CIContext( CIRecordingContext value ) {
			return new CIContext( value.Handle );
		}
		public static implicit operator NSObject( CIRecordingContext value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIRecordingContext value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIRecordingContext value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIRecordingContext?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIRecordingContext value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIRecordingContext value1, CIRecordingContext value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIRecordingContext value1, CIRecordingContext value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIRecordingContext( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIRecordingContext alloc() {
			return new CIRecordingContext( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject initWithOptions_( NObjective.RuntimeObject options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithOptions_( Handle, CachedSelectors.initWithOptions_, out ___occuredException, sizeof( NObjective.RuntimeObject ), options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithOptions_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject options );
		}
		static internal class CachedSelectors {
			public static readonly Selector initWithOptions_ = "initWithOptions:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIContextImpl ) )]
	public struct CIRecordingContextImpl : IEquatable<CIRecordingContextImpl> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIRecordingContextImpl;
		public static implicit operator CIContextImpl( CIRecordingContextImpl value ) {
			return new CIContextImpl( value.Handle );
		}
		public static implicit operator NSObject( CIRecordingContextImpl value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIRecordingContextImpl value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIRecordingContextImpl value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIRecordingContextImpl?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIRecordingContextImpl value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIRecordingContextImpl value1, CIRecordingContextImpl value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIRecordingContextImpl value1, CIRecordingContextImpl value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIRecordingContextImpl( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIRecordingContextImpl alloc() {
			return new CIRecordingContextImpl( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIRectangleGenerator : IEquatable<CIRectangleGenerator> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIRectangleGenerator;
		public static implicit operator CIFilter( CIRectangleGenerator value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIRectangleGenerator value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIRectangleGenerator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIRectangleGenerator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIRectangleGenerator?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIRectangleGenerator value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIRectangleGenerator value1, CIRectangleGenerator value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIRectangleGenerator value1, CIRectangleGenerator value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIRectangleGenerator( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIRectangleGenerator alloc() {
			return new CIRectangleGenerator( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIRefractedMaterial : IEquatable<CIRefractedMaterial> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIRefractedMaterial;
		public static implicit operator CIFilter( CIRefractedMaterial value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIRefractedMaterial value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIRefractedMaterial value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIRefractedMaterial value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIRefractedMaterial?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIRefractedMaterial value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIRefractedMaterial value1, CIRefractedMaterial value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIRefractedMaterial value1, CIRefractedMaterial value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIRefractedMaterial( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIRefractedMaterial alloc() {
			return new CIRefractedMaterial( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct CIRenderProviderDelegate : IEquatable<CIRenderProviderDelegate> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIRenderProviderDelegate;
		public static implicit operator NSObject( CIRenderProviderDelegate value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIRenderProviderDelegate value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIRenderProviderDelegate value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIRenderProviderDelegate?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIRenderProviderDelegate value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIRenderProviderDelegate value1, CIRenderProviderDelegate value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIRenderProviderDelegate value1, CIRenderProviderDelegate value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIRenderProviderDelegate( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIRenderProviderDelegate alloc() {
			return new CIRenderProviderDelegate( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void provideImageData_bytesPerRow_origin__size__userInfo_( System.IntPtr data, uint bytesPerRow, uint origin, uint unnamedParameter, uint size, uint unnamedParameter2, NObjective.RuntimeObject userInfo ) {
			RuntimeObject ___occuredException;
			NativeMethods.provideImageData_bytesPerRow_origin__size__userInfo_( Handle, CachedSelectors.provideImageData_bytesPerRow_origin__size__userInfo_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( uint ) + sizeof( uint ) + sizeof( uint ) + sizeof( uint ) + sizeof( uint ) + sizeof( NObjective.RuntimeObject ), data, bytesPerRow, origin, unnamedParameter, size, unnamedParameter2, 
			userInfo );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void provideImageData_bytesPerRow_origin__size__userInfo_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr data, uint bytesPerRow, uint origin, uint unnamedParameter, uint size, uint unnamedParameter2, 
			NObjective.RuntimeObject userInfo );
		}
		static internal class CachedSelectors {
			public static readonly Selector provideImageData_bytesPerRow_origin__size__userInfo_ = "provideImageData:bytesPerRow:origin::size::userInfo:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIRippleTransition : IEquatable<CIRippleTransition> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIRippleTransition;
		public static implicit operator CIFilter( CIRippleTransition value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIRippleTransition value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIRippleTransition value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIRippleTransition value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIRippleTransition?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIRippleTransition value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIRippleTransition value1, CIRippleTransition value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIRippleTransition value1, CIRippleTransition value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIRippleTransition( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIRippleTransition alloc() {
			return new CIRippleTransition( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIRotatingCubeTransition : IEquatable<CIRotatingCubeTransition> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIRotatingCubeTransition;
		public static implicit operator CIFilter( CIRotatingCubeTransition value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIRotatingCubeTransition value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIRotatingCubeTransition value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIRotatingCubeTransition value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIRotatingCubeTransition?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIRotatingCubeTransition value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIRotatingCubeTransition value1, CIRotatingCubeTransition value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIRotatingCubeTransition value1, CIRotatingCubeTransition value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIRotatingCubeTransition( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIRotatingCubeTransition alloc() {
			return new CIRotatingCubeTransition( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CISampleAreaOperation : IEquatable<CISampleAreaOperation> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CISampleAreaOperation;
		public static implicit operator CIFilter( CISampleAreaOperation value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CISampleAreaOperation value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CISampleAreaOperation value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CISampleAreaOperation value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CISampleAreaOperation?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CISampleAreaOperation value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CISampleAreaOperation value1, CISampleAreaOperation value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CISampleAreaOperation value1, CISampleAreaOperation value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CISampleAreaOperation( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CISampleAreaOperation alloc() {
			return new CISampleAreaOperation( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject doPass_sums_( NObjective.RuntimeObject pass, NObjective.RuntimeObject sums ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.doPass_sums_( Handle, CachedSelectors.doPass_sums_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), pass, sums );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public int samplesPerPass() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.samplesPerPass( Handle, CachedSelectors.samplesPerPass, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr doPass_sums_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject pass, NObjective.RuntimeObject sums );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int samplesPerPass( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector doPass_sums_ = "doPass:sums:";
			public static readonly Selector outputImage = "outputImage";
			public static readonly Selector samplesPerPass = "samplesPerPass";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct CISampler : IEquatable<CISampler> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CISampler;
		public static implicit operator NSObject( CISampler value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CISampler value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CISampler value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CISampler?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CISampler value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CISampler value1, CISampler value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CISampler value1, CISampler value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CISampler( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CISampler alloc() {
			return new CISampler( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static CISampler samplerWithImage_( CIImage image ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.samplerWithImage_( ClassHandle, CachedSelectors.samplerWithImage_, out ___occuredException, sizeof( CIImage ), image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CISampler( ___result );
		}
		public static CISampler samplerWithImage_keysAndValues_( CIImage image, NObjective.RuntimeObject keysAndValues, params object[] variableArguments ) {
			return new CISampler( ClassHandle.InvokeObjectFast( CachedSelectors.samplerWithImage_keysAndValues_, CachedEncodings.__19F8A84A, image, keysAndValues, variableArguments ) );
		}
		unsafe public static CISampler samplerWithImage_options_( CIImage image, NSDictionary options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.samplerWithImage_options_( ClassHandle, CachedSelectors.samplerWithImage_options_, out ___occuredException, sizeof( CIImage ) + sizeof( NSDictionary ), image, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CISampler( ___result );
		}
		unsafe public NObjective.RuntimeObject apply_( NObjective.RuntimeObject apply ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.apply_( Handle, CachedSelectors.apply_, out ___occuredException, sizeof( NObjective.RuntimeObject ), apply );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public System.IntPtr colorSpace() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.colorSpace( Handle, CachedSelectors.colorSpace, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public CIFilterShape definition() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.definition( Handle, CachedSelectors.definition, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIFilterShape( ___result );
		}
		unsafe public CGRect extent() {
			CGRect ___result;
			RuntimeObject ___occuredException;
			NativeMethods.extent( out ___result, sizeof( CGRect ), Handle, CachedSelectors.extent, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject initWithImage_( CIImage image ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithImage_( Handle, CachedSelectors.initWithImage_, out ___occuredException, sizeof( CIImage ), image );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		public NObjective.RuntimeObject initWithImage_keysAndValues_( CIImage image, NObjective.RuntimeObject keysAndValues ) {
			return Handle.InvokeObjectFast( CachedSelectors.initWithImage_keysAndValues_, CachedEncodings.__19F8A84A, image, keysAndValues );
		}
		unsafe public NObjective.RuntimeObject initWithImage_options_( CIImage image, NSDictionary options ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithImage_options_( Handle, CachedSelectors.initWithImage_options_, out ___occuredException, sizeof( CIImage ) + sizeof( NSDictionary ), image, options );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject opaqueShape() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.opaqueShape( Handle, CachedSelectors.opaqueShape, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject wrapMode() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.wrapMode( Handle, CachedSelectors.wrapMode, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr apply_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject apply );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern System.IntPtr colorSpace( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr definition( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_stret_eh2" )]
			public static extern void extent( out CGRect ___structAddress, int ___structSize, RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithImage_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, CIImage image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithImage_options_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, CIImage image, NSDictionary options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr opaqueShape( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr samplerWithImage_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, CIImage image );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr samplerWithImage_options_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, CIImage image, NSDictionary options );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr wrapMode( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedEncodings {
			public static readonly RuntimeMethodEncoding __19F8A84A = "@16@0:4@8@12";
		}
		static internal class CachedSelectors {
			public static readonly Selector apply_ = "apply:";
			public static readonly Selector colorSpace = "colorSpace";
			public static readonly Selector definition = "definition";
			public static readonly Selector extent = "extent";
			public static readonly Selector initWithImage_ = "initWithImage:";
			public static readonly Selector initWithImage_keysAndValues_ = "initWithImage:keysAndValues:";
			public static readonly Selector initWithImage_options_ = "initWithImage:options:";
			public static readonly Selector opaqueShape = "opaqueShape";
			public static readonly Selector samplerWithImage_ = "samplerWithImage:";
			public static readonly Selector samplerWithImage_keysAndValues_ = "samplerWithImage:keysAndValues:";
			public static readonly Selector samplerWithImage_options_ = "samplerWithImage:options:";
			public static readonly Selector wrapMode = "wrapMode";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CISaturationBlendMode : IEquatable<CISaturationBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CISaturationBlendMode;
		public static implicit operator CIFilter( CISaturationBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CISaturationBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CISaturationBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CISaturationBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CISaturationBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CISaturationBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CISaturationBlendMode value1, CISaturationBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CISaturationBlendMode value1, CISaturationBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CISaturationBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CISaturationBlendMode alloc() {
			return new CISaturationBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIScreenBlendMode : IEquatable<CIScreenBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIScreenBlendMode;
		public static implicit operator CIFilter( CIScreenBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIScreenBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIScreenBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIScreenBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIScreenBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIScreenBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIScreenBlendMode value1, CIScreenBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIScreenBlendMode value1, CIScreenBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIScreenBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIScreenBlendMode alloc() {
			return new CIScreenBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CISepiaTone : IEquatable<CISepiaTone> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CISepiaTone;
		public static implicit operator CIFilter( CISepiaTone value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CISepiaTone value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CISepiaTone value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CISepiaTone value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CISepiaTone?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CISepiaTone value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CISepiaTone value1, CISepiaTone value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CISepiaTone value1, CISepiaTone value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CISepiaTone( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CISepiaTone alloc() {
			return new CISepiaTone( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIShadedMaterial : IEquatable<CIShadedMaterial> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIShadedMaterial;
		public static implicit operator CIFilter( CIShadedMaterial value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIShadedMaterial value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIShadedMaterial value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIShadedMaterial value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIShadedMaterial?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIShadedMaterial value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIShadedMaterial value1, CIShadedMaterial value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIShadedMaterial value1, CIShadedMaterial value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIShadedMaterial( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIShadedMaterial alloc() {
			return new CIShadedMaterial( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIShapedWaterRipple : IEquatable<CIShapedWaterRipple> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIShapedWaterRipple;
		public static implicit operator CIFilter( CIShapedWaterRipple value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIShapedWaterRipple value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIShapedWaterRipple value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIShapedWaterRipple value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIShapedWaterRipple?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIShapedWaterRipple value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIShapedWaterRipple value1, CIShapedWaterRipple value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIShapedWaterRipple value1, CIShapedWaterRipple value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIShapedWaterRipple( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIShapedWaterRipple alloc() {
			return new CIShapedWaterRipple( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject wavePattern() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.wavePattern( Handle, CachedSelectors.wavePattern, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr wavePattern( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
			public static readonly Selector wavePattern = "wavePattern";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CISharpenLuminance : IEquatable<CISharpenLuminance> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CISharpenLuminance;
		public static implicit operator CIFilter( CISharpenLuminance value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CISharpenLuminance value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CISharpenLuminance value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CISharpenLuminance value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CISharpenLuminance?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CISharpenLuminance value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CISharpenLuminance value1, CISharpenLuminance value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CISharpenLuminance value1, CISharpenLuminance value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CISharpenLuminance( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CISharpenLuminance alloc() {
			return new CISharpenLuminance( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CISilhouetteAlphaBlendMode : IEquatable<CISilhouetteAlphaBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CISilhouetteAlphaBlendMode;
		public static implicit operator CIFilter( CISilhouetteAlphaBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CISilhouetteAlphaBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CISilhouetteAlphaBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CISilhouetteAlphaBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CISilhouetteAlphaBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CISilhouetteAlphaBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CISilhouetteAlphaBlendMode value1, CISilhouetteAlphaBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CISilhouetteAlphaBlendMode value1, CISilhouetteAlphaBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CISilhouetteAlphaBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CISilhouetteAlphaBlendMode alloc() {
			return new CISilhouetteAlphaBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CISilhouetteLumaBlendMode : IEquatable<CISilhouetteLumaBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CISilhouetteLumaBlendMode;
		public static implicit operator CIFilter( CISilhouetteLumaBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CISilhouetteLumaBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CISilhouetteLumaBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CISilhouetteLumaBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CISilhouetteLumaBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CISilhouetteLumaBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CISilhouetteLumaBlendMode value1, CISilhouetteLumaBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CISilhouetteLumaBlendMode value1, CISilhouetteLumaBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CISilhouetteLumaBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CISilhouetteLumaBlendMode alloc() {
			return new CISilhouetteLumaBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CISoftLightBlendMode : IEquatable<CISoftLightBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CISoftLightBlendMode;
		public static implicit operator CIFilter( CISoftLightBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CISoftLightBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CISoftLightBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CISoftLightBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CISoftLightBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CISoftLightBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CISoftLightBlendMode value1, CISoftLightBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CISoftLightBlendMode value1, CISoftLightBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CISoftLightBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CISoftLightBlendMode alloc() {
			return new CISoftLightBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CISourceAtopCompositing : IEquatable<CISourceAtopCompositing> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CISourceAtopCompositing;
		public static implicit operator CIFilter( CISourceAtopCompositing value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CISourceAtopCompositing value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CISourceAtopCompositing value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CISourceAtopCompositing value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CISourceAtopCompositing?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CISourceAtopCompositing value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CISourceAtopCompositing value1, CISourceAtopCompositing value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CISourceAtopCompositing value1, CISourceAtopCompositing value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CISourceAtopCompositing( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CISourceAtopCompositing alloc() {
			return new CISourceAtopCompositing( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CISourceInCompositing : IEquatable<CISourceInCompositing> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CISourceInCompositing;
		public static implicit operator CIFilter( CISourceInCompositing value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CISourceInCompositing value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CISourceInCompositing value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CISourceInCompositing value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CISourceInCompositing?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CISourceInCompositing value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CISourceInCompositing value1, CISourceInCompositing value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CISourceInCompositing value1, CISourceInCompositing value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CISourceInCompositing( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CISourceInCompositing alloc() {
			return new CISourceInCompositing( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CISourceOutCompositing : IEquatable<CISourceOutCompositing> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CISourceOutCompositing;
		public static implicit operator CIFilter( CISourceOutCompositing value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CISourceOutCompositing value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CISourceOutCompositing value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CISourceOutCompositing value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CISourceOutCompositing?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CISourceOutCompositing value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CISourceOutCompositing value1, CISourceOutCompositing value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CISourceOutCompositing value1, CISourceOutCompositing value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CISourceOutCompositing( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CISourceOutCompositing alloc() {
			return new CISourceOutCompositing( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CISourceOverCompositing : IEquatable<CISourceOverCompositing> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CISourceOverCompositing;
		public static implicit operator CIFilter( CISourceOverCompositing value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CISourceOverCompositing value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CISourceOverCompositing value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CISourceOverCompositing value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CISourceOverCompositing?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CISourceOverCompositing value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CISourceOverCompositing value1, CISourceOverCompositing value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CISourceOverCompositing value1, CISourceOverCompositing value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CISourceOverCompositing( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CISourceOverCompositing alloc() {
			return new CISourceOverCompositing( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CISpotLight : IEquatable<CISpotLight> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CISpotLight;
		public static implicit operator CIFilter( CISpotLight value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CISpotLight value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CISpotLight value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CISpotLight value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CISpotLight?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CISpotLight value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CISpotLight value1, CISpotLight value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CISpotLight value1, CISpotLight value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CISpotLight( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CISpotLight alloc() {
			return new CISpotLight( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIStarShineGenerator : IEquatable<CIStarShineGenerator> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIStarShineGenerator;
		public static implicit operator CIFilter( CIStarShineGenerator value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIStarShineGenerator value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIStarShineGenerator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIStarShineGenerator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIStarShineGenerator?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIStarShineGenerator value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIStarShineGenerator value1, CIStarShineGenerator value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIStarShineGenerator value1, CIStarShineGenerator value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIStarShineGenerator( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIStarShineGenerator alloc() {
			return new CIStarShineGenerator( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIStencilAlphaBlendMode : IEquatable<CIStencilAlphaBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIStencilAlphaBlendMode;
		public static implicit operator CIFilter( CIStencilAlphaBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIStencilAlphaBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIStencilAlphaBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIStencilAlphaBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIStencilAlphaBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIStencilAlphaBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIStencilAlphaBlendMode value1, CIStencilAlphaBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIStencilAlphaBlendMode value1, CIStencilAlphaBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIStencilAlphaBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIStencilAlphaBlendMode alloc() {
			return new CIStencilAlphaBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIStencilLumaBlendMode : IEquatable<CIStencilLumaBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIStencilLumaBlendMode;
		public static implicit operator CIFilter( CIStencilLumaBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIStencilLumaBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIStencilLumaBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIStencilLumaBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIStencilLumaBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIStencilLumaBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIStencilLumaBlendMode value1, CIStencilLumaBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIStencilLumaBlendMode value1, CIStencilLumaBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIStencilLumaBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIStencilLumaBlendMode alloc() {
			return new CIStencilLumaBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIStripesGenerator : IEquatable<CIStripesGenerator> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIStripesGenerator;
		public static implicit operator CIFilter( CIStripesGenerator value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIStripesGenerator value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIStripesGenerator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIStripesGenerator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIStripesGenerator?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIStripesGenerator value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIStripesGenerator value1, CIStripesGenerator value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIStripesGenerator value1, CIStripesGenerator value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIStripesGenerator( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIStripesGenerator alloc() {
			return new CIStripesGenerator( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CISubtractBlendMode : IEquatable<CISubtractBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CISubtractBlendMode;
		public static implicit operator CIFilter( CISubtractBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CISubtractBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CISubtractBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CISubtractBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CISubtractBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CISubtractBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CISubtractBlendMode value1, CISubtractBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CISubtractBlendMode value1, CISubtractBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CISubtractBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CISubtractBlendMode alloc() {
			return new CISubtractBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CISumOf8Conics : IEquatable<CISumOf8Conics> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CISumOf8Conics;
		public static implicit operator CIFilter( CISumOf8Conics value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CISumOf8Conics value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CISumOf8Conics value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CISumOf8Conics value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CISumOf8Conics?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CISumOf8Conics value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CISumOf8Conics value1, CISumOf8Conics value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CISumOf8Conics value1, CISumOf8Conics value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CISumOf8Conics( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CISumOf8Conics alloc() {
			return new CISumOf8Conics( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CISunbeamsGenerator : IEquatable<CISunbeamsGenerator> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CISunbeamsGenerator;
		public static implicit operator CIFilter( CISunbeamsGenerator value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CISunbeamsGenerator value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CISunbeamsGenerator value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CISunbeamsGenerator value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CISunbeamsGenerator?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CISunbeamsGenerator value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CISunbeamsGenerator value1, CISunbeamsGenerator value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CISunbeamsGenerator value1, CISunbeamsGenerator value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CISunbeamsGenerator( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CISunbeamsGenerator alloc() {
			return new CISunbeamsGenerator( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CISwipeTransition : IEquatable<CISwipeTransition> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CISwipeTransition;
		public static implicit operator CIFilter( CISwipeTransition value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CISwipeTransition value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CISwipeTransition value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CISwipeTransition value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CISwipeTransition?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CISwipeTransition value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CISwipeTransition value1, CISwipeTransition value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CISwipeTransition value1, CISwipeTransition value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CISwipeTransition( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CISwipeTransition alloc() {
			return new CISwipeTransition( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CITagWithColorSpace : IEquatable<CITagWithColorSpace> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CITagWithColorSpace;
		public static implicit operator CIFilter( CITagWithColorSpace value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CITagWithColorSpace value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CITagWithColorSpace value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CITagWithColorSpace value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CITagWithColorSpace?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CITagWithColorSpace value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CITagWithColorSpace value1, CITagWithColorSpace value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CITagWithColorSpace value1, CITagWithColorSpace value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CITagWithColorSpace( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CITagWithColorSpace alloc() {
			return new CITagWithColorSpace( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CITorusLensDistortion : IEquatable<CITorusLensDistortion> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CITorusLensDistortion;
		public static implicit operator CIFilter( CITorusLensDistortion value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CITorusLensDistortion value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CITorusLensDistortion value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CITorusLensDistortion value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CITorusLensDistortion?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CITorusLensDistortion value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CITorusLensDistortion value1, CITorusLensDistortion value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CITorusLensDistortion value1, CITorusLensDistortion value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CITorusLensDistortion( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CITorusLensDistortion alloc() {
			return new CITorusLensDistortion( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CITriangleTile : IEquatable<CITriangleTile> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CITriangleTile;
		public static implicit operator CIFilter( CITriangleTile value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CITriangleTile value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CITriangleTile value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CITriangleTile value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CITriangleTile?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CITriangleTile value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CITriangleTile value1, CITriangleTile value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CITriangleTile value1, CITriangleTile value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CITriangleTile( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CITriangleTile alloc() {
			return new CITriangleTile( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CITwirlDistortion : IEquatable<CITwirlDistortion> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CITwirlDistortion;
		public static implicit operator CIFilter( CITwirlDistortion value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CITwirlDistortion value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CITwirlDistortion value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CITwirlDistortion value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CITwirlDistortion?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CITwirlDistortion value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CITwirlDistortion value1, CITwirlDistortion value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CITwirlDistortion value1, CITwirlDistortion value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CITwirlDistortion( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CITwirlDistortion alloc() {
			return new CITwirlDistortion( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct CIUIBundle : IEquatable<CIUIBundle> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIUIBundle;
		public static implicit operator NSObject( CIUIBundle value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIUIBundle value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIUIBundle value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIUIBundle?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIUIBundle value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIUIBundle value1, CIUIBundle value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIUIBundle value1, CIUIBundle value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIUIBundle( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIUIBundle alloc() {
			return new CIUIBundle( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject arrayOrNumberFromResolutions_andValues_withCount_( System.IntPtr resolutions, System.IntPtr andValues, int withCount ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.arrayOrNumberFromResolutions_andValues_withCount_( ClassHandle, CachedSelectors.arrayOrNumberFromResolutions_andValues_withCount_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( System.IntPtr ) + sizeof( int ), resolutions, andValues, withCount );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static void computeLinearA_andB_fromX0_y0_x1_y1_( System.IntPtr a, System.IntPtr andB, float fromX0, float y0, float x1, float y1 ) {
			RuntimeObject ___occuredException;
			NativeMethods.computeLinearA_andB_fromX0_y0_x1_y1_( ClassHandle, CachedSelectors.computeLinearA_andB_fromX0_y0_x1_y1_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( System.IntPtr ) + sizeof( float ) + sizeof( float ) + sizeof( float ) + sizeof( float ), a, andB, fromX0, y0, x1, y1
			 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public static NObjective.RuntimeObject dropFirstComponent_( NObjective.RuntimeObject component ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dropFirstComponent_( ClassHandle, CachedSelectors.dropFirstComponent_, out ___occuredException, sizeof( NObjective.RuntimeObject ), component );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject dropLastComponent_( NObjective.RuntimeObject component ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dropLastComponent_( ClassHandle, CachedSelectors.dropLastComponent_, out ___occuredException, sizeof( NObjective.RuntimeObject ), component );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static float evaluateFromResolutionArray_valueArray_arrayCount_atResolution_( System.IntPtr array, System.IntPtr valueArray, int arrayCount, float atResolution ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.evaluateFromResolutionArray_valueArray_arrayCount_atResolution_( ClassHandle, CachedSelectors.evaluateFromResolutionArray_valueArray_arrayCount_atResolution_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( System.IntPtr ) + sizeof( int ) + sizeof( float ), array, valueArray, arrayCount, atResolution );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static NObjective.RuntimeObject firstComponent_( NObjective.RuntimeObject component ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.firstComponent_( ClassHandle, CachedSelectors.firstComponent_, out ___occuredException, sizeof( NObjective.RuntimeObject ), component );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static bool isLinearX0_y0_x1_y1_x2_y2_( float x0, float y0, float x1, float y1, float x2, float y2 ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isLinearX0_y0_x1_y1_x2_y2_( ClassHandle, CachedSelectors.isLinearX0_y0_x1_y1_x2_y2_, out ___occuredException, sizeof( float ) + sizeof( float ) + sizeof( float ) + sizeof( float ) + sizeof( float ) + sizeof( float ), x0, y0, x1, y1, x2, y2
			 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static NObjective.RuntimeObject keyForParameter_( int parameter ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.keyForParameter_( ClassHandle, CachedSelectors.keyForParameter_, out ___occuredException, sizeof( int ), parameter );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject lastComponent_( NObjective.RuntimeObject component ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.lastComponent_( ClassHandle, CachedSelectors.lastComponent_, out ___occuredException, sizeof( NObjective.RuntimeObject ), component );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static int typeForParameter_( int parameter ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.typeForParameter_( ClassHandle, CachedSelectors.typeForParameter_, out ___occuredException, sizeof( int ), parameter );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public static void values_forResolutions_withCount_fromArrayOrNumber_( System.IntPtr values, System.IntPtr forResolutions, int withCount, NObjective.RuntimeObject fromArrayOrNumber ) {
			RuntimeObject ___occuredException;
			NativeMethods.values_forResolutions_withCount_fromArrayOrNumber_( ClassHandle, CachedSelectors.values_forResolutions_withCount_fromArrayOrNumber_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( System.IntPtr ) + sizeof( int ) + sizeof( NObjective.RuntimeObject ), values, forResolutions, withCount, fromArrayOrNumber );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public bool atRoot() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.atRoot( Handle, CachedSelectors.atRoot, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool boolParameterValue_( int value ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.boolParameterValue_( Handle, CachedSelectors.boolParameterValue_, out ___occuredException, sizeof( int ), value );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject bundle() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.bundle( Handle, CachedSelectors.bundle, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject bundlePath() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.bundlePath( Handle, CachedSelectors.bundlePath, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject buttonEMapResultForResolution_( int resolution ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.buttonEMapResultForResolution_( Handle, CachedSelectors.buttonEMapResultForResolution_, out ___occuredException, sizeof( int ), resolution );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject buttonResultForPPI_centerX_Y_( float ppi, float centerX, float Y ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.buttonResultForPPI_centerX_Y_( Handle, CachedSelectors.buttonResultForPPI_centerX_Y_, out ___occuredException, sizeof( float ) + sizeof( float ) + sizeof( float ), ppi, centerX, Y );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject buttonResultForResolution_( int resolution ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.buttonResultForResolution_( Handle, CachedSelectors.buttonResultForResolution_, out ___occuredException, sizeof( int ), resolution );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void copyResolution_into_( int resolution, int @into ) {
			RuntimeObject ___occuredException;
			NativeMethods.copyResolution_into_( Handle, CachedSelectors.copyResolution_into_, out ___occuredException, sizeof( int ) + sizeof( int ), resolution, @into );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject dataForPPI_( float ppi ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dataForPPI_( Handle, CachedSelectors.dataForPPI_, out ___occuredException, sizeof( float ), ppi );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public float floatParameterValue_forResolution_( int value, int forResolution ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.floatParameterValue_forResolution_( Handle, CachedSelectors.floatParameterValue_forResolution_, out ___occuredException, sizeof( int ) + sizeof( int ), value, forResolution );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject highlightEMapResultForResolution_( int resolution ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.highlightEMapResultForResolution_( Handle, CachedSelectors.highlightEMapResultForResolution_, out ___occuredException, sizeof( int ), resolution );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject imageWithPath_( NObjective.RuntimeObject path ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.imageWithPath_( Handle, CachedSelectors.imageWithPath_, out ___occuredException, sizeof( NObjective.RuntimeObject ), path );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject imageWithPathInner_( NObjective.RuntimeObject inner ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.imageWithPathInner_( Handle, CachedSelectors.imageWithPathInner_, out ___occuredException, sizeof( NObjective.RuntimeObject ), inner );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void initialize_( System.IntPtr initialize ) {
			RuntimeObject ___occuredException;
			NativeMethods.initialize_( Handle, CachedSelectors.initialize_, out ___occuredException, sizeof( System.IntPtr ), initialize );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject inlayEMapResultForResolution_( int resolution ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.inlayEMapResultForResolution_( Handle, CachedSelectors.inlayEMapResultForResolution_, out ___occuredException, sizeof( int ), resolution );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public int intParameterValue_( int value ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.intParameterValue_( Handle, CachedSelectors.intParameterValue_, out ___occuredException, sizeof( int ), value );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void loadRecipeOverrides_( NObjective.RuntimeObject overrides ) {
			RuntimeObject ___occuredException;
			NativeMethods.loadRecipeOverrides_( Handle, CachedSelectors.loadRecipeOverrides_, out ___occuredException, sizeof( NObjective.RuntimeObject ), overrides );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void openCategoryFile_( NObjective.RuntimeObject file ) {
			RuntimeObject ___occuredException;
			NativeMethods.openCategoryFile_( Handle, CachedSelectors.openCategoryFile_, out ___occuredException, sizeof( NObjective.RuntimeObject ), file );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void openRoot() {
			RuntimeObject ___occuredException;
			NativeMethods.openRoot( Handle, CachedSelectors.openRoot, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject path() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.path( Handle, CachedSelectors.path, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject properties() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.properties( Handle, CachedSelectors.properties, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void pushSubnode_( NObjective.RuntimeObject subnode ) {
			RuntimeObject ___occuredException;
			NativeMethods.pushSubnode_( Handle, CachedSelectors.pushSubnode_, out ___occuredException, sizeof( NObjective.RuntimeObject ), subnode );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void recalcFigureForResolution_( int resolution ) {
			RuntimeObject ___occuredException;
			NativeMethods.recalcFigureForResolution_( Handle, CachedSelectors.recalcFigureForResolution_, out ___occuredException, sizeof( int ), resolution );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void restoreParameter_from_( int parameter, NObjective.RuntimeObject @from ) {
			RuntimeObject ___occuredException;
			NativeMethods.restoreParameter_from_( Handle, CachedSelectors.restoreParameter_from_, out ___occuredException, sizeof( int ) + sizeof( NObjective.RuntimeObject ), parameter, @from );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void restoreResolutions() {
			RuntimeObject ___occuredException;
			NativeMethods.restoreResolutions( Handle, CachedSelectors.restoreResolutions, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public bool rootIsNil() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.rootIsNil( Handle, CachedSelectors.rootIsNil, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public bool rootIsOpen() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.rootIsOpen( Handle, CachedSelectors.rootIsOpen, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void saveResolutions() {
			RuntimeObject ___occuredException;
			NativeMethods.saveResolutions( Handle, CachedSelectors.saveResolutions, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setBoolParameterValue_to_( int value, bool to ) {
			RuntimeObject ___occuredException;
			NativeMethods.setBoolParameterValue_to_( Handle, CachedSelectors.setBoolParameterValue_to_, out ___occuredException, sizeof( int ) + sizeof( bool ), value, to );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setBundlePath_( NObjective.RuntimeObject path ) {
			RuntimeObject ___occuredException;
			NativeMethods.setBundlePath_( Handle, CachedSelectors.setBundlePath_, out ___occuredException, sizeof( NObjective.RuntimeObject ), path );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setFloatParameterValue_forResolution_to_( int value, int forResolution, float to ) {
			RuntimeObject ___occuredException;
			NativeMethods.setFloatParameterValue_forResolution_to_( Handle, CachedSelectors.setFloatParameterValue_forResolution_to_, out ___occuredException, sizeof( int ) + sizeof( int ) + sizeof( float ), value, forResolution, to );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setFloatParameterValue_to_( int value, float to ) {
			RuntimeObject ___occuredException;
			NativeMethods.setFloatParameterValue_to_( Handle, CachedSelectors.setFloatParameterValue_to_, out ___occuredException, sizeof( int ) + sizeof( float ), value, to );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setIntParameterValue_to_( int value, int to ) {
			RuntimeObject ___occuredException;
			NativeMethods.setIntParameterValue_to_( Handle, CachedSelectors.setIntParameterValue_to_, out ___occuredException, sizeof( int ) + sizeof( int ), value, to );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public bool setPath_( NObjective.RuntimeObject path ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.setPath_( Handle, CachedSelectors.setPath_, out ___occuredException, sizeof( NObjective.RuntimeObject ), path );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void setPhase_( float phase ) {
			RuntimeObject ___occuredException;
			NativeMethods.setPhase_( Handle, CachedSelectors.setPhase_, out ___occuredException, sizeof( float ), phase );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public int setStringParameterValue_to_( int value, NObjective.RuntimeObject to ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.setStringParameterValue_to_( Handle, CachedSelectors.setStringParameterValue_to_, out ___occuredException, sizeof( int ) + sizeof( NObjective.RuntimeObject ), value, to );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject stringParameterValue_( int value ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.stringParameterValue_( Handle, CachedSelectors.stringParameterValue_, out ___occuredException, sizeof( int ), value );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject subnodesDictionaryForPath_( NObjective.RuntimeObject path ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.subnodesDictionaryForPath_( Handle, CachedSelectors.subnodesDictionaryForPath_, out ___occuredException, sizeof( NObjective.RuntimeObject ), path );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr arrayOrNumberFromResolutions_andValues_withCount_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr resolutions, System.IntPtr andValues, int withCount );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool atRoot( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool boolParameterValue_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int value );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr bundle( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr bundlePath( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr buttonEMapResultForResolution_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int resolution );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr buttonResultForPPI_centerX_Y_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, float ppi, float centerX, float Y );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr buttonResultForResolution_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int resolution );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void computeLinearA_andB_fromX0_y0_x1_y1_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr a, System.IntPtr andB, float fromX0, float y0, float x1, float y1
			 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void copyResolution_into_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int resolution, int @into );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr dataForPPI_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, float ppi );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr dropFirstComponent_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject component );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr dropLastComponent_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject component );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern float evaluateFromResolutionArray_valueArray_arrayCount_atResolution_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr array, System.IntPtr valueArray, int arrayCount, float atResolution );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr firstComponent_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject component );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern float floatParameterValue_forResolution_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int value, int forResolution );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr highlightEMapResultForResolution_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int resolution );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr imageWithPath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject path );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr imageWithPathInner_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject inner );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void initialize_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr initialize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr inlayEMapResultForResolution_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int resolution );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int intParameterValue_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int value );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool isLinearX0_y0_x1_y1_x2_y2_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, float x0, float y0, float x1, float y1, float x2, float y2
			 );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr keyForParameter_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int parameter );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr lastComponent_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject component );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void loadRecipeOverrides_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject overrides );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void openCategoryFile_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject file );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void openRoot( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr path( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr properties( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void pushSubnode_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject subnode );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void recalcFigureForResolution_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int resolution );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void restoreParameter_from_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int parameter, NObjective.RuntimeObject @from );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void restoreResolutions( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool rootIsNil( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool rootIsOpen( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void saveResolutions( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setBoolParameterValue_to_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int value, bool to );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setBundlePath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject path );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setFloatParameterValue_forResolution_to_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int value, int forResolution, float to );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setFloatParameterValue_to_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int value, float to );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setIntParameterValue_to_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int value, int to );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern bool setPath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject path );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setPhase_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, float phase );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int setStringParameterValue_to_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int value, NObjective.RuntimeObject to );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr stringParameterValue_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int value );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr subnodesDictionaryForPath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject path );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern int typeForParameter_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int parameter );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void values_forResolutions_withCount_fromArrayOrNumber_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr values, System.IntPtr forResolutions, int withCount, NObjective.RuntimeObject fromArrayOrNumber );
		}
		static internal class CachedSelectors {
			public static readonly Selector arrayOrNumberFromResolutions_andValues_withCount_ = "arrayOrNumberFromResolutions:andValues:withCount:";
			public static readonly Selector atRoot = "atRoot";
			public static readonly Selector boolParameterValue_ = "boolParameterValue:";
			public static readonly Selector bundle = "bundle";
			public static readonly Selector bundlePath = "bundlePath";
			public static readonly Selector buttonEMapResultForResolution_ = "buttonEMapResultForResolution:";
			public static readonly Selector buttonResultForPPI_centerX_Y_ = "buttonResultForPPI:centerX:Y:";
			public static readonly Selector buttonResultForResolution_ = "buttonResultForResolution:";
			public static readonly Selector computeLinearA_andB_fromX0_y0_x1_y1_ = "computeLinearA:andB:fromX0:y0:x1:y1:";
			public static readonly Selector copyResolution_into_ = "copyResolution:into:";
			public static readonly Selector dataForPPI_ = "dataForPPI:";
			public static readonly Selector dropFirstComponent_ = "dropFirstComponent:";
			public static readonly Selector dropLastComponent_ = "dropLastComponent:";
			public static readonly Selector evaluateFromResolutionArray_valueArray_arrayCount_atResolution_ = "evaluateFromResolutionArray:valueArray:arrayCount:atResolution:";
			public static readonly Selector firstComponent_ = "firstComponent:";
			public static readonly Selector floatParameterValue_forResolution_ = "floatParameterValue:forResolution:";
			public static readonly Selector highlightEMapResultForResolution_ = "highlightEMapResultForResolution:";
			public static readonly Selector imageWithPath_ = "imageWithPath:";
			public static readonly Selector imageWithPathInner_ = "imageWithPathInner:";
			public static readonly Selector initialize_ = "initialize:";
			public static readonly Selector inlayEMapResultForResolution_ = "inlayEMapResultForResolution:";
			public static readonly Selector intParameterValue_ = "intParameterValue:";
			public static readonly Selector isLinearX0_y0_x1_y1_x2_y2_ = "isLinearX0:y0:x1:y1:x2:y2:";
			public static readonly Selector keyForParameter_ = "keyForParameter:";
			public static readonly Selector lastComponent_ = "lastComponent:";
			public static readonly Selector loadRecipeOverrides_ = "loadRecipeOverrides:";
			public static readonly Selector openCategoryFile_ = "openCategoryFile:";
			public static readonly Selector openRoot = "openRoot";
			public static readonly Selector path = "path";
			public static readonly Selector properties = "properties";
			public static readonly Selector pushSubnode_ = "pushSubnode:";
			public static readonly Selector recalcFigureForResolution_ = "recalcFigureForResolution:";
			public static readonly Selector restoreParameter_from_ = "restoreParameter:from:";
			public static readonly Selector restoreResolutions = "restoreResolutions";
			public static readonly Selector rootIsNil = "rootIsNil";
			public static readonly Selector rootIsOpen = "rootIsOpen";
			public static readonly Selector saveResolutions = "saveResolutions";
			public static readonly Selector setBoolParameterValue_to_ = "setBoolParameterValue:to:";
			public static readonly Selector setBundlePath_ = "setBundlePath:";
			public static readonly Selector setFloatParameterValue_forResolution_to_ = "setFloatParameterValue:forResolution:to:";
			public static readonly Selector setFloatParameterValue_to_ = "setFloatParameterValue:to:";
			public static readonly Selector setIntParameterValue_to_ = "setIntParameterValue:to:";
			public static readonly Selector setPath_ = "setPath:";
			public static readonly Selector setPhase_ = "setPhase:";
			public static readonly Selector setStringParameterValue_to_ = "setStringParameterValue:to:";
			public static readonly Selector stringParameterValue_ = "stringParameterValue:";
			public static readonly Selector subnodesDictionaryForPath_ = "subnodesDictionaryForPath:";
			public static readonly Selector typeForParameter_ = "typeForParameter:";
			public static readonly Selector values_forResolutions_withCount_fromArrayOrNumber_ = "values:forResolutions:withCount:fromArrayOrNumber:";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIUnsharpMask : IEquatable<CIUnsharpMask> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIUnsharpMask;
		public static implicit operator CIFilter( CIUnsharpMask value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIUnsharpMask value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIUnsharpMask value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIUnsharpMask value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIUnsharpMask?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIUnsharpMask value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIUnsharpMask value1, CIUnsharpMask value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIUnsharpMask value1, CIUnsharpMask value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIUnsharpMask( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIUnsharpMask alloc() {
			return new CIUnsharpMask( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( NSObject ) )]
	public struct CIVector : IEquatable<CIVector> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIVector;
		public static implicit operator NSObject( CIVector value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIVector value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIVector value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIVector?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIVector value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIVector value1, CIVector value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIVector value1, CIVector value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIVector( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIVector alloc() {
			return new CIVector( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static CIVector vectorWithString_( string @string ) {
			RuntimeObject ___occuredException;
			var ___wrappedstring = Runtime.CreateStringProxy( @string );
			var ___result = NativeMethods.vectorWithString_( ClassHandle, CachedSelectors.vectorWithString_, out ___occuredException, sizeof( IntPtr ), ___wrappedstring );
			Runtime.ReleaseNativeObject( ___wrappedstring );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIVector( ___result );
		}
		unsafe public static CIVector vectorWithValues_count_( IntPtr values, uint count ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.vectorWithValues_count_( ClassHandle, CachedSelectors.vectorWithValues_count_, out ___occuredException, sizeof( IntPtr ) + sizeof( uint ), values, count );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIVector( ___result );
		}
		unsafe public static CIVector vectorWithX_( float x ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.vectorWithX_( ClassHandle, CachedSelectors.vectorWithX_, out ___occuredException, sizeof( float ), x );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIVector( ___result );
		}
		unsafe public static CIVector vectorWithX_Y_( float x, float Y ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.vectorWithX_Y_( ClassHandle, CachedSelectors.vectorWithX_Y_, out ___occuredException, sizeof( float ) + sizeof( float ), x, Y );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIVector( ___result );
		}
		unsafe public static CIVector vectorWithX_Y_Z_( float x, float Y, float Z ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.vectorWithX_Y_Z_( ClassHandle, CachedSelectors.vectorWithX_Y_Z_, out ___occuredException, sizeof( float ) + sizeof( float ) + sizeof( float ), x, Y, Z );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIVector( ___result );
		}
		unsafe public static CIVector vectorWithX_Y_Z_W_( float x, float Y, float Z, float W ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.vectorWithX_Y_Z_W_( ClassHandle, CachedSelectors.vectorWithX_Y_Z_W_, out ___occuredException, sizeof( float ) + sizeof( float ) + sizeof( float ) + sizeof( float ), x, Y, Z, W );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new CIVector( ___result );
		}
		unsafe public uint count() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.count( Handle, CachedSelectors.count, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint ) ___result;
		}
		unsafe public void encodeWithCoder_( NSCoder coder ) {
			RuntimeObject ___occuredException;
			NativeMethods.encodeWithCoder_( Handle, CachedSelectors.encodeWithCoder_, out ___occuredException, sizeof( NSCoder ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject initWithCoder_( NObjective.RuntimeObject coder ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithCoder_( Handle, CachedSelectors.initWithCoder_, out ___occuredException, sizeof( NObjective.RuntimeObject ), coder );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithString_( NObjective.RuntimeObject @string ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithString_( Handle, CachedSelectors.initWithString_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @string );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithValues_count_( IntPtr values, uint count ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithValues_count_( Handle, CachedSelectors.initWithValues_count_, out ___occuredException, sizeof( IntPtr ) + sizeof( uint ), values, count );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithX_( float x ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithX_( Handle, CachedSelectors.initWithX_, out ___occuredException, sizeof( float ), x );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithX_Y_( float x, float Y ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithX_Y_( Handle, CachedSelectors.initWithX_Y_, out ___occuredException, sizeof( float ) + sizeof( float ), x, Y );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithX_Y_Z_( float x, float Y, float Z ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithX_Y_Z_( Handle, CachedSelectors.initWithX_Y_Z_, out ___occuredException, sizeof( float ) + sizeof( float ) + sizeof( float ), x, Y, Z );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithX_Y_Z_W_( float x, float Y, float Z, float W ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithX_Y_Z_W_( Handle, CachedSelectors.initWithX_Y_Z_W_, out ___occuredException, sizeof( float ) + sizeof( float ) + sizeof( float ) + sizeof( float ), x, Y, Z, W );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public string stringRepresentation() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.stringRepresentation( Handle, CachedSelectors.stringRepresentation, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return Runtime.UnwrapNSString( ___result );
		}
		unsafe public float valueAtIndex_( uint index ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.valueAtIndex_( Handle, CachedSelectors.valueAtIndex_, out ___occuredException, sizeof( uint ), index );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public float W() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.W( Handle, CachedSelectors.W, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public float X() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.X( Handle, CachedSelectors.X, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public float Y() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.Y( Handle, CachedSelectors.Y, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public float Z() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.Z( Handle, CachedSelectors.Z, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern uint count( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void encodeWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NSCoder coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithCoder_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject coder );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithString_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @string );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithValues_count_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr values, uint count );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithX_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, float x );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithX_Y_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, float x, float Y );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithX_Y_Z_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, float x, float Y, float Z );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr initWithX_Y_Z_W_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, float x, float Y, float Z, float W );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr stringRepresentation( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern float valueAtIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint index );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr vectorWithString_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr @string );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr vectorWithValues_count_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, IntPtr values, uint count );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr vectorWithX_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, float x );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr vectorWithX_Y_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, float x, float Y );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr vectorWithX_Y_Z_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, float x, float Y, float Z );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr vectorWithX_Y_Z_W_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, float x, float Y, float Z, float W );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern float W( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern float X( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern float Y( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_fpret_eh2" )]
			public static extern float Z( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector count = "count";
			public static readonly Selector encodeWithCoder_ = "encodeWithCoder:";
			public static readonly Selector initWithCoder_ = "initWithCoder:";
			public static readonly Selector initWithString_ = "initWithString:";
			public static readonly Selector initWithValues_count_ = "initWithValues:count:";
			public static readonly Selector initWithX_ = "initWithX:";
			public static readonly Selector initWithX_Y_ = "initWithX:Y:";
			public static readonly Selector initWithX_Y_Z_ = "initWithX:Y:Z:";
			public static readonly Selector initWithX_Y_Z_W_ = "initWithX:Y:Z:W:";
			public static readonly Selector stringRepresentation = "stringRepresentation";
			public static readonly Selector valueAtIndex_ = "valueAtIndex:";
			public static readonly Selector vectorWithString_ = "vectorWithString:";
			public static readonly Selector vectorWithValues_count_ = "vectorWithValues:count:";
			public static readonly Selector vectorWithX_ = "vectorWithX:";
			public static readonly Selector vectorWithX_Y_ = "vectorWithX:Y:";
			public static readonly Selector vectorWithX_Y_Z_ = "vectorWithX:Y:Z:";
			public static readonly Selector vectorWithX_Y_Z_W_ = "vectorWithX:Y:Z:W:";
			public static readonly Selector W = "W";
			public static readonly Selector X = "X";
			public static readonly Selector Y = "Y";
			public static readonly Selector Z = "Z";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIVideoNoiseFilter : IEquatable<CIVideoNoiseFilter> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIVideoNoiseFilter;
		public static implicit operator CIFilter( CIVideoNoiseFilter value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIVideoNoiseFilter value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIVideoNoiseFilter value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIVideoNoiseFilter value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIVideoNoiseFilter?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIVideoNoiseFilter value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIVideoNoiseFilter value1, CIVideoNoiseFilter value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIVideoNoiseFilter value1, CIVideoNoiseFilter value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIVideoNoiseFilter( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIVideoNoiseFilter alloc() {
			return new CIVideoNoiseFilter( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIVividLightBlendMode : IEquatable<CIVividLightBlendMode> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIVividLightBlendMode;
		public static implicit operator CIFilter( CIVividLightBlendMode value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIVividLightBlendMode value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIVividLightBlendMode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIVividLightBlendMode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIVividLightBlendMode?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIVividLightBlendMode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIVividLightBlendMode value1, CIVividLightBlendMode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIVividLightBlendMode value1, CIVividLightBlendMode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIVividLightBlendMode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIVividLightBlendMode alloc() {
			return new CIVividLightBlendMode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIVortexDistortion : IEquatable<CIVortexDistortion> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIVortexDistortion;
		public static implicit operator CIFilter( CIVortexDistortion value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIVortexDistortion value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIVortexDistortion value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIVortexDistortion value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIVortexDistortion?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIVortexDistortion value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIVortexDistortion value1, CIVortexDistortion value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIVortexDistortion value1, CIVortexDistortion value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIVortexDistortion( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIVortexDistortion alloc() {
			return new CIVortexDistortion( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIWhitePoint : IEquatable<CIWhitePoint> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIWhitePoint;
		public static implicit operator CIFilter( CIWhitePoint value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIWhitePoint value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIWhitePoint value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIWhitePoint value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIWhitePoint?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIWhitePoint value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIWhitePoint value1, CIWhitePoint value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIWhitePoint value1, CIWhitePoint value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIWhitePoint( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIWhitePoint alloc() {
			return new CIWhitePoint( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIWhitePointAdjust : IEquatable<CIWhitePointAdjust> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIWhitePointAdjust;
		public static implicit operator CIFilter( CIWhitePointAdjust value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIWhitePointAdjust value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIWhitePointAdjust value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIWhitePointAdjust value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIWhitePointAdjust?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIWhitePointAdjust value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIWhitePointAdjust value1, CIWhitePointAdjust value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIWhitePointAdjust value1, CIWhitePointAdjust value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIWhitePointAdjust( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIWhitePointAdjust alloc() {
			return new CIWhitePointAdjust( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIYCbCrSubsampledReconstruction : IEquatable<CIYCbCrSubsampledReconstruction> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIYCbCrSubsampledReconstruction;
		public static implicit operator CIFilter( CIYCbCrSubsampledReconstruction value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIYCbCrSubsampledReconstruction value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIYCbCrSubsampledReconstruction value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIYCbCrSubsampledReconstruction value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIYCbCrSubsampledReconstruction?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIYCbCrSubsampledReconstruction value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIYCbCrSubsampledReconstruction value1, CIYCbCrSubsampledReconstruction value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIYCbCrSubsampledReconstruction value1, CIYCbCrSubsampledReconstruction value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIYCbCrSubsampledReconstruction( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIYCbCrSubsampledReconstruction alloc() {
			return new CIYCbCrSubsampledReconstruction( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	[ProxyBaseClass( typeof( CIFilter ) )]
	public struct CIZoomBlur : IEquatable<CIZoomBlur> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = QuartzCoreCachedClasses.CIZoomBlur;
		public static implicit operator CIFilter( CIZoomBlur value ) {
			return new CIFilter( value.Handle );
		}
		public static implicit operator NSObject( CIZoomBlur value ) {
			return new NSObject( value.Handle );
		}
		public static implicit operator IntPtr( CIZoomBlur value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CIZoomBlur value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CIZoomBlur?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CIZoomBlur value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CIZoomBlur value1, CIZoomBlur value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CIZoomBlur value1, CIZoomBlur value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CIZoomBlur( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CIZoomBlur alloc() {
			return new CIZoomBlur( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject blur_pass_( NObjective.RuntimeObject blur, int pass ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.blur_pass_( Handle, CachedSelectors.blur_pass_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( int ), blur, pass );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject outputImage() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.outputImage( Handle, CachedSelectors.outputImage, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr blur_pass_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject blur, int pass );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern IntPtr outputImage( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector blur_pass_ = "blur:pass:";
			public static readonly Selector outputImage = "outputImage";
		}
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	public static class QuartzCoreExtensionsOfNSObject {
		private static int ___lazyLoad = QuartzCoreCachedClasses.___lazyLoad;
	}
	[StructLayoutAttribute( LayoutKind.Explicit )]
	public static class QuartzCoreExtensionsOfNSArray {
		private static int ___lazyLoad = QuartzCoreCachedClasses.___lazyLoad;
	}
	static internal class QuartzCoreCachedClasses {
		static internal int ___lazyLoad = Platform.NativeMethods.dlopen( "/System/Library/Frameworks/QuartzCore.framework/Versions/A/QuartzCore" );
		public static readonly RuntimeClass CIAddBlendMode = "CIAddBlendMode";
		public static readonly RuntimeClass CIAdditionCompositing = "CIAdditionCompositing";
		public static readonly RuntimeClass CIAffineClamp = "CIAffineClamp";
		public static readonly RuntimeClass CIAffineTile = "CIAffineTile";
		public static readonly RuntimeClass CIAffineTransform = "CIAffineTransform";
		public static readonly RuntimeClass CIAlphaAddBlendMode = "CIAlphaAddBlendMode";
		public static readonly RuntimeClass CIAutoBlackPointWhitePoint = "CIAutoBlackPointWhitePoint";
		public static readonly RuntimeClass CIBackground = "CIBackground";
		public static readonly RuntimeClass CIBayerReconstruction = "CIBayerReconstruction";
		public static readonly RuntimeClass CIBayerReconstructionFuji = "CIBayerReconstructionFuji";
		public static readonly RuntimeClass CIBayerReconstructionV0 = "CIBayerReconstructionV0";
		public static readonly RuntimeClass CIBehindBlendMode = "CIBehindBlendMode";
		public static readonly RuntimeClass CIBilateralConvolution = "CIBilateralConvolution";
		public static readonly RuntimeClass CIBilateralFilter = "CIBilateralFilter";
		public static readonly RuntimeClass CIBitmapContext = "CIBitmapContext";
		public static readonly RuntimeClass CIBitmapContextImpl = "CIBitmapContextImpl";
		public static readonly RuntimeClass CIBlendWithMask = "CIBlendWithMask";
		public static readonly RuntimeClass CIBloom = "CIBloom";
		public static readonly RuntimeClass CIBumpDistortion = "CIBumpDistortion";
		public static readonly RuntimeClass CICGContext = "CICGContext";
		public static readonly RuntimeClass CICGContextImpl = "CICGContextImpl";
		public static readonly RuntimeClass CICGSFilter = "CICGSFilter";
		public static readonly RuntimeClass CICheapBlur = "CICheapBlur";
		public static readonly RuntimeClass CICheckerboardGenerator = "CICheckerboardGenerator";
		public static readonly RuntimeClass CIChopLines = "CIChopLines";
		public static readonly RuntimeClass CICircleSplashDistortion = "CICircleSplashDistortion";
		public static readonly RuntimeClass CICircularScreen = "CICircularScreen";
		public static readonly RuntimeClass CICircularWrap = "CICircularWrap";
		public static readonly RuntimeClass CICMYKHalftone = "CICMYKHalftone";
		public static readonly RuntimeClass CIColor = "CIColor";
		public static readonly RuntimeClass CIColorBlendMode = "CIColorBlendMode";
		public static readonly RuntimeClass CIColorBurnBlendMode = "CIColorBurnBlendMode";
		public static readonly RuntimeClass CIColorControls = "CIColorControls";
		public static readonly RuntimeClass CIColorCube = "CIColorCube";
		public static readonly RuntimeClass CIColorDodgeBlendMode = "CIColorDodgeBlendMode";
		public static readonly RuntimeClass CIColorInvert = "CIColorInvert";
		public static readonly RuntimeClass CIColorMap = "CIColorMap";
		public static readonly RuntimeClass CIColorMatrix = "CIColorMatrix";
		public static readonly RuntimeClass CIColorMonochrome = "CIColorMonochrome";
		public static readonly RuntimeClass CIColorPosterize = "CIColorPosterize";
		public static readonly RuntimeClass CIColorWheelGenerator = "CIColorWheelGenerator";
		public static readonly RuntimeClass CIConcreteImage = "CIConcreteImage";
		public static readonly RuntimeClass CIConcreteKernel = "CIConcreteKernel";
		public static readonly RuntimeClass CIConcretePromise = "CIConcretePromise";
		public static readonly RuntimeClass CIConcreteSampler = "CIConcreteSampler";
		public static readonly RuntimeClass CIConstantColorGenerator = "CIConstantColorGenerator";
		public static readonly RuntimeClass CIContext = "CIContext";
		public static readonly RuntimeClass CIContextImpl = "CIContextImpl";
		public static readonly RuntimeClass CICopyMachineTransition = "CICopyMachineTransition";
		public static readonly RuntimeClass CICrop = "CICrop";
		public static readonly RuntimeClass CICrystallize = "CICrystallize";
		public static readonly RuntimeClass CICVImageProviderDelegate = "CICVImageProviderDelegate";
		public static readonly RuntimeClass CIDarkenBlendMode = "CIDarkenBlendMode";
		public static readonly RuntimeClass CIDeBayer = "CIDeBayer";
		public static readonly RuntimeClass CIDesaturateGamutMapping = "CIDesaturateGamutMapping";
		public static readonly RuntimeClass CIDifferenceBlendMode = "CIDifferenceBlendMode";
		public static readonly RuntimeClass CIDisintegrateWithMaskTransition = "CIDisintegrateWithMaskTransition";
		public static readonly RuntimeClass CIDisplacementDistortion = "CIDisplacementDistortion";
		public static readonly RuntimeClass CIDisplaceWithNoise = "CIDisplaceWithNoise";
		public static readonly RuntimeClass CIDissolveTransition = "CIDissolveTransition";
		public static readonly RuntimeClass CIDistanceFieldFromMask = "CIDistanceFieldFromMask";
		public static readonly RuntimeClass CIDotScreen = "CIDotScreen";
		public static readonly RuntimeClass CIEdge = "CIEdge";
		public static readonly RuntimeClass CIEdges = "CIEdges";
		public static readonly RuntimeClass CIEdgeWork = "CIEdgeWork";
		public static readonly RuntimeClass CIEmboss = "CIEmboss";
		public static readonly RuntimeClass CIExclusionBlendMode = "CIExclusionBlendMode";
		public static readonly RuntimeClass CIExposureAdjust = "CIExposureAdjust";
		public static readonly RuntimeClass CIFalseColor = "CIFalseColor";
		public static readonly RuntimeClass CIFilter = "CIFilter";
		public static readonly RuntimeClass CIFilterClassDescription = "CIFilterClassDescription";
		public static readonly RuntimeClass CIFilterGraph = "CIFilterGraph";
		public static readonly RuntimeClass CIFilterPlugIn = "CIFilterPlugIn";
		public static readonly RuntimeClass CIFilterShape = "CIFilterShape";
		public static readonly RuntimeClass CIFlashTransition = "CIFlashTransition";
		public static readonly RuntimeClass CIFullButton = "CIFullButton";
		public static readonly RuntimeClass CIGammaAdjust = "CIGammaAdjust";
		public static readonly RuntimeClass CIGamutAlarm = "CIGamutAlarm";
		public static readonly RuntimeClass CIGamutClamp = "CIGamutClamp";
		public static readonly RuntimeClass CIGamutRollOff = "CIGamutRollOff";
		public static readonly RuntimeClass CIGaussianBlur = "CIGaussianBlur";
		public static readonly RuntimeClass CIGaussianGradient = "CIGaussianGradient";
		public static readonly RuntimeClass CIGaussianPyramid = "CIGaussianPyramid";
		public static readonly RuntimeClass CIGlassDistortion = "CIGlassDistortion";
		public static readonly RuntimeClass CIGlassLozenge = "CIGlassLozenge";
		public static readonly RuntimeClass CIGloom = "CIGloom";
		public static readonly RuntimeClass CIGraph = "CIGraph";
		public static readonly RuntimeClass CIHardLightBlendMode = "CIHardLightBlendMode";
		public static readonly RuntimeClass CIHardMixBlendMode = "CIHardMixBlendMode";
		public static readonly RuntimeClass CIHatchedScreen = "CIHatchedScreen";
		public static readonly RuntimeClass CIHeightFieldFromConstraints = "CIHeightFieldFromConstraints";
		public static readonly RuntimeClass CIHeightFieldFromMask = "CIHeightFieldFromMask";
		public static readonly RuntimeClass CIHistogram = "CIHistogram";
		public static readonly RuntimeClass CIHoleDistortion = "CIHoleDistortion";
		public static readonly RuntimeClass CIHueAdjust = "CIHueAdjust";
		public static readonly RuntimeClass CIHueBlendMode = "CIHueBlendMode";
		public static readonly RuntimeClass CIImage = "CIImage";
		public static readonly RuntimeClass CIImageAccumulator = "CIImageAccumulator";
		public static readonly RuntimeClass CIKaleidoscope = "CIKaleidoscope";
		public static readonly RuntimeClass CIKernel = "CIKernel";
		public static readonly RuntimeClass CILanczosBayerReconstruction = "CILanczosBayerReconstruction";
		public static readonly RuntimeClass CILanczosResize = "CILanczosResize";
		public static readonly RuntimeClass CILanczosScaleTransform = "CILanczosScaleTransform";
		public static readonly RuntimeClass CILenticularHaloGenerator = "CILenticularHaloGenerator";
		public static readonly RuntimeClass CILightenBlendMode = "CILightenBlendMode";
		public static readonly RuntimeClass CILinearBurnBlendMode = "CILinearBurnBlendMode";
		public static readonly RuntimeClass CILinearDodgeBlendMode = "CILinearDodgeBlendMode";
		public static readonly RuntimeClass CILinearGradient = "CILinearGradient";
		public static readonly RuntimeClass CILinearLightBlendMode = "CILinearLightBlendMode";
		public static readonly RuntimeClass CILineScreen = "CILineScreen";
		public static readonly RuntimeClass CILuminanceGamutMapping = "CILuminanceGamutMapping";
		public static readonly RuntimeClass CILuminescentPremultiplyBlendMode = "CILuminescentPremultiplyBlendMode";
		public static readonly RuntimeClass CILuminosityBlendMode = "CILuminosityBlendMode";
		public static readonly RuntimeClass CIMaskToAlpha = "CIMaskToAlpha";
		public static readonly RuntimeClass CIMaterialMap = "CIMaterialMap";
		public static readonly RuntimeClass CIMaximumCompositing = "CIMaximumCompositing";
		public static readonly RuntimeClass CIMedianFilter = "CIMedianFilter";
		public static readonly RuntimeClass CIMinimumCompositing = "CIMinimumCompositing";
		public static readonly RuntimeClass CIMixOver = "CIMixOver";
		public static readonly RuntimeClass CIModTransition = "CIModTransition";
		public static readonly RuntimeClass CIMotionBlur = "CIMotionBlur";
		public static readonly RuntimeClass CIMultiplyBlendMode = "CIMultiplyBlendMode";
		public static readonly RuntimeClass CIMultiplyCompositing = "CIMultiplyCompositing";
		public static readonly RuntimeClass CIMutableFilterShape = "CIMutableFilterShape";
		public static readonly RuntimeClass CIMutableUIBundle = "CIMutableUIBundle";
		public static readonly RuntimeClass CINoiseReduction = "CINoiseReduction";
		public static readonly RuntimeClass CIOpacity = "CIOpacity";
		public static readonly RuntimeClass CIOpenGLContext = "CIOpenGLContext";
		public static readonly RuntimeClass CIOpenGLContextImpl = "CIOpenGLContextImpl";
		public static readonly RuntimeClass CIOpTile = "CIOpTile";
		public static readonly RuntimeClass CIOverlayBlendMode = "CIOverlayBlendMode";
		public static readonly RuntimeClass CIPageCurlTransition = "CIPageCurlTransition";
		public static readonly RuntimeClass CIParallelogramTile = "CIParallelogramTile";
		public static readonly RuntimeClass CIPerspectiveTile = "CIPerspectiveTile";
		public static readonly RuntimeClass CIPerspectiveTransform = "CIPerspectiveTransform";
		public static readonly RuntimeClass CIPinchDistortion = "CIPinchDistortion";
		public static readonly RuntimeClass CIPinLightBlendMode = "CIPinLightBlendMode";
		public static readonly RuntimeClass CIPixellate = "CIPixellate";
		public static readonly RuntimeClass CIPixelZoom = "CIPixelZoom";
		public static readonly RuntimeClass CIPlugIn = "CIPlugIn";
		public static readonly RuntimeClass CIPlugInStandardFilter = "CIPlugInStandardFilter";
		public static readonly RuntimeClass CIPointillize = "CIPointillize";
		public static readonly RuntimeClass CIPromise = "CIPromise";
		public static readonly RuntimeClass CIPromiseInvocation = "CIPromiseInvocation";
		public static readonly RuntimeClass CIRadialGradient = "CIRadialGradient";
		public static readonly RuntimeClass CIRandomGenerator = "CIRandomGenerator";
		public static readonly RuntimeClass CIRAWGamutMapping = "CIRAWGamutMapping";
		public static readonly RuntimeClass CIRAWSharpen = "CIRAWSharpen";
		public static readonly RuntimeClass CIRAWTemperatureAdjust = "CIRAWTemperatureAdjust";
		public static readonly RuntimeClass CIRecordingContext = "CIRecordingContext";
		public static readonly RuntimeClass CIRecordingContextImpl = "CIRecordingContextImpl";
		public static readonly RuntimeClass CIRectangleGenerator = "CIRectangleGenerator";
		public static readonly RuntimeClass CIRefractedMaterial = "CIRefractedMaterial";
		public static readonly RuntimeClass CIRenderProviderDelegate = "CIRenderProviderDelegate";
		public static readonly RuntimeClass CIRippleTransition = "CIRippleTransition";
		public static readonly RuntimeClass CIRotatingCubeTransition = "CIRotatingCubeTransition";
		public static readonly RuntimeClass CISampleAreaOperation = "CISampleAreaOperation";
		public static readonly RuntimeClass CISampler = "CISampler";
		public static readonly RuntimeClass CISaturationBlendMode = "CISaturationBlendMode";
		public static readonly RuntimeClass CIScreenBlendMode = "CIScreenBlendMode";
		public static readonly RuntimeClass CISepiaTone = "CISepiaTone";
		public static readonly RuntimeClass CIShadedMaterial = "CIShadedMaterial";
		public static readonly RuntimeClass CIShapedWaterRipple = "CIShapedWaterRipple";
		public static readonly RuntimeClass CISharpenLuminance = "CISharpenLuminance";
		public static readonly RuntimeClass CISilhouetteAlphaBlendMode = "CISilhouetteAlphaBlendMode";
		public static readonly RuntimeClass CISilhouetteLumaBlendMode = "CISilhouetteLumaBlendMode";
		public static readonly RuntimeClass CISoftLightBlendMode = "CISoftLightBlendMode";
		public static readonly RuntimeClass CISourceAtopCompositing = "CISourceAtopCompositing";
		public static readonly RuntimeClass CISourceInCompositing = "CISourceInCompositing";
		public static readonly RuntimeClass CISourceOutCompositing = "CISourceOutCompositing";
		public static readonly RuntimeClass CISourceOverCompositing = "CISourceOverCompositing";
		public static readonly RuntimeClass CISpotLight = "CISpotLight";
		public static readonly RuntimeClass CIStarShineGenerator = "CIStarShineGenerator";
		public static readonly RuntimeClass CIStencilAlphaBlendMode = "CIStencilAlphaBlendMode";
		public static readonly RuntimeClass CIStencilLumaBlendMode = "CIStencilLumaBlendMode";
		public static readonly RuntimeClass CIStripesGenerator = "CIStripesGenerator";
		public static readonly RuntimeClass CISubtractBlendMode = "CISubtractBlendMode";
		public static readonly RuntimeClass CISumOf8Conics = "CISumOf8Conics";
		public static readonly RuntimeClass CISunbeamsGenerator = "CISunbeamsGenerator";
		public static readonly RuntimeClass CISwipeTransition = "CISwipeTransition";
		public static readonly RuntimeClass CITagWithColorSpace = "CITagWithColorSpace";
		public static readonly RuntimeClass CITorusLensDistortion = "CITorusLensDistortion";
		public static readonly RuntimeClass CITriangleTile = "CITriangleTile";
		public static readonly RuntimeClass CITwirlDistortion = "CITwirlDistortion";
		public static readonly RuntimeClass CIUIBundle = "CIUIBundle";
		public static readonly RuntimeClass CIUnsharpMask = "CIUnsharpMask";
		public static readonly RuntimeClass CIVector = "CIVector";
		public static readonly RuntimeClass CIVideoNoiseFilter = "CIVideoNoiseFilter";
		public static readonly RuntimeClass CIVividLightBlendMode = "CIVividLightBlendMode";
		public static readonly RuntimeClass CIVortexDistortion = "CIVortexDistortion";
		public static readonly RuntimeClass CIWhitePoint = "CIWhitePoint";
		public static readonly RuntimeClass CIWhitePointAdjust = "CIWhitePointAdjust";
		public static readonly RuntimeClass CIYCbCrSubsampledReconstruction = "CIYCbCrSubsampledReconstruction";
		public static readonly RuntimeClass CIZoomBlur = "CIZoomBlur";
		public static readonly RuntimeClass NSObject = "NSObject";
		public static readonly RuntimeClass NSArray = "NSArray";
	}
}
