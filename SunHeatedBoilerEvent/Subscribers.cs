using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunHeatedBoilerEvent
{
    internal class Subscribers
    {
        public void OnTemperatureChanged(object? sender, TemperatureChangedEventArgs ev)
        {
            Console.WriteLine($" Current Temperature is: {ev.CurrentTemperature:F}°C at {ev.MeasurementTime} d");
        }
    }
}
