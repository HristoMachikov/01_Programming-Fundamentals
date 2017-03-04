namespace _10PairsByDifference
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PairsByDifference
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int difference = int.Parse(Console.ReadLine());

            string[] inputArray = input.Split(' ').ToArray();
            long[] scanArray = new long[inputArray.Length];
            for (int i = 0; i < scanArray.Length; i++)
            {
                scanArray[i] = int.Parse(inputArray[i]);
            }
  
            long count = 0;
            long maxCount = 0;
            Array.Sort(scanArray);
            long preview = scanArray[0];
            for (int i = 1; i < scanArray.Length; i++)
            {
                long current = scanArray[i];
                if (current - preview <= difference)
                {
                    for (int j = i; j < scanArray.Length; j++)
                    {
                        if (scanArray[j] - preview == difference)
                        {
                            count += 1;
                            if (count > maxCount)
                            {
                                maxCount = count;
                            }
                        }
                        else if (scanArray[j] - preview > difference)
                        {
                            break;
                        }
                    }
                }

                preview = scanArray[i];
            }

            Console.WriteLine(maxCount);
        }
    }
}
