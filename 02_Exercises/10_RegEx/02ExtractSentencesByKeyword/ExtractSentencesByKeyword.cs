namespace _02ExtractSentencesByKeyword
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractSentencesByKeyword
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            string sentence = Console.ReadLine();
            MatchCollection matches = Regex.Matches(sentence, @"(\w+.*?[.?!])");
            foreach (Match match in matches)
            {
                if (Regex.IsMatch(match.ToString(), "\\b" + word + "\\b"))
                {
                    Console.WriteLine(match.ToString().Trim(new char[] { '.', '?', '!' }));
                }
            }
        }
    }
}