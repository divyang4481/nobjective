//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace NObjective.Tracing
{
	/// <summary>
	/// 
	/// </summary>
	public sealed class TraceSource : IDisposable
	{
		private string _name;
		/// <summary>
		/// 
		/// </summary>
		public string Name { get { return _name; } }

		private int _level;

		/// <summary>
		/// 
		/// </summary>
		[System.Diagnostics.Conditional( "TRACE" )]
		public void IncreaseLevel() { _level++; }

		/// <summary>
		/// 
		/// </summary>
		[System.Diagnostics.Conditional( "TRACE" )]
		public void DecreaseLevel() { _level--; }

		/// <summary>
		/// 
		/// </summary>
		public int Level { get { return _level; } }

		/// <summary>
		/// 
		/// </summary>
		public List<TraceListener> _listeners = new List<TraceListener>();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		public TraceSource( string name )
		{
			_name = name;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="listener"></param>
		[System.Diagnostics.Conditional( "TRACE" )]
		[MethodImpl( MethodImplOptions.Synchronized )]
		public void AddListener( TraceListener listener )
		{
			var listeners = _listeners.ToList();
			listeners.Add( listener );

			_listeners = listeners;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="listener"></param>
		[System.Diagnostics.Conditional( "TRACE" )]
		[MethodImpl( MethodImplOptions.Synchronized )]
		public void RemoveListener( TraceListener listener )
		{
			var listeners = _listeners.ToList();
			listeners.Remove( listener );

			_listeners = listeners;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		[System.Diagnostics.Conditional( "TRACE" )]
		[MethodImpl( MethodImplOptions.Synchronized )]
		public void Warning( string message )
		{
			var context = new TraceContext( this, TraceMessageType.Warning );

			foreach( var listener in _listeners )
				listener.Trace( context, message );
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="arguments"></param>
		[System.Diagnostics.Conditional( "TRACE" )]
		[MethodImpl( MethodImplOptions.Synchronized )]
		public void Warning( string message, params object[] arguments )
		{
			var context = new TraceContext( this, TraceMessageType.Warning );

			foreach( var listener in _listeners )
				listener.Trace( context, string.Format( message, arguments ) );
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		[System.Diagnostics.Conditional( "TRACE" )]
		[MethodImpl( MethodImplOptions.Synchronized )]
		public void Information( string message )
		{
			var context = new TraceContext( this, TraceMessageType.Information );

			foreach( var listener in _listeners )
				listener.Trace( context, message );
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="arguments"></param>
		[System.Diagnostics.Conditional( "TRACE" )]
		[MethodImpl( MethodImplOptions.Synchronized )]
		public void Information( string message, params object[] arguments )
		{
			var context = new TraceContext( this, TraceMessageType.Information );

			foreach( var listener in _listeners )
				listener.Trace( context, string.Format( message, arguments ) );
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		[System.Diagnostics.Conditional( "TRACE" )]
		[MethodImpl( MethodImplOptions.Synchronized )]
		public void Error( string message )
		{
			var context = new TraceContext( this, TraceMessageType.Error );

			foreach( var listener in _listeners )
				listener.Trace( context, message );
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <param name="arguments"></param>
		[System.Diagnostics.Conditional( "TRACE" )]
		[MethodImpl( MethodImplOptions.Synchronized )]
		public void Error( string message, params object[] arguments )
		{
			var context = new TraceContext( this, TraceMessageType.Error );

			foreach( var listener in _listeners )
				listener.Trace( context, string.Format( message, arguments ) );
		}

		/// <summary>
		/// 
		/// </summary>
		[System.Diagnostics.Conditional( "TRACE" )]
		[MethodImpl( MethodImplOptions.Synchronized )]
		public void Flush()
		{
			foreach( var listener in _listeners )
				listener.Flush();
		}

		#region IDisposable Members

		/// <summary>
		/// 
		/// </summary>
		public void Dispose()
		{
			Flush();
		}

		#endregion
	}
}
