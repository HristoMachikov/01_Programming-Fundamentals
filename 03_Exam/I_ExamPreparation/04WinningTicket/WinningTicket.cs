namespace _04WinningTicket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class WinningTicket
    {
        public static void Main()
        {
            string[] allTickets = Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            string[] winingSymbols = new[] { "@", "#", "\\$", "\\^" };

            foreach (var ticket in allTickets)
            {
                string leftHalf = new string(ticket.Take(10).ToArray());
                string rightHalf = new string(ticket.Skip(10).ToArray());
                if (ticket.Length == 20)
                {
                    bool checkMatch = false;
                    foreach (var symbol in winingSymbols)
                    {
                        string minRepeatTimes = symbol + "{6,}";
                        Regex myRegex = new Regex(minRepeatTimes);
                        Match matchLeft = myRegex.Match(leftHalf);
                        if (matchLeft.Success)
                        {
                            Match matchRight = myRegex.Match(rightHalf);
                            if (matchRight.Success)
                            {
                                int minMatchLength = Math.Min(matchLeft.Length, matchRight.Length);
                                var isJackpot = matchRight.Length == 10 && matchLeft.Length == 10
                                    ? " Jackpot!"
                                    : string.Empty;
                                Console.WriteLine("ticket \"{0}\" - {1}{2}{3}", ticket, minMatchLength, symbol.Last(), isJackpot);
                                checkMatch = true;
                                break;
                            }
                        }
                    }

                    if (!checkMatch)
                    {
                        Console.WriteLine("ticket \"{0}\" - no match", ticket);
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}