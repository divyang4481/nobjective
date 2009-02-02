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

namespace NObjectiveAST
{
	public class Parser
	{
		internal static readonly HashSet<Tokens> Primitives = new HashSet<Tokens>
		{
			Tokens._void,

			Tokens._bool,

			Tokens._char,
			Tokens._short,
			Tokens._int,
			Tokens._long,
			Tokens._long_long,
			Tokens._unsigned_char,
			Tokens._unsigned_short,
			Tokens._unsigned_int,
			Tokens._unsigned_long,
			Tokens._unsigned_long_long,	

			Tokens._float,
			Tokens._double,	
			Tokens._long_double,
		};

		private enum ContextType
		{
			TranslationUnit,

			Namespace,
			Type,
			ObjectiveType,
			Function,

			/// <summary>
			/// evaluation inside generic parameters &lt;...&gt;
			/// </summary>
			Generic,

			Expression
		}

		private struct EvaluationContext
		{
			public Node Node;

			public ContextType ContextType;

			public EvaluationContext( Node node, ContextType contextType )
			{
				Node = node;
				ContextType = contextType;
			}
		}

		private Stack<EvaluationContext> _context = new Stack<EvaluationContext>();

		private Token[] _tokens;
		public TranslationUnit TranslationUnit { get; set; }

		public Parser( Lexer lexer )
		{
			_tokens = lexer.Output;

			TranslationUnit = GetTranslationUnit();
		}

		public Parser( Token[] lexems )
		{
			_tokens = lexems;

			TranslationUnit = GetTranslationUnit();
		}

		private bool Optional( Tokens token, ref int parsingLocation )
		{
			if( _tokens[parsingLocation].Type == token )
			{
				parsingLocation++;
				return true;
			}

			return false;
		}

		private void Required( Tokens token, ref int parsingLocation )
		{
			if( _tokens[parsingLocation].Type == token )
			{
				parsingLocation++;
				return;
			}

			ThrowException( parsingLocation, @"Required ""{0}""", Lexer.GetTokenString( token ) );
		}

		private Expression GetUnaryOrCastExpression( ref int parsingLocation )
		{
			int localIndex = parsingLocation;
			Expression firstExpression = null, lastExpression = null;

			Action<Expression> linkLastExpression = newExpression =>
			{
				if( lastExpression == null )
				{
					firstExpression = newExpression;
					lastExpression = newExpression;
					return;
				}

				var unaryOperatorExpression = lastExpression as UnaryOperatorExpression;
				if( unaryOperatorExpression != null )
				{
					unaryOperatorExpression.Expression = newExpression;
					lastExpression = newExpression;
					return;
				}

				var castExpression = lastExpression as CastExpression;
				if( castExpression != null )
				{
					castExpression.Expression = newExpression;
					lastExpression = newExpression;
					return;
				}

				Debugger.Break();
			};

			bool checkUnaryOperators = true;
			while( checkUnaryOperators )
				switch( _tokens[localIndex++].Type )
				{
					case Tokens.Plus:
						linkLastExpression( new UnaryOperatorExpression { Operator = UnaryOperatorExpression.Operators.Plus } );
						break;

					case Tokens.Minus:
						linkLastExpression( new UnaryOperatorExpression { Operator = UnaryOperatorExpression.Operators.Minus } );
						break;

					case Tokens.Increment:
						linkLastExpression( new UnaryOperatorExpression { Operator = UnaryOperatorExpression.Operators.PrefixIncrement } );
						break;

					case Tokens.Decrement:
						linkLastExpression( new UnaryOperatorExpression { Operator = UnaryOperatorExpression.Operators.PrefixDecrement } );
						break;

					case Tokens.BitwiseComplement:
						linkLastExpression( new UnaryOperatorExpression { Operator = UnaryOperatorExpression.Operators.Complement } );
						break;

					case Tokens.Not:
						linkLastExpression( new UnaryOperatorExpression { Operator = UnaryOperatorExpression.Operators.Not } );
						break;

					case Tokens.BitwiseAnd:
						linkLastExpression( new UnaryOperatorExpression { Operator = UnaryOperatorExpression.Operators.AddressOf } );
						break;

					case Tokens.Multiply:
						linkLastExpression( new UnaryOperatorExpression { Operator = UnaryOperatorExpression.Operators.Indirection } );
						break;

					// cast expression
					// currently I can't normally recognize cast expressions. It need more complex evaluator
					// ( xxx::yyy ) * ...
					// it can be type or variable/constant

					case Tokens.OpenParenthesis:
						{
							var castLocalIndex = localIndex;

							var castTo = GetTypeReference( ref castLocalIndex );

							// parenthesized expression
							if( castTo == null )
								goto default;

							if( _tokens[castLocalIndex++].Type == Tokens.CloseParenthesis )
							{
								bool nonVariableTypes = castTo.TypeKind == TypeKind.Pointer || castTo.TypeKind == TypeKind.Reference;
								bool nonVariableTokens = _tokens[castLocalIndex].Type == Tokens.ScopeResolution || _tokens[castLocalIndex].Type == Tokens.Identifier || _tokens[castLocalIndex].Type == Tokens.OpenParenthesis || _tokens[castLocalIndex].Type == Tokens.Literal;
								bool keywordType = castTo.TypeKind == TypeKind.Normal && EvaluatedRepresentation.PrimitiveType.IsPrimitive( castTo.TypeName );

								if( nonVariableTypes || nonVariableTokens || keywordType )
								{
									localIndex = castLocalIndex;
									linkLastExpression( new CastExpression { CastType = CastExpression.CastTypes.C, TypeReference = castTo } );
									break;
								}
							}

							goto default;
						}

					default:
						checkUnaryOperators = false;
						localIndex--;
						break;
				}

			var primaryExpression = GetPrimaryExpression( ref localIndex );
			linkLastExpression( primaryExpression );

			parsingLocation = localIndex;
			return firstExpression;
		}

		private Expression GetPrimaryExpression( ref int parsingLocation )
		{
			int localIndex = parsingLocation;
			Expression result = null;

			switch( _tokens[localIndex].Type )
			{
				case Tokens._true:
					result = new PrimitiveExpression( true );
					localIndex++;
					break;

				case Tokens._false:
					result = new PrimitiveExpression( false );
					localIndex++;
					break;

				case Tokens.Literal:
					result = new PrimitiveExpression { Value = new PrimitiveExpression.LiteralValue( _tokens[localIndex].LiteralValue ) };
					localIndex++;
					break;

				case Tokens.OpenParenthesis:
					{
						localIndex++;
						var innerExpression = GetExpression( ref localIndex );
						if( innerExpression == null )
							Debugger.Break();

						result = new ParenthesizedExpression( innerExpression );
						Required( Tokens.CloseParenthesis, ref localIndex );
						break;
					}

				case Tokens._this:
					result = new ThisReferenceExpression();
					localIndex++;
					break;

				case Tokens._new:
					new NewExpression();
					Debugger.Break();
					break;

				case Tokens._typeid:
					{
						localIndex++;
						Required( Tokens.OpenParenthesis, ref localIndex );

						var subNode = ( Node ) GetExpression( ref localIndex );
						subNode = subNode ?? GetTypeReference( ref localIndex );

						if( subNode == null )
						{
							Debugger.Break();
							return null;
						}
						Required( Tokens.CloseParenthesis, ref localIndex );

						result = new TypeidExpression { Node = subNode };
						break;
					}

				case Tokens._sizeof:
					{
						localIndex++;
						Required( Tokens.OpenParenthesis, ref localIndex );

						var subNode = ( Node ) GetExpression( ref localIndex );
						subNode = subNode ?? GetTypeReference( ref localIndex );

						if( subNode == null )
						{
							Debugger.Break();
							return null;
						}
						Required( Tokens.CloseParenthesis, ref localIndex );

						result = new SizeofExpression { Node = subNode };
						break;
					}

				case Tokens.ScopeResolution:
				case Tokens.Identifier:
					result = new QualifiedIdentifierExpression { Name = GetQualifiedName( ref localIndex ) };
					break;
			}

			bool checkPrimaryExpressions = true;
			while( checkPrimaryExpressions )
				switch( _tokens[localIndex].Type )
				{
					case Tokens.Increment:
						result = new UnaryOperatorExpression { Operator = UnaryOperatorExpression.Operators.PostfixIncrement, Expression = result };
						localIndex++;
						break;

					case Tokens.Decrement:
						result = new UnaryOperatorExpression { Operator = UnaryOperatorExpression.Operators.PostfixDecrement, Expression = result };
						localIndex++;
						break;

					case Tokens.PointerToMemberAccessFromPointer:
						{
							localIndex++;
							var identifier = GetIdentifier( ref localIndex );
							result = new MemberReferenceExpression { Node = result, Name = identifier, MemberAccess = MemberReferenceExpression.MemberAccessStyle.PointerToMemberFromPointer };
						}
						break;

					case Tokens.PointerToMemberAccessFromReference:
						{
							localIndex++;
							var identifier = GetIdentifier( ref localIndex );
							result = new MemberReferenceExpression { Node = result, Name = identifier, MemberAccess = MemberReferenceExpression.MemberAccessStyle.PointerToMemberFromReference };
						}
						break;

					case Tokens.MemberSelection:
						{
							localIndex++;
							var identifier = GetIdentifier( ref localIndex );
							result = new MemberReferenceExpression { Node = result, Name = identifier, MemberAccess = MemberReferenceExpression.MemberAccessStyle.Pointer };
						}
						break;

					case Tokens.Dot:
						{
							localIndex++;
							var identifier = GetIdentifier( ref localIndex );
							result = new MemberReferenceExpression { Node = result, Name = identifier, MemberAccess = MemberReferenceExpression.MemberAccessStyle.Reference };
						}
						break;

					// invocation
					case Tokens.OpenParenthesis:
						{
							localIndex++;
							var invocationExpression = new InvocationExpression { Expression = result };
							result = invocationExpression;

							if( _tokens[localIndex].Type != Tokens.CloseParenthesis )
								do
								{
									var argument = GetExpression( ref localIndex );
									if( argument == null )
									{
										Debugger.Break();
										return null;
									}

									invocationExpression.AddArgument( argument );

									if( Optional( Tokens.Comma, ref localIndex ) )
										continue;
								} while( _tokens[localIndex].Type != Tokens.CloseParenthesis );

							localIndex++;
							break;
						}

					default:
						checkPrimaryExpressions = false;
						break;
				}

			parsingLocation = localIndex;
			return result;
		}

		private Expression TryGetBinaryOperatorExpression( ref int parsingLocation, Expression lvalue )
		{
			return TryGetLogicalOrExpression( ref parsingLocation, lvalue );
		}

		private Expression TryGetLogicalOrExpression( ref int parsingLocation, Expression lvalue )
		{
			int localIndex = parsingLocation;

			var result = TryGetLogicalAndExpression( ref localIndex, lvalue );
			while( Optional( Tokens.LogicalOr, ref localIndex ) )
			{
				var rvalue = GetUnaryOrCastExpression( ref localIndex );
				rvalue = TryGetLogicalAndExpression( ref localIndex, rvalue );

				result = new BinaryOperatorExpression( result, BinaryOperatorExpression.Operators.LogicalOr, rvalue );
			}

			parsingLocation = localIndex;
			return result;
		}

		private Expression TryGetLogicalAndExpression( ref int parsingLocation, Expression lvalue )
		{
			int localIndex = parsingLocation;

			var result = TryGetBitwiseOrExpression( ref localIndex, lvalue );
			while( Optional( Tokens.LogicalAnd, ref localIndex ) )
			{
				var rvalue = GetUnaryOrCastExpression( ref localIndex );
				rvalue = TryGetBitwiseOrExpression( ref localIndex, rvalue );

				result = new BinaryOperatorExpression( result, BinaryOperatorExpression.Operators.LogicalAnd, rvalue );
			}

			parsingLocation = localIndex;
			return result;
		}

		private Expression TryGetBitwiseOrExpression( ref int parsingLocation, Expression lvalue )
		{
			int localIndex = parsingLocation;

			var result = TryGetXorExpression( ref localIndex, lvalue );
			while( Optional( Tokens.BitwiseOr, ref localIndex ) )
			{
				var rvalue = GetUnaryOrCastExpression( ref localIndex );
				rvalue = TryGetXorExpression( ref localIndex, rvalue );

				result = new BinaryOperatorExpression( result, BinaryOperatorExpression.Operators.BitwiseOr, rvalue );
			}

			parsingLocation = localIndex;
			return result;
		}

		private Expression TryGetXorExpression( ref int parsingLocation, Expression lvalue )
		{
			int localIndex = parsingLocation;

			var result = TryGetBitwiseAndExpression( ref localIndex, lvalue );
			while( Optional( Tokens.Xor, ref localIndex ) )
			{
				var rvalue = GetUnaryOrCastExpression( ref localIndex );
				rvalue = TryGetBitwiseAndExpression( ref localIndex, rvalue );

				result = new BinaryOperatorExpression( result, BinaryOperatorExpression.Operators.ExclusiveOr, rvalue );
			}

			parsingLocation = localIndex;
			return result;
		}

		private Expression TryGetBitwiseAndExpression( ref int parsingLocation, Expression lvalue )
		{
			int localIndex = parsingLocation;

			var result = TryGetEqualityExpression( ref localIndex, lvalue );
			while( Optional( Tokens.BitwiseAnd, ref localIndex ) )
			{
				var rvalue = GetUnaryOrCastExpression( ref localIndex );
				rvalue = TryGetEqualityExpression( ref localIndex, rvalue );

				result = new BinaryOperatorExpression( result, BinaryOperatorExpression.Operators.BitwiseAnd, rvalue );
			}

			parsingLocation = localIndex;
			return result;
		}

		private Expression TryGetEqualityExpression( ref int parsingLocation, Expression lvalue )
		{
			int localIndex = parsingLocation;

			var result = TryGetRelationalExpression( ref localIndex, lvalue );
			bool checkExpression = true;

			while( checkExpression )
			{
				var @operator = BinaryOperatorExpression.Operators.Invalid;

				switch( _tokens[localIndex].Type )
				{
					case Tokens.Equality:
						localIndex++;
						@operator = BinaryOperatorExpression.Operators.Equality;
						break;

					case Tokens.Inequality:
						localIndex++;
						@operator = BinaryOperatorExpression.Operators.Inequality;
						break;
				}

				if( @operator == BinaryOperatorExpression.Operators.Invalid )
					break;

				var rvalue = GetUnaryOrCastExpression( ref localIndex );
				rvalue = TryGetRelationalExpression( ref localIndex, rvalue );

				result = new BinaryOperatorExpression( result, @operator, rvalue );
			}

			parsingLocation = localIndex;
			return result;
		}

		private Expression TryGetRelationalExpression( ref int parsingLocation, Expression lvalue )
		{
			int localIndex = parsingLocation;

			var result = TryGetShiftExpression( ref localIndex, lvalue );
			bool checkExpression = true;

			while( checkExpression )
			{
				var @operator = BinaryOperatorExpression.Operators.Invalid;

				switch( _tokens[localIndex].Type )
				{
					case Tokens.LessThan:
						localIndex++;
						@operator = BinaryOperatorExpression.Operators.LessThan;
						break;

					case Tokens.LessThanOrEqual:
						localIndex++;
						@operator = BinaryOperatorExpression.Operators.LessThanOrEqual;
						break;

					case Tokens.GreaterThan:
						localIndex++;
						@operator = BinaryOperatorExpression.Operators.GreaterThan;
						break;

					case Tokens.GreaterThanOrEqual:
						localIndex++;
						@operator = BinaryOperatorExpression.Operators.GreaterThanOrEqual;
						break;
				}

				if( @operator == BinaryOperatorExpression.Operators.Invalid )
					break;

				var rvalue = GetUnaryOrCastExpression( ref localIndex );
				rvalue = TryGetShiftExpression( ref localIndex, rvalue );

				result = new BinaryOperatorExpression( result, @operator, rvalue );
			}

			parsingLocation = localIndex;
			return result;
		}

		private Expression TryGetShiftExpression( ref int parsingLocation, Expression lvalue )
		{
			int localIndex = parsingLocation;

			var result = TryGetAddOrSubtractExpression( ref localIndex, lvalue );
			bool checkExpression = true;

			while( checkExpression )
			{
				var @operator = BinaryOperatorExpression.Operators.Invalid;

				switch( _tokens[localIndex].Type )
				{
					case Tokens.ShiftLeft:
						localIndex++;
						@operator = BinaryOperatorExpression.Operators.ShiftLeft;
						break;

					case Tokens.GreaterThan:
						localIndex++;
						Required( Tokens.GreaterThan, ref localIndex );
						@operator = BinaryOperatorExpression.Operators.ShiftRight;
						break;
				}

				if( @operator == BinaryOperatorExpression.Operators.Invalid )
					break;

				var rvalue = GetUnaryOrCastExpression( ref localIndex );
				rvalue = TryGetAddOrSubtractExpression( ref localIndex, rvalue );

				result = new BinaryOperatorExpression( result, @operator, rvalue );
			}

			parsingLocation = localIndex;
			return result;
		}

		private Expression TryGetAddOrSubtractExpression( ref int parsingLocation, Expression lvalue )
		{
			int localIndex = parsingLocation;

			var result = TryGetMultiplyOrDivideOrModulusExpression( ref localIndex, lvalue );
			bool checkExpression = true;

			while( checkExpression )
			{
				var @operator = BinaryOperatorExpression.Operators.Invalid;

				switch( _tokens[localIndex].Type )
				{
					case Tokens.Plus:
						localIndex++;
						@operator = BinaryOperatorExpression.Operators.Add;
						break;

					case Tokens.Minus:
						localIndex++;
						@operator = BinaryOperatorExpression.Operators.Subtract;
						break;
				}

				if( @operator == BinaryOperatorExpression.Operators.Invalid )
					break;

				var rvalue = GetUnaryOrCastExpression( ref localIndex );
				rvalue = TryGetMultiplyOrDivideOrModulusExpression( ref localIndex, rvalue );

				result = new BinaryOperatorExpression( result, @operator, rvalue );
			}

			parsingLocation = localIndex;
			return result;
		}

		private Expression TryGetMultiplyOrDivideOrModulusExpression( ref int parsingLocation, Expression lvalue )
		{
			int localIndex = parsingLocation;

			var result = lvalue;
			bool checkExpression = true;

			while( checkExpression )
			{
				var @operator = BinaryOperatorExpression.Operators.Invalid;

				switch( _tokens[localIndex].Type )
				{
					case Tokens.Multiply:
						localIndex++;
						@operator = BinaryOperatorExpression.Operators.Multiply;
						break;

					case Tokens.Div:
						localIndex++;
						@operator = BinaryOperatorExpression.Operators.Divide;
						break;

					case Tokens.Mod:
						localIndex++;
						@operator = BinaryOperatorExpression.Operators.Modulus;
						break;
				}

				if( @operator == BinaryOperatorExpression.Operators.Invalid )
					break;

				var rvalue = GetUnaryOrCastExpression( ref localIndex );
				if( rvalue == null )
				{
					Debugger.Break();
					return null;
				}

				result = new BinaryOperatorExpression( result, @operator, rvalue );
			}

			parsingLocation = localIndex;
			return result;
		}

		private Expression GetExpression( ref int parsingLocation )
		{
			int localIndex = parsingLocation;

			var lvalue = GetUnaryOrCastExpression( ref localIndex );
			var result = lvalue;

			switch( _tokens[localIndex++].Type )
			{
				case Tokens.Assign:
					{
						var rvalue = GetExpression( ref localIndex );
						result = new AssignmentExpression( lvalue, AssignmentExpression.Operators.Assign, rvalue );
						break;
					}

				case Tokens.AddAssign:
					{
						var rvalue = GetExpression( ref localIndex );
						result = new AssignmentExpression( lvalue, AssignmentExpression.Operators.Add, rvalue );
						break;
					}

				case Tokens.SubtractAssign:
					{
						var rvalue = GetExpression( ref localIndex );
						result = new AssignmentExpression( lvalue, AssignmentExpression.Operators.Subtract, rvalue );
						break;
					}

				case Tokens.ModulusAssign:
					{
						var rvalue = GetExpression( ref localIndex );
						result = new AssignmentExpression( lvalue, AssignmentExpression.Operators.Modulus, rvalue );
						break;
					}
				case Tokens.MultiplyAssign:
					{
						var rvalue = GetExpression( ref localIndex );
						result = new AssignmentExpression( lvalue, AssignmentExpression.Operators.Multiply, rvalue );
						break;
					}
				case Tokens.DivideAssign:
					{
						var rvalue = GetExpression( ref localIndex );
						result = new AssignmentExpression( lvalue, AssignmentExpression.Operators.Divide, rvalue );
						break;
					}
				case Tokens.BitwiseOrAssign:
					{
						var rvalue = GetExpression( ref localIndex );
						result = new AssignmentExpression( lvalue, AssignmentExpression.Operators.BitwiseOr, rvalue );
						break;
					}

				case Tokens.BitwiseAndAssign:
					{
						var rvalue = GetExpression( ref localIndex );
						result = new AssignmentExpression( lvalue, AssignmentExpression.Operators.BitwiseAnd, rvalue );
						break;
					}

				case Tokens.XorAssign:
					{
						var rvalue = GetExpression( ref localIndex );
						result = new AssignmentExpression( lvalue, AssignmentExpression.Operators.Xor, rvalue );
						break;
					}

				case Tokens.ShiftLeftAssign:
					{
						var rvalue = GetExpression( ref localIndex );
						result = new AssignmentExpression( lvalue, AssignmentExpression.Operators.ShiftLeft, rvalue );
						break;
					}

				case Tokens.GreaterThan:
					if( _context.Peek().ContextType == ContextType.Generic )
					{
						localIndex--;
						break;
					}

					if( _tokens[localIndex].Type == Tokens.GreaterThanOrEqual )
					{
						localIndex++;
						var rvalue = GetExpression( ref localIndex );
						result = new AssignmentExpression( lvalue, AssignmentExpression.Operators.ShiftRight, rvalue );
						break;
					}
					goto default;

				default:
					{
						localIndex--;
						result = TryGetBinaryOperatorExpression( ref localIndex, lvalue );
						if( Optional( Tokens.Question, ref localIndex ) )
						{
							var trueExpression = GetExpression( ref localIndex );
							Required( Tokens.Colon, ref localIndex );
							var falseExpression = GetPrimaryExpression( ref localIndex );

							result = new ConditionalExpression( result, trueExpression, falseExpression );
						}
						break;
					}
			}

			parsingLocation = localIndex;
			return result;
		}

		private Expression GetVariableInitializerExpression( ref int parsingLocation )
		{
			var localIndex = parsingLocation;
			Expression result = null;

			switch( _tokens[localIndex].Type )
			{
				case Tokens._new:
					Debugger.Break();
					break;

				default:
					{
						result = GetExpression( ref localIndex );
						break;
					}
			}

			parsingLocation = localIndex;
			return result;
		}

		private Statement GetStatement( ref int parsingLocation )
		{
			var localIndex = parsingLocation;

			Statement result = null;
			switch( _tokens[localIndex].Type )
			{
				case Tokens.Identifier:
					if( _tokens[localIndex + 1].Type != Tokens.Colon )
						break;
					result = new LabeledStatement { Name = ( string ) _tokens[localIndex].Value };
					break;

				default:
					Debugger.Break();
					break;
			}

			parsingLocation = localIndex;
			return result;
		}

		private TypeReference ParseDeclarationSubexpression( ref string identifier, ref int parsingLocation, TypeReference outerTypeReference )
		{
			int localIndex = parsingLocation;

			TypeReference prePointee = null;
			TypeReference result = null;

			var memberOf = GetQualifiedName( ref localIndex );
			var isMemberOf = memberOf != null && _tokens[localIndex - 1].Type == Tokens.ScopeResolution;
			var parseFunction = false;

			if( memberOf != null && _tokens[localIndex].Type == Tokens.OpenParenthesis )
				parseFunction = true;

			while( _tokens[localIndex].Type == Tokens.Multiply || _tokens[localIndex].Type == Tokens.BitwiseAnd )
			{
				result = new TypeReference { TypeKind = _tokens[localIndex].Type == Tokens.Multiply ? TypeKind.Pointer : TypeKind.Reference, ElementType = result };
				if( prePointee == null )
					prePointee = result;

				localIndex++;

			fetch_pointer_modifier:
				switch( _tokens[localIndex].Type )
				{
					case Tokens._const:
						result.Modifiers |= TypeModifiers.Const;
						localIndex++;
						goto fetch_pointer_modifier;

					case Tokens._volatile:
						result.Modifiers |= TypeModifiers.Volatile;
						localIndex++;
						goto fetch_pointer_modifier;

					case Tokens._restrict:
					case Tokens.___restrict:
						result.Modifiers |= TypeModifiers.Restrict;
						localIndex++;
						goto fetch_pointer_modifier;
				}
			}

			if( _tokens[localIndex].Type == Tokens.OpenParenthesis && !parseFunction )
			{
				var outerTypeReferenceForInnerExpression = result ?? outerTypeReference;
				int parethesisEnd = FindMatchingParenthesis( localIndex ) + 1;
				var parametersDeclaration = GetParameterDeclaration( ref parethesisEnd );

				// function result
				if( parametersDeclaration != null )
					outerTypeReferenceForInnerExpression = new TypeReference { TypeKind = TypeKind.Function, ParameterDeclaration = parametersDeclaration, ReturnType = outerTypeReferenceForInnerExpression };

				localIndex++;

				if( result == null )
					result = ParseDeclarationSubexpression( ref identifier, ref localIndex, outerTypeReferenceForInnerExpression );
				else
				{
					result = ParseDeclarationSubexpression( ref identifier, ref localIndex, outerTypeReferenceForInnerExpression );
					prePointee.ElementType = outerTypeReference;
				}

				if( result == null && identifier == null )
					return null;

				if( _tokens[localIndex++].Type != Tokens.CloseParenthesis )
					return null;

				if( parametersDeclaration != null )
				{
					localIndex = parethesisEnd;

					if( _tokens[localIndex].Type == Tokens._const )
					{
						localIndex++;

						result.Modifiers |= TypeModifiers.Const;
					}
				}
			}
			else if( identifier == null )
			{
				if( prePointee != null )
					prePointee.ElementType = outerTypeReference;

				if( _tokens[localIndex].Type == Tokens._operator )
				{
					localIndex++;

					var @operator = RedefinableOperators.Invalid;
					switch( _tokens[localIndex++].Type )
					{
						case Tokens.PointerToMemberAccessFromPointer:
							@operator = RedefinableOperators.PointerToMemberSelection;
							break;

						case Tokens.Assign:
							@operator = RedefinableOperators.Assign;
							break;

						case Tokens.Plus:
							@operator = RedefinableOperators.Plus;
							break;

						case Tokens.Minus:
							@operator = RedefinableOperators.Minus;
							break;

						case Tokens.Multiply:
							@operator = RedefinableOperators.Multiply;
							break;

						case Tokens.Div:
							@operator = RedefinableOperators.Div;
							break;

						case Tokens.Mod:
							@operator = RedefinableOperators.Modulus;
							break;

						case Tokens.Comma:
							@operator = RedefinableOperators.Comma;
							break;

						case Tokens.OpenSquareBracket:
							if( _tokens[localIndex++].Type != Tokens.CloseSquareBracket )
								Debugger.Break();
							@operator = RedefinableOperators.ArraySubscript;
							break;

						case Tokens.OpenParenthesis:
							if( _tokens[localIndex++].Type != Tokens.CloseParenthesis )
								Debugger.Break();
							@operator = RedefinableOperators.FunctionCall;
							break;

						case Tokens.GreaterThan:
							if( _tokens[localIndex].Type == Tokens.GreaterThan )
							{
								localIndex++;
								@operator = RedefinableOperators.RightShift;
							}
							else if( _tokens[localIndex].Type == Tokens.GreaterThanOrEqual )
							{
								localIndex++;
								@operator = RedefinableOperators.RightShiftAssign;
							}
							else
								@operator = RedefinableOperators.GreaterThan;
							break;

						case Tokens.LessThan:
							@operator = RedefinableOperators.LessThan;
							break;

						case Tokens.Not:
							@operator = RedefinableOperators.Not;
							break;

						case Tokens.LogicalAnd:
							@operator = RedefinableOperators.LogicalAnd;
							break;

						case Tokens.LogicalOr:
							@operator = RedefinableOperators.LogicalOr;
							break;

						case Tokens.BitwiseComplement:
							@operator = RedefinableOperators.BitwiseComplement;
							break;

						case Tokens.BitwiseAnd:
							@operator = RedefinableOperators.BitwiseAnd;
							break;

						case Tokens.BitwiseOr:
							@operator = RedefinableOperators.BitwiseOr;
							break;

						case Tokens.Xor:
							@operator = RedefinableOperators.Xor;
							break;

						case Tokens.Increment:
							@operator = RedefinableOperators.Increment;
							break;

						case Tokens.Decrement:
							@operator = RedefinableOperators.Decrement;
							break;

						case Tokens.Equality:
							@operator = RedefinableOperators.Equality;
							break;

						case Tokens.Inequality:
							@operator = RedefinableOperators.Inequality;
							break;

						case Tokens.GreaterThanOrEqual:
							@operator = RedefinableOperators.GreaterEqual;
							break;

						case Tokens.LessThanOrEqual:
							@operator = RedefinableOperators.LessEqual;
							break;

						case Tokens.ShiftLeft:
							@operator = RedefinableOperators.ShiftLeft;
							break;

						case Tokens.AddAssign:
							@operator = RedefinableOperators.AddAssign;
							break;

						case Tokens.SubtractAssign:
							@operator = RedefinableOperators.SubtractAssign;
							break;

						case Tokens.MultiplyAssign:
							@operator = RedefinableOperators.MultiplyAssign;
							break;

						case Tokens.DivideAssign:
							@operator = RedefinableOperators.DivideAssign;
							break;

						case Tokens.ModulusAssign:
							@operator = RedefinableOperators.ModulusAssign;
							break;

						case Tokens.BitwiseAndAssign:
							@operator = RedefinableOperators.BitwiseAndAssign;
							break;

						case Tokens.BitwiseOrAssign:
							@operator = RedefinableOperators.BitwiseOrAssign;
							break;

						case Tokens.XorAssign:
							@operator = RedefinableOperators.XorAssign;
							break;

						case Tokens.ShiftLeftAssign:
							@operator = RedefinableOperators.ShiftLeftAssign;
							break;

						case Tokens.MemberSelection:
							@operator = RedefinableOperators.MemberSelection;
							break;

						default:
							Debugger.Break();

							break;
					}

					var parametersDeclaration = GetParameterDeclaration( ref localIndex );
					result = new TypeReference { TypeKind = TypeKind.RedefinableOperator, Operator = @operator, ReturnType = result ?? outerTypeReference, ParameterDeclaration = parametersDeclaration };
				}
				else
				{
					result = result ?? outerTypeReference;

					if( isMemberOf )
					{
						result.MemberOf = memberOf;
						identifier = GetObjectiveIdentifier( ref localIndex );
					}
					else
					{
						if( memberOf == null )
							identifier = GetObjectiveIdentifier( ref localIndex );
						else
						{
							identifier = memberOf.NestedNames.Last().Name;
							memberOf.NestedNames.RemoveAt( memberOf.NestedNames.Count - 1 );
							if( memberOf.NestedNames.Count != 0 )
								result.MemberOf = memberOf;
						}
					}

					if( _tokens[localIndex].Type == Tokens.OpenParenthesis )
					{
						var parametersDeclaration = GetParameterDeclaration( ref localIndex );

						if( parametersDeclaration != null )
						{
							result = new TypeReference { TypeKind = TypeKind.Function, ReturnType = result, ParameterDeclaration = parametersDeclaration };

							if( _tokens[localIndex].Type == Tokens._const )
							{
								localIndex++;

								result.Modifiers |= TypeModifiers.Const;
							}
						}
					}
				}
			}

			if( _tokens[localIndex].Type == Tokens.OpenSquareBracket )
			{
				TypeReference previousArray = null, lastArray = null, firstArray = null;

				while( _tokens[localIndex].Type == Tokens.OpenSquareBracket )
				{
					localIndex++;
					Expression size = null;

					if( _tokens[localIndex].Type == Tokens.CloseSquareBracket )
						size = new EmptyExpression();
					else
						size = GetExpression( ref localIndex );

					if( size == null )
					{
						Debugger.Break();
						return null;
					}

					previousArray = lastArray;
					lastArray = new TypeReference { TypeKind = TypeKind.Array, Size = size };
					firstArray = firstArray ?? lastArray;

					if( previousArray != null )
						previousArray.ElementType = lastArray;

					if( _tokens[localIndex++].Type != Tokens.CloseSquareBracket )
					{
						Debugger.Break();
						return null;
					}
				}

				lastArray.ElementType = result;
				result = firstArray;
			}

			parsingLocation = localIndex;
			return result;
		}

		private static readonly Dictionary<Tokens, DeclarationExpression.DeclarationModifiers> _declarationModifiers = new Dictionary<Tokens, DeclarationExpression.DeclarationModifiers>
		{
			{ Tokens._auto, DeclarationExpression.DeclarationModifiers.Auto },
			{ Tokens._extern, DeclarationExpression.DeclarationModifiers.Extern },
			{ Tokens._register, DeclarationExpression.DeclarationModifiers.Register },
			{ Tokens._static, DeclarationExpression.DeclarationModifiers.Static },
			{ Tokens._inline, DeclarationExpression.DeclarationModifiers.Inline },
			{ Tokens.___inline, DeclarationExpression.DeclarationModifiers.Inline },
			{ Tokens.___inline__, DeclarationExpression.DeclarationModifiers.Inline },
			{ Tokens._const, DeclarationExpression.DeclarationModifiers.None },
			{ Tokens._volatile, DeclarationExpression.DeclarationModifiers.None },

			// skip
			{ Tokens.___attribute__, DeclarationExpression.DeclarationModifiers.None },
		};

		[Flags]
		private enum DeclarationParsingFlags
		{
			ParseAll = 0,
			ParseFirst = 1 << 0,
			NameMayBeOmitted = 1 << 1,
			BreakOnAssignment = 1 << 2
		}

		private DeclarationExpression GetDeclarationExpression( ref int parsingLocation, DeclarationParsingFlags declarationParsingFlags )
		{
			var localIndex = parsingLocation;
			var result = new DeclarationExpression();

			bool isConst = false, isVolatile = false;

			while( _declarationModifiers.ContainsKey( _tokens[localIndex].Type ) )
			{
				if( _tokens[localIndex].Type == Tokens._const )
				{
					isConst = true;
					localIndex++;
					continue;
				}

				if( _tokens[localIndex].Type == Tokens._volatile )
				{
					isVolatile = true;
					localIndex++;
					continue;
				}

				if( _tokens[localIndex].Type == Tokens.___attribute__ )
				{
					localIndex = FindMatchingParenthesis( localIndex + 1 ) + 1;
					continue;
				}

				result.Modifiers = _declarationModifiers[_tokens[localIndex].Type];
				localIndex++;
			}

			result.TypeDeclarationExpression = GetTypeDeclarationExpression( ref localIndex );
			if( result.TypeDeclarationExpression == null )
			{
				result.TypeReference = new TypeReference();

				if( _tokens[localIndex].Type == Tokens._const )
				{
					result.TypeReference.Modifiers |= TypeModifiers.Const;
					localIndex++;
				}

				if( Primitives.Contains( _tokens[localIndex].Type ) )
				{
					result.TypeReference.TypeName = Lexer.GetTokenString( _tokens[localIndex++].Type );
				}
				// c-style addition to type name
				else if( _tokens[localIndex].Type == Tokens._struct || _tokens[localIndex].Type == Tokens._union || _tokens[localIndex].Type == Tokens._class )
				{
					localIndex++;

					// skip type declarationWithoutModifiers
					if( _tokens[localIndex].Type == Tokens.OpenCurlyBrace )
						ThrowException( localIndex, "should be parsed to result.TypeDeclarationExpression" );
				}
				else if( _tokens[localIndex].Type == Tokens.Identifier )
				{
					result.TypeReference.TypeName = GetIdentifier( ref localIndex );

					if( _tokens[localIndex].Type == Tokens.LessThan )
					{
						localIndex++;
						using( _context.PushScoped( new EvaluationContext( result, ContextType.Generic ) ) )
						{
							while( _tokens[localIndex].Type != Tokens.GreaterThan )
							{
								var declarationExpression = GetDeclarationExpression( ref localIndex, DeclarationParsingFlags.NameMayBeOmitted | DeclarationParsingFlags.ParseFirst );
								Expression expression = null;

								if( declarationExpression == null )
								{
									expression = GetExpression( ref localIndex );
									if( expression == null )
									{
										Debugger.Break();

										return null;
									}
								}

								result.TypeReference.AddGenericArgument( ( Node ) declarationExpression ?? expression );
							}
						}

						localIndex++;
					}
				}
				else
					return null;

				SkipGCCAttribute( ref localIndex );

				if( _tokens[localIndex].Type == Tokens._const )
				{
					result.TypeReference.Modifiers |= TypeModifiers.Const;
					localIndex++;
				}

				SkipGCCAttribute( ref localIndex );
			}
			else
				result.TypeReference = new TypeReference { TypeKind = TypeKind.EmbeddedDeclaration };

			if( isConst )
				result.TypeReference.Modifiers |= TypeModifiers.Const;

			if( isVolatile )
				result.TypeReference.Modifiers |= TypeModifiers.Volatile;

			do
			{
				string variableName = null;
				TypeReference variableType = null;

				// unnamed bitset
				// struct __darwin_fp_control { unsigned short :1, :2; };
				if( _tokens[localIndex].Type == Tokens.Colon )
				{
					variableType = result.TypeReference;
					goto parseBitset;
				}

				variableType = ParseDeclarationSubexpression( ref variableName, ref localIndex, result.TypeReference );
				if( variableName == null && ( declarationParsingFlags & DeclarationParsingFlags.NameMayBeOmitted ) == 0 )
					return null;

			parseBitset:
				// bitsets
				var declarationNode = new DeclarationNode { Name = variableName, TypeReference = variableType };

				if( _tokens[localIndex].Type == Tokens.Colon )
				{
					if( _context.Peek().ContextType != ContextType.Type && _context.Peek().ContextType != ContextType.ObjectiveType )
						ThrowException( localIndex, "bitsets can be only declared in structs/classes/unions" );

					localIndex++;

					declarationNode.TypeReference = new TypeReference { TypeKind = TypeKind.Bitset, ElementType = declarationNode.TypeReference, Size = GetExpression( ref localIndex ) };
					if( declarationNode.TypeReference.Size == null )
					{
						Debugger.Break();
						return null;
					}
				}

				if( _tokens[localIndex].Type == Tokens.Assign )
				{
					localIndex++;

					declarationNode.InitializerExpression = GetExpression( ref localIndex );
					if( declarationNode.InitializerExpression == null )
					{
						Debugger.Break();

						return null;
					}
				}

				SkipGCCAsm( ref localIndex );
				SkipGCCAttribute( ref localIndex );

				result.AddDeclarationNode( declarationNode );

				if( _tokens[localIndex].Type != Tokens.Comma || ( declarationParsingFlags & DeclarationParsingFlags.ParseFirst ) != 0 )
					break;

				localIndex++;
			} while( true );

			parsingLocation = localIndex;
			return result;
		}

		private TypeReference GetTypeReference( ref int parsingLocation )
		{
			var localIndex = parsingLocation;

			var declarationExpression = GetDeclarationExpression( ref localIndex, DeclarationParsingFlags.ParseFirst | DeclarationParsingFlags.NameMayBeOmitted );
			if( declarationExpression == null )
				return null;

			if( declarationExpression.Declarations.Count != 1 || declarationExpression.Declarations[0].Name != null )
				return null;

			parsingLocation = localIndex;
			return declarationExpression.Declarations[0].TypeReference;
		}

		private QualifiedName GetQualifiedName( ref int parsingLocation )
		{
			var localIndex = parsingLocation;

			if( _tokens[localIndex].Type != Tokens.Identifier && _tokens[localIndex].Type != Tokens.ScopeResolution )
				return null;

			var result = new QualifiedName();
			var nestedName = new QualifiedNestedName();

			if( Optional( Tokens.ScopeResolution, ref localIndex ) )
				result.NestedNames.Add( nestedName );

			while( _tokens[localIndex].Type == Tokens.Identifier )
			{
				var identifier = GetIdentifier( ref localIndex );
				nestedName = new QualifiedNestedName { Name = identifier };

				if( Optional( Tokens.LessThan, ref localIndex ) )
					using( _context.PushScoped( new EvaluationContext( null, ContextType.Generic ) ) )
						while( !Optional( Tokens.GreaterThan, ref localIndex ) )
						{
							var genericArgument = GetQualifiedName( ref localIndex );
							if( genericArgument == null )
							{
								var expression = GetExpression( ref localIndex );
								if( expression == null )
									Debugger.Break();
								else
									nestedName.GenericArguments.Add( expression );
							}
							else
								nestedName.GenericArguments.Add( genericArgument );

							if( Optional( Tokens.Comma, ref localIndex ) )
								continue;
						}

				result.NestedNames.Add( nestedName );

				if( Optional( Tokens.ScopeResolution, ref localIndex ) )
					continue;

				break;
			}

			parsingLocation = localIndex;
			return result;
		}

		private TemplateParametersDeclaration GetTemplateParametersDeclaration( ref int parsingLocation )
		{
			var localIndex = parsingLocation;

			if( !Optional( Tokens._template, ref localIndex ) )
				return null;

			Required( Tokens.LessThan, ref localIndex );

			var result = new TemplateParametersDeclaration();

			using( _context.PushScoped( new EvaluationContext( null, ContextType.Generic ) ) )
				while( !Optional( Tokens.GreaterThan, ref localIndex ) )
				{
					TemplateParameterDeclaration genericArgument = new TemplateParameterDeclaration();

					if( _tokens[localIndex].Type == Tokens._template )
						genericArgument.TemplateParametersDeclaration = GetTemplateParametersDeclaration( ref localIndex );

					if( Optional( Tokens._class, ref localIndex ) || Optional( Tokens._typename, ref localIndex ) )
					{
						var isTypename = _tokens[localIndex - 1].Type == Tokens._typename;

						genericArgument.Name = GetIdentifier( ref localIndex );
						genericArgument.ParameterType = isTypename ? TemplateParameterType.Typename : TemplateParameterType.Class;

						if( Optional( Tokens.Assign, ref localIndex ) )
						{
							genericArgument.Initializer = GetQualifiedName( ref localIndex ) ?? GetExpression( ref localIndex ) ?? ( Node ) GetTypeReference( ref localIndex );

							if( genericArgument.Initializer == null )
								Debugger.Break();
						}
					}
					else
					{
						var declarationExpression = GetDeclarationExpression( ref localIndex, DeclarationParsingFlags.ParseFirst | DeclarationParsingFlags.NameMayBeOmitted );
						if( declarationExpression == null )
							return null;

						genericArgument.TypeReference = declarationExpression.TypeReference;
						genericArgument.Initializer = declarationExpression.Declarations[0].InitializerExpression;
						genericArgument.Name = declarationExpression.Declarations[0].Name;
						genericArgument.ParameterType = TemplateParameterType.Type;
					}

					result.Parameters.Add( genericArgument );

					if( Optional( Tokens.Comma, ref localIndex ) )
						continue;
				}

			parsingLocation = localIndex;
			return result;
		}

		private TypeDeclarationExpression GetTypeDeclarationExpression( ref int parsingLocation )
		{
			var localIndex = parsingLocation;

			Func<Statement> nextMember = () =>
				( Statement ) GetMemberAccessSpecifier( ref localIndex ) ??
				( Statement ) GetConstructorDeclaration( ref localIndex ) ??
				( Statement ) GetDestructorDeclaration( ref localIndex ) ??
				( Statement ) GetTypedefStatement( ref localIndex ) ??
				( Statement ) GetTypeDeclarationStatement( ref localIndex ) ??
				( Statement ) GetDeclarationStatement( ref localIndex );

			TemplateParametersDeclaration templateParametersDeclaration = null;

			if( _tokens[localIndex].Type == Tokens._template )
				templateParametersDeclaration = GetTemplateParametersDeclaration( ref localIndex );

			var languageType = TypeDeclarationExpression.TypeKind.Invalid;
			switch( _tokens[localIndex++].Type )
			{
				case Tokens._class:
					languageType = TypeDeclarationExpression.TypeKind.Class;
					break;

				case Tokens._struct:
					languageType = TypeDeclarationExpression.TypeKind.Struct;
					break;

				case Tokens._union:
					languageType = TypeDeclarationExpression.TypeKind.Union;
					break;

				case Tokens._enum:
					languageType = TypeDeclarationExpression.TypeKind.Enum;
					break;

				default:
					return null;
			}

			var typeName = GetQualifiedName( ref localIndex );

			var result = new TypeDeclarationExpression();
			result.Type = languageType;
			result.Name = typeName;
			result.TemplateParametersDeclaration = templateParametersDeclaration;

			if( _tokens[localIndex].Type != Tokens.OpenCurlyBrace )
			{
				parsingLocation = localIndex;
				result.IsForwardDeclaration = true;
				return result;
			}

			localIndex++;
			// parse members

			if( result.Type == TypeDeclarationExpression.TypeKind.Enum )
			{
				do
				{
					if( _tokens[localIndex].Type == Tokens.CloseCurlyBrace )
						break;

					var enumElementDeclaration = new EnumElementDeclaration { Parent = result };

					enumElementDeclaration.Name = GetIdentifier( ref localIndex );
					if( enumElementDeclaration.Name == null )
					{
						Debugger.Break();

						return null;
					}

					if( _tokens[localIndex].Type == Tokens.Assign )
					{
						localIndex++;
						enumElementDeclaration.InitializerExpression = GetVariableInitializerExpression( ref localIndex );

						if( enumElementDeclaration.InitializerExpression == null )
						{
							Debugger.Break();

							return null;
						}
					}

					result.AddStatement( enumElementDeclaration );

					if( _tokens[localIndex].Type == Tokens.Comma )
						localIndex++;

				} while( !IsEOF( localIndex ) );
			}
			else
			{
				using( _context.PushScoped( new EvaluationContext( result, ContextType.Type ) ) )
				{
					do
					{
						if( _tokens[localIndex].Type == Tokens.CloseCurlyBrace )
							break;

						var member = nextMember();
						if( member != null )
						{
							result.AddStatement( member );
							continue;
						}

						Debugger.Break();
					} while( !IsEOF( localIndex ) );
				}
			}

			if( _tokens[localIndex++].Type != Tokens.CloseCurlyBrace )
				return null;

			parsingLocation = localIndex;
			return result;
		}

		private ParameterDeclaration GetParameterDeclaration( ref int parsingLocation )
		{
			var localIndex = parsingLocation;

			if( _tokens[localIndex++].Type != Tokens.OpenParenthesis )
				return null;

			var result = new ParameterDeclaration();

			// ()
			if( _tokens[localIndex].Type == Tokens.CloseParenthesis )
				goto end_parameter_declaration;

			// ( void )
			if( _tokens[localIndex].Type == Tokens._void && _tokens[localIndex + 1].Type == Tokens.CloseParenthesis )
			{
				localIndex++;
				goto end_parameter_declaration;
			}

			for( ; ; )
			{
				if( _tokens[localIndex].Type == Tokens.Ellipsis )
				{
					localIndex++;

					result.IsVararg = true;

					break;
				}

				var declarationExpression = GetDeclarationExpression( ref localIndex, DeclarationParsingFlags.ParseFirst | DeclarationParsingFlags.NameMayBeOmitted );
				if( declarationExpression == null || declarationExpression.Declarations.Count != 1 )
					return null;

				if( declarationExpression.Declarations[0].TypeReference == null )
					return null;

				result.AddParameter( declarationExpression.Declarations[0] );

				if( _tokens[localIndex].Type == Tokens.Comma )
				{
					localIndex++;
					continue;
				}
				break;
			}

		end_parameter_declaration:
			if( _tokens[localIndex++].Type != Tokens.CloseParenthesis )
				return null;

			parsingLocation = localIndex;
			return result;
		}

		private ConstructorDeclaration GetConstructorDeclaration( ref int parsingLocation )
		{
			var localIndex = parsingLocation;

			if( _context.Count == 0 )
				return null;

			var typeName = ( _context.Peek().Node as TypeDeclarationExpression ).Name;
			if( typeName == null || GetIdentifier( ref localIndex ) != typeName.NestedNames.Last().Name )
				return null;

			var parameterDeclaration = GetParameterDeclaration( ref localIndex );
			if( parameterDeclaration == null )
				return null;

			var result = new ConstructorDeclaration { ParameterDeclaration = parameterDeclaration };

			// currently we skip initialization list
			if( _tokens[localIndex++].Type == Tokens.Colon )
			{
				while( _tokens[localIndex].Type != Tokens.OpenCurlyBrace )
					localIndex++;
			}

			if( _tokens[localIndex].Type == Tokens.OpenCurlyBrace )
				localIndex = FindMatchingCurlyBrace( localIndex ) + 1;
			else if( _tokens[localIndex++].Type != Tokens.Semicolon )
				return null;

			parsingLocation = localIndex;
			return result;
		}

		private DestructorDeclaration GetDestructorDeclaration( ref int parsingLocation )
		{
			var localIndex = parsingLocation;

			if( _context.Count == 0 )
				return null;

			bool isVirtual = false;

			if( _tokens[localIndex].Type == Tokens._virtual )
			{
				isVirtual = true;
				localIndex++;
			}

			if( _tokens[localIndex++].Type != Tokens.BitwiseComplement )
				return null;

			if( GetIdentifier( ref localIndex ) != ( _context.Peek().Node as TypeDeclarationExpression ).Name.NestedNames.Last().Name )
				return null;

			if( _tokens[localIndex++].Type != Tokens.OpenParenthesis )
				return null;

			if( _tokens[localIndex++].Type != Tokens.CloseParenthesis )
				return null;

			var result = new DestructorDeclaration { IsVirtual = isVirtual };

			if( _tokens[localIndex].Type == Tokens.OpenCurlyBrace )
				localIndex = FindMatchingCurlyBrace( localIndex ) + 1;
			else if( _tokens[localIndex++].Type != Tokens.Semicolon )
				return null;

			parsingLocation = localIndex;
			return result;
		}

		private MemberAccessSpecifier GetMemberAccessSpecifier( ref int parsingLocation )
		{
			var localIndex = parsingLocation;

			var modifier = MemberAccessKind.Invalid;

			switch( _tokens[localIndex++].Type )
			{
				case Tokens._public:
					modifier = MemberAccessKind.Public;
					break;

				case Tokens._protected:
					modifier = MemberAccessKind.Protected;
					break;

				case Tokens._private:
					modifier = MemberAccessKind.Private;
					break;

				default:
					return null;
			}

			if( _tokens[localIndex++].Type != Tokens.Colon )
				return null;

			parsingLocation = localIndex;
			return new MemberAccessSpecifier { AccessKind = modifier };
		}

		private ObjectiveTypeModifierStatement GetObjectiveMemberModifierStatement( ref int parsingLocation )
		{
			var localIndex = parsingLocation;

			var modifier = ObjectiveTypeModifierStatement.Modifiers.Invalid;

			switch( _tokens[localIndex++].Type )
			{
				case Tokens.at_public:
					modifier = ObjectiveTypeModifierStatement.Modifiers.Public;
					break;

				case Tokens.at_protected:
					modifier = ObjectiveTypeModifierStatement.Modifiers.Protected;
					break;

				case Tokens.at_private:
					modifier = ObjectiveTypeModifierStatement.Modifiers.Private;
					break;

				case Tokens.at_optional:
					modifier = ObjectiveTypeModifierStatement.Modifiers.Optional;
					break;

				case Tokens.at_required:
					modifier = ObjectiveTypeModifierStatement.Modifiers.Required;
					break;

				default:
					return null;
			}


			parsingLocation = localIndex;
			return new ObjectiveTypeModifierStatement { Modifier = modifier };
		}

		private ExpressionStatement GetTypeDeclarationStatement( ref int parsingLocation )
		{
			var localIndex = parsingLocation;

			var result = GetTypeDeclarationExpression( ref localIndex );
			SkipGCCAttribute( ref localIndex );

			if( result == null || _tokens[localIndex].Type != Tokens.Semicolon )
				return null;

			localIndex++;

			parsingLocation = localIndex;
			return new ExpressionStatement( result );
		}

		private Statement GetDeclarationStatement( ref int parsingLocation )
		{
			var localIndex = parsingLocation;

			var functionModifiers = FunctionDefinitionStatement.FunctionModifiers.None;

			bool checkFunctionModifiers = true;
			while( checkFunctionModifiers )
			{
				SkipGCCAttribute( ref localIndex );

				switch( _tokens[localIndex++].Type )
				{
					case Tokens._static:
						functionModifiers |= FunctionDefinitionStatement.FunctionModifiers.Static;
						break;

					case Tokens.___forceinline:
						functionModifiers |= FunctionDefinitionStatement.FunctionModifiers.ForceInline;
						break;

					case Tokens.___inline:
					case Tokens.___inline__:
					case Tokens._inline:
						functionModifiers |= FunctionDefinitionStatement.FunctionModifiers.Inline;
						break;

					default:
						localIndex--;
						checkFunctionModifiers = false;
						break;
				}
			}

			var declarationExpresion = GetDeclarationExpression( ref localIndex, DeclarationParsingFlags.ParseAll );
			if( declarationExpresion == null )
				return null;

			SkipGCCAttribute( ref localIndex );

			if( _tokens[localIndex].Type != Tokens.OpenCurlyBrace || declarationExpresion.Declarations.Count != 1 || declarationExpresion.Declarations[0].TypeReference == null || ( declarationExpresion.Declarations[0].TypeReference.TypeKind != TypeKind.Function && declarationExpresion.Declarations[0].TypeReference.TypeKind != TypeKind.RedefinableOperator ) )
			{
				Required( Tokens.Semicolon, ref localIndex );

				parsingLocation = localIndex;
				return new ExpressionStatement( declarationExpresion );
			}

			// function declaration
			localIndex = FindMatchingCurlyBrace( localIndex ) + 1;

			var functionDefinitionStatement = new FunctionDefinitionStatement
			{
				DeclarationNode = declarationExpresion.Declarations[0],
				Modifiers = functionModifiers
			};

			parsingLocation = localIndex;
			return functionDefinitionStatement;
		}

		private TypedefStatement GetTypedefStatement( ref int parsingLocation )
		{
			var localIndex = parsingLocation;

			if( _tokens[localIndex].Type != Tokens._typedef )
				return null;

			localIndex++;

			var declarationExpression = GetDeclarationExpression( ref localIndex, DeclarationParsingFlags.ParseAll );
			if( declarationExpression == null )
			{
				Debugger.Break();

				return null;
			}

			var result = new TypedefStatement();
			result.DeclarationExpression = declarationExpression;

			localIndex++;

			parsingLocation = localIndex;
			return result;
		}

		private ObjectiveTypeForwardDeclarationStatement GetObjectiveTypeForwardDeclarationStatement( ref int parsingLocation )
		{
			var localIndex = parsingLocation;

			var declarationType = ObjectiveTypes.Invalid;

			switch( _tokens[localIndex++].Type )
			{
				case Tokens.at_class:
					declarationType = ObjectiveTypes.Class;
					break;

				case Tokens.at_protocol:
					declarationType = ObjectiveTypes.Protocol;
					break;

				default:
					return null;
			}

			var result = new ObjectiveTypeForwardDeclarationStatement { Type = declarationType };

			do
			{
				var identifier = GetIdentifier( ref localIndex );
				if( identifier == null )
					return null;

				result.Names.Add( identifier );

				if( _tokens[localIndex].Type == Tokens.Comma )
				{
					localIndex++;
					continue;
				}

				break;
			} while( !IsEOF( localIndex ) );

			if( _tokens[localIndex++].Type != Tokens.Semicolon )
				return null;

			parsingLocation = localIndex;
			return result;
		}

		private ObjectiveMethodDeclarationStatement GetObjectiveMethodDeclarationStatement( ref int parsingLocation )
		{
			var localIndex = parsingLocation;

			var methodType = ObjectiveMethodDeclarationStatement.MethodModifiers.Invalid;

			switch( _tokens[localIndex++].Type )
			{
				case Tokens.Minus:
					methodType = ObjectiveMethodDeclarationStatement.MethodModifiers.InstanceMethod;
					break;

				case Tokens.Plus:
					methodType = ObjectiveMethodDeclarationStatement.MethodModifiers.ClassMethod;
					break;

				default:
					return null;
			}

			var returnValueModifier = ObjectiveParameterModifier.None;
			TypeReference returnType = null;

			if( _tokens[localIndex].Type == Tokens.OpenParenthesis )
			{
				localIndex++;

				returnValueModifier = GetObjectiveParameterModifier( ref localIndex );

				returnType = GetTypeReference( ref localIndex );
				if( returnType == null )
					return null;

				if( _tokens[localIndex++].Type != Tokens.CloseParenthesis )
					return null;
			}

			var methodName = GetObjectiveIdentifier( ref localIndex );
			if( methodName == null )
				return null;

			var result = new ObjectiveMethodDeclarationStatement
			{
				Modifiers = methodType,
				Name = methodName,
				ReturnType = returnType,
				ReturnValueModifier = returnValueModifier
			};

			// parameters
			if( _tokens[localIndex].Type == Tokens.Colon )
			{
				localIndex++;

				var parameter = new ObjectiveParameterDeclaration();

				if( _tokens[localIndex].Type == Tokens.OpenParenthesis )
				{
					localIndex++;

					parameter.Modifer = GetObjectiveParameterModifier( ref localIndex );
					parameter.TypeReference = GetTypeReference( ref localIndex );

					if( _tokens[localIndex++].Type != Tokens.CloseParenthesis )
						return null;
				}

				parameter.Name = GetIdentifier( ref localIndex );
				result.AddParameter( parameter );

				SkipGCCAttribute( ref localIndex );

				while( _tokens[localIndex].Type != Tokens.Semicolon && _tokens[localIndex].Type != Tokens.OpenCurlyBrace )
				{
					if( SkipGCCAttribute( ref localIndex ) )
						continue;

					if( _tokens[localIndex].Type == Tokens.Comma )
					{
						localIndex++;

						if( _tokens[localIndex++].Type == Tokens.Ellipsis )
						{
							result.Modifiers |= ObjectiveMethodDeclarationStatement.MethodModifiers.Vararg;
							continue;
						}
					}

					parameter = new ObjectiveParameterDeclaration();

					parameter.SelectorPart = GetIdentifier( ref localIndex );

					if( _tokens[localIndex++].Type != Tokens.Colon )
						return null;

					if( _tokens[localIndex].Type == Tokens.OpenParenthesis )
					{
						localIndex++;

						parameter.Modifer = GetObjectiveParameterModifier( ref localIndex );
						parameter.TypeReference = GetTypeReference( ref localIndex );

						if( _tokens[localIndex++].Type != Tokens.CloseParenthesis )
							return null;
					}

					parameter.Name = GetIdentifier( ref localIndex );

					result.AddParameter( parameter );
				}
			}

			SkipGCCAttribute( ref localIndex );

			if( _tokens[localIndex].Type == Tokens.OpenCurlyBrace )
				localIndex = FindMatchingCurlyBrace( localIndex ) + 1;
			else if( _tokens[localIndex++].Type != Tokens.Semicolon )
			{
				Debugger.Break();

				return null;
			}

			parsingLocation = localIndex;
			return result;
		}

		private ObjectivePropertyDeclarationStatement GetObjectivePropertyDeclarationStatement( ref int parsingLocation )
		{
			var localIndex = parsingLocation;

			if( _tokens[localIndex++].Type != Tokens.at_property )
				return null;

			var result = new ObjectivePropertyDeclarationStatement();

			if( _tokens[localIndex].Type == Tokens.OpenParenthesis )
			{
				localIndex++;

				while( _tokens[localIndex].Type != Tokens.CloseParenthesis )
				{
					switch( GetIdentifier( ref localIndex ) )
					{
						case "readonly":
							result.Modifiers |= ObjectivePropertyDeclarationStatement.PropertyModifiers.ReadOnly;
							break;

						case "retain":
							result.Modifiers |= ObjectivePropertyDeclarationStatement.PropertyModifiers.Retain;
							break;

						case "copy":
							result.Modifiers |= ObjectivePropertyDeclarationStatement.PropertyModifiers.Copy;
							break;

						case "assign":
							result.Modifiers |= ObjectivePropertyDeclarationStatement.PropertyModifiers.Assign;
							break;

						case "getter":
							if( _tokens[localIndex++].Type != Tokens.Assign )
							{
								Debugger.Break();
								return null;
							}

							result.GetterName = GetIdentifier( ref localIndex );
							break;

						case "setter":
							if( _tokens[localIndex++].Type != Tokens.Assign )
							{
								Debugger.Break();
								return null;
							}

							result.SetterName = GetIdentifier( ref localIndex );
							break;

						default:
							Debugger.Break();

							return null;
					}

					if( _tokens[localIndex].Type == Tokens.Comma )
						localIndex++;
				}

				localIndex++;
			}

			result.DeclarationExpression = GetDeclarationExpression( ref localIndex, DeclarationParsingFlags.ParseAll );
			if( result.DeclarationExpression == null )
				return null;

			if( _tokens[localIndex++].Type != Tokens.Semicolon )
				return null;

			parsingLocation = localIndex;
			return result;
		}

		private ObjectiveParameterModifier GetObjectiveParameterModifier( ref int parsingLocation )
		{
			var localIndex = parsingLocation;

			switch( GetIdentifier( ref parsingLocation ) )
			{
				case "in": return ObjectiveParameterModifier.In;
				case "out": return ObjectiveParameterModifier.Out;
				case "inout": return ObjectiveParameterModifier.InOut;
				case "bycopy": return ObjectiveParameterModifier.ByCopy;
				case "byref": return ObjectiveParameterModifier.ByRef;
				case "oneway": return ObjectiveParameterModifier.Oneway;
			}

			parsingLocation = localIndex;
			return ObjectiveParameterModifier.None;
		}

		private ObjectiveTypeDeclarationStatement GetObjectiveTypeDeclarationStatement( ref int parsingLocation )
		{
			var localIndex = parsingLocation;

			Func<Statement> nextInstanceVariableSectionNode = () =>
				( Statement ) GetNullStatement( ref localIndex ) ??
				( Statement ) GetObjectiveMemberModifierStatement( ref localIndex ) ??
				( Statement ) GetDeclarationStatement( ref localIndex );

			Func<Statement> nextNode = () =>
				( Statement ) GetObjectiveMemberModifierStatement( ref localIndex ) ??
				( Statement ) GetObjectiveMethodDeclarationStatement( ref localIndex ) ??
				( Statement ) GetObjectivePropertyDeclarationStatement( ref localIndex ) ??
				( Statement ) GetTypeDeclarationStatement( ref localIndex ) ??
				( Statement ) GetTypedefStatement( ref localIndex ) ??
				( Statement ) GetDeclarationStatement( ref localIndex ) ??
				( Statement ) GetNullStatement( ref localIndex );

			var declarationType = ObjectiveTypes.Invalid;

			switch( _tokens[localIndex++].Type )
			{
				case Tokens.at_interface:
					declarationType = ObjectiveTypes.Class;
					break;

				case Tokens.at_protocol:
					declarationType = ObjectiveTypes.Protocol;
					break;

				default:
					return null;
			}

			var typeName = GetIdentifier( ref localIndex );
			if( typeName == null )
				return null;

			var result = new ObjectiveTypeDeclarationStatement { Type = declarationType, Name = typeName };
			using( _context.PushScoped( new EvaluationContext( result, ContextType.ObjectiveType ) ) )
			{

				if( _tokens[localIndex].Type == Tokens.Colon )
				{
					localIndex++;

					result.BaseClass = GetIdentifier( ref localIndex );
				}

				if( _tokens[localIndex].Type == Tokens.OpenParenthesis )
				{
					localIndex++;

					result.Category = GetIdentifier( ref localIndex );

					if( _tokens[localIndex++].Type != Tokens.CloseParenthesis )
						ThrowException( localIndex, @"Should close category name by "")""" );
				}

				if( _tokens[localIndex].Type == Tokens.LessThan )
				{
					do
					{
						localIndex++;

						var adoptedProtocol = GetIdentifier( ref localIndex );
						if( adoptedProtocol == null )
							ThrowException( localIndex, "Invalid protocol name" );

						result.AddAdoptedProtocol( adoptedProtocol );
					} while( _tokens[localIndex].Type == Tokens.Comma );

					if( _tokens[localIndex++].Type != Tokens.GreaterThan )
						ThrowException( localIndex, @"Should close adopted protocols list by "">""" );
				}

				if( _tokens[localIndex].Type == Tokens.OpenCurlyBrace )
				{
					localIndex++;

					while( _tokens[localIndex].Type != Tokens.CloseCurlyBrace )
					{
						var node = nextInstanceVariableSectionNode();
						if( node == null )
						{
							Debugger.Break();

							ThrowException( localIndex, "Cannot parse instance variable section element" );
						}

						result.AddIinstanceVariableStatement( node );
					}

					localIndex++;
				}

				while( _tokens[localIndex].Type != Tokens.at_end )
				{
					var statement = nextNode();
					if( statement != null )
					{
						result.AddStatement( statement );
						continue;
					}

					Debugger.Break();
				}

				localIndex++;

				parsingLocation = localIndex;
				return result;
			}
		}

		private NullStatement GetNullStatement( ref int parsingLocation )
		{
			var localIndex = parsingLocation;

			if( _tokens[localIndex++].Type != Tokens.Semicolon )
				return null;

			parsingLocation = localIndex;
			return new NullStatement();
		}

		private UsingDirectiveStatement GetUsingDirectiveStatement( ref int parsingLocation )
		{
			var localIndex = parsingLocation;
			if( _tokens[localIndex++].Type != Tokens._using )
				return null;

			if( _tokens[localIndex++].Type != Tokens._namespace )
				return null;

			var result = new UsingDirectiveStatement();

			while( _tokens[localIndex].Type != Tokens.Semicolon )
			{
				if( _tokens[localIndex].Type == Tokens.ScopeResolution )
				{
					localIndex++;
					continue;
				}

				var outerNamespace = GetIdentifier( ref localIndex );
				if( outerNamespace == null )
				{
					Debugger.Break();

					return null;
				}

				result.Namespace.Add( outerNamespace );
			}
			localIndex++;

			parsingLocation = localIndex;
			return result;
		}

		private UsingDeclarationStatement GetUsingDeclarationStatement( ref int parsingLocation )
		{
			var localIndex = parsingLocation;
			if( _tokens[localIndex++].Type != Tokens._using )
				return null;

			var typeReference = GetTypeReference( ref localIndex );
			if( typeReference == null )
			{
				Debugger.Break();

				return null;
			}

			var result = new UsingDeclarationStatement();
			result.TypeReference = typeReference;

			if( _tokens[localIndex++].Type != Tokens.Semicolon )
				return null;

			parsingLocation = localIndex;
			return result;
		}

		private NamespaceDeclaration GetNamespaceDeclaration( ref int parsingLocation )
		{
			var localIndex = parsingLocation;

			Func<Statement> nextStatement = () =>
				GetNamespaceDeclaration( ref localIndex ) ??
				GetTypedefStatement( ref localIndex ) ??
				GetTypeDeclarationStatement( ref localIndex ) ??
				GetDeclarationStatement( ref localIndex ) ??
				GetUsingDirectiveStatement( ref localIndex ) ??
				GetUsingDeclarationStatement( ref localIndex ) ??
				GetObjectiveTypeForwardDeclarationStatement( ref localIndex ) ??
				( Statement ) GetObjectiveTypeDeclarationStatement( ref localIndex );

			if( _tokens[localIndex++].Type != Tokens._namespace )
				return null;

			var result = new NamespaceDeclaration();
			result.Name = GetIdentifier( ref localIndex );

			if( _tokens[localIndex++].Type != Tokens.OpenCurlyBrace )
				return null;

			using( _context.PushScoped( new EvaluationContext( result, ContextType.Namespace ) ) )
			{
				while( _tokens[localIndex].Type != Tokens.CloseCurlyBrace && !IsEOF( localIndex ) )
				{
					var statement = nextStatement();

					if( statement != null )
					{
						result.AddStatement( statement );
						continue;
					}

					Debugger.Break();
				}
			}
			localIndex++;

			parsingLocation = localIndex;
			return result;
		}

		private TranslationUnit GetTranslationUnit()
		{
			int localIndex = 0;
			var result = new TranslationUnit();

			Func<Statement> nextStatement = () =>
				GetNullStatement( ref localIndex ) ??
				GetNamespaceDeclaration( ref localIndex ) ??
				GetTypedefStatement( ref localIndex ) ??
				GetTypeDeclarationStatement( ref localIndex ) ??
				GetDeclarationStatement( ref localIndex ) ??
				GetUsingDirectiveStatement( ref localIndex ) ??
				GetUsingDeclarationStatement( ref localIndex ) ??
				GetObjectiveTypeForwardDeclarationStatement( ref localIndex ) ??
				( Statement ) GetObjectiveTypeDeclarationStatement( ref localIndex );

			using( _context.PushScoped( new EvaluationContext( result, ContextType.TranslationUnit ) ) )
			{
				while( !IsEOF( localIndex ) )
				{
					var statement = nextStatement();

					if( statement != null )
					{
						result.AddStatement( statement );
						continue;
					}

					Debugger.Break();
				}

				return result;
			}
		}

		private bool IsEOF( int parsingLocation )
		{
			return parsingLocation >= _tokens.Length || _tokens[parsingLocation].Type == Tokens.EOF;
		}

		private bool SkipGCCAttribute( ref int parsingLocation )
		{
			int localIndex = parsingLocation;

			if( _tokens[localIndex++].Type != Tokens.___attribute__ )
				return false;

			localIndex = FindMatchingParenthesis( localIndex ) + 1;

			parsingLocation = localIndex;
			return true;
		}

		private void SkipGCCAsm( ref int parsingLocation )
		{
			int localIndex = parsingLocation;

			if( _tokens[localIndex++].Type != Tokens.___asm )
				return;

			localIndex = FindMatchingParenthesis( localIndex ) + 1;

			parsingLocation = localIndex;
		}

		private int FindMatchingCurlyBrace( int parsingLocation )
		{
			int localIndex = parsingLocation;
			int bracesCount = 0;

			do
			{
				if( _tokens[localIndex].Type == Tokens.OpenCurlyBrace )
					bracesCount++;
				else if( _tokens[localIndex].Type == Tokens.CloseCurlyBrace )
					bracesCount--;

				localIndex++;
			} while( bracesCount > 0 );

			return --localIndex;
		}

		private int FindMatchingParenthesis( int parsingLocation )
		{
			int localIndex = parsingLocation;
			int parenthesisCount = 0;

			do
			{
				if( _tokens[localIndex].Type == Tokens.OpenParenthesis )
					parenthesisCount++;
				else if( _tokens[localIndex].Type == Tokens.CloseParenthesis )
					parenthesisCount--;

				localIndex++;
			} while( parenthesisCount > 0 );

			return --localIndex;
		}

		private int FindMatchingSquareBracket( int parsingLocation )
		{
			int localIndex = parsingLocation;
			int bracketsCount = 0;

			do
			{
				if( _tokens[localIndex].Type == Tokens.OpenSquareBracket )
					bracketsCount++;
				else if( _tokens[localIndex].Type == Tokens.CloseSquareBracket )
					bracketsCount--;

				localIndex++;
			} while( bracketsCount > 0 );

			return --localIndex;
		}

		private int FindSemicolon( int parsingLocation )
		{
			int localIndex = parsingLocation;

			while( !IsEOF( localIndex ) )
			{
				if( _tokens[localIndex].Type == Tokens.Semicolon )
					return localIndex;

				localIndex++;
			}

			return localIndex;
		}

		private string GetIdentifier( ref int parsingLocation )
		{
			if( _tokens[parsingLocation].Type != Tokens.Identifier )
				return null;

			return ( string ) _tokens[parsingLocation++].Value;
		}

		private string GetObjectiveIdentifier( ref int parsingLocation )
		{
			var localIndex = parsingLocation;

			var result = GetIdentifier( ref localIndex );

			if( result == null )
			{
				switch( _tokens[localIndex].Type )
				{
					case Tokens._class:
					case Tokens._new:
					case Tokens._delete:
					case Tokens._template:
						result = Lexer.GetTokenString( _tokens[localIndex++].Type );
						break;

					default:
						return null;
				}
			}

			parsingLocation = localIndex;
			return result;
		}

		private void ThrowException( int parsingLocation, string format, params object[] parameters )
		{
			throw new ParserException( string.Format( format, parameters ), _tokens[parsingLocation].Row, _tokens[parsingLocation].Column );
		}
	}

	/// <summary>
	/// Occured while parser encounters any parsing error.
	/// </summary>
	public class ParserException : Exception
	{
		public ParserException( string message, int row, int column )
			: base( message )
		{
			Row = row;
			Column = column;
		}

		public int Row { get; private set; }
		public int Column { get; private set; }
	}
}
