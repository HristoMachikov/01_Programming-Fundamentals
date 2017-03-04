namespace _06UserLogs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UserLogs
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            SortedDictionary<string, Dictionary<string, int>> myDateBase = new SortedDictionary<string, Dictionary<string, int>>();
            while (input != "end")
            {
                string[] myInputArray = input.Split('=');
                string name = myInputArray.Last();
                string newIP = myInputArray[1].Split(' ').First();

                if (!myDateBase.ContainsKey(name))
                {
                    myDateBase[name] = new Dictionary<string, int>();
                }

                if (!myDateBase[name].ContainsKey(newIP))
                {
                    myDateBase[name][newIP] = 0;
                }

                myDateBase[name][newIP] += 1;
                input = Console.ReadLine();
            }

            foreach (var person in myDateBase)
            {
                Console.WriteLine("{0}:", person.Key);
                string output = string.Empty;
                var outputList = new List<string>();
                foreach (var adresses in person.Value)
                {
                    output = string.Format("{0} => {1}", adresses.Key, adresses.Value);
                    outputList.Add(output);
                }

                Console.Write(string.Join(", ", outputList));
                Console.WriteLine('.');
            }
        }
    }
}
