//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System.Diagnostics;
using System;
using System.Reflection;

[assembly: AssemblyVersion( "0.5.0.0" )]

namespace Monobjc.Cocoa
{
	public class MonobjcTest : NObjective.PerformanceTestBase
	{
		private static NSAutoreleasePool _pool;

		private static void Main( string[] args )
		{
			test_regression();
		}

		/// <summary>
		/// Used for regression tests.
		/// </summary>
		public static void test_regression()
		{
			ObjectiveCRuntime.LoadFramework( "Cocoa" );
			ObjectiveCRuntime.Initialize();

			var test = new MonobjcTest();

			test.OnBeginTest += () => { _pool = new NSAutoreleasePool(); };
			test.OnEndTest += () => { _pool.Release(); _pool = null; };

			test.TestAll( typeof( ObjectiveCRuntime ).Assembly );
		}

		public override void TestVarargMarshaling( int iterations )
		{
			var instance = new NSString( "some string to test" ).Autorelease<NSString>();

			for( int i = 0; i < iterations; i++ )
				instance.StringByAppendingFormat( " %@ %@ %f %d %d", ( NSString ) "some", ( NSString ) "text", System.Math.PI, true, 10 ).ToString();
		}

		public override void TestInvocation( int iterations )
		{
			uint hash = 0;
			var instance = new NSNumber( 10 ).Autorelease<NSNumber>();

			for( int i = 0; i < iterations; i++ )
				hash += instance.Hash;
		}

		public override void TestAllocation( int iterations )
		{
			for( int i = 0; i < iterations; i++ )
				new NSNumber( 10 ).Autorelease<NSNumber>();
		}
	}
}