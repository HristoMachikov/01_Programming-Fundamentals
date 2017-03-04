namespace _03UnicodeCharacters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UnicodeCharacters
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            foreach (char innerChar in input)
            {
                result.AppendFormat("\\u{0:x4}", (int)innerChar);
            }

            Console.WriteLine(result.ToString());
        }
    }
}