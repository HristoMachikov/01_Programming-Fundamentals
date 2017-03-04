namespace _01SinoTheWalker
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text;

    public class SinoTheWalker
    {
        public static void Main()
        {
            DateTime startTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            int steps = int.Parse(Console.ReadLine());
            int timePerStep = int.Parse(Console.ReadLine());

            long startTimeInSeconds = (startTime.Hour * 60 * 60) + (startTime.Minute * 60) + startTime.Second;
            ulong totalTimeInSeconds = (ulong)startTimeInSeconds + ((ulong)steps * (ulong)timePerStep);

            ulong seconds = totalTimeInSeconds % 60;
            ulong totalMinutes = totalTimeInSeconds / 60;
            ulong minutes = totalMinutes % 60;
            ulong totalHours = totalMinutes / 60;
            ulong hours = totalHours % 24;

            Console.WriteLine("Time Arrival: {0}:{1}:{2}", hours.ToString("00"), minutes.ToString("00"), seconds.ToString("00"));
        }
    }
}