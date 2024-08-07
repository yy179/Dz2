using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car fCar = new Car("Bmv", "X8", 2008, 12000);// в машинах не разбираюсь поэтому год от балды написал
            Console.WriteLine($"Миляж: {fCar.Mileage}");
            Console.WriteLine(fCar.Drive(100));
            Console.WriteLine(fCar.Drive(125));
            Console.WriteLine(fCar.Drive(100,2));
            Console.WriteLine($"Возраст: {fCar.Age()}");
            ElectricCar elcar = new ElectricCar("Tesla", "Model S", 2020, 20000, 100);
            Console.WriteLine(elcar.Drive(200));
            Console.WriteLine(elcar.Charge(10));
            Console.WriteLine(elcar.Charge(5));
            Console.WriteLine(elcar.Drive(100,2));
            Console.WriteLine($"Возраст: {elcar.Age()}");
            // проверку заряда на меньше нуля и больше ста не делал, разбираться в каких моделях электро-машин до скольки можно заряжать, и есть ли резервное питание на случай разрядки, а в каких нет - не особо хотелось
        }
    }
}