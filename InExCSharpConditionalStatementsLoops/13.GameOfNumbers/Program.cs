using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinationsCounter = 0;
            string output = string.Empty;
            bool found = false;
            for (int first = start; first <= end; first++)
            {
                for (int second = start; second <= end; second++)
                {
                    if (first + second == magicNumber)
                    {
                        found = true;
                        output = $"Number found! {first} + {second} = {magicNumber}";
                    }
                    combinationsCounter++;
                }
            }
            if (found)
            {
                Console.WriteLine(output);
                return;
            }
            Console.WriteLine($"{combinationsCounter} combinations - neither equals {magicNumber}");
        }
    }
}
