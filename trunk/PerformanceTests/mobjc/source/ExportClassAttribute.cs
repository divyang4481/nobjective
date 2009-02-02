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

using System;

namespace MObjc
{
	// Used to mark a class as one that can be used from Objective-C.
	// Note that the class should also be a descendent of NSObject.
	[Serializable]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public sealed class ExportClassAttribute : Attribute
	{		
		public ExportClassAttribute(string derivedName) : this(derivedName, "NSObject")
		{
		}
		
		public ExportClassAttribute(string derivedName, string baseName) 
		{
			if (string.IsNullOrEmpty(derivedName))
				throw new ArgumentException("derivedName is null or empty");
				
			if (string.IsNullOrEmpty(baseName))
				throw new ArgumentException("baseName is null or empty");
				
			DerivedName = derivedName;
			BaseName = baseName;
		}
		
		// The C# class can be instantiated using a C# new expression
		// or using the derived name and the alloc method.
		public string DerivedName {get; private set;}
	
		public string BaseName {get; private set;}
	
		// Space delimited list of instance variables to add to the class.
		public string Outlets {get; set;}
	}
}
