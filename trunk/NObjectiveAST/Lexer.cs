//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace NObjectiveAST
{
	/// <summary>
	/// Lexer uses preprocessed output from GCC
	/// </summary>
	public unsafe partial class Lexer
	{
		/// <summary>
		/// Represents single token.
		/// </summary>
		public struct Token
		{
			/// <summary>
			/// Type of token
			/// </summary>
			public Tokens Type;

			/// <summary>
			/// Value of Identifier or Literal token
			/// </summary>
			public object Value;

			public override string ToString()
			{
				switch( Type )
				{
					case Tokens.Literal:
					case Tokens.Identifier:
						return string.Format( "{0}: <{1}>", Type, Value );
				}

				return Type.ToString();
			}

			public LiteralValue LiteralValue
			{
				get { return ( LiteralValue ) Value; }
				set { Value = value; }
			}

			public int Row;
			public int Column;
		}

		/// <summary>
		/// Represents value of literal token
		/// </summary>
		public struct LiteralValue
		{
			public LiteralValueFormat Type;

			public object Value;

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

				return Value.ToString();
			}
		}

		/// <summary>
		/// Type of literal value and its modifiers
		/// </summary>
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
			UnsignedSuffix = 1 << 10
		}

		/// <summary>
		/// .NET's string pool not applicable due to its persistance
		/// </summary>
		private unsafe struct IdentifierPoolEntry : IEquatable<IdentifierPoolEntry>, IComparable<IdentifierPoolEntry>
		{
			public char* Text;
			public int Length;
			public int Hash;

#pragma warning disable 649
			public int Padding;
#pragma warning restore 649

			public override int GetHashCode()
			{
				return Hash;
			}

			#region IEquatable<IdentifierPoolEntry> Members

			public bool Equals( IdentifierPoolEntry other )
			{
				if( Length != other.Length || Hash != other.Hash )
					return false;

				var ptr1 = Text;
				var ptr2 = other.Text;
				var counter = Length;

				while( counter-- > 0 )
				{
					if( *ptr1++ != *ptr2++ )
						return false;
				}

				return true;
			}

			#endregion

			#region IComparable<IdentifierPoolEntry> Members

			public int CompareTo( IdentifierPoolEntry other )
			{
				if( Length < other.Length )
					return -1;

				if( Length > other.Length )
					return 1;

				if( Hash < other.Hash )
					return -1;

				if( Hash > other.Hash )
					return 1;

				var text = Text;
				var otherText = other.Text;

				var counter = Length;
				while( counter-- > 0 )
				{
					if( *text < *otherText )
						return -1;

					if( *text++ > *otherText++ )
						return 1;
				}

				return 0;
			}

			#endregion
		}

		/// <summary>
		/// Tokens produced by lexer
		/// </summary>
		public Token[] Output { get; set; }

		private char[] _text;
		private char* _textPointer;

		private Token[] _tokens;

		private int _readIndex = 0;
		private int _writeIndex = 0;

		private Dictionary<IdentifierPoolEntry, string> _identifierPool;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		public Lexer( string text )
		{
			if( text == null )
				throw new ArgumentNullException( "text" );

			Tokenize( text.ToCharArray() );
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="text"></param>
		public Lexer( char[] text )
		{
			if( text == null )
				throw new ArgumentNullException( "text" );

			Tokenize( text );
		}

		private unsafe void Tokenize( char[] text )
		{
			_text = text;
			_tokens = new Token[text.Length];
			_identifierPool = new Dictionary<IdentifierPoolEntry, string>( text.Length / 77 );

			fixed( char* textPointer = text )
			{
				_textPointer = textPointer;

				while( !IsEOF )
				{
					switch( ( byte ) CurrentCharacter )
					{
						case ( byte ) ' ':
						case ( byte ) '\t':
							_readIndex++;
							continue;

						case ( byte ) '#':
							// skip preprocessor directives
							SkipCurrentAndNewLines();
							continue;

						case ( byte ) '\r':
						case ( byte ) '\n':
							SkipCurrentAndNewLines();
							continue;

						case ( byte ) '"':
							_tokens[_writeIndex].Type = Tokens.Literal;
							_tokens[_writeIndex].LiteralValue = new LiteralValue { Type = LiteralValueFormat.AnsiString, Value = ReadQuotedString() };
							_tokens[_writeIndex].Row = CurrentRow;
							_tokens[_writeIndex].Column = CurrentColumn;
							_writeIndex++;

							continue;

						case ( byte ) '\'':
							ReadChar();
							continue;

						case ( byte ) 'L':
							if( NextCharacter == '"' )
							{
								_readIndex++;

								_tokens[_writeIndex].Type = Tokens.Literal;
								_tokens[_writeIndex].LiteralValue = new LiteralValue { Type = LiteralValueFormat.AnsiString | LiteralValueFormat.UnicodeString, Value = ReadQuotedString() };
								_tokens[_writeIndex].Row = CurrentRow;
								_tokens[_writeIndex].Column = CurrentColumn;
								_writeIndex++;
							}
							else
								TokenizeWord();
							continue;

						case ( byte ) '@':
							if( IsNextEOF )
								ThrowException( "Unexpected end of file" );

							if( NextCharacter == '"' )
							{
								_readIndex++;

								_tokens[_writeIndex].Type = Tokens.Literal;
								_tokens[_writeIndex].LiteralValue = new LiteralValue { Type = LiteralValueFormat.AnsiString | LiteralValueFormat.ObjectiveCString, Value = ReadQuotedString() };
								_tokens[_writeIndex].Row = CurrentRow;
								_tokens[_writeIndex].Column = CurrentColumn;
								_writeIndex++;
							}
							else
							{
								_readIndex++;

								// in objective-c you can write: "@  class" insted of "@class"
								while( _text[_readIndex] == ' ' || _text[_readIndex] == '\t' || _text[_readIndex] == '\r' || _text[_readIndex] == '\n' )
									_readIndex++;

								TokenizeObjectiveWord();
							}
							continue;

						case ( byte ) '0':
						case ( byte ) '1':
						case ( byte ) '2':
						case ( byte ) '3':
						case ( byte ) '4':
						case ( byte ) '5':
						case ( byte ) '6':
						case ( byte ) '7':
						case ( byte ) '8':
						case ( byte ) '9':
							TokenizeNumberLiteral();
							break;

						case ( byte ) '_':
						case ( byte ) '$':
						case ( byte ) 'a':
						case ( byte ) 'b':
						case ( byte ) 'c':
						case ( byte ) 'd':
						case ( byte ) 'e':
						case ( byte ) 'f':
						case ( byte ) 'g':
						case ( byte ) 'h':
						case ( byte ) 'i':
						case ( byte ) 'j':
						case ( byte ) 'k':
						case ( byte ) 'l':
						case ( byte ) 'm':
						case ( byte ) 'n':
						case ( byte ) 'o':
						case ( byte ) 'p':
						case ( byte ) 'q':
						case ( byte ) 'r':
						case ( byte ) 's':
						case ( byte ) 't':
						case ( byte ) 'u':
						case ( byte ) 'v':
						case ( byte ) 'w':
						case ( byte ) 'x':
						case ( byte ) 'y':
						case ( byte ) 'z':
						case ( byte ) 'A':
						case ( byte ) 'B':
						case ( byte ) 'C':
						case ( byte ) 'D':
						case ( byte ) 'E':
						case ( byte ) 'F':
						case ( byte ) 'G':
						case ( byte ) 'H':
						case ( byte ) 'I':
						case ( byte ) 'J':
						case ( byte ) 'K':
						//case ( byte ) 'L':
						case ( byte ) 'M':
						case ( byte ) 'N':
						case ( byte ) 'O':
						case ( byte ) 'P':
						case ( byte ) 'Q':
						case ( byte ) 'R':
						case ( byte ) 'S':
						case ( byte ) 'T':
						case ( byte ) 'U':
						case ( byte ) 'V':
						case ( byte ) 'W':
						case ( byte ) 'X':
						case ( byte ) 'Y':
						case ( byte ) 'Z':
							TokenizeWord();
							continue;

						case ( byte ) '{':
							NewToken( Tokens.OpenCurlyBrace );
							_readIndex++;
							continue;

						case ( byte ) '}':
							NewToken( Tokens.CloseCurlyBrace );
							_readIndex++;
							continue;

						case ( byte ) '(':
							NewToken( Tokens.OpenParenthesis );
							_readIndex++;
							continue;

						case ( byte ) ')':
							NewToken( Tokens.CloseParenthesis );
							_readIndex++;
							continue;

						case ( byte ) '[':
							NewToken( Tokens.OpenSquareBracket );
							_readIndex++;
							continue;

						case ( byte ) ']':
							NewToken( Tokens.CloseSquareBracket );
							_readIndex++;
							continue;

						case ( byte ) ',':
							NewToken( Tokens.Comma );
							_readIndex++;
							continue;

						case ( byte ) '?':
							NewToken( Tokens.Question );
							_readIndex++;
							continue;

						case ( byte ) ';':
							NewToken( Tokens.Semicolon );
							_readIndex++;
							continue;

						case ( byte ) '!':
							if( NextCharacter == '=' )
							{
								NewToken( Tokens.Inequality );
								_readIndex += 2;
							}
							else
							{
								NewToken( Tokens.Not );
								_readIndex++;
							}
							continue;

						case ( byte ) '=':
							if( NextCharacter == '=' )
							{
								NewToken( Tokens.Equality );
								_readIndex += 2;
							}
							else
							{
								NewToken( Tokens.Assign );
								_readIndex++;
							}
							continue;

						case ( byte ) '.':
							if( NextCharacter == '.' )
							{
								if( NextNextCharacter == '.' )
								{
									NewToken( Tokens.Ellipsis );
									_readIndex += 3;
								}
								else
								{
									ThrowException( "Invalid token" );
								}
							}
							else if( NextCharacter == '*' )
							{
								NewToken( Tokens.PointerToMemberAccessFromReference );
								_readIndex += 2;
							}
							else
							{
								NewToken( Tokens.Dot );
								_readIndex++;
							}
							continue;

						case ( byte ) ':':
							if( NextCharacter == ':' )
							{
								NewToken( Tokens.ScopeResolution );
								_readIndex += 2;
							}
							else
							{
								NewToken( Tokens.Colon );
								_readIndex++;
							}
							continue;

						case ( byte ) '&':
							if( NextCharacter == '&' )
							{
								NewToken( Tokens.LogicalAnd );
								_readIndex += 2;
							}
							else if( NextCharacter == '=' )
							{
								NewToken( Tokens.BitwiseAndAssign );
								_readIndex += 2;
							}
							else
							{
								NewToken( Tokens.BitwiseAnd );
								_readIndex++;
							}
							continue;

						case ( byte ) '|':
							if( NextCharacter == '|' )
							{
								NewToken( Tokens.LogicalOr );
								_readIndex += 2;
							}
							else if( NextCharacter == '=' )
							{
								NewToken( Tokens.BitwiseOrAssign );
								_readIndex += 2;
							}
							else
							{
								NewToken( Tokens.BitwiseOr );
								_readIndex++;
							}
							continue;

						case ( byte ) '^':
							if( NextCharacter == '=' )
							{
								NewToken( Tokens.XorAssign );
								_readIndex += 2;
							}
							else
							{
								NewToken( Tokens.Xor );
								_readIndex++;
							}
							continue;

						case ( byte ) '/':
							if( NextCharacter == '/' )
								SkipCurrentAndNewLines();
							else if( NextCharacter == '=' )
							{
								NewToken( Tokens.DivideAssign );
								_readIndex += 2;
							}
							else
							{
								NewToken( Tokens.Div );
								_readIndex++;
							}
							continue;

						case ( byte ) '%':
							if( NextCharacter == '=' )
							{
								NewToken( Tokens.ModulusAssign );
								_readIndex += 2;
							}
							else
							{
								NewToken( Tokens.Mod );
								_readIndex++;
							}
							continue;

						case ( byte ) '~':
							NewToken( Tokens.BitwiseComplement );
							_readIndex++;
							continue;

						case ( byte ) '+':
							if( NextCharacter == '+' )
							{
								NewToken( Tokens.Increment );
								_readIndex += 2;
							}
							else if( NextCharacter == '=' )
							{
								NewToken( Tokens.AddAssign );
								_readIndex += 2;
							}
							else
							{
								NewToken( Tokens.Plus );
								_readIndex++;
							}
							continue;

						case ( byte ) '*':
							if( NextCharacter == '=' )
							{
								NewToken( Tokens.MultiplyAssign );
								_readIndex += 2;
							}
							else
							{
								NewToken( Tokens.Multiply );
								_readIndex++;
							}
							continue;

						case ( byte ) '-':
							if( NextCharacter == '-' )
							{
								NewToken( Tokens.Decrement );
								_readIndex += 2;
							}
							else if( NextCharacter == '=' )
							{
								NewToken( Tokens.SubtractAssign );
								_readIndex += 2;
							}
							else if( NextCharacter == '>' )
							{
								if( NextNextCharacter == '*' )
								{
									NewToken( Tokens.PointerToMemberAccessFromPointer );
									_readIndex += 3;
								}
								else
								{
									NewToken( Tokens.MemberSelection );
									_readIndex += 2;
								}
							}
							else
							{
								NewToken( Tokens.Minus );
								_readIndex++;
							}
							continue;

						case ( byte ) '>':
							if( NextCharacter == '=' )
							{
								NewToken( Tokens.GreaterThanOrEqual );
								_readIndex += 2;
							}
							else
							{
								NewToken( Tokens.GreaterThan );
								_readIndex++;
							}
							continue;

						case ( byte ) '<':
							if( NextCharacter == '=' )
							{
								NewToken( Tokens.LessThanOrEqual );
								_readIndex += 2;
							}
							else if( NextCharacter == '<' )
							{
								if( NextNextCharacter == '=' )
								{
									NewToken( Tokens.ShiftLeftAssign );
									_readIndex += 3;
								}
								else
								{
									NewToken( Tokens.ShiftLeft );
									_readIndex += 2;
								}
							}
							else
							{
								NewToken( Tokens.LessThan );
								_readIndex++;
							}
							continue;
					}
				}
			}

			for( int i = 0; i < _writeIndex; i++ )
			{
				if( _tokens[i].Type == Tokens._signed )
					_tokens[i].Type = Tokens._int;
				else if( _tokens[i].Type == Tokens._unsigned )
					_tokens[i].Type = Tokens._unsigned_int;
			}

			Output = _tokens;

			_identifierPool = null;
			_quotedStringBuilder = null;
		}

		private void TokenizeNumberLiteral()
		{
			bool isHex = false, isOctal = false;
			bool isDouble = false, isFloat = false, isFloating = false;

			if( CurrentCharacter == '0' )
			{
				if( NextCharacter == 'x' )
				{
					isHex = true;
					_readIndex += 2;
				}
				else if( char.IsDigit( NextCharacter ) )
				{
					isOctal = true;
					_readIndex++;
				}
			}

			long integerPart = 0;
			ulong decimalPart = 0;
			long exponentPart = 0;

			if( isHex )
			{
				for( var value = HexValue[( byte ) CurrentCharacter]; value != -1; _readIndex++, value = HexValue[( byte ) CurrentCharacter] )
				{
					integerPart <<= 4;
					integerPart += value;
				}
			}
			else if( isOctal )
			{
				while( char.IsDigit( CurrentCharacter ) )
				{
					integerPart <<= 3;
					integerPart += ( long ) ( CurrentCharacter - '0' );
					_readIndex++;
				}
			}
			else
			{
				while( char.IsDigit( CurrentCharacter ) )
				{
					integerPart *= 10;
					integerPart += ( long ) ( CurrentCharacter - '0' );
					_readIndex++;
				}

				if( CurrentCharacter == '.' )
				{
					_readIndex++;
					isFloating = true;

					while( char.IsDigit( CurrentCharacter ) )
					{
						decimalPart *= 10;
						decimalPart += ( ulong ) ( CurrentCharacter - '0' );
						_readIndex++;
					}
				}
			}

			// scientific notation
			if( CurrentCharacter == 'e' )
			{
				_readIndex++;

				bool negate = false;

				if( CurrentCharacter == '-' || CurrentCharacter == '+' )
				{
					negate = CurrentCharacter == '-';
					_readIndex++;
				}

				if( char.IsDigit( CurrentCharacter ) )
				{
					isDouble = true;

					while( char.IsDigit( CurrentCharacter ) )
					{
						exponentPart *= 10;
						exponentPart += ( long ) ( CurrentCharacter - '0' );
						_readIndex++;
					}
				}
				else
					ThrowException( "Invalid number format" );

				if( negate )
					exponentPart = -exponentPart;
			}

			// double
			if( CurrentCharacter == 'd' || CurrentCharacter == 'D' )
			{
				isDouble = true;
				_readIndex++;
			}
			// float
			else if( CurrentCharacter == 'f' || CurrentCharacter == 'F' )
			{
				isFloat = true;
				_readIndex++;
			}

			bool isUnsigned = false, isLong = false, isLongLong = false;

			// unsigned
			if( CurrentCharacter == 'u' || CurrentCharacter == 'U' )
			{
				isUnsigned = true;
				_readIndex++;
			}

			// long
			if( CurrentCharacter == 'l' || CurrentCharacter == 'L' )
			{
				isLong = true;
				_readIndex++;
			}

			// long long case
			if( CurrentCharacter == 'l' || CurrentCharacter == 'L' )
			{
				isLongLong = true;
				_readIndex++;
			}

			if( !isDouble && !isFloat && isFloating )
				isDouble = true;

			object literalValue;

			if( isDouble )
			{
				_quotedStringBuilder.Length = 0;
				_quotedStringBuilder.AppendFormat( "{0}.{1}e{2}", integerPart, decimalPart, exponentPart );
				literalValue = double.Parse( _quotedStringBuilder.ToString(), System.Globalization.CultureInfo.InvariantCulture );
			}
			else if( isFloat )
			{
				_quotedStringBuilder.Length = 0;
				_quotedStringBuilder.AppendFormat( "{0}.{1}e{2}", integerPart, decimalPart, exponentPart );
				literalValue = float.Parse( _quotedStringBuilder.ToString(), System.Globalization.CultureInfo.InvariantCulture );
			}
			else
				literalValue = integerPart;

			var literalType = LiteralValueFormat.Decimal;

			if( isHex )
				literalType |= LiteralValueFormat.Hexadecimal;
			else if( isOctal )
				literalType |= LiteralValueFormat.Octal;
			else if( isFloat )
				literalType |= LiteralValueFormat.FloatSuffix;

			if( isLongLong )
				literalType |= LiteralValueFormat.LongLongSuffix;
			else if( isLong )
				literalType |= LiteralValueFormat.LongSuffix;

			if( isUnsigned )
				literalType |= LiteralValueFormat.UnsignedSuffix;

			_tokens[_writeIndex].Type = Tokens.Literal;
			_tokens[_writeIndex].LiteralValue = new LiteralValue { Type = literalType, Value = literalValue };
			_tokens[_writeIndex].Row = CurrentRow;
			_tokens[_writeIndex].Column = CurrentColumn;
			_writeIndex++;
		}

		private void NewToken( Tokens type )
		{
			_tokens[_writeIndex].Type = type;
			_tokens[_writeIndex].Row = CurrentRow;
			_tokens[_writeIndex].Column = CurrentColumn;
			_writeIndex++;
		}

		private bool IsEOF { get { return _readIndex >= _text.Length; } }
		private bool IsNextEOF { get { return _readIndex + 1 >= _text.Length; } }
		private bool IsNextNextEOF { get { return _readIndex + 2 >= _text.Length; } }

		private char NextCharacter { get { return _text[_readIndex + 1]; } }
		private char CurrentCharacter { get { return _text[_readIndex]; } }
		private char NextNextCharacter { get { return _text[_readIndex + 2]; } }

#if DEBUG
		/// <summary>
		/// For debug purposes
		/// </summary>
		private string Follow { get { return new string( _text, _readIndex, 64 ); } }
#endif
		private StringBuilder _quotedStringBuilder = new StringBuilder();

		private string ReadQuotedString()
		{
			var newLinesCount = 0;
			var lineFeedsCount = 0;

			_quotedStringBuilder.Length = 0;

		start_scanning:
			_readIndex++;

			while( !IsEOF )
			{
				if( CurrentCharacter == '"' )
				{
					while( !IsEOF )
					{
						_readIndex++;

						// try to fuse next string
						if( CurrentCharacter == '"' )
							goto start_scanning;

						if( CurrentCharacter == ' ' || CurrentCharacter == '\t' )
							continue;

						if( CurrentCharacter == '\n' )
						{
							newLinesCount++;
							_columnStart = _readIndex - 1;
							continue;
						}

						if( CurrentCharacter == '\r' )
						{
							lineFeedsCount++;
							_columnStart = _readIndex - 1;
							continue;
						}

						break;
					}
					_currentRow += Math.Max( newLinesCount, lineFeedsCount );

					return _quotedStringBuilder.ToString();
				}

				if( CurrentCharacter == '\\' )
					_quotedStringBuilder.Append( GetEscapeSequence() );
				else if( CurrentCharacter == '\n' || CurrentCharacter == '\r' )
					ThrowException( "No new line is allowed inside a string literal" );
				else
				{
					_quotedStringBuilder.Append( CurrentCharacter );
					_readIndex++;
				}
			}

			ThrowException( "End of file reached inside string literal" );
			return null;
		}

		private string ReadIdentifier()
		{
			int startIndex = _readIndex;
			uint hash = 0xCE0CE0CE;

			for( ; ; )
			{
				hash = ( hash << 4 ) | ( hash >> 28 );
				hash ^= _text[_readIndex];

				_readIndex++;

				if( IsEOF || !IsIdentifierCharacter[( byte ) CurrentCharacter] )
					break;
			}

			string result = null;
			var key = new IdentifierPoolEntry
			{
				Text = _textPointer + startIndex,
				Length = _readIndex - startIndex,
				Hash = ( int ) hash
			};

			if( _identifierPool.TryGetValue( key, out result ) )
				return result;

			result = new string( _text, startIndex, _readIndex - startIndex );
			_identifierPool[key] = result;

			return result;
		}

		private void ReadChar()
		{
			long result = 0;
			_readIndex++;

			while( CurrentCharacter != '\'' )
			{
				result <<= 8;

				if( CurrentCharacter == '\\' )
					result += GetEscapeSequence();
				else if( CurrentCharacter == '\n' )
					ThrowException( "No new line is allowed inside a char literal" );
				else
					result += _text[_readIndex++];
			}

			_readIndex++;

			_tokens[_writeIndex].Type = Tokens.Literal;
			_tokens[_writeIndex].Value = new LiteralValue { Type = LiteralValueFormat.Decimal | LiteralValueFormat.Character, Value = result };
			_tokens[_writeIndex].Row = CurrentRow;
			_tokens[_writeIndex].Column = CurrentColumn;
			_writeIndex++;
		}

		private char GetEscapeSequence()
		{
			_readIndex++;

			if( IsEOF )
				ThrowException( "End of file reached inside escape sequence" );

			switch( _text[_readIndex++] )
			{
				case '\'':
					return '\'';
				case '\"':
					return '\"';
				case '\\':
					return '\\';
				case '0':
					return '\0';
				case 'a':
					return '\a';
				case 'b':
					return '\b';
				case 'f':
					return '\f';
				case 'n':
					return '\n';
				case 'r':
					return '\r';
				case 't':
					return '\t';
				case 'v':
					return '\v';

				case '?':
					return '?';

				default:
					ThrowException( "Unexpected escape sequence : {0}", CurrentCharacter );
					return ' ';
			}
		}

		private int _currentRow = 1;
		private int _columnStart = 0;

		private int CurrentRow { get { return _currentRow; } }
		private int CurrentColumn { get { return _readIndex - _columnStart; } }

		private void SkipCurrentAndNewLines()
		{
			int newLinesCount = 0, lineFeedsCount = 0;

			// skip current line
			while( !IsEOF && CurrentCharacter != '\r' && CurrentCharacter != '\n' )
				_readIndex++;

			//skip new lines
			while( !IsEOF && ( CurrentCharacter == '\r' || CurrentCharacter == '\n' ) )
			{
				if( CurrentCharacter == '\r' )
					lineFeedsCount++;
				else if( CurrentCharacter == '\n' )
					newLinesCount++;

				_readIndex++;
			}
			_columnStart = _readIndex - 1;

			_currentRow += Math.Max( newLinesCount, lineFeedsCount );
		}

		private void ThrowException( string format, params object[] parameters )
		{
			throw new LexerException( string.Format( format, parameters ), CurrentRow, CurrentColumn );
		}

		public void SaveTokens( string filename )
		{
			using( var writer = new StreamWriter( filename ) )
			{
				var tokens = Output.TakeWhile( x => x.Type != Tokens.EOF ).ToArray();

				for( int i = 0; i < tokens.Length; i++ )
					writer.WriteLine( tokens[i] );
			}
		}

		public void SaveText( string filename )
		{
			bool insideEnum = false;

			bool needSpace = false;
			int indent = 0;

			var tokens = Output.TakeWhile( x => x.Type != Tokens.EOF ).ToArray();

			using( var writer = new StreamWriter( filename ) )
				for( int i = 0; i < tokens.Length; i++ )
				{
					var token = tokens[i];

					if( token.Type == Tokens._enum )
						insideEnum = true;

					if( token.Type == Tokens.OpenCurlyBrace )
					{
						writer.WriteLine();
						writer.Write( new string( '\t', indent ) );
						writer.Write( GetTokenString( token.Type ) );
						writer.WriteLine();
						writer.Write( new string( '\t', ++indent ) );
						needSpace = false;
						continue;
					}

					if( token.Type == Tokens.CloseCurlyBrace )
					{
						insideEnum = false;

						--indent;
						if( tokens[i - 1].Type != Tokens.Semicolon )
						{
							writer.WriteLine();
							writer.Write( new string( '\t', indent ) );
						}

						writer.Write( GetTokenString( token.Type ) );

						if( i < tokens.Length - 2 && tokens[i + 1].Type != Tokens.Semicolon && tokens[i + 1].Type != Tokens.Identifier )
						{
							writer.WriteLine();
							writer.Write( new string( '\t', indent ) );
						}

						needSpace = false;
						continue;
					}

					//needSpace = true;

					if( token.Type == Tokens.at_interface || token.Type == Tokens.at_protocol )
					{
						writer.WriteLine();
						writer.Write( new string( '\t', indent ) );
						writer.Write( GetTokenString( token.Type ) );

						if( token.Type == Tokens.at_protocol )
						{
							if( tokens[i + 2].Type != Tokens.Semicolon )
								indent++;
						}
						else
							indent++;

						for( i++; i < tokens.Length; i++ )
						{
							token = tokens[i];

							if( token.Type == Tokens.OpenCurlyBrace || token.Type == Tokens.Semicolon || token.Type == Tokens.at_end )
							{
								needSpace = false;
								i--;
								break;
							}

							if( token.Type == Tokens.Minus || token.Type == Tokens.Plus )
							{
								writer.WriteLine();
								writer.Write( new string( '\t', indent ) );
								needSpace = false;
								i--;
								break;
							}

							writer.Write( ' ' );

							if( token.Type == Tokens.Identifier || token.Type == Tokens.Literal )
								writer.Write( token.Value );
							else
								writer.Write( GetTokenString( token.Type ) );
						}

						continue;
					}

					if( token.Type == Tokens.at_end )
					{
						--indent;
						if( tokens[i - 1].Type != Tokens.Semicolon )
						{
							writer.WriteLine();
							writer.Write( new string( '\t', indent ) );
						}

						writer.WriteLine( GetTokenString( token.Type ) );
						writer.Write( new string( '\t', indent ) );
						needSpace = false;
						continue;
					}

					if( needSpace && token.Type != Tokens.OpenSquareBracket && token.Type != Tokens.CloseSquareBracket && token.Type != Tokens.Semicolon && token.Type != Tokens.Comma && token.Type != Tokens.Dot )
						writer.Write( ' ' );

					if( token.Type == Tokens.Identifier || token.Type == Tokens.Literal )
						writer.Write( token.Value );
					else
						writer.Write( GetTokenString( token.Type ) );

					if( insideEnum && token.Type == Tokens.Comma )
					{
						needSpace = false;
						writer.WriteLine();
						writer.Write( new string( '\t', indent ) );
						continue;
					}

					if( token.Type == Tokens.Semicolon )
					{
						writer.WriteLine();

						if( i != tokens.Length - 1 && ( tokens[i + 1].Type == Tokens.CloseCurlyBrace || tokens[i + 1].Type == Tokens.at_end ) )
							writer.Write( new string( '\t', Math.Max( indent - 1, 0 ) ) );
						else
							writer.Write( new string( '\t', indent ) );

						needSpace = false;
					}
					else if( token.Type == Tokens.OpenSquareBracket || token.Type == Tokens.Dot )
						needSpace = false;
					else
						needSpace = true;
				}
		}

		public void PrintTokenStatistics( string filename )
		{
			using( var writer = new StreamWriter( filename ) )
				PrintTokenStatistics( writer );
		}

		public void PrintTokenStatistics( TextWriter writer )
		{
			foreach( var tokenGroup in Output.TakeWhile( x => x.Type != Tokens.EOF ).GroupBy( x => x.Type ).OrderByDescending( x => x.Count() ) )
				writer.WriteLine( "{0}: {1}", tokenGroup.Key, tokenGroup.Count() );
		}

		public void PrintIdentifierStatistics( string filename )
		{
			using( var writer = new StreamWriter( filename ) )
				PrintIdentifierStatistics( writer );
		}

		public void PrintIdentifierStatistics( TextWriter writer )
		{
			foreach( var tokenGroup in Output.TakeWhile( x => x.Type != Tokens.EOF ).Where( x => x.Type == Tokens.Identifier ).GroupBy( x => x.Value ).OrderByDescending( x => x.Count() ) )
				writer.WriteLine( "{0}: {1}", tokenGroup.Key, tokenGroup.Count() );
		}
	}

	public class LexerException : Exception
	{
		public LexerException( string message, int row, int column )
			: base( message )
		{
			Row = row;
			Column = column;
		}

		public int Row { get; private set; }
		public int Column { get; private set; }
	}
}
