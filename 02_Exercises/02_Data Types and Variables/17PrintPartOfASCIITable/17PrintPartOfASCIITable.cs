using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInput = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());
            for (int i = firstInput; i <= secondInput; i++)
            {
                char output = Convert.ToChar(i);
                Console.Write(output + " ");
            }
            Console.WriteLine();
        }
    }
}
