using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_8
{
    internal class ThreadsCreate
    {
        private Thread thread1;
        private Thread thread2;
        public ThreadsCreate() {
            thread1 = new Thread(Work1);
            thread2 = new Thread(Work2);
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
        }

        private void Work1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Поток 1: {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(500);
            }
        }
        private void Work2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Поток 2: {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(500);
            }
        }
        
    }
}
