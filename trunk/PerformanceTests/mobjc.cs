//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System.Diagnostics;
using System;


namespace MObjc
{
	public class MobjcTest : NObjective.PerformanceTestBase
	{
		private static void Main( string[] args )
		{
			test_regression();
		}
		
		/// <summary>
		/// Used for regression tests.
		/// </summary>
		public static void test_regression()
		{
			Registrar.CanInit = true;
			Managed.LogException = delegate { };

			NSObject pool = null;

			var test = new MobjcTest();

			test.OnBeginTest += () => { pool = ( NSObject ) new Class( "NSAutoreleasePool" ).Call( "alloc" ).Call( "init" ); };
			test.OnEndTest += () => { pool.release(); };

			test.TestAll( typeof( NSObject ).Assembly );
		}

		public override void TestVarargMarshaling( int iterations )
		{
			throw new NotImplementedException();

			var instance = new Class( "NSString" ).Call( "stringWithUTF8String:", "some string to test" );
			var selector = new Selector( "stringByAppendingFormat:" );

			for( int i = 0; i < iterations; i++ )
				instance.Call( selector, " %@ %@ %f %d %d", "some", "text", System.Math.PI, true, 10 );
		}

		public override void TestInvocation( int iterations )
		{
			var selector = new Selector( "hash" );
			var instance = new Class( "NSNumber" ).Call( "numberWithInt:", 10 );

			for( int i = 0; i < iterations; i++ )
				instance.Call( selector );
		}

		public override void TestAllocation( int iterations )
		{
			var @class = new Class( "NSNumber" );
			var selector = new Selector( "numberWithInt:" );

			for( int i = 0; i < iterations; i++ )
				@class.Call( selector, 10 );
		}

		public override void TestExceptionHandlerOverhead( int iterations )
		{
			var instance = new Class( typeof( ExceptionTester ).Name ).Call( "alloc" ).Call( "init" ).To<NSObject>();
			var selector = new Selector( "NoThrow:arg2:arg3:arg4:arg5:" );

			for( int i = 0; i < iterations; i++ )
			{
				try { instance.Call( selector, 10L, 20L, 30L, 40L, 50L ); }
				catch { }
			}
		}

		public override void TestExceptionRethrow( int iterations )
		{
			var instance = new Class( typeof( ExceptionTester ).Name ).Call( "alloc" ).Call( "init" ).To<NSObject>();
			var selector = new Selector( "Throw:arg2:arg3:arg4:arg5:" );

			for( int i = 0; i < iterations; i++ )
			{
				try { instance.Call( selector, 10L, 20L, 30L, 40L, 50L ); }
				catch { }
			}
		}
	}

	[ExportClass( "ExceptionTester", "NSObject" )]
	public class ExceptionTester : NSObject
	{
		public ExceptionTester( IntPtr value )
			: base( value )
		{
		}

		[Register( "NoThrow:arg2:arg3:arg4:arg5:" )]
		public void NoThrow( long arg1, long arg2, long arg3, long arg4, long arg5 )
		{
		}

		[Register( "Throw:arg2:arg3:arg4:arg5:" )]
		public void Throw( long arg1, long arg2, long arg3, long arg4, long arg5 )
		{
			throw new Exception();
		}
	}
}