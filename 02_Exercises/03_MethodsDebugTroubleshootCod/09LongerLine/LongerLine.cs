namespace _09LongerLine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LongerLine
    {
        public static void Main()
        {
            double firstLineX1 = double.Parse(Console.ReadLine());
            double firstLineY1 = double.Parse(Console.ReadLine());
            double firstLineX2 = double.Parse(Console.ReadLine());
            double firstLineY2 = double.Parse(Console.ReadLine());
            double secondLineX1 = double.Parse(Console.ReadLine());
            double secondLineY1 = double.Parse(Console.ReadLine());
            double secondLineX2 = double.Parse(Console.ReadLine());
            double secondLineY2 = double.Parse(Console.ReadLine());

            var firstLenght = LenghtOfLine(firstLineX1, firstLineY1, firstLineX2, firstLineY2);
            var secondLenght = LenghtOfLine(secondLineX1, secondLineY1, secondLineX2, secondLineY2);

            var firstDist1 = DistanceToCenter(firstLineX1, firstLineY1);
            var firstDist2 = DistanceToCenter(firstLineX2, firstLineY2);
            var secondDist1 = DistanceToCenter(secondLineX1, secondLineY1);
            var secondDist2 = DistanceToCenter(secondLineX2, secondLineY2);
            if (firstLenght > secondLenght)
            {
                if (firstDist1 <= firstDist2)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", firstLineX1, firstLineY1, firstLineX2, firstLineY2);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", firstLineX2, firstLineY2, firstLineX1, firstLineY1);
                }
            }
            else if (firstLenght < secondLenght)
            {
                if (secondDist1 <= secondDist2)
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", secondLineX1, secondLineY1, secondLineX2, secondLineY2);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", secondLineX2, secondLineY2, secondLineX1, secondLineY1);
                }
            }
            else
            {
                var minFirst = Math.Min(firstDist1, firstDist2);
                var minSecond = Math.Min(secondDist1, secondDist2);
                if (minFirst < minSecond)
                {
                    if (firstDist1 <= firstDist2)
                    {
                        Console.WriteLine("({0}, {1})({2}, {3})", firstLineX1, firstLineY1, firstLineX2, firstLineY2);
                    }
                    else
                    {
                        Console.WriteLine("({0}, {1})({2}, {3})", firstLineX2, firstLineY2, firstLineX1, firstLineY1);
                    }
                }
                else
                {
                    if (secondDist1 <= secondDist2)
                    {
                        Console.WriteLine("({0}, {1})({2}, {3})", secondLineX1, secondLineY1, secondLineX2, secondLineY2);
                    }
                    else
                    {
                        Console.WriteLine("({0}, {1})({2}, {3})", secondLineX2, secondLineY2, secondLineX1, secondLineY1);
                    }
                }
            }
        }

        public static double DistanceToCenter(double X, double Y)
        {
            var distance = Math.Sqrt(RaiseToPower(X, 2) + RaiseToPower(Y, 2));
            return distance;
        }

        public static double LenghtOfLine(double X1, double Y1, double X2, double Y2)
        {
            var lenght = Math.Sqrt(RaiseToPower(X1 - X2, 2) + RaiseToPower(Y1 - Y2, 2));
            return lenght;
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
