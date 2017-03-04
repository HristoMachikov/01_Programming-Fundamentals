namespace _10CubeProperties
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CubeProperties
    {
        public static void Main()
        {
            decimal sideOfCube = decimal.Parse(Console.ReadLine());
            string parameter = Console.ReadLine().ToLower();
            if (sideOfCube >= 0)
            {
                decimal result = 0.0m;
                switch (parameter)
                {
                    case "face":
                        result = CalcFaceDiagon(sideOfCube);
                        break;
                    case "space":
                        result = CalcSpaceDiagon(sideOfCube);
                        break;
                    case "volume":
                        result = CalcCubeVolume(sideOfCube);
                        break;
                    case "area":
                        result = CalcCubeArea(sideOfCube);
                        break;
                }

                Console.WriteLine("{0:f2}", result);
            }
        }

        public static decimal CalcCubeArea(decimal side)
        {
            decimal cubeArea = RaiseToPower(side, 2) * 6;
            return cubeArea;
        }

        public static decimal CalcCubeVolume(decimal side)
        {
            decimal cubeVolume = RaiseToPower(side, 3);
            return cubeVolume;
        }

        public static decimal CalcSpaceDiagon(decimal side)
        {
            decimal root = RaiseToPower(side, 2);
            double rootDbl = (double)root;
            decimal spaceDiagon = (decimal)Math.Sqrt(3 * rootDbl);
            return spaceDiagon;
        }

        public static decimal CalcFaceDiagon(decimal side)
        {
            decimal root = RaiseToPower(side, 2);
            double rootDbl = (double)root;
            decimal faceDiagon = (decimal)Math.Sqrt(2 * rootDbl);
            return faceDiagon;
        }

        public static decimal RaiseToPower(decimal numb, long pow)
        {
            decimal answer = 1.0m;
            for (int i = 1; i <= pow; i++)
            {
                answer *= numb;
            }

            return answer;
        }
    }
}
