namespace InlämningsuppgiftTDD1DennisByberg

{
    using InlämningsuppgiftTDD1DennisByberg.Shapes;
    public class Rectangle : IShapeModel
    {
        public float Width { get; }
        public float Height { get; }

        public Rectangle(float width, float height)
        {
            Width = width;
            Height = height;
        }

        public float Area() => Width * Height;
        public float Perimeter() => Width + Width + Height + Height;
    }
}
