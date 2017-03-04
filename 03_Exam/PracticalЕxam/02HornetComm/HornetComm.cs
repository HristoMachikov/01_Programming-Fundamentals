namespace _02HornetComm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Message
    {
        public string Mess { get; set; }

        public string Code { get; set; }
    }

    public class Broadcast
    {
        public string Message { get; set; }

        public string Frequency { get; set; }
    }

    public class HornetComm
    {
        public static void Main()
        {
            List<Message> messages = new List<Message>();
            List<Broadcast> broadcasts = new List<Broadcast>();
            string messagePattern = @"^(\d+) <-> ([\da-zA-Z]+)$";
            string broadcastPattern = @"^([^\d]+) <-> ([\da-zA-Z]+)$";
            Regex messageRegex = new Regex(messagePattern);
            Regex broadcastRegex = new Regex(broadcastPattern);

            string input = Console.ReadLine();
            int counter = 1;

            while (true)
            {
                if (input == "Hornet is Green"
                    || counter > 1000)
                {
                    break;
                }
                else
                {
                    Match messageMatch = messageRegex.Match(input);
                    if (messageMatch.Success)
                    {
                        char[] code = messageMatch.Groups[1].Value.Reverse().ToArray();
                        string reversedCode = new string(code);
                        string messege = messageMatch.Groups[2].Value;

                        Message currentMessage = new Message()
                        {
                            Code = reversedCode,
                            Mess = messege
                        };

                        messages.Add(currentMessage);
                    }

                    Match broadcastMatch = broadcastRegex.Match(input);
                    if (broadcastMatch.Success)
                    {
                        string messege = broadcastMatch.Groups[1].Value;
                        string frequency = broadcastMatch.Groups[2].Value;

                        StringBuilder sb = new StringBuilder();
                        foreach (char symbol in frequency)
                        {
                            char currentSymbol = symbol;
                            if (!char.IsDigit(symbol))
                            {
                                if (char.IsUpper(symbol))
                                {
                                    currentSymbol = Char.ToLower(symbol);
                                }
                                else
                                {
                                    currentSymbol = Char.ToUpper(symbol);
                                }
                            }
                            sb.Append(currentSymbol);
                        }

                        string changedFrequency = sb.ToString();
                        Broadcast currentBroadcast = new Broadcast()
                        {
                            Message = messege,
                            Frequency = changedFrequency
                        };
                        broadcasts.Add(currentBroadcast);
                    }
                }

                input = Console.ReadLine();
                counter++;
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Any())
            {
                foreach (var broadcast in broadcasts)
                {
                    Console.WriteLine("{0} -> {1}", broadcast.Frequency, broadcast.Message);
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");
            if (messages.Any())
            {
                foreach (var message in messages)
                {
                    Console.WriteLine("{0} -> {1}", message.Code, message.Mess);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}