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
	/// Provides NSAutoreleasePool functionality with "using" pattern:
	/// <code>
	/// using( new AutoreleaseScope() ) {
	///		...
	///		...
	///		...
	///	}
	/// </code>
	/// </summary>
	public sealed class AutoreleaseScope : IDisposable
	{
		/// <summary>
		/// Points to NSAutoreleasePool object.
		/// </summary>
		private RuntimeObject _handle;

		/// <summary>
		/// Creates new NSAutoreleasePool object.
		/// </summary>
		public AutoreleaseScope()
		{
			_handle = new RuntimeObject( Runtime.SendMessage( Runtime.SendMessage( RuntimeClasses.NSAutoreleasePool, Selectors.alloc ), Selectors.init ) );
		}

		/// <summary>
		/// Releases internal NSAutoreleasePool object.
		/// </summary>
		~AutoreleaseScope()
		{
			Dispose();
		}

		#region IDisposable Members

		/// <summary>
		/// Releases internal NSAutoreleasePool object.
		/// </summary>
		public void Dispose()
		{
			Runtime.SendMessage( _handle, Selectors.release );

			_handle = RuntimeObject.Null;
			GC.SuppressFinalize( this );
		}

		#endregion
	}
}
