using Xunit;
using System.Diagnostics;

namespace xUnit_test1.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void ShouldAdd()
        {
            //Arrange
            var sut = new Calculator();

            //Act 
            var result = sut.Add(5, 5);

            //Assert
            Assert.Equal(10, result);

        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 1, 3)]
        [InlineData(5, 5, 10)]
        public void ShouldAddTheory(int x, int y, int res)
        {
            //Arrange
            var sut = new Calculator();

            //Act 
            var result = sut.Add(x, y);

            Debug.WriteLine(result);
            Debug.WriteLine(res);
            //Assert
            Assert.Equal(res, result);
        }
    }
}
