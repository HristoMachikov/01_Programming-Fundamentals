namespace _04Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Palindromes
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(new char[] { ',', '.', ' ', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            HashSet<string> result = new HashSet<string>();
            foreach (string word in words)
            {
                int count = 0;
                for (int i = 0; i < word.Length / 2; i++)
                {
                    if (word[i] == word[word.Length - i - 1])
                    {
                        count += 1;
                    }
                    else
                    {
                        break;
                    }
                }

                if (count == word.Length / 2)
                {
                    result.Add(word);
                }
            }

            var resultOrder = result.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", resultOrder));
        }
    }
}