using ProcessMonitor.ProcessTypes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMonitor.ProcessManager
{
    public class PUtils
    {
        public static void PrintProcessInfo(ProcessInfo pInfo)
        {
            Console.WriteLine();
            Console.WriteLine($"Process Name: {pInfo.ProcName}");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Process PID: {pInfo.ProcPid}");
            Console.WriteLine($"Process {pInfo.ProcPid} BasePriority: {pInfo.ProcBasePriority}");
            Console.WriteLine($"Process {pInfo.ProcPid} PhysicalMemoryUsage: {pInfo.ProcPhysicalMemoryUsage}");
            Console.WriteLine($"Process {pInfo.ProcPid} Status: {pInfo.ProcStatus}");
            Console.WriteLine();
        }
        
        public static void LogProcessInfo(List<ProcessInfo> pInfos)
        {
            List<string> list = new List<string>();
            string dirName = @"C:\ProcessLogs";
            
            if (!Directory.Exists(dirName))
            {
                Directory.CreateDirectory(dirName);
            }

            foreach (ProcessInfo pInfo in pInfos)
            {
                string procStr = $"\n{pInfo.ProcName}\n------------------------\n\tPID: {pInfo.ProcPid}\n\tBasePriority: {pInfo.ProcBasePriority}\n\tPhysicalMemoryUsage: {pInfo.ProcPhysicalMemoryUsage}\n\tStatus: {pInfo.ProcStatus}\n";
                list.Add(procStr);
            }
            string fileName = "process_logs.log";
            string pathName = Path.Combine(dirName, fileName);

            File.WriteAllLines(pathName, list);
        }

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
