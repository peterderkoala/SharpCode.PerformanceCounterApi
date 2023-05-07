using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCode.PerformanceCounterApi.Persistence.Model
{
    public class ValueModel
    {
        public int Id { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
        public decimal MeasuredValue { get; set; }
        public decimal ValueType { get; set; }
        public SensorModel Sensor { get; set; } = null!;
    }
}
