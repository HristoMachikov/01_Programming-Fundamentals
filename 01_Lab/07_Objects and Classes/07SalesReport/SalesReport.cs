namespace _07SalesReport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SalesReport
    {
        public static void Main()
        {
            int numbSeles = int.Parse(Console.ReadLine());
            SortedDictionary<string, double> selesReport = new SortedDictionary<string, double>();
            for (int i = 0; i < numbSeles; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();

                Seles currentSele = new Seles()
                {
                    Town = input[0],
                    Product = input[1],
                    Price = double.Parse(input[2]),
                    Quantity = double.Parse(input[3])
                };
                if (!selesReport.ContainsKey(currentSele.Town))
                {
                    selesReport[currentSele.Town] = 0;
                }

                selesReport[currentSele.Town] += currentSele.Total;
            }

            foreach (var pair in selesReport)
            {
                Console.WriteLine("{0} -> {1:f2}", pair.Key, pair.Value);
            }
        }
    }
}