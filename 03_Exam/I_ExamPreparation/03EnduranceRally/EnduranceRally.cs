namespace _03EnduranceRally
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class EnduranceRally
    {
        public static void Main()
        {
            string[] drivers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] trackLayout = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int[] checkpoints = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            foreach (var driver in drivers)
            {
                decimal startingFuel = driver.First();
                int zoneNumb = 0;
                for (int i = 0; i < trackLayout.Length; i++)
                {
                    if (checkpoints.Contains(i))
                    {
                        startingFuel += decimal.Parse(trackLayout[i]);
                    }
                    else
                    {
                        startingFuel -= decimal.Parse(trackLayout[i]);
                    }
                    if (startingFuel <= 0)
                    {
                        zoneNumb = i;
                        break;
                    }
                }
                if (startingFuel <= 0)
                {
                    Console.WriteLine("{0} - reached {1}", driver, zoneNumb);
                }
                else
                {
                    Console.WriteLine("{0} - fuel left {1:f2}", driver, startingFuel);
                }
            }
        }
    }
}