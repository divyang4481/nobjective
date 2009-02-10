//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Token = NObjectiveAST.Lexer.Token;
using Tokens = NObjectiveAST.Lexer.Tokens;
using System.Diagnostics;
using System.IO;

namespace NObjectiveAST
{
	public class OutputVisitor : TraversalVisitor
	{
		public OutputOptions Options { get; set; }

		private StringBuilder _text = new StringBuilder();

		public OutputVisitor()
		{
			Options = OutputOptions.DefaultOptions;
		}

		public OutputVisitor( OutputOptions options )
		{
			Options = options;
		}

		public static void Write( string filename, Node node )
		{
			var visitor = new OutputVisitor();

			node.AcceptVisitor( visitor );

			File.WriteAllText( filename, visitor.Text );
		}

		public static string GetNodeText( Node node )
		{
			var printer = new OutputVisitor();

			node.AcceptVisitor( printer );

			return printer.Text;
		}

		public static string GetNodeText( Node node, OutputOptions options )
		{
			var printer = new OutputVisitor( options );

			node.AcceptVisitor( printer );

			return printer.Text;
		}

		public string Text
		{
			get { return _text.ToString(); }
			set
			{
				_text.Length = 0;
				_text.Append( value );
			}
		}

		private void Print( Tokens token )
		{
			_text.Append( Lexer.GetTokenString( token ) );
		}

		private void PrintWord( Tokens token )
		{
			if( _text.Length > 0 && _text[_text.Length - 1] != '\t' && _text[_text.Length - 1] != ' ' && _text[_text.Length - 1] != '\r' && _text[_text.Length - 1] != '\n' )
				PrintSpace();

			_text.Append( Lexer.GetTokenString( token ) );

			PrintSpace();
		}

		private void PrintWord( string @string )
		{
			if( @string == null )
				return;

			if( _text.Length > 0 && _text[_text.Length - 1] != '\t' && _text[_text.Length - 1] != ' ' && _text[_text.Length - 1] != '\r' && _text[_text.Length - 1] != '\n' )
				PrintSpace();

			Print( @string );

			PrintSpace();
		}

		private void Print( string @string )
		{
			_text.Append( @string );
		}

		private void Print( string @string, params object[] parameters )
		{
			_text.AppendFormat( @string, parameters );
		}

		private void Insert( Tokens token )
		{
			_text.Insert( 0, Lexer.GetTokenString( token ) );
		}

		private void Insert( string @string )
		{
			_text.Insert( 0, @string );
		}

		private void Insert( string @string, params object[] parameters )
		{
			_text.Insert( 0, string.Format( @string, parameters ) );
		}

		private void Print( StringBuilder stringBuilder )
		{
			_text.Append( stringBuilder );
		}

		private void PrintSpace()
		{
			_text.Append( ' ' );
		}

		private void PrintSpace( bool condition )
		{
			if( condition )
				_text.Append( ' ' );
		}

		private void InsertSpace()
		{
			_text.Insert( 0, ' ' );
		}

		private void InsertSpace( bool condition )
		{
			if( condition )
				_text.Insert( 0, ' ' );
		}

		[DebuggerStepThrough]
		private void PrintCommaSeparatedList<T>( List<T> values ) where T : Node
		{
			if( values == null )
				return;

			bool needComma = false;

			foreach( var item in values )
			{
				if( needComma ) Print( ", " );
				else needComma = true;

				item.AcceptVisitor( this );
			}
		}

		[DebuggerStepThrough]
		private void PrintSeparatedList<T>( string separator, List<T> values ) where T : Node
		{
			if( values == null )
				return;

			bool needComma = false;

			foreach( var item in values )
			{
				if( needComma ) Print( separator );
				else needComma = true;

				item.AcceptVisitor( this );
			}
		}

		private void PrintCommaSeparatedList( List<string> values )
		{
			PrintSeparatedList( ", ", values );
		}

		private void PrintSeparatedList( string separator, List<string> values )
		{
			if( values == null )
				return;

			bool needSeparator = false;

			foreach( var item in values )
			{
				if( needSeparator ) Print( separator );
				else needSeparator = true;

				Print( item );
			}
		}

		private int _currentIndent = 0;
		private void NewLine()
		{
			if( _text.Length == 0 )
				return;

			_text.Append( Environment.NewLine );
			_text.Append( new string( '\t', _currentIndent ) );
		}

		private void PrintTypeReference( TypeReference typeReference, TypeReference printUpTo, string identifier )
		{
			using( NewOutputContext() )
			{
				var currentElement = typeReference;
				var previousElement = typeReference;

				var endElement = printUpTo;

				while( currentElement != null && currentElement != endElement )
				{
					switch( currentElement.TypeKind )
					{
						case TypeKind.Normal:
							if( currentElement.MemberOf != null )
							{
								Insert( "::" );
								Insert( currentElement.MemberOf.ToString() );
							}
							
							InsertSpace();
							Insert( currentElement.TypeName );

							if( ( currentElement.Modifiers & TypeModifiers.Const ) != 0 )
								Insert( "const " );

							if( ( currentElement.Modifiers & TypeModifiers.Volatile ) != 0 )
								Insert( "volatile " );

							break;

						case TypeKind.Bitset:
							Print( "{0}:{1}", identifier, GetNodeText( currentElement.Size, Options ) );
							identifier = null;
							break;

						case TypeKind.Array:
							Print( "{0}[{1}]", identifier, GetNodeText( currentElement.Size, Options ) );
							identifier = null;
							break;

						case TypeKind.Pointer:
							Insert( identifier );
							if( ( currentElement.Modifiers & TypeModifiers.Const ) != 0 )
								Insert( "const " );

							if( ( currentElement.Modifiers & TypeModifiers.Restrict ) != 0 )
								Insert( "restrict " );

							if( ( currentElement.Modifiers & TypeModifiers.Volatile ) != 0 )
								Insert( "volatile " );

							InsertSpace();
							Insert( Tokens.Multiply );

							if( currentElement.MemberOf != null )
							{
								Insert( "::" );
								Insert( currentElement.MemberOf.ToString() );
							}

							identifier = null;
							break;

						case TypeKind.Reference:
							Insert( identifier );
							Insert( Tokens.BitwiseAnd );
							identifier = null;
							break;

						case TypeKind.Function:
						case TypeKind.RedefinableOperator:
							if( previousElement.TypeKind == TypeKind.Pointer || previousElement.TypeKind == TypeKind.Reference )
							{
								InsertSpace( Options.SpacesInsideParenthesis );
								Insert( Tokens.OpenParenthesis );
							}

							if( previousElement.TypeKind == TypeKind.Pointer || previousElement.TypeKind == TypeKind.Reference )
							{
								PrintSpace( Options.SpacesInsideParenthesis );
								Print( Tokens.CloseParenthesis );
							}

							if( currentElement.TypeKind == TypeKind.RedefinableOperator )
							{
								Print( Tokens._operator );
								PrintSpace();

								switch( currentElement.Operator )
								{
									case RedefinableOperators.Comma:
										Print( Tokens.Comma );
										break;
									case RedefinableOperators.Not:
										Print( Tokens.Not );
										break;
									case RedefinableOperators.Inequality:
										Print( Tokens.Inequality );
										break;
									case RedefinableOperators.Modulus:
										Print( Tokens.Mod );
										break;
									case RedefinableOperators.ModulusAssign:
										Print( Tokens.ModulusAssign );
										break;
									case RedefinableOperators.BitwiseAnd:
										Print( Tokens.BitwiseAnd );
										break;
									case RedefinableOperators.AddressOf:
										Print( Tokens.BitwiseAnd );
										break;
									case RedefinableOperators.LogicalAnd:
										Print( Tokens.LogicalAnd );
										break;
									case RedefinableOperators.BitwiseAndAssign:
										Print( Tokens.BitwiseAndAssign );
										break;
									case RedefinableOperators.FunctionCall:
										Print( Tokens.OpenParenthesis );
										Print( Tokens.CloseParenthesis );
										break;
									case RedefinableOperators.Cast:
										Print( Tokens.Comma );
										break;
									case RedefinableOperators.Multiply:
										Print( Tokens.Multiply );
										break;
									case RedefinableOperators.Indirection:
										Print( Tokens.Multiply );
										break;
									case RedefinableOperators.MultiplyAssign:
										Print( Tokens.MultiplyAssign );
										break;
									case RedefinableOperators.Add:
										Print( Tokens.Plus );
										break;
									case RedefinableOperators.Plus:
										Print( Tokens.Plus );
										break;
									case RedefinableOperators.Increment:
										Print( Tokens.Increment );
										break;
									case RedefinableOperators.AddAssign:
										Print( Tokens.AddAssign );
										break;
									case RedefinableOperators.Subtract:
										Print( Tokens.Minus );
										break;
									case RedefinableOperators.Minus:
										Print( Tokens.Minus );
										break;
									case RedefinableOperators.Decrement:
										Print( Tokens.Decrement );
										break;
									case RedefinableOperators.SubtractAssign:
										Print( Tokens.SubtractAssign );
										break;
									case RedefinableOperators.MemberSelection:
										Print( Tokens.MemberSelection );
										break;
									case RedefinableOperators.PointerToMemberSelection:
										Print( Tokens.PointerToMemberAccessFromPointer );
										break;
									case RedefinableOperators.Div:
										Print( Tokens.Div );
										break;
									case RedefinableOperators.DivideAssign:
										Print( Tokens.DivideAssign );
										break;
									case RedefinableOperators.LessThan:
										Print( Tokens.LessThan );
										break;
									case RedefinableOperators.ShiftLeft:
										Print( Tokens.ShiftLeft );
										break;
									case RedefinableOperators.ShiftLeftAssign:
										Print( Tokens.ShiftLeftAssign );
										break;
									case RedefinableOperators.LessEqual:
										Print( Tokens.LessThanOrEqual );
										break;
									case RedefinableOperators.Assign:
										Print( Tokens.Assign );
										break;
									case RedefinableOperators.Equality:
										Print( Tokens.Equality );
										break;
									case RedefinableOperators.GreaterThan:
										Print( Tokens.GreaterThan );
										break;
									case RedefinableOperators.GreaterEqual:
										Print( Tokens.GreaterThanOrEqual );
										break;
									case RedefinableOperators.RightShift:
										Print( Tokens.GreaterThan );
										Print( Tokens.GreaterThan );
										break;
									case RedefinableOperators.RightShiftAssign:
										Print( Tokens.GreaterThan );
										Print( Tokens.GreaterThan );
										Print( Tokens.Assign );
										break;
									case RedefinableOperators.ArraySubscript:
										Print( Tokens.OpenSquareBracket );
										Print( Tokens.CloseSquareBracket );
										break;
									case RedefinableOperators.Xor:
										Print( Tokens.Xor );
										break;
									case RedefinableOperators.XorAssign:
										Print( Tokens.XorAssign );
										break;
									case RedefinableOperators.BitwiseOr:
										Print( Tokens.BitwiseOr );
										break;
									case RedefinableOperators.BitwiseOrAssign:
										Print( Tokens.BitwiseOrAssign );
										break;
									case RedefinableOperators.LogicalOr:
										Print( Tokens.LogicalOr );
										break;
									case RedefinableOperators.BitwiseComplement:
										Print( Tokens.BitwiseComplement );
										break;
									case RedefinableOperators.Delete:
										Print( Tokens._delete );
										break;
									case RedefinableOperators.New:
										Print( Tokens._new );
										break;
									default:
										break;
								}
							}
							else
							{
								Print( identifier );
								identifier = null;
							}

							Print( GetNodeText( currentElement.ParameterDeclaration, Options ) );

							if( ( currentElement.Modifiers & TypeModifiers.Const ) != 0 )
							{
								PrintSpace();
								Print( Tokens._const );
							}

							currentElement = currentElement.ReturnType;
							continue;

						case TypeKind.RValueReference:
							Insert( identifier );
							Insert( Tokens.LogicalAnd );
							identifier = null;
							break;

						default:
							break;
					}

					previousElement = currentElement;
					currentElement = currentElement.ElementType;
				}

				Print( identifier );

				if( _text.Length > 0 && _text[_text.Length - 1] == ' ' )
					_text.Length--;
			}
		}

		public override object Visit( DeclarationExpression node )
		{
			if( ( node.Modifiers & DeclarationExpression.DeclarationModifiers.Auto ) != 0 )
				PrintWord( Tokens._auto );

			if( ( node.Modifiers & DeclarationExpression.DeclarationModifiers.Extern ) != 0 )
				PrintWord( Tokens._extern );

			if( ( node.Modifiers & DeclarationExpression.DeclarationModifiers.Inline ) != 0 )
				PrintWord( Tokens._inline );

			if( ( node.Modifiers & DeclarationExpression.DeclarationModifiers.Register ) != 0 )
				PrintWord( Tokens._register );

			if( ( node.Modifiers & DeclarationExpression.DeclarationModifiers.Static ) != 0 )
				PrintWord( Tokens._static );

			if( node.TypeDeclarationExpression != null )
				node.TypeDeclarationExpression.AcceptVisitor( this );
			else
				PrintTypeReference( node.TypeReference, null, null );

			PrintSpace();

			PrintCommaSeparatedList( node.Declarations );

			return null;
		}

		public override object Visit( DeclarationNode node )
		{
			var declarationExpression = node.Parent as DeclarationExpression;
			PrintTypeReference( node.TypeReference, declarationExpression != null ? declarationExpression.TypeReference : null, node.Name );

			if( node.InitializerExpression != null )
			{
				PrintSpace();
				Print( Tokens.Assign );
				PrintSpace();

				node.InitializerExpression.AcceptVisitor( this );
			}

			return null;
		}

		public override object Visit( TypedefStatement node )
		{
			NewLine();
			Print( Tokens._typedef );
			PrintSpace();

			node.DeclarationExpression.AcceptVisitor( this );

			Print( Tokens.Semicolon );

			return null;
		}

		public override object Visit( ExpressionStatement node )
		{
			NewLine();

			node.Expression.AcceptVisitor( this );

			Print( Tokens.Semicolon );

			return null;
		}

		public override object Visit( ParameterDeclaration node )
		{
			Print( Tokens.OpenParenthesis );
			if( node.Parameters.Count > 0 )
			{
				PrintSpace( Options.SpacesInsideParameterDeclaration );

				PrintCommaSeparatedList( node.Parameters );

				PrintSpace( Options.SpacesInsideParameterDeclaration );
			}
			Print( Tokens.CloseParenthesis );

			return null;
		}

		public override object Visit( PrimitiveExpression node )
		{
			Print( node.Value.ToString() );

			return null;
		}

		public override object Visit( ParenthesizedExpression node )
		{
			Print( Tokens.OpenParenthesis );
			PrintSpace( Options.SpacesInsideParenthesis );

			base.Visit( node );

			PrintSpace( Options.SpacesInsideParenthesis );
			Print( Tokens.CloseParenthesis );

			return null;
		}

		public override object Visit( ObjectiveTypeForwardDeclarationStatement node )
		{
			NewLine();

			switch( node.Type )
			{
				case ObjectiveTypes.Class:
					Print( Tokens.at_class );
					break;

				case ObjectiveTypes.Protocol:
					Print( Tokens.at_protocol );
					break;

				default:
				case ObjectiveTypes.Invalid:
					Debugger.Break();
					return null;
			}

			PrintSpace();

			PrintCommaSeparatedList( node.Names );
			Print( Tokens.Semicolon );

			return null;
		}

		public override object Visit( BreakStatement node )
		{
			Print( Tokens._break );

			return null;
		}

		public override object Visit( ContinueStatement node )
		{
			Print( Tokens._continue );

			return null;
		}

		public override object Visit( ReturnStatement node )
		{
			Print( Tokens._return );

			return node.AcceptVisitor( this );
		}

		public override object Visit( AssignmentExpression node )
		{
			node.Left.AcceptVisitor( this );

			PrintSpace();
			AssignmentExpression.GetOperatorString( node.Operator );
			PrintSpace();

			node.Right.AcceptVisitor( this );

			return null;
		}

		public override object Visit( BinaryOperatorExpression node )
		{
			node.Left.AcceptVisitor( this );

			PrintSpace( Options.SpacesAroundBinaryOperators );
			Print( BinaryOperatorExpression.GetOperatorString( node.Operator ) );
			PrintSpace( Options.SpacesAroundBinaryOperators );

			node.Right.AcceptVisitor( this );

			return null;
		}

		public override object Visit( CommaExpression node )
		{
			node.Left.AcceptVisitor( this );

			Print( Tokens.Comma );
			PrintSpace();

			node.Right.AcceptVisitor( this );

			return null;
		}

		public override object Visit( ThrowStatement node )
		{
			Print( Tokens._throw );
			PrintSpace();

			node.Expression.AcceptVisitor( this );

			return null;
		}

		public override object Visit( ConditionalExpression node )
		{
			node.ConditionExpression.AcceptVisitor( this );

			PrintSpace();
			Print( Tokens.Question );
			PrintSpace();

			node.TrueExpression.AcceptVisitor( this );

			PrintSpace();
			Print( Tokens.Colon );
			PrintSpace();

			node.FalseExpression.AcceptVisitor( this );

			return null;
		}

		public override object Visit( UnaryOperatorExpression node )
		{
			if( node.IsPostfix )
			{
				node.Expression.AcceptVisitor( this );
				Print( UnaryOperatorExpression.GetOperatorString( node.Operator ) );
			}
			else
			{
				Print( UnaryOperatorExpression.GetOperatorString( node.Operator ) );
				node.Expression.AcceptVisitor( this );
			}

			return null;
		}

		public override object Visit( QualifiedIdentifierExpression node )
		{
			AcceptNode( node.QualifiedName );

			return null;
		}

		public override object Visit( SizeofExpression node )
		{
			Print( Tokens._sizeof );

			Print( Tokens.OpenParenthesis );
			PrintSpace();

			node.Node.AcceptVisitor( this );

			PrintSpace();
			Print( Tokens.CloseParenthesis );

			return null;
		}

		public override object Visit( TypeReference node )
		{
			PrintTypeReference( node, null, null );

			return null;
		}

		public override object Visit( TemplateParameterDeclaration node )
		{
			AcceptNode( node.TemplateParametersDeclaration );
			PrintSpace( node.TemplateParametersDeclaration != null );

			switch( node.ParameterType )
			{
				case TemplateParameterType.Type:
					node.TypeReference.AcceptVisitor( this );
					PrintSpace();
					Print( node.Name );
					break;

				case TemplateParameterType.Class:
					Print( Tokens._class );
					PrintSpace();

					Print( node.Name );
					break;

				case TemplateParameterType.Typename:
					Print( Tokens._typename );
					PrintSpace();

					Print( node.Name );
					break;

				case TemplateParameterType.Invalid:
				default:
					break;
			}

			if( node.Initializer != null )
			{
				PrintSpace();
				Print( Tokens.Assign );
				PrintSpace();

				node.Initializer.AcceptVisitor( this );
			}

			return null;
		}

		public override object Visit( TemplateParametersDeclaration node )
		{
			Print( Tokens._template );
			Print( Tokens.LessThan );

			PrintCommaSeparatedList( node.Parameters );

			Print( Tokens.GreaterThan );
			return null;
		}

		public override object Visit( TypeDeclarationExpression node )
		{
			AcceptNode( node.TemplateParametersDeclaration );
			if( node.TemplateParametersDeclaration != null )
				NewLine();

			switch( node.Type )
			{
				case TypeDeclarationExpression.TypeKind.Class:
					Print( Tokens._class );
					break;
				case TypeDeclarationExpression.TypeKind.Struct:
					Print( Tokens._struct );
					break;
				case TypeDeclarationExpression.TypeKind.Union:
					Print( Tokens._union );
					break;
				case TypeDeclarationExpression.TypeKind.Enum:
					Print( Tokens._enum );
					break;

				default:
				case TypeDeclarationExpression.TypeKind.Invalid:
					break;
			}

			PrintWord( node.Name +"" );

			if( node.Body != null )
			{
				using( NewBraceScope() )
				{
					for( int i = 0; i < node.Body.Count; i++ )
					{
						bool lastElement = i == node.Body.Count - 1;

						node.Body[i].AcceptVisitor( this );

						if( node.Type == TypeDeclarationExpression.TypeKind.Enum )
							if( !lastElement )
								Print( Tokens.Comma );
					}
				}
			}

			return null;
		}

		public override object Visit( FunctionDefinitionStatement node )
		{
			NewLine();

			if( ( node.Modifiers & FunctionDefinitionStatement.FunctionModifiers.Static ) != 0 )
				PrintWord( Tokens._static );

			if( ( node.Modifiers & FunctionDefinitionStatement.FunctionModifiers.Inline ) != 0 )
				PrintWord( Tokens._inline );

			if( ( node.Modifiers & FunctionDefinitionStatement.FunctionModifiers.ForceInline ) != 0 )
				PrintWord( Tokens.___forceinline );

			node.DeclarationNode.AcceptVisitor( this );
			PrintSpace();

			using( NewBraceScope() ) ;

			return null;
		}

		public override object Visit( EnumElementDeclaration node )
		{
			NewLine();

			Print( node.Name );

			if( node.InitializerExpression != null )
			{
				PrintSpace();
				Print( Tokens.Assign );
				PrintSpace();

				node.InitializerExpression.AcceptVisitor( this );
			}

			return null;
		}

		public override object Visit( MemberAccessSpecifier node )
		{
			_text.Length--;

			switch( node.AccessKind )
			{
				case MemberAccessKind.Public:
					Print( Tokens._public );
					Print( Tokens.Colon );
					break;

				case MemberAccessKind.Protected:
					Print( Tokens._protected );
					Print( Tokens.Colon );
					break;

				case MemberAccessKind.Private:
					Print( Tokens._private );
					Print( Tokens.Colon );
					break;

				default:
				case MemberAccessKind.Invalid:
					break;
			}

			return base.Visit( node );
		}

		public override object Visit( QualifiedNestedName node )
		{
			Print( node.Name );
			if( node.GenericArguments != null )
			{
				Print( Tokens.LessThan );

				foreach( var genericArgument in node.GenericArguments )
					genericArgument.AcceptVisitor( this );

				Print( Tokens.GreaterThan );
			}

			return null;
		}

		public override object Visit( QualifiedName node )
		{
			PrintSeparatedList( "::", node.NestedNames );

			return null;
		}

		public override object Visit( CaseLabel node )
		{
			NewLine();

			Print( Tokens._case );
			PrintSpace();

			node.Expression.AcceptVisitor( this );

			Print( Tokens.Colon );
			NewLine();

			return null;
		}

		public override object Visit( CastExpression node )
		{
			switch( node.CastType )
			{
				case CastExpression.CastTypes.Const:
					Print( Tokens._const_cast );
					goto cpp_cast;

				case CastExpression.CastTypes.Dynamic:
					Print( Tokens._dynamic_cast );
					goto cpp_cast;

				case CastExpression.CastTypes.Reinterpret:
					Print( Tokens._reinterpret_cast );
					goto cpp_cast;

				case CastExpression.CastTypes.Static:
					Print( Tokens._static_cast );
					goto cpp_cast;

				case CastExpression.CastTypes.C:
					Print( Tokens.OpenParenthesis );
					PrintSpace();

					node.TypeReference.AcceptVisitor( this );

					PrintSpace();
					Print( Tokens.CloseParenthesis );
					PrintSpace();

					node.Expression.AcceptVisitor( this );
					break;

				case CastExpression.CastTypes.Explicit:
					node.TypeReference.AcceptVisitor( this );

					Print( Tokens.OpenParenthesis );
					PrintSpace();

					node.Expression.AcceptVisitor( this );

					PrintSpace();
					Print( Tokens.CloseParenthesis );

					break;

				default:
				case CastExpression.CastTypes.Invalid:
					break;
			}

			return null;

		cpp_cast:
			Print( Tokens.LessThan );
			node.TypeReference.AcceptVisitor( this );
			Print( Tokens.GreaterThan );

			Print( Tokens.OpenParenthesis );
			PrintSpace();

			node.Expression.AcceptVisitor( this );

			PrintSpace();
			Print( Tokens.CloseParenthesis );

			return null;
		}

		public override object Visit( UsingDeclarationStatement node )
		{
			NewLine();
			PrintWord( Tokens._using );

			node.TypeReference.AcceptVisitor( this );

			Print( Tokens.Semicolon );

			return null;
		}

		public override object Visit( UsingDirectiveStatement node )
		{
			NewLine();
			PrintWord( Tokens._using );
			PrintWord( Tokens._namespace );

			PrintSeparatedList( "::", node.Namespace );
			Print( Tokens.Semicolon );

			return null;
		}

		public override object Visit( TranslationUnit node )
		{
			return base.Visit( node );
		}

		public override object Visit( NamespaceDeclaration node )
		{
			NewLine();

			Print( Tokens._namespace );
			PrintSpace();
			PrintWord( node.Name );

			using( NewBraceScope() )
				base.Visit( node );

			return null;
		}

		public override object Visit( ObjectiveMethodDeclarationStatement node )
		{
			NewLine();

			if( ( node.Modifiers & ObjectiveMethodDeclarationStatement.MethodModifiers.InstanceMethod ) != 0 )
				Print( Tokens.Minus );

			if( ( node.Modifiers & ObjectiveMethodDeclarationStatement.MethodModifiers.ClassMethod ) != 0 )
				Print( Tokens.Plus );

			if( node.ReturnType != null )
			{
				Print( Tokens.OpenParenthesis );
				PrintSpace();

				PrintSpace( Print( node.ReturnValueModifier ) );
				node.ReturnType.AcceptVisitor( this );

				PrintSpace();
				Print( Tokens.CloseParenthesis );
			}

			Print( node.Name );

			if( node.Parameters.Count > 0 )
			{
				Print( Tokens.Colon );

				if( node.Parameters[0].TypeReference != null )
				{
					Print( Tokens.OpenParenthesis );
					PrintSpace();

					PrintSpace( Print( node.Parameters[0].Modifer ) );
					node.Parameters[0].TypeReference.AcceptVisitor( this );

					PrintSpace();
					Print( Tokens.CloseParenthesis );
				}

				Print( node.Parameters[0].SelectorPart );

				for( int i = 1; i < node.Parameters.Count; i++ )
				{
					var currentParameter = node.Parameters[i];

					PrintSpace();
					Print( currentParameter.SelectorPart );
					Print( Tokens.Colon );

					Print( Tokens.OpenParenthesis );
					PrintSpace();

					currentParameter.TypeReference.AcceptVisitor( this );

					PrintSpace();
					Print( Tokens.CloseParenthesis );

					Print( currentParameter.SelectorPart );
				}

				if( ( node.Modifiers & ObjectiveMethodDeclarationStatement.MethodModifiers.Vararg ) != 0 )
				{
					Print( Tokens.Comma );
					PrintSpace();
					Print( Tokens.Ellipsis );
				}
			}

			Print( Tokens.Semicolon );

			return null;
		}

		public override object Visit( ObjectiveTypeModifierStatement node )
		{
			NewLine();

			switch( node.Modifier )
			{
				case ObjectiveTypeModifierStatement.Modifiers.Public:
					Print( Tokens.at_public );
					break;

				case ObjectiveTypeModifierStatement.Modifiers.Protected:
					Print( Tokens.at_protected );
					break;

				case ObjectiveTypeModifierStatement.Modifiers.Private:
					Print( Tokens.at_private );
					break;

				case ObjectiveTypeModifierStatement.Modifiers.Optional:
					Print( Tokens.at_optional );
					break;

				case ObjectiveTypeModifierStatement.Modifiers.Required:
					Print( Tokens.at_required );
					break;

				case ObjectiveTypeModifierStatement.Modifiers.Invalid:
				default:
					break;
			}

			return null;
		}

		private bool Print( ObjectiveParameterModifier objectiveParameterModifier )
		{
			switch( objectiveParameterModifier )
			{
				case ObjectiveParameterModifier.In:
					Print( "in" );
					return true;

				case ObjectiveParameterModifier.Out:
					Print( "out" );
					return true;

				case ObjectiveParameterModifier.InOut:
					Print( "inout" );
					return true;

				case ObjectiveParameterModifier.ByCopy:
					Print( "bycopy" );
					return true;

				case ObjectiveParameterModifier.ByRef:
					Print( "byref" );
					return true;

				case ObjectiveParameterModifier.Oneway:
					Print( "oneway" );
					return true;

				case ObjectiveParameterModifier.None:
				default:
					return false;
			}
		}

		public override object Visit( ObjectivePropertyDeclarationStatement node )
		{
			NewLine();

			Print( Tokens.at_property );
			if( node.Modifiers != ObjectivePropertyDeclarationStatement.PropertyModifiers.None )
			{
				Print( Tokens.OpenParenthesis );
				PrintSpace();

				var modifiers = new List<string>();
				if( ( node.Modifiers & ObjectivePropertyDeclarationStatement.PropertyModifiers.Copy ) != 0 )
					modifiers.Add( "copy" );

				if( ( node.Modifiers & ObjectivePropertyDeclarationStatement.PropertyModifiers.ReadOnly ) != 0 )
					modifiers.Add( "readonly" );

				if( ( node.Modifiers & ObjectivePropertyDeclarationStatement.PropertyModifiers.Retain ) != 0 )
					modifiers.Add( "retain" );

				PrintCommaSeparatedList( modifiers );

				PrintSpace();
				Print( Tokens.CloseParenthesis );
			}

			PrintSpace();

			node.DeclarationExpression.AcceptVisitor( this );

			Print( Tokens.Semicolon );

			return null;
		}

		public override object Visit( ObjectiveTypeDeclarationStatement node )
		{
			NewLine();
			PrintWord( Tokens.at_interface );
			PrintWord( node.Name );

			if( node.BaseClass != null )
			{
				PrintWord( Tokens.Colon );
				PrintWord( node.BaseClass );
			}

			if( node.Category != null )
			{
				Print( Tokens.OpenParenthesis );
				PrintWord( node.Category );
				PrintWord( Tokens.CloseParenthesis );
			}

			if( node.AdoptedProtocols != null )
			{
				Print( Tokens.LessThan );

				PrintCommaSeparatedList( node.AdoptedProtocols );

				Print( Tokens.GreaterThan );
			}

			if( node.InstanceVariableStatements != null )
				using( NewBraceScope() )
					foreach( var statement in node.InstanceVariableStatements )
						statement.AcceptVisitor( this );

			_currentIndent++;

			foreach( var item in node.Body )
				item.AcceptVisitor( this );

			_currentIndent--;
			NewLine();

			PrintWord( Tokens.at_end );

			return null;
		}

		public override object Visit( ScopeStatement node )
		{
			using( NewBraceScope() )
				return base.Visit( node );
		}

		public override object Visit( NullStatement node )
		{
			NewLine();
			Print( Tokens.Semicolon );

			return null;
		}

		public override object Visit( TypeidExpression node )
		{
			Print( Tokens._typeid );
			Print( Tokens.OpenParenthesis );
			PrintSpace();
			node.Node.AcceptVisitor( this );
			PrintSpace();
			Print( Tokens.CloseParenthesis );

			return null;
		}

		public override object Visit( MemberReferenceExpression node )
		{
			node.Node.AcceptVisitor( this );

			switch( node.MemberAccess )
			{
				case MemberReferenceExpression.MemberAccessStyle.Pointer:
					Print( Tokens.MemberSelection );
					break;

				case MemberReferenceExpression.MemberAccessStyle.Reference:
					Print( Tokens.Dot );
					break;

				case MemberReferenceExpression.MemberAccessStyle.PointerToMemberFromPointer:
					Print( Tokens.PointerToMemberAccessFromPointer );
					break;

				case MemberReferenceExpression.MemberAccessStyle.PointerToMemberFromReference:
					Print( Tokens.PointerToMemberAccessFromReference );
					break;
			}

			Print( node.Name );

			return null;
		}

		public override object Visit( InvocationExpression node )
		{
			node.Expression.AcceptVisitor( this );

			Print( Tokens.OpenParenthesis );

			PrintSpace();
			PrintCommaSeparatedList( node.Arguments );
			PrintSpace();

			Print( Tokens.CloseParenthesis );

			return null;
		}

		private IDisposable NewBraceScope()
		{
			PrintWord( Tokens.OpenCurlyBrace );
			_currentIndent++;

			return new Extensions.ActionInvoker( () =>
			{
				_currentIndent--;
				NewLine();
				Print( Tokens.CloseCurlyBrace );
			} );
		}

		private IDisposable NewOutputContext()
		{
			var oldOutputContext = _text;
			var newOutputContext = new StringBuilder();

			_text = newOutputContext;

			return new Extensions.ActionInvoker( () =>
			{
				_text = oldOutputContext;

				Print( newOutputContext );
			} );
		}

		public struct OutputOptions
		{
			public static readonly OutputOptions DefaultOptions;

			static OutputOptions()
			{
				DefaultOptions = new OutputOptions
				{
					SpacesInsideParenthesis = true,
					SpacesInsideParameterDeclaration = true,
					SpacesAroundBinaryOperators = true,
				};

			}

			public bool SpacesInsideParameterDeclaration;
			public bool SpacesInsideParenthesis;
			public bool SpacesAroundBinaryOperators;
		}
	}
}
