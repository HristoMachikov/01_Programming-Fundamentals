namespace _07PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PopulationCounter
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> myDateBase = new Dictionary<string, Dictionary<string, long>>();
            while (input != "report")
            {
                string[] myInputArray = input.Split('|');
                string city = myInputArray.First();
                string country = myInputArray[1];
                int population = int.Parse(myInputArray.Last());

                if (!myDateBase.ContainsKey(country))
                {
                    myDateBase[country] = new Dictionary<string, long>();
                }

                if (!myDateBase[country].ContainsKey(city))
                {
                    myDateBase[country][city] = 0;
                }

                myDateBase[country][city] += population;
                input = Console.ReadLine();
            }

            myDateBase = myDateBase
                .OrderByDescending(pair => pair.Value.Values.Sum())
                .ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var pair in myDateBase)
            {
                Console.WriteLine("{0} (total population: {1})", pair.Key, pair.Value.Values.Sum());
                foreach (var innerpair in pair.Value.OrderByDescending(key => key.Value))
                {
                    Console.WriteLine("=>{0}: {1}", innerpair.Key, innerpair.Value);
                }
            }
        }
    }
}