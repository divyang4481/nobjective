//
// Copyright (C) 2009 Eugeny Grishul
//
// See license in License.txt
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System.Globalization;

namespace NObjective
{
	/// <summary>
	/// 
	/// </summary>
	public class PeformanceVisualizer
	{
		public static void Main( string[] parameters )
		{
			foreach( var platform in Directory.GetDirectories( "." ) )
			{
				foreach( var os in Directory.GetDirectories( platform ) )
				{
					var files = Directory.GetFiles( os, "*.Results.xml" );
					if( files.Length == 0 ) continue;

					var libraryNames = files.Select( x => x.Remove( x.Length - 12 ) ).ToArray();
					var results = files.Select( x => PerformanceTestResult.Load( x ) ).ToArray();

					var categories = results.SelectMany( x => x.Entries ).Select( x => x.Name ).Distinct().ToArray();

					using( var htmlWriter = new StreamWriter( Path.Combine( os, "TestResults.htm" ) ) )
					using( var wikiWriter = new StreamWriter( Path.Combine( os, "TestResults.wiki" ) ) )
					{
						htmlWriter.WriteLine( "<html><body>" );
						foreach( var category in categories )
						{
							var entries = results.Select( x => new { Entry = x[category], Name = x.AssemblyName } ).OrderByDescending( x => x.Name ).ToArray();

							var performanceValues = entries.Select( x => x.Entry == null ? 0 : ( double ) x.Entry.Score ).ToArray();
							var maximumValue = performanceValues.Max();
							var normalizedValues = performanceValues.Select( x => ( x * 100.0 / maximumValue ).ToString( CultureInfo.InvariantCulture ) ).ToArray();

							var url = string.Format( @"http://chart.apis.google.com/chart?chtt={5}&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|{1}|{2}|{3}&cht=bhg&chd=t:{4}&chdl={0}&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png", string.Join( "|", entries.Select( x => x.Name ).ToArray() ), ( long ) ( maximumValue / 3 ), ( long ) ( maximumValue * 2 / 3 ), maximumValue, string.Join( "|", normalizedValues ), Escape( category ) );

							htmlWriter.WriteLine( @"<img src=""{0}""/>", url );
							wikiWriter.WriteLine( "{0}", url );
						}
						htmlWriter.WriteLine( "</body></html>" );
					}
				}
			}
		}

		public static string Escape( string value )
		{
			return value.Replace( ' ', '+' ).Replace( "#", "%23" );
		}
	}
}