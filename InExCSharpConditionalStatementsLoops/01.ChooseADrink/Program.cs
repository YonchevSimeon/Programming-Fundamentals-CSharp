using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> database = new Dictionary<string, string>();
            database["Athlete"] = "Water";
            database["Businessman"] = "Coffee";
            database["Businesswoman"] = "Coffee";
            database["SoftUni Student"] = "Beer";
            string profession = Console.ReadLine();
            if (database.ContainsKey(profession))
            {
                Console.WriteLine(database[profession]);
            }
            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
