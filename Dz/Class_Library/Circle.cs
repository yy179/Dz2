using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Понятно что можно было вообще в солюшн не добавлять, но чтобы вы в гитхабе видели код а не я кидал файл отдельно, я сюда добавил
namespace Class_Library
{
    public class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return $"Circle: Radius = {Radius}, Area = {Area():F2}, Perimeter = {Perimeter():F2}";
        }
    }
}
