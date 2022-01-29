using InlämningsuppgiftTDD1DennisByberg.Shapes;
using System;
using Xunit;

namespace InlämningsuppgiftTDD1DennisByberg.Tests
{
    public class AreaTests
    {
        [Theory]
        [InlineData(10, 100)]
        [InlineData(5.2f, 27.039997f)]
        public void CalculateSquareArea(float side, float expected)
        {
            var square = new Square(side);
            var result = GeometricCalculator.GetArea(square);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 20, 200)]
        [InlineData(5.2, 10.2, 53.039997)]
        public void CalculateRectangleArea(float width, float height, float expected)
        {
            var rectangle = new Rectangle(width, height);
            var result = GeometricCalculator.GetArea(rectangle);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 314.15927)]
        [InlineData(5.2, 84.948654)]
        public void CalculateCirleArea(float radius, float expected)
        {
            var circle = new Circle(radius);
            var result = GeometricCalculator.GetArea(circle);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 2, 2, 1.7320508)] // Likbent.
        [InlineData(5, 5, 3, 7.154544)] // Liksidig.
        [InlineData(5, 10, 11.8, 24.745222)] // Rätvinklig.
        public void CalculateTriangleArea(float sideA, float sideB, float sideC, float expected)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            var result = GeometricCalculator.GetArea(triangle);
            Assert.Equal(expected, result);
        }
    }
}