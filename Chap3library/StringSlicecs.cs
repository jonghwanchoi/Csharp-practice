using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chap3library
{
    public class StringSlicecs
    {
        public void exam()
        {
            string greeting = "Good morning,everyone. ";

            WriteLine(greeting.Substring(5,3)); // "morning"
            WriteLine(greeting.Substring(0)); // "Good"
            WriteLine();

            string[] arr = greeting.Split(
                new string[] { " " , "," }, StringSplitOptions.None);
            WriteLine("Word Count : {0}", arr.Length);

            foreach (string element in arr)
            WriteLine("{0}", element);
        }
    }
}
