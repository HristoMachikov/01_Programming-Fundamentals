namespace _07MultiplyBigNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MultiplyBigNumber
    {
        public static void Main()
        {
            string bigNumber = Console.ReadLine();
            bool check = false;
            foreach (var item in bigNumber)
            {
                if (item != '0')
                {
                    check = true;
                }
            }

            if (check)
            {
                bigNumber = bigNumber.TrimStart('0');
            }
            else
            {
                bigNumber = "0";
            }

            string multipleBy = Console.ReadLine();
            string result = string.Empty;
            if (multipleBy == "0")
            {
                result = "0";
            }
            else
            {
                result = MultiplyBigNumb(bigNumber, multipleBy);
            }
             
            Console.WriteLine(result);
        }

        private static string MultiplyBigNumb(string bigNumber, string multipleBy)
        {
            char[] bigNumbChar = bigNumber.ToCharArray();
            int multiplier = int.Parse(multipleBy);
            int keepInMind = 0;
            StringBuilder result = new StringBuilder();
            for (int i = bigNumbChar.Length - 1; i >= 0; i--)
            {
                int innerResult = ((bigNumbChar[i] - '0') * multiplier) + keepInMind;
                int currResult = innerResult % 10;
                result.Append(currResult);
                keepInMind = innerResult / 10;
            }

            if (keepInMind > 0)
            {
                result.Append(keepInMind);
            }

            StringBuilder output = new StringBuilder(result.Length);
            for (int i = result.Length - 1; i >= 0; i--)
            {
                output.Append(result[i]);
            }

            return output.ToString();
        }
    }
}