using FluentAssertions;
using MyStore.Tests.Unit.Classes;

namespace MyStore.Tests.Unit
{
    public class CalculatorTests
    {
        private readonly Calculator subjectUnderTest;
        public CalculatorTests()
        {
            subjectUnderTest = new Calculator();
        }

        [Fact]
        public void SumShouldReturn_CorectNumber()
        {
            //arrange
            var x = 1;
            var y = 2;
            var expectedResult = 3; 

            //act
            var actualResult = subjectUnderTest.Sum(x, y);

            //assert
            expectedResult.Should().Be(actualResult);
        }

        [Fact]
        public void Multiply_ShouldReturn_Correct()
        {
            //arrange
            var x = 1;
            var factor = 2;
            var expectedResult = 2;

            //act
            var actualResult = subjectUnderTest.Multiply(x, factor);

            //assert
            expectedResult.Should().Be(actualResult);
        }
    }
}