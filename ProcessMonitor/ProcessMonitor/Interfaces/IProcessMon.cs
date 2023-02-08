using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMonitor.Interfaces
{
    public interface IProcessMon
    {
        Process[] GetAllLocalProcesses();
        Process[] GetLocalProcessesByName(string name);
        Process GetLocalProcessById(int id);
    }
}
