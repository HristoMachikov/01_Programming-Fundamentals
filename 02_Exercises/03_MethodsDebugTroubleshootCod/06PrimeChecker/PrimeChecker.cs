namespace _06PrimeChecker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PrimeChecker
    {
        public static void Main()
        {
            try
            {
                ulong numb = ulong.Parse(Console.ReadLine());
                if (numb > 1)
                {
                    bool primeOrNot = IsPrime(numb);
                    Console.WriteLine(primeOrNot);
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
                 catch (System.FormatException)
            {
                Console.WriteLine("False");
            }
        }

        public static bool IsPrime(ulong n)
        {
            bool isTrue = true;
            ulong limit = (ulong)Math.Floor(Math.Sqrt(n));
            for (ulong i = 2; i <= limit; i++)
            {
                if (n % i == 0)
                {
                    isTrue = false;
                    break;
                }
            }

            return isTrue;
        }
    }
}