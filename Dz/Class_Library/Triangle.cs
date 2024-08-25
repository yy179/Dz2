using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class Triangle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException("Not valid triangle");
            }
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double Area()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public double Perimeter()
        {
            return SideA + SideB + SideC;
        }

        public override string ToString()
        {
            return $"Triangle: SideA = {SideA}, SideB = {SideB}, SideC = {SideC}, Area = {Area():F2}, Perimeter = {Perimeter():F2}";
        }
    }
}
