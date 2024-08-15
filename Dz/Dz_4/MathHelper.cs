using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_4
{
    internal static class MathHelper
    {
        public static long Factorial(int n)
        {
            if (n < 0) throw new ArgumentException("Только положительные числа");
            long res = 1;
            for (int i = 0; i < n; i++) { res *= i; } return res;
        }
        public static int GCD(int a, int b)
        {
            if (a < 0 || b < 0) throw new ArgumentException("Только положительные числа");
            while (b != 0) {int tmp = b; b = a % b; a = tmp; } return a;
        }
        public static int LCM(int a, int b) { return Math.Abs(a * b) / GCD(a, b); }

    }
}
