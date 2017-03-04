using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int century = int.Parse(Console.ReadLine());

            int yars = 100 * century;
            int days = (int)(yars * 365.2422);
            int hours = 24 * days;
            int minutes = 60 * hours;
            Console.WriteLine(century);
            Console.WriteLine(yars);
            Console.WriteLine(days);
            Console.WriteLine(hours);
            Console.WriteLine(minutes);
        }
    }
}
