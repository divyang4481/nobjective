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

namespace NObjective
{
	/// <summary>
	/// Manages exception barriers for classes exported to Objective-C runtime.
	/// Since Apple don't like Objective-C classes unloading, so we don't need freeing yet.
	/// </summary>
	internal unsafe class ExceptionBarrierManager
	{
		/// <summary>
		/// Exception barrier implementation types.
		/// </summary>
		public enum BarrierType
		{
			None,

			X86,
			PPC,
			X86_64,
			PPC64
		}

		public static BarrierType Type { get; private set; }

		public static readonly ExceptionBarrierManager Instance = SelectBarrierManager();

		private static ExceptionBarrierManager SelectBarrierManager()
		{
			if( IntPtr.Size != 4 )
				return new ExceptionBarrierManager();

			if( !BitConverter.IsLittleEndian )
				return new PPCBarrier();

			return new X86Barrier();
		}

		public virtual IntPtr Allocate( IntPtr methodAddress )
		{
			return methodAddress;
		}

		private static int Align( int value, int boundary )
		{
			return ( value + boundary - 1 ) & ~( boundary - 1 );
		}

		private static void CopyMemory( byte* destination, byte[] source, int size )
		{
			for( int i = 0; i < size; i++ )
				*destination++ = source[i];
		}

		private ExceptionBarrierManager()
		{
			Type = BarrierType.None;
		}

		/// <summary>
		/// Exception barrier implementation for IA32.
		/// </summary>
		private sealed class X86Barrier : ExceptionBarrierManager
		{
			private static byte[] _barrierCode = { 0x83, 0xEC, 0x08, 0x54, 0x68, 0x00, 0x00, 0x00, 0x00, 0xE9, 0x00, 0x00, 0x00, 0x00, 0x83, 0x7C, 0x24, 0x04, 0x00, 0x0F, 0x85, 0x00, 0x00, 0x00, 0x00, 0x83, 0xc4, 0x0C, 0xC3 };
			private static byte[] _exceptionHandlerCode = { 0x8B, 0x44, 0x24, 0x04, 0x89, 0x04, 0x24, 0xe8, 0x00, 0x00, 0x00, 0x00, 0x83, 0xc4, 0x0C, 0xC3 };

			private const int BlockSize = 4096;

			public X86Barrier()
			{
				Type = BarrierType.X86;
			}

			public override IntPtr Allocate( IntPtr methodAddress )
			{
				_writePosition += Align( _barrierCode.Length, 32 );

				if( _writePosition >= _blockEnd )
				{
					byte* allocatedAddress = null;
					Platform.NativeMethods.vm_allocate( Platform.NativeMethods.mach_task_self(), ( void** ) &allocatedAddress, BlockSize, true );
					_writePosition = allocatedAddress;

					_blockEnd = _writePosition + BlockSize;

					for( var trapSetter = _writePosition; trapSetter < _blockEnd; trapSetter++ )
						*trapSetter = 0xCC;
				}

				if( _exceptionHandler == null )
				{
					_exceptionHandler = _writePosition;

					CopyMemory( _writePosition, _exceptionHandlerCode, _exceptionHandlerCode.Length );
					FixupRelative( _writePosition + 8, objc_exception_throw.ToPointer() );
					_writePosition += Align( _exceptionHandlerCode.Length, 32 );
				}
				
				// vm_protect not works as expected
				//Console.WriteLine( Platform.NativeMethods.vm_protect( Platform.NativeMethods.mach_task_self(), _blockEnd - BlockSize, BlockSize, false, Platform.vm_prot_t.VM_PROT_WRITE ) );
				Platform.NativeMethods.mprotect( _blockEnd - BlockSize, BlockSize, Platform.MemoryProtection.PROT_WRITE );
				{
					CopyMemory( _writePosition, _barrierCode, _barrierCode.Length );

					FixupImmediate( _writePosition + 5, _writePosition + 14 );
					FixupRelative( _writePosition + 10, methodAddress.ToPointer() );
					FixupRelative( _writePosition + 21, _exceptionHandler );
				}
				Platform.NativeMethods.mprotect( _blockEnd - BlockSize, BlockSize, Platform.MemoryProtection.PROT_EXEC );
				//Console.WriteLine( Platform.NativeMethods.vm_protect( Platform.NativeMethods.mach_task_self(), _blockEnd - BlockSize, BlockSize, false, Platform.vm_prot_t.VM_PROT_EXEC ) );

				return new IntPtr( _writePosition );
			}

			private static void FixupRelative( byte* offset, void* value )
			{
				*( int* ) offset = ( ( int ) value ) - ( ( int ) offset ) - 4;
			}

			private static void FixupImmediate( byte* offset, void* value )
			{
				*( int* ) offset = ( int ) value;
			}

			private byte* _exceptionHandler;
			private byte* _writePosition;
			private byte* _blockEnd;
		}

		/// <summary>
		/// Exception barrier implementation for 32-bit PowerPC.
		/// </summary>
		private sealed class PPCBarrier : ExceptionBarrierManager
		{
			private static byte[] _barrierCode = { 0x7c, 0x08, 0x02, 0xa6, 0x90, 0x81, 0x00, 0x0c, 0x90, 0x01, 0x00, 0x10, 0x3c, 0x80, 0x00, 0x00, 0x60, 0x84, 0x1d, 0x98, 0x7c, 0x89, 0x03, 0xa6, 0x38, 0x81, 0x00, 0x0c, 0x4e, 0x80, 0x04, 0x21, 0x80, 0x01, 0x00, 0x0c, 0x2f, 0x80, 0x00, 0x00, 0x40, 0x9e, 0x00, 0x10, 0x80, 0x01, 0x00, 0x10, 0x7c, 0x09, 0x03, 0xa6, 0x4e, 0x80, 0x04, 0x20 };
			private static byte[] _exceptionHandlerCode = { 0x7c, 0x03, 0x03, 0x78, 0x3c, 0x80, 0x00, 0x00, 0x60, 0x84, 0x1d, 0x98, 0x7c, 0x89, 0x03, 0xa6, 0x4e, 0x80, 0x04, 0x21 };

			private const int BlockSize = 16384;

			public PPCBarrier()
			{
				Type = BarrierType.PPC;
			}

			public override IntPtr Allocate( IntPtr methodAddress )
			{
				_writePosition += Align( _barrierCode.Length, 32 );

				if( _writePosition >= _blockEnd )
				{
					byte* allocatedAddress = null;
					Platform.NativeMethods.vm_allocate( Platform.NativeMethods.mach_task_self(), ( void** ) &allocatedAddress, BlockSize, true );
					_writePosition = allocatedAddress;

					_blockEnd = _writePosition + BlockSize;

					for( var trapSetter = ( int* ) _writePosition; trapSetter < ( int* ) _blockEnd; trapSetter++ )
						*trapSetter = 0x7fe00008;

					_exceptionHandler = _writePosition;
					CopyMemory( _writePosition, _exceptionHandlerCode, _exceptionHandlerCode.Length );

					FixupImmediate( _writePosition + 6, ( short ) ( objc_exception_throw.ToInt32() >> 16 ) );
					FixupImmediate( _writePosition + 10, ( short ) objc_exception_throw.ToInt32() );

					_writePosition += Align( _exceptionHandlerCode.Length, 64 );
				}

				Platform.NativeMethods.mprotect( _blockEnd - BlockSize, BlockSize, Platform.MemoryProtection.PROT_WRITE | Platform.MemoryProtection.PROT_READ );
				{
					CopyMemory( _writePosition, _barrierCode, _barrierCode.Length );

					FixupImmediate( _writePosition + 14, ( short ) ( methodAddress.ToInt32() >> 16 ) );
					FixupImmediate( _writePosition + 18, ( short ) methodAddress.ToInt32() );

					FixupRelative( _writePosition + 42, _exceptionHandler );
				}
				Platform.NativeMethods.mprotect( _blockEnd - BlockSize, BlockSize, Platform.MemoryProtection.PROT_EXEC );

				return new IntPtr( _writePosition );
			}

			private static void FixupRelative( byte* offset, byte* value )
			{
				*( short* ) offset = ( short ) ( ( ( ( int ) value ) - ( ( ( int ) offset ) - 2 ) ) & 0xFFFC | ( *( int* ) offset & 3 ) );
			}

			private static void FixupImmediate( byte* offset, short value )
			{
				*( short* ) offset = value;
			}

			private byte* _exceptionHandler;
			private byte* _writePosition;
			private byte* _blockEnd;
		}

		private static IntPtr objc_exception_throw = Platform.NativeMethods.NSAddressOfSymbol( Platform.NativeMethods.NSLookupAndBindSymbol( "_objc_exception_throw" ) );
	}
}
