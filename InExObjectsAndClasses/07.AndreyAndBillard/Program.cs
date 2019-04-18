using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.AndreyAndBillard
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> clients = new List<Client>();
            Dictionary<string, decimal> shopProducts = new Dictionary<string, decimal>();
            int numberOfProducts = int.Parse(Console.ReadLine());
            for (int cur = 0; cur < numberOfProducts; cur++)
            {
                string[] currProductPricePair = Console.ReadLine().Split('-');
                string product = currProductPricePair[0];
                decimal price = decimal.Parse(currProductPricePair[1]);
                shopProducts[product] = price;
            }
            string input = Console.ReadLine();
            while (input != "end of clients")
            {
                string[] inputTokens = input.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string name = inputTokens[0];
                string product = inputTokens[1];
                int quantity = int.Parse(inputTokens[2]);
                if (shopProducts.ContainsKey(product))
                {
                    Client currentClient = Client.ReadClient(name);
                    Client boolClient = clients.SingleOrDefault(x => x.Name == currentClient.Name);
                    if (!clients.Contains(boolClient))
                    {
                        clients.Add(currentClient);
                    }
                    int indexOfClient = clients.FindIndex(x => x.Name == currentClient.Name);
                    if (!clients[indexOfClient].Products.ContainsKey(product))
                    {
                        clients[indexOfClient].Products[product] = 0;
                    }
                    clients[indexOfClient].Products[product] += quantity;
                    clients[indexOfClient].Bill += quantity * shopProducts[product];
                }
                input = Console.ReadLine();
            }
            foreach (Client client in clients.OrderBy(x => x.Name))
            {
                Console.WriteLine(client.Name);
                foreach (KeyValuePair<string, int> product in client.Products)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }
                Console.WriteLine($"Bill: {client.Bill:f2}");
            }
            Console.WriteLine($"Total bill: {clients.Sum(x => x.Bill):f2}");
        }
    }
    class Client
    {
        public string Name { get; set; }
        public Dictionary<string, int> Products {get; set;}
        public decimal Bill { get; set; }

        public static Client ReadClient(string name)
        {
            return new Client
            {
                Name = name,
                Products = new Dictionary<string, int>(),
                Bill = 0
            };
        }
    }
}
