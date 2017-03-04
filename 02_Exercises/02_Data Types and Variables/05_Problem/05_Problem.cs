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
            string trueFalse = Console.ReadLine();
            bool result = Convert.ToBoolean(trueFalse);
            if(result)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
