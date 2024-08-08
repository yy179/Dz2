using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_2
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override void Move(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
            Console.WriteLine($"moved: ({X},{Y})");
        }
        public void Resize(Vector vector) 
        {
            Width += vector.X;
            Height += vector.Y;
            Console.WriteLine($"Resized! Width: {Width}, Height: {Height}");
        }
    }
}
