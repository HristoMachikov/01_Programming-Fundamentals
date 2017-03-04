namespace _02RotateAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RotateAndSum
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            string[] inputArray = input.Split(' ').ToArray();
            int[] newIntArray = new int[inputArray.Length];
            for (int i = 0; i < newIntArray.Length; i++)
            {
                newIntArray[i] = int.Parse(inputArray[i]);
            }

            int[] sumArray = new int[newIntArray.Length];
            for (int i = 0; i < times; i++)
            {
                int temp = newIntArray[newIntArray.Length - 1];
                for (int j = 0; j < newIntArray.Length - 1; j++)
                {
                    newIntArray[newIntArray.Length - 1 - j] = newIntArray[newIntArray.Length - 2 - j];
                }

                newIntArray[0] = temp;
                for (int k = 0; k < sumArray.Length; k++)
                {
                    if (i == 0)
                    {
                        sumArray[k] = newIntArray[k];
                    }
                    else
                    {
                        sumArray[k] += newIntArray[k];
                    }
                }
            }

            string output = string.Join(" ", sumArray);
            Console.WriteLine(output);
        }
    }
}