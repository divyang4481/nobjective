//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//


using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

namespace NObjective
{
	internal static class Extensions
	{
		internal static T GetCustomAttribute<T>( this Type @this, bool inherited ) where T : Attribute
		{
			return @this.GetCustomAttributes( typeof( T ), inherited ).Cast<T>().FirstOrDefault();
		}

		internal static T GetCustomAttribute<T>( this MemberInfo @this, bool inherited ) where T : Attribute
		{
			return @this.GetCustomAttributes( typeof( T ), inherited ).Cast<T>().FirstOrDefault();
		}

		internal static T GetCustomAttribute<T>( this ParameterInfo @this, bool inherited ) where T : Attribute
		{
			return @this.GetCustomAttributes( typeof( T ), inherited ).Cast<T>().FirstOrDefault();
		}

		internal static IEnumerable<Type> GetClassHierarchy( this Type type )
		{
			var result = type;

			while( result != null )
			{
				yield return result;

				result = result.BaseType;
			}
		}
	}
}
