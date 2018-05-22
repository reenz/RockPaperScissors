using System;
using System.Collections.Generic;

namespace RPS.Lib
{
    public class HumanPlayer : IPlayer
    {
        private string name;

        public HumanPlayer(string name)
        {
            this.name = name;
        }

        public Weapon Move()
        {
           Console.Write("Please enter your move(rock, paper, scissors): ") ;
           var playerMove = Console.ReadLine().Trim().ToUpper();
           var move = Enum.Parse(typeof(Weapon), playerMove);
           return (Weapon)move;
        }

        public string Name()
        {
            return this.name;
        }
    }
}