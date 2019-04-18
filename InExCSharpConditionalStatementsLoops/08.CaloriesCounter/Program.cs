using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ingredients = new Dictionary<string, int>();
            ingredients["cheese"] = 500;
            ingredients["tomato sauce"] = 150;
            ingredients["salami"] = 600;
            ingredients["pepper"] = 50;

            //List<string> addedIngredients = new List<string>();

            int calories = 0;

            int input = int.Parse(Console.ReadLine());

            for (int index = 0; index < input; index++)
            {
                string currentIngredient = Console.ReadLine().ToLower();
                if (ingredients.ContainsKey(currentIngredient))
                {
                    calories += ingredients[currentIngredient];
                }
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
