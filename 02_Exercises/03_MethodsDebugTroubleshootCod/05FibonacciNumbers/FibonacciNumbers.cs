namespace _05FibonacciNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FibonacciNumbers
    {
        public static void Main()
        {
            try
            {
                ulong numb = ulong.Parse(Console.ReadLine());
                ulong fibNumb = 0;
                if (numb == 0 || numb == 1)
                {
                    fibNumb = 1;
                }
                else if (numb > 1)
                {
                    fibNumb = FibonacciNumb(numb);
                }

                Console.WriteLine(fibNumb);
            }
            catch (System.OverflowException)
            {
            }
            catch (System.FormatException)
            {
            }
        }

        public static ulong FibonacciNumb(ulong number)
        {
            ulong[] arrayOfFibon = new ulong[number + 1];
            arrayOfFibon[0] = 1;
            arrayOfFibon[1] = 1;
            for (ulong i = 2; i < (ulong)arrayOfFibon.Length; i++)
            {
                arrayOfFibon[i] = arrayOfFibon[i - 1] + arrayOfFibon[i - 2];
            }

            ulong result = arrayOfFibon[number];
            return result;
        }
    }
}