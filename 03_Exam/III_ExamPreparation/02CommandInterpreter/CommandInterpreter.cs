namespace _02CommandInterpreter
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CommandInterpreter
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandArray = command
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
                string action = commandArray[0];
                switch (action)
                {
                    case "reverse":
                        int reverseStartIndex = int.Parse(commandArray[2]);
                        int reverseCount = int.Parse(commandArray[4]);
                        ReverseCollection(reverseStartIndex, reverseCount, input);
                        break;

                    case "sort":
                        int sortStartIndex = int.Parse(commandArray[2]);
                        int sortCount = int.Parse(commandArray[4]);
                        SortCollection(sortStartIndex, sortCount, input);
                        break;

                    case "rollLeft":
                        int rollLeftCount = int.Parse(commandArray[1]);
                        input = RollLeftCollection(rollLeftCount, input);
                        break;

                    case "rollRight":
                        int rollRightCount = int.Parse(commandArray[1]);
                        input = RollRightCollection(rollRightCount, input);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", input));
        }

        private static void ReverseCollection(int reverseStartIndex, int reverseCount, List<string> input)
        {
            if (reverseStartIndex >= 0 && reverseStartIndex < input.Count && reverseCount >= 0 && reverseCount <= input.Count && reverseStartIndex + reverseCount <= input.Count)
            {
                input.Reverse(reverseStartIndex, reverseCount);
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }
        }

        private static void SortCollection(int sortStartIndex, int sortCount, List<string> input)
        {
            if (sortStartIndex >= 0 && sortStartIndex < input.Count && sortCount >= 0 && sortCount <= input.Count && sortStartIndex + sortCount <= input.Count)
            {
                List<string> result = input.Skip(sortStartIndex).Take(sortCount).OrderBy(x => x).ToList();
                input.RemoveRange(sortStartIndex, sortCount);
                input.InsertRange(sortStartIndex, result);
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }
        }

        private static List<string> RollLeftCollection(int rollLeftCount, List<string> input)
        {
            if (rollLeftCount >= 0)
            {
                int rollLeftNumb = rollLeftCount % input.Count;
                for (int i = 0; i < rollLeftNumb; i++)
                {
                    string temp = input[0];
                    for (int j = 1; j < input.Count; j++)
                    {
                        input[j - 1] = input[j];
                    }

                    input[input.Count - 1] = temp;
                }

                return input;
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
                return input;
            }
        }

        private static List<string> RollRightCollection(int rollRightCount, List<string> input)
        {
            if (rollRightCount >= 0)
            {
                int rollRigthNumb = rollRightCount % input.Count;
                for (int i = 0; i < rollRigthNumb; i++)
                {
                    string temp = input[input.Count - 1];
                    for (int j = input.Count - 1; j >= 1; j--)
                    {
                        input[j] = input[j - 1];
                    }

                    input[0] = temp;
                }

                return input;
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
                return input;
            }
        }
    }
}