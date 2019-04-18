using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _06.BookLibraryModification
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            int numberOfInputs = int.Parse(Console.ReadLine());
            for (int curr = 0; curr < numberOfInputs; curr++)
            {
                string[] currentInputTokens = Console.ReadLine().Split(' ');
                string title = currentInputTokens[0];
                DateTime releaseDate = DateTime.ParseExact(currentInputTokens[3], "d.M.yyyy", CultureInfo.InvariantCulture);
                Book currentBook = Book.ReadBook(title, releaseDate);
                Book boolBook = books.SingleOrDefault(x => x.Title == currentBook.Title);
                if (books.Contains(boolBook))
                {
                    int existingBookIndex = books.FindIndex(x => x.Title == currentBook.Title);
                    books.RemoveAt(existingBookIndex);
                }
                books.Add(currentBook);
            }
            DateTime givenDate = DateTime.ParseExact(Console.ReadLine(), "dd.M.yyyy", CultureInfo.InvariantCulture);

            foreach (Book book in books.OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title))
            {
                if (book.ReleaseDate > givenDate)
                {
                    Console.WriteLine($"{book.Title} -> {book.ReleaseDate.ToString(@"dd.MM.yyyy")}");
                }
            }
        }
    }
    class Book
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }

        public static Book ReadBook(string title, DateTime date)
        {
            return new Book
            {
                Title = title,
                ReleaseDate = date
            };
        }
    }
}
