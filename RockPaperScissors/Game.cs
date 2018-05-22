using System;
using System.Collections.Generic;

namespace RPS.Lib
{
    public class Game
    {
        private Player playerOne;

        private Player playerTwo;

        private int bestOf;

        private Dictionary<Weapon, List<Weapon>> rules = GetRules();
        
        private static Dictionary<Weapon, List<Weapon>> GetRules()
        {
            //using list as value so that it can be extended to add spoke and lizard
            var rules = new Dictionary<Weapon, List<Weapon>>();
            rules.Add(Weapon.ROCK, new List<Weapon>{Weapon.SCISSORS});
            rules.Add(Weapon.PAPER,new List<Weapon>{Weapon.ROCK});
            rules.Add(Weapon.SCISSORS,new List<Weapon>{Weapon.PAPER}); 
            return rules;
        }

        public Game(Player playerOne, Player playerTwo, int bestOf)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
            this.bestOf = bestOf;
        }

        public Player Play()
        {
            return this.playerOne;
        }
    }
}
