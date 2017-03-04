using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = "Hello";
            string secondWord = "World";

            object result = firstWord + " " + secondWord;
            string sentence = (string)(result);
            Console.WriteLine(sentence);
        }
    }
}
