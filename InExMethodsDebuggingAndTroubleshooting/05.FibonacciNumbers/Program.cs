using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintFibonacciNumber(input);
        }

        private static void PrintFibonacciNumber(int input)
        {
            int a = 0;
            int b = 1;
            for (int index = 0; index < input; index++)
            {
                int temp = a;
                a = b;
                b = temp + a;
            }
            Console.WriteLine(b);
        }
    }
}
