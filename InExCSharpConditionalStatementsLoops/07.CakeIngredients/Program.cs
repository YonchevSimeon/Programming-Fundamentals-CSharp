using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> ingredients = new List<string>();
            string input = Console.ReadLine();
            int ingredients = 0;
            while (input != "Bake!")
            {
                //if (!ingredients.Contains(input))
                //{
                //    Console.WriteLine($"Adding ingredient {input}.");
                //}
                ingredients++;
                Console.WriteLine($"Adding ingredient {input}.");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {ingredients} ingredients.");
        }
    }
}
