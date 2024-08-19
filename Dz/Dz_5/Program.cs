using System;
using System.Numerics;
using System.Threading.Channels;

namespace Dz_5;

internal class Program
{
    public static void Main(string[] args)
    {
        #region Task_1
        Thermostat thermostat = new Thermostat();
        thermostat.TemperatureChanged += ShowTemperature;
        thermostat.Changer(24);
        thermostat.Changer(30);
        #endregion
        #region Task_2
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        List<int> couples = numbers.Where(n => n % 2 == 0).ToList();
        Console.Write("Input number: ");
        int input = int.Parse(Console.ReadLine());
        List<int> biggest = numbers.Where(n => n > input).ToList();
        Console.WriteLine(string.Join(", ",numbers));
        Console.WriteLine(string.Join(", ", couples));
        Console.WriteLine(string.Join(", ", biggest));
        #endregion
        #region Task_3
        int[] nums1 = { 1, 2, 3, 4, 5, 6 };
        double avg1 = nums1.Average();
        Console.WriteLine(avg1);
        int[] nums2 = { 1, 2, 3, 4, 5, 6, 22 ,3 };
        double avg2 = nums2.Average();
        Console.WriteLine(avg2);
        #endregion
        #region Task_4
        Sensor sensor = new Sensor();
        sensor.MeasurementUpdated += average => Console.WriteLine($"Avg: {average}");
        sensor.measAdd(10.5);
        sensor.measAdd(-1.0);
        sensor.measAdd(20.3);
        sensor.measAdd(19.4);
        #endregion
    }
    public static void ShowTemperature(int temperature) { Console.WriteLine($"Temperature has changed to: {temperature}"); }
}