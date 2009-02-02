//
// Copyright (C) 2008 Eugeny Grishul
//
// See license in License.txt
//

using System;

namespace NObjective
{
	/// <summary>
	/// The exception that is thrown when Objective-C exception was trapped.
	/// </summary>
	public sealed class RuntimeException : Exception
	{
		/// <summary>
		/// Original Objective-C exception that produced that.
		/// </summary>
		public RuntimeObject Object { get; private set; }

		/// <summary>
		/// Description from original Objective-C exception that describes the error.
		/// </summary>
		public override string Message { get { return Object.InvokeString( Selectors.description ); } }

		/// <summary>
		/// Initializes new instance of RuntimeException.
		/// </summary>
		public RuntimeException()
		{ }

		/// <summary>
		/// Releases internal native exception.
		/// </summary>
		~RuntimeException()
		{
			Runtime.ReleaseNativeObject( Object );
		}

		/// <summary>
		/// Initializes new instance of RuntimeException class with specified Objective-C exception.
		/// </summary>
		/// <param name="object">Original Objective-C exception.</param>
		public RuntimeException( RuntimeObject @object )
		{
			Object = @object;

			Runtime.RetainNativeObject( Object );
		}

		/// <summary>
		/// Extracts information about managed exception passed throught native barrier via ExceptionProxy
		/// or creates new instance of RuntimeException class with specified Objective-C exception.
		/// </summary>
		/// <param name="object">Original Objective-C exception.</param>
		/// <returns>New exception instance.</returns>
		public unsafe static Exception Create( RuntimeObject @object )
		{
			if( @object.Class == Runtime.ExceptionProxy.Class )
			{
				var result = ( ( Runtime.ExceptionProxy* ) ( IntPtr ) @object )->ManagedException;

				Runtime.ReleaseNativeObject( @object );

				return result;
			}

			return new RuntimeException( @object );
		}
	}

	/// <summary>
	/// The exception that is thrown when errors are occured while class registration.
	/// </summary>
	public sealed class RegistrationException : Exception
	{
		/// <summary>
		/// Initializes new instance of RegistrationException class.
		/// </summary>
		public RegistrationException()
		{ }

		/// <summary>
		/// Initializes new instance of RegistrationException class with specified message.
		/// </summary>
		/// <param name="message">The message that describes the error.</param>
		public RegistrationException( string message )
			: base( message )
		{
		}

		/// <summary>
		/// Initializes new instance of RegistrationException class with specified formatting string and appropriate arguments.
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="arguments">An System.Object array containing zero or more objects to format.</param>
		public RegistrationException( string format, params object[] arguments )
			: base( string.Format( format, arguments ) )
		{
		}
	}

	/// <summary>
	/// The exception that is thrown when errors are occered while Objective-C interop.
	/// </summary>
	public sealed class InteropException : Exception
	{
		/// <summary>
		/// Initializes new instance of InteropException class.
		/// </summary>
		public InteropException()
		{ }

		/// <summary>
		/// Initializes new instance of InteropException class with specified message.
		/// </summary>
		/// <param name="message">The message that describes the error.</param>
		public InteropException( string message )
			: base( message )
		{
		}

		/// <summary>
		/// Initializes new instance of InteropException class with specified formatting string and appropriate arguments.
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="arguments">An System.Object array containing zero or more objects to format.</param>
		public InteropException( string format, params object[] arguments )
			: base( string.Format( format, arguments ) )
		{
		}
	}

	/// <summary>
	/// The exception that is thrown when accessing to ivars from released exported class instance.
	/// </summary>
	public sealed class ObjectReleasedException : Exception
	{
		/// <summary>
		/// Initializes new instance of ObjectReleasedException class.
		/// </summary>
		public ObjectReleasedException()
		{ }

		/// <summary>
		/// Initializes new instance of ObjectReleasedException class with specified message.
		/// </summary>
		/// <param name="message">The message that describes the error.</param>
		public ObjectReleasedException( string message )
			: base( message )
		{
		}

		/// <summary>
		/// Initializes new instance of ObjectReleasedException class with specified formatting string and appropriate arguments.
		/// </summary>
		/// <param name="format">A composite format string.</param>
		/// <param name="arguments">An System.Object array containing zero or more objects to format.</param>
		public ObjectReleasedException( string format, params object[] arguments )
			: base( string.Format( format, arguments ) )
		{
		}
	}
}
