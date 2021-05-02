using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3library
{
    public class IntegralTypes
    {
        public IntegralTypes()
        {
            sbyte a = -10;
            byte b = 40;
            Console.WriteLine($"a = {a},b = {b}");
        }

        public void exam()
        {
            short c = -30000;
            ushort d = 60000;
            Console.WriteLine($"c = {c},d = {d}");
        }

        public void exam1()
        {
            int e = -1000_0000;
            uint f = 3_0000_0000;
            long g = -5000_0000_0000;
            ulong h = 200_0000_0000_0000_0000;
            Console.WriteLine($"e = {e}, f = {f}\ng = {g}, h = {h}");
        }
    }
}
