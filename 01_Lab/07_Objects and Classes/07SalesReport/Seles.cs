namespace _07SalesReport
{
   public class Seles
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public double Total
        {
            get
            {
                return Quantity * Price;
            }
        }
    }
}
