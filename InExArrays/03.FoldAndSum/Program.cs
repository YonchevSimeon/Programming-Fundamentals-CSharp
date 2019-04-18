using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int fourthFromTheArray = input.Length / 4;
            List<int> topSequence = new List<int>();
            List<int> botSequence = new List<int>();
            int[] output = new int[2 * fourthFromTheArray];
            for (int index = fourthFromTheArray - 1; index >= 0; index--)
            {
                topSequence.Add(input[index]);
            }
            for (int index = input.Length - 1; index >= 3 * fourthFromTheArray; index--)
            {
                topSequence.Add(input[index]);
            }
            for (int index = fourthFromTheArray; index < 3 * fourthFromTheArray; index++)
            {
                botSequence.Add(input[index]);
            }
            for (int index = 0; index < topSequence.Count; index++)
            {
                output[index] = topSequence[index] + botSequence[index];
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
