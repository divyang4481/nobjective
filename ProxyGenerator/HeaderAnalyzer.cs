//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in GPLv3.txt
//

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using NObjective.ProxyGenerator;
using NObjectiveAST;
using NObjectiveAST.EvaluatedRepresentation;

namespace NObjective.ProxyGenerator
{
	internal static class HeaderAnalyzer
	{
		private const string AnalyzeFile = "analyze";
		private static readonly Tracing.TraceSource Tracer = new Tracing.TraceSource( "Objc Header Analyzer" );

		private static ObjectiveCParsedInfo ParsedInfo = new ObjectiveCParsedInfo();

		private static NObjectiveAST.TranslationUnit AstTranslationUnit;
		private static NObjectiveAST.EvaluatedRepresentation.TranslationUnit EvaluatedTranslationUnit;

		public static void Analyze( string profileName )
		{
			Console.WriteLine( "Begin header parsing.." );

			using( Tracer )
			{
				//Tracer.AddListener( new Tracing.TextWriterTraceListener( Console.Out ) );
				Tracer.AddListener( new Tracing.TextWriterTraceListener( "HeaderAnalyzer.log" ) );

				var frameworkIncludes = RuntimeDumper.Settings.Frameworks.SelectMany( x => x.Includes != null && x.Includes.Count > 0 ? ( IEnumerable<string> ) x.Includes : new[] { x.Name + '/' + x.Name + ".h" } ).Select( x => string.Format( "#include <{0}>", x ) );

				File.WriteAllText( AnalyzeFile + ".mm", string.Join( Environment.NewLine, new[] {
					"//",
					"// Copyright (C) 2009 Eugeny Grishul",
					"//",
					"// See license in License.txt",
					"//",
					"",
					"#include <Cocoa/Cocoa.h>"
				}.Concat( frameworkIncludes ).ToArray()
				) );

				if( ProxyBuilder.IsRunningOnMacintosh )
				{
					string GCC = "", GCC_options = "";
					switch( Runtime.Version )
					{
						case Runtime.MacOSVersion.Tiger:
							GCC = "/Developer/usr/bin/gcc-4.0"; ;
							GCC_options = "-x objective-c -arch i386 -fmessage-length=0 -pipe -std=c99 -isysroot /Developer/SDKs/MacOSX10.4u.sdk -mmacosx-version-min=10.4 -E {0}.mm -o {0}.i";
							break;

						case Runtime.MacOSVersion.Leopard:
							GCC = "/Developer/usr/bin/gcc-4.2";
							GCC_options = "-x objective-c -arch i386 -fmessage-length=0 -pipe -std=c99 -isysroot /Developer/SDKs/MacOSX10.5.sdk -mmacosx-version-min=10.5 -E {0}.mm -o {0}.i";
							break;
					}

					Process.Start( GCC, string.Format( GCC_options, AnalyzeFile ) ).WaitForExit();
					Tracer.Information( "Finished preprocess.." );
				}

				// BOOL --> bool
				var lexems = new Lexer( File.ReadAllText( AnalyzeFile + ".i" ) ).Output.ToList();
				for( int i = 0; i < lexems.Count; i++ )
				{
					if( lexems[i].Type == Lexer.Tokens.Identifier && ( string ) lexems[i].Value == "BOOL" )
						lexems[i] = new Lexer.Token { Type = Lexer.Tokens._bool };
					else if( lexems[i].Type == Lexer.Tokens._typedef && lexems[i + 1].Type == Lexer.Tokens._char && lexems[i + 2].Type == Lexer.Tokens.Identifier && ( string ) lexems[i + 2].Value == "BOOL" )
					{
						lexems.RemoveAt( i );
						lexems.RemoveAt( i );
						lexems.RemoveAt( i );
						lexems.RemoveAt( i-- );
					}
				}

				AstTranslationUnit = new Parser( lexems.ToArray() ).TranslationUnit;
				EvaluatedTranslationUnit = new EvaluationVisitor( AstTranslationUnit ).TranslationUnit;

				for( int elementCounter = 0; elementCounter < AstTranslationUnit.Body.Count; elementCounter++ )
				{
					var typedefStatement = AstTranslationUnit.Body[elementCounter] as TypedefStatement;
					if( typedefStatement == null )
						continue;

					if( typedefStatement.DeclarationExpression.TypeReference.TypeName == "NSUInteger" )
					{
						var enumDeclarationStatement = AstTranslationUnit.Body[elementCounter - 1] as ExpressionStatement;
						if( enumDeclarationStatement == null )
							continue;

						var enumDeclaration = enumDeclarationStatement.Expression as TypeDeclarationExpression;
						if( enumDeclaration == null )
							continue;

						AddEnum( typedefStatement.DeclarationExpression.Declarations[0].Name, enumDeclaration );
					}
				}

				foreach( var @class in EvaluatedTranslationUnit.ObjectiveTypes )
				{
					//if( @class.Name != "NSNumber" )
					//	continue;

					// different category with same class name
					var existingMapping = ParsedInfo.Classes.FirstOrDefault( x => x.Name == @class.Name );
					var currentMapping = existingMapping ?? new ObjectiveCParsedInfo.ClassInfo { Name = @class.Name };

					if( existingMapping == null && RuntimeDumper.ClassIncludeFilters.Any( x => x.IsMatch( @class.Name ) ) && RuntimeDumper.ClassExcludeFilters.All( x => !x.IsMatch( @class.Name ) ) )
						ParsedInfo.Classes.Add( currentMapping );

					foreach( var method in @class.Methods.Where( x => RuntimeDumper.MethodExcludeFilters.All( y => !y.IsMatch( x.Name ) ) ) )
					{
						//if( method.FullName != "compare:" )
						//	continue;

						var methodMapping = new ObjectiveCParsedInfo.ClassInfo.MethodInfo { Method = method.FullName };

						methodMapping.IsVararg = method.IsVararg;

						if( method.IsClassMethod )
							methodMapping.Method = "+" + methodMapping.Method;
						else
							methodMapping.Method = "-" + methodMapping.Method;

						methodMapping.Result = ObjectiveCTypeToMarshalledType( method.ReturnType, true, method.IsVararg ).Name;
						var probablyEnum = ParsedInfo.Enums.FirstOrDefault( x => method.Original.ReturnType != null && x.Name == method.Original.ReturnType.TypeName );
						if( probablyEnum != null )
							methodMapping.Result = probablyEnum.Name;

						for( int parameterIndex = 0; parameterIndex < method.Parameters.Count; parameterIndex++ )
						{
							var parameterType = ObjectiveCTypeToMarshalledType( method.Parameters[parameterIndex].Type, false, method.IsVararg );
							probablyEnum = ParsedInfo.Enums.FirstOrDefault( x => method.Original.Parameters[parameterIndex].TypeReference != null && x.Name == method.Original.Parameters[parameterIndex].TypeReference.TypeName );
							if( probablyEnum != null )
								parameterType.Name = probablyEnum.Name;

							methodMapping.Parameters.Add( new ObjectiveCParsedInfo.ClassInfo.MethodInfo.ParameterInfo
							{
								Index = parameterIndex,
								Name = method.Parameters[parameterIndex].Name,
								Type = parameterType.Name,
								Modifiers = parameterType.Modifiers
							} );
						}


						currentMapping.Methods.Add( methodMapping );
					}

					foreach( var property in @class.Properties )
					{
						var propertyMapping = new ObjectiveCParsedInfo.ClassInfo.PropertyInfo { Name = property.Name };

						propertyMapping.PropertyType = ObjectiveCTypeToMarshalledType( property.PropertyType, true, false ).Name;

						propertyMapping.Getter = property.DeclarationStatement.GetterName;
						propertyMapping.Setter = property.DeclarationStatement.SetterName;
						propertyMapping.Modifiers = property.DeclarationStatement.Modifiers;

						var probablyEnum = ParsedInfo.Enums.FirstOrDefault( x => property.Original.TypeReference != null && x.Name == property.Original.TypeReference.TypeName );
						if( probablyEnum != null )
							propertyMapping.PropertyType = probablyEnum.Name;

						currentMapping.Properties.Add( propertyMapping );
					}
				}

				foreach( CppType structure in _marshalledStructures.ToArray() )
					foreach( var field in structure.Fields )
						ObjectiveCTypeToMarshalledType( field.Type, false, false );

				foreach( CppType structure in _marshalledStructures )
				{
					var structureMapping = new ObjectiveCParsedInfo.StructInfo();

					structureMapping.Name = structure.Name;
					foreach( var field in structure.Fields )
						structureMapping.Fields.Add( ConvertToSettingField( field ) );

					ParsedInfo.Structs.Add( structureMapping );
				}

				ParsedInfo.Classes = ParsedInfo.Classes.OrderBy( x => x.Name ).ToList();
				ParsedInfo.Structs = ParsedInfo.Structs.OrderBy( x => x.Name ).ToList();
				ParsedInfo.Enums = ParsedInfo.Enums.OrderBy( x => x.Name ).ToList();

				foreach( var mapping in ParsedInfo.Classes )
					mapping.Methods = mapping.Methods.OrderBy( x => x.Method ).ToList();

				using( var file = new StreamWriter( string.Format( ProxyBuilder.SettingsFile, profileName ) ) )
					new XmlSerializer( typeof( ObjectiveCParsedInfo ) ).Serialize( file, ParsedInfo );

				Console.WriteLine( "Header analysis information:" );
				Console.WriteLine( " {0} classes", ParsedInfo.Classes.Count );
				Console.WriteLine( " {0} methods", ParsedInfo.Classes.SelectMany( x => x.Methods ).Count() );
				Console.WriteLine( " {0} structs", ParsedInfo.Structs.Count );
				Console.WriteLine( " {0} enums", ParsedInfo.Enums.Count );
			}
		}

		public static void AddEnum( string enumName, TypeDeclarationExpression enumDeclaration )
		{
			if( ParsedInfo.Enums.Any( x => x.Name == enumName ) )
				return;

			var enumMapping = new ObjectiveCParsedInfo.EnumInfo { Name = enumName };
			var evaluatedEnum = EvaluatedTranslationUnit.Enums.FirstOrDefault( x => x.Original == enumDeclaration );

			foreach( var enumElement in evaluatedEnum.Items )
				enumMapping.Elements.Add( new ObjectiveCParsedInfo.EnumInfo.ElementInfo { Name = enumElement.Key, Value = enumElement.Value } );

			ParsedInfo.Enums.Add( enumMapping );
		}

		public static readonly HashSet<LanguageType> _marshalledStructures = new HashSet<LanguageType>();

		private struct MarshalledType
		{
			public string Name;

			public ObjectiveCParsedInfo.ClassInfo.MethodInfo.ParameterInfo.ParameterModifiers Modifiers;

			public MarshalledType( string name )
			{
				Name = name;
				Modifiers = ObjectiveCParsedInfo.ClassInfo.MethodInfo.ParameterInfo.ParameterModifiers.None;
			}
		}

		/// <summary>
		/// We don't need recursive transform here. Complex pointers should be represented as IntPtrs etc.
		/// </summary>
		/// <param name="node"></param>
		/// <param name="returnType"></param>
		/// <returns></returns>
		private static MarshalledType ObjectiveCTypeToMarshalledType( NObjectiveAST.EvaluatedRepresentation.Node node, bool returnType, bool varargMethod )
		{
			var primitiveType = node as PrimitiveType;
			if( primitiveType != null )
			{
				if( _cppToCSharpTypeMapping.ContainsKey( primitiveType ) )
					return new MarshalledType( _cppToCSharpTypeMapping[primitiveType] );
			}

			var cppType = node as CppType;
			if( cppType != null )
			{
				if( cppType.IsDefined )
				{
					_marshalledStructures.Add( cppType );
					return new MarshalledType( cppType.Name );
				}
			}

			var enumType = node as NObjectiveAST.EvaluatedRepresentation.Enum;
			if( enumType != null )
			{
				AddEnum( enumType.Name, enumType.Original );
				return new MarshalledType( enumType.Name );
			}

			var bitsetType = node as BitsetType;
			if( bitsetType != null )
				return new MarshalledType( _cppToCSharpTypeMapping[bitsetType.ElementType] + ":" + bitsetType.BitsetSize );

			var pointerType = node as PointerType;
			if( pointerType != null )
			{
				var objectiveType = pointerType.Pointee as ObjectiveType;
				if( objectiveType != null )
				{
					if( objectiveType.Name == "NSString" )
						return new MarshalledType( "string" );

					return new MarshalledType( objectiveType.Name );
				}

				cppType = pointerType.Pointee as CppType;
				if( cppType != null )
				{
					// we can determine it through objc-introspection
					if( cppType.Name == "objc_object" || cppType.Name == "objc_selector" || cppType.Name == "objc_class" )
						return new MarshalledType( null );

					if( returnType )
						return new MarshalledType( "IntPtr" );

					if( cppType.IsDefined )
					{
						_marshalledStructures.Add( cppType );
						return new MarshalledType( cppType.Name + "[]" );
					}
				}

				if( returnType )
					return new MarshalledType( "IntPtr" );

				primitiveType = node as PrimitiveType;
				if( primitiveType != null )
				{
					if( _cppToCSharpTypeMapping.ContainsKey( primitiveType ) )
						return new MarshalledType( _cppToCSharpTypeMapping[primitiveType] + "[]" );
				}

				enumType = node as NObjectiveAST.EvaluatedRepresentation.Enum;
				if( enumType != null )
				{
					AddEnum( enumType.Name, enumType.Original );
					return new MarshalledType( enumType.Name + "[]" );
				}

				if( !varargMethod )
				{
					var pointerType2 = pointerType.Pointee as PointerType;
					if( pointerType2 != null )
					{
						objectiveType = pointerType2.Pointee as ObjectiveType;


						if( objectiveType != null )
						{
							if( objectiveType.Name == "NSString" )
								return new MarshalledType( "string" ) { Modifiers = ObjectiveCParsedInfo.ClassInfo.MethodInfo.ParameterInfo.ParameterModifiers.Ref };

							return new MarshalledType( objectiveType.Name ) { Modifiers = ObjectiveCParsedInfo.ClassInfo.MethodInfo.ParameterInfo.ParameterModifiers.Ref };
						}
					}
				}

				return new MarshalledType( "IntPtr" );
			}

			if( node is ReferenceType )
				return new MarshalledType( "IntPtr" );

			return new MarshalledType( null );
		}

		private static ObjectiveCParsedInfo.StructInfo.Field ConvertToSettingField( Variable variable )
		{
			var primitiveType = variable.Type as PrimitiveType;
			if( primitiveType != null )
			{
				if( _cppToCSharpTypeMapping.ContainsKey( primitiveType ) )
					return new ObjectiveCParsedInfo.StructInfo.Field
					{
						Name = variable.Name,
						Type = _cppToCSharpTypeMapping[primitiveType]
					};
			}

			var cppType = variable.Type as CppType;
			if( cppType != null )
			{
				if( cppType.IsDefined )
					return new ObjectiveCParsedInfo.StructInfo.Field
					{
						Name = variable.Name,
						Type = cppType.Name
					};
			}

			var bitsetType = variable.Type as BitsetType;
			if( bitsetType != null )
				return new ObjectiveCParsedInfo.StructInfo.BitsetField
				{
					Name = variable.Name,
					Type = _cppToCSharpTypeMapping[bitsetType.ElementType],
					Size = bitsetType.BitsetSize
				};

			var pointerType = variable.Type as PointerType;
			if( pointerType != null )
			{
				var objectiveType = pointerType.Pointee as ObjectiveType;
				if( objectiveType != null )
					return new ObjectiveCParsedInfo.StructInfo.Field
					{
						Name = variable.Name,
						Type = objectiveType.Name
					};

				cppType = pointerType.Pointee as CppType;
				if( cppType != null )
				{
					if( cppType.Name == "objc_object" )
						return new ObjectiveCParsedInfo.StructInfo.Field
						{
							Name = variable.Name,
							Type = "RuntimeObject"
						};

					if( cppType.Name == "objc_selector" )
						return new ObjectiveCParsedInfo.StructInfo.Field
						{
							Name = variable.Name,
							Type = "Selector"
						};

					if( cppType.Name == "objc_class" )
						return new ObjectiveCParsedInfo.StructInfo.Field
						{
							Name = variable.Name,
							Type = "RuntimeClass"
						};

					if( cppType.IsDefined )
					{
						return new ObjectiveCParsedInfo.StructInfo.PointerField
						{
							Name = variable.Name,
							Type = cppType.Name
						};
					}

					return new ObjectiveCParsedInfo.StructInfo.Field
					{
						Name = variable.Name,
						Type = "IntPtr"
					};
				}

				primitiveType = variable.Type as PrimitiveType;
				if( primitiveType != null )
				{
					if( _cppToCSharpTypeMapping.ContainsKey( primitiveType ) )
						return new ObjectiveCParsedInfo.StructInfo.PointerField
						{
							Name = variable.Name,
							Type = _cppToCSharpTypeMapping[primitiveType]
						};
				}

				return new ObjectiveCParsedInfo.StructInfo.Field
				{
					Name = variable.Name,
					Type = "IntPtr"
				};
			}

			var arrayType = variable.Type as ArrayType;
			if( arrayType != null )
			{
				primitiveType = arrayType.ElementType as PrimitiveType;
				if( primitiveType != null )
				{
					if( _cppToCSharpTypeMapping.ContainsKey( primitiveType ) )
						return new ObjectiveCParsedInfo.StructInfo.ArrayField
						{
							Name = variable.Name,
							Type = _cppToCSharpTypeMapping[primitiveType],
							Size = arrayType.Size
						};
				}
			}

			if( variable.Type is ReferenceType )
				return new ObjectiveCParsedInfo.StructInfo.Field
				{
					Name = variable.Name,
					Type = "IntPtr"
				};

			return null;
		}

		private static readonly Dictionary<LanguageType, string> _cppToCSharpTypeMapping = new Dictionary<LanguageType, string>
		{
			{ PrimitiveType.Void, "void" },

			{ PrimitiveType.Bool, "bool" },
			{ PrimitiveType.WideChar, "wchar_t" },

			{ PrimitiveType.Char, "sbyte" },
			{ PrimitiveType.Short, "short" },
			{ PrimitiveType.Int, "int" },
			{ PrimitiveType.Long, "int" },
			{ PrimitiveType.LongLong, "long" },
			{ PrimitiveType.UnsignedChar, "byte" },
			{ PrimitiveType.UnsignedShort, "ushort" },
			{ PrimitiveType.UnsignedInt, "uint" },
			{ PrimitiveType.UnsignedLong, "uint" },
			{ PrimitiveType.UnsignedLongLong, "ulong" },
			
			{ PrimitiveType.Float, "float" },
			{ PrimitiveType.Double, "double" },
			{ PrimitiveType.LongDouble, "double" },
		};
	}
}