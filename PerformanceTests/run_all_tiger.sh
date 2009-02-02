#!/bin/sh
#
# Copyright (C) 2009 Eugeny Grishul
#
# See license in License.txt
#

cd `dirname "$0"`
killall mono

pushd ..
nant perftests_tiger
if [ "$?" -ne "0" ]; then exit 1; fi; 
popd

cp run_tiger_tests.sh bin/run_tiger_tests.sh
cd bin

./run_tiger_tests.sh