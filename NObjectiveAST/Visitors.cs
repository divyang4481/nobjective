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
using System.Xml;
using System.Xml.Serialization;

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

		public object AcceptChildren<T>( IEnumerable<T> node ) where T : Node
		{
			if( node == null )
				return null;

			foreach( var child in node )
				child.AcceptVisitor( this );

			return null;
		}

		protected void OnBeginVisit( string name, Node node )
		{
			BeginVisit( name, node );
		}

		protected void OnEndVisit( string name, Node node )
		{
			EndVisit( name, node );
		}

		protected void OnBeginVisitChildren( string name, Node node )
		{
			BeginVisitChildren( name, node );
		}

		protected void OnEndVisitChildren( string name, Node node )
		{
			EndVisitChildren( name, node );
		}
	}

	public sealed class StatisticsVisitor : TraversalVisitor
	{
		private static readonly XmlSerializer _serializer = new XmlSerializer( typeof( TranslationUnit ), System.Reflection.Assembly.GetExecutingAssembly().GetExportedTypes().Where( x => typeof( Node ).IsAssignableFrom( x ) ).ToArray() );

		public static void SaveAST( string filename, Node node )
		{
			using( var writer = new StreamWriter( filename, false, Encoding.UTF8 ) )
				_serializer.Serialize( writer, node );
		}

		public static Node LoadAST( string filename )
		{
			using( var reader = new StreamReader( filename ) )
				return ( Node ) _serializer.Deserialize( reader );
		}

		public static void PrintStatistics( string filename, Node node )
		{
			using( var writer = new StreamWriter( filename ) )
				PrintStatistics( writer, node );
		}

		public static void PrintStatistics( TextWriter writer, Node node )
		{
			var visitor = new StatisticsVisitor();
			var astStatistics = new Dictionary<Type, int>();

			visitor.BeginVisit += ( name, child ) =>
			{
				var type = child.GetType();

				if( astStatistics.ContainsKey( type ) )
					astStatistics[type]++;
				else
					astStatistics.Add( type, 1 );
			};

			visitor.OnBeginVisit( node.GetType().Name, node );
			visitor.OnEndVisit( node.GetType().Name, node );
			node.AcceptVisitor( visitor );

			foreach( var item in astStatistics.OrderByDescending( x => x.Value ) )
			{
				writer.WriteLine( "{0}: {1}", item.Key.Name, item.Value );
			}
		}
	}
}
