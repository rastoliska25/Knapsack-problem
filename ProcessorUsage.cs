using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data;


namespace Knapsack_problem
{
    internal class ProcessorUsage
    {
        private static PerformanceCounter avgCounter64Sample;
        private static PerformanceCounter avgCounter64SampleBase;

        PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");

        public float getCurrentCpuUsage()
        {
            cpuCounter.NextValue();
            System.Threading.Thread.Sleep(100);
            return cpuCounter.NextValue();
        }

        public string getAvailableRAM()
        {
            return ramCounter.NextValue() + " MB";
        }
    }
}
