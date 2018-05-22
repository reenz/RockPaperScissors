using System;

namespace RPS.Lib
{
        public interface IPlayer
    {
        Weapon Move();

        string Name();
    }
}