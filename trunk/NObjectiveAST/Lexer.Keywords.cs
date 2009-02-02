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
	public partial class Lexer
	{
		internal static readonly string[] Keywords = new[]
		{
			"__asm",
			"__asm__",
			"__attribute__",
			"__inline",
			"__inline__",
			"__restrict",
			"__forceinline",

			"asm",
			"auto",
			"bool",
			"break",
			"byte",
			"case",
			"catch",
			"char",
			"unsigned",
			"class",
			"const",
			"const_cast",
			"continue",
			"default",
			"delete",
			"do",
			"double",
			"dynamic_cast",
			"else",
			"enum",
			"explicit",
			"extern",
			"false",
			"float",
			"for",
			"goto",
			"if",
			"inline",
			"int",
			"long",
			"namespace",
			"new",
			"operator",
			"private",
			"protected",
			"public",
			"register",
			"reinterpret_cast",
			"return",
			"restrict",
			"short",
			"signed",
			"sizeof",
			"static",
			"static_cast",
			"struct",
			"switch",
			"template",
			"this",
			"throw",
			"true",
			"try",
			"typedef",
			"typeid",
			"typename",
			"union",
			"using",
			"virtual",
			"void",
			"volatile",
			// "wchar_t",
			"while"
		};

		internal static readonly string[] ObjectiveKeywords = new[]
		{
			"catch",
			"class",
			"end",
			"finally",
			"implementation",
			"interface",
			"optional",
			"private",
			"property",
			"protected",
			"protocol",
			"public",
			"required",
			"throw",
			"try"
		};
	}
}