using NUnit.Framework;
using Moq;
using PlayersManagerLib;
using System;

namespace PlayerManager.Tests
{
    [TestFixture]
    public class PlayerTests
    {
        private Mock<IPlayerMapper> _mockMapper;

        [OneTimeSetUp]
        public void Init()
        {
            _mockMapper = new Mock<IPlayerMapper>();
        }

        [Test]
        public void RegisterNewPlayer_ValidName_ReturnsPlayer()
        {
            string playerName = "Rohit";
            _mockMapper.Setup(m => m.IsPlayerNameExistsInDb(playerName)).Returns(false);

            Player player = Player.RegisterNewPlayer(playerName, _mockMapper.Object);

            Assert.That(player, Is.Not.Null);
            Assert.That(player.Name, Is.EqualTo(playerName));
            Assert.That(player.Age, Is.EqualTo(23));
            Assert.That(player.Country, Is.EqualTo("India"));
            Assert.That(player.NoOfMatches, Is.EqualTo(30));

            _mockMapper.Verify(m => m.AddNewPlayerIntoDb(playerName), Times.Once);
        }

        [Test]
        public void RegisterNewPlayer_EmptyName_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() =>
                Player.RegisterNewPlayer("", _mockMapper.Object));

            Assert.That(ex.Message, Is.EqualTo("Player name can’t be empty."));
        }

        [Test]
        public void RegisterNewPlayer_DuplicateName_ThrowsArgumentException()
        {
            string duplicateName = "Virat";
            _mockMapper.Setup(m => m.IsPlayerNameExistsInDb(duplicateName)).Returns(true);

            var ex = Assert.Throws<ArgumentException>(() =>
                Player.RegisterNewPlayer(duplicateName, _mockMapper.Object));

            Assert.That(ex.Message, Is.EqualTo("Player name already exists."));
        }
    }
}