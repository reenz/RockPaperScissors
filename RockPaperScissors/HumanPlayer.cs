using System;
using System.Collections.Generic;

namespace RPS.Lib
{
    public class HumanPlayer : IPlayer
    {
        private string name;

        private IUserInterface ui;

        public HumanPlayer(string name, IUserInterface ui)
        {
            this.name = name;
            this.ui = ui;
        }
        public Weapon Move()
        {
            ui.ShowToUser("Please enter your move(rock, paper, scissors): ");
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