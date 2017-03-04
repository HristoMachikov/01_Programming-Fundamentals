namespace _03RageQuit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Pairs
    {
        public string PairsString { get; set; }

        public int PairsNumber { get; set; }
    }

    public class RageQuit
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"([^\d]+)(\d+)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            List<Pairs> allStringNumb = new List<Pairs>();
            HashSet<char> uniqueSymbols = new HashSet<char>();
            foreach (Match match in matches)
            {
                int currentNumber = int.Parse(match.Groups[2].Value.ToString());
                char[] currentSymbols = match.Groups[1].Value.ToUpper().ToArray();
                if (currentNumber > 0)
                {
                    foreach (var symbol in currentSymbols)
                    {
                        uniqueSymbols.Add(symbol);
                    }
                }

                string currentString = new string(currentSymbols);
                Pairs currentPair = new Pairs
                {
                    PairsString = currentString,
                    PairsNumber = currentNumber
                };
                allStringNumb.Add(currentPair);
            }

            StringBuilder sb = new StringBuilder();
            foreach (var pair in allStringNumb)
            {
                int repeat = pair.PairsNumber;
                if (pair.PairsNumber > 20)
                {
                    repeat = 20;
                }

                for (int i = 0; i < repeat; i++)
                {
                    sb.Append(pair.PairsString);
                }
            }

            string result = sb.ToString();
            Console.WriteLine("Unique symbols used: {0}", uniqueSymbols.Count);
            Console.WriteLine(result);
        }
    }
}