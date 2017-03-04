using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstVar = 5;
            int secondVar = 10;
            int tempVar = firstVar;
            
            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}", firstVar);
            Console.WriteLine("b = {0}", secondVar);
            firstVar = secondVar;
            secondVar = tempVar;
            Console.WriteLine("After:");
            Console.WriteLine("a = {0}", firstVar);
            Console.WriteLine("b = {0}", secondVar);
        }
    }
}
