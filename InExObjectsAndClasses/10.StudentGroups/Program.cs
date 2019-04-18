using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace _10.StudentGroups
{
    class Program
    {   public static Town currentTown;
        public static Group currentGroup;
        static void Main(string[] args)
        {
            List<Group> groups = new List<Group>();
            List<Town> towns = new List<Town>();
            
            string input = Console.ReadLine();
            while (input != "End")
            {
                
                if (input.Contains("=>"))
                {
                    string[] inputTokens = input.Split(new string[] { " => ", " seats"},StringSplitOptions.None);
                    string townName = inputTokens[0];
                    int townSeats = int.Parse(inputTokens[1]);
                    currentTown = Town.ReadTown(townName, townSeats);
                    towns.Add(currentTown);
                }
                else
                {
                    string[] inputTokens = input.Split('|');
                    string studentName = inputTokens[0].Trim();
                    string studentEmail = inputTokens[1].Trim();
                    DateTime studentRegistrationDate = DateTime.ParseExact(inputTokens[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    Student currentStudent = Student.ReadStudent(studentName, studentEmail, studentRegistrationDate);
                    int indexfOfCurrentTown = towns.FindIndex(x => x.Name == currentTown.Name);
                    towns[indexfOfCurrentTown].Students.Add(currentStudent);
                }
                input = Console.ReadLine();
            }

            int currentGroupIndex = -1;

            foreach (Town town in towns.OrderBy(x => x.Name))
            {
                currentGroupIndex++;
                currentGroup = Group.ReadGroup(town);
                groups.Add(currentGroup);
                int currentGroupSeatsCounter = 0;
                foreach (Student student in town.Students
                    .OrderBy(x => x.RegistrationDate)
                    .ThenBy(x => x.Name)
                    .ThenBy(x => x.Email))
                {
                    if (currentGroupSeatsCounter == town.Seats)
                    {
                        currentGroupIndex++;
                        currentGroupSeatsCounter = 0;
                        currentGroup = Group.ReadGroup(town);
                        groups.Add(currentGroup);
                    }
                    if (currentGroupSeatsCounter <= town.Seats)
                    {
                        groups[currentGroupIndex].StudentEmails.Add(student.Email);
                        currentGroupSeatsCounter++;
                    }                    
                }
            }
            Console.WriteLine($"Created {groups.Count} groups in {towns.Count} towns:");
            foreach (Group group in groups)
            {
                Console.WriteLine($"{group.Town} => {string.Join(", ", group.StudentEmails)}");               
            }
        }
    }
    class Group
    {
        public string Town { get; set; }
        public List<string> StudentEmails { get; set; }

        public static Group ReadGroup(Town town)
        {
            return new Group
            {
                Town = town.Name,
                StudentEmails = new List<string>()
            };
        }
    }
    class Town
    {
        public string Name { get; set; }
        public int Seats { get; set; }
        public List<Student> Students { get; set; }

        public static Town ReadTown(string townName, int townSeats)
        {
            return new Town
            {
                Name = townName,
                Seats = townSeats,
                Students = new List<Student>()
            };
        }

    }
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }

        public static Student ReadStudent(string name, string email, DateTime registrationDate)
        {
            return new Student
            {
                Name = name,
                Email = email,
                RegistrationDate = registrationDate
            };
        }
    }
}
