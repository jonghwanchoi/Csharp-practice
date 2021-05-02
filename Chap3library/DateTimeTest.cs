using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Globalization;

namespace Chap3library
{
    
    public class DateTimeTest
    {

        public void exam()
        {
            DateTime dt = new (2021, 04, 15, 16, 47, 33);
            WriteLine("{0}",dt);

            CultureInfo Ciko = new CultureInfo("ko-KR");

            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (dddd)",Ciko));

            CultureInfo CiEo = new CultureInfo("en-US");

            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (dddd)", CiEo));
        }
    }
}
