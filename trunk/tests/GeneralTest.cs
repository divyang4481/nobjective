//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System.Diagnostics;
using NUnit.Framework;
using System.Linq;
using System;

namespace NObjective.Tests
{
	[TestFixture]
	public partial class GeneralTest : NObjectiveTestBase
	{
		[Test]
		public void Strings()
		{
			Assert.AreEqual( "10 yo wazzup", new RuntimeClass( "NSString" ).Invoke( "stringWithFormat:", "%d %@ %@", 10, "yo", "wazzup" ) );
		}

		[Test]
		public void PrimitiveMarshaling()
		{
			Assert.AreEqual( true, new RuntimeClass( "NSNumber" ).InvokeObject( "numberWithBool:", true ).InvokeBool( "boolValue" ) );
			Assert.AreEqual( false, new RuntimeClass( "NSNumber" ).InvokeObject( "numberWithBool:", false ).InvokeBool( "boolValue" ) );
			Assert.AreEqual( 'A', new RuntimeClass( "NSNumber" ).InvokeObject( "numberWithChar:", 'A' ).InvokeChar( "charValue" ) );
			Assert.AreEqual( 10.5, new RuntimeClass( "NSNumber" ).InvokeObject( "numberWithDouble:", 10.5 ).InvokeDouble( "doubleValue" ) );
			Assert.AreEqual( 1.0f, new RuntimeClass( "NSNumber" ).InvokeObject( "numberWithFloat:", 1.0f ).InvokeFloat( "floatValue" ) );

			Assert.AreEqual( short.MaxValue, new RuntimeClass( "NSNumber" ).InvokeObject( "numberWithShort:", short.MaxValue ).InvokeInt16( "shortValue" ) );
			Assert.AreEqual( int.MaxValue, new RuntimeClass( "NSNumber" ).InvokeObject( "numberWithInt:", int.MaxValue ).InvokeInt32( "intValue" ) );
			Assert.AreEqual( long.MaxValue, new RuntimeClass( "NSNumber" ).InvokeObject( "numberWithLongLong:", long.MaxValue ).InvokeInt64( "longLongValue" ) );

			Assert.AreEqual( ushort.MaxValue, new RuntimeClass( "NSNumber" ).InvokeObject( "numberWithUnsignedShort:", ushort.MaxValue ).InvokeUInt16( "unsignedShortValue" ) );
			Assert.AreEqual( uint.MaxValue, new RuntimeClass( "NSNumber" ).InvokeObject( "numberWithUnsignedInt:", uint.MaxValue ).InvokeUInt32( "unsignedIntValue" ) );
			Assert.AreEqual( ulong.MaxValue, new RuntimeClass( "NSNumber" ).InvokeObject( "numberWithUnsignedLongLong:", ulong.MaxValue ).InvokeUInt64( "unsignedLongLongValue" ) );
		}

		[Test]
		[ExpectedException( typeof( RuntimeException ) )]
		public void InvalidArgumentException()
		{
			//invalid argument
			new RuntimeClass( "NSString" ).Invoke( "localizedStringWithFormat:", null );
		}

		[Test]
		public void MakeStackFilled()
		{
			new RuntimeClass( "NSString" ).Invoke( "stringWithFormat:", "yo", Enumerable.Range( 0, 30 ).Select( x => ( object ) 0 ).ToArray() );
		}

		[Test]
		[ExpectedException( typeof( InteropException ) )]
		public void StackOverflowException()
		{
			new RuntimeClass( "NSString" ).Invoke( "stringWithFormat:", "yo", Enumerable.Range( 0, 31 ).Select( x => ( object ) 0 ).ToArray() );
		}
	}
}
