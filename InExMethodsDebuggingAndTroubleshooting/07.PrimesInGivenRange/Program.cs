using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int startOfTheRange = int.Parse(Console.ReadLine());
            int endOfTheRange = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(", ", GetPrimesInTheRange(startOfTheRange, endOfTheRange)));

        }
        static List<int> GetPrimesInTheRange(int startOfTheRange, int endOfTheRange)
        {
            List<int> database = new List<int>();
            if(endOfTheRange < startOfTheRange)
            {
                return database;
            }
            for (int currentNumber = startOfTheRange; currentNumber <= endOfTheRange; currentNumber++)
            {
                int squareRootNumber = (int)Math.Sqrt(currentNumber);
                
                if (currentNumber < 2)
                {
                    continue; 
                }
                else if(currentNumber > 2)
                {
                    bool isPrime = true;
                    for (int index = 2; index <= squareRootNumber; index++)
                    {
                        if(currentNumber % index == 0)
                        {
                            isPrime = false;
                        }
                    }
                    if (isPrime)
                    {
                        database.Add(currentNumber);
                    }
                }
                else
                {
                    database.Add(currentNumber);
                }
            }

            return database;
        }
    }
}
