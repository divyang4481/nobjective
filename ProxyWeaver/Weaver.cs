//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in GPLv3.txt
//

using System;
using System.Linq;
using Mono.Cecil;
using Mono.Cecil.Metadata;
using Mono.Cecil.Cil;

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

			var instrumentedAssembly = AssemblyFactory.GetAssembly( args[0] );
			if( instrumentedAssembly.Name.Name.EndsWith( "Unweaved" ) )
				instrumentedAssembly.Name.Name = instrumentedAssembly.Name.Name.Remove( instrumentedAssembly.Name.Name.IndexOf( "Unweaved" ) - 1 );

			foreach( ModuleDefinition module in instrumentedAssembly.Modules )
			{
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
			}

			AssemblyFactory.SaveAssembly( instrumentedAssembly, args[1] );
			//Process.Start( @"c:\Program Files\Microsoft SDKs\Windows\v6.0A\Bin\ildasm.exe", "/out=nobjective.il " + args[0] );
			//Process.Start( @"c:\Program Files\Microsoft SDKs\Windows\v6.0A\Bin\ildasm.exe", "/out=nobjective2.il " + args[1] );
		}
	}
}
