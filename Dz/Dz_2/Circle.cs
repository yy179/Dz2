using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_2
{
    internal class Circle : Shape
    {
        public override void Move(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
            Console.WriteLine($"moved: ({X},{Y})");
        }

    }
}
