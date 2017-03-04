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
            int n = int.Parse(Console.ReadLine());
            char lastChar = (char)('a' + n);
            for (char i = 'a'; i < lastChar; i++)
            {
                for (char j = 'a'; j < lastChar; j++)
                {
                    for (char k = 'a'; k < lastChar; k++)
                    {
                        Console.WriteLine("{0}{1}{2}",i,j,k);
                    }
                }
            }
        }
    }
}
