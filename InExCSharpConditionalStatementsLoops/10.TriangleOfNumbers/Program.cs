using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int index = 1; index <= input; index++)
            {
                PrintLine(index);
            }
        }
        static void PrintLine (int index)
        {
            for (int i = 1; i <= index; i++)
            {
                Console.Write($"{index} ");
            }
            Console.WriteLine();
        }
    }
}
