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
using System.IO;

namespace NObjectiveAST
{
	public partial interface IAstVisitor
	{
		event Action<string, Node> BeginVisit;
		event Action<string, Node> EndVisit;

		event Action<string, object> BeginVisitChildren;
		event Action<string, object> EndVisitChildren;
	}

	public partial class TraversalVisitor : IAstVisitor
	{
		public event Action<string, Node> BeginVisit = ( name, node ) => { };
		public event Action<string, Node> EndVisit = ( name, node ) => { };

		public event Action<string, object> BeginVisitChildren = ( name, node ) => { };
		public event Action<string, object> EndVisitChildren = ( name, node ) => { };

		public object AcceptNode( Node node )
		{
			if( node == null )
				return null;

			return node.AcceptVisitor( this );
		}

		public object AcceptChildren<T>( IEnumerable<T> node ) where T:Node
		{
			if( node == null )
				return null;

			foreach( var child in node )
				child.AcceptVisitor( this );

			return null;
		}

		public static void PrintTree( string filename, Node node )
		{
			using( var writer = new StreamWriter( filename ) )
				PrintTree( writer, node );
		}

		public static void PrintTree( TextWriter writer, Node node )
		{
			var visitor = new TraversalVisitor();

			int indent = 0;

			visitor.BeginVisit += ( name, child ) =>
			{
				writer.WriteLine( "{0}{1} ({2})", new string( '\t', indent++ ), child.GetType().Name, name );
			};

			visitor.EndVisit += ( name, child ) =>
			{
				indent--;
			};

			visitor.BeginVisitChildren += ( name, child ) =>
			{
				writer.WriteLine( "{0}Children:", new string( '\t', indent++ ), child.GetType().Name );
			};

			visitor.EndVisitChildren += ( name, child ) =>
			{
				indent--;
			};

			visitor.BeginVisit( node.GetType().Name, node );
			visitor.EndVisit( node.GetType().Name, node );
			node.AcceptVisitor( visitor );
		}

		public static void PrintStatistics( string filename, Node node )
		{
			using( var writer = new StreamWriter( filename ) )
				PrintStatistics( writer, node );
		}

		public static void PrintStatistics( TextWriter writer, Node node )
		{
			var visitor = new TraversalVisitor();
			Dictionary<Type, int> astStatistics = new Dictionary<Type, int>();

			visitor.BeginVisit += ( name, child ) =>
			{
				var type = child.GetType();

				if( astStatistics.ContainsKey( type ) )
					astStatistics[type]++;
				else
					astStatistics.Add( type, 1 );
			};

			visitor.BeginVisit( node.GetType().Name, node );
			visitor.EndVisit( node.GetType().Name, node );
			node.AcceptVisitor( visitor );

			foreach( var item in astStatistics.OrderByDescending( x => x.Value ) )
			{
				writer.WriteLine( "{0}: {1}", item.Key.Name, item.Value );
			}
		}
	}
}
