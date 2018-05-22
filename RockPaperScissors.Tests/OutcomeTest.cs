using System;
using NUnit.Framework;
using RPS.Lib;

namespace RPS.Lib.Tests
{
    [TestFixture]
    public class OutcomeTests
    {

        [Test]
        public void ShouldReturnPlayerOneWinner()
        {   
            var playerOneScore = 2;
            var playerTwoScore = 1;
            var outcome= new Outcome(playerOneScore, playerTwoScore);
            var result = outcome.Winner();
            Assert.AreEqual(result,"Player One Wins");
        }

        [Test]
        public void ShouldReturnPlayerTwoWinner()
        {   
            var playerOneScore = 1;
            var playerTwoScore = 2;
            var outcome= new Outcome(playerOneScore, playerTwoScore);
            var result = outcome.Winner();
            Assert.AreEqual(result,"Player Two Wins");
        }
    }
}