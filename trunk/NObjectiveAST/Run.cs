//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

#define GCCFILE

using System.IO;
using NObjectiveAST;
using System.Diagnostics;
using System.Threading;
using System;

namespace NHeader
{
	internal static class Run
	{
#if GCCFILE
		const string InputFile = "objc_gcc_preprocessed.mm";
#else
		const string InputFile = "test.cpp";
#endif
		const string LexerOutputFile = "lexer_output.cpp";

		[STAThread]
		static unsafe void Main( string[] args )
		{
			Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
			Thread.CurrentThread.Priority = ThreadPriority.AboveNormal;

			Lexer lexer = null;
			TranslationUnit translationUnit = null;
			NObjectiveAST.EvaluatedRepresentation.TranslationUnit evaluatedTranslationUnit = null;

			var stopwatch = new Stopwatch();
			for( int i = 0; i < 1; i++ )
			{
				stopwatch.Start();
				lexer = new Lexer( File.ReadAllText( InputFile ) );
				translationUnit = new Parser( lexer ).TranslationUnit;
				evaluatedTranslationUnit = NObjectiveAST.EvaluatedRepresentation.EvaluationVisitor.GetTranslationUnit( translationUnit );
				stopwatch.Stop();

				GC.Collect();
				Console.WriteLine( "Memory: {0}KiB", GC.GetTotalMemory( false ) / 1024 );
				Console.WriteLine( "Elapsed: {0}ms", stopwatch.ElapsedMilliseconds );
				Console.WriteLine();
				
				stopwatch.Reset();
			}

			lexer.PrintTokenStatistics( "tokens_stats.txt" );
			lexer.PrintIdentifierStatistics( "identifier_stats.txt" );

			StatisticsVisitor.SaveAST( "ast_tree.xml", translationUnit );
			StatisticsVisitor.LoadAST( "ast_tree.xml" );
			StatisticsVisitor.PrintStatistics( "ast_stats.txt", translationUnit );

			lexer.SaveTokens( LexerOutputFile );
			OutputVisitor.Write( "ast_formatted.cpp", translationUnit );

			//Process.Start( "winmerge", "lexer_output.cpp lexer_output_orig.cpp /e" );
		}
	}
}
