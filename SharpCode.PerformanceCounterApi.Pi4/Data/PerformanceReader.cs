using Iot.Device.CpuTemperature;
using Unosquare.RaspberryIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SharpCode.PerformanceCounterApi.Pi4.Data
{
    internal class PerformanceReader
    {

        public void ReadCpu()
        {
            using CpuTemperature cpuTemperature = new CpuTemperature();
            var temp = cpuTemperature.ReadTemperatures();            
        }

        public void Test()
        {
            Iot.Device.HardwareMonitor.OpenHardwareMonitor a = new();
        }

    }
}
