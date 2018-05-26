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
                return $"Player One Wins with {this.playerOneScore} points : beating 2nd by {this.playerTwoScore} points";
            }
            else if (this.playerOneScore == this.playerTwoScore)
            {
                return "Its a draw";
            }
            {
                return $"Player Two Wins with {this.playerTwoScore} points : beating 1st by {this.playerOneScore} points";
            }


        }
    }
}