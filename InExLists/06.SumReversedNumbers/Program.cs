using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            for (int index = 0; index < input.Count; index++)
            {
                char[] arr = input[index].ToCharArray();
                Array.Reverse(arr);
                input[index] = new string(arr);
            }
            List<int> output = input.Select(int.Parse).ToList();
            Console.WriteLine(output.Sum());
        }
    }
}
