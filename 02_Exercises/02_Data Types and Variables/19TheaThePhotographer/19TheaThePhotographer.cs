using System;
namespace _19TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long takenPics = int.Parse(Console.ReadLine());
            long filterTime = int.Parse(Console.ReadLine());
            long filterFactor = int.Parse(Console.ReadLine());
            long uploadTime = int.Parse(Console.ReadLine());

            long totalTimeInSec = takenPics * filterTime + (int)(Math.Ceiling(takenPics * (filterFactor * 0.01))) * uploadTime;
            long days = (totalTimeInSec - (totalTimeInSec % 60)) / (24 * 60 * 60);
            long hours = ((totalTimeInSec - (totalTimeInSec % 60)) - (days * 24 * 60 * 60)) / (60 * 60);
            long minutes = ((totalTimeInSec - (totalTimeInSec % 60)) - (days * 24 * 60 * 60) - (hours * 60 * 60)) / 60;
            long seconds = totalTimeInSec % 60;

            //seconds = totalTimeInSec % 60;
            //totalTimeInSec = totalTimeInSec - seconds;
            //hours = totalTimeInSec / 3600;
            //minutes = totalTimeInSec / 60 - hours * 60;
            //days = hours / 24;
            //hours = totalTimeInSec / 3600 - days * 24;
            Console.WriteLine("{0}:{1}:{2}:{3}", days, hours.ToString("00"), minutes.ToString("00"), seconds.ToString("00"));
        }
    }
}
