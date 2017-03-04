namespace _03SequenceOfCommands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public class Program
    {
       public const char ArgumentsDelimiter = ' ';

        public static void Main(string[] args)
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();
            string[] stringParams = command.Trim().Split(ArgumentsDelimiter);
            string commandToDo = stringParams[0];
            while (!commandToDo.Equals("stop"))
            {
                if (commandToDo.Equals("add") || commandToDo.Equals("subtract") || commandToDo.Equals("multiply"))
                {
                    int[] argum = new int[2];
                    argum[0] = int.Parse(stringParams[1]);
                    argum[1] = int.Parse(stringParams[2]);
                    array = PerformAction(array, commandToDo, argum);
                }
                else if (commandToDo.Equals("lshift"))
                {
                    array = ArrayShiftLeft(array);
                }
                else if (commandToDo.Equals("rshift"))
                {
                    array = ArrayShiftRight(array);
                }

                string result = string.Join(" ", array);
                Console.WriteLine(result + " ");
                command = Console.ReadLine();
                stringParams = command.Trim().Split(ArgumentsDelimiter);
                commandToDo = stringParams[0];
            }
        }

        public static long[] PerformAction(long[] arr, string action, int[] args)
        {
            long[] array = arr.Clone() as long[];
            int pos = args[0] - 1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos] *= value;
                    break;
                case "add":
                    array[pos] += value;
                    break;
                case "subtract":
                    array[pos] -= value;
                    break;
            }

            return array;
        }

        public static long[] ArrayShiftRight(long[] array)
        {
            long temp = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = temp;
            return array;
        }

        public static long[] ArrayShiftLeft(long[] array)
        {
            long temp = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Length - 1] = temp;
            return array;
        }
    }
}
