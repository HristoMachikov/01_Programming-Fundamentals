namespace _03CirclesIntersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CirclesIntersection
    {
        public static void Main()
        {
            int[] firstCircleArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] secondCircleArr = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToArray();

            Point centerFirst = new Point()
            {
                X = firstCircleArr[0],
                Y = firstCircleArr[1]
            };

            Circle firstCircle = new Circle()
            {
                Center = centerFirst,
                Radius = firstCircleArr[2]
            };

            Point centerSecond = new Point()
            {
                X = secondCircleArr[0],
                Y = secondCircleArr[1]
            };

            Circle secondCircle = new Circle()
            {
                Center = centerSecond,
                Radius = secondCircleArr[2]
            };

            if (IsIntersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static bool IsIntersect(Circle firstCircle, Circle secondCircle)
        {
            int horiz = firstCircle.Center.X - secondCircle.Center.X;
            int vert = firstCircle.Center.Y - secondCircle.Center.Y;
            double distence = Math.Sqrt(Math.Pow(horiz, 2) + Math.Pow(vert, 2));
            return distence <= firstCircle.Radius + secondCircle.Radius;
        }
    }
}