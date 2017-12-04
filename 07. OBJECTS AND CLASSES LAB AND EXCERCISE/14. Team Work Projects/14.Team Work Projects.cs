using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Team
{
    public List<string> Members { get; set; }
    public string CreatorName { get; set; }
    public string TeamName { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        List<Team> listTeam = new List<Team>();
        RegisteringTeams(listTeam, n);
        AddingTeamMembers(listTeam);
        PrintingResult(listTeam);
    }

    private static void PrintingResult(List<Team> listTeam)
    {
        var teamDIssband = listTeam.Where(x => x.Members.Count == 0).Select(x => x.TeamName).ToList();
        foreach (var item in listTeam.OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName))
        {
            if (item.Members.Count == 0)
            { continue; }
            Console.WriteLine(item.TeamName);
            Console.WriteLine($"-- {item.CreatorName}");
            foreach (var pl in item.Members.OrderBy(x =>x))
            {
                Console.WriteLine($"-- {pl}");
            }
        }
        Console.WriteLine("Teams To Disband:");
        foreach (var item in teamDIssband.OrderBy(x =>x))
        {
            Console.WriteLine(item);
        }
    }

    private static void AddingTeamMembers(List<Team> listTeam)
    {
        var input = Console.ReadLine().Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();


        while (true)
        {
            var user = input[0];
            var teamToJoint = input[1];

            if (!listTeam.Any(t => t.TeamName == teamToJoint))
            {
                Console.WriteLine($"Team {teamToJoint} does not exist.");
                continue;
            }

            if (listTeam.Any(cr => cr.CreatorName == user) || listTeam.Any(mem => mem.Members.Contains(user)))
            {
                Console.WriteLine($"Member {user} cannot join team {teamToJoint}!");
                continue;
            }

            if (listTeam.Any(t => t.TeamName == teamToJoint))
            {
                var existingTeam = listTeam.First(t => t.TeamName == teamToJoint);

                existingTeam.Members.Add(user);
                continue;
            }
            input = Console.ReadLine().Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }
    }

    private static void RegisteringTeams(List<Team> listTeam, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Team currentTeam = new Team();
            var input = Console.ReadLine().Split('-').ToList();
            var creator = input[0];
            var teamName = input[1];

            currentTeam.CreatorName = creator;
            currentTeam.TeamName = teamName;
            currentTeam.Members = new List<string>();

            if (listTeam.Any(t => t.TeamName == teamName))
            {
                Console.WriteLine($"Team {teamName} was already created.");
                continue;
            }
            listTeam.Add(currentTeam);
            Console.WriteLine($"Team {currentTeam} has been created by {creator}");
        };

        
    }
}
