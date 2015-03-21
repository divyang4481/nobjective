## General ##
### What is NObjective bridge? ###
NObjective bridge is a collection a .NET libraries that enabled a .NET application to use the Mac OS X Objective-C libraries such as Foundation, WebKit, etc. These libraries are exposed through a set of classes that makes their use very easy, because no native code is involved. NObjective internally uses lexer and parser for Objective-C to provide ability to create classes for any arbitrary Objective-C framework.

### Why using NObjective bridge? ###
Использование подобного моста в первую очередь оправдано при портировании Windows-приложений под Mac OS X. Его использование позволит сохранить всю логику приложения и переписать только код связанный с GUI.

### How NObjective bridge works? ###
NObjective bridge provides .NET wrappers for Objective-C types exported by various Mac OS X frameworks. This mechanism allows any .NET applications to access the Mac OS X frameworks as if they were .NET libraries. In addition, .NET class can be exported to the Objective-C runtime to be transparently called within native code. NObjective bridge takes care of all the machinery behind.

### What kind of API does the NObjective bridge exposes? ###
NObjective bridge exposes all the major Mac OS X framework such as Foundation, WebKit and AddressBook. Any .NET application can access these frameworks as if they were .NET libraries and leverage the power of Mac OS X frameworks in a simple way.

### Why does NObjective bridge come in two versions? ###
NObjective bridge comes in two versions, because of its support for both Mac OS X 10.4 and 10.5. NObjective.Proxies.Tiger.dll contains wrappers for Mac OS X 10.4 API, and NObjective.Proxies.Leopard.dll contains wrappers Mac OX X 10.5 API.
If you want to target both Mac OS X 10.4 and 10.5, you should develop your application with NObjective.Proxies.Tiger.dll, and if you want to target Mac OS X 10.5 only, you can develop your application NObjective.Proxies.Leopard.dll assembly.

### What is the difference with the SWF/GTK driver included in Mono ? ###
SWF/GTK drivers included in Mono is focused on cross-platform ability to run .NET code that relies on the SWF/GTK# UI. This port relies on the mapping of the SWF/GTK UI to Mac OS X UI using native API. NObjective bridge takes a different approach: it provides a direct access to the Mac OS X UI API as the RubyCocoa and PyObjc projects do.

## Contributions ##
### How can I help NObjective? ###
The best way to help NObjective is to use it.
Another way is to implement some useful logic and send me patches.

## Licensing ##
### Which license does NObjective bridge uses? ###
NObjective project is licensed under the [GNU Lesser General Public License v3.0 or later](http://www.gnu.org/licenses/lgpl-3.0.html).

### Why NObjective bridge is using the LGPL license ? ###
NObjective bridge is using the LGPL license to ensure a widespread adoption of the technology. The LGPL has all of the restrictions of the GPL except that you may use the code at compile time without the derivative work becoming a GPL work. This allows the use of the code in proprietary works.

### Can I use NObjective bridge in an other Open Source project or product? ###
You can freely modify, extend, and improve NObjective project source code in an other Open Source project. The LGPL requires that all changes must be made available if the combined work is distributed. For more information on the LGPL, you can visit the [Free Software Foundation's FAQ](http://www.gnu.org/licenses/gpl-faq.html)

### Can I use NObjective bridge in a commercial product? ###
You can freely modify, extend, and improve the NObjective project source code in a commercial product. The LGPL requires that all changes must be made available if the product is distributed. For more information on the LGPL, you can visit the [Free Software Foundation's FAQ](http://www.gnu.org/licenses/gpl-faq.html)

## Runtime ##
### What is the minimum version of Mac OS X to run NObjective bridge? ###
The NObjective bridge requires at least Mac OS X 10.4.

### Does NObjective bridge works with Leopard (Mac OS X 10.5)? ###
Yes, it works on Mac OS X 10.5. NObjective bridge has been designed to work both on Mac OS X 10.4 and Mac OS X 10.5. The runtime automatically detects the proper runtime to use.

### What are the requirements for NObjective? ###
The only requirement is to have a Mono runtime installed. If you consider doing some development with NObjective, you will need the Apple XCode Developer Tool.

### Does NObjective needs X11? ###
No, it does not. NObjective only relies on standard Mac OS X technologies and it does not use X11 at all.

### Does NObjective bridge works on 64 bits hardware? ###
No, it does not. At least exception propagation will be broken.

## Development ##
### How to build library? ###
There are two scripts for build it:
  * build\_debug.sh - builds library with debug information and tracing
  * build\_release - without it

### Which frameworks are available through the NObjective bridge? ###
See [proxy generator settings](http://code.google.com/p/nobjective/source/browse/trunk/ProxyGenerator/Profiles/10.5/dumper_settings.xml). You can edit it and recreate all proxies to add specific frameworks.

### Can I use NObjective bridge in VB.NET/MC++/F#/My Language ? ###
Yes, you can. As long as the language is supported by the .NET runtime (i.e. can be transformed into IL), there is no limitations other than those of the language.

### How do I develop my own application? ###
**[VS2008](http://msdn.microsoft.com/en-us/vstudio/default.aspx) + telnet/ssh to Mac OS machine** Monodevelop
**NAnt + terminal**

### Is there any similar products or projects? ###
Similar projects exist: Dumbarton, ObjC#, Cocoa-Sharp, Monobjc. Both Dumbarton and ObjC# focused on the integration of .NET into the Objective-C runtime (when you have a large Objective-C code base) whereas Cocoa-Sharp, Monobjc are focused on the Objective-C integration into the .NET runtime (when you have a large .NET code base).

### Why creating NObjective bridge instead of re-using/re-writing/contributing to XXX? ###
Some projects were around for many years and was not maintained. Some projects are mature, looks pretty and modern like Monobjc. But there were things like poor performance, lacking of exception propagation, partial APIs, etc., that promotes the fact that eventually a new clean-room bridge implementation was needed. So I started to code  new engine using 11 years experience in low-level and high-level programming.

## Usage ##
### If I want additional frameworks should I modify analyze.mm? ###
See [dumper\_settings.xml](http://code.google.com/p/nobjective/source/browse/trunk/ProxyGenerator/Profiles/10.5/dumper_settings.xml), add appropriate entry to it and recreate all proxies ( "-D:RegenProxies=True" option for nant ).

### I tried to port some of my code to use your library and ran into this issue ###
```
// unable to cast RuntimeObject to NSNotificationCenter.
NSNotificationCenter def = NSNotificationCenter.defaultCenter();
```


If you think that parameters or return value is wrong, you should look in Objective-C headers:
@interface NSNotificationCenter : NSObject { ... }
...
+ (id) defaultCenter;
...

As you see, declaration doesn't contain any appropriate info about of return type. Objective-C method declarations are less typified than C++ or C#, so you have such problems. Use such construction:
```
var def = new NSNotificationCenter( NSNotificationCenter.defaultCenter() );
```
### What happens if an exception is thrown in C#? Can it be caught in ObjC? Vice-versa? Will it be of a sensible type? ###
Currenly exception propagation works in both directions for PPC/x86 processor architectures. Libraries like [LIBFFI](http://sourceware.org/libffi/) don't meet mine performance requirements ( see mobjc test result - it's slower ). Also you can catch wrapped managed exceptions in native code using "NOExceptionProxy" class.

### If a string is passed from one runtime to the other and back, is the identity preserved? ###
When string passes from .NET runtime - yes.
If string passes from Objective-C runtime, idenity behaviour will depend from method signature ("string" parameters or transparent proxies like "NSString" ).

### Collections -- do they "just work" on both sides of the bridge?  I.e. can you pass an NSArray instance into the C# runtime and have it be transparently compatible with whatever vector/array thingamabob exists therein? ###
Collections should be manually marshalled since them not such primitive types like floats/ints etc.

### Do the fundamentals of Cocoa work?  KVC?  KVO? Bindings?  Can I slap an array of C# objects behind a Cocoa UI using controllers and bindings? ###
Bridge provides low-level interop such as introspection/messaging/marshalling. It doesn't matter what kind of objc classes/logic are used. Use appropriate proxy objects to achieve same results like in native code. So you can't slap C# array but you can use proxies like NSArray.

### How about memory management?  I have seen naive bridges where every bridge object creates a retain cycle to itself.  Obviously, an extreme fail.  How much does the developer need to think about it?  Ideally, the bridge would use the garbage collector provided with Leopard ###
All proxies don't use "retain" since they represent wrapped raw pointers. But if you want to retain just invoke retain() or use RuntimeObjectProxy class.

### What about messaging?  Does the bridge provide access to all Cocoa methods?  How does it deal with things like (NSError )?  How about the various random C APIs?  Or paired arguments like (int 