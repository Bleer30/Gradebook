using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
               grades.Add(grade);
            } else
            {
                Console.WriteLine("Invalid Value");
            }
        }

        internal Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.high = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.high = Math.Max(grade, result.high);
                result.Average += grade;
            }
            result /= grades.Count;

            return result;
        }

        public List<double> grades;
        public sting name;
    }
}
