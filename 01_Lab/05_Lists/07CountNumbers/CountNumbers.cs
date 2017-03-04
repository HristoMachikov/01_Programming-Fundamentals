namespace _07CountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CountNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .ToList();
            input.Sort();
            int previews = input[0];
            int count = 1;
            for (int i = 1; i < input.Count; i++)
            {
                int current = input[i];
                if (current == previews)
                {
                    count += 1;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", previews, count);
                    previews = input[i];
                    count = 1;
                }
            }

            Console.WriteLine("{0} -> {1}", previews, count);
        }
    }
}