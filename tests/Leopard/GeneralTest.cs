//
// Copyright (C) 2009 Eugeny Grishul
//
// See license in License.txt
//

using System.Diagnostics;
using NUnit.Framework;
using System.Linq;
using System;

namespace NObjective.Tests
{
	public partial class GeneralTest : NObjectiveTestBase
	{
		[Test]
		public unsafe void StructsMarshaling()
		{
			var random = new Random();

			var twoRegistersResult = new RuntimeClass( "NSString" ).InvokeObject( "stringWithString:", "First second third" ).InvokeStruct<NObjective.Proxies._NSRange>( "rangeOfString:", "second" );
			Assert.AreEqual( 6, twoRegistersResult.location );
			Assert.AreEqual( 6, twoRegistersResult.length );

			var originalMatrix = new NObjective.Proxies.CATransform3D();
			float* originalMatrixPtr = &originalMatrix.m11;

			for( int i = 0; i < 16; i++ )
				originalMatrixPtr[i] = ( float ) random.NextDouble();

			var newMatrix = new RuntimeClass( "NSValue" ).InvokeObject( "valueWithCATransform3D:", originalMatrix ).InvokeStruct<NObjective.Proxies.CATransform3D>( "CATransform3DValue" );
			float* newMatrixPtr = &newMatrix.m11;

			for( int i = 0; i < 16; i++ )
				Assert.AreEqual( originalMatrixPtr[i], newMatrixPtr[i] );
		}

		[Test]
		[ExpectedException( typeof( InteropException ) )]
		public void MethodNotFoundException()
		{
			// not responds to selector
			new RuntimeClass( "NSString" ).Invoke( "yoyoyo:", null );
		}
	}
}
