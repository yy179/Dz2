using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_2
{
    internal abstract class Shape : IMovable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public abstract void Move(int deltaX, int deltaY);
    }
}
