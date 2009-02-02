//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in GPLv3.txt
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICSharpCode.NRefactory.Ast;

namespace NObjective.ProxyGenerator
{
	internal static class NRefactoryExtensions
	{
		public static void AddAttribute( this AttributedNode typeDeclaration, string name, params Expression[] positionalArguments )
		{
			var section = new AttributeSection();

			section.Attributes.Add( new ICSharpCode.NRefactory.Ast.Attribute( name, positionalArguments.ToList(), null ) );

			typeDeclaration.Attributes.Add( section );
		}

		public static void AddAttribute( this AttributedNode typeDeclaration, string name, Expression[] positionalArguments, params NamedArgumentExpression[] namedArguments )
		{
			var section = new AttributeSection();

			section.Attributes.Add( new ICSharpCode.NRefactory.Ast.Attribute( name, positionalArguments.ToList(), namedArguments.ToList() ) );

			typeDeclaration.Attributes.Add( section );
		}

		public static FieldDeclaration AddField( this TypeDeclaration typeDeclaration, TypeReference typeReference, string name )
		{
			var result = new FieldDeclaration( null, typeReference, 0 );

			result.Fields.Add( new VariableDeclaration( name ) );
			typeDeclaration.AddChild( result );

			return result;
		}

		public static FieldDeclaration AddField( this TypeDeclaration typeDeclaration, string type, string name )
		{
			return AddField( typeDeclaration, new TypeReference( type ), name );
		}

		public static OperatorDeclaration AddImplicitConversionOperator( this TypeDeclaration typeDeclaration, string type )
		{
			var result = new OperatorDeclaration();

			result.Modifier = Modifiers.Public | Modifiers.Static;
			result.ConversionType = ConversionType.Implicit;
			result.Body = new BlockStatement();

			result.TypeReference = new TypeReference( type );
			result.Parameters.Add( new ParameterDeclarationExpression( new TypeReference( typeDeclaration.Name ), "value" ) );

			typeDeclaration.AddChild( result );

			return result;
		}

		public static MethodDeclaration AddMethod( this TypeDeclaration typeDeclaration, string name )
		{
			var result = new MethodDeclaration();

			result.Name = name;
			result.Modifier = Modifiers.Public;
			result.Body = new BlockStatement();
			typeDeclaration.AddChild( result );

			return result;
		}

		public static PropertyDeclaration AddProperty( this TypeDeclaration typeDeclaration, string name )
		{
			var result = new PropertyDeclaration( Modifiers.Public, null, name, null ); ;

			typeDeclaration.AddChild( result );

			return result;
		}

		public static ParameterDeclarationExpression AddParameter( this MethodDeclaration methodDeclaration, string name, string parameterType )
		{
			var result = new ParameterDeclarationExpression( new TypeReference( parameterType ), name );

			methodDeclaration.Parameters.Add( result );

			return result;
		}

		public static ConstructorDeclaration AddConstructor( this TypeDeclaration typeDeclaration, params ParameterDeclarationExpression[] parameters )
		{
			var constructorDeclaration = new ConstructorDeclaration( typeDeclaration.Name, 0, parameters.ToList(), null );

			constructorDeclaration.Modifier = Modifiers.Public;
			constructorDeclaration.Body = new BlockStatement();
			typeDeclaration.AddChild( constructorDeclaration );

			return constructorDeclaration;
		}

		public static OperatorDeclaration AddOperator( this TypeDeclaration typeDeclaration, OverloadableOperatorType @operator )
		{
			var result = new OperatorDeclaration();

			result.OverloadableOperator = @operator;
			result.Body = new BlockStatement();
			result.Modifier = Modifiers.Public | Modifiers.Static;

			result.Parameters.Add( new ParameterDeclarationExpression( new TypeReference( typeDeclaration.Name ), "value1" ) );
			result.Parameters.Add( new ParameterDeclarationExpression( new TypeReference( typeDeclaration.Name ), "value2" ) );

			typeDeclaration.AddChild( result );
			return result;
		}

		public static NamespaceDeclaration AddNamespace( this CompilationUnit compilationUnit, string name )
		{
			var @namespace = new NamespaceDeclaration( name );
			
			compilationUnit.AddChild( @namespace );
			
			return @namespace;
		}

		public static TypeDeclaration AddType( this NamespaceDeclaration namespaceDeclaration, string typeName )
		{
			var typeDeclaration = new TypeDeclaration( Modifiers.Public, null );

			typeDeclaration.Name = typeName;
			namespaceDeclaration.AddChild( typeDeclaration );

			return typeDeclaration;
		}
	}
}
