namespace _07SumArrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SumArrays
    {
        public static void Main()
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();

            string[] firstArray = firstInput.Split(' ').ToArray();
            string[] secondArray = secondInput.Split(' ').ToArray();

            int[] firstIntArray = new int[firstArray.Length];
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstIntArray[i] = int.Parse(firstArray[i]);
            }

            int[] secondIntArray = new int[secondArray.Length];
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondIntArray[i] = int.Parse(secondArray[i]);
            }

            int[] maxIntArray = new int[Math.Max(firstIntArray.Length, secondIntArray.Length)];
            for (int i = 0; i < maxIntArray.Length; i++)
            {
                maxIntArray[i] = firstIntArray[i % firstIntArray.Length] + secondIntArray[i % secondIntArray.Length];
            }

            string output = string.Join(" ", maxIntArray);
            Console.WriteLine(output);
        }
    }
}
