using System;
using System.IO;
using System.Runtime.InteropServices;
using Cocoa;

namespace Cocoa {
	public class Bundle : Cocoa.Object {
		private static string ObjectiveCName = "NSBundle";                                                                                      
		public Bundle (IntPtr native_object) : base (native_object) {}

		public static Bundle BundleWithPath (string path) {
			return (Bundle) Object.FromIntPtr ((IntPtr) ObjCMessaging.objc_msgSend ((IntPtr) ObjCClass.FromType (typeof (Bundle)).ToIntPtr (), "bundleWithPath:", typeof (IntPtr), typeof (IntPtr), new Cocoa.String (path).NativeObject));
		}

		public static void LoadFramework (string frameworkname) {
			if (Directory.Exists (System.String.Format ("/System/Library/Frameworks/{0}.framework", frameworkname))) {
				Bundle b = Bundle.BundleWithPath (System.String.Format ("/System/Library/Frameworks/{0}.framework", frameworkname));
				if (b.NativeObject == IntPtr.Zero)
					throw new Exception ("Error loading framework: {0}" + frameworkname);
				b.Load ();
				return;
			}
			if (Directory.Exists (System.String.Format ("./{0}.framework", frameworkname))) {
				Bundle b = Bundle.BundleWithPath (System.String.Format ("./{0}.framework", frameworkname));
				if (b.NativeObject == IntPtr.Zero)
					throw new Exception ("Error loading framework: {0}" + frameworkname);
				b.Load ();
				return;
			}
			// TODO: Load from MainBundle.ResourcePath
			throw new Exception ("Couldn't locate framework: " + frameworkname);
		}

		public static void LoadNib (string nibname) {
			Dictionary dict = new Dictionary ("NSOwner", Application.SharedApplication);
			ObjCMessaging.objc_msgSend ((IntPtr) ObjCClass.FromType (typeof (Bundle)).ToIntPtr (), "loadNibFile:externalNameTable:withZone:", typeof (bool), typeof (System.IntPtr), new Cocoa.String (nibname).NativeObject, typeof (System.IntPtr), dict.NativeObject, typeof (System.IntPtr), Application.SharedApplication.Zone);
			ObjCMessaging.objc_msgSend ((IntPtr) ObjCClass.FromType (typeof (Bundle)).ToIntPtr (), "loadNibNamed:owner:", typeof (bool), typeof (System.IntPtr), new Cocoa.String (nibname).NativeObject, typeof (System.IntPtr), Application.SharedApplication.NativeObject);
		}

		public void Load () {
			ObjCMessaging.objc_msgSend (NativeObject, "load", typeof (void));
		}

		public static Bundle Main {
			get {
				return (Bundle)Object.FromIntPtr((IntPtr)ObjCMessaging.objc_msgSend ((IntPtr) ObjCClass.FromType (typeof (Bundle)).ToIntPtr (), "mainBundle", typeof (IntPtr)));
			}
		}
		public bool LoadNibFile (string nibname) {
			Dictionary dict = new Dictionary ("NSOwner", Application.SharedApplication);
			return (bool)ObjCMessaging.objc_msgSend (NativeObject, "loadNibFile:externalNameTable:withZone:", typeof (bool), typeof (System.IntPtr), new Cocoa.String (nibname).NativeObject, typeof (System.IntPtr), dict.NativeObject, typeof (System.IntPtr), Application.SharedApplication.Zone);
		}
	}
}
