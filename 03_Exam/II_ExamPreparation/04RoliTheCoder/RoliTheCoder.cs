namespace _04RoliTheCoder
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Event
    {
        public string Name { get; set; }

        public List<string> Peoples { get; set; }
    }

    public class RoliTheCoder
    {
        public static void Main()
        {
            ////string[] inputArray = File.ReadAllLines(@"../../Input.txt");
            ////int count = 0;
            ////string input = inputArray[count];
            string input = Console.ReadLine();
            var allEvent = new Dictionary<string, Event>();
            while (input != "Time for Code")
            {
                if (input.Contains('#'))
                {
                    string[] currentEvent = input
                        .Split('#')
                        .Select(x => x.Trim())
                        .ToArray();
                    string ID = currentEvent[0];
                    string name = string.Empty;
                    List<string> eventNameNumb = new List<string>();
                    if (!currentEvent[1].Contains("@"))
                    {
                        name = currentEvent[1];
                    }
                    else
                    {
                        eventNameNumb = currentEvent[1]
                       .Split('@')
                       .Select(x => x.Trim())
                       .ToList();
                        name = eventNameNumb[0];
                    }

                    if (!allEvent.ContainsKey(ID))
                    {
                        allEvent[ID] = new Event()
                        {
                            Name = name,
                            Peoples = new List<string>()
                        };
                    }

                    if (allEvent[ID].Name == name)
                    {
                        for (int i = 1; i < eventNameNumb.Count; i++)
                        {
                            string nextName = eventNameNumb[i];
                            if (!allEvent[ID].Peoples.Contains(nextName))
                            {
                                allEvent[ID].Peoples.Add(nextName);
                            }
                        }
                    }
                }
                ////count += 1;
                ////input = inputArray[count];
                input = Console.ReadLine();
            }

            if (allEvent.Any())
            {
                allEvent = allEvent
                    .OrderByDescending(x => x.Value.Peoples.Count)
                    .ThenBy(x => x.Value.Name)
                    .ToDictionary(x => x.Key, x => x.Value);
                foreach (var kvp in allEvent)
                {
                    Console.WriteLine("{0} - {1}", kvp.Value.Name, kvp.Value.Peoples.Count);
                    foreach (var people in kvp.Value.Peoples.OrderBy(x => x))
                    {
                        Console.WriteLine("@{0}", people);
                    }
                }
            }
        }
    }
}