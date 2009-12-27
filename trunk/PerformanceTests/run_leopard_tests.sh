#!/bin/sh
#
# Copyright (C) 2009 Eugeny Grishul
#
# See license in License.txt
#

cd `dirname "$0"`

echo
mono --version
echo

mono NObjective.Performance.exe 

if [ "$SKIP_OTHER_BRIDGES" != "1" ]; then
	mono Monobjc.Performance.exe 
	mono Mobjc.Performance.exe
	mono CocoaSharp.Performance.exe
fi;