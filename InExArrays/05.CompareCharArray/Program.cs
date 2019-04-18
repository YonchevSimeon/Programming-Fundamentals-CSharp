using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArray
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] topArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] botArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            if(topArray.Length > botArray.Length)
            {
                Console.WriteLine(string.Join("", botArray));
                Console.WriteLine(string.Join("", topArray));
            }
            else if(topArray.Length < botArray.Length)
            {
                Console.WriteLine(string.Join("", topArray));
                Console.WriteLine(string.Join("", botArray));
            }
            else
            {
                int topArraySum = GetTopArraySum(topArray);
                int botArraySum = GetBotArraySum(botArray);
                if(topArraySum > botArraySum)
                {
                    Console.WriteLine(string.Join("", botArray));
                    Console.WriteLine(string.Join("", topArray));
                }
                else
                {
                    Console.WriteLine(string.Join("", topArray));
                    Console.WriteLine(string.Join("", botArray));
                }
            }

        }

        private static int GetBotArraySum(char[] botArray)
        {
            int sum = 0;
            for (int index = 0; index < botArray.Length; index++)
            {
                sum += Convert.ToInt32(botArray[index]);
            }
            return sum;
        }

        private static int GetTopArraySum(char[] topArray)
        {
            int sum = 0;
            for (int index = 0; index < topArray.Length; index++)
            {
                sum += Convert.ToInt32(topArray[index]);
            }
            return sum;
        }
    }
}
