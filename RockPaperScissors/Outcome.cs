using System;

namespace RPS.Lib
{
    public class Outcome
    {
        private float playerOneScore;

        private float playerTwoScore;
        public Outcome(float playerOneScore, float playerTwoScore)
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