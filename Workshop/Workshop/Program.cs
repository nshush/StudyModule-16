using NUnit.Framework;

namespace Practices.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Additional_ShouldReturnSum_WhenValidNumbersAreProvided()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            var result = _calculator.Additional(a, b);

            // Assert
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Subtraction_ShouldReturnDifference_WhenValidNumbersAreProvided()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            var result = _calculator.Subtraction(a, b);

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Miltiplication_ShouldReturnProduct_WhenValidNumbersAreProvided()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            var result = _calculator.Miltiplication(a, b);

            // Assert
            Assert.AreEqual(15, result);
        }

        [Test]
        public void Division_ShouldReturnQuotient_WhenValidNumbersAreProvided()
        {
            // Arrange
            int a = 6;
            int b = 3;

            // Act
            var result = _calculator.Division(a, b);

            // Assert
            Assert.AreEqual(2, result);
        }

        public void Division_ShouldThrowDivideByZeroException_WhenDividedByZero()
        {
            // Arrange
            int a = 5;
            int b = 0;

            // Act & Assert
            Assert.Throws<System.DivideByZeroException>(() => _calculator.Division(a, b));
        }
    }
}