using System;
using System.Collections.Generic;

namespace Laborator2
{
    class FootballData
    {
        public List<Team> Teams { get; private set; }
        public FootballData()
        {
            Teams = new List<Team>();
        }
        public void AddData(List<List<string>> lines)
        {
            foreach (List<string> line in lines)
            {
                Teams.Add(new Team(Convert.ToInt32(line[0]), line[1], Convert.ToInt32(line[2]), Convert.ToInt32(line[3]), Convert.ToInt32(line[4]), Convert.ToInt32(line[5]), Convert.ToInt32(line[6]), Convert.ToInt32(line[7]), Convert.ToInt32(line[8])));
            }
        }

        public string GetSmallestDifference()
        {
            string winningName = Teams[0].Name;
            int diff = (Teams[0].F - Teams[0].A);
            foreach (Team team in Teams)
            {
                if (diff > Math.Abs(team.F - team.A))
                {
                    winningName = team.Name;
                    diff = Math.Abs(team.F - team.A);
                }
            }
            return winningName;
        }
        public void GetTeamsNames()
        {
            foreach (Team team in Teams)
            {
                Console.WriteLine(team.Name);
            }
        }
    }
}
