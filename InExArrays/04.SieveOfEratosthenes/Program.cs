using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] inputTokens = new int[input + 1];
            List<int> primeNumbers = new List<int>();
            for (int index = 0; index < input + 1; index++)
            {
                inputTokens[index] = index;
            }
            for (int index = 2; index < inputTokens.Length; index++)
            {
                bool isPrime = true;
                for (int currentIndex = 2; currentIndex < inputTokens.Length; currentIndex++)
                {
                    if (currentIndex != index && index % currentIndex == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeNumbers.Add(inputTokens[index]);
                }
            }
            Console.WriteLine(string.Join(" ", primeNumbers));
        }
    }
}
