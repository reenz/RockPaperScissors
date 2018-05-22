using System;
using RPS.Lib;

namespace RPS.App
{
    public class ConsoleGame
    {
        static int BEST_OF = 3;

        private IUserInterface ui;

         public ConsoleGame(IUserInterface ui)
        {
            this.ui = ui;
        }

        static void Main(string[] args)
        {
            //can create object which will make testing easy
            new ConsoleGame(new ConsoleUserInterface()).PlayGame();
        }

        void PlayGame()
        {
            ui.ShowToUser("Welcome to our Game\n");
            var playerOne = GetPlayer();
            var playerTwo = GetPlayer();
            var game = new Game(playerOne, playerTwo, BEST_OF);
            var outcome = game.Play();
            ui.ShowToUser(outcome.Winner());
            ui.ShowToUser("\nThank you for playing RPS\n");

        }

        public Player GetPlayer()
        {
            ui.ShowToUser("Please enter type of player (human, computer, tactical_computer): ");
            var playerType = ui.GetFromUser();
            switch (playerType)
            {
                case "HUMAN":
                    return new Player(playerType);
                case "COMPUTER":
                    return new Player(playerType);
                case "TACTICAL_COMPUTER":
                    return new Player(playerType);
                default:
                    throw new ArgumentException("Invalid player type: " + playerType);
            }
        }

    }
}
