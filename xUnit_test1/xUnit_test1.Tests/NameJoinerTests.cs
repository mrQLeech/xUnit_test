using Xunit;

namespace xUnit_test1.Tests
{
    public class NameJoinerTests
    {
        [Theory]
        [InlineData("sarah", "smith", "sarah smith", false)]
        [InlineData("sarah", "smith", "SARAH SMITH", true)]
        public void ShouldJoinNames(string firstName, string lastName, string result, bool ignoringCase)
        {
            var obj = new NameJoiner();
            var fullName = obj.Join(firstName, lastName);

            Assert.Equal(result, fullName, ignoreCase: ignoringCase);
        }

        [Theory]
        [InlineData("sarah", "smith", "sarah")]
        [InlineData("SARAH", "smith", "SARAH")]
        public void ShouldStartFromName(string firstName, string lastName, string result)
        {
            var obj = new NameJoiner();
            var fullName = obj.Join(firstName, lastName);

            Assert.StartsWith(result, fullName);
        }

        [Theory]
        [InlineData("sarah", "SMITH", "ITH")]
        [InlineData("SARAH", "smith", "ith")]
        public void ShouldEndWithName(string firstName, string lastName, string result)
        {
            var obj = new NameJoiner();
            var fullName = obj.Join(firstName, lastName);

            Assert.EndsWith(result, fullName);
        }

        [Theory]
        [InlineData("sarah", "SMITH", "[a-z]+ [A-Z]+")]
        [InlineData("SARAH", "smith", "[A-Z]+ [a-z]+")]
        [InlineData("Sarah", "Smith", "[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+")]
        public void ShouldJoinNamesRegex(string firstName, string lastName, string regex)
        {
            var obj = new NameJoiner();
            var fullName = obj.Join(firstName, lastName);

            Assert.Matches(regex, fullName);
        }
    }
}
