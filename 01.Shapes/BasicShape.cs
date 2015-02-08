
namespace Problem_1.Shapes
{
    using System;

    public abstract class BasicShape : IShape
    {
        public double Width { get; set; }
        public double Heigth { get; set; }

        public BasicShape(double width, double height)
        {
            this.Width = width;
            this.Heigth = height;
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}
