using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_1
{
    internal class Car
    {
        private string brand;
        private string model;
        private int year;
        private double mileage;
        private double distance;
        public double Mileage { get { return mileage; } } // Подумал что нет необходимости делать здесь приватный сеттер 
        public Car (string brand, string model, int year, double mileage) 
        { 
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.mileage = mileage;
        }
        public virtual string Drive(double distance)
        { this.distance += distance; return $"Пробег: {this.distance}"; }

        public string Drive(double distance, int hours)
        { return $"Средняя скорость: {distance / hours}"; } // Сделал задание так как понял, взял не уже пройденное расстояние так как написано что дистанция именно принимается, если все-же нужно и принять и добавить то просто добавить строку как в драйв с 1-ой перегрузкой и в расчетах вписать this.distance 

        public int Age()
        {return DateTime.Now.Year - year; }
        ~Car() { Console.WriteLine("Обьект удален из памяти"); }

    }
}
