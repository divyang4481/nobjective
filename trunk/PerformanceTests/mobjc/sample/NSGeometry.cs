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

// http://developer.apple.com/documentation/Cocoa/Reference/Foundation/Miscellaneous/Foundation_DataTypes/Reference/reference.html#//apple_ref/doc/uid/20000018-DontLinkElementID_11
[Register("_NSPoint")]
internal struct NSPoint
{
	public float x;
	public float y;
	
	public NSPoint(float x, float y)
	{
		this.x = x;
		this.y = y;
	}
	
	public static readonly NSPoint Empty = new NSPoint(0.0f, 0.0f);
}

[Register("_NSSize")]
internal struct NSSize
{
	public float width;
	public float height;
	
	public NSSize(float width, float height)
	{
		this.width = width;
		this.height = height;
	}
	
	public static readonly NSSize Empty = new NSSize(0.0f, 0.0f);
}

[Register("_NSRect")]
internal struct NSRect
{
	public NSPoint origin;
	public NSSize size;
	
	public NSRect(float x, float y, float width, float height)
	{
		origin = new NSPoint(x, y);
		size = new NSSize(width, height);
	}
	
	public NSRect ToIntegral()
	{
		return NSIntegralRect(this);
	}

 	[DllImport("/System/Library/Frameworks/Foundation.framework/Foundation")]
	private extern static NSRect NSIntegralRect(NSRect aRect);
}
