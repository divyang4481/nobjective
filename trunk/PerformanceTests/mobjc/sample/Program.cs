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

// This is based on the AnimatingViews AppKit example from the developer examples.
using MObjc;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

// http://developer.apple.com/documentation/Cocoa/Reference/ApplicationKit/Miscellaneous/AppKit_Functions/Reference/reference.html
internal static class Program
{
	internal static void Main(string[] args)
	{	
		try
		{
			Registrar.CanInit = true;

			// Force Trace.Assert and Debug.Assert to throw exceptions
			AssertListener.Install();
			
			// Make our app a foreground app (if we don't do this we won't appear in the dock).
			IntPtr psn = IntPtr.Zero;	
			GetCurrentProcess(ref psn);
			
			TransformProcessType(ref psn, 1);
			SetFrontProcess(ref psn);
		
			// Load the nib and run the main event loop.
			NSObject pool = new NSObject(NSObject.AllocNative("NSAutoreleasePool"));
			App app = new App("MainMenu.nib");
			pool.release();

			app.Run();
		}
		catch (Exception e)
		{
			Console.WriteLine(e);
		}
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	private static extern void GetCurrentProcess(ref IntPtr psn);

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	private static extern void TransformProcessType(ref IntPtr psn, uint type);

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	private static extern void SetFrontProcess(ref IntPtr psn);
}
