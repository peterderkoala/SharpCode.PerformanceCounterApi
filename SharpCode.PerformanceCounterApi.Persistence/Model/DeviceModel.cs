using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCode.PerformanceCounterApi.Persistence.Model
{
    public class DeviceModel
    {
        public int Id { get; set; }
        public string DeviceName { get; set; }
        public string DeviceIp { get; set; }
        public string DeviceMAC { get; set; }

        public virtual List<SensorModel> Sensors { get; set; } = new();
    }
}
