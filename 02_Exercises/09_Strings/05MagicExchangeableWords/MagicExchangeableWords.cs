namespace _05MagicExchangeableWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MagicExchangeableWords
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            string firstString = words[0];
            string secondString = words[1];

            bool result = AreTwoStringsExchangeable(firstString, secondString);
            Console.WriteLine(result.ToString().ToLower());
        }

        private static bool AreTwoStringsExchangeable(string firstString, string secondString)
        {
            bool exchangeOrNot = false;
            char[] firstChars = firstString.ToCharArray();
            HashSet<char> firstUniquChars = new HashSet<char>(firstChars);
            char[] secondChars = secondString.ToCharArray();
            HashSet<char> secondUniquChars = new HashSet<char>(secondChars);
            if (firstUniquChars.Count == secondUniquChars.Count)
            {
                exchangeOrNot = true;
            }

            return exchangeOrNot;
        }
    }
}