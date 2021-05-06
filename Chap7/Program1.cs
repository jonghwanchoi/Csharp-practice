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

            /*  Thiskeyword pooh = new Thiskeyword();
              pooh.SetName("pooh");
              pooh.SetPosition("Waiter");
              Console.WriteLine($"{pooh.GetName()} {pooh.GetPosition()}");

              Thiskeyword tigger = new Thiskeyword();
              tigger.SetName("Tigger");
              tigger.SetPosition("Cleaner");
              Console.WriteLine($"{tigger.GetName()} {tigger.GetPosition()}");

              ThisConstructor a = new ThisConstructor();
              a.PrintFields();
              Console.WriteLine();

              ThisConstructor b = new ThisConstructor(1);
              b.PrintFields();
              Console.WriteLine();

              ThisConstructor c = new ThisConstructor(10, 20);
              c.PrintFields();*/

            /*try
            {
                AccessModifier heater = new AccessModifier();
                heater.SetTemperature(20);
                heater.TurnOnWater();

                heater.SetTemperature(-2);
                heater.TurnOnWater();

                heater.SetTemperature(50);
                heater.TurnOnWater();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Base a = new Base("a");
            a.BaseMethod();

            Derived b = new Derived("b");
            b.BaseMethod();
            b.DerivedMethod();*/

            /*Mammal mammal = new Dog();
            Dog dog;

            if (mammal is Dog)
            {
                dog = (Dog)mammal;
                dog.Bark();
            }

            Mammal mammal2 = new Cat();
            Cat cat = mammal2 as Cat;
            if(cat != null)
            {
                cat.Meow();
            }

            Cat cat2 = mammal as Cat;
            if(cat2 != null)
            {
                cat2.Meow();
            }
            else
            {
                Console.WriteLine("cat is not a Cat");
            }*/

            /*Console.WriteLine("Creating ArmorSuite...");
            Armorsuite armorsuite = new Armorsuite();
            armorsuite.Initialize();

            Console.WriteLine("\nCreating IronMan...");
            Armorsuite ironman = new IronMan();
            ironman.Initialize();

            Console.WriteLine("\nCreating WarMachine...");
            Armorsuite warmachine = new WarMachine();
            warmachine.Initialize();*/

            /*Base1 baseObj = new Base1();
            baseObj.MyMethod();

            Derived1 derivedObj = new Derived1();
            derivedObj.MyMethod();

            Base1 baseOrDerived = new Derived1();
            baseOrDerived.MyMethod();*/
            
            // 명명되지 않은 튜플
            var a = ("슈퍼맨", 9999);
            Console.WriteLine($"{a.Item1} {a.Item2}");

            // 명명된 튜플
            var b = (Name: "박상현", Age: 17);
            Console.WriteLine($"{b.Name} {b.Age}");

            // 분해
            var (name, age) = b;
            Console.WriteLine($"{name} {age}");

            // 분해2
            var (name2, age2) = ("박문수", 34);
            Console.WriteLine($"{name2} {age2}");

            // 명명된 튜플 = 명명되지 않은 튜플
            b = a;
            Console.WriteLine($"{b.Name} {b.Age}");
        }//end
    }
}
