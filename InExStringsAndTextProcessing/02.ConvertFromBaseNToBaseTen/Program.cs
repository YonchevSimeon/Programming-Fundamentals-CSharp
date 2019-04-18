using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _02.ConvertFromBaseNToBaseTen
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputTokens = Console.ReadLine().Split(' ');
            long fromBase = long.Parse(inputTokens[0]);
            string numberToConvert = inputTokens[1];
            BigInteger convertedNumber = 0;
            for (int index = 0; index < numberToConvert.Length; index++)
            {
                BigInteger currentNumber = BigInteger.Parse(numberToConvert[index].ToString());
                convertedNumber += BigInteger.Multiply(currentNumber, BigInteger.Pow(fromBase, numberToConvert.Length - 1 - index));
            }
            Console.WriteLine(convertedNumber);
        }
    }
}
