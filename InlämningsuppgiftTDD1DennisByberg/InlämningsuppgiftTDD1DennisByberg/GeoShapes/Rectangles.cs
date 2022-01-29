using InlämningsuppgiftTDD1DennisByberg.Shapes;

namespace InlämningsuppgiftTDD1DennisByberg
{
    public class Rectangles : IShapeModel
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public Rectangles (float width, float height)
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
