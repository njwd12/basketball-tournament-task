using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public static class DataLoader
{
    public static List<Team> LoadTeams(string groupsFilePath)
    {
        var json = File.ReadAllText(groupsFilePath);
        var groups = JsonConvert.DeserializeObject<Dictionary<string, List<Team>>>(json);

        var teams = new List<Team>();
        foreach (var group in groups.Values)
        {
            teams.AddRange(group);
        }
        return teams;
    }

    public static Dictionary<string, List<MatchResult>> LoadExhibitions(string exhibitionsFilePath)
    {
        var json = File.ReadAllText(exhibitionsFilePath);
        return JsonConvert.DeserializeObject<Dictionary<string, List<MatchResult>>>(json);
    }
}
