using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCode.PerformanceCounterApi.Persistence.Model
{
    public class SensorModel
    {
        public int Id { get; set; }
        public string SensorName { get; set; }

        public int DeviceId { get; set; }
        public DeviceModel Device { get; set; } = null!;
        public virtual List<ValueModel> MeasuredValues { get; set; } = new();
    }
}
