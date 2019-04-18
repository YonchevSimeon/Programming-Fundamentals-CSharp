using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] inputTokens = Console.ReadLine().ToArray();
            PrintInReversedOrder(inputTokens);
        }
        private static void PrintInReversedOrder(char[] inputTokens)
        {
            Console.WriteLine(string.Join("", inputTokens.Reverse()));
        }
    }
}
