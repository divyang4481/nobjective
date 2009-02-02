//
// Copyright (C) 2009 Eugeny Grishul
//
// See license in License.txt
//

using System;
using System.Runtime.InteropServices;
namespace NObjective.Proxies {
	public struct _NSPoint {
		public float x;
		public float y;
	}
	public struct _NSRange {
		public uint location;
		public uint length;
	}
	public struct _NSRect {
		public _NSPoint origin;
		public _NSSize size;
	}
	public struct _NSSize {
		public float width;
		public float height;
	}
	public struct AEDesc {
		public uint descriptorType;
		public IntPtr dataHandle;
	}
	public struct CATransform3D {
		public float m11;
		public float m12;
		public float m13;
		public float m14;
		public float m21;
		public float m22;
		public float m23;
		public float m24;
		public float m31;
		public float m32;
		public float m33;
		public float m34;
		public float m41;
		public float m42;
		public float m43;
		public float m44;
	}
	public struct CGAffineTransform {
		public float a;
		public float b;
		public float c;
		public float d;
		public float tx;
		public float ty;
	}
	public struct CGPoint {
		public float x;
		public float y;
	}
	public struct CGRect {
		public CGPoint origin;
		public CGSize size;
	}
	public struct CGSize {
		public float width;
		public float height;
	}
	public struct CVSMPTETime {
		public short subframes;
		public short subframeDivisor;
		public uint counter;
		public uint type;
		public uint flags;
		public short hours;
		public short minutes;
		public short seconds;
		public short frames;
	}
	public struct CVTimeStamp {
		public uint version;
		public int videoTimeScale;
		public long videoTime;
		public ulong hostTime;
		public double rateScalar;
		public long videoRefreshPeriod;
		public CVSMPTETime smpteTime;
		public ulong flags;
		public ulong reserved;
	}
	public struct NSAffineTransformStruct {
		public float m11;
		public float m12;
		public float m21;
		public float m22;
		public float tX;
		public float tY;
	}
	unsafe public struct NSDecimal {
		private fixed byte __bitsetGroup0[4];
		public int _exponent {
			get {
				throw new NotImplementedException( "TODO" );
			}
			set {
				throw new NotImplementedException( "TODO" );
			}
		}
		public uint _length {
			get {
				throw new NotImplementedException( "TODO" );
			}
			set {
				throw new NotImplementedException( "TODO" );
			}
		}
		public uint _isNegative {
			get {
				throw new NotImplementedException( "TODO" );
			}
			set {
				throw new NotImplementedException( "TODO" );
			}
		}
		public uint _isCompact {
			get {
				throw new NotImplementedException( "TODO" );
			}
			set {
				throw new NotImplementedException( "TODO" );
			}
		}
		public uint _reserved {
			get {
				throw new NotImplementedException( "TODO" );
			}
			set {
				throw new NotImplementedException( "TODO" );
			}
		}
		public fixed ushort _mantissa[16];
	}
	unsafe public struct NSFastEnumerationState {
		public uint state;
		public IntPtr itemsPtr;
		public IntPtr mutationsPtr;
		public fixed uint extra[20];
	}
}
