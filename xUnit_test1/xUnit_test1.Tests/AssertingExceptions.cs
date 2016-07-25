using System;
using Xunit;

namespace xUnit_test1.Tests
{
    public class AssertingExceptions
    {
        [Fact]
        public void ShouldErrorWhenDivideByZero()
        {
            var calc = new Calculator();

            Assert.Throws<DivideByZeroException>(() => calc.Divide(10, 0));
        }


        [Fact]
        public void ShouldErrorWhenNumberTooBig()
        {
            var calc = new Calculator();

            ArgumentOutOfRangeException thrownException =
                Assert.Throws<ArgumentOutOfRangeException>(() => calc.Divide(201, 1));

            Assert.Equal("value", thrownException.ParamName);
           
        }
    }
}
