using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMonitor.Interop
{
    public enum CreateSnapshotFlags : uint
    {
        Inherit = 0x80000000,
        SnapHeapList = 0x00000001,
        SnapProcess = 0x00000002,
        SnapThread = 0x00000004,
        SnapModule = 0x00000008,
        SnapModule32 = 0x00000010,
        SnapAll = SnapHeapList | SnapModule | SnapProcess | SnapThread
    }
}
