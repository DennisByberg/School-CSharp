using InlämningsuppgiftTDD1DennisByberg.Shapes;

namespace InlämningsuppgiftTDD1DennisByberg
{
    //TODO: Ska innehålla: Rättvinkliga, Likbenta och Liksidiga?
    public class Triangles : IShapeModel
    {
        public float SideA { get; }
        public float SideB { get; }
        public float SideC { get; }
        public float Widht { get; }
        public float Height { get; }

        public Triangles(float sideA, float sideB, float sideC, float widht, float height)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Widht = widht;
            Height = height;
        }

        public float Area()
        {
            var area = Widht * Height / 2;
            return area;
        }

        public float Perimeter()
        {
            var perimeter = SideA + SideB + SideC;
            return perimeter;
        }
    }
}
