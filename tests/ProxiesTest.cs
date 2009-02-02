//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using NObjective.Proxies;
using NUnit.Framework;
using System;

namespace NObjective.Tests
{
	[TestFixture]
	public partial class ProxiesTest : NObjectiveTestBase
	{
		[Test]
		public void TestMarshaling()
		{
			Assert.AreEqual( true, NSNumber.numberWithBool_( true ).boolValue() );
			Assert.AreEqual( false, NSNumber.numberWithBool_( false ).boolValue() );

			Assert.AreEqual( 'A', new NSNumber( NSNumber.numberWithChar_( ( sbyte ) 'A' ) ).charValue() );

			Assert.AreEqual( 0x6f7f, new NSNumber( NSNumber.numberWithShort_( 0x6f7f ) ).shortValue() );
			Assert.AreEqual( 0x7f6f, new NSNumber( NSNumber.numberWithUnsignedShort_( 0x7f6f ) ).unsignedShortValue() );

			Assert.AreEqual( 0x6FFF7FFF, new NSNumber( NSNumber.numberWithInt_( 0x6FFF7FFF ) ).intValue() );
			Assert.AreEqual( 0x6FFF7FFF, new NSNumber( NSNumber.numberWithLong_( 0x6FFF7FFF ) ).longValue() );
			Assert.AreEqual( 0x7FFF6FFFu, new NSNumber( NSNumber.numberWithUnsignedInt_( 0x7FFF6FFFu ) ).unsignedIntValue() );

			Assert.AreEqual( float.MaxValue, new NSNumber( NSNumber.numberWithFloat_( float.MaxValue ) ).floatValue() );
			Assert.AreEqual( double.MaxValue, new NSNumber( NSNumber.numberWithDouble_( double.MaxValue ) ).doubleValue() );

			Assert.AreEqual( long.MaxValue, new NSNumber( NSNumber.numberWithLongLong_( long.MaxValue ) ).longLongValue() );
			Assert.AreEqual( 0x7FFFFFFF6FFFFFFFL, new NSNumber( NSNumber.numberWithLongLong_( 0x7FFFFFFF6FFFFFFFL ) ).longLongValue() );

			Assert.AreEqual( ulong.MaxValue, new NSNumber( NSNumber.numberWithUnsignedLongLong_( ulong.MaxValue ) ).unsignedLongLongValue() );
			Assert.AreEqual( 0x7FFFFFFF6FFFFFFFUL, new NSNumber( NSNumber.numberWithUnsignedLongLong_( 0x7FFFFFFF6FFFFFFFL ) ).unsignedLongLongValue() );

			Assert.AreEqual( int.MaxValue.ToString(), new NSString( NSNumber.numberWithInt_( int.MaxValue ) ).description() );

			Assert.AreEqual( "123", NSString.stringWithString_( "01234567890" ).substringWithRange_( new _NSRange { location = 1, length = 3 } ).ToString() );
		}

		[Test]
		[ExpectedException( typeof( RuntimeException ) )]
		public void Exceptions()
		{
			NSString.localizedStringWithFormat_( null );
		}
	}
}
