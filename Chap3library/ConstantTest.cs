using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3library
{
    public class ConstantTest
    {
        public void exam()
        {
            const int MAX_INT = 2147483647;
            const int MIN_INT = -2147483647;

            Console.WriteLine(MAX_INT);
            Console.WriteLine(MIN_INT);
        }
    }
}
