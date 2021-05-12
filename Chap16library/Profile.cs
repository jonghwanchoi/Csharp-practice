using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Chap16library
{
    public class Profile
    {
        private string name;
        private string phone;
        public Profile()
        {
            name = ""; phone = "";
        }

        public Profile(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }

        
        public void Print()
        {
            Console.WriteLine($"{name}, {phone}");
            Console.WriteLine();
        }

        [Test]
        public string Record()
        {
            Console.WriteLine("Goals : 17, Assists : 10");
            Console.WriteLine();

            return "[Goals] : 17 / [Assists] : 10";
        }

        [Test]
        public string Info()
        {
            Console.WriteLine("Age : 30, BackNumber : 7");
            Console.WriteLine();

            return "[Age] : 30 / [BackNumber] : 7";
        }
     
        [Test]
        public string Test(string name, string phone)
        {
            this.name = name;
            this.phone = phone;

            return "[Test] : " + name + " / " + phone;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }

    public class Test : System.Attribute
    {
        public Test()
        {

        }
    }
}
