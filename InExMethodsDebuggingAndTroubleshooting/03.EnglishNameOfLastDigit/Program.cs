using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnglishNameOfLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            long digit = Math.Abs(input % 10);
            GetLastDigitEnglishName(digit);
        }
        static void GetLastDigitEnglishName(long digit)
        {
            string[] data = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Console.WriteLine(data[digit]);
        }
    }
}
