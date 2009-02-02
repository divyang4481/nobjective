// Copyright (C) 2008 Jesse Jones
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using NUnit.Framework;
using MObjc;
using System;
using System.Runtime.InteropServices;

[TestFixture]
public class ReturnTests 	
{
	[TestFixtureSetUp]
	public void Init()
	{
		AssertListener.Install();

		Registrar.CanInit = true;
		m_pool = new NSObject(NSObject.AllocNative("NSAutoreleasePool"));
	}
	
	[TestFixtureTearDown]
	public void DeInit()
	{
		if (m_pool != null)
		{
			m_pool.release();
			m_pool = null;
		}
	}
	
	[SetUp]
	public void Setup()
	{
		GC.Collect(); 			
		GC.WaitForPendingFinalizers();
	}
	
	[Test]
	public void BoolWithTo() 
	{
		Class klass = new Class("NSNumber");
		
		NSObject num = klass.Call("alloc").To<NSObject>();
		num = num.Call("initWithBool:", (sbyte) 1).To<NSObject>();
		
		sbyte result = num.Call("boolValue").To<sbyte>();
		Assert.AreEqual(1, result);
	}

	[Test]
	public void BoolWithTo2() 
	{
		Class klass = new Class("NSNumber");
		
		NSObject num = klass.Call("alloc").To<NSObject>();
		num = num.Call("initWithBool:", (sbyte) 1).To<NSObject>();
		
		bool b = num.Call("boolValue").To<bool>();	// To special cases sbyte to bool
		Assert.AreEqual(true, b);
	}

	[Test]
	public void UInt16WithTo() 
	{
		Class klass = new Class("NSNumber");
		
		NSObject num = klass.Call("alloc").To<NSObject>();
		num = num.Call("initWithInt:", 5000).To<NSObject>();
		
		UInt16 result = num.Call("unsignedShortValue").To<UInt16>();
		Assert.AreEqual(5000, result);
	}

	[Test]
	public void UInt16WithCast() 
	{
		Class klass = new Class("NSNumber");
		
		NSObject num = klass.Call("alloc").To<NSObject>();
		num = num.Call("initWithInt:", 5000).To<NSObject>();
		
		UInt16 result = (UInt16) num.Call("unsignedShortValue");
		Assert.AreEqual(5000, result);
	}

	[Test]
	public void SCharWithTo() 
	{
		Class klass = new Class("NSNumber");
		
		NSObject num = klass.Call("alloc").To<NSObject>();
		num = num.Call("initWithInt:", 122).To<NSObject>();
		
		sbyte result = num.Call("charValue").To<sbyte>();
		Assert.AreEqual(122, result);
	}

	[Test]
	public void CharWithTo() 
	{
		Class klass = new Class("NSNumber");
		
		NSObject num = klass.Call("alloc").To<NSObject>();
		num = num.Call("initWithInt:", 122).To<NSObject>();
		
		byte result = num.Call("unsignedCharValue").To<byte>();
		Assert.AreEqual(122, result);
	}

	[Test]
	public void ShortWithTo() 
	{
		Class klass = new Class("NSNumber");
		
		NSObject num = klass.Call("alloc").To<NSObject>();
		num = num.Call("initWithInt:", 122).To<NSObject>();
		
		short result = num.Call("shortValue").To<short>();
		Assert.AreEqual(122, result);
	}

	[Test]
	public void IntWithTo() 
	{
		Class klass = new Class("NSNumber");
		
		NSObject num = klass.Call("alloc").To<NSObject>();
		num = num.Call("initWithInt:", 122).To<NSObject>();
		
		int result = num.Call("intValue").To<int>();
		Assert.AreEqual(122, result);
	}

	[Test]
	public void UIntWithTo() 
	{
		Class klass = new Class("NSNumber");
		
		NSObject num = klass.Call("alloc").To<NSObject>();
		num = num.Call("initWithInt:", 122).To<NSObject>();
		
		uint result = num.Call("unsignedIntValue").To<uint>();
		Assert.AreEqual(122, result);
	}

	[Test]
	public void LongWithTo() 
	{
		Class klass = new Class("NSNumber");
		
		NSObject num = klass.Call("alloc").To<NSObject>();
		num = num.Call("initWithInt:", 122).To<NSObject>();
		
		int result = num.Call("longValue").To<int>();
		Assert.AreEqual(122, result);
	}

	[Test]
	public void ULongWithTo() 
	{
		Class klass = new Class("NSNumber");
		
		NSObject num = klass.Call("alloc").To<NSObject>();
		num = num.Call("initWithInt:", 122).To<NSObject>();
		
		uint result = num.Call("unsignedLongValue").To<uint>();
		Assert.AreEqual(122, result);
	}


	[Test]
	public void LongLongWithTo() 
	{
		Class klass = new Class("NSNumber");
		
		NSObject num = klass.Call("alloc").To<NSObject>();
		num = num.Call("initWithInt:", 122).To<NSObject>();
		
		long result = num.Call("longLongValue").To<long>();
		Assert.AreEqual(122, result);
	}

	[Test]
	public void ULongLongWithTo() 
	{
		Class klass = new Class("NSNumber");
		
		NSObject num = klass.Call("alloc").To<NSObject>();
		num = num.Call("initWithInt:", 122).To<NSObject>();
		
		ulong result = num.Call("unsignedLongLongValue").To<ulong>();
		Assert.AreEqual(122, result);
	}
	
	[Test]
	public void FloatWithTo() 
	{
		Class klass = new Class("NSNumber");
		
		NSObject num = klass.Call("alloc").To<NSObject>();
		num = num.Call("initWithInt:", 122).To<NSObject>();
		
		float result = num.Call("floatValue").To<float>();
		Assert.IsTrue(Math.Abs(122.0 - result) < 0.001);
	}

	[Test]
	public void DoubleWithTo() 
	{
		Class klass = new Class("NSNumber");
		
		NSObject num = klass.Call("alloc").To<NSObject>();
		num = num.Call("initWithInt:", 122).To<NSObject>();
		
		double result = num.Call("doubleValue").To<double>();
		Assert.IsTrue(Math.Abs(122.0 - result) < 0.001);
	}

	[Test]
	public void CStringWithTo() 
	{
		Class klass = new Class("NSString");
		
		NSObject str = klass.Call("stringWithUTF8String:", Marshal.StringToHGlobalAuto("hey")).To<NSObject>();
		string result = Marshal.PtrToStringAuto((IntPtr) str.Call("UTF8String"));
		Assert.AreEqual("hey", result);
		
		const char omega = '\x3AA';
		const char ellipsis = '\x2027';
		string u32 = new string(new char[]{omega, ellipsis});

		str = klass.Call("alloc").Call("initWithCharacters:length:", Marshal.StringToHGlobalUni(u32), 2U).To<NSObject>();
		string s = Marshal.PtrToStringAuto((IntPtr) str.Call("UTF8String"));
		Assert.AreEqual((int) omega, (int) s[0]);
		Assert.AreEqual((int) ellipsis, (int) s[1]);

		str = klass.Call("stringWithUTF8String:", Marshal.StringToHGlobalAuto(u32)).To<NSObject>();
		s = Marshal.PtrToStringAuto((IntPtr) str.Call("UTF8String"));
		Assert.AreEqual((int) omega, (int) s[0]);
		Assert.AreEqual((int) ellipsis, (int) s[1]);
	}
	
	[Test]
	public void CStringWithCast() 
	{
		Class klass = new Class("NSString");
		
		NSObject str = klass.Call("stringWithUTF8String:", Marshal.StringToHGlobalAuto("hey")).To<NSObject>();
		string result = Marshal.PtrToStringAuto((IntPtr) str.Call("UTF8String"));
		Assert.AreEqual("hey", result);
		
		const char omega = '\x3AA';
		const char ellipsis = '\x2027';
		string u32 = new string(new char[]{omega, ellipsis});

		str = klass.Call("alloc").Call("initWithCharacters:length:", Marshal.StringToHGlobalUni(u32), 2U).To<NSObject>();
		string s = Marshal.PtrToStringAuto((IntPtr) str.Call("UTF8String"));
		Assert.AreEqual((int) omega, (int) s[0]);
		Assert.AreEqual((int) ellipsis, (int) s[1]);

		str = klass.Call("stringWithUTF8String:", Marshal.StringToHGlobalAuto(u32)).To<NSObject>();
		s = Marshal.PtrToStringAuto((IntPtr) str.Call("UTF8String"));
		Assert.AreEqual((int) omega, (int) s[0]);
		Assert.AreEqual((int) ellipsis, (int) s[1]);
	}
	
	[Test]
	public void Void1() 
	{
		NSObject str1 = new Class("NSMutableString").Call("stringWithCapacity:", 12U).To<NSObject>();
		NSObject str2 = new Class("NSString").Call("stringWithUTF8String:", Marshal.StringToHGlobalAuto("hey")).To<NSObject>();
		
		object result = str1.Call("appendString:", str2);
		Assert.AreEqual(null, result);
		
		string s = Marshal.PtrToStringAuto((IntPtr) str1.Call("UTF8String"));
		Assert.AreEqual("hey", s);
	}
	
	[Test]
	public void Void2() 
	{
		NSObject str1 = new Class("NSMutableString").Call("stringWithCapacity:", 12U).To<NSObject>();
		NSObject str2 = new Class("NSString").Call("stringWithUTF8String:", Marshal.StringToHGlobalAuto("hey")).To<NSObject>();
		
		NSObject result = str1.Call("appendString:", str2).To<NSObject>();
		Assert.IsTrue(result.IsNil());
	}
	
	[Test]
	public void Void3() 
	{
		IntPtr ip = IntPtr.Zero;		
		NSObject result = ip.To<NSObject>();
		Assert.IsTrue(result.IsNil());
	}
	
	[Test]
	public void ClassWithTo() 
	{
		NSObject table = new Class("NSHashTable").Call("alloc").Call("init").To<NSObject>();
		Class result = table.Call("class").To<Class>();

		Assert.AreEqual("NSConcreteHashTable", result.Name);
	}
	
	[Test]
	public void ClassWithCast() 
	{
		NSObject table = (NSObject) new Class("NSHashTable").Call("alloc").Call("init");
		Class result = (Class) table.Call("class");

		Assert.AreEqual("NSConcreteHashTable", result.Name);
	}
	
	[Test]
	public void NSObjectWithCast() 
	{
		Class klass = new Class("NSNumber");
		
		NSObject num = klass.Call("alloc").To<NSObject>();
		num = (NSObject) num.Call("initWithInt:", 5000);
		
		UInt16 result = (UInt16) num.Call("unsignedShortValue");
		Assert.AreEqual(5000, result);
	}
	
	[Test]
	public void DerivedWithTo() 
	{
		NSObject o = new Class("Subclass1").Call("alloc").Call("initValue").To<NSObject>();
	
		NSObject p = o.Call("Clone").To<NSObject>();
		Assert.IsTrue((IntPtr) o != (IntPtr) p);
		Assert.AreEqual(100, (int) p.Call("getValue"));
		
		Subclass1 q = o.Call("Clone").To<Subclass1>();
		Assert.IsTrue((IntPtr) o != (IntPtr) q);
		Assert.AreEqual(100, q.GetValue());
	}

	[Test]
	public void DerivedWithCast() 
	{
		NSObject o = (NSObject) new Class("Subclass1").Call("alloc").Call("initValue");
	
		NSObject p = (NSObject) o.Call("Clone");
		Assert.IsTrue((IntPtr) o != (IntPtr) p);
		Assert.AreEqual(100, (int) p.Call("getValue"));
		
		Subclass1 q = (Subclass1) o.Call("Clone");
		Assert.IsTrue((IntPtr) o != (IntPtr) q);
		Assert.AreEqual(100, q.GetValue());
	}

	[Test]
	public void SelectorWithTo() 
	{
		NSObject table = (NSObject) new Class("NSHashTable").Call("alloc").Call("init");
		Selector selector = new Selector("addObject:");
		NSObject sig = (NSObject) table.Call("methodSignatureForSelector:", selector);
		
		Class klass = new Class("NSInvocation");
		NSObject invoke = (NSObject) klass.Call("invocationWithMethodSignature:", sig);
		
		invoke.Call("setSelector:", selector);
		Selector result = invoke.Call("selector").To<Selector>();
		
		Assert.AreEqual("addObject:", result.Name);
	}
	
	[Test]
	public void SelectorWithCast() 
	{
		NSObject table = (NSObject) new Class("NSHashTable").Call("alloc").Call("init");
		Selector selector = new Selector("addObject:");
		NSObject sig = (NSObject) table.Call("methodSignatureForSelector:", selector);
		
		Class klass = new Class("NSInvocation");
		NSObject invoke = (NSObject) klass.Call("invocationWithMethodSignature:", sig);
		
		invoke.Call("setSelector:", selector);
		Selector result = (Selector) invoke.Call("selector");
		
		Assert.AreEqual("addObject:", result.Name);
	}
	
	[Test]
	public void StructWithTo() 
	{
		Class klass = new Class("NSString");
		NSObject str = (NSObject) klass.Call("stringWithUTF8String:", Marshal.StringToHGlobalAuto("the quick brown fox"));
		NSObject quick = (NSObject) klass.Call("stringWithUTF8String:", Marshal.StringToHGlobalAuto("quick"));
		
		NSRange result = str.Call("rangeOfString:", quick).To<NSRange>();
		Assert.AreEqual(4, result.location);
		Assert.AreEqual(5, result.length);
	}

	[Test]
	public void StructWithCast() 
	{
		Class klass = new Class("NSString");
		NSObject str = (NSObject) klass.Call("stringWithUTF8String:", Marshal.StringToHGlobalAuto("the quick brown fox"));
		NSObject quick = (NSObject) klass.Call("stringWithUTF8String:", Marshal.StringToHGlobalAuto("quick"));
		
		NSRange result = (NSRange) str.Call("rangeOfString:", quick);
		Assert.AreEqual(4, result.location);
		Assert.AreEqual(5, result.length);
	}

	[Test]
	[ExpectedException(typeof(InvalidCastException))]
	public void BadUInt16To()
	{
		Class klass = new Class("NSNumber");
		
		NSObject num = klass.Call("alloc").To<NSObject>();
		num = num.Call("initWithInt:", 5000).To<NSObject>();
		
		num.Call("unsignedShortValue").To<Int32>();
	}

	[Test]
	[ExpectedException(typeof(InvalidCastException))]
	public void BadLongTo()
	{
		Class klass = new Class("NSNumber");
		
		NSObject num = klass.Call("alloc").To<NSObject>();
		num = num.Call("initWithInt:", 5000).To<NSObject>();
		
		num.Call("longValue").To<Int64>();
	}

	[Test]
	[ExpectedException(typeof(InvalidCastException))]
	public void BadFloatTo()
	{
		Class klass = new Class("NSNumber");
		
		NSObject num = klass.Call("alloc").To<NSObject>();
		num = num.Call("initWithInt:", 5000).To<NSObject>();
		
		num.Call("floatValue").To<double>();
	}

	private NSObject m_pool;
}
