using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.Factorial
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
            Console.WriteLine(factorial);
        }
    }
}
