using ProcessMonitor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMonitor.ProcessCalls
{
    public class CallFactory
    {
        public static IProcessMon GetProcessCalls()
        {
            return new ProcessCaller();
        }
    }
}
