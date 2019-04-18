using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.FastPrimeChecker_Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            
            for (int currentNumber = 2; currentNumber <= input; currentNumber++)
            {
                bool isPrime = true;
                for (int index = 2; index <= Math.Sqrt(currentNumber); index++)
                {
                    if (currentNumber % index == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNumber} -> {isPrime}");
            }
        }
    }
}
