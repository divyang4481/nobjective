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

mono NObjective.Performance.Leopard.exe 
#mono Monobjc.Performance.Leopard.exe 
#mono Mobjc.Performance.exe
#mono CocoaSharp.Performance.exe 