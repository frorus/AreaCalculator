using NUnit.Framework;
using System;

namespace AreaCalculator.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        [TestCase(0, 1, 1)]
        [TestCase(1, 0, 1)]
        [TestCase(1, 1, 0)]
        public void Triangle_WrongSides_ThrowsException(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(sideA, sideB, sideC));
        }

        [TestCase(3, 4, 5, ExpectedResult = 6)]
        [TestCase(5.123, 6.456, 7.789, ExpectedResult = 16.43723622849779)]
        public double Triangle_GetFigureArea_ReturnsCorrectResults(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);

            return triangle.Area;
        }

        [TestCase(3, 4, 5, ExpectedResult = true)]
        [TestCase(5.123, 6.456, 8.241666397034036, ExpectedResult = true)]
        public bool Triangle_IsRightTriangle_ReturnsTrue(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);

            return triangle.IsRightTriangle;
        }

        [TestCase(3, 4, 6, ExpectedResult = false)]
        [TestCase(5.123, 6.456, 8, ExpectedResult = false)]
        public bool Triangle_IsRightTriangle_ReturnsFalse(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle(sideA, sideB, sideC);

            return triangle.IsRightTriangle;
        }
    }
}