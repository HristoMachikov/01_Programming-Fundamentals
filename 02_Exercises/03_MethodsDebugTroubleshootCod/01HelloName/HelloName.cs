namespace _01HelloName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HelloName
    {
       public  static void Main()
        {
            string input = Console.ReadLine();
            PrintCongratulatio(input);
        }

       private static void PrintCongratulatio(string param)
       {
           Console.WriteLine("Hello, {0}!",param);
       }
    }
}
