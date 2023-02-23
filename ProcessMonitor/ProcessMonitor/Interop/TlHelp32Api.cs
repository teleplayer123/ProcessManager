using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMonitor.Interop
{
    public class TlHelp32Api
    {

        [DllImport("kernel32.dll")]
        public static extern IntPtr CreateToolhelp32Snapshot(
            [In] CreateSnapshotFlags dwFlags,
            [In] uint processId);

        [DllImport("kernel32.dll")]
        public static extern bool Process32First(
            [In] IntPtr hSnapshot,
            [Out] out ProcessEntry32 lpPE);

        [DllImport("kernel32.dll")]
        public static extern bool Process32Next(
            [In] IntPtr hSnapshot,
            [Out] out ProcessEntry32 lpPE);
    }
}
