namespace _11EqualSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EqualSums
    {
        public static void Main()
        {
            var output = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;
            bool check = false;

            for (int i = 0; i < output.Length; i++)
            {
                ////int leftSum = output.Take(i).Sum();
                ////int rightSum = output.Skip(i + 1).Sum();
                for (int left = 0; left < i; left++)
                {
                    leftSum += output[left];
                }

                for (int right = i + 1; right < output.Length; right++)
                {
                    rightSum += output[right];
                }

                if (leftSum == rightSum)
                {
                    check = true;
                    Console.WriteLine(i);
                    break;
                }

                leftSum = 0;
                rightSum = 0;
            }

            if (!check)
            {
                Console.WriteLine("no");
            }
        }
    }
}
