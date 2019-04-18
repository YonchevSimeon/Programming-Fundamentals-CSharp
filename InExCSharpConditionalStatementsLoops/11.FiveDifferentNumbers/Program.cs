using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FiveDifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            bool thereAreNumbers = false;
            for (int first = a; first <= b; first++)
            {
                for (int second = a; second <= b; second++)
                {
                    for (int third = a; third <= b; third++)
                    {
                        for (int fourth = a; fourth <= b; fourth++)
                        {
                            for (int fifth = a; fifth <= b; fifth++)
                            {
                                if(a <= first &&
                                   first < second &&
                                   second < third &&
                                   third < fourth &&
                                   fourth < fifth &&
                                   fifth <= b)
                                {
                                    thereAreNumbers = true;
                                    Console.WriteLine($"{first} {second} {third} {fourth} {fifth}");
                                }
                            }
                        }
                    }
                }
            }
            if (!thereAreNumbers)
            {
                Console.WriteLine("No");
            }
        }
    }
}
