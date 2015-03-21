### Calling Objective-C Methods ###
You can call objective-c methods in different ways:
  * Pure-dynamic (bad) way:
```
var xxx = (bool)(((RuntimeObject)(new RuntimeClass( "NSNumber" ).Invoke( "numberWithBool:", true ))).Invoke( "boolValue" ));
```
> And less dynamic way:
```
var xxx = new RuntimeClass( "NSNumber" ).InvokeObject( "numberWithBool:", true ).InvokeBool( "boolValue" );
```
> There is no refcount operations, so NSNumber instance will be released in appropriate NSAutoreleasePool. You can create pool in such manner:
```
using( AutoreleaseScope.New() )
{
    new RuntimeClass( "NSNumber" ).InvokeObject( "numberWithBool:", true ).InvokeBool( "boolValue" );
}
```
> Also you can increase object refcount for long-time use:
```
var proxy = new RuntimeObjectProxy( new RuntimeClass( "NSNumber" ).InvokeObject( "numberWithBool:", true ) );
proxy.InvokeBool( "boolValue" );
```
> also you can use it in "using" pattern:
```
using( var proxy = new RuntimeObjectProxy( new RuntimeClass( "NSNumber" ).InvokeObject( "numberWithBool:", true ) ) )
    proxy.InvokeBool( "boolValue" );
```
  * Static-typed way:
```
NSNumber.numberWithBool_( true ).boolValue();
```
> It's most efficient and easy way to use objective-c.
> Note that method name is transformed selector name by replacing ':' with "`_`"

> See also [ProxiesTest.cs](http://code.google.com/p/nobjective/source/browse/trunk/tests/ProxiesTest.cs)
### Exception handling ###
Mono runtime don't like setjmp/longjmp behavior of objective-c exceptions so they catched in NObjective.dylib. Test it:
```
NSString.localizedStringWithFormat_( null );
```
### Tracing ###
You can see library's internal actions by enabling trace listeners ( don't forget define TRACE ):
```
Runtime.AddListener( new Tracing.TextWriterTraceListener( Console.Out ) );
```
**Note don't forget build debug version of library ./build\_debug.sh
```
Perform selector init on object AutoRegisteredClass (009D8DB0)
        Encoding = ^0, result = ^
        --SEND START--
                native call objc_msgSend_eh
        --SEND END--
        Returned: BFFFEAA4009D8DB0
Perform selector AccessHandle on object AutoRegisteredClass (009D8DB0)
        Encoding = ^8@0:4, result = ^
        --SEND START--
                native call objc_msgSend_eh
        --SEND END--
        Returned: BFFFEAE4009D8DB0
Perform selector ArgumentsTest:param2:param3: on object AutoRegisteredClass (009D8DB0)
        Encoding = f20i8@12f16@0:4, result = f
        param 0 with value 10 serialized as structure with size 4
        param 1 with value 20 serialized as NSString proxy
        param 2 with value 30 serialized as structure with size 4
        --SEND START--
                native call objc_msgSend_fpret_eh
                Perform selector description on object MonoStringTransparentProxy (009D8E20)
                        Encoding = @8@0:4, result = @
                        --SEND START--
                                native call objc_msgSend_eh
.                       --SEND END--
                        Returned: 00000001009D8E20
                Deserialize invocation result..
                        Encoded type: @8@0:4 --> RuntimeObject
                        Return type hierarchy: MonoStringTransparentProxy <-- NSString <-- NSObject
                        string proxy responded to length
                        string proxy responded to getCharacters:
                        Deserialize "20" as string
        --SEND END--
        Returned: 404E000000000000
        ~dealloc NSString proxy
Deserialize invocation result..
        Encoded type: f20i8@12f16@0:4 --> Single
        Deserialize 60 as float
Perform selector alloc on class NSAutoreleasePool (A06929E0)
        Encoding = @8@0:4, result = @
        --SEND START--
                native call objc_msgSend_eh
        --SEND END--
        Returned: A06929E0009DA8B0
Perform selector init on object NSAutoreleasePool (009DA8B0)
        Encoding = @8@0:4, result = @
        --SEND START--
                native call objc_msgSend_eh
        --SEND END--
```**

### Exporting types to objc-runtime ###
Existing classes can't be exported to objc runtime coz my little experience ( about 3 years objc and 10 years of C++ programming ) prompts me that solution will not be fast/flexible/efficient.

So at first you should create abstract class and derive it from RuntimeExportBase.
```
public abstract class AutoRegisteredClass : RuntimeExportBase
```
Than you may create abstract properties which will be ivars-accessors:
```
public abstract byte _byte { get; set; }
public abstract sbyte _sbyte { get; set; }
public abstract char _char { get; set; }
public abstract short _short { get; set; }
public abstract ushort _ushort { get; set; }

public abstract decimal _decimal { get; set; }
public abstract Guid _guid { get; set; }
public abstract IntPtr _intPtr { get; set; }

public abstract int _int { get; set; }
public abstract uint _uint { get; set; }
public abstract long _long { get; set; }
public abstract ulong _ulong { get; set; }
public abstract float _float { get; set; }
public abstract double _double { get; set; }
```
Also you can use generated proxies as ivar types:
```
public abstract NSString _string { get; set; }
public abstract NSNumber _number { get; set; }
```
Add constructor and methods:
```
public AutoRegisteredClass()
{
}

public void MethodToTest()
{
    Console.WriteLine( "TestMethod" );
}

// for first argument will be invoked special transparent marshaling
public string MarshalStrings( string first, NSString second )
{
    return first + second.ToString();
}
```
After library was loaded all classes derived from `RuntimeExportBase` will be automatically exports to objc-runtime. All abstract properties will be implemented at runtime and will provide direct access to native ivars. Also native objc class will have init methods mapped to your constructors.
Enable tracing to see details of exporting process:
```
                Adding ivar _byte from type Byte to class with size = 1; encoding = C
                Adding ivar _sbyte from type SByte to class with size = 1; encoding = c
                Adding ivar _char from type Char to class with size = 2; encoding = s
                Adding ivar _short from type Int16 to class with size = 2; encoding = s
                Adding ivar _ushort from type UInt16 to class with size = 2; encoding = S
                Adding ivar _decimal from type Decimal to class with size = 16; encoding = {System.Decimal=qq}
                Adding ivar _guid from type Guid to class with size = 16; encoding = {System.Guid=issCCCCCCCC}
                Adding ivar _intPtr from type IntPtr to class with size = 4; encoding = ^l
                Adding ivar _int from type Int32 to class with size = 4; encoding = i
                Adding ivar _uint from type UInt32 to class with size = 4; encoding = I
                Adding ivar _long from type Int64 to class with size = 8; encoding = q
                Adding ivar _ulong from type UInt64 to class with size = 8; encoding = Q
                Adding ivar _float from type Single to class with size = 4; encoding = f
                Adding ivar _double from type Double to class with size = 8; encoding = d
                Adding ivar _object from type RuntimeObject to class with size = 4; encoding = @
                Adding method AccessHandle from IntPtr AccessHandle() to class with encoding = ^l8@0:4, address = 24094CC
```
### Working with exported classes ###
You can create class instance in dynamic way:
```
var instance = Runtime.GetExportedClass<AutoRegisteredClass>().CreateInstance( "init" );

Assert.AreEqual( 6, instance.InvokeInt8( "MarshalSBytes:second:third:", 1, 2, 3 ) );
```
Also you can create objc object and attach to it's managed transparent proxy:
```
var proxy = Runtime.CreateInstance<AutoRegisteredClass>( "init:", 888 );
proxy.MarshalSBytes( 1, 2, 3 );
```
See also [RegistrationTest.cs](http://code.google.com/p/nobjective/source/browse/trunk/tests/RegistrationTest.cs) and [GUI.cs](http://code.google.com/p/nobjective/source/browse/trunk/example/GUI.cs)
### Customizing exporting ###
Good enought? No?
If you don't like naming scheme used by class exporter you can override it for method:
```
[Selector( "renamedMarshalULongsMethod:yo:yo:" )]
public ulong MarshalULongs2( ulong first, ulong second, ulong third )
```
or for parameter:
```
public ulong MarshalULongs3( ulong first, [ParameterName( "something" )] ulong second, ulong third )
```
### Exported class instance lifetime ###
  1. Class can not be unregistered. Just send message to Apple about their "nice" API and it's issues. Not just message but objc-message =)
  1. Instances of exported classes creates ONLY from unmanaged code. After allocation of all ivars you can call "init" to invoke appropriate managed constructor. That call creates managed proxy ( which derived from your managed class ), acquiring gchandle for it. After that managed proxy CAN NOT be garbage collected until unmanaged part still alive coz it hold gchandle. But your managed proxy still alive while unmanaged was released.. Try to use it. You will be surprised with ObjectReleasedException =)public ulong MarshalULongs3( ulong first, [ParameterName( "something" )] ulong second, ulong third )
}}}```