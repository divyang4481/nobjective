//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System.Linq;
using NUnit.Framework;

namespace NObjective.Tests
{
	[TestFixture]
	public unsafe class EncodingTest : NObjectiveTestBase
	{
		[Test]
		public void Test()
		{
			Assert.AreEqual( 3, new RuntimeMethodEncoding( "@8@0:4" ).Types.Length );

			Assert.AreEqual( true, new RuntimeMethodEncoding( "@8@0:4" ).Types.SequenceEqual( new[] { typeof( RuntimeObject ), typeof( RuntimeObject ), typeof( Selector ) } ) );
			Assert.AreEqual( true, new RuntimeMethodEncoding( "@8@0:4" ).Offsets.SequenceEqual( new[] { 8, 0, 4 } ) );

			Assert.AreEqual( true, new RuntimeMethodEncoding( "@12@0:4i8" ).Types.SequenceEqual( new[] { typeof( RuntimeObject ), typeof( RuntimeObject ), typeof( Selector ), typeof( int ) } ) );
			Assert.AreEqual( true, new RuntimeMethodEncoding( "@12@0:4i8" ).Offsets.SequenceEqual( new[] { 12, 0, 4, 8 } ) );

			Assert.AreEqual( true, new RuntimeMethodEncoding( "@12@0:4r^i8" ).Types.SequenceEqual( new[] { typeof( RuntimeObject ), typeof( RuntimeObject ), typeof( Selector ), typeof( int* ) } ) );
			Assert.AreEqual( true, new RuntimeMethodEncoding( "@12@0:4r^i8" ).Offsets.SequenceEqual( new[] { 12, 0, 4, 8 } ) );

			Assert.AreEqual( "@12@0:4^i8", new RuntimeMethodEncoding( new[] { typeof( RuntimeObject ), typeof( RuntimeObject ), typeof( Selector ), typeof( int* ) } ).Encoding );
			Assert.AreEqual( true, new RuntimeMethodEncoding( "@12@0:4^i8" ).Sizes.SequenceEqual( new[] { 4, 4, 4, 4 } ) );
		}
	}
}
