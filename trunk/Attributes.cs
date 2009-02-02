//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System;

namespace NObjective
{
	/// <summary>
	/// Used to override automatic selector naming for methods whil exporting class to Objective-C runtime.
	/// </summary>
	[AttributeUsage( AttributeTargets.Method | AttributeTargets.Constructor, AllowMultiple = false )]
	public sealed class SelectorAttribute : Attribute
	{
		/// <summary>
		/// Initializes new instance of SelectorAttribute with specified selector name that will be later used in method registration.
		/// </summary>
		/// <param name="selector"></param>
		public SelectorAttribute( string selector )
		{
			Selector = selector;
		}

		/// <summary>
		/// Overriden name that replaces automatically generated name.
		/// </summary>
		public string Selector { get; private set; }
	}

	/// <summary>
	/// Used to override automatic parameter naming for methods while exporting class to Objective-C runtime.
	/// </summary>
	[AttributeUsage( AttributeTargets.Parameter, AllowMultiple = false )]
	public sealed class ParameterNameAttribute : Attribute
	{
		/// <summary>
		/// Initializes new instance of ParameterNameAttribute with specified name that will be later used in parameter naming during method registration.
		/// </summary>
		/// <param name="name"></param>
		public ParameterNameAttribute( string name )
		{
			Name = name;
		}

		/// <summary>
		/// Overriden parameter name.
		/// </summary>
		public string Name { get; private set; }
	}

	/// <summary>
	/// Used to override automatic class naming while exporting class to Objective-C runtime. 
	/// </summary>
	[AttributeUsage( AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false )]
	public sealed class ClassNameAttribute : Attribute
	{
		/// <summary>
		/// Initializes new instance of ClassNameAttribute with specified name that will be later used in class naming during class registration.
		/// </summary>
		/// <param name="name"></param>
		public ClassNameAttribute( string name )
		{
			Name = name;
		}

		/// <summary>
		/// Overriden class name.
		/// </summary>
		public string Name { get; private set; }
	}

	/// <summary>
	/// Used to specify Objective-C base class for classes that will be exported to Objective-C runtime.
	/// </summary>
	[AttributeUsage( AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false )]
	public sealed class BaseClassAttribute : Attribute
	{
		/// <summary>
		/// Initializes new instance of BaseClassAttribute with specified name for base class that will be later used during class registration.
		/// </summary>
		/// <param name="base">Base class name.</param>
		public BaseClassAttribute( string @base )
		{
			Base = @base;
		}

		/// <summary>
		/// Base class name.
		/// </summary>
		public string Base { get; private set; }
	}

	/// <summary>
	/// Used to specify adopted protocol name for classes that will be exported to Objective-C runtime.
	/// </summary>
	[AttributeUsage( AttributeTargets.Class, AllowMultiple = false )]
	public sealed class AdoptedProtocolAttribute : Attribute
	{
		/// <summary>
		/// Initializes new instance of AdoptedProtocolAttribute with specified adopted protocol name that will be later used during class registration.
		/// </summary>
		/// <param name="name">Name of protocol class that was adopted.</param>
		public AdoptedProtocolAttribute( string name )
		{
			Name = name;
		}

		/// <summary>
		/// Name of protocol class that was adopted.
		/// </summary>
		public string Name { get; private set; }
	}

	/// <summary>
	/// Used to ignore class during autoregistration.
	/// Use it only in testing purposes in other cases you should only use auto registration.
	/// </summary>
	[AttributeUsage( AttributeTargets.Class, AllowMultiple = false )]
	public sealed class ManualRegisterAttribute : Attribute
	{
	}

	/// <summary>
	/// Used in generated code to declare base type.
	/// </summary>
	[AttributeUsage( AttributeTargets.Struct, AllowMultiple = false )]
	public sealed class ProxyBaseClassAttribute : Attribute
	{
		/// <summary>
		/// Initializes new instance of ProxyBaseClassAttribute with specified base type.
		/// </summary>
		/// <param name="baseType"></param>
		public ProxyBaseClassAttribute( Type baseType )
		{
			Base = baseType;
		}

		/// <summary>
		/// Base Type for class.
		/// </summary>
		public Type Base { get; private set; }
	}
}
