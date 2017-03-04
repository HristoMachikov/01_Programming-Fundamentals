namespace _04SplitByWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SplitByWordCasing
    {
        public static void Main()
        {
            ////The fowolling separators are used: , ; : . ! ( ) " ' \ / [ ] space
            char[] separators = new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' };
            var input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            var uperCase = new List<string>();
            var lowerCase = new List<string>();
            var other = new List<string>();

            foreach (string words in input)
            {
                int countL = 0;
                int countU = 0;
                for (int i = 0; i < words.Length; i++)
                {
                    char symbol = words[i];
                    if (symbol >= 'a' && symbol <= 'z')
                    {
                        countL += 1;
                    }
                    else if (symbol >= 'A' && symbol <= 'Z')
                    {
                        countU += 1;
                    }
                }

                if (countL == words.Length)
                {
                    lowerCase.Add(words);
                }
                else if (countU == words.Length)
                {
                    uperCase.Add(words);
                }
                else
                {
                    other.Add(words);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", other));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", uperCase));
        }
    }
}
