using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            double R = double.Parse(Console.ReadLine());

            double area = Math.PI * R * R;
            Console.WriteLine("{0:f12}", area);
        }
    }
}
