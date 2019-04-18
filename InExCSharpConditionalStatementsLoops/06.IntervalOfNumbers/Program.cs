using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            if(first < second)
                for (int index = first; index <= second; index++)
                    Console.WriteLine(index);             
            else
                for (int index = second; index <= first; index++)                
                    Console.WriteLine(index);            
        }
    }
}
