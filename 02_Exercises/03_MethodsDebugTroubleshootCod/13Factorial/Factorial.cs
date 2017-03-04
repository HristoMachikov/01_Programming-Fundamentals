namespace _13Factorial
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

   public class Factorial
    {
        public static void Main()
        {
            try
            {
                int input = int.Parse(Console.ReadLine());
                if (input > 0)
                {
                    BigInteger number = 1;
                    for (int i = 1; i <= input; i++)
                    {
                        number *= i;
                    }
                    Console.WriteLine(number);
                } 
            }
            catch (System.FormatException)
            {
            }
        }
    }
}
