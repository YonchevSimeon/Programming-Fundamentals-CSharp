using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            string shorterNumber = (firstNumber.Length <= secondNumber.Length) ? firstNumber : secondNumber;
            string longerNumber = (firstNumber.Length > secondNumber.Length) ? firstNumber : secondNumber;

            string output = string.Empty;

            int remainder = 0;
            int currentSum = 0;
            int shorterNumberIndex = shorterNumber.Length - 1;
            int longerNumberIndex = longerNumber.Length - 1;
            while(shorterNumberIndex >= 0)
            {
                currentSum = (shorterNumber[shorterNumberIndex] - '0') + (longerNumber[longerNumberIndex] - '0') + remainder;
                if(currentSum > 9)
                {
                    remainder = 1;
                    currentSum %= 10;
                }
                else
                    remainder = 0;
                output = currentSum.ToString() + output;
                shorterNumberIndex--;
                longerNumberIndex--;
            }
            while(longerNumberIndex >= 0)
            {
                currentSum = (longerNumber[longerNumberIndex] - '0') + remainder;
                if (currentSum > 9)
                {
                    remainder = 1;
                    currentSum %= 10;
                }
                else
                    remainder = 0;
                output = currentSum.ToString() + output;
                longerNumberIndex--;
            }
            if(remainder > 0)
            {
                output = "1" + output;
            }
            output = output.TrimStart('0');
            Console.WriteLine(output);
        }
    }
}
