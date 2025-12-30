using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunHeatedBoilerEvent
{
    internal class DisplayUnits
    
     {public void DisplayTemperature(object sender, TemperatureEventArgs Event)
        {
            Console.Write($"\rCurrent Temperature: {Event.currentTemperature}°C at {Event.eventTime}");

        }
}
}
