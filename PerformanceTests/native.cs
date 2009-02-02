//
// Copyright (C) 2009 Eugeny Grishul
//
// See license in License.txt
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using NObjective;

namespace Native
{
	[SuppressUnmanagedCodeSecurityAttribute]
	public static class Program
	{
		private static readonly Stopwatch _timer = new Stopwatch();

		private static void Main( string[] args )
		{
			Test( "Invocation", TestInvocationUnprotected );
			Test( "Invocation + @try/@catch", TestInvocationProtected );

			Test( "Imp invocation", TestImpInvocation );
			
			Test( "DllImport overhead", TestDllImportOverheadUnprotected );
			Test( "DllImport + @try/@catch", TestDllImportOverheadProtected );
			
			Test( "Allocation", TestAllocation );
			Test( "Vararg marshaling", TestVarargMarshaling );
			Test( "@try/@catch overhead", TestExceptionOverhead );
			Test( "Exception rethrow", TestExceptionRethrow );

			GC.Collect();
			Console.WriteLine( "TotalMemory: {0} KiB", GC.GetTotalMemory( true ) / 1024d );
			Console.WriteLine();
		}

		private static void Test( string name, Action<int> test )
		{
			using( var scope = new AutoreleaseScope() )
				test( 20000 );

			using( var scope = new AutoreleaseScope() )
			{

				_timer.Start();
				test( 20000 );
				_timer.Stop();

				System.Console.WriteLine( "{0}: {1}ms", name, _timer.Elapsed.TotalMilliseconds );
				_timer.Reset();
			}
		}

		private static void TestDllImportOverheadUnprotected( int iterations )
		{
			for( int i = 0; i < iterations; i++ )
				DllImportOverheadUnprotected( IntPtr.Zero, IntPtr.Zero );
		}

		private static void TestDllImportOverheadProtected( int iterations )
		{
			for( int i = 0; i < iterations; i++ )
				DllImportOverheadProtected( IntPtr.Zero, IntPtr.Zero );
		}

		[DllImport( "native.dylib" )]
		private extern static void TestInvocationUnprotected( int iterations );

		[DllImport( "native.dylib" )]
		private extern static void TestInvocationProtected( int iterations );

		[DllImport( "native.dylib" )]
		private extern static void TestImpInvocation( int iterations );

		[DllImport( "native.dylib" )]
		private extern static void TestVarargMarshaling( int iterations );

		[DllImport( "native.dylib" )]
		private extern static void TestAllocation( int iterations );

		[DllImport( "native.dylib" )]
		private extern static void TestExceptionOverhead( int iterations );

		[DllImport( "native.dylib" )]
		private extern static void TestExceptionRethrow( int iterations );

		[DllImport( "native.dylib" )]
		private extern static void DllImportOverheadUnprotected( IntPtr @object, IntPtr selector );

		[DllImport( "native.dylib" )]
		private extern static void DllImportOverheadProtected( IntPtr @object, IntPtr selector );
	}
}
