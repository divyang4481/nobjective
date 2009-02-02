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

// http://developer.apple.com/documentation/Cocoa/Reference/ObjCRuntimeRef/Reference/reference.html
#include <Foundation/Foundation.h>
#include <objc/runtime.h>

#define MACOSX  		// this is what the man page says to do...
#include <ffi/ffi.h>
#include <sys/mman.h>

typedef NSException* (*ManagedImp)(void* dummy, void* result, void** args);

Class CreateClass(Class superClass, const char* name, id* exception)
{
	Class klass = nil;
		
	@try
	{
		klass = objc_allocateClassPair(superClass, name, 0);
		if (klass == nil)
			[NSException raise: @"Couldn't allocate class pair" format: @"'%s' may already be allocated", name];
	}
	@catch (id e)
	{
		*exception = e;
	}
	
	return klass;
}

static void Thunk(ffi_cif* cif, void* ret, void** args, void* userData)
{
	ManagedImp mimp = (ManagedImp) userData;
	NSException* e = mimp(NULL, ret, args);
	
	if (e != nil)
	{
		[e raise];
	}
}

int AddMethod(Class superClass, Class klass, SEL selector, const char* sig, ManagedImp mimp, ffi_cif* cif)
{	
	int status = 0;			
	
	// Use libffi to install an IMP which will call our forwarder function with
	// the arguments used in the original method call.
	ffi_closure* closure = mmap(NULL, sizeof(ffi_closure), PROT_READ | PROT_WRITE, MAP_ANON | MAP_PRIVATE, -1, 0); 
	if (closure == (void*)-1)
		status = errno;
	
	if (status == 0)
		status = ffi_prep_closure(closure, cif, Thunk, mimp);	// the newer ffilib's have a simpler closure API, but it doesn't ship with leopard
		
	if (status == 0)
		if (mprotect(closure, sizeof(closure), PROT_READ | PROT_EXEC) == -1)
			status = errno;
			
	if (status == 0)
		if (!class_addMethod(klass, selector, (IMP) closure, sig))
			status = 0xADDF;

	return status;
}

void RegisterClass(Class klass, id* exception)
{	
	@try
	{
		objc_registerClassPair(klass);	
	}
	@catch (id e)
	{
		*exception = e;
	}
}
