using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_GameEngine
{
    public class Game
    {
        public Game(Team team1, Team team2, Referee referee, Referee assistantReferee1, Referee assistantReferee2)
        {
            //Taking first 11 players from the team
            team1.Players = team1.Players.Take(11).ToList();
            team2.Players = team2.Players.Take(11).ToList();

            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            AssistantReferee1 = assistantReferee1;
            AssistantReferee2 = assistantReferee2;
            Goals = new Dictionary<string, FootballPlayer>();
            GameResult = new int[2];
        }

        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public Referee AssistantReferee1 { get; set; }
        public Referee AssistantReferee2 { get; set; }

        private Dictionary<string, FootballPlayer> Goals { get; set; }

        //The first item is the result of the first team and the second - second team
        private int[] GameResult { get; set; }
        public Team Winner { get; set; }

        public void ScoreGoal(string time, FootballPlayer player)
        {
            Goals.Add(time, player);
        }


        private void CalculateGameResult()
        {
            int countOfGolsForFirstTeam = 0;
            int countOfGolsForSecondTeam = 0;

            foreach (KeyValuePair<string, FootballPlayer> goal in Goals)
            {
                if (Team1.Players.Contains(goal.Value))
                {
                    countOfGolsForFirstTeam++;
                }
                else
                {
                    countOfGolsForSecondTeam++;
                }
            }
            GameResult[0] = countOfGolsForFirstTeam;
            GameResult[1] = countOfGolsForSecondTeam;
        }
        public void ShowGameResult()
        {
            CalculateGameResult();
            Console.WriteLine($"The game result is {GameResult[0]}:{GameResult[1]}");
        }
        public void ShowTheWinner()
        {
            ShowGameResult();
            Console.Write("And the winner is... ");
            if (GameResult[0] > GameResult[1])
            {
                Console.WriteLine(Team1.Name);
                Winner = Team1;
            }
            else if (GameResult[0] < GameResult[1])
            {
                Console.WriteLine(Team2.Name);
                Winner = Team2;
            }
            else
            {
                Console.WriteLine("Umm, even score! There is no winner;");
            }
        }
    }
}
