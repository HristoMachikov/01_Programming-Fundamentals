namespace _03TextFilter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TextFilter
    {
        public static void Main()
        {
            string[] bannedWords = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string inputText = Console.ReadLine();
            string output = inputText;
            for (int i = 0; i < bannedWords.Length; i++)
            {
                output = output.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
            }

            Console.WriteLine(output);
        }
    }
}
