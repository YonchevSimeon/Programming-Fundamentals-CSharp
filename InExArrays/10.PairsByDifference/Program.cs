using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int pairsOfElementsWithDifference = 0;
            for (int currentIndex = 0; currentIndex < input.Length; currentIndex++)
            {
                for (int innerIndex = currentIndex; innerIndex < input.Length; innerIndex++)
                {
                    if(Math.Abs(input[currentIndex] - input[innerIndex]) == difference)
                    {
                        pairsOfElementsWithDifference++;
                    }
                }
            }
            Console.WriteLine(pairsOfElementsWithDifference);
        }
    }
}
