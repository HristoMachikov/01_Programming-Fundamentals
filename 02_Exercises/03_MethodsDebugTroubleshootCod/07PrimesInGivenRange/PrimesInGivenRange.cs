namespace _07PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PrimesInGivenRange
    {
        public static void Main()
        {
            int firstNumb = int.Parse(Console.ReadLine());
            int secondNumb = int.Parse(Console.ReadLine());
            if (firstNumb < 2 && secondNumb < 2)
            {
                return;
            }

            if (firstNumb < 2 && secondNumb > 2)
            {
                firstNumb = 2;
            }
           
            List<int> listOfPrimeNumbers = FindPrimesInRange(firstNumb, secondNumb);
            string printResult = string.Join(", ", listOfPrimeNumbers);
            Console.WriteLine(printResult);
        }

        public static List<int> FindPrimesInRange(int firstValue, int secondValue)
        {
            List<int> primeNumbers = new List<int>();
            for (int i = firstValue; i <= secondValue; i++)
            {
                int check = 0;
                for (int j = 2; j <= i; j++)
                {
                    check = j;
                    if (i % j == 0)
                    {
                        break;
                    }
                }

                if (check == i)
                {
                    primeNumbers.Add(i);
                }  
            }

            return primeNumbers;
        }
    }
}