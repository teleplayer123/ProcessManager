using ProcessMonitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMonitor.ProcessCalls
{
    public class ProcessCaller : IProcessMon
    {
        public Process[] GetAllLocalProcesses()
        {
            Process[] processes = Process.GetProcesses();
            return processes;
        }

        public Process[] GetLocalProcessesByName(string name)
        {
            Process[] processes = Process.GetProcessesByName(name); 
            return processes;
        }

        public Process GetLocalProcessById(int id) 
        {
            Process process = Process.GetProcessById(id);
            return process;
        }
    }
}
