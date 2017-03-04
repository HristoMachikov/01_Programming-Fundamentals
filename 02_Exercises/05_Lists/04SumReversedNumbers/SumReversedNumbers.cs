namespace _04SumReversedNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumReversedNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToList();
            int sum = 0;
            foreach (var number in input)
            {
                var revers = new List<char>();
                for (int i = number.Length - 1; i >= 0; i--)
                {
                    revers.Add(number[i]);
                }

                string numbRev = string.Join(string.Empty, revers);
                int numb = int.Parse(numbRev);
                sum += numb;
            }

            Console.WriteLine(sum);
        }
    }
}
