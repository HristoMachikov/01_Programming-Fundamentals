using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = 0;
            bool check = false;
            for (int i = 1; i <= n; i++)
            {
                number = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                check = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", number, check);
                sum = 0;
                i = number;
            }
        }
    }
}
