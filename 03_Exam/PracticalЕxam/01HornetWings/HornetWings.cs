namespace _01HornetWings
{
    using System;
    using System.Numerics;

    public class HornetWings
    {
        public static void Main()
        {
            long wingFlaps = long.Parse(Console.ReadLine());
            decimal distanceInMeters = decimal.Parse(Console.ReadLine());
            long endurance = long.Parse(Console.ReadLine());

            decimal totalDistance = wingFlaps * 0.001m * distanceInMeters;
            decimal secondsForWinning = wingFlaps * 0.01m;
            decimal seconsdForRest = wingFlaps / endurance * 5;
            decimal totalSeconds = secondsForWinning + seconsdForRest;

            Console.WriteLine("{0:f2} m.", totalDistance);
            Console.WriteLine("{0:f0} s.", totalSeconds);
        }
    }
}