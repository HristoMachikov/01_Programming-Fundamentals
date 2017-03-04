namespace _08LettersChangeNumbers
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class LettersChangeNumbers
    {
        public static void Main()
        {
            MatchCollection matches = Regex.Matches(Console.ReadLine(), @"([A-Za-z])(\-?(?:\d+|\d+.?\d+))([A-Za-z])");
            decimal totalSum = 0;

            foreach (Match match in matches)
            {
                decimal sum = 0;
                decimal number = decimal.Parse(match.Groups[2].ToString());
                char firstChar = char.Parse(match.Groups[1].ToString());
                char lastChar = char.Parse(match.Groups[3].ToString());
                int indexOfFirstChar = 0;
                int indexOfLastChar = 0;
                if (firstChar >= 'a' & firstChar <= 'z')
                {
                    indexOfFirstChar = firstChar - 'a' + 1;
                    sum += number * indexOfFirstChar;
                }
                else if (firstChar >= 'A' && firstChar <= 'Z')
                {
                    indexOfFirstChar = firstChar - 'A' + 1;
                    sum += number / indexOfFirstChar;
                }

                if (lastChar >= 'a' && lastChar <= 'z')
                {
                    indexOfLastChar = lastChar - 'a' + 1;
                    sum += indexOfLastChar;
                }
                else if (lastChar >= 'A' && lastChar <= 'Z')
                {
                    indexOfLastChar = lastChar - 'A' + 1;
                    sum -= indexOfLastChar;
                }

                totalSum += sum;
            }

            Console.WriteLine("{0:f2}", totalSum);
        }
    }
}