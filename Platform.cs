//
// Copyright (C) 2009 Eugeny Grishul
//
// See license in License.txt
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace NObjective
{
	/// <summary>
	/// Managed wrapper for MachO and other platform services.
	/// See usr\include\**\*.h
	/// </summary>
	public static unsafe class Platform
	{
#pragma warning disable 649
		/// <summary>
		/// Specifies general attributes of the file.
		/// </summary>
		public unsafe struct mach_header
		{
			/// <summary>
			/// mach magic number identifier
			/// </summary>
			public MachOFileTypeMagic magic;

			/// <summary>
			/// cpu specifier
			/// </summary>
			public CpuType cputype;

			/// <summary>
			/// machine specifier
			/// </summary>
			public int cpusubtype;

			/// <summary>
			/// type of file
			/// </summary>
			public MachOFileType filetype;

			/// <summary>
			/// number of load commands
			/// </summary>
			public uint ncmds;

			/// <summary>
			/// the size of all the load commands
			/// </summary>
			public uint sizeofcmds;

			/// <summary>
			/// flags
			/// </summary>
			public MachOFileFlags flags;

			/// <summary>
			/// Retrieves string representation of object.
			/// </summary>
			/// <returns></returns>
			public override string ToString()
			{
				return string.Format( @"{{ magic={0} cputype={1} cpusubtype={2} filetype={3} ncmds={4} sizeofcmds={5} flags=""{6}"" }}", magic, cputype, cpusubtype, filetype, ncmds, sizeofcmds, flags );
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public struct section
		{
			/// <summary>
			/// name of this section
			/// </summary>
			public fixed byte sectname[16];

			/// <summary>
			/// name of this section
			/// </summary>
			public string Section
			{
				get
				{
					fixed( byte* sectionName = sectname )
						return Marshal.PtrToStringAnsi( new IntPtr( sectionName ), 16 );
				}
			}

			/// <summary>
			/// segment this section goes in
			/// </summary>
			public fixed byte segname[16];

			/// <summary>
			/// segment this section goes in
			/// </summary>
			public string Segment
			{
				get
				{
					fixed( byte* segmentName = segname )
						return Marshal.PtrToStringAnsi( new IntPtr( segmentName ), 16 );
				}
			}
			/// <summary>
			/// memory address of this section
			/// </summary>
			public uint addr;

			/// <summary>
			/// size in bytes of this section
			/// </summary>
			public uint size;

			/// <summary>
			/// file offset of this section
			/// </summary>
			public uint offset;

			/// <summary>
			/// section alignment (power of 2)
			/// </summary>
			public uint align;

			/// <summary>
			/// file offset of relocation entries
			/// </summary>
			public uint reloff;

			/// <summary>
			/// number of relocation entries
			/// </summary>
			public uint nreloc;

			/// <summary>
			/// flags (section type and attributes)
			/// </summary>
			public uint flags;

			/// <summary>
			/// reserved (for offset or index)
			/// </summary>
			public uint reserved1;

			/// <summary>
			/// reserved (for count or sizeof)
			/// </summary>
			public uint reserved2;

			/// <summary>
			/// Retrieves string representation of object.
			/// </summary>
			/// <returns></returns>
			public override string ToString()
			{
				return string.Format( @"{{ sectname={0}, segname={1}, addr={2}, size={3}, offset={4}, align={5}, reloff={6}, nreloc={7}, flags={8}, reserved1={9}, reserved2={10} }}", Section, Segment, addr, size, offset, align, reloff, nreloc, flags, reserved1, reserved2 );
			}
		};

		/// <summary>
		/// 
		/// </summary>
		public struct section_64
		{
			/// <summary>
			/// name of this section
			/// </summary>
			public fixed byte sectname[16];

			/// <summary>
			/// segment this section goes in
			/// </summary>
			public fixed byte segname[16];

			/// <summary>
			/// memory address of this section
			/// </summary>
			public ulong addr;

			/// <summary>
			/// size in bytes of this section 
			/// </summary>
			public ulong size;

			/// <summary>
			/// file offset of this section
			/// </summary>
			public uint offset;

			/// <summary>
			/// section alignment (power of 2)
			/// </summary>
			public uint align;

			/// <summary>
			/// file offset of relocation entries
			/// </summary>
			public uint reloff;

			/// <summary>
			/// number of relocation entries
			/// </summary>
			public uint nreloc;

			/// <summary>
			/// flags (section type and attributes)
			/// </summary>
			public uint flags;

			/// <summary>
			/// reserved (for offset or index)
			/// </summary>
			public uint reserved1;

			/// <summary>
			/// reserved (for count or sizeof)
			/// </summary>
			public uint reserved2;

			/// <summary>
			/// reserved
			/// </summary>
			public uint reserved3;
		};

		/// <summary>
		/// 
		/// </summary>
		public enum CpuType
		{
			/// <summary></summary>
			CPU_TYPE_ANY = -1,
			/// <summary></summary>
			CPU_TYPE_VAX = 1,
			/// <summary></summary>
			CPU_TYPE_MC680x0 = 6,
			/// <summary></summary>
			CPU_TYPE_X86 = 7,
			/// <summary></summary>
			CPU_TYPE_I386 = CPU_TYPE_X86,
			/// <summary></summary>
			CPU_TYPE_X86_64 = ( CPU_TYPE_X86 | 0x01000000 ),
			/// <summary></summary>
			CPU_TYPE_MC98000 = 10,
			/// <summary></summary>
			CPU_TYPE_HPPA = 11,
			/// <summary></summary>
			CPU_TYPE_MC88000 = 13,
			/// <summary></summary>
			CPU_TYPE_SPARC = 14,
			/// <summary></summary>
			CPU_TYPE_I860 = 15,
			/// <summary></summary>
			CPU_TYPE_POWERPC = 18,
			/// <summary></summary>
			CPU_TYPE_POWERPC64 = ( CPU_TYPE_POWERPC | 0x01000000 )
		}

		/// <summary>
		/// MachOFileType
		/// </summary>
		public enum MachOFileType
		{
			/// <summary>
			/// relocatable object file
			/// </summary>
			MH_OBJECT = 0x1,

			/// <summary>
			/// demand paged executable file
			/// </summary>
			MH_EXECUTE = 0x2,

			/// <summary>
			/// fixed VM shared library file
			/// </summary>
			MH_FVMLIB = 0x3,

			/// <summary>
			/// core file
			/// </summary>
			MH_CORE = 0x4,

			/// <summary>
			/// preloaded executable file
			/// </summary>
			MH_PRELOAD = 0x5,

			/// <summary>
			/// dynamically bound shared library
			/// </summary>
			MH_DYLIB = 0x6,

			/// <summary>
			/// dynamic link editor
			/// </summary>
			MH_DYLINKER = 0x7,

			/// <summary>
			/// dynamically bound bundle file
			/// </summary>
			MH_BUNDLE = 0x8,

			/// <summary>
			/// shared library stub for static
			/// </summary>
			MH_DYLIB_STUB = 0x9,

			/// <summary>
			/// linking only, no section contents companion file with only debug sections
			/// </summary>
			MH_DSYM = 0xa
		}

		/// <summary>
		/// 
		/// </summary>
		public enum MachOFileTypeMagic : uint
		{
			/// <summary></summary>
			MH_MAGIC = 0xfeedface,
			/// <summary></summary>
			MH_CIGAM = 0xcefaedfe,
			/// <summary></summary>
			MH_MAGIC_64 = 0xfeedfacf,
			/// <summary></summary>
			MH_CIGAM_64 = 0xcffaedfe
		}

		/// <summary>
		/// MachOFileFlags
		/// </summary>
		[Flags]
		public enum MachOFileFlags
		{
			/// <summary>
			/// the object file has no undefined references
			/// </summary>
			MH_NOUNDEFS = 0x1,

			/// <summary>
			/// the object file is the output of an incremental link against a base file and can't be link edited again
			/// </summary>
			MH_INCRLINK = 0x2,

			/// <summary>
			/// the object file is input for the dynamic linker and can't be staticly link edited again
			/// </summary>
			MH_DYLDLINK = 0x4,

			/// <summary>
			/// the object file's undefined references are bound by the dynamic linker when loaded.
			/// </summary>
			MH_BINDATLOAD = 0x8,

			/// <summary>
			/// the file has its dynamic undefined references prebound.
			/// </summary>
			MH_PREBOUND = 0x10,

			/// <summary>
			/// the file has its read-only and read-write segments split
			/// </summary>
			MH_SPLIT_SEGS = 0x20,

			/// <summary>
			/// the shared library init routine is to be run lazily via catching memory faults to its writeable segments (obsolete)
			/// </summary>
			MH_LAZY_INIT = 0x40,

			/// <summary>
			/// the image is using two-level name space bindings 
			/// </summary>
			MH_TWOLEVEL = 0x80,
			/// <summary>
			/// the executable is forcing all images to use flat name space bindings
			/// </summary>
			MH_FORCE_FLAT = 0x100,
			/// <summary>
			/// this umbrella guarantees no multiple defintions of symbols in its sub-images so the two-level namespace hints can always be used.
			/// </summary>
			MH_NOMULTIDEFS = 0x200,

			/// <summary>
			/// do not have dyld notify the prebinding agent about this executable
			/// </summary>
			MH_NOFIXPREBINDING = 0x400,

			/// <summary>
			/// the binary is not prebound but can have its prebinding redone. only used when MH_PREBOUND is not set.
			/// </summary>
			MH_PREBINDABLE = 0x800,

			/// <summary>
			/// indicates that this binary binds to all two-level namespace modules of its dependent libraries. only used when MH_PREBINDABLE and MH_TWOLEVEL are both set.
			/// </summary>
			MH_ALLMODSBOUND = 0x1000,

			/// <summary>
			/// safe to divide up the sections into sub-sections via symbols for dead code stripping
			/// </summary>
			MH_SUBSECTIONS_VIA_SYMBOLS = 0x2000,

			/// <summary>
			/// the binary has been canonicalized via the unprebind operation
			/// </summary>
			MH_CANONICAL = 0x4000,

			/// <summary>
			/// the final linked image contains external weak symbols
			/// </summary>
			MH_WEAK_DEFINES = 0x8000,

			/// <summary>
			/// the final linked image uses weak symbols
			/// </summary>
			MH_BINDS_TO_WEAK = 0x10000,

			/// <summary>
			/// When this bit is set, all stacks in the task will be given stack execution privilege.  Only used in MH_EXECUTE filetypes.
			/// </summary>
			MH_ALLOW_STACK_EXECUTION = 0x20000
		}

		/// <summary>
		/// Infromation about address from dynamic linker.
		/// </summary>
		public struct Dl_info
		{
			/// <summary>
			/// The pathname of the shared object containing the address.
			/// </summary>
			public IntPtr dli_fname;

			/// <summary>
			/// The base address (mach_header) at which the image is mapped into the address space of the calling process.
			/// </summary>
			public mach_header* dli_fbase;

			/// <summary>
			/// The name of the nearest run-time symbol with a value less than or equal to addr.
			/// </summary>
			public IntPtr dli_sname;

			/// <summary>
			/// The value of the symbol returned in dli_sname.
			/// </summary>
			public IntPtr dli_saddr;
		}

		/// <summary>
		/// 
		/// </summary>
		public enum LoadCommandType : uint
		{
			/// <summary></summary>
			LC_REQ_DYLD = 0x80000000,

			/// <summary>
			/// segment of this file to be mapped
			/// </summary>
			LC_SEGMENT = 0x1,

			/// <summary>
			/// link-edit stab symbol table info
			/// </summary>
			LC_SYMTAB = 0x2,

			/// <summary>
			/// link-edit gdb symbol table info (obsolete)
			/// </summary>
			LC_SYMSEG = 0x3,

			/// <summary>
			/// thread
			/// </summary>
			LC_THREAD = 0x4,

			/// <summary>
			/// unix thread (includes a stack)
			/// </summary>
			LC_UNIXTHREAD = 0x5,

			/// <summary>
			/// load a specified fixed VM shared library
			/// </summary>
			LC_LOADFVMLIB = 0x6,

			/// <summary>
			/// fixed VM shared library identification
			/// </summary>
			LC_IDFVMLIB = 0x7,

			/// <summary>
			/// object identification info (obsolete)
			/// </summary>
			LC_IDENT = 0x8,

			/// <summary>
			/// fixed VM file inclusion (internal use)
			/// </summary>
			LC_FVMFILE = 0x9,

			/// <summary>
			/// prepage command (internal use)
			/// </summary>
			LC_PREPAGE = 0xa,

			/// <summary>
			/// dynamic link-edit symbol table info
			/// </summary>
			LC_DYSYMTAB = 0xb,

			/// <summary>
			/// load a dynamically linked shared library
			/// </summary>
			LC_LOAD_DYLIB = 0xc,

			/// <summary>
			/// dynamically linked shared lib ident
			/// </summary>
			LC_ID_DYLIB = 0xd,

			/// <summary>
			/// load a dynamic linker
			/// </summary>
			LC_LOAD_DYLINKER = 0xe,

			/// <summary>
			/// dynamic linker identification
			/// </summary>
			LC_ID_DYLINKER = 0xf,

			/// <summary>
			/// modules prebound for a dynamically
			/// </summary>
			LC_PREBOUND_DYLIB = 0x10,

			/// <summary>
			/// image routines
			/// </summary>
			LC_ROUTINES = 0x11,

			/// <summary>
			/// sub framework
			/// </summary>
			LC_SUB_FRAMEWORK = 0x12,

			/// <summary>
			/// sub umbrella
			/// </summary>
			LC_SUB_UMBRELLA = 0x13,

			/// <summary>
			/// sub client
			/// </summary>
			LC_SUB_CLIENT = 0x14,

			/// <summary>
			/// sub library
			/// </summary>
			LC_SUB_LIBRARY = 0x15,

			/// <summary>
			/// two-level namespace lookup hints
			/// </summary>
			LC_TWOLEVEL_HINTS = 0x16,

			/// <summary>
			/// prebind checksum
			/// </summary>
			LC_PREBIND_CKSUM = 0x17,

			/// <summary>
			/// 
			/// </summary>
			LC_LOAD_WEAK_DYLIB = ( 0x18 | LC_REQ_DYLD ),

			/// <summary>
			/// 64-bit segment of this file to be mapped
			/// </summary>
			LC_SEGMENT_64 = 0x19,

			/// <summary>
			/// 64-bit image routines
			/// </summary>
			LC_ROUTINES_64 = 0x1a,

			/// <summary>
			/// the uuid
			/// </summary>
			LC_UUID = 0x1b,

			/// <summary>
			/// runpath additions
			/// </summary>
			LC_RPATH = ( 0x1c | LC_REQ_DYLD ),

			/// <summary>
			/// local of code signature
			/// </summary>
			LC_CODE_SIGNATURE = 0x1d,

			/// <summary>
			/// local of info to split segments
			/// </summary>
			LC_SEGMENT_SPLIT_INFO = 0x1e,

			/// <summary>
			/// load and re-export dylib
			/// </summary>
			LC_REEXPORT_DYLIB = ( 0x1f | LC_REQ_DYLD ),

			/// <summary>
			/// delay load of dylib until first use
			/// </summary>
			LC_LAZY_LOAD_DYLIB = 0x20,

			/// <summary>
			/// encrypted segment information
			/// </summary>
			LC_ENCRYPTION_INFO = 0x21,
		}

		/// <summary>
		/// 
		/// </summary>
		public struct load_command
		{
			/// <summary>
			/// type of load command
			/// </summary>
			public LoadCommandType cmd;

			/// <summary>
			/// total size of command in bytes
			/// </summary>
			public uint cmdsize;

			/// <summary>
			/// 
			/// </summary>
			/// <returns></returns>
			public override string ToString()
			{
				return string.Format( "{{ cmd={0}, cmdsize={1} }}", cmd, cmdsize );
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public struct dylib
		{
			/// <summary>
			/// library's path name
			/// </summary>
			public int name;

			/// <summary>
			/// library's build time stamp
			/// </summary>
			public uint timestamp;

			/// <summary>
			/// library's current version number
			/// </summary>
			public uint current_version;

			/// <summary>
			/// library's compatibility vers number
			/// </summary>
			public uint compatibility_version;

			/// <summary>
			/// 
			/// </summary>
			public string Name
			{
				get
				{
					fixed( int* thisPtr = &name )
						return Marshal.PtrToStringAnsi( new IntPtr( name + ( byte* ) ( thisPtr - 2 ) ) );
				}
			}

			/// <summary>
			/// 
			/// </summary>
			/// <returns></returns>
			public override string ToString()
			{
				return string.Format( "{{ name={0}, timestamp={1}, current_version={2}, compatibility_version={3} }}", name, timestamp, current_version, compatibility_version );
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public struct dylib_command
		{
			/// <summary>
			/// LC_ID_DYLIB, LC_LOAD_{,WEAK_}DYLIB, LC_REEXPORT_DYLIB
			/// </summary>
			public LoadCommandType cmd;

			/// <summary>
			/// includes pathname string
			/// </summary>
			public uint cmdsize;

			/// <summary>
			/// the library identification
			/// </summary>
			public dylib dylib;

			/// <summary>
			/// 
			/// </summary>
			/// <returns></returns>
			public override string ToString()
			{
				return string.Format( "{{ cmd={0}, cmdsize={1}, dylib={2} }}", cmd, cmdsize, dylib );
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public struct uuid_command
		{
			/// <summary>
			/// LC_UUID
			/// </summary>
			public LoadCommandType cmd;

			/// <summary>
			/// sizeof( uuid_command )
			/// </summary>
			public uint cmdsize;

			/// <summary>
			/// the 128-bit uuid
			/// </summary>
			public fixed byte uuid[16];
		}

		/// <summary>
		/// 
		/// </summary>
		[Flags]
		public enum vm_prot_t
		{
			/// <summary>
			/// 
			/// </summary>
			VM_PROT_NONE = 0x00,

			/// <summary>
			/// read permission
			/// </summary>
			VM_PROT_READ = 0x01,

			/// <summary>
			/// write permission
			/// </summary>
			VM_PROT_WRITE = 0x02,

			/// <summary>
			/// execute permission
			/// </summary>
			VM_PROT_EXECUTE = 0x04,

			/// <summary>
			/// An invalid protection value.
			/// Used only by memory_object_lock_request to indicate no change to page locks.  Using -1 here is a bad idea because it looks like VM_PROT_ALL and then some.
			/// </summary>
			VM_PROT_NO_CHANGE = 0x08,

			/// <summary>
			/// When a caller finds that he cannot obtain write permission on a mapped entry, the following flag can be used.  The entry will be made "needs copy" effectively copying the object (using COW), and write permission will be added to the maximum protections for the associated entry. 
			/// </summary>
			VM_PROT_COPY = 0x10,

			/// <summary>
			///	Another invalid protection value. 
			///	Used only by memory_object_data_request upon an object which has specified a copy_call copy strategy.
			///	It is used when the kernel wants a page belonging to a copy of the object, and is only asking the object as a result of	following a shadow chain.
			///	This solves the race between pages being pushed up by the memory manager and the kernel walking down the shadow chain.
			/// </summary>
			VM_PROT_WANTS_COPY = 0x10
		}

		/// <summary>
		/// Constants for the flags field of the segment_command
		/// </summary>
		[Flags]
		public enum SegmentFlags
		{
			/// <summary>
			/// the file contents for this segment is for the high part of the VM space, the low part is zero filled (for stacks in core files)
			/// </summary>
			SG_HIGHVM = 0x1,

			/// <summary>
			/// this segment is the VM that is allocated by a fixed VM library, for overlap checking in the link editor
			/// </summary>
			SG_FVMLIB = 0x2,

			/// <summary>
			/// this segment has nothing that was relocated in it and nothing relocated to it, that is  it maybe safely replaced without relocation
			/// </summary>
			SG_NORELOC = 0x4,

			/// <summary>
			/// This segment is protected.  If the segment starts at file offset 0, the first page of the segment is not protected.  All other pages of the segment are protected.
			/// </summary>
			SG_PROTECTED_VERSION_1 = 0x8
		}

		/// <summary>
		/// for 32-bit architectures
		/// </summary>
		public struct segment_command
		{
			/// <summary>
			/// LC_SEGMENT
			/// </summary>
			public LoadCommandType cmd;

			/// <summary>
			/// includes sizeof section structs
			/// </summary>
			public uint cmdsize;

			/// <summary>
			/// segment name
			/// </summary>
			public fixed byte segname[16];

			/// <summary>
			/// memory address of this segment
			/// </summary>
			public uint vmaddr;

			/// <summary>
			/// memory size of this segment
			/// </summary>
			public uint vmsize;

			/// <summary>
			/// file offset of this segment
			/// </summary>
			public uint fileoff;

			/// <summary>
			/// amount to map from the file
			/// </summary>
			public uint filesize;

			/// <summary>
			/// maximum VM protection
			/// </summary>
			public vm_prot_t maxprot;

			/// <summary>
			/// initial VM protection
			/// </summary>
			public vm_prot_t initprot;

			/// <summary>
			/// number of sections in segment
			/// </summary>
			public uint nsects;

			/// <summary>
			/// flags
			/// </summary>
			public SegmentFlags flags;

			/// <summary>
			/// segment name
			/// </summary>
			public string SegmentName
			{
				get
				{
					fixed( byte* segmentName = segname )
						return Marshal.PtrToStringAnsi( new IntPtr( segmentName ), 16 );
				}
			}

			/// <summary>
			/// 
			/// </summary>
			/// <returns></returns>
			public override string ToString()
			{
				return string.Format( @"{{ cmd={0}, cmdsize={1}, segname={2}, vmaddr={3}, vmsize={4}, fileoff={5}, filesize={6}, maxprot=""{7}"", initprot=""{8}"", nsects={9}, flags={10} }}", cmd, cmdsize, SegmentName, vmaddr, vmsize, fileoff, filesize, maxprot, initprot, nsects, flags );
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="header"></param>
		/// <returns></returns>
		public static string[] GetReferencedLibraries( mach_header* header )
		{
			var result = new List<string>();

			var commands = ( Platform.load_command* ) ( header + 1 );
			for( uint j = 0; j < header->ncmds; j++ )
			{
				if( commands->cmd == Platform.LoadCommandType.LC_LOAD_DYLIB || commands->cmd == Platform.LoadCommandType.LC_LOAD_WEAK_DYLIB || commands->cmd == Platform.LoadCommandType.LC_REEXPORT_DYLIB )
				{
					var dylibCommand = ( Platform.dylib_command* ) commands;
					result.Add( dylibCommand->dylib.Name );
				}

				commands = ( Platform.load_command* ) ( ( ( byte* ) commands ) + commands->cmdsize );
			}

			return result.ToArray();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="header"></param>
		/// <returns></returns>
		public static string[] GetSegmentNames( mach_header* header )
		{
			var result = new List<string>();

			var commands = ( Platform.load_command* ) ( header + 1 );
			for( uint j = 0; j < header->ncmds; j++ )
			{
				if( commands->cmd == Platform.LoadCommandType.LC_SEGMENT )
				{
					var segmentCommand = ( Platform.segment_command* ) commands;
					result.Add( segmentCommand->SegmentName );
				}

				commands = ( Platform.load_command* ) ( ( ( byte* ) commands ) + commands->cmdsize );
			}

			return result.ToArray();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="header"></param>
		/// <param name="segmentName"></param>
		/// <returns></returns>
		public static string[] GetSectionNames( mach_header* header, string segmentName )
		{
			var result = new List<string>();

			var commands = ( Platform.load_command* ) ( header + 1 );
			for( uint j = 0; j < header->ncmds; j++ )
			{
				if( commands->cmd == Platform.LoadCommandType.LC_SEGMENT )
				{
					var segmentCommand = ( Platform.segment_command* ) commands;
					if( segmentCommand->SegmentName == segmentName )
					{
						var sections = ( Platform.section* ) ( segmentCommand + 1 );

						for( int k = 0; k < segmentCommand->nsects; k++ )
							result.Add( sections[k].Section );
					}
				}

				commands = ( Platform.load_command* ) ( ( ( byte* ) commands ) + commands->cmdsize );
			}

			return result.ToArray();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="header"></param>
		/// <param name="imageSlide"></param>
		public static void DumpInformation( mach_header* header, IntPtr imageSlide )
		{
			Console.WriteLine( "mach_header: {0}", *header );
			var commands = ( Platform.load_command* ) ( header + 1 );
			for( uint j = 0; j < header->ncmds; j++ )
			{
				if( commands->cmd == Platform.LoadCommandType.LC_ID_DYLIB || commands->cmd == Platform.LoadCommandType.LC_LOAD_DYLIB || commands->cmd == Platform.LoadCommandType.LC_LOAD_WEAK_DYLIB || commands->cmd == Platform.LoadCommandType.LC_REEXPORT_DYLIB )
				{
					var dylibCommand = ( Platform.dylib_command* ) commands;
					Console.WriteLine( " dylib_command: {0}", *dylibCommand );
					Console.WriteLine( "  loads {0}", dylibCommand->dylib.Name );
				}
				else if( commands->cmd == Platform.LoadCommandType.LC_SEGMENT )
				{
					var segmentCommand = ( Platform.segment_command* ) commands;
					Console.WriteLine( " segment_command: {0}", *segmentCommand );

					var sections = ( Platform.section* ) ( segmentCommand + 1 );
					for( int k = 0; k < segmentCommand->nsects; k++ )
					{
						Console.WriteLine( "  section: {0}", sections[k] );

						var sectionStart = sections[k].addr + ( uint ) imageSlide.ToInt32();
						var sectionEnd = sections[k].addr + sections[k].size + ( uint ) imageSlide.ToInt32();

						if( sections[k].Section == "__protocol" )
						{
							for( var protocolAddress = sectionStart; protocolAddress < sectionEnd; protocolAddress += ( uint ) sizeof( RuntimeV1Implementation.objc_protocol ) )
							{
								var protocolObject = new RuntimeProtocol( new IntPtr( ( int ) protocolAddress ) );

								var adoptedProtocols = protocolObject.GetAdoptedProtocols();
								Console.WriteLine( "   @protocol {0}{1} {2}", protocolObject.Name, adoptedProtocols.Length != 0 ? " <" + string.Join( ", ", adoptedProtocols.Select( x => x.Name + " " + x.Address ).ToArray() ) + ">" : "", protocolObject.Address );
							}
						}
						else if( sections[k].Section == "__class" || sections[k].Section == "__meta_class" )
						{
							var filler = Runtime.Version == Runtime.MacOSVersion.Leopard ? IntPtr.Size * 6 : IntPtr.Size * 2;
							for( var classAddress = sectionStart; classAddress < sectionEnd; classAddress += ( uint ) ( sizeof( RuntimeV1Implementation.objc_class ) + filler ) )
							{
								var classObject = new RuntimeClass( new IntPtr( ( int ) classAddress ) );

								var adoptedProtocols = classObject.GetAdoptedProtocols();
								Console.WriteLine( "   @class {0} : {1}{2}", classObject.Name, classObject.BaseClass.Name, adoptedProtocols.Length != 0 ? " <" + string.Join( ", ", adoptedProtocols.Select( x => x.Name + " " + x.Address ).ToArray() ) + ">" : "" );
							}
						}
						else if( sections[k].Section == "__category" )
						{
							var filler = Runtime.Version == Runtime.MacOSVersion.Leopard ? IntPtr.Size * 2 : -IntPtr.Size;
							Console.WriteLine( sizeof( RuntimeV1Implementation.objc_category ) );
							for( var categoryAddress = sectionStart; categoryAddress < sectionEnd; categoryAddress += ( uint ) ( sizeof( RuntimeV1Implementation.objc_category ) + filler ) )
							{
								var categoryObject = ( RuntimeV1Implementation.objc_category* ) categoryAddress;
								Console.WriteLine( "   @class {0}({1})", ( uint ) categoryObject->class_name.ToInt32() < 0xFFFF ? "<invalid>=" + categoryObject->class_name : Marshal.PtrToStringAnsi( categoryObject->class_name ), ( uint ) categoryObject->category_name.ToInt32() < 0xFFFF ? "<invalid>=" + categoryObject->category_name : Marshal.PtrToStringAnsi( categoryObject->category_name ) );
							}
						}
					}
				}
				else
					Console.WriteLine( " {0}", *commands );

				commands = ( Platform.load_command* ) ( ( ( byte* ) commands ) + commands->cmdsize );
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public static void DumpAll()
		{
			var imagesCount = NativeMethods._dyld_image_count();
			for( uint i = 0; i < imagesCount; i++ )
			{
				var header = NativeMethods._dyld_get_image_header( i );
				var imageSlide = NativeMethods._dyld_get_image_vmaddr_slide( i );

				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine( "Image: {0}, Slide: {1}", NativeMethods._dyld_get_image_name( i ), imageSlide );
				Platform.DumpInformation( header, imageSlide );
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public struct time_value
		{
			/// <summary>
			/// 
			/// </summary>
			public int seconds;

			/// <summary>
			/// 
			/// </summary>
			public int microseconds;
		}

		/// <summary>
		/// 
		/// </summary>
		public struct task_basic_info
		{
			/// <summary>
			/// 
			/// </summary>
			public int suspend_count;

			/// <summary>
			/// 
			/// </summary>
			public IntPtr virtual_size;

			/// <summary>
			/// 
			/// </summary>
			public IntPtr resident_size;

			/// <summary>
			/// 
			/// </summary>
			public time_value user_time;

			/// <summary>
			/// 
			/// </summary>
			public time_value system_time;

			/// <summary>
			/// 
			/// </summary>
			public int policy;

			/// <summary>
			/// 
			/// </summary>
			/// <returns></returns>
			public override string ToString()
			{
				return string.Format( "{{ resident_size={0}, virtual_size={1} }}", resident_size, virtual_size );
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public enum task_flavor_t
		{
			/// <summary>
			/// 
			/// </summary>
			TASK_BASIC_INFO_32 = 4,

			/// <summary>
			/// 
			/// </summary>
			TASK_BASIC2_INFO_32 = 6
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public static task_basic_info GetTaskBasicInfo()
		{
			var result = new task_basic_info();
			int structureLength = sizeof( task_basic_info ) / IntPtr.Size;

			NativeMethods.task_info( NativeMethods.mach_task_self(), task_flavor_t.TASK_BASIC_INFO_32, new IntPtr( &result ), ref structureLength );

			return result;
		}

		/// <summary>
		/// 
		/// </summary>
		public enum MemoryProtection
		{
			/// <summary>
			/// 
			/// </summary>
			PROT_READ = 0x01,

			/// <summary>
			/// 
			/// </summary>
			PROT_WRITE = 0x02,

			/// <summary>
			/// 
			/// </summary>
			PROT_EXEC = 0x04
		}

		/// <summary>
		/// 
		/// </summary>
		public enum MmapFlags
		{
			/// <summary>
			/// 
			/// </summary>
			MAP_PRIVATE = 0x0002,

			/// <summary>
			/// 
			/// </summary>
			MAP_ANON = 0x1000
		}

		/// <summary>
		/// 
		/// </summary>
		public enum kern_return_t
		{
			/// <summary>All is OK.</summary>
			KERN_SUCCESS = 0,

			/// <summary>Specified address is not currently valid.</summary>
			KERN_INVALID_ADDRESS = 1,

			/// <summary>Specified memory is valid, but does not permit the required forms of access.</summary>
			KERN_PROTECTION_FAILURE = 2,

			/// <summary>The address range specified is already in use, or no address range of the size specified could be found.</summary>
			KERN_NO_SPACE = 3,

			/// <summary>The function requested was not applicable to this type of argument, or an argument is invalid.</summary>
			KERN_INVALID_ARGUMENT = 4,

			/// <summary>The function could not be performed. A catch-all.</summary>
			KERN_FAILURE = 5,

			/// <summary>A system resource could not be allocated to fulfill this request. This failure may not be permanent.</summary>
			KERN_RESOURCE_SHORTAGE = 6,

			/// <summary>The task in question does not hold receive rights for the port argument.</summary>
			KERN_NOT_RECEIVER = 7,

			/// <summary>Bogus access restriction.</summary>
			KERN_NO_ACCESS = 8,

			/// <summary>During a page fault, the target address refers to a memory object that has been destroyed. This failure is permanent.</summary>
			KERN_MEMORY_FAILURE = 9,

			/// <summary>During a page fault, the memory object indicated that the data could not be returned. This failure may be temporary; future attempts to access this same data may succeed, as defined by the memory object.</summary>
			KERN_MEMORY_ERROR = 10,

			/// <summary>The receive right is already a member of the portset.</summary>
			KERN_ALREADY_IN_SET = 11,

			/// <summary>The receive right is not a member of a port set.</summary>
			KERN_NOT_IN_SET = 12,

			/// <summary>The name already denotes a right in the task.</summary>
			KERN_NAME_EXISTS = 13,

			/// <summary>The operation was aborted. Ipc code will catch this and reflect it as a message error.</summary>
			KERN_ABORTED = 14,

			/// <summary>The name doesn't denote a right in the task.</summary>
			KERN_INVALID_NAME = 15,

			/// <summary>Target task isn't an active task.</summary>
			KERN_INVALID_TASK = 16,

			/// <summary>The name denotes a right, but not an appropriate right.</summary>
			KERN_INVALID_RIGHT = 17,

			/// <summary>A blatant range error.</summary>
			KERN_INVALID_VALUE = 18,

			/// <summary>Operation would overflow limit on user-references.</summary>
			KERN_UREFS_OVERFLOW = 19,

			/// <summary>The supplied (port) capability is improper.</summary>
			KERN_INVALID_CAPABILITY = 20,

			/// <summary>The task already has send or receive rights for the port under another name.</summary>
			KERN_RIGHT_EXISTS = 21,

			/// <summary>Target host isn't actually a host.</summary>
			KERN_INVALID_HOST = 22,

			/// <summary>An attempt was made to supply "precious" data for memory that is already present in a memory object.</summary>
			KERN_MEMORY_PRESENT = 23,

			/// <summary>
			/// A page was requested of a memory manager via memory_object_data_request for an object using a MEMORY_OBJECT_COPY_CALL strategy, with the VM_PROT_WANTS_COPY flag being used to specify that the page desired is for a copy of the object, and the memory manager has detected the page was pushed into a copy of the object while the kernel was walking the shadow chain from the copy to the object.
			/// This error code is delivered via memory_object_data_error and is handled by the kernel (it forces the kernel to restart the fault). It will not be seen by users.
			/// </summary>
			KERN_MEMORY_DATA_MOVED = 24,

			/// <summary>
			/// A strategic copy was attempted of an object upon which a quicker copy is now possible.
			/// The caller should retry the copy using vm_object_copy_quickly.
			/// This error code is seen only by the kernel.
			/// </summary>
			KERN_MEMORY_RESTART_COPY = 25,

			/// <summary>An argument applied to assert processor set privilege was not a processor set control port.</summary>
			KERN_INVALID_PROCESSOR_SET = 26,

			/// <summary>The specified scheduling attributes exceed the thread's limits.</summary>
			KERN_POLICY_LIMIT = 27,

			/// <summary>The specified scheduling policy is not currently enabled for the processor set.</summary>
			KERN_INVALID_POLICY = 28,

			/// <summary>The external memory manager failed to initialize the memory object.</summary>
			KERN_INVALID_OBJECT = 29,

			/// <summary>A thread is attempting to wait for an event for which there is already a waiting thread.</summary>
			KERN_ALREADY_WAITING = 30,

			/// <summary>An attempt was made to destroy the default processor set.</summary>
			KERN_DEFAULT_SET = 31,

			/// <summary>An attempt was made to fetch an exception port that is protected, or to abort a thread while processing a protected exception.</summary>
			KERN_EXCEPTION_PROTECTED = 32,

			/// <summary>A ledger was required but not supplied.</summary>
			KERN_INVALID_LEDGER = 33,

			/// <summary>The port was not a memory cache control port.</summary>
			KERN_INVALID_MEMORY_CONTROL = 34,

			/// <summary>An argument supplied to assert security privilege was not a host security port.</summary>
			KERN_INVALID_SECURITY = 35,

			/// <summary>thread_depress_abort was called on a thread which was not currently depressed.</summary>
			KERN_NOT_DEPRESSED = 36,

			/// <summary>Object has been terminated and is no longer available.</summary>
			KERN_TERMINATED = 37,

			/// <summary>Lock set has been destroyed and is no longer available.</summary>
			KERN_LOCK_SET_DESTROYED = 38,

			/// <summary>The thread holding the lock terminated before releasing the lock.</summary>
			KERN_LOCK_UNSTABLE = 39,

			/// <summary>The lock is already owned by another thread.</summary>
			KERN_LOCK_OWNED = 40,

			/// <summary>The lock is already owned by the calling thread.</summary>
			KERN_LOCK_OWNED_SELF = 41,

			/// <summary>Semaphore has been destroyed and is no longer available.</summary>
			KERN_SEMAPHORE_DESTROYED = 42,

			/// <summary>Return from RPC indicating the target server was terminated before it successfully replied.</summary>
			KERN_RPC_SERVER_TERMINATED = 43,

			/// <summary>Terminate an orphaned activation.</summary>
			KERN_RPC_TERMINATE_ORPHAN = 44,

			/// <summary>Allow an orphaned activation to continue executing.</summary>
			KERN_RPC_CONTINUE_ORPHAN = 45,

			/// <summary>Empty thread activation (No thread linked to it)</summary>
			KERN_NOT_SUPPORTED = 46,

			/// <summary>Remote node down or inaccessible.</summary>
			KERN_NODE_DOWN = 47,

			/// <summary>A signalled thread was not actually waiting.</summary>
			KERN_NOT_WAITING = 48,

			/// <summary>Some thread-oriented operation (semaphore_wait) timed out</summary>
			KERN_OPERATION_TIMED_OUT = 49,

			/// <summary>Maximum return value allowable.</summary>
			KERN_RETURN_MAX = 0x100
		}

		/// <summary>
		/// Machine-independent exception behaviors.
		/// </summary>
		public enum exception_behavior_t : uint
		{
			/// <summary> Send a catch_exception_raise message including the identity. </summary>
			EXCEPTION_DEFAULT = 1,

			/// <summary>Send a catch_exception_raise_state message including the thread state.  </summary>
			EXCEPTION_STATE = 2,

			/// <summary> Send a catch_exception_raise_state_identity message including the thread identity and state. </summary>
			EXCEPTION_STATE_IDENTITY = 3,

			/// <summary>Send 64-bit code and subcode in the exception header</summary>
			MACH_EXCEPTION_CODES = 0x80000000
		}

		/// <summary>
		/// Machine-independent exception definitions.
		/// </summary>
		public enum exception_type_t
		{
			/// <summary>Could not access memory. Code contains kern_return_t describing error. Subcode contains bad memory address.</summary>
			EXC_BAD_ACCESS = 1,

			/// <summary>Instruction failed. Illegal or undefined instruction or operand. </summary>
			EXC_BAD_INSTRUCTION = 2,

			/// <summary>Arithmetic exception. Exact nature of exception is in code field. </summary>
			EXC_ARITHMETIC = 3,

			/// <summary>Emulation instruction. Emulation support instruction encountered. Details in code and subcode fields.</summary>
			EXC_EMULATION = 4,

			/// <summary>Software generated exception.
			/// Exact exception is in code field. 
			/// Codes 0 - 0xFFFF reserved to hardware. Codes 0x10000 - 0x1FFFF reserved for OS emulation (Unix).
			/// </summary>
			EXC_SOFTWARE = 5,

			/// <summary>Trace, breakpoint, etc. Details in code field. Details in code field.</summary>
			EXC_BREAKPOINT = 6,

			/// <summary>System calls. </summary>
			EXC_SYSCALL = 7,

			/// <summary>Mach system calls.</summary>
			EXC_MACH_SYSCALL = 8,

			/// <summary> RPC alert. </summary>
			EXC_RPC_ALERT = 9,

			/// <summary> Abnormal process exit </summary>
			EXC_CRASH = 10,
		}

		/// <summary>
		/// Masks for exception definitions.
		/// </summary>
		public enum exception_mask_t
		{
			/// <summary></summary>
			EXC_MASK_MACHINE = 0,

			/// <summary></summary>
			EXC_MASK_BAD_ACCESS = 1 << exception_type_t.EXC_BAD_ACCESS,

			/// <summary></summary>
			EXC_MASK_BAD_INSTRUCTION = 1 << exception_type_t.EXC_BAD_INSTRUCTION,

			/// <summary></summary>
			EXC_MASK_ARITHMETIC = 1 << exception_type_t.EXC_ARITHMETIC,

			/// <summary></summary>
			EXC_MASK_EMULATION = 1 << exception_type_t.EXC_EMULATION,

			/// <summary></summary>
			EXC_MASK_SOFTWARE = 1 << exception_type_t.EXC_SOFTWARE,

			/// <summary></summary>
			EXC_MASK_BREAKPOINT = 1 << exception_type_t.EXC_BREAKPOINT,

			/// <summary></summary>
			EXC_MASK_SYSCALL = 1 << exception_type_t.EXC_SYSCALL,

			/// <summary></summary>
			EXC_MASK_MACH_SYSCALL = 1 << exception_type_t.EXC_MACH_SYSCALL,

			/// <summary></summary>
			EXC_MASK_RPC_ALERT = 1 << exception_type_t.EXC_RPC_ALERT,

			/// <summary></summary>
			EXC_MASK_CRASH = 1 << exception_type_t.EXC_CRASH,

			/// <summary></summary>
			EXC_MASK_ALL = EXC_MASK_BAD_ACCESS | EXC_MASK_BAD_INSTRUCTION | EXC_MASK_ARITHMETIC | EXC_MASK_EMULATION | EXC_MASK_SOFTWARE | EXC_MASK_BREAKPOINT | EXC_MASK_SYSCALL | EXC_MASK_MACH_SYSCALL | EXC_MASK_RPC_ALERT | EXC_MASK_CRASH | EXC_MASK_MACHINE
		}

		/// <summary></summary>
		public struct mach_msg_header_t
		{
			/// <summary>This field specifies the properties of the message.</summary>
			public mach_msg_bits_t msgh_bits;

			/// <summary>
			/// This field is ignored on send (the size to send is specified by the send_size parameter to mach_msg); 
			/// the field is set on receive to the sum of the message header and body sizes (in bytes).
			/// Note that this value may be different from the send size specified by the sender if the sender and receiver machines have differing sizes for port names, memory addresses or memory range sizes.
			/// </summary>
			public uint msgh_size;

			/// <summary>
			/// When sending, specifies the destination port of the message.
			/// The field must carry a legitimate send or send-once right for a port. 
			/// When received, this field is swapped with msgh_local_port.
			/// </summary>
			public IntPtr msgh_remote_port;

			/// <summary>
			/// When sending, specifies an auxiliary port right, which is conventionally used as a reply port by the recipient of the message.
			/// The field must carry a send right, a send-once right, MACH_PORT_NULL, or MACH_PORT_DEAD.
			/// When received, this field is swapped with msgh_remote_port.
			/// </summary>
			public IntPtr msgh_local_port;

			/// <summary>Reserved.</summary>
			public uint msgh_reserved;

			/// <summary>
			/// Not set or read by the mach_msg call.
			/// The conventional meaning is to convey an operation or function ID.
			/// The msgh_id field is uninterpreted by the message primitives.
			/// It normally carries information specifying the format or meaning of the message.
			/// </summary>
			public mach_msg_id_t msgh_id;

			/// <summary></summary>
			public fixed byte Data[488];

			/// <summary></summary>
			public override string ToString()
			{
				return string.Format( "{{ msgh_bits={0}, msgh_size={1}, msgh_remote_port={2}, msgh_local_port={3}, msgh_reserved={4}, msgh_id={5} }}", ( ( uint ) msgh_bits ).ToString( "X8" ), msgh_size, msgh_remote_port, msgh_local_port, msgh_reserved, msgh_id );
			}

			public void PrintData()
			{
				fixed( byte* data = Data )
				{
					var dataWords = ( int* ) data;

					for( int i = 0; i < msgh_size; i += 4 )
					{
						if( i > 0 && ( i & 31 ) == 0 )
							Console.WriteLine();

						Console.Write( "{0} ", ( *dataWords++ ).ToString( "X8" ) );
					}

					if( ( msgh_size & 31 ) != 0 )
						Console.WriteLine();
				}
			}
		}

		/// <summary></summary>
		[Flags]
		public enum mach_msg_id_t
		{
			/// <summary></summary>
			MACH_NOTIFY_FIRST = 0100,

			/// <summary>A send or send-once right was deleted.</summary>
			MACH_NOTIFY_PORT_DELETED = ( MACH_NOTIFY_FIRST + 001 ),

			/// <summary>A receive right was (would have been) deallocated.</summary>
			MACH_NOTIFY_PORT_DESTROYED = ( MACH_NOTIFY_FIRST + 005 ),

			/// <summary>Receive right has no extant send rights.</summary>
			MACH_NOTIFY_NO_SENDERS = ( MACH_NOTIFY_FIRST + 006 ),

			/// <summary>An extant send-once right died.</summary>
			MACH_NOTIFY_SEND_ONCE = ( MACH_NOTIFY_FIRST + 007 ),

			/// <summary>Send or send-once right died, leaving a dead-name.</summary>
			MACH_NOTIFY_DEAD_NAME = ( MACH_NOTIFY_FIRST + 010 ),

			/// <summary></summary>
			MACH_NOTIFY_LAST = ( MACH_NOTIFY_FIRST + 015 )
		}

		/// <summary></summary>
		public enum mach_port_right_t
		{
			/// <summary></summary>
			MACH_PORT_RIGHT_SEND = 0,

			/// <summary></summary>
			MACH_PORT_RIGHT_RECEIVE = 1,

			/// <summary></summary>
			MACH_PORT_RIGHT_SEND_ONCE = 2,

			/// <summary></summary>
			MACH_PORT_RIGHT_PORT_SET = 3,

			/// <summary></summary>
			MACH_PORT_RIGHT_DEAD_NAME = 4,

			/// <summary></summary>
			MACH_PORT_RIGHT_LABELH = 5,

			/// <summary></summary>
			MACH_PORT_RIGHT_NUMBER = 6,
		}

		/// <summary></summary>
		public enum mach_port_type_t
		{
			/// <summary></summary>
			MACH_PORT_TYPE_NONE = 0,

			/// <summary></summary>
			MACH_PORT_TYPE_SEND = 1 << mach_port_right_t.MACH_PORT_RIGHT_SEND + 16,

			/// <summary></summary>
			MACH_PORT_TYPE_RECEIVE = 1 << mach_port_right_t.MACH_PORT_RIGHT_RECEIVE + 16,

			/// <summary></summary>
			MACH_PORT_TYPE_SEND_ONCE = 1 << mach_port_right_t.MACH_PORT_RIGHT_SEND_ONCE + 16,

			/// <summary></summary>
			MACH_PORT_TYPE_PORT_SET = 1 << mach_port_right_t.MACH_PORT_RIGHT_PORT_SET + 16,

			/// <summary></summary>
			MACH_PORT_TYPE_DEAD_NAME = 1 << mach_port_right_t.MACH_PORT_RIGHT_DEAD_NAME + 16,

			/// <summary></summary>
			MACH_PORT_TYPE_LABELH = 1 << mach_port_right_t.MACH_PORT_RIGHT_LABELH + 16

		}

		/// <summary>
		/// Structure used to pass information about port allocation requests. Must be padded to 64-bits total length.
		/// </summary>
		public struct mach_port_qos_t
		{
			//public int		name:1;		/* name given */
			//public int 		prealloc:1;	/* prealloced message */
			//public	int	pad1:30;
			/// <summary></summary>
			public int filler;

			/// <summary></summary>
			public int len;
		}

		/// <summary>
		///  Much code assumes that mach_msg_return_t == kern_return_t. This definition is useful for descriptive purposes.
		///  See mach/error.h for the format of error codes. IPC errors are system 4.  Send errors are subsystem 0; receive errors are subsystem 1.
		///  The code field is always non-zero. The high bits of the code field communicate extra information for some error codes.
		///  MACH_MSG_MASK masks off these special bits.
		/// </summary>
		public enum mach_msg_return_t
		{
			/// <summary>All is OK.</summary>
			MACH_MSG_SUCCESS = 0x00000000,

			#region kern_return_t

			/// <summary>All is OK.</summary>
			KERN_SUCCESS = 0,

			/// <summary>Specified address is not currently valid.</summary>
			KERN_INVALID_ADDRESS = 1,

			/// <summary>Specified memory is valid, but does not permit the required forms of access.</summary>
			KERN_PROTECTION_FAILURE = 2,

			/// <summary>The address range specified is already in use, or no address range of the size specified could be found.</summary>
			KERN_NO_SPACE = 3,

			/// <summary>The function requested was not applicable to this type of argument, or an argument is invalid.</summary>
			KERN_INVALID_ARGUMENT = 4,

			/// <summary>The function could not be performed. A catch-all.</summary>
			KERN_FAILURE = 5,

			/// <summary>A system resource could not be allocated to fulfill this request. This failure may not be permanent.</summary>
			KERN_RESOURCE_SHORTAGE = 6,

			/// <summary>The task in question does not hold receive rights for the port argument.</summary>
			KERN_NOT_RECEIVER = 7,

			/// <summary>Bogus access restriction.</summary>
			KERN_NO_ACCESS = 8,

			/// <summary>During a page fault, the target address refers to a memory object that has been destroyed. This failure is permanent.</summary>
			KERN_MEMORY_FAILURE = 9,

			/// <summary>During a page fault, the memory object indicated that the data could not be returned. This failure may be temporary; future attempts to access this same data may succeed, as defined by the memory object.</summary>
			KERN_MEMORY_ERROR = 10,

			/// <summary>The receive right is already a member of the portset.</summary>
			KERN_ALREADY_IN_SET = 11,

			/// <summary>The receive right is not a member of a port set.</summary>
			KERN_NOT_IN_SET = 12,

			/// <summary>The name already denotes a right in the task.</summary>
			KERN_NAME_EXISTS = 13,

			/// <summary>The operation was aborted. Ipc code will catch this and reflect it as a message error.</summary>
			KERN_ABORTED = 14,

			/// <summary>The name doesn't denote a right in the task.</summary>
			KERN_INVALID_NAME = 15,

			/// <summary>Target task isn't an active task.</summary>
			KERN_INVALID_TASK = 16,

			/// <summary>The name denotes a right, but not an appropriate right.</summary>
			KERN_INVALID_RIGHT = 17,

			/// <summary>A blatant range error.</summary>
			KERN_INVALID_VALUE = 18,

			/// <summary>Operation would overflow limit on user-references.</summary>
			KERN_UREFS_OVERFLOW = 19,

			/// <summary>The supplied (port) capability is improper.</summary>
			KERN_INVALID_CAPABILITY = 20,

			/// <summary>The task already has send or receive rights for the port under another name.</summary>
			KERN_RIGHT_EXISTS = 21,

			/// <summary>Target host isn't actually a host.</summary>
			KERN_INVALID_HOST = 22,

			/// <summary>An attempt was made to supply "precious" data for memory that is already present in a memory object.</summary>
			KERN_MEMORY_PRESENT = 23,

			/// <summary>
			/// A page was requested of a memory manager via memory_object_data_request for an object using a MEMORY_OBJECT_COPY_CALL strategy, with the VM_PROT_WANTS_COPY flag being used to specify that the page desired is for a copy of the object, and the memory manager has detected the page was pushed into a copy of the object while the kernel was walking the shadow chain from the copy to the object.
			/// This error code is delivered via memory_object_data_error and is handled by the kernel (it forces the kernel to restart the fault). It will not be seen by users.
			/// </summary>
			KERN_MEMORY_DATA_MOVED = 24,

			/// <summary>
			/// A strategic copy was attempted of an object upon which a quicker copy is now possible.
			/// The caller should retry the copy using vm_object_copy_quickly.
			/// This error code is seen only by the kernel.
			/// </summary>
			KERN_MEMORY_RESTART_COPY = 25,

			/// <summary>An argument applied to assert processor set privilege was not a processor set control port.</summary>
			KERN_INVALID_PROCESSOR_SET = 26,

			/// <summary>The specified scheduling attributes exceed the thread's limits.</summary>
			KERN_POLICY_LIMIT = 27,

			/// <summary>The specified scheduling policy is not currently enabled for the processor set.</summary>
			KERN_INVALID_POLICY = 28,

			/// <summary>The external memory manager failed to initialize the memory object.</summary>
			KERN_INVALID_OBJECT = 29,

			/// <summary>A thread is attempting to wait for an event for which there is already a waiting thread.</summary>
			KERN_ALREADY_WAITING = 30,

			/// <summary>An attempt was made to destroy the default processor set.</summary>
			KERN_DEFAULT_SET = 31,

			/// <summary>An attempt was made to fetch an exception port that is protected, or to abort a thread while processing a protected exception.</summary>
			KERN_EXCEPTION_PROTECTED = 32,

			/// <summary>A ledger was required but not supplied.</summary>
			KERN_INVALID_LEDGER = 33,

			/// <summary>The port was not a memory cache control port.</summary>
			KERN_INVALID_MEMORY_CONTROL = 34,

			/// <summary>An argument supplied to assert security privilege was not a host security port.</summary>
			KERN_INVALID_SECURITY = 35,

			/// <summary>thread_depress_abort was called on a thread which was not currently depressed.</summary>
			KERN_NOT_DEPRESSED = 36,

			/// <summary>Object has been terminated and is no longer available.</summary>
			KERN_TERMINATED = 37,

			/// <summary>Lock set has been destroyed and is no longer available.</summary>
			KERN_LOCK_SET_DESTROYED = 38,

			/// <summary>The thread holding the lock terminated before releasing the lock.</summary>
			KERN_LOCK_UNSTABLE = 39,

			/// <summary>The lock is already owned by another thread.</summary>
			KERN_LOCK_OWNED = 40,

			/// <summary>The lock is already owned by the calling thread.</summary>
			KERN_LOCK_OWNED_SELF = 41,

			/// <summary>Semaphore has been destroyed and is no longer available.</summary>
			KERN_SEMAPHORE_DESTROYED = 42,

			/// <summary>Return from RPC indicating the target server was terminated before it successfully replied.</summary>
			KERN_RPC_SERVER_TERMINATED = 43,

			/// <summary>Terminate an orphaned activation.</summary>
			KERN_RPC_TERMINATE_ORPHAN = 44,

			/// <summary>Allow an orphaned activation to continue executing.</summary>
			KERN_RPC_CONTINUE_ORPHAN = 45,

			/// <summary>Empty thread activation (No thread linked to it)</summary>
			KERN_NOT_SUPPORTED = 46,

			/// <summary>Remote node down or inaccessible.</summary>
			KERN_NODE_DOWN = 47,

			/// <summary>A signalled thread was not actually waiting.</summary>
			KERN_NOT_WAITING = 48,

			/// <summary>Some thread-oriented operation (semaphore_wait) timed out</summary>
			KERN_OPERATION_TIMED_OUT = 49,

			#endregion

			/// <summary>All special error code bits defined below.</summary>
			MACH_MSG_MASK = 0x00003e00,

			/// <summary>No room in IPC name space for another capability name.</summary>
			MACH_MSG_IPC_SPACE = 0x00002000,

			/// <summary>No room in VM address space for out-of-line memory.</summary>
			MACH_MSG_VM_SPACE = 0x00001000,

			/// <summary>Kernel resource shortage handling an IPC capability.</summary>
			MACH_MSG_IPC_KERNEL = 0x00000800,

			/// <summary>Kernel resource shortage handling out-of-line memory.</summary>
			MACH_MSG_VM_KERNEL = 0x00000400,

			/// <summary>Thread is waiting to send.  (Internal use only.)</summary>
			MACH_SEND_IN_PROGRESS = 0x10000001,

			/// <summary>Bogus in-line data.</summary>
			MACH_SEND_INVALID_DATA = 0x10000002,

			/// <summary>Bogus destination port.</summary>
			MACH_SEND_INVALID_DEST = 0x10000003,

			/// <summary>Message not sent before timeout expired.</summary>
			MACH_SEND_TIMED_OUT = 0x10000004,

			/// <summary>Software interrupt.</summary>
			MACH_SEND_INTERRUPTED = 0x10000007,

			/// <summary>Data doesn't contain a complete message.</summary>
			MACH_SEND_MSG_TOO_SMALL = 0x10000008,

			/// <summary>Bogus reply port.</summary>/
			MACH_SEND_INVALID_REPLY = 0x10000009,

			/// <summary>Bogus port rights in the message body.</summary>
			MACH_SEND_INVALID_RIGHT = 0x1000000a,

			/// <summary>Bogus notify port argument.</summary>
			MACH_SEND_INVALID_NOTIFY = 0x1000000b,

			/// <summary>Invalid out-of-line memory pointer.</summary>
			MACH_SEND_INVALID_MEMORY = 0x1000000c,

			/// <summary>No message buffer is available.</summary>
			MACH_SEND_NO_BUFFER = 0x1000000d,

			/// <summary>Send is too large for port</summary>
			MACH_SEND_TOO_LARGE = 0x1000000e,

			/// <summary>Invalid msg-type specification.</summary>
			MACH_SEND_INVALID_TYPE = 0x1000000f,

			/// <summary>A field in the header had a bad value.</summary>
			MACH_SEND_INVALID_HEADER = 0x10000010,

			/// <summary>The trailer to be sent does not match kernel format.</summary>
			MACH_SEND_INVALID_TRAILER = 0x10000011,

			/// <summary>compatibility: no longer a returned error</summary>
			MACH_SEND_INVALID_RT_OOL_SIZE = 0x10000015,

			/// <summary>Thread is waiting for receive.  (Internal use only.)</summary>
			MACH_RCV_IN_PROGRESS = 0x10004001,

			/// <summary>Bogus name for receive port/port-set.</summary>
			MACH_RCV_INVALID_NAME = 0x10004002,

			/// <summary>Didn't get a message within the timeout value.</summary>
			MACH_RCV_TIMED_OUT = 0x10004003,

			/// <summary>Message buffer is not large enough for inline data.</summary>
			MACH_RCV_TOO_LARGE = 0x10004004,

			/// <summary>Software interrupt.</summary>
			MACH_RCV_INTERRUPTED = 0x10004005,

			/// <summary>compatibility: no longer a returned error</summary>
			MACH_RCV_PORT_CHANGED = 0x10004006,

			/// <summary>Bogus notify port argument.</summary>
			MACH_RCV_INVALID_NOTIFY = 0x10004007,

			/// <summary>Bogus message buffer for inline data.</summary>
			MACH_RCV_INVALID_DATA = 0x10004008,

			/// <summary>Port/set was sent away/died during receive.</summary>
			MACH_RCV_PORT_DIED = 0x10004009,

			/// <summary>compatibility: no longer a returned error</summary>
			MACH_RCV_IN_SET = 0x1000400a,

			/// <summary>Error receiving message header.  See special bits.</summary>
			MACH_RCV_HEADER_ERROR = 0x1000400b,

			/// <summary>Error receiving message body.  See special bits.</summary>
			MACH_RCV_BODY_ERROR = 0x1000400c,

			/// <summary>Invalid msg-type specification in scatter list.</summary>
			MACH_RCV_INVALID_TYPE = 0x1000400d,

			/// <summary>Out-of-line overwrite region is not large enough</summary>
			MACH_RCV_SCATTER_SMALL = 0x1000400e,

			/// <summary>trailer type or number of trailer elements not supported</summary>
			MACH_RCV_INVALID_TRAILER = 0x1000400f,

			/// <summary>Waiting for receive with timeout. (Internal use only.)</summary>
			MACH_RCV_IN_PROGRESS_TIMED = 0x10004011,
		}

		/// <summary></summary>
		public enum mach_msg_type_name_t
		{
			/// <summary>Must hold receive rights</summary>
			MACH_MSG_TYPE_MOVE_RECEIVE = 16,

			/// <summary>Must hold send rights</summary>
			MACH_MSG_TYPE_MOVE_SEND = 17,

			/// <summary>Must hold sendonce rights</summary>
			MACH_MSG_TYPE_MOVE_SEND_ONCE = 18,

			/// <summary>Must hold send rights</summary>
			MACH_MSG_TYPE_COPY_SEND = 19,

			/// <summary>Must hold receive rights</summary>
			MACH_MSG_TYPE_MAKE_SEND = 20,

			/// <summary>Must hold receive rights</summary>
			MACH_MSG_TYPE_MAKE_SEND_ONCE = 21,

			/// <summary>Must hold receive rights</summary>
			MACH_MSG_TYPE_COPY_RECEIVE = 22,
		}

		/// <summary></summary>
		public enum mach_msg_copy_options_t
		{
			/// <summary></summary>
			MACH_MSG_PHYSICAL_COPY = 0,

			/// <summary></summary>
			MACH_MSG_VIRTUAL_COPY = 1,

			/// <summary></summary>
			MACH_MSG_ALLOCATE = 2,

			/// <summary></summary>
			MACH_MSG_OVERWRITE = 3,

			/// <summary></summary>
			MACH_MSG_KALLOC_COPY_T = 4,
		}

		/// <summary></summary>
		public enum mach_msg_descriptor_type_t
		{
			/// <summary></summary>
			MACH_MSG_PORT_DESCRIPTOR = 0,

			/// <summary></summary>
			MACH_MSG_OOL_DESCRIPTOR = 1,

			/// <summary></summary>
			MACH_MSG_OOL_PORTS_DESCRIPTOR = 2,

			/// <summary></summary>
			MACH_MSG_OOL_VOLATILE_DESCRIPTOR = 3,
		}

		/// <summary></summary>
		public enum thread_state_flavor_t
		{
			/// <summary></summary>
			x86_THREAD_STATE32 = 1,

			/// <summary></summary>
			x86_FLOAT_STATE32 = 2,

			/// <summary></summary>
			x86_EXCEPTION_STATE32 = 3,

			/// <summary></summary>
			x86_THREAD_STATE64 = 4,

			/// <summary></summary>
			x86_FLOAT_STATE64 = 5,

			/// <summary></summary>
			x86_EXCEPTION_STATE64 = 6,

			/// <summary></summary>
			x86_THREAD_STATE = 7,

			/// <summary></summary>
			x86_FLOAT_STATE = 8,

			/// <summary></summary>
			x86_EXCEPTION_STATE = 9,

			/// <summary></summary>
			x86_DEBUG_STATE32 = 10,

			/// <summary></summary>
			x86_DEBUG_STATE64 = 11,

			/// <summary></summary>
			x86_DEBUG_STATE = 12,

			/// <summary></summary>
			x86_THREAD_STATE_NONE = 13,

			/// <summary></summary>
			PPC_THREAD_STATE = 1,

			/// <summary></summary>
			PPC_FLOAT_STATE = 2,

			/// <summary></summary>
			PPC_EXCEPTION_STATE = 3,

			/// <summary></summary>
			PPC_VECTOR_STATE = 4,

			/// <summary></summary>
			PPC_THREAD_STATE64 = 5,

			/// <summary></summary>
			PPC_EXCEPTION_STATE64 = 6,

			/// <summary></summary>
			PPC_THREAD_STATE_NONE = 7,
		}

		/// <summary></summary>
		[Flags]
		public enum mach_msg_option_t
		{
			/// <summary></summary>
			MACH_MSG_OPTION_NONE = 0x00000000,

			/// <summary></summary>
			MACH_SEND_MSG = 0x00000001,

			/// <summary></summary>
			MACH_RCV_MSG = 0x00000002,

			/// <summary>
			/// If the message is larger than receive_limit or an out-of-line region is larger than the size allowed by a corresponding receive descriptor (MACH_RCV_OVERWRITE), the message remains queued instead of being destroyed. 
			/// If the header, trailer and body would not fit into receive_limit, only the message header (mach_msg_header) and trailer header (mach_msg_trailer) are returned with the actual size of the message returned in the msgh_size field, the actual size of the trailer returned in the msgh_trailer_size field and an error return value of MACH_RCV_TOO_LARGE.
			/// If receive_limit is sufficient but an out-of-line descriptor is not, the message header, trailer and body are received, with out-of-line descriptors set to indicate the nature and size of the out-of-line regions, with an error return of MACH_RCV_SCATTER_SMALL. No out-of-line regions or port rights (including the reply right) will be received.
			/// If this option is not specified, messages too large will be de-queued and then destroyed; the caller receives the message header, with all fields correct, including the destination port but excepting the reply port, which is MACH_PORT_NULL and an empty (no additional element) message trailer.
			/// </summary>
			MACH_RCV_LARGE = 0x00000004,

			/// <summary></summary>
			MACH_SEND_TIMEOUT = 0x00000010,

			/// <summary>libmach implements</summary>
			MACH_SEND_INTERRUPT = 0x00000040,

			/// <summary></summary>
			MACH_SEND_CANCEL = 0x00000080,

			/// <summary>internal use only</summary>
			MACH_SEND_ALWAYS = 0x00010000,

			/// <summary></summary>
			MACH_SEND_TRAILER = 0x00020000,

			/// <summary>
			/// The timeout argument should specify a maximum time (in milliseconds) for the call to block before giving up. 
			/// If no message arrives before the timeout interval elapses, then the call returns MACH_RCV_TIMED_OUT.
			/// A zero timeout is legitimate.</summary>
			MACH_RCV_TIMEOUT = 0x00000100,

			/// <summary>
			/// The notify argument should specify a receive right for a notify port.
			/// If receiving the reply port creates a new port right in the caller, then the notify port is used to request a dead-name notification for the new port right.
			/// </summary>
			MACH_RCV_NOTIFY = 0x00000200,

			/// <summary>
			/// If specified, the mach_msg call will return MACH_RCV_INTERRUPTED if a software interrupt aborts the call.
			/// Otherwise, the receive operation will be retried.
			/// </summary>
			MACH_RCV_INTERRUPT = 0x00000400,

			/// <summary>
			/// If specified, the message buffer specified by receive_msg (or msg), of length receive_msg_size,
			/// will be scanned for out-of-line descriptors to specify the processing to be done when receiving out-of-line regions. 
			/// This option is only allowed for mach_msg_overwrite.
			/// </summary>
			MACH_RCV_OVERWRITE = 0x00001000,
		}

		[Flags]
		public enum mach_msg_bits_t : uint
		{
			/// <summary></summary>
			MACH_MSGH_BITS_ZERO = 0x00000000,

			/// <summary>Encodes mach_msg_type_name_t values that specify the port rights in the msgh_remote_port field. The value must specify a send or send-once right for the destination of the message.</summary>
			MACH_MSGH_BITS_REMOTE_MASK = 0x000000ff,

			/// <summary>Encodes mach_msg_type_name_t values that specify the port rights in the msgh_local_port field. If the value doesn't specify a send or send-once right for the message's reply port, it must be zero and msgh_local_port must be MACH_PORT_NULL.</summary>
			MACH_MSGH_BITS_LOCAL_MASK = 0x0000ff00,

			/// <summary>The complex bit must be specified if the message body contains additional port rights or out-of-line memory regions.</summary>
			MACH_MSGH_BITS_COMPLEX = 0x80000000,

			/// <summary></summary>
			MACH_MSGH_BITS_USER = 0x8000ffff,

			/// <summary>internal use only</summary>
			MACH_MSGH_BITS_CIRCULAR = 0x40000000,

			/// <summary></summary>
			MACH_MSGH_BITS_USED = 0xc000ffff
		}

#pragma warning restore 649

		/// <summary>
		/// Dyld operations ain't thread-safe so I add excplicit sync.
		/// </summary>
		public static class NativeMethods
		{
			/// <summary>
			/// 
			/// </summary>
			/// <param name="mach_task_t"></param>
			/// <param name="pid"></param>
			/// <param name="task"></param>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			public static extern kern_return_t task_for_pid( IntPtr target_tport, uint pid, out IntPtr task );

			/// <summary>
			/// 
			/// </summary>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			public static extern IntPtr mach_task_self();

			/// <summary>
			/// 
			/// </summary>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			public static extern IntPtr mach_thread_self();

			/// <summary>
			/// 
			/// </summary>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			public static extern IntPtr mach_host_self();

			/// <summary>
			/// 
			/// </summary>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			public static extern uint getpid();

			/// <summary>
			/// 
			/// </summary>
			/// <param name="task"></param>
			/// <param name="flavor"></param>
			/// <param name="taskInfoStructure"></param>
			/// <param name="structureLength"></param>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			public static extern int task_info( IntPtr task, task_flavor_t flavor, IntPtr taskInfoStructure, ref int structureLength );

			/// <summary>
			/// 
			/// </summary>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			[MethodImpl( MethodImplOptions.Synchronized )]
			public static extern uint _dyld_image_count();

			/// <summary>
			/// 
			/// </summary>
			/// <param name="imageIndex"></param>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			[MethodImpl( MethodImplOptions.Synchronized )]
			public static extern mach_header* _dyld_get_image_header( uint imageIndex );

			/// <summary>
			/// 
			/// </summary>
			/// <param name="imageIndex"></param>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			[MethodImpl( MethodImplOptions.Synchronized )]
			public static extern IntPtr _dyld_get_image_vmaddr_slide( uint imageIndex );

			/// <summary>
			/// 
			/// </summary>
			/// <param name="imageIndex"></param>
			/// <returns></returns>
			[MethodImpl( MethodImplOptions.Synchronized )]
			public static string _dyld_get_image_name( uint imageIndex )
			{
				return Marshal.PtrToStringAnsi( UnsafeNativeMethods._dyld_get_image_name( imageIndex ) );
			}

			/// <summary>
			/// 
			/// </summary>
			/// <param name="address"></param>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			[MethodImpl( MethodImplOptions.Synchronized )]
			public static extern mach_header* _dyld_get_image_header_containing_address( IntPtr address );

			/// <summary>
			/// 
			/// </summary>
			/// <param name="header"></param>
			/// <param name="segmentName"></param>
			/// <param name="sectionName"></param>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			public static extern section* getsectbynamefromheader( void* header, string segmentName, string sectionName );

			/// <summary>
			/// 
			/// </summary>
			/// <param name="header"></param>
			/// <param name="segmentName"></param>
			/// <param name="sectionName"></param>
			/// <param name="size"></param>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			public static extern section* getsectdatafromheader( void* header, string segmentName, string sectionName, out uint size );

			/// <summary>
			/// 
			/// </summary>
			/// <param name="address"></param>
			/// <param name="info"></param>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			[MethodImpl( MethodImplOptions.Synchronized )]
			public static extern int dladdr( IntPtr address, out Dl_info info );

			/// <summary>
			/// 
			/// </summary>
			/// <param name="path"></param>
			/// <returns></returns>
			[DllImportAttribute( "libobjc.dylib" )]
			[MethodImpl( MethodImplOptions.Synchronized )]
			public static extern int dlopen( string path );

			/// <summary>
			/// 
			/// </summary>
			/// <param name="handle"></param>
			/// <param name="name"></param>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			public static extern IntPtr dlsym( IntPtr handle, string name );

			/// <summary>
			/// 
			/// </summary>
			/// <param name="name"></param>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			public static extern IntPtr NSLookupAndBindSymbol( string name );

			/// <summary>
			/// 
			/// </summary>
			/// <param name="symbol"></param>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			public static extern IntPtr NSAddressOfSymbol( IntPtr symbol );

			/// <summary>
			/// 
			/// </summary>
			/// <param name="address"></param>
			/// <param name="length"></param>
			/// <param name="protection"></param>
			/// <param name="flags"></param>
			/// <param name="fileDescriptor"></param>
			/// <param name="off"></param>
			/// <returns></returns>
			[DllImport( "libc.dylib", EntryPoint = "mmap$UNIX2003" )]
			public static extern byte* mmap( void* address, int length, MemoryProtection protection, MmapFlags flags, int fileDescriptor, int off );

			/// <summary>
			/// 
			/// </summary>
			/// <param name="address"></param>
			/// <param name="length"></param>
			/// <param name="protection"></param>
			/// <returns></returns>
			[DllImport( "libc.dylib", EntryPoint = "mprotect$UNIX2003" )]
			public static extern int mprotect( void* address, int length, MemoryProtection protection );

			/// <summary>
			/// 
			/// </summary>
			/// <param name="target_task"></param>
			/// <param name="address"></param>
			/// <param name="size"></param>
			/// <param name="anywhere"></param>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			public static extern kern_return_t vm_allocate( IntPtr target_task, void** address, int size, bool anywhere );

			/// <summary>
			/// 
			/// </summary>
			/// <param name="target_task"></param>
			/// <param name="address"></param>
			/// <param name="size"></param>
			/// <param name="set_maximum"></param>
			/// <param name="new_protection"></param>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			public static extern kern_return_t vm_protect( IntPtr target_task, void* address, int size, bool set_maximum, vm_prot_t new_protection );

			/// <summary>
			/// 
			/// </summary>
			/// <param name="host"></param>
			/// <param name="target_task"></param>
			/// <param name="address"></param>
			/// <param name="size"></param>
			/// <param name="wired_access"></param>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			public static extern kern_return_t vm_wire( IntPtr host, IntPtr target_task, void* address, int size, vm_prot_t wired_access );

			/// <summary>
			/// 
			/// </summary>
			/// <param name="task"></param>
			/// <param name="right"></param>
			/// <param name="name"></param>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			public extern static kern_return_t mach_port_allocate( IntPtr task, mach_port_right_t right, out IntPtr name );

			/// <summary>
			/// 
			/// </summary>
			/// <param name="task"></param>
			/// <param name="right"></param>
			/// <param name="proto"></param>
			/// <param name="qos"></param>
			/// <param name="name"></param>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			public extern static kern_return_t mach_port_allocate_full( IntPtr task, mach_port_right_t right, IntPtr proto, ref mach_port_qos_t qos, ref IntPtr name );

			/// <summary>
			/// Send and/or receive a message from the target port.
			/// </summary>
			/// <param name="message">A message buffer used by mach_msg both for send and receive. This must be naturally aligned.</param>
			/// <param name="options">Message options are bit values, combined with bitwise-or. One or both of MACH_SEND_MSG and MACH_RCV_MSG should be used. Other options act as modifiers.</param>
			/// <param name="sendSize">When sending a message, specifies the size of the message buffer to be sent (the size of the header and body) in bytes. Otherwise zero should be supplied.</param>
			/// <param name="receiveSize">When receiving a message, specifies the maximum size of the msg or receive_msg buffer in bytes. Otherwise zero should be supplied.</param>
			/// <param name="receiverPort">When receiving a message, specifies the port or port set. Otherwise MACH_PORT_NULL should be supplied.</param>
			/// <param name="timeout">When using the MACH_SEND_TIMEOUT and MACH_RCV_TIMEOUT options, specifies the time in milliseconds to wait before giving up. Otherwise MACH_MSG_TIMEOUT_NONE should be supplied.</param>
			/// <param name="notifyPort">When using the MACH_SEND_CANCEL and MACH_RCV_NOTIFY options, specifies the port used for the notification. Otherwise MACH_PORT_NULL should be supplied.</param>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			public extern static mach_msg_return_t mach_msg( ref mach_msg_header_t message, mach_msg_option_t options, uint sendSize, uint receiveSize, IntPtr receiverPort, int timeout, IntPtr notifyPort );

			/// <summary>
			/// 
			/// </summary>
			/// <param name="task"></param>
			/// <param name="exception_mask"></param>
			/// <param name="new_port"></param>
			/// <param name="behavior"></param>
			/// <param name="new_flavor"></param>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			public extern static mach_msg_return_t task_set_exception_ports( IntPtr task, exception_mask_t exception_mask, IntPtr new_port, exception_behavior_t behavior, thread_state_flavor_t new_flavor );

			/// <summary>
			/// 
			/// </summary>
			/// <param name="task"></param>
			/// <param name="name"></param>
			/// <param name="msgt_name"></param>
			/// <param name="poly"></param>
			/// <param name="polyPoly"></param>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			public extern static kern_return_t mach_port_extract_right( IntPtr task, IntPtr name, mach_msg_type_name_t msgt_name, ref IntPtr poly, ref mach_msg_type_name_t polyPoly );

			/// <summary>
			/// </summary>
			/// <param name="task"></param>
			/// <param name="name"></param>
			/// <param name="poly"></param>
			/// <param name="polyPoly"></param>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			public extern static kern_return_t mach_port_insert_right( IntPtr task, IntPtr name, IntPtr poly, mach_msg_type_name_t polyPoly );

			/// <summary>
			/// Abort a thread, restartably. 
			/// The thread_abort_safely function aborts page faults and any message primitive calls in use by <paramref name="thread"/>.
			/// Scheduling depressions and clock sleeps are also aborted. The call returns a code indicating that it was interrupted.
			/// The call is interrupted even if the thread (or the task containing it) is suspended. 
			/// If it is suspended, the thread receives the interrupt when it resumes. 
			/// If its state is not modified before it resumes, the thread will retry an aborted page fault.
			/// The Mach message trap returns either MACH_SEND_INTERRUPTED or MACH_RCV_INTERRUPTED, depending on whether the send or the receive side was interrupted.
			/// Note, though, that the Mach message trap is contained within the mach_msg library routine, which, by default, retries interrupted message calls. 
			/// The basic purpose of thread_abort_safely is to let one thread cleanly stop another thread (target_thread).
			/// The target thread is stopped in such a manner that its future execution can be controlled in a predictable way.
			/// When thread_abort_safely returns (if successful), the target thread will appear to have just returned from the kernel (if it had been in kernel mode). 
			/// </summary>
			/// <param name="thread">The thread to be aborted.</param>
			/// <returns></returns>
			[DllImport( "libc.dylib" )]
			public extern static kern_return_t thread_abort_safely( IntPtr thread );
		}

		private static class UnsafeNativeMethods
		{
			[DllImport( "libc.dylib" )]
			public static extern IntPtr _dyld_get_image_name( uint imageIndex );
		}
	}
}
