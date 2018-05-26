using System;
using System.Collections.Generic;

namespace RPS.Lib
{
    public class TacticalComputerPlayer : ComputerPlayer
    {
        private string name;

        Weapon tacticMove ;
        public TacticalComputerPlayer(string name) : base(name)
        {
            this.name = name;
            this.tacticMove = base.Move();
        }

        public Weapon Move()
        {
            var move = this.tacticMove;

            var rules = Game.GetRules();

            foreach (var item in rules)
            {
                if( item.Value.Contains(move))
                {
                   this.tacticMove = item.Key;
                    break;
                }
            }
            return this.tacticMove;
        }

        public string Name()
        {
            return this.name;
        }
    }
}