using System;

namespace Chap13library
{
    public delegate int MyDelegate(int a, int b); //class 밖에 선언해야 class 안에서 사용 가능
    public class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }
    }
}
