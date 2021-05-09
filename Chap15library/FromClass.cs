using System;
using System.Linq;

namespace Chap15library
{
    public class FromClass
    {
        public void exam()
        {
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };

            var result = from n in numbers
                         where n % 2 ==0
                         orderby n
                         select n;
            foreach (int n in result)
            {
                Console.WriteLine($"짝수 : {n}");
            }
        }
    }
}
