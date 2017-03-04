namespace _03ArrayManipulator
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
            var input = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var toDo = Console.ReadLine().Split(' ').ToArray();
            string command = toDo[0];

            while (command != "print")
            {
                switch (command)
                {
                    case "add":
                        InsertElement(input, toDo);
                        break;
                    case "addMany":
                        AddManyElements(input, toDo);
                        break;
                    case "contains":
                        IsContains(input, toDo);
                        break;
                    case "remove":
                        RemoveElementAtIndex(input, toDo);
                        break;
                    case "shift":
                        RotateToRight(input, toDo);
                        break;
                    case "sumPairs":
                        var inputNew = new List<long>(SumOfPairs(input));
                        input = new List<long>(inputNew);
                        break;
                    default:
                        break;
                }

                toDo = Console.ReadLine().Split(' ').ToArray();
                command = toDo[0];
            }

            if (command == "print")
            {
                Console.WriteLine("[{0}]", string.Join(", ", input));
            }
        }

        private static List<long> SumOfPairs(List<long> input)
        {
            var inputNew = new List<long>();
            if (input.Count % 2 == 0)
            {
                for (int i = 0; i < input.Count / 2; i++)
                {
                    inputNew.Add(input[2 * i] + input[(2 * i) + 1]);
                }
            }
            else
            {
                for (int i = 0; i < (input.Count - 1) / 2; i++)
                {
                    inputNew.Add(input[2 * i] + input[(2 * i) + 1]);
                }

                inputNew.Add(input[input.Count - 1]);
            }

            return inputNew;
        }

        private static void RotateToRight(List<long> input, string[] toDo)
        {
            int index = int.Parse(toDo[1]);
            var inputCopy = new List<long>(input);
            for (int i = 0; i < input.Count; i++)
            {
                input[i] = inputCopy[(i + index) % input.Count];
            }
        }

        private static void RemoveElementAtIndex(List<long> input, string[] toDo)
        {
            int index = int.Parse(toDo[1]);
            input.RemoveAt(index);
        }

        private static void InsertElement(List<long> input, string[] toDo)
        {
            int index = int.Parse(toDo[1]);
            int element = int.Parse(toDo[2]);
            input.Insert(index, element);
        }

        private static void AddManyElements(List<long> input, string[] toDo)
        {
            int index = int.Parse(toDo[1]);
            var elemRange = new List<long>();
            for (int i = 2; i < toDo.Length; i++)
            {
                int a = int.Parse(toDo[i]);
                elemRange.Add(a);
            }

            input.InsertRange(index, elemRange);
        }

        private static void IsContains(List<long> input, string[] toDo)
        {
            int element = int.Parse(toDo[1]);
            if (input.Contains(element))
            {
                Console.WriteLine(input.IndexOf(element));
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
