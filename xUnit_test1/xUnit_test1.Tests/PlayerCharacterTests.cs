using Xunit;

namespace xUnit_test1.Tests
{
    class PlayerCharacterTests
    {
        [Fact]
        public void ShouldHaveStartGeneratedName()
        {
            var player = new PlayerCharacter();
            Assert.False(string.IsNullOrWhiteSpace(player.Name) || string.IsNullOrEmpty(player.Name));
        }

        [Fact]
        public void ShouldNotHaveNickName()
        {
            var player = new PlayerCharacter();
            Assert.Null(player.NickName);
        }

        [Fact]
        public void ShouldNotBeNoob()
        {
            var player = new PlayerCharacter();
            Assert.True(player.IsNoob);
        }
    }
}
