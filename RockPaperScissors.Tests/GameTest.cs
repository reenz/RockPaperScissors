using System;
using NUnit.Framework;
using RPS.Lib;

namespace RPS.Lib.Tests
{
    [TestFixture]
    public class GameTests
    {

        [Test]
        public void ShouldReturnMove()
        {   
            var playerOne = new Player("HUMAN");
            var playerTwo = new Player("COMPUTER");
            var game = new Game(playerOne, playerTwo, 3);
            var result = game.Play();
            Assert.AreEqual(result, playerOne);
        }
    }
}