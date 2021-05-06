using System;

namespace Chap7library
{
    class MethodHiding
    {
    }

    public class Base1
    {
        public void MyMethod()
        {
            Console.WriteLine("Base.MyMethod()");
        }
    }

    public class Derived1 : Base1
    {
        public new void MyMethod()
        {
            Console.WriteLine("Derived.MyMethod()");
        }
    }


}//end
