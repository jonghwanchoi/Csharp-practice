using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap19library
{
    public class AsyncClass
    {
        async static private void MyMethodAsync(int count)
        {
            Console.WriteLine("C");
            Console.WriteLine("D");

            await Task.Run(async () => //async가 await를 만나면 제어를 호출자로 이동시키고 나머지 동시 진행
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.WriteLine($"{i}/{count} ...");
                    await Task.Delay(100);
                }
            });
            Console.WriteLine("G");
            Console.WriteLine("H");
        }

        static void Caller() //호출자
        {
            Console.WriteLine("A");
            Console.WriteLine("B");

            MyMethodAsync(3);

            Console.WriteLine("E");
            Console.WriteLine("F");
        }

        public void exam()
        {
            Caller();

            Console.ReadLine();
        }
    }
}
