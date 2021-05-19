using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Chap19library;

namespace Chap19
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ThreadTest threadTest = new ThreadTest();
            threadTest.exam();*/

            /*TaskResult taskResult = new TaskResult();
            taskResult.exam(args);*/

            /*ParallelLoop parallelLoop = new ParallelLoop();
            parallelLoop.exam(args);*/

            /*AsyncClass asyncClass = new AsyncClass();
            asyncClass.exam();*/

            AsyncFileIO asyncFileIO = new AsyncFileIO();
            asyncFileIO.exam(args);
        }

    }
}
