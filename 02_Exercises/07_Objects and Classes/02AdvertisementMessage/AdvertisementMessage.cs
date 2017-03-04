namespace _02AdvertisementMessage
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class AdvertisementMessage
    {
        public static void Main()
        {
            int numb = int.Parse(Console.ReadLine());
            string[] phrasesArray = new string[] 
            { 
                "Excellent product.", 
                "Such a great product.", 
                "I always use that product.", 
                "Best product of its category.", 
                "Exceptional product.", 
                "I can’t live without this product." 
            };
            string[] eventsArray = new string[] 
            { 
                "Now I feel good.", 
                "I have succeeded with this product.", 
                "Makes miracles. I am happy of the results!", 
                "I cannot believe but now I feel awesome.", 
                "Try it yourself, I am very satisfied.", 
                "I feel great!"
            };
            string[] authorArray = new string[] 
            { 
                "Diana", 
                "Petya", 
                "Stella", 
                "Elena", 
                "Katya", 
                "Iva", 
                "Annie", 
                "Eva" 
            };
            string[] citiesArray = new string[] 
            { 
                "Burgas", 
                "Sofia",
                "Plovdiv",
                "Varna", 
                "Ruse" 
            };

            Random phrasesIndex = new Random();
            Random eventIndex = new Random();
            Random authorIndex = new Random();
            Random cityIndex = new Random();

            for (int i = 0; i < numb; i++)
            {
                string phrase = phrasesArray[phrasesIndex.Next(0, phrasesArray.Length - 1)];
                string myEvent = eventsArray[eventIndex.Next(0, eventsArray.Length - 1)];
                string author = authorArray[authorIndex.Next(0, authorArray.Length - 1)];
                string city = citiesArray[cityIndex.Next(0, citiesArray.Length - 1)];
                Console.WriteLine("{0} {1} {2} – {3}.", phrase, myEvent, author, city);
            }
        }
    }
}