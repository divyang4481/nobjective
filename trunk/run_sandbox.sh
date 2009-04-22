#!/bin/sh
#
# Copyright (C) 2009 Eugeny Grishul
#
# See license in License.txt
#

cd `dirname "$0"`
killall mono

gmcs -target:exe -unsafe -out:bin/Sandbox.exe Platform.cs Sandbox.cs
if [ "$?" -ne "0" ]; then exit 1; fi; 

echo ==start==
mono bin/Sandbox.exe
echo ==end==
read