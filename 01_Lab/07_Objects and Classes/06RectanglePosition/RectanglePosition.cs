namespace _06RectanglePosition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RectanglePosition
    {
        public static void Main()
        {
            int[] firstRectanglArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] secondRectangleArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Rectangle firstRec = new Rectangle();
            firstRec.Left = firstRectanglArr[0];
            firstRec.Top = firstRectanglArr[1];
            firstRec.Width = firstRectanglArr[2];
            firstRec.Height = firstRectanglArr[3];

            Rectangle secondRec = new Rectangle()
            {
                Left = secondRectangleArr[0],
                Top = secondRectangleArr[1],
                Width = secondRectangleArr[2],
                Height = secondRectangleArr[3]
            };

            if (IsInside(firstRec, secondRec))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        private static bool IsInside(Rectangle firstRec, Rectangle secondRec)
        {
            return firstRec.Left >= secondRec.Left
                && firstRec.Right <= secondRec.Right
                && firstRec.Top >= secondRec.Top
                && firstRec.Bottom <= secondRec.Bottom;
        }
    }
}
