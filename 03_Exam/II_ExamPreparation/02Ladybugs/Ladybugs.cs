namespace _02Ladybugs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Ladybugs
    {
        public static void Main()
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            long[] indexOfLadybug = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .Where(x => x >= 0 && x < sizeOfField)
                .ToArray();

            long[] ladybugArray = new long[sizeOfField];
            for (int i = 0; i < sizeOfField; i++)
            {
                if (indexOfLadybug.Contains(i))
                {
                    ladybugArray[i] = 1;
                }
                else
                {
                    ladybugArray[i] = 0;
                }
            }

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandArray = command.Split();
                long currentIndex = long.Parse(commandArray[0]);
                string direction = commandArray[1];
                long flyLength = long.Parse(commandArray[2]);
                if (currentIndex >= 0 && currentIndex < ladybugArray.Length && ladybugArray[currentIndex] == 1)
                {
                    long nextIndex = CalcNextIndex(currentIndex, direction, flyLength);
                    ladybugArray[currentIndex] = 0;
                    if (nextIndex >= 0 && nextIndex < ladybugArray.Length)
                    {
                        if (ladybugArray[nextIndex] == 0)
                        {
                            ladybugArray[nextIndex] = 1;
                        }
                        else if (ladybugArray[nextIndex] == 1)
                        {
                            while (nextIndex >= 0 && nextIndex < ladybugArray.Length)
                            {
                                currentIndex = nextIndex;
                                if (ladybugArray[nextIndex] == 0)
                                {
                                    ladybugArray[nextIndex] = 1;
                                    break;
                                }

                                nextIndex = CalcNextIndex(currentIndex, direction, flyLength);
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", ladybugArray));
        }

        private static long CalcNextIndex(long currentIndex, string direction, long flyLength)
        {
            long nextIndex = 0;
            if (direction == "left")
            {
                nextIndex = currentIndex - flyLength;
            }
            else if (direction == "right")
            {
                nextIndex = currentIndex + flyLength;
            }

            return nextIndex;
        }
    }
}