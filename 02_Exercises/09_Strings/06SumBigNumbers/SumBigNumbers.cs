namespace _06SumBigNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SumBigNumbers
    {
        public static void Main()
        {
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            firstNumber = firstNumber.TrimStart(new char[] { '0' });
            secondNumber = secondNumber.TrimStart('0');
            string result = SumOfTwoBigNumbers(firstNumber, secondNumber);
            Console.WriteLine(result);
        }

        private static string SumOfTwoBigNumbers(string firstNumber, string secondNumber)
        {
            StringBuilder sum = new StringBuilder();
            char[] firstDigits = firstNumber.ToCharArray();
            char[] secondDigits = secondNumber.ToCharArray();
            
            int maxDigits = Math.Max(firstDigits.Length, secondDigits.Length);
            int toBeAdded = 0;
            for (int i = 0; i < maxDigits; i++)
            {
                int currFirstDigit = 0;
                int currSecondDigit = 0;
                if (firstDigits.Length - 1 >= i)
                {
                    currFirstDigit = firstDigits[firstDigits.Length - 1 - i] - '0';
                }

                if (secondDigits.Length - 1 >= i)
                {
                    currSecondDigit = secondDigits[secondDigits.Length - 1 - i] - '0';
                }

                int innerSum = currFirstDigit + currSecondDigit + toBeAdded;
                int rest = innerSum % 10;
                sum.Append(rest);
                toBeAdded = innerSum / 10;
            }

            if (toBeAdded > 0)
            {
                sum.Append(toBeAdded);
            }

            StringBuilder output = new StringBuilder(sum.Length);
            for (int i = sum.Length - 1; i >= 0; i--)
            {
                output.Append(sum[i]);
            }

            return output.ToString();
        }
    }
}