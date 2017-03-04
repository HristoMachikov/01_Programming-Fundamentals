namespace _01SweetDessert
{
    using System;

    public class SweetDessert
    {
        public static void Main()
        {
            decimal allMoney = decimal.Parse(Console.ReadLine());
            decimal guess = decimal.Parse(Console.ReadLine());
            decimal bannanasLv = decimal.Parse(Console.ReadLine());
            decimal eggesLv = decimal.Parse(Console.ReadLine());
            decimal berriesLv = decimal.Parse(Console.ReadLine());

            decimal allPortions = Math.Ceiling(guess / 6.0m);
            decimal productsMoney = allPortions * (2 * bannanasLv + 4 * eggesLv + 0.2m * berriesLv);
            if (productsMoney <= allMoney)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", productsMoney);
            }
            else
            {
                decimal neededMoney = productsMoney - allMoney;
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", neededMoney);
            }
        }
    }
}