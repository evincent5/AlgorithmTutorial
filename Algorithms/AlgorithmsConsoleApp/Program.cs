using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsConsoleApp
{
     class Program : IComparable
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 9, 5, 20, 4, 3, 84, 56, 1, 8, 0 };

            //List<int> numbers = new List<int>();
            //numbers.Add(20);
            //numbers.Add(2);
            //numbers.Add(56);
            //numbers.Add(84);
            //numbers.Add(451);
            //numbers.Add(200);
            //numbers.Add(57);
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(45);
            //numbers.Add(8);
            //numbers.Add(4);
            //numbers.Add(1);

            //numbers.Sort();

            foreach (int number in numbers)
            //    //for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("The new Array: ");
            //SelectionSort.Selection(numbers);
            InsertionSort.InsertionSorter(numbers);
            //MergeSorter.DoMergeSort(numbers);
            //BubbleSort.DoBubbleSort(numbers);
            foreach (int number in numbers)
            //    //for (int i = 0; i < numbers.Length; i++)
            {
                //        //    Console.Write(numbers[i]+ " ");
                Console.Write(number + " ");

            }
            Console.ReadLine();
            //Console.Write(numbers.Average());

            Console.ReadLine();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        //public static void Main(string[] args)
        //{
        //    string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H" };
        //    letters.DoFisherYatesShuffle();
        //    foreach(string letter in letters)
        //    {
        //        Console.Write(letter + " ");
        //    }
        //    Console.ReadLine();

        //}
    }
}

