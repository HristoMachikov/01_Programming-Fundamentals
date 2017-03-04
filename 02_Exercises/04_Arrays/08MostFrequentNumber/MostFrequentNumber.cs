namespace _08MostFrequentNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MostFrequentNumber
    {
        public static void Main()
        {
            var scanArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int count = 1;
            int maxCount = 0;
            int maxTemp = scanArray[0];
            for (int i = 0; i < scanArray.Length; i++)
            {
                for (int j = 0; j < scanArray.Length; j++)
                {
                    if (i != j)
                    {
                        if (scanArray[i] == scanArray[j])
                        {
                            count += 1;
                            if (count > maxCount)
                            {
                                maxCount = count;
                                maxTemp = scanArray[i];
                            }
                        }
                    }
                }

                count = 1;
            }

            Console.WriteLine(maxTemp);
        }
    }
}