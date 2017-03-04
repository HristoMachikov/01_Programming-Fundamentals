namespace _02OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OddOccurrences
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToLower().Split(' ').ToList();
            Dictionary<string, int> words = new Dictionary<string, int>();
            foreach (var item in input)
            {
                if (!words.ContainsKey(item))
                {
                    words[item] = 0;
                }

                words[item]++;
            }

            var result = new List<string>();
            foreach (var pairs in words)
            {
                if (pairs.Value % 2 != 0)
                {
                    result.Add(pairs.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
