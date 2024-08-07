using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_1
{
    internal class ElectricCar : Car
    {
        private double batteryCapacity;
        public ElectricCar(string brand, string model, int year, double mileage, double batteryCapacity) : base(brand, model, year, mileage)
        {
            this.batteryCapacity = batteryCapacity;
        }
        public string Charge(double amount) { return $"Заряжено на {amount}%. Текущий заряд = {batteryCapacity += amount} "; }
        public override string Drive(double distance) // Бреинлаг небольшой произошел с обдумыванием алгоритма, сделал на основе введенной дистанции ввиде километров
        {
            double procents = distance * 0.1;
            batteryCapacity -= procents;
            return $"Заряд после поездки: {batteryCapacity}";
        }
    }
}
