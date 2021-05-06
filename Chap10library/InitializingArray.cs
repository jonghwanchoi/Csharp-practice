using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10library
{
   public  class InitializingArray
    {
        public void exam()
        {
            string[] array1 = new string[3] { "안녕", "Hello", "Halo" };  // 용량 명시
            Console.WriteLine("array1...");
            foreach (string greeting in array1)
            {
                Console.WriteLine($"{greeting}");
            }

            string[] array2 = new string[] { "안녕", "Hello", "Halo" }; // 용량 생략

            Console.WriteLine("\narray2...");
            foreach(string greeting in array2)
            {
                Console.WriteLine($"{greeting}");
            }

            string[] array3 = { "안녕", "Hello", "Halo" }; // 연사자, 대괄호, 용량 모두 생략

            Console.WriteLine("\narray3...");
            foreach(string greeting in array3)
            {
                Console.WriteLine($"{greeting}");
            }
        }
    }
}
