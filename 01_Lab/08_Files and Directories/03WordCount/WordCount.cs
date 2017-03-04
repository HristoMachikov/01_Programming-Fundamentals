namespace _03WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class WordCount
    {
        public static void Main()
        {
            string[] words = File.ReadAllText(@"..\..\words.txt").Split();
            string[] input = File.ReadAllText(@"..\..\Input.txt").Split(new char[] { ',', '.', '!', ' ', '?', '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray(); ;
            int[] count = new int[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                for (int j = 0; j < input.Length; j++)
                {
                    if (currentWord.ToLower() == input[j].ToLower())
                    {
                        count[i] += 1;
                    }
                }
            }

            Dictionary<string, int> output = new Dictionary<string, int>();
            for (int i = 0; i < count.Length; i++)
            {
                output.Add(words[i], count[i]);
            }
            output = output
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var pair in output)
            {
                string result = pair.Key + " - " + pair.Value;
                File.AppendAllText(@"..\..\Output.txt", result + Environment.NewLine);
            }
        }
    }
}
