using Xunit;
using JohnRodAreaCalculate;
using System;

namespace AreaCalculateUnitTest
{
    public class UnitTest
    {
        [Fact]
        public void CircleNegativeRadius()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-10));
        }

        [Fact]
        public void CircleAreaCalculation()
        {
            var circle = new Circle(10);
            var circleArea = circle.Area;
            Assert.Equal(314.15926535897931, circleArea);
        }

        [Fact]
        public void TriangleNegativeSides()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 0, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, -1, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 0, -1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, -1, -1));
        }

        [Fact]
        public void TriangleArea()
        {
            var triangle = new Triangle(3, 4, 5);
            var actual = triangle.Area;
            Assert.Equal(6, actual);
        }

        [Fact]
        public void RightAngleTriangle()
        {
            var triangle = new Triangle(3, 4, 5);
            var isTriangleRightAngled = triangle.IsRightTriangle;
            Assert.True(isTriangleRightAngled);
        }

        [Fact]
        public void NotRightAngleTriangle()
        {
            var triangle = new Triangle(6, 2, 5);
            var isTriangleRightAngled = triangle.IsRightTriangle;
            Assert.False(isTriangleRightAngled);
        }
    }
}
