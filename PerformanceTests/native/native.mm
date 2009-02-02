//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

#include <stdio.h>
#include <string.h>
#include <sys/mman.h>
#include <objc/objc.h>
#include <Cocoa/Cocoa.h>
#include <objc/message.h>

@interface ExceptionTest : NSObject
- ( void ) Throw:( long long ) arg1 arg2:( long long ) arg2 arg3:( long long ) arg3 arg4:( long long ) arg4 arg5:( long long ) arg5;
- ( void ) NoThrow:( long long ) arg1 arg2:( long long ) arg2 arg3:( long long ) arg3 arg4:( long long ) arg4 arg5:( long long ) arg5;
@end

@implementation ExceptionTest

- ( void ) Throw:( long long ) arg1 arg2:( long long ) arg2 arg3:( long long ) arg3 arg4:( long long ) arg4 arg5:( long long ) arg5 {
	@throw [NSException exceptionWithName:@"Exception" reason:@"Exception" userInfo:nil];
}

- ( void ) NoThrow:( long long ) arg1 arg2:( long long ) arg2 arg3:( long long ) arg3 arg4:( long long ) arg4 arg5:( long long ) arg5 {
}

@end


extern "C" {
	void TestImpInvocation( int iterations ) {
		typedef int (*hash_imp)( const void*, const void* );

		const NSNumber* instance = [NSNumber numberWithInt:10];

		const SEL sel = @selector( hash );
		const hash_imp imp = ( hash_imp ) class_getMethodImplementation( objc_getClass( "NSCFNumber" ), sel );

		for( int i = 0; i < iterations; i++ )
			imp( instance, sel );
	}

	void TestInvocationUnprotected( int iterations ) {
		NSNumber* instance = [NSNumber numberWithInt:10];

		for( int i = 0; i < iterations; i++ )
			[instance hash];
	}

	void TestInvocationProtected( int iterations ) {
		NSNumber* instance = [NSNumber numberWithInt:10];

		for( int i = 0; i < iterations; i++ )
		{
			@try {
				[instance hash];
			}
			@catch( id excpetion ) {
			}
		}
	}

	void DllImportOverheadUnprotected( void* object, SEL sel ) {
	}

	void DllImportOverheadProtected( void* object, SEL sel ) {
		@try {
		}
		@catch( id excpt ) {
		}
	}

	void TestVarargMarshaling( int iterations ) {
		NSString* instance = [NSString stringWithString: @"some string to test" ];

		for( int i = 0; i < iterations; i++ )
			[instance stringByAppendingFormat: @" %@ %@ %f %d %d", @"some", @"text", 3.14159265, true, 10 ];
	}

	void TestAllocation( int iterations ) {
		for( int i = 0; i < iterations; i++ )
			[NSNumber numberWithInt: 10 ];
	}	
	
	void TestExceptionOverhead( int iterations ) {
		ExceptionTest *instance = [[ExceptionTest alloc] init];
		
		for( int i = 0; i < iterations; i++ )
			@try { [instance NoThrow:10 arg2:20 arg3:30 arg4:40 arg5:50]; }
			@catch( id exception ) { }
	}

	void TestExceptionRethrow( int iterations ) {
		ExceptionTest *instance = [[ExceptionTest alloc] init];
		
		for( int i = 0; i < iterations; i++ )
			@try { [instance Throw:10 arg2:20 arg3:30 arg4:40 arg5:50]; }
			@catch( id exception ) { }
	}
}