using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());
            double kcal = energyContent / 100.0;
            double sugars = volume / 100.0;
            Console.WriteLine($"{volume}ml {productName}:");
            Console.WriteLine($"{kcal * volume}kcal, {sugars * sugarContent}g sugars");
        }
    }
}
