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
	public struct CTGlyphStorageInterface : IEquatable<CTGlyphStorageInterface> {
		[FieldOffsetAttribute( 0 )]
		private NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = CoreTextCachedClasses.CTGlyphStorageInterface;
		public static implicit operator IntPtr( CTGlyphStorageInterface value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CTGlyphStorageInterface value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			var compareTo = value as CTGlyphStorageInterface?;
			return compareTo != null && Handle == compareTo.Value.Handle;
		}
		public bool Equals( CTGlyphStorageInterface value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CTGlyphStorageInterface value1, CTGlyphStorageInterface value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CTGlyphStorageInterface value1, CTGlyphStorageInterface value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CTGlyphStorageInterface( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CTGlyphStorageInterface alloc() {
			return new CTGlyphStorageInterface( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void disposeGlyphStack() {
			RuntimeObject ___occuredException;
			NativeMethods.disposeGlyphStack( Handle, CachedSelectors.disposeGlyphStack, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void initGlyphStack_( int stack ) {
			RuntimeObject ___occuredException;
			NativeMethods.initGlyphStack_( Handle, CachedSelectors.initGlyphStack_, out ___occuredException, sizeof( int ), stack );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void popGlyph_( int glyph ) {
			RuntimeObject ___occuredException;
			NativeMethods.popGlyph_( Handle, CachedSelectors.popGlyph_, out ___occuredException, sizeof( int ), glyph );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void pushGlyph_( int glyph ) {
			RuntimeObject ___occuredException;
			NativeMethods.pushGlyph_( Handle, CachedSelectors.pushGlyph_, out ___occuredException, sizeof( int ), glyph );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setAbsorbedCount_forIndex_( int count, int forIndex ) {
			RuntimeObject ___occuredException;
			NativeMethods.setAbsorbedCount_forIndex_( Handle, CachedSelectors.setAbsorbedCount_forIndex_, out ___occuredException, sizeof( int ) + sizeof( int ), count, forIndex );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setGlyphID_forIndex_( ushort id, int forIndex ) {
			RuntimeObject ___occuredException;
			NativeMethods.setGlyphID_forIndex_( Handle, CachedSelectors.setGlyphID_forIndex_, out ___occuredException, sizeof( ushort ) + sizeof( int ), id, forIndex );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setProps_forIndex_( uint props, int forIndex ) {
			RuntimeObject ___occuredException;
			NativeMethods.setProps_forIndex_( Handle, CachedSelectors.setProps_forIndex_, out ___occuredException, sizeof( uint ) + sizeof( int ), props, forIndex );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setStringIndex_forIndex_( int index, int forIndex ) {
			RuntimeObject ___occuredException;
			NativeMethods.setStringIndex_forIndex_( Handle, CachedSelectors.setStringIndex_forIndex_, out ___occuredException, sizeof( int ) + sizeof( int ), index, forIndex );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void swapGlyph_withIndex_( int glyph, int withIndex ) {
			RuntimeObject ___occuredException;
			NativeMethods.swapGlyph_withIndex_( Handle, CachedSelectors.swapGlyph_withIndex_, out ___occuredException, sizeof( int ) + sizeof( int ), glyph, withIndex );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void disposeGlyphStack( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void initGlyphStack_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int stack );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void popGlyph_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int glyph );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void pushGlyph_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int glyph );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setAbsorbedCount_forIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int count, int forIndex );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setGlyphID_forIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, ushort id, int forIndex );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setProps_forIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint props, int forIndex );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void setStringIndex_forIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int index, int forIndex );
			[DllImport( Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2" )]
			public static extern void swapGlyph_withIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int glyph, int withIndex );
		}
		static internal class CachedSelectors {
			public static readonly Selector disposeGlyphStack = "disposeGlyphStack";
			public static readonly Selector initGlyphStack_ = "initGlyphStack:";
			public static readonly Selector popGlyph_ = "popGlyph:";
			public static readonly Selector pushGlyph_ = "pushGlyph:";
			public static readonly Selector setAbsorbedCount_forIndex_ = "setAbsorbedCount:forIndex:";
			public static readonly Selector setGlyphID_forIndex_ = "setGlyphID:forIndex:";
			public static readonly Selector setProps_forIndex_ = "setProps:forIndex:";
			public static readonly Selector setStringIndex_forIndex_ = "setStringIndex:forIndex:";
			public static readonly Selector swapGlyph_withIndex_ = "swapGlyph:withIndex:";
		}
	}
	static internal class CoreTextCachedClasses {
		static internal int ___lazyLoad = Platform.NativeMethods.dlopen( "/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreText.framework/Versions/A/CoreText" );
		public static readonly RuntimeClass CTGlyphStorageInterface = "CTGlyphStorageInterface";
	}
}
