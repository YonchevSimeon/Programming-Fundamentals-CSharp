using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            if(input.Count == 1)
            {
                Console.WriteLine(input[0]);
                return;
            }
            List<int> output = new List<int>();
            List<int> current = new List<int>();
            current.Add(input[0]);
            for (int index = 0; index < input.Count - 1; index++)
            {
                if (current.Count > output.Count)
                {
                    output.Clear();
                    output.AddRange(current);
                }
                if (input[index] == input[index + 1])
                {
                    current.Add(input[index]);
                }
                else
                {
                    current.Clear();
                    current.Add(input[index + 1]);
                }
                if (current.Count > output.Count)
                {
                    output.Clear();
                    output.AddRange(current);
                }

            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
