#!/usr/bin/python
# Used to generate the source/DirectCalls.cs and glue/DirectCalls.m files.
import datetime
import string
import sys

# f - float
# d - double
# s - short

rtypes = ["void", "void*", "int", "short", "unsigned char"]
atypes = ["void*", "int", "short", "unsigned char"]

labels = {
	"int" : "i",
	"short" : "s", 
	"unsigned char" : "C", 
	"void" : "v", 
	"void*" : "p", 
}
mtypes = {
	"int" : "Int32",
	"short" : "Int16", 
	"unsigned char" : "Byte",
	"void" : "void", 
	"void*" : "IntPtr", 
}

class GenerateCS:
	def __init__(self, path):
		self.__file = open(path, "w")
		
	def generate(self):
		self.write("// Machine generated on %s" % datetime.date.today())
		self.write("using System;")
		self.write("using System.Runtime.InteropServices;")
		self.write("")
		self.write("namespace MObjc")
		self.write("{")
		self.write("	public static class DirectCalls")
		self.write("	{")
		self.writeCalls()
		self.write("	}")
		self.write("}")
		self.write("")
		self.__file.flush()
		
	def writeCalls(self):
		self.write("		// nullary")
		for rtype in rtypes:
			self.write("		[DllImport(\"mobjc-glue.dylib\")]")
			self.write("		public extern static %s Call%s(IntPtr instance, IntPtr selector, ref IntPtr exception);" % (mtypes[rtype], labels[rtype]))
			self.write("")

		self.write("		// unary")
		for rtype in rtypes:
			for a0 in atypes:
				self.write("		[DllImport(\"mobjc-glue.dylib\")]")
				self.write("		public extern static %s Call%s%s(IntPtr instance, IntPtr selector, %s arg0, ref IntPtr exception);" % (mtypes[rtype], labels[rtype], labels[a0], mtypes[a0]))
				self.write("")

		self.write("		// binary")
		for rtype in rtypes:
			for a0 in atypes:
				for a1 in atypes:
					self.write("		[DllImport(\"mobjc-glue.dylib\")]")
					self.write("		public extern static %s Call%s%s%s(IntPtr instance, IntPtr selector, %s arg0, %s arg1, ref IntPtr exception);" % (mtypes[rtype], labels[rtype], labels[a0], labels[a1], mtypes[a0], mtypes[a1]))
					self.write("")
		
	def write(self, s):
		self.__file.write(s)
		self.__file.write("\n")

class GenerateObjc:
	def __init__(self, path):
		self.__file = open(path, "w")
		
	def generate(self):
		self.write("// Machine generated on %s" % datetime.date.today())
		self.write("#include <Foundation/Foundation.h>")
		self.write("#include <objc/message.h>")
		self.write("")
		self.writeCalls()
		self.__file.flush()
		
	def writeCalls(self):
		self.write("// nullary")
		for rtype in rtypes:
			self.write("typedef %s (*Method%s)(id, SEL);" % (rtype, labels[rtype]))
			self.write("%s Call%s(id instance, SEL selector, id* exception)" % (rtype, labels[rtype]))
			self.write("{")
			if rtype != "void":
				self.write("	%s result;" % rtype)
				self.write("")
				self.write("	@try")
				self.write("	{")
				self.write("		Method%s method = (Method%s) objc_msgSend;" % (labels[rtype], labels[rtype]))
				self.write("		result = method(instance, selector);")
				self.write("	}")
				self.write("	@catch (id e)")
				self.write("	{")
				self.write("		*exception = e;")
				self.write("	}")
				self.write("")	
				self.write("	return result;")
			else:
				self.write("	@try")
				self.write("	{")
				self.write("		Method%s method = (Method%s) objc_msgSend;" % (labels[rtype], labels[rtype]))
				self.write("		method(instance, selector);")
				self.write("	}")
				self.write("	@catch (id e)")
				self.write("	{")
				self.write("		*exception = e;")
				self.write("	}")
			self.write("}")
			self.write("")
		
		self.write("// unary")
		for rtype in rtypes:
			for a0 in atypes:
				self.write("typedef %s (*Method%s%s)(id, SEL, %s);" % (rtype, labels[rtype], labels[a0], a0))
				self.write("%s Call%s%s(id instance, SEL selector, %s arg0, id* exception)" % (rtype, labels[rtype], labels[a0], a0))
				self.write("{")
				if rtype != "void":
					self.write("	%s result;" % rtype)
					self.write("")
					self.write("	@try")
					self.write("	{")
					self.write("		Method%s%s method = (Method%s%s) objc_msgSend;" % (labels[rtype], labels[a0], labels[rtype], labels[a0]))
					self.write("		result = method(instance, selector, arg0);")
					self.write("	}")
					self.write("	@catch (id e)")
					self.write("	{")
					self.write("		*exception = e;")
					self.write("	}")
					self.write("")	
					self.write("	return result;")
				else:
					self.write("	@try")
					self.write("	{")
					self.write("		Method%s%s method = (Method%s%s) objc_msgSend;" % (labels[rtype], labels[a0], labels[rtype], labels[a0]))
					self.write("		method(instance, selector, arg0);")
					self.write("	}")
					self.write("	@catch (id e)")
					self.write("	{")
					self.write("		*exception = e;")
					self.write("	}")
				self.write("}")
				self.write("")
		
		self.write("// binary")
		for rtype in rtypes:
			for a0 in atypes:
				for a1 in atypes:
					self.write("typedef %s (*Method%s%s%s)(id, SEL, %s, %s);" % (rtype, labels[rtype], labels[a0], labels[a1], a0, a1))
					self.write("%s Call%s%s%s(id instance, SEL selector, %s arg0, %s arg1, id* exception)" % (rtype, labels[rtype], labels[a0], labels[a1], a0, a1))
					self.write("{")
					if rtype != "void":
						self.write("	%s result;" % rtype)
						self.write("")
						self.write("	@try")
						self.write("	{")
						self.write("		Method%s%s%s method = (Method%s%s%s) objc_msgSend;" % (labels[rtype], labels[a0], labels[a1], labels[rtype], labels[a0], labels[a1]))
						self.write("		result = method(instance, selector, arg0, arg1);")
						self.write("	}")
						self.write("	@catch (id e)")
						self.write("	{")
						self.write("		*exception = e;")
						self.write("	}")
						self.write("")	
						self.write("	return result;")
					else:
						self.write("	@try")
						self.write("	{")
						self.write("		Method%s%s%s method = (Method%s%s%s) objc_msgSend;" % (labels[rtype], labels[a0], labels[a1], labels[rtype], labels[a0], labels[a1]))
						self.write("		method(instance, selector, arg0, arg1);")
						self.write("	}")
						self.write("	@catch (id e)")
						self.write("	{")
						self.write("		*exception = e;")
						self.write("	}")
					self.write("}")
					self.write("")
		
	def write(self, s):
		self.__file.write(s)
		self.__file.write("\n")

generate = GenerateCS("source/DirectCalls.cs")
generate.generate()

generate = GenerateObjc("glue/DirectCalls.m")
generate.generate()
