//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System;
using System.Runtime.InteropServices;

namespace NObjective
{
	/// <summary>
	/// Used for "using" pattern. See usages.
	/// </summary>
	internal unsafe sealed class ScopedMemoryCustodian : IDisposable
	{
		private readonly IntPtr _buffer;
		private readonly Action<IntPtr> _deleter;

		public ScopedMemoryCustodian( IntPtr buffer )
		{
			_buffer = buffer;
			_deleter = Marshal.FreeCoTaskMem;
		}

		public ScopedMemoryCustodian( IntPtr buffer, Action<IntPtr> deleter )
		{
			_buffer = buffer;
			_deleter = deleter;
		}

		~ScopedMemoryCustodian()
		{
			Dispose();
		}

		public IntPtr Buffer { get { return _buffer; } }

		public IntPtr this[int index]
		{
			get { return ( ( IntPtr* ) _buffer )[index]; }
		}

		public IntPtr this[uint index]
		{
			get { return ( ( IntPtr* ) _buffer )[index]; }
		}

		public void Dispose()
		{
			if( _deleter != null )
				_deleter( _buffer );

			GC.SuppressFinalize( this );
		}
	}
}
