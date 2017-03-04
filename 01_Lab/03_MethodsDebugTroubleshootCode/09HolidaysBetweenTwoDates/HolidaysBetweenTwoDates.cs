using System;
using System.Linq;
using System.Globalization;
using System.Data;

namespace _09HolidaysBetweenTwoDates
{
    public class HolidaysBetweenTwoDates
    {
        public static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();

            string[] firstDate = firstInput.Split('.').ToArray();
            string[] secondDate = secondInput.Split('.').ToArray();
            int daysF = firstDate[0].Length;
            int monthF = firstDate[1].Length;
            int daysS = secondDate[0].Length;
            int monthS = secondDate[1].Length;
            string formatF, formatS;
            if (daysF == 1)
            {
                if (monthF == 1)
                {
                    formatF = "d.M.yyyy";
                }
                else
                {
                    formatF = "d.MM.yyyy";
                }
            }
            else
            {
                if (monthF == 1)
                {
                    formatF = "dd.M.yyyy";
                }
                else
                {
                    formatF = "dd.MM.yyyy";
                }
            }
            if (daysS == 1)
            {
                if (monthS == 1)
                {
                    formatS = "d.M.yyyy";
                }
                else
                {
                    formatS = "d.MM.yyyy";
                }
            }
            else
            {
                if (monthS == 1)
                {
                    formatS = "dd.M.yyyy";
                }
                else
                {
                    formatS = "dd.MM.yyyy";
                }
            }
            var holidaysCount = 0;
            DateTime startDate = DateTime.ParseExact(firstInput, formatF, CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(secondInput, formatS, CultureInfo.InvariantCulture);
            DateTime date = startDate;
            //while (date <= endDate)
            for (date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
                //date = date.AddDays(1);
            }
            Console.WriteLine(holidaysCount);
        }
    }
}
