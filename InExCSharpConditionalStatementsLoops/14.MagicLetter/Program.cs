using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>();
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char special = char.Parse(Console.ReadLine());
            for (char first = start; first <= end; first++)
            {
                for (char second = start; second <= end; second++)
                {
                    for (char third = start; third <= end; third++)
                    {
                        if(first != special && second != special && third != special)
                        {
                            data.Add($"{first}{second}{third}");
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", data));
        }
    }
}
