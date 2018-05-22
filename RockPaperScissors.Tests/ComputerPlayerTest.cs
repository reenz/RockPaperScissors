using NUnit.Framework;
using RPS.Lib;

namespace RPS.Lib.Tests
{
    [TestFixture]
    public class ComputerPlayerTests
    {

        [Test]
        public void ShouldReturnComputerPlayerName()
        {   
            var name = "COMPUTER";
            var player = new ComputerPlayer(name);
            var result = player.Name();
            Assert.AreEqual(result, "COMPUTER");
        }
    }
}