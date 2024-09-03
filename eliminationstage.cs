using System;
using System.Collections.Generic;
using System.Linq;

public class EliminationStage
{
    private List<Team> teams;

    public EliminationStage(List<Team> teams)
    {
        this.teams = teams;
    }

    public void SimulateEliminationStage()
    {
        var topTeams = teams.OrderByDescending(t => t.Points).Take(8).ToList();
        
        var groupD = topTeams.Where(t => t.Points == 1).ToList();
        var groupE = topTeams.Where(t => t.Points == 2).ToList();
        var groupF = topTeams.Where(t => t.Points == 3).ToList();
        var groupG = topTeams.Where(t => t.Points == 4).ToList();

        Console.WriteLine("Četvrtfinale:");
        var quarterFinals = new List<(Team, Team)>
        {
            (groupD[0], groupG[0]),
            (groupD[1], groupG[1]),
            (groupE[0], groupF[0]),
            (groupE[1], groupF[1])
        };

        foreach (var match in quarterFinals)
        {
            var (score1, score2) = Match.SimulateMatch(match.Item1, match.Item2);
            Console.WriteLine($"{match.Item1.TeamName} - {match.Item2.TeamName} ({score1}:{score2})");
        }

        // Further stages can be simulated similarly
    }
}
