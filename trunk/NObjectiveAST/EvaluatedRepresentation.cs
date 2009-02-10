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
using System.Reflection;

namespace NObjectiveAST.EvaluatedRepresentation
{
	public abstract class Node
	{
	}

	public abstract class LanguageType : Node
	{
		public abstract string Name { get; set; }

		public abstract int Size { get; }

		public override string ToString()
		{
			return string.Format( @"{0}", Name );
		}
	}

	public class Enum : LanguageType
	{
		public NObjectiveAST.TypeDeclarationExpression Original { get; set; }

		public override string Name { get; set; }
		public override int Size { get { return 4; } }

		public SortedList<string, long> Items = new SortedList<string, long>();
	}

	public class CppType : LanguageType
	{
		public NObjectiveAST.TypeDeclarationExpression Original { get; set; }

		public override string Name { get; set; }
		public override int Size
		{
			get
			{
				return Math.Max( 1,
					Fields.Where( x => !( x.Type is BitsetType ) ).Sum( x => x.Type.Size ) +
					Fields.Select( x => x.Type ).OfType<BitsetType>().Sum( x => x.BitsetSize ) / 8 );
			}
		}

		public bool IsDefined { get; set; }
		public List<Variable> Fields = new List<Variable>();

		public override string ToString()
		{
			return string.Format( @"{0}", Name );
		}
	}

	public class PrimitiveType : LanguageType
	{
		public static readonly PrimitiveType Void = new PrimitiveType( "void" );

		public static readonly PrimitiveType Bool = new PrimitiveType( "bool" );
		public static readonly PrimitiveType WideChar = new PrimitiveType( "wchar_t" );

		public static readonly PrimitiveType Char = new PrimitiveType( "char" );
		public static readonly PrimitiveType Short = new PrimitiveType( "short" );
		public static readonly PrimitiveType Int = new PrimitiveType( "int" );
		public static readonly PrimitiveType Long = new PrimitiveType( "long" );
		public static readonly PrimitiveType LongLong = new PrimitiveType( "long long" );
		public static readonly PrimitiveType UnsignedChar = new PrimitiveType( "unsgned char" );
		public static readonly PrimitiveType UnsignedShort = new PrimitiveType( "unsigned short" );
		public static readonly PrimitiveType UnsignedInt = new PrimitiveType( "unsigned int" );
		public static readonly PrimitiveType UnsignedLong = new PrimitiveType( "unsigned long" );
		public static readonly PrimitiveType UnsignedLongLong = new PrimitiveType( "unsigned long long" );

		public static readonly PrimitiveType Float = new PrimitiveType( "float" );
		public static readonly PrimitiveType Double = new PrimitiveType( "double" );
		public static readonly PrimitiveType LongDouble = new PrimitiveType( "long double" );

		private PrimitiveType( string name )
		{
			Name = name;
		}

		public override string Name { get; set; }

		public override int Size
		{
			get { return _sizes[this]; }
		}

		public override string ToString()
		{
			return Name;
		}

		private static readonly Dictionary<PrimitiveType, int> _sizes = new Dictionary<PrimitiveType, int>
		{
			{ Void, 0 },

			{ Bool, 1 },
			{ WideChar, 2 },

			{ Char, 1 },
			{ Short, 2 },
			{ Int, 4 },
			{ Long, 4 },
			{ LongLong, 8 },
			{ UnsignedChar, 1 },
			{ UnsignedShort, 2 },
			{ UnsignedInt, 4 },
			{ UnsignedLong, 4 },
			{ UnsignedLongLong, 8 },
			
			{ Float, 4 },
			{ Double, 8 },
			{ LongDouble, 10 },
		};

		public static bool IsPrimitive( string value )
		{
			foreach( var field in typeof( PrimitiveType ).GetFields( BindingFlags.Static | BindingFlags.Public ) )
				if( value == ( ( PrimitiveType ) field.GetValue( null ) ).Name )
					return true;

			return false;
		}
	}

	public class PointerType : LanguageType
	{
		public override string Name
		{
			get { return string.Format( "{0} *", Pointee ); }
			set { throw new InvalidOperationException(); }
		}

		public override int Size { get { return 4; } }

		public LanguageType Pointee { get; set; }

		public PointerType( LanguageType pointee )
		{
			Pointee = pointee;
		}
	}

	public class ReferenceType : LanguageType
	{
		public override string Name
		{
			get { return string.Format( "{0} &", Pointee ); }
			set { throw new InvalidOperationException(); }
		}

		public override int Size { get { return 4; } }

		public LanguageType Pointee { get; set; }

		public ReferenceType( LanguageType pointee )
		{
			Pointee = pointee;
		}
	}

	public class ArrayType : LanguageType
	{
		public override string Name
		{
			get { return string.Format( "{0}[{1}]", ElementType, ArraySizeNotSpecified ? "" : ArraySize.ToString() ); }
			set { throw new InvalidOperationException(); }
		}

		/// <summary>
		/// -1 if array size is omitted
		/// </summary>
		public int ArraySize { get; set; }

		public bool ArraySizeNotSpecified { get { return ArraySize == -1; } }

		public override int Size
		{
			get
			{
				if( ArraySizeNotSpecified )
					return -1;

				return ElementType.Size * ArraySize;
			}
		}

		public LanguageType ElementType { get; set; }

		public ArrayType( LanguageType element, int size )
		{
			ElementType = element;
			ArraySize = size;
		}
	}

	public class BitsetType : LanguageType
	{
		public override string Name
		{
			get { return string.Format( "{0}:{1}", ElementType, BitsetSize ); }
			set { throw new InvalidOperationException(); }
		}

		public override int Size
		{
			get { return BitsetSize / 8; }
		}

		public int BitsetSize { get; set; }
		
		/// <summary>
		/// Enum or primitive type.
		/// </summary>
		public LanguageType ElementType { get; set; }

		public BitsetType( LanguageType elementType, int bitsetSize )
		{
			BitsetSize = bitsetSize;
			ElementType = elementType;
		}
	}

	public class Variable : Node
	{
		public string Name { get; set; }

		public LanguageType Type { get; set; }

		public Variable( string name, LanguageType type )
		{
			Name = name;
			Type = type;
		}

		public override string ToString()
		{
			return string.Format( @"{0} {1}", Type, Name );
		}
	}

	public class Method : LanguageType
	{
		public override string Name { get; set; }
		public override int Size { get { return 0; } }

		public Node DeclaredIn { get; set; }
		public LanguageType ReturnType { get; set; }

		public List<Variable> Parameters = new List<Variable>();

		public CppType DeclaringClass { get { return DeclaredIn as CppType; } }
		public CppNamespace DeclaringNamespace { get { return DeclaredIn as CppNamespace; } }
	}

	public class CppNamespace : Node
	{
		public CppNamespace OuterNamespace { get; set; }
	}

	public class ObjectiveType : LanguageType
	{
		public override string Name { get; set; }

		public override int Size
		{
			get { return Math.Max( 1, Fields.Sum( x => x.Type.Size ) ); }
		}

		public List<Variable> Fields = new List<Variable>();
		public List<ObjectiveMethod> Methods = new List<ObjectiveMethod>();
		public List<ObjectiveProperty> Properties = new List<ObjectiveProperty>();
	}

	public class ObjectiveMethod : Node
	{
		public ObjectiveMethodDeclarationStatement Original { get; set; }

		public string Name { get; set; }

		public bool IsVararg { get; set; }

		private bool _isInstanceMethod = false;

		public bool IsClassMethod { get { return !_isInstanceMethod; } set { _isInstanceMethod = !value; } }
		public bool IsInstanceMethod { get { return _isInstanceMethod; } set { _isInstanceMethod = value; } }

		public LanguageType ReturnType { get; set; }

		public List<Variable> Parameters = new List<Variable>();
		public List<string> SelectorParts = new List<string>();

		public string FullName
		{
			get { return Name + ( Parameters.Count > 0 ? ":" + string.Join( "", SelectorParts.Select( x => x + ":" ).ToArray() ) : "" ); }
		}

		public override string ToString()
		{
			return FullName;
		}
	}

	public class ObjectiveProperty : Node
	{
		public DeclarationNode Original { get; set; }
		public ObjectivePropertyDeclarationStatement DeclarationStatement { get; set; }

		public string Name { get; set; }

		public LanguageType PropertyType { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}
	public class TranslationUnit : Node
	{
		public List<Enum> Enums = new List<Enum>();
		public List<CppType> CppTypes = new List<CppType>();
		public List<ObjectiveType> ObjectiveTypes = new List<ObjectiveType>();
		public List<Variable> Variables = new List<Variable>();

		public List<CppNamespace> Namespaces = new List<CppNamespace>();
	}

	public class EvaluationVisitor : TraversalVisitor
	{
		public TranslationUnit TranslationUnit { get; set; }

		internal Stack<NObjectiveAST.Node> ASTScope = new Stack<NObjectiveAST.Node>();
		internal Stack<Node> Scope = new Stack<Node>();

		/// <summary>
		/// structs, enums
		/// </summary>
		internal Stack<Dictionary<string, LanguageType>> Types = new Stack<Dictionary<string, LanguageType>>();
		internal Stack<Dictionary<string, LanguageType>> TypeAliases = new Stack<Dictionary<string, LanguageType>>();

		private static readonly Dictionary<string, PrimitiveType> _cppTypeMapping;

		static EvaluationVisitor()
		{
			_cppTypeMapping = new Dictionary<string, PrimitiveType>();

			foreach( var cppTypeField in typeof( PrimitiveType ).GetFields( BindingFlags.Public | BindingFlags.Static ) )
			{
				var cppType = cppTypeField.GetValue( null ) as PrimitiveType;

				_cppTypeMapping[cppType.Name] = cppType;
			}

		}

		public static TranslationUnit GetTranslationUnit( NObjectiveAST.TranslationUnit translationUnit )
		{
			return new EvaluationVisitor( translationUnit ).TranslationUnit;
		}

		public EvaluationVisitor( NObjectiveAST.TranslationUnit translationUnit )
		{
			TranslationUnit = new TranslationUnit();
			Types.Push( new Dictionary<string, LanguageType>() );
			TypeAliases.Push( new Dictionary<string, LanguageType>() );

			Scope.Push( TranslationUnit );
			ASTScope.Push( translationUnit );

			translationUnit.AcceptVisitor( this );
		}

		public EvaluationVisitor( string text )
			: this( new Parser( new Lexer( text ) ).TranslationUnit )
		{
		}

		public override object Visit( TypeDeclarationExpression node )
		{
			using( ASTScope.PushScoped( node ) )
			{
				if( node.Type == TypeDeclarationExpression.TypeKind.Enum )
				{
					long value = 0;
					var @enum = new Enum();
					@enum.Original = node;

					using( Scope.PushScoped( @enum ) )
						foreach( EnumElementDeclaration element in node.Body )
						{
							if( element.InitializerExpression != null )
							{
								var evaluatedValue = element.InitializerExpression.AcceptVisitor( new ConstantEvaluator( this ) );
								if( evaluatedValue == null )
									Debugger.Break();

								value = ( long ) evaluatedValue;
							}

							@enum.Items.Add( element.Name, value );

							value++;
						}

					TranslationUnit.Enums.Add( @enum );

					if( node.Name != null )
						Types.Peek()[node.Name.ToString()] = @enum;

					return @enum;
				}
				else
				{
					LanguageType cppTypeNode;
					CppType cppType = null;

					if( node.Name != null && Types.Peek().TryGetValue( node.Name.ToString(), out cppTypeNode ) )
						cppType = ( CppType ) cppTypeNode;
					else
					{
						cppType = new CppType();
						cppType.Name = node.Name != null ? node.Name.ToString() : null;
						cppType.Original = node;
					}

					if( !cppType.IsDefined && !node.IsForwardDeclaration )
					{
						cppType.IsDefined = true;
					}
					else if( cppType.IsDefined && !node.IsForwardDeclaration )
					{
						Debugger.Break();
					}

					if( node.Name != null )
						Types.Peek()[node.Name.ToString()] = cppType;

					TranslationUnit.CppTypes.Add( cppType );

					using( Scope.PushScoped( cppType ) )
						base.Visit( node );

					return cppType;
				}
			}
		}

		public override object Visit( DeclarationNode node )
		{
			var cppType = Scope.Peek() as CppType;
			if( cppType != null )
				cppType.Fields.Add( new Variable( node.Name, Convert( node.TypeReference ) ) );

			var objectiveType = Scope.Peek() as ObjectiveType;
			if( objectiveType != null )
				objectiveType.Fields.Add( new Variable( node.Name, Convert( node.TypeReference ) ) );

			return null;
		}

		public override object Visit( ObjectiveTypeForwardDeclarationStatement node )
		{
			foreach( var typeName in node.Names )
			{
				LanguageType objectiveTypeNode = null;
				ObjectiveType objectiveType = null;

				if( Types.Peek().TryGetValue( typeName, out objectiveTypeNode ) )
					objectiveType = ( ObjectiveType ) objectiveTypeNode;
				else
				{
					objectiveType = new ObjectiveType();
					TranslationUnit.ObjectiveTypes.Add( objectiveType );
					Types.Peek()[typeName] = objectiveType;

					objectiveType.Name = typeName;
				}
			}

			return null;
		}

		public override object Visit( ObjectiveTypeDeclarationStatement node )
		{
			using( ASTScope.PushScoped( node ) )
			{
				LanguageType objectiveTypeNode = null;
				ObjectiveType objectiveType = null;

				if( Types.Peek().TryGetValue( node.Name, out objectiveTypeNode ) )
					objectiveType = ( ObjectiveType ) objectiveTypeNode;
				else
				{
					objectiveType = new ObjectiveType();
					TranslationUnit.ObjectiveTypes.Add( objectiveType );
					Types.Peek()[node.Name] = objectiveType;

					objectiveType.Name = node.Name;
				}

				using( Scope.PushScoped( objectiveType ) )
					return base.Visit( node );
			}
		}

		public override object Visit( ObjectiveMethodDeclarationStatement node )
		{
			using( ASTScope.PushScoped( node ) )
			using( Scope.PushScoped( new ObjectiveMethod() ) )
			{
				var objectiveClass = Scope.Skip( 1 ).FirstOrDefault() as ObjectiveType;
				var objectiveMethod = Scope.Peek() as ObjectiveMethod;

				objectiveMethod.Name = node.Name;
				objectiveMethod.Original = node;

				if( node.Parameters.Count > 1 )
					objectiveMethod.SelectorParts = node.Parameters.Skip( 1 ).Select( x => x.SelectorPart ).ToList();

				objectiveMethod.IsVararg = ( node.Modifiers & ObjectiveMethodDeclarationStatement.MethodModifiers.Vararg ) != 0;
				objectiveMethod.IsInstanceMethod = ( node.Modifiers & ObjectiveMethodDeclarationStatement.MethodModifiers.InstanceMethod ) != 0;

				objectiveMethod.ReturnType = Convert( node.ReturnType );

				foreach( var parameter in node.Parameters )
					objectiveMethod.Parameters.Add( new Variable( parameter.SelectorPart, Convert( parameter.TypeReference ) ) );

				objectiveClass.Methods.Add( objectiveMethod );
				return base.Visit( node );
			}
		}

		public override object Visit( ObjectivePropertyDeclarationStatement node )
		{
			using( ASTScope.PushScoped( node ) )
			{
				var objectiveClass = Scope.FirstOrDefault() as ObjectiveType;
				var objectiveProperty = new ObjectiveProperty();

				foreach( var declaration in node.DeclarationExpression.Declarations )
				{
					objectiveProperty.Name = declaration.Name;
					
					objectiveProperty.Original = declaration;
					objectiveProperty.DeclarationStatement = node;

					objectiveProperty.PropertyType = Convert( declaration.TypeReference );

					objectiveClass.Properties.Add( objectiveProperty );
				}
			}

			return null;
		}
		
		public override object Visit( TypedefStatement node )
		{
			LanguageType declaredType = null;
			
			if( node.DeclarationExpression.TypeDeclarationExpression != null )
				declaredType = ( LanguageType ) node.DeclarationExpression.TypeDeclarationExpression.AcceptVisitor( this );

			foreach( var declaration in node.DeclarationExpression.Declarations )
				TypeAliases.Peek()[declaration.Name] = Convert( declaration.TypeReference, declaredType );

			if( declaredType != null && declaredType.Name == null )
			{
				foreach( var declarationWithoutModifiers in node.DeclarationExpression.Declarations.Where( x => x.TypeReference == node.DeclarationExpression.TypeReference ) )
				{
					declaredType.Name = declarationWithoutModifiers.Name;
					break;
				}
			}

			return null;
		}

		private LanguageType Convert( TypeReference typeReference )
		{
			return Convert( typeReference, null );
		}

		private LanguageType Convert( TypeReference typeReference, LanguageType resolved )
		{
			if( typeReference == null )
				return null;

			switch( typeReference.TypeKind )
			{
				case TypeKind.Normal:
					if( typeReference.TypeName == null )
						return resolved;

					if( _cppTypeMapping.ContainsKey( typeReference.TypeName ) )
						return _cppTypeMapping[typeReference.TypeName];

					foreach( var alias in TypeAliases )
						if( alias.ContainsKey( typeReference.TypeName ) )
							return alias[typeReference.TypeName];

					foreach( var alias in Types )
						if( alias.ContainsKey( typeReference.TypeName ) )
							return alias[typeReference.TypeName];

					break;

				case TypeKind.Bitset:
					return new BitsetType( Convert( typeReference.ElementType, resolved ), ( int ) ( long ) typeReference.Size.AcceptVisitor( new ConstantEvaluator( this ) ) );

				case TypeKind.Array:
					return new ArrayType( Convert( typeReference.ElementType ), typeReference.Size is EmptyExpression ? -1 : ( int ) ( long ) typeReference.Size.AcceptVisitor( new ConstantEvaluator( this ) ) );

				case TypeKind.Pointer:
					return new PointerType( Convert( typeReference.ElementType, resolved ) );

				case TypeKind.Reference:
					return new ReferenceType( Convert( typeReference.ElementType, resolved ) );

				case TypeKind.EmbeddedDeclaration:
					return resolved;

				case TypeKind.Function:
					{
						var result = new Method();

						result.Name = typeReference.TypeName;
						result.DeclaredIn = Scope.Peek();

						foreach( var parameter in typeReference.ParameterDeclaration.Parameters )
						{
							var evaluatedParameter = new Variable( parameter.Name, Convert( parameter.TypeReference ) );

							result.Parameters.Add( evaluatedParameter );
						}

						return result;
					}

				case TypeKind.RValueReference:
					break;

				case TypeKind.RedefinableOperator:
					break;

				default:
					break;
			}

			return null;
		}
	}

	internal class ConstantEvaluator : TraversalVisitor
	{
		public EvaluationVisitor _evaluationVisitor;

		public ConstantEvaluator( EvaluationVisitor evaluationVisitor )
		{
			_evaluationVisitor = evaluationVisitor;
		}

		public override object Visit( PrimitiveExpression node )
		{
			return node.Value.Value;
		}

		public override object Visit( ParenthesizedExpression node )
		{
			return node.Expression.AcceptVisitor( this );
		}

		public override object Visit( UnaryOperatorExpression node )
		{
			switch( node.Operator )
			{
				case UnaryOperatorExpression.Operators.Complement:
					return ~Convert.ToInt64( node.Expression.AcceptVisitor( this ) );
				case UnaryOperatorExpression.Operators.Not:
					return Convert.ToInt64( node.Expression.AcceptVisitor( this ) ) == 0 ? 1L : 0L;
				case UnaryOperatorExpression.Operators.Minus:
					return -Convert.ToInt64( node.Expression.AcceptVisitor( this ) );
				case UnaryOperatorExpression.Operators.Plus:
					return +Convert.ToInt64( node.Expression.AcceptVisitor( this ) );
				default:
					Debugger.Break();
					break;
			}

			return null;
		}

		public override object Visit( BinaryOperatorExpression node )
		{
			switch( node.Operator )
			{
				case BinaryOperatorExpression.Operators.Multiply:
					return Convert.ToInt64( node.Left.AcceptVisitor( this ) ) * Convert.ToInt64( node.Right.AcceptVisitor( this ) );
				case BinaryOperatorExpression.Operators.Divide:
					return Convert.ToInt64( node.Left.AcceptVisitor( this ) ) / Convert.ToInt64( node.Right.AcceptVisitor( this ) );
				case BinaryOperatorExpression.Operators.Modulus:
					return Convert.ToInt64( node.Left.AcceptVisitor( this ) ) % Convert.ToInt64( node.Right.AcceptVisitor( this ) );
				case BinaryOperatorExpression.Operators.Add:
					return Convert.ToInt64( node.Left.AcceptVisitor( this ) ) + Convert.ToInt64( node.Right.AcceptVisitor( this ) );
				case BinaryOperatorExpression.Operators.Subtract:
					return Convert.ToInt64( node.Left.AcceptVisitor( this ) ) - Convert.ToInt64( node.Right.AcceptVisitor( this ) );
				case BinaryOperatorExpression.Operators.ShiftLeft:
					return Convert.ToInt64( node.Left.AcceptVisitor( this ) ) << Convert.ToInt32( node.Right.AcceptVisitor( this ) );
				case BinaryOperatorExpression.Operators.ShiftRight:
					return Convert.ToInt64( node.Left.AcceptVisitor( this ) ) >> Convert.ToInt32( node.Right.AcceptVisitor( this ) );
				case BinaryOperatorExpression.Operators.LessThan:
					return Convert.ToInt64( node.Left.AcceptVisitor( this ) ) < Convert.ToInt64( node.Right.AcceptVisitor( this ) );
				case BinaryOperatorExpression.Operators.GreaterThan:
					return Convert.ToInt64( node.Left.AcceptVisitor( this ) ) > Convert.ToInt64( node.Right.AcceptVisitor( this ) );
				case BinaryOperatorExpression.Operators.LessThanOrEqual:
					return Convert.ToInt64( node.Left.AcceptVisitor( this ) ) <= Convert.ToInt64( node.Right.AcceptVisitor( this ) );
				case BinaryOperatorExpression.Operators.GreaterThanOrEqual:
					return Convert.ToInt64( node.Left.AcceptVisitor( this ) ) >= Convert.ToInt64( node.Right.AcceptVisitor( this ) );
				case BinaryOperatorExpression.Operators.Equality:
					return Convert.ToInt64( node.Left.AcceptVisitor( this ) ) == Convert.ToInt64( node.Right.AcceptVisitor( this ) );
				case BinaryOperatorExpression.Operators.Inequality:
					return Convert.ToInt64( node.Left.AcceptVisitor( this ) ) != Convert.ToInt64( node.Right.AcceptVisitor( this ) );
				case BinaryOperatorExpression.Operators.BitwiseAnd:
					return Convert.ToInt64( node.Left.AcceptVisitor( this ) ) & Convert.ToInt64( node.Right.AcceptVisitor( this ) );
				case BinaryOperatorExpression.Operators.ExclusiveOr:
					return Convert.ToInt64( node.Left.AcceptVisitor( this ) ) ^ Convert.ToInt64( node.Right.AcceptVisitor( this ) );
				case BinaryOperatorExpression.Operators.BitwiseOr:
					return Convert.ToInt64( node.Left.AcceptVisitor( this ) ) | Convert.ToInt64( node.Right.AcceptVisitor( this ) );
				case BinaryOperatorExpression.Operators.LogicalAnd:
					return ( Convert.ToInt64( node.Left.AcceptVisitor( this ) ) & Convert.ToInt64( node.Right.AcceptVisitor( this ) ) ) == 0 ? 0L : 1L;
				case BinaryOperatorExpression.Operators.LogicalOr:
					return ( Convert.ToInt64( node.Left.AcceptVisitor( this ) ) | Convert.ToInt64( node.Right.AcceptVisitor( this ) ) ) == 0 ? 0L : 1L;

				case BinaryOperatorExpression.Operators.Invalid:
				default:
					break;
			}

			return null;
		}

		public override object Visit( QualifiedIdentifierExpression node )
		{
			foreach( var item in _evaluationVisitor.Scope )
			{
				var enumScope = item as Enum;
				if( enumScope != null )
				{
					if( enumScope.Items.ContainsKey( node.QualifiedName.ToString() ) )
						return enumScope.Items[node.QualifiedName.ToString()];

					continue;
				}

				var translationUnitScope = item as TranslationUnit;
				if( translationUnitScope != null )
				{
					foreach( var @enum in translationUnitScope.Enums )
					{
						if( @enum.Items.ContainsKey( node.QualifiedName.ToString() ) )
							return @enum.Items[node.QualifiedName.ToString()];
					}

					continue;
				}
			}
			return base.Visit( node );
		}

		public override object Visit( CastExpression node )
		{
			return node.Expression.AcceptVisitor( this );
		}

		public override object Visit( SizeofExpression node )
		{
			return 0xCCCCCCCCL;// _evaluationVisitor.Visit( node.Node );
		}
	}
}
