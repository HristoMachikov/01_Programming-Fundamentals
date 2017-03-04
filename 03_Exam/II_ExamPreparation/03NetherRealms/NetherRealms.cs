namespace _03NetherRealms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Demon
    {
        public string Name { get; set; }
        public long Health { get; set; }
        public decimal Damage { get; set; }
    }

    public class NetherRealms
    {
        public static void Main()
        {
            string[] demons = Console.ReadLine()
                .Trim()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            List<Demon> allDemons = new List<Demon>();

            foreach (var demon in demons)
            {
                string name = demon;
                Match removeSpace = Regex.Match(demon, @"\s+|\n+");
                if (removeSpace.Success)
                {
                    name = Regex.Replace(demon, @"\s+|\n+", string.Empty);
                }

                long health = 0;
                decimal damage = 0.0m;

                Regex regexHealth = new Regex(@"[^0-9\.\/\*\+-]");
                MatchCollection matchesDemon = regexHealth.Matches(name);
                foreach (var match in matchesDemon)
                {
                    health += Convert.ToChar(match.ToString());
                }

                Regex regexBaseDamage = new Regex(@"-?(\d+\.?\d+|\d+)");
                MatchCollection matchesBase = regexBaseDamage.Matches(demon);
                foreach (var match in matchesBase)
                {
                    damage += decimal.Parse(match.ToString());
                }

                Regex regexDamage = new Regex(@"(\*)|(\/)");
                MatchCollection matches = regexDamage.Matches(demon);
                foreach (var match in matches)
                {
                    if (match.ToString() == "*")
                    {
                        damage *= 2;
                    }
                    if (match.ToString() == "/")
                    {
                        damage /= 2;
                    }
                }
                
                Demon currentDemon = new Demon()
                 {
                     Name = name,
                     Health = health,
                     Damage = damage
                 };

                allDemons.Add(currentDemon);
            }

            if (allDemons.Any())
            {
                foreach (var obj in allDemons.OrderBy(x => x.Name))
                {
                    Console.WriteLine("{0} - {1} health, {2:f2} damage", obj.Name, obj.Health, obj.Damage);
                }
            }
        }
    }
}