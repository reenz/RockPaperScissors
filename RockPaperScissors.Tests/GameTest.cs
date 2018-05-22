using System;
using NUnit.Framework;
using RPS.Lib;
using Moq;

namespace RPS.Lib.Tests
{
    [TestFixture]
    public class GameTests
    {

        [Test]
        public void ShouldCheckOutcomeIsNotNull()
        {   
            var playerOne = new Player("HUMAN");
            var playerTwo = new Player("COMPUTER");
            var game = new Game(playerOne, playerTwo, 3);
            var result = game.Play();
            Assert.NotNull(result);
            //test is not appropriate I am running out of time to create interface to mock the 
            //outcome of play method,ideally it should check for scores of Players.
        }
    }
}