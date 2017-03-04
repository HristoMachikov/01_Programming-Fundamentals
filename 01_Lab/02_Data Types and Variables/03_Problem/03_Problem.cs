using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum = 0.0m;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                decimal newValue = decimal.Parse(Console.ReadLine());
                if (newValue % 1 == 0)
                {
                    count += 1;
                }
                sum += newValue;
            }

            if (count == n)
            {
                Console.WriteLine(Math.Round(sum));
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
