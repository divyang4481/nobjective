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
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

#if YUCK
[TestFixture]
public class MemoryTests 	
{
	const int NumIterations = 10000;
	
	[TestFixtureSetUp]
	public void Init()
	{
		AssertListener.Install();

		Registrar.CanInit = true;
	}
	
	[Test]					
	public void Released() 
	{
		NSObject pool = new NSObject(NSObject.AllocNative("NSAutoreleasePool"));
		long bytes = DoGetMemory();
		
		for (int j = 1; j < 100; ++j)
		{
			for (int i = 0; i < NumIterations/100; ++i)
			{
				Class klass = new Class("NSNumber");	
				klass.release();
			}
	        GC.Collect();        
		}
		
		pool.release();
        GC.Collect();        
        GC.WaitForPendingFinalizers();

		long delta = DoGetMemory() - bytes;
		if (delta/NumIterations > 4)
			Assert.Fail("Released used {0}K of memory ({1} bytes per iteration)!", delta/1024, delta/NumIterations);
	}
	
	[Test]
	public void IntArg() 
	{
		NSObject pool = new NSObject(NSObject.AllocNative("NSAutoreleasePool"));
		long bytes = DoGetMemory();

		Class nsString = new Class("NSString");
		NSObject str = (NSObject) nsString.Call("stringWithUTF8String:", Marshal.StringToHGlobalAuto("hello world"));

		for (int j = 1; j < 100; ++j)
		{
			for (int i = 0; i < NumIterations/100; ++i)
			{
				str.Call("characterAtIndex:", 2);	
			}
	        GC.Collect();        
		}
		
		pool.release();
        GC.Collect();        
        GC.WaitForPendingFinalizers();

		long delta = DoGetMemory() - bytes;
		if (delta/NumIterations > 4)
			Assert.Fail("IntArg used {0}K of memory ({1} bytes per iteration)!", delta/1024, delta/NumIterations);
	}

	[Test]
	public void ArrayArg() 
	{
		NSObject pool = new NSObject(NSObject.AllocNative("NSAutoreleasePool"));
		Class nsData = new Class("NSData");	
		long bytes = DoGetMemory();

		for (int j = 1; j < 100; ++j)
		{
			for (int i = 0; i < NumIterations/100; ++i)
			{
				byte[] data = new byte[]{2, 5, 6, 3};
	
				NSObject d = new NSObject(nsData.Call("alloc"));
				NSObject e = (NSObject) d.Call("initWithBytes:length:", data, data.Length);
				e.release();
			}
	        GC.Collect();        
		}
		
		pool.release();
        GC.Collect();        
        GC.WaitForPendingFinalizers();

		long delta = DoGetMemory() - bytes;
		if (delta/NumIterations > 4)
			Assert.Fail("ArrayArg used {0}K of memory ({1} bytes per iteration)!", delta/1024, delta/NumIterations);
	}

	[Test]
	public void Formatted() 
	{
		NSObject pool = new NSObject(NSObject.AllocNative("NSAutoreleasePool"));
		long bytes = DoGetMemory();

		for (int j = 1; j < 100; ++j)
		{
				for (int i = 0; i < NumIterations/100; ++i)
				{
				NSObject s = (NSObject) Native.Call("[[NSNumber alloc] initWithInteger:{0}]", 33);
				s.release();
			}
	        GC.Collect();        
		}
		
		pool.release();
        GC.Collect();        
        GC.WaitForPendingFinalizers();

		long delta = DoGetMemory() - bytes;
		if (delta/NumIterations > 4)			
			Assert.Fail("Formatted used {0}K of memory ({1} bytes per iteration)!", delta/1024, delta/NumIterations);
	}

	[Test]
	public void Managed() 
	{
		NSObject pool = new NSObject(NSObject.AllocNative("NSAutoreleasePool"));
		long bytes = DoGetMemory();

		for (int j = 1; j < 100; ++j)
		{
			for (int i = 0; i < NumIterations/100; ++i)
			{
				NSObject instance = (NSObject) new Class("Subclass1").Call("alloc").Call("init");			
				instance.Call("TakeString", "what");
				instance.release();
			}
	        GC.Collect();        
		}
		
		pool.release();
        GC.Collect();        
        GC.WaitForPendingFinalizers();

		long delta = DoGetMemory() - bytes;
		if (delta/NumIterations > 4)
			Assert.Fail("Managed used {0}K of memory ({1} bytes per iteration)!", delta/1024, delta/NumIterations);
	}
	 
    private static long DoGetMemory()
    {
        GC.Collect();                 
		GC.WaitForPendingFinalizers();
        
        // Get the result of running top.
        ProcessStartInfo info = new ProcessStartInfo();
        info.Arguments = "-l 1 -P 'PID   COMMAND            RSIZE     VSIZE' -p '^aaaa ^bbbbbbbbbbbb $jjjjjjjjjj $llllllllll'";;
        info.FileName = "top";
        info.RedirectStandardOutput = true;
        info.UseShellExecute = false;
    
        Process process = Process.Start(info);
        
        if (!process.WaitForExit(60*1000))
            throw new ApplicationException("timed out waiting for top.");
            
        if (process.ExitCode < 0 || process.ExitCode > 1)
            throw new ApplicationException("top failed with error " + process.ExitCode + ".");
            
        // Get our pid.
        string pid = Process.GetCurrentProcess().Id.ToString();

        // Find the line in the top output that starts with our pid.
        while (!process.StandardOutput.EndOfStream)
        {
            string line = process.StandardOutput.ReadLine();
            if (line.StartsWith(pid + " "))
            {
                string[] parts = line.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length == 4)
                {
                    string bytes = parts[2];    // resident
//                  string bytes = parts[3];    // virtual
					return long.Parse(bytes);
                }
                else
                    throw new ApplicationException("Expected four columns from top, but got: " + line);
            }
        }

        throw new ApplicationException("Couldn't find our pid: " + pid);
    }
}
#endif