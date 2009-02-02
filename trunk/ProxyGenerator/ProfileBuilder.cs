//
// Copyright (C) 2009 Eugeny Grishul
//
// See license in GPLv3.txt
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection.Emit;
using System.Reflection;

namespace NObjective.ProxyGenerator
{
	/// <summary>
	/// Generates proxies for different Objective-C runtimes.
	/// </summary>
	internal class ProfileBuilder
	{
		public const string ProfileDirectory = "../ProxyGenerator/Profiles/";
		public static string ProfileToGenerate = "10.5";

		private static void Main( string[] args )
		{
			if( args.Length == 1 )
				ProfileToGenerate = args[0];

			var profileDirectory = Path.Combine( ProfileDirectory, ProfileToGenerate );

			Console.WriteLine( string.Join( Environment.NewLine, new[] {
          		"This program Copyright (C) 2009 Eugeny Grishul",
          		"This program comes with ABSOLUTELY NO WARRANTY",
          		"This is free software, and you are welcome to redistribute it under certain conditions", 
          		"", "" } ) );

			if( !Directory.Exists( profileDirectory ) )
			{
				Console.WriteLine( "Profile directory {0} not exists!", profileDirectory );
				return;
			}

			RuntimeDumper.LoadSettings( ProfileToGenerate );

			if( ProfileToGenerate == RuntimeDumper.NativeProfile )
				RuntimeDumper.Dump( ProfileToGenerate );

			//HeaderAnalyzer.Analyze( ProfileToGenerate );

			ProxyBuilder.GenerateProfile( ProfileToGenerate );
		}
	}
}
