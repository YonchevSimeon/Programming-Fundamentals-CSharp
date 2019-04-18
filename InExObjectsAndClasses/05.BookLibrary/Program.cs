using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Library> libraries = new List<Library>();
            int numberOfInputs = int.Parse(Console.ReadLine());
            for (int curr = 0; curr < numberOfInputs; curr++)
            {
                string[] currentInputTokens = Console.ReadLine().Split(' ');
                string title = currentInputTokens[0];
                string name = currentInputTokens[1];
                double price = double.Parse(currentInputTokens[5]);
                Library currentLibrary = Library.CreateAuthorAndLibrary(name);
                Book currentBook = Book.ReadBookAndPrice(title, price);
                Library boolLibrary = libraries.SingleOrDefault(x => x.Name == name);
                if (!libraries.Contains(boolLibrary))
                {
                    libraries.Add(currentLibrary);
                }
                int indexOfLibrary = libraries.FindIndex(x => x.Name == currentLibrary.Name);
                libraries[indexOfLibrary].Books.Add(currentBook);
            }
            foreach (Library library in libraries.OrderBy(x => -x.Books.Sum(a => a.Price)).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{library.Name} -> {library.Books.Sum(x => x.Price):f2}");
            }
        }
    }
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public static Library CreateAuthorAndLibrary(string name)
        {
            return new Library
            {
                Name = name,
                Books = new List<Book>()
            };
        }
    }
    class Book
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public static Book ReadBookAndPrice (string title, double price)
        {
            return new Book
            {
                Title = title,
                Price = price
            };
        }
    }
}
