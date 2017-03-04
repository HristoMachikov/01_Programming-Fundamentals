namespace _05BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }

    public class BookLibrary
    {
        public static void Main()
        {
            int numb = int.Parse(Console.ReadLine());
            Book[] allBooks = new Book[numb];
            Dictionary<string, double> pricePerAutor = new Dictionary<string, double>();
            ////List<Library> libraryBooks = new List<Library>();
            for (int i = 0; i < numb; i++)
            {
                string[] currentInput = Console.ReadLine().Split(' ');
                Book currnetBook = new Book()
                {
                    Title = currentInput[0],
                    Author = currentInput[1],
                    Publisher = currentInput[2],
                    ReleaseDate = DateTime.ParseExact(currentInput[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = currentInput[4],
                    Price = double.Parse(currentInput[5])
                };
                ////Library currentLibrary = new Library();
                ////currentLibrary.Name = currnetBook.Author;
                ////currentLibrary.Books.Add(currnetBook);
                ////libraryBooks.Add(currentLibrary);
                allBooks[i] = currnetBook;
            }
            ////List<Library> sortedLabaryBooks=libraryBooks.OrderBy(x=>x.Name).

            foreach (var obj in allBooks)
            {
                if (!pricePerAutor.ContainsKey(obj.Author))
                {
                    pricePerAutor[obj.Author] = 0;
                }

                pricePerAutor[obj.Author] += obj.Price;
            }

            pricePerAutor = pricePerAutor
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var pair in pricePerAutor)
            {
                Console.WriteLine("{0} -> {1:f2}", pair.Key, pair.Value);
            }
        }
    }
}
