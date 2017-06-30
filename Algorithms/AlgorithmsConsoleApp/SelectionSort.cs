using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsConsoleApp
{
    public static class SelectionSort
    {
        public static void Selection(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int temp;
                int imin = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[imin])
                    {
                        imin = j;
                    }
                }
                temp = numbers[imin];
                numbers[imin] = numbers[i];
                numbers[i] = temp;
            }
        }
        //public static void Selection(int[] A)
        //{
        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        int min = i;
        //        for (int j = i + 1; j < A.Length; j++)
        //        {
        //            if (A[j] < A[min])
        //                min = j;
        //        }
        //        Swapper.SwapValuesAtIndices(A, min, i);
        //    }
        //}

    }
}
