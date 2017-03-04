using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = new string[100];
            int count = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                string input = null;
                input = Console.ReadLine();
                inputArray[i] = input;
                if (input == "")
                {
                    break;
                }
                count += 1;
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(inputArray[i]);
            }
        }
    }
}
