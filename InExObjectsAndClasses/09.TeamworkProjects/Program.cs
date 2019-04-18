using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int numberOfTeamsToRegister = int.Parse(Console.ReadLine());
            for (int curr = 0; curr < numberOfTeamsToRegister; curr++)
            {
                string[] inputTokens = Console.ReadLine().Split('-');
                string team = inputTokens[1];
                string teamCaptain = inputTokens[0];
                Team currentTeam = Team.CreateTeam(team, teamCaptain);
                Team currentTeamTeamName = teams.SingleOrDefault(x => x.TeamName == currentTeam.TeamName);
                Team currentTeamTeamCaptainName = teams.SingleOrDefault(x => x.TeamCaptainName == currentTeam.TeamCaptainName);
                if (teams.Contains(currentTeamTeamName))
                {
                    Console.WriteLine($"Team {currentTeam.TeamName} was already created!");
                }
                else if (teams.Contains(currentTeamTeamCaptainName))
                {
                    Console.WriteLine($"{currentTeam.TeamCaptainName} cannot create another team!");
                }
                else
                {
                    teams.Add(currentTeam);
                    Console.WriteLine($"Team {currentTeam.TeamName} has been created by {currentTeam.TeamCaptainName}!");
                }
            }
            string input = Console.ReadLine();
            while (input != "end of assignment")
            {
                string[] inputTokens = input.Split(new string[] { "->" }, StringSplitOptions.None);
                string name = inputTokens[0];
                string team = inputTokens[1];
                Team currentTeam = teams.SingleOrDefault(x => x.TeamName == team);
                Team currentName = teams.SingleOrDefault(x => x.TeamCaptainName == name);
                Team currentNameTwo = teams.SingleOrDefault(x => x.Members.Contains(name));
                if (!teams.Contains(currentTeam))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                else if(teams.Contains(currentName) || teams.Contains(currentNameTwo))
                {
                    Console.WriteLine($"Member {name} cannot join team {team}!");
                }
                else
                {
                    int indexOfTeam = teams.FindIndex(x => x.TeamName == team);
                    teams[indexOfTeam].Members.Add(name);
                }
                input = Console.ReadLine();
            }
            foreach (Team team in teams
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName).Where(x => x.Members.Count > 0))
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.TeamCaptainName}");
                foreach (string member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (Team team in teams.OrderBy(x => x.TeamName).Where(x => x.Members.Count <= 0))
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }
    class Team
    {
        public string TeamName { get; set; }
        public string TeamCaptainName { get; set; }
        public List<string> Members { get; set; }  
        
        public static Team CreateTeam (string team, string teamCaptain)
        {
            return new Team
            {
                TeamName = team,
                TeamCaptainName = teamCaptain,
                Members = new List<string>()
            };
        }
    }
}
