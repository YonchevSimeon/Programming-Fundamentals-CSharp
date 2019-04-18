using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> bombWithPower = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int specialBombNumber = bombWithPower[0];
            int bombPower = bombWithPower[1];
            while (input.Contains(specialBombNumber))
            {
                int currentIndexOfBombNumber = input.IndexOf(specialBombNumber);
                int removingCounter = 0;
                for (int index = currentIndexOfBombNumber - 1; index >= 0; index--)
                {
                    removingCounter++;
                    if(removingCounter <= bombPower && index >= 0)
                    {
                        input.RemoveAt(index);
                    }
                }
                currentIndexOfBombNumber = input.IndexOf(specialBombNumber);
                removingCounter = 0;
                for (int index = currentIndexOfBombNumber + 1; index < input.Count; index++)
                {
                    removingCounter++;
                    if(removingCounter <= bombPower && index <= input.Count - 1)
                    {
                        input.RemoveAt(index);
                        index--;
                    }
                }
                input.Remove(specialBombNumber);
            }
            Console.WriteLine(input.Sum());
        }
    }
}
