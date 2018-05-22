using System;
using NUnit.Framework;
using RPS.App;
using RPS.Lib;
using Moq;

namespace RPS.App.Tests
{
    [TestFixture]
    public class ConsoleGameTests
    {

        [Test]
        public void ShouldReturnTypeOfPlayer()
        {   
            var mockUI = new Mock<IUserInterface>();
            mockUI.Setup(o => o.GetFromUser()).Returns("HUMAN");
            var game = new ConsoleGame(mockUI.Object);
            var result = game.GetPlayer();
            Assert.AreEqual("HUMAN", result.Name());
        }
    }
}