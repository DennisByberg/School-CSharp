using InlämningsuppgiftTDD1DennisByberg.Shapes;

namespace InlämningsuppgiftTDD1DennisByberg
{
    public class Triangle : IShapeModel
    {
        public float SideA { get; }
        public float SideB { get; }
        public float SideC { get; }

        public Triangle(float sideA, float sideB, float sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public float Area()
        {
            var s = (SideA + SideB + SideC) / 2;
            var area = (float)Math.Sqrt( s * ((s - SideA) * (s - SideB) * (s - SideC)));
            return area;
        }

        public float Perimeter()
        {
            var perimeter = SideA + SideB + SideC;
            return perimeter;
        }
    }
}
