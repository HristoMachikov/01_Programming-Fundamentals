namespace _07MaxSequenceOfIncreasingElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MaxSequenceOfIncreasingElements
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ').ToArray();
            long[] scanArray = new long[inputArray.Length];
            for (int i = 0; i < scanArray.Length; i++)
            {
                scanArray[i] = int.Parse(inputArray[i]);
            }

            long temp = scanArray[0];
            long count = 1;
            long maxCount = long.MinValue;
            long startTemp = 0;
            for (long i = 1; i < scanArray.Length; i++)
            {
                if (scanArray[i - 1] < scanArray[i])
                {
                    count += 1;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        startTemp = i + 1 - maxCount;
                    }
                }
                else
                {
                    temp = scanArray[i];
                    count = 1;
                }
            }

            var maxTempArray = new long[maxCount];
            for (long i = 0; i < maxTempArray.Length; i++)
            {
                maxTempArray[i] = scanArray[i + startTemp];
            }

            string output = string.Join(" ", maxTempArray);
            Console.WriteLine(output);
            //    string output = string.Join(string.Empty, inputArray).Substring(startTemp, maxCount);
            //    string result = string.Join<char>(" ", output);
            //    Console.WriteLine(result);
        }
    }
}