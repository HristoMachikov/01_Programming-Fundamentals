namespace _12MasterNumber
{
    using System;
    using System.Collections.Generic;

    public class MasterNumber
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {

                bool isPalindrom = IsPalindrom(i);
                bool sumOfDigits = SumOfDigits(i);
                bool containsEvenDigit = ContainsEvenDigit(i);
                if (isPalindrom == true && sumOfDigits == true && containsEvenDigit == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool ContainsEvenDigit(int i)
        {
            var isEvenDigit = false;
            int remainder = i;
            while (i != 0)
            {
                if (remainder % 2 == 0)
                {
                    isEvenDigit = true;
                    break;
                }
                remainder = i % 10;
                i = i / 10;
            }

            return isEvenDigit;
        }

        public static bool SumOfDigits(int input)
        {
            string inputToString = input.ToString();
            int sumOfDigit = 0;
            var digitSeven = false;
            for (int i = 0; i < inputToString.Length; i++)
            {
                sumOfDigit += (inputToString[i] - '0');
            }
            if (sumOfDigit % 7 == 0)
            {
                digitSeven = true;
            }
            return digitSeven;
        }

        public static bool IsPalindrom(int input)
        {
            string inputToString = input.ToString();
            var palindrom = false;
            if (input > 10)
            {
                palindrom = true;
                for (int i = 0; i < Math.Floor(inputToString.Length / 2.0); i++)
                {
                    var c = inputToString[i];
                    var d = inputToString[inputToString.Length - 1 - i];
                    if (c != d)
                    {
                        palindrom = false;
                        break;
                    }
                }
            }
            return palindrom;
        }
    }
}
