namespace _02LongestIncreasingSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestIncreasingSubsequence
    {
        public static void Main()
        {
            var inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] myLen = new int[inputArray.Length];
            int[] myPrev = new int[inputArray.Length];
            int maxLength = 0;
            int prevIndex = -1;

            for (int i = 0; i < inputArray.Length; i++)
            {
                myLen[i] = 1;
                myPrev[i] = -1;
                for (int j = 0; j < i; j++)
                {
                    if ((inputArray[j] < inputArray[i]) && (myLen[j] >= myLen[i]))
                    {
                        myLen[i] = myLen[j] + 1;
                        myPrev[i] = j;
                    }
                }

                if (myLen[i] > maxLength)
                {
                    maxLength = myLen[i];
                    prevIndex = i;
                }
            }

            var outputLongest = new List<int>();
            for (int i = 0; i < maxLength; i++)
            {
                outputLongest.Add(inputArray[prevIndex]);
                prevIndex = myPrev[prevIndex];
            }

            outputLongest.Reverse();
            Console.WriteLine(string.Join(" ", outputLongest));
        }
    }
}