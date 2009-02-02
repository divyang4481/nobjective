#!/bin/sh
#
# Copyright (C) 2008 Eugeny Grishul
#

killall mono
cd `dirname "$0"`
DYLD_LIBRARY_PATH=/Users/Jack/NObjective/bin:$DYLD_LIBRARY_PATH

pushd ..
nant -D:Configuration=debug proxy_generator
if [ "$?" -ne "0" ]; then exit 1; fi; 
popd

cd ../bin
time mono NObjective.ProxyGenerator.exe
if [ "$?" -ne "0" ]; then exit 1; fi; 