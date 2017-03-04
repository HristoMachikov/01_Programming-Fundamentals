namespace _01CountWorkDays
{
    using System;
    using System.Globalization;
    using System.Collections.Generic;
    using System.Linq;

    public class CountWorkDays
    {
        public static void Main()
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            int count = 0;
            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                DateTime currentDate = i;
                DateTime[] officialHolidays = new DateTime[] 
            {
              new DateTime(currentDate.Year,1,1),
              new DateTime(currentDate.Year,3,3),
              new DateTime(currentDate.Year,5,1),
              new DateTime(currentDate.Year,5,6),
              new DateTime(currentDate.Year,5,24),
              new DateTime(currentDate.Year,9,6),
              new DateTime(currentDate.Year,9,22),
              new DateTime(currentDate.Year,11,1),
              new DateTime(currentDate.Year,12,24),
              new DateTime(currentDate.Year,12,25),
              new DateTime(currentDate.Year,12,26)
             };

                if (i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday && !officialHolidays.Contains(i))
                {
                    count += 1;
                }
            }

            Console.WriteLine(count);
        }
    }
}