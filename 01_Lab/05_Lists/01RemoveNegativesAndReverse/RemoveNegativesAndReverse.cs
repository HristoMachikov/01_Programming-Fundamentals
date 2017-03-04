namespace _01RemoveNegativesAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveNegativesAndReverse
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var output = new List<int>();

            foreach (var symbol in input)
            {
                if (symbol >= 0)
                {
                    output.Add(symbol);
                }
            }

            if (output.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                output.Reverse();
                Console.WriteLine(string.Join(" ", output));
            }
        }
    }
}
