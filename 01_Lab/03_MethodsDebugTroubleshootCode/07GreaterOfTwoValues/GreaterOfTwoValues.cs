using System;

namespace _07GreaterOfTwoValues
{
    public class GreaterOfTwoValues
    {
        public static void Main()
        {
            string inputType = Console.ReadLine();

            if (inputType == "int")
            {
                int firstInput = int.Parse(Console.ReadLine());
                int secondInput = int.Parse(Console.ReadLine());

                int maxValue = GetMax(firstInput, secondInput);
                Console.WriteLine(maxValue);
            }
            else if (inputType == "char")
            {
                char firstInput = char.Parse(Console.ReadLine());
                char secondInput = char.Parse(Console.ReadLine());

                char maxValue = GetMax(firstInput, secondInput);
                Console.WriteLine(maxValue);
            }
            else if (inputType == "string")
            {
                string firstInput = Console.ReadLine();
                string secondInput = Console.ReadLine();
     
                string maxValue = GetMax(firstInput, secondInput);
                Console.WriteLine(maxValue);
            }
        }
        private static string GetMax(string FirstValue, string SecondValue)
        {
            if (FirstValue.CompareTo(SecondValue) <= 0)
            {
                return SecondValue;
            }
            else
            {
                return FirstValue;
            }
        }
        private static char GetMax(char FirstValue, char SecondValue)
        {
            if (FirstValue.CompareTo(SecondValue) <= 0)
            {
                return SecondValue;
            }
            else
            {
                return FirstValue;
            }
        }
        private static int GetMax(int FirstValue, int SecondValue)
        {
            if (FirstValue.CompareTo(SecondValue) <= 0)
            {
                return SecondValue;
            }
            else
            {
                return FirstValue;
            }
        }
    }
}
