using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap7library
{
    public class StaticField
    {
        public static int count = 0;
    }

    public class ClassA
    {
        public ClassA()
        {
            StaticField.count++;
        }
    }

    public class ClassB
    {
        public ClassB()
        {
            StaticField.count++;
        }
    }
}
