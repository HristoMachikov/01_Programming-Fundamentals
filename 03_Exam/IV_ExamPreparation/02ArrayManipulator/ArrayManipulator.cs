namespace _02ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ArrayManipulator
    {
        public static void Main()
        {
            try
            {
                int[] inputArray = Console.ReadLine()
                .Trim()
                .Split()
                .Select(int.Parse)
                .ToArray();
                while (true)
                {
                    string currentCommand = Console.ReadLine();
                    if (currentCommand == "end")
                    {
                        break;
                    }
                    else
                    {
                        string[] currentCommandArray = currentCommand
                            .Split()
                            .ToArray();
                        string command = currentCommandArray[0];
                        string evenOrOdd = string.Empty;
                        switch (command)
                        {
                            case "exchange":
                                int index = int.Parse(currentCommandArray.Last());
                                inputArray = Exchange(inputArray, index);
                                break;
                            case "max":
                            case "min":
                                string maxOrMin = currentCommandArray.First();
                                evenOrOdd = currentCommandArray.Last();
                                inputArray = MaxOrMinEvenOrOdd(inputArray, maxOrMin, evenOrOdd);
                                break;
                            case "first":
                            case "last":
                                string firstOrLast = currentCommandArray.First();
                                evenOrOdd = currentCommandArray.Last();
                                int elements = int.Parse(currentCommandArray[1]);
                                inputArray = FirstnEvenOrOdd(inputArray, firstOrLast, evenOrOdd, elements);
                                break;
                        }
                    }
                }

                Console.WriteLine("[{0}]", string.Join(", ", inputArray));
            }
            catch (System.FormatException)
            {
            }
        }

        private static int[] FirstnEvenOrOdd(int[] inputArray, string firstOrLast, string evenOrOdd, int elements)
        {
            int[] outputArray;
            var result = (evenOrOdd == "even")
                ? outputArray = inputArray.Where(x => x % 2 == 0).ToArray()
                : outputArray = inputArray.Where(x => x % 2 != 0).ToArray();

            if (elements > inputArray.Length || elements <= 0)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                if (outputArray.Any())
                {
                    if (elements > outputArray.Length)
                    {
                        elements = outputArray.Length;
                    }

                    int[] currentResult;
                    var isTrue = (firstOrLast == "first")
                ? currentResult = outputArray.Take(elements).ToArray()
                : currentResult = outputArray.Reverse().Take(elements).Reverse().ToArray();

                    Console.WriteLine("[{0}]", string.Join(", ", currentResult));
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }

            return inputArray;
        }

        private static int[] Exchange(int[] inputArray, int index)
        {
            if (index < 0 || index > inputArray.Length - 1)
            {
                Console.WriteLine("Invalid index");
                return inputArray;
            }
            else
            {
                int[] leftArray = inputArray.Take(index + 1).ToArray();
                int[] rightArray = inputArray.Skip(index + 1).Take(inputArray.Length - 1 - index).ToArray();
                int[] outputArray = rightArray.Concat(leftArray).ToArray();
                return outputArray;
            }
        }

        private static int[] MaxOrMinEvenOrOdd(int[] inputArray, string maxOrMin, string evenOrOdd)
        {
            int[] outputArray;
            var result = (evenOrOdd == "even")
                ? outputArray = inputArray.Where(x => x % 2 == 0).ToArray()
                : outputArray = inputArray.Where(x => x % 2 != 0).ToArray();
            int value = 0;
            var valueMaxMin = (maxOrMin == "max")
                ? value = int.MinValue
                : value = int.MaxValue;

            if (outputArray.Any())
            {
                int check = 0;
                if (evenOrOdd == "odd")
                {
                    check = 1;
                }

                int count = 0;
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (inputArray[i] >= value && inputArray[i] % 2 == check && maxOrMin == "max")
                    {
                        value = inputArray[i];
                        count = i;
                    }

                    if (inputArray[i] <= value && inputArray[i] % 2 == check && maxOrMin == "min")
                    {
                        value = inputArray[i];
                        count = i;
                    }
                }

                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine("No matches");
            }

            return inputArray;
        }
    }
}