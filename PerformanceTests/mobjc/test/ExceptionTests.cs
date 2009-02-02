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
public class ExceptionTests 	
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
	public void FromNative()	 
	{
		NSObject s = new Class("NSString").Call("stringWithUTF8String:", Marshal.StringToHGlobalAuto("hello")).To<NSObject>();
	
		try
		{
			s.Call("stringByAppendingString:", IntPtr.Zero);
			Assert.Fail("should have been an exception");
		}
		catch (CocoaException e)
		{
			Assert.IsTrue(e.Message.Contains("NSInvalidArgumentException"));
			Assert.IsTrue(e.Message.Contains("nil argument"));
		}
	}

	[Test]
	public void FromManaged()	 
	{
		NSObject s = new Class("Subclass1").Call("alloc").Call("init").To<NSObject>();
	
		try
		{
			Managed.LogException = (e) => {};
			s.Call("BadValue");
			Assert.Fail("should have been an exception");
		}
		catch (TargetInvocationException e)
		{
			Assert.IsTrue(e.Message.Contains("Exception has been thrown by the target of an Objective-C method call"));
			Assert.IsNotNull(e.InnerException);
			
			ArgumentException ae = e.InnerException as ArgumentException;
			Assert.IsNotNull(ae);
			Assert.IsTrue(ae.Message.Contains("my error"));
			Assert.IsTrue(ae.Message.Contains("alpha"));
			Assert.AreEqual("alpha", ae.ParamName);
		}
		finally
		{
			Managed.LogException = null;
		}
	}

	private NSObject m_pool;
}
