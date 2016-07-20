using Xunit;
using System.Diagnostics;

namespace xUnit_test1.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void ShouldAdd()
        {
            //Arrange. Подготовка
            var sut = new Calculator();

            //Act. Действие 
            var result = sut.AddInts(5, 5);

            //Assert. Проверка утверждения
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
            var result = sut.AddInts(x, y);

            Debug.WriteLine(result);
            Debug.WriteLine(res);
            //Assert
            Assert.Equal(res, result);
        }


        [Theory]
        [InlineData(1.1d, 2.2d, 3.3d, 1)]
        [InlineData(2.32d, 1.23d, 3.55d, 12)]
        [InlineData(5.11111111d, 5.11111111d, 10.22222222d, 12)]
        public void ShouldAddDoubleTheory(double x, double y, double res, int precission)
        {
            //arrange 
            var calc = new Calculator();

            //act
            var result = calc.AddDoubles(x, y);

            //assert
            Assert.Equal(res, result, precission);
            
        }

        [Theory]
        [InlineData(5d, 2d, 2.5d, 12)]
        [InlineData(1d, 3d, 0.333333333333d, 12)]
        [InlineData(12, 4, 3, 12)]
        public void ShouldDivideTheory(double val, double by, double res, int precission)
        {
            //arrange 
            var calc = new Calculator();

            //act
            var result = calc.Divide(val, by);

            //assert
            Assert.Equal(res, result, precission);
        }

    }
}
