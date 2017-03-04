namespace _01SoftuniCoffeeOrders
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SoftuniCoffeeOrders
    {
        public static void Main()
        {
            long countOfOrders = long.Parse(Console.ReadLine());
            decimal[] allPrices = new decimal[countOfOrders];
            for (int i = 0; i < allPrices.Length; i++)
            {
                decimal pricePerCapsul = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsulesCount = long.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                decimal priceForCoffee = daysInMonth * (decimal)capsulesCount * pricePerCapsul;
                allPrices[i] = priceForCoffee;
            }

            foreach (var price in allPrices)
            {
                Console.WriteLine("The price for the coffee is: ${0:f2}", price);
            }

            Console.WriteLine("Total: ${0:f2}", allPrices.Sum());
        }
    }
}