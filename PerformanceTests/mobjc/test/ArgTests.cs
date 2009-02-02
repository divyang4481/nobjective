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
using System.Reflection;
using System.Runtime.InteropServices;

[TestFixture]
public class ArgTests 	
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
	public void SChar1()	 
	{
		NSObject n = new Class("NSNumber").Call("numberWithChar:", (sbyte) 17).To<NSObject>();
		Assert.AreEqual("17", n.description());
	}

	[Test]
	public void SChar2()	 
	{
		NSObject n = new Class("NSNumber").Call("numberWithChar:", true).To<NSObject>();
		Assert.AreEqual("1", n.description());
	}

	[Test]
	public void UChar()	 
	{
		NSObject n = new Class("NSNumber").Call("numberWithUnsignedChar:", (byte) 17).To<NSObject>();
		Assert.AreEqual("17", n.description());
	}

	[Test]
	public void Short()	 
	{
		NSObject n = new Class("NSNumber").Call("numberWithShort:", (short) 17).To<NSObject>();
		Assert.AreEqual("17", n.description());
	}

	[Test]
	public void Int()	 
	{
		NSObject n = new Class("NSNumber").Call("numberWithInt:", 17).To<NSObject>();
		Assert.AreEqual("17", n.description());
	}

	[Test]
	public void Long()	 
	{
		NSObject n = new Class("NSNumber").Call("numberWithLong:", 17).To<NSObject>();
		Assert.AreEqual("17", n.description());
	}

	[Test]
	public void LongLong()	 
	{
		NSObject n = new Class("NSNumber").Call("numberWithLongLong:", 17L).To<NSObject>();
		Assert.AreEqual("17", n.description());
	}

	[Test]
	public void UShort1()	 
	{
		NSObject n = new Class("NSNumber").Call("numberWithUnsignedShort:", (ushort) 17).To<NSObject>();
		Assert.AreEqual("17", n.description());
	}

	[Test]
	public void UShort2()	 
	{
		NSObject n = new Class("NSNumber").Call("numberWithUnsignedShort:", 'x').To<NSObject>();
		Assert.AreEqual("120", n.description());
	}

	[Test]
	public void UInt()	 
	{
		NSObject n = new Class("NSNumber").Call("numberWithUnsignedInt:", 17U).To<NSObject>();
		Assert.AreEqual("17", n.description());
	}

	[Test]
	public void ULong()	 
	{
		NSObject n = new Class("NSNumber").Call("numberWithUnsignedLong:", 17U).To<NSObject>();
		Assert.AreEqual("17", n.description());
	}

	[Test]
	public void ULongLong()	 
	{
		NSObject n = new Class("NSNumber").Call("numberWithUnsignedLongLong:", 17UL).To<NSObject>();
		Assert.AreEqual("17", n.description());
	}

	[Test]
	public void Float()	 
	{
		NSObject n = new Class("NSNumber").Call("numberWithFloat:", 1.2f).To<NSObject>();
		float x = (float) n.Call("floatValue");
		Assert.IsTrue(Math.Abs(1.2 - x) < 0.001);
	}

	[Test]
	public void Double1()	 
	{
		NSObject n = new Class("NSNumber").Call("numberWithDouble:", 1.2).To<NSObject>();
		double x = (double) n.Call("doubleValue");
		Assert.IsTrue(Math.Abs(1.2 - x) < 0.001);
	}

	[Test]
	public void Double2()	 
	{
		NSObject n = new Class("NSNumber").Call("numberWithDouble:", 1.2f).To<NSObject>();
		double x = (double) n.Call("doubleValue");
		Assert.IsTrue(Math.Abs(1.2 - x) < 0.001);
	}

	[Test]
	public void CString()	 
	{
		NSObject s = new Class("NSString").Call("stringWithUTF8String:", Marshal.StringToHGlobalAuto("hello")).To<NSObject>();
		Assert.AreEqual("hello", s.description());
	}
	
	[Test]
	public void UnicharString()	 
	{
		NSObject s = new Class("NSString").Call("stringWithCharacters:length:", Marshal.StringToHGlobalUni("hello"), (uint) "hello".Length).To<NSObject>();
		Assert.AreEqual("hello", s.description());
	}
	
	[Test]
	public void Object1()	 
	{
		NSObject s = new Class("NSString").Call("stringWithUTF8String:", Marshal.StringToHGlobalAuto("hello")).To<NSObject>();
		NSObject t = new Class("NSString").Call("stringWithString:", s).To<NSObject>();
		Assert.AreEqual("hello", t.description());
	}
	
	[Test]
	public void Object2()	 
	{
		NSObject s = new Class("NSString").Call("stringWithUTF8String:", Marshal.StringToHGlobalAuto("hello")).To<NSObject>();
		NSObject t = new Class("NSString").Call("stringWithString:", (IntPtr) s).To<NSObject>();
		Assert.AreEqual("hello", t.description());
	}
	
	[Test]
	public void Class1()	 
	{
		Class objClass = new Class("NSObject");
		Class strClass = new Class("NSString");
		Class numClass = new Class("NSNumber");

		NSObject s = strClass.Call("stringWithUTF8String:", Marshal.StringToHGlobalAuto("hello")).To<NSObject>();

		sbyte b = (sbyte) s.Call("isKindOfClass:", strClass);
		Assert.AreEqual(1, b);

		b = (sbyte) s.Call("isKindOfClass:", objClass);
		Assert.AreEqual(1, b);

		b = (sbyte) s.Call("isKindOfClass:", numClass);
		Assert.AreEqual(0, b);
	}
	
	[Test]
	public void Class2()	 
	{
		Class objClass = new Class("NSObject");
		Class strClass = new Class("NSString");
		Class numClass = new Class("NSNumber");

		NSObject s = strClass.Call("stringWithUTF8String:", Marshal.StringToHGlobalAuto("hello")).To<NSObject>();

		sbyte b = (sbyte) s.Call("isKindOfClass:", (IntPtr) strClass);
		Assert.AreEqual(1, b);

		b = (sbyte) s.Call("isKindOfClass:", (IntPtr) objClass);
		Assert.AreEqual(1, b);

		b = (sbyte) s.Call("isKindOfClass:", (IntPtr) numClass);
		Assert.AreEqual(0, b);
	}
	
	[Test]
	public void Selector1()	 
	{
		NSObject s = new Class("NSString").Call("stringWithUTF8String:", Marshal.StringToHGlobalAuto("hello")).To<NSObject>();

		sbyte b = (sbyte) s.Call("respondsToSelector:", new Selector("getCharacters:"));
		Assert.AreEqual(1, b);

		b = (sbyte) s.Call("respondsToSelector:", new Selector("xxx:"));
		Assert.AreEqual(0, b);
	}
	
	[Test]
	public void Selector2()	 
	{
		NSObject s = new Class("NSString").Call("stringWithUTF8String:", Marshal.StringToHGlobalAuto("hello")).To<NSObject>();

		sbyte b = (sbyte) s.Call("respondsToSelector:", (IntPtr) new Selector("getCharacters:"));
		Assert.AreEqual(1, b);

		b = (sbyte) s.Call("respondsToSelector:", (IntPtr) new Selector("xxx:"));
		Assert.AreEqual(0, b);
	}
	
	[Test]
	public void Struct() 
	{
		NSObject str = new Class("NSString").Call("stringWithUTF8String:", Marshal.StringToHGlobalAuto("the quick brown fox")).To<NSObject>();
		
		NSRange range = new NSRange();
		range.location = 4;
		range.length = 5;
		
		NSObject iresult = (NSObject) str.Call("substringWithRange:", range);
		string sresult = Marshal.PtrToStringAuto((IntPtr) iresult.Call("UTF8String"));
		
		Assert.AreEqual("quick", sresult);
	}

	[Test]
	[ExpectedException(typeof(InvalidCallException))]
	public void BadStruct() 
	{
		NSObject str = new Class("NSString").Call("stringWithUTF8String:", Marshal.StringToHGlobalAuto("the quick brown fox")).To<NSObject>();
		
		NSRect r = new NSRect();
		str.Call("substringWithRange:", r);
	}

	[Test]
	[ExpectedException(typeof(InvalidCallException))]
	public void BadInt()	 
	{
		new Class("NSNumber").Call("numberWithInt:", (short) 17).To<NSObject>();
	}

	private NSObject m_pool;
}
