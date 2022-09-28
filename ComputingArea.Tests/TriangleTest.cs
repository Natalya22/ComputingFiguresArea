using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ComputingArea.Tests
{
    public class TriangleTest
    {
        [Theory]
        [InlineData(-1, 1, 1)]
        [InlineData(1, -1, 1)]
        [InlineData(1, 1, -1)]
        [InlineData(0, 0, 0)]
        public void InitTriangleWithWrongData(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Fact]
        public void InitTriangleWithBadSides()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 4));
        }

        [Fact]
        public void CheckOnRightTrianlge()
        {
            // Arrange
            Triangle rightTriangle = new Triangle(3, 4, 5);
            bool isRightTriangle = Math.Pow(5, 2) == Math.Pow(3, 2) + Math.Pow(4, 2);

            // Act
            bool checkIsRigthTriangle = rightTriangle.IsRightTriangle;

            // Assert
            Assert.Equal(isRightTriangle, checkIsRigthTriangle);
        }

        [Fact]
        public void ComputeTriangleSquare()
        {
            // Arrange
            double a = 3d, b = 4d, c = 5d;
            Triangle triangle = new Triangle(a, b, c);
            double square = 6d;

            // Act
            double res = triangle.GetSquare();

            // Assert
            Assert.Equal(square, res);
        }
    }
}
