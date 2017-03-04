using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06MathPower
{
   public class MathPower
    {
       public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            long power = long.Parse(Console.ReadLine());
            double result = RaiseToPower(number, power);
            Console.WriteLine(result);
        }

       public static double RaiseToPower(double numb, long pow)
       {
           double answer = 1;
           for (int i = 1; i <= pow; i++)
           {
               answer *= numb;
           }
           return answer;
       }
    }
}
