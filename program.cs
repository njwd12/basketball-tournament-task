using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var teams = DataLoader.LoadTeams("groups.json");
        var groupStage = new GroupStage(teams);
        groupStage.SimulateGroupStage();

        var eliminationStage = new EliminationStage(teams);
        eliminationStage.SimulateEliminationStage();
    }
}
