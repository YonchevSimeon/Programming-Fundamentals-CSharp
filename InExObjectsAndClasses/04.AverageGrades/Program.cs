using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int numberOfInputs = int.Parse(Console.ReadLine());
            for (int curr = 0; curr < numberOfInputs; curr++)
            {
                string[] currentInput = Console.ReadLine().Split(' ');
                string name = currentInput[0];                
                double[] grades = currentInput.Skip(1).Select(double.Parse).ToArray();
                Student currentStudent = Student.ReadStudent(name, grades);
                students.Add(currentStudent);
            }
            foreach (Student student in students.OrderBy(x => x.Name).ThenBy(x => -x.AverageGrade))
            {
                if(student.AverageGrade >= 5.00)
                {
                    Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
                }
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }
        public double AverageGrade { get; set; }

        public static Student ReadStudent (string name, double[] grades)
        {
            return new Student
            {
                Name = name,
                Grades = grades,
                AverageGrade = grades.Average()
            };
        }
    }
}
