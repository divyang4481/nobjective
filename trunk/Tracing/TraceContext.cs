//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//


namespace NObjective.Tracing
{
	/// <summary>
	/// Used to provide all necessary info about place from which trace was requested.
	/// </summary>
	public sealed class TraceContext
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="traceSource"></param>
		/// <param name="traceType"></param>
		public TraceContext( TraceSource traceSource, TraceMessageType traceType )
		{
			TraceSource = traceSource;
			TraceType = traceType;
			Stack = new System.Diagnostics.StackTrace( 2 );
		}

		/// <summary>
		/// Stack trace from trace invocation location.
		/// </summary>
		public System.Diagnostics.StackTrace Stack { get; set; }

		/// <summary>
		/// Which trace source requested to trace.
		/// </summary>
		public TraceSource TraceSource { get; set; }

		/// <summary>
		/// What kind of trace was requested.
		/// </summary>
		public TraceMessageType TraceType { get; set; }
	}
}
