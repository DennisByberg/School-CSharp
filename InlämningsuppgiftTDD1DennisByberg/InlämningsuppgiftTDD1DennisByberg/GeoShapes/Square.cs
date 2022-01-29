using InlämningsuppgiftTDD1DennisByberg.Shapes;

namespace InlämningsuppgiftTDD1DennisByberg
{
    public class Square : IShapeModel
    {
        public float Side { get; }

        public Square (float side)
        {
            Side = side;
        }

        public float Area()
        {
            var area = Side * Side;
            return area;
        }

        public float Perimeter()
        {
            var perimeter = Side + Side + Side + Side;
            return perimeter;
        }
    }
}
