namespace _05RoundingNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RoundingNumbers
    {
        public static void Main()
        {
            string[] arrayOfNumb = Console.ReadLine().Trim().Split(' ');

            for (int i = 0; i < arrayOfNumb.Length; i++)
            {
                double numbDoub = double.Parse(arrayOfNumb[i]);
                int numbInt = (int)Math.Round(numbDoub, MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}",numbDoub,numbInt);
            }
        }
    }
}
