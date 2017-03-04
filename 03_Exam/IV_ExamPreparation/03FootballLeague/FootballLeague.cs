namespace _03FootballLeague
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class FootballLeague
    {
        public static void Main()
        {
            string key = Console.ReadLine();
            Dictionary<string, long> allGoals = new Dictionary<string, long>();
            Dictionary<string, long> allPoints = new Dictionary<string, long>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "final")
                {
                    break;
                }
                else
                {
                    string escapedPattern = Regex.Escape(key);
                    string pattern = escapedPattern + @"(.*?)" + escapedPattern + @".*?" + escapedPattern + @"(.*?)" + escapedPattern + @".*?(\d+):(\d+)";
                    Regex regex = new Regex(pattern);
                    Match match = regex.Match(input);

                    if (match.Success)
                    {
                        char[] theFirst = match.Groups[1].Value.Reverse().ToArray();
                        string firstTeam = new string(theFirst).ToUpper();
                        char[] theSecond = match.Groups[2].Value.Reverse().ToArray();
                        string secondTeam = new string(theSecond).ToUpper();
                        long golsFirstTeam = long.Parse(match.Groups[3].Value);
                        long golsSecondTeam = long.Parse(match.Groups[4].Value);

                        int pointsFirst = 0;
                        int pointsSecond = 0;
                        if (golsFirstTeam > golsSecondTeam)
                        {
                            pointsFirst = 3;
                        }
                        else if (golsFirstTeam < golsSecondTeam)
                        {
                            pointsSecond = 3;
                        }
                        else
                        {
                            pointsFirst = 1;
                            pointsSecond = 1;
                        }

                        if (!allPoints.ContainsKey(firstTeam))
                        {
                            allPoints[firstTeam] = 0;
                        }

                        allPoints[firstTeam] += pointsFirst;

                        if (!allPoints.ContainsKey(secondTeam))
                        {
                            allPoints[secondTeam] = 0;
                        }

                        allPoints[secondTeam] += pointsSecond;

                        if (!allGoals.ContainsKey(firstTeam))
                        {
                            allGoals[firstTeam] = 0;
                        }

                        allGoals[firstTeam] += golsFirstTeam;

                        if (!allGoals.ContainsKey(secondTeam))
                        {
                            allGoals[secondTeam] = 0;
                        }

                        allGoals[secondTeam] += golsSecondTeam;
                    }
                }
            }

            allPoints = allPoints
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            allGoals = allGoals
               .OrderByDescending(x => x.Value)
               .ThenBy(x => x.Key)
               .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("League standings:");
            int count = 0;
            foreach (var team in allPoints)
            {
                count++;
                Console.WriteLine("{0}. {1} {2}", count, team.Key, team.Value);
            }

            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in allGoals.Take(3))
            {
                Console.WriteLine("- {0} -> {1}", team.Key, team.Value);
            }
        }
    }
}