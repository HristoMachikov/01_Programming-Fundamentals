namespace _01CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CountRealNumbers
    {
        public static void Main()
        {
            SortedDictionary<double, int> countNumb = new SortedDictionary<double, int>();
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            foreach (var item in input)
            {
                if (!countNumb.ContainsKey(item))
                {
                    countNumb[item] = 0;
                }

                countNumb[item]++;
            }

            foreach (var pair in countNumb)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
