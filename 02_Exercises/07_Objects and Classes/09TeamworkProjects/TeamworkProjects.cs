namespace _09TeamworkProjects
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TeamworkProjects
    {
        public static void Main()
        {
            int numb = int.Parse(Console.ReadLine());
            List<Team> allTeam = new List<Team>();
            List<string> output = new List<string>();

            for (int i = 0; i < numb; i++)
            {
                string inputText = Console.ReadLine();
                string[] input = inputText
                    .Split('-');
                string creator = input[0];
                string teamName = input[1];
                Team inputTeam = new Team()
                {
                    Creator = creator,
                    TeamName = teamName,
                    Members = new List<string>()
                };

                allTeam.Add(inputTeam);
            }

            List<Team> uniquTeams = new List<Team>();
            for (int i = 0; i < allTeam.Count; i++)
            {
                Team currentTeam = allTeam[i];
                if (uniquTeams.Any(t => t.TeamName == currentTeam.TeamName))
                {
                    Console.WriteLine("Team " + currentTeam.TeamName + " was already created!");
                }
                else if (uniquTeams.Any(g => g.Creator == currentTeam.Creator))
                {
                    Console.WriteLine(currentTeam.Creator + " cannot create another team!");
                }
                else
                {
                    Console.WriteLine("Team " + currentTeam.TeamName + " has been created by " + currentTeam.Creator + "!");
                    uniquTeams.Add(currentTeam);
                }
            }

            string inputUsers = Console.ReadLine();
            while (inputUsers != "end of assignment")
            {
                string[] inputNextUser = inputUsers
                    .Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string user = inputNextUser[0];
                string team = inputNextUser[1];
                bool isThisTeamExist = false;
                bool isThisNameExist = false;
                foreach (var obj in uniquTeams)
                {
                    if (obj.TeamName == team)
                    {
                        isThisTeamExist = true;
                    }

                    if (obj.Creator == user)
                    {
                        isThisNameExist = true;
                    }
                }

                if (!isThisTeamExist)
                {
                    string result = "Team " + team + " does not exist!";
                    output.Add(result);
                }
                else
                {
                    if (uniquTeams.Any(x => x.Members.Contains(user))
                        || isThisNameExist)
                    {
                        string result = "Member " + user + " cannot join team " + team + "!";
                        output.Add(result);
                    }
                    else
                    {
                        //// uniquTeams.First(x => x.TeamName == team).Members.Add(user);
                        Team currentTeam = uniquTeams.FirstOrDefault(x => x.TeamName == team);
                        currentTeam.Members.Add(user);
                    }
                }

                inputUsers = Console.ReadLine();
            }

            List<Team> lastTeams = uniquTeams.Where(x => x.Members.Count > 0).ToList();
            List<Team> zeroTeams = uniquTeams.Where(x => x.Members.Count < 1).ToList();
            lastTeams = lastTeams
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName)
                .ToList();
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

            foreach (var obj in lastTeams)
            {
                Console.WriteLine(obj.TeamName);
                Console.WriteLine("- {0}", obj.Creator);
                foreach (var member in obj.Members.OrderBy(x => x).ToList())
                {
                    Console.WriteLine("-- {0}", member);
                }
            }

            Console.WriteLine("Teams to disband:");
            if (zeroTeams.Count > 0)
            {
                foreach (var obj in zeroTeams.OrderBy(x => x.TeamName))
                {
                    Console.WriteLine(obj.TeamName);
                }
            }
        }
    }
}
