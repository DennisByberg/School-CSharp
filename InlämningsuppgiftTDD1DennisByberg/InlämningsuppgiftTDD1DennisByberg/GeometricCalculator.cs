using InlämningsuppgiftTDD1DennisByberg.Shapes;

namespace InlämningsuppgiftTDD1DennisByberg
{
    public static class GeometricCalculator
    {
        /// <summary>
        /// Returns the area of the given shape
        /// </summary>
        /// <param name="shape">The shape to get the area from</param>
        /// <returns></returns>
        public static float GetArea(IShapeModel shape)
        {
            return shape.Area();
        }

        public static float GetPerimeter(IShapeModel shape)
        {
            return shape.Perimeter();
        }

        public static float GetPerimeter(IShapeModel[] shapes)
        {
            return shapes.Sum(shape => GetPerimeter(shape));
        }
    }
}