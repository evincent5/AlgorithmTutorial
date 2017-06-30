using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsConsoleApp
{
    public static class FisherYates
    {
        private static Random randomNumber = new Random();

        public static void DoFisherYatesShuffle(this object[] objects)
        {
            for (int i = objects.Length-1; i > 0; i--)
            {
                //int j = GetNextRandom(i);
                Swapper.SwapValuesAtIndices(objects, i, GetNextRandom(i));
            }
        }

        private static int GetNextRandom( int i)
        {
            return randomNumber.Next(i + 1);
        }
    }
}
