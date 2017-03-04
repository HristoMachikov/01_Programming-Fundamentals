namespace _06SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SquareNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var output = new List<int>();
            foreach (var number in input)
            {
                var squarNumb = Math.Sqrt(number);
                if (squarNumb % 1 == 0)
                {
                    output.Add(number);
                }
            }

            output.Sort();
            output.Reverse();
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
