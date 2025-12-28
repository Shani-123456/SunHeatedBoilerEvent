using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunHeatedBoilerEvent
{
    internal class TemperatureChangedEventArgs: EventArgs

    {
        public double CurrentTemperature { get; set; }
        public DateTime MeasurementTime { get; set; }

        public TemperatureChangedEventArgs(double currentTemperature, DateTime measurementTime)
        {
            CurrentTemperature = currentTemperature;
            MeasurementTime = measurementTime;
        }

    }
}
