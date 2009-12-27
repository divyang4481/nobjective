#!/bin/sh
#
# Copyright (C) 2008 Eugeny Grishul
#
# See license in License.txt
#

cd `dirname "$0"`
killall mono

pushd ..
nant perftests_leopard
if [ "$?" -ne "0" ]; then exit 1; fi; 
popd

cp run_leopard_tests.sh bin/10.5/run_leopard_tests.sh
cd bin

./10.5/run_leopard_tests.sh