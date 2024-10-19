namespace Dz_19
{
    internal class Program
    {
        private static ManualResetEvent manualResetEvent = new ManualResetEvent(false);
        private static Mutex mut = new Mutex();
        private static int count = 0;
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(PrintThreadInfo);
            Thread thread2 = new Thread(PrintThreadInfo);
            Thread thread3 = new Thread(PrintThreadInfo);

            thread1.Start(1);
            thread2.Start(2);
            thread3.Start(3);
            
            manualResetEvent.Set();

            

            thread1.Join();
            Console.WriteLine("Thread 1 finished work");
            thread2.Join();
            Console.WriteLine("Thread 2 finished work");
            thread3.Join();
            Console.WriteLine("Thread 3 finished work");
        }
        private static void PrintThreadInfo(object threadNumber) 
        {
            Console.WriteLine("Waithing for a signal...");
            manualResetEvent.WaitOne();
            mut.WaitOne();
            for (int i = 0; i < 3; i++)
            {
                count += 1;
                Console.WriteLine($"Thread: {threadNumber} - count: {count}");
                Thread.Sleep(100);
            }
            mut.ReleaseMutex();
        }
    }
}