using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Knapsack_problem
{
    internal class ProcessorUsage
    {

        private static PerformanceCounter avgCounter64Sample;
        private static PerformanceCounter avgCounter64SampleBase;

        PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");

        public string getCurrentCpuUsage()
        {
            cpuCounter.NextValue();
            System.Threading.Thread.Sleep(1000);
            return cpuCounter.NextValue() + "%";
        }

        public string getAvailableRAM()
        {
            cpuCounter.NextValue();
            System.Threading.Thread.Sleep(1000);
            return ramCounter.NextValue() + "MB";
        }
    }
}
