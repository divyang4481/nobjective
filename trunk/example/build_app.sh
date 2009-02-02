#!/bin/bash
#
# Copyright (C) 2008 Eugeny Grishul
#

cd `dirname "$0"`

ASSEMBLY_NAME=gui
APPLICATION_ICON=mono.icns
EXECUTABLE_NAME=$ASSEMBLY_NAME.exe
APPLICATION_NAME=$ASSEMBLY_NAME.app
APPLICATION_CONTENTS=$APPLICATION_NAME/Contents
APPLICATION_RESOURCES=$APPLICATION_CONTENTS/Resources
APPLICATION_MACOS=$APPLICATION_CONTENTS/MacOS
APPLICATION_MACOS_MAIN=$APPLICATION_MACOS/$ASSEMBLY_NAME

rm -drf $APPLICATION_NAME
mkdir $APPLICATION_NAME
mkdir $APPLICATION_CONTENTS
mkdir $APPLICATION_RESOURCES
mkdir $APPLICATION_MACOS

#setup main file
echo \
"#!/bin/bash
cd \`dirname \"\$0\"\`
cd ../Resources
rm -f ./$ASSEMBLY_NAME
ln -s \`which mono\` ./$ASSEMBLY_NAME
./$ASSEMBLY_NAME ./$EXECUTABLE_NAME
" > $APPLICATION_MACOS_MAIN

echo \
"<?xml version=\"1.0\" encoding=\"UTF-8\"?>
<!DOCTYPE plist PUBLIC \"-//Apple//DTD PLIST 1.0//EN\" \"http://www.apple.com/DTDs/PropertyList-1.0.dtd\">
<plist version=\"1.0\">
<dict>
	<key>CFBundleDevelopmentRegion</key>
	<string>English</string>
	<key>CFBundleExecutable</key>
	<string>$ASSEMBLY_NAME</string>
	<key>CFBundleIdentifier</key>
	<string>com.evilsoftware.gui</string>
	<key>CFBundleInfoDictionaryVersion</key>
	<string>6.0</string>
	<key>CFBundleName</key>
	<string>$ASSEMBLY_NAME</string>
	<key>CFBundlePackageType</key>
	<string>APPL</string>
	<key>CFBundleSignature</key>
	<string>????</string>
	<key>CFBundleVersion</key>
	<string>1.0</string>
	<key>NSMainNibFile</key>
	<string>GUI</string>
	<key>NSPrincipalClass</key>
	<string>NSApplication</string>
	<key>CFBundleIconFile</key>
	<string>$APPLICATION_ICON</string></dict>
</plist>
" > $APPLICATION_CONTENTS/Info.plist

echo Copy dependencies..
cp ../bin/NObjective.dll $APPLICATION_RESOURCES
cp ../bin/NObjective.Proxies.Leopard.dll $APPLICATION_RESOURCES
cp ../bin/NObjective.dylib $APPLICATION_RESOURCES
cp $APPLICATION_ICON $APPLICATION_RESOURCES

echo Compiling..
gmcs -define:TRACE,DEBUG -m:NObjective.GUITest -warn:4 -target:exe -unsafe -r:../bin/NObjective.dll -r:../bin/NObjective.Proxies.Leopard.dll -out:$APPLICATION_RESOURCES/$EXECUTABLE_NAME \
	*.cs
if [ "$?" -ne "0" ]; then exit 1; fi

echo Converting XIBs..
ibtool --errors --warnings --notices --output-format human-readable-text --compile $APPLICATION_RESOURCES/GUI.nib GUI.xib

echo OK!