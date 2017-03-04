using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string hexadecimalNumb = Convert.ToString(input,16);
            hexadecimalNumb = hexadecimalNumb.ToUpper();
            string binaryNumb = Convert.ToString(input, 2);
            //string decimalNumb = Convert.ToString(input, 10);
            Console.WriteLine(hexadecimalNumb);
            Console.WriteLine(binaryNumb);
            //Console.WriteLine(decimalNumb);
        }
    }
}
