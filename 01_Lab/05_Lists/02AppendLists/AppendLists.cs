namespace _02AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AppendLists
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split('|').ToArray();
            List<int> output = new List<int>();
            char[] separators = new char[] {' '};
            for (int i = input.Length - 1; i >= 0; i--)
            {
                var groups = input[i].Split(separators,StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                output.AddRange(groups);
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
