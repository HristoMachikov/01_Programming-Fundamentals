using System;
namespace _09_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] threeChar = new char[3];
            for (int i = 0; i < 3; i++) threeChar[i] = char.Parse(Console.ReadLine());
            for (int i = threeChar.Length - 1; i >= 0; i--) Console.Write(threeChar[i]);
            Console.WriteLine();
        }
    }
}
