namespace _14FactorialTrailingZeroes
{
    using System;
    using System.Numerics;

    public class FactorialTrailingZeroes
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            BigInteger number = 1;
            for (int i = 1; i <= input; i++)
            {
                number *= i;
            }

            int count = 0;
            string numberToString = number.ToString();
            for (int i = numberToString.Length; i >= 0; i--)
            {
                var c = numberToString[i - 1];
                if (c - '0' == 0)
                {
                    count += 1;
                }

                if (c - '0' != 0)
                {
                    break;
                }
            }

            Console.WriteLine(count);
        }
    }
}
