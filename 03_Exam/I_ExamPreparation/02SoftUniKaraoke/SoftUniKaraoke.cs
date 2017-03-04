namespace _02SoftUniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SoftUniKaraoke
    {
        public static void Main()
        {
            string[] participants = Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            string[] songs = Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            Dictionary<string, List<string>> allParticipants = new Dictionary<string, List<string>>();

            string currentPerformance = Console.ReadLine();
            while (currentPerformance != "dawn")
            {
                string[] currentPerformArray = currentPerformance
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();
                string participant = currentPerformArray[0];
                string song = currentPerformArray[1];
                string award = currentPerformArray[2];
                if (participants.Contains(participant) && songs.Contains(song))
                {
                    if (!allParticipants.ContainsKey(participant))
                    {
                        allParticipants[participant] = new List<string>();
                    }

                    if (!allParticipants[participant].Contains(award))
                    {
                        allParticipants[participant].Add(award);
                    }
                }

                currentPerformance = Console.ReadLine();
            }

            if (allParticipants.Any())
            {
                allParticipants = allParticipants
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

                foreach (var kvp in allParticipants)
                {
                    var singer = kvp.Key;
                    var wins = kvp.Value;
                    Console.WriteLine("{0}: {1} awards", singer, wins.Count());
                    foreach (var win in wins.OrderBy(x => x))
                    {
                        Console.WriteLine("--{0}", win);
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}