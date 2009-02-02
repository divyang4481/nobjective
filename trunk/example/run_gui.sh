#!/bin/bash
#
# Copyright (C) 2008 Eugeny Grishul
#

cd `dirname "$0"`

../build_debug.sh
./build_app.sh
./gui.app/Contents/MacOS/gui