//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in GPLv3.txt
//

using System;
using System.CodeDom;

namespace NObjective.ProxyGenerator
{
	internal static class CodeCompileUnitExtensions
	{
		public static CodeNamespace AddNamespace( this CodeCompileUnit compileUnit, string @namespace )
		{
			var result = new CodeNamespace( @namespace );
			compileUnit.Namespaces.Add( result );
			return result;
		}
	}

	internal static class CodeNamespaceExtensions
	{
		public static CodeNamespaceImport AddImport( this CodeNamespace @namespace, string import )
		{
			var result = new CodeNamespaceImport( import );
			@namespace.Imports.Add( result );
			return result;
		}

		public static CodeTypeDeclaration AddType( this CodeNamespace @namespace, string type )
		{
			var result = new CodeTypeDeclaration( type );
			@namespace.Types.Add( result );
			return result;
		}
	}

	internal static class CodeTypeDeclarationExtensions
	{
		public static void AddSummary( this CodeTypeDeclaration declaration, string summary )
		{
			if( summary == null )
				return;

			declaration.Comments.Add( new CodeCommentStatement( "<summary>", true ) );
			declaration.Comments.Add( new CodeCommentStatement( summary, true ) );
			declaration.Comments.Add( new CodeCommentStatement( "</summary>", true ) );
		}

		public static CodeMemberField AddField( this CodeTypeDeclaration declaration, string type, string name )
		{
			var result = new CodeMemberField( type, name );
			declaration.Members.Add( result );
			return result;
		}

		public static CodeMemberField AddField( this CodeTypeDeclaration declaration, Type type, string name )
		{
			var result = new CodeMemberField( type, name );
			declaration.Members.Add( result );
			return result;
		}

		public static CodeMemberMethod AddMethod( this CodeTypeDeclaration declaration, string name )
		{
			var result = new CodeMemberMethod { Name = name, Attributes = ( MemberAttributes.Public | MemberAttributes.Final ) };
			declaration.Members.Add( result );
			return result;
		}

		public static CodeMemberMethod AddMethod( this CodeTypeDeclaration declaration, string name, Type returnType )
		{
			var result = new CodeMemberMethod
			{
				Name = name,
				ReturnType = new CodeTypeReference( returnType ),
				Attributes = ( MemberAttributes.Public | MemberAttributes.Final )
			};
			declaration.Members.Add( result );
			return result;
		}

		public static CodeMemberMethod AddMethod( this CodeTypeDeclaration declaration, string name, string returnType )
		{
			var result = new CodeMemberMethod
			{
				Name = name,
				Attributes = ( MemberAttributes.Public | MemberAttributes.Final ),
				ReturnType = new CodeTypeReference( returnType )
			};
			declaration.Members.Add( result );
			return result;
		}

		public static CodeConstructor AddConstructor( this CodeTypeDeclaration declaration, params CodeParameterDeclarationExpression[] parameters )
		{
			var result = new CodeConstructor
			{
				Name = declaration.Name,
				Attributes = ( MemberAttributes.Public | MemberAttributes.Final )
			};
			result.Parameters.AddRange( parameters );
			declaration.Members.Add( result );
			return result;
		}

		public static CodeMemberMethod AddImplicitOperator( this CodeTypeDeclaration declaration, string toType )
		{
			var result = declaration.AddMethod( "implicit operator " + toType, toType );
			result.AddParameter( "value", declaration.Name );
			result.Attributes = MemberAttributes.Public | MemberAttributes.Static;

			result.ReturnType = new CodeTypeReference();
			return result;
		}

		public static CodeMemberMethod AddEqualityOperator( this CodeTypeDeclaration declaration )
		{
			var result = declaration.AddMethod( "operator ==", typeof( bool ) );
			result.AddParameter( "value1", declaration.Name );
			result.AddParameter( "value2", declaration.Name );
			result.Attributes = MemberAttributes.Public | MemberAttributes.Static;
			return result;
		}

		public static CodeMemberMethod AddInequalityOperator( this CodeTypeDeclaration declaration )
		{
			var result = declaration.AddMethod( "operator !=", typeof( bool ) );
			result.AddParameter( "value1", declaration.Name );
			result.AddParameter( "value2", declaration.Name );
			result.Attributes = MemberAttributes.Public | MemberAttributes.Static;
			return result;
		}

		public static CodeMemberMethod AddImplicitOperator( this CodeTypeDeclaration declaration, Type toType )
		{
			var result = declaration.AddMethod( "implicit operator " + toType.FullName );
			result.Attributes |= MemberAttributes.Static;
			result.AddParameter( "value", declaration.Name );
			result.Attributes = MemberAttributes.Public | MemberAttributes.Static;

			result.ReturnType = new CodeTypeReference();
			return result;
		}
	}

	internal static class CodeMemberMethodExtensions
	{
		public static void AddSummary( this CodeMemberMethod declaration, string summary )
		{
			if( summary == null )
				return;

			declaration.Comments.Add( new CodeCommentStatement( "<summary>", true ) );
			declaration.Comments.Add( new CodeCommentStatement( summary, true ) );
			declaration.Comments.Add( new CodeCommentStatement( "</summary>", true ) );
		}

		public static CodeParameterDeclarationExpression AddParameter( this CodeMemberMethod method, string name, string type )
		{
			var result = new CodeParameterDeclarationExpression { Name = name, Type = new CodeTypeReference( type ) };
			method.Parameters.Add( result );
			return result;
		}

		public static CodeParameterDeclarationExpression AddParameter( this CodeMemberMethod method, string name, Type type )
		{
			var result = new CodeParameterDeclarationExpression
			{
				Name = name,
				Type = new CodeTypeReference( type )
			};
			method.Parameters.Add( result );
			return result;
		}
	}

	internal static class CodeExpressionExtensions
	{
		public static CodeExpression InvokeMethod( this CodeExpression left, string methodName, params CodeExpression[] parameters )
		{
			var result = new CodeMethodInvokeExpression( left, methodName, parameters );
			return result;
		}
	}
}