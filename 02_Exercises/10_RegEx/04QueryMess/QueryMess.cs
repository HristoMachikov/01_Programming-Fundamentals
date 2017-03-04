namespace _04QueryMess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class QueryMess
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(\+|%20)+";
            while (input != "END")
            {
                MatchCollection matches = Regex.Matches(input, @"([^?&]+)=([^?&]+)");
                Dictionary<string, List<string>> currentResult = new Dictionary<string, List<string>>();
                foreach (Match match in matches)
                {
                    string innerKeys = match.Groups[1].ToString();
                    innerKeys = Regex.Replace(innerKeys, pattern, " ").Trim();
                    List<string> innerKeysColect = innerKeys.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    string key = string.Join(" ", innerKeysColect);

                    string innerValues = match.Groups[2].ToString();
                    innerValues = Regex.Replace(innerValues, pattern, " ").Trim();
                    List<string> innerValuesColect = innerValues.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    string value = string.Join(" ", innerValuesColect);

                    if (!currentResult.ContainsKey(key))
                    {
                        currentResult[key] = new List<string>();
                    }

                    currentResult[key].Add(value);
                }

                foreach (var pair in currentResult)
                {
                    Console.Write("{0}=[{1}]", pair.Key, string.Join(", ", pair.Value));
                }

                Console.WriteLine();
                input = Console.ReadLine();
            }
        }
    }
}