namespace _04HornetArmada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Region
    {
        public int LastActivity { get; set; }

        public Dictionary<string, long> SoldierType { get; set; }
    }

    public class HornetArmada
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, Region> allRegions = new Dictionary<string, Region>();
            for (int i = 0; i < number; i++)
            {
                string[] inputArray = Console.ReadLine()
                    .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string[] legionArray = inputArray.First()
                    .Trim()
                    .Split(new[] { " = " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();

                string[] soldierArray = inputArray.Last()
                    .Trim()
                    .Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();

                int currentActivity = int.Parse(legionArray.First());
                string currentLegion = legionArray.Last();
                string currentSoldierType = soldierArray.First();
                int currentCount = int.Parse(soldierArray.Last());

                if (!allRegions.ContainsKey(currentLegion))
                {
                    allRegions[currentLegion] = new Region()
                    {
                        LastActivity = currentActivity,
                        SoldierType = new Dictionary<string, long>()
                    };
                }

                if (!allRegions[currentLegion].SoldierType.ContainsKey(currentSoldierType))
                {
                    allRegions[currentLegion].SoldierType[currentSoldierType] = 0;
                }

                allRegions[currentLegion].SoldierType[currentSoldierType] += currentCount;

                if (allRegions[currentLegion].LastActivity < currentActivity)
                {
                    allRegions[currentLegion].LastActivity = currentActivity;
                }
            }

            string command = Console.ReadLine();
            string checkSoldier = string.Empty;
            if (command.Contains('\\'))
            {
                string[] commandArray = command
                    .Trim()
                    .Split('\\')
                    .Select(x => x.Trim())
                    .ToArray();
                int checkActivity = int.Parse(commandArray.First());
                checkSoldier = commandArray.Last();

                allRegions = allRegions
                    .Where(x => x.Value.LastActivity < checkActivity)
                    .ToDictionary(x => x.Key, x => x.Value);
                Dictionary<string, long> resultRegions = new Dictionary<string, long>();

                foreach (var region in allRegions)
                {
                    foreach (var soldier in region.Value.SoldierType.Where(x => x.Key == checkSoldier))
                    {
                        resultRegions[region.Key] = soldier.Value;
                    }
                }

                foreach (var legion in resultRegions.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("{0} -> {1}", legion.Key, legion.Value);
                }
            }
            else
            {
                checkSoldier = command;

                foreach (var region in allRegions.OrderByDescending(x => x.Value.LastActivity))
                {
                    foreach (var soldier in region.Value.SoldierType.Where(x => x.Key == checkSoldier))
                    {
                        Console.WriteLine("{0} : {1}", region.Value.LastActivity, region.Key);
                    }
                }
            }
        }
    }
}