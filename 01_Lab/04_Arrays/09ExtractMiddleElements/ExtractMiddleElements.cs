namespace _09ExtractMiddleElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ExtractMiddleElements
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ').ToArray();
            string output = string.Empty;
            if (inputArray.Length == 1)
            {
                output = input;
            }
            else if (inputArray.Length % 2 == 0)
            {
                output = MiddleOfEven(inputArray);
            }
            else if (inputArray.Length % 1 == 0)
            {
                output = MiddleOfOdd(inputArray);
            }

            Console.WriteLine("{ " + output + " }");
        }

        private static string MiddleOfOdd(string[] inputArray)
        {
            string[] oddArray = new string[3];
            for (int i = 0; i < 3; i++)
            {
                oddArray[i] = inputArray[((inputArray.Length - 1) / 2) - 1 + i];
            }

            string result = string.Join(", ", oddArray);
            return result;
        }

        private static string MiddleOfEven(string[] inputArray)
        {
            string[] evenArray = new string[2];
            for (int i = 0; i < 2; i++)
            {
                evenArray[i] = inputArray[(inputArray.Length / 2) - 1 + i];
            }

            string result = string.Join(", ", evenArray);
            return result;
        }
    }
}