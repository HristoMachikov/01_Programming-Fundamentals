using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                string numbDigit = i.ToString();
                int number = i;
                int rest = 1;

                for (int j = 0; j < numbDigit.Length; j++)
                {
                    rest = number % 10;
                    number = number / 10;
                    sum += rest;
                } 

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine("{0} \"->\" True", i);
                }
                else
                {
                    Console.WriteLine("{0} \"->\" False", i);
                }
            }
        }
    }
}
