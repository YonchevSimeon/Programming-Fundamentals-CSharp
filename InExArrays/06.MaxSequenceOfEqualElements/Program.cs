using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int maxEqualElements = 1;
            int currentMaxEqualElements = 1;
            int currentMaxEqualElementsValue = 0;
            for (int index = 0; index < input.Length - 1; index++)
            {
                if(input[index] == input[index + 1])
                {
                    currentMaxEqualElements++;
                }
                if (currentMaxEqualElements > maxEqualElements)
                {
                    maxEqualElements = currentMaxEqualElements;
                    currentMaxEqualElementsValue = input[index];
                }
                if (input[index] != input[index + 1])
                {
                    currentMaxEqualElements = 1;
                }                
            }
            int[] outputArray = new int[maxEqualElements];
            for (int index = 0; index < outputArray.Length; index++)
            {
                outputArray[index] = currentMaxEqualElementsValue;
            }
            Console.WriteLine(string.Join(" ", outputArray));
        }
    }
}
