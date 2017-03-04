namespace _04AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Student
    {
        public string Name { get; set; }
        public List<double> ListOfGrade { get; set; }

        public double AverageGrade
        {
            get
            {
                return ListOfGrade.Average();
            }
        }
    }
}
