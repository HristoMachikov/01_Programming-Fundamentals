namespace _02RandomizeWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RandomizeWords
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] inputArr = input.Split(' ');

            var rmz = new Random();

            for (int i = 0; i < inputArr.Length; i++)
            {
                string temp = inputArr[i];
                int nextPlace = rmz.Next(0, inputArr.Length - 1);
                inputArr[i] = inputArr[nextPlace];
                inputArr[nextPlace] = temp;
            }
            ////for (int i = 0; i < inputArr.Length; i++)
            ////{
            ////    Console.WriteLine(inputArr[i]);
            ////}
            Console.WriteLine(string.Join("\n", inputArr));
        }
    }
}