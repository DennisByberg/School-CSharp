namespace InlämningsuppgiftTDD1DennisByberg
{
    using InlämningsuppgiftTDD1DennisByberg.Shapes;
    public static class GeometricCalculator
    {
        /// <summary>
        /// Returns the area of the given shape
        /// </summary>
        /// <param name="shape">The shape to get the area from</param>
        /// <returns>Area of the given shape</returns>
        public static float GetArea(IShapeModel shape) => shape.Area();

        /// <summary>
        /// Returns the perimeter of the given shape
        /// </summary>
        /// <param name="shape">The shape to get the area from</param>
        /// <returns>Preimeter of the given shape</returns>
        public static float GetPerimeter(IShapeModel shape) => shape.Perimeter();

        /// <summary>
        ///  Returns the perimeter of the given array of shapes
        /// </summary>
        /// <param name="shapes"></param>
        /// <returns>Perimeter of the given array of shapes</returns>
        public static float GetPerimeter(IShapeModel[] shapes) => shapes.Sum(shape => GetPerimeter(shape));
    }
}