namespace _06MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MaxSequenceOfEqualElements
    {
       public static void Main()
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ').ToArray();
            int[] scanArray = new int[inputArray.Length];
            for (int i = 0; i < scanArray.Length; i++)
            {
                scanArray[i] = int.Parse(inputArray[i]);
            }

            int temp = scanArray[0];
            int count = 1;
            int maxCount = int.MinValue;
            int maxTemp = int.MinValue;
            for (int i = 1; i < scanArray.Length; i++)
            {
                if (temp == scanArray[i])
                {
                    count += 1;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxTemp = temp;
                    }
                }
                else
                {
                    temp = scanArray[i];
                    count = 1;
                }
            }

            var maxTempArray = new int[maxCount];
            for (int i = 0; i < maxTempArray.Length; i++)
            {
                maxTempArray[i] = maxTemp;
            }

            string output = string.Join(" ", maxTempArray);
            Console.WriteLine(output);
        }
    }
}
