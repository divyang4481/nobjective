//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System;
using System.Linq;
using NUnit.Framework;
using NObjective.Proxies;
using System.Runtime.InteropServices;
using System.Text;

namespace NObjective.Tests
{
	[TestFixture]
	public class RegistrationTest : NObjectiveTestBase
	{
		[Test]
		public void ConstructorsTest()
		{
			Assert.AreEqual( false, Runtime.IsClassExportedByRuntime( new RuntimeClass( Guid.NewGuid().ToString() ) ) );
			Assert.AreEqual( true, Runtime.IsClassExportedByRuntime( Runtime.GetExportedClass<AutoRegisteredClass>() ) );

			var instance = Runtime.GetExportedClass<AutoRegisteredClass>().CreateInstance( "init" );

			Assert.AreEqual( true, instance.InvokeBool( "IsConstuctorCalled" ) );
			Assert.AreEqual( 777, Runtime.GetExportedClass<AutoRegisteredClass>().CreateInstance( "init:", 777 ).InvokeInt32( "GetConstructorParameter" ) );

			var proxy = Runtime.Attach<AutoRegisteredClass>( instance );
			Assert.AreEqual( instance, proxy.Handle );

			var proxy2 = Runtime.CreateInstance<AutoRegisteredClass>( "init:", 888 );
			Assert.AreEqual( 888, proxy2.ConstructorPassedParameter );

			var proxy3 = Runtime.CreateInstance<AutoRegisteredClass>( "init:value2:", 999, "xxx" );
			Assert.AreEqual( 999, proxy3.ConstructorPassedParameter );
			Assert.AreEqual( "xxx", proxy3.ConstructorPassedParameter2 );
		}

		[Test]
		public void MethodsTest()
		{
			var instance = Runtime.GetExportedClass<AutoRegisteredClass>().CreateInstance( "init" );

			Assert.AreEqual( ( IntPtr ) instance, instance.InvokeIntPtr( "AccessHandle" ) );

			Assert.AreEqual( 6, instance.InvokeInt8( "MarshalSBytes:second:third:", 1, 2, 3 ), "sbyte marshalling failure" );
			Assert.AreEqual( 7, instance.InvokeUInt8( "MarshalBytes:second:third:", 1, 2, 4 ), "byte marshalling failure" );

			Assert.AreEqual( 8, instance.InvokeInt16( "MarshalShorts:second:third:", 1, 2, 5 ), "short marshalling failure" );
			Assert.AreEqual( 9, instance.InvokeUInt16( "MarshalUShorts:second:third:", 1, 2, 6 ), "ushort marshalling failure" );

			Assert.AreEqual( 10, instance.InvokeInt32( "MarshalInts:second:third:", 1, 2, 7 ), "int marshalling failure" );
			Assert.AreEqual( 11, instance.InvokeUInt32( "MarshalUInts:second:third:", 1, 2, 8 ), "uint marshalling failure" );

			Assert.AreEqual( 12, instance.InvokeInt64( "MarshalLongs:second:third:", 1, 2, 9 ), "long marshalling failure" );
			Assert.AreEqual( 13, instance.InvokeUInt64( "MarshalULongs:second:third:", 1, 2, 10 ), "ulong marshalling failure" );

			Assert.AreEqual( 14, instance.InvokeFloat( "MarshalFloats:second:third:", 1f, 2f, 11f ), "float marshalling failure" );
			Assert.AreEqual( 15, instance.InvokeDouble( "MarshalDoubles:second:third:", 1d, 2d, 12d ), "double marshalling failure" );

			Assert.AreEqual( "yowazzup", instance.InvokeString( "MarshalStrings:second:", "yo", "wazzup" ) );

			Assert.AreEqual( 90, instance.InvokeDouble( "MarshalArrays:second:", Enumerable.Range( 0, 10 ).Select( x => ( double ) x ).ToArray(), Enumerable.Range( 0, 10 ).Select( x => ( int ) x ).ToArray() ) );

			Assert.AreEqual( "marshalled bytes", instance.InvokeString( "MarshalBytePtr:", "marshalled bytes" ), "string --> byte* marshalling failure" );

			Assert.AreEqual( ( IntPtr ) instance, ( IntPtr ) instance.InvokeObject( "ReturnObject:", ( IntPtr ) instance ) );
			Assert.AreEqual( ( IntPtr ) instance.Class, ( IntPtr ) instance.InvokeObject( "ReturnClass:", ( IntPtr ) instance.Class ) );
		}

		[Test]
		public void IntegrationTest()
		{
			var instance = Runtime.GetExportedClass<AutoRegisteredClass>().CreateInstance( "init" );

			Assert.AreEqual( 777, instance.InvokeUInt32( "hash" ) );
			Assert.AreEqual( "yoyoyo", instance.InvokeString( "description" ) );
		}

		[Test]
		public void RenamingTest()
		{
			var instance = Runtime.GetExportedClass<AutoRegisteredClass>().CreateInstance( "init" );

			Assert.AreEqual( 6, instance.InvokeUInt64( "renamedMarshalULongsMethod:yo:yo:", 1, 2, 3 ) );
			Assert.AreEqual( 6, instance.InvokeUInt64( "MarshalULongs3:something:third:", 1, 2, 3 ) );
		}

		[Test]
		public void IvarsTest()
		{
			var proxy = Runtime.CreateInstance<AutoRegisteredClass>( "init" );

			// check offset of first ivar
			Assert.AreEqual( IntPtr.Size * 2, new RuntimeVariable( proxy.Handle, "_byte" ).Offset );
			Assert.AreEqual( IntPtr.Size * 2, new RuntimeVariable( proxy.Handle.Class, "_byte" ).Offset );

			var test = new
			{
				_byte = 1,
				_sbyte = 2,
				_char = 'c',
				_short = 3,
				_ushort = 4,
				_decimal = 5,
				_guid = Guid.NewGuid(),
				_intPtr = new IntPtr( 6 ),
				_int = 7,
				_uint = 8,
				_long = 9,
				_ulong = 10,
				_float = 11,
				_double = 12
			};

			foreach( var item in test.GetType().GetFields() )
				proxy.GetType().GetProperty( item.Name ).SetValue( proxy, item.GetValue( test ), null );

			foreach( var item in test.GetType().GetFields() )
				Assert.AreEqual( item.GetValue( test ), proxy.GetType().GetProperty( item.Name ).GetValue( proxy, null ) );
		}

		[Test]
		public void ManualRegistrationTest()
		{
			Assert.AreEqual( false, RuntimeClass.GetAllClasses().Any( x => x.Name == Runtime.GetExportedClassName<ManualRegisteredClass>() ) );

			Assert.AreEqual( false, Runtime.IsClassExportedByRuntime( Runtime.GetExportedClass<ManualRegisteredClass>() ) );
			Runtime.ExportClass( typeof( ManualRegisteredClass ) );
			Assert.AreEqual( true, Runtime.IsClassExportedByRuntime( Runtime.GetExportedClass<ManualRegisteredClass>() ) );

			var proxy = Runtime.CreateInstance<ManualRegisteredClass>( "init" );
		}

		[Test]
		public void ForwardingTest()
		{
			var proxy = Runtime.CreateInstance<ForwardingTester>( "init" );

			Assert.AreEqual( false, proxy.IsMessageForwarded );

			proxy.Handle.Invoke( "someMissedMethod" );

			Assert.AreEqual( true, proxy.IsMessageForwarded );
		}

		[Test]
		public void AbortRegistrationTest()
		{
			try
			{
				Runtime.ExportClass( typeof( Test1.AbortRegistrationTest ) );
				Assert.Fail();
			}
			catch( RegistrationException ) { }

			Runtime.ExportClass( typeof( Test2.AbortRegistrationTest ) );
		}

		[Test]
		[ExpectedException( typeof( ObjectReleasedException ) )]
		public void DeallocationThrowOnGet()
		{
			AutoRegisteredClass proxy = null;
			using( var scope = new AutoreleaseScope() )
				proxy = Runtime.CreateInstance<AutoRegisteredClass>( "init" );

			Assert.AreEqual( RuntimeObject.Null, proxy.Handle );

			proxy._int = proxy._int;
		}

		[Test]
		[ExpectedException( typeof( ObjectReleasedException ) )]
		public void DeallocationThrowOnSet()
		{
			AutoRegisteredClass proxy = null;
			using( var scope = new AutoreleaseScope() )
				proxy = Runtime.CreateInstance<AutoRegisteredClass>( "init" );

			Assert.AreEqual( RuntimeObject.Null, proxy.Handle );

			proxy._int = 10;
		}

		[Test]
		[ExpectedException( typeof( ObjectDisposedException ) )]
		public void ExceptionMethodTest()
		{
			var instance = Runtime.GetExportedClass<ExceptionThrowerClass1>().CreateInstance( "init" );

			instance.Invoke( "ThrowException" );
		}

		[Test]
		[ExpectedException( typeof( ObjectDisposedException ) )]
		public void ExceptionCtorTest()
		{
			var instance = Runtime.GetExportedClass<ExceptionThrowerClass2>().CreateInstance( "init" );
		}

		[Test]
		public void InheritanceTest()
		{
			HierarchyBase @base;
			HierarchyDerived derived;

			using( new AutoreleaseScope() )
			{
				@base = Runtime.CreateInstance<HierarchyBase>( "init" );
				derived = Runtime.CreateInstance<HierarchyDerived>( "init" );

				HierarchyBase derivedCastedToBase = derived;

				var test = new
				{
					_int = 7,
					_uint = 8,
					_long = 9,
					_ulong = 10,
					_float = 11,
					_double = 12
				};

				foreach( var item in test.GetType().GetFields() )
					derived.GetType().GetProperty( item.Name ).SetValue( derived, item.GetValue( test ), null );

				foreach( var item in test.GetType().GetFields() )
					Assert.AreEqual( item.GetValue( test ), derived.GetType().GetProperty( item.Name ).GetValue( derived, null ) );

				Assert.AreEqual( @base.ToString(), derived.ToString() );
				Assert.AreEqual( @base.FloatingPointReturn(), derived.FloatingPointReturn() );
				Assert.AreEqual( @base.IntReturn(), derived.IntReturn() );
				Assert.AreEqual( @base.ShortReturn(), derived.ShortReturn() );

				// override by name
				Assert.AreEqual( @base.Supercall(), derived.Handle.SuperInvokeInt32( "Supercall" ) );
				Assert.AreEqual( @base.Supercall(), Runtime.SendMessageToBase( derived.Handle, derived.Handle.Class.BaseClass, "Supercall" ).ToInt32() );

				// C#-like override
				Assert.IsTrue( derivedCastedToBase.VirtualMethod() == derived.Handle.InvokeUInt32( "VirtualMethod" ) );
			}

			Assert.AreEqual( true, @base.IsDeallocCalledForBase );
			Assert.AreEqual( true, derived.IsDeallocCalledForBase, "dealloc implementation of base class not called" );
			Assert.AreEqual( true, derived.IsDeallocCalledForChild, "dealloc implementation of derived class not called" );

			Assert.AreEqual( RuntimeObject.Null, @base.Handle, "Handle not set to Null in base class" );
			Assert.AreEqual( RuntimeObject.Null, derived.Handle, "Handle not set to Null in derived class" );
		}

		/// <summary>
		/// Exceptions from dealloc should be suppressed.
		/// </summary>
		[Test]
		public void ExceptionEatDisposeExceptionTest()
		{
			ExceptionThrowerClass3 managedPart;
			using( var instance = Runtime.GetExportedClass<ExceptionThrowerClass3>().CreateProxyInstance() )
			{
				instance.InvokeObject( "init" );
				managedPart = Runtime.Attach<ExceptionThrowerClass3>( instance.Handle );
			}

			Assert.AreEqual( true, managedPart.IsDeallocCalled );
		}
	}

	public abstract class AutoRegisteredClass : RuntimeExportBase
	{
		public abstract byte _byte { get; set; }
		public abstract sbyte _sbyte { get; set; }
		public abstract char _char { get; set; }
		public abstract short _short { get; set; }
		public abstract ushort _ushort { get; set; }

		public abstract decimal _decimal { get; set; }
		public abstract Guid _guid { get; set; }
		public abstract IntPtr _intPtr { get; set; }

		public abstract int _int { get; set; }
		public abstract uint _uint { get; set; }
		public abstract long _long { get; set; }
		public abstract ulong _ulong { get; set; }
		public abstract float _float { get; set; }
		public abstract double _double { get; set; }

		public abstract RuntimeObject _object { get; set; }
		//public abstract NObjective.Generated.NSString _string { get; set; }

		public bool ConstuctorCalled = false;
		public int ConstructorPassedParameter = -1;
		public string ConstructorPassedParameter2;

		public AutoRegisteredClass()
		{
			ConstuctorCalled = true;
		}

		public AutoRegisteredClass( int value )
		{
			ConstructorPassedParameter = value;
		}

		public AutoRegisteredClass( int value, string value2 )
		{
			ConstructorPassedParameter = value;
			ConstructorPassedParameter2 = value2;
		}

		public IntPtr AccessHandle()
		{
			return Handle;
		}

		public bool IsConstuctorCalled()
		{
			return ConstuctorCalled;
		}

		public int GetConstructorParameter()
		{
			return ConstructorPassedParameter;
		}

		public string GetConstructorParameter2()
		{
			return ConstructorPassedParameter2;
		}

		public override int GetHashCode()
		{
			return 777;
		}

		public override string ToString()
		{
			return "yoyoyo";
		}

		public byte MarshalBytes( byte first, byte second, byte third )
		{
			return ( byte ) ( first + second + third );
		}

		public sbyte MarshalSBytes( sbyte first, sbyte second, sbyte third )
		{
			return ( sbyte ) ( first + second + third );
		}

		public short MarshalShorts( short first, short second, short third )
		{
			return ( short ) ( first + second + third );
		}

		public ushort MarshalUShorts( ushort first, ushort second, ushort third )
		{
			return ( ushort ) ( first + second + third );
		}

		public int MarshalInts( int first, int second, int third )
		{
			return ( int ) ( first + second + third );
		}

		public uint MarshalUInts( uint first, uint second, uint third )
		{
			return ( uint ) ( first + second + third );
		}

		public long MarshalLongs( long first, long second, long third )
		{
			return ( long ) ( first + second + third );
		}

		public ulong MarshalULongs( ulong first, ulong second, ulong third )
		{
			return ( ulong ) ( first + second + third );
		}

		public float MarshalFloats( float first, float second, float third )
		{
			return first + second + third;
		}

		public double MarshalDoubles( double first, double second, double third )
		{
			return first + second + third;
		}

		public decimal MarshalDecimals( decimal first, decimal second, decimal third )
		{
			return first + second + third;
		}

		[Selector( "renamedMarshalULongsMethod:yo:yo:" )]
		public ulong MarshalULongs2( ulong first, ulong second, ulong third )
		{
			return ( ulong ) ( first + second + third );
		}

		public ulong MarshalULongs3( ulong first, [ParameterName( "something" )] ulong second, ulong third )
		{
			return ( ulong ) ( first + second + third );
		}

		public string MarshalStrings( string first, NSString second )
		{
			return first + second.ToString();
		}

		public unsafe double MarshalArrays( double* first, int* second )
		{
			double result = 0;

			for( int i = 0; i < 10; i++ )
				result += first[i] + second[i];

			return result;
		}

		public unsafe string MarshalBytePtr( byte* ptr )
		{
			return Marshal.PtrToStringAnsi( new IntPtr( ptr ) );
		}

		public RuntimeObject ReturnObject( RuntimeObject @object )
		{
			return @object;
		}

		public RuntimeClass ReturnClass( RuntimeClass @class )
		{
			return @class;
		}
	}

	public abstract class ExceptionThrowerClass1 : RuntimeExportBase
	{
		public void ThrowException()
		{
			throw new ObjectDisposedException( "ExceptionThrowerClass1 ThrowException" );
		}
	}

	public abstract class ExceptionThrowerClass2 : RuntimeExportBase
	{
		public ExceptionThrowerClass2()
		{
			throw new ObjectDisposedException( "ExceptionThrowerClass2 .ctor" );
		}
	}

	public abstract class ExceptionThrowerClass3 : RuntimeExportBase
	{
		public bool IsDeallocCalled = false;

		public void dealloc()
		{
			IsDeallocCalled = true;
			throw new Exception( "ExceptionThrowerClass3 Dispose" );
		}
	}

	[ManualRegister]
	public abstract class ManualRegisteredClass : RuntimeExportBase
	{
	}

	namespace Test1
	{
		[ManualRegister]
		public abstract class AbortRegistrationTest : RuntimeExportBase
		{
			public ulong IncorrectParameterNameLocation( [ParameterName( "something" )]ulong first, ulong second, ulong third )
			{
				return ( ulong ) ( first + second + third );
			}
		}
	}

	namespace Test2
	{
		[ManualRegister]
		public abstract class AbortRegistrationTest : RuntimeExportBase
		{
		}
	}

	public abstract class HierarchyBase : RuntimeExportBase
	{
		public abstract int _int { get; set; }
		public abstract uint _uint { get; set; }
		public abstract long _long { get; set; }

		public override string ToString()
		{
			return "some text from HierarchyBase class";
		}

		public virtual float FloatingPointReturn()
		{
			return ( float ) Math.PI;
		}

		public virtual int IntReturn()
		{
			return 777;
		}

		public virtual short ShortReturn()
		{
			return 777;
		}

		public int Supercall()
		{
			return 7;
		}

		public virtual uint VirtualMethod()
		{
			return 0xDEADBEEF;
		}

		public void dealloc()
		{
			IsDeallocCalledForBase = true;
		}

		public bool IsDeallocCalledForBase = false;
	}

	public abstract class HierarchyDerived : HierarchyBase
	{
		public abstract ulong _ulong { get; set; }
		public abstract float _float { get; set; }
		public abstract double _double { get; set; }

		public override string ToString()
		{
			return Handle.SuperInvokeString( "description" );
		}

		public new float FloatingPointReturn()
		{
			return Handle.SuperInvokeFloat( "FloatingPointReturn" );
		}

		public override int IntReturn()
		{
			return Handle.SuperInvokeInt32( "IntReturn" );
		}

		public new virtual short ShortReturn()
		{
			return Handle.SuperInvokeInt16( "ShortReturn" );
		}

		public new int Supercall()
		{
			return 8;
		}

		public override uint VirtualMethod()
		{
			return 0xBEEFDEAD;
		}

		public new void dealloc()
		{
			IsDeallocCalledForChild = true;
		}

		public bool IsDeallocCalledForChild = false;
	}

	[AdoptedProtocol( "NSObject" )]
	public abstract class ForwardingTester : RuntimeExportBase
	{
		public bool IsMessageForwarded = false;

		public void forwardInvocation( IntPtr invocation )
		{
			IsMessageForwarded = true;
		}

		public IntPtr methodSignatureForSelector( Selector selector )
		{
			return new RuntimeClass( "NSMethodSignature" ).InvokeObject( "signatureWithObjCTypes:", "v@:" );
		}
	}
}
