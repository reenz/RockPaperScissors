using System;
using System.Collections.Generic;

namespace RPS.Lib
{
    public class Game
    {
        private IPlayer playerOne;

        private IPlayer playerTwo;

        private float playerOneScore;

        private float playerTwoScore;
        private int bestOf;
        private IUserInterface ui;

        private Dictionary<Weapon, List<Weapon>> rules = GetRules();

        private static Dictionary<Weapon, List<Weapon>> GetRules()
        {
            //using list as value so that it can be extended to add spoke and lizard
            var rules = new Dictionary<Weapon, List<Weapon>>();
            rules.Add(Weapon.ROCK, new List<Weapon> { Weapon.SCISSORS, Weapon.LIZARD });
            rules.Add(Weapon.PAPER, new List<Weapon> { Weapon.ROCK, Weapon.SPOCK});
            rules.Add(Weapon.SCISSORS, new List<Weapon> { Weapon.PAPER, Weapon.LIZARD });
            rules.Add(Weapon.LIZARD, new List<Weapon>{Weapon.SPOCK,Weapon.PAPER});
            rules.Add(Weapon.SPOCK, new List<Weapon>{Weapon.ROCK, Weapon.SCISSORS});
            return rules;
        }

        public Game(IPlayer playerOne, IPlayer playerTwo, int bestOf, IUserInterface ui)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
            this.bestOf = bestOf;
            this.ui = ui;
        }

        public Outcome Play()
        {
            for (int i = 0; i < bestOf; i++)
            {
                this.PlayOneTurn();
            }
            return new Outcome(playerOneScore, playerTwoScore);
        }

        private void PlayOneTurn()
        {
            var move1 = this.playerOne.Move();
            ui.ShowToUser($"PlayerOne's move {move1} ");
            var move2 = this.playerTwo.Move();
            ui.ShowToUser($"PlayerTwo's move {move2} ");
            var beats = rules[move1];
            if (move1 == move2)
            {
                playerOneScore += 0.5f;
                playerTwoScore += 0.5f;
            }
            else if (beats.Contains(move2))
            {
                playerOneScore += 1;
            }
            else
            {
                playerTwoScore += 1;
            }
        }

    }
}
