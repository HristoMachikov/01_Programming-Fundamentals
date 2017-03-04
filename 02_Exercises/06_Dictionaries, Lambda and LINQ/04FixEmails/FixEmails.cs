namespace _04FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FixEmails
    {
        public static void Main()
        {
            string inputName = Console.ReadLine();
            var myColection = new Dictionary<string, string>();
            while (inputName != "stop")
            {
                string inputEmail = Console.ReadLine();
                if (!myColection.ContainsKey(inputName))
                {
                    myColection[inputName] = null;
                }

                myColection[inputName] = inputEmail;
                inputName = Console.ReadLine();
            }

            var myNewColection = new Dictionary<string, string>();
            foreach (var item in myColection)
            {
                string check = item.Value.Substring(item.Value.Length - 3, 3);
                if (check != ".us" && check != ".uk")
                {
                    myNewColection[item.Key] = item.Value;
                }
            }

            foreach (var item in myNewColection)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
