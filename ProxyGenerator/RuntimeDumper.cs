//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in GPLv3.txt
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace NObjective.ProxyGenerator
{
	/// <summary>
	/// Dumps all neccessary Objective-C runtime information.
	/// </summary>
	internal class RuntimeDumper
	{
		public const string InputFilename = "../ProxyGenerator/Profiles/{0}/dumper_settings.xml";
		public const string OutputFilename = "../ProxyGenerator/Profiles/{0}/runtime_dump.xml";

		public static DumpingSettings Settings = new DumpingSettings
		{
			ClassIncludeFilters = new[] { 
				".*" 
			},

			MethodExcludeFilters = new[] {
				"^_",
				"^CA_",
				"^alloc$",
				"^dealloc$",
				"^finalize$",
				"^allocWithZone:$",
				"^copyWithZone:$",
			},

			Frameworks = new List<FrameworkInfo> { 
				new FrameworkInfo( "Cocoa" ),
				new FrameworkInfo( "CoreData" ),
				new FrameworkInfo( "CoreVideo" ),
				new FrameworkInfo( "CoreAudio" ),
				new FrameworkInfo( "QuartzCore" ),
				new FrameworkInfo( "AppKit" ),
				new FrameworkInfo( "AddressBook" ),
				new FrameworkInfo( "WebKit" ),
				new FrameworkInfo( "DiscRecording" )		
			}
		};

		private static string _nativeProfile;
		public static string NativeProfile
		{
			get
			{
				if( _nativeProfile != null )
					return _nativeProfile;

				if( ProxyBuilder.IsRunningOnMacintosh )
					switch( Runtime.Version )
					{
						case Runtime.MacOSVersion.Tiger:
							return _nativeProfile = "10.4";

						case Runtime.MacOSVersion.Leopard:
							return _nativeProfile = "10.5";

						case Runtime.MacOSVersion.SnowLeopard:
							return _nativeProfile = "10.6";

						case Runtime.MacOSVersion.IPhone:
							return _nativeProfile = "iPhone";
					}

				return _nativeProfile = "invalid";
			}
		}

		public static Regex[] MethodExcludeFilters;
		public static Regex[] ClassIncludeFilters;
		public static Regex[] ClassExcludeFilters;

		public static void LoadSettings( string profileName )
		{
			bool regenerate = false;

			if( File.Exists( string.Format( InputFilename, profileName ) ) )
				try
				{
					using( var xml = new StreamReader( string.Format( InputFilename, profileName ) ) )
						Settings = new XmlSerializer( Settings.GetType() ).Deserialize( xml ) as DumpingSettings;
				}
				catch { regenerate = true; }
			else
				regenerate = true;

			if( regenerate )
			{
				Console.WriteLine( "Regeneration of setting file.." );
				var frameworks = Directory.GetDirectories( "/System/Library/Frameworks/" ).Where( x => x.EndsWith( ".framework" ) );
				Settings.Frameworks = frameworks.Select( x => new FrameworkInfo() { Name = Path.GetFileNameWithoutExtension( x ) } ).ToList();

				using( var xml = new StreamWriter( string.Format( InputFilename, profileName ) ) )
					new XmlSerializer( Settings.GetType() ).Serialize( xml, Settings );
			}

			MethodExcludeFilters = Settings.MethodExcludeFilters.Select( x => new Regex( x, RegexOptions.Compiled ) ).ToArray();
			ClassIncludeFilters = Settings.ClassIncludeFilters.Select( x => new Regex( x, RegexOptions.Compiled ) ).ToArray();
			ClassExcludeFilters = Settings.ClassExcludeFilters.Select( x => new Regex( x, RegexOptions.Compiled ) ).ToArray();
		}

		public static void Dump( string profileName )
		{
			if( !ProxyBuilder.IsRunningOnMacintosh )
				return;

			// load classes from specified frameworks
			foreach( var setting in Settings.Frameworks )
			{
				setting.Path = setting.Path ?? string.Format( "/System/Library/Frameworks/{0}.framework/{0}", setting.Name );

				Console.WriteLine( "Loading library {0}..", setting.Path );

				NativeMethods.dlopen( setting.Path, 0x1 );
			}

			var result = new ObjectiveCRuntimeInfo { OSVersion = Runtime.Version.ToString() };
			var libraries = new Dictionary<string, ObjectiveCRuntimeInfo.LibraryInfo>();

			var dumpedMethods = new HashSet<string>();

			Action<string> createLibary = ( libraryName ) =>
			{
				if( !libraries.ContainsKey( libraryName ) )
				{
					libraries[libraryName] = new ObjectiveCRuntimeInfo.LibraryInfo();
					libraries[libraryName].Path = libraryName;
				}
			};

			foreach( var @class in RuntimeClass.GetAllClasses() )
			{
				var className = @class.Name;

				if( !ClassExcludeFilters.All( x => !x.IsMatch( className ) ) || !ClassIncludeFilters.Any( x => x.IsMatch( className ) ) )
					continue;

				if( Runtime.IsInternalProxyClass( @class ) )
					continue;

				var classSetting = new ObjectiveCRuntimeInfo.ClassInfo { Name = className };

				var libraryName = @class.DeclaringImage;

				// for generated classes
				if( libraryName == null )
				{
					var baseImage = "/usr/lib/libobjc.A.dylib";

					foreach( var item in @class.BaseClass.BaseHierarchy )
					{
						if( item.DeclaringImage == null )
							continue;

						baseImage = item.DeclaringImage;
						break;
					}
					libraryName = baseImage;
				}

				createLibary( libraryName );

				if( @class.BaseClass != RuntimeClass.Null )
					classSetting.BaseClassName = @class.BaseClass.Name;

				dumpedMethods.Clear();
				foreach( var method in @class.Methods )
				{
					var methodName = method.Name;
					var methodLibrary = method.DeclaringImage;

					if( !MethodExcludeFilters.All( x => !x.IsMatch( methodName ) ) || dumpedMethods.Contains( methodName ) )
						continue;

					dumpedMethods.Add( methodName );

					if( methodLibrary != libraryName )
					{
						createLibary( methodLibrary );

						var extensionsClass = libraries[methodLibrary].Extensions.FirstOrDefault( x => x.Name == className );
						if( extensionsClass == null )
						{
							extensionsClass = new ObjectiveCRuntimeInfo.ClassInfo { Name = className };
							libraries[methodLibrary].Extensions.Add( extensionsClass );
						}

						extensionsClass.InstanceMethods.Add( new ObjectiveCRuntimeInfo.MethodInfo { Name = method.Name, Encoding = method.Encoding } );
						continue;
					}

					classSetting.InstanceMethods.Add( new ObjectiveCRuntimeInfo.MethodInfo { Name = method.Name, Encoding = method.Encoding } );
				}

				foreach( var property in @class.Properties )
				{
					classSetting.Properties = classSetting.Properties ?? new List<ObjectiveCRuntimeInfo.PropertyInfo>();
					classSetting.Properties.Add( new ObjectiveCRuntimeInfo.PropertyInfo { Name = property.Name, Encoding = property.Attributes } );
				}

				dumpedMethods.Clear();
				foreach( var method in @class.MetaClass.Methods )
				{
					var methodName = method.Name;
					var methodLibrary = method.DeclaringImage;

					if( !MethodExcludeFilters.All( x => !x.IsMatch( methodName ) ) || dumpedMethods.Contains( methodName ) )
						continue;

					dumpedMethods.Add( methodName );

					if( methodLibrary != libraryName )
					{
						createLibary( methodLibrary );

						var extensionsClass = libraries[methodLibrary].Extensions.FirstOrDefault( x => x.Name == className );
						if( extensionsClass == null )
						{
							extensionsClass = new ObjectiveCRuntimeInfo.ClassInfo { Name = className };
							libraries[methodLibrary].Extensions.Add( extensionsClass );
						}

						extensionsClass.ClassMethods.Add( new ObjectiveCRuntimeInfo.MethodInfo { Name = method.Name, Encoding = method.Encoding } );
						continue;
					}

					classSetting.ClassMethods.Add( new ObjectiveCRuntimeInfo.MethodInfo { Name = methodName, Encoding = method.Encoding } );
				}

				libraries[libraryName].Classes.Add( classSetting );
			}

			result.Libraries = libraries.Select( x => x.Value ).OrderBy( x => x.Path ).ToList();

			foreach( var library in result.Libraries )
			{
				library.Classes = library.Classes.OrderBy( x => x.Name ).ToList();

				foreach( var @class in library.Classes )
				{
					@class.ClassMethods = @class.ClassMethods.OrderBy( x => x.Name ).ToList();
					@class.InstanceMethods = @class.InstanceMethods.OrderBy( x => x.Name ).ToList();

					if( @class.Properties != null )
						@class.Properties = @class.Properties.OrderBy( x => x.Name ).ToList();
				}
			}

			using( var file = new StreamWriter( string.Format( OutputFilename, profileName ) ) )
				new XmlSerializer( result.GetType() ).Serialize( file, result );

			Console.WriteLine( "Dump information:" );
			Console.WriteLine( " {0} libraries", result.Libraries.Count );
			Console.WriteLine( " {0} classes", result.Libraries.Sum( x => x.Classes.Count ) );
			Console.WriteLine( " {0} methods", result.Libraries.SelectMany( x => x.Classes ).Sum( x => x.ClassMethods.Count + x.InstanceMethods.Count ) );
			Console.WriteLine( " {0} properties", result.Libraries.SelectMany( x => x.Classes ).Sum( x => x.Properties == null ? 0 : x.Properties.Count ) );
		}

		private static class NativeMethods
		{
			[DllImport( "libobjc.dylib" )]
			public static extern int dlopen( string name, int type );
		}
	}

	public class DumpingSettings
	{
		/// <summary>
		/// Inclusive class name filter.
		/// </summary>
		public string[] ClassIncludeFilters = { "^NS" };

		/// <summary>
		/// Exclusive class name filter.
		/// </summary>
		public string[] ClassExcludeFilters = { };

		/// <summary>
		/// Exclusive method name filter.
		/// </summary>
		public string[] MethodExcludeFilters = { "^_" };

		/// <summary>
		/// Hold setting about frameworks which will be loaded and processed.
		/// </summary>
		public List<FrameworkInfo> Frameworks;
	}

	public class ObjectiveCRuntimeInfo
	{
		[XmlType( "library" )]
		public class LibraryInfo
		{
			[XmlAttribute( "image" )]
			public string Path;

			[XmlElement( "class" )]
			public List<ClassInfo> Classes = new List<ClassInfo>();

			[XmlElement( "extension" )]
			public List<ClassInfo> Extensions = new List<ClassInfo>();

			[XmlIgnore]
			public string Name { get { return System.IO.Path.GetFileName( Path ); } }

			[XmlIgnore]
			public string Identifier { get { return Name.Replace( '.', '_' ); } }

			public override string ToString()
			{
				return Path;
			}
		}

		[XmlType( "class" )]
		public class ClassInfo
		{
			[XmlAttribute( "name" )]
			public string Name;

			[XmlIgnore]
			public string Identifier
			{
				get { return ProxyBuilder.GetValidIdentifier( Name ); }
			}

			[XmlAttribute( "base" )]
			public string BaseClassName;

			public List<MethodInfo> ClassMethods = new List<MethodInfo>();
			public List<MethodInfo> InstanceMethods = new List<MethodInfo>();
			public List<PropertyInfo> Properties = null;

			public override string ToString()
			{
				return Name;
			}
		}

		[XmlType( "method" )]
		public class MethodInfo
		{
			[XmlAttribute( "name" )]
			public string Name;

			[XmlAttribute( "encoding" )]
			public string Encoding;

			public override string ToString()
			{
				return Name;
			}
		}

		[XmlType( "property" )]
		public class PropertyInfo
		{
			[XmlAttribute( "name" )]
			public string Name;

			[XmlAttribute( "encoding" )]
			public string Encoding;

			public override string ToString()
			{
				return Name;
			}
		}

		[XmlAttribute( "os" )]
		public string OSVersion;

		[XmlElement( "library" )]
		public List<LibraryInfo> Libraries = new List<LibraryInfo>();
	}

	[XmlType( "framework" )]
	public class FrameworkInfo
	{
		/// <summary>
		/// Framework name.
		/// </summary>
		[XmlAttribute( "name" )]
		public string Name;

		/// <summary>
		/// Non-standart path ( /System/Library/Frameworks/${Name}.framework/ ) to framework or null otherwise.
		/// </summary>
		[XmlAttribute( "path" )]
		public string Path;

		/// <summary>
		/// Header files to analyze or null to analyze ${Name}/${Name}.h
		/// </summary>
		[XmlElement( "include" )]
		public List<string> Includes;

		public FrameworkInfo()
		{
		}

		public FrameworkInfo( string name )
		{
			Name = name;
		}

		public override string ToString()
		{
			return Name ?? Path;
		}
	}
}
