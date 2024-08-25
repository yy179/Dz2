using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_7
{
    internal class ComplexNumber
    {
        private double real;
        private double imaginary;
        public ComplexNumber(double real, double imaginary) { this.real = real; this.imaginary = imaginary; }
        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b) { return new ComplexNumber(a.real + b.real, a.imaginary + b.imaginary); }
        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b) { return new ComplexNumber(a.real - b.real, a.imaginary - b.imaginary); }
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b) {
            double real = a.real * b.real - a.imaginary * b.imaginary;
            double imaginary = a.real * b.imaginary + a.imaginary * b.real;
            return new ComplexNumber(real, imaginary);
        }
        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            double denom = b.real * b.real + b.imaginary * b.imaginary;
            if (denom == 0)
            {
                throw new DivideByZeroException("Division by zero.");
            }

            double real = (a.real * b.real + a.imaginary * b.imaginary) / denom;
            double imaginary = (a.imaginary * b.real - a.real * b.imaginary) / denom;
            return new ComplexNumber(real, imaginary);
        }
        public override string ToString()
        {
            if (imaginary >= 0)
            {
                return $"{real} + {imaginary}i";
            }
            else { return $"{real} - {-imaginary}i"; }
        }
        public static bool operator ==(ComplexNumber a, ComplexNumber b)
        {
            return a.real == b.real && a.imaginary == b.imaginary;
        }

        public static bool operator !=(ComplexNumber a, ComplexNumber b)
        {
            return !(a == b);
        }
        public override bool Equals(object obj)
        {
            if (obj is ComplexNumber other)
            {
                return this == other;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (real, imaginary).GetHashCode();
        }
    }
}
