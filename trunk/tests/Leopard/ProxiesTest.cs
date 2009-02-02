//
// Copyright (C) 2009 Eugeny Grishul
//
// See license in License.txt
//

using NObjective.Proxies;
using NUnit.Framework;
using System;

namespace NObjective.Tests
{
	public partial class ProxiesTest : NObjectiveTestBase
	{
		[Test]
		public unsafe void TestStructMarshaling()
		{
			var random = new Random();

			var twoRegistersResult = NSString.stringWithString_( "First second third" ).rangeOfString_( "second" );
			Assert.AreEqual( 6, twoRegistersResult.location );
			Assert.AreEqual( 6, twoRegistersResult.length );

			var originalMatrix = new CATransform3D();
			float* originalMatrixPtr = &originalMatrix.m11;

			for( int i = 0; i < 16; i++ )
				originalMatrixPtr[i] = ( float ) random.NextDouble();

			var newMatrix = QuartzCoreExtensionsOfNSValue.valueWithCATransform3D_( originalMatrix ).CATransform3DValue();
			float* newMatrixPtr = &newMatrix.m11;

			Console.WriteLine();
			for( int i = 0; i < 16; i++ )
			{
				//Assert.AreEqual( originalMatrixPtr[i], newMatrixPtr[i] );
				Assert.AreEqual( ( &originalMatrix.m11 )[i], ( &newMatrix.m11 )[i] );
			}
		}
	}
}
