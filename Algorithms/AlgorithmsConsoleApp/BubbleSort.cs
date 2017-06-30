using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsConsoleApp
{
    public static class BubbleSort
    {
        public static void DoBubbleSort(int[] numbers)
        {
            for (int i = numbers.Length-1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    //Swapper.SwapValuesAtIndices(numbers, j, j+1);
                    numbers.SwapValuesAtIndices(j, j + 1);
                }
            }
        }

    }
}
