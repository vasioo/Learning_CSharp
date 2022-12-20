using System;
using System.Collections.Generic;
using System.Linq;

namespace AvarageGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();
            for (double i = 0; i < n; i++)
            {
                string[] student = Console.ReadLine().Split();
                var name = student[0];
                double grade = double.Parse(student[1]);
                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades.Add(name, new List<double>());
                }
                studentGrades[name].Add(grade);
            }
            foreach (var student in studentGrades)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}
