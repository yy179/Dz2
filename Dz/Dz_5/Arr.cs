using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_5
{
    public static class Arr
    {
        public static double Average(this int[] array) 
        {
            if (array == null || array.Length == 0) { throw new Exception("Array cant be null || length 0"); }
            double sum = 0;
            foreach (var number in array){ sum += number; }
            return sum / array.Length;
        }
    }
}
