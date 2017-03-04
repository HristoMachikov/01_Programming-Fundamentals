namespace _03HornetAssault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class HornetAssault
    {
        public static void Main()
        {
            long[] beehives = Console.ReadLine()
                .Trim()
                .Split()
                .Select(long.Parse)
                .ToArray();
            long[] hornets = Console.ReadLine()
                 .Trim()
                 .Split()
                 .Select(long.Parse)
                 .ToArray();

            long powerOfHornets = hornets.Sum();
            int hornetIndex = 0;
            if (powerOfHornets > 0)
            {
                for (int i = 0; i < beehives.Length; i++)
                {
                    long currentAmountBees = beehives[i];
                    if (currentAmountBees >= powerOfHornets)
                    {
                        beehives[i] = currentAmountBees - powerOfHornets;
                        hornets[hornetIndex] = 0;
                        hornetIndex++;
                        powerOfHornets = hornets.Sum();
                        if (powerOfHornets <= 0)
                        {
                            break;
                        }
                    }
                    else
                    {
                        beehives[i] = 0;
                    }
                }
            }

            List<long> beehivesRest = new List<long>();
            List<long> hornetsRest = new List<long>();
            beehivesRest = beehives.Where(x => x > 0).ToList();
            hornetsRest = hornets.Where(x => x > 0).ToList();
            if (beehivesRest.Any())
            {
                Console.WriteLine(string.Join(" ", beehivesRest));
            }
            else if (hornetsRest.Any())
            {
                Console.WriteLine(string.Join(" ", hornetsRest));
            }
        }
    }
}