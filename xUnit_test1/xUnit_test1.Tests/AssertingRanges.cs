using Xunit;

namespace xUnit_test1.Tests
{
    public class AssertingRanges
    {
        [Fact]
        public void ShouldIncreaseHealthAfterSleeping()
        {
            var player = new PlayerCharacter { Health = 100 };

            player.Sleep();
            Assert.InRange(player.Health, 101, 200);
        }
    }
}
