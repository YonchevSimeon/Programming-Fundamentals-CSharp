using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> database = new Dictionary<int, int>();
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int index = 0; index < input.Length; index++)
            {
                if (!database.ContainsKey(input[index]))
                {
                    database[input[index]] = 0;
                }
                database[input[index]]++;
            }
            foreach (KeyValuePair<int, int> number in database.OrderBy(x => -x.Value))
            {
                Console.WriteLine(number.Key);
                return;
            }
        }
    }
}
