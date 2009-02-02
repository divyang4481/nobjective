//
// Copyright (C) 2009 Eugeny Grishul
//
// See license in License.txt
//

namespace NObjective.Proxies {
	using System;
	using System.Runtime.InteropServices;
	[ProxyBaseClass(typeof( NSObject ))]
	public struct CocoaWindowController : IEquatable<CocoaWindowController> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = BackupCachedClasses.CocoaWindowController;
		public static implicit operator IntPtr( CocoaWindowController value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( CocoaWindowController value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is CocoaWindowController ) ) return false; 
			return Handle == ( ( CocoaWindowController )value ).Handle;
		}
		public bool Equals( CocoaWindowController value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( CocoaWindowController value1, CocoaWindowController value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( CocoaWindowController value1, CocoaWindowController value2 ) {
			return value1.Handle != value2.Handle;
		}
		public CocoaWindowController( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static CocoaWindowController alloc() {
			return new CocoaWindowController( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void windowDidEndLiveResize_( NObjective.RuntimeObject resize ) {
			RuntimeObject ___occuredException;
			NativeMethods.windowDidEndLiveResize_( Handle, CachedSelectors.windowDidEndLiveResize_, out ___occuredException, sizeof( NObjective.RuntimeObject ), resize );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void windowWillStartLiveResize_( NObjective.RuntimeObject resize ) {
			RuntimeObject ___occuredException;
			NativeMethods.windowWillStartLiveResize_( Handle, CachedSelectors.windowWillStartLiveResize_, out ___occuredException, sizeof( NObjective.RuntimeObject ), resize );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void windowDidEndLiveResize_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject resize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void windowWillStartLiveResize_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject resize );
		}
		static internal class CachedSelectors {
			public static readonly Selector windowDidEndLiveResize_ = "windowDidEndLiveResize:";
			public static readonly Selector windowWillStartLiveResize_ = "windowWillStartLiveResize:";
		}
	}
	static internal class BackupCachedClasses {
		static internal int ___lazyLoad = Platform.NativeMethods.dlopen( "/System/Library/PrivateFrameworks/Backup.framework/Versions/A/Backup" );
		public static readonly RuntimeClass CocoaWindowController = "CocoaWindowController";
	}
}
