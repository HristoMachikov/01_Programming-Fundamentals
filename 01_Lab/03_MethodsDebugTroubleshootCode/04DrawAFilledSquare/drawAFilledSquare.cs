using System;

namespace _04DrawAFilledSquare
{
    public class DrawAFilledSquare
    {
        public static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            PrintHeaderOrFooterRow(n);
            PrintMiddleRow(n);
            PrintHeaderOrFooterRow(n);
        }

        private static void PrintMiddleRow(int number)
        {
            for (int i = 0; i < number - 2; i++)
            {
                Console.Write('-');
                for (int j = 0; j < number - 1; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }
        public static void PrintHeaderOrFooterRow(int number)
        {
            Console.WriteLine(new string('-', 2 * number));
        }
    }
}
