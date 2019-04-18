using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hall> halls = new List<Hall>();
            halls.Add(new Hall { Type = "Small Hall", Price = 2500});
            halls.Add(new Hall { Type = "Terrace", Price = 5000});
            halls.Add(new Hall { Type = "Great Hall", Price = 7500});

            List<Table> tables = new List<Table>();
            tables.Add(new Table { Type = "Normal", Price = 500, Discount = 0.95});
            tables.Add(new Table { Type = "Gold", Price = 750, Discount = 0.90});
            tables.Add(new Table { Type = "Platinum", Price = 1000, Discount = 0.85});

            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double pricePerPerson;
            string offer = string.Empty;

            int index = tables.FindIndex(x => x.Type == package);

            if (groupSize <= 50)
            {
                pricePerPerson = (halls[0].Price + tables[index].Price) * tables[index].Discount / groupSize;
                offer = halls[0].Type;
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                pricePerPerson = (halls[1].Price + tables[index].Price) * tables[index].Discount / groupSize;
                offer = halls[1].Type;
            }
            else if(groupSize > 100 && groupSize <= 120)
            {
                pricePerPerson = (halls[2].Price + tables[index].Price) * tables[index].Discount / groupSize;
                offer = halls[2].Type;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            Console.WriteLine($"We can offer you the {offer}");
            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
        }
    }
    class Hall
    {
        public string Type { get; set; }
        public int Price { get; set; }
    }
    class Table
    {
        public string Type { get; set; }
        public int Price { get; set; }
        public double Discount { get; set; }
    }
}
