namespace _10СръбскоUnleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class СръбскоUnleashed
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> myDateBase = new Dictionary<string, Dictionary<string, int>>();
            while (input != "End")
            {
                string correctInputPattern = @"(([a-zA-Z]+\s){1,3})@(([a-zA-Z]+\s){1,3})(\d+)\s(\d+)";

                if (Regex.IsMatch(input, correctInputPattern))
                {
                    Match match = Regex.Match(input, correctInputPattern);

                    string name = match.Groups[1].Value.Trim();
                    string venue = match.Groups[3].Value.Trim();
                    int ticketsPrice = int.Parse(match.Groups[5].Value);
                    int ticketsCount = int.Parse(match.Groups[6].Value);
                    int tickets = ticketsPrice * ticketsCount;

                    if (!myDateBase.ContainsKey(venue))
                    {
                        myDateBase[venue] = new Dictionary<string, int>();
                    }

                    if (!myDateBase[venue].ContainsKey(name))
                    {
                        myDateBase[venue][name] = 0;
                    }

                    myDateBase[venue][name] += tickets;
                }

                input = Console.ReadLine();
            }

            foreach (var pair in myDateBase)
            {
                Console.WriteLine("{0}", pair.Key);
                foreach (var innerpair in pair.Value.OrderByDescending(key => key.Value))
                {
                    Console.WriteLine(string.Format("#  {0} -> {1}", innerpair.Key, innerpair.Value));
                }
            }
        }
    }
}