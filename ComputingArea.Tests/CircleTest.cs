using System;
using Xunit;

namespace ComputingArea.Tests
{
    public class CircleTest
    {
        [Fact]
        public void ZeroRadiusTest()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0d));
        }

        [Fact]
        public void NegativeRadiusTest()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1d));
        }

        [Fact]
        public void GetSquareTest()
        {
            // Arrange
            double radius = 3.0;
            Circle circle = new Circle(radius);
            double expectedVal = Math.PI * Math.Pow(radius, 2);

            // Act
            double result = circle.GetSquare();

            // Assert
            Assert.Equal(expectedVal, result);
        }
    }
}
