using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class Program
    {
        public static string[] firstArray;
        public static string[] secondArray;
        public static int fromLeftToRightCount = 0;
        public static int fromRightToLeftCount = 0;
        static void Main(string[] args)
        {
            firstArray = Console.ReadLine().Split(' ').ToArray();
            secondArray = Console.ReadLine().Split(' ').ToArray();
            fromLeftToRightCount = GetFromLeftToRightCount();
            fromRightToLeftCount = GetFromRightToLeftCount();
            CheckWhichSequnceIsBiggerAndPrintIt();
        }

        private static void CheckWhichSequnceIsBiggerAndPrintIt()
        {
            if(fromLeftToRightCount > fromRightToLeftCount)
            {
                Console.WriteLine(fromLeftToRightCount);
            }
            else
            {
                Console.WriteLine(fromRightToLeftCount);
            }
        }

        private static int GetFromRightToLeftCount()
        {
            while (fromRightToLeftCount < firstArray.Length && fromRightToLeftCount < secondArray.Length)
            {
                if (firstArray[firstArray.Length - fromRightToLeftCount - 1] == secondArray[secondArray.Length - fromRightToLeftCount - 1])
                {
                    fromRightToLeftCount++;
                    continue;
                }
                break;
            }
            return fromRightToLeftCount;
        }

        private static int GetFromLeftToRightCount()
        {
            while (fromLeftToRightCount < firstArray.Length && fromLeftToRightCount < secondArray.Length)
            {
                if (firstArray[fromLeftToRightCount] == secondArray[fromLeftToRightCount])
                {
                    fromLeftToRightCount++;
                    continue;
                }
                break;
            }
            return fromLeftToRightCount;
        }
    }
}
