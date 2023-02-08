using ProcessMonitor.ProcessTypes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMonitor.ProcessManager
{
    public class PMonitor
    {
        public static List<ProcessInfo> IterateProcesses(Process[] processes) 
        {
            List<ProcessInfo> processInfoList = new();
            ProcessInfo processInfo;

            foreach (Process process in processes)
            {
                processInfo = new ProcessInfo(process);
                processInfoList.Add(processInfo);
            }
            return processInfoList;
        }

        public static ProcessInfo GetProcessInfo(Process process) 
        {
            ProcessInfo processInfo = new ProcessInfo(process);
            return processInfo;
        }
    }
}
