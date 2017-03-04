using System;

namespace _08MultiplyEvensByOdds
{
    public class MultiplyEvensByOdds
    {
       public static void Main()
        {
            int input =int.Parse(Console.ReadLine());
            //if (input < 0)
            //{
            //    input *= -1;
            //}
            int result = GetOddSum(input) * GetEvenSum(input);
            Console.WriteLine(result);
        }

       public static int GetEvenSum(int number)
       {
          int sumEven=0;
          foreach (var digit in number.ToString())
          {
              var remainder = digit - '0';
              if (remainder % 2 == 1)
              {
                  sumEven += remainder;
              }
          }
          return sumEven;
       }

       public static int GetOddSum(int number)
       {
           int sumOdd = 0;
           foreach (var digit in number.ToString())
           {
               var remainder = digit - '0';
               if (remainder % 2 == 0)
               {
                   sumOdd += remainder;
               }
           }

           return sumOdd;
       }
    }
}
