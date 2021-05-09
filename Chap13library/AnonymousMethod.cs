using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap13library
{
    public delegate int Compare1(int a, int b);
    public class AnonymousMethod
    {
        static public void BubbleSort(int[] DataSet, Compare1 Comparer)
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            for (i = 0; i < DataSet.Length-1; i++)
            {
                for (j = 0; j < DataSet.Length-(i+1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j+1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }
    }
}
