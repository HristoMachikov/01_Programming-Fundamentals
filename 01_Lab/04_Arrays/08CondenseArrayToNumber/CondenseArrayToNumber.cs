namespace _08CondenseArrayToNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CondenseArrayToNumber
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ').ToArray();
            long[] intArray = new long[inputArray.Length];
            for (long i = 0; i < inputArray.Length; i++)
            {
                intArray[i] = long.Parse(inputArray[i]);
            }

            long[] newIntArray = intArray.Clone() as long[];
            for (long i = 0; i < intArray.Length; i++)
            {
                for (long j = 0; j < intArray.Length - i - 1; j++)
                {
                    long temp = newIntArray[j];

                    newIntArray[j] = newIntArray[j + 1] + temp;
                }
            }

            Console.WriteLine(newIntArray[0]);
        }
    }
}