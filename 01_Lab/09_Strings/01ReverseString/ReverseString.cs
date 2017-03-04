namespace _01ReverseString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ReverseString
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            char[] inputArray = input.ToCharArray();
            var inputArrayNew = inputArray.Reverse();
            string output = string.Empty;
            foreach (var newchar in inputArrayNew)
            {
                output += newchar;
            }

            Console.WriteLine(output);
        }
    }
}