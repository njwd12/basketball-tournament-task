using System;

public static class Match
{
    public static (int, int) SimulateMatch(Team team1, Team team2)
    {
        var random = new Random();
        double chance = (team2.FIBARanking - team1.FIBARanking) / 10.0;
        double winProbability = 0.5 + chance / 2;
        
        bool team1Wins = random.NextDouble() < winProbability;
        int team1Score = random.Next(70, 120);
        int team2Score = random.Next(70, 120);
        
        if (team1Wins)
        {
            team1.Wins++;
            team1.Points += 2;
            team2.Losses++;
        }
        else
        {
            team2.Wins++;
            team2.Points += 2;
            team1.Losses++;
        }
        
        team1.ScoredPoints += team1Score;
        team1.ConcededPoints += team2Score;
        team2.ScoredPoints += team2Score;
        team2.ConcededPoints += team1Score;

        return (team1Score, team2Score);
    }
}
