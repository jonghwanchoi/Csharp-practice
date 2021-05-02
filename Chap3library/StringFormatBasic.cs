using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chap3library
{
    public class StringFormatBasic
    {
        public void exam()
        {
            string fmt = "{0,-20}{1,-15}{2, 30}";
            string interpol = "ABC";

            string result = string.Format($"{interpol}");

            WriteLine(interpol);
            WriteLine(fmt, "Publisher", "Author", "Title");
            WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            WriteLine(fmt, "Hanbit", "Sanghyun Park", "This is C#");
            WriteLine(fmt, "Prentice Hall", "K&R", "The C Programming Language");
        }
    }
}
