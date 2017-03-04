namespace _09IndexOfLetters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class IndexOfLetters
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            foreach (var symbol in input)
            {
                int digit = symbol - 'a';
                Console.WriteLine("{0} -> {1}", symbol, digit);
            }
        }
    }
}
