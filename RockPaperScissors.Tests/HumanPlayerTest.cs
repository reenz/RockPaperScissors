using NUnit.Framework;
using RPS.Lib;
using Moq;

namespace RPS.Lib.Tests
{
    [TestFixture]
    public class HumanPlayerTests
    {

        [Test]
        public void ShouldReturnHumanPlayerName()
        {   
            var mockUI = new Mock<IUserInterface>();
            mockUI.Setup(o => o.GetFromUser()).Returns("ROCK");
            var name = "HUMAN";
            var player = new HumanPlayer(name, mockUI.Object);
            var result = player.Name();
            Assert.AreEqual(result, "HUMAN");
        }

        [Test]
        public void ShouldReturnHumanPlayerMove()
        {   
            var mockUI = new Mock<IUserInterface>();
            mockUI.Setup(o => o.GetFromUser()).Returns("ROCK");
            var name = "HUMAN";
            var player = new HumanPlayer(name, mockUI.Object);
            var result = player.Move();
            Assert.AreEqual(Weapon.ROCK,result);
        }
    }
}