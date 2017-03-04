namespace _01ConvertFromBase10ToBaseN
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    public class ConvertFromBase10ToBaseN
    {
        public static void Main()
        {
            BigInteger[] input = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            int baseN = (int)input[0];
            BigInteger number = input[1];
            string output = string.Empty;
            while (number != 0)
            {
                BigInteger toBeConcat = number % baseN;
                output += toBeConcat;
                number = number / baseN;
            }

            char[] outputArray = output.ToCharArray();
            char[] outputArrayRev = outputArray.Reverse().ToArray();
            StringBuilder result = new StringBuilder();
            foreach (char nextChar in outputArrayRev)
            {
                result.Append(nextChar);
            }

            Console.WriteLine(result);
        }
    }
}