using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3library
{
    public class NullableTypes
    {
        public void exam()
        {
            int? a = null;
            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);

            a = 3;

            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);
            Console.WriteLine(a.Value);
        }
    }
}
