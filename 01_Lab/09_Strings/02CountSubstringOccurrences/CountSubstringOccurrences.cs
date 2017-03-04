namespace _02CountSubstringOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string search = Console.ReadLine().ToLower();
            int count = 0;
            int index = 0;
            while (true)
            {
                int searchIndex = input.IndexOf(search, index);
                if (searchIndex >= 0)
                {
                    index = searchIndex + 1;
                    count += 1;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(count);
        }
    }
}