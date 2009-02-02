//
// Copyright (C) 2009 Eugeny Grishul
//
// See license in License.txt
//

using System;
using System.Runtime.InteropServices;
namespace NObjective.Proxies {
	public struct _NSAffineTransformStruct {
		public float m11;
		public float m12;
		public float m21;
		public float m22;
		public float tX;
		public float tY;
	}
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
	public struct _NSTypesetterGlyphInfo {
		public _NSPoint curLocation;
		public float extent;
		public float belowBaseline;
		public float aboveBaseline;
		public uint glyphCharacterIndex;
		public NSFont font;
		public _NSSize attachmentSize;
	}
	public struct AEDesc {
		public uint descriptorType;
		public IntPtr dataHandle;
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
}
