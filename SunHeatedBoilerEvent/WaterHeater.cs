using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunHeatedBoilerEvent
{
    internal class WaterHeater
    {
        double CurrentTemperature { get;  set; }
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;
        EventHandler TargetReached;
        public void StartBoiler(double targetTemp)
        {
            while (CurrentTemperature < targetTemp)
            {
                CurrentTemperature += 2;

                EventHandler(new TemperatureChangedEventArgs(CurrentTemperature, DateTime.Now));

                Thread.Sleep(500);
            }

            TargetReached();
        }
    }
    
}
