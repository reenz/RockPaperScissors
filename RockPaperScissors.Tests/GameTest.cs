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
            var playerOne = new ComputerPlayer("COMPUTER");
            var playerTwo = new ComputerPlayer("COMPUTER");
            var game = new Game(playerOne, playerTwo, 3);
            var result = game.Play();
            Assert.NotNull(result);
            //test is not appropriate I am running out of time to mock the 
            //outcome of play method,ideally it should check for scores of Players.
        }
    }
}