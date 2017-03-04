namespace _07ReplaceATag
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class ReplaceATag
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                string myPattern = @"<a.*?href=(""|')(.*)\1>(.*?)<\/a>";
                Regex myRegex = new Regex(myPattern);
                string replace = @"[URL href=""$2""]$3[/URL]";
                string result = myRegex.Replace(input, replace);

                Console.WriteLine(result);
                input = Console.ReadLine();
            }
        }
    }
}