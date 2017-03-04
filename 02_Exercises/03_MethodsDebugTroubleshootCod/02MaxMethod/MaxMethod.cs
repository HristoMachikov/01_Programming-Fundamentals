namespace _02MaxMethod
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public class MaxMethod
    {
        public static void Main()
        {
            var inputList = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                int input = int.Parse(Console.ReadLine());
                inputList.Add(input);
            }

            int maxValue = inputList.Max();
            Console.WriteLine(maxValue);
        }
    }
}
