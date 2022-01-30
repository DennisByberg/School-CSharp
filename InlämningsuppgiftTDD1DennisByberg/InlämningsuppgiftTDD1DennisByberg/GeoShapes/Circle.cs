namespace InlämningsuppgiftTDD1DennisByberg

{
    using InlämningsuppgiftTDD1DennisByberg.Shapes;
    public class Circle : IShapeModel
    {
        public float Radius { get; }

        /// <summary>Initializes a new instance of the <see cref="Circle" /> class.</summary>
        /// <param name="radius">The radius.</param>
        public Circle(float radius) => Radius = radius;

        public float Area() => (float)Math.PI * Radius * Radius;
        public float Perimeter() => (float)Math.PI * Radius * 2;
    }
}
