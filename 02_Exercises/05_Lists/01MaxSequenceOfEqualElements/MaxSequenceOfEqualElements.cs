namespace _01MaxSequenceOfEqualElements
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
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int count = 1;
            int previews = input[0];
            int maxCount = 1;
            int maxValue = previews;
            for (int i = 1; i < input.Count; i++)
            {
                int current = input[i];
                if (current == previews)
                {
                    count += 1;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxValue = previews;
                    }
                }
                else
                {
                    previews = current;
                    count = 1;
                }
            }

            var output = new List<int>();
            for (int i = 0; i < maxCount; i++)
            {
                output.Add(maxValue);
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
