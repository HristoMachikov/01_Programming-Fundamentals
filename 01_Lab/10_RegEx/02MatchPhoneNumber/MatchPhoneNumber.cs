namespace _02MatchPhoneNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            string text = "+359 2 222 2222 +359-2-222-2222	359-2-222-2222, +359/2/222/2222, +359-2 222 2222 +359 2-222-2222, +359-2-222-222, +359-2-222-22222";
            string pattern = @"\+359( |-)2\1[0-9]{3}\1[0-9]{4}\b";
            Regex myRegex = new Regex(pattern);
            MatchCollection result = myRegex.Matches(text);
            foreach (Match mach in result)
            {
                Console.WriteLine(mach);
            }
        }
    }
}