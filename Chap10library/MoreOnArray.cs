using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10library
{
    public class MoreOnArray
    {
        private static bool CheckPassed(int score)
        {
            return score >= 60;
        }

        private static void Print(int value)
        {
            Console.WriteLine($"{value}");
        }
        public void exam()
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };

            foreach (int score in scores)
            {
                Console.WriteLine($"{score}");
            }
            Console.WriteLine();

            Array.Sort(scores); // 배열 정렬
            Array.ForEach<int>(scores, new Action<int>(Print)); //Print 수행
            Console.WriteLine();

            Console.WriteLine($"Number of dimensions : {scores.Rank}"); // 배열의 차원 반환

            Console.WriteLine($"BinarySearch: 81 is at " + $"{Array.BinarySearch<int>(scores, 81)}"); //조건에 해당하는 이진 탐색

            Console.WriteLine($"Linear Search: 90 is at " + $"{Array.IndexOf(scores, 90)}"); //조건에 해당하는 인덱스 값 찾기

            Console.WriteLine($"Everyone passed ? : " + $"{Array.TrueForAll<int>(scores, CheckPassed)}");

            int index = Array.FindIndex<int>(scores, (score) => score < 60); // 60점 미만인 인덱스 찾기
            scores[index] = 61;
            Console.WriteLine($"Everyone passed ? : " + $"{Array.TrueForAll<int>(scores, CheckPassed)}");

            Console.WriteLine("Old length of scores : "+ $"{scores.GetLength(0)}");

            Array.Resize<int>(ref scores, 10);
            Console.WriteLine($"New length of scores : {scores.Length}");

            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            Array.Clear(scores, 3, 7);
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            int[] sliced = new int[3];
            Array.Copy(scores, 0, sliced, 0, 3);
            Array.ForEach<int>(sliced, new Action<int>(Print));
            Console.WriteLine();
        }
    }
}
