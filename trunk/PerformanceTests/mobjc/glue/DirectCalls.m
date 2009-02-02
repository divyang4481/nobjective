// Machine generated on 2008-11-16
#include <Foundation/Foundation.h>
#include <objc/message.h>

// nullary
typedef void (*Methodv)(id, SEL);
void Callv(id instance, SEL selector, id* exception)
{
	@try
	{
		Methodv method = (Methodv) objc_msgSend;
		method(instance, selector);
	}
	@catch (id e)
	{
		*exception = e;
	}
}

typedef void* (*Methodp)(id, SEL);
void* Callp(id instance, SEL selector, id* exception)
{
	void* result;

	@try
	{
		Methodp method = (Methodp) objc_msgSend;
		result = method(instance, selector);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef int (*Methodi)(id, SEL);
int Calli(id instance, SEL selector, id* exception)
{
	int result;

	@try
	{
		Methodi method = (Methodi) objc_msgSend;
		result = method(instance, selector);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef short (*Methods)(id, SEL);
short Calls(id instance, SEL selector, id* exception)
{
	short result;

	@try
	{
		Methods method = (Methods) objc_msgSend;
		result = method(instance, selector);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef unsigned char (*MethodC)(id, SEL);
unsigned char CallC(id instance, SEL selector, id* exception)
{
	unsigned char result;

	@try
	{
		MethodC method = (MethodC) objc_msgSend;
		result = method(instance, selector);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

// unary
typedef void (*Methodvp)(id, SEL, void*);
void Callvp(id instance, SEL selector, void* arg0, id* exception)
{
	@try
	{
		Methodvp method = (Methodvp) objc_msgSend;
		method(instance, selector, arg0);
	}
	@catch (id e)
	{
		*exception = e;
	}
}

typedef void (*Methodvi)(id, SEL, int);
void Callvi(id instance, SEL selector, int arg0, id* exception)
{
	@try
	{
		Methodvi method = (Methodvi) objc_msgSend;
		method(instance, selector, arg0);
	}
	@catch (id e)
	{
		*exception = e;
	}
}

typedef void (*Methodvs)(id, SEL, short);
void Callvs(id instance, SEL selector, short arg0, id* exception)
{
	@try
	{
		Methodvs method = (Methodvs) objc_msgSend;
		method(instance, selector, arg0);
	}
	@catch (id e)
	{
		*exception = e;
	}
}

typedef void (*MethodvC)(id, SEL, unsigned char);
void CallvC(id instance, SEL selector, unsigned char arg0, id* exception)
{
	@try
	{
		MethodvC method = (MethodvC) objc_msgSend;
		method(instance, selector, arg0);
	}
	@catch (id e)
	{
		*exception = e;
	}
}

typedef void* (*Methodpp)(id, SEL, void*);
void* Callpp(id instance, SEL selector, void* arg0, id* exception)
{
	void* result;

	@try
	{
		Methodpp method = (Methodpp) objc_msgSend;
		result = method(instance, selector, arg0);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef void* (*Methodpi)(id, SEL, int);
void* Callpi(id instance, SEL selector, int arg0, id* exception)
{
	void* result;

	@try
	{
		Methodpi method = (Methodpi) objc_msgSend;
		result = method(instance, selector, arg0);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef void* (*Methodps)(id, SEL, short);
void* Callps(id instance, SEL selector, short arg0, id* exception)
{
	void* result;

	@try
	{
		Methodps method = (Methodps) objc_msgSend;
		result = method(instance, selector, arg0);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef void* (*MethodpC)(id, SEL, unsigned char);
void* CallpC(id instance, SEL selector, unsigned char arg0, id* exception)
{
	void* result;

	@try
	{
		MethodpC method = (MethodpC) objc_msgSend;
		result = method(instance, selector, arg0);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef int (*Methodip)(id, SEL, void*);
int Callip(id instance, SEL selector, void* arg0, id* exception)
{
	int result;

	@try
	{
		Methodip method = (Methodip) objc_msgSend;
		result = method(instance, selector, arg0);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef int (*Methodii)(id, SEL, int);
int Callii(id instance, SEL selector, int arg0, id* exception)
{
	int result;

	@try
	{
		Methodii method = (Methodii) objc_msgSend;
		result = method(instance, selector, arg0);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef int (*Methodis)(id, SEL, short);
int Callis(id instance, SEL selector, short arg0, id* exception)
{
	int result;

	@try
	{
		Methodis method = (Methodis) objc_msgSend;
		result = method(instance, selector, arg0);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef int (*MethodiC)(id, SEL, unsigned char);
int CalliC(id instance, SEL selector, unsigned char arg0, id* exception)
{
	int result;

	@try
	{
		MethodiC method = (MethodiC) objc_msgSend;
		result = method(instance, selector, arg0);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef short (*Methodsp)(id, SEL, void*);
short Callsp(id instance, SEL selector, void* arg0, id* exception)
{
	short result;

	@try
	{
		Methodsp method = (Methodsp) objc_msgSend;
		result = method(instance, selector, arg0);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef short (*Methodsi)(id, SEL, int);
short Callsi(id instance, SEL selector, int arg0, id* exception)
{
	short result;

	@try
	{
		Methodsi method = (Methodsi) objc_msgSend;
		result = method(instance, selector, arg0);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef short (*Methodss)(id, SEL, short);
short Callss(id instance, SEL selector, short arg0, id* exception)
{
	short result;

	@try
	{
		Methodss method = (Methodss) objc_msgSend;
		result = method(instance, selector, arg0);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef short (*MethodsC)(id, SEL, unsigned char);
short CallsC(id instance, SEL selector, unsigned char arg0, id* exception)
{
	short result;

	@try
	{
		MethodsC method = (MethodsC) objc_msgSend;
		result = method(instance, selector, arg0);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef unsigned char (*MethodCp)(id, SEL, void*);
unsigned char CallCp(id instance, SEL selector, void* arg0, id* exception)
{
	unsigned char result;

	@try
	{
		MethodCp method = (MethodCp) objc_msgSend;
		result = method(instance, selector, arg0);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef unsigned char (*MethodCi)(id, SEL, int);
unsigned char CallCi(id instance, SEL selector, int arg0, id* exception)
{
	unsigned char result;

	@try
	{
		MethodCi method = (MethodCi) objc_msgSend;
		result = method(instance, selector, arg0);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef unsigned char (*MethodCs)(id, SEL, short);
unsigned char CallCs(id instance, SEL selector, short arg0, id* exception)
{
	unsigned char result;

	@try
	{
		MethodCs method = (MethodCs) objc_msgSend;
		result = method(instance, selector, arg0);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef unsigned char (*MethodCC)(id, SEL, unsigned char);
unsigned char CallCC(id instance, SEL selector, unsigned char arg0, id* exception)
{
	unsigned char result;

	@try
	{
		MethodCC method = (MethodCC) objc_msgSend;
		result = method(instance, selector, arg0);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

// binary
typedef void (*Methodvpp)(id, SEL, void*, void*);
void Callvpp(id instance, SEL selector, void* arg0, void* arg1, id* exception)
{
	@try
	{
		Methodvpp method = (Methodvpp) objc_msgSend;
		method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}
}

typedef void (*Methodvpi)(id, SEL, void*, int);
void Callvpi(id instance, SEL selector, void* arg0, int arg1, id* exception)
{
	@try
	{
		Methodvpi method = (Methodvpi) objc_msgSend;
		method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}
}

typedef void (*Methodvps)(id, SEL, void*, short);
void Callvps(id instance, SEL selector, void* arg0, short arg1, id* exception)
{
	@try
	{
		Methodvps method = (Methodvps) objc_msgSend;
		method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}
}

typedef void (*MethodvpC)(id, SEL, void*, unsigned char);
void CallvpC(id instance, SEL selector, void* arg0, unsigned char arg1, id* exception)
{
	@try
	{
		MethodvpC method = (MethodvpC) objc_msgSend;
		method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}
}

typedef void (*Methodvip)(id, SEL, int, void*);
void Callvip(id instance, SEL selector, int arg0, void* arg1, id* exception)
{
	@try
	{
		Methodvip method = (Methodvip) objc_msgSend;
		method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}
}

typedef void (*Methodvii)(id, SEL, int, int);
void Callvii(id instance, SEL selector, int arg0, int arg1, id* exception)
{
	@try
	{
		Methodvii method = (Methodvii) objc_msgSend;
		method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}
}

typedef void (*Methodvis)(id, SEL, int, short);
void Callvis(id instance, SEL selector, int arg0, short arg1, id* exception)
{
	@try
	{
		Methodvis method = (Methodvis) objc_msgSend;
		method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}
}

typedef void (*MethodviC)(id, SEL, int, unsigned char);
void CallviC(id instance, SEL selector, int arg0, unsigned char arg1, id* exception)
{
	@try
	{
		MethodviC method = (MethodviC) objc_msgSend;
		method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}
}

typedef void (*Methodvsp)(id, SEL, short, void*);
void Callvsp(id instance, SEL selector, short arg0, void* arg1, id* exception)
{
	@try
	{
		Methodvsp method = (Methodvsp) objc_msgSend;
		method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}
}

typedef void (*Methodvsi)(id, SEL, short, int);
void Callvsi(id instance, SEL selector, short arg0, int arg1, id* exception)
{
	@try
	{
		Methodvsi method = (Methodvsi) objc_msgSend;
		method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}
}

typedef void (*Methodvss)(id, SEL, short, short);
void Callvss(id instance, SEL selector, short arg0, short arg1, id* exception)
{
	@try
	{
		Methodvss method = (Methodvss) objc_msgSend;
		method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}
}

typedef void (*MethodvsC)(id, SEL, short, unsigned char);
void CallvsC(id instance, SEL selector, short arg0, unsigned char arg1, id* exception)
{
	@try
	{
		MethodvsC method = (MethodvsC) objc_msgSend;
		method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}
}

typedef void (*MethodvCp)(id, SEL, unsigned char, void*);
void CallvCp(id instance, SEL selector, unsigned char arg0, void* arg1, id* exception)
{
	@try
	{
		MethodvCp method = (MethodvCp) objc_msgSend;
		method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}
}

typedef void (*MethodvCi)(id, SEL, unsigned char, int);
void CallvCi(id instance, SEL selector, unsigned char arg0, int arg1, id* exception)
{
	@try
	{
		MethodvCi method = (MethodvCi) objc_msgSend;
		method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}
}

typedef void (*MethodvCs)(id, SEL, unsigned char, short);
void CallvCs(id instance, SEL selector, unsigned char arg0, short arg1, id* exception)
{
	@try
	{
		MethodvCs method = (MethodvCs) objc_msgSend;
		method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}
}

typedef void (*MethodvCC)(id, SEL, unsigned char, unsigned char);
void CallvCC(id instance, SEL selector, unsigned char arg0, unsigned char arg1, id* exception)
{
	@try
	{
		MethodvCC method = (MethodvCC) objc_msgSend;
		method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}
}

typedef void* (*Methodppp)(id, SEL, void*, void*);
void* Callppp(id instance, SEL selector, void* arg0, void* arg1, id* exception)
{
	void* result;

	@try
	{
		Methodppp method = (Methodppp) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef void* (*Methodppi)(id, SEL, void*, int);
void* Callppi(id instance, SEL selector, void* arg0, int arg1, id* exception)
{
	void* result;

	@try
	{
		Methodppi method = (Methodppi) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef void* (*Methodpps)(id, SEL, void*, short);
void* Callpps(id instance, SEL selector, void* arg0, short arg1, id* exception)
{
	void* result;

	@try
	{
		Methodpps method = (Methodpps) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef void* (*MethodppC)(id, SEL, void*, unsigned char);
void* CallppC(id instance, SEL selector, void* arg0, unsigned char arg1, id* exception)
{
	void* result;

	@try
	{
		MethodppC method = (MethodppC) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef void* (*Methodpip)(id, SEL, int, void*);
void* Callpip(id instance, SEL selector, int arg0, void* arg1, id* exception)
{
	void* result;

	@try
	{
		Methodpip method = (Methodpip) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef void* (*Methodpii)(id, SEL, int, int);
void* Callpii(id instance, SEL selector, int arg0, int arg1, id* exception)
{
	void* result;

	@try
	{
		Methodpii method = (Methodpii) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef void* (*Methodpis)(id, SEL, int, short);
void* Callpis(id instance, SEL selector, int arg0, short arg1, id* exception)
{
	void* result;

	@try
	{
		Methodpis method = (Methodpis) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef void* (*MethodpiC)(id, SEL, int, unsigned char);
void* CallpiC(id instance, SEL selector, int arg0, unsigned char arg1, id* exception)
{
	void* result;

	@try
	{
		MethodpiC method = (MethodpiC) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef void* (*Methodpsp)(id, SEL, short, void*);
void* Callpsp(id instance, SEL selector, short arg0, void* arg1, id* exception)
{
	void* result;

	@try
	{
		Methodpsp method = (Methodpsp) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef void* (*Methodpsi)(id, SEL, short, int);
void* Callpsi(id instance, SEL selector, short arg0, int arg1, id* exception)
{
	void* result;

	@try
	{
		Methodpsi method = (Methodpsi) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef void* (*Methodpss)(id, SEL, short, short);
void* Callpss(id instance, SEL selector, short arg0, short arg1, id* exception)
{
	void* result;

	@try
	{
		Methodpss method = (Methodpss) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef void* (*MethodpsC)(id, SEL, short, unsigned char);
void* CallpsC(id instance, SEL selector, short arg0, unsigned char arg1, id* exception)
{
	void* result;

	@try
	{
		MethodpsC method = (MethodpsC) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef void* (*MethodpCp)(id, SEL, unsigned char, void*);
void* CallpCp(id instance, SEL selector, unsigned char arg0, void* arg1, id* exception)
{
	void* result;

	@try
	{
		MethodpCp method = (MethodpCp) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef void* (*MethodpCi)(id, SEL, unsigned char, int);
void* CallpCi(id instance, SEL selector, unsigned char arg0, int arg1, id* exception)
{
	void* result;

	@try
	{
		MethodpCi method = (MethodpCi) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef void* (*MethodpCs)(id, SEL, unsigned char, short);
void* CallpCs(id instance, SEL selector, unsigned char arg0, short arg1, id* exception)
{
	void* result;

	@try
	{
		MethodpCs method = (MethodpCs) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef void* (*MethodpCC)(id, SEL, unsigned char, unsigned char);
void* CallpCC(id instance, SEL selector, unsigned char arg0, unsigned char arg1, id* exception)
{
	void* result;

	@try
	{
		MethodpCC method = (MethodpCC) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef int (*Methodipp)(id, SEL, void*, void*);
int Callipp(id instance, SEL selector, void* arg0, void* arg1, id* exception)
{
	int result;

	@try
	{
		Methodipp method = (Methodipp) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef int (*Methodipi)(id, SEL, void*, int);
int Callipi(id instance, SEL selector, void* arg0, int arg1, id* exception)
{
	int result;

	@try
	{
		Methodipi method = (Methodipi) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef int (*Methodips)(id, SEL, void*, short);
int Callips(id instance, SEL selector, void* arg0, short arg1, id* exception)
{
	int result;

	@try
	{
		Methodips method = (Methodips) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef int (*MethodipC)(id, SEL, void*, unsigned char);
int CallipC(id instance, SEL selector, void* arg0, unsigned char arg1, id* exception)
{
	int result;

	@try
	{
		MethodipC method = (MethodipC) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef int (*Methodiip)(id, SEL, int, void*);
int Calliip(id instance, SEL selector, int arg0, void* arg1, id* exception)
{
	int result;

	@try
	{
		Methodiip method = (Methodiip) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef int (*Methodiii)(id, SEL, int, int);
int Calliii(id instance, SEL selector, int arg0, int arg1, id* exception)
{
	int result;

	@try
	{
		Methodiii method = (Methodiii) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef int (*Methodiis)(id, SEL, int, short);
int Calliis(id instance, SEL selector, int arg0, short arg1, id* exception)
{
	int result;

	@try
	{
		Methodiis method = (Methodiis) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef int (*MethodiiC)(id, SEL, int, unsigned char);
int CalliiC(id instance, SEL selector, int arg0, unsigned char arg1, id* exception)
{
	int result;

	@try
	{
		MethodiiC method = (MethodiiC) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef int (*Methodisp)(id, SEL, short, void*);
int Callisp(id instance, SEL selector, short arg0, void* arg1, id* exception)
{
	int result;

	@try
	{
		Methodisp method = (Methodisp) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef int (*Methodisi)(id, SEL, short, int);
int Callisi(id instance, SEL selector, short arg0, int arg1, id* exception)
{
	int result;

	@try
	{
		Methodisi method = (Methodisi) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef int (*Methodiss)(id, SEL, short, short);
int Calliss(id instance, SEL selector, short arg0, short arg1, id* exception)
{
	int result;

	@try
	{
		Methodiss method = (Methodiss) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef int (*MethodisC)(id, SEL, short, unsigned char);
int CallisC(id instance, SEL selector, short arg0, unsigned char arg1, id* exception)
{
	int result;

	@try
	{
		MethodisC method = (MethodisC) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef int (*MethodiCp)(id, SEL, unsigned char, void*);
int CalliCp(id instance, SEL selector, unsigned char arg0, void* arg1, id* exception)
{
	int result;

	@try
	{
		MethodiCp method = (MethodiCp) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef int (*MethodiCi)(id, SEL, unsigned char, int);
int CalliCi(id instance, SEL selector, unsigned char arg0, int arg1, id* exception)
{
	int result;

	@try
	{
		MethodiCi method = (MethodiCi) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef int (*MethodiCs)(id, SEL, unsigned char, short);
int CalliCs(id instance, SEL selector, unsigned char arg0, short arg1, id* exception)
{
	int result;

	@try
	{
		MethodiCs method = (MethodiCs) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef int (*MethodiCC)(id, SEL, unsigned char, unsigned char);
int CalliCC(id instance, SEL selector, unsigned char arg0, unsigned char arg1, id* exception)
{
	int result;

	@try
	{
		MethodiCC method = (MethodiCC) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef short (*Methodspp)(id, SEL, void*, void*);
short Callspp(id instance, SEL selector, void* arg0, void* arg1, id* exception)
{
	short result;

	@try
	{
		Methodspp method = (Methodspp) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef short (*Methodspi)(id, SEL, void*, int);
short Callspi(id instance, SEL selector, void* arg0, int arg1, id* exception)
{
	short result;

	@try
	{
		Methodspi method = (Methodspi) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef short (*Methodsps)(id, SEL, void*, short);
short Callsps(id instance, SEL selector, void* arg0, short arg1, id* exception)
{
	short result;

	@try
	{
		Methodsps method = (Methodsps) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef short (*MethodspC)(id, SEL, void*, unsigned char);
short CallspC(id instance, SEL selector, void* arg0, unsigned char arg1, id* exception)
{
	short result;

	@try
	{
		MethodspC method = (MethodspC) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef short (*Methodsip)(id, SEL, int, void*);
short Callsip(id instance, SEL selector, int arg0, void* arg1, id* exception)
{
	short result;

	@try
	{
		Methodsip method = (Methodsip) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef short (*Methodsii)(id, SEL, int, int);
short Callsii(id instance, SEL selector, int arg0, int arg1, id* exception)
{
	short result;

	@try
	{
		Methodsii method = (Methodsii) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef short (*Methodsis)(id, SEL, int, short);
short Callsis(id instance, SEL selector, int arg0, short arg1, id* exception)
{
	short result;

	@try
	{
		Methodsis method = (Methodsis) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef short (*MethodsiC)(id, SEL, int, unsigned char);
short CallsiC(id instance, SEL selector, int arg0, unsigned char arg1, id* exception)
{
	short result;

	@try
	{
		MethodsiC method = (MethodsiC) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef short (*Methodssp)(id, SEL, short, void*);
short Callssp(id instance, SEL selector, short arg0, void* arg1, id* exception)
{
	short result;

	@try
	{
		Methodssp method = (Methodssp) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef short (*Methodssi)(id, SEL, short, int);
short Callssi(id instance, SEL selector, short arg0, int arg1, id* exception)
{
	short result;

	@try
	{
		Methodssi method = (Methodssi) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef short (*Methodsss)(id, SEL, short, short);
short Callsss(id instance, SEL selector, short arg0, short arg1, id* exception)
{
	short result;

	@try
	{
		Methodsss method = (Methodsss) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef short (*MethodssC)(id, SEL, short, unsigned char);
short CallssC(id instance, SEL selector, short arg0, unsigned char arg1, id* exception)
{
	short result;

	@try
	{
		MethodssC method = (MethodssC) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef short (*MethodsCp)(id, SEL, unsigned char, void*);
short CallsCp(id instance, SEL selector, unsigned char arg0, void* arg1, id* exception)
{
	short result;

	@try
	{
		MethodsCp method = (MethodsCp) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef short (*MethodsCi)(id, SEL, unsigned char, int);
short CallsCi(id instance, SEL selector, unsigned char arg0, int arg1, id* exception)
{
	short result;

	@try
	{
		MethodsCi method = (MethodsCi) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef short (*MethodsCs)(id, SEL, unsigned char, short);
short CallsCs(id instance, SEL selector, unsigned char arg0, short arg1, id* exception)
{
	short result;

	@try
	{
		MethodsCs method = (MethodsCs) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef short (*MethodsCC)(id, SEL, unsigned char, unsigned char);
short CallsCC(id instance, SEL selector, unsigned char arg0, unsigned char arg1, id* exception)
{
	short result;

	@try
	{
		MethodsCC method = (MethodsCC) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef unsigned char (*MethodCpp)(id, SEL, void*, void*);
unsigned char CallCpp(id instance, SEL selector, void* arg0, void* arg1, id* exception)
{
	unsigned char result;

	@try
	{
		MethodCpp method = (MethodCpp) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef unsigned char (*MethodCpi)(id, SEL, void*, int);
unsigned char CallCpi(id instance, SEL selector, void* arg0, int arg1, id* exception)
{
	unsigned char result;

	@try
	{
		MethodCpi method = (MethodCpi) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef unsigned char (*MethodCps)(id, SEL, void*, short);
unsigned char CallCps(id instance, SEL selector, void* arg0, short arg1, id* exception)
{
	unsigned char result;

	@try
	{
		MethodCps method = (MethodCps) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef unsigned char (*MethodCpC)(id, SEL, void*, unsigned char);
unsigned char CallCpC(id instance, SEL selector, void* arg0, unsigned char arg1, id* exception)
{
	unsigned char result;

	@try
	{
		MethodCpC method = (MethodCpC) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef unsigned char (*MethodCip)(id, SEL, int, void*);
unsigned char CallCip(id instance, SEL selector, int arg0, void* arg1, id* exception)
{
	unsigned char result;

	@try
	{
		MethodCip method = (MethodCip) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef unsigned char (*MethodCii)(id, SEL, int, int);
unsigned char CallCii(id instance, SEL selector, int arg0, int arg1, id* exception)
{
	unsigned char result;

	@try
	{
		MethodCii method = (MethodCii) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef unsigned char (*MethodCis)(id, SEL, int, short);
unsigned char CallCis(id instance, SEL selector, int arg0, short arg1, id* exception)
{
	unsigned char result;

	@try
	{
		MethodCis method = (MethodCis) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef unsigned char (*MethodCiC)(id, SEL, int, unsigned char);
unsigned char CallCiC(id instance, SEL selector, int arg0, unsigned char arg1, id* exception)
{
	unsigned char result;

	@try
	{
		MethodCiC method = (MethodCiC) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef unsigned char (*MethodCsp)(id, SEL, short, void*);
unsigned char CallCsp(id instance, SEL selector, short arg0, void* arg1, id* exception)
{
	unsigned char result;

	@try
	{
		MethodCsp method = (MethodCsp) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef unsigned char (*MethodCsi)(id, SEL, short, int);
unsigned char CallCsi(id instance, SEL selector, short arg0, int arg1, id* exception)
{
	unsigned char result;

	@try
	{
		MethodCsi method = (MethodCsi) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef unsigned char (*MethodCss)(id, SEL, short, short);
unsigned char CallCss(id instance, SEL selector, short arg0, short arg1, id* exception)
{
	unsigned char result;

	@try
	{
		MethodCss method = (MethodCss) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef unsigned char (*MethodCsC)(id, SEL, short, unsigned char);
unsigned char CallCsC(id instance, SEL selector, short arg0, unsigned char arg1, id* exception)
{
	unsigned char result;

	@try
	{
		MethodCsC method = (MethodCsC) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef unsigned char (*MethodCCp)(id, SEL, unsigned char, void*);
unsigned char CallCCp(id instance, SEL selector, unsigned char arg0, void* arg1, id* exception)
{
	unsigned char result;

	@try
	{
		MethodCCp method = (MethodCCp) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef unsigned char (*MethodCCi)(id, SEL, unsigned char, int);
unsigned char CallCCi(id instance, SEL selector, unsigned char arg0, int arg1, id* exception)
{
	unsigned char result;

	@try
	{
		MethodCCi method = (MethodCCi) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef unsigned char (*MethodCCs)(id, SEL, unsigned char, short);
unsigned char CallCCs(id instance, SEL selector, unsigned char arg0, short arg1, id* exception)
{
	unsigned char result;

	@try
	{
		MethodCCs method = (MethodCCs) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

typedef unsigned char (*MethodCCC)(id, SEL, unsigned char, unsigned char);
unsigned char CallCCC(id instance, SEL selector, unsigned char arg0, unsigned char arg1, id* exception)
{
	unsigned char result;

	@try
	{
		MethodCCC method = (MethodCCC) objc_msgSend;
		result = method(instance, selector, arg0, arg1);
	}
	@catch (id e)
	{
		*exception = e;
	}

	return result;
}

