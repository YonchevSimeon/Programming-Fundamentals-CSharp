using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            firstNumber = GetMax(firstNumber, secondNumber);
            firstNumber = GetMax(firstNumber, thirdNumber);
            Console.WriteLine(firstNumber);
        }
        static int GetMax(int a, int b)
        {
            if(a < b)
            {
                a = b;
            }
            return a;
        }
    }
}
