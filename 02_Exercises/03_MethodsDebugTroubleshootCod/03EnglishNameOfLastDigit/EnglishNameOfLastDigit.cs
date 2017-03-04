namespace _03EnglishNameOfLastDigit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;

    public class EnglishNameOfLastDigit
    {
        public static void Main()
        {
            try
            {
                BigInteger input = BigInteger.Parse(Console.ReadLine());
                Console.WriteLine(NameOfLastDigit(input));
            }
            catch (System.FormatException)
            {
            }
        }

        private static string NameOfLastDigit(BigInteger input)
        {
            char[] arrayOfnumbers = input.ToString().ToArray();
            char lastDigit = arrayOfnumbers[arrayOfnumbers.Length - 1];
            string name = string.Empty;
            switch (lastDigit)
            {
                case '0':
                    name = "zero";
                    break;
                case '1':
                    name = "one";
                    break;
                case '2':
                    name = "two";
                    break;
                case '3':
                    name = "three";
                    break;
                case '4':
                    name = "four";
                    break;
                case '5':
                    name = "five";
                    break;
                case '6':
                    name = "six";
                    break;
                case '7':
                    name = "seven";
                    break;
                case '8':
                    name = "eight";
                    break;
                case '9':
                    name = "nine";
                    break;
            }

            return name;
        }
    }
}
