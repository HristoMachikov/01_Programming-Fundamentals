using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            try
            {
                char vowel = Convert.ToChar(input);
                if (vowel >= 'a' && vowel <= 'z')
                {
                    if (vowel == 'a' || vowel == 'o' || vowel == 'u' || vowel == 'e' || vowel == 'i')
                    {
                        Console.WriteLine("vowel");
                    }
                    else
                    {
                        Console.WriteLine("other");
                    }
                    return;
                }
            }
            catch (System.FormatException)
            {
            }

            try
            {
            int digit = Convert.ToInt32(input);
            Console.WriteLine("digit");
            return;
            }
            catch (System.FormatException)
            {
            }
            Console.WriteLine("other");
        }
    }
}
