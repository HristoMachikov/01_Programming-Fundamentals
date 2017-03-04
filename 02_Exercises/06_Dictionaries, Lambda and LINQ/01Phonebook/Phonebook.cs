namespace _01Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Phonebook
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var phonebook = new Dictionary<string, string>();
            
            string phone = string.Empty;
            while (input != "END")
            {
                List<string> currentRow = input.Split(' ').ToList();
                char command = char.Parse(currentRow.First());
                ////string name = currentRow.Skip(1).Take(1).ToString();
                string name = currentRow[1];
                switch (command)
                {
                    case 'A':
                        phone = currentRow.Last().ToString();
                        if (!phonebook.ContainsKey(name))
                        {
                            phonebook.Add(name, phone);
                        }
                        else
                        {
                            phonebook[name] = phone;
                        }

                        break;
                    case 'S':
                        if (!phonebook.ContainsKey(name))
                        {
                            Console.WriteLine("Contact {0} does not exist.", name);
                        }
                        else
                        {
                            Console.WriteLine("{0} -> {1}", name, phonebook[name]);
                        }

                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
