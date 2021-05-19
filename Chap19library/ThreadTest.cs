using System;
using System.Threading;

namespace Chap19library
{
    public class ThreadTest
    {
        public void Dosomething()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10);
            }
        }

        public void exam()
        {
            Thread t1 = new Thread(new ThreadStart(Dosomething));

            Console.WriteLine("Starting thread...");
            t1.Start(); 

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Main ; {i}");
                Thread.Sleep(10);
            }

            Console.WriteLine("Wating until thread stops...");
            t1.Join();

            Console.WriteLine("Finished");
        }
    }
}
