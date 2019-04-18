using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Trim();
            int multiplyDigit = int.Parse(Console.ReadLine());
            int remainder = 0;
            int currentSum = 0;
            string output = string.Empty;
            
            for (int currentDigit = input.Length - 1; currentDigit >= 0; currentDigit--)
            {
                if(input[currentDigit] != '0')
                {
                    currentSum = ((input[currentDigit] - '0') * multiplyDigit) + remainder;
                    if(currentSum > 9)
                    {
                        remainder = currentSum / 10;
                        currentSum %= 10;
                    }
                    else
                    {
                        remainder = 0;
                    }
                    output = currentSum + output;
                }
                else
                {
                    output = remainder + output;
                    remainder = 0;
                }
            }
            output = remainder + output;
            output = output.TrimStart('0');
            Console.WriteLine(output.Length > 0 ? output : "0");
            
        }
    }
}
