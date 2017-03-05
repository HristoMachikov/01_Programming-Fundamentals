namespace _02_Problem
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public class DoublePalindromes
    {
        public static void Main()
        {
            //List<int> result = new List<int>() { 0, 1 };
            //int index = 2;
            //while (result.Count < 29)
            //{
            //    int number = index;
            //    int secondCheck = 0;
            //    string numberToString = index.ToString();
            //    if (numberToString.Length > 1)
            //    {
            //        for (int i = 0; i < numberToString.Length / 2; i++)
            //        {
            //            if (numberToString[i] == numberToString[numberToString.Length - 1 - i])
            //            {
            //                secondCheck++;
            //            }
            //            else
            //            {
            //                break;
            //            }
            //        }
            //    }

            //    if (secondCheck == numberToString.Length / 2)
            //    {
            //        string outputArray = Convert.ToString(number, 2);

            //        //string output = string.Empty;
            //        //while (number != 0)
            //        //{
            //        //    BigInteger toBeConcat = number % 2;
            //        //    output += toBeConcat;
            //        //    number = number / 2;
            //        //}

            //        //char[] outputArray = output.ToCharArray();

            //        int firstCheck = 0;
            //        for (int i = 0; i < outputArray.Length / 2; i++)
            //        {
            //            if (outputArray[i] == outputArray[outputArray.Length - 1 - i])
            //            {
            //                firstCheck++;
            //            }
            //            else
            //            {
            //                break;
            //            }
            //        }

            //        if (firstCheck == outputArray.Length / 2)
            //        {
            //            result.Add(index);
            //        }
            //    }

            //    index++;
            //}

            //Console.WriteLine(string.Join(", ", result));

            int numb=int.Parse(Console.ReadLine());
            string[] inputArray = File.ReadAllLines(@"../../Input.txt");
            List<string> output = new List<string>();
            foreach (var line in inputArray)
            {
                string[] result = line
                    .Trim()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                output.Add(result[3]);
            }
            Console.WriteLine(string.Join(", ", output));
        }
    }
}