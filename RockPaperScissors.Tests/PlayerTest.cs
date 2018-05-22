using NUnit.Framework;
using RPS.Lib;

namespace RPS.Lib.Tests
{
    [TestFixture]
    public class PlayerTests
    {

        [Test]
        public void ShouldReturnMove()
        {   
            var name = "COMPUTER";
            var player = new Player(name);
            var result = player.Name();
            Assert.AreEqual(result, "COMPUTER");
        }
    }
}