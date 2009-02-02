//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System.Diagnostics;
using System;

namespace Cocoa
{
	public class CocoaSharpTest : NObjective.PerformanceTestBase
	{
		private static AutoreleasePool _pool;

		private static void Main( string[] args )
		{
			test_regression();
		}

		/// <summary>
		/// Used for regression tests.
		/// </summary>
		public static void test_regression()
		{
			var test = new CocoaSharpTest();

			test.OnBeginTest += () => { _pool = new AutoreleasePool(); };
			test.OnEndTest += () => { _pool.Dispose(); };

			test.TestAll( typeof( AutoreleasePool ).Assembly );
		}

		public override void TestVarargMarshaling( int iterations )
		{
			var instance = new Cocoa.String( "some string to test" );

			for( int i = 0; i < iterations; i++ )
				new Cocoa.String( ( IntPtr ) ObjCMessaging.objc_msgSend( instance.NativeObject, "stringByAppendingFormat:", typeof( IntPtr ), typeof( IntPtr ), new Cocoa.String( " %@ %@ %f %d %d" ).NativeObject, typeof( IntPtr ), new Cocoa.String( "some" ).NativeObject, typeof( IntPtr ), new Cocoa.String( "text" ).NativeObject, typeof( double ), System.Math.PI, typeof( bool ), true, typeof( int ), 10 ) ).ToString();
		}

		public override void TestInvocation( int iterations )
		{
			var instance = new NSNumber( 10 );

			for( int i = 0; i < iterations; i++ )
				instance.hash();
		}

		public override void TestAllocation( int iterations )
		{
			for( int i = 0; i < iterations; i++ )
				new NSNumber( 10 );
		}
	}

	public class NSNumber : Cocoa.Object
	{
		private static string ObjectiveCName = "NSNumber";
		public NSNumber() : base() { }

		public NSNumber( IntPtr native_object ) : base( native_object ) { }

		public NSNumber( int initialValue )
		{
			NativeObject = ( IntPtr ) ObjCMessaging.objc_msgSend( NativeClass.ToIntPtr(), "numberWithInt:", typeof( IntPtr ), typeof( int ), initialValue );
		}

		public int hash()
		{
			return ( int ) ObjCMessaging.objc_msgSend( NativeClass.ToIntPtr(), "hash", typeof( int ) );
		}
	}
}