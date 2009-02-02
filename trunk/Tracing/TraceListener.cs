//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//


using System.Runtime.CompilerServices;

namespace NObjective.Tracing
{
	/// <summary>
	/// Provides the abstract base class for the listeners who monitor trace output.
	/// </summary>
	public abstract class TraceListener
	{
		/// <summary>
		/// Receives TraseSource's trace output.
		/// </summary>
		/// <param name="context"></param>
		/// <param name="message"></param>
		[MethodImpl( MethodImplOptions.Synchronized )]
		public abstract void Trace( TraceContext context, string message );

		/// <summary>
		/// When overridden in a derived class, flushes the output buffer.
		/// </summary>
		[MethodImpl( MethodImplOptions.Synchronized )]
		public abstract void Flush();
	}
}
