using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double wight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double perim = 2 * wight + 2 * height;
            double area = wight * height;
            double diag = Math.Pow(Math.Pow(height, 2) + Math.Pow(wight, 2), 0.5);
            Console.WriteLine(perim);
            Console.WriteLine(area);
            Console.WriteLine(diag);
        }
    }
}
