namespace _04Largest3Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Largest3Numbers
    {
        public static void Main()
        {
            var list = Console.ReadLine()
                                    .Split(' ')
                                    .Select(double.Parse)
                                    .OrderByDescending(n => n)
                                    .Take(3)
                                    .ToList();

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
