namespace _02PhonebookUpgrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PhonebookUpgrade
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var phonebook = new SortedDictionary<string, string>();

            ////string phone = string.Empty;
            while (input != "END")
            {
                List<string> currentRow = input.Split(' ').ToList();
                if (currentRow.First() == "ListAll")
                {
                    foreach (var item in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                    }
                }
                else
                {
                    char command = char.Parse(currentRow.First());
                    string name = currentRow[1];
                    switch (command)
                    {
                        case 'A':
                            string phone = currentRow.Last().ToString();
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
                }

                input = Console.ReadLine();
            }
        }
    }
}
