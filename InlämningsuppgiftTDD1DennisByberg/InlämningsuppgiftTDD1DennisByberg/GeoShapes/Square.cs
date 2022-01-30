namespace InlämningsuppgiftTDD1DennisByberg
{
    using InlämningsuppgiftTDD1DennisByberg.Shapes;
    public class Square : IShapeModel
    {
        public float Side { get; }

        public Square (float side) => Side = side;
        public float Area() => Side * Side;
        public float Perimeter() => Side + Side + Side + Side;
    }
}
