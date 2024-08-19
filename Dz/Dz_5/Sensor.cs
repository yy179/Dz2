using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_5
{
    public class Sensor
    {
        public event Action<double> MeasurementUpdated;
        private List<double> measurements = new List<double>();
        public void measAdd (double measurement) 
        {
            if (measurement > 0) 
            {   measurements.Add(measurement);
                MeasurementUpdated?.Invoke(measurements.ToArray().Average()); }
        }

    }
}
