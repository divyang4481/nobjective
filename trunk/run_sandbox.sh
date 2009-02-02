#!/bin/sh
#
# Copyright (C) 2009 Eugeny Grishul
#
# See license in License.txt
#

cd `dirname "$0"`
killall mono

gmcs -target:exe -unsafe -out:bin/Sandbox.dll Platform.cs Sandbox.cs

mono bin/Sandbox.dll
echo ==end==
read