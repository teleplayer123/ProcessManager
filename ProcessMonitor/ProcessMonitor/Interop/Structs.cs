using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMonitor.Interop
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ProcessEntry32
    {
        /// <summary>
        /// Size of the structure in bytes. Before calling <see cref="TlHelp32Api.Process32First"/> function,
        /// set this member to sizeof(PROCESSENTRY32).
        /// </summary>
        public uint dwSize;
        /// <summary>
        /// No longer in use, always set to zero.
        /// </summary>
        public uint cntUsage;
        /// <summary>
        /// Process identifier.
        /// </summary>
        public uint th32ProcessId;
        /// <summary>
        /// No longer in use, always set to zero.
        /// </summary>
        public IntPtr th32DefaultHeapId;
        /// <summary>
        /// No longer in use, always set to zero.
        /// </summary>
        public uint th32ModuleId;
        /// <summary>
        /// Number of execution threads started by the process.
        /// </summary>
        public uint cntThreads;
        /// <summary>
        /// Identifier of the process that created this process.
        /// </summary>
        public uint th32ParentProcessId;
        /// <summary>
        /// Base priority of any threads created by this process.
        /// </summary>
        public long pcPriClassBase;
        /// <summary>
        /// No longer used, always set to zero.
        /// </summary>
        public uint dwFlags;
        /// <summary>
        /// Name of the executable file for the process.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
        public byte[] szExeFile;
    }
}
