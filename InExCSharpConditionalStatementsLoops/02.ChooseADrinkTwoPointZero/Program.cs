using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChooseADrinkTwoPointZero
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> database = new List<Person>();
            database.Add(new Person { Profession = "Athlete", Drink = "Water", Price = 0.70 });
            database.Add(new Person { Profession = "Businessman", Drink = "Coffee", Price = 1.00 });
            database.Add(new Person { Profession = "Businesswoman", Drink = "Coffee", Price = 1.00 });
            database.Add(new Person { Profession = "SoftUni Student", Drink = "Beer", Price = 1.70 });            
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            if (database.Any(x => x.Profession == profession))
            {
                int index = database.IndexOf(database.Single(x => x.Profession == profession));
                Console.WriteLine($"The {profession} has to pay {quantity * database[index].Price:f2}.");
            }
            else
            {
                Console.WriteLine($"The {profession} has to pay {quantity * 1.20:f2}.");
            }
        }
    }
    class Person
    {
        public string Profession { get; set; }
        public string Drink { get; set; }
        public double Price { get; set; }
    }
}
