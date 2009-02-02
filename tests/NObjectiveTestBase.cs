//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System;
using NUnit.Framework;

namespace NObjective.Tests
{
	public class NObjectiveTestBase
	{
		private static readonly Tracing.TextWriterTraceListener _runtimeListener = new Tracing.TextWriterTraceListener( Console.Out );

		private AutoreleaseScope _autoreleasePool;

		[TestFixtureSetUp]
		public void FixtureSetUp()
		{
			Runtime.AddListener( _runtimeListener );
		}

		[TestFixtureTearDown]
		public void FixtureTearDown()
		{
			Runtime.RemoveListener( _runtimeListener );
		}

		[SetUp]
		public void SetUp()
		{
			_autoreleasePool = new AutoreleaseScope();
		}

		[TearDown]
		public void TearDown()
		{
			_autoreleasePool.Dispose();
		}
	}
}
