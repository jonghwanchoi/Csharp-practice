using System;
using Chap7library;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap7
{
    class Program1
    {
        static void Main(string[] args)
        {
            /*BasicClass basicClass = new BasicClass();
            basicClass.Color = "하얀색";
            basicClass.Name = "비둘기";

            basicClass.exam();
            Console.WriteLine($"{basicClass.Name} : {basicClass.Color}");

            BasicClass basicClass1 = new BasicClass();
            basicClass1.Color = "검은색";
            basicClass1.Name = "까마귀";

            basicClass1.exam();
            Console.WriteLine($"{basicClass1.Name} : {basicClass1.Color}");

            Console.WriteLine();

            Constructor kitty = new Constructor("비둘기", "하얀색");
            kitty.exam();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            Constructor nero = new Constructor("까마귀", "까만색");
            nero.exam();
            Console.WriteLine($"{nero.Name} : {nero.Color}");*/

            Console.WriteLine($"StaticField.count : {StaticField.count} ");

            new ClassA();
            new ClassA();
            new ClassB();
            new ClassB();

            Console.WriteLine($"StaticField.count : {StaticField.count}");

        }
    }
}
