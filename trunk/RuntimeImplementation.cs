//
// Copyright (C) 2009 Eugeny Grishul
//
// See license in License.txt
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.IO;

namespace NObjective
{
	internal interface IRuntimeImplementation
	{
		string class_getName( RuntimeClass @class );
		string class_getImageName( RuntimeClass @class );
		// use direct access instead
		//RuntimeClass class_getSuperclass( RuntimeClass @class );
		RuntimeMethod[] class_copyMethodList( RuntimeClass @class );
		Selector method_getName( RuntimeMethod method );
		string method_getTypeEncoding( RuntimeMethod method );
		RuntimeProperty[] class_copyPropertyList( RuntimeClass @class );
		RuntimeClass object_getClass( IntPtr @object );
		RuntimeClass objc_allocateClassPair( RuntimeClass superClass, string name, uint extraBytes );
		bool class_addIvar( IntPtr @class, string name, int size, uint alignment, string types );
		void objc_registerClassPair( RuntimeClass @class );
		bool class_addMethod( IntPtr @class, Selector selector, IntPtr implementation, string typeEncoding );
		RuntimeProtocol[] class_copyProtocolList( RuntimeClass @class );
		RuntimeProtocol[] protocol_copyProtocolList( RuntimeProtocol protocol );
		bool class_isMetaClass( RuntimeClass handle );
		uint class_getInstanceSize( RuntimeClass @class );
		IntPtr method_getImplementation( RuntimeMethod methodHandle );
		RuntimeVariable[] class_copyIvarList( RuntimeClass @class );
		string ivar_getName( RuntimeVariable handle );
		string ivar_getTypeEncoding( RuntimeVariable handle );
		int ivar_getOffset( RuntimeVariable handle );
		void objc_disposeClassPair( RuntimeClass classHandle );
		RuntimeVariable class_getClassVariable( RuntimeObject @object, string name );
		RuntimeVariable class_getInstanceVariable( RuntimeClass @class, string name );
		RuntimeProtocol objc_getProtocol( string name );
		RuntimeProtocol[] objc_copyProtocolList();
		string protocol_getName( RuntimeProtocol protocol );
		bool class_addProtocol( RuntimeClass @class, RuntimeProtocol protocol );
	}

	internal sealed class RuntimeV0Implementation : IRuntimeImplementation
	{
		private IRuntimeImplementation _delegate;
		private StreamWriter _writer;

		public RuntimeV0Implementation( IRuntimeImplementation @delegate, string filename )
		{
			_delegate = @delegate;

			_writer = new StreamWriter( filename );
			_writer.AutoFlush = true;
		}

		#region IRuntimeImplementation Members

		public string class_getName( RuntimeClass @class )
		{
			_writer.Write( "class_getName( {0} )", @class.Address );
			var result = _delegate.class_getName( @class );
			_writer.WriteLine( " = ( {0} )", result );

			return result;
		}

		public string class_getImageName( RuntimeClass @class )
		{
			_writer.Write( "class_getImageName( {0} )", @class.Address );
			var result = _delegate.class_getImageName( @class );
			_writer.WriteLine( " = {0}", result );

			return result;
		}

		//public RuntimeClass class_getSuperclass( RuntimeClass @class )
		//{
		//    _writer.Write( "class_getSuperclass( {0} )", @class.Address );
		//    var result = _delegate.class_getSuperclass( @class );
		//    _writer.WriteLine( " = {0}", result.Address );

		//    return result;
		//}

		public RuntimeMethod[] class_copyMethodList( RuntimeClass @class )
		{
			_writer.Write( "class_copyMethodList( {0} )", @class.Address );
			var result = _delegate.class_copyMethodList( @class );
			_writer.WriteLine( " = {0}", result.Length );

			return result;
		}

		public Selector method_getName( RuntimeMethod method )
		{
			_writer.Write( "method_getName( {0} )", method.Address );
			var result = _delegate.method_getName( method );
			_writer.WriteLine( " = {0}", result );

			return result;
		}

		public string method_getTypeEncoding( RuntimeMethod method )
		{
			_writer.Write( "method_getTypeEncoding( {0} )", method.Address );
			var result = _delegate.method_getTypeEncoding( method );
			_writer.WriteLine( " = {0}", result );

			return result;
		}

		public RuntimeProperty[] class_copyPropertyList( RuntimeClass @class )
		{
			_writer.Write( "class_copyPropertyList( {0} )", @class.Address );
			var result = _delegate.class_copyPropertyList( @class );
			_writer.WriteLine( " = {0}", result.Length );

			return result;
		}

		public RuntimeClass object_getClass( IntPtr @object )
		{
			_writer.Write( "object_getClass( {0} )", @object.ToString( "X8" ) );
			var result = _delegate.object_getClass( @object );
			_writer.WriteLine( " = {0}", result.Address );

			return result;
		}

		public RuntimeClass objc_allocateClassPair( RuntimeClass superClass, string name, uint extraBytes )
		{
			_writer.Write( "objc_allocateClassPair( {0}, {1}, {2} )", superClass.Address, name, extraBytes );
			var result = _delegate.objc_allocateClassPair( superClass, name, extraBytes );
			_writer.WriteLine( " = {0}", result.Address );

			return result;
		}

		public bool class_addIvar( IntPtr @class, string name, int size, uint alignment, string types )
		{
			_writer.Write( "class_addIvar( {0}, {1}, {2}, {3}, {4} )", @class.ToString( "X8" ), name, size, alignment, types );
			var result = _delegate.class_addIvar( @class, name, size, alignment, types );
			_writer.WriteLine( " = {0}", result );

			return result;
		}

		public unsafe void objc_registerClassPair( RuntimeClass classHandle )
		{
			var @class = ( RuntimeV1Implementation.objc_class* ) ( IntPtr ) classHandle;

			_writer.WriteLine( "objc_registerClassPair( {0} )", classHandle.Address );
			_delegate.objc_registerClassPair( classHandle );
			_writer.WriteLine( classHandle );
		}

		public bool class_addMethod( IntPtr @class, Selector selector, IntPtr implementation, string typeEncoding )
		{
			_writer.Write( "class_addMethod( {0}, {1}, {2}, {3} )", @class.ToString( "X8" ), selector, implementation.ToString( "X8" ), typeEncoding );
			var result = _delegate.class_addMethod( @class, selector, implementation, typeEncoding );
			_writer.WriteLine( " = {0}", result );

			return result;
		}

		public RuntimeProtocol[] class_copyProtocolList( RuntimeClass @class )
		{
			_writer.Write( "class_copyProtocolList( {0} )", @class.Address );
			var result = _delegate.class_copyProtocolList( @class );
			_writer.WriteLine( " = {0}", result.Length );

			return result;
		}

		public RuntimeProtocol[] protocol_copyProtocolList( RuntimeProtocol protocol )
		{
			_writer.Write( "protocol_copyProtocolList( {0} )", protocol.Address );
			var result = _delegate.protocol_copyProtocolList( protocol );
			_writer.WriteLine( " = {0}", result.Length );

			return result;
		}

		public bool class_isMetaClass( RuntimeClass handle )
		{
			_writer.Write( "class_isMetaClass( {0} )", handle.Address );
			var result = _delegate.class_isMetaClass( handle );
			_writer.WriteLine( " = {0}", result );

			return result;
		}

		public uint class_getInstanceSize( RuntimeClass @class )
		{
			_writer.Write( "class_getInstanceSize( {0} )", @class.Address );
			var result = _delegate.class_getInstanceSize( @class );
			_writer.WriteLine( " = {0}", result );

			return result;
		}

		public IntPtr method_getImplementation( RuntimeMethod methodHandle )
		{
			_writer.Write( "class_getInstanceSize( {0} )", methodHandle.Address );
			var result = _delegate.method_getImplementation( methodHandle );
			_writer.WriteLine( " = {0}", result.ToString( "X8" ) );

			return result;
		}

		public RuntimeVariable[] class_copyIvarList( RuntimeClass @class )
		{
			_writer.Write( "class_copyIvarList( {0} )", @class.Address );
			var result = _delegate.class_copyIvarList( @class );
			_writer.WriteLine( " = {0}", result.Length );

			return result;
		}

		public string ivar_getName( RuntimeVariable handle )
		{
			_writer.Write( "ivar_getName( {0} )", handle.Address );
			var result = _delegate.ivar_getName( handle );
			_writer.WriteLine( " = {0}", result );

			return result;
		}

		public string ivar_getTypeEncoding( RuntimeVariable handle )
		{
			_writer.Write( "ivar_getTypeEncoding( {0} )", handle.Address );
			var result = _delegate.ivar_getTypeEncoding( handle );
			_writer.WriteLine( " = {0}", result );

			return result;
		}

		public int ivar_getOffset( RuntimeVariable handle )
		{
			_writer.Write( "ivar_getOffset( {0} )", handle.Address );
			var result = _delegate.ivar_getOffset( handle );
			_writer.WriteLine( " = {0}", result );

			return result;
		}

		public void objc_disposeClassPair( RuntimeClass classHandle )
		{
			_writer.WriteLine( "objc_disposeClassPair( {0} )", classHandle.Address );
			_delegate.objc_disposeClassPair( classHandle );
		}

		public RuntimeVariable class_getClassVariable( RuntimeObject @object, string name )
		{
			_writer.Write( "class_getClassVariable( {0}, {1} )", @object.Address, name );
			var result = _delegate.class_getClassVariable( @object, name );
			_writer.WriteLine( " = {0}", result.Address );

			return result;
		}

		public RuntimeVariable class_getInstanceVariable( RuntimeClass @class, string name )
		{
			_writer.Write( "class_getInstanceVariable( {0}, {1} )", @class.Address, name );
			var result = _delegate.class_getInstanceVariable( @class, name );
			_writer.WriteLine( " = {0}", result.Address );

			return result;
		}

		public RuntimeProtocol objc_getProtocol( string name )
		{
			_writer.Write( "objc_getProtocol( {0} )", name );
			var result = _delegate.objc_getProtocol( name );
			_writer.WriteLine( " = {0}", result.Address );

			return result;
		}

		public RuntimeProtocol[] objc_copyProtocolList()
		{
			_writer.Write( "objc_copyProtocolList()" );
			var result = _delegate.objc_copyProtocolList();
			_writer.WriteLine( " = {0}", result.Length );

			return result;
		}

		public string protocol_getName( RuntimeProtocol protocol )
		{
			_writer.Write( "protocol_getName( {0} )", protocol.Address );
			var result = _delegate.protocol_getName( protocol );
			_writer.WriteLine( " = {0}", result );

			return result;
		}

		public bool class_addProtocol( RuntimeClass @class, RuntimeProtocol protocol )
		{
			_writer.Write( "class_addProtocol( {0}, {1} )", @class.Address, protocol.Address );
			var result = _delegate.class_addProtocol( @class, protocol );
			_writer.WriteLine( " = {0}", result );

			return result;
		}

		#endregion
	}

	internal unsafe sealed class RuntimeV1Implementation : IRuntimeImplementation
	{
#pragma warning disable 649
		public struct objc_method_description
		{
			public Selector name;
			public byte* types;
		}

		public struct objc_method
		{
			public Selector method_name;
			public IntPtr method_types;
			public IntPtr method_imp;
		}

		public struct objc_method_list
		{
			public objc_method_list* nextList;
			public int method_count;

			public objc_method First;
		}

		public struct objc_ivar
		{
			public IntPtr ivar_name;
			public IntPtr ivar_type;
			public int ivar_offset;
		}

		public struct objc_ivar_list
		{
			public int ivar_count;

			public objc_ivar First;
		}

		public struct objc_method_description_list
		{
			public int count;

			public objc_method_description First;
		}

		public struct objc_protocol_list
		{
			public objc_protocol_list* next;
			public int count;

			public objc_protocol* First;
		}

		public struct objc_category
		{
			public IntPtr category_name;
			public IntPtr class_name;
			public objc_method_list* instance_methods;
			public objc_method_list* class_methods;
			public objc_protocol_list* protocols;
		}

		public struct objc_protocol
		{
			public RuntimeClass isa;
			public IntPtr protocol_name;
			public objc_protocol_list* protocol_list;
			public objc_method_description_list* instance_methods;
			public objc_method_description_list* class_methods;
		}

		public struct objc_class
		{
			public objc_class* isa;
			public objc_class* super_class;
			public IntPtr name;
			public int version;
			public ClassInfo info;
			public int instance_size;
			public objc_ivar_list* ivars;
			public objc_method_list** methodLists;
			public IntPtr cache;
			public objc_protocol_list* protocols;
		}

		[Flags]
		public enum ClassInfo
		{
			CLS_NONE = 0x0,
			CLS_CLASS = 0x1,
			CLS_META = 0x2,
			CLS_INITIALIZED = 0x4,
			CLS_POSING = 0x8,
			CLS_MAPPED = 0x10,
			CLS_FLUSH_CACHE = 0x20,
			CLS_GROW_CACHE = 0x40,
			CLS_NEED_BIND = 0x80,
			CLS_METHOD_ARRAY = 0x100,
			CLS_JAVA_HYBRID = 0x200,
			CLS_JAVA_CLASS = 0x400,
			CLS_INITIALIZING = 0x800,
			CLS_FROM_BUNDLE = 0x1000,
			CLS_HAS_CXX_STRUCTORS = 0x2000,
			CLS_NO_METHOD_ARRAY = 0x4000,
			CLS_HAS_LOAD_METHOD = 0x8000,
			CLS_CONSTRUCTING = 0x10000,
			CLS_EXT = 0x20000,
			CLS_FINALIZE_ON_MAIN_THREAD = 0x40000,
			CLS_NO_PROPERTY_ARRAY = 0x80000,
			CLS_CONNECTED = 0x100000,
			CLS_LOADED = 0x200000,
			CLS_CONSTRUCTED = 0x400000,
			CLS_LEAF = 0x800000,
			CLS_UNKNOWN1 = 0x1000000,
			CLS_UNKNOWN2 = 0x2000000,
			CLS_UNKNOWN3 = 0x4000000,
			CLS_UNKNOWN4 = 0x8000000,
		}

#pragma warning restore 649

		#region IRuntimeImplementation Members

		public string class_getName( RuntimeClass classHandle )
		{
			if( classHandle == RuntimeClass.Null )
				return null;

			var @class = ( objc_class* ) ( IntPtr ) classHandle;

			if( @class->name == IntPtr.Zero )
				return null;

			return Marshal.PtrToStringAnsi( @class->name );
		}

		public string class_getImageName( RuntimeClass @class )
		{
			if( @class == RuntimeClass.Null )
				return null;

			Platform.Dl_info info;
			Platform.NativeMethods.dladdr( @class, out info );

			return Marshal.PtrToStringAnsi( info.dli_fname );
		}

		//public RuntimeClass class_getSuperclass( RuntimeClass @class )
		//{
		//    return new RuntimeClass( new IntPtr( ( ( objc_class* ) ( IntPtr ) @class )->super_class ) );
		//}

		private static readonly objc_method_list* MethodListTerminator = ( objc_method_list* ) -1;

		public RuntimeMethod[] class_copyMethodList( RuntimeClass classHandle )
		{
			if( classHandle == RuntimeClass.Null )
				return new RuntimeMethod[0];

			var @class = ( objc_class* ) ( IntPtr ) classHandle;
			var methodsCount = 0;
			var iterator = IntPtr.Zero;

			// I'm using class_nextMethodList instead of direct pointers traverse coz it fixups methods
			var methodList = NativeMethods.class_nextMethodList( classHandle, ref iterator );
			while( methodList != null && methodList != MethodListTerminator )
			{
				methodsCount += methodList->method_count;
				methodList = NativeMethods.class_nextMethodList( classHandle, ref iterator );
			}

			var result = new RuntimeMethod[methodsCount];
			int resultWriteIndex = 0;

			iterator = IntPtr.Zero;
			methodList = NativeMethods.class_nextMethodList( classHandle, ref iterator );
			while( methodList != null && methodList != MethodListTerminator )
			{
				for( int i = 0; i < methodList->method_count; i++ )
					result[resultWriteIndex++] = new RuntimeMethod( new IntPtr( &methodList->First + i ) );

				methodList = NativeMethods.class_nextMethodList( classHandle, ref iterator );
			}

			return result;
		}

		public Selector method_getName( RuntimeMethod methodHandle )
		{
			if( methodHandle == RuntimeMethod.Null )
				return Selector.Null;

			var method = ( objc_method* ) ( IntPtr ) methodHandle;

			if( method == null || method->method_name == Selector.Null )
				return Selector.Null;

			return method->method_name;
		}

		public string method_getTypeEncoding( RuntimeMethod methodHandle )
		{
			if( methodHandle == RuntimeMethod.Null )
				return null;

			return Marshal.PtrToStringAnsi( ( ( objc_method* ) ( IntPtr ) methodHandle )->method_types );
		}

		/// <summary>
		/// There is no properties in 1.0 runtime.
		/// </summary>
		/// <param name="class"></param>
		/// <returns></returns>
		public RuntimeProperty[] class_copyPropertyList( RuntimeClass @class )
		{
			return new RuntimeProperty[0];
		}

		public RuntimeClass object_getClass( IntPtr @object )
		{
			if( @object == IntPtr.Zero )
				return RuntimeClass.Null;

			return new RuntimeClass( ( ( objc_class* ) @object )->isa );
		}

		public RuntimeClass objc_allocateClassPair( RuntimeClass superClassPtr, string name, uint extraBytes )
		{
			if( Runtime.NativeMethods.objc_getClass( name ) != IntPtr.Zero || String.IsNullOrEmpty( name ) )
				return RuntimeClass.Null;

			bool createNewRoot = superClassPtr == IntPtr.Zero;

			// Objective-C runtime 2.0 makes two allocations.
			var superClass = ( objc_class* ) ( IntPtr ) superClassPtr;
			var @class = ( objc_class* ) Marshal.AllocHGlobal( sizeof( objc_class ) + ( int ) extraBytes );
			var metaclass = ( objc_class* ) Marshal.AllocHGlobal( sizeof( objc_class ) + ( int ) extraBytes );

			// to superclass
			@class->super_class = superClass;
			metaclass->super_class = superClass->isa;

			// to metaclass
			@class->isa = metaclass;
			// to root class
			if( createNewRoot )
				metaclass->isa = null;
			else
				metaclass->isa = superClass->isa->isa;

			@class->info = ClassInfo.CLS_CLASS | ClassInfo.CLS_CONSTRUCTING | ClassInfo.CLS_LEAF;
			metaclass->info = ClassInfo.CLS_META | ClassInfo.CLS_CONSTRUCTING | ClassInfo.CLS_LEAF;

			@class->name = Marshal.StringToHGlobalAnsi( name );
			metaclass->name = Marshal.StringToHGlobalAnsi( name );

			if( createNewRoot )
			{
				@class->instance_size = IntPtr.Size;
				metaclass->instance_size = IntPtr.Size;
			}
			else
			{
				@class->instance_size = @class->super_class->instance_size;
				metaclass->instance_size = metaclass->super_class->instance_size;
			}
			@class->cache = metaclass->cache = IntPtr.Zero;
			@class->ivars = metaclass->ivars = null;
			@class->protocols = metaclass->protocols = null;

			@class->version = 0;
			metaclass->version = 6;

			@class->methodLists = metaclass->methodLists = null;

			return new RuntimeClass( @class );
		}

		public bool class_addIvar( IntPtr @class, string name, int size, uint alignment, string types )
		{
			if( @class == IntPtr.Zero || string.IsNullOrEmpty( name ) )
				return false;

			objc_ivar_list* updatedList;
			var classObject = ( objc_class* ) @class;

			if( classObject->ivars != null )
			{
				var newListSize = new IntPtr( sizeof( objc_ivar_list ) + classObject->ivars->ivar_count * sizeof( objc_ivar ) );

				updatedList = ( objc_ivar_list* ) Marshal.ReAllocHGlobal( new IntPtr( classObject->ivars ), newListSize );
				if( updatedList == null )
				{
					updatedList = ( objc_ivar_list* ) Marshal.AllocHGlobal( newListSize );
					NativeMethods.memcpy( updatedList, classObject->ivars, sizeof( objc_ivar_list ) + ( classObject->ivars->ivar_count - 1 ) * sizeof( objc_ivar ) );
					Marshal.FreeHGlobal( new IntPtr( classObject->ivars ) );
				}
			}
			else
			{
				updatedList = ( objc_ivar_list* ) Marshal.AllocHGlobal( sizeof( objc_ivar_list ) );
				updatedList->ivar_count = 0;
			}

			classObject->ivars = updatedList;
			var newIvar = &updatedList->First + updatedList->ivar_count++;

			newIvar->ivar_name = Marshal.StringToHGlobalAnsi( name );
			newIvar->ivar_type = Marshal.StringToHGlobalAnsi( types );

			newIvar->ivar_offset = classObject->instance_size;

			if( alignment > 0 )
				if( ( newIvar->ivar_offset % alignment ) != 0 )
					newIvar->ivar_offset += ( int ) ( alignment - ( newIvar->ivar_offset % alignment ) );

			classObject->instance_size = newIvar->ivar_offset + size;

			return true;
		}

		public bool class_addMethod( IntPtr classPtr, Selector selector, IntPtr implementation, string typeEncoding )
		{
			if( classPtr == IntPtr.Zero || selector == Selector.Null || implementation == IntPtr.Zero || string.IsNullOrEmpty( typeEncoding ) )
				return false;

			var @class = ( objc_class* ) classPtr;

			if( @class->methodLists == null )
			{
				@class->methodLists = ( objc_method_list** ) Marshal.AllocHGlobal( IntPtr.Size * 2 );
				@class->methodLists[0] = ( objc_method_list* ) Marshal.AllocHGlobal( sizeof( objc_method_list ) );
				@class->methodLists[0]->nextList = null;
				@class->methodLists[0]->method_count = 0;
				@class->methodLists[1] = MethodListTerminator;
			}

			for( var listIterator = @class->methodLists; *listIterator != MethodListTerminator; listIterator++ )
				for( var methodCounter = 0; methodCounter < listIterator[0]->method_count; methodCounter++ )
					if( ( &listIterator[0]->First )[methodCounter].method_name == selector )
						return false;

			var newListSize = new IntPtr( sizeof( objc_method_list ) + sizeof( objc_method ) * ( @class->methodLists[0]->method_count + 1 ) );
			var updatedList = ( objc_method_list* ) Marshal.ReAllocHGlobal( new IntPtr( @class->methodLists[0] ), newListSize );
			if( updatedList == null )
			{
				updatedList = ( objc_method_list* ) Marshal.AllocHGlobal( newListSize );
				NativeMethods.memcpy( updatedList, @class->methodLists[0], sizeof( objc_method_list ) + sizeof( objc_method ) * @class->methodLists[0]->method_count );
				Marshal.FreeHGlobal( new IntPtr( @class->methodLists[0] ) );
			}

			@class->methodLists[0] = updatedList;

			var newMethod = &updatedList->First + updatedList->method_count++;

			newMethod->method_name = selector;
			newMethod->method_imp = implementation;
			newMethod->method_types = Marshal.StringToHGlobalAnsi( typeEncoding );

			return true;
		}

		public void objc_registerClassPair( RuntimeClass classHandle )
		{
			if( classHandle == RuntimeClass.Null )
				return;

			var @class = ( objc_class* ) ( IntPtr ) classHandle;

			if( ( @class->info & ClassInfo.CLS_CONSTRUCTED ) != 0 || ( @class->isa->info & ClassInfo.CLS_CONSTRUCTED ) != 0 )
				return;

			if( ( @class->info & ClassInfo.CLS_CONSTRUCTING ) == 0 || ( @class->isa->info & ClassInfo.CLS_CONSTRUCTING ) == 0 )
				return;

			NativeMethods.objc_addClass( classHandle );

			@class->info &= ~ClassInfo.CLS_CONSTRUCTING;
			@class->isa->info &= ~ClassInfo.CLS_CONSTRUCTING;

			@class->info |= ClassInfo.CLS_CONSTRUCTED | ClassInfo.CLS_LEAF;
			@class->isa->info |= ClassInfo.CLS_CONSTRUCTED | ClassInfo.CLS_LEAF;
		}

		public RuntimeProtocol[] class_copyProtocolList( RuntimeClass classPtr )
		{
			return new RuntimeProtocol[0];
		}

		public RuntimeProtocol[] protocol_copyProtocolList( RuntimeProtocol protocol )
		{
			return new RuntimeProtocol[0];
		}

		public bool class_isMetaClass( RuntimeClass classHandle )
		{
			if( classHandle == RuntimeClass.Null )
				return false;

			var @class = ( objc_class* ) ( IntPtr ) classHandle;

			return ( @class->info & ClassInfo.CLS_META ) != 0;
		}

		public uint class_getInstanceSize( RuntimeClass classHandle )
		{
			if( classHandle == RuntimeClass.Null )
				return 0;

			var @class = ( objc_class* ) ( IntPtr ) classHandle;

			return ( uint ) @class->instance_size;
		}

		public IntPtr method_getImplementation( RuntimeMethod methodHandle )
		{
			if( methodHandle == RuntimeMethod.Null )
				return IntPtr.Zero;

			var method = ( objc_method* ) ( IntPtr ) methodHandle;

			return method->method_imp;
		}

		public RuntimeVariable[] class_copyIvarList( RuntimeClass classHandle )
		{
			if( classHandle == RuntimeClass.Null )
				return new RuntimeVariable[0];

			var @class = ( objc_class* ) ( IntPtr ) classHandle;

			if( @class->ivars == null )
				return new RuntimeVariable[0];

			var result = new RuntimeVariable[@class->ivars->ivar_count];
			for( int i = 0; i < @class->ivars->ivar_count; i++ )
				result[i] = new RuntimeVariable( new IntPtr( &@class->ivars->First + i ) );

			return result;
		}

		public string ivar_getName( RuntimeVariable ivarHandle )
		{
			if( ivarHandle == RuntimeVariable.Null )
				return null;

			var ivar = ( objc_ivar* ) ( IntPtr ) ivarHandle;

			return Marshal.PtrToStringAnsi( ivar->ivar_name );
		}

		public string ivar_getTypeEncoding( RuntimeVariable ivarHandle )
		{
			if( ivarHandle == RuntimeVariable.Null )
				return null;

			var ivar = ( objc_ivar* ) ( IntPtr ) ivarHandle;

			return Marshal.PtrToStringAnsi( ivar->ivar_type );
		}

		public int ivar_getOffset( RuntimeVariable ivarHandle )
		{
			if( ivarHandle == RuntimeVariable.Null )
				return 0;

			var ivar = ( objc_ivar* ) ( IntPtr ) ivarHandle;

			return ivar->ivar_offset;
		}

		public void objc_disposeClassPair( RuntimeClass classHandle )
		{
			if( classHandle == RuntimeClass.Null )
				return;

			var @class = ( objc_class* ) ( IntPtr ) classHandle;

			DisposeClass( @class->isa );
			DisposeClass( @class );
		}

		private void DisposeClass( objc_class* @class )
		{
			if( @class == null )
				return;

			var classPtr = new IntPtr( @class );
			var classHandle = new RuntimeClass( classPtr );

			// we should remove only unregistered classes
			if( ( @class->info & ClassInfo.CLS_CONSTRUCTING ) == 0 )
				return;

			var iterator = IntPtr.Zero;
			var methodList = NativeMethods.class_nextMethodList( classHandle, ref iterator );

			while( methodList != null && methodList != MethodListTerminator )
			{
				for( int i = 0; i < methodList->method_count; i++ )
					Marshal.FreeHGlobal( ( &methodList->First + i )->method_types );

				Marshal.FreeHGlobal( new IntPtr( methodList ) );
				methodList = NativeMethods.class_nextMethodList( classHandle, ref iterator );
			}

			if( @class->ivars != null )
			{
				for( int i = 0; i < @class->ivars->ivar_count; i++ )
				{
					Marshal.FreeHGlobal( ( &@class->ivars->First + i )->ivar_name );
					Marshal.FreeHGlobal( ( &@class->ivars->First + i )->ivar_type );
				}
			}

			Marshal.FreeHGlobal( new IntPtr( @class->ivars ) );
			Marshal.FreeHGlobal( new IntPtr( @class->methodLists ) );

			Marshal.FreeHGlobal( @class->name );
			Marshal.FreeHGlobal( classPtr );
		}

		public RuntimeVariable class_getClassVariable( RuntimeObject @object, string name )
		{
			if( @object == RuntimeObject.Null || string.IsNullOrEmpty( name ) )
				return RuntimeVariable.Null;

			return new RuntimeVariable( class_getInstanceVariable( @object.Class, name ) );
		}

		public RuntimeVariable class_getInstanceVariable( RuntimeClass classHandle, string name )
		{
			if( classHandle == RuntimeClass.Null || string.IsNullOrEmpty( name ) )
				return RuntimeVariable.Null;

			var @class = ( objc_class* ) ( IntPtr ) classHandle;

			if( @class->ivars != null )
			{
				for( int i = 0; i < @class->ivars->ivar_count; i++ )
				{
					var currentIvar = &@class->ivars->First + i;

					if( Marshal.PtrToStringAnsi( currentIvar->ivar_name ) == name )
						return new RuntimeVariable( currentIvar );
				}
			}

			return new RuntimeVariable( IntPtr.Zero );
		}

		[MethodImpl( MethodImplOptions.Synchronized )]
		public RuntimeProtocol objc_getProtocol( string name )
		{
			if( string.IsNullOrEmpty( name ) )
				return RuntimeProtocol.Null;

			var imagesCount = Platform.NativeMethods._dyld_image_count();

			for( uint i = 0; i < imagesCount; i++ )
			{
				var header = Platform.NativeMethods._dyld_get_image_header( i );
				var imageSlide = Platform.NativeMethods._dyld_get_image_vmaddr_slide( i );
				var commands = ( Platform.load_command* ) ( header + 1 );

				for( uint j = 0; j < header->ncmds; j++ )
				{
					if( commands->cmd == Platform.LoadCommandType.LC_SEGMENT )
					{
						var segmentCommand = ( Platform.segment_command* ) commands;

						var sections = ( Platform.section* ) ( segmentCommand + 1 );
						for( int k = 0; k < segmentCommand->nsects; k++ )
						{
							if( sections[k].Section == "__protocol" )
							{
								var sectionStart = sections[k].addr + ( uint ) imageSlide.ToInt32();
								var sectionEnd = sections[k].addr + sections[k].size + ( uint ) imageSlide.ToInt32();

								for( var protocolAddress = sectionStart; protocolAddress < sectionEnd; protocolAddress += ( uint ) sizeof( RuntimeV1Implementation.objc_protocol ) )
								{
									var protocolObject = new RuntimeProtocol( new IntPtr( ( int ) protocolAddress ) );

									if( protocolObject.Name == name )
										return protocolObject;
								}
							}
						}
					}

					commands = ( Platform.load_command* ) ( ( ( byte* ) commands ) + commands->cmdsize );
				}
			}

			return RuntimeProtocol.Null;
		}

		[MethodImpl( MethodImplOptions.Synchronized )]
		public RuntimeProtocol[] objc_copyProtocolList()
		{
			var imagesCount = Platform.NativeMethods._dyld_image_count();
			var result = new Dictionary<string, RuntimeProtocol>();

			for( uint i = 0; i < imagesCount; i++ )
			{
				var header = Platform.NativeMethods._dyld_get_image_header( i );
				var imageSlide = Platform.NativeMethods._dyld_get_image_vmaddr_slide( i );
				var commands = ( Platform.load_command* ) ( header + 1 );

				for( uint j = 0; j < header->ncmds; j++ )
				{
					if( commands->cmd == Platform.LoadCommandType.LC_SEGMENT )
					{
						var segmentCommand = ( Platform.segment_command* ) commands;

						var sections = ( Platform.section* ) ( segmentCommand + 1 );
						for( int k = 0; k < segmentCommand->nsects; k++ )
						{
							if( sections[k].Section == "__protocol" )
							{
								var sectionStart = sections[k].addr + ( uint ) imageSlide.ToInt32();
								var sectionEnd = sections[k].addr + sections[k].size + ( uint ) imageSlide.ToInt32();

								for( var protocolAddress = sectionStart; protocolAddress < sectionEnd; protocolAddress += ( uint ) sizeof( RuntimeV1Implementation.objc_protocol ) )
								{
									var protocolObject = new RuntimeProtocol( new IntPtr( ( int ) protocolAddress ) );
									var name = protocolObject.Name;

									if( !result.ContainsKey( name ) )
										result[name] = protocolObject;
								}
							}
						}
					}

					commands = ( Platform.load_command* ) ( ( ( byte* ) commands ) + commands->cmdsize );
				}
			}

			return result.Values.ToArray();
		}

		public string protocol_getName( RuntimeProtocol protocolPtr )
		{
			if( protocolPtr == RuntimeProtocol.Null )
				return null;

			var protocol = ( objc_protocol* ) ( IntPtr ) protocolPtr;

			if( protocol->protocol_name == IntPtr.Zero )
				return null;

			return Marshal.PtrToStringAnsi( protocol->protocol_name );
		}

		public bool class_addProtocol( RuntimeClass @class, RuntimeProtocol protocol )
		{
			if( @class == RuntimeClass.Null || protocol == RuntimeProtocol.Null )
				return false;

			objc_protocol_list* updatedList;
			var classObject = ( objc_class* ) ( IntPtr ) @class;

			if( classObject->protocols != null )
			{
				var newListSize = new IntPtr( sizeof( objc_protocol_list ) + classObject->protocols->count * sizeof( objc_protocol* ) );

				updatedList = ( objc_protocol_list* ) Marshal.ReAllocHGlobal( new IntPtr( classObject->protocols ), newListSize );
				if( updatedList == null )
				{
					updatedList = ( objc_protocol_list* ) Marshal.AllocHGlobal( newListSize );
					NativeMethods.memcpy( updatedList, classObject->protocols, sizeof( objc_protocol_list ) + ( classObject->protocols->count - 1 ) * sizeof( objc_protocol* ) );
					Marshal.FreeHGlobal( new IntPtr( classObject->protocols ) );
				}
			}
			else
			{
				updatedList = ( objc_protocol_list* ) Marshal.AllocHGlobal( sizeof( objc_protocol_list ) );
				updatedList->count = 0;
				updatedList->next = null;
			}

			classObject->protocols = updatedList;
			var newEntry = &updatedList->First + updatedList->count++;
			*newEntry = ( objc_protocol* ) ( IntPtr ) protocol;

			return true;
		}

		#endregion

		private const string RuntimeLibrary = Runtime.RuntimeLibrary;

		private static class NativeMethods
		{
			[DllImport( RuntimeLibrary )]
			public static extern objc_method_list* class_nextMethodList( RuntimeClass @class, ref IntPtr iterator );

			[DllImport( RuntimeLibrary )]
			public static extern void objc_addClass( IntPtr @class );

			[DllImport( "libc.dylib" )]
			public static extern void memcpy( void* destination, void* source, int bytesToCopy );
		}
	}

	internal unsafe sealed class RuntimeV2Implementation : IRuntimeImplementation
	{
		#region IRuntimeImplementation Members

		public unsafe string class_getName( RuntimeClass classHandle )
		{
			return Marshal.PtrToStringAnsi( UnsafeNativeMethods.class_getName( @classHandle ) );
		}

		public string class_getImageName( RuntimeClass @class )
		{
			return Marshal.PtrToStringAnsi( UnsafeNativeMethods.class_getImageName( @class ) );
		}

		//public RuntimeClass class_getSuperclass( RuntimeClass @class )
		//{
		//    return new RuntimeClass( NativeMethods.class_getSuperclass( @class ) );
		//}

		public RuntimeMethod[] class_copyMethodList( RuntimeClass @class )
		{
			uint count;

			using( var scopeGuard = new ScopedMemoryCustodian( NativeMethods.class_copyMethodList( @class, out count ) ) )
			{
				var result = new RuntimeMethod[count];

				for( uint i = 0; i < count; i++ )
					result[i] = new RuntimeMethod( scopeGuard[i] );

				return result;
			}
		}

		public Selector method_getName( RuntimeMethod method )
		{
			return new Selector( NativeMethods.method_getName( method ) );
		}

		public string method_getTypeEncoding( RuntimeMethod method )
		{
			return Marshal.PtrToStringAnsi( UnsafeNativeMethods.method_getTypeEncoding( method ) );
		}

		public RuntimeProperty[] class_copyPropertyList( RuntimeClass @class )
		{
			uint count;

			using( var scopeGuard = new ScopedMemoryCustodian( NativeMethods.class_copyPropertyList( @class, out count ) ) )
			{
				var result = new RuntimeProperty[count];

				for( uint i = 0; i < count; i++ )
					result[i] = new RuntimeProperty( scopeGuard[i] );

				return result;
			}
		}

		public RuntimeClass object_getClass( IntPtr @object )
		{
			return new RuntimeClass( NativeMethods.object_getClass( @object ) );
		}

		public RuntimeClass objc_allocateClassPair( RuntimeClass superclass, string name, uint extraBytes )
		{
			return new RuntimeClass( NativeMethods.objc_allocateClassPair( superclass, name, extraBytes ) );
		}

		public bool class_addIvar( IntPtr @class, string name, int size, uint alignment, string types )
		{
			return NativeMethods.class_addIvar( @class, name, size, alignment, types );
		}

		public void objc_registerClassPair( RuntimeClass @class )
		{
			NativeMethods.objc_registerClassPair( @class );
		}

		public bool class_addMethod( IntPtr classPtr, Selector selector, IntPtr implementation, string typeEncoding )
		{
			return NativeMethods.class_addMethod( @classPtr, selector, implementation, typeEncoding );
		}

		public RuntimeProtocol[] class_copyProtocolList( RuntimeClass @class )
		{
			uint count;

			using( var scopeGuard = new ScopedMemoryCustodian( NativeMethods.class_copyProtocolList( @class, out count ) ) )
			{
				var result = new RuntimeProtocol[count];

				for( uint i = 0; i < count; i++ )
					result[i] = new RuntimeProtocol( scopeGuard[i] );

				return result;
			}
		}

		public RuntimeProtocol[] protocol_copyProtocolList( RuntimeProtocol protocol )
		{
			uint count;

			using( var scopeGuard = new ScopedMemoryCustodian( NativeMethods.protocol_copyProtocolList( protocol, out count ) ) )
			{
				var result = new RuntimeProtocol[count];

				for( uint i = 0; i < count; i++ )
					result[i] = new RuntimeProtocol( scopeGuard[i] );

				return result;
			}
		}

		public bool class_isMetaClass( RuntimeClass @class )
		{
			return NativeMethods.class_isMetaClass( @class );
		}

		public uint class_getInstanceSize( RuntimeClass @class )
		{
			return NativeMethods.class_getInstanceSize( @class );
		}

		public IntPtr method_getImplementation( RuntimeMethod methodHandle )
		{
			return NativeMethods.method_getImplementation( methodHandle );
		}

		public RuntimeVariable[] class_copyIvarList( RuntimeClass @class )
		{
			int count;

			using( var scopeGuard = new ScopedMemoryCustodian( NativeMethods.class_copyIvarList( @class, out count ) ) )
			{
				var result = new RuntimeVariable[count];

				for( uint i = 0; i < count; i++ )
					result[i] = new RuntimeVariable( scopeGuard[i] );

				return result;
			}
		}

		public string ivar_getName( RuntimeVariable handle )
		{
			return Marshal.PtrToStringAnsi( UnsafeNativeMethods.ivar_getName( handle ) );
		}

		public string ivar_getTypeEncoding( RuntimeVariable handle )
		{
			return Marshal.PtrToStringAnsi( UnsafeNativeMethods.ivar_getTypeEncoding( handle ) );
		}

		public int ivar_getOffset( RuntimeVariable handle )
		{
			return NativeMethods.ivar_getOffset( handle );
		}

		public void objc_disposeClassPair( RuntimeClass @class )
		{
			NativeMethods.objc_disposeClassPair( @class );
		}

		public RuntimeVariable class_getClassVariable( RuntimeObject @object, string name )
		{
			return new RuntimeVariable( NativeMethods.class_getClassVariable( @object, name ) );
		}

		public RuntimeVariable class_getInstanceVariable( RuntimeClass @class, string name )
		{
			return new RuntimeVariable( NativeMethods.class_getInstanceVariable( @class, name ) );
		}

		public RuntimeProtocol objc_getProtocol( string name )
		{
			return new RuntimeProtocol( NativeMethods.objc_getProtocol( name ) );
		}

		public RuntimeProtocol[] objc_copyProtocolList()
		{
			uint count;

			using( var scopeGuard = new ScopedMemoryCustodian( NativeMethods.objc_copyProtocolList( out count ) ) )
			{
				var result = new RuntimeProtocol[count];

				for( uint i = 0; i < count; i++ )
					result[i] = new RuntimeProtocol( scopeGuard[i] );

				return result;
			}
		}

		public string protocol_getName( RuntimeProtocol protocol )
		{
			return Marshal.PtrToStringAnsi( UnsafeNativeMethods.protocol_getName( protocol ) );
		}

		public bool class_addProtocol( RuntimeClass @class, RuntimeProtocol protocol )
		{
			return NativeMethods.class_addProtocol( @class, protocol );
		}

		#endregion

		private const string RuntimeLibrary = Runtime.RuntimeLibrary;

		private static class NativeMethods
		{
			//[DllImport( RuntimeLibrary )]
			//internal static extern IntPtr class_getSuperclass( IntPtr @class );

			[DllImport( RuntimeLibrary )]
			internal static extern IntPtr class_copyMethodList( RuntimeClass @class, out uint count );

			[DllImport( RuntimeLibrary )]
			internal static extern IntPtr method_getName( RuntimeMethod method );

			[DllImport( RuntimeLibrary )]
			public static extern IntPtr class_copyPropertyList( RuntimeClass @class, out uint count );

			[DllImport( RuntimeLibrary )]
			internal static extern IntPtr object_getClass( IntPtr @object );

			[DllImport( RuntimeLibrary )]
			internal static extern IntPtr objc_allocateClassPair( IntPtr superclass, string name, uint extraBytes );

			[DllImport( RuntimeLibrary )]
			internal static extern bool class_addIvar( IntPtr @class, string name, int size, uint alignment, string types );

			[DllImport( RuntimeLibrary )]
			internal static extern void objc_registerClassPair( IntPtr @class );

			[DllImport( RuntimeLibrary )]
			internal static extern bool class_addMethod( IntPtr @class, IntPtr selector, IntPtr implementation, string typeEncoding );

			[DllImport( RuntimeLibrary )]
			public static extern IntPtr class_copyProtocolList( RuntimeClass @class, out uint count );

			[DllImport( RuntimeLibrary )]
			public static extern IntPtr protocol_copyProtocolList( RuntimeProtocol protocol, out uint count );

			[DllImport( RuntimeLibrary )]
			internal static extern bool class_isMetaClass( RuntimeClass handle );

			[DllImport( RuntimeLibrary )]
			internal static extern uint class_getInstanceSize( RuntimeClass @class );

			[DllImport( RuntimeLibrary )]
			internal static extern IntPtr method_getImplementation( RuntimeMethod method );

			[DllImport( RuntimeLibrary )]
			internal static extern IntPtr class_copyIvarList( RuntimeClass @class, out int count );

			[DllImport( RuntimeLibrary )]
			internal static extern int ivar_getOffset( RuntimeVariable handle );

			[DllImport( RuntimeLibrary )]
			internal static extern void objc_disposeClassPair( RuntimeClass @class );

			[DllImport( RuntimeLibrary )]
			internal static extern IntPtr class_getClassVariable( RuntimeObject @object, string name );

			[DllImport( RuntimeLibrary )]
			internal static extern IntPtr class_getInstanceVariable( RuntimeClass @class, string name );

			[DllImport( RuntimeLibrary )]
			public static extern IntPtr objc_getProtocol( string name );

			[DllImport( RuntimeLibrary )]
			internal static extern IntPtr objc_copyProtocolList( out uint outCount );

			[DllImport( RuntimeLibrary )]
			internal static extern bool class_addProtocol( RuntimeClass @class, RuntimeProtocol protocol );
		}

		private static class UnsafeNativeMethods
		{
			[DllImport( RuntimeLibrary )]
			internal static extern IntPtr class_getName( RuntimeClass @class );

			[DllImport( RuntimeLibrary )]
			internal static extern IntPtr class_getImageName( RuntimeClass @class );

			[DllImport( RuntimeLibrary )]
			public static extern IntPtr method_getTypeEncoding( RuntimeMethod method );

			[DllImport( RuntimeLibrary )]
			public static extern IntPtr ivar_getName( RuntimeVariable variable );

			[DllImport( RuntimeLibrary )]
			public static extern IntPtr ivar_getTypeEncoding( RuntimeVariable variable );

			[DllImport( RuntimeLibrary )]
			public static extern IntPtr protocol_getName( RuntimeProtocol protocol );
		}
	}
}
