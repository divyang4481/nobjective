//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in GPLv3.txt
//

#define USE_CECIL

// Available in Mono 2.0, 2.2. Broken in Mono 2.4, 2.6
//#define USE_VALUE_TYPE_INHERITANCE

using System;
using System.Linq;

#if USE_CECIL
using Mono.Cecil;
using Mono.Cecil.Metadata;
using Mono.Cecil.Cil;
#else
using Microsoft.Cci;
using Microsoft.Cci.MutableCodeModel;
#endif

using System.Diagnostics;
using System.IO;
using System.Collections.Generic;

namespace NObjective.ProxyWeaver
{
	public class RuntimeInstrumentation
	{
		static void Main( string[] args )
		{
			if( args.Length == 0 )
			{
				Console.WriteLine( "post-instrumentation source.dll target.dll" );
				return;
			}

			var timer = new Stopwatch();
			timer.Start();

#if USE_CECIL
			var instrumentedAssembly = AssemblyFactory.GetAssembly( args[0] );
			if( instrumentedAssembly.Name.Name.EndsWith( "Unweaved" ) )
			{
				instrumentedAssembly.Name.Name = instrumentedAssembly.Name.Name.Remove( instrumentedAssembly.Name.Name.IndexOf( "Unweaved" ) - 1 );
				instrumentedAssembly.Modules[0].Name = instrumentedAssembly.Name.Name;
			}

			var excludedMethods = new HashSet<string> { "op_Implicit", "op_Explicit", "op_Inequality", "op_Equality" };

			foreach( ModuleDefinition module in instrumentedAssembly.Modules )
			{
#if USE_VALUE_TYPE_INHERITANCE
				var nsobjectref = module.TypeReferences["NObjective.Proxies.NSObject"];
				var handleField = module.Types["NObjective.Proxies.NSObject"].Fields[0];

				if( nsobjectref == null )
				{
					nsobjectref = new TypeReference( "NSObject", "NObjective.Proxies", module, false )
					{
						MetadataToken = new MetadataToken( TokenType.TypeRef, ( uint ) module.TypeReferences.Count + 1 )
					};
					module.TypeReferences.Add( nsobjectref );
				}

				foreach( TypeDefinition type in module.Types )
				{
					if( type.Namespace != "NObjective.Proxies" )
						continue;

					if( !type.IsPublic || type.IsEnum || !type.IsValueType )
						continue;

					var localHandle = type.Fields.Cast<FieldDefinition>().FirstOrDefault( x => x.Name == "Handle" );
					if( localHandle == null )
						continue;

					type.IsSealed = false;

					if( type.Name == "NSObject" )
						continue;

					foreach( var method in type.Methods.Cast<MethodDefinition>().Concat( type.Constructors.Cast<MethodDefinition>() ) )
						if( method.Body != null )
							foreach( Instruction item in method.Body.Instructions )
							{
								if( item.Operand == localHandle )
									item.Operand = handleField;
							}

					type.Fields.Remove( localHandle );

					var baseTypeAttribute = type.CustomAttributes.OfType<CustomAttribute>().FirstOrDefault();
					var baseTypeName = baseTypeAttribute != null ? ( string ) baseTypeAttribute.ConstructorParameters[0] : null;

					if( baseTypeName == null )
						continue;

					type.BaseType = module.TypeReferences[baseTypeName];

					if( type.BaseType != null )
						continue;

					type.BaseType = new TypeReference( baseTypeName.Split( '.' ).Last(), "NObjective.Proxies", module, false )
					{
						MetadataToken = new MetadataToken( TokenType.TypeRef, ( uint ) module.TypeReferences.Count + 1 )
					};
					module.TypeReferences.Add( type.BaseType );
				}
#else
				var nsobjectref = module.TypeReferences["NObjective.Proxies.NSObject"];

				if( nsobjectref == null )
				{
					nsobjectref = new TypeReference( "NSObject", "NObjective.Proxies", module, false )
					{
						MetadataToken = new MetadataToken( TokenType.TypeRef, ( uint ) module.TypeReferences.Count + 1 )
					};
					module.TypeReferences.Add( nsobjectref );
				}

				foreach( TypeDefinition type in module.Types.OfType<TypeDefinition>().OrderBy( x => GetHerarchyDepth( module, x ) ) )
				{
					if( type.Namespace != "NObjective.Proxies" )
						continue;

					if( !type.IsPublic || type.IsEnum || !type.IsValueType )
						continue;

					var thisHandleField = type.Fields.Cast<FieldDefinition>().FirstOrDefault( x => x.Name == "Handle" );
					if( thisHandleField == null )
						continue;

					if( type.Name == "NSObject" )
						continue;

					var baseType = GetBaseType( module, type );
					if( baseType == null ) continue;

					var baseHandleField = baseType.Fields[0];

					foreach( var method in baseType.Methods.Cast<MethodDefinition>().Where( x => !excludedMethods.Contains( x.Name ) ) )
					{
						//if( method.Name == "Equals" && method.Parameters.Count == 1 && method.Parameters[0].ParameterType.FullName == "System.Object" ) continue;
						//if( method.Name == "ToString" && method.Parameters.Count == 0 ) continue;
						if( method.Name == "GetHashCode" && method.Parameters.Count == 0 ) continue;
						if( method.Name == "alloc" && method.Parameters.Count == 0 ) continue;

						var clone = method.Clone();

						//if( method.Body != null )
						//    foreach( Instruction item in method.Body.Instructions )
						//    {
						//        if( item.Operand == baseHandleField )
						//            item.Operand = thisHandleField;
						//    }

						type.Methods.Add( clone );
					}
				}
#endif
			}

			AssemblyFactory.SaveAssembly( instrumentedAssembly, args[1] );
#else
			var host = new PeReader.DefaultHost();

			var assembly = host.LoadUnitFrom( args[0] ) as IAssembly;
			if( assembly == null || assembly == Dummy.Module || assembly == Dummy.Assembly )
			{
				Console.WriteLine( args[0] + " is not a PE file containing a CLR assembly, or an error occurred when loading it." );
				return;
			}

			var weaver = new BaseWeaver( host );
			assembly = weaver.Visit( assembly );

			PeWriter.WritePeToStream( assembly, host, File.Create( args[1] ), null, null, null );
#endif
			timer.Stop();
			Console.WriteLine( "Elapsed: {0}s", timer.Elapsed.TotalSeconds );

			//Process.Start( @"c:\Program Files\Microsoft SDKs\Windows\v6.0A\Bin\ildasm.exe", "/out=nobjective.il " + args[0] );
			//Process.Start( @"c:\Program Files\Microsoft SDKs\Windows\v6.0A\Bin\ildasm.exe", "/out=nobjective2.il " + args[1] );
		}

		public static TypeDefinition GetBaseType( ModuleDefinition module, TypeDefinition type )
		{
			var baseTypeAttribute = type.CustomAttributes.OfType<CustomAttribute>().FirstOrDefault( x => x.Constructor.DeclaringType.FullName == "NObjective.ProxyBaseClassAttribute" );
			if( baseTypeAttribute == null ) return null;
			if( baseTypeAttribute.ConstructorParameters.Count == 0 ) return null;

			var baseTypeName = ( string ) baseTypeAttribute.ConstructorParameters[0];
			if( baseTypeName == null ) return null;

			return module.Types[baseTypeName];
		}

		public static int GetHerarchyDepth( ModuleDefinition module, TypeDefinition type )
		{
			var result = 0;

			var baseType = type;
			while( ( baseType = GetBaseType( module, baseType ) ) != null )
				result++;

			return result;
		}
	}

#if !USE_CECIL
	public class BaseWeaver : MetadataMutator
	{
		private INamedTypeDefinition _nsobject, _proxyBaseClassAttribute;
		private IFieldDefinition _nsobjectHandle;

		public BaseWeaver( IMetadataHost host )
			: base( host, true )
		{
		}

		public override MethodBody Visit( MethodBody methodBody )
		{
			return base.Visit( methodBody );
		}

		//public override FieldReference Visit( FieldReference fieldReference )
		//{
		//    if( fieldReference.Name.Value == "Handle" )
		//    {
		//        Debugger.Break();
		//    }

		//    return base.Visit( fieldReference );
		//}

		public override FieldDefinition Visit( FieldDefinition fieldDefinition )
		{
			if( fieldDefinition.Name.Value == "Handle" )
			{
				var x = fieldDefinition.ContainingType.Attributes.First().Type;
				Debugger.Break();
			}

			return base.Visit( fieldDefinition );
		}

		public override Module Visit( Module module )
		{
			return base.Visit( module );
		}
		
		public override Assembly Visit( Assembly assembly )
		{
			_nsobject = UnitHelper.FindType( host.NameTable, assembly, "NObjective.Proxies.NSObject" );
			//_proxyBaseClassAttribute = UnitHelper.FindType( host.NameTable, assembly, "NObjective.ProxyBaseClassAttribute" );

			_nsobjectHandle = _nsobject.Fields.First( x => x.Name.Value == "Handle" );
			
			return base.Visit( assembly );
		}
	}
#endif
}
