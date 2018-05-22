﻿using System;
using System.Collections.Generic;

namespace RPS.Lib
{
    public class Game
    {
        private IPlayer playerOne;

        private IPlayer playerTwo;

        private int playerOneScore;

        private int playerTwoScore;
        private int bestOf;

        private Dictionary<Weapon, List<Weapon>> rules = GetRules();

        private static Dictionary<Weapon, List<Weapon>> GetRules()
        {
            //using list as value so that it can be extended to add spoke and lizard
            var rules = new Dictionary<Weapon, List<Weapon>>();
            rules.Add(Weapon.ROCK, new List<Weapon> { Weapon.SCISSORS });
            rules.Add(Weapon.PAPER, new List<Weapon> { Weapon.ROCK });
            rules.Add(Weapon.SCISSORS, new List<Weapon> { Weapon.PAPER });
            return rules;
        }

        public Game(IPlayer playerOne, IPlayer playerTwo, int bestOf)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
            this.bestOf = bestOf;
        }

        public Outcome Play()
        {
            for(int i = 0; i < bestOf; i++)
            {
                this.PlayOneTurn();
            }
            return new Outcome(playerOneScore, playerTwoScore);
        }

        private void PlayOneTurn()
        {  
            var move1 = this.playerOne.Move();
            Console.WriteLine($"PlayerOne's move {move1} ");
            var move2 = this.playerTwo.Move();
            Console.WriteLine($"PlayerTwo's move {move2} ");
            var beats = rules[move1];
            if (move1 == move2)
            {
                playerOneScore += 1;
                playerTwoScore += 1;
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
