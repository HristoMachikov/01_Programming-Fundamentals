namespace _09LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LegendaryFarming
    {
        public static void Main()
        {
            var junkDict = new Dictionary<string, int>();
            var obtainedDict = new Dictionary<string, int>();
            obtainedDict.Add("shards", 0);
            obtainedDict.Add("fragments", 0);
            obtainedDict.Add("motes", 0);

            while (obtainedDict["shards"] < 250 && obtainedDict["fragments"] < 250 && obtainedDict["motes"] < 250)
            {
                string input = Console.ReadLine();
                string[] myInputArray = input.ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 1; i < myInputArray.Length; i += 2)
                {
                    if (obtainedDict["shards"] >= 250 || obtainedDict["fragments"] >= 250 || obtainedDict["motes"] >= 250)
                    {
                        break;
                    }

                    string material = myInputArray[i];
                    int quantity = int.Parse(myInputArray[i - 1]);

                    if (!obtainedDict.ContainsKey(material))
                    {
                        if (!junkDict.ContainsKey(material))
                        {
                            junkDict[material] = quantity;
                        }
                        else
                        {
                            junkDict[material] += quantity;
                        }
                    }
                    else
                    {
                        obtainedDict[material] += quantity;
                    }
                }
            }

            if (obtainedDict["shards"] >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                obtainedDict["shards"] -= 250;
            }
            else if (obtainedDict["fragments"] >= 250)
            {
                Console.WriteLine("Valanyr obtained!");
                obtainedDict["fragments"] -= 250;
            }
            else if (obtainedDict["motes"] >= 250)
            {
                Console.WriteLine("Dragonwrath obtained!");
                obtainedDict["motes"] -= 250;
            }

            obtainedDict = obtainedDict
                .OrderByDescending(pair => pair.Value)
                .ThenBy(pair => pair.Key)
                .ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var pair in obtainedDict)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }

            junkDict = junkDict
                .OrderBy(pair => pair.Key)
                .ToDictionary(pair => pair.Key, pair => pair.Value);
            foreach (var pair in junkDict)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }
        }
    }
}