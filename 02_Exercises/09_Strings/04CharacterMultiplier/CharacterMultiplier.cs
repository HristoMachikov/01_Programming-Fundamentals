namespace _04CharacterMultiplier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    public class CharacterMultiplier
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            string firstString = words[0];
            string secondString = words[1];
            BigInteger result = SumOfStringsChar(firstString, secondString);
            Console.WriteLine(result);
        }

        private static BigInteger SumOfStringsChar(string firstString, string secondString)
        {
            int sum = 0;
            char[] firstCharArray = firstString.ToCharArray();
            char[] secondCharArray = secondString.ToCharArray();
            int maxCharArray = Math.Max(firstCharArray.Length, secondCharArray.Length);
            for (int i = 0; i < maxCharArray; i++)
            {
                int firstChar = 1;
                int secondChar = 1;
                if (firstCharArray.Length - 1 >= i)
                {
                    firstChar = (int)firstCharArray[i];
                }

                if (secondCharArray.Length - 1 >= i)
                {
                    secondChar = (int)secondCharArray[i];
                }

                sum += firstChar * secondChar;
            }

            return sum;
        }
    }
}