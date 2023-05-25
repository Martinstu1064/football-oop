using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Team
    {
        private Coach coach;
        private List<FootballPlayer> players = new List<FootballPlayer>();
        public Team(Coach coach, List<FootballPlayer> players)
        {
            this.coach = coach;
            if (players.Count > 10 && players.Count < 23)
            {
                this.players = players;
            }
            else
            {
                throw new Exception("Team must be between 11 and 22 players!");
            }
        }
        public IReadOnlyList<FootballPlayer> Players
        {
            get { return this.players; }
        }
        public int AverageAge
        {
            get
            {
                int sum = 0;
                foreach (var player in players)
                {
                    sum += player.GetAge;
                }
                return sum / players.Count;
            }
        }
    }
}
