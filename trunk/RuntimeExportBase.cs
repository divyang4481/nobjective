//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System;
namespace NObjective
{
	/// <summary>
	/// Used for exporting .NET classes to Objective-C runtime.
	/// </summary>
	public abstract class RuntimeExportBase
	{
		/// <summary>
		/// Handle
		/// </summary>
		public abstract RuntimeObject Handle { get; }
	}
}
