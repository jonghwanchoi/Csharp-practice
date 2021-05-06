using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10library
{
    public class Slices
    {
        static void PrintArray(System.Array array)
        {
            foreach (var e in array)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
        }

        public  void exam()
        {
            char[] array = new char['Z' - 'A' + 1];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (char)('A' + i);
            }

            PrintArray(array[..]); // 배열 전체
            PrintArray(array[5..]); // 5번째부터 끝까지

            Range range_5_10 = 5..10;
            PrintArray(array[range_5_10]); //5번째부터 9까지(10-1)

            Index last = ^0;
            Range range_5_last = 5..last;
            PrintArray(array[range_5_last]); // 5번째부터 끝까지

            PrintArray(array[^4..^1]); //끝(^)에서 4번째부터 끝에서 2번째까지 (반대로 앞에 인덱스가 +1? 되는듯)ㄴ
        }
    }

}
