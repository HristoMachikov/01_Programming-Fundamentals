using System;
using System.Numerics;

namespace _10CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds
            int centuries = int.Parse(Console.ReadLine());
            int years = 100 * centuries;
            int days = (int)(365.2422 * years);
            long hours = 24 * days;
            long minutes = 60 * hours;
            long seconds = 60 * minutes;
            long milliseconds = 1000 * seconds;
            long microseconds = 1000 * milliseconds;
            BigInteger nanoseconds = (BigInteger) 1000 * microseconds;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);
        }
    }
}
