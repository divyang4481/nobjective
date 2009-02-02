# ------------------
# Public variables
TEST1 ?= ReturnTests
CSC ?= gmcs
GCC ?= gcc
NUNIT ?= nunit-console2
MONO ?= mono
GENDARME ?= /usr/local/bin/gendarme/gendarme.exe

ifdef RELEASE
	# Note that -debug+ just generates an mdb file.
	CSC_FLAGS ?= -checked+ -debug+ -optimize+ -warn:4 -d:TRACE
	GCC_FLAGS ?= -Wall -O3
else
	CSC_FLAGS ?= -checked+ -debug+ -warn:4 -warnaserror+ -d:DEBUG -d:TRACE
	GCC_FLAGS ?= -ggdb -Wall -Werror -D DEBUG
endif

INSTALL_DIR ?= /usr/local

# ------------------
# Internal variables
dummy1 := $(shell mkdir bin 2> /dev/null)			
dummy2 := $(shell if [[ "$(CSC_FLAGS)" != `cat bin/csc_flags 2> /dev/null` ]]; then echo "$(CSC_FLAGS)" > bin/csc_flags; fi)
dummy3 := $(shell if [[ "$(GCC_FLAGS)" != `cat bin/gcc_flags 2> /dev/null` ]]; then echo "$(GCC_FLAGS)" > bin/gcc_flags; fi)

base_version := 0.4.xxx.0										# major.minor.build.revision
version := $(shell ./get_version.sh $(base_version) build_num)	# this will increment the build number stored in build_num
version := $(strip $(version))
export version

# use the libffi that ships with leopard
ffi_include := /usr/include
ffi_lib := ffi
#ffi_include := /usr/local/lib/libffi-3.0.5/include	# the newer libffi
#ffi_lib := ffi.5

pkg_config_dir := $(INSTALL_DIR)/lib/pkgconfig

# ------------------
# Primary targets
all: bin/tests.dll bin/sample.exe

libs: bin/mobjc.dll bin/mobjc-glue.dylib

# Note that it's important to cd to the tests directory: nunit doesn't seem
# to like absolute paths to the tests dll and if you're not in the tests
# directory and aren't using an absolute path to nunit the tests dll won't
# be able to use other dlls beside it.
test: bin/tests.dll bin/mobjc-glue.dylib
	cd bin && "$(NUNIT)" -nologo tests.dll

# TODO: if mono ever ships an nunit that isn't a thousand years old we can
# use -run instead of -fixture which is a bit more flexible.
test1: bin/tests.dll bin/mobjc-glue.dylib
	cd bin && "$(NUNIT)" -nologo -fixture=$(TEST1) tests.dll 

app: libs
	cd sample && make app
	
run-app: libs
	cd sample && make run

# ------------------
# Binary targets 
bin/mobjc.dll: keys bin/csc_flags source/*.cs
	@./gen_version.sh $(version) source/AssemblyVersion.cs
	$(CSC) -out:bin/mobjc.dll $(CSC_FLAGS) -keyfile:keys -target:library source/*.cs

bin/mobjc-glue.dylib: bin/gcc_flags glue/*.m
	$(GCC) -o bin/mobjc-glue.dylib $(GCC_FLAGS) -framework Foundation -dynamiclib -l$(ffi_lib) -I $(ffi_include) glue/*.m

bin/tests.dll: bin/csc_flags bin/mobjc.dll test/*.cs
	$(CSC) -out:bin/tests.dll $(CSC_FLAGS) -pkg:mono-nunit -r:bin/mobjc.dll -target:library test/*.cs

# ------------------
# Misc targets
keys: 
	sn -k keys
	
smokey_flags := --not-localized -set:naming:jurassic
smokey_flags += -exclude-check:D1020	# NativeMethods
smokey_flags += -exclude-check:PO1001	# DllImportPath
smokey_flags += -exclude-check:PO1002	# DllImportExtension
smokey_flags += -exclude-check:P1003	# AvoidBoxing
smokey_flags += -exclude-check:P1004	# AvoidUnboxing
smokey_flags += -exclude-check:P1005	# StringConcat
smokey_flags += -exclude-check:R1039	# ThreadSafeAttr
smokey_flags += -exclude-check:S1020	# VisiblePInvoke (mcocoa needs these for the fast path)
smoke: bin/mobjc.dll
	@-smoke $(smokey_flags) bin/mobjc.dll
	
gendarme_flags := --severity all --confidence all --ignore gendarme.ignore --quiet
gendarme: bin/mobjc.dll
	@-$(MONO) "$(GENDARME)" $(gendarme_flags) bin/mobjc.dll
	
clean:
	-rm -rf bin/Sample.app
	-rm  bin/TestResult.xml
	-rm  bin/*.exe
	-rm  bin/*.dylib
	-rm -rf bin/*.dSYM
	-rm  bin/*.dll
	-rm  bin/*.mdb
	
help:
	@echo "mobjc version $(version)"
	@echo " "
	@echo "The primary targets are:"
	@echo "libs      - build the managed and native dll's"
	@echo "test      - run the unit tests"
	@echo "app       - build the cocoa sample app"
	@echo "run-app   - run the cocoa sample app"
	@echo "install   - install the dll's and a pkg-config file"
	@echo "uninstall - remove the dll's and the pkg-config file"
	@echo " "
	@echo "Variables include:"
	@echo "RELEASE - define to enable release builds, defaults to not defined"
	@echo "INSTALL_DIR - where to put the dlls, defaults to $(INSTALL_DIR)"
	@echo " "
	@echo "Here's an example:"	
	@echo "sudo make RELEASE=1 install"	

pc_file := $(pkg_config_dir)/mobjc.pc
install: libs
	cp "cocoa-pack" "$(INSTALL_DIR)/bin"
	cp "bin/mobjc-glue.dylib" "$(INSTALL_DIR)/lib"
	cp "bin/mobjc.dll" "$(INSTALL_DIR)/lib"
ifndef RELEASE
	cp "bin/mobjc.dll.mdb" "$(INSTALL_DIR)/lib"
endif
	@echo "generating $(pc_file)"
	@echo "# Use 'cp \x60pkg-config --variable=Libraries mobjc\x60 bin' to copy the libraries into your build directory." > $(pc_file)
	@echo "# 'pkg-config --libs mobjc' can be used to get the gmcs flags." >> $(pc_file)
	@echo "# 'pkg-config --cflags mobjc' can be used to get the (optional) macpack flags." >> $(pc_file)
	@echo "prefix=$(INSTALL_DIR)/lib" >> $(pc_file)
	@echo "Libraries=\x24{prefix}/mobjc.dll \x24{prefix}/mobjc-glue.dylib\c" >> $(pc_file)
ifndef RELEASE
	@echo " \x24{prefix}/mobjc.dll.mdb\c" >> $(pc_file)
endif
	@echo "" >> $(pc_file)
	@echo "" >> $(pc_file)
	@echo "Name: mobjc" >> $(pc_file)
	@echo "Description: Cocoa/Mono bridge" >> $(pc_file)
	@echo "Version: $(version)" >> $(pc_file)
	@echo "Libs: -r:mobjc.dll" >> $(pc_file)
	@echo "Cflags: -r:mobjc.dll -r:mobjc-glue.dylib\c" >> $(pc_file)
ifndef RELEASE
	@echo " -r:mobjc.dll.mdb\c" >> $(pc_file)
endif
	@echo "" >> $(pc_file)
	
uninstall:
	-rm "$(INSTALL_DIR)/bin/cocoa-pack"
	-rm "$(INSTALL_DIR)/lib/mobjc-glue.dylib"
	-rm "$(INSTALL_DIR)/lib/mobjc.dll"
	-rm "$(INSTALL_DIR)/lib/mobjc.dll.mdb"
	-rm $(pc_file)
	
tar:
	tar --create --compress --exclude \*/.svn --exclude \*/.svn/\* --file=mobjc-$(version).tar.gz \
		CHANGES CHANGE_LOG MIT.X11 Makefile README cocoa-pack gen_direct.py gendarme.ignore gen_version.sh get_version.sh glue sample source test 

