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
using System.Runtime.InteropServices;

namespace NObjective
{
	public class PerformanceTestBase
	{
		public const int Runnings = 3;
		public const int Iterations = 20000;

		private readonly Stopwatch _timer = new Stopwatch();

		public event Action OnBeginTest = delegate { };
		public event Action OnEndTest = delegate { };

		public event Action<string, double> OnPerformanceReport = ( name, score ) => { Console.WriteLine( "{0}: {1}", name, score ); Console.Out.Flush(); };

		public const string Invocation = "Invocations per second";
		public const string Allocation = "Allocations per second";
		public const string VarargInvocations = "Vararg invocations per second";
		public const string ExceptionHandlerOverhead = "Protected calls per second";
		public const string ExceptionRethrows = "Exception rethrows per second";
		public const string TotalManagedMemory = "Managed memory consumption (KiB)";
		public const string TotalUnmanagedMemory = "Unmanaged memory consumption (KiB)";

		public void TestAll( Assembly testedAssembly )
		{
			Console.WriteLine( "{0} v{1} results:", testedAssembly.GetName().Name, testedAssembly.GetName().Version );

			var testResult = new PerformanceTestResult();
			testResult.AssemblyName = testedAssembly.GetName().Name.Split( '.' ).First();

			Action<string, double> addEntry = ( name, score ) => { testResult.Entries.Add( new PerformanceEntry( name, score ) ); };
			OnPerformanceReport += addEntry;

			var methodsToTest = new Action<int>[] { 
				TestInvocation,
				TestAllocation, 
				TestVarargMarshaling,
				TestExceptionHandlerOverhead,
				TestExceptionRethrow
			};

			var testNames = new string[] { 
				Invocation,
				Allocation, 
				VarargInvocations,
				ExceptionHandlerOverhead,
				ExceptionRethrows
			};

			var perSecond = new bool[]{
				true,
				true,
				true,
				true,
				true,
			};

			try
			{
				// JITting code
				for( int i = 0; i < methodsToTest.Length; i++ )
				{
					_timer.Start();

					OnBeginTest();
					try { methodsToTest[i]( Iterations ); }
					catch( NotImplementedException ) { }
					OnEndTest();
					GC.Collect();

					_timer.Stop();
					_timer.Reset();
				}

				// run tests
				for( int i = 0; i < methodsToTest.Length; i++ )
				{
					var bestResult = double.MaxValue;
					for( int j = 0; j < Runnings; j++ )
					{
						OnBeginTest();
						try
						{
							_timer.Start();
							methodsToTest[i]( Iterations );
							_timer.Stop();
						}
						catch( NotImplementedException ) { goto end_test; }
						finally
						{
							OnEndTest();
							GC.Collect();
						}

						bestResult = Math.Min( bestResult, _timer.Elapsed.TotalMilliseconds );
						_timer.Reset();
					}

					OnPerformanceReport( testNames[i], perSecond[i] ? ( long ) ( 1000.0 * Iterations / bestResult ) : bestResult );

				end_test:
					continue;
				}

				GC.Collect();
				OnPerformanceReport( TotalManagedMemory, GC.GetTotalMemory( true ) / 1024.0 );

				GC.Collect();
				OnPerformanceReport( TotalUnmanagedMemory, OS.GetTaskBasicInfo().resident_size.ToInt32() / 1024 );
			}
			finally
			{
				OnPerformanceReport -= addEntry;
			}
			Console.WriteLine();

			var osdir = "";
			switch( OS.Version ) {
				case OS.MacOSVersion.Tiger: osdir = "Tiger"; break;
				case OS.MacOSVersion.Leopard: osdir = "Leopard"; break;
				case OS.MacOSVersion.SnowLeopard: osdir = "Snow Leopard"; break;
			}
				
			var resultsFile = Assembly.GetExecutingAssembly().GetName().Name + ".Results.xml";
			var statisticsDirectory = PathCombine( "..", "..", "results", BitConverter.IsLittleEndian ? "Intel" : "PowerPC", osdir );
			
			if( Directory.Exists( statisticsDirectory ) ) {
				testResult.Save( Path.Combine( statisticsDirectory, resultsFile ) );
			}
				
			testResult.Save( resultsFile );
		}
		
		private static string PathCombine( params string[] directories ) {
			var result = directories[0];
			
			for (int i = 1; i < directories.Length; ++i ) {
				result = Path.Combine( result, directories[i] );
			}
			
			return result;
		}

		public virtual void TestInvocation( int iterations )
		{
			throw new NotImplementedException();
		}

		public virtual void TestAllocation( int iterations )
		{
			throw new NotImplementedException();
		}

		public virtual void TestVarargMarshaling( int iterations )
		{
			throw new NotImplementedException();
		}

		public virtual void TestExceptionHandlerOverhead( int iterations )
		{
			throw new NotImplementedException();
		}

		public virtual void TestExceptionRethrow( int iterations )
		{
			throw new NotImplementedException();
		}
	}

	public class PerformanceTestResult
	{
		[XmlElement( "entry" )]
		public List<PerformanceEntry> Entries = new List<PerformanceEntry>();

		[XmlAttribute( "name" )]
		public string AssemblyName;

		public static PerformanceTestResult Load( string filename )
		{
			using( var reader = new StreamReader( filename ) )
				return ( PerformanceTestResult ) new XmlSerializer( typeof( PerformanceTestResult ) ).Deserialize( reader );
		}

		public void Save( string filename )
		{
			using( var writer = new StreamWriter( filename ) )
				new XmlSerializer( typeof( PerformanceTestResult ) ).Serialize( writer, this );
		}

		public PerformanceEntry this[string name]
		{
			get { return Entries.FirstOrDefault( x => x.Name == name ); }
		}

		public override string ToString()
		{
			return string.Format( "{0}", AssemblyName );
		}
	}

	public class PerformanceEntry
	{
		public PerformanceEntry()
		{
		}

		public PerformanceEntry( string name, double score )
		{
			Name = name;
			Score = score;
		}

		[XmlAttribute( "name" )]
		public string Name;

		[XmlAttribute( "score" )]
		public double Score;

		public override string ToString()
		{
			return string.Format( "{0}: {1}", Name, Score );
		}
	}

	public static unsafe class OS
	{
		public struct time_value
		{
			public int seconds;
			public int microseconds;
		}

		public struct task_basic_info
		{
			public int suspend_count;
			public IntPtr virtual_size;
			public IntPtr resident_size;
			public time_value user_time;
			public time_value system_time;
			public int policy;
		}

		public enum task_flavor_t
		{
			TASK_BASIC_INFO_32 = 4,
			TASK_BASIC2_INFO_32 = 6
		}

		public static task_basic_info GetTaskBasicInfo()
		{
			var result = new task_basic_info();
			int structureLength = sizeof( task_basic_info ) / IntPtr.Size;

			NativeMethods.task_info( NativeMethods.mach_task_self(), task_flavor_t.TASK_BASIC_INFO_32, new IntPtr( &result ), ref structureLength );

			return result;
		}

		public enum MacOSVersion
		{
			Invalid,
			Cheetah,
			Puma,
			Jaguar,
			Panther,
			Tiger,
			Leopard,
			SnowLeopard,
			Future,
			IPhone
		}

		public static MacOSVersion Version
		{
			get
			{
				if( _version != null )
					return _version.Value;

				int response;
				NativeMethods.Gestalt( 0x73797376, out response );

				if( response < 0x1000 )
					_version = MacOSVersion.Invalid;
				else if( response < 0x1010 )
					_version = MacOSVersion.Cheetah;
				else if( response < 0x1020 )
					_version = MacOSVersion.Puma;
				else if( response < 0x1030 )
					_version = MacOSVersion.Jaguar;
				else if( response < 0x1040 )
					_version = MacOSVersion.Panther;
				else if( response < 0x1050 )
					_version = MacOSVersion.Tiger;
				else if( response < 0x1060 )
					_version = MacOSVersion.Leopard;
				else if( response < 0x1070 )
					_version = MacOSVersion.SnowLeopard;

				return _version.Value;
			}
		}
		private static MacOSVersion? _version;
		
		private static class NativeMethods
		{
			[DllImport( "libc.dylib" )]
			public static extern IntPtr mach_task_self();

			[DllImport( "libc.dylib" )]
			public static extern int task_info( IntPtr task, task_flavor_t flavor, IntPtr taskInfoStructure, ref int structureLength );

			[DllImport( "/System/Library/Frameworks/CoreServices.framework/CoreServices" )]
			public static extern short Gestalt( int selector, out int response );
		}
	}
}
