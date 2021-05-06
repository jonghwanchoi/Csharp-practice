using System;
using Chap8library;

namespace Chap8
{
    class Program
    {
        static void Main(string[] args)
        {
            ClimateMonitor monitor = new ClimateMonitor(
                new FileLogger("MyLog.txt")
            );

            monitor.start();
        }
    }
}
