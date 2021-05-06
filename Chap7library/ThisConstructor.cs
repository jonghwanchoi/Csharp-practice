using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap7library
{
    public class ThisConstructor
    {
        int a, b, c;

        public ThisConstructor()
        {
            this.a = 5425;
            Console.WriteLine("ThisConstructor()");
        }

        public ThisConstructor(int b): this()
        {
            this.b = b;
            Console.WriteLine($"ThisConstructor({b})");
        }

        public ThisConstructor(int b, int c): this(b)
        {
            this.c = c;
            Console.WriteLine($"ThisConstructor({b}, {c})");
        }

        public void PrintFields()
        {
            Console.WriteLine($"a:{a}, b:{b}, c:{c}");
        }
    }
}
