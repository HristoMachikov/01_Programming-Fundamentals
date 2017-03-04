namespace _08MentorGroup
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class MentorGroup
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<Student> allStudent = new List<Student>();
            while (input != "end of dates")
            {
                string[] inputArray = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = string.Empty;
                List<string> inputDate = new List<string>();
                bool isHaveDate = false;
                if (inputArray.Length > 1)
                {
                    name = inputArray[0];
                    inputDate = inputArray[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    isHaveDate = true;
                }
                else
                {
                    name = inputArray[0];
                }

                if (allStudent.Any(t => t.Name == name))
                {
                    if (isHaveDate)
                    {
                        foreach (var date in inputDate)
                        {
                            DateTime newDate = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            allStudent.First(x => x.Name == name).AllDates.Add(newDate);
                        }
                    }
                }
                else
                {
                    Student currentStudent = new Student();
                    currentStudent.Name = name;
                    currentStudent.AllDates = new List<DateTime>();
                    currentStudent.Comments = new List<string>();
                    if (isHaveDate)
                    {
                        foreach (var date in inputDate)
                        {
                            DateTime newDate = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            currentStudent.AllDates.Add(newDate);
                        }
                    }

                    allStudent.Add(currentStudent);
                }

                input = Console.ReadLine();
            }

            string nextInput = Console.ReadLine();
            while (nextInput != "end of comments")
            {
                string[] nextInputArray = nextInput.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                string name = nextInputArray[0];
                string comment = nextInputArray[1];

                if (allStudent.Any(t => t.Name == name))
                {
                    allStudent.First(x => x.Name == name).Comments.Add(comment);
                }

                nextInput = Console.ReadLine();
            }

            allStudent = allStudent
                .OrderBy(x => x.Name)
                .ToList();
            foreach (var obj in allStudent)
            {
                Console.WriteLine(obj.Name);
                Console.WriteLine("Comments:");

                foreach (var comm in obj.Comments)
                {
                    Console.WriteLine("- {0}", comm);
                }

                Console.WriteLine("Dates attended:");
                foreach (var date in obj.AllDates.OrderBy(x => x))
                {
                    Console.WriteLine("-- {0}", date.ToString("dd/MM/yyyy"));
                }
            }
        }
    }
}