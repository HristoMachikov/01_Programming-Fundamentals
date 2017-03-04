namespace _07AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Customer
    {
        public string Name { get; set; }

        public Dictionary<string, int> ShopList { get; set; }

        public decimal TotalPrice { get; set; }

        public decimal CalulatePrice(int count, decimal price)
        {
            return count * price;
        }
    }
}