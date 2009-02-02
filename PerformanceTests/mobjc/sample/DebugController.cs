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

using MObjc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

[ExportClass("DebugController", "NSObject")]
internal sealed class DebugController : NSObject
{
	private DebugController(IntPtr instance) : base(instance)
	{
	}

#if DEBUG	
	public void collectGarbage(NSObject sender)
	{
		GC.Collect();
		GC.WaitForPendingFinalizers();
	}
		
	public void dumpObjects(NSObject sender)
	{
		List<string> lines = new List<string>();
		
		GC.Collect();
		GC.WaitForPendingFinalizers();

		foreach (NSObject o in NSObject.Snapshot())
		{
			lines.Add(o.ToString("G", null));
		}
		
		lines.Sort();
		foreach (string line in lines)
			Console.WriteLine(line);
		Console.WriteLine(" ");
	}
		
	public void dumpMemory(NSObject sender)
	{
		DoPrintMemory();		
	}
		
	public void memoryTest(NSObject sender)	
	{
		lock (m_lock)
		{
			if (m_checkingMemory)
			{
				m_checkingMemory = false;
				Monitor.PulseAll(m_lock);
				
				m_thread1 = null;
				m_thread2 = null;
			}
			else
			{				
				NSObject app = (NSObject) new Class("NSApplication").Call("sharedApplication");
				NSObject window = (NSObject) app.Call("mainWindow");
				NSObject content = (NSObject) window.Call("contentView");
				NSObject view = (NSObject) content.Call("viewWithTag:", 33);

				if (!view.IsNil())
				{
					m_thread1 = new Thread(this.DoDumpStatsThread);
					m_thread1.Start();

					m_thread2 = new Thread(this.DoMemoryThread);
					m_thread2.Start(view);

					m_checkingMemory = true;	
				}
				else
					Console.WriteLine("Couldn't find the simple layout view.");
			}
		}
	}
#endif

	public bool validateMenuItem(NSObject menuItem)
	{
		Selector selector = (Selector) menuItem.Call("action");
		if (selector.Name == "memoryTest:")
		{
			NSObject text;

			lock (m_lock)
			{
				if (m_checkingMemory)
					text = (NSObject) new Class("NSString").Call("stringWithUTF8String:", Marshal.StringToHGlobalAuto("Stop Memory Test"));
				else
					text = (NSObject) new Class("NSString").Call("stringWithUTF8String:", Marshal.StringToHGlobalAuto("Start Memory Test"));
			}
			
			menuItem.Call("setTitle:", text);
		}
			
		return true;
	}

#if DEBUG	
	// There's probably a better way to do this but using top is easy and should give us
	// accurate results. Note that Process does have a number of memory related properties
	// but they all return 0 with mono 1.9 except Process.MaxWorkingSet.
	private void DoPrintMemory()
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
					const double OneMeg = 1024.0*1024.0;	
					
					Console.WriteLine("timestamp: {0:hh:mm}", DateTime.Now);
					Console.WriteLine("resident bytes: {0:0.000}M", long.Parse(parts[2])/OneMeg);
					Console.WriteLine("virtual bytes: {0:0.000}M", long.Parse(parts[3])/OneMeg);
					Console.WriteLine("managed bytes: {0:0.000}M", GC.GetTotalMemory(false)/OneMeg);
					Console.WriteLine("NSObject count: {0}", NSObject.Snapshot().Length);
					Console.WriteLine(" ");
				}
				else
					Console.WriteLine("Expected four columns from top, but got '{0}'", line);
				return;
			}
		}

		Console.WriteLine("Couldn't find our pid: {0}.", pid);
	}

	private void DoDumpStatsThread(object instance)
	{		
		TimeSpan interval = TimeSpan.FromMinutes(60);
		Unused.Value = (NSObject) new Class("NSAutoreleasePool").Call("alloc").Call("init");

		lock (m_lock)
		{
			while (m_checkingMemory)
			{
				DoPrintMemory();		

				Unused.Value = Monitor.Wait(m_lock, interval);
			}
		}
	}

	private void DoMemoryThread(object arg)
	{		
		NSObject view = (NSObject) arg;
		TimeSpan interval = TimeSpan.FromSeconds(5);
		Random rand = new Random(1);

		NSObject pool = (NSObject) new Class("NSAutoreleasePool").Call("alloc").Call("init");

		lock (m_lock)
		{
			int count = 0;				// note that this isn't the count of boxes: it's the count of boxes added by this thread
			
			while (m_checkingMemory)
			{
				bool signaled = Monitor.Wait(m_lock, interval);
				
				if (!signaled)
				{
					Selector selector;
					if ((rand.Next(2) == 0 || count == 0) && count < 12)
					{
						selector = new Selector("addABox:");
						++count;
					}
					else
					{
						selector = new Selector("removeLastBox:");
						--count;
					}
						
					view.Call("performSelectorOnMainThread:withObject:waitUntilDone:", selector, null, false);
				}
			}
		}
		
		pool.release();
	}
#endif

	private Thread m_thread1;
	private Thread m_thread2;
	private bool m_checkingMemory;
	private object m_lock = new object();
}
