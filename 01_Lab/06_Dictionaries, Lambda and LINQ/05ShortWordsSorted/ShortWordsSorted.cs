namespace _05ShortWordsSorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ShortWordsSorted
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                                        .ToLower()
                                        .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Where(text => text.Length < 5)
                                        .OrderBy(x => x)
                                        .ToList();
            var result = new Dictionary<string, int>();
            foreach (var item in words)
            {
                if (!result.ContainsKey(item))
                {
                    result[item] = 0;
                }

                result[item]++;
            }

            var output = string.Join(", ", result.Keys);
            Console.WriteLine(output);
        }
    }
}
