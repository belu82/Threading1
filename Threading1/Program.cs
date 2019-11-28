using System;
using System.Threading;

namespace Threading1
{
    class Program
    {
       

        static void Main(string[] args)
        {
            ThreadStart starter = new ThreadStart(counting);
            Thread first = new Thread(starter);
            Thread second = new Thread(starter);
            first.Start();
            second.Start();

            first.Join();
            second.Join();

            Console.Read();
        }

        public static void counting()
        {
            
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine("Count: {0} - Thread Id: {1}", i, Thread.CurrentThread.ManagedThreadId);
                int sleepfor = 1000;

                Thread.Sleep(sleepfor);
            }
        }
    }
}
