namespace _02ConvertFromBaseNToBase10
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    public class ConvertFromBaseNToBase10
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            int baseN = int.Parse(input[0]);
            char[] numberNAsChar = input[1].ToCharArray();
            int[] numberNAsInt = new int[numberNAsChar.Length];

            for (int i = 0; i < numberNAsChar.Length; i++)
            {
                numberNAsInt[i] = numberNAsChar[i] - '0';
            }

            BigInteger number10 = 0;
            for (int i = 0; i < numberNAsInt.Length; i++)
            {
                int power = numberNAsInt.Length - 1 - i;
                number10 += numberNAsInt[i] * RaiseToPower(baseN, power);
            }

            Console.WriteLine(number10);
        }

        public static BigInteger RaiseToPower(int numb, int pow)
        {
            BigInteger answer = 1;
            for (int i = 1; i <= pow; i++)
            {
                answer *= numb;
            }

            return answer;
        }
    }
}