namespace _02Reverse_ArrayOfIntegers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ReverseArrayOfIntegers
    {
        public static void Main()
        {
            int numb = int.Parse(Console.ReadLine());
            int [] arrayOfNumb=new int[numb];
            int[] revArrayOfNumb = new int[numb];
            for (int i = 0; i < arrayOfNumb.Length; i++)
            {
                arrayOfNumb[i] = int.Parse(Console.ReadLine());
                revArrayOfNumb[arrayOfNumb.Length - 1 - i] = arrayOfNumb[i];
            }
            var result = string.Join(" ", revArrayOfNumb);
            Console.WriteLine(result);
        }
    }
}
