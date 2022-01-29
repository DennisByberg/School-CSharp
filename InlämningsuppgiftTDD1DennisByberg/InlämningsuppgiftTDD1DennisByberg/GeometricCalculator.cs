using InlämningsuppgiftTDD1DennisByberg.Shapes;

namespace InlämningsuppgiftTDD1DennisByberg
{
    public class GeometricCalculator
    {
        public float GetArea(IShapeModel shape)
        {
            return shape.Area();
        }

        public float GetPerimeter(IShapeModel shape)
        {
            return shape.Perimeter();
        }

        public float GetPerimeter(IShapeModel[] shapes)
        {
            return shapes.Sum(shape => GetPerimeter(shape));
        }
    }
}