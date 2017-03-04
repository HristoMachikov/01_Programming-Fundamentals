namespace _05CompareCharArrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CompareCharArrays
    {
        public static void Main()
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            string[] firstArray = firstInput.Split(' ').ToArray();
            string[] secondArray = secondInput.Split(' ').ToArray();
            var firstChar = ConvertStringToChar(firstArray);
            var secondChar = ConvertStringToChar(secondArray);

            bool check = false;
            for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {
                if (firstChar[i] > secondChar[i])
                {
                    check = true;
                    break;
                }
            }

            string outputFirst = string.Join(string.Empty, firstChar);
            string outputSecond = string.Join(string.Empty, secondChar);
            if (!check)
            {
                if (firstArray.Length > secondArray.Length)
                {
                    Console.WriteLine(outputSecond);
                    Console.WriteLine(outputFirst);
                }
                else
                {  
                    Console.WriteLine(outputFirst);
                    Console.WriteLine(outputSecond);
                }
            }
            else
            {
                Console.WriteLine(outputSecond);
                Console.WriteLine(outputFirst);
            }
        }

        private static char[] ConvertStringToChar(string[] array)
        {
            var charArray = new char[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                charArray[i] = Convert.ToChar(array[i]);
            }

            return charArray;
        }
    }
}