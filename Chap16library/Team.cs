//Team.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap16library
{
    public class Team : Attribute
    {
        private string name;
        private string location;
        public Team()
        {
            name = ""; location = "";
        }

        public Team(string name, string location)
        {
            this.name = name;
            this.location = location;
        }
       
        public void Print()
        {
            Console.WriteLine($"{name}, {location}");
            Console.WriteLine();
        }

        [Test]
        public string T_Record()
        {
            Console.WriteLine("Win : 16, Draw : 8, Lose : 11");
            Console.WriteLine();
            return "[Win] : 16 / [Draw] : 8 / [Lose] : 11";
        }
        [Test]
        public string T_Info()
        {
            Console.WriteLine("Owner : Joe Lewis, Coach : Vacant");
            Console.WriteLine();
            return "[Owner] : Joe Lewis / [Coach] : Vacant";
        }

        [Test]
        public string Test_T(string name, string location)
        {
            this.name = name;
            this.location = location;

            return "[Test_T] : " + name + " / " + location;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }
    }
}
