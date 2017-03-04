namespace _05ClosestTwoPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ClosestTwoPoints
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ');
                Point inputPoint = new Point()
                {
                    X = int.Parse(input[0]),
                    Y = int.Parse(input[1])
                };
                points[i] = inputPoint;
            }

            double minDist = double.MaxValue;
            Point p1 = new Point();
            Point p2 = new Point();
            for (int i = 0; i < points.Length - 1; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double distance = FindClosestPoints(points[i], points[j]);
                    if (distance < minDist)
                    {
                        minDist = distance;
                        p1 = points[i];
                        p2 = points[j];
                    }
                }
            }

            Console.WriteLine("{0:f3}", minDist);
            Console.WriteLine("({0}, {1})", p1.X, p1.Y);
            Console.WriteLine("({0}, {1})", p2.X, p2.Y);
        }

        private static double FindClosestPoints(Point point1, Point point2)
        {
            double xDiff = Math.Abs(point1.X - point2.X);
            double yDiff = Math.Abs(point1.Y - point2.Y);
            double dist = Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));

            return dist;
        }
    }
}