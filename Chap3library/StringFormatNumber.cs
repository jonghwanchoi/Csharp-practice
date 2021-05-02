using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chap3library
{
    public class StringFormatNumber
    {
        public void exam()
        {
            WriteLine("10진수: {0:D}", 123);
            WriteLine("10진수: {0:D5}", 123);
            
            WriteLine("16진수: 0x{0:x}", 0xFF1234);
            WriteLine("16진수: 0x{0:x8}", 0xFF1234);
            
            WriteLine("숫자: {0:N}", 123456789);
            WriteLine("숫자: {0:N0}", 123456789);
            
            WriteLine("고정소수점: {0:F}", 123.45);
            WriteLine("고정소수점: {0:F5}", 123.456);

            WriteLine("공학: {0:E}", 123.456789);
        }
    }
}
