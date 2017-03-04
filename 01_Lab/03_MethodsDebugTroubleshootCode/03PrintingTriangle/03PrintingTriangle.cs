using System;

namespace _03PrintingTriangle
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                PrintHorizontaly(1, i);
            }
            for (int i = n - 1; i > 0; i--)
            {
                PrintHorizontaly(1, i);
            }
        }
        public static void PrintHorizontaly(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}

