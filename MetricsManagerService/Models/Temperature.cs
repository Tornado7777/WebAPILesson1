using System;

namespace MetricsManagerService.Models
{
    public class Temperature
    {
        public TimeSpan Date { get; set; }

        public int TemperatureC { get; set; }
    }
}
