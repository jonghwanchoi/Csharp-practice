using System;
using Chap6library;

namespace Chap6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Overloading.Plus(a:1, b:2));
            Console.WriteLine(Overloading.Plus(1, 2, 3));
            Console.WriteLine(Overloading.Plus(1.0, 2.4));
            Console.WriteLine(Overloading.Plus(2.4, 1));

            int sum = UsingParam.Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine("Sum : {0}", sum );
        }
    }
}
