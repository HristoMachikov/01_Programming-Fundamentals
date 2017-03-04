namespace _05UseYourChainsBuddy
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

    public class UseYourChainsBuddy
    {
        public static void Main()
        {
            //string input = File.ReadAllText(@"..\..\Input.txt");
            string input = Console.ReadLine();
            string pattern = @"<p>(.*?)<\/p>";
            string notLowerOrDigit = @"[^a-z0-9]";
            string lower = @"[a-z]+";
            string emptySpaces = @"\s+";
            MatchCollection matches = Regex.Matches(input, pattern);
            StringBuilder sb = new StringBuilder();
            foreach (Match match in matches)
            {
                string currentString = match.Groups[1].ToString();
                currentString = Regex.Replace(currentString, notLowerOrDigit, " ");
                MatchEvaluator myEvaluator = new MatchEvaluator(AfterHalfAlphabet);
                currentString = Regex.Replace(currentString, lower, myEvaluator);
                currentString = Regex.Replace(currentString, emptySpaces, " ");
                sb.Append(currentString);
            }

            string output = sb.ToString();
            Console.WriteLine(output);
        }

        public static string AfterHalfAlphabet(Match match)
        {
            StringBuilder result = new StringBuilder();
            char[] alphabet = new char[26]
            { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            for (int i = 0; i < match.Value.Length; i++)
            {
                int index = match.Value[i] - 'a';
                char resultChar = alphabet[(index + 13) % alphabet.Length];
                result.Append(resultChar);
            }

            return result.ToString();
        }
    }
}