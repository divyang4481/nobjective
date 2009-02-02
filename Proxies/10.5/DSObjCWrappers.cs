//
// Copyright (C) 2009 Eugeny Grishul
//
// See license in License.txt
//

namespace NObjective.Proxies {
	using System;
	using System.Runtime.InteropServices;
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DSoAttributeUtils : IEquatable<DSoAttributeUtils> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DSObjCWrappersCachedClasses.DSoAttributeUtils;
		public static implicit operator IntPtr( DSoAttributeUtils value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DSoAttributeUtils value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DSoAttributeUtils ) ) return false; 
			return Handle == ( ( DSoAttributeUtils )value ).Handle;
		}
		public bool Equals( DSoAttributeUtils value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DSoAttributeUtils value1, DSoAttributeUtils value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DSoAttributeUtils value1, DSoAttributeUtils value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DSoAttributeUtils( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DSoAttributeUtils alloc() {
			return new DSoAttributeUtils( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject getAttributesAndValuesInNode_fromBuffer_listReference_count_( NObjective.RuntimeObject node, NObjective.RuntimeObject fromBuffer, uint listReference, uint count ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getAttributesAndValuesInNode_fromBuffer_listReference_count_( ClassHandle, CachedSelectors.getAttributesAndValuesInNode_fromBuffer_listReference_count_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( uint ) + sizeof( uint ), node, fromBuffer, listReference, count );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject getAttributesAndValuesInNode_fromBuffer_listReference_count_allowBinary_( NObjective.RuntimeObject node, NObjective.RuntimeObject fromBuffer, uint listReference, uint count, char allowBinary ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getAttributesAndValuesInNode_fromBuffer_listReference_count_allowBinary_( ClassHandle, CachedSelectors.getAttributesAndValuesInNode_fromBuffer_listReference_count_allowBinary_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( uint ) + sizeof( uint ) + sizeof( char ), node, fromBuffer, listReference, count, allowBinary );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject getAttributesInNode_fromBuffer_listReference_count_( NObjective.RuntimeObject node, NObjective.RuntimeObject fromBuffer, uint listReference, uint count ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getAttributesInNode_fromBuffer_listReference_count_( ClassHandle, CachedSelectors.getAttributesInNode_fromBuffer_listReference_count_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( uint ) + sizeof( uint ), node, fromBuffer, listReference, count );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static NObjective.RuntimeObject getAttributesInNode_fromBuffer_listReference_count_allowBinary_( NObjective.RuntimeObject node, NObjective.RuntimeObject fromBuffer, uint listReference, uint count, char allowBinary ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getAttributesInNode_fromBuffer_listReference_count_allowBinary_( ClassHandle, CachedSelectors.getAttributesInNode_fromBuffer_listReference_count_allowBinary_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( uint ) + sizeof( uint ) + sizeof( char ), node, fromBuffer, listReference, count, allowBinary );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr getAttributesAndValuesInNode_fromBuffer_listReference_count_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject node, NObjective.RuntimeObject fromBuffer, uint listReference, uint count );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr getAttributesAndValuesInNode_fromBuffer_listReference_count_allowBinary_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject node, NObjective.RuntimeObject fromBuffer, uint listReference, uint count, char allowBinary );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr getAttributesInNode_fromBuffer_listReference_count_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject node, NObjective.RuntimeObject fromBuffer, uint listReference, uint count );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr getAttributesInNode_fromBuffer_listReference_count_allowBinary_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject node, NObjective.RuntimeObject fromBuffer, uint listReference, uint count, char allowBinary );
		}
		static internal class CachedSelectors {
			public static readonly Selector getAttributesAndValuesInNode_fromBuffer_listReference_count_ = "getAttributesAndValuesInNode:fromBuffer:listReference:count:";
			public static readonly Selector getAttributesAndValuesInNode_fromBuffer_listReference_count_allowBinary_ = "getAttributesAndValuesInNode:fromBuffer:listReference:count:allowBinary:";
			public static readonly Selector getAttributesInNode_fromBuffer_listReference_count_ = "getAttributesInNode:fromBuffer:listReference:count:";
			public static readonly Selector getAttributesInNode_fromBuffer_listReference_count_allowBinary_ = "getAttributesInNode:fromBuffer:listReference:count:allowBinary:";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DSoBuffer : IEquatable<DSoBuffer> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DSObjCWrappersCachedClasses.DSoBuffer;
		public static implicit operator IntPtr( DSoBuffer value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DSoBuffer value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DSoBuffer ) ) return false; 
			return Handle == ( ( DSoBuffer )value ).Handle;
		}
		public bool Equals( DSoBuffer value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DSoBuffer value1, DSoBuffer value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DSoBuffer value1, DSoBuffer value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DSoBuffer( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DSoBuffer alloc() {
			return new DSoBuffer( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void appendData_length_( System.IntPtr data, uint length ) {
			RuntimeObject ___occuredException;
			NativeMethods.appendData_length_( Handle, CachedSelectors.appendData_length_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( uint ), data, length );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public uint getBufferSize() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getBufferSize( Handle, CachedSelectors.getBufferSize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public uint getDataLength() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getDataLength( Handle, CachedSelectors.getDataLength, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public NObjective.RuntimeObject initWithDir_( NObjective.RuntimeObject dir ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithDir_( Handle, CachedSelectors.initWithDir_, out ___occuredException, sizeof( NObjective.RuntimeObject ), dir );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithDir_bufferSize_( NObjective.RuntimeObject dir, uint bufferSize ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithDir_bufferSize_( Handle, CachedSelectors.initWithDir_bufferSize_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ), dir, bufferSize );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setData_length_( System.IntPtr data, uint length ) {
			RuntimeObject ___occuredException;
			NativeMethods.setData_length_( Handle, CachedSelectors.setData_length_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( uint ), data, length );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setDataLength_( uint length ) {
			RuntimeObject ___occuredException;
			NativeMethods.setDataLength_( Handle, CachedSelectors.setDataLength_, out ___occuredException, sizeof( uint ), length );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void appendData_length_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr data, uint length );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint getBufferSize( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint getDataLength( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithDir_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dir );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithDir_bufferSize_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dir, uint bufferSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setData_length_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr data, uint length );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setDataLength_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint length );
		}
		static internal class CachedSelectors {
			public static readonly Selector appendData_length_ = "appendData:length:";
			public static readonly Selector getBufferSize = "getBufferSize";
			public static readonly Selector getDataLength = "getDataLength";
			public static readonly Selector initWithDir_ = "initWithDir:";
			public static readonly Selector initWithDir_bufferSize_ = "initWithDir:bufferSize:";
			public static readonly Selector setData_length_ = "setData:length:";
			public static readonly Selector setDataLength_ = "setDataLength:";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DSoDataList : IEquatable<DSoDataList> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DSObjCWrappersCachedClasses.DSoDataList;
		public static implicit operator IntPtr( DSoDataList value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DSoDataList value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DSoDataList ) ) return false; 
			return Handle == ( ( DSoDataList )value ).Handle;
		}
		public bool Equals( DSoDataList value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DSoDataList value1, DSoDataList value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DSoDataList value1, DSoDataList value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DSoDataList( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DSoDataList alloc() {
			return new DSoDataList( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void append_( NObjective.RuntimeObject append ) {
			RuntimeObject ___occuredException;
			NativeMethods.append_( Handle, CachedSelectors.append_, out ___occuredException, sizeof( NObjective.RuntimeObject ), append );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public uint getCount() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getCount( Handle, CachedSelectors.getCount, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public uint getDataLength() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getDataLength( Handle, CachedSelectors.getDataLength, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public NObjective.RuntimeObject initWithDataList_( NObjective.RuntimeObject list ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithDataList_( Handle, CachedSelectors.initWithDataList_, out ___occuredException, sizeof( NObjective.RuntimeObject ), list );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithDir_cString_( NObjective.RuntimeObject dir, System.IntPtr cString ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithDir_cString_( Handle, CachedSelectors.initWithDir_cString_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), dir, cString );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithDir_cStrings_( NObjective.RuntimeObject dir, System.IntPtr cStrings ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithDir_cStrings_( Handle, CachedSelectors.initWithDir_cStrings_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), dir, cStrings );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithDir_separator_pattern_( NObjective.RuntimeObject dir, char separator, NObjective.RuntimeObject pattern ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithDir_separator_pattern_( Handle, CachedSelectors.initWithDir_separator_pattern_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( char ) + sizeof( NObjective.RuntimeObject ), dir, separator, pattern );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithDir_string_( NObjective.RuntimeObject dir, NObjective.RuntimeObject @string ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithDir_string_( Handle, CachedSelectors.initWithDir_string_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), dir, @string );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithDir_strings_( NObjective.RuntimeObject dir, NObjective.RuntimeObject strings ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithDir_strings_( Handle, CachedSelectors.initWithDir_strings_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), dir, strings );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithDir_value_( NObjective.RuntimeObject dir, NObjective.RuntimeObject value ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithDir_value_( Handle, CachedSelectors.initWithDir_value_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), dir, value );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithDir_values_( NObjective.RuntimeObject dir, NObjective.RuntimeObject values ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithDir_values_( Handle, CachedSelectors.initWithDir_values_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), dir, values );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject objectAtIndex_( uint index ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.objectAtIndex_( Handle, CachedSelectors.objectAtIndex_, out ___occuredException, sizeof( uint ), index );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void append_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject append );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint getCount( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint getDataLength( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithDataList_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject list );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithDir_cString_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dir, System.IntPtr cString );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithDir_cStrings_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dir, System.IntPtr cStrings );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithDir_separator_pattern_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dir, char separator, NObjective.RuntimeObject pattern );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithDir_string_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dir, NObjective.RuntimeObject @string );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithDir_strings_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dir, NObjective.RuntimeObject strings );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithDir_value_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dir, NObjective.RuntimeObject value );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithDir_values_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dir, NObjective.RuntimeObject values );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr objectAtIndex_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint index );
		}
		static internal class CachedSelectors {
			public static readonly Selector append_ = "append:";
			public static readonly Selector getCount = "getCount";
			public static readonly Selector getDataLength = "getDataLength";
			public static readonly Selector initWithDataList_ = "initWithDataList:";
			public static readonly Selector initWithDir_cString_ = "initWithDir:cString:";
			public static readonly Selector initWithDir_cStrings_ = "initWithDir:cStrings:";
			public static readonly Selector initWithDir_separator_pattern_ = "initWithDir:separator:pattern:";
			public static readonly Selector initWithDir_string_ = "initWithDir:string:";
			public static readonly Selector initWithDir_strings_ = "initWithDir:strings:";
			public static readonly Selector initWithDir_value_ = "initWithDir:value:";
			public static readonly Selector initWithDir_values_ = "initWithDir:values:";
			public static readonly Selector objectAtIndex_ = "objectAtIndex:";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DSoDataNode : IEquatable<DSoDataNode> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DSObjCWrappersCachedClasses.DSoDataNode;
		public static implicit operator IntPtr( DSoDataNode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DSoDataNode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DSoDataNode ) ) return false; 
			return Handle == ( ( DSoDataNode )value ).Handle;
		}
		public bool Equals( DSoDataNode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DSoDataNode value1, DSoDataNode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DSoDataNode value1, DSoDataNode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DSoDataNode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DSoDataNode alloc() {
			return new DSoDataNode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public uint getBufferSize() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getBufferSize( Handle, CachedSelectors.getBufferSize, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public uint getDataLength() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getDataLength( Handle, CachedSelectors.getDataLength, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public NObjective.RuntimeObject initWithDir_bufferSize_dataLength_data_( NObjective.RuntimeObject dir, uint bufferSize, uint dataLength, System.IntPtr data ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithDir_bufferSize_dataLength_data_( Handle, CachedSelectors.initWithDir_bufferSize_dataLength_data_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ) + sizeof( uint ) + sizeof( System.IntPtr ), dir, bufferSize, dataLength, data );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithDir_cString_( NObjective.RuntimeObject dir, System.IntPtr cString ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithDir_cString_( Handle, CachedSelectors.initWithDir_cString_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), dir, cString );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithDir_string_( NObjective.RuntimeObject dir, NObjective.RuntimeObject @string ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithDir_string_( Handle, CachedSelectors.initWithDir_string_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), dir, @string );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithDir_value_( NObjective.RuntimeObject dir, NObjective.RuntimeObject value ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithDir_value_( Handle, CachedSelectors.initWithDir_value_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), dir, value );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setDataLength_( uint length ) {
			RuntimeObject ___occuredException;
			NativeMethods.setDataLength_( Handle, CachedSelectors.setDataLength_, out ___occuredException, sizeof( uint ), length );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint getBufferSize( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint getDataLength( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithDir_bufferSize_dataLength_data_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dir, uint bufferSize, uint dataLength, System.IntPtr data );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithDir_cString_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dir, System.IntPtr cString );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithDir_string_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dir, NObjective.RuntimeObject @string );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithDir_value_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dir, NObjective.RuntimeObject value );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setDataLength_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, uint length );
		}
		static internal class CachedSelectors {
			public static readonly Selector getBufferSize = "getBufferSize";
			public static readonly Selector getDataLength = "getDataLength";
			public static readonly Selector initWithDir_bufferSize_dataLength_data_ = "initWithDir:bufferSize:dataLength:data:";
			public static readonly Selector initWithDir_cString_ = "initWithDir:cString:";
			public static readonly Selector initWithDir_string_ = "initWithDir:string:";
			public static readonly Selector initWithDir_value_ = "initWithDir:value:";
			public static readonly Selector setDataLength_ = "setDataLength:";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DSoDirectory : IEquatable<DSoDirectory> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DSObjCWrappersCachedClasses.DSoDirectory;
		public static implicit operator IntPtr( DSoDirectory value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DSoDirectory value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DSoDirectory ) ) return false; 
			return Handle == ( ( DSoDirectory )value ).Handle;
		}
		public bool Equals( DSoDirectory value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DSoDirectory value1, DSoDirectory value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DSoDirectory value1, DSoDirectory value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DSoDirectory( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DSoDirectory alloc() {
			return new DSoDirectory( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void close() {
			RuntimeObject ___occuredException;
			NativeMethods.close( Handle, CachedSelectors.close, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject configNode() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.configNode( Handle, CachedSelectors.configNode, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public uint dsDirRef() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dsDirRef( Handle, CachedSelectors.dsDirRef, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public NObjective.RuntimeObject findNode_( NObjective.RuntimeObject node ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.findNode_( Handle, CachedSelectors.findNode_, out ___occuredException, sizeof( NObjective.RuntimeObject ), node );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject findNode_matchType_( NObjective.RuntimeObject node, int matchType ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.findNode_matchType_( Handle, CachedSelectors.findNode_matchType_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( int ), node, matchType );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject findNode_matchType_useFirst_( NObjective.RuntimeObject node, int matchType, char useFirst ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.findNode_matchType_useFirst_( Handle, CachedSelectors.findNode_matchType_useFirst_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( int ) + sizeof( char ), node, matchType, useFirst );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject findNodeNames() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.findNodeNames( Handle, CachedSelectors.findNodeNames, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject findNodeNames_matchType_( NObjective.RuntimeObject names, int matchType ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.findNodeNames_matchType_( Handle, CachedSelectors.findNodeNames_matchType_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( int ), names, matchType );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject findNodeViaEnum_( int @enum ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.findNodeViaEnum_( Handle, CachedSelectors.findNodeViaEnum_, out ___occuredException, sizeof( int ), @enum );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithHost_user_password_( NObjective.RuntimeObject host, NObjective.RuntimeObject user, NObjective.RuntimeObject password ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithHost_user_password_( Handle, CachedSelectors.initWithHost_user_password_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), host, user, password );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithLocal() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithLocal( Handle, CachedSelectors.initWithLocal, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithLocalPath_( NObjective.RuntimeObject path ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithLocalPath_( Handle, CachedSelectors.initWithLocalPath_, out ___occuredException, sizeof( NObjective.RuntimeObject ), path );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject localNode() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.localNode( Handle, CachedSelectors.localNode, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject nodeBrowserItems() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.nodeBrowserItems( Handle, CachedSelectors.nodeBrowserItems, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public uint nodeCount() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.nodeCount( Handle, CachedSelectors.nodeCount, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public void openHost_user_password_( NObjective.RuntimeObject host, NObjective.RuntimeObject user, NObjective.RuntimeObject password ) {
			RuntimeObject ___occuredException;
			NativeMethods.openHost_user_password_( Handle, CachedSelectors.openHost_user_password_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), host, user, password );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void openLocalHost() {
			RuntimeObject ___occuredException;
			NativeMethods.openLocalHost( Handle, CachedSelectors.openLocalHost, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void openLocalOnlyWithLocalPath_( NObjective.RuntimeObject path ) {
			RuntimeObject ___occuredException;
			NativeMethods.openLocalOnlyWithLocalPath_( Handle, CachedSelectors.openLocalOnlyWithLocalPath_, out ___occuredException, sizeof( NObjective.RuntimeObject ), path );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void reopen() {
			RuntimeObject ___occuredException;
			NativeMethods.reopen( Handle, CachedSelectors.reopen, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject searchNode() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.searchNode( Handle, CachedSelectors.searchNode, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject standardAttributeTypes() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.standardAttributeTypes( Handle, CachedSelectors.standardAttributeTypes, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject standardRecordTypes() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.standardRecordTypes( Handle, CachedSelectors.standardRecordTypes, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public uint verifiedDirRef() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.verifiedDirRef( Handle, CachedSelectors.verifiedDirRef, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void close( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr configNode( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint dsDirRef( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr findNode_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject node );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr findNode_matchType_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject node, int matchType );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr findNode_matchType_useFirst_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject node, int matchType, char useFirst );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr findNodeNames( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr findNodeNames_matchType_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject names, int matchType );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr findNodeViaEnum_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int @enum );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithHost_user_password_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject host, NObjective.RuntimeObject user, NObjective.RuntimeObject password );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithLocal( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithLocalPath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject path );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr localNode( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr nodeBrowserItems( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint nodeCount( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void openHost_user_password_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject host, NObjective.RuntimeObject user, NObjective.RuntimeObject password );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void openLocalHost( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void openLocalOnlyWithLocalPath_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject path );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void reopen( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr searchNode( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr standardAttributeTypes( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr standardRecordTypes( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint verifiedDirRef( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector close = "close";
			public static readonly Selector configNode = "configNode";
			public static readonly Selector dsDirRef = "dsDirRef";
			public static readonly Selector findNode_ = "findNode:";
			public static readonly Selector findNode_matchType_ = "findNode:matchType:";
			public static readonly Selector findNode_matchType_useFirst_ = "findNode:matchType:useFirst:";
			public static readonly Selector findNodeNames = "findNodeNames";
			public static readonly Selector findNodeNames_matchType_ = "findNodeNames:matchType:";
			public static readonly Selector findNodeViaEnum_ = "findNodeViaEnum:";
			public static readonly Selector initWithHost_user_password_ = "initWithHost:user:password:";
			public static readonly Selector initWithLocal = "initWithLocal";
			public static readonly Selector initWithLocalPath_ = "initWithLocalPath:";
			public static readonly Selector localNode = "localNode";
			public static readonly Selector nodeBrowserItems = "nodeBrowserItems";
			public static readonly Selector nodeCount = "nodeCount";
			public static readonly Selector openHost_user_password_ = "openHost:user:password:";
			public static readonly Selector openLocalHost = "openLocalHost";
			public static readonly Selector openLocalOnlyWithLocalPath_ = "openLocalOnlyWithLocalPath:";
			public static readonly Selector reopen = "reopen";
			public static readonly Selector searchNode = "searchNode";
			public static readonly Selector standardAttributeTypes = "standardAttributeTypes";
			public static readonly Selector standardRecordTypes = "standardRecordTypes";
			public static readonly Selector verifiedDirRef = "verifiedDirRef";
		}
	}
	[ProxyBaseClass(typeof( NSException ))]
	public struct DSoException : IEquatable<DSoException> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DSObjCWrappersCachedClasses.DSoException;
		public static implicit operator IntPtr( DSoException value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DSoException value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DSoException ) ) return false; 
			return Handle == ( ( DSoException )value ).Handle;
		}
		public bool Equals( DSoException value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DSoException value1, DSoException value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DSoException value1, DSoException value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DSoException( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DSoException alloc() {
			return new DSoException( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject name_reason_status_( NObjective.RuntimeObject name, NObjective.RuntimeObject reason, int status ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.name_reason_status_( ClassHandle, CachedSelectors.name_reason_status_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( int ), name, reason, status );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public static void raiseWithStatus_( int status ) {
			RuntimeObject ___occuredException;
			NativeMethods.raiseWithStatus_( ClassHandle, CachedSelectors.raiseWithStatus_, out ___occuredException, sizeof( int ), status );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public int status() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.status( Handle, CachedSelectors.status, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public System.IntPtr statusCString() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.statusCString( Handle, CachedSelectors.statusCString, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject statusString() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.statusString( Handle, CachedSelectors.statusString, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr name_reason_status_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name, NObjective.RuntimeObject reason, int status );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void raiseWithStatus_( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int status );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern int status( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern System.IntPtr statusCString( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr statusString( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector name_reason_status_ = "name:reason:status:";
			public static readonly Selector raiseWithStatus_ = "raiseWithStatus:";
			public static readonly Selector status = "status";
			public static readonly Selector statusCString = "statusCString";
			public static readonly Selector statusString = "statusString";
		}
	}
	[ProxyBaseClass(typeof( DSoRecord ))]
	public struct DSoGroup : IEquatable<DSoGroup> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DSObjCWrappersCachedClasses.DSoGroup;
		public static implicit operator IntPtr( DSoGroup value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DSoGroup value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DSoGroup ) ) return false; 
			return Handle == ( ( DSoGroup )value ).Handle;
		}
		public bool Equals( DSoGroup value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DSoGroup value1, DSoGroup value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DSoGroup value1, DSoGroup value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DSoGroup( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DSoGroup alloc() {
			return new DSoGroup( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public uint getGid() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getGid( Handle, CachedSelectors.getGid, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public NObjective.RuntimeObject initInNode_name_( NObjective.RuntimeObject node, NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initInNode_name_( Handle, CachedSelectors.initInNode_name_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), node, name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public bool isMember_( NObjective.RuntimeObject member ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isMember_( Handle, CachedSelectors.isMember_, out ___occuredException, sizeof( NObjective.RuntimeObject ), member );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint getGid( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initInNode_name_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject node, NObjective.RuntimeObject name );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool isMember_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject member );
		}
		static internal class CachedSelectors {
			public static readonly Selector getGid = "getGid";
			public static readonly Selector initInNode_name_ = "initInNode:name:";
			public static readonly Selector isMember_ = "isMember:";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DSoNode : IEquatable<DSoNode> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DSObjCWrappersCachedClasses.DSoNode;
		public static implicit operator IntPtr( DSoNode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DSoNode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DSoNode ) ) return false; 
			return Handle == ( ( DSoNode )value ).Handle;
		}
		public bool Equals( DSoNode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DSoNode value1, DSoNode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DSoNode value1, DSoNode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DSoNode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DSoNode alloc() {
			return new DSoNode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject adminGroup() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.adminGroup( Handle, CachedSelectors.adminGroup, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public int authenticateName_withPassword_( NObjective.RuntimeObject name, NObjective.RuntimeObject withPassword ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.authenticateName_withPassword_( Handle, CachedSelectors.authenticateName_withPassword_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), name, withPassword );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public int authenticateName_withPassword_authOnly_( NObjective.RuntimeObject name, NObjective.RuntimeObject withPassword, char authOnly ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.authenticateName_withPassword_authOnly_( Handle, CachedSelectors.authenticateName_withPassword_authOnly_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( char ), name, withPassword, authOnly );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public int authenticateWithBufferItems_authType_authOnly_( NObjective.RuntimeObject items, System.IntPtr authType, char authOnly ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.authenticateWithBufferItems_authType_authOnly_( Handle, CachedSelectors.authenticateWithBufferItems_authType_authOnly_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( char ), items, authType, authOnly );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public int authenticateWithBufferItems_authType_authOnly_responseBufferItems_( NObjective.RuntimeObject items, System.IntPtr authType, char authOnly, System.IntPtr responseBufferItems ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.authenticateWithBufferItems_authType_authOnly_responseBufferItems_( Handle, CachedSelectors.authenticateWithBufferItems_authType_authOnly_responseBufferItems_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( char ) + sizeof( System.IntPtr ), items, authType, authOnly, responseBufferItems );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public int customCall_inputData_outputData_( int call, NObjective.RuntimeObject inputData, NObjective.RuntimeObject outputData ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.customCall_inputData_outputData_( Handle, CachedSelectors.customCall_inputData_outputData_, out ___occuredException, sizeof( int ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), call, inputData, outputData );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public int customCall_receiveData_withAuthorization_sizeCall_( int call, NObjective.RuntimeObject receiveData, System.IntPtr withAuthorization, int sizeCall ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.customCall_receiveData_withAuthorization_sizeCall_( Handle, CachedSelectors.customCall_receiveData_withAuthorization_sizeCall_, out ___occuredException, sizeof( int ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( int ), call, receiveData, withAuthorization, sizeCall );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public int customCall_sendData_withAuthorization_( int call, NObjective.RuntimeObject sendData, System.IntPtr withAuthorization ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.customCall_sendData_withAuthorization_( Handle, CachedSelectors.customCall_sendData_withAuthorization_, out ___occuredException, sizeof( int ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), call, sendData, withAuthorization );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public int customCall_sendItems_outputData_( int call, NObjective.RuntimeObject sendItems, NObjective.RuntimeObject outputData ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.customCall_sendItems_outputData_( Handle, CachedSelectors.customCall_sendItems_outputData_, out ___occuredException, sizeof( int ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), call, sendItems, outputData );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public int customCall_sendPropertyList_withAuthorization_( int call, NObjective.RuntimeObject sendPropertyList, System.IntPtr withAuthorization ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.customCall_sendPropertyList_withAuthorization_( Handle, CachedSelectors.customCall_sendPropertyList_withAuthorization_, out ___occuredException, sizeof( int ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), call, sendPropertyList, withAuthorization );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public int customCall_withAuthorization_( int call, System.IntPtr withAuthorization ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.customCall_withAuthorization_( Handle, CachedSelectors.customCall_withAuthorization_, out ___occuredException, sizeof( int ) + sizeof( System.IntPtr ), call, withAuthorization );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject directory() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.directory( Handle, CachedSelectors.directory, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public uint dsNodeReference() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dsNodeReference( Handle, CachedSelectors.dsNodeReference, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public NObjective.RuntimeObject findGroup_( NObjective.RuntimeObject @group ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.findGroup_( Handle, CachedSelectors.findGroup_, out ___occuredException, sizeof( NObjective.RuntimeObject ), @group );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject findRecord_ofType_( NObjective.RuntimeObject record, System.IntPtr ofType ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.findRecord_ofType_( Handle, CachedSelectors.findRecord_ofType_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), record, ofType );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject findRecordNames_andAttributes_ofType_matchType_( NObjective.RuntimeObject names, NObjective.RuntimeObject andAttributes, System.IntPtr ofType, int matchType ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.findRecordNames_andAttributes_ofType_matchType_( Handle, CachedSelectors.findRecordNames_andAttributes_ofType_matchType_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( int ), names, andAttributes, ofType, matchType );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject findRecordNames_ofType_matchType_( NObjective.RuntimeObject names, System.IntPtr ofType, int matchType ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.findRecordNames_ofType_matchType_( Handle, CachedSelectors.findRecordNames_ofType_matchType_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( int ), names, ofType, matchType );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject findRecordNamesOfTypes_withAttribute_value_matchType_( NObjective.RuntimeObject types, System.IntPtr withAttribute, NObjective.RuntimeObject value, int matchType ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.findRecordNamesOfTypes_withAttribute_value_matchType_( Handle, CachedSelectors.findRecordNamesOfTypes_withAttribute_value_matchType_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ) + sizeof( int ), types, withAttribute, value, matchType );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject findRecordsOfTypes_withAttribute_value_matchType_( NObjective.RuntimeObject types, System.IntPtr withAttribute, NObjective.RuntimeObject value, int matchType ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.findRecordsOfTypes_withAttribute_value_matchType_( Handle, CachedSelectors.findRecordsOfTypes_withAttribute_value_matchType_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ) + sizeof( int ), types, withAttribute, value, matchType );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject findRecordsOfTypes_withAttribute_value_matchType_allowBinary_( NObjective.RuntimeObject types, System.IntPtr withAttribute, NObjective.RuntimeObject value, int matchType, char allowBinary ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.findRecordsOfTypes_withAttribute_value_matchType_allowBinary_( Handle, CachedSelectors.findRecordsOfTypes_withAttribute_value_matchType_allowBinary_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ) + sizeof( int ) + sizeof( char ), types, withAttribute, value, matchType, allowBinary );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject findRecordsOfTypes_withAttribute_value_matchType_retrieveAttributes_( NObjective.RuntimeObject types, System.IntPtr withAttribute, NObjective.RuntimeObject value, int matchType, NObjective.RuntimeObject retrieveAttributes ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.findRecordsOfTypes_withAttribute_value_matchType_retrieveAttributes_( Handle, CachedSelectors.findRecordsOfTypes_withAttribute_value_matchType_retrieveAttributes_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ) + sizeof( int ) + sizeof( NObjective.RuntimeObject ), types, withAttribute, value, matchType, retrieveAttributes );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject findRecordsOfTypes_withAttribute_value_matchType_retrieveAttributes_allowBinary_( NObjective.RuntimeObject types, System.IntPtr withAttribute, NObjective.RuntimeObject value, int matchType, NObjective.RuntimeObject retrieveAttributes, char allowBinary ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.findRecordsOfTypes_withAttribute_value_matchType_retrieveAttributes_allowBinary_( Handle, CachedSelectors.findRecordsOfTypes_withAttribute_value_matchType_retrieveAttributes_allowBinary_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ) + sizeof( int ) + sizeof( NObjective.RuntimeObject ) + sizeof( char ), types, withAttribute, value, matchType, retrieveAttributes, allowBinary
			 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject findRecordTypes() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.findRecordTypes( Handle, CachedSelectors.findRecordTypes, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject findUser_( NObjective.RuntimeObject user ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.findUser_( Handle, CachedSelectors.findUser_, out ___occuredException, sizeof( NObjective.RuntimeObject ), user );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject getAllAttributes() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getAllAttributes( Handle, CachedSelectors.getAllAttributes, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject getAllAttributesAllowingBinary_( char binary ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getAllAttributesAllowingBinary_( Handle, CachedSelectors.getAllAttributesAllowingBinary_, out ___occuredException, sizeof( char ), binary );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject getAttribute_( System.IntPtr attribute ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getAttribute_( Handle, CachedSelectors.getAttribute_, out ___occuredException, sizeof( System.IntPtr ), attribute );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject getAttribute_allowBinary_( System.IntPtr attribute, char allowBinary ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getAttribute_allowBinary_( Handle, CachedSelectors.getAttribute_allowBinary_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( char ), attribute, allowBinary );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject getAttributeFirstValue_( System.IntPtr value ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getAttributeFirstValue_( Handle, CachedSelectors.getAttributeFirstValue_, out ___occuredException, sizeof( System.IntPtr ), value );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject getAttributeFirstValue_allowBinary_( System.IntPtr value, char allowBinary ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getAttributeFirstValue_allowBinary_( Handle, CachedSelectors.getAttributeFirstValue_allowBinary_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( char ), value, allowBinary );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject getName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getName( Handle, CachedSelectors.getName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char hasRecordsOfType_( System.IntPtr type ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.hasRecordsOfType_( Handle, CachedSelectors.hasRecordsOfType_, out ___occuredException, sizeof( System.IntPtr ), type );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject initWithDir_nodeRef_nodeName_( NObjective.RuntimeObject dir, uint nodeRef, NObjective.RuntimeObject nodeName ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithDir_nodeRef_nodeName_( Handle, CachedSelectors.initWithDir_nodeRef_nodeName_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ) + sizeof( NObjective.RuntimeObject ), dir, nodeRef, nodeName );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject newRecord_ofType_( NObjective.RuntimeObject record, System.IntPtr ofType ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.newRecord_ofType_( Handle, CachedSelectors.newRecord_ofType_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ), record, ofType );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void reopen() {
			RuntimeObject ___occuredException;
			NativeMethods.reopen( Handle, CachedSelectors.reopen, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public NObjective.RuntimeObject searchAttributes_( System.IntPtr attributes ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.searchAttributes_( Handle, CachedSelectors.searchAttributes_, out ___occuredException, sizeof( System.IntPtr ), attributes );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject searchAttributes_allowBinary_( System.IntPtr attributes, char allowBinary ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.searchAttributes_allowBinary_( Handle, CachedSelectors.searchAttributes_allowBinary_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( char ), attributes, allowBinary );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void setSupportsSetAttributeValues_( char values ) {
			RuntimeObject ___occuredException;
			NativeMethods.setSupportsSetAttributeValues_( Handle, CachedSelectors.setSupportsSetAttributeValues_, out ___occuredException, sizeof( char ), values );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setUsesMultiThreaded_( char threaded ) {
			RuntimeObject ___occuredException;
			NativeMethods.setUsesMultiThreaded_( Handle, CachedSelectors.setUsesMultiThreaded_, out ___occuredException, sizeof( char ), threaded );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public char supportsSetAttributeValues() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.supportsSetAttributeValues( Handle, CachedSelectors.supportsSetAttributeValues, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char usesMultiThreaded() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.usesMultiThreaded( Handle, CachedSelectors.usesMultiThreaded, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr adminGroup( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern int authenticateName_withPassword_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name, NObjective.RuntimeObject withPassword );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern int authenticateName_withPassword_authOnly_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name, NObjective.RuntimeObject withPassword, char authOnly );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern int authenticateWithBufferItems_authType_authOnly_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject items, System.IntPtr authType, char authOnly );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern int authenticateWithBufferItems_authType_authOnly_responseBufferItems_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject items, System.IntPtr authType, char authOnly, System.IntPtr responseBufferItems );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern int customCall_inputData_outputData_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int call, NObjective.RuntimeObject inputData, NObjective.RuntimeObject outputData );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern int customCall_receiveData_withAuthorization_sizeCall_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int call, NObjective.RuntimeObject receiveData, System.IntPtr withAuthorization, int sizeCall );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern int customCall_sendData_withAuthorization_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int call, NObjective.RuntimeObject sendData, System.IntPtr withAuthorization );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern int customCall_sendItems_outputData_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int call, NObjective.RuntimeObject sendItems, NObjective.RuntimeObject outputData );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern int customCall_sendPropertyList_withAuthorization_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int call, NObjective.RuntimeObject sendPropertyList, System.IntPtr withAuthorization );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern int customCall_withAuthorization_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int call, System.IntPtr withAuthorization );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr directory( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint dsNodeReference( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr findGroup_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject @group );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr findRecord_ofType_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject record, System.IntPtr ofType );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr findRecordNames_andAttributes_ofType_matchType_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject names, NObjective.RuntimeObject andAttributes, System.IntPtr ofType, int matchType );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr findRecordNames_ofType_matchType_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject names, System.IntPtr ofType, int matchType );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr findRecordNamesOfTypes_withAttribute_value_matchType_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject types, System.IntPtr withAttribute, NObjective.RuntimeObject value, int matchType );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr findRecordsOfTypes_withAttribute_value_matchType_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject types, System.IntPtr withAttribute, NObjective.RuntimeObject value, int matchType );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr findRecordsOfTypes_withAttribute_value_matchType_allowBinary_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject types, System.IntPtr withAttribute, NObjective.RuntimeObject value, int matchType, char allowBinary );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr findRecordsOfTypes_withAttribute_value_matchType_retrieveAttributes_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject types, System.IntPtr withAttribute, NObjective.RuntimeObject value, int matchType, NObjective.RuntimeObject retrieveAttributes );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr findRecordsOfTypes_withAttribute_value_matchType_retrieveAttributes_allowBinary_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject types, System.IntPtr withAttribute, NObjective.RuntimeObject value, int matchType, NObjective.RuntimeObject retrieveAttributes, char allowBinary
			 );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr findRecordTypes( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr findUser_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject user );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr getAllAttributes( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr getAllAttributesAllowingBinary_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, char binary );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr getAttribute_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr attribute );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr getAttribute_allowBinary_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr attribute, char allowBinary );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr getAttributeFirstValue_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr value );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr getAttributeFirstValue_allowBinary_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr value, char allowBinary );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr getName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char hasRecordsOfType_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr type );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithDir_nodeRef_nodeName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dir, uint nodeRef, NObjective.RuntimeObject nodeName );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr newRecord_ofType_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject record, System.IntPtr ofType );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void reopen( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr searchAttributes_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr attributes );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr searchAttributes_allowBinary_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr attributes, char allowBinary );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setSupportsSetAttributeValues_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, char values );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setUsesMultiThreaded_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, char threaded );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char supportsSetAttributeValues( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char usesMultiThreaded( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector adminGroup = "adminGroup";
			public static readonly Selector authenticateName_withPassword_ = "authenticateName:withPassword:";
			public static readonly Selector authenticateName_withPassword_authOnly_ = "authenticateName:withPassword:authOnly:";
			public static readonly Selector authenticateWithBufferItems_authType_authOnly_ = "authenticateWithBufferItems:authType:authOnly:";
			public static readonly Selector authenticateWithBufferItems_authType_authOnly_responseBufferItems_ = "authenticateWithBufferItems:authType:authOnly:responseBufferItems:";
			public static readonly Selector customCall_inputData_outputData_ = "customCall:inputData:outputData:";
			public static readonly Selector customCall_receiveData_withAuthorization_sizeCall_ = "customCall:receiveData:withAuthorization:sizeCall:";
			public static readonly Selector customCall_sendData_withAuthorization_ = "customCall:sendData:withAuthorization:";
			public static readonly Selector customCall_sendItems_outputData_ = "customCall:sendItems:outputData:";
			public static readonly Selector customCall_sendPropertyList_withAuthorization_ = "customCall:sendPropertyList:withAuthorization:";
			public static readonly Selector customCall_withAuthorization_ = "customCall:withAuthorization:";
			public static readonly Selector directory = "directory";
			public static readonly Selector dsNodeReference = "dsNodeReference";
			public static readonly Selector findGroup_ = "findGroup:";
			public static readonly Selector findRecord_ofType_ = "findRecord:ofType:";
			public static readonly Selector findRecordNames_andAttributes_ofType_matchType_ = "findRecordNames:andAttributes:ofType:matchType:";
			public static readonly Selector findRecordNames_ofType_matchType_ = "findRecordNames:ofType:matchType:";
			public static readonly Selector findRecordNamesOfTypes_withAttribute_value_matchType_ = "findRecordNamesOfTypes:withAttribute:value:matchType:";
			public static readonly Selector findRecordsOfTypes_withAttribute_value_matchType_ = "findRecordsOfTypes:withAttribute:value:matchType:";
			public static readonly Selector findRecordsOfTypes_withAttribute_value_matchType_allowBinary_ = "findRecordsOfTypes:withAttribute:value:matchType:allowBinary:";
			public static readonly Selector findRecordsOfTypes_withAttribute_value_matchType_retrieveAttributes_ = "findRecordsOfTypes:withAttribute:value:matchType:retrieveAttributes:";
			public static readonly Selector findRecordsOfTypes_withAttribute_value_matchType_retrieveAttributes_allowBinary_ = "findRecordsOfTypes:withAttribute:value:matchType:retrieveAttributes:allowBinary:";
			public static readonly Selector findRecordTypes = "findRecordTypes";
			public static readonly Selector findUser_ = "findUser:";
			public static readonly Selector getAllAttributes = "getAllAttributes";
			public static readonly Selector getAllAttributesAllowingBinary_ = "getAllAttributesAllowingBinary:";
			public static readonly Selector getAttribute_ = "getAttribute:";
			public static readonly Selector getAttribute_allowBinary_ = "getAttribute:allowBinary:";
			public static readonly Selector getAttributeFirstValue_ = "getAttributeFirstValue:";
			public static readonly Selector getAttributeFirstValue_allowBinary_ = "getAttributeFirstValue:allowBinary:";
			public static readonly Selector getName = "getName";
			public static readonly Selector hasRecordsOfType_ = "hasRecordsOfType:";
			public static readonly Selector initWithDir_nodeRef_nodeName_ = "initWithDir:nodeRef:nodeName:";
			public static readonly Selector newRecord_ofType_ = "newRecord:ofType:";
			public static readonly Selector reopen = "reopen";
			public static readonly Selector searchAttributes_ = "searchAttributes:";
			public static readonly Selector searchAttributes_allowBinary_ = "searchAttributes:allowBinary:";
			public static readonly Selector setSupportsSetAttributeValues_ = "setSupportsSetAttributeValues:";
			public static readonly Selector setUsesMultiThreaded_ = "setUsesMultiThreaded:";
			public static readonly Selector supportsSetAttributeValues = "supportsSetAttributeValues";
			public static readonly Selector usesMultiThreaded = "usesMultiThreaded";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DSoNodeBrowserItem : IEquatable<DSoNodeBrowserItem> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DSObjCWrappersCachedClasses.DSoNodeBrowserItem;
		public static implicit operator IntPtr( DSoNodeBrowserItem value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DSoNodeBrowserItem value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DSoNodeBrowserItem ) ) return false; 
			return Handle == ( ( DSoNodeBrowserItem )value ).Handle;
		}
		public bool Equals( DSoNodeBrowserItem value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DSoNodeBrowserItem value1, DSoNodeBrowserItem value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DSoNodeBrowserItem value1, DSoNodeBrowserItem value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DSoNodeBrowserItem( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DSoNodeBrowserItem alloc() {
			return new DSoNodeBrowserItem( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject children() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.children( Handle, CachedSelectors.children, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject childWithName_( NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.childWithName_( Handle, CachedSelectors.childWithName_, out ___occuredException, sizeof( NObjective.RuntimeObject ), name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public int compareNames_( NObjective.RuntimeObject names ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.compareNames_( Handle, CachedSelectors.compareNames_, out ___occuredException, sizeof( NObjective.RuntimeObject ), names );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public char hasChildren() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.hasChildren( Handle, CachedSelectors.hasChildren, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject initWithName_directory_( NObjective.RuntimeObject name, NObjective.RuntimeObject directory ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithName_directory_( Handle, CachedSelectors.initWithName_directory_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), name, directory );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithPath_directory_( NObjective.RuntimeObject path, NObjective.RuntimeObject directory ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithPath_directory_( Handle, CachedSelectors.initWithPath_directory_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), path, directory );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char loadedChildren() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.loadedChildren( Handle, CachedSelectors.loadedChildren, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject name() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.name( Handle, CachedSelectors.name, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject node() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.node( Handle, CachedSelectors.node, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject path() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.path( Handle, CachedSelectors.path, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject registeredChildrenPaths() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.registeredChildrenPaths( Handle, CachedSelectors.registeredChildrenPaths, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr children( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr childWithName_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern int compareNames_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject names );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char hasChildren( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithName_directory_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject name, NObjective.RuntimeObject directory );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithPath_directory_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject path, NObjective.RuntimeObject directory );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char loadedChildren( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr name( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr node( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr path( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr registeredChildrenPaths( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
		}
		static internal class CachedSelectors {
			public static readonly Selector children = "children";
			public static readonly Selector childWithName_ = "childWithName:";
			public static readonly Selector compareNames_ = "compareNames:";
			public static readonly Selector hasChildren = "hasChildren";
			public static readonly Selector initWithName_directory_ = "initWithName:directory:";
			public static readonly Selector initWithPath_directory_ = "initWithPath:directory:";
			public static readonly Selector loadedChildren = "loadedChildren";
			public static readonly Selector name = "name";
			public static readonly Selector node = "node";
			public static readonly Selector path = "path";
			public static readonly Selector registeredChildrenPaths = "registeredChildrenPaths";
		}
	}
	[ProxyBaseClass(typeof( DSoNode ))]
	public struct DSoNodeConfig : IEquatable<DSoNodeConfig> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DSObjCWrappersCachedClasses.DSoNodeConfig;
		public static implicit operator IntPtr( DSoNodeConfig value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DSoNodeConfig value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DSoNodeConfig ) ) return false; 
			return Handle == ( ( DSoNodeConfig )value ).Handle;
		}
		public bool Equals( DSoNodeConfig value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DSoNodeConfig value1, DSoNodeConfig value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DSoNodeConfig value1, DSoNodeConfig value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DSoNodeConfig( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DSoNodeConfig alloc() {
			return new DSoNodeConfig( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public NObjective.RuntimeObject getAttributesAndValuesForPlugin_( NObjective.RuntimeObject plugin ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getAttributesAndValuesForPlugin_( Handle, CachedSelectors.getAttributesAndValuesForPlugin_, out ___occuredException, sizeof( NObjective.RuntimeObject ), plugin );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject getPluginList() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getPluginList( Handle, CachedSelectors.getPluginList, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initWithDir_( NObjective.RuntimeObject dir ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initWithDir_( Handle, CachedSelectors.initWithDir_, out ___occuredException, sizeof( NObjective.RuntimeObject ), dir );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public char pluginEnabled_( NObjective.RuntimeObject enabled ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.pluginEnabled_( Handle, CachedSelectors.pluginEnabled_, out ___occuredException, sizeof( NObjective.RuntimeObject ), enabled );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void setPlugin_enabled_( NObjective.RuntimeObject plugin, char enabled ) {
			RuntimeObject ___occuredException;
			NativeMethods.setPlugin_enabled_( Handle, CachedSelectors.setPlugin_enabled_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( char ), plugin, enabled );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setPlugin_enabled_withAuthorization_( NObjective.RuntimeObject plugin, char enabled, System.IntPtr withAuthorization ) {
			RuntimeObject ___occuredException;
			NativeMethods.setPlugin_enabled_withAuthorization_( Handle, CachedSelectors.setPlugin_enabled_withAuthorization_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( char ) + sizeof( System.IntPtr ), plugin, enabled, withAuthorization );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr getAttributesAndValuesForPlugin_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject plugin );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr getPluginList( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initWithDir_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject dir );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char pluginEnabled_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject enabled );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setPlugin_enabled_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject plugin, char enabled );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setPlugin_enabled_withAuthorization_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject plugin, char enabled, System.IntPtr withAuthorization );
		}
		static internal class CachedSelectors {
			public static readonly Selector getAttributesAndValuesForPlugin_ = "getAttributesAndValuesForPlugin:";
			public static readonly Selector getPluginList = "getPluginList";
			public static readonly Selector initWithDir_ = "initWithDir:";
			public static readonly Selector pluginEnabled_ = "pluginEnabled:";
			public static readonly Selector setPlugin_enabled_ = "setPlugin:enabled:";
			public static readonly Selector setPlugin_enabled_withAuthorization_ = "setPlugin:enabled:withAuthorization:";
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DSoRecord : IEquatable<DSoRecord> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DSObjCWrappersCachedClasses.DSoRecord;
		public static implicit operator IntPtr( DSoRecord value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DSoRecord value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DSoRecord ) ) return false; 
			return Handle == ( ( DSoRecord )value ).Handle;
		}
		public bool Equals( DSoRecord value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DSoRecord value1, DSoRecord value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DSoRecord value1, DSoRecord value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DSoRecord( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DSoRecord alloc() {
			return new DSoRecord( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public void addAttribute_values_( System.IntPtr attribute, NObjective.RuntimeObject values ) {
			RuntimeObject ___occuredException;
			NativeMethods.addAttribute_values_( Handle, CachedSelectors.addAttribute_values_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ), attribute, values );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void addAttribute_values_mergeValues_( System.IntPtr attribute, NObjective.RuntimeObject values, char mergeValues ) {
			RuntimeObject ___occuredException;
			NativeMethods.addAttribute_values_mergeValues_( Handle, CachedSelectors.addAttribute_values_mergeValues_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ) + sizeof( char ), attribute, values, mergeValues );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public uint attributeCount() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.attributeCount( Handle, CachedSelectors.attributeCount, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public char attributeExists_withValue_( System.IntPtr exists, NObjective.RuntimeObject withValue ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.attributeExists_withValue_( Handle, CachedSelectors.attributeExists_withValue_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ), exists, withValue );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void changeAttribute_index_newValue_( System.IntPtr attribute, uint index, NObjective.RuntimeObject newValue ) {
			RuntimeObject ___occuredException;
			NativeMethods.changeAttribute_index_newValue_( Handle, CachedSelectors.changeAttribute_index_newValue_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( uint ) + sizeof( NObjective.RuntimeObject ), attribute, index, newValue );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void changeAttribute_oldValue_newValue_( System.IntPtr attribute, NObjective.RuntimeObject oldValue, NObjective.RuntimeObject newValue ) {
			RuntimeObject ___occuredException;
			NativeMethods.changeAttribute_oldValue_newValue_( Handle, CachedSelectors.changeAttribute_oldValue_newValue_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), attribute, oldValue, newValue );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public uint dsRecordReference() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.dsRecordReference( Handle, CachedSelectors.dsRecordReference, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public NObjective.RuntimeObject getAllAttributes() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getAllAttributes( Handle, CachedSelectors.getAllAttributes, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject getAllAttributesAndValues() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getAllAttributesAndValues( Handle, CachedSelectors.getAllAttributesAndValues, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject getAttribute_( System.IntPtr attribute ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getAttribute_( Handle, CachedSelectors.getAttribute_, out ___occuredException, sizeof( System.IntPtr ), attribute );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject getAttribute_allowBinary_( System.IntPtr attribute, char allowBinary ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getAttribute_allowBinary_( Handle, CachedSelectors.getAttribute_allowBinary_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( char ), attribute, allowBinary );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject getAttribute_index_( System.IntPtr attribute, uint index ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getAttribute_index_( Handle, CachedSelectors.getAttribute_index_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( uint ), attribute, index );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject getAttribute_index_allowBinary_( System.IntPtr attribute, uint index, char allowBinary ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getAttribute_index_allowBinary_( Handle, CachedSelectors.getAttribute_index_allowBinary_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( uint ) + sizeof( char ), attribute, index, allowBinary );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject getAttributes_( NObjective.RuntimeObject attributes ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getAttributes_( Handle, CachedSelectors.getAttributes_, out ___occuredException, sizeof( NObjective.RuntimeObject ), attributes );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public uint getAttributeValueCount_( System.IntPtr count ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getAttributeValueCount_( Handle, CachedSelectors.getAttributeValueCount_, out ___occuredException, sizeof( System.IntPtr ), count );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public NObjective.RuntimeObject getName() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getName( Handle, CachedSelectors.getName, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public System.IntPtr getType() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getType( Handle, CachedSelectors.getType, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject initInNode_recordRef_( NObjective.RuntimeObject node, uint recordRef ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initInNode_recordRef_( Handle, CachedSelectors.initInNode_recordRef_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ), node, recordRef );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initInNode_recordRef_type_( NObjective.RuntimeObject node, uint recordRef, System.IntPtr type ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initInNode_recordRef_type_( Handle, CachedSelectors.initInNode_recordRef_type_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( uint ) + sizeof( System.IntPtr ), node, recordRef, type );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initInNode_type_name_( NObjective.RuntimeObject node, System.IntPtr type, NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initInNode_type_name_( Handle, CachedSelectors.initInNode_type_name_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ), node, type, name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject initInNode_type_name_create_( NObjective.RuntimeObject node, System.IntPtr type, NObjective.RuntimeObject name, char create ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initInNode_type_name_create_( Handle, CachedSelectors.initInNode_type_name_create_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ) + sizeof( char ), node, type, name, create );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public NObjective.RuntimeObject node() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.node( Handle, CachedSelectors.node, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public void removeAttribute_( System.IntPtr attribute ) {
			RuntimeObject ___occuredException;
			NativeMethods.removeAttribute_( Handle, CachedSelectors.removeAttribute_, out ___occuredException, sizeof( System.IntPtr ), attribute );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeAttribute_index_( System.IntPtr attribute, uint index ) {
			RuntimeObject ___occuredException;
			NativeMethods.removeAttribute_index_( Handle, CachedSelectors.removeAttribute_index_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( uint ), attribute, index );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeAttribute_value_( System.IntPtr attribute, NObjective.RuntimeObject value ) {
			RuntimeObject ___occuredException;
			NativeMethods.removeAttribute_value_( Handle, CachedSelectors.removeAttribute_value_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ), attribute, value );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeAttribute_values_( System.IntPtr attribute, NObjective.RuntimeObject values ) {
			RuntimeObject ___occuredException;
			NativeMethods.removeAttribute_values_( Handle, CachedSelectors.removeAttribute_values_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ), attribute, values );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void removeRecord() {
			RuntimeObject ___occuredException;
			NativeMethods.removeRecord( Handle, CachedSelectors.removeRecord, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setAttribute_value_( System.IntPtr attribute, NObjective.RuntimeObject value ) {
			RuntimeObject ___occuredException;
			NativeMethods.setAttribute_value_( Handle, CachedSelectors.setAttribute_value_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ), attribute, value );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public void setAttribute_values_( System.IntPtr attribute, NObjective.RuntimeObject values ) {
			RuntimeObject ___occuredException;
			NativeMethods.setAttribute_values_( Handle, CachedSelectors.setAttribute_values_, out ___occuredException, sizeof( System.IntPtr ) + sizeof( NObjective.RuntimeObject ), attribute, values );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void addAttribute_values_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr attribute, NObjective.RuntimeObject values );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void addAttribute_values_mergeValues_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr attribute, NObjective.RuntimeObject values, char mergeValues );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint attributeCount( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern char attributeExists_withValue_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr exists, NObjective.RuntimeObject withValue );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void changeAttribute_index_newValue_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr attribute, uint index, NObjective.RuntimeObject newValue );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void changeAttribute_oldValue_newValue_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr attribute, NObjective.RuntimeObject oldValue, NObjective.RuntimeObject newValue );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint dsRecordReference( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr getAllAttributes( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr getAllAttributesAndValues( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr getAttribute_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr attribute );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr getAttribute_allowBinary_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr attribute, char allowBinary );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr getAttribute_index_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr attribute, uint index );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr getAttribute_index_allowBinary_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr attribute, uint index, char allowBinary );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr getAttributes_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject attributes );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint getAttributeValueCount_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr count );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr getName( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern System.IntPtr getType( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initInNode_recordRef_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject node, uint recordRef );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initInNode_recordRef_type_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject node, uint recordRef, System.IntPtr type );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initInNode_type_name_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject node, System.IntPtr type, NObjective.RuntimeObject name );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initInNode_type_name_create_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject node, System.IntPtr type, NObjective.RuntimeObject name, char create );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr node( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void removeAttribute_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr attribute );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void removeAttribute_index_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr attribute, uint index );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void removeAttribute_value_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr attribute, NObjective.RuntimeObject value );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void removeAttribute_values_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr attribute, NObjective.RuntimeObject values );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void removeRecord( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setAttribute_value_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr attribute, NObjective.RuntimeObject value );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setAttribute_values_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, System.IntPtr attribute, NObjective.RuntimeObject values );
		}
		static internal class CachedSelectors {
			public static readonly Selector addAttribute_values_ = "addAttribute:values:";
			public static readonly Selector addAttribute_values_mergeValues_ = "addAttribute:values:mergeValues:";
			public static readonly Selector attributeCount = "attributeCount";
			public static readonly Selector attributeExists_withValue_ = "attributeExists:withValue:";
			public static readonly Selector changeAttribute_index_newValue_ = "changeAttribute:index:newValue:";
			public static readonly Selector changeAttribute_oldValue_newValue_ = "changeAttribute:oldValue:newValue:";
			public static readonly Selector dsRecordReference = "dsRecordReference";
			public static readonly Selector getAllAttributes = "getAllAttributes";
			public static readonly Selector getAllAttributesAndValues = "getAllAttributesAndValues";
			public static readonly Selector getAttribute_ = "getAttribute:";
			public static readonly Selector getAttribute_allowBinary_ = "getAttribute:allowBinary:";
			public static readonly Selector getAttribute_index_ = "getAttribute:index:";
			public static readonly Selector getAttribute_index_allowBinary_ = "getAttribute:index:allowBinary:";
			public static readonly Selector getAttributes_ = "getAttributes:";
			public static readonly Selector getAttributeValueCount_ = "getAttributeValueCount:";
			public static readonly Selector getName = "getName";
			public static readonly Selector getType = "getType";
			public static readonly Selector initInNode_recordRef_ = "initInNode:recordRef:";
			public static readonly Selector initInNode_recordRef_type_ = "initInNode:recordRef:type:";
			public static readonly Selector initInNode_type_name_ = "initInNode:type:name:";
			public static readonly Selector initInNode_type_name_create_ = "initInNode:type:name:create:";
			public static readonly Selector node = "node";
			public static readonly Selector removeAttribute_ = "removeAttribute:";
			public static readonly Selector removeAttribute_index_ = "removeAttribute:index:";
			public static readonly Selector removeAttribute_value_ = "removeAttribute:value:";
			public static readonly Selector removeAttribute_values_ = "removeAttribute:values:";
			public static readonly Selector removeRecord = "removeRecord";
			public static readonly Selector setAttribute_value_ = "setAttribute:value:";
			public static readonly Selector setAttribute_values_ = "setAttribute:values:";
		}
	}
	[ProxyBaseClass(typeof( DSoNode ))]
	public struct DSoSearchNode : IEquatable<DSoSearchNode> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DSObjCWrappersCachedClasses.DSoSearchNode;
		public static implicit operator IntPtr( DSoSearchNode value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DSoSearchNode value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DSoSearchNode ) ) return false; 
			return Handle == ( ( DSoSearchNode )value ).Handle;
		}
		public bool Equals( DSoSearchNode value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DSoSearchNode value1, DSoSearchNode value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DSoSearchNode value1, DSoSearchNode value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DSoSearchNode( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DSoSearchNode alloc() {
			return new DSoSearchNode( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
	}
	[ProxyBaseClass(typeof( NSObject ))]
	public struct DSoStatus : IEquatable<DSoStatus> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DSObjCWrappersCachedClasses.DSoStatus;
		public static implicit operator IntPtr( DSoStatus value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DSoStatus value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DSoStatus ) ) return false; 
			return Handle == ( ( DSoStatus )value ).Handle;
		}
		public bool Equals( DSoStatus value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DSoStatus value1, DSoStatus value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DSoStatus value1, DSoStatus value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DSoStatus( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DSoStatus alloc() {
			return new DSoStatus( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public static NObjective.RuntimeObject sharedInstance() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.sharedInstance( ClassHandle, CachedSelectors.sharedInstance, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public System.IntPtr cStringForStatus_( int status ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.cStringForStatus_( Handle, CachedSelectors.cStringForStatus_, out ___occuredException, sizeof( int ), status );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public NObjective.RuntimeObject stringForStatus_( int status ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.stringForStatus_( Handle, CachedSelectors.stringForStatus_, out ___occuredException, sizeof( int ), status );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern System.IntPtr cStringForStatus_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int status );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr sharedInstance( RuntimeClass ___class, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr stringForStatus_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, int status );
		}
		static internal class CachedSelectors {
			public static readonly Selector cStringForStatus_ = "cStringForStatus:";
			public static readonly Selector sharedInstance = "sharedInstance";
			public static readonly Selector stringForStatus_ = "stringForStatus:";
		}
	}
	[ProxyBaseClass(typeof( DSoRecord ))]
	public struct DSoUser : IEquatable<DSoUser> {
		internal NObjective.RuntimeObject Handle;
		public static readonly RuntimeClass ClassHandle = DSObjCWrappersCachedClasses.DSoUser;
		public static implicit operator IntPtr( DSoUser value ) {
			return value.Handle;
		}
		public static implicit operator NObjective.RuntimeObject( DSoUser value ) {
			return value.Handle;
		}
		public override bool Equals( object value ) {
			if( !( value is DSoUser ) ) return false; 
			return Handle == ( ( DSoUser )value ).Handle;
		}
		public bool Equals( DSoUser value ) {
			return Handle == value.Handle;
		}
		public static bool operator ==( DSoUser value1, DSoUser value2 ) {
			return value1.Handle == value2.Handle;
		}
		public static bool operator !=( DSoUser value1, DSoUser value2 ) {
			return value1.Handle != value2.Handle;
		}
		public DSoUser( IntPtr value ) {
			this.Handle = new RuntimeObject( value );
		}
		public static DSoUser alloc() {
			return new DSoUser( ClassHandle.InvokeIntPtr( Selectors.alloc ) );
		}
		unsafe public int authenticate_( NObjective.RuntimeObject authenticate ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.authenticate_( Handle, CachedSelectors.authenticate_, out ___occuredException, sizeof( NObjective.RuntimeObject ), authenticate );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void changePassword_toNewPassword_( NObjective.RuntimeObject password, NObjective.RuntimeObject toNewPassword ) {
			RuntimeObject ___occuredException;
			NativeMethods.changePassword_toNewPassword_( Handle, CachedSelectors.changePassword_toNewPassword_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), password, toNewPassword );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		unsafe public uint getGid() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getGid( Handle, CachedSelectors.getGid, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public uint getUid() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.getUid( Handle, CachedSelectors.getUid, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ( uint )___result;
		}
		unsafe public NObjective.RuntimeObject initInNode_name_( NObjective.RuntimeObject node, NObjective.RuntimeObject name ) {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.initInNode_name_( Handle, CachedSelectors.initInNode_name_, out ___occuredException, sizeof( NObjective.RuntimeObject ) + sizeof( NObjective.RuntimeObject ), node, name );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return new NObjective.RuntimeObject( ___result );
		}
		unsafe public bool isAdmin() {
			RuntimeObject ___occuredException;
			var ___result = NativeMethods.isAdmin( Handle, CachedSelectors.isAdmin, out ___occuredException, 0 );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
			return ___result;
		}
		unsafe public void setPassword_( NObjective.RuntimeObject password ) {
			RuntimeObject ___occuredException;
			NativeMethods.setPassword_( Handle, CachedSelectors.setPassword_, out ___occuredException, sizeof( NObjective.RuntimeObject ), password );
			if( ___occuredException != RuntimeObject.Null ) throw RuntimeException.Create( ___occuredException ); 
		}
		private static class NativeMethods {
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern int authenticate_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject authenticate );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void changePassword_toNewPassword_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject password, NObjective.RuntimeObject toNewPassword );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint getGid( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern uint getUid( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern IntPtr initInNode_name_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject node, NObjective.RuntimeObject name );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern bool isAdmin( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize );
			[DllImport(Runtime.InteropLibrary, EntryPoint = "objc_msgSend_eh2")]
			public static extern void setPassword_( RuntimeObject ___object, Selector ___selector, out RuntimeObject ___occuredException, int ___stackSize, NObjective.RuntimeObject password );
		}
		static internal class CachedSelectors {
			public static readonly Selector authenticate_ = "authenticate:";
			public static readonly Selector changePassword_toNewPassword_ = "changePassword:toNewPassword:";
			public static readonly Selector getGid = "getGid";
			public static readonly Selector getUid = "getUid";
			public static readonly Selector initInNode_name_ = "initInNode:name:";
			public static readonly Selector isAdmin = "isAdmin";
			public static readonly Selector setPassword_ = "setPassword:";
		}
	}
	static internal class DSObjCWrappersCachedClasses {
		static internal int ___lazyLoad = Platform.NativeMethods.dlopen( "/System/Library/PrivateFrameworks/DSObjCWrappers.framework/Versions/A/DSObjCWrappers" );
		public static readonly RuntimeClass DSoAttributeUtils = "DSoAttributeUtils";
		public static readonly RuntimeClass DSoBuffer = "DSoBuffer";
		public static readonly RuntimeClass DSoDataList = "DSoDataList";
		public static readonly RuntimeClass DSoDataNode = "DSoDataNode";
		public static readonly RuntimeClass DSoDirectory = "DSoDirectory";
		public static readonly RuntimeClass DSoException = "DSoException";
		public static readonly RuntimeClass DSoGroup = "DSoGroup";
		public static readonly RuntimeClass DSoNode = "DSoNode";
		public static readonly RuntimeClass DSoNodeBrowserItem = "DSoNodeBrowserItem";
		public static readonly RuntimeClass DSoNodeConfig = "DSoNodeConfig";
		public static readonly RuntimeClass DSoRecord = "DSoRecord";
		public static readonly RuntimeClass DSoSearchNode = "DSoSearchNode";
		public static readonly RuntimeClass DSoStatus = "DSoStatus";
		public static readonly RuntimeClass DSoUser = "DSoUser";
	}
}
