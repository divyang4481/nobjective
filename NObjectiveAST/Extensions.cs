//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace NObjectiveAST
{
	[DebuggerStepThrough]
	internal static class Extensions
	{
		public static IDisposable PushScoped<T>( this Stack<T> @this, T element )
		{
			@this.Push( element );
			return new ActionInvoker( delegate { @this.Pop(); } );
		}

		[DebuggerStepThrough]
		internal class ActionInvoker : IDisposable
		{
			public Action _action;

			public ActionInvoker( Action action )
			{
				_action = action;
			}

			#region IDisposable Members

			public void Dispose()
			{
				_action();
			}

			#endregion
		}

		public static void Perform<T>( this IEnumerable<T> @this, Action<T> action )
		{
			foreach( var item in @this )
				action( item );
		}

		internal static IEnumerable<Type> GetElementHierarchy( this Type type )
		{
			var result = type;

			while( result != null )
			{
				yield return result;

				result = result.BaseType;
			}
		}
	}
}
