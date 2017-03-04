namespace _11DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DragonArmy
    {
        public static void Main()
        {
            int numb = int.Parse(Console.ReadLine());
            var myDateBase = new Dictionary<string, SortedDictionary<string, int[]>>();

            for (int i = 0; i < numb; i++)
            {
                string[] myInputArray = Console.ReadLine()
                    .Split(' ');
                string type = myInputArray[0];
                string name = myInputArray[1];

                int damage = 0;
                int health = 0;
                int armor = 0;
                var damageTry = int.TryParse(myInputArray[2], out damage);
                var healthTry = int.TryParse(myInputArray[3], out health);
                var armorTry = int.TryParse(myInputArray[4], out armor);
                int damageDefaut = 45;
                int healthDefaut = 250;
                int armorDefaut = 10;

                if (!myDateBase.ContainsKey(type))
                {
                    myDateBase[type] = new SortedDictionary<string, int[]>();
                }

                if (!myDateBase[type].ContainsKey(name))
                {
                    myDateBase[type][name] = new int[3];
                }

                if (damage == 0 && !damageTry)
                {
                    damage = damageDefaut;
                }

                if (health == 0 && !healthTry)
                {
                    health = healthDefaut;
                }

                if (armor == 0 && !armorTry)
                {
                    armor = armorDefaut;
                }

                myDateBase[type][name] = new int[] { damage, health, armor };
            }

            foreach (var pair in myDateBase)
            {
                double damageAver = pair.Value.Values.Select(x => x[0]).Average();
                double healthAver = pair.Value.Values.Select(x => x[1]).Average();
                double armorAver = pair.Value.Values.Select(x => x[2]).Average();

                Console.WriteLine("{0}::({1:f2}/{2:f2}/{3:f2})", pair.Key, damageAver, healthAver, armorAver);

                foreach (var innerpair in pair.Value)
                {
                    Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}", innerpair.Key, innerpair.Value[0], innerpair.Value[1], innerpair.Value[2]);
                }
            }
        }
    }
}