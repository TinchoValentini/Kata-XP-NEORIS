using Xunit;

namespace TDD.Kata.StringCalculator.Tests.Unit
{
    public class UnitTestExample
    {
        private StringCalculator Target;

        public UnitTestExample()
        {
            this.Target = new StringCalculator();
        }

        [Fact]
        public void Example()
        {
            //Arrange
            //Your set up!.

            //Act
            //Your principal action to test.
            var result = this.Target.add(string.Empty);

            //Assert
            //Your expected value.
            Assert.Equal<int>(result, 0);
        }
    }
}
