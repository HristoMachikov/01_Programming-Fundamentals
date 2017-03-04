namespace _04TrippleSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;

    public class TrippleSum
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            BigInteger[] arrayOfInt = input.Split(' ').Select(BigInteger.Parse).ToArray();
            int count = 0;
            for (int i = 0; i < arrayOfInt.Length - 1; i++)
            {
                for (int j = i + 1; j < arrayOfInt.Length; j++)
                {
                    //for (int k = 0; k < arrayOfInt.Length; k++)
                    //{
                        BigInteger sum = arrayOfInt[i] + arrayOfInt[j];
                        if (arrayOfInt.Contains(sum))
                        //if (sum == arrayOfInt[k])
                        {
                            Console.WriteLine("{0} + {1} == {2}", arrayOfInt[i], arrayOfInt[j], sum);
                            count += 1;
                        }
                    //}
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
