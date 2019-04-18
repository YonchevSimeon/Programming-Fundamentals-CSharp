using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputTokens = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            double totalSum = 0.0;
            for (int currentPair = 0; currentPair < inputTokens.Length; currentPair++)
            {
                int frontCharValue = (inputTokens[currentPair][0]);
                int backCharValue = (inputTokens[currentPair][inputTokens[currentPair].Length - 1]);
                inputTokens[currentPair] = inputTokens[currentPair].Remove(0, 1);
                inputTokens[currentPair] = inputTokens[currentPair].Remove(inputTokens[currentPair].Length - 1, 1);
                double currentNumber = double.Parse(inputTokens[currentPair]);
                if(frontCharValue >= 65 && frontCharValue <= 90)
                {
                    currentNumber /= frontCharValue - 64;
                }
                else
                {
                    currentNumber *= frontCharValue - 96;
                }
                if(backCharValue >= 65 && backCharValue <= 90)
                {
                    currentNumber -= backCharValue - 64;
                }
                else
                {
                    currentNumber += backCharValue - 96;
                }
                totalSum += currentNumber;
            }
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
