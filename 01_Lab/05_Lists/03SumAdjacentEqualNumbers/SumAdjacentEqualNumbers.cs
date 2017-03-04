namespace _03SumAdjacentEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            for (int j = 0; j <= input.Count; j++)
            {
                for (int i = 0; i < input.Count - 1; i++)
                {
                    if (input[i] == input[i + 1])
                    {
                        decimal sum = input[i] + input[i + 1];
                        input.RemoveRange(i, 2);
                        input.Insert(i, sum);
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
