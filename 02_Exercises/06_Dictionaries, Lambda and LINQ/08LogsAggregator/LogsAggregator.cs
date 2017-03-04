namespace _08LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LogsAggregator
    {
        public static void Main()
        {
            int numb = int.Parse(Console.ReadLine());
            SortedDictionary<string, SortedDictionary<string, long>> myDateBase = new SortedDictionary<string, SortedDictionary<string, long>>();

            for (int i = 0; i < numb; i++)
            {
                string input = Console.ReadLine();
                string[] myInputArray = input.Split(' ');
                string user = myInputArray[1];
                string commingIP = myInputArray.First();
                long duration = long.Parse(myInputArray.Last());

                if (!myDateBase.ContainsKey(user))
                {
                    myDateBase[user] = new SortedDictionary<string, long>();
                }

                if (!myDateBase[user].ContainsKey(commingIP))
                {
                    myDateBase[user][commingIP] = 0;
                }

                myDateBase[user][commingIP] += duration;
            }

            foreach (var pair in myDateBase)
            {
                Console.Write("{0}: {1} ", pair.Key, pair.Value.Values.Sum());
                var outputList = new List<string>();
                foreach (var innerpair in pair.Value)
                {
                    outputList.Add(innerpair.Key);
                }

                Console.WriteLine(string.Format("[{0}]", string.Join(", ", outputList)));
            }
        }
    }
}