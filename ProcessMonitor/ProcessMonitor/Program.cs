using ProcessMonitor.ProcessCalls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcessMonitor.ProcessManager;
using ProcessMonitor.ProcessTypes;

namespace ProcessMonitor
{
    public class Program
    {
        static void Main()
        {
            var pcaller = CallFactory.GetProcessCalls();
            var processes = pcaller.GetAllLocalProcesses();
            var result = PMonitor.IterateProcesses(processes);
            foreach(ProcessInfo pinfo in result ) 
            {
                PUtils.PrintProcessInfo(pinfo);
            }
            PUtils.LogProcessInfo(result);
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
