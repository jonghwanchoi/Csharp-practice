using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap7library
{
    public class Constructor
    {
        public Constructor() //기본 생성자
        {
            Name = "";
            Color = "";
        }
        public Constructor(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }
        ~Constructor()
        {
            Console.WriteLine($"{Name} : 잘가");
        }

        public string Name;
        public string Color;

        public void exam()
        {
            Console.WriteLine($"{Name} : 짹짹");
        }
    }
}
