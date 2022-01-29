using InlämningsuppgiftTDD1DennisByberg.Shapes;

namespace InlämningsuppgiftTDD1DennisByberg
{
    public class Rectangle : IShapeModel
    {
        public float Width { get; }
        public float Height { get; }

        public Rectangle (float width, float height)
        {
            Width = width;
            Height = height;
        }

        public float Area()
        {
            var area = Width * Height;
            return area;
        }

        public float Perimeter()
        {
            var perimeter = Width + Width + Height + Height;
            return perimeter;
        }
    }
}
