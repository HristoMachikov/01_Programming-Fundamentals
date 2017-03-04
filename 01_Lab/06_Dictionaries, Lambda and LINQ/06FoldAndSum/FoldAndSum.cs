namespace _06FoldAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int
                .Parse)
                .ToList();
            var start = input.Take(input.Count / 4).Reverse().ToList();
            List<int> end = input.Skip(3 * (input.Count / 4)).Take(input.Count / 4).Reverse().ToList();
            List<int> secondRow = input.Skip(input.Count / 4).Take(input.Count / 2).ToList();
            var firstRow = start.Concat(end).ToList();

            var result = firstRow.Zip(secondRow, (x, y) => x + y).ToList();
            var output = string.Join(" ", result);
            Console.WriteLine(output);
        }
    }
}
