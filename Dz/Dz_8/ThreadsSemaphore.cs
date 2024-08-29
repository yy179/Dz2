using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_8
{
    internal class ThreadsSemaphore
    {
        private Semaphore semaphore = new Semaphore(2,2);
        private int counter = 0;
        public ThreadsSemaphore() 
        {
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(Work);
                thread.Start();
                Console.WriteLine($"Semaphore count: {counter}");
            }
        }
        private void Work() 
        {
            semaphore.WaitOne();
            for (int i = 0; i < 1000; i++)
            {
                counter++;
            }
            semaphore.Release();
        }//Можно и оставить лок но зачем тут тогда вообще семафор нужен будет
    }
}
