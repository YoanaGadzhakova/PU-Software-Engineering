using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_GameEngine
{
    public class Team
    {
        public Team(Coach coach, List<FootballPlayer> players, string name)
        {
            Coach = coach;
            Players = players;
            if (Players.Count < 11 || Players.Count > 22)
            {
                throw new ArgumentOutOfRangeException("The number of players should be minimum 11 and maximum 22");
            }
            AverageAge = players.Sum(x => x.Age) / players.Count;
            this.Name = name;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Name should not be null!");
                }
                name = value;
            }
        }
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; }
        public int AverageAge { get; set; }
    }
}
