//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using NObjective.Proxies;
using System.Diagnostics;
using System;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Collections.Generic;

namespace NObjective
{
	public class NObjectiveTest : PerformanceTestBase
	{
		private static AutoreleaseScope _scope;

		private static void Main( string[] args )
		{
			test_regression();
		}

		/// <summary>
		/// Used for regression tests.
		/// </summary>
		public static void test_regression()
		{
			var test = new NObjectiveTest();

			test.OnBeginTest += () => { _scope = AutoreleaseScope.New(); };
			test.OnEndTest += () => { _scope.Dispose(); };

			test.TestAll( typeof( AutoreleaseScope ).Assembly );
		}

		public override void TestInvocation( int iterations )
		{
			var instance = NSNumber.numberWithInt_( 10 );

			for( int i = 0; i < iterations; i++ )
				instance.hash();
		}

		public override void TestVarargMarshaling( int iterations )
		{
			var instance = NSString.stringWithString_( "some string to test" );

			for( int i = 0; i < iterations; i++ )
				instance.stringByAppendingFormat_( " %@ %@ %f %d %d", "some", "text", System.Math.PI, true, 10 );
		}

		public override void TestAllocation( int iterations )
		{
			for( int i = 0; i < iterations; i++ )
				NSNumber.numberWithInt_( 10 );
		}

		public override void TestExceptionHandlerOverhead( int iterations )
		{
			var @class = Runtime.GetExportedClass<ExceptionTester>();
			var selector = new Selector( typeof( ExceptionTester ).GetMethod( "NoThrow" ) );
			var encoding = new RuntimeMethodEncoding( typeof( ExceptionTester ).GetMethod( "NoThrow" ) );

			for( int i = 0; i < iterations; i++ )
			{
				try
				{
					@class.InvokeVoidFast( selector, encoding, 10L, 20L, 30L, 40L, 50L );
				}
				catch { Console.WriteLine( "Should not catch exception!" ); }
			}
		}

		public override void TestExceptionRethrow( int iterations )
		{
			var @class = Runtime.GetExportedClass<ExceptionTester>();
			var selector = new Selector( typeof( ExceptionTester ).GetMethod( "Throw" ) );
			var encoding = new RuntimeMethodEncoding( typeof( ExceptionTester ).GetMethod( "Throw" ) );

			var exceptionCatched = true;

			for( int i = 0; i < iterations; i++ )
			{
				try
				{
					@class.InvokeVoidFast( selector, encoding, 10L, 20L, 30L, 40L, 50L );
					exceptionCatched = false;
				}
				catch { }
			}

			if( !exceptionCatched )
				Console.WriteLine( "Should catch exception!" );
		}

		public abstract class ExceptionTester : RuntimeExportBase
		{
			public static void NoThrow( long arg1, long arg2, long arg3, long arg4, long arg5 )
			{
			}

			public static void Throw( long arg1, long arg2, long arg3, long arg4, long arg5 )
			{
				throw new Exception();
			}
		}
	}
}