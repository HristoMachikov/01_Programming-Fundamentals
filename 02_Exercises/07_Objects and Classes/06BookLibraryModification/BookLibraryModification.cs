namespace _06BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class BookLibraryModification
    {
        public static void Main()
        {
            int numb = int.Parse(Console.ReadLine());
            Book[] allBooks = new Book[numb];
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
                allBooks[i] = currnetBook;
            }

            var olderDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            List<Book> newlyTitle = allBooks
                .Where(x => x.ReleaseDate > olderDate)
                .OrderBy(x => x.ReleaseDate)
                .ThenBy(x => x.Title)
                .ToList();

            foreach (var obj in newlyTitle)
            {
                Console.WriteLine("{0} -> {1}", obj.Title, obj.ReleaseDate.ToString("dd.MM.yyyy"));
            }
        }
    }
}