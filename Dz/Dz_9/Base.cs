using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_9
{
    internal class Base
    {

        public Base()
        {
            Task task1 = Task.Run(() => Console.WriteLine("Task 1"));
            Task task2 = Task.Run(() => 3+5);
            Task task3 = Task.Run(() => Task.Delay(1000).Wait());
            Task.WaitAll(task1, task2, task3);
            Console.WriteLine("Finished!");
        }
    }
}
