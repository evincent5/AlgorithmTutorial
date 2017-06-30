using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsConsoleApp
{
    public static class MergeSorter
    {
        public static void DoMergeSort( int[] numbers)
        {
            var sortednumbers = MergeSort(numbers);
            for (int i = 0; i < sortednumbers.Length; i++)
            {
                numbers[i] = sortednumbers[i];
            }
            
        }
        private static int[] MergeSort(int[] numbers)
        {
            if (numbers.Length <= 1) return numbers; // base case

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            Divide(numbers, left, right);

            left = MergeSortList(left);
            right = MergeSortList(right);

            return Merge(left, right);
        }
        private static List<int> MergeSortList(List<int> list)
        {
            return MergeSort(list.ToArray()).ToList();
        }
        private static void Divide(int[] numbers, List<int> left, List<int> right)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i.IsOdd())
                    left.Add(numbers[i]);
                else
                    right.Add(numbers[i]);
            }
        }

        private static int[] Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            //while (NotEmpty(left) && NotEmpty(right))
                while (left.Any() && right.Any())

                    MoveSmallerValueInLeftOrRightToResult(left, right, result);

            MoveRemainingValuesFromSourceToResult(left, result);
            MoveRemainingValuesFromSourceToResult(right, result);

            return result.ToArray();
        }

        private static bool NotEmpty(List<int> list)
        {
            return list.Count > 0;
        }

        private static void MoveSmallerValueInLeftOrRightToResult(List<int> left, List<int> right, List<int> result)
        {
            if (left.First() <= right.First())
            {
                MoveValueFromSourceToResult(left, result);
            }
            else
            {
                MoveValueFromSourceToResult(right, result);
            }
        }

        private static void MoveValueFromSourceToResult(List<int> list, List<int> result)
        {
            result.Add(list.First());
            list.RemoveAt(0);
        }
        private static void MoveRemainingValuesFromSourceToResult(List<int> left, List<int> result)
        {
            //while (NotEmpty(left)))
                while (left.Any())
                    MoveValueFromSourceToResult(left, result);
        }

    }
}
