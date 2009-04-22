//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System;
using NObjective.Proxies;
using System.Diagnostics;
using System.Threading;

namespace NObjective
{
	/// <summary>
	/// Each instance of that class will contain Handle - pointer to objc container which holds ivars and exported methods.
	/// For each abstract property in objc container will be generated ivar with appropriate name and properties itself
	/// will be impemented in derived class which invisible to programmer, but can accessed via <code>new RuntimeClass( "GUITest" )</code>.
	/// </summary>
	[BaseClass( "NSWindowController" )]
	public abstract class GUITest : RuntimeExportBase
	{
		protected GUITest()
		{
		}

		/// <summary>
		/// Body of that property is generated by runtime and get\sets values from appropriate "Button" ivar (outlet for IB) in unmanaged part of code
		/// </summary>
		public abstract NSButton Button { get; set; }

		/// <summary>
		/// Body of that property is generated by runtime and get\sets values from appropriate "Progress" ivar (outlet for IB) in unmanaged part of code
		/// </summary>
		public abstract NSProgressIndicator Progress { get; set; }
		
		public abstract NSSlider Slider { get; set; }
		public abstract NSProgressIndicator SpinnedProgress { get; set; }

		public abstract NSButton Checkbox { get; set; }
		public abstract NSComboBox Combobox { get; set; }
		/// <summary>
		/// See actions in XIB file. For Button acion is "ButtonPressed:"
		/// </summary>
		/// <param name="sender"></param>
		public void ButtonPressed( NSButton sender )
		{
			// coz there are bugs in mono JIT, so advanced techniques used to build assembly currently causes errors in some cases.. (  Microsoft's VES currenly normally handles such code  )
			// dont allow proxy objects be directly boxed like Console.WriteLine( "Pressed {0}", sender );
			// also don't directly convert to base type line Console.WriteLine( "Pressed {0}", (NSObject)sender );
			// use follow workaround Console.WriteLine( "Pressed {0}", new NSObject( sender ) );
			//Console.WriteLine( "Pressed {0}", sender );
			Console.WriteLine( "Pressed {0}", sender.ToString() );

			var value = new Random().NextDouble();

			Progress.setDoubleValue_( value );
			Slider.setDoubleValue_( value );
			SpinnedProgress.setDoubleValue_( value );
			Checkbox.setState_( Checkbox.state() ^ 1 );
		}

		public void OnSliderMove( NSButton sender )
		{
			var value = Slider.doubleValue();

			Progress.setDoubleValue_( value );
			SpinnedProgress.setDoubleValue_( value );
		}

		/// <summary>
		/// Called after binding outlets
		/// </summary>
		public void awakeFromNib()
		{
			foreach( TypeCode element in Enum.GetValues( typeof( TypeCode ) ) )
				Combobox.addItemWithObjectValue_( element.ToString() );

			Combobox.selectItemAtIndex_( 0 );
		}

		/// <summary>
		/// Application should terminate after last window closed? No? Are you sure?
		/// </summary>
		/// <param name="application"></param>
		/// <returns>No if you want to see application in dock =)</returns>
		public bool applicationShouldTerminateAfterLastWindowClosed( NSApplication application )
		{
			Console.WriteLine( "All windows in {0} are closed..", application.ToString() );
			return true;
		}

		/// <summary>
		/// Entry point for our application
		/// </summary>
		/// <param name="args"></param>
		static void Main( string[] args )
		{
			try
			{
				Console.WriteLine( "Application started.." );
				Console.WriteLine( "pwd {0}", Environment.CurrentDirectory );
				Trace.AutoFlush = true;
				NSApplication.sharedApplication();

				Console.WriteLine( "bundlePath = {0}", NSBundle.mainBundle().bundlePath() );
				Console.WriteLine( "executablePath = {0}", NSBundle.mainBundle().executablePath() );
				Console.WriteLine( "resourcePath = {0}", NSBundle.mainBundle().resourcePath() );

				Console.WriteLine( "privateFrameworksPath = {0}", NSBundle.mainBundle().privateFrameworksPath() );
				Console.WriteLine( "sharedFrameworksPath = {0}", NSBundle.mainBundle().sharedFrameworksPath() );
				Console.WriteLine( "sharedSupportPath = {0}", NSBundle.mainBundle().sharedSupportPath() );
				Console.WriteLine( "builtInPlugInsPath = {0}", NSBundle.mainBundle().builtInPlugInsPath() );

				var proxy = Runtime.CreateInstance<GUITest>( "init" );

				Console.WriteLine( "pwd {0}", Environment.CurrentDirectory );
				Console.WriteLine( "Load NIB: {0}", AppKitExtensionsOfNSBundle.loadNibNamed_owner_( "GUI", proxy.Handle ) );
				Console.WriteLine( "Application runned.." );

				var consoleReaderThread = new Thread( () =>
				{
					while( Console.Read() != 'q' ) { }

					NSApplication.sharedApplication().terminate_( NSApplication.sharedApplication() );
				} );
				consoleReaderThread.Start();

				NSApplication.sharedApplication().run();
				consoleReaderThread.Interrupt();
			}
			catch( Exception excpt )
			{
				Console.WriteLine( excpt );
			}
			finally
			{
				Console.WriteLine( "Application closed.." );
			}
		}

	}
}
