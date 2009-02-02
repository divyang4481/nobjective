//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System.IO;
using System.Text;
using System.Runtime.CompilerServices;

namespace NObjective.Tracing
{
	/// <summary>
	/// Directs tracing output to a System.IO.TextWriter or to a System.IO.Stream, such as System.IO.FileStream
	/// </summary>
	public sealed class TextWriterTraceListener : TraceListener
	{
		/// <summary>
		/// Initializes a new instance of the TextWriterTraceListener class, using the file as the recipient of the debugging and tracing output.
		/// </summary>
		/// <param name="fileName">The name of the file that will be overwritten with tracing output.</param>
		public TextWriterTraceListener( string fileName )
		{
			_writer = new StreamWriter( fileName );
		}

		/// <summary>
		/// Initializes a new instance of the TextWriterTraceListener class, using the file as the recipient of the debugging and tracing output.
		/// </summary>
		/// <param name="fileName">The name of the file that will be used to write tracing output.</param>
		/// <param name="append">False if file should be overwritten, True otherwise.</param>
		/// <param name="encoding">Encodingh that will be used to encode tracing output.</param>
		public TextWriterTraceListener( string fileName, bool append, Encoding encoding )
		{
			_writer = new StreamWriter( fileName, append, encoding );
		}

		/// <summary>
		/// Initializes a new instance of the TextWriterTraceListener class, using the specified writer as the recipient of the debugging and tracing output.
		/// </summary>
		/// <param name="writer"> A System.IO.TextWriter that receives the trace output.</param>
		public TextWriterTraceListener( TextWriter writer )
		{
			_writer = writer;
		}

		/// <summary>
		/// Writes a message to internal writer.
		/// </summary>
		/// <param name="context"></param>
		/// <param name="message"></param>
		[MethodImpl( MethodImplOptions.Synchronized )]
		public override void Trace( TraceContext context, string message )
		{
			if( context.TraceSource.Level > 0 )
				_writer.Write( new string( '\t', context.TraceSource.Level ) );

			_writer.WriteLine( message );
		}

		/// <summary>
		/// Flushes the output buffer for internal writer.
		/// </summary>
		[MethodImpl( MethodImplOptions.Synchronized )]
		public override void Flush()
		{
			_writer.Flush();
		}

		/// <summary>
		/// Internal writer.
		/// </summary>
		private readonly TextWriter _writer;
	}
}
