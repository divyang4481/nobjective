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
using System.Runtime.InteropServices;

// http://developer.apple.com/documentation/Cocoa/Reference/ApplicationKit/Classes/NSApplication_Class/Reference/Reference.html
internal sealed class App 
{
	public App(string nibName)
	{		
		NSObject app = (NSObject) new Class("NSApplication").Call("sharedApplication");

		// Load our nib. This will instantiate all of the native objects and wire them together.
		// The C# SimpleLayoutView will be created the first time Objective-C calls one of the
		// methods SimpleLayoutView added or overrode.
		NSObject dict = new Class("NSMutableDictionary").Call("alloc").Call("init").To<NSObject>();
		NSObject key = new Class("NSString").Call("stringWithUTF8String:", Marshal.StringToHGlobalAuto("NSOwner")).To<NSObject>();
		dict.Call("setObject:forKey:", app, key);

		NSObject bundle = new Class("NSBundle").Call("mainBundle").To<NSObject>();

		NSObject nib = new Class("NSString").Call("stringWithUTF8String:", Marshal.StringToHGlobalAuto(nibName)).To<NSObject>();
		sbyte loaded = (sbyte) bundle.Call("loadNibFile:externalNameTable:withZone:", nib, dict, null);
		if (loaded != 1)
			throw new InvalidOperationException("Couldn't load the nib file");
		
		// We need an NSAutoreleasePool to do Native.Call, but we don't want to have one
		// hanging around while we're in the main event loop because that may hide bugs.
		// So, we'll instantiate a Native instance here and call Invoke later which can
		// be done without an NSAutoreleasePool.
		m_run = new Native(app, new Selector("run"));
		
		dict.release();
	}
		
	public void Run()
	{
		m_run.Invoke();
	}

	private Native m_run;
}
