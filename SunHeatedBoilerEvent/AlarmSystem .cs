using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunHeatedBoilerEvent
{
    internal class AlarmSystem
    {
        public void TargetReached(object? sender, EventArgs ev)
        {
            Console.WriteLine("ALARM] Target temperature degrees reached! Powering off....");
        }
    }
}
