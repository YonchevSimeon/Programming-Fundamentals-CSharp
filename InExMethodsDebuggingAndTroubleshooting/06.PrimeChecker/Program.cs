using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(input));
        }
        static bool IsPrime(long input)
        {
            int squareRoot = (int)Math.Sqrt(input);
            if (input < 2)
            {
                return false;
            }
            else if (input > 2)
            {
                for (int index = 2; index <= squareRoot; index++)
                {
                    if (input % index == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
