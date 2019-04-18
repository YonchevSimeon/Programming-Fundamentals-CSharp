using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintHelloName(input);
        }

        private static void PrintHelloName(string input)
        {
            Console.WriteLine($"Hello, {input}!");
        }
    }
}
