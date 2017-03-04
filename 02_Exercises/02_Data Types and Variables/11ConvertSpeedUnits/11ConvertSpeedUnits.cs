using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float dist = float.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minuites = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float timeInSec = 60 * 60 * hours + 60 * minuites + seconds;
            float speedInMS = dist / timeInSec;
            float speedInKH = (float)(speedInMS * 3.6);
            float speedInMH = (float)(speedInMS * (3600 / 1609.0));
            Console.WriteLine(speedInMS);
            Console.WriteLine(speedInKH);
            Console.WriteLine(speedInMH);
        }
    }
}
