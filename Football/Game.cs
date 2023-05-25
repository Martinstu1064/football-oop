using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Game
    {
        private Team team1;
        private Team team2;
        private Referee referee;
        private Dictionary<string, Referee> assReferee;
        private Dictionary<string, FootballPlayer> goals;
        public Game(Team team1,Team team2, Referee referee,Dictionary<string,Referee> assReferee,Dictionary<string, FootballPlayer> goals)
        {
            this.team1 = team1;
            this.team2 = team2;
            this.referee = referee;
            this.assReferee = assReferee;
            this.goals = goals;
        }
        public string Winner
        {
            get
            {
                GetResult(out int team1Goals, out int team2Goals);
                if (team1Goals > team2Goals)
                    return "Team 1 is the winner!";
                else if (team1Goals < team2Goals)
                    return "Team 2 is the winner!";
                else
                    return "Match finished in a draw!";
            }
        }

        public string GameResult
        {
            get
            {
                return GetResult(out int team1Goals, out int team2Goals);
            }
        }
        private string GetResult(out int team1Goals, out int team2Goals)
        {
            team1Goals = 0;
            team2Goals = 0;
            foreach (var player in goals.Values)
            {
                if (team1.Players.Contains(player))
                {
                    team1Goals++;
                }
                else if (team2.Players.Contains(player))
                {
                    team2Goals++;
                }
            }
            return $"{team1Goals}:{team2Goals}";
        }

    }
}
