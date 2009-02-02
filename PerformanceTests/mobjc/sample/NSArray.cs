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

// http://developer.apple.com/documentation/Cocoa/Reference/Foundation/Classes/NSArray_Class/Reference/Reference.html
[Register]
internal sealed class NSArray : NSObject
{
	public NSArray(IntPtr value) : base(value)
	{
	}
	
	public int Length
	{
		get
		{
			return (int) (uint) Call("count");
		}
	}
	
	public NSObject this[int index]
	{
		get
		{				
			return Call("objectAtIndex:", (uint) index).To<NSObject>();
		}
	}
 
 	public NSObject LastObject()
 	{
 		return (NSObject) Call("lastObject");
 	}
}
