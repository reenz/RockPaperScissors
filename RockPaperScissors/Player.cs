using System;

namespace RPS.Lib
{
    public class Player
    {
        private string name;

        public Player(string name)
        {
            this.name = name;
        }

        public Weapon Move()
        {
            return Weapon.ROCK;
        }

        public string Name()
        {
            return this.name;
        }
    }
}