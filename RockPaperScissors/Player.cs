using System;
using System.Collections.Generic;

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
            var enumValues = Enum.GetValues(typeof(Weapon));
            var idx = new Random().Next(enumValues.Length);
            var weapon = enumValues.GetValue(idx);
            return (Weapon)weapon;
        }

        public string Name()
        {
            return this.name;
        }
    }
}