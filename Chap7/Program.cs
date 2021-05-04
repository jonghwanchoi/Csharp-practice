using System;
using Chap7library;
using System.Collections.Generic;


namespace Chap7
{
    struct Point3D
    {
        public int X;
        public int Y;
        public int Z;

        public Point3D(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public override string ToString()
        {
            return string.Format($"{X}, {Y}, {Z}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*NestedClasscs config = new NestedClasscs();
            config.SetConfig("version", "V 5.0");
            config.SetConfig("Size", "655,324 KB");

            Console.WriteLine(config.GetConfig("Version"));
            Console.WriteLine(config.GetConfig("Size"));

            config.SetConfig("Version", "V 5.0.1");
            Console.WriteLine(config.GetConfig("Version"));
            Console.WriteLine();

            Console.WriteLine($"{3}^2 : {3.Square()}");
            Console.WriteLine($"{3}^{4} : {3.Power(4)}");
            Console.WriteLine($"{2}^{10} : {2.Power(10)}");
            Console.WriteLine();

            string hello = "Hello";
            Console.WriteLine(hello.Append(", World"));*/

            Point3D p3d1;
            p3d1.X = 10;
            p3d1.Y = 20;
            p3d1.Z = 40;

            Console.WriteLine(p3d1.ToString());

            Point3D p3d2 = new Point3D(100, 200, 300);
            Point3D p3d3 = p3d2;
            p3d3.Z = 400;

            Console.WriteLine(p3d2.ToString());
            Console.WriteLine(p3d3.ToString());
        }
    }
}
