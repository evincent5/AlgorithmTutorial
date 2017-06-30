using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsConsoleApp
{
     public static class InsertionSort
    {
        //public static void InsertionSorter(int[] numbers)
        //{
        //    for (int i = 1; i < numbers.Length; i++)
        //    {
        //        for (int j = i; j > 0 && numbers[j - 1] > numbers[j]; j--)
        //        {
        //            //Swapper.SwapValuesAtIndices(numbers, j, j - 1);
        //            numbers.SwapValuesAtIndices(j, j - 1);
        //        }

        //    }
        //}
        public static void InsertionSorter(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                //int imin = i;
                for (int j = i; j > 0; j--)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        //imin = j;
                        Swapper.SwapValuesAtIndices(numbers, j, j - 1);
                    }
                }
            }
        }
    }
}
