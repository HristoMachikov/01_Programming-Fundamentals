namespace _04DistanceBetweenPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var firstPointArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondPointArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point first = new Point()
            {
                X = firstPointArr[0],
                Y = firstPointArr[1]
            };

            Point second = new Point();
            second.X = secondPointArr[0];
            second.Y = secondPointArr[1];

            double distence = CalculateDistance(first, second);
            Console.WriteLine("{0:f3}", distence);
        }

        public static double CalculateDistance(Point p1, Point p2)
        {
            double xDiff = Math.Abs(p1.X - p2.X);
            double yDiff = Math.Abs(p1.Y - p2.Y);
            double result = Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));

            return result;
        }
    }
}
