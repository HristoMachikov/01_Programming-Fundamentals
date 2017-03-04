using System;
namespace _02SignOfIntegerNumber
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }

        public static void PrintSign(int number)
        {
            if(number>0)
            {
                Console.WriteLine("The number {0} is positive.",number);
            }
            else if (number < 0)
            {
                Console.WriteLine("The number {0} is negative.",number);
            }
            else
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }

    }
}
