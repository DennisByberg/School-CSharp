namespace InlämningsuppgiftTDD1DennisByberg
{
    using InlämningsuppgiftTDD1DennisByberg.Shapes;
    public class Square : IShapeModel
    {
        public float Side { get; }

        /// <summary>Initializes a new instance of the <see cref="Square" /> class.</summary>
        /// <param name="side">The side.</param>
        public Square (float side) => Side = side;
        public float Area() => Side * Side;
        public float Perimeter() => Side + Side + Side + Side;
    }
}
