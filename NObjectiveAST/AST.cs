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
using System.Xml.Serialization;

namespace NObjectiveAST
{
	/// <summary>
	/// Base class for all nodes in AST
	/// </summary>
	public abstract class Node
	{
		[XmlIgnore]
		public Node Parent { get; set; }

		protected T SetParent<T>( T node ) where T : Node
		{
			if( node != null )
				node.Parent = this;

			return node;
		}

		protected List<T> SetParent<T>( List<T> nodeCollection ) where T : Node
		{
			if( nodeCollection != null )
				nodeCollection.Perform( x => SetParent( x ) );

			return nodeCollection;
		}

		public virtual object AcceptVisitor( IAstVisitor visitor ) { throw new Exception( "Should implement AcceptVisitor properly!" ); }

		public override string ToString()
		{
			return OutputVisitor.GetNodeText( this );
		}
	}

	/// <summary>
	/// boost::mpl::detail
	/// </summary>
	public partial class QualifiedName : Node
	{
		private List<QualifiedNestedName> _nestedNames = new List<QualifiedNestedName>();

		public QualifiedName()
		{
		}

		public QualifiedName( string name )
		{
			_nestedNames.Add( new QualifiedNestedName( name ) );
		}
	}

	public partial class QualifiedNestedName : Node
	{
		private string _name;

		/// <summary>
		/// Can be expression or QualifiedName
		/// </summary>
		private List<Node> _genericArguments;

		public QualifiedNestedName()
		{
		}

		public QualifiedNestedName( string name )
		{
			_name = name;
		}
	}

	/// <summary>
	/// ...;
	/// </summary>
	public abstract class Statement : Node
	{
	}

	/// <summary>
	/// ...
	/// </summary>
	public abstract class Expression : Node
	{
	}

	/// <summary>
	/// Special expression for omitted array sizes etc.
	/// </summary>
	public partial class EmptyExpression : Expression
	{
	}

	/// <summary>
	/// {
	///		...
	///	}
	/// </summary>
	public partial class ScopeStatement : Statement
	{
	}

	/// <summary>
	/// Represents file contents
	/// </summary>
	public partial class TranslationUnit : Node
	{
		private List<Statement> _body;

		public void AddStatement( Statement node )
		{
			_body = _body ?? new List<Statement>();
			_body.Add( SetParent( node ) );
		}
	}

	/// <summary>
	/// int xxx
	/// int foo()
	/// int ( *foo() )(FILE *)
	/// </summary>
	public partial class DeclarationNode : Node
	{
		/// <summary>
		/// Name of astField/variable/function
		/// </summary>
		private string _name;

		private TypeReference _typeReference;
		private Expression _initializerExpression;

		public DeclarationNode()
		{
		}

		public DeclarationNode( TypeReference typeReference )
		{
			_typeReference = SetParent( typeReference );
		}

		public DeclarationNode( TypeReference typeReference, Expression initializerExpression )
		{
			_typeReference = SetParent( typeReference );
			_initializerExpression = SetParent( initializerExpression );
		}
	}

	public enum ObjectiveTypes
	{
		Invalid,

		Class,
		Protocol
	}

	/// <summary>
	/// @class a, b;
	/// @protocol c, d;
	/// </summary>
	public partial class ObjectiveTypeForwardDeclarationStatement : Statement
	{
		private ObjectiveTypes _type;

		public List<string> Names = new List<string>();
	}

	/// <summary>
	/// @interface a
	///		...
	///	@end
	///	
	/// @protocol a
	///		...
	///	@end
	/// </summary>
	public partial class ObjectiveTypeDeclarationStatement : Statement
	{
		private ObjectiveTypes _type;

		private string _name;
		private string _category;
		private string _baseClass;

		public List<string> AdoptedProtocols { get; set; }

		public void AddAdoptedProtocol( string protocol )
		{
			AdoptedProtocols = AdoptedProtocols ?? new List<string>();
			AdoptedProtocols.Add( protocol );
		}

		private List<Statement> _instanceVariableStatements;
		public void AddIinstanceVariableStatement( Statement statement )
		{
			_instanceVariableStatements = _instanceVariableStatements ?? new List<Statement>();
			_instanceVariableStatements.Add( SetParent( statement ) );
		}

		private List<Statement> _body = new List<Statement>();
		public void AddStatement( Statement statement )
		{
			_body = _body ?? new List<Statement>();
			_body.Add( SetParent( statement ) );
		}
	}

	/// <summary>
	/// @property(readonly, retain) NSSomething *prop;
	/// @property NSUInteger (*hashFunction)(const void *nodeType, NSUInteger (*size)(const void *nodeType));
	/// </summary>
	public partial class ObjectivePropertyDeclarationStatement : Statement
	{
		/// <summary>
		/// @property(PropertyModifiers,PropertyModifiers,PropertyModifiers)
		/// </summary>
		[Flags]
		public enum PropertyModifiers
		{
			/// <summary>
			/// No modifiers was specified.
			/// </summary>
			None,

			/// <summary>
			/// By default properies are readwrite.
			/// </summary>
			ReadWrite = 1 << 0,

			/// <summary>
			/// Specifies that retain should be invoked on the object upon assignment and previous value recieve release message after assignment performed.
			/// </summary>
			Retain = 1 << 1,

			/// <summary>
			/// Indicates that the property is read-only. Only a getter method is required in the @implementation. If you use @synthesize in the implementation block, only the getter method is synthesized. 
			/// </summary>
			ReadOnly = 1 << 2,

			/// <summary>
			/// Specifies that a copy of the object should be used for assignment. The previous value is sent a release message. The copy is made by invoking the copy method.
			/// </summary>
			Copy = 1 << 3,

			/// <summary>
			/// Specifies that the setter uses simple assignment. This is the default.
			/// </summary>
			Assign = 1 << 4,

			/// <summary>
			/// Specifies that accessors are non-atomic. By default, accessors are atomic.
			/// </summary>
			NonAtomic = 1 << 5
		}

		/// <summary>
		/// Additional modifiers used in property declaration.
		/// </summary>
		private PropertyModifiers _modifiers;

		/// <summary>
		/// Name of getter method.
		/// </summary>
		private string _getterName;

		/// <summary>
		/// Name of setter method.
		/// </summary>
		private string _setterName;

		private DeclarationExpression _declarationExpression;
	}

	/// <summary>
	/// selector_part:(BOOL)deep
	/// </summary>
	public partial class ObjectiveParameterDeclaration : Node
	{
		private ObjectiveParameterModifier _modifer;

		private TypeReference _typeReference;

		/// <summary>
		/// Name that used to build selector name.
		/// </summary>
		private string _selectorPart;

		/// <summary>
		/// Name of parameter.
		/// </summary>
		private string _name { get; set; }

		public override string ToString()
		{
			return string.Format( "{0}:({1}){2}", _selectorPart, _typeReference, _name );
		}
	}

	public enum ObjectiveParameterModifier
	{
		None,

		In,
		Out,
		InOut,
		ByCopy,
		ByRef,
		Oneway
	}

	/// <summary>
	/// - (DOMNode *)cloneNode:(BOOL)deep;
	/// </summary>
	public partial class ObjectiveMethodDeclarationStatement : Statement
	{
		[Flags]
		public enum MethodModifiers
		{
			Invalid = 0,

			InstanceMethod = 1,
			ClassMethod = 2,
			Vararg = 4
		}

		private string _name;
		private MethodModifiers _modifiers;

		private TypeReference _returnType;
		private ObjectiveParameterModifier _returnValueModifier;

		private List<ObjectiveParameterDeclaration> _parameters = new List<ObjectiveParameterDeclaration>();
		public void AddParameter( ObjectiveParameterDeclaration parameter )
		{
			_parameters.Add( SetParent( parameter ) );
		}
	}

	/// <summary>
	/// static int xxx, *yyy, foo()
	/// struct in_place_struct_declaration *yyy
	/// struct in_place_struct_definition { } xxx, *yyy
	/// </summary>
	public partial class DeclarationExpression : Expression
	{
		public enum DeclarationModifiers
		{
			None,

			Auto = 1 << 0,
			Static = 1 << 1,
			Extern = 1 << 2,
			Register = 1 << 3,

			Inline = 1 << 4,
		}

		private DeclarationModifiers _modifiers;

		private TypeReference _typeReference;
		private List<DeclarationNode> _declarations = new List<DeclarationNode>();
		private TypeDeclarationExpression _typeDeclarationExpression;

		public void AddDeclarationNode( DeclarationNode declarationNode )
		{
			_declarations.Add( SetParent( declarationNode ) );
		}

		public override string ToString()
		{
			return string.Join( ", ", _declarations.Select( x => x.ToString() ).ToArray() );
		}
	}

	public partial class FunctionDefinitionStatement : Statement
	{
		[Flags]
		public enum FunctionModifiers
		{
			None = 0,
			Inline = 1 << 0,
			Static = 1 << 1,

			/// <summary>
			/// The __forceinline keyword overrides the cost/benefit analysis and relies on the judgment of the programmer instead. 
			/// </summary>
			ForceInline = 1 << 2,
		}

		private FunctionModifiers _modifiers;
		private DeclarationNode _declarationNode;

		public override string ToString()
		{
			return _declarationNode + " {...}";
		}
	}

	/// <summary>
	/// typedef int p1, *p2;
	/// typedef foo();
	/// </summary>
	public partial class TypedefStatement : Statement
	{
		private DeclarationExpression _declarationExpression;

		public override string ToString()
		{
			return string.Format( "typedef {0}", _declarationExpression );
		}
	}

	/// <summary>
	/// ( ... )
	/// </summary>
	public partial class ParenthesizedExpression : Expression
	{
		private Expression _expression;

		public ParenthesizedExpression()
		{
		}

		public ParenthesizedExpression( Expression expression )
		{
			_expression = SetParent( expression );
		}

		public override string ToString()
		{
			return string.Format( "({0})", _expression );
		}
	}

	/// <summary>
	/// sizeof( 10 )
	/// sizeof( int )
	/// </summary>
	public partial class SizeofExpression : Expression
	{
		/// <summary>
		/// It can be sizeof( type ) or sizeof( expression )
		/// </summary>
		private Node _node;

		public override string ToString()
		{
			return string.Format( "sizeof({0})", _node );
		}
	}

	public partial class TypeidExpression : Expression
	{
		/// <summary>
		/// It can be typeid( type ) or typeid( expression )
		/// </summary>
		private Node _node;

		public override string ToString()
		{
			return string.Format( "sizeof({0})", _node );
		}
	}

	public partial class MemberReferenceExpression : Expression
	{
		public enum MemberAccessStyle
		{
			Invalid,

			/// <summary>
			/// pointer->member
			/// </summary>
			Pointer,

			/// <summary>
			/// reference.member
			/// </summary>
			Reference,

			/// <summary>
			/// pointer->*pointer_to_member
			/// </summary>
			PointerToMemberFromPointer,

			/// <summary>
			/// reference.*PointerToMemberFromPointer
			/// </summary>
			PointerToMemberFromReference,
		}

		private Node _node;
		private MemberAccessStyle _memberAccess;

		private string _name;
	}

	/// <summary>
	/// this
	/// </summary>
	public partial class ThisReferenceExpression : Expression
	{
	}

	public partial class NewExpression : Expression
	{
		private List<Expression> _operatorParameters;

		private Expression _typeExpression;
	}

	/// <summary>
	/// x ? y : z
	/// </summary>
	public partial class ConditionalExpression : Expression
	{
		private Expression _conditionExpression;
		private Expression _trueExpression;
		private Expression _falseExpression;

		public ConditionalExpression()
		{
		}

		public ConditionalExpression( Expression testExpression, Expression trueExpression, Expression falseExpression )
		{
			_conditionExpression = SetParent( testExpression );
			_trueExpression = SetParent( trueExpression );
			_falseExpression = SetParent( falseExpression );
		}

		public override string ToString()
		{
			return _conditionExpression + " ? " + _trueExpression + " : " + _falseExpression;
		}
	}

	/// <summary>
	/// x ...= y
	/// </summary>
	public partial class AssignmentExpression : Expression
	{
		/// <summary>
		/// All available C++ assignment operators according by it's precedence.
		/// ms-help://MS.VSCC.v90/MS.MSDNQTR.v90.en/dv_vclang/html/95c1f0ba-dad8-4034-b039-f79a904f112f.htm
		/// </summary>
		[XmlType( "AssignmentOperator" )]
		public enum Operators
		{
			Invalid,

			/// <summary>
			/// x = y
			/// </summary>
			Assign,

			/// <summary>
			/// x *= y
			/// </summary>
			Multiply,

			/// <summary>
			/// x /= y
			/// </summary>
			Divide,

			/// <summary>
			/// x %= y
			/// </summary>
			Modulus,

			/// <summary>
			/// x += y
			/// </summary>
			Add,

			/// <summary>
			/// x -= y
			/// </summary>
			Subtract,

			/// <summary>
			/// x &lt;&lt;= y
			/// </summary>
			ShiftLeft,

			/// <summary>
			/// x &gt;&gt;= y
			/// </summary>
			ShiftRight,

			/// <summary>
			/// x &amp;= y
			/// </summary>
			BitwiseAnd,

			/// <summary>
			/// x |= y
			/// </summary>
			BitwiseOr,

			/// <summary>
			/// x ^= y
			/// </summary>
			Xor
		}

		/// <summary>
		/// Left operand.
		/// </summary>
		private Expression _left;

		/// <summary>
		/// Kind of assignment.
		/// </summary>
		private Operators _operator;

		/// <summary>
		/// Right operand.
		/// </summary>
		private Expression _right;

		public AssignmentExpression() { }

		public AssignmentExpression( Expression left, Operators @operator, Expression right )
		{
			_left = SetParent( left );
			_right = SetParent( right );
			_operator = @operator;
		}

		public static string GetOperatorString( Operators @operator )
		{
			switch( @operator )
			{
				case Operators.Assign: return "=";
				case Operators.Multiply: return "*=";
				case Operators.Divide: return "/=";
				case Operators.Modulus: return "%=";
				case Operators.Add: return "+=";
				case Operators.Subtract: return "-=";
				case Operators.ShiftLeft: return "<<=";
				case Operators.ShiftRight: return ">>=";
				case Operators.BitwiseAnd: return "&=";
				case Operators.BitwiseOr: return "|=";
				case Operators.Xor: return "^=";
			}

			return "?=";
		}

		public override string ToString()
		{
			return _left + " " + GetOperatorString( _operator ) + " " + _right;
		}
	}

	/// <summary>
	/// x ... y
	/// </summary>
	public partial class BinaryOperatorExpression : Expression
	{
		/// <summary>
		/// All available C++ binary operators according by it's precedence.
		/// ms-help://MS.VSCC.v90/MS.MSDNQTR.v90.en/dv_vclang/html/95c1f0ba-dad8-4034-b039-f79a904f112f.htm
		/// </summary>
		[XmlType( "BinaryOperator" )]
		public enum Operators
		{
			Invalid,

			/// <summary>
			/// x * y
			/// </summary>
			Multiply,

			/// <summary>
			/// x / y
			/// </summary>
			Divide,

			/// <summary>
			/// x % y
			/// </summary>
			Modulus,

			/// <summary>
			/// x + y
			/// </summary>
			Add,

			/// <summary>
			/// x - y
			/// </summary>
			Subtract,

			/// <summary>
			/// x &lt;&lt; y
			/// </summary>
			ShiftLeft,

			/// <summary>
			/// x &gt;&gt; y
			/// </summary>
			ShiftRight,


			/// <summary>
			/// x &lt; y
			/// </summary>
			LessThan,

			/// <summary>
			/// x &gt; y
			/// </summary>
			GreaterThan,

			/// <summary>
			/// x &lt;= y
			/// </summary>
			LessThanOrEqual,

			/// <summary>
			/// x &gt;= y
			/// </summary>
			GreaterThanOrEqual,

			/// <summary>
			/// x == y
			/// </summary>
			Equality,

			/// <summary>
			/// x != y
			/// </summary>
			Inequality,

			/// <summary>
			/// x &amp; y
			/// </summary>
			BitwiseAnd,

			/// <summary>
			/// x ^ y
			/// </summary>
			ExclusiveOr,

			/// <summary>
			/// x | y
			/// </summary>
			BitwiseOr,

			/// <summary>
			/// x &amp;&amp; y
			/// </summary>
			LogicalAnd,

			/// <summary>
			/// x || y
			/// </summary>
			LogicalOr
		}

		/// <summary>
		/// Left operand.
		/// </summary>
		private Expression _left;

		/// <summary>
		/// Kind of binary relation.
		/// </summary>
		private Operators _operator;

		/// <summary>
		/// Right operand.
		/// </summary>
		private Expression _right;

		public BinaryOperatorExpression() { }

		public BinaryOperatorExpression( Expression left, Operators @operator, Expression right )
		{
			_left = SetParent( left );
			_right = SetParent( right );
			_operator = @operator;
		}

		public static string GetOperatorString( Operators @operator )
		{
			switch( @operator )
			{
				case Operators.Multiply: return "*";
				case Operators.Divide: return "/";
				case Operators.Modulus: return "%";
				case Operators.Add: return "+";
				case Operators.Subtract: return "-";
				case Operators.ShiftLeft: return "<<";
				case Operators.ShiftRight: return ">>";
				case Operators.LessThan: return "<";
				case Operators.GreaterThan: return ">";
				case Operators.LessThanOrEqual: return "<=";
				case Operators.GreaterThanOrEqual: return ">=";
				case Operators.Equality: return "==";
				case Operators.Inequality: return "!=";
				case Operators.BitwiseAnd: return "&";
				case Operators.ExclusiveOr: return "^";
				case Operators.BitwiseOr: return "|";
				case Operators.LogicalAnd: return "&&";
				case Operators.LogicalOr: return "||";
			}

			return "???";
		}

		public override string ToString()
		{
			return _left + " " + GetOperatorString( _operator ) + " " + _right;
		}
	}

	/// <summary>
	/// !x
	/// &amp;function
	/// </summary>
	public partial class UnaryOperatorExpression : Expression
	{
		/// <summary>
		/// All available C++ unary operators according by it's precedence.
		/// ms-help://MS.VSCC.v90/MS.MSDNQTR.v90.en/dv_vclang/html/95c1f0ba-dad8-4034-b039-f79a904f112f.htm
		/// </summary>
		public enum Operators
		{
			Invalid,

			PostfixIncrement,
			PostfixDecrement,

			PrefixIncrement,
			PrefixDecrement,
			Complement,

			Not,
			Minus,
			Plus,

			AddressOf,
			Indirection
		}

		private Expression _expression;

		private Operators _operator;

		public static string GetOperatorString( Operators @operator )
		{
			switch( @operator )
			{
				case Operators.PostfixIncrement:
				case Operators.PrefixIncrement: return "++";

				case Operators.PostfixDecrement:
				case Operators.PrefixDecrement: return "--";

				case Operators.Complement: return "~";
				case Operators.Not: return "!";
				case Operators.Minus: return "-";
				case Operators.Plus: return "+";
				case Operators.AddressOf: return "&";
				case Operators.Indirection: return "*";
			}

			return "???";
		}

		public bool IsPostfix
		{
			get { return _operator == Operators.PostfixDecrement || _operator == Operators.PostfixIncrement; }
		}

		public bool IsPrefix
		{
			get { return !IsPostfix; }
		}

		public override string ToString()
		{
			if( IsPostfix )
				return string.Format( "{0}{1}", _expression, GetOperatorString( _operator ) );

			return string.Format( "{0}{1}", GetOperatorString( _operator ), _expression );
		}
	}

	public partial class ParameterDeclaration : Node
	{
		private List<DeclarationNode> _parameters = new List<DeclarationNode>();

		public void AddParameter( DeclarationNode declarationNode )
		{
			_parameters.Add( SetParent( declarationNode ) );
		}

		/// <summary>
		/// void foo( int x, ... )
		/// </summary>
		private bool _isVararg;

		public override string ToString()
		{
			return "( " + string.Join( ", ", _parameters.Select( x => x.ToString() ).ToArray() ) + " )";
		}
	}

	public partial class ConstructorDeclaration : Statement
	{
		[Flags]
		public enum ConstructorModifiers
		{
			None,

			Explicit = 1
		}

		private ConstructorModifiers _modifiers;
		private ParameterDeclaration _parameterDeclaration;

		private List<Statement> _body;

		public bool IsDefinition { get { return _body != null; } }
		public bool IsDeclaration { get { return _body == null; } }

		public override string ToString()
		{
			return "ctor" + _parameterDeclaration;
		}
	}

	public partial class DestructorDeclaration : Statement
	{
		private bool _isVirtual;

		private List<Statement> _body;

		public bool IsDefinition { get { return _body != null; } }
		public bool IsDeclaration { get { return _body == null; } }

		public override string ToString()
		{
			return "~ctor()";
		}
	}


	/// <summary>
	/// foo( ( left, right ), x )
	/// </summary>
	public partial class CommaExpression : Expression
	{
		/// <summary>
		/// Left operand.
		/// </summary>
		private Expression _left;

		/// <summary>
		/// Right operand.
		/// </summary>
		private Expression _right;

		public override string ToString()
		{
			return _left + ", " + _right;
		}
	}

	/// <summary>
	/// ( TypeReference ) Expression
	/// static_cast&lt;TypeReference&gt;( Expression )
	/// dynamic_cast&lt;TypeReference&gt;( Expression )
	/// const_cast&lt;TypeReference&gt;( Expression )
	/// </summary>
	public partial class CastExpression : Expression
	{
		/// <summary>
		/// Cast types according it's precedence
		/// ms-help://MS.VSCC.v90/MS.MSDNQTR.v90.en/dv_vclang/html/95c1f0ba-dad8-4034-b039-f79a904f112f.htm
		/// </summary>
		public enum CastTypes
		{
			Invalid,

			/// <summary>
			/// const_cast&lt;TypeReference&gt;( Expression )
			/// </summary>
			Const,

			/// <summary>
			/// dynamic_cast&lt;TypeReference&gt;( Expression )
			/// </summary>
			Dynamic,

			/// <summary>
			/// reinterpret_cast&lt;TypeReference&gt;( Expression )
			/// </summary>
			Reinterpret,

			/// <summary>
			/// static_cast&lt;TypeReference&gt;( Expression )
			/// </summary>
			Static,

			/// <summary>
			/// ( TypeReference ) x
			/// </summary>
			C,

			/// <summary>
			/// int( x )
			/// </summary>
			Explicit
		}

		private CastTypes _castType;

		private TypeReference _typeReference;
		private Expression _expression;
	}

	/// <summary>
	/// goto somewhere_defined_label;
	/// </summary>
	public partial class GotoStatement : Statement
	{
		private string _label;
	}

	/// <summary>
	///		...
	/// somewhere_defined_label:
	///		...
	/// </summary>
	public partial class LabeledStatement : Statement
	{
		private string _name;
	}

	/// <summary>
	/// ;
	/// </summary>
	public partial class NullStatement : Statement
	{
	}

	public partial class InvocationExpression : Expression
	{
		private Expression _expression;
		private List<Expression> _arguments = new List<Expression>();

		public void AddArgument( Expression argument )
		{
			_arguments.Add( SetParent( argument ) );
		}
	}

	/// <summary>
	/// if( ... ) {
	/// }
	/// 
	/// if(...)
	///		...
	///	else
	///		...
	/// </summary>
	public partial class IfStatement : Statement
	{
		private Expression _conditionExpression;
		private Statement _elseStatement;
	}

	/// <summary>
	/// while( ... ) {
	///		...
	/// }
	/// </summary>
	public partial class WhileStatement : Statement
	{
		private Expression _conditionExpression;

		public override string ToString()
		{
			return string.Format( "while( {0} ) {{...}}", _conditionExpression );
		}
	}

	/// <summary>
	/// do {
	///		...
	///	} while( ... );
	/// </summary>
	public partial class DoWhileStatement : Statement
	{
		private Expression _conditionExpression;

		public override string ToString()
		{
			return string.Format( "do {{...}} while( {0} );", _conditionExpression );
		}
	}

	/// <summary>
	/// throw x;
	/// </summary>
	public partial class ThrowStatement : Statement
	{
		private Expression _expression;

		public override string ToString()
		{
			return string.Format( "throw {0};", _expression );
		}
	}

	/// <summary>
	/// return x;
	/// </summary>
	public partial class ReturnStatement : Statement
	{
		private Expression _expression;

		public override string ToString()
		{
			return string.Format( "return {0};", _expression );
		}
	}

	/// <summary>
	/// try {
	///		...
	/// }
	/// catch( int x ) {
	///		...
	/// }
	/// </summary>
	public partial class TryCatchStatement : Statement
	{
		private List<CatchBlock> _catchBlocks = new List<CatchBlock>();
		private List<Statement> _body;

		public override string ToString()
		{
			return string.Format( "try {{ ... }} {0}", string.Join( " ", _catchBlocks.Select( x => x.ToString() ).ToArray() ) );
		}
	}

	public partial class CatchBlock : Node
	{
		private DeclarationNode _exceptionParameter;
		private List<Statement> _body;

		public void AddStatement( Statement statement )
		{
			_body = _body ?? new List<Statement>();
			_body.Add( SetParent( statement ) );
		}

		public override string ToString()
		{
			return string.Format( "catch( {0} ) {{ ... }}", _exceptionParameter );
		}
	}

	/// <summary>
	/// break;
	/// </summary>
	public partial class BreakStatement : Statement
	{
	}

	/// <summary>
	/// continue;
	/// </summary>
	public partial class ContinueStatement : Statement
	{
	}

	/// <summary>
	/// switch(...) {
	///		case ...:
	///			...
	///		break;
	///	}
	/// </summary>
	public partial class SwitchStatement : Statement
	{
		private Expression _expression;

		public override string ToString()
		{
			return string.Format( "switch( {0} ) {{ ... }}", _expression );
		}
	}

	public partial class CaseLabel : Node
	{
		private Expression _expression;

		public override string ToString()
		{
			return string.Format( "case {0}:", _expression );
		}
	}

	/// <summary>
	/// for( InitializerExpression; ConditionExpression; LoopExpression ) {
	///		...
	/// }
	/// </summary>
	public partial class ForStatement : Statement
	{
		private Expression _initializationExpression;
		private Expression _conditionExpression;
		private Expression _loopExpression;

	}

	/// <summary>
	/// public:
	///		...
	///	protected:
	///		...
	///	private:
	///		...
	/// </summary>
	public partial class MemberAccessSpecifier : Statement
	{
		private MemberAccessKind _accessKind;
	}

	public enum MemberAccessKind
	{
		Invalid,

		Public,
		Protected,
		Private
	}

	/// <summary>
	/// @public
	///		...
	///	@protected
	///		...
	///	@private
	///		...
	/// </summary>
	public partial class ObjectiveTypeModifierStatement : Statement
	{
		public enum Modifiers
		{
			Invalid,

			Public,
			Protected,
			Private,

			Optional,
			Required
		}

		private Modifiers _modifier;
	}

	public partial class TemplateParameterDeclaration : Node
	{
		private string _name;
		private TemplateParameterType _parameterType;

		/// <summary>
		/// template&lt;class T = std::vector&gt;
		/// template&lt;int T = 0&gt;
		/// </summary>
		private Node _initializer;
		private TypeReference _typeReference;
		private TemplateParametersDeclaration _templateParametersDeclaration;
	}

	/// <summary>
	/// template&lt; ... &gt;
	/// </summary>
	public partial class TemplateParametersDeclaration : Node
	{
		private List<TemplateParameterDeclaration> _parameters = new List<TemplateParameterDeclaration>();
	}

	public enum TemplateParameterType
	{
		Invalid,

		/// <summary>
		/// template&lt;int T&gt;
		/// template&lt;char T&gt;
		/// </summary>
		Type,

		/// <summary>
		/// template&lt;class T&gt;
		/// </summary>
		Class,

		/// <summary>
		/// template&lt;typename T&gt;
		/// </summary>
		Typename,
	}

	/// <summary>
	/// class { ... }
	/// struct { ... }
	/// union { ... }
	/// enum { ... }
	/// </summary>
	public partial class TypeDeclarationExpression : Expression
	{
		[XmlType( "TypeDeclarationKind" )]
		public enum TypeKind
		{
			Invalid,

			Class,
			Struct,
			Union,

			/// <summary>
			/// Body contains only EnumElementDeclaration
			/// </summary>
			Enum
		}

		private TemplateParametersDeclaration _templateParametersDeclaration;

		private TypeKind _type;
		private QualifiedName _name;

		private bool _isForwardDeclaration;

		private List<Statement> _body = new List<Statement>();

		public void AddStatement( Statement node )
		{
			_body.Add( SetParent( node ) );
		}

		public override string ToString()
		{
			return string.Format( "{0} {1} {{ ... }}", _type.ToString().ToLower(), _name );
		}
	}

	/// <summary>
	/// name = value
	/// </summary>
	public partial class EnumElementDeclaration : Statement
	{
		private string _name;

		private Expression _initializerExpression;
	}

	public partial class QualifiedIdentifierExpression : Expression
	{
		private QualifiedName _qualifiedName;
	}

	/// <summary>
	/// ...;
	/// </summary>
	public partial class ExpressionStatement : Statement
	{
		private Expression _expression;

		public ExpressionStatement() { }

		public ExpressionStatement( Expression expression )
		{
			_expression = SetParent( expression );
		}
	}

	/// <summary>
	/// namespace Name {
	///		...
	/// }
	/// </summary>
	public partial class NamespaceDeclaration : Statement
	{
		private string _name;

		public bool IsAnonymous { get { return _name == null; } }

		private List<Statement> _body;
		public void AddStatement( Statement node )
		{
			_body = _body ?? new List<Statement>();

			_body.Add( SetParent( node ) );
		}

		public override string ToString()
		{
			return string.Format( "namespace {0} {{ ... }}", _name );
		}
	}

	/// <summary>
	/// using some_namespace::some_type;
	/// </summary>
	public partial class UsingDeclarationStatement : Statement
	{
		private TypeReference _typeReference;
	}

	/// <summary>
	/// using namespace namespace_name;
	/// </summary>
	public partial class UsingDirectiveStatement : Statement
	{
		public List<string> Namespace { get; set; }

		public UsingDirectiveStatement()
		{
			Namespace = new List<string>();
		}
	}

	/// <summary>
	/// 1
	/// 2L
	/// 3ULL
	/// 0x65
	/// 010
	/// 'A'
	/// 'BB'
	/// 'CCCC'
	/// </summary>
	public partial class PrimitiveExpression : Expression
	{
		public struct LiteralValue
		{
			[XmlAttribute]
			public LiteralValueFormat Type;

			public object Value;

			public LiteralValue( LiteralValueFormat type, object value )
			{
				Type = type;
				Value = value;
			}

			public LiteralValue( Lexer.LiteralValue literalValue )
			{
				Type = ( LiteralValueFormat ) literalValue.Type;
				Value = literalValue.Value;
			}

			public override string ToString()
			{
				if( ( Type & LiteralValueFormat.Decimal ) != 0 )
				{
					var prefix = "";
					var value = "";
					var suffix = "";

					if( ( Type & LiteralValueFormat.Hexadecimal ) != 0 )
					{
						prefix = "0x";
						value = Convert.ToString( ( long ) Value, 16 );
					}
					else if( ( Type & LiteralValueFormat.Octal ) != 0 )
					{
						prefix = "0";
						value = Convert.ToString( ( long ) Value, 8 );
					}
					else if( ( Type & LiteralValueFormat.Character ) != 0 )
					{
						prefix = "'";

						var reminder = ( long ) Value;
						while( reminder > 0 )
						{
							value = ( char ) ( reminder & 0xFF ) + value;
							reminder >>= 8;
						}

						suffix = "'";
					}
					else
						value = Value.ToString();

					if( ( Type & LiteralValueFormat.UnsignedSuffix ) != 0 )
						suffix = "U";
					else if( ( Type & LiteralValueFormat.FloatSuffix ) != 0 )
						suffix = "f";

					if( ( Type & LiteralValueFormat.LongLongSuffix ) != 0 )
						suffix += "LL";
					else if( ( Type & LiteralValueFormat.LongSuffix ) != 0 )
						suffix += "L";

					return prefix + value + suffix;
				}
				else if( ( Type & LiteralValueFormat.AnsiString ) != 0 )
				{
					var value = ( string ) Value;

					value = value.Replace( "\a", "\\a" );
					value = value.Replace( "\b", "\\b" );
					value = value.Replace( "\f", "\\f" );
					value = value.Replace( "\n", "\\n" );
					value = value.Replace( "\r", "\\r" );
					value = value.Replace( "\t", "\\t" );
					value = value.Replace( "\v", "\\v" );

					if( ( Type & LiteralValueFormat.UnicodeString ) != 0 )
						return string.Format( @"L""{0}""", value );
					else if( ( Type & LiteralValueFormat.ObjectiveCString ) != 0 )
						return string.Format( @"@""{0}""", value );

					return string.Format( @"""{0}""", value );
				}
				else if( ( Type & LiteralValueFormat.Boolean ) != 0 )
					return ( bool ) Value ? "true" : "false";

				return Value.ToString();
			}
		}

		[Flags]
		public enum LiteralValueFormat
		{
			Invalid = 0,

			/// <summary>
			/// 06457
			/// </summary>
			Octal = 1 << 0,

			/// <summary>
			/// 1655
			/// </summary>
			Decimal = 1 << 1,

			/// <summary>
			/// 0xDEADBEEF
			/// </summary>
			Hexadecimal = 1 << 2,

			/// <summary>
			/// 'beef'
			/// </summary>
			Character = 1 << 3,

			/// <summary>
			/// "text"
			/// </summary>
			AnsiString = 1 << 4,

			/// <summary>
			/// L"unicode text"
			/// </summary>
			UnicodeString = 1 << 5,

			/// <summary>
			/// @"NSString"
			/// </summary>
			ObjectiveCString = 1 << 6,

			/// <summary>
			/// 10.0f
			/// </summary>
			FloatSuffix = 1 << 7,

			/// <summary>
			/// 5433L
			/// </summary>
			LongSuffix = 1 << 8,

			/// <summary>
			/// 5433LL
			/// </summary>
			LongLongSuffix = 1 << 9,

			/// <summary>
			/// 5433U
			/// </summary>
			UnsignedSuffix = 1 << 10,

			/// <summary>
			/// true
			/// false
			/// </summary>
			Boolean = 1 << 11
		}

		private LiteralValue _value;

		public PrimitiveExpression()
		{
		}

		public PrimitiveExpression( bool value )
		{
			_value = new LiteralValue( LiteralValueFormat.Boolean, value );
		}

		public PrimitiveExpression( LiteralValueFormat type, object value )
		{
			_value = new LiteralValue( type, value );
		}
	}

	public enum TypeKind
	{
		/// <summary>
		/// Can be generic or arbitrary type
		/// </summary>
		Normal,

		/// <summary>
		/// Use ElementType to determine type of bitset
		/// Use Size to determine bitset size
		/// </summary>
		Bitset,

		/// <summary>
		/// Use ElementType to retrieve array element type
		/// Use Size to determine array size
		/// </summary>
		Array,

		/// <summary>
		/// Use ElementType to retrieve type of pointed object
		/// </summary>
		Pointer,

		/// <summary>
		/// Use ElementType to retrieve type of referenced object
		/// </summary>
		Reference,

		/// <summary>
		/// Use ReturnType to determine type of returning value
		/// Use ParameterDeclaration to determine parameterDeclaration
		/// </summary>
		Function,

		/// <summary>
		/// Use ElementType to retrieve type of referenced object
		/// </summary>
		RValueReference,

		/// <summary>
		/// TypeDeclarationExpression is defined in Parent or somewhere else..
		/// </summary>
		EmbeddedDeclaration,

		/// <summary>
		/// something operator op( something const&amp; value1, something const&amp; value2 );
		/// </summary>
		RedefinableOperator,
	}

	/// <summary>
	/// List of redefinable operators.
	/// </summary>
	public enum RedefinableOperators
	{
		Invalid,

		/// <summary>
		/// x, y
		/// </summary>
		Comma,

		/// <summary>
		/// !x
		/// </summary>
		Not,

		/// <summary>
		/// x != y
		/// </summary>
		Inequality,

		/// <summary>
		/// x % y
		/// </summary>
		Modulus,

		/// <summary>
		/// x %= y
		/// </summary>
		ModulusAssign,

		/// <summary>
		/// x &amp; y
		/// </summary>
		BitwiseAnd,

		/// <summary>
		/// &amp;x
		/// </summary>
		AddressOf,

		/// <summary>
		/// x &amp;&amp; y
		/// </summary>
		LogicalAnd,

		/// <summary>
		/// x &amp;= y
		/// </summary>
		BitwiseAndAssign,

		/// <summary>
		/// x( y )
		/// </summary>
		FunctionCall,

		/// <summary>
		/// ( y ) x
		/// </summary>
		Cast,

		/// <summary>
		/// x * y
		/// </summary>
		Multiply,

		/// <summary>
		/// *x
		/// </summary>
		Indirection,

		/// <summary>
		/// x *= y
		/// </summary>
		MultiplyAssign,

		/// <summary>
		/// x + y
		/// </summary>
		Add,

		/// <summary>
		/// +x
		/// </summary>
		Plus,

		/// <summary>
		/// x++
		/// </summary>
		Increment,

		/// <summary>
		/// x += y
		/// </summary>
		AddAssign,

		/// <summary>
		/// x - y
		/// </summary>
		Subtract,

		/// <summary>
		/// -x
		/// </summary>
		Minus,

		/// <summary>
		/// x--
		/// </summary>
		Decrement,

		/// <summary>
		/// x -= y
		/// </summary>
		SubtractAssign,

		/// <summary>
		/// x-&gt;y
		/// </summary>
		MemberSelection,

		/// <summary>
		/// x-&gt;*y
		/// </summary>
		PointerToMemberSelection,

		/// <summary>
		/// x / y
		/// </summary>
		Div,

		/// <summary>
		/// x /= y
		/// </summary>
		DivideAssign,

		/// <summary>
		/// x &lt; y
		/// </summary>
		LessThan,

		/// <summary>
		/// x &lt;&lt; y
		/// </summary>
		ShiftLeft,

		/// <summary>
		/// x &lt;&lt;= y
		/// </summary>
		ShiftLeftAssign,

		/// <summary>
		/// x &lt;= y
		/// </summary>
		LessEqual,

		/// <summary>
		/// x = y
		/// </summary>
		Assign,

		/// <summary>
		/// x == y
		/// </summary>
		Equality,

		/// <summary>
		/// x &gt; y
		/// </summary>
		GreaterThan,

		/// <summary>
		/// x &gt;= y
		/// </summary>
		GreaterEqual,

		/// <summary>
		/// x &gt;&gt; y
		/// </summary>
		RightShift,

		/// <summary>
		/// x &gt;&gt;= y
		/// </summary>
		RightShiftAssign,

		/// <summary>
		/// x[y]
		/// </summary>
		ArraySubscript,

		/// <summary>
		/// x ^ y
		/// </summary>
		Xor,

		/// <summary>
		/// x ^= y
		/// </summary>
		XorAssign,

		/// <summary>
		/// x ^= y
		/// </summary>
		BitwiseOr,

		/// <summary>
		/// x |= y
		/// </summary>
		BitwiseOrAssign,

		/// <summary>
		/// x || y
		/// </summary>
		LogicalOr,

		/// <summary>
		/// ~x
		/// </summary>
		BitwiseComplement,

		/// <summary>
		/// operator delete
		/// </summary>
		Delete,

		/// <summary>
		/// operator new
		/// </summary>
		New
	}

	[Flags]
	public enum TypeModifiers
	{
		None,
		Const = 1,
		Restrict = 2,
		Volatile = 4,
	}

	public partial class TypeReference : Node, ICloneable
	{
		private string _typeName;

		/// <summary>
		/// std::vector&lt;GenericArgument&gt;
		/// Also it used for protocol specification: id&lt;NSTextAttachmentCell&gt;
		/// </summary>
		private List<Node> _genericArguments;

		public void AddGenericArgument( Node expression )
		{
			_genericArguments = _genericArguments ?? new List<Node>();
			_genericArguments.Add( SetParent( expression ) );
		}

		private TypeKind _typeKind;
		private TypeReference _elementType;
		private Expression _size;

		/// <summary>
		/// memberof::memberof::type
		/// </summary>
		private QualifiedName _memberOf;

		private RedefinableOperators _operator;

		private TypeReference _returnType;
		private ParameterDeclaration _parameterDeclaration;

		private TypeModifiers _modifiers;

		/// <summary>
		/// Is type generic?
		/// </summary>
		public bool IsGeneric { get { return _genericArguments != null; } }

		public TypeReference()
		{
		}

		public TypeReference( string name )
		{
			_typeName = name;
		}

		public override string ToString()
		{
			//return TypeName +" "+ TypeKind;
			//if( new StackTrace().FrameCount > 100 )
			//	return "@you have dependency loop@";

			if( _typeKind == TypeKind.Array )
				return string.Format( "{0}[{1}]", _elementType, _size == null ? "" : _size.ToString() );

			if( _typeKind == TypeKind.Pointer )
				return string.Format( "{0}*", _elementType );

			if( _typeKind == TypeKind.Reference )
				return string.Format( "{0}&", _elementType );

			if( _typeKind == TypeKind.Function )
				return string.Format( "{0}{1}", _returnType, _parameterDeclaration );

			if( IsGeneric )
				return string.Format( "{0}<{1}>", _typeName, string.Join( ", ", _genericArguments.Select( x => x.ToString() ).ToArray() ) );

			if( _typeKind == TypeKind.Bitset )
				return string.Format( "{0} : {1}", _elementType, _size );

			var result = _typeName;

			return result;
		}

		object ICloneable.Clone()
		{
			return Clone();
		}

		public TypeReference Clone()
		{
			var result = MemberwiseClone() as TypeReference;

			//if( GenericArguments != null )
			//	result.GenericArguments = GenericArguments.Select( x => x.Clone() ).ToList();

			if( _elementType != null )
				result._elementType = _elementType.Clone();

			if( _returnType != null )
				result._returnType = _returnType.Clone();

			return result;
		}
	}
}
