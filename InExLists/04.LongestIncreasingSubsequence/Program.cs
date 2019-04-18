using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> output = new List<int>();
            int[] len = new int[input.Count];
            int[] temp = new int[input.Count];
            int maxLenghtOfTheSequence = 0;
            int lastIndex = -1;
            for (int index = 0; index < input.Count; index++)
            {
                len[index] = 1;
                temp[index] = -1;
                for (int curr = 0; curr < index; curr++)
                {
                    if(input[index] > input[curr] && len[index] <= len[curr])
                    {
                        len[index] = 1 + len[curr];
                        temp[index] = curr;
                    }
                }
                if(len[index] > maxLenghtOfTheSequence)
                {
                    maxLenghtOfTheSequence = len[index];
                    lastIndex = index;
                }
            }
            for (int index = 0; index < maxLenghtOfTheSequence; index++)
            {
                output.Add(input[lastIndex]);
                lastIndex = temp[lastIndex];
            }
            output.Reverse();
            Console.WriteLine(string.Join(" ", output));            
        }
    }
}
