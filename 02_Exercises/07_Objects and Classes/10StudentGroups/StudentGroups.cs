namespace _10StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    public class StudentGroups
    {
        public static void Main()
        {
            List<Town> towns = new List<Town>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                if (input.Contains("=>"))
                {
                    Town currentTown = new Town();
                    string[] inputArray = input
                        .Trim()
                        .Split(new[] { "=>" }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    string name = inputArray.First();
                    int seatPlases = int.Parse(inputArray[1].Trim().Split().ToArray().First());
                    currentTown.Name = name;
                    currentTown.SeatPlaces = seatPlases;
                    currentTown.Students = new List<Student>();
                    input = Console.ReadLine();

                    while (input != "End" && !input.Contains("=>"))
                    {
                        string[] currentStudent = input
                            .Trim()
                            .Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => x.Trim())
                            .ToArray();
                        Student student = new Student()
                        {
                            Name = currentStudent.First(),
                            Email = currentStudent[1],
                            Registration = DateTime.ParseExact(currentStudent[2], "d-MMM-yyyy", CultureInfo.InvariantCulture)
                        };
                        currentTown.Students.Add(student);
                        input = Console.ReadLine();
                    }

                    towns.Add(currentTown);
                }
            }

            List<Group> allGroups = CreateGroup(towns);

            Console.WriteLine("Created {0} groups in {1} towns:", allGroups.Count, towns.Count);
            foreach (var group in allGroups)
            {
                Console.WriteLine("{0}=> {1}", group.TownName, group.Students.Select(x => x.Email).ToList());
            }
        }

        private static List<Group> CreateGroup(List<Town> towns)
        {
            List<Group> groups = new List<Group>();
            foreach (var town in towns.OrderBy(x => x.Name))
            {
                IEnumerable<Student> students = town.Students.OrderBy(x => x.Registration).ThenBy(x => x.Name).ThenBy(x => x.Email);
                while (true)
                {
                    if (!students.Any())
                    {
                        break;
                    }

                    Group group = new Group()
                    {
                        Students = students.Take(town.SeatPlaces).ToList(),
                        TownName = town.Name
                    };
                    groups.Add(group);
                    students = students.Skip(town.SeatPlaces);
                }
            }

            return groups;
        }
    }
}