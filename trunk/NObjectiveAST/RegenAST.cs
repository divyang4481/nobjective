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
using ICSharpCode.NRefactory.Ast;
using System.Reflection;
using ICSharpCode.NRefactory.PrettyPrinter;
using System.IO;

namespace NObjectiveASTRegen
{
	internal static class RegenAST
	{
		[STAThread]
		private static void Main( string[] args )
		{
			var compilationUnit = new CompilationUnit();

			var @namespace = new NamespaceDeclaration( "NObjectiveAST" );
			compilationUnit.Children.Add( @namespace );

			var visitorsInterface = new TypeDeclaration( Modifiers.Public | Modifiers.Partial, null );
			visitorsInterface.Type = ClassType.Interface;
			visitorsInterface.Name = "IAstVisitor";

			var traversalVisitor = new TypeDeclaration( Modifiers.Public | Modifiers.Partial, null );
			traversalVisitor.Type = ClassType.Class;
			traversalVisitor.Name = "TraversalVisitor";
			traversalVisitor.BaseTypes = new List<TypeReference> { new TypeReference( visitorsInterface.Name ) };

			@namespace.Children.Add( visitorsInterface );
			@namespace.Children.Add( traversalVisitor );

			{
				var visitNode = new MethodDeclaration();
				visitNode.Modifier = Modifiers.Public;
				visitNode.Name = "Visit";
				visitNode.Parameters.Add( new ParameterDeclarationExpression( new TypeReference( "Node" ), "node" ) );
				visitNode.TypeReference = new TypeReference( "object" );
				visitNode.Body = new BlockStatement();
				visitNode.Body.Children.Add( new ReturnStatement( new InvocationExpression( new MemberReferenceExpression( new IdentifierExpression( "node" ), "AcceptVisitor" ), new List<Expression> { new ThisReferenceExpression() } ) ) );

				traversalVisitor.Children.Add( visitNode );
			}

			foreach( var nodeType in Assembly.GetExecutingAssembly().GetTypes().Where( x => !x.IsAbstract && x.GetClassHierarchy().Contains( typeof( NObjectiveAST.Node ) ) ).OrderBy( x => x.Name ) )
			{
				var visitMethod = new MethodDeclaration();
				visitMethod.Name = "Visit";
				visitMethod.Parameters.Add( new ParameterDeclarationExpression( new TypeReference( nodeType.Name ), "node" ) );
				visitMethod.TypeReference = new TypeReference( "object" );

				visitorsInterface.Children.Add( visitMethod );

				visitMethod = new MethodDeclaration();
				visitMethod.Body = new BlockStatement();
				visitMethod.Modifier = Modifiers.Public | Modifiers.Virtual;
				visitMethod.Name = "Visit";
				visitMethod.Parameters.Add( new ParameterDeclarationExpression( new TypeReference( nodeType.Name ), "node" ) );
				visitMethod.TypeReference = new TypeReference( "object" );

				foreach( var astField in nodeType.GetFields( BindingFlags.Instance | BindingFlags.NonPublic ).Where( x => x.FieldType.GetClassHierarchy().Contains( typeof( NObjectiveAST.Node ) ) ).Where( x => x.Name != "Parent" ).OrderBy( x => x.Name ) )
				{
					var block = new BlockStatement();
					block.AddChild( new ExpressionStatement( new InvocationExpression( new IdentifierExpression( "BeginVisit" ), new List<Expression> { new PrimitiveExpression( GetPropertyName( astField.Name ), GetPropertyName( astField.Name ) ), new MemberReferenceExpression( new IdentifierExpression( "node" ), GetPropertyName( astField.Name ) ) } ) ) );
					block.AddChild( new ExpressionStatement( new InvocationExpression( new MemberReferenceExpression( new MemberReferenceExpression( new IdentifierExpression( "node" ), GetPropertyName( astField.Name ) ), "AcceptVisitor" ), new List<Expression> { new ThisReferenceExpression() } ) ) );
					block.AddChild( new ExpressionStatement( new InvocationExpression( new IdentifierExpression( "EndVisit" ), new List<Expression> { new PrimitiveExpression( GetPropertyName( astField.Name ), GetPropertyName( astField.Name ) ), new MemberReferenceExpression( new IdentifierExpression( "node" ), GetPropertyName( astField.Name ) ) } ) ) );

					visitMethod.Body.AddChild( new IfElseStatement( new BinaryOperatorExpression( new MemberReferenceExpression( new IdentifierExpression( "node" ), GetPropertyName( astField.Name ) ), BinaryOperatorType.InEquality, new PrimitiveExpression( null, "null" ) ), block ) );
				}

				foreach( var astField in nodeType.GetFields( BindingFlags.Instance | BindingFlags.NonPublic ).Where( x => x.FieldType.IsGenericType && x.FieldType.GetGenericTypeDefinition() == typeof( List<> ) && x.FieldType.GetGenericArguments()[0].GetClassHierarchy().Contains( typeof( NObjectiveAST.Node ) ) ).OrderBy( x => x.Name ) )
				{
					var block = new BlockStatement();
					var foreachBlock = new BlockStatement();
					foreachBlock.AddChild( new ExpressionStatement( new InvocationExpression( new IdentifierExpression( "BeginVisit" ), new List<Expression> { new PrimitiveExpression( GetPropertyName( astField.Name ), GetPropertyName( astField.Name ) ), new IdentifierExpression( "item" ) } ) ) );
					foreachBlock.AddChild( new ExpressionStatement( new InvocationExpression( new MemberReferenceExpression( new IdentifierExpression( "item" ), "AcceptVisitor" ), new List<Expression> { new ThisReferenceExpression() } ) ) );
					foreachBlock.AddChild( new ExpressionStatement( new InvocationExpression( new IdentifierExpression( "EndVisit" ), new List<Expression> { new PrimitiveExpression( GetPropertyName( astField.Name ), GetPropertyName( astField.Name ) ), new IdentifierExpression( "item" ) } ) ) );

					block.AddChild( new ExpressionStatement( new InvocationExpression( new IdentifierExpression( "BeginVisitChildren" ), new List<Expression> { new PrimitiveExpression( GetPropertyName( astField.Name ), GetPropertyName( astField.Name ) ), new MemberReferenceExpression( new IdentifierExpression( "node" ), GetPropertyName( astField.Name ) ) } ) ) );
					block.AddChild( new ForeachStatement( new TypeReference( "var" ), "item", new MemberReferenceExpression( new IdentifierExpression( "node" ), GetPropertyName( astField.Name ) ), foreachBlock ) );
					block.AddChild( new ExpressionStatement( new InvocationExpression( new IdentifierExpression( "EndVisitChildren" ), new List<Expression> { new PrimitiveExpression( GetPropertyName( astField.Name ), GetPropertyName( astField.Name ) ), new MemberReferenceExpression( new IdentifierExpression( "node" ), GetPropertyName( astField.Name ) ) } ) ) );

					visitMethod.Body.AddChild( new IfElseStatement( new BinaryOperatorExpression( new MemberReferenceExpression( new IdentifierExpression( "node" ), GetPropertyName( astField.Name ) ), BinaryOperatorType.InEquality, new PrimitiveExpression( null, "null" ) ), block ) );
				}

				visitMethod.Body.Children.Add( new ReturnStatement( new PrimitiveExpression( null, "null" ) ) );

				traversalVisitor.Children.Add( visitMethod );

				var astNodeExtension = new TypeDeclaration( Modifiers.Public, null );
				astNodeExtension.Type = ClassType.Class;
				astNodeExtension.Modifier |= Modifiers.Partial;
				astNodeExtension.Name = nodeType.Name;

				var acceptVisitor = new MethodDeclaration();
				acceptVisitor.Modifier = Modifiers.Public | Modifiers.Override;
				acceptVisitor.Name = "AcceptVisitor";
				acceptVisitor.Attributes.Add( new AttributeSection { Attributes = new List<ICSharpCode.NRefactory.Ast.Attribute> { new ICSharpCode.NRefactory.Ast.Attribute( typeof( DebuggerStepThroughAttribute ).Name, null, null ) } } );
				acceptVisitor.Parameters.Add( new ParameterDeclarationExpression( new TypeReference( "IAstVisitor" ), "visitor" ) );
				acceptVisitor.TypeReference = new TypeReference( "object" );
				acceptVisitor.Body = new BlockStatement();
				acceptVisitor.Body.Children.Add( new ReturnStatement( new InvocationExpression( new MemberReferenceExpression( new IdentifierExpression( "visitor" ), "Visit" ), new List<Expression> { new ThisReferenceExpression() } ) ) );

				foreach( var item in nodeType.GetFields( BindingFlags.Instance | BindingFlags.NonPublic ).Where( x => x.Name.StartsWith( "_" ) ) )
				{
					var getBlock = new BlockStatement();
					var setBlock = new BlockStatement();

					getBlock.AddChild( new ReturnStatement( new IdentifierExpression( item.Name ) ) );
					setBlock.AddChild( new ExpressionStatement( new AssignmentExpression( new IdentifierExpression( item.Name ), AssignmentOperatorType.Assign, new InvocationExpression( new IdentifierExpression( "SetParent" ), new List<Expression> { new IdentifierExpression( "value" ) } ) ) ) );

					var property = new PropertyDeclaration( Modifiers.Public, null, GetPropertyName( item.Name ), null );
					property.TypeReference = GetTypeReference( item.FieldType );
					property.GetRegion = new PropertyGetRegion( getBlock, null );
					property.SetRegion = new PropertySetRegion( setBlock, null );

					astNodeExtension.AddChild( property );
				}

				astNodeExtension.Children.Add( acceptVisitor );
				@namespace.Children.Add( astNodeExtension );
			}

			var outputVisitor = new CSharpOutputVisitor();
			outputVisitor.VisitCompilationUnit( compilationUnit, null );

			//using( var writer )
			File.WriteAllText( @"..\..\Visitors.Generated.cs", NObjectiveAST.Properties.Resources.FileHeader + outputVisitor.Text );
		}

		private static string GetPropertyName( string name )
		{
			return char.ToUpper( name[1] ) + name.Substring( 2 );
		}

		private static TypeReference GetTypeReference( Type type )
		{
			var result = new TypeReference( "" );

			if( type.IsGenericType )
			{
				result.Type = type.GetGenericTypeDefinition().Name.Split( '`' )[0];

				foreach( var genericArgument in type.GetGenericArguments() )
				{
					result.GenericTypes.Add( GetTypeReference( genericArgument ) );
				}
			}
			else
				result.Type = type.Name;

			return result;
		}

		internal static IEnumerable<Type> GetClassHierarchy( this Type type )
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

namespace NObjectiveAST
{
	public class OutputVisitor
	{
		public static string GetNodeText( NObjectiveAST.Node node )
		{
			return "";
		}
	}
}