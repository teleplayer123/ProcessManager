using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMonitor.ProcessTypes
{
    public class ProcessInfo
    {
        public string ProcName { get; private set; }
        public int ProcBasePriority { get; private set; }
        public ProcessPriorityClass ProcessPriorityClass { get; private set; }
        public TimeSpan ProcUserProcessorTime { get; private set; }
        public TimeSpan ProcPrivilegedProcessorTime { get; private set; }
        public TimeSpan ProcTotalProcessorTime { get; private set; }
        public long ProcPhysicalMemoryUsage { get; private set; }
        public int ProcPid { get; private set; }
        public bool ProcStatus { get; private set; }

        public ProcessInfo(Process process) 
        {
            ProcName = process.ProcessName;
            ProcBasePriority = process.BasePriority;
            //ProcessPriorityClass = process.PriorityClass;
            //ProcUserProcessorTime = process.UserProcessorTime;
            //ProcPrivilegedProcessorTime = process.PrivilegedProcessorTime;
            //ProcTotalProcessorTime = process.TotalProcessorTime;
            ProcPhysicalMemoryUsage = process.WorkingSet64;
            ProcPid = process.Id;
            ProcStatus = process.Responding;
        }
    }
}
