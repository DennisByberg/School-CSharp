namespace InlämningsuppgiftTDD1DennisByberg.Shapes
{
    public interface IShapeModel
    {
        /// <summary>
        /// Returns the perimeter of the shape
        /// </summary>
        public float Perimeter();

        /// <summary>
        /// Returns the area of the shape
        /// </summary>
        public float Area();
    }
}
