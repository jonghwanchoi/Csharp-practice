using System;
using Chap13library;

namespace Chap13
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Calculator Calc = new Calculator();
             MyDelegate Callback; // 형식

             Callback = new MyDelegate(Calc.Plus); //인스턴스 선언
             Console.WriteLine(Callback(3, 4));

             Callback = new MyDelegate(Calc.Minus);
             Console.WriteLine(Callback(7, 5));*/

            /*int[] array = { 3, 7, 4, 2, 10 };

            Console.WriteLine("Sorting ascending...");
            UsingCallback.BubbleSort(array, new Compare(UsingCallback.AscendCompare));

            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");

            int[] array2 = { 7, 2, 8, 10, 11 };
            Console.WriteLine("\nSorting descending...");
            UsingCallback.BubbleSort(array2, new Compare(UsingCallback.DescendCompare));

            for (int i = 0; i < array2.Length; i++)
                Console.Write($"{array2[i]} ");

            Console.WriteLine();*/

            /* Notifier notifier = new Notifier();
             EventListener listener1 = new EventListener("Listener1"); // 이름 지정
             EventListener listener2 = new EventListener("Listener2");
             EventListener listener3 = new EventListener("Listener3");

             notifier.EventOccured += listener1.SomethingHappend;
             notifier.EventOccured += listener2.SomethingHappend;
             notifier.EventOccured += listener3.SomethingHappend;
             notifier.EventOccured("You've got mail."); //delegate랑 어떻게 연결되는건지?

             Console.WriteLine();

             notifier.EventOccured -= listener2.SomethingHappend;
             notifier.EventOccured("Download complete.");

             Console.WriteLine();

             notifier.EventOccured = new Notify(listener2.SomethingHappend) + new Notify(listener3.SomethingHappend);
             notifier.EventOccured("Nuclear launch detected.");

             Console.WriteLine();

             Notify notify1 = new Notify(listener1.SomethingHappend);
             Notify notify2 = new Notify(listener2.SomethingHappend);

             notifier.EventOccured = (Notify)Delegate.Combine(notify1, notify2);
             notifier.EventOccured("Fire!!");

             Console.WriteLine();

             notifier.EventOccured = (Notify)Delegate.Remove(notifier.EventOccured, notify2);
             notifier.EventOccured("RPG!");*/

            /*MyModifier notifier = new MyModifier();
            notifier.SomethingHappened += new EventHandlers(MyModifier.MyHandler);  //구독?

            *//*for (int i = 1; i < 30; i++)
            {
                notifier.DoSomething(i); // somethinghappend선언시 연결돼 값 입력후 출력?
                //notifier.SomethingHappened("Hello"); //직접 이벤트를 호출 할 수 없다.*//*
            }*/

            /*int[] array = { 3, 7, 4, 2, 10 };

            Console.WriteLine("Sorting ascending...");
            GenericDelegate.BubbleSort<int>(array, new Compare<int>(GenericDelegate.AscendCompare));

            for (int i =0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} ");
            }

            string[] array2 = { "abc", "def", "ghi", "jkl", "mno" };

            Console.WriteLine("\nSorting descending...");
            GenericDelegate.BubbleSort<string>(array2, new Compare<string>(GenericDelegate.DescendCompare));

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine($"{array2[i]} ");
            }*/
            //--------------------------------------------------------------

            /* int[] array = { 3, 7, 4, 2, 10 };

             Console.WriteLine("Sorting ascending...");
             AnonymousMethod.BubbleSort(array, delegate (int a, int b)
             {
                 if (a > b)
                 {
                     return 1;
                 }
                 else if (a == b)
                 {
                     return 0;
                 }
                 else return -1;
             });

             for (int i = 0; i < array.Length; i++)
             {
                 Console.WriteLine($"{array[i]} ");
             }

             int[] array2 = { 7, 2, 8, 10, 11 };

             Console.WriteLine("Sorting Descending...");
             AnonymousMethod.BubbleSort(array2, delegate (int a, int b)//익명의 메소드를 매개변수로 받고 호출시 메소드 안에 있는 코드 실행
             {
                 if (a < b)
                 {
                     return 1;
                 }
                 else if (a == b)
                 {
                     return 0;
                 }
                 else return -1;
             });

             for (int i = 0; i < array2.Length; i++)
             {
                 Console.WriteLine($"{array2[i]} ");
             }

             Console.WriteLine();*/
            //--------------------------------------------------------

            MyModifier notifier = new MyModifier();
            notifier.SomethingHappened += new EventHandlers(MyModifier.MyHandler);

            for(int i = 0; i < 30; i++ )
            {
                notifier.DoSomething(i);
            }

        }//end
    }
}
