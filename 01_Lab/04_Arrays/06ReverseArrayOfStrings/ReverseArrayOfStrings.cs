namespace _06ReverseArrayOfStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ReverseArrayOfStrings
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] arrayOfString = input.Trim().Split();
            string[] reversArrayOfString = new string[arrayOfString.Length];
            for (int i = 0; i < arrayOfString.Length; i++)
            {
                reversArrayOfString[arrayOfString.Length - 1 - i] = arrayOfString[i];
            }

            string output = string.Join(" ", reversArrayOfString);
            Console.WriteLine(output);
        }
    }
}
