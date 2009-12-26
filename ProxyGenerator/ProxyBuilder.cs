//
// Copyright (C) 2009 Eugeny Grishul
//
// See license in GPLv3.txt
//

//#define USE_VALUE_TYPE_INHERITANCE

using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using Microsoft.CSharp;
using System.Diagnostics;
using ICSharpCode.NRefactory.Ast;
using ICSharpCode.NRefactory.PrettyPrinter;
using System.Threading;
using System.Runtime.CompilerServices;

namespace NObjective.ProxyGenerator
{
	/// <summary>
	/// Builds C# proxies for Objective-C classes.
	/// </summary>
	internal class ProxyBuilder
	{
		/// <summary>
		/// Number of generated proxies.
		/// </summary>
		private static int GeneratedProxiesCount;
		private int _generatedProxiesCount;

		/// <summary>
		/// Number of generated properties.
		/// </summary>
		private static int GeneratedPropertiesCount;
		private int _generatedPropertiesCount;

		/// <summary>
		/// Number of generated methods.
		/// </summary>
		private static int GeneratedMethodsCount;
		private int _generatedMethodsCount;

		/// <summary>
		/// Number of generated structures.
		/// </summary>
		public static int GeneratedStructuresCount { get; set; }

		/// <summary>
		/// Number of generated enums.
		/// </summary>
		public static int GeneratedEnumsCount { get; set; }

		/// <summary>
		/// Generate only classes and member that mentioned in analyze.i
		/// </summary>
		public const bool GenerateOnlyParsedClassesAndMethods = false;

		/// <summary>
		/// Setting file that contains information from parsed headers.
		/// </summary>
		internal const string SettingsFile = "../ProxyGenerator/Profiles/{0}/parsed_headers.xml";

		private static readonly Tracing.TraceSource Tracer = new Tracing.TraceSource( "Objc Class Generator" );

		private enum MethodType
		{
			Instance,
			Class
		}

		/// <summary>
		/// Information from parsed headers.
		/// </summary>
		private static ObjectiveCParsedInfo ParsedInformation = new ObjectiveCParsedInfo();

		/// <summary>
		/// Information from Objective-C introspection.
		/// </summary>
		private static ObjectiveCRuntimeInfo RuntimeInformation = new ObjectiveCRuntimeInfo();
		private static Dictionary<string, ObjectiveCRuntimeInfo.ClassInfo> ClassesToExport;

		public static void GenerateProfile( string profileName )
		{
			using( Tracer )
			{
				if( IsRunningOnMacintosh )
					Runtime.AddListener( new Tracing.TextWriterTraceListener( Console.Out ) );

				Tracer.AddListener( new Tracing.TextWriterTraceListener( "Class Generator.log" ) );

				using( var file = new StreamReader( string.Format( RuntimeDumper.OutputFilename, profileName ) ) )
					RuntimeInformation = new XmlSerializer( RuntimeInformation.GetType() ).Deserialize( file ) as ObjectiveCRuntimeInfo;

				Directory.CreateDirectory( string.Format( "../Proxies/{0}", profileName ) );

				if( File.Exists( SettingsFile ) )
					try
					{
						using( var xml = new StreamReader( string.Format( SettingsFile, profileName ) ) )
							ParsedInformation = new XmlSerializer( typeof( ObjectiveCParsedInfo ) ).Deserialize( xml ) as ObjectiveCParsedInfo;
					}
					catch( Exception excpt )
					{
						Tracer.Information( excpt.ToString() );
					}

				using( var file = new StreamReader( string.Format( SettingsFile, profileName ) ) )
					ParsedInformation = new XmlSerializer( ParsedInformation.GetType() ).Deserialize( file ) as ObjectiveCParsedInfo;

				//var invalid = RuntimeInformation.Libraries.SelectMany( x => x.Classes ).GroupBy( x => x.Name ).Where( x => x.Count() > 1 ).SelectMany( x => x ).ToArray();
				ClassesToExport = RuntimeInformation.Libraries.SelectMany( x => x.Classes ).ToDictionary( x => x.Name );

				GenerateStructures( profileName );
				GenerateEnums( profileName );

				GenerateLibraries( profileName );

				CheckUnhandledMembers();

				Console.WriteLine( "Generated:" );
				Console.WriteLine( " {0} proxies", GeneratedProxiesCount );
				Console.WriteLine( " {0} methods", GeneratedMethodsCount );
				Console.WriteLine( " {0} properties", GeneratedPropertiesCount );
				Console.WriteLine( " {0} enums", GeneratedEnumsCount );
				Console.WriteLine( " {0} structures", GeneratedStructuresCount );
			}
		}

		private ProxyBuilder()
		{
		}

		/// <summary>
		/// Generated all classes specified in runtime_dump.xml
		/// </summary>
		private static void GenerateLibraries( string profileName )
		{
			Action<ObjectiveCRuntimeInfo.LibraryInfo> classGeneration = ( ObjectiveCRuntimeInfo.LibraryInfo runtimeLibraryInfo ) =>
			{
				var builder = new ProxyBuilder();
				var compilationUnit = builder.GetCompilationUnit( runtimeLibraryInfo );

				Interlocked.Add( ref GeneratedProxiesCount, builder._generatedProxiesCount );
				Interlocked.Add( ref GeneratedMethodsCount, builder._generatedMethodsCount );
				Interlocked.Add( ref GeneratedPropertiesCount, builder._generatedPropertiesCount );

				var outputVisitor = new CSharpOutputVisitor();
				SetFormatterOptions( outputVisitor );

				compilationUnit.AcceptVisitor( outputVisitor, null );
				File.WriteAllText( string.Format( "../Proxies/{1}/{0}.cs", runtimeLibraryInfo.Name, profileName ), string.Join( Environment.NewLine, new[] {
						"//",
						"// Copyright (C) 2009 Eugeny Grishul",
						"//",
						"// See license in License.txt",
						"//",
						"",
						outputVisitor.Text } ) );
			};

			if( !IsRunningOnMacintosh )
			{
				if( Debugger.IsAttached )
				{
					foreach( var library in RuntimeInformation.Libraries.OrderByDescending( x => x.Classes.Count ) )
						classGeneration( library );
				}
				else
				{
					var listOfAsyncOperations = new List<IAsyncResult>();
					foreach( var library in RuntimeInformation.Libraries.OrderByDescending( x => x.Classes.Count ) )
						listOfAsyncOperations.Add( classGeneration.BeginInvoke( library, null, null ) );

					foreach( var item in listOfAsyncOperations )
					{
						classGeneration.EndInvoke( item );
						item.AsyncWaitHandle.Close();
					}
				}
			}
			else
			{
				// in version 2.0 mono for Mac OS X ThreadPool not working correctly
				foreach( var library in RuntimeInformation.Libraries )
					classGeneration( library );
			}
		}

		private CompilationUnit GetCompilationUnit( ObjectiveCRuntimeInfo.LibraryInfo runtimeLibraryInfo )
		{
			if( runtimeLibraryInfo.Classes.Count == 0 )
				return null;

			//			bool frameworkNeedLoading = true;
			//			if( runtimeLibraryInfo.Name == "libobjc.A.dylib" )
			//				frameworkNeedLoading = false;

			Console.WriteLine( "Processing {0}.. Generate {1} proxies from {2} classes", runtimeLibraryInfo.Name, runtimeLibraryInfo.Classes.Count, runtimeLibraryInfo.Classes.Count() );

			var result = new CompilationUnit();
			var @namespace = result.AddNamespace( "NObjective.Proxies" );

			@namespace.AddChild( new UsingDeclaration( "System" ) );
			@namespace.AddChild( new UsingDeclaration( "System.Runtime.InteropServices" ) );

			var cachedClassesType = new TypeDeclaration( Modifiers.Internal | Modifiers.Static, null ) { Name = runtimeLibraryInfo.Identifier + "CachedClasses" };
			cachedClassesType.Type = ClassType.Class;

			// load library here
			//			if( frameworkNeedLoading )
			//			{
			var loadLibrary = cachedClassesType.AddField( "int", "___lazyLoad" );
			loadLibrary.Modifier = Modifiers.Internal | Modifiers.Static;
			loadLibrary.Fields[0].Initializer = new InvocationExpression( new MemberReferenceExpression( new MemberReferenceExpression( new IdentifierExpression( "Platform" ), "NativeMethods" ), "dlopen" ), new List<Expression> { new PrimitiveExpression( runtimeLibraryInfo.Path, runtimeLibraryInfo.Path ) } );
			//			}

			@namespace.Children.AddRange( runtimeLibraryInfo.Classes.Select( x => ( INode ) GetTypeDeclaration( runtimeLibraryInfo, x, cachedClassesType, false ) ).Where( x => x != null ) );
			@namespace.Children.AddRange( runtimeLibraryInfo.Extensions.Select( x => ( INode ) GetTypeDeclaration( runtimeLibraryInfo, x, cachedClassesType, true ) ).Where( x => x != null ) );
			@namespace.AddChild( cachedClassesType );

			return result;
		}

		internal static string GetValidIdentifier( string value )
		{
			if( value.IndexOf( '%' ) == -1 )
				return value;

			return value.Replace( '%', '_' );
		}

		/// <summary>
		/// Generates TypeDeclaration using runtime and header information.
		/// </summary>
		/// <param name="runtimeClassInfo"></param>
		/// <returns></returns>
		private TypeDeclaration GetTypeDeclaration( ObjectiveCRuntimeInfo.LibraryInfo runtimeLibraryInfo, ObjectiveCRuntimeInfo.ClassInfo runtimeClassInfo, TypeDeclaration cachedClassesType, bool isExtensionClass )
		{
			//if( @runtimeClassInfo.Name != "NSFormatter" )
			//	return null;

			// find appropriate parsed class.
			var parsedClassInfo = ParsedInformation.Classes.Where( x => x.Name == runtimeClassInfo.Name ).FirstOrDefault();
			if( parsedClassInfo != null )
				parsedClassInfo.IsHandled = true;

			var nonAmbiguousClassName = GetUnambiguousNRefactoryName( runtimeClassInfo.Identifier );

			var result = new TypeDeclaration( Modifiers.Public, null );
			if( !isExtensionClass )
			{
				result.Type = ClassType.Struct;
				result.Name = runtimeClassInfo.Identifier;
				result.Modifier = Modifiers.Public;
			}
			else
			{
				result.Type = ClassType.Class;
				result.Name = string.Format( "{0}ExtensionsOf{1}", runtimeLibraryInfo.Identifier, runtimeClassInfo.Identifier );
				result.Modifier = Modifiers.Public | Modifiers.Static;

				var lazyLibraryLoad = result.AddField( "int", "___lazyLoad" );
				lazyLibraryLoad.Modifier = Modifiers.Static | Modifiers.Private;
				lazyLibraryLoad.Fields[0].Initializer = new MemberReferenceExpression( new IdentifierExpression( cachedClassesType.Name ), "___lazyLoad" );
			}

			result.Attributes = new List<AttributeSection> { new AttributeSection() { Attributes = new List<ICSharpCode.NRefactory.Ast.Attribute> { new ICSharpCode.NRefactory.Ast.Attribute( typeof( StructLayoutAttribute ).Name, new List<Expression> { new IdentifierExpression( "LayoutKind.Explicit" ) }, null ) } } };

			_generatedProxiesCount++;

			// non-vararg methods implemented through P/Invoke
			var nativeMethods = new TypeDeclaration( Modifiers.Private | Modifiers.Static, null );
			nativeMethods.Type = ClassType.Class;
			nativeMethods.Name = "NativeMethods";

			// selectors are cached to improve invocation performance and reduce marshaling overheads
			var cachedSelectors = new TypeDeclaration( Modifiers.Static | Modifiers.Internal, null ) { Name = "CachedSelectors" };
			cachedSelectors.Type = ClassType.Class;

			// cached encodings for vararg methods to reduce encoding parsing overhead
			var cachedEncodings = new TypeDeclaration( Modifiers.Static | Modifiers.Internal, null ) { Name = "CachedEncodings" };
			cachedEncodings.Type = ClassType.Class;

			// properties implemented via property-accessor class since there is no way to keep property and method with same name in single class.
			var propertyImplementation = new TypeDeclaration( Modifiers.Public, null ) { Name = "ObjectiveCPropertyImplementation" };
			propertyImplementation.Type = ClassType.Struct;

			// added base class information for weaver.
			if( !isExtensionClass )
			{
				if( runtimeClassInfo.BaseClassName != null )
					result.AddAttribute( GetAttributeName( typeof( ProxyBaseClassAttribute ).Name ), new TypeOfExpression( new TypeReference( GetUnambiguousNRefactoryName( GetValidIdentifier( runtimeClassInfo.BaseClassName ) ) ) ) );
				result.BaseTypes.Add( new TypeReference( "IEquatable", new List<TypeReference> { new TypeReference( runtimeClassInfo.Identifier ) } ) );

				// internal handle for Objective-C object.
				var handleField = result.AddField( typeof( RuntimeObject ).FullName, "Handle" );
				handleField.Modifier = Modifiers.Private;
				handleField.Attributes = new List<AttributeSection> { new AttributeSection { Attributes = new List<ICSharpCode.NRefactory.Ast.Attribute> { new ICSharpCode.NRefactory.Ast.Attribute( typeof( FieldOffsetAttribute ).Name, new List<Expression> { new PrimitiveExpression( 0, "0" ) }, null ) } } };

				// internal handle for Objective-C class object.
				var classHandleField = result.AddField( typeof( RuntimeClass ).Name, "ClassHandle" );
				classHandleField.Modifier = Modifiers.Static | Modifiers.Public | Modifiers.ReadOnly;
				classHandleField.Fields[0].Initializer = new MemberReferenceExpression( new TypeReferenceExpression( runtimeLibraryInfo.Identifier + "CachedClasses" ), runtimeClassInfo.Identifier );

				// provide GetHashCode for root Objective-C classes.
				if( runtimeClassInfo.BaseClassName == null )
				{
					var getHashCode = result.AddMethod( "GetHashCode" );
					getHashCode.TypeReference = new TypeReference( "int" );
					getHashCode.Modifier = Modifiers.Public | Modifiers.Override;
					getHashCode.Body.AddChild( new ReturnStatement( new InvocationExpression( new MemberReferenceExpression( new IdentifierExpression( "Handle" ), "GetHashCode" ) ) ) );
				}
				// need to generate implicit conversions to all base classes.
#if !USE_VALUE_TYPE_INHERITANCE
				else
				{
					var baseName = runtimeClassInfo.BaseClassName;

					while( baseName != null )
					{
						var currentClass = ClassesToExport[baseName];

						var baseConversion = result.AddImplicitConversionOperator( GetUnambiguousNRefactoryName( currentClass.Identifier ) );
						baseConversion.Parameters[0].TypeReference.Type = GetUnambiguousNRefactoryName( runtimeClassInfo.Identifier );
						baseConversion.Body.AddChild( new ReturnStatement( new ObjectCreateExpression( new TypeReference( GetUnambiguousNRefactoryName( currentClass.Identifier ) ), new List<Expression> { new MemberReferenceExpression( new IdentifierExpression( "value" ), "Handle" ) } ) ) );

						baseName = currentClass.BaseClassName;
					}
#endif
				}

				// implicit conversion to System.IntPtr
				var intptr = result.AddImplicitConversionOperator( "IntPtr" );
				intptr.Parameters[0].TypeReference.Type = nonAmbiguousClassName;
				intptr.Body.AddChild( new ReturnStatement( new MemberReferenceExpression( new IdentifierExpression( "value" ), "Handle" ) ) );

				// implicit conversion to RuntimeObject
				var objectHandle = result.AddImplicitConversionOperator( typeof( RuntimeObject ).FullName );
				objectHandle.Parameters[0].TypeReference.Type = nonAmbiguousClassName;
				objectHandle.Body.AddChild( new ReturnStatement( new MemberReferenceExpression( new IdentifierExpression( "value" ), "Handle" ) ) );

				// override System.Object.Equals( object obj )
				{
					var equals = result.AddMethod( "Equals" );
					equals.TypeReference = new TypeReference( "bool" );
					equals.Modifier = Modifiers.Public | Modifiers.Override;
					equals.AddParameter( "value", "object" );

					var localVariableStatement = new LocalVariableDeclaration( new TypeReference( "var" ) );
					var compareToVariable = new VariableDeclaration( "compareTo", new CastExpression( new TypeReference( nonAmbiguousClassName + "?" ), new IdentifierExpression( "value" ), CastType.TryCast ) );
					localVariableStatement.Variables.Add( compareToVariable );
					equals.Body.AddChild( localVariableStatement );

					equals.Body.AddChild( new ReturnStatement( new BinaryOperatorExpression( new BinaryOperatorExpression( new IdentifierExpression( compareToVariable.Name ), BinaryOperatorType.InEquality, new PrimitiveExpression( null, null ) ), BinaryOperatorType.LogicalAnd, new BinaryOperatorExpression( new IdentifierExpression( "Handle" ), BinaryOperatorType.Equality, new MemberReferenceExpression( new MemberReferenceExpression( new IdentifierExpression( compareToVariable.Name ), "Value" ), "Handle" ) ) ) ) );
				}

				// imlement IEquatable<T>.Equals( T obj )
				{
					var equals = result.AddMethod( "Equals" );
					equals.TypeReference = new TypeReference( "bool" );
					equals.Modifier = Modifiers.Public;
					equals.AddParameter( "value", nonAmbiguousClassName );
					equals.Body.AddChild( new ReturnStatement( new BinaryOperatorExpression( new IdentifierExpression( "Handle" ), BinaryOperatorType.Equality, new MemberReferenceExpression( new IdentifierExpression( "value" ), "Handle" ) ) ) );
				}

				// implement bool operator ==( T value1, T value2 )
				var equalityOperator = result.AddOperator( OverloadableOperatorType.Equality );
				equalityOperator.Parameters[0].TypeReference.Type = nonAmbiguousClassName;
				equalityOperator.Parameters[1].TypeReference.Type = nonAmbiguousClassName;
				equalityOperator.Body.AddChild( new ReturnStatement( new BinaryOperatorExpression( new MemberReferenceExpression( new IdentifierExpression( "value1" ), "Handle" ), BinaryOperatorType.Equality, new MemberReferenceExpression( new IdentifierExpression( "value2" ), "Handle" ) ) ) );
				equalityOperator.TypeReference = new TypeReference( "bool" );

				// implement bool operator !=( T value1, T value2 )
				var inequalityOperator = result.AddOperator( OverloadableOperatorType.InEquality );
				inequalityOperator.Parameters[0].TypeReference.Type = nonAmbiguousClassName;
				inequalityOperator.Parameters[1].TypeReference.Type = nonAmbiguousClassName;
				inequalityOperator.Body.AddChild( new ReturnStatement( new BinaryOperatorExpression( new MemberReferenceExpression( new IdentifierExpression( "value1" ), "Handle" ), BinaryOperatorType.InEquality, new MemberReferenceExpression( new IdentifierExpression( "value2" ), "Handle" ) ) ) );
				inequalityOperator.TypeReference = new TypeReference( "bool" );

				// constructor T( IntPtr value )
				var ctor = result.AddConstructor( new ParameterDeclarationExpression( new TypeReference( "IntPtr" ), "value" ) );
				ctor.Body.AddChild( new ExpressionStatement( new AssignmentExpression( new MemberReferenceExpression( new ThisReferenceExpression(), "Handle" ), AssignmentOperatorType.Assign, new ObjectCreateExpression( new TypeReference( typeof( RuntimeObject ).Name ), new List<Expression> { new IdentifierExpression( "value" ) } ) ) ) );

				// alloc method that return same type: static T alloc()
				var allocMethod = result.AddMethod( "alloc" );
				allocMethod.TypeReference = new TypeReference( runtimeClassInfo.Identifier );
				allocMethod.Modifier = Modifiers.Public | Modifiers.Static;
				allocMethod.Body.AddChild( new ReturnStatement( new ObjectCreateExpression( new TypeReference( nonAmbiguousClassName ), new List<Expression> { new InvocationExpression( new MemberReferenceExpression( new IdentifierExpression( "ClassHandle" ), "InvokeIntPtr" ), new List<Expression> { new MemberReferenceExpression( new IdentifierExpression( "Selectors" ), "alloc" ) } ) } ) ) );

				// provide ToString for root Objective-C classes.
				if( runtimeClassInfo.BaseClassName == null )
				{
					// [object description] ==> ToString 
					var toString = result.AddMethod( "ToString" );
					toString.TypeReference = new TypeReference( "string" );
					toString.Modifier = Modifiers.Public | Modifiers.Override;
					toString.Body.AddChild( new ReturnStatement( new InvocationExpression( new MemberReferenceExpression( new IdentifierExpression( "Handle" ), "InvokeString" ), new List<Expression> { new MemberReferenceExpression( new IdentifierExpression( "Selectors" ), "description" ) } ) ) );
				}
			}

			// generate static methods bodies.
			var classMethods = runtimeClassInfo.ClassMethods.OrderBy( x => x.Name ).Select( x => ( INode ) GetMethodDeclaration( runtimeClassInfo, parsedClassInfo, MethodType.Class, x, cachedSelectors, cachedEncodings, nativeMethods, isExtensionClass ) ).Where( x => x != null ).ToArray();
			_generatedMethodsCount += classMethods.Length;

			// generate instance methods bodies.
			var instanceMethods = runtimeClassInfo.InstanceMethods.OrderBy( x => x.Name ).Select( x => ( INode ) GetMethodDeclaration( runtimeClassInfo, parsedClassInfo, MethodType.Instance, x, cachedSelectors, cachedEncodings, nativeMethods, isExtensionClass ) ).Where( x => x != null ).ToArray();
			_generatedMethodsCount += instanceMethods.Length;

			// generate properties.
			var properties = runtimeClassInfo.Properties.OrderBy( x => x.Name ).Select( x => ( INode ) GetPropertyDeclaration( runtimeClassInfo, parsedClassInfo, x ) ).Where( x => x != null ).ToArray();
			_generatedPropertiesCount += properties.Length;

			result.Children.AddRange( classMethods );
			result.Children.AddRange( instanceMethods );
			propertyImplementation.Children.AddRange( properties );

			// if there are properties then we should create appropriate accessors.
			if( propertyImplementation.Children.Count > 0 )
			{
				propertyImplementation.AddField( new TypeReference( result.Name ), "_handle" ).Modifier = Modifiers.Private | Modifiers.ReadOnly;

				var propertyCtor = propertyImplementation.AddConstructor( new ParameterDeclarationExpression( new TypeReference( result.Name ), "value" ) );
				propertyCtor.Body.AddChild( new ExpressionStatement( new AssignmentExpression( new IdentifierExpression( "_handle" ), AssignmentOperatorType.Assign, new IdentifierExpression( "value" ) ) ) );

				result.AddChild( propertyImplementation );

				var propertyAccessor = result.AddProperty( "Properties" );
				propertyAccessor.TypeReference = new TypeReference( propertyImplementation.Name );
				propertyAccessor.GetRegion = new PropertyGetRegion( new BlockStatement(), null );

				propertyAccessor.GetRegion.Block.AddChild( new ReturnStatement( new ObjectCreateExpression( new TypeReference( propertyImplementation.Name ), new List<Expression> { new ThisReferenceExpression() } ) ) );
			}

			// if there are native methods then add them.
			if( nativeMethods.Children.Count > 0 )
			{
				nativeMethods.Children = nativeMethods.Children.Cast<MethodDeclaration>().OrderBy( x => x.Name ).Cast<INode>().ToList();
				result.AddChild( nativeMethods );
			}

			// if there are cached encodings then add them.
			if( cachedEncodings.Children.Count > 0 )
			{
				cachedEncodings.Children = cachedEncodings.Children.Cast<FieldDeclaration>().OrderBy( x => x.Fields[0].Name ).Cast<INode>().ToList();
				result.AddChild( cachedEncodings );
			}

			// if there are cached selectors then add them.
			if( cachedSelectors.Children.Count > 0 )
			{
				cachedSelectors.Children = cachedSelectors.Children.Cast<FieldDeclaration>().OrderBy( x => x.Fields[0].Name ).Cast<INode>().ToList();
				result.AddChild( cachedSelectors );
			}

			// add cached classes entry
			{
				var classField = cachedClassesType.AddField( "RuntimeClass", runtimeClassInfo.Identifier );
				classField.Fields[0].Initializer = new PrimitiveExpression( runtimeClassInfo.Name, runtimeClassInfo.Name );
				classField.Modifier = Modifiers.Static | Modifiers.Public | Modifiers.ReadOnly;
			}

			return result;
		}

		/// <summary>
		/// Generates property body.
		/// </summary>
		/// <param name="runtimeClassInfo"></param>
		/// <param name="parsedClassInfo"></param>
		/// <param name="property"></param>
		/// <returns></returns>
		private PropertyDeclaration GetPropertyDeclaration( ObjectiveCRuntimeInfo.ClassInfo runtimeClassInfo, ObjectiveCParsedInfo.ClassInfo parsedClassInfo, ObjectiveCRuntimeInfo.PropertyInfo property )
		{
			var result = new PropertyDeclaration( Modifiers.Public, null, property.Name, null ); ;

			var settingProperty = parsedClassInfo != null ? parsedClassInfo.Properties.FirstOrDefault( x => x.Name == property.Name ) : null;
			var encoding = new RuntimePropertyEncoding( property.Encoding );

			var setterName = "set" + char.ToUpper( property.Name[0] ) + property.Name.Substring( 1 );
			var getterName = property.Name;

			// getter/setter names from Objective-C introspection.
			getterName = encoding.Getter ?? getterName;
			setterName = encoding.Setter ?? setterName;

			// getter/setter names from headers.
			if( settingProperty != null )
			{
				getterName = settingProperty.Getter ?? getterName;
				setterName = settingProperty.Setter ?? setterName;
			}

			setterName = setterName.Replace( ':', '_' );

			// find appropriate getter method to retrieve return type from.
			foreach( var @class in GetBaseHierarchy( ClassesToExport, runtimeClassInfo ).Where( x => x.InstanceMethods.Any( y => y.Name == getterName ) ) )
			{
				var runtimeGetterMethod = @class.InstanceMethods.First( x => x.Name == getterName );
				var methodDeclaration = GetMethodDeclaration( @class, ParsedInformation.Classes.Where( x => x.Name == runtimeClassInfo.Name ).FirstOrDefault(), MethodType.Instance, runtimeGetterMethod, null, null, null, true );

				if( methodDeclaration == null )
					continue;

				var methodInvocationExpression = ( Expression ) new IdentifierExpression( "_handle" );

				// if found in base class then convert type.
				if( runtimeClassInfo.Name != @class.Name )
					methodInvocationExpression = new ObjectCreateExpression( new TypeReference( @class.Name ), new List<Expression> { methodInvocationExpression } );

				methodInvocationExpression = new MemberReferenceExpression( methodInvocationExpression, getterName );

				result.GetRegion = new PropertyGetRegion( new BlockStatement(), null );
				result.GetRegion.Block.AddChild( new ReturnStatement( new InvocationExpression( methodInvocationExpression ) ) );

				result.TypeReference = methodDeclaration.TypeReference;
				break;
			}

			// find appropriate setter method to retrieve type of first parameter from.
			foreach( var @class in GetBaseHierarchy( ClassesToExport, runtimeClassInfo ).Where( x => x.InstanceMethods.Any( y => y.Name == setterName ) ) )
			{
				var runtimeGetterMethod = @class.InstanceMethods.First( x => x.Name == setterName );
				var methodDeclaration = GetMethodDeclaration( @class, ParsedInformation.Classes.Where( x => x.Name == runtimeClassInfo.Name ).FirstOrDefault(), MethodType.Instance, runtimeGetterMethod, null, null, null, true );

				if( methodDeclaration == null )
					continue;

				var methodInvocationExpression = ( Expression ) new IdentifierExpression( "_handle" );

				// if found in base class then convert type.
				if( runtimeClassInfo.Name != @class.Name )
					methodInvocationExpression = new ObjectCreateExpression( new TypeReference( @class.Name ), new List<Expression> { methodInvocationExpression } );

				methodInvocationExpression = new MemberReferenceExpression( methodInvocationExpression, setterName );

				result.SetRegion = new PropertySetRegion( new BlockStatement(), null );
				result.SetRegion.Block.AddChild( new InvocationExpression( methodInvocationExpression, new List<Expression> { new IdentifierExpression( "value" ) } ) );

				result.TypeReference = result.TypeReference ?? methodDeclaration.Parameters[0].TypeReference;
				break;
			}

			// can't retrieve neccessary information.
			if( ( result.GetRegion == PropertyGetRegion.Null && result.SetRegion != PropertySetRegion.Null ) || result.TypeReference == TypeReference.Null )
				return null;

			return result;
		}

		/// <summary>
		/// Generates method body.
		/// </summary>
		/// <param name="runtimeClassInfo"></param>
		/// <param name="parsedClassInfo"></param>
		/// <param name="methodType"></param>
		/// <param name="runtimeMethodInfo"></param>
		/// <param name="cachedSelectors"></param>
		/// <param name="cachedEncodings"></param>
		/// <param name="nativeMethods"></param>
		/// <returns></returns>
		private MethodDeclaration GetMethodDeclaration( ObjectiveCRuntimeInfo.ClassInfo runtimeClassInfo, ObjectiveCParsedInfo.ClassInfo parsedClassInfo, MethodType methodType, ObjectiveCRuntimeInfo.MethodInfo runtimeMethodInfo, TypeDeclaration cachedSelectors, TypeDeclaration cachedEncodings, TypeDeclaration nativeMethods, bool isExtensionMethod )
		{
			var methodName = runtimeMethodInfo.Name;
			//if( methodName != "isPartialStringValid:proposedSelectedRange:originalString:originalSelectedRange:errorDescription:" )
			//	return null;

			var parsedMethodName = ( methodType == MethodType.Class ? '+' : '-' ) + methodName;
			var methodNativeEncoding = runtimeMethodInfo.Encoding;

			// method is already in base type. But if it has another encoding..
			if( GetBaseHierarchy( ClassesToExport, runtimeClassInfo ).Skip( 1 ).SelectMany( x => ( methodType == MethodType.Class ? x.ClassMethods : x.InstanceMethods ) ).Any( x => x.Name == methodName && x.Encoding == methodNativeEncoding ) )
				return null;

			// can not define instance+static methods with same signature
			if( methodType == MethodType.Class )
				if( runtimeClassInfo.InstanceMethods.Any( x => x.Name == methodName ) )
					methodName = "__" + methodName;

			var parsedMethodInfo = parsedClassInfo != null ? parsedClassInfo.Methods.Where( x => x.Method == parsedMethodName ).FirstOrDefault() : null;

			if( parsedMethodInfo != null )
				parsedMethodInfo.IsHandled = true;

			var isReturnTypeParsed = parsedMethodInfo != null && parsedMethodInfo.Result != null;
			var splittedSelector = methodName.Split( new[] { ':' } );

			var encoding = new RuntimeMethodEncoding( methodNativeEncoding );

			// skip methods with undeterminable parameters
			bool hasUndeterminableParameters = false;
			for( int undefinedTypeCounter = 0; undefinedTypeCounter < encoding.Types.Length - 3; undefinedTypeCounter++ )
			{
				if( encoding.Types[undefinedTypeCounter + 3] != null )
					continue;

				if( parsedMethodInfo != null )
				{
					var parameter = parsedMethodInfo.Parameters.FirstOrDefault( x => x.Index == undefinedTypeCounter );
					if( parameter != null && !string.IsNullOrEmpty( parameter.Type ) )
						continue;
				}

				hasUndeterminableParameters = true;
				break;
			}

			if( hasUndeterminableParameters )
			{
				Tracer.Information( @"Rejected: class ""{1}"" method ""{0}"" encoding ""{2}""", methodName, runtimeClassInfo.Name, encoding.Encoding );
				return null;
			}

			// void foo( some_type firstArgumentName )
			// -(void) foo:(some_type) firstArgumentName;
			var firstArgumentName = new StringBuilder( methodName.Length );

			// -(void) loadXML:(some_type) xml;
			bool abbreviation = char.IsUpper( splittedSelector[0][splittedSelector[0].Length - 1] );

			for( int i = splittedSelector[0].Length - 1; i >= 0; i-- )
			{
				firstArgumentName.Insert( 0, char.ToLower( splittedSelector[0][i] ) );

				if( abbreviation ^ char.IsUpper( splittedSelector[0][i] ) )
				{
					if( abbreviation )
						firstArgumentName.Remove( 0, 1 );

					break;
				}
			}

			var returnType = encoding.Types[0];

			// unknown structs now cannot be returned.
			if( returnType == null && ( parsedMethodInfo == null || !ParsedInformation.Structs.Any( x => x.Name == parsedMethodInfo.Result ) ) )
				return null;

			if( returnType != null && returnType.IsPointer )
				returnType = typeof( IntPtr );

			// create Method
			var method = new MethodDeclaration();
			method.Name = methodName.Replace( ':', '_' );
			method.Modifier = Modifiers.Public;
			method.Body = new BlockStatement();
			method.IsExtensionMethod = isExtensionMethod && methodType == MethodType.Instance;

			var parameters = new List<ParameterDeclarationExpression>();

			if( methodType == MethodType.Class || isExtensionMethod )
				method.Modifier |= Modifiers.Static;

			// set name for unnamed parameters, set parameter types from introspection information.
			for( var i = 3; i < encoding.Types.Length; i++ )
			{
				var parameterName = i == 3 ? firstArgumentName.ToString() : String.IsNullOrEmpty( splittedSelector[i - 3] ) ? "unnamedParameter" : splittedSelector[i - 3];
				var parameterType = encoding.Types[i];
				var parameterTypeString = "";

				// mapped from settings
				if( parameterType != null )
				{
					if( parameterType.IsPointer )
						parameterType = typeof( IntPtr );

					parameterTypeString = MapToKeywordType( parameterType );
				}

				parameters.Add( method.AddParameter( parameterName, parameterTypeString ) );
			}

			//for( var i = 0; i < parameters.Count; i++ )
			//	if( String.IsNullOrEmpty( parameters[i].ParameterName ) )
			//		parameters[i].ParameterName = "argument" + i;

			// add vararg parameter
			if( isReturnTypeParsed && parsedMethodInfo.IsVararg )
				parameters.Add( method.AddParameter( "variableArguments", "params object[]" ) );

			// check that parameters have unique name.
			for( var i = 0; i < parameters.Count - 1; i++ )
				for( var j = i + 1; j < parameters.Count; j++ )
				{
					if( parameters[j].ParameterName != parameters[i].ParameterName )
						continue;

					if( !char.IsDigit( parameters[j].ParameterName[parameters[j].ParameterName.Length - 1] ) )
						parameters[j].ParameterName += "2";
					else
					{
						var match = Regex.Match( parameters[j].ParameterName, "^(.*)(\\d)$" );
						parameters[j].ParameterName = match.Groups[1].ToString() + ( int.Parse( match.Groups[2].ToString() ) + 1 );
					}
				}

			// set parameter type and name from settings file.
			if( parsedMethodInfo != null )
				foreach( var settingsParameter in parsedMethodInfo.Parameters.Where( x => x.Type != null ) )
				{
					var mappedParameter = parameters[settingsParameter.Index];
					//var platformType = MapFromKeywordType( settingsParameter.Type );

					//if( platformType != null )
					//	mappedParameter.TypeReference = new TypeReference( settingsParameter.Type );
					//else 
					if( settingsParameter.Type != null )
						mappedParameter.TypeReference = new TypeReference( settingsParameter.Type );

					if( ( settingsParameter.Modifiers & ObjectiveCParsedInfo.ClassInfo.MethodInfo.ParameterInfo.ParameterModifiers.Ref ) != 0 )
						mappedParameter.ParamModifier |= ParameterModifiers.Ref;

					if( ( settingsParameter.Modifiers & ObjectiveCParsedInfo.ClassInfo.MethodInfo.ParameterInfo.ParameterModifiers.Out ) != 0 )
						mappedParameter.ParamModifier |= ParameterModifiers.Out;

					settingsParameter.IsHandled = true;
				}

			// is mapping performed by common naming pattern
			var objectAutomappingPerformed = false;

			// automatic return type mapping by common method name
			if( methodType == MethodType.Instance )
			{
				switch( methodName )
				{
					case "stringValue":
					case "description":
						returnType = typeof( string );
						break;

					case "boolValue":
						returnType = typeof( bool );
						break;

					case "encodeWithCoder:":
						parameters[0].TypeReference = new TypeReference( "NSCoder" );
						break;
				}
			}
			// bool value = [self isSomething]
			var booleanMethodsStartsWith = new[] { "is", "should", "matches" };
			foreach( var prefix in booleanMethodsStartsWith )
				if( methodName.StartsWith( prefix ) && methodName.Length > prefix.Length && char.IsUpper( methodName[prefix.Length] ) && returnType == typeof( char ) )
					returnType = typeof( bool );

			// non generated struct
			if( returnType != null )
				method.TypeReference = new TypeReference( returnType.FullName );

			// automatic return type mapping by Cocoa common naming pattern, like: @class NSYo --> [NSYo yoWithInt:10] have type of NSYo
			if( returnType != typeof( void ) )
			{
				string autoMappedReturnType = null;

				if( methodType == MethodType.Class && methodName == "alloc" )
					autoMappedReturnType = runtimeClassInfo.Identifier;

				if( autoMappedReturnType == null && runtimeClassInfo.Name.StartsWith( "NS" ) )
				{
					var classNameUsedInInitialization = runtimeClassInfo.Name.Substring( 2 );
					classNameUsedInInitialization = char.ToLower( classNameUsedInInitialization[0] ) + classNameUsedInInitialization.Substring( 1 );

					if( methodType == MethodType.Class && methodName.StartsWith( classNameUsedInInitialization + "With" ) )
						autoMappedReturnType = runtimeClassInfo.Identifier;

					if( methodType == MethodType.Instance && methodName.StartsWith( "init" ) )
						autoMappedReturnType = runtimeClassInfo.Identifier;

					if( methodName.EndsWith( "WithBool:" ) && encoding.Types.Length > 2 && encoding.Types[2] == typeof( sbyte ) )
						parameters[0].TypeReference = new TypeReference( "bool" );
				}

				if( autoMappedReturnType != null )
					method.TypeReference = new TypeReference( autoMappedReturnType );

				objectAutomappingPerformed |= autoMappedReturnType != null;
			}

			if( isReturnTypeParsed )
			{
				var platformType = MapFromKeywordType( parsedMethodInfo.Result );

				if( platformType != null )
				{
					returnType = platformType;
					method.TypeReference = new TypeReference( returnType.FullName );
				}
				else
					method.TypeReference = new TypeReference( parsedMethodInfo.Result );
			}

			//if( manualMappingPerformed )
			//	method.AddSummary( setingsMethod.Summary );

			// add cached selector
			if( cachedSelectors != null )
			{
				var selectorField = cachedSelectors.AddField( "Selector", methodName.Replace( ':', '_' ) );
				selectorField.Fields[0].Initializer = new PrimitiveExpression( methodName, methodName );
				selectorField.Modifier = Modifiers.Static | Modifiers.Public | Modifiers.ReadOnly;
			}

			Expression callTargetExpression;
			if( isExtensionMethod )
			{
				if( methodType == MethodType.Class )
					callTargetExpression = new MemberReferenceExpression( new IdentifierExpression( runtimeClassInfo.Identifier ), "ClassHandle" );
				else
					callTargetExpression = new IdentifierExpression( "___this" );
			}
			else if( methodType == MethodType.Class )
				callTargetExpression = new IdentifierExpression( "ClassHandle" );
			else
				callTargetExpression = new IdentifierExpression( "Handle" );

			if( parsedMethodInfo == null || !parsedMethodInfo.IsVararg )
			{
				if( nativeMethods != null )
				{
					method.Modifier |= Modifiers.Unsafe;

					var nativeMethod = nativeMethods.AddMethod( method.Name );
					nativeMethod.Body = BlockStatement.Null;
					nativeMethod.Modifier = Modifiers.Static | Modifiers.Extern | Modifiers.Public;
					nativeMethod.TypeReference = new TypeReference( returnType == null ? "void" : MapToKeywordType( returnType ) );

					var entryPoint = nativeMethod.TypeReference.SystemType == "System.Single" || nativeMethod.TypeReference.SystemType == "System.Double" ? "objc_msgSend_fpret_eh2" : "objc_msgSend_eh2";
					if( returnType == null )
						entryPoint = "objc_msgSend_stret_eh2";

					nativeMethod.AddAttribute( "DllImport", new[] { new MemberReferenceExpression( new IdentifierExpression( "Runtime" ), "InteropLibrary" ) }, new NamedArgumentExpression( "EntryPoint", new PrimitiveExpression( entryPoint, null ) ) );
					if( returnType == typeof( string ) || returnType == typeof( RuntimeObject ) || ClassesToExport.ContainsKey( method.TypeReference.Type ) )
						nativeMethod.TypeReference.Type = "IntPtr";

					if( returnType == null )
					{
						nativeMethod.AddParameter( "___structAddress", parsedMethodInfo.Result ).ParamModifier = ParameterModifiers.Out;
						nativeMethod.AddParameter( "___structSize", "int" );
					}

					if( methodType == MethodType.Class )
						nativeMethod.AddParameter( "___class", typeof( RuntimeClass ).Name );
					else
						nativeMethod.AddParameter( "___object", typeof( RuntimeObject ).Name );
					nativeMethod.AddParameter( "___selector", typeof( Selector ).Name );
					nativeMethod.AddParameter( "___occuredException", typeof( RuntimeObject ).Name ).ParamModifier = ParameterModifiers.Out;
					nativeMethod.AddParameter( "___stackSize", "int" );

					var nativeMethodInvocationParameters = new List<Expression>();
					if( returnType == null )
					{
						var resultFromNative = new VariableDeclaration( "___result", Expression.Null, new TypeReference( parsedMethodInfo.Result ) );
						method.Body.AddChild( new LocalVariableDeclaration( resultFromNative ) );

						nativeMethodInvocationParameters.Add( new DirectionExpression( ICSharpCode.NRefactory.Ast.FieldDirection.Out, new IdentifierExpression( "___result" ) ) );
						nativeMethodInvocationParameters.Add( new SizeOfExpression( new TypeReference( parsedMethodInfo.Result ) ) );
					}

					nativeMethodInvocationParameters.Add( callTargetExpression );

					nativeMethodInvocationParameters.Add( new MemberReferenceExpression( new IdentifierExpression( "CachedSelectors" ), methodName.Replace( ':', '_' ) ) );
					nativeMethodInvocationParameters.Add( new DirectionExpression( ICSharpCode.NRefactory.Ast.FieldDirection.Out, new IdentifierExpression( "___occuredException" ) ) );
					nativeMethodInvocationParameters.Add( Expression.Null );
					var stackSizeExpression = Expression.Null;
					var releaseStatements = new List<Statement>();

					method.Body.AddChild( new LocalVariableDeclaration( new VariableDeclaration( "___occuredException", Expression.Null, new TypeReference( typeof( RuntimeObject ).Name ) ) ) );
					// prepare parameters
					foreach( var methodParameter in method.Parameters )
					{
						var parameterType = methodParameter.TypeReference.Type;
						var argumentName = methodParameter.ParameterName;

						if( parameterType == "string" )
						{
							parameterType = "IntPtr";
							argumentName = "___wrapped" + methodParameter.ParameterName;

							var initializer = ( Expression ) new InvocationExpression( new MemberReferenceExpression( new IdentifierExpression( typeof( Runtime ).Name ), "CreateStringProxy" ), new List<Expression> { new IdentifierExpression( methodParameter.ParameterName ) } );
							if( ( methodParameter.ParamModifier & ParameterModifiers.Out ) != 0 )
								initializer = Expression.Null;

							method.Body.AddChild( new LocalVariableDeclaration( new VariableDeclaration( "___wrapped" + methodParameter.ParameterName, initializer, new TypeReference( "var" ) ) ) );

							if( ( methodParameter.ParamModifier & ( ParameterModifiers.Ref | ParameterModifiers.Out ) ) != 0 )
								releaseStatements.Add( new ExpressionStatement( new AssignmentExpression( new IdentifierExpression( methodParameter.ParameterName ), AssignmentOperatorType.Assign, new InvocationExpression( new MemberReferenceExpression( new IdentifierExpression( "Runtime" ), "UnwrapNSString" ), new List<Expression> { new IdentifierExpression( "___wrapped" + methodParameter.ParameterName ) } ) ) ) );

							releaseStatements.Add( new ExpressionStatement( new InvocationExpression( new MemberReferenceExpression( new IdentifierExpression( typeof( Runtime ).Name ), "ReleaseNativeObject" ), new List<Expression> { new IdentifierExpression( argumentName ) } ) ) );
						}

						var passParameterExpression = ( Expression ) new IdentifierExpression( argumentName );

						if( ( methodParameter.ParamModifier & ParameterModifiers.Ref ) != 0 )
						{
							passParameterExpression = new DirectionExpression( ICSharpCode.NRefactory.Ast.FieldDirection.Ref, passParameterExpression );
							nativeMethod.AddParameter( methodParameter.ParameterName, "ref " + parameterType );
						}
						else if( ( methodParameter.ParamModifier & ParameterModifiers.Out ) != 0 )
						{
							passParameterExpression = new DirectionExpression( ICSharpCode.NRefactory.Ast.FieldDirection.Out, passParameterExpression );
							nativeMethod.AddParameter( methodParameter.ParameterName, "out " + parameterType );
						}
						else
							nativeMethod.AddParameter( methodParameter.ParameterName, parameterType );

						nativeMethodInvocationParameters.Add( passParameterExpression );

						if( parameterType.EndsWith( "[]" ) || ( methodParameter.ParamModifier & ( ParameterModifiers.Ref | ParameterModifiers.Out ) ) != 0 )
							parameterType = "IntPtr";

						if( stackSizeExpression != Expression.Null )
							stackSizeExpression = new BinaryOperatorExpression( stackSizeExpression, BinaryOperatorType.Add, new SizeOfExpression( new TypeReference( parameterType ) ) );
						else
							stackSizeExpression = new SizeOfExpression( new TypeReference( parameterType ) );

					}
					if( stackSizeExpression == Expression.Null )
						stackSizeExpression = new PrimitiveExpression( 0, null );

					nativeMethodInvocationParameters[returnType == null ? 5 : 3] = stackSizeExpression;

					// call method
					var nativeMethodCall = new InvocationExpression( new MemberReferenceExpression( new IdentifierExpression( "NativeMethods" ), method.Name ), nativeMethodInvocationParameters );

					if( returnType != typeof( void ) && returnType != null )
					{
						var resultFromNative = new VariableDeclaration( "___result", nativeMethodCall, new TypeReference( "var" ) );
						method.Body.AddChild( new LocalVariableDeclaration( resultFromNative ) );
					}
					else
						method.Body.AddChild( new ExpressionStatement( nativeMethodCall ) );

					// release arguments
					foreach( var releaseStatement in releaseStatements )
						method.Body.Children.Add( releaseStatement );

					// check exception
					method.Body.AddChild( new IfElseStatement( new BinaryOperatorExpression( new IdentifierExpression( "___occuredException" ), BinaryOperatorType.InEquality, new MemberReferenceExpression( new IdentifierExpression( typeof( RuntimeObject ).Name ), "Null" ) ), new ThrowStatement( new InvocationExpression( new MemberReferenceExpression( new IdentifierExpression( "RuntimeException" ), "Create" ), new List<Expression> { new IdentifierExpression( "___occuredException" ) } ) ) ) );

					if( returnType != typeof( void ) || returnType == null )
					{
						var returnExpression = ( Expression ) new IdentifierExpression( "___result" );

						if( ClassesToExport.ContainsKey( method.TypeReference.Type ) || returnType == typeof( RuntimeObject ) )
						{
							if( returnType != typeof( RuntimeObject ) )
								returnExpression = new CastExpression( new TypeReference( "IntPtr" ), returnExpression, CastType.Cast );

							returnExpression = new ObjectCreateExpression( new TypeReference( method.TypeReference.Type ), new List<Expression> { returnExpression } );
						}
						else if( ParsedInformation.Enums.Any( x => x.Name == method.TypeReference.Type ) )
							returnExpression = new CastExpression( new TypeReference( method.TypeReference.Type ), returnExpression, CastType.Cast );
						else if( returnType == typeof( uint ) && method.TypeReference.Type != "uint" )
							returnExpression = new CastExpression( new TypeReference( method.TypeReference.Type ), returnExpression, CastType.Cast );
						else if( returnType == typeof( string ) )
							returnExpression = new InvocationExpression( new MemberReferenceExpression( new IdentifierExpression( typeof( Runtime ).Name ), "UnwrapNSString" ), new List<Expression> { new IdentifierExpression( "___result" ) } );

						method.Body.AddChild( new ReturnStatement( returnExpression ) );
					}
				}
			}
			else
			{
				var encodingFieldName = "__" + encoding.Encoding.GetHashCode().ToString( "X8" );

				// add cached encoding
				if( cachedEncodings != null && !cachedEncodings.Children.OfType<ICSharpCode.NRefactory.Ast.FieldDeclaration>().Any( x => x.Fields[0].Name == encodingFieldName ) )
				{
					var encodingField = cachedEncodings.AddField( "RuntimeMethodEncoding", encodingFieldName );
					encodingField.Fields[0].Initializer = new PrimitiveExpression( encoding.Encoding, encoding.Encoding );
					encodingField.Modifier = Modifiers.Static | Modifiers.Public | Modifiers.ReadOnly;
				}

				var invokationMethodName = "UndefinedInvoke";

				if( returnType == typeof( string ) )
					invokationMethodName = "InvokeStringFast";
				else if( objectAutomappingPerformed )
					invokationMethodName = "InvokeIntPtrFast";
				else if( returnType == typeof( IntPtr ) )
					invokationMethodName = "InvokeIntPtrFast";
				else if( returnType == typeof( Selector ) )
					invokationMethodName = "InvokeSelectorFast";
				else if( returnType == typeof( void ) )
					invokationMethodName = "InvokeVoidFast";
				else if( returnType == typeof( char ) )
					invokationMethodName = "InvokeCharFast";
				else if( returnType == typeof( float ) )
					invokationMethodName = "InvokeFloatFast";
				else if( returnType == typeof( double ) )
					invokationMethodName = "InvokeDoubleFast";
				else if( returnType == typeof( bool ) )
					invokationMethodName = "InvokeBoolFast";
				else if( returnType == typeof( sbyte ) )
					invokationMethodName = "InvokeInt8Fast";
				else if( returnType == typeof( byte ) )
					invokationMethodName = "InvokeUInt8Fast";
				else if( returnType == typeof( short ) )
					invokationMethodName = "InvokeInt16Fast";
				else if( returnType == typeof( ushort ) )
					invokationMethodName = "InvokeUInt16Fast";
				else if( returnType == typeof( int ) )
					invokationMethodName = "InvokeInt32Fast";
				else if( returnType == typeof( uint ) )
					invokationMethodName = "InvokeUInt32Fast";
				else if( returnType == typeof( long ) )
					invokationMethodName = "InvokeInt64Fast";
				else if( returnType == typeof( ulong ) )
					invokationMethodName = "InvokeUInt64Fast";
				else if( returnType == typeof( RuntimeObject ) )
					invokationMethodName = "InvokeObjectFast";
				else if( returnType == typeof( RuntimeClass ) )
					invokationMethodName = "InvokeClassFast";
				else if( parsedMethodInfo.Result != null )
					invokationMethodName = "InvokeStruct<" + parsedMethodInfo.Result + ">";

				var invocationParameters = new List<Expression>();
				invocationParameters.Add( new MemberReferenceExpression( new IdentifierExpression( "CachedSelectors" ), methodName.Replace( ':', '_' ) ) );

				// add encoding to non-struct returning invocations
				if( returnType != null )
					invocationParameters.Add( new IdentifierExpression( "CachedEncodings.__" + runtimeMethodInfo.Encoding.GetHashCode().ToString( "X8" ) ) );

				invocationParameters.AddRange( parameters.Select( x => ( Expression ) new IdentifierExpression( x.ParameterName ) ) );

				var invokeExpression = new InvocationExpression( new MemberReferenceExpression( callTargetExpression, invokationMethodName ), invocationParameters );

				if( returnType == typeof( void ) )
					method.Body.AddChild( new ExpressionStatement( invokeExpression ) );
				else if( objectAutomappingPerformed )
				{
					if( returnType == typeof( string ) )
						method.Body.AddChild( new ReturnStatement( invokeExpression ) );
					else
						method.Body.AddChild( new ReturnStatement( new ObjectCreateExpression( method.TypeReference, new List<Expression> { invokeExpression } ) ) );
				}
				else if( isReturnTypeParsed )
				{
					if( invokationMethodName == "InvokeObjectFast" )
						method.Body.AddChild( new ReturnStatement( new ObjectCreateExpression( new TypeReference( parsedMethodInfo.Result ), new List<Expression> { invokeExpression } ) ) );
					else
					{
						var returnExpression = ( Expression ) invokeExpression;
						if( ParsedInformation.Enums.FirstOrDefault( x => x.Name == method.TypeReference.Type ) != null )
							returnExpression = new CastExpression( new TypeReference( method.TypeReference.Type ), returnExpression, CastType.Cast );

						method.Body.AddChild( new ReturnStatement( returnExpression ) );
					}
				}
				else
					method.Body.AddChild( new ReturnStatement( invokeExpression ) );
			}

			if( isExtensionMethod && methodType == MethodType.Instance )
				method.Parameters.Insert( 0, new ParameterDeclarationExpression( new TypeReference( GetUnambiguousNRefactoryName( runtimeClassInfo.Identifier ) ), "___this" ) );

			return method;
		}

		/// <summary>
		/// Generates all essential structures.
		/// </summary>
		private static void GenerateStructures( string profileName )
		{
			var compilationUnit = new CompilationUnit();
			compilationUnit.AddChild( new UsingDeclaration( "System" ) );
			compilationUnit.AddChild( new UsingDeclaration( "System.Runtime.InteropServices" ) );

			var @namespace = compilationUnit.AddNamespace( "NObjective.Proxies" );

			foreach( var structSetting in ParsedInformation.Structs )
			{
				var @struct = @namespace.AddType( structSetting.Name );
				GeneratedStructuresCount++;

				@struct.Modifier = Modifiers.Public;
				@struct.Type = ClassType.Struct;

				FieldDeclaration bitsetStructField = null;
				int accumulatedBitsetSize = 0;
				int bitsetGroup = 0;

				for( int fieldSettingCounter = 0; fieldSettingCounter < structSetting.Fields.Count; fieldSettingCounter++ )
				{
					var fieldSetting = structSetting.Fields[fieldSettingCounter];

					var bitsetField = fieldSetting as ObjectiveCParsedInfo.StructInfo.BitsetField;
					if( bitsetField != null )
					{
						if( bitsetStructField == null )
						{
							bitsetStructField = new FieldDeclaration( null )
							{
								Fields = new List<VariableDeclaration>
									{ 
										new VariableDeclaration( "__bitsetGroup" + bitsetGroup ) 
									}
							};

							@struct.Modifier |= Modifiers.Unsafe;
							bitsetStructField.TypeReference = new TypeReference( "byte" );
							bitsetStructField.Modifier = Modifiers.Fixed | Modifiers.Private;

							@struct.Children.Add( bitsetStructField );
						}

						accumulatedBitsetSize += bitsetField.Size;

						var property = new PropertyDeclaration( Modifiers.Public, null, bitsetField.Name, null );

						property.TypeReference = new TypeReference( bitsetField.Type );
						property.GetRegion = new PropertyGetRegion( new BlockStatement(), null );
						property.GetRegion.Block.AddChild( new ThrowStatement( new ObjectCreateExpression( new TypeReference( "NotImplementedException" ), new List<Expression> { new PrimitiveExpression( "TODO", null ) } ) ) );

						property.SetRegion = new PropertySetRegion( new BlockStatement(), null );
						property.SetRegion.Block.AddChild( new ThrowStatement( new ObjectCreateExpression( new TypeReference( "NotImplementedException" ), new List<Expression> { new PrimitiveExpression( "TODO", null ) } ) ) );
						@struct.Children.Add( property );
						continue;
					}

					if( bitsetStructField != null )
					{
						bitsetStructField.Fields[0].Name += "[" + ( accumulatedBitsetSize + 31 ) / 32 * 4 + "]";
						bitsetStructField = null;
						accumulatedBitsetSize = 0;
						bitsetGroup++;
					}

					var variable = new VariableDeclaration( fieldSetting.Name );
					var field = new FieldDeclaration( null ) { Fields = new List<VariableDeclaration> { variable } };

					field.Modifier = Modifiers.Public;

					var arrayField = fieldSetting as ObjectiveCParsedInfo.StructInfo.ArrayField;
					if( arrayField != null )
					{
						field.Modifier |= Modifiers.Fixed;
						@struct.Modifier |= Modifiers.Unsafe;
						variable.Name += "[" + arrayField.Size + "]";
					}

					variable.TypeReference = new TypeReference( fieldSetting.Type );

					@struct.Children.Add( field );
				}
			}

			var outputVisitor = new CSharpOutputVisitor();
			SetFormatterOptions( outputVisitor );

			compilationUnit.AcceptVisitor( outputVisitor, null );

			File.WriteAllText( string.Format( "../Proxies/{0}/Structs.cs", profileName ), string.Join( Environment.NewLine, new[] {
						"//",
						"// Copyright (C) 2009 Eugeny Grishul",
						"//",
						"// See license in License.txt",
						"//",
						"",
						outputVisitor.Text } ) );
		}

		/// <summary>
		/// Generates all essential enums.
		/// </summary>
		private static void GenerateEnums( string profileName )
		{
			var compilationUnit = new CompilationUnit();
			compilationUnit.AddChild( new UsingDeclaration( "System" ) );
			var @namespace = compilationUnit.AddNamespace( "NObjective.Proxies" );

			foreach( var enumSetting in ParsedInformation.Enums )
			{
				var @enum = @namespace.AddType( enumSetting.Name );
				GeneratedEnumsCount++;

				@enum.Type = ClassType.Enum;

				if( enumSetting.Flags )
					@enum.AddAttribute( "Flags" );

				foreach( var enumElement in enumSetting.Elements )
					@enum.Children.Add( new FieldDeclaration( null ) { Fields = new List<VariableDeclaration> { new VariableDeclaration( enumElement.Name, new PrimitiveExpression( ( int ) enumElement.Value, null ) ) } } );
			}

			var outputVisitor = new CSharpOutputVisitor();
			SetFormatterOptions( outputVisitor );

			compilationUnit.AcceptVisitor( outputVisitor, null );

			File.WriteAllText( string.Format( "../Proxies/{0}/Enums.cs", profileName ), string.Join( Environment.NewLine, new[] {
						"//",
						"// Copyright (C) 2009 Eugeny Grishul",
						"//",
						"// See license in License.txt",
						"//",
						"",
						outputVisitor.Text } ) );
		}

		/// <summary>
		/// Checks that for some members proxies not generated.
		/// </summary>
		private static void CheckUnhandledMembers()
		{
#if false
			Tracer.Information( "Analyzing settings file.." );
			foreach( var @class in ParsedHeaderInformation.Classes )
			{
				if( !@class.IsHandled )
				{
					Tracer.Information( "  Class {0} not handled!", @class.Name );
					continue;
				}

				foreach( var method in @class.Methods )
				{
					if( !method.IsHandled )
					{
						Tracer.Information( "  Method {1} in class {0} not handled!", @class.Name, method.Method );
						continue;
					}

					foreach( var parameter in method.Parameters )
					{
						if( !parameter.IsHandled )
						{
							Tracer.Information( "  Parameter {2} in method {1} in class {0} not handled!", @class.Name, method.Method, parameter.Name );
							continue;
						}
					}
				}
			}
#endif
		}

		/// <summary>
		/// Setup formatting options for NRefactory.
		/// </summary>
		/// <param name="outputVisitor"></param>
		private static void SetFormatterOptions( CSharpOutputVisitor outputVisitor )
		{
			outputVisitor.Options.ConstructorBraceStyle = BraceStyle.EndOfLine;
			outputVisitor.Options.DestructorBraceStyle = BraceStyle.EndOfLine;
			outputVisitor.Options.MethodBraceStyle = BraceStyle.EndOfLine;
			outputVisitor.Options.NamespaceBraceStyle = BraceStyle.EndOfLine;
			outputVisitor.Options.PropertyBraceStyle = BraceStyle.EndOfLine;
			outputVisitor.Options.PropertyGetBraceStyle = BraceStyle.EndOfLine;
			outputVisitor.Options.PropertySetBraceStyle = BraceStyle.EndOfLine;
			outputVisitor.Options.ClassBraceStyle = BraceStyle.EndOfLine;
			outputVisitor.Options.StructBraceStyle = BraceStyle.EndOfLine;

			outputVisitor.Options.IfParentheses = false;
		}

		/// <summary>
		/// Check is application runned on Mac.
		/// </summary>
		public static bool IsRunningOnMacintosh
		{
			get { return Environment.OSVersion.Platform == PlatformID.Unix; }
		}

		/// <summary>
		/// Gets attribute type name without last ..."Attribute"
		/// </summary>
		/// <param name="attribute"></param>
		/// <returns></returns>
		private static string GetAttributeName( string attribute )
		{
			if( attribute.EndsWith( "Attribute" ) )
				return attribute.Substring( 0, attribute.Length - 9 );

			return attribute;
		}

		/// <summary>
		/// Used for sorting RuntimeMethods
		/// </summary>
		internal sealed class MethodsComparer : IEqualityComparer<RuntimeMethod>
		{
			#region IEqualityComparer<RuntimeMethod> Members

			public bool Equals( RuntimeMethod x, RuntimeMethod y )
			{
				return x.Name != y.Name;
			}

			public int GetHashCode( RuntimeMethod obj )
			{
				return obj.GetHashCode();
			}

			#endregion
		}

		/// <summary>
		/// Retrieves full type name for some cases.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		private static string GetUnambiguousNRefactoryName( string name )
		{
			switch( name )
			{
				case "Object":
					name = "NObjective.Proxies." + name;
					break;
			}

			return name;
		}

		private static readonly Dictionary<string, Type> _keywordTypes = new Dictionary<string, Type>
		{
			{ "void", typeof( void ) },

			{ "bool", typeof( bool ) },
			{ "char", typeof( char ) },

			{ "byte", typeof( byte ) },
			{ "sbyte", typeof( sbyte ) },
			{ "short", typeof( short ) },
			{ "ushort", typeof( ushort ) },
			{ "int", typeof( int ) },
			{ "uint", typeof( uint ) },
			{ "long", typeof( long ) },
			{ "ulong", typeof( ulong ) },

			{ "float", typeof( float ) },
			{ "double", typeof( double ) },
			{ "decimal", typeof( decimal ) },

			{ "string", typeof( string ) },
		};

		private static readonly Dictionary<Type, string> _keywordTypesReverse = _keywordTypes.ToDictionary( x => x.Value, x => x.Key );

		/// <summary>
		/// Maps C# keyword to appropriate .NET type.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		private static Type MapFromKeywordType( string value )
		{
			if( _keywordTypes.ContainsKey( value ) )
				return _keywordTypes[value];

			return null;
		}

		/// <summary>
		/// Maps .NET type to appropriate C# keyword.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		private static string MapToKeywordType( Type value )
		{
			if( _keywordTypesReverse.ContainsKey( value ) )
				return _keywordTypesReverse[value];

			return value.FullName;
		}

		/// <summary>
		/// Gets base class hierarchy using information from parsed headers.
		/// </summary>
		/// <param name="classes"></param>
		/// <param name="class"></param>
		/// <returns></returns>
		private static IEnumerable<ObjectiveCRuntimeInfo.ClassInfo> GetBaseHierarchy( Dictionary<string, ObjectiveCRuntimeInfo.ClassInfo> classes, ObjectiveCRuntimeInfo.ClassInfo @class )
		{
			while( @class != null )
			{
				yield return @class;

				if( @class.BaseClassName == null )
					yield break;

				@class = classes[@class.BaseClassName];
			}
		}
	}

	/// <summary>
	/// Hold settings used by ClassGenerator
	/// </summary>
	public class ObjectiveCParsedInfo
	{
		[XmlType( "class" )]
		public class ClassInfo
		{
			/// <summary>
			/// Parsed property information.
			/// </summary>
			[XmlType( "property" )]
			public class PropertyInfo
			{
				/// <summary>
				/// Name of property.
				/// </summary>
				[XmlAttribute( "name" )]
				public string Name;

				/// <summary>
				/// Type of property.
				/// </summary>
				[XmlAttribute( "type" )]
				public string PropertyType;

				/// <summary>
				/// Getter name.
				/// </summary>
				[XmlAttribute( "getter" )]
				public string Getter;

				/// <summary>
				/// Setter name.
				/// </summary>
				[XmlAttribute( "setter" )]
				public string Setter;

				/// <summary>
				/// Modifers that used while property synthezation.
				/// </summary>
				[XmlAttribute( "modifiers" )]
				public NObjectiveAST.ObjectivePropertyDeclarationStatement.PropertyModifiers Modifiers;

				public override string ToString()
				{
					return string.Format( "{0} {1}", PropertyType, Name );
				}
			}

			/// <summary>
			/// Parsed method information.
			/// </summary>
			[XmlType( "method" )]
			public class MethodInfo
			{
				/// <summary>
				/// Parsed parameter information.
				/// </summary>
				[XmlType( "parameter" )]
				public class ParameterInfo
				{
					[Flags]
					public enum ParameterModifiers
					{
						None = 0,
						Ref = 1,
						Out = 2
					}

					/// <summary>
					/// Index of parameter.
					/// </summary>
					[XmlAttribute( "index" )]
					public int Index;

					/// <summary>
					/// Parameter name.
					/// </summary>
					[XmlAttribute( "name" )]
					public string Name;

					/// <summary>
					/// Parameter type.
					/// </summary>
					[XmlAttribute( "type" )]
					public string Type;

					/// <summary>
					/// Parameter modifiers.
					/// </summary>
					[XmlAttribute( "modifiers" )]
					public ParameterModifiers Modifiers;

					[XmlIgnore]
					public bool IsHandled;

					public override string ToString()
					{
						return Type ?? "<?>" + " " + Name;
					}
				}

				/// <summary>
				/// Method name. Should be prefixed with "+" for class methods or "-" for instance methods.
				/// </summary>
				[XmlAttribute( "name" )]
				public string Method;

				/// <summary>
				/// Is variable-argument method.
				/// </summary>
				[XmlAttribute( "vararg" )]
				public bool IsVararg;

				/// <summary>
				/// Summary comment for method.
				/// </summary>
				[XmlElement( "summary" )]
				public string Summary;

				/// <summary>
				/// Type of result. Should have ctor which receive IntPtr as first settingsParameter.
				/// </summary>
				[XmlAttribute( "return" )]
				public string Result;

				/// <summary>
				/// Classes for parameters.
				/// </summary>
				[XmlElement( "parameter" )]
				public List<ParameterInfo> Parameters = new List<ParameterInfo>();

				[XmlIgnore]
				public bool IsHandled;

				public override string ToString()
				{
					return string.Format( "{0} {1}( {2} )", Result ?? "<?>", Method, string.Join( ", ", Parameters.Select( x => x.ToString() ).ToArray() ) );
				}
			}

			/// <summary>
			/// Objective-C class name.
			/// </summary>
			[XmlAttribute( "name" )]
			public string Name;

			/// <summary>
			/// Summary comment for class.
			/// </summary>
			[XmlElement( "summary" )]
			public string Summary;

			/// <summary>
			/// Mapping for methods.
			/// </summary>
			[XmlElement( "method" )]
			public List<MethodInfo> Methods = new List<MethodInfo>();

			/// <summary>
			/// Mapping for properties.
			/// </summary>
			[XmlElement( "property" )]
			public List<PropertyInfo> Properties = new List<PropertyInfo>();

			[XmlIgnore]
			public bool IsHandled;

			public override string ToString()
			{
				return Name;
			}
		}

		/// <summary>
		/// All parsed classes.
		/// </summary>
		public List<ClassInfo> Classes = new List<ClassInfo>();

		/// <summary>
		/// Parsed enum.
		/// </summary>
		[XmlType( "enum" )]
		public class EnumInfo
		{
			/// <summary>
			/// Enum element info.
			/// </summary>
			[XmlType( "element" )]
			public class ElementInfo
			{
				/// <summary>
				/// Element name.
				/// </summary>
				[XmlAttribute( "name" )]
				public string Name;

				/// <summary>
				/// Element value.
				/// </summary>
				[XmlAttribute( "value" )]
				public long Value;

				public override string ToString()
				{
					return string.Format( "{0} = {1}", Name, Value );
				}
			}

			/// <summary>
			/// Enum name.
			/// </summary>
			[XmlAttribute( "name" )]
			public string Name;

			/// <summary>
			/// Is flags enum.
			/// </summary>
			[XmlAttribute( "flags" )]
			public bool Flags;

			/// <summary>
			/// Enum body.
			/// </summary>
			[XmlElement( "element" )]
			public List<ElementInfo> Elements = new List<ElementInfo>();

			public override string ToString()
			{
				return Name;
			}
		}

		/// <summary>
		/// Necessary parsed enums.
		/// </summary>
		public List<EnumInfo> Enums = new List<EnumInfo>();

		/// <summary>
		/// Parsed structure.
		/// </summary>
		[XmlType( "struct" )]
		public class StructInfo
		{
			[XmlType( "field" )]
			[XmlInclude( typeof( ArrayField ) )]
			[XmlInclude( typeof( BitsetField ) )]
			[XmlInclude( typeof( PointerField ) )]
			public class Field
			{
				[XmlAttribute( "name" )]
				public string Name;

				[XmlAttribute( "type" )]
				public string Type;
			}

			[XmlType( "bitset" )]
			public class BitsetField : Field
			{
				[XmlAttribute( "size" )]
				public int Size;
			}

			[XmlType( "pointer" )]
			public class PointerField : Field
			{
			}

			[XmlType( "array" )]
			public class ArrayField : Field
			{
				[XmlAttribute( "size" )]
				public int Size;
			}

			[XmlAttribute( "name" )]
			public string Name;

			[XmlElement( "element" )]
			public List<Field> Fields = new List<Field>();

			public override string ToString()
			{
				return Name;
			}
		}

		public List<StructInfo> Structs = new List<StructInfo>();
	}
}
