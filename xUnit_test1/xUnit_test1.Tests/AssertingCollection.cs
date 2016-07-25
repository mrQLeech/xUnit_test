using System.Collections.Generic;
using Xunit;
namespace xUnit_test1.Tests
{
    public class AssertingCollection
    {
        [Fact]
        public void ShouldHaveNoEmptyDefaultWeapons()
        {
            var player = new PlayerCharacter();

            Assert.All(player.Weapons, weapon => Assert.False(string.IsNullOrEmpty(weapon.Trim())));
        }


        [Fact]
        public void ShouldContainWeapons()
        {
            var player = new PlayerCharacter();

            Assert.Contains("Long Bow", player.Weapons);
        }

        [Fact]
        public void ShouldNotContainWeapons()
        {
            var player = new PlayerCharacter();

            Assert.DoesNotContain("Longer Bow", player.Weapons);
        }

        [Fact]
        public void ShouldHaveAtLeastOneKindOfSword()
        {
            var player = new PlayerCharacter();

            Assert.Contains(player.Weapons, weapon => weapon.Contains("Sword"));
        }



        [Fact]
        public void ShouldHaveAllExpectedWeapons()
        {
            var player = new PlayerCharacter();

            var expectedWeapons = new []
                      {
                          "Long Bow",
                          "Short Bow",
                          "Short Sword",
                      };

            Assert.Equal(expectedWeapons, player.Weapons);
        }
    }
}
