namespace _05HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HandsOfCards
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> namePower = new Dictionary<string, Dictionary<string, int>>();
            while (input != "JOKER")
            {
                List<string> inputArray = input.Split(':').ToList();
                List<string> powerTypeArray = inputArray[1].Split(new char[] {',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string name = inputArray[0];

                if (!namePower.ContainsKey(name))
                {
                    namePower[name] = new Dictionary<string, int>();
                }

                foreach (var item in powerTypeArray)
                {
                    if (namePower.ContainsKey(name) && !namePower[name].ContainsKey(item))
                    {
                        namePower[name][item] = CardPower(item);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var names in namePower)
            {
                Console.WriteLine("{0}: {1}", names.Key, names.Value.Values.Sum());
            }
        }

        private static int CardPower(string item)
        {
            int totalValue = 0;
            int firstValue = 0;
            int secondValue = 0;
            char last = item.Last();
            char first = item.First();
            switch (last)
            {
                case 'S':
                    secondValue = 4;
                    break;
                case 'H':
                    secondValue = 3;
                    break;
                case 'D':
                    secondValue = 2;
                    break;
                case 'C':
                    secondValue = 1;
                    break;
            }

            switch (first)
            {
                case 'J':
                    firstValue = 11;
                    break;
                case 'Q':
                    firstValue = 12;
                    break;
                case 'K':
                    firstValue = 13;
                    break;
                case 'A':
                    firstValue = 14;
                    break;
            }

            if (first != 'J' && first != 'Q' && first != 'K' && first != 'A' && first != '1')
            {
                firstValue = first - '0';
            }

            if (first == '1')
            {
                firstValue = int.Parse(item.Substring(0, item.Length - 1));
            }

            totalValue = firstValue * secondValue;
            return totalValue;
        }
    }
}