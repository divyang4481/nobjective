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

if [ "$SKIP_OTHER_BRIDGES" != "1" ]; then
	mono NObjective.Performance.Tiger.exe 
	mono Monobjc.Performance.Tiger.exe 
	mono CocoaSharp.Performance.exe 
fi;