using System;
using System.Reflection;
using System.Runtime.CompilerServices; 
using System.Runtime.InteropServices;
using System.Security.Permissions;
 
[assembly: AssemblyTitle("obj3.sharp library")]    
[assembly: AssemblyDescription(".NET <--> Objective C bridge")]
[assembly: AssemblyCopyright("Copyright (C) 2008 Jesse Jones")]
 
[assembly: CLSCompliant(false)]			// It would be relatively easy to make the library compliant, but a lot harder to make mcocoa compliant because Cocoa uses unsigned ints all over
[assembly: ComVisible(false)]             
[assembly: PermissionSet(SecurityAction.RequestMinimum, Unrestricted = true)]
