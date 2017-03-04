namespace _01LargestCommonEnd
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LargestCommonEnd
    {
        public static void Main()
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            string[] firstArray = firstInput.Split(' ').ToArray();
            string[] secondArray = secondInput.Split(' ').ToArray();

            int output = 0;
            if (firstArray.Length > secondArray.Length)
            {
                output = MaxFirstArray(firstArray, secondArray);
            }
            else if (firstArray.Length < secondArray.Length)
            {
                output = MaxSecondArray(firstArray, secondArray);
            }
            else if (firstArray.Length == secondArray.Length)
            {
                output = EqualArray(firstArray, secondArray);
            }

            Console.WriteLine(output);
        }

        private static int EqualArray(string[] firstArray, string[] secondArray)
        {
            int count = 0;
            for (int i = 0; i < secondArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    count += 1;
                }
            }

            return count;
        }

        private static int MaxFirstArray(string[] firstArray, string[] secondArray)
        {
            int count = 0;
            for (int i = 0; i < secondArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    count += 1;
                }
            }

            var firstArrayRev = firstArray.Clone() as string[];
            for (int i = 0; i < firstArrayRev.Length / 2; i++)
            {
                string oldElem = firstArrayRev[i];
                firstArrayRev[i] = firstArrayRev[firstArrayRev.Length - 1 - i];
                firstArrayRev[firstArrayRev.Length - 1 - i] = oldElem;
            }

            var secondArrayRev = secondArray.Clone() as string[];
            for (int i = 0; i < secondArrayRev.Length / 2; i++)
            {
                string oldElem = secondArrayRev[i];
                secondArrayRev[i] = secondArrayRev[secondArrayRev.Length - 1 - i];
                secondArrayRev[secondArrayRev.Length - 1 - i] = oldElem;
            }

            int countR = 0;
            for (int i = 0; i < secondArrayRev.Length; i++)
            {
                if (firstArrayRev[i] == secondArrayRev[i])
                {
                    countR += 1;
                }
            }

            return Math.Max(count, countR);
        }

        private static int MaxSecondArray(string[] firstArray, string[] secondArray)
        {
            int count = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    count += 1;
                }
            }

            var firstArrayRev = firstArray.Clone() as string[];
            for (int i = 0; i < firstArrayRev.Length / 2; i++)
            {
                string oldElem = firstArrayRev[i];
                firstArrayRev[i] = firstArrayRev[firstArrayRev.Length - 1 - i];
                firstArrayRev[firstArrayRev.Length - 1 - i] = oldElem;
            }

            var secondArrayRev = secondArray.Clone() as string[];
            for (int i = 0; i < secondArrayRev.Length / 2; i++)
            {
                string oldElem = secondArrayRev[i];
                secondArrayRev[i] = secondArrayRev[secondArrayRev.Length - 1 - i];
                secondArrayRev[secondArrayRev.Length - 1 - i] = oldElem;
            }

            int countR = 0;
            for (int i = 0; i < firstArrayRev.Length; i++)
            {
                if (firstArrayRev[i] == secondArrayRev[i])
                {
                    countR += 1;
                }
            }

            return Math.Max(count, countR);
        }
    }
}