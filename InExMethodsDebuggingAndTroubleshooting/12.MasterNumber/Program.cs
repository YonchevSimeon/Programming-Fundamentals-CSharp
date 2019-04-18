using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MasterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int currentNumber = 1; currentNumber <= input; currentNumber++)
            {
                if (CheckCurrentNumber(currentNumber))
                {
                    Console.WriteLine(currentNumber);
                }
            }
        }

        private static bool CheckCurrentNumber(int currentNumber)
        {
            bool isMasterNumber = true;
            if (!isSymmetric(currentNumber))
            {
                isMasterNumber = false;
            }
            if (!isDivisibleBySeven(currentNumber))
            {
                isMasterNumber = false;
            }
            if (!doesItContainsAtleastOneEvenDigit(currentNumber))
            {
                isMasterNumber = false;
            }
            return isMasterNumber;
        }

        private static bool doesItContainsAtleastOneEvenDigit(int currentNumber)
        {
            string currentNum = currentNumber.ToString();
            for (int index = 0; index < currentNum.Length; index++)
            {
                if(currentNum[index] % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool isDivisibleBySeven(int currentNumber)
        {
            int currentNumSum = 0;
            while(currentNumber > 0)
            {
                int currentDigit = currentNumber % 10;
                currentNumSum += currentDigit;
                currentNumber /= 10;
            }
            if(currentNumSum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        private static bool isSymmetric(int currentNumber)
        {
            string currentNum = currentNumber.ToString();
            for (int index = 0; index <= currentNum.Length / 2; index++)
            {
                if (currentNum[index] != currentNum[currentNum.Length - 1 - index])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
