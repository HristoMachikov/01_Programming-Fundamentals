namespace _04AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageGrades
    {
        public static void Main()
        {
            int numb = int.Parse(Console.ReadLine());
            Dictionary<string, double> listOfStudents = new Dictionary<string, double>();
            Student[] student = new Student[numb];
            for (int i = 0; i < numb; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                Student inputStudent = new Student()
                {
                    Name = input[0],
                    ListOfGrade = new List<double>()
                };
                for (int j = 1; j < input.Length; j++)
                {
                    inputStudent.ListOfGrade.Add(double.Parse(input[j]));
                }

                student[i] = inputStudent;
            }

            Student[] exelantStudent = student
                .Where(x => x.AverageGrade >= 5.00)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.AverageGrade)
                .ToArray();
            foreach (var obj in exelantStudent)
            {
                Console.WriteLine("{0} -> {1:f2}", obj.Name, obj.AverageGrade);
            }
        }
    }
}