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
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double numbCourses = Math.Ceiling(people/(capacity*1.0));
            Console.WriteLine(numbCourses);
        }
    }
}
