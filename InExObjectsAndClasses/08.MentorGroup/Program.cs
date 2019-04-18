using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _08.MentorGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = Console.ReadLine();
            while (input != "end of dates")
            {
                string[] inputTokens = input.Split(' ');
                string name = inputTokens[0];
                
                Student currentStudent = Student.AddStudent(name);
                Student boolCurrentStudent = students.SingleOrDefault(x => x.Name == currentStudent.Name);
                if (!students.Contains(boolCurrentStudent))
                {
                    students.Add(currentStudent);
                }
                if(inputTokens.Length > 1)
                {
                    DateTime[] dates = inputTokens[1]
                    .Split(',').Select(x => DateTime.ParseExact(x, "dd/M/yyyy", CultureInfo.InvariantCulture)).ToArray();
                    int indexOfCurrentStudent = students.FindIndex(x => x.Name == currentStudent.Name);
                    students[indexOfCurrentStudent].AttendanceDates.AddRange(dates);
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "end of comments")
            {
                string[] inputTokens = input.Split('-');
                string name = inputTokens[0];
                string comment = inputTokens[1];
                Student boolCurrentStudent = students.SingleOrDefault(x => x.Name == name);
                if (students.Contains(boolCurrentStudent))
                {
                    int indexOfCurrentStudent = students.FindIndex(x => x.Name == name);
                    students[indexOfCurrentStudent].Comments.Add(comment);
                }
                input = Console.ReadLine();
            }
            foreach (Student student in students.OrderBy(x => x.Name))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");
                foreach (string comment in student.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (DateTime attendanceDate in student.AttendanceDates.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {attendanceDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> AttendanceDates { get; set; }

        public static Student AddStudent (string name)
        {
            return new Student
            {
                Name = name,
                Comments = new List<string>(),
                AttendanceDates = new List<DateTime>()
            };
        }
    }
}
