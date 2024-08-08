using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_2
{
    public struct Vector
    {
        public double X {  get; set; }
        public double Y {  get; set; }
        public Vector(double x, double y) { X = x; Y = y; }
        public double Length() { return Math.Sqrt(X * X + Y * Y); }
    }
}
