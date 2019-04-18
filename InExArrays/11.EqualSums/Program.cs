using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int index = 0; index < input.Length; index++)
            {
                int leftPartSum = GetLeftPartSum(input, index);
                int rightPartSum = GetRightPartSum(input, index);
                if(leftPartSum == rightPartSum)
                {
                    Console.WriteLine(index);
                    return;
                }
            }
            Console.WriteLine("no");
        }

        private static int GetRightPartSum(int[] input, int index)
        {
            int rightPartSum = 0;
            for (int currentIndex = index + 1; currentIndex < input.Length; currentIndex++)
            {
                rightPartSum += input[currentIndex];
            }
            return rightPartSum;
        }

        private static int GetLeftPartSum(int[] input, int index)
        {
            int leftPartSum = 0;
            for (int currentIndex = 0; currentIndex < index; currentIndex++)
            {
                leftPartSum += input[currentIndex];
            }
            return leftPartSum;
        }
    }
}
