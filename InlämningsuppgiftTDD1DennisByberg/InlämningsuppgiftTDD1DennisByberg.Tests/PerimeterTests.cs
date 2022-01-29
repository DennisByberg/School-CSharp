using InlämningsuppgiftTDD1DennisByberg.Shapes;
using Xunit;

namespace InlämningsuppgiftTDD1DennisByberg.Tests
{
    public class PerimeterTests
    {
        private GeometricCalculator _calculator = new GeometricCalculator();

        [Theory]
        [InlineData(2, 8)]
        [InlineData(3.5, 14)]
        public void CalculateSquarePerimeter(float side, float expected)
        {
            var square = new Square(side);
            var result = _calculator.GetPerimeter(square);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 4, 12)]
        [InlineData(3.5, 5.5, 18)]
        public void CalculateRectanglePerimeter(float width, float height, float expected)
        {
            var rectangle = new Rectangle(width, height);
            var result = _calculator.GetPerimeter(rectangle);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 12.5663706)]
        [InlineData(4.7, 29.53097)]
        public void CalculateCirclePerimeter(float radius, float expected)
        {
            var circle = new Circle(radius);
            var result = _calculator.GetPerimeter(circle);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2,4,6,12)]
        [InlineData(3.1537,7.423,2.322,12.898701)]
        public void CalculateTrianglePerimeter(float sideA, float sideB, float sideC, float expected)
        {
            var triangle = new Triangle(sideA, sideB, sideC);
            var result = _calculator.GetPerimeter(triangle);
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

            var result = _calculator.GetPerimeter(geoThings);
            float expected = 0;

            foreach (var geoThing in geoThings)
            {
                expected += _calculator.GetPerimeter(geoThing);
            }

            Assert.Equal(expected, result);
        }
    }
}
