using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int result = Convert.ToInt32(input, 16);
            Console.WriteLine(result);
        }
    }
}
