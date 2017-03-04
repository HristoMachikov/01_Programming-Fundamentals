namespace _08CenterPoint
{
    using System;

    public class CenterPoint
    {
        public static void Main()
        {
            double firstLineX1 = double.Parse(Console.ReadLine());
            double firstLineY1 = double.Parse(Console.ReadLine());
            double firstLineX2 = double.Parse(Console.ReadLine());
            double firstLineY2 = double.Parse(Console.ReadLine());

            var firstDist1 = DistanceToCenter(firstLineX1, firstLineY1);
            var firstDist2 = DistanceToCenter(firstLineX2, firstLineY2);

            if (firstDist1 <= firstDist2)
            {
                Console.WriteLine("({0}, {1})", firstLineX1, firstLineY1);
            }
            else
            {
                Console.WriteLine("({0}, {1})", firstLineX2, firstLineY2);
            }
        }

        public static double DistanceToCenter(double x, double y)
        {
            var distance = Math.Sqrt(RaiseToPower(x, 2) + RaiseToPower(y, 2));
            return distance;
        }

        public static double RaiseToPower(double numb, long pow)
        {
            double answer = 1.0;
            for (int i = 1; i <= pow; i++)
            {
                answer *= numb;
            }

            return answer;
        }
    }
}
