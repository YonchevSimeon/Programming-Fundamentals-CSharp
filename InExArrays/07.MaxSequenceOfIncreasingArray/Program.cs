using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MaxSequenceOfIncreasingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int maxInreasingElementsCount = 1;
            int currentMaxIncreasingElementsCount = 1;
            int endIndex = 0;
            for (int index = 0; index < input.Length - 1; index++)
            {
                if(input[index] < input[index + 1])
                {
                    currentMaxIncreasingElementsCount++;
                    
                }
                if(currentMaxIncreasingElementsCount > maxInreasingElementsCount)
                {
                    maxInreasingElementsCount = currentMaxIncreasingElementsCount;
                    endIndex = index + 1;
                }
                if(input[index] >= input[index + 1])
                {
                    currentMaxIncreasingElementsCount = 1;
                }

            }
            int[] output = new int[maxInreasingElementsCount];
            int outputIndex = 0;
            for (int index = endIndex - maxInreasingElementsCount + 1; index <= endIndex; index++)
            {
                output[outputIndex] = input[index];
                outputIndex++;
            }
            Console.WriteLine(string.Join(" ", output));
                
        }
    }
}
