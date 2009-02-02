//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

#include <stdio.h>
#include <string.h>
#include <sys/mman.h>
#include <objc/objc.h>
#include <objc/message.h>

typedef unsigned char byte;

#if defined( __i386__ )
	#define FPRET_TYPE double
#elif defined( __x86_64__ )
	#define FPRET_TYPE long double 
#else
	#define FPRET_TYPE double
#endif

#if defined( __i386__ ) || defined( __x86_64__ )
	#define __objc_msgSend_fpret objc_msgSend_fpret
#else
	#define __objc_msgSend_fpret objc_msgSend
#endif

template<int StackSize>
struct ArgumentsStack {
	char Filler[StackSize];
};

#define TRACE_PARAMETERS()
//#define TRACE_PARAMETERS() printf( "object: %08x, selector: %s, occuredException: %08x\r\n", object, sel_getName( selector ), occuredException ); fflush( stdout );

typedef void ( *objc_msgSend_stret_ptr )( void * stretAddress, void* object, SEL selector, ... );
typedef void ( *objc_msgSendSuper_stret_ptr )( void * stretAddress, objc_super* object, SEL selector, ... );

typedef long long ( *objc_msgSend64 )( void* object, SEL selector, ... );
typedef long long ( *objc_msgSendSuper64 )( objc_super* object, SEL selector, ... );

typedef FPRET_TYPE ( *objc_msgSend_floating )( void* object, SEL selector, ... );
typedef FPRET_TYPE ( *objc_msgSendSuper_floating )( objc_super* object, SEL selector, ... );

extern "C" {
	long long objc_msgSend_eh( id object, SEL selector, id *occuredException, int stackLength, void *serializedArguments );
	
	
	/// Guarded message sending used in dynamic invocation.
	void objc_msgSend_stret_eh( void *resultAddress, int resultSize, id object, SEL selector, id *occuredException, int stackLength, void *serializedArguments ) {
#if defined( __i386__ ) || defined( __x86_64__ )
		if( resultSize <= sizeof( void* ) * 2 )
		{
			long long twoRegistersResult = objc_msgSend_eh( object, selector, occuredException, stackLength, serializedArguments );
			memcpy( resultAddress, &twoRegistersResult, resultSize );
			return;
		}
#endif		
		TRACE_PARAMETERS();

		@try {
			*occuredException = 0;
			
			if( stackLength == 0 )
				( ( objc_msgSend_stret_ptr ) objc_msgSend_stret )( resultAddress, object, selector );
			else if( stackLength <= 4 )
				( ( objc_msgSend_stret_ptr ) objc_msgSend_stret )( resultAddress, object, selector, * ( ArgumentsStack<4>* ) serializedArguments );
			else if( stackLength <= 8 )
				( ( objc_msgSend_stret_ptr ) objc_msgSend_stret )( resultAddress, object, selector, * ( ArgumentsStack<8>* ) serializedArguments );
			else if( stackLength <= 16 )
				( ( objc_msgSend_stret_ptr ) objc_msgSend_stret )( resultAddress, object, selector, * ( ArgumentsStack<16>* ) serializedArguments );
			else if( stackLength <= 32 )
				( ( objc_msgSend_stret_ptr ) objc_msgSend_stret )( resultAddress, object, selector, * ( ArgumentsStack<32>* ) serializedArguments );
			else if( stackLength <= 64 )
				( ( objc_msgSend_stret_ptr ) objc_msgSend_stret )( resultAddress, object, selector, * ( ArgumentsStack<64>* ) serializedArguments );
			else if( stackLength <= 128 )
				( ( objc_msgSend_stret_ptr ) objc_msgSend_stret )( resultAddress, object, selector, * ( ArgumentsStack<128>* ) serializedArguments );
			else if( stackLength <= 256 )
				( ( objc_msgSend_stret_ptr ) objc_msgSend_stret )( resultAddress, object, selector, * ( ArgumentsStack<256>* ) serializedArguments );
			else if( stackLength <= 512 )
				( ( objc_msgSend_stret_ptr ) objc_msgSend_stret )( resultAddress, object, selector, * ( ArgumentsStack<512>* ) serializedArguments );
			else if( stackLength <= 1024 )
				( ( objc_msgSend_stret_ptr ) objc_msgSend_stret )( resultAddress, object, selector, * ( ArgumentsStack<1024>* ) serializedArguments );
		}
		@catch( id exception ) {
			*occuredException = exception;
		}
	}
	
	/// Guarded message sending for generated proxies in P/Invoke.
	void objc_msgSend_stret_eh2( void *resultAddress, int resultSize, id object, SEL selector, id *occuredException, int stackLength, ... ) {
#if defined( __i386__ ) || defined( __x86_64__ )
		if( resultSize <= sizeof( void* ) * 2 )
		{
			TRACE_PARAMETERS();
			
			void *serializedArguments = &stackLength + 1;
			long long twoRegistersResult;
			
#if defined( __ppc__ )
			va_list varargPPChack;
			va_start( varargPPChack, stackLength );
			
			for( int i = 0; i < stackLength; i += 4 )
				va_arg( varargPPChack, int );
			
			va_end( varargPPChack );
#endif
			
			@try {
				*occuredException = 0;
				
				if( stackLength == 0 )
					twoRegistersResult = ( ( objc_msgSend64 ) objc_msgSend )( object, selector );
				else if( stackLength <= 4 )
					twoRegistersResult = ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<4>* ) serializedArguments );
				else if( stackLength <= 8 )
					twoRegistersResult = ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<8>* ) serializedArguments );
				else if( stackLength <= 16 )
					twoRegistersResult = ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<16>* ) serializedArguments );
				else if( stackLength <= 32 )
					twoRegistersResult = ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<32>* ) serializedArguments );
				else if( stackLength <= 64 )
					twoRegistersResult = ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<64>* ) serializedArguments );
				else if( stackLength <= 128 )
					twoRegistersResult = ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<128>* ) serializedArguments );
				else if( stackLength <= 256 )
					twoRegistersResult = ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<256>* ) serializedArguments );
				else if( stackLength <= 512 )
					twoRegistersResult = ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<512>* ) serializedArguments );
				else if( stackLength <= 1024 )
					twoRegistersResult = ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<1024>* ) serializedArguments );
			}
			@catch( id exception ) {
				*occuredException = exception;
			}
			
			memcpy( resultAddress, &twoRegistersResult, resultSize );
			return;
		}
#endif		
		TRACE_PARAMETERS();
		
		void *serializedArguments = &stackLength + 1;
		
#if defined( __ppc__ )
		va_list varargPPChack;
		va_start( varargPPChack, stackLength );

		for( int i = 0; i < stackLength; i += 4 )
			va_arg( varargPPChack, int );

		va_end( varargPPChack );
#endif

		@try {
			*occuredException = 0;
			
			if( stackLength == 0 )
				( ( objc_msgSend_stret_ptr ) objc_msgSend_stret )( resultAddress, object, selector );
			else if( stackLength <= 4 )
				( ( objc_msgSend_stret_ptr ) objc_msgSend_stret )( resultAddress, object, selector, * ( ArgumentsStack<4>* ) serializedArguments );
			else if( stackLength <= 8 )
				( ( objc_msgSend_stret_ptr ) objc_msgSend_stret )( resultAddress, object, selector, * ( ArgumentsStack<8>* ) serializedArguments );
			else if( stackLength <= 16 )
				( ( objc_msgSend_stret_ptr ) objc_msgSend_stret )( resultAddress, object, selector, * ( ArgumentsStack<16>* ) serializedArguments );
			else if( stackLength <= 32 )
				( ( objc_msgSend_stret_ptr ) objc_msgSend_stret )( resultAddress, object, selector, * ( ArgumentsStack<32>* ) serializedArguments );
			else if( stackLength <= 64 )
				( ( objc_msgSend_stret_ptr ) objc_msgSend_stret )( resultAddress, object, selector, * ( ArgumentsStack<64>* ) serializedArguments );
			else if( stackLength <= 128 )
				( ( objc_msgSend_stret_ptr ) objc_msgSend_stret )( resultAddress, object, selector, * ( ArgumentsStack<128>* ) serializedArguments );
			else if( stackLength <= 256 )
				( ( objc_msgSend_stret_ptr ) objc_msgSend_stret )( resultAddress, object, selector, * ( ArgumentsStack<256>* ) serializedArguments );
			else if( stackLength <= 512 )
				( ( objc_msgSend_stret_ptr ) objc_msgSend_stret )( resultAddress, object, selector, * ( ArgumentsStack<512>* ) serializedArguments );
			else if( stackLength <= 1024 )
				( ( objc_msgSend_stret_ptr ) objc_msgSend_stret )( resultAddress, object, selector, * ( ArgumentsStack<1024>* ) serializedArguments );
		}
		@catch( id exception ) {
			*occuredException = exception;
		}
	}

	/// Guarded message sending in dynamic invocation.
	long long objc_msgSend_eh( id object, SEL selector, id *occuredException, int stackLength, void *serializedArguments ) {
		TRACE_PARAMETERS();

		@try {
			*occuredException = 0;
			
			if( stackLength == 0 )
				return ( ( objc_msgSend64 ) objc_msgSend )( object, selector );
			else if( stackLength <= 4 )
				return ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<4>* ) serializedArguments );
			else if( stackLength <= 8 )
				return ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<8>* ) serializedArguments );
			else if( stackLength <= 16 )
				return ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<16>* ) serializedArguments );
			else if( stackLength <= 32 )
				return ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<32>* ) serializedArguments );
			else if( stackLength <= 64 )
				return ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<64>* ) serializedArguments );
			else if( stackLength <= 128 )
				return ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<128>* ) serializedArguments );
			else if( stackLength <= 256 )
				return ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<256>* ) serializedArguments );
			else if( stackLength <= 512 )
				return ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<512>* ) serializedArguments );
			else if( stackLength <= 1024 )
				return ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<1024>* ) serializedArguments );
		}
		@catch( id exception ) {
			*occuredException = exception;
		}
		return -1l;
	}
	
	/// Guarded message sending for generated proxies in P/Invoke.
	long long objc_msgSend_eh2( id object, SEL selector, id *occuredException, int stackLength, ... ) {
		TRACE_PARAMETERS();
		
		void *serializedArguments = &stackLength + 1;
		
#if defined( __ppc__ )
		va_list varargPPChack;
		va_start( varargPPChack, stackLength );

		for( int i = 0; i < stackLength; i += 4 )
			va_arg( varargPPChack, int );

		va_end( varargPPChack );
#endif

		@try {
			*occuredException = 0;
			
			if( stackLength == 0 )
				return ( ( objc_msgSend64 ) objc_msgSend )( object, selector );
			else if( stackLength <= 4 )
				return ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<4>* ) serializedArguments );
			else if( stackLength <= 8 )
				return ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<8>* ) serializedArguments );
			else if( stackLength <= 16 )
				return ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<16>* ) serializedArguments );
			else if( stackLength <= 32 )
				return ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<32>* ) serializedArguments );
			else if( stackLength <= 64 )
				return ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<64>* ) serializedArguments );
			else if( stackLength <= 128 )
				return ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<128>* ) serializedArguments );
			else if( stackLength <= 256 )
				return ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<256>* ) serializedArguments );
			else if( stackLength <= 512 )
				return ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<512>* ) serializedArguments );
			else if( stackLength <= 1024 )
				return ( ( objc_msgSend64 ) objc_msgSend )( object, selector, * ( ArgumentsStack<1024>* ) serializedArguments );
		}
		@catch( id exception ) {
			*occuredException = exception;
		}
		return -1l;
	}

	/// Guarded message sending in dynamic invocation.
	long long objc_msgSendSuper_eh( objc_super *object, SEL selector, id *occuredException, int stackLength, void *serializedArguments ) {
		TRACE_PARAMETERS();
		
		@try {
			*occuredException = 0;
			
			if( stackLength == 0 )
				return ( ( objc_msgSendSuper64 ) objc_msgSendSuper )( object, selector );
			else if( stackLength <= 4 )
				return ( ( objc_msgSendSuper64 ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<4>* ) serializedArguments );
			else if( stackLength <= 8 )
				return ( ( objc_msgSendSuper64 ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<8>* ) serializedArguments );
			else if( stackLength <= 16 )
				return ( ( objc_msgSendSuper64 ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<16>* ) serializedArguments );
			else if( stackLength <= 32 )
				return ( ( objc_msgSendSuper64 ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<32>* ) serializedArguments );
			else if( stackLength <= 64 )
				return ( ( objc_msgSendSuper64 ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<64>* ) serializedArguments );
			else if( stackLength <= 128 )
				return ( ( objc_msgSendSuper64 ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<128>* ) serializedArguments );
			else if( stackLength <= 256 )
				return ( ( objc_msgSendSuper64 ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<256>* ) serializedArguments );
			else if( stackLength <= 512 )
				return ( ( objc_msgSendSuper64 ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<512>* ) serializedArguments );
			else if( stackLength <= 1024 )
				return ( ( objc_msgSendSuper64 ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<1024>* ) serializedArguments );
		}
		@catch( id exception ) {
			*occuredException = exception;
		}
		return -1l;
	}

	/// Guarded message sending for generated proxies in P/Invoke.
	long long objc_msgSendSuper_eh2( objc_super *object, SEL selector, id *occuredException, int stackLength, ... ) {
		TRACE_PARAMETERS();
		
		void *serializedArguments = &stackLength + 1;
		
#if defined( __ppc__ )
		va_list varargPPChack;
		va_start( varargPPChack, stackLength );

		for( int i = 0; i < stackLength; i += 4 )
			va_arg( varargPPChack, int );

		va_end( varargPPChack );
#endif

		@try {
			*occuredException = 0;
			
			if( stackLength == 0 )
				return ( ( objc_msgSendSuper64 ) objc_msgSendSuper )( object, selector );
			else if( stackLength <= 4 )
				return ( ( objc_msgSendSuper64 ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<4>* ) serializedArguments );
			else if( stackLength <= 8 )
				return ( ( objc_msgSendSuper64 ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<8>* ) serializedArguments );
			else if( stackLength <= 16 )
				return ( ( objc_msgSendSuper64 ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<16>* ) serializedArguments );
			else if( stackLength <= 32 )
				return ( ( objc_msgSendSuper64 ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<32>* ) serializedArguments );
			else if( stackLength <= 64 )
				return ( ( objc_msgSendSuper64 ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<64>* ) serializedArguments );
			else if( stackLength <= 128 )
				return ( ( objc_msgSendSuper64 ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<128>* ) serializedArguments );
			else if( stackLength <= 256 )
				return ( ( objc_msgSendSuper64 ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<256>* ) serializedArguments );
			else if( stackLength <= 512 )
				return ( ( objc_msgSendSuper64 ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<512>* ) serializedArguments );
			else if( stackLength <= 1024 )
				return ( ( objc_msgSendSuper64 ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<1024>* ) serializedArguments );
		}
		@catch( id exception ) {
			*occuredException = exception;
		}
		return -1l;
	}

	/// Guarded message sending used in dynamic invocation.
	void objc_msgSendSuper_stret_eh( void *resultAddress, int resultSize, objc_super *object, SEL selector, id *occuredException, int stackLength, void *serializedArguments ) {
#if defined( __i386__ ) || defined( __x86_64__ )
		if( resultSize <= sizeof( void* ) * 2 )
		{
			long long twoRegistersResult = objc_msgSendSuper_eh( object, selector, occuredException, stackLength, serializedArguments );
			memcpy( resultAddress, &twoRegistersResult, resultSize );
			return;
		}
#endif		
		TRACE_PARAMETERS();

		@try {
			*occuredException = 0;
			
			if( stackLength == 0 )
				( ( objc_msgSendSuper_stret_ptr ) objc_msgSendSuper_stret )( resultAddress, object, selector );
			else if( stackLength <= 4 )
				( ( objc_msgSendSuper_stret_ptr ) objc_msgSendSuper_stret )( resultAddress, object, selector, * ( ArgumentsStack<4>* ) serializedArguments );
			else if( stackLength <= 8 )
				( ( objc_msgSendSuper_stret_ptr ) objc_msgSendSuper_stret )( resultAddress, object, selector, * ( ArgumentsStack<8>* ) serializedArguments );
			else if( stackLength <= 16 )
				( ( objc_msgSendSuper_stret_ptr ) objc_msgSendSuper_stret )( resultAddress, object, selector, * ( ArgumentsStack<16>* ) serializedArguments );
			else if( stackLength <= 32 )
				( ( objc_msgSendSuper_stret_ptr ) objc_msgSendSuper_stret )( resultAddress, object, selector, * ( ArgumentsStack<32>* ) serializedArguments );
			else if( stackLength <= 64 )
				( ( objc_msgSendSuper_stret_ptr ) objc_msgSendSuper_stret )( resultAddress, object, selector, * ( ArgumentsStack<64>* ) serializedArguments );
			else if( stackLength <= 128 )
				( ( objc_msgSendSuper_stret_ptr ) objc_msgSendSuper_stret )( resultAddress, object, selector, * ( ArgumentsStack<128>* ) serializedArguments );
			else if( stackLength <= 256 )
				( ( objc_msgSendSuper_stret_ptr ) objc_msgSendSuper_stret )( resultAddress, object, selector, * ( ArgumentsStack<256>* ) serializedArguments );
			else if( stackLength <= 512 )
				( ( objc_msgSendSuper_stret_ptr ) objc_msgSendSuper_stret )( resultAddress, object, selector, * ( ArgumentsStack<512>* ) serializedArguments );
			else if( stackLength <= 1024 )
				( ( objc_msgSendSuper_stret_ptr ) objc_msgSendSuper_stret )( resultAddress, object, selector, * ( ArgumentsStack<1024>* ) serializedArguments );
		}
		@catch( id exception ) {
			*occuredException = exception;
		}
	}

	/// Guarded message sending in dynamic invocation.
	FPRET_TYPE objc_msgSend_fpret_eh( id object, SEL selector, id *occuredException, int stackLength, void *serializedArguments ) {
		TRACE_PARAMETERS();
		
		@try {
			*occuredException = 0;
			
			if( stackLength == 0 )
				return ( ( objc_msgSend_floating ) __objc_msgSend_fpret )( object, selector );
			else if( stackLength <= 4 )
				return ( ( objc_msgSend_floating ) __objc_msgSend_fpret )( object, selector, * ( ArgumentsStack<4>* ) serializedArguments );
			else if( stackLength <= 8 )
				return ( ( objc_msgSend_floating ) __objc_msgSend_fpret )( object, selector, * ( ArgumentsStack<8>* ) serializedArguments );
			else if( stackLength <= 16 )
				return ( ( objc_msgSend_floating ) __objc_msgSend_fpret )( object, selector, * ( ArgumentsStack<16>* ) serializedArguments );
			else if( stackLength <= 32 )
				return ( ( objc_msgSend_floating ) __objc_msgSend_fpret )( object, selector, * ( ArgumentsStack<32>* ) serializedArguments );
			else if( stackLength <= 64 )
				return ( ( objc_msgSend_floating ) __objc_msgSend_fpret )( object, selector, * ( ArgumentsStack<64>* ) serializedArguments );
			else if( stackLength <= 128 )
				return ( ( objc_msgSend_floating ) __objc_msgSend_fpret )( object, selector, * ( ArgumentsStack<128>* ) serializedArguments );
			else if( stackLength <= 256 )
				return ( ( objc_msgSend_floating ) __objc_msgSend_fpret )( object, selector, * ( ArgumentsStack<256>* ) serializedArguments );
			else if( stackLength <= 512 )
				return ( ( objc_msgSend_floating ) __objc_msgSend_fpret )( object, selector, * ( ArgumentsStack<512>* ) serializedArguments );
			else if( stackLength <= 1024 )
				return ( ( objc_msgSend_floating ) __objc_msgSend_fpret )( object, selector, * ( ArgumentsStack<1024>* ) serializedArguments );
		}
		@catch( id exception ) {
			*occuredException = exception;
		}
		return -1l;
	}

	/// Guarded message sending for generated proxies in P/Invoke.
	FPRET_TYPE objc_msgSend_fpret_eh2( id object, SEL selector, id *occuredException, int stackLength, ... ) {
		TRACE_PARAMETERS();
		
		void *serializedArguments = &stackLength + 1;

#if defined( __ppc__ )
		va_list varargPPChack;
		va_start( varargPPChack, stackLength );

		for( int i = 0; i < stackLength; i += 4 )
			va_arg( varargPPChack, int );

		va_end( varargPPChack );
#endif

		@try {
			*occuredException = 0;
			
			if( stackLength == 0 )
				return ( ( objc_msgSend_floating ) __objc_msgSend_fpret )( object, selector );
			else if( stackLength <= 4 )
				return ( ( objc_msgSend_floating ) __objc_msgSend_fpret )( object, selector, * ( ArgumentsStack<4>* ) serializedArguments );
			else if( stackLength <= 8 )
				return ( ( objc_msgSend_floating ) __objc_msgSend_fpret )( object, selector, * ( ArgumentsStack<8>* ) serializedArguments );
			else if( stackLength <= 16 )
				return ( ( objc_msgSend_floating ) __objc_msgSend_fpret )( object, selector, * ( ArgumentsStack<16>* ) serializedArguments );
			else if( stackLength <= 32 )
				return ( ( objc_msgSend_floating ) __objc_msgSend_fpret )( object, selector, * ( ArgumentsStack<32>* ) serializedArguments );
			else if( stackLength <= 64 )
				return ( ( objc_msgSend_floating ) __objc_msgSend_fpret )( object, selector, * ( ArgumentsStack<64>* ) serializedArguments );
			else if( stackLength <= 128 )
				return ( ( objc_msgSend_floating ) __objc_msgSend_fpret )( object, selector, * ( ArgumentsStack<128>* ) serializedArguments );
			else if( stackLength <= 256 )
				return ( ( objc_msgSend_floating ) __objc_msgSend_fpret )( object, selector, * ( ArgumentsStack<256>* ) serializedArguments );
			else if( stackLength <= 512 )
				return ( ( objc_msgSend_floating ) __objc_msgSend_fpret )( object, selector, * ( ArgumentsStack<512>* ) serializedArguments );
			else if( stackLength <= 1024 )
				return ( ( objc_msgSend_floating ) __objc_msgSend_fpret )( object, selector, * ( ArgumentsStack<1024>* ) serializedArguments );
		}
		@catch( id exception ) {
			*occuredException = exception;
		}
		return -1l;
	}

	/// Guarded message sending in dynamic invocation.
	FPRET_TYPE objc_msgSendSuper_fpret_eh( objc_super *object, SEL selector, id *occuredException, int stackLength, void *serializedArguments ) {
		TRACE_PARAMETERS();
		
		@try {
			*occuredException = 0;
			
			if( stackLength == 0 )
				return ( ( objc_msgSendSuper_floating ) objc_msgSendSuper )( object, selector );
			else if( stackLength <= 4 )
				return ( ( objc_msgSendSuper_floating ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<4>* ) serializedArguments );
			else if( stackLength <= 8 )
				return ( ( objc_msgSendSuper_floating ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<8>* ) serializedArguments );
			else if( stackLength <= 16 )
				return ( ( objc_msgSendSuper_floating ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<16>* ) serializedArguments );
			else if( stackLength <= 32 )
				return ( ( objc_msgSendSuper_floating ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<32>* ) serializedArguments );
			else if( stackLength <= 64 )
				return ( ( objc_msgSendSuper_floating ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<64>* ) serializedArguments );
			else if( stackLength <= 128 )
				return ( ( objc_msgSendSuper_floating ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<128>* ) serializedArguments );
			else if( stackLength <= 256 )
				return ( ( objc_msgSendSuper_floating ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<256>* ) serializedArguments );
			else if( stackLength <= 512 )
				return ( ( objc_msgSendSuper_floating ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<512>* ) serializedArguments );
			else if( stackLength <= 1024 )
				return ( ( objc_msgSendSuper_floating ) objc_msgSendSuper )( object, selector, * ( ArgumentsStack<1024>* ) serializedArguments );
		}
		@catch( id exception ) {
			*occuredException = exception;
		}
		return -1l;
	}
}
