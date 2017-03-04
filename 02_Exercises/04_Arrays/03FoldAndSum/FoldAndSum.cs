namespace _03FoldAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FoldAndSum
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ').ToArray();
            int[] total = new int[inputArray.Length];
            for (int i = 0; i < total.Length; i++)
            {
                total[i] = int.Parse(inputArray[i]);
            }

            int[] secondRow = new int[total.Length / 2];
            for (int i = 0; i < secondRow.Length; i++)
            {
                secondRow[i] = total[(total.Length / 4) + i];
            }

            int[] firstRow = new int[total.Length / 2];
            for (int i = 0; i < firstRow.Length / 2; i++)
            {
                firstRow[i] = total[(total.Length / 4) - i - 1];
            }

            for (int i = firstRow.Length / 2; i < firstRow.Length; i++)
            {
                firstRow[i] = total[total.Length - i - 1 + (firstRow.Length / 2)];
            }

            int[] sum = new int[total.Length / 2];
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = firstRow[i] + secondRow[i];
            }

            string output = string.Join(" ", sum);
            Console.WriteLine(output);
        }
    }
}
