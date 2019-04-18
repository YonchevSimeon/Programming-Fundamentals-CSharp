using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotatingCount = int.Parse(Console.ReadLine());
            int[] outputSum = new int[input.Length];
            for (int currentRotation = 0; currentRotation < rotatingCount; currentRotation++)
            {
                input = RotateTheArrayAndReturnIt(input);
                for (int index = 0; index < input.Length; index++)
                {
                    outputSum[index] += input[index];
                }
            }
            Console.WriteLine(string.Join(" ", outputSum));

        }

        private static int[] RotateTheArrayAndReturnIt(int[] input)
        {
            int tempLastIndexValue = input[input.Length - 1];
            for (int index = input.Length - 1; index >= 1; index--)
            {
                input[index] = input[index - 1];
            }
            input[0] = tempLastIndexValue;
            return input;
        }
    }
}
