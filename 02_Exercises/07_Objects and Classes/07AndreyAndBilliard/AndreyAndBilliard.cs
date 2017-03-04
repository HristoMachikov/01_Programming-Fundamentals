namespace _07AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AndreyAndBilliard
    {
        public static void Main()
        {
            int numb = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> allEntity = new Dictionary<string, decimal>();

            for (int i = 0; i < numb; i++)
            {
                string[] input = Console.ReadLine()
                    .Split('-');
                string currentEntity = input[0];
                decimal currentPrice = decimal.Parse(input[1]);
                if (!allEntity.ContainsKey(currentEntity))
                {
                    allEntity[currentEntity] = 0.0m;
                }

                allEntity[currentEntity] = currentPrice;
            }

            string nextInput = Console.ReadLine();
            List<Customer> allClients = new List<Customer>();
            while (nextInput != "end of clients")
            {
                string[] currentClient = nextInput
                    .Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                string name = currentClient[0];
                string[] currrentWishCount = currentClient[1].Split(',');
                bool haveSameName = false;
                foreach (var obj in allClients)
                {
                    if (obj.Name.Contains(name))
                    {
                        haveSameName = true;
                    }
                }

                if (haveSameName)
                {
                    var found = allClients.FirstOrDefault(x => x.Name == name);

                    for (int i = 0; i < currrentWishCount.Length; i += 2)
                    {
                        string currentWish = currrentWishCount[i];
                        int currentCount = int.Parse(currrentWishCount[i + 1]);
                        if (allEntity.Keys.Contains(currentWish))
                        {
                            if (!found.ShopList.ContainsKey(currentWish))
                            {
                                found.ShopList[currentWish] = 0;
                            }

                            found.ShopList[currentWish] += currentCount;
                            found.TotalPrice += found.CalulatePrice(currentCount, allEntity[currentWish]);
                        }
                    }
                }
                else
                {
                    Customer client = new Customer();
                    client.Name = name;
                    client.ShopList = new Dictionary<string, int>();
                    client.TotalPrice = 0.0m;
                    for (int i = 0; i < currrentWishCount.Length; i += 2)
                    {
                        string currentWish = currrentWishCount[i];
                        int currentCount = int.Parse(currrentWishCount[i + 1]);
                        if (allEntity.Keys.Contains(currentWish))
                        {
                            if (!client.ShopList.ContainsKey(currentWish))
                            {
                                client.ShopList[currentWish] = 0;
                            }

                            client.ShopList[currentWish] += currentCount;
                            client.TotalPrice += client.CalulatePrice(currentCount, allEntity[currentWish]);
                        }
                    }

                    if (client.ShopList.Values.Sum() != 0)
                    {
                        allClients.Add(client);
                    }
                }

                haveSameName = false;
                nextInput = Console.ReadLine();
            }

            allClients = allClients.OrderBy(x => x.Name).ToList();
            decimal totalBill = 0.0m;
            foreach (var obj in allClients)
            {
                Console.WriteLine(obj.Name);
                foreach (var objpair in obj.ShopList)
                {
                    Console.WriteLine("-- {0} - {1}", objpair.Key, objpair.Value);
                }

                totalBill += obj.TotalPrice;
                Console.WriteLine("Bill: {0:f2}", obj.TotalPrice);
            }

            Console.WriteLine("Total bill: {0:f2}", totalBill);
        }
    }
}