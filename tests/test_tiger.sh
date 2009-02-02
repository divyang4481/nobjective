#!/bin/sh
#
# Copyright (C) 2009 Eugeny Grishul
#
# See license in License.txt
#

cd `dirname "$0"`
killall mono

cd ..
nant -D:Configuration=debug tests_tiger
if [ "$?" -ne "0" ]; then exit 1; fi;

#nunit_image=`which nunit-console2`
#nunit_image=/Library/Frameworks/Mono.framework/Versions/2.0.1/bin/nunit-console2
nunit_image=/Library/Frameworks/Mono.framework/Versions/2.2/bin/nunit-console2

cd bin
$nunit_image /nologo NObjective.Tests.Tiger.dll # /fixture=NObjective.Tests.ProxiesTest