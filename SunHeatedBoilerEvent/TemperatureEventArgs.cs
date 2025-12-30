using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunHeatedBoilerEvent
{
    internal class TemperatureEventArgs : EventArgs
    {
        public double currentTemperature { get; }

        public DateTime eventTime { get; }

        //-----------------------------------------------------------

        public TemperatureEventArgs(double currentTemperature)
        {
            this.currentTemperature = currentTemperature;
            this.eventTime = DateTime.Now;
        }

        //-----------------------------------------------------------
    }
}
