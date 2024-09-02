using System;
using System.Collections.Generic;
using System.Linq;

public class GroupStage
{
    private List<Team> teams;

    public GroupStage(List<Team> teams)
    {
        this.teams = teams;
    }

    public void SimulateGroupStage()
    {
        foreach (var team1 in teams)
        {
            foreach (var team2 in teams)
            {
                if (team1 != team2)
                {
                    var (score1, score2) = Match.SimulateMatch(team1, team2);
                    Console.WriteLine($"{team1.TeamName} - {team2.TeamName} ({score1}:{score2})");
                }
            }
        }

        RankTeams();
    }

    private void RankTeams()
    {
        var groupedTeams = teams.GroupBy(t => t.ISOCode.Substring(0, 1)).ToList();
        foreach (var group in groupedTeams)
        {
            var sortedTeams = group.OrderByDescending(t => t.Points)
                                   .ThenByDescending(t => t.PointDifference)
                                   .ThenByDescending(t => t.ScoredPoints)
                                   .ToList();

            Console.WriteLine($"Grupa {group.Key}:");
            for (int i = 0; i < sortedTeams.Count; i++)
            {
                var team = sortedTeams[i];
                Console.WriteLine($"{i + 1}. {team.TeamName} {team.Wins} / {team.Losses} / {team.Points} / {team.ScoredPoints} / {team.ConcededPoints} / {team.PointDifference}");
            }
        }
    }
}
