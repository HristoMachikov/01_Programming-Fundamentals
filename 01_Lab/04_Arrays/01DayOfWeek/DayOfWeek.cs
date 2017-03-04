namespace _01DayOfWeek
{
    using System;

    public class DayOfWeek
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] dayOfWeek = { "Invalid Day!", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (n < 0 || n > 7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(dayOfWeek[n]);
            }
        }
    }
}
