namespace _05SortNumbers
{
using System;
using System.Collections.Generic;
using System.Linq;

    public class SortNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            input.Sort();
            Console.WriteLine(string.Join(" <= ",input));
        }
    }
}