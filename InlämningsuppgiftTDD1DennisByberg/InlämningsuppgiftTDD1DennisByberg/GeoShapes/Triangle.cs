namespace InlämningsuppgiftTDD1DennisByberg

{
    using InlämningsuppgiftTDD1DennisByberg.Shapes;
    public class Triangle : IShapeModel
    {
        public float SideA { get; }
        public float SideB { get; }
        public float SideC { get; }

        /// <summary>Initializes a new instance of the <see cref="Triangle" /> class.</summary>
        /// <param name="sideA">The side a.</param>
        /// <param name="sideB">The side b.</param>
        /// <param name="sideC">The side c.</param>
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

        public float Perimeter() => SideA + SideB + SideC;
    }
}
