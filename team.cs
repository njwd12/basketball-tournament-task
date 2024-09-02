public class Team
{
    public string TeamName { get; set; }
    public string ISOCode { get; set; }
    public int FIBARanking { get; set; }
    public int Wins { get; set; }
    public int Losses { get; set; }
    public int Points { get; set; }
    public int ScoredPoints { get; set; }
    public int ConcededPoints { get; set; }
    public int PointDifference => ScoredPoints - ConcededPoints;

    public Team(string name, string isoCode, int fibaRanking)
    {
        TeamName = name;
        ISOCode = isoCode;
        FIBARanking = fibaRanking;
        Wins = 0;
        Losses = 0;
        Points = 0;
        ScoredPoints = 0;
        ConcededPoints = 0;
    }
}
