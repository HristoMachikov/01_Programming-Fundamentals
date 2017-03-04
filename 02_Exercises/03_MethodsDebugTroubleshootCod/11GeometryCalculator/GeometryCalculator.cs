namespace _11GeometryCalculator
{
    using System;

    public class GeometryCalculator
    {
        public static void Main()
        {
            string typeFigure = Console.ReadLine();
            typeFigure = typeFigure.ToLower();
            double area = 0.0;
            switch (typeFigure)
            {
                case "triangle":
                    area = AreaOfTriangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                    break;
                case "rectangle":
                    area = AreaOfRectangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                    break;
                case "square":
                    area = AreaOfSquare(double.Parse(Console.ReadLine()));
                    break;
                case "circle":
                    area = AreaOfCircle(double.Parse(Console.ReadLine()));
                    break;
            }

            Console.WriteLine("{0:f2}", area);
        }

        public static double AreaOfCircle(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        public static double AreaOfSquare(double side)
        {
            double area = side * side;
            return area;
        }

        public static double AreaOfRectangle(double sideA, double sideB)
        {
            double area = sideA * sideB;
            return area;
        }

        public static double AreaOfTriangle(double side, double height)
        {
            double area = side * height / 2;
            return area;
        }
    }
}
