using InlämningsuppgiftTDD1DennisByberg.Shapes;
namespace InlämningsuppgiftTDD1DennisByberg
{
    public class Circle : IShapeModel
    {
        public float Radius { get; }

        public Circle(float radius) => Radius = radius;

        public float Area() => (float)Math.PI * Radius * Radius;
        public float Perimeter() => (float)Math.PI * Radius * 2;
    }
}
