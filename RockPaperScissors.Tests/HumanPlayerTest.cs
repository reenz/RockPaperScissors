using NUnit.Framework;
using RPS.Lib;

namespace RPS.Lib.Tests
{
    [TestFixture]
    public class HumanPlayerTests
    {

        [Test]
        public void ShouldReturnHumanPlayerName()
        {   
            var name = "HUMAN";
            var player = new HumanPlayer(name);
            var result = player.Name();
            Assert.AreEqual(result, "HUMAN");
        }
    }
}