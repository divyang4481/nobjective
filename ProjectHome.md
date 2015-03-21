NObjective bridge to Objective-C provides the necessary classes to develop and run .NET applications which interact with Objective-C frameworks and libraries under Mac OS X with high performance and reliability.

&lt;wiki:gadget url="http://www.ohloh.net/p/309337/widgets/project\_users.xml?style=blue" height="100"  border="0" /&gt;

<table>
<tr>
<td>
Description:<br>
<ul><li>High-performance solution with minimal cpu/memory overheads compared to similar bridges ( <a href='http://www.monobjc.net'>Monobjc</a>, <a href='http://code.google.com/p/mobjc'>Mobjc</a>, <a href='http://www.mono-project.com/CocoaSharp'>Cocoa#</a> )<br>
</li><li>Huge library of automatically generated proxies around Objective-C classes<br>
<ul><li>More than 2300 classes and 23000 methods can be used directly from your .NET code<br>
</li><li>Proxies are generated using Objective-C introspection. Using .h files parsing provides more natural method signatures.<br>
</li><li>Generates essential enums and structs<br>
</li><li>Also proxies can be generated without C header files<br>
</li></ul></li><li>Transparent cross-runtime exception rethrowing<br>
<ul><li>from managed to unmanaged world<br>
</li><li>from unmanaged to managed world<br>
</li></ul></li><li>Easy access to major Mac OS X frameworks and libraries<br>
<ul><li>Ability to generate Objective-C proxies for any framework<br>
</li><li>Ability to build your own types that can be used inside Cocoa<br>
</li></ul></li><li>Combines flexibility of managed and power of unmanaged code to achieve highest performance<br>
<ul><li>Deep integration with Objective-C runtime<br>
</li><li>Ships with x86/ppc UB library<br>
</li></ul></li><li>Used special coding style which provides exellent perception<br>
</li><li>Client applications can be written in some .NET language ( C#, VB.NET, etc )<br>
</li><li>Works with the most popular versions of OS X:<br>
<ul><li>MacOS Tiger 10.4 ( x86/ppc )<br>
<ul><li>about 2000 classes and 20000 methods are available<br>
</li></ul></li><li>MacOS Leopard 10.5 ( x86/ppc )<br>
<ul><li>about 2300 classes and 23000 methods are available<br>
</li></ul></li><li>MacOS Snow Leopard 10.6 ( x86 )<br>
<ul><li>about 2300 classes and 23000 methods are available<br>
</li></ul></li></ul></li><li>Open Source, Free Software<br>
</li></ul><blockquote><img src='http://www.gnu.org/graphics/lgplv3-147x51.png' />
</td>
<td valign='bottom'></td>
</tr>
</table>
<wiki:gadget url="http://www.ohloh.net/p/309337/widgets/project_cocomo.xml" border="0" height="240"/></blockquote>

&lt;wiki:gadget url="http://www.ohloh.net/p/309337/widgets/project\_languages.xml" border="0" height="240" width="400" /&gt;

Notes:
  * Library aimed on mature Objective-C developers so if something will not work.. use Objective-C before shout that the bridge sucks.
  * Library doesn't provide any tools to simplify your build process on Mac.

Planned features:
  * Create hierarchy for property accessors.
  * Add Property synthezation for exported classes.
  * Add Ivars accessors for generated proxies.
  * Add bitset accessors for generated structs.
  * Reduce metadata size after fixing P/Invoke layer for vararg calls in Mono.

Also you can make project better!
  * Useful patches are welcomed!
  * Ask mono team to implement value type inheritance properly in compiler (it should not able to create such inheritance from C# code, but able to work with such structs referenced from assemblies ) and execution engine. Currently it behaviour differs from MS implementation. With such feature Proxy Dlls will about 4 times smaller. But Novell customers not interested in fast and efficient bindings (compatible on IL level with MS CLR) so it would be trouble.
  * Ask mono team to implement 'arglist' and related keywords in compiler and execution engine - it will reduce metadata size for native calls. Mono team don't like refactoring ( need to refactor P/Invoke layer for vararg calls ) so it would be trouble.

Results of simple performance benchmark:

![http://a248.e.akamai.net/7/248/2041/1520/store.apple.com/Catalog/US/Images/macpro/img/product-front-side.jpg](http://a248.e.akamai.net/7/248/2041/1520/store.apple.com/Catalog/US/Images/macpro/img/product-front-side.jpg)

1) Mac Pro ( Intel Xeon ) OS X 10.6.2
```
Jack$ ./run_leopard_tests.sh 

Mono JIT compiler version 2.6.3 (tarball Wed Mar 10 18:18:12 MST 2010)
Copyright (C) 2002-2010 Novell, Inc and Contributors. www.mono-project.com
	TLS:           normal
	GC:            Included Boehm (with typed GC)
	SIGSEGV:       normal
	Notification:  Thread + polling
	Architecture:  x86
	Disabled:      none

NObjective v0.9.6.0 results:
Invocations per second: 7342143
Allocations per second: 4179728
Vararg invocations per second: 36452
Protected calls per second: 224517
Exception rethrows per second: 28563
Managed memory consumption (KiB): 472
Unmanaged memory consumption (KiB): 19076

Monobjc v2.0.492.0 results:
Invocations per second: 1128158
Allocations per second: 119183
Vararg invocations per second: 20386
Managed memory consumption (KiB): 14876
Unmanaged memory consumption (KiB): 44860

mobjc v0.7.0.0 results:
Invocations per second: 73379
Allocations per second: 17912
Protected calls per second: 16635
Exception rethrows per second: 913
Managed memory consumption (KiB): 1384
Unmanaged memory consumption (KiB): 115772

cocoa-sharp v1.9.0.0 results:
Invocations per second: 47828
Allocations per second: 10930
Vararg invocations per second: 2531
Managed memory consumption (KiB): 29072
Unmanaged memory consumption (KiB): 71344

```

![http://chart.apis.google.com/chart?chtt=Invocations+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|2447381|4894762|7342143&cht=bhg&chd=t:100|15.3655138561044|0.999422103328688|0.651417440384912&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Invocations+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|2447381|4894762|7342143&cht=bhg&chd=t:100|15.3655138561044|0.999422103328688|0.651417440384912&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)
![http://chart.apis.google.com/chart?chtt=Allocations+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|1393242|2786485|4179728&cht=bhg&chd=t:100|2.85145349171047|0.428544632569392|0.261500269874021&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Allocations+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|1393242|2786485|4179728&cht=bhg&chd=t:100|2.85145349171047|0.428544632569392|0.261500269874021&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)
![http://chart.apis.google.com/chart?chtt=Vararg+invocations+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|12150|24301|36452&cht=bhg&chd=t:100|55.9256007900801|0|6.94337759245035&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Vararg+invocations+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|12150|24301|36452&cht=bhg&chd=t:100|55.9256007900801|0|6.94337759245035&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)
![http://chart.apis.google.com/chart?chtt=Managed+memory+consumption+(KiB)&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|9694|19389|29084&cht=bhg&chd=t:1.62288543529088|51.1483977444643|4.75863017466648|100&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Managed+memory+consumption+(KiB)&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|9694|19389|29084&cht=bhg&chd=t:1.62288543529088|51.1483977444643|4.75863017466648|100&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)
![http://chart.apis.google.com/chart?chtt=Unmanaged+memory+consumption+(KiB)&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|38590|77181|115772&cht=bhg&chd=t:16.4772138340877|38.7485747849221|100|61.8007808451094&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Unmanaged+memory+consumption+(KiB)&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|38590|77181|115772&cht=bhg&chd=t:16.4772138340877|38.7485747849221|100|61.8007808451094&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)
![http://chart.apis.google.com/chart?chtt=Protected+calls+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|74839|149678|224517&cht=bhg&chd=t:100|0|7.40923849864375|0&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Protected+calls+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|74839|149678|224517&cht=bhg&chd=t:100|0|7.40923849864375|0&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)
![http://chart.apis.google.com/chart?chtt=Exception+rethrows+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|9521|19042|28563&cht=bhg&chd=t:100|0|3.19644295067045|0&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Exception+rethrows+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|9521|19042|28563&cht=bhg&chd=t:100|0|3.19644295067045|0&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)

**Note: vararg calls not implemented in mobjc**

**Note: cross-runtime exception rethrowing not supported by monobjc/cocoa#**

![http://a248.e.akamai.net/7/248/2041/1520/store.apple.com/Catalog/US/Images/macpro/img/product-front-side.jpg](http://a248.e.akamai.net/7/248/2041/1520/store.apple.com/Catalog/US/Images/macpro/img/product-front-side.jpg)

2) Mac Pro ( Intel Xeon ) OS X 10.5.8
```
./run_leopard_tests.sh 

Mono JIT compiler version 2.6.3 (tarball Wed Mar 10 18:18:12 MST 2010)
Copyright (C) 2002-2010 Novell, Inc and Contributors. www.mono-project.com
	TLS:           normal
	GC:            Included Boehm (with typed GC)
	SIGSEGV:       normal
	Notification:  Thread + polling
	Architecture:  x86
	Disabled:      none

NObjective v0.9.6.0 results:
Invocations per second: 6731740
Allocations per second: 4285408
Vararg invocations per second: 36170
Protected calls per second: 217997
Exception rethrows per second: 29442
Managed memory consumption (KiB): 476
Unmanaged memory consumption (KiB): 16008

Monobjc v2.0.492.0 results:
Invocations per second: 1206709
Allocations per second: 129954
Vararg invocations per second: 20877
Managed memory consumption (KiB): 14116
Unmanaged memory consumption (KiB): 42220

mobjc v0.7.0.0 results:
Invocations per second: 72914
Allocations per second: 21188
Protected calls per second: 16732
Exception rethrows per second: 804
Managed memory consumption (KiB): 1364
Unmanaged memory consumption (KiB): 61484

cocoa-sharp v1.9.0.0 results:
Invocations per second: 48668
Allocations per second: 10461
Vararg invocations per second: 2459
Managed memory consumption (KiB): 29092
Unmanaged memory consumption (KiB): 65548
```

![http://chart.apis.google.com/chart?chtt=Invocations+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|2243913|4487826|6731740&cht=bhg&chd=t:100|17.9256626072902|1.08313749491216|0.722963156628153&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Invocations+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|2243913|4487826|6731740&cht=bhg&chd=t:100|17.9256626072902|1.08313749491216|0.722963156628153&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)
![http://chart.apis.google.com/chart?chtt=Allocations+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|1428469|2856938|4285408&cht=bhg&chd=t:100|3.03247672100299|0.49442200135903|0.244107445545442&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Allocations+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|1428469|2856938|4285408&cht=bhg&chd=t:100|3.03247672100299|0.49442200135903|0.244107445545442&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)
![http://chart.apis.google.com/chart?chtt=Vararg+invocations+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|12056|24113|36170&cht=bhg&chd=t:100|57.7191042300249|0|6.79845175559856&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Vararg+invocations+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|12056|24113|36170&cht=bhg&chd=t:100|57.7191042300249|0|6.79845175559856&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)
![http://chart.apis.google.com/chart?chtt=Managed+memory+consumption+(KiB)&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|9697|19394|29092&cht=bhg&chd=t:1.63618864292589|48.521930427609|4.68857417846831|100&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Managed+memory+consumption+(KiB)&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|9697|19394|29092&cht=bhg&chd=t:1.63618864292589|48.521930427609|4.68857417846831|100&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)
![http://chart.apis.google.com/chart?chtt=Unmanaged+memory+consumption+(KiB)&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|21849|43698|65548&cht=bhg&chd=t:24.4217977665222|64.4108134496857|93.7999633856105|100&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Unmanaged+memory+consumption+(KiB)&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|21849|43698|65548&cht=bhg&chd=t:24.4217977665222|64.4108134496857|93.7999633856105|100&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)
![http://chart.apis.google.com/chart?chtt=Protected+calls+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|72665|145331|217997&cht=bhg&chd=t:100|0|7.67533498167406|0&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Protected+calls+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|72665|145331|217997&cht=bhg&chd=t:100|0|7.67533498167406|0&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)
![http://chart.apis.google.com/chart?chtt=Exception+rethrows+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|9814|19628|29442&cht=bhg&chd=t:100|0|2.73079274505808|0&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Exception+rethrows+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|9814|19628|29442&cht=bhg&chd=t:100|0|2.73079274505808|0&chdl=NObjective|Monobjc|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)

![http://images.apple.com/support/_images/hero_powermacg4.jpg](http://images.apple.com/support/_images/hero_powermacg4.jpg)

3) `PowerMac` G4 1GHz OS X 10.5.8
```
./run_leopard_tests.sh 

Mono JIT compiler version 2.6.3 (tarball Wed Mar 10 18:31:54 MST 2010)
Copyright (C) 2002-2010 Novell, Inc and Contributors. www.mono-project.com
	TLS:           normal
	GC:            Included Boehm (with typed GC)
	SIGSEGV:       normal
	Notification:  Thread + polling
	Architecture:  ppc
	Disabled:      none

NObjective v0.9.6.0 results:
Invocations per second: 813504
Allocations per second: 518510
Vararg invocations per second: 5902
Protected calls per second: 26115
Exception rethrows per second: 7383
Managed memory consumption (KiB): 448
Unmanaged memory consumption (KiB): 16360

Monobjc v2.0.492.0 results:

Unhandled Exception: System.ExecutionEngineException: SIGILL
mobjc v0.7.0.0 results:
Invocations per second: 10845
Allocations per second: 5730
Protected calls per second: 2437
Exception rethrows per second: 173
Managed memory consumption (KiB): 1364
Unmanaged memory consumption (KiB): 61948

cocoa-sharp v1.9.0.0 results:
Invocations per second: 8708
Allocations per second: 1778
Vararg invocations per second: 455
Managed memory consumption (KiB): 28484
Unmanaged memory consumption (KiB): 63384
```

![http://chart.apis.google.com/chart?chtt=Invocations+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|271168|542336|813504&cht=bhg&chd=t:100|1.33312190228936|1.07043112264967&chdl=NObjective|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Invocations+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|271168|542336|813504&cht=bhg&chd=t:100|1.33312190228936|1.07043112264967&chdl=NObjective|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)
![http://chart.apis.google.com/chart?chtt=Allocations+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|172836|345673|518510&cht=bhg&chd=t:100|1.10508958361459|0.342905633449692&chdl=NObjective|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Allocations+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|172836|345673|518510&cht=bhg&chd=t:100|1.10508958361459|0.342905633449692&chdl=NObjective|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)
![http://chart.apis.google.com/chart?chtt=Vararg+invocations+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|1967|3934|5902&cht=bhg&chd=t:100|0|7.70925110132159&chdl=NObjective|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Vararg+invocations+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|1967|3934|5902&cht=bhg&chd=t:100|0|7.70925110132159&chdl=NObjective|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)
![http://chart.apis.google.com/chart?chtt=Managed+memory+consumption+(KiB)&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|9494|18989|28484&cht=bhg&chd=t:1.57281280719|4.78865327903384|100&chdl=NObjective|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Managed+memory+consumption+(KiB)&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|9494|18989|28484&cht=bhg&chd=t:1.57281280719|4.78865327903384|100&chdl=NObjective|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)
![http://chart.apis.google.com/chart?chtt=Unmanaged+memory+consumption+(KiB)&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|21128|42256|63384&cht=bhg&chd=t:25.8109302032059|97.7344440237284|100&chdl=NObjective|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Unmanaged+memory+consumption+(KiB)&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|21128|42256|63384&cht=bhg&chd=t:25.8109302032059|97.7344440237284|100&chdl=NObjective|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)
![http://chart.apis.google.com/chart?chtt=Protected+calls+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|8705|17410|26115&cht=bhg&chd=t:100|9.33180164656328|0&chdl=NObjective|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Protected+calls+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|8705|17410|26115&cht=bhg&chd=t:100|9.33180164656328|0&chdl=NObjective|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)
![http://chart.apis.google.com/chart?chtt=Exception+rethrows+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|2461|4922|7383&cht=bhg&chd=t:100|2.34322091290803|0&chdl=NObjective|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Exception+rethrows+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|2461|4922|7383&cht=bhg&chd=t:100|2.34322091290803|0&chdl=NObjective|mobjc|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)

**Note Monobjc 2.0.492 didn't work on PowerPC with mono 2.6.3**

![http://images.apple.com/support/_images/hero_powermacg4.jpg](http://images.apple.com/support/_images/hero_powermacg4.jpg)

4) `PowerMac` G4 1GHz OS X 10.4.11
```
./run_tiger_tests.sh 

Mono JIT compiler version 2.6.3 (tarball Wed Mar 10 18:31:54 MST 2010)
Copyright (C) 2002-2010 Novell, Inc and Contributors. www.mono-project.com
        TLS:           normal
        GC:            Included Boehm (with typed GC)
        SIGSEGV:       normal
        Notification:  Thread + polling
        Architecture:  ppc
        Disabled:      none

NObjective v0.9.6.0 results:
Invocations per second: 992999
Allocations per second: 467836
Vararg invocations per second: 3660
Protected calls per second: 28710
Exception rethrows per second: 4167
Managed memory consumption (KiB): 448
Unmanaged memory consumption (KiB): 16344

Monobjc v1.0.492.0 results:

Unhandled Exception: System.ExecutionEngineException: SIGILL
cocoa-sharp v1.9.0.0 results:
Invocations per second: 5673
Allocations per second: 1945
Vararg invocations per second: 444
Managed memory consumption (KiB): 46300
Unmanaged memory consumption (KiB): 95768
```

![http://chart.apis.google.com/chart?chtt=Invocations+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|330999|661999|992999&cht=bhg&chd=t:100|0.571299668982547&chdl=NObjective|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Invocations+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|330999|661999|992999&cht=bhg&chd=t:100|0.571299668982547&chdl=NObjective|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)
![http://chart.apis.google.com/chart?chtt=Allocations+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|155945|311890|467836&cht=bhg&chd=t:100|0.415743978659188&chdl=NObjective|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Allocations+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|155945|311890|467836&cht=bhg&chd=t:100|0.415743978659188&chdl=NObjective|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)
![http://chart.apis.google.com/chart?chtt=Vararg+invocations+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|1220|2440|3660&cht=bhg&chd=t:100|12.1311475409836&chdl=NObjective|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Vararg+invocations+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|1220|2440|3660&cht=bhg&chd=t:100|12.1311475409836&chdl=NObjective|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)
![http://chart.apis.google.com/chart?chtt=Managed+memory+consumption+(KiB)&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|15433|30866|46300&cht=bhg&chd=t:0.967602591792657|100&chdl=NObjective|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Managed+memory+consumption+(KiB)&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|15433|30866|46300&cht=bhg&chd=t:0.967602591792657|100&chdl=NObjective|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)
![http://chart.apis.google.com/chart?chtt=Unmanaged+memory+consumption+(KiB)&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|31922|63845|95768&cht=bhg&chd=t:17.0662434216022|100&chdl=NObjective|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Unmanaged+memory+consumption+(KiB)&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|31922|63845|95768&cht=bhg&chd=t:17.0662434216022|100&chdl=NObjective|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)
![http://chart.apis.google.com/chart?chtt=Protected+calls+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|9570|19140|28710&cht=bhg&chd=t:100|0&chdl=NObjective|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Protected+calls+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|9570|19140|28710&cht=bhg&chd=t:100|0&chdl=NObjective|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)
![http://chart.apis.google.com/chart?chtt=Exception+rethrows+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|1389|2778|4167&cht=bhg&chd=t:100|0&chdl=NObjective|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png](http://chart.apis.google.com/chart?chtt=Exception+rethrows+per+second&chts=000000,12&chs=1000x120&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=1:||0:|0|1389|2778|4167&cht=bhg&chd=t:100|0&chdl=NObjective|cocoa-sharp&chco=cc0000,003399,ff00cc,cc6600&chbh=10&nonsense=something_that_ends_with.png)

**Note Monobjc 2.0.492 didn't work on PowerPC with mono 2.6.3**

Libraries used:
  * [NObjective v0.9.5](http://code.google.com/p/nobjective/source/browse/trunk/PerformanceTests/nobjective.cs)
  * [Monobjc v2.0.404](http://code.google.com/p/nobjective/source/browse/trunk/PerformanceTests/monobjc.cs)
  * [Mobjc v0.7](http://code.google.com/p/nobjective/source/browse/trunk/PerformanceTests/mobjc.cs)
  * [Cocoa# v0.9.4](http://code.google.com/p/nobjective/source/browse/trunk/PerformanceTests/cocoasharp.cs)

Contacts:
> Email: eugeny.grishul(a)gmail.com

> Facebook: http://www.facebook.com/profile.php?id=1038466393

> VKontakte: http://vkontakte.ru/id181869

WBR, Eugeny Grishul

> ![http://profile.ak.facebook.com/v224/76/116/n1038466393_7370.jpg](http://profile.ak.facebook.com/v224/76/116/n1038466393_7370.jpg)