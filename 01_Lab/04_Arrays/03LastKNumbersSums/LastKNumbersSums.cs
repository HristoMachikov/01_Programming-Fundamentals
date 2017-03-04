namespace _03LastKNumbersSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LastKNumbersSums
    {
        public static void Main()
        {
            long[] numbOfElem = new long[long.Parse(Console.ReadLine())];
            long elements = long.Parse(Console.ReadLine());
            numbOfElem[0] = 1;
            for (long i = 1; i < numbOfElem.Length; i++)
            {
                long sumElem = 0;
                if (i < elements)
                {
                    for (long j = i - 1; j >= 0; j--)
                    {
                        sumElem += numbOfElem[j];
                    }

                    numbOfElem[i] = sumElem;
                }
                else
                {
                    for (long j = i - 1; j >= i - elements; j--)
                    {
                        sumElem += numbOfElem[j];
                    }

                    numbOfElem[i] = sumElem;
                }
            }

            var result = string.Join(" ", numbOfElem);
            Console.WriteLine(result);
        }
    }
}