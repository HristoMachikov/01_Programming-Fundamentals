namespace _04SieveOfEratosthenes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SieveOfEratosthenes
    {
        public static void Main()
        {
            int numb = int.Parse(Console.ReadLine());
            bool[] primes = new bool[numb + 1];
            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            primes[0] = primes[1] = false;
            for (int i = 2; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    for (int j = 2 * i; j < primes.Length; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }

            var primesUpToNumb = new List<int>();
            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    primesUpToNumb.Add(i);
                }
            }

            string output = string.Join(" ", primesUpToNumb);
            Console.WriteLine(output);
        }
    }
}