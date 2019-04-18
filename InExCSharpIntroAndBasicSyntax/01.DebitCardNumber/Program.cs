using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> debitCard = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                debitCard.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"{debitCard[0]:d4} {debitCard[1]:d4} {debitCard[2]:d4} {debitCard[3]:d4}");
        }
    }
}
