using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_8
{
    internal class ThreadsSync
    {
        private Thread thread1;
        private Thread thread2;
        private int counter = 0;
        private readonly object _lockObject = new object();
        public ThreadsSync() 
        {
            thread1 = new Thread(Work);
            thread2 = new Thread(Work);
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            Console.WriteLine($"Count: {counter}");
        }
        private void Work() 
        {
            for (int i = 0; i < 1000; i++) 
            { 
                lock(_lockObject) { counter++; }
            }
        }
    }
}
