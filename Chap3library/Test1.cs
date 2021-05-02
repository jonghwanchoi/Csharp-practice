using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chap3library
{
    public class Test1
    {
        public int AddNum(string x, string y)
        {
            int a, b, result = 0;

            a = Convert.ToInt32(x);
            b = Convert.ToInt32(y);
            result = a + b;
            
            return result;
        }
    }
}
