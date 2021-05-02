using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3library
{
    public class StringSearch
    {
        public void exam()
        {
            string greeting = "Good afternoon";
            Console.WriteLine(greeting);

            int a = greeting.IndexOf("after");
            Console.WriteLine(a);

            a = greeting.IndexOf("Good");
            Console.WriteLine(a);

            a = greeting.LastIndexOf("after");
            Console.WriteLine(a);

            bool isStart = greeting.StartsWith("Good");
            Console.WriteLine(isStart);


            isStart = greeting.EndsWith("ood");
            Console.WriteLine(isStart);

            Console.WriteLine(greeting.Replace("afternoon", "evening"));

            

        }
    }
}
