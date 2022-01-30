namespace InlämningsuppgiftTDD1DennisByberg.Tests
{
    using Xunit;
    public class AreaTests
    {
        [Theory]
        [InlineData(10, 100)]
        [InlineData(5.2f, 27.039997f)]
        [InlineData(-5, 25)]
        public void CalculateSquareArea(float side, float expected)
        {
            var square = new Square(side);
            var result = GeometricCalculator.GetArea(square);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 20, 200)]
        [InlineData(5.2f, 10.2f, 53.039997f)]
        [InlineData(-5, -2, 10)]
        public void CalculateRectangleArea(float width, float height, float expected)
        {
            var rectangle = new Rectangle(width, height);
            var result = GeometricCalculator.GetArea(rectangle);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10.0f, 314.15927f)]
        [InlineData(5.2f, 84.948654f)]
        [InlineData(-10, 314.15927f)]
        public void CalculateCirleArea(float radius, float expected)
        {
            var circle = new Circle(radius);
            var result = GeometricCalculator.GetArea(circle);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 2, 2, 1.7320508f)]         // Likbent Triangel.
        [InlineData(5, 5, 3, 7.154544f)]          // Liksidig Triangel.
        [InlineData(5, 10, 11.8f, 24.745222f)]    // Rätvinklig Triangel.
        public void CalculateTriangleArea(float sideA, float sideB, float sideC, float expected)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            var result = GeometricCalculator.GetArea(triangle);
            Assert.Equal(expected, result);
        }
    }
}