namespace _01DayOfWeek
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Globalization;
    using System.Linq;   

    public class DayOfWeek
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int[] inputArr = input.Split('-').Select(x => int.Parse(x)).ToArray();
            int day = inputArr[0];
            int month = inputArr[1];
            int year = inputArr[2];

            DateTime inputDate = new DateTime(year, month, day);
            ////inputDate = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(inputDate.DayOfWeek);
        }
    }
}