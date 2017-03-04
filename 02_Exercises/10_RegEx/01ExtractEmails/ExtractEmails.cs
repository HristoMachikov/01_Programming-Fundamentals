namespace _01ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"([a-zA-Z0-9_\.-]+(:?\.|-|_)?[a-zA-Z0-9]+)@(([a-zA-Z]+-?[a-zA-Z]+)(\.[a-zA-Z]+)+)";
            Regex formatEmail = new Regex(pattern);
            MatchCollection matches = formatEmail.Matches(input);
            foreach (Match match in matches)
            {
                string user = match.Groups[1].ToString();
                if (!(user.StartsWith("-") || user.StartsWith("_") || user.StartsWith(".")
                    || user.EndsWith("-") || user.EndsWith("_") || user.EndsWith(".")))
                {
                    Console.WriteLine(match.ToString());
                }
            }
        }
    }
}