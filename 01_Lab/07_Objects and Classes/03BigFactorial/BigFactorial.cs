namespace _03BigFactorial
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class BigFactorial
    {
        public static void Main()
        {
            int numb = int.Parse(Console.ReadLine());
            BigInteger output = 1;
            for (int i = 1; i < numb; i++)
            {
                output += output * i;
            }

            Console.WriteLine(output);
        }
    }
}