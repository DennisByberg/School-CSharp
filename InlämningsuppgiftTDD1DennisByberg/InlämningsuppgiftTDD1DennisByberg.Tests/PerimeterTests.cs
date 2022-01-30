namespace InlämningsuppgiftTDD1DennisByberg.Tests
{
    using InlämningsuppgiftTDD1DennisByberg.Shapes;
    using Xunit;
    public class PerimeterTests
    {
        [Theory]
        [InlineData(2, 8)]
        [InlineData(3.5f, 14)]
        [InlineData(-2, -8)]
        public void CalculateSquarePerimeter(float side, float expected)
        {
            var square = new Square(side);
            var result = GeometricCalculator.GetPerimeter(square);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 4, 12)]
        [InlineData(3.5f, 5.5f, 18)]
        [InlineData(-2, -4, -12)]
        public void CalculateRectanglePerimeter(float width, float height, float expected)
        {
            var rectangle = new Rectangle(width, height);
            var result = GeometricCalculator.GetPerimeter(rectangle);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 12.5663706f)]
        [InlineData(4.7f, 29.53097f)]
        [InlineData(-2, -12.5663706f)]
        public void CalculateCirclePerimeter(float radius, float expected)
        {
            var circle = new Circle(radius);
            var result = GeometricCalculator.GetPerimeter(circle);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2,4,6,12)]
        [InlineData(3.1537f,7.423f,2.322f,12.898701f)]
        [InlineData(-2, -4, -6, -12)]
        public void CalculateTrianglePerimeter(float sideA, float sideB, float sideC, float expected)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            var result = GeometricCalculator.GetPerimeter(triangle);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalculateArrayPerimeter()
        {
            var geoThings = new IShapeModel[]
            {
                new Triangle(10,15,20),
                new Square(10),
                new Circle(10),
                new Rectangle(10,20)
            };

            var result = GeometricCalculator.GetPerimeter(geoThings);
            float expected = 0;

            foreach (var geoThing in geoThings)
            {
                expected += GeometricCalculator.GetPerimeter(geoThing);
            }
            Assert.Equal(expected, result);
        }
    }
}
