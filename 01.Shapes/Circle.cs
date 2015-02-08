namespace Problem_1.Shapes
{
    using System;

    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double CalculateArea()
        {
            return this.Radius * this.Radius * Math.PI;
        }

        public double CalculatePerimeter()
        {
            return this.Radius * 2 * Math.PI;
        }
    }
}
