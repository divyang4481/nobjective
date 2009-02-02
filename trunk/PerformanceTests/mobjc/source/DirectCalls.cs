// Machine generated on 2008-11-16
using System;
using System.Runtime.InteropServices;

namespace MObjc
{
	[DisableRule("S1020", "VisiblePInvoke")]	// these have to be visible so mcocoa's fast path can get at them
	public static class DirectCalls
	{
		// nullary
		[DllImport("mobjc-glue.dylib")]
		public extern static void Callv(IntPtr instance, IntPtr selector, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static IntPtr Callp(IntPtr instance, IntPtr selector, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int32 Calli(IntPtr instance, IntPtr selector, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int16 Calls(IntPtr instance, IntPtr selector, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Byte CallC(IntPtr instance, IntPtr selector, ref IntPtr exception);

		// unary
		[DllImport("mobjc-glue.dylib")]
		public extern static void Callvp(IntPtr instance, IntPtr selector, IntPtr arg0, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static void Callvi(IntPtr instance, IntPtr selector, Int32 arg0, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static void Callvs(IntPtr instance, IntPtr selector, Int16 arg0, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static void CallvC(IntPtr instance, IntPtr selector, Byte arg0, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static IntPtr Callpp(IntPtr instance, IntPtr selector, IntPtr arg0, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static IntPtr Callpi(IntPtr instance, IntPtr selector, Int32 arg0, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static IntPtr Callps(IntPtr instance, IntPtr selector, Int16 arg0, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static IntPtr CallpC(IntPtr instance, IntPtr selector, Byte arg0, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int32 Callip(IntPtr instance, IntPtr selector, IntPtr arg0, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int32 Callii(IntPtr instance, IntPtr selector, Int32 arg0, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int32 Callis(IntPtr instance, IntPtr selector, Int16 arg0, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int32 CalliC(IntPtr instance, IntPtr selector, Byte arg0, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int16 Callsp(IntPtr instance, IntPtr selector, IntPtr arg0, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int16 Callsi(IntPtr instance, IntPtr selector, Int32 arg0, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int16 Callss(IntPtr instance, IntPtr selector, Int16 arg0, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int16 CallsC(IntPtr instance, IntPtr selector, Byte arg0, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Byte CallCp(IntPtr instance, IntPtr selector, IntPtr arg0, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Byte CallCi(IntPtr instance, IntPtr selector, Int32 arg0, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Byte CallCs(IntPtr instance, IntPtr selector, Int16 arg0, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Byte CallCC(IntPtr instance, IntPtr selector, Byte arg0, ref IntPtr exception);

		// binary
		[DllImport("mobjc-glue.dylib")]
		public extern static void Callvpp(IntPtr instance, IntPtr selector, IntPtr arg0, IntPtr arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static void Callvpi(IntPtr instance, IntPtr selector, IntPtr arg0, Int32 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static void Callvps(IntPtr instance, IntPtr selector, IntPtr arg0, Int16 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static void CallvpC(IntPtr instance, IntPtr selector, IntPtr arg0, Byte arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static void Callvip(IntPtr instance, IntPtr selector, Int32 arg0, IntPtr arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static void Callvii(IntPtr instance, IntPtr selector, Int32 arg0, Int32 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static void Callvis(IntPtr instance, IntPtr selector, Int32 arg0, Int16 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static void CallviC(IntPtr instance, IntPtr selector, Int32 arg0, Byte arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static void Callvsp(IntPtr instance, IntPtr selector, Int16 arg0, IntPtr arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static void Callvsi(IntPtr instance, IntPtr selector, Int16 arg0, Int32 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static void Callvss(IntPtr instance, IntPtr selector, Int16 arg0, Int16 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static void CallvsC(IntPtr instance, IntPtr selector, Int16 arg0, Byte arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static void CallvCp(IntPtr instance, IntPtr selector, Byte arg0, IntPtr arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static void CallvCi(IntPtr instance, IntPtr selector, Byte arg0, Int32 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static void CallvCs(IntPtr instance, IntPtr selector, Byte arg0, Int16 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static void CallvCC(IntPtr instance, IntPtr selector, Byte arg0, Byte arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static IntPtr Callppp(IntPtr instance, IntPtr selector, IntPtr arg0, IntPtr arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static IntPtr Callppi(IntPtr instance, IntPtr selector, IntPtr arg0, Int32 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static IntPtr Callpps(IntPtr instance, IntPtr selector, IntPtr arg0, Int16 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static IntPtr CallppC(IntPtr instance, IntPtr selector, IntPtr arg0, Byte arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static IntPtr Callpip(IntPtr instance, IntPtr selector, Int32 arg0, IntPtr arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static IntPtr Callpii(IntPtr instance, IntPtr selector, Int32 arg0, Int32 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static IntPtr Callpis(IntPtr instance, IntPtr selector, Int32 arg0, Int16 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static IntPtr CallpiC(IntPtr instance, IntPtr selector, Int32 arg0, Byte arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static IntPtr Callpsp(IntPtr instance, IntPtr selector, Int16 arg0, IntPtr arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static IntPtr Callpsi(IntPtr instance, IntPtr selector, Int16 arg0, Int32 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static IntPtr Callpss(IntPtr instance, IntPtr selector, Int16 arg0, Int16 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static IntPtr CallpsC(IntPtr instance, IntPtr selector, Int16 arg0, Byte arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static IntPtr CallpCp(IntPtr instance, IntPtr selector, Byte arg0, IntPtr arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static IntPtr CallpCi(IntPtr instance, IntPtr selector, Byte arg0, Int32 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static IntPtr CallpCs(IntPtr instance, IntPtr selector, Byte arg0, Int16 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static IntPtr CallpCC(IntPtr instance, IntPtr selector, Byte arg0, Byte arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int32 Callipp(IntPtr instance, IntPtr selector, IntPtr arg0, IntPtr arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int32 Callipi(IntPtr instance, IntPtr selector, IntPtr arg0, Int32 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int32 Callips(IntPtr instance, IntPtr selector, IntPtr arg0, Int16 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int32 CallipC(IntPtr instance, IntPtr selector, IntPtr arg0, Byte arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int32 Calliip(IntPtr instance, IntPtr selector, Int32 arg0, IntPtr arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int32 Calliii(IntPtr instance, IntPtr selector, Int32 arg0, Int32 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int32 Calliis(IntPtr instance, IntPtr selector, Int32 arg0, Int16 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int32 CalliiC(IntPtr instance, IntPtr selector, Int32 arg0, Byte arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int32 Callisp(IntPtr instance, IntPtr selector, Int16 arg0, IntPtr arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int32 Callisi(IntPtr instance, IntPtr selector, Int16 arg0, Int32 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int32 Calliss(IntPtr instance, IntPtr selector, Int16 arg0, Int16 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int32 CallisC(IntPtr instance, IntPtr selector, Int16 arg0, Byte arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int32 CalliCp(IntPtr instance, IntPtr selector, Byte arg0, IntPtr arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int32 CalliCi(IntPtr instance, IntPtr selector, Byte arg0, Int32 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int32 CalliCs(IntPtr instance, IntPtr selector, Byte arg0, Int16 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int32 CalliCC(IntPtr instance, IntPtr selector, Byte arg0, Byte arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int16 Callspp(IntPtr instance, IntPtr selector, IntPtr arg0, IntPtr arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int16 Callspi(IntPtr instance, IntPtr selector, IntPtr arg0, Int32 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int16 Callsps(IntPtr instance, IntPtr selector, IntPtr arg0, Int16 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int16 CallspC(IntPtr instance, IntPtr selector, IntPtr arg0, Byte arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int16 Callsip(IntPtr instance, IntPtr selector, Int32 arg0, IntPtr arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int16 Callsii(IntPtr instance, IntPtr selector, Int32 arg0, Int32 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int16 Callsis(IntPtr instance, IntPtr selector, Int32 arg0, Int16 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int16 CallsiC(IntPtr instance, IntPtr selector, Int32 arg0, Byte arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int16 Callssp(IntPtr instance, IntPtr selector, Int16 arg0, IntPtr arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int16 Callssi(IntPtr instance, IntPtr selector, Int16 arg0, Int32 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int16 Callsss(IntPtr instance, IntPtr selector, Int16 arg0, Int16 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int16 CallssC(IntPtr instance, IntPtr selector, Int16 arg0, Byte arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int16 CallsCp(IntPtr instance, IntPtr selector, Byte arg0, IntPtr arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int16 CallsCi(IntPtr instance, IntPtr selector, Byte arg0, Int32 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int16 CallsCs(IntPtr instance, IntPtr selector, Byte arg0, Int16 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Int16 CallsCC(IntPtr instance, IntPtr selector, Byte arg0, Byte arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Byte CallCpp(IntPtr instance, IntPtr selector, IntPtr arg0, IntPtr arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Byte CallCpi(IntPtr instance, IntPtr selector, IntPtr arg0, Int32 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Byte CallCps(IntPtr instance, IntPtr selector, IntPtr arg0, Int16 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Byte CallCpC(IntPtr instance, IntPtr selector, IntPtr arg0, Byte arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Byte CallCip(IntPtr instance, IntPtr selector, Int32 arg0, IntPtr arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Byte CallCii(IntPtr instance, IntPtr selector, Int32 arg0, Int32 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Byte CallCis(IntPtr instance, IntPtr selector, Int32 arg0, Int16 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Byte CallCiC(IntPtr instance, IntPtr selector, Int32 arg0, Byte arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Byte CallCsp(IntPtr instance, IntPtr selector, Int16 arg0, IntPtr arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Byte CallCsi(IntPtr instance, IntPtr selector, Int16 arg0, Int32 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Byte CallCss(IntPtr instance, IntPtr selector, Int16 arg0, Int16 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Byte CallCsC(IntPtr instance, IntPtr selector, Int16 arg0, Byte arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Byte CallCCp(IntPtr instance, IntPtr selector, Byte arg0, IntPtr arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Byte CallCCi(IntPtr instance, IntPtr selector, Byte arg0, Int32 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Byte CallCCs(IntPtr instance, IntPtr selector, Byte arg0, Int16 arg1, ref IntPtr exception);

		[DllImport("mobjc-glue.dylib")]
		public extern static Byte CallCCC(IntPtr instance, IntPtr selector, Byte arg0, Byte arg1, ref IntPtr exception);

	}
}

