using System;

namespace RPS.Lib
{
    public class Outcome
    {
        private int playerOneScore;

        private int playerTwoScore;
        public Outcome(int playerOneScore, int playerTwoScore)
        {
            this.playerOneScore = playerOneScore;
            this.playerTwoScore = playerTwoScore;
        }

        public string Winner()
        {
            if (this.playerOneScore > this.playerTwoScore)
            {
                return "Player One Wins";
            }
            else
            {
                return "Player Two Wins";
            }

        }
    }
}