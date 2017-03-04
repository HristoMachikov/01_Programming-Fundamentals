namespace _01CharityMarathon
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {

            var maratonDays = decimal.Parse(Console.ReadLine());
            var runners = decimal.Parse(Console.ReadLine());
            var averageLabsPerRunner = decimal.Parse(Console.ReadLine());
            var lengthOfTrack = decimal.Parse(Console.ReadLine());
            var capacityOfTrack = decimal.Parse(Console.ReadLine());
            decimal moneyDonated = decimal.Parse(Console.ReadLine());

            decimal participantRunners = runners;
            if (runners > capacityOfTrack * maratonDays)
            {
                participantRunners = capacityOfTrack * maratonDays;
            }

            var totalMeters = participantRunners * averageLabsPerRunner * lengthOfTrack * moneyDonated * 0.001m;
            Console.WriteLine("Money raised: {0:f2}", totalMeters);
        }
    }
}