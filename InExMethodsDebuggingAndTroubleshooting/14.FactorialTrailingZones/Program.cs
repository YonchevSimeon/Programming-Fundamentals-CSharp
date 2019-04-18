using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.FactorialTrailingZones
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputFactorial = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int currentNumber = 1; currentNumber <= inputFactorial; currentNumber++)
            {
                factorial *= currentNumber;
            }
            Console.WriteLine(PrintTrailingZeroes(factorial));
        }

        private static int PrintTrailingZeroes(BigInteger factorial)
        {
            List<int> listOfIntegers = factorial.ToString().ToCharArray().Select(x => Convert.ToInt32(x - '0')).ToList();
            int trailingZeroesCount = 0;
            for (int index = listOfIntegers.Count - 1; index >= 0; index--)
            {
                if(listOfIntegers[index] == 0)
                {
                    trailingZeroesCount++;
                }
                else
                {
                    return trailingZeroesCount;
                }
            }
            return trailingZeroesCount;
        }
    }
}
