using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int combinationsCounter = 0;

            int sum = 0;

            for (int first = n; first >= 1; first--)
            {
                for (int second = 1; second <= m; second++)
                {
                    sum += 3 * (first * second);
                    combinationsCounter++;
                    if (sum >= maxSum)
                    {
                        Console.WriteLine($"{combinationsCounter} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSum}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combinationsCounter} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
