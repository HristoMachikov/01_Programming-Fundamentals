namespace _04CubicMessages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class CubicMessages
    {
        public static void Main()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Over!")
                {
                    break;
                }

                int number = int.Parse(Console.ReadLine());
                string key = "{" + number + "}";
                string pattern = @"^(\d+)([a-zA-Z]" + key + @")([^a-zA-Z]*?)$";
                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string message = match.Groups[2].Value;
                    string firstPart = match.Groups[1].Value;
                    string lastPart = match.Groups[3].Value;

                    StringBuilder sb = new StringBuilder();
                    foreach (var digit in firstPart)
                    {
                        int currentDigit = digit - '0';
                        if (currentDigit < message.Length)
                        {
                            sb.Append(message[currentDigit]);
                        }
                        else
                        {
                            sb.Append(' ');
                        }
                    }

                    MatchCollection matches = Regex.Matches(lastPart, @"\d");
                    foreach (Match digit in matches)
                    {
                        int currentDigit = int.Parse(digit.ToString());
                        if (currentDigit < message.Length)
                        {
                            sb.Append(message[currentDigit]);
                        }
                        else
                        {
                            sb.Append(' ');
                        }
                    }

                    string verificationCode = sb.ToString();
                    Console.WriteLine("{0} == {1}", message, verificationCode);
                }
            }
        }
    }
}