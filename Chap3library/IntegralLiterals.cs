using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3library
{
    public class IntegralLiterals
    {
        public IntegralLiterals()
        {

        }

        public void exam()
        {
            byte a = 240;
            Console.WriteLine($"a = {a}");

            byte b = 0b1111_0000;
            Console.WriteLine($"b = {b}");

        }
    }
}
