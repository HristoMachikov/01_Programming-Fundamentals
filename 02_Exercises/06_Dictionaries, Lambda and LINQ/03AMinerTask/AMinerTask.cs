namespace _03AMinerTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AMinerTask
    {
        public static void Main()
        {
            string resource = Console.ReadLine();
            var myColection = new Dictionary<string, long>();
            while (resource != "stop")
            {
                long quantity = long.Parse(Console.ReadLine());
                if (!myColection.ContainsKey(resource))
                {
                    myColection[resource] = quantity;
                }
                else
                {
                    myColection[resource] += quantity;
                }

                resource = Console.ReadLine();
            }

            foreach (var item in myColection)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
