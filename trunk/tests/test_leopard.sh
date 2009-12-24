#!/bin/sh
#
# Copyright (C) 2009 Eugeny Grishul
#
# See license in License.txt
#

cd `dirname "$0"`
killall mono

cd ..
/Library/Frameworks/Mono.framework/Versions/Current/bin/nant -D:Configuration=debug tests_leopard
if [ "$?" -ne "0" ]; then exit 1; fi;

#nunit_image=`which nunit-console2`
nunit_image=/Library/Frameworks/Mono.framework/Versions/Current/bin/nunit-console2


cd bin
$nunit_image -nologo NObjective.Tests.Leopard.dll # /fixture=NObjective.Tests.ProxiesTest