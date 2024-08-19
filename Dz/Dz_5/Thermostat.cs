using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Dz_5
{
    public delegate void TemperatureChangedEventHandler(int temperature);
    internal class Thermostat
    {
        
        public event TemperatureChangedEventHandler TemperatureChanged;
        private int temperature;
        public void Changer(int temperature) { this.temperature = temperature; Tempevent(temperature) ;  }
        protected virtual void Tempevent(int temperature) { TemperatureChanged?.Invoke(temperature); }
        
    }
}
