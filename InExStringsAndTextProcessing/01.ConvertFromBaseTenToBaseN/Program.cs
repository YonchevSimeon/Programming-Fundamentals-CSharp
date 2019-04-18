using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _01.ConvertFromBaseTenToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "stop")
            {
                string[] inputTokens = input.Split(' ');
                long toBase = long.Parse(inputTokens[0]);
                BigInteger numberToConvert = BigInteger.Parse(inputTokens[1]);
                string convertedNumber = string.Empty;
                while (numberToConvert > 0)
                {
                    convertedNumber = numberToConvert % toBase + convertedNumber;
                    numberToConvert /= toBase;
                }
                Console.WriteLine(convertedNumber);
            }
        }
    }
}
