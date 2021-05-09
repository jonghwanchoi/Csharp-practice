using System;
using Chap14library;

namespace Chap14
{
    class Program
    {
        delegate string Concatenate(string[] args);
        static void Main(string[] args)
        {
            /*Calculate calc = (a, b) => a + b;

            Console.WriteLine($"{3} + {4} : {calc(3, 4)}");*/

            //----------------------------------------

            Concatenate concat =
                (arr) =>
                {
                    string result = "";
                    foreach (string s in arr)
                    {
                        result += s;
                    }
                    return result;
                };
            Console.WriteLine( concat(args) ); //속성에 애플리케이션 인수 추가해야 결과값 나옴.

            FuncTest funcTest = new FuncTest();
            funcTest.exam();

            ActionTest actionTest = new ActionTest();
            actionTest.exam();
        }
    }
}
