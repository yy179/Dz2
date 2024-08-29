using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_8
{
    
    internal class ThreadsPool
    {
        public ThreadsPool()
        {
            for (int i = 1; i <= 10; i++)
            {
                int taskNumber = i;
                ThreadPool.QueueUserWorkItem(Work, taskNumber);
                //Thread.Sleep(200);//Со слипом за выполнение всего берется один и тот-же поток, без него - разные
            }
        }
        static void Work (object state)
        {
            int taskNumber = (int)state;
            Console.WriteLine($"Task: {taskNumber} Thread: {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
