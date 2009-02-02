# ------------------
# Public variables
CSC ?= gmcs
PACK ?= ../cocoa-pack

ifdef RELEASE
	CSC_FLAGS ?= -checked+ -warn:4 -optimize+
else
	CSC_FLAGS ?= -checked+ -debug+ -warnaserror+ -warn:4 -define:DEBUG
	MONO_FLAGS ?= --debug
endif

# ------------------
# Internal variables
bin-path := ../bin
exe-name := sample
app-name := Sample

app-path := $(bin-path)/$(app-name).app
contents-path := $(app-path)/Contents
macos-path := $(contents-path)/MacOS
exe-path := $(bin-path)/$(exe-name).exe

dummy ?= $(shell if [[ "$(CSC_FLAGS)" != `cat $(bin-path)/csc_flags 2> /dev/null` ]]; then echo "$(CSC_FLAGS)" > $(bin-path)/csc_flags; fi)
build-num := $(shell echo "$(version)" | cut -d . -f 3)

# ------------------
# Primary targets
all: app

app: $(app-path)

# Note that running this way (instead of via open or the Finder) allows us to see console
# output in the terminal instead of the system log.
run: $(app-path)
	$(macos-path)/launcher

# ------------------
# Binary targets 
# Note that with your own apps you would normally have an update-libraries target in your
# makefile which copies the mobjc libraries into your project. Something like this:
# update-libraries:
#	cp `pkg-config --variable=Libraries mobjc` bin

# assembly 
gmcs-resources := $(bin-path)/mobjc.dll
gmcs-files := $(shell echo $(gmcs-resources) | sed "s/,/ /g")
source-files := *.cs

$(exe-path): $(bin-path)/csc_flags $(gmcs-files) $(source-files)
	$(CSC) -out:$(exe-path) $(CSC_FLAGS) -r:$(gmcs-resources) -target:exe $(source-files)

# bundle
localized-resources := MainMenu.nib
localized-files := $(shell echo $(localized-resources) | sed "s/,/ /g")

other-resources := $(bin-path)/mobjc-glue.dylib
other-files := $(shell echo $(other-resources) | sed "s/,/ /g")

$(app-path): $(exe-path) Info.plist $(other-files) $(localized-files) $(PACK)
	@echo "building $(app-path)"
	$(PACK) --app=$(app-path) --exe=$(exe-path) --mono-flags='$(MONO_FLAGS)' --plist=Info.plist           \
	--resources=$(gmcs-resources),$(other-resources) --resources=English.lproj:$(localized-resources) \
	--vars=APPNAME:$(app-name),VERSION:$(version),BUILDNUM:$(build-num)



