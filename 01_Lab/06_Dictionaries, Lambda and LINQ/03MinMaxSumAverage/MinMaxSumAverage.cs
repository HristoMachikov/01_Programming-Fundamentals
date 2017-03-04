namespace _03MinMaxSumAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MinMaxSumAverage
    {
        public static void Main()
        {
            int numb = int.Parse(Console.ReadLine());
            List<double> input = new List<double>();
            for (int i = 0; i < numb; i++)
            {
                input.Add(double.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Sum = {0}", input.Sum());
            Console.WriteLine("Min = {0}", input.Min());
            Console.WriteLine("Max = {0}", input.Max());
            Console.WriteLine("Average = {0}", input.Average());
        }
    }
}
