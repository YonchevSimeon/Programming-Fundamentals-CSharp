using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string firstWord = input[0];
            string secondWord = input[1];
            string longerWord = (firstWord.Length > secondWord.Length) ? firstWord : secondWord;
            string shorterWord = (firstWord.Length < secondWord.Length) ? firstWord : secondWord;
            
            long outputSum = 0;
            int index = 0;
            while(index < shorterWord.Length)
            {
                outputSum += (firstWord[index] * secondWord[index]);
                index++;
            }
            for (int curr = index; curr < longerWord.Length; curr++)
            {
                outputSum += longerWord[curr];
            }
            Console.WriteLine(outputSum);
        }
    }
}
