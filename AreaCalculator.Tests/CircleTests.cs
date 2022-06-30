using NUnit.Framework;
using System;

namespace AreaCalculator.Tests
{
    [TestFixture]
    public class CircleTests
    {
        [TestCase(-1)]
        [TestCase(0)]
        public void Circle_WrongRadius_ThrowsException(double value)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(value));
        }

        [TestCase(1, ExpectedResult = 3.141592653589793)]
        [TestCase(5.123, ExpectedResult = 82.45150445891643)]
        public double Circle_GetFigureArea_ReturnsCorrectResults(double value)
        {
            var circle = new Circle(value);

            return circle.Area;
        }
    }
}