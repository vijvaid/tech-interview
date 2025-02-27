using NUnit.Framework;
using Solutions;

namespace Solutions.Tests
{
    [TestFixture]
    public class SimpleMathTests
    {
        [Test]
        public void Add_PositiveNumbers_ReturnsSum()
        {
            // Arrange
            int x = 5;
            int y = 10;
            int expectedSum = 15;

            // Act
            int actualSum = SimpleMath.Add(x, y);

            // Assert
            Assert.That(actualSum, Is.EqualTo(expectedSum));
        }

        [Test]
        public void Add_NegativeNumbers_ReturnsSum()
        {
            // Arrange
            int x = -5;
            int y = -10;
            int expectedSum = -15;

            // Act
            int actualSum = SimpleMath.Add(x, y);

            // Assert
            Assert.That(actualSum, Is.EqualTo(expectedSum));
        }

        [Test]
        public void Add_PositiveAndNegativeNumbers_ReturnsSum()
        {
            // Arrange
            int x = 5;
            int y = -10;
            int expectedSum = -5;

            // Act
            int actualSum = SimpleMath.Add(x, y);

            // Assert
            Assert.That(actualSum, Is.EqualTo(expectedSum));
        }

        [Test]
        public void Subtract_PositiveNumbers_ReturnsDifference()
        {
            // Arrange
            int x = 10;
            int y = 5;
            int expectedDifference = 5;

            // Act
            int actualDifference = SimpleMath.Subtract(x, y);

            // Assert
            Assert.That(actualDifference, Is.EqualTo(expectedDifference));
        }

        [Test]
        public void Subtract_NegativeNumbers_ReturnsDifference()
        {
            // Arrange
            int x = -5;
            int y = -10;
            int expectedDifference = 5;

            // Act
            int actualDifference = SimpleMath.Subtract(x, y);

            // Assert
            Assert.That(actualDifference, Is.EqualTo(expectedDifference));
        }

        [Test]
        public void Subtract_PositiveAndNegativeNumbers_ReturnsDifference()
        {
            // Arrange
            int x = 10;
            int y = -5;
            int expectedDifference = 15;

            // Act
            int actualDifference = SimpleMath.Subtract(x, y);

            // Assert
            Assert.That(actualDifference, Is.EqualTo(expectedDifference));
        }

        [Test]
        public void Multiply_PositiveNumbers_ReturnsProduct()
        {
            // Arrange
            int x = 5;
            int y = 10;
            int expectedProduct = 50;

            // Act
            int actualProduct = SimpleMath.Multiply(x, y);

            // Assert
            Assert.That(actualProduct, Is.EqualTo(expectedProduct));
        }

        [Test]
        public void Multiply_NegativeNumbers_ReturnsProduct()
        {
            // Arrange
            int x = -5;
            int y = -10;
            int expectedProduct = 50;

            // Act
            int actualProduct = SimpleMath.Multiply(x, y);

            // Assert
            Assert.That(actualProduct, Is.EqualTo(expectedProduct));
        }

        [Test]
        public void Multiply_PositiveAndNegativeNumbers_ReturnsProduct()
        {
            // Arrange
            int x = 5;
            int y = -10;
            int expectedProduct = -50;

            // Act
            int actualProduct = SimpleMath.Multiply(x, y);

            // Assert
            Assert.That(actualProduct, Is.EqualTo(expectedProduct));
        }
        
        [Test]
        public void Multiply_ByZero_ReturnsZero()
        {
             // Arrange
            int x = 5;
            int y = 0;
            int expectedProduct = 0;

            // Act
            int actualProduct = SimpleMath.Multiply(x, y);

            // Assert
            Assert.That(actualProduct, Is.EqualTo(expectedProduct));
        }

        [Test]
        public void Divide_PositiveNumbers_ReturnsQuotient()
        {
            // Arrange
            int x = 10;
            int y = 2;
            int expectedQuotient = 5;

            // Act
            int actualQuotient = SimpleMath.Divide(x, y);

            // Assert
            Assert.That(actualQuotient, Is.EqualTo(expectedQuotient));
        }

        [Test]
        public void Divide_NegativeNumbers_ReturnsQuotient()
        {
            // Arrange
            int x = -10;
            int y = -2;
            int expectedQuotient = 5;

            // Act
            int actualQuotient = SimpleMath.Divide(x, y);

            // Assert
            Assert.That(actualQuotient, Is.EqualTo(expectedQuotient));
        }

        [Test]
        public void Divide_PositiveAndNegativeNumbers_ReturnsQuotient()
        {
            // Arrange
            int x = 10;
            int y = -2;
            int expectedQuotient = -5;

            // Act
            int actualQuotient = SimpleMath.Divide(x, y);

            // Assert
            Assert.That(actualQuotient, Is.EqualTo(expectedQuotient));
        }
        
        [Test]
        public void Divide_ByOne_ReturnsDividend()
        {
             // Arrange
            int x = 5;
            int y = 1;
            int expectedQuotient = 5;

            // Act
            int actualQuotient = SimpleMath.Divide(x, y);

            // Assert
            Assert.That(actualQuotient, Is.EqualTo(expectedQuotient));
        }

        [Test]
        public void Divide_BySelf_ReturnsOne()
        {
             // Arrange
            int x = 5;
            int y = 5;
            int expectedQuotient = 1;

            // Act
            int actualQuotient = SimpleMath.Divide(x, y);

            // Assert
            Assert.That(actualQuotient, Is.EqualTo(expectedQuotient));
        }

        [Test]
        public void Divide_ZeroByNumber_ReturnsZero()
        {
             // Arrange
            int x = 0;
            int y = 5;
            int expectedQuotient = 0;

            // Act
            int actualQuotient = SimpleMath.Divide(x, y);

            // Assert
            Assert.That(actualQuotient, Is.EqualTo(expectedQuotient));
        }
        
        [Test]
        public void Divide_ByZero_ThrowsException()
        {
             // Arrange
            int x = 5;
            int y = 0;

            // Act & Assert
            Assert.Throws<System.DivideByZeroException>(() => SimpleMath.Divide(x, y));
        }
    }
}
