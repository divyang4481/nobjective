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

#include <Foundation/Foundation.h>
#include <objc/message.h>

#define MACOSX  		// this is what the man page says to do...
#include <ffi/ffi.h>

#if 0
void DumpCif(ffi_cif* cif)
{
	int i;
	
	fprintf(stderr, "cif addr: %X\n", (int) cif);
	fprintf(stderr, "cif nargs: %d\n", cif->nargs);
	for (i = 0; i < cif->nargs + 1; ++i)
		fprintf(stderr, "atype%d: %X\n", i, (int) cif->arg_types[i]);
	fprintf(stderr, "rtype: %X\n", (int) cif->rtype);
	fprintf(stderr, "bytes: %d\n", cif->bytes);
	fprintf(stderr, "flags: %d\n", cif->flags);
}

void DumpClosure(ffi_closure* closure)
{
	int i;
	
	fprintf(stderr, "closure addr: %X\n", (int) closure);
	
	fprintf(stderr, "   tramp: ");
	for (i = 0; i < FFI_TRAMPOLINE_SIZE; ++i)
		fprintf(stderr, "%.2x", (int) closure->tramp[i]);
	fprintf(stderr, "\n");

	fprintf(stderr, "   cif abi: %d\n", closure->cif->abi);
	for (i = 0; i < closure->cif->nargs + 1; ++i)
		fprintf(stderr, "   cif atype%d: %X\n", i, (int) closure->cif->arg_types[i]);
	fprintf(stderr, "   cif rtype: %X\n", (int) closure->cif->rtype);
	fprintf(stderr, "   cif bytes: %d\n", closure->cif->bytes);
	fprintf(stderr, "   cif flags: %d\n", closure->cif->flags);
	fprintf(stderr, "   fun: %X\n", (int) closure->fun);
	fprintf(stderr, "   user_data: %X\n", (int) closure->user_data);
}
#endif

ffi_type* GetFfiType(char code)
{
	ffi_type* type = NULL;
	
	switch (code)
	{
		case 'v':
			type = &ffi_type_void;
			break;
			
		case 'C':
			type = &ffi_type_uint8;
			break;
			
		case 'c':
			type = &ffi_type_sint8;
			break;
			
		case 'S':
			type = &ffi_type_uint16;
			break;
			
		case 's':
			type = &ffi_type_sint16;
			break;
			
		case 'I':
		case 'L':
			type = &ffi_type_uint32;
			break;
			
		case 'i':
		case 'l':
			type = &ffi_type_sint32;
			break;
			
		case 'Q':
			type = &ffi_type_uint64;
			break;
			
		case 'q':
			type = &ffi_type_sint64;
			break;
			
		case 'f':
			type = &ffi_type_float;
			break;
			
		case 'd':
			type = &ffi_type_double;
			break;
						
		case 'p':
			type = &ffi_type_pointer;
			break;			
	}
	
	return type;
}

ffi_type* AllocStructFfiType(ffi_type** fieldTypes)
{
	ffi_type* type = malloc(sizeof(ffi_type));
	
	type->size = 0;
	type->alignment = 0;
	type->type = FFI_TYPE_STRUCT;
	type->elements = fieldTypes;

	return type;
}

void FreeStructType(ffi_type* type)
{
	free(type->elements);
	free(type);
}

ffi_cif* AllocCif(int numArgs, ffi_type* rtype, ffi_type** atypes)
{
	ffi_cif* cif = malloc(sizeof(ffi_cif));

	ffi_status status = ffi_prep_cif(cif, FFI_DEFAULT_ABI, numArgs, rtype, atypes);
	if (status == FFI_OK)
	{
		return cif;
	}
	else
	{
		free(cif);
		return (ffi_cif*) status;
	}
}

// Calling arbitrary IMPs is difficult to do in a cross platform manner. The
// runtime provides objc_msgSend, objc_msgSend_stret, and objc_msgSend_fpret
// functions to call IMPs, but the one you need to call depends on the current
// platform and sometimes even on the struct size.
//
// libffi provides a much better solution. It allows us to safely and portably
// call any IMP so we don't need to muck with the objc_msgSend functions at all.
typedef void (*Methodg)();
void FfiCall(ffi_cif* cif, Methodg imp, void* result, void** args, id* exception)
{
	@try
	{		
		ffi_call(cif, imp, result, args);
	}
	@catch (id e)
	{
		*exception = e;
	}
}

void FreeCif(ffi_cif* cif)
{
	free(cif);
}
