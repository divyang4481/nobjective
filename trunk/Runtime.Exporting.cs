//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.IO;

namespace NObjective
{
	public static partial class Runtime
	{
		/// <summary>
		/// Create instance of specified exported type.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="initializationMethod"></param>
		/// <param name="arguments"></param>
		/// <returns></returns>
		public static T CreateInstance<T>( Selector initializationMethod, params object[] arguments ) where T : RuntimeExportBase
		{
			return Attach<T>( GetExportedClass<T>().CreateInstance( initializationMethod, arguments ) );
		}

		/// <summary>
		/// Native part contains managed handle to managed part. Using it you can access to managed part.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="object"></param>
		/// <returns></returns>
		public static T Attach<T>( RuntimeObject @object ) where T : RuntimeExportBase
		{
			return ( T ) GCHandle.FromIntPtr( Runtime.SendMessage( @object, GetManagedHandleReservedFunctionNameSelector ) ).Target;
		}

		/// <summary>
		/// Check if Objective-C class was exported by <see cref="ExportClass"/>.
		/// </summary>
		/// <param name="class">Objective-C class to check.</param>
		/// <returns>True if class was previously registered by <see cref="ExportClass"/>, False otherwise.</returns>
		public static bool IsClassExportedByRuntime( RuntimeClass @class )
		{
			if( @class == RuntimeClass.Null )
				return false;

			return new RuntimeMethod( @class, GetManagedHandleReservedFunctionName ) != RuntimeMethod.Null;
		}

		/// <summary>
		/// Get name for exported class in Objective-C runtime.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public static string GetExportedClassName<T>()
		{
			return GetExportedClassName( typeof( T ) );
		}

		/// <summary>
		/// Get name for exported class in Objective-C runtime.
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public static string GetExportedClassName( Type type )
		{
			var overridenName = type.GetCustomAttribute<ClassNameAttribute>( false );

			if( overridenName != null )
				return overridenName.Name;

			return type.Name;
		}

		/// <summary>
		/// Get class object for exported class in Objective-C runtime.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public static RuntimeClass GetExportedClass<T>()
		{
			return new RuntimeClass( GetExportedClassName<T>() );
		}

		/// <summary>
		/// Get class object for exported class in Objective-C runtime.
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public static RuntimeClass GetExportedClass( Type type )
		{
			return new RuntimeClass( GetExportedClassName( type ) );
		}

		/// <summary>
		/// Reserved name for Objective-C instance method that return managed handle.
		/// </summary>
		internal const string GetManagedHandleReservedFunctionName = "__get_exported_class_managed_handle_from_native_object";

		/// <summary>
		/// Selector for Objective-C instance method that return managed handle.
		/// </summary>
		internal static readonly Selector GetManagedHandleReservedFunctionNameSelector = GetManagedHandleReservedFunctionName;

		/// <summary>
		/// Performs exporting to Objective-C runtime of all classes that derived from RuntimeExportBase.
		/// Excluded classes should be marked with ManualRegisterAttribute attribute.
		/// </summary>
		public static void ExportAllClasses()
		{
			Tracer.Information( "Begin automatic class registering.." );

			foreach( var assembly in AppDomain.CurrentDomain.GetAssemblies() )
			{
				Tracer.Information( "Scanning assembly {0}..", assembly );

				// skip dynamic assemblies
				try { assembly.GetExportedTypes(); }
				catch { continue; }

				Tracer.IncreaseLevel();

				foreach( var type in assembly.GetExportedTypes().Where( x => x.GetClassHierarchy().Contains( typeof( RuntimeExportBase ) ) && x != typeof( RuntimeExportBase ) && !x.IsDefined( typeof( ManualRegisterAttribute ), true ) ) )
				{
					var existingClass = NativeMethods.objc_getClass( GetExportedClassName( type ) );
					if( existingClass != IntPtr.Zero && IsClassExportedByRuntime( new RuntimeClass( existingClass ) ) )
						continue;

					Tracer.Information( "Found {0}..", type );
					ExportClass( type );
				}

				Tracer.DecreaseLevel();
			}
		}
		/// <summary>
		/// Export type which derived from RuntimeExportBase to Objective-C runtime.
		/// </summary>
		/// <param name="type">Type to register.</param>
		/// <returns>RuntimeClass class instance that represents newly created Objective-C class.</returns>
		public static unsafe RuntimeClass ExportClass( Type type )
		{
			var classNameToExport = GetExportedClassName( type );
			var existingClass = new RuntimeClass( classNameToExport );

			// class exists
			if( existingClass != RuntimeClass.Null )
				throw new RegistrationException( "Class {0} already registered!", classNameToExport );

			if( type.IsValueType )
				throw new RegistrationException( "Registering of value types is not supported" );

			if( type.IsInterface )
				throw new RegistrationException( "Registering of interfaces is not supported" );

			if( type == typeof( RuntimeExportBase ) )
				throw new RegistrationException( "RuntimeExportBase used for other purposes =)" );

			if( !type.GetClassHierarchy().Contains( typeof( RuntimeExportBase ) ) )
				throw new RegistrationException( "Exported types should inherit from RuntimeExportBase" );

			// add ivars, accessible by properties
			var toStringBase = typeof( object ).GetMethod( "ToString" );
			var getHashcodeBase = typeof( object ).GetMethod( "GetHashCode" );
			var declaredDealloc = type.GetMethod( "dealloc", BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly, Type.DefaultBinder, new Type[] { }, null );

			Func<MethodInfo, bool> methodFilter = x => x.GetBaseDefinition() != toStringBase && x.GetBaseDefinition() != getHashcodeBase && x != declaredDealloc;
			Func<ParameterInfo, bool> parameterFilter = x => x.ParameterType.IsValueType || x.ParameterType == typeof( string ) || x.ParameterType.IsPointer;

			var exportedMethods = type.GetMethods( BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly ).Where( methodFilter ).Where( x => x.GetParameters().All( parameterFilter ) ).Where( x => !type.GetProperties( BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.DeclaredOnly ).Where( y => !y.IsDefined( typeof( PropertySynthesisAttribute ), false ) ).SelectMany( y => y.GetAccessors() ).Contains( x ) ).ToArray();
			var exportedConstructors = type.GetConstructors( BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.NonPublic ).Where( x => ( x.Attributes & ( MethodAttributes.Family | MethodAttributes.Public ) ) != 0 ).Where( x => x.GetParameters().All( parameterFilter ) ).ToArray();

			Tracer.Information( "Following methods will be exported:" );
			Tracer.IncreaseLevel();

			foreach( var method in exportedMethods )
				Tracer.Information( "{0}", method );

			Tracer.DecreaseLevel();

			Tracer.Information( "Following constructors will be exported:" );
			Tracer.IncreaseLevel();

			foreach( var constructor in exportedConstructors )
				Tracer.Information( "{0}", constructor );

			Tracer.DecreaseLevel();

			// check renaming errors
			{
				var methodWithRenamedParameter = exportedMethods.Where( x => x.GetParameters().Length > 0 ).FirstOrDefault( x => x.GetParameters()[0].IsDefined( typeof( ParameterNameAttribute ), true ) );

				if( methodWithRenamedParameter != null )
					throw new RegistrationException( "{0} on first parameter of method {1} makes no sense!", typeof( ParameterNameAttribute ).Name, methodWithRenamedParameter.Name );

				var ctorWithRenamedParameter = exportedConstructors.Where( x => x.GetParameters().Length > 0 ).FirstOrDefault( x => x.GetParameters()[0].IsDefined( typeof( ParameterNameAttribute ), true ) );

				if( ctorWithRenamedParameter != null )
					throw new RegistrationException( "{0} on first parameter of constructor {1} makes no sense!", typeof( ParameterNameAttribute ).Name, ctorWithRenamedParameter.Name );

				var incorrectlyRenamedMethod = exportedMethods.Where( x => x.IsDefined( typeof( SelectorAttribute ), true ) ).FirstOrDefault( x => new Selector( x.GetCustomAttribute<SelectorAttribute>( true ).Selector ).ParametersCount != x.GetParameters().Length );

				if( incorrectlyRenamedMethod != null )
					throw new RegistrationException( "Selector for {0} is malformed", incorrectlyRenamedMethod.Name );
			}

			RuntimeClass baseClass;
			bool isFirstHierarchyProxy = true;

			if( type.IsDefined( typeof( BaseClassAttribute ), false ) )
			{
				var baseClassName = type.GetCustomAttribute<BaseClassAttribute>( false ).Base;
				baseClass = new RuntimeClass( baseClassName );

				if( baseClass == RuntimeClass.Null )
					throw new RegistrationException( "Can't find {0} base class", baseClassName );
			}
			else if( type.BaseType == typeof( RuntimeExportBase ) )
				baseClass = new RuntimeClass( "NSObject" );
			else
			{
				baseClass = GetExportedClass( type.BaseType );

				if( baseClass == IntPtr.Zero )
					baseClass = ExportClass( type.BaseType );

				isFirstHierarchyProxy = false;
			}

			var result = new RuntimeClass( CompatibilityLayer.objc_allocateClassPair( baseClass, classNameToExport, 0 ) );
			var metaclass = result.MetaClass;

			// class version version have internal special meaning
			// var assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version;
			// NativeMethods.class_setVersion( result, assemblyVersion.Major * 10 + assemblyVersion.Minor );

			try
			{
				if( result == RuntimeClass.Null )
					throw new RegistrationException( "Can't register class " + classNameToExport + "!" );

				if( isFirstHierarchyProxy )
					CompatibilityLayer.class_addIvar( result, "_managedHandle", sizeof( GCHandle ), 1, "^l" );

				foreach( AdoptedProtocolAttribute protocolAttribute in type.GetCustomAttributes( typeof( AdoptedProtocolAttribute ), false ) )
				{
					var protocol = CompatibilityLayer.objc_getProtocol( protocolAttribute.Name );

					if( protocol == IntPtr.Zero )
						throw new RegistrationException( "Can't find protocol named {0}", protocolAttribute.Name );

					CompatibilityLayer.class_addProtocol( result, protocol );
				}

				Tracer.Information( "Registering Objective-C class {0} ..", classNameToExport );
				Tracer.IncreaseLevel();

				// unmanaged --> transition class --> managed class
				var transitionTypeBuilder = _interopModuleBuilder.DefineType( "Transition" + type.FullName, TypeAttributes.Sealed | TypeAttributes.Public | TypeAttributes.BeforeFieldInit );
				var implementationTypeBuilder = _interopModuleBuilder.DefineType( "Implementation" + type.FullName, TypeAttributes.Sealed | TypeAttributes.Public | TypeAttributes.BeforeFieldInit, type );

				var methodTransitions = new List<MethodTransitionData>();
				var constructorTransitions = new List<ConstructorTransitionData>();

				// delegate constructors. without it we can't create object of proxy type.
				foreach( var constructorInfo in exportedConstructors )
				{
					var parameters = constructorInfo.GetParameters().Select( x => x.ParameterType ).ToArray();
					var constructor = implementationTypeBuilder.DefineConstructor( MethodAttributes.Public, CallingConventions.Standard, parameters );
					var body = constructor.GetILGenerator();

					body.Emit( OpCodes.Ldarg_0 );

					for( int i = 0; i < parameters.Length; i++ )
						body.Emit( OpCodes.Ldarg_S, i + 1 );

					body.Emit( OpCodes.Call, constructorInfo );
					body.Emit( OpCodes.Ret );

					constructorTransitions.Add( new ConstructorTransitionData( constructorInfo ) { Builder = constructor } );
				}

				// we need to create at least one ctor
				if( exportedConstructors.Count() == 0 )
				{
					var parameters = new Type[0];
					var missedDefaultConstructor = implementationTypeBuilder.DefineConstructor( MethodAttributes.Public, CallingConventions.Standard, parameters );
					var body = missedDefaultConstructor.GetILGenerator();

					body.Emit( OpCodes.Ret );

					constructorTransitions.Add( new ConstructorTransitionData { Builder = missedDefaultConstructor, Original = null, Parameters = parameters } );
				}

				var intPtrZeroField = typeof( IntPtr ).GetField( "Zero" );
				var nativeHandleField = implementationTypeBuilder.DefineField( "_nativeHandle", typeof( IntPtr ), FieldAttributes.Assembly );

				// implement "Handle" property
				var getHandleProperty = type.GetProperty( "Handle", BindingFlags.Public | BindingFlags.Instance );
				if( getHandleProperty != null )
				{
					Tracer.Information( "Generating body for {0} {1} property..", getHandleProperty.PropertyType, getHandleProperty.Name );

					var property = implementationTypeBuilder.DefineProperty( getHandleProperty.Name, PropertyAttributes.None, getHandleProperty.PropertyType, new Type[] { } );

					var get = implementationTypeBuilder.DefineMethod( "get_" + getHandleProperty.Name, MethodAttributes.Public | MethodAttributes.Virtual, getHandleProperty.PropertyType, new Type[] { } );
					var getBody = get.GetILGenerator();

					getBody.Emit( OpCodes.Ldarg_0 );
					getBody.Emit( OpCodes.Ldfld, nativeHandleField );
					getBody.Emit( OpCodes.Newobj, typeof( RuntimeObject ).GetConstructor( new[] { typeof( IntPtr ) } ) );
					getBody.Emit( OpCodes.Ret );

					property.SetGetMethod( get );
				}
				else
					throw new RegistrationException( "Why Handle not found???" );

				// implement base class handle
				FieldBuilder baseClassField;
				{
					baseClassField = implementationTypeBuilder.DefineField( "_baseClass", typeof( RuntimeClass ), FieldAttributes.Assembly | FieldAttributes.Static );

					var cctor = implementationTypeBuilder.DefineConstructor( MethodAttributes.Static, CallingConventions.Standard, null );
					var body = cctor.GetILGenerator();

					body.Emit( OpCodes.Ldstr, baseClass.Name );
					body.Emit( OpCodes.Newobj, typeof( RuntimeClass ).GetConstructor( new[] { typeof( string ) } ) );
					body.Emit( OpCodes.Stsfld, baseClassField );

					body.Emit( OpCodes.Ret );
				}

				Func<PropertyInfo, bool> getDefined = x => x.GetGetMethod() != null;
				Func<PropertyInfo, bool> setDefined = x => x.GetSetMethod() != null;

				Func<PropertyInfo, bool> getAbstract = x => ( x.GetGetMethod().Attributes & MethodAttributes.Abstract ) != 0;
				Func<PropertyInfo, bool> setAbstract = x => ( x.GetSetMethod().Attributes & MethodAttributes.Abstract ) != 0;

				Func<PropertyInfo, bool> getDefinedAndAbstract = x => getDefined( x ) && getAbstract( x );
				Func<PropertyInfo, bool> setDefinedAndAbstract = x => setDefined( x ) && setAbstract( x );

				// find ivar-accessors. since they abstract they will not be added to metaclass
				IEnumerable<PropertyInfo> exportedIvars = type.GetProperties( BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly ).Where( x => ( getDefinedAndAbstract( x ) && !setDefined( x ) ) || ( !getDefined( x ) && setDefinedAndAbstract( x ) ) || ( getDefinedAndAbstract( x ) && setDefinedAndAbstract( x ) ) );

				if( exportedIvars.Any( x => x.PropertyType == typeof( string ) ) )
					throw new RegistrationException( "String ivars not implemented!" );

				if( exportedIvars.Any( x => !x.PropertyType.IsValueType ) )
					throw new RegistrationException( "Only value-type ivars supported" );

				// register ivars
				foreach( var propertyInfo in exportedIvars )
				{
					int variableSize;
					string variableEncoding;

					if( propertyInfo.PropertyType.IsValueType )
					{
						variableSize = Marshal.SizeOf( propertyInfo.PropertyType );
						variableEncoding = RuntimeMethodEncoding.EncodeType( propertyInfo.PropertyType );
					}
					else
					{
						variableSize = IntPtr.Size;
						variableEncoding = RuntimeMethodEncoding.EncodeType( typeof( IntPtr ) );
					}

					Tracer.Information( "Adding ivar {0} from type {1} with size = {2}; encoding = {3}", propertyInfo.Name, propertyInfo.PropertyType.Name, variableSize, variableEncoding );
					CompatibilityLayer.class_addIvar( result, propertyInfo.Name, variableSize, 0, variableEncoding );
				}

				// implement ivars properties
				foreach( var propertyInfo in exportedIvars )
				{
					var exportedIvar = new RuntimeVariable( result, propertyInfo.Name );
					var property = implementationTypeBuilder.DefineProperty( propertyInfo.Name, PropertyAttributes.None, propertyInfo.PropertyType, new Type[] { } );

					var get = implementationTypeBuilder.DefineMethod( "get_" + propertyInfo.Name, MethodAttributes.Public | MethodAttributes.Virtual, propertyInfo.PropertyType, new Type[] { } );
					var set = implementationTypeBuilder.DefineMethod( "set_" + propertyInfo.Name, MethodAttributes.Public | MethodAttributes.Virtual, typeof( void ), new[] { propertyInfo.PropertyType } );

					var getBody = get.GetILGenerator();
					var setBody = set.GetILGenerator();

					var objectValid = getBody.DefineLabel();

					// check native handle
					getBody.Emit( OpCodes.Ldarg_0 );
					getBody.Emit( OpCodes.Ldfld, nativeHandleField );
					getBody.Emit( OpCodes.Brtrue, objectValid );
					getBody.Emit( OpCodes.Newobj, typeof( ObjectReleasedException ).GetConstructor( new Type[] { } ) );
					getBody.Emit( OpCodes.Throw );

					getBody.MarkLabel( objectValid );
					getBody.Emit( OpCodes.Ldarg_0 );
					getBody.Emit( OpCodes.Ldfld, nativeHandleField );
					getBody.Emit( OpCodes.Ldc_I4, exportedIvar.Offset );
					getBody.Emit( OpCodes.Add );
					getBody.Emit( OpCodes.Ldobj, propertyInfo.PropertyType );

					getBody.Emit( OpCodes.Ret );

					objectValid = setBody.DefineLabel();
					// check native handle
					setBody.Emit( OpCodes.Ldarg_0 );
					setBody.Emit( OpCodes.Ldfld, nativeHandleField );
					setBody.Emit( OpCodes.Brtrue, objectValid );
					setBody.Emit( OpCodes.Newobj, typeof( ObjectReleasedException ).GetConstructor( new Type[] { } ) );
					setBody.Emit( OpCodes.Throw );

					setBody.MarkLabel( objectValid );
					setBody.Emit( OpCodes.Ldarg_0 );
					setBody.Emit( OpCodes.Ldfld, nativeHandleField );
					setBody.Emit( OpCodes.Ldc_I4, exportedIvar.Offset );
					setBody.Emit( OpCodes.Add );
					setBody.Emit( OpCodes.Ldarg_1 );
					setBody.Emit( OpCodes.Stobj, propertyInfo.PropertyType );

					setBody.Emit( OpCodes.Ret );

					property.SetGetMethod( get );
					property.SetSetMethod( set );
				}

				// [RegisteredClass init]
				// 1) native part already created by objc runtime
				// 2) so we need create managed part and call appropriate ctor
				// 3) setup _nativeHandle to native part
				// 4) aquire tracking GCHandle to managed part and write it to native part
				int counter = 0;
				int argumentsBias = ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.X86 ? 4 : 0;

				foreach( var constructor in constructorTransitions )
				{
					var parameters = new[] { typeof( RuntimeObject ), typeof( Selector ) }.Concat( constructor.Parameters ).ToArray();
					var nativeReturnType = typeof( ObjectMark* );

					if( ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.X86 )
						parameters = new[] { typeof( int* ), typeof( int* ), typeof( int ), typeof( int ) }.Concat( parameters ).ToArray();

					for( int i = 0; i < parameters.Length; i++ )
					{
						if( parameters[i] == typeof( string ) )
							parameters[i] = typeof( RuntimeObject );
					}

					var constructorTransitionMethod = transitionTypeBuilder.DefineMethod( "-ctor" + counter, MethodAttributes.Public | MethodAttributes.Static, nativeReturnType, parameters );

					for( int i = 0; i < constructor.Parameters.Length; i++ )
						constructorTransitionMethod.DefineParameter( argumentsBias + i + 3, ParameterAttributes.None, constructor.ParameterNames[i] );

					var body = constructorTransitionMethod.GetILGenerator();
					var exitLabel = body.DefineLabel();

					var resultLocal = body.DeclareLocal( nativeReturnType );
					var exceptionLocal = body.DeclareLocal( typeof( IntPtr ) );

					body.BeginExceptionBlock();
					{
						for( int i = 0; i < constructor.Parameters.Length; i++ )
						{
							if( constructor.Parameters[i] == typeof( string ) )
							{
								body.Emit( OpCodes.Ldarga, argumentsBias + i + 2 );
								body.Emit( OpCodes.Conv_U );

								body.Emit( OpCodes.Ldobj, typeof( IntPtr ) );
								body.Emit( OpCodes.Call, typeof( Runtime ).GetMethod( "UnwrapNSString" ) );
							}
							else
							{
								body.Emit( OpCodes.Ldarg, argumentsBias + i + 2 );
							}
						}

						var createdManagedObject = body.DeclareLocal( implementationTypeBuilder );

						// ctor can throw so write "0" to native part
						body.Emit( OpCodes.Ldarga, argumentsBias );
						body.Emit( OpCodes.Conv_U );
						body.Emit( OpCodes.Ldobj, typeof( IntPtr ) );
						body.Emit( OpCodes.Ldc_I4, IntPtr.Size );
						body.Emit( OpCodes.Add );
						body.Emit( OpCodes.Ldc_I4, 0 );
						body.Emit( OpCodes.Stobj, typeof( IntPtr ) );

						// create implementation proxy
						body.Emit( OpCodes.Newobj, constructor.Builder );
						body.Emit( OpCodes.Stloc, createdManagedObject );

						// store pointer to object in it
						body.Emit( OpCodes.Ldloc, createdManagedObject );
						body.Emit( OpCodes.Ldarga, argumentsBias );
						body.Emit( OpCodes.Conv_U );
						body.Emit( OpCodes.Ldobj, typeof( IntPtr ) );
						body.Emit( OpCodes.Stfld, nativeHandleField );

						// store gchandle in unmanaged part
						body.Emit( OpCodes.Ldarga, argumentsBias );
						body.Emit( OpCodes.Conv_U );
						body.Emit( OpCodes.Ldobj, typeof( IntPtr ) );
						body.Emit( OpCodes.Ldc_I4, IntPtr.Size );
						body.Emit( OpCodes.Add );
						body.Emit( OpCodes.Ldloc, createdManagedObject );
						body.EmitCall( OpCodes.Call, typeof( GCHandle ).GetMethod( "Alloc", new[] { typeof( object ) } ), null );
						body.Emit( OpCodes.Stobj, typeof( GCHandle ) );

						body.Emit( OpCodes.Ldarga, argumentsBias );
						body.Emit( OpCodes.Conv_U );
						body.Emit( OpCodes.Ldobj, typeof( IntPtr ) );
						body.Emit( OpCodes.Stloc, resultLocal );

						if( ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.X86 )
						{
							body.Emit( OpCodes.Ldarg, 0 );
							body.Emit( OpCodes.Ldnull );
							body.Emit( OpCodes.Stind_I );
						}
						else if( ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.PPC )
						{
							body.Emit( OpCodes.Ldarga, 1 );
							body.Emit( OpCodes.Conv_U );
							body.Emit( OpCodes.Ldobj, typeof( IntPtr ) );
							body.Emit( OpCodes.Ldnull );
							body.Emit( OpCodes.Stind_I );
						}

						body.Emit( OpCodes.Leave, exitLabel );
					}
					body.BeginCatchBlock( typeof( object ) );
					{
						if( ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.X86 )
						{
							body.Emit( OpCodes.Call, typeof( Runtime ).GetMethod( "CreateExceptionProxy" ) );
							body.Emit( OpCodes.Stloc, exceptionLocal );
							body.Emit( OpCodes.Ldarg, 0 );
							body.Emit( OpCodes.Ldloc, exceptionLocal );
							body.Emit( OpCodes.Stind_I );
						}
						else if( ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.PPC )
						{
							body.Emit( OpCodes.Call, typeof( Runtime ).GetMethod( "CreateExceptionProxy" ) );
							body.Emit( OpCodes.Stloc, exceptionLocal );
							body.Emit( OpCodes.Ldarga, 1 );
							body.Emit( OpCodes.Conv_U );
							body.Emit( OpCodes.Ldobj, typeof( IntPtr ) );
							body.Emit( OpCodes.Ldloc, exceptionLocal );
							body.Emit( OpCodes.Stind_I );
						}
						else
							body.Emit( OpCodes.Pop );

						body.Emit( OpCodes.Leave, exitLabel );
					}
					body.EndExceptionBlock();

					body.MarkLabel( exitLabel );
					body.Emit( OpCodes.Ldloc, resultLocal );
					body.Emit( OpCodes.Ret );

					var retrieveAddressMethod = transitionTypeBuilder.DefineMethod( "&ctor" + counter, MethodAttributes.Public | MethodAttributes.Static, typeof( IntPtr ), new Type[] { } );
					body = retrieveAddressMethod.GetILGenerator();

					body.Emit( OpCodes.Ldftn, constructorTransitionMethod );
					body.Emit( OpCodes.Ret );

					counter++;
				}

				foreach( var item in exportedMethods )
					methodTransitions.Add( new MethodTransitionData( item ) );

				// [object hash]
				// create new method on each override to provide supercall ability from Objective-C code
				var overridenGetHashCode = type.GetMethods( BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly ).FirstOrDefault( x => x.GetBaseDefinition() == getHashcodeBase );
				if( overridenGetHashCode != null )
				{
					var selector = "hash";
					var parameters = new Type[] { };
					var returnType = typeof( uint );

					var hash = implementationTypeBuilder.DefineMethod( selector, MethodAttributes.Public, returnType, parameters );
					var body = hash.GetILGenerator();

					body.Emit( OpCodes.Ldarg_0 );
					body.Emit( OpCodes.Call, overridenGetHashCode );
					body.Emit( OpCodes.Ret );

					methodTransitions.Add( new MethodTransitionData { Name = selector, Builder = hash, IsStatic = false, ReturnType = returnType, Parameters = parameters } );
				}

				// [object description]
				// create new method on each override to provide supercall ability from Objective-C code
				var overridenToString = type.GetMethods( BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly ).FirstOrDefault( x => x.GetBaseDefinition() == toStringBase );
				if( overridenToString != null )
				{
					var selector = "description";
					var parameters = new Type[] { };
					var returnType = typeof( string );

					var description = implementationTypeBuilder.DefineMethod( selector, MethodAttributes.Public, returnType, parameters );
					var body = description.GetILGenerator();

					body.Emit( OpCodes.Ldarg_0 );
					body.Emit( OpCodes.Call, overridenToString );
					body.Emit( OpCodes.Ret );

					methodTransitions.Add( new MethodTransitionData { Name = selector, Builder = description, IsStatic = false, ReturnType = returnType, Parameters = parameters } );
				}

				// for each exported method create appropriate static method in transitionType which have two additional parameters - raw pointer to objc object and selector to perform.
				// these generated methods will be directly called from objc runtime
				counter = 0;
				foreach( var method in methodTransitions )
				{
					var arguments = new[] { typeof( RuntimeObject ), typeof( Selector ) }.Concat( method.Parameters ).ToArray();

					if( ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.X86 )
						arguments = new[] { typeof( int* ), typeof( int* ), typeof( int ), typeof( int ) }.Concat( arguments ).ToArray();

					var nativeReturnType = method.ReturnType;

					// signature should not contain managed arguments
					for( int i = 0; i < arguments.Length; i++ )
					{
						if( arguments[i] == typeof( string ) )
							arguments[i] = typeof( RuntimeObject );
					}

					if( nativeReturnType == typeof( string ) )
						nativeReturnType = typeof( ObjectMark* );

					var proxyReturnType = nativeReturnType;
					bool isReturnTypeObjectProxy = nativeReturnType == typeof( RuntimeObject ) || nativeReturnType == typeof( RuntimeClass ) || proxyReturnType.Namespace == "NObjective.Proxies";

					if( isReturnTypeObjectProxy )
						nativeReturnType = typeof( ObjectMark* );

					var methodTransitionMethod = transitionTypeBuilder.DefineMethod( ( method.IsStatic ? "+" : "-" ) + "method" + counter, MethodAttributes.Public | MethodAttributes.Static, nativeReturnType, arguments );
					// copy parameter names
					for( int i = 0; i < method.Parameters.Length; i++ )
						methodTransitionMethod.DefineParameter( argumentsBias + i + 3, ParameterAttributes.None, method.ParameterNames[i] );

					var body = methodTransitionMethod.GetILGenerator();
					var exitLabel = body.DefineLabel();

					LocalBuilder resultLocal = null;
					var exceptionLocal = body.DeclareLocal( typeof( IntPtr ) );

					if( nativeReturnType != typeof( void ) )
						resultLocal = body.DeclareLocal( nativeReturnType );

					body.BeginExceptionBlock();
					{
						// get managed target
						if( !method.IsStatic )
						{
							body.Emit( OpCodes.Ldarga, argumentsBias );
							body.Emit( OpCodes.Conv_U );

							body.Emit( OpCodes.Ldobj, typeof( IntPtr ) );
							body.Emit( OpCodes.Sizeof, typeof( IntPtr ) );
							body.Emit( OpCodes.Add );
							body.Emit( OpCodes.Call, typeof( GCHandle ).GetProperty( "Target" ).GetGetMethod() );
						}

						// skip target/selector
						for( int i = 0; i < method.Parameters.Length; i++ )
						{
							if( method.Parameters[i] == typeof( string ) )
							{
								body.Emit( OpCodes.Ldarga, argumentsBias + i + 2 );
								body.Emit( OpCodes.Conv_U );

								body.Emit( OpCodes.Ldobj, typeof( IntPtr ) );
								body.Emit( OpCodes.Call, typeof( Runtime ).GetMethod( "UnwrapNSString" ) );
							}
							else
							{
								body.Emit( OpCodes.Ldarg, argumentsBias + i + 2 );
							}
						}

						if( method.Original != null )
							body.Emit( OpCodes.Call, method.Original );
						else if( method.Builder != null )
							body.Emit( OpCodes.Call, method.Builder );
						else
							throw new RegistrationException( "Specify what to call!" );

						// return to objc NSString proxy
						if( method.ReturnType == typeof( string ) )
						{
							body.Emit( OpCodes.Call, typeof( Runtime ).GetMethod( "CreateStringProxy" ) );
							body.Emit( OpCodes.Call, typeof( Runtime ).GetMethod( "AutoreleaseNativeObject" ) );
						}

						if( nativeReturnType != typeof( void ) )
						{
							if( isReturnTypeObjectProxy )
							{
								body.Emit( OpCodes.Call, proxyReturnType.GetMethods( BindingFlags.Static | BindingFlags.Public ).FirstOrDefault( x => x.Name == "op_Implicit" && x.ReturnType == typeof( IntPtr ) ) );
								body.Emit( OpCodes.Stloc, resultLocal );
							}
							else
								body.Emit( OpCodes.Stloc, resultLocal );
						}

						if( ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.X86 )
						{
							body.Emit( OpCodes.Ldarg, 0 );
							body.Emit( OpCodes.Ldnull );
							body.Emit( OpCodes.Stind_I );
						}
						else if( ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.PPC )
						{
							body.Emit( OpCodes.Ldarga, 1 );
							body.Emit( OpCodes.Conv_U );
							body.Emit( OpCodes.Ldobj, typeof( IntPtr ) );
							body.Emit( OpCodes.Ldsfld, intPtrZeroField );
							body.Emit( OpCodes.Stind_I );
						}

						body.Emit( OpCodes.Leave_S, exitLabel );
					}
					body.BeginCatchBlock( typeof( object ) );
					{
						if( ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.X86 )
						{
							body.Emit( OpCodes.Call, typeof( Runtime ).GetMethod( "CreateExceptionProxy" ) );
							body.Emit( OpCodes.Stloc, exceptionLocal );
							body.Emit( OpCodes.Ldarg, 0 );
							body.Emit( OpCodes.Ldloc, exceptionLocal );
							body.Emit( OpCodes.Stind_I );
						}
						else if( ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.PPC )
						{
							body.Emit( OpCodes.Call, typeof( Runtime ).GetMethod( "CreateExceptionProxy" ) );
							body.Emit( OpCodes.Stloc, exceptionLocal );
							body.Emit( OpCodes.Ldarga, 1 );
							body.Emit( OpCodes.Conv_U );
							body.Emit( OpCodes.Ldobj, typeof( IntPtr ) );
							body.Emit( OpCodes.Ldloc, exceptionLocal );
							body.Emit( OpCodes.Stind_I );
						}
						else
							body.Emit( OpCodes.Pop );

						body.Emit( OpCodes.Leave_S, exitLabel );
					}
					body.EndExceptionBlock();

					body.MarkLabel( exitLabel );

					if( nativeReturnType != typeof( void ) )
						body.Emit( OpCodes.Ldloc, resultLocal );

					body.Emit( OpCodes.Ret );

					var retrieveAddressMethod = transitionTypeBuilder.DefineMethod( "&method" + counter, MethodAttributes.Public | MethodAttributes.Static, typeof( IntPtr ), new Type[] { } );
					body = retrieveAddressMethod.GetILGenerator();

					body.Emit( OpCodes.Ldftn, methodTransitionMethod );
					body.Emit( OpCodes.Ret );

					counter++;
				}

				var additionalNothrowTransitionMethods = new List<SpecialMethodTransitionData>();

				// Add method to access managed object from native runtime
				// [object __get_exported_class_managed_handle_from_native_object]
				if( isFirstHierarchyProxy )
				{
					var selector = Runtime.GetManagedHandleReservedFunctionName;
					var parameters = new Type[] { typeof( ObjectMark* ), typeof( Selector ) };
					var returnType = typeof( IntPtr );

					var method = transitionTypeBuilder.DefineMethod( selector, MethodAttributes.Public | MethodAttributes.Static, returnType, parameters );
					var body = method.GetILGenerator();

					body.Emit( OpCodes.Ldarg_0 );
					body.Emit( OpCodes.Sizeof, typeof( IntPtr ) );
					body.Emit( OpCodes.Add );
					body.Emit( OpCodes.Ldobj, typeof( IntPtr ) );
					body.Emit( OpCodes.Ret );

					additionalNothrowTransitionMethods.Add( new SpecialMethodTransitionData { Name = selector, Builder = method } );
				}

				// [object dealloc]
				// define it for each child in hierarchy
				{
					var selector = "dealloc";
					var parameters = new[] { typeof( RuntimeObject ), typeof( Selector ) };
					var returnType = typeof( void );

					var method = transitionTypeBuilder.DefineMethod( selector, MethodAttributes.Public | MethodAttributes.Static, returnType, parameters );
					var body = method.GetILGenerator();
					var exit = body.DefineLabel();

					var gchandle = body.DeclareLocal( typeof( IntPtr ) );
					var managedObject = body.DeclareLocal( typeof( RuntimeExportBase ) );

					// load gchandle
					body.Emit( OpCodes.Ldarga, 0 );
					body.Emit( OpCodes.Conv_U );
					body.Emit( OpCodes.Ldobj, typeof( IntPtr ) );
					body.Emit( OpCodes.Sizeof, typeof( IntPtr ) );
					body.Emit( OpCodes.Add );
					body.Emit( OpCodes.Ldobj, typeof( IntPtr ) );
					body.Emit( OpCodes.Stloc, gchandle );

					// check gchandle
					body.Emit( OpCodes.Ldloc, gchandle );
					body.Emit( OpCodes.Brfalse, exit );

					// load managed handle
					if( declaredDealloc != null || isFirstHierarchyProxy )
					{
						body.Emit( OpCodes.Ldloca, gchandle );
						body.Emit( OpCodes.Call, typeof( GCHandle ).GetProperty( "Target" ).GetGetMethod() );
						body.Emit( OpCodes.Stloc, managedObject );
					}

					if( declaredDealloc != null )
					{
						body.BeginExceptionBlock();
						{
							body.Emit( OpCodes.Ldloc, managedObject );
							body.Emit( OpCodes.Call, declaredDealloc );
						}
						body.BeginCatchBlock( typeof( object ) );
						{
							body.Emit( OpCodes.Pop );
						}
						body.EndExceptionBlock();
					}

					// send "dealloc" to superclass
					body.BeginExceptionBlock();
					{
						body.Emit( OpCodes.Ldarga, 0 );
						body.Emit( OpCodes.Conv_U );
						body.Emit( OpCodes.Ldobj, typeof( IntPtr ) );
						body.Emit( OpCodes.Ldsfld, baseClassField );
						body.Emit( OpCodes.Ldsfld, typeof( Selectors ).GetField( "dealloc", BindingFlags.Static | BindingFlags.Public ) );
						body.Emit( OpCodes.Call, typeof( Runtime ).GetMethod( "SendMessageToBase", BindingFlags.Static | BindingFlags.Public ) );
					}
					body.BeginCatchBlock( typeof( object ) );
					{
						body.Emit( OpCodes.Pop );
					}
					body.EndExceptionBlock();

					if( isFirstHierarchyProxy )
					{
						// write 0 to _nativeHandle
						body.Emit( OpCodes.Ldloc, managedObject );
						body.Emit( OpCodes.Ldsfld, intPtrZeroField );
						body.Emit( OpCodes.Stfld, nativeHandleField );

						// release gchandle
						body.Emit( OpCodes.Ldloca, gchandle );
						body.Emit( OpCodes.Call, typeof( GCHandle ).GetMethod( "Free", new Type[] { } ) );
					}

					body.MarkLabel( exit );
					body.Emit( OpCodes.Ret );

					additionalNothrowTransitionMethods.Add( new SpecialMethodTransitionData { Name = selector, Builder = method } );
				}

				// create address retrieval methods for specials
				foreach( var special in additionalNothrowTransitionMethods )
				{
					var retrieveAddressMethod = transitionTypeBuilder.DefineMethod( "&" + special.Name, MethodAttributes.Public | MethodAttributes.Static, typeof( IntPtr ), new Type[] { } );
					var body = retrieveAddressMethod.GetILGenerator();

					body.Emit( OpCodes.Ldftn, special.Builder );
					body.Emit( OpCodes.Ret );
				}

				Tracer.Information( "Create transition proxy.." );
				// methods from that class directly called from native code. so it just redirects that calls to implementation proxy.
				var transitionProxy = transitionTypeBuilder.CreateType();
				Tracer.Information( "Transition proxy available methods:" );

				Tracer.IncreaseLevel();
				foreach( var item in transitionProxy.GetMethods() )
					Tracer.Information( "{0}", item.ToString() );

				Tracer.DecreaseLevel();

				Tracer.Information( "Create implementation proxy.." );
				// used to implement ivars accessors etc.. native code creates this type.
				var implementationProxy = implementationTypeBuilder.CreateType();

				// add special methods
				foreach( var special in additionalNothrowTransitionMethods )
					CompatibilityLayer.class_addMethod( result, special.Name, ( IntPtr ) transitionProxy.GetMethod( "&" + special.Name ).Invoke( null, null ), RuntimeMethodEncoding.GetEncoding( transitionProxy.GetMethod( special.Name ), RuntimeMethodEncoding.Options.TransitionMethod ) );

				// register methods from transitionProxy
				for( counter = 0; counter < methodTransitions.Count; counter++ )
				{
					var methodInfo = methodTransitions[counter].Original ?? implementationProxy.GetMethod( methodTransitions[counter].Name );

					var transitionMethodInfo = transitionProxy.GetMethod( ( methodInfo.IsStatic ? "+" : "-" ) + "method" + counter );
					var addTo = methodInfo.IsStatic ? metaclass : result;

					var selector = new Selector( methodInfo, Selector.Options.None );
					var encoding = RuntimeMethodEncoding.GetEncoding( transitionMethodInfo, RuntimeMethodEncoding.Options.TransitionMethod | ( ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.X86 ? RuntimeMethodEncoding.Options.StripExceptionParameters : 0 ) );
					var address = ( IntPtr ) transitionProxy.GetMethod( "&method" + counter ).Invoke( null, null );

					Tracer.Information( "Adding method {0} from {1} {2}({3}) to {4} with encoding = {5}, address = {6:X}", selector, transitionMethodInfo.ReturnType.Name, transitionMethodInfo.Name, string.Join( ", ", transitionMethodInfo.GetParameters().Select( x => x.Name + " " + x.ParameterType ).ToArray() ), addTo == metaclass ? "metaclass" : "class", encoding, ( int ) address );

					if( ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.X86 || ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.PPC )
						address = ExceptionBarrierManager.Instance.Allocate( address );

					CompatibilityLayer.class_addMethod( addTo, selector, address, encoding );
				}

				// add constructors with value-type arguments
				for( counter = 0; counter < constructorTransitions.Count; counter++ )
				{
					var constructorInfo = transitionProxy.GetMethod( "-ctor" + counter );

					var constructorName = new Selector( constructorInfo, Selector.Options.Transition | Selector.Options.Constructor | ( ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.X86 ? Selector.Options.StripExceptionParameters : 0 ) );
					var constructorEncodedName = RuntimeMethodEncoding.GetEncoding( constructorInfo, RuntimeMethodEncoding.Options.TransitionMethod | ( ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.X86 ? RuntimeMethodEncoding.Options.StripExceptionParameters : 0 ) );

					var nativeMethodAddress = ( IntPtr ) transitionProxy.GetMethod( "&ctor" + counter ).Invoke( null, null );

					Tracer.Information( "Adding constructor {0} from {1}({2}) to class with encoding = {3}, address = {4}", constructorName, constructorInfo.Name, string.Join( ", ", constructorInfo.GetParameters().Select( x => x.Name + " " + x.ParameterType ).ToArray() ), constructorEncodedName, nativeMethodAddress.ToString( "X8" ) );

					if( ExceptionBarrierManager.Type != ExceptionBarrierManager.BarrierType.None )
						nativeMethodAddress = ExceptionBarrierManager.Instance.Allocate( nativeMethodAddress );

					CompatibilityLayer.class_addMethod( result, constructorName, nativeMethodAddress, constructorEncodedName );
				}

				Tracer.DecreaseLevel();

				CompatibilityLayer.objc_registerClassPair( result );

				Tracer.Information( "{0}", result.ToString() );
				Tracer.Information( "{0}", result.MetaClass.ToString() );

				return result;
			}
			catch( Exception )
			{
				CompatibilityLayer.objc_disposeClassPair( result );
				throw;
			}
		}

		/// <summary>
		/// Export type which derived from RuntimeExportBase to Objective-C runtime.
		/// </summary>
		/// <param name="type">Type to register.</param>
		/// <returns>RuntimeClass class instance that represents newly created Objective-C class.</returns>
		public static unsafe RuntimeClass ExportStructure( Type type )
		{
			var classNameToExport = GetExportedClassName( type );
			var existingClass = new RuntimeClass( classNameToExport );

			// class exists
			if( existingClass != RuntimeClass.Null )
				throw new RegistrationException( "Class {0} already registered!", classNameToExport );

			if( type.IsClass )
				throw new RegistrationException( "Registering of class types is not supported" );

			if( type.IsInterface )
				throw new RegistrationException( "Registering of interfaces is not supported" );

			// add ivars, accessible by properties
			Func<ParameterInfo, bool> parameterFilter = x => x.ParameterType.IsValueType || x.ParameterType == typeof( string ) || x.ParameterType.IsPointer;

			var exportedMethods = type.GetMethods( BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly ).Where( x => x.GetParameters().All( parameterFilter ) ).Where( x => !type.GetProperties( BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.DeclaredOnly ).Where( y => !y.IsDefined( typeof( PropertySynthesisAttribute ), false ) ).SelectMany( y => y.GetAccessors() ).Contains( x ) ).ToArray();
			var exportedConstructors = type.GetConstructors( BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.NonPublic ).Where( x => ( x.Attributes & ( MethodAttributes.Family | MethodAttributes.Public ) ) != 0 ).Where( x => x.GetParameters().All( parameterFilter ) ).ToArray();

			Tracer.Information( "Following methods will be exported:" );
			Tracer.IncreaseLevel();

			foreach( var method in exportedMethods )
				Tracer.Information( "{0}", method );

			Tracer.DecreaseLevel();

			Tracer.Information( "Following constructors will be exported:" );
			Tracer.IncreaseLevel();

			foreach( var constructor in exportedConstructors )
				Tracer.Information( "{0}", constructor );

			Tracer.DecreaseLevel();

			// check renaming errors
			{
				var methodWithRenamedParameter = exportedMethods.Where( x => x.GetParameters().Length > 0 ).FirstOrDefault( x => x.GetParameters()[0].IsDefined( typeof( ParameterNameAttribute ), true ) );

				if( methodWithRenamedParameter != null )
					throw new RegistrationException( "{0} on first parameter of method {1} makes no sense!", typeof( ParameterNameAttribute ).Name, methodWithRenamedParameter.Name );

				var ctorWithRenamedParameter = exportedConstructors.Where( x => x.GetParameters().Length > 0 ).FirstOrDefault( x => x.GetParameters()[0].IsDefined( typeof( ParameterNameAttribute ), true ) );

				if( ctorWithRenamedParameter != null )
					throw new RegistrationException( "{0} on first parameter of constructor {1} makes no sense!", typeof( ParameterNameAttribute ).Name, ctorWithRenamedParameter.Name );

				var incorrectlyRenamedMethod = exportedMethods.Where( x => x.IsDefined( typeof( SelectorAttribute ), true ) ).FirstOrDefault( x => new Selector( x.GetCustomAttribute<SelectorAttribute>( true ).Selector ).ParametersCount != x.GetParameters().Length );

				if( incorrectlyRenamedMethod != null )
					throw new RegistrationException( "Selector for {0} is malformed", incorrectlyRenamedMethod.Name );
			}

			RuntimeClass baseClass;

			if( type.IsDefined( typeof( BaseClassAttribute ), false ) )
			{
				var baseClassName = type.GetCustomAttribute<BaseClassAttribute>( false ).Base;
				baseClass = new RuntimeClass( baseClassName );

				if( baseClass == RuntimeClass.Null )
					throw new RegistrationException( "Can't find {0} base class", baseClassName );
			}
			else
				baseClass = new RuntimeClass( "NSObject" );

			var result = new RuntimeClass( CompatibilityLayer.objc_allocateClassPair( baseClass, classNameToExport, 0 ) );
			var metaclass = result.MetaClass;

			try
			{
				if( result == RuntimeClass.Null )
					throw new RegistrationException( "Can't register class " + classNameToExport + "!" );

				foreach( AdoptedProtocolAttribute protocolAttribute in type.GetCustomAttributes( typeof( AdoptedProtocolAttribute ), false ) )
				{
					var protocol = CompatibilityLayer.objc_getProtocol( protocolAttribute.Name );

					if( protocol == IntPtr.Zero )
						throw new RegistrationException( "Can't find protocol named {0}", protocolAttribute.Name );

					CompatibilityLayer.class_addProtocol( result, protocol );
				}

				Tracer.Information( "Registering Objective-C class {0} ..", classNameToExport );
				Tracer.IncreaseLevel();

				// unmanaged --> transition class --> managed structure
				var transitionTypeBuilder = _interopModuleBuilder.DefineType( "Transition" + type.FullName, TypeAttributes.Sealed | TypeAttributes.Public | TypeAttributes.BeforeFieldInit );

				var methodTransitions = new List<MethodTransitionData>();
				var constructorTransitions = new List<ConstructorTransitionData>();

				var intPtrZeroField = typeof( IntPtr ).GetField( "Zero" );
				var nativeHandleField = type.GetField( "_isa", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic );
				if( nativeHandleField == null )
					throw new RegistrationException( @"""_isa"" instance field not found!" );

				if( nativeHandleField.FieldType != typeof( RuntimeClass ) )
					throw new RegistrationException( @"""_isa"" field should be of type RuntimeClass!" );

				if( Marshal.OffsetOf( type, "_isa" ) != IntPtr.Zero )
					throw new RegistrationException( @"""_isa"" field should be first field!" );

				// find ivar-accessors. since they abstract they will not be added to metaclass
				IEnumerable<FieldInfo> exportedIvars = type.GetFields( BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly ).Where( x => x.Name != "_isa" );

				if( exportedIvars.Any( x => !x.FieldType.IsValueType ) )
					throw new RegistrationException( "Only value-type ivars supported" );

				// register ivars
				foreach( var propertyInfo in exportedIvars )
				{
					int variableSize;
					string variableEncoding;

					variableSize = Marshal.SizeOf( propertyInfo.FieldType );
					variableEncoding = RuntimeMethodEncoding.EncodeType( propertyInfo.FieldType );

					Tracer.Information( "Adding ivar {0} from type {1} with size = {2}; encoding = {3}", propertyInfo.Name, propertyInfo.FieldType.Name, variableSize, variableEncoding );
					CompatibilityLayer.class_addIvar( result, propertyInfo.Name, variableSize, 0, variableEncoding );

					if( new RuntimeVariable( result, propertyInfo.Name ).Offset != Marshal.OffsetOf( type, propertyInfo.Name ).ToInt32() )
						throw new RegistrationException( "Field layout should be equal!" );
				}

				// implement base class handle
				FieldBuilder baseClassField;
				{
					baseClassField = transitionTypeBuilder.DefineField( "_baseClass", typeof( RuntimeClass ), FieldAttributes.Assembly | FieldAttributes.Static );

					var cctor = transitionTypeBuilder.DefineConstructor( MethodAttributes.Static, CallingConventions.Standard, null );
					var body = cctor.GetILGenerator();

					body.Emit( OpCodes.Ldstr, baseClass.Name );
					body.Emit( OpCodes.Newobj, typeof( RuntimeClass ).GetConstructor( new[] { typeof( string ) } ) );
					body.Emit( OpCodes.Stsfld, baseClassField );

					body.Emit( OpCodes.Ret );
				}

				int counter = 0;
				int argumentsBias = ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.X86 ? 4 : 0;

				foreach( var item in exportedMethods )
					methodTransitions.Add( new MethodTransitionData( item ) );

				// for each exported method create appropriate static method in transitionType which have two additional parameters - raw pointer to objc object and selector to perform.
				// these generated methods will be directly called from objc runtime
				counter = 0;
				foreach( var method in methodTransitions )
				{
					var arguments = new[] { typeof( RuntimeObject ), typeof( Selector ) }.Concat( method.Parameters ).ToArray();

					if( ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.X86 )
						arguments = new[] { typeof( int* ), typeof( int* ), typeof( int ), typeof( int ) }.Concat( arguments ).ToArray();

					var nativeReturnType = method.ReturnType;

					// signature should not contain managed arguments
					for( int i = 0; i < arguments.Length; i++ )
					{
						if( arguments[i] == typeof( string ) )
							arguments[i] = typeof( RuntimeObject );
					}

					if( nativeReturnType == typeof( string ) )
						nativeReturnType = typeof( ObjectMark* );

					var proxyReturnType = nativeReturnType;
					bool isReturnTypeObjectProxy = nativeReturnType == typeof( RuntimeObject ) || nativeReturnType == typeof( RuntimeClass ) || proxyReturnType.Namespace == "NObjective.Proxies";

					if( isReturnTypeObjectProxy )
						nativeReturnType = typeof( ObjectMark* );

					var methodTransitionMethod = transitionTypeBuilder.DefineMethod( ( method.IsStatic ? "+" : "-" ) + "method" + counter, MethodAttributes.Public | MethodAttributes.Static, nativeReturnType, arguments );
					// copy parameter names
					for( int i = 0; i < method.Parameters.Length; i++ )
						methodTransitionMethod.DefineParameter( argumentsBias + i + 3, ParameterAttributes.None, method.ParameterNames[i] );

					var body = methodTransitionMethod.GetILGenerator();
					var exitLabel = body.DefineLabel();

					LocalBuilder resultLocal = null;
					var exceptionLocal = body.DeclareLocal( typeof( IntPtr ) );

					if( nativeReturnType != typeof( void ) )
						resultLocal = body.DeclareLocal( nativeReturnType );

					body.BeginExceptionBlock();
					{
						// get managed target
						if( !method.IsStatic )
						{
							body.Emit( OpCodes.Ldarga, argumentsBias );
							body.Emit( OpCodes.Conv_U );

							body.Emit( OpCodes.Ldobj, typeof( IntPtr ) );
						}

						// skip target/selector
						for( int i = 0; i < method.Parameters.Length; i++ )
						{
							if( method.Parameters[i] == typeof( string ) )
							{
								body.Emit( OpCodes.Ldarga, argumentsBias + i + 2 );
								body.Emit( OpCodes.Conv_U );

								body.Emit( OpCodes.Ldobj, typeof( IntPtr ) );
								body.Emit( OpCodes.Call, typeof( Runtime ).GetMethod( "UnwrapNSString" ) );
							}
							else
							{
								body.Emit( OpCodes.Ldarg, argumentsBias + i + 2 );
							}
						}

						body.Emit( OpCodes.Call, method.Original );

						// emit "dealloc" call for super class
						if( method.Original.Name == "dealloc" && method.Original.GetParameters().Length == 0 && !method.IsStatic )
						{
							if( method.Original.ReturnType != typeof( void ) )
								throw new RegistrationException( @"Invalid dealloc signature. Should be ""void dealloc()""" );

							body.Emit( OpCodes.Ldarga, argumentsBias );
							body.Emit( OpCodes.Conv_U );
							body.Emit( OpCodes.Ldobj, typeof( IntPtr ) );
							body.Emit( OpCodes.Ldsfld, baseClassField );
							body.Emit( OpCodes.Ldsfld, typeof( Selectors ).GetField( "dealloc", BindingFlags.Static | BindingFlags.Public ) );

							body.Emit( OpCodes.Call, typeof( Runtime ).GetMethod( "SendMessageToBase", BindingFlags.Static | BindingFlags.Public ) );
						}

						// return to objc NSString proxy
						if( method.ReturnType == typeof( string ) )
						{
							body.Emit( OpCodes.Call, typeof( Runtime ).GetMethod( "CreateStringProxy" ) );
							body.Emit( OpCodes.Call, typeof( Runtime ).GetMethod( "AutoreleaseNativeObject" ) );
						}

						if( nativeReturnType != typeof( void ) )
						{
							if( isReturnTypeObjectProxy )
							{
								body.Emit( OpCodes.Call, proxyReturnType.GetMethods( BindingFlags.Static | BindingFlags.Public ).FirstOrDefault( x => x.Name == "op_Implicit" && x.ReturnType == typeof( IntPtr ) ) );
								body.Emit( OpCodes.Stloc, resultLocal );
							}
							else
								body.Emit( OpCodes.Stloc, resultLocal );
						}

						if( ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.X86 )
						{
							body.Emit( OpCodes.Ldarg, 0 );
							body.Emit( OpCodes.Ldnull );
							body.Emit( OpCodes.Stind_I );
						}
						else if( ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.PPC )
						{
							body.Emit( OpCodes.Ldarga, 1 );
							body.Emit( OpCodes.Conv_U );
							body.Emit( OpCodes.Ldobj, typeof( IntPtr ) );
							body.Emit( OpCodes.Ldsfld, intPtrZeroField );
							body.Emit( OpCodes.Stind_I );
						}

						body.Emit( OpCodes.Leave_S, exitLabel );
					}
					body.BeginCatchBlock( typeof( object ) );
					{
						if( ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.X86 )
						{
							body.Emit( OpCodes.Call, typeof( Runtime ).GetMethod( "CreateExceptionProxy" ) );
							body.Emit( OpCodes.Stloc, exceptionLocal );
							body.Emit( OpCodes.Ldarg, 0 );
							body.Emit( OpCodes.Ldloc, exceptionLocal );
							body.Emit( OpCodes.Stind_I );
						}
						else if( ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.PPC )
						{
							body.Emit( OpCodes.Call, typeof( Runtime ).GetMethod( "CreateExceptionProxy" ) );
							body.Emit( OpCodes.Stloc, exceptionLocal );
							body.Emit( OpCodes.Ldarga, 1 );
							body.Emit( OpCodes.Conv_U );
							body.Emit( OpCodes.Ldobj, typeof( IntPtr ) );
							body.Emit( OpCodes.Ldloc, exceptionLocal );
							body.Emit( OpCodes.Stind_I );
						}
						else
							body.Emit( OpCodes.Pop );

						body.Emit( OpCodes.Leave_S, exitLabel );
					}
					body.EndExceptionBlock();

					body.MarkLabel( exitLabel );

					if( nativeReturnType != typeof( void ) )
						body.Emit( OpCodes.Ldloc, resultLocal );

					body.Emit( OpCodes.Ret );

					var retrieveAddressMethod = transitionTypeBuilder.DefineMethod( "&method" + counter, MethodAttributes.Public | MethodAttributes.Static, typeof( IntPtr ), new Type[] { } );
					body = retrieveAddressMethod.GetILGenerator();

					body.Emit( OpCodes.Ldftn, methodTransitionMethod );
					body.Emit( OpCodes.Ret );

					counter++;
				}

				Tracer.Information( "Create transition proxy.." );
				// methods from that class directly called from native code. so it just redirects that calls to implementation proxy.
				var transitionProxy = transitionTypeBuilder.CreateType();
				Tracer.Information( "Transition proxy available methods:" );

				Tracer.IncreaseLevel();
				foreach( var item in transitionProxy.GetMethods() )
					Tracer.Information( "{0}", item.ToString() );

				Tracer.DecreaseLevel();

				Tracer.Information( "Create implementation proxy.." );
				// used to implement ivars accessors etc.. native code creates this type.

				// register methods from transitionProxy
				for( counter = 0; counter < methodTransitions.Count; counter++ )
				{
					var methodInfo = methodTransitions[counter].Original;

					var transitionMethodInfo = transitionProxy.GetMethod( ( methodInfo.IsStatic ? "+" : "-" ) + "method" + counter );
					var addTo = methodInfo.IsStatic ? metaclass : result;

					var selector = new Selector( methodInfo, Selector.Options.None );
					var encoding = RuntimeMethodEncoding.GetEncoding( transitionMethodInfo, RuntimeMethodEncoding.Options.TransitionMethod | ( ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.X86 ? RuntimeMethodEncoding.Options.StripExceptionParameters : 0 ) );
					var address = ( IntPtr ) transitionProxy.GetMethod( "&method" + counter ).Invoke( null, null );

					Tracer.Information( "Adding method {0} from {1} {2}({3}) to {4} with encoding = {5}, address = {6:X}", selector, transitionMethodInfo.ReturnType.Name, transitionMethodInfo.Name, string.Join( ", ", transitionMethodInfo.GetParameters().Select( x => x.Name + " " + x.ParameterType ).ToArray() ), addTo == metaclass ? "metaclass" : "class", encoding, ( int ) address );

					if( ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.X86 || ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.PPC )
						address = ExceptionBarrierManager.Instance.Allocate( address );

					CompatibilityLayer.class_addMethod( addTo, selector, address, encoding );
				}

				// add constructors with value-type arguments
				for( counter = 0; counter < constructorTransitions.Count; counter++ )
				{
					var constructorInfo = transitionProxy.GetMethod( "-ctor" + counter );

					var constructorName = new Selector( constructorInfo, Selector.Options.Transition | Selector.Options.Constructor | ( ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.X86 ? Selector.Options.StripExceptionParameters : 0 ) );
					var constructorEncodedName = RuntimeMethodEncoding.GetEncoding( constructorInfo, RuntimeMethodEncoding.Options.TransitionMethod | ( ExceptionBarrierManager.Type == ExceptionBarrierManager.BarrierType.X86 ? RuntimeMethodEncoding.Options.StripExceptionParameters : 0 ) );

					var nativeMethodAddress = ( IntPtr ) transitionProxy.GetMethod( "&ctor" + counter ).Invoke( null, null );

					Tracer.Information( "Adding constructor {0} from {1}({2}) to class with encoding = {3}, address = {4}", constructorName, constructorInfo.Name, string.Join( ", ", constructorInfo.GetParameters().Select( x => x.Name + " " + x.ParameterType ).ToArray() ), constructorEncodedName, nativeMethodAddress.ToString( "X8" ) );

					if( ExceptionBarrierManager.Type != ExceptionBarrierManager.BarrierType.None )
						nativeMethodAddress = ExceptionBarrierManager.Instance.Allocate( nativeMethodAddress );

					CompatibilityLayer.class_addMethod( result, constructorName, nativeMethodAddress, constructorEncodedName );
				}

				Tracer.DecreaseLevel();

				CompatibilityLayer.objc_registerClassPair( result );

				Tracer.Information( "{0}", result.ToString() );
				Tracer.Information( "{0}", result.MetaClass.ToString() );

				return result;
			}
			catch( Exception )
			{
				CompatibilityLayer.objc_disposeClassPair( result );
				throw;
			}
		}

		private struct ConstructorTransitionData
		{
			public ConstructorTransitionData( ConstructorInfo value )
			{
				Original = value;
				Parameters = value.GetParameters().Select( x => x.ParameterType ).ToArray();
				ParameterNames = value.GetParameters().Select( x => x.Name ).ToArray();

				Builder = null;
			}

			public ConstructorInfo Original;

			public Type[] Parameters;
			public string[] ParameterNames;

			public ConstructorBuilder Builder;
		}

		private struct MethodTransitionData
		{
			public MethodTransitionData( MethodInfo value )
			{
				Original = value;
				Parameters = value.GetParameters().Select( x => x.ParameterType ).ToArray();
				ParameterNames = value.GetParameters().Select( x => x.Name ).ToArray();
				IsStatic = value.IsStatic;
				ReturnType = value.ReturnType;
				Name = value.Name;
				Builder = null;
			}

			public MethodInfo Original;
			public string[] ParameterNames;
			public Type[] Parameters;
			public Type ReturnType;
			public bool IsStatic;
			public string Name;

			public bool IsSynthesized { get { return Original != null; } }

			public MethodBuilder Builder;
		}

		private struct SpecialMethodTransitionData
		{
			public string Name;
			public MethodBuilder Builder;
		}
	}
}