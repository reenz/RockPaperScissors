using System;
using NUnit.Framework;
using Game.Lib;

namespace Game.Lib.Tests
{
    public class GameTests
    {

        [Test]
        public void ShouldReturnMove()
        {   
            var game = new Game();
            var result = game.Play();
            Assert.AreEqual(result, "Rock");
        }
    }
}