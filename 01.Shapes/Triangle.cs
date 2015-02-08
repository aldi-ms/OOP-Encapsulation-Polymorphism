namespace Problem_1.Shapes
{
    using System;

    public class Triangle : BasicShape
    {
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double width, double height, double b, double c)
            : base(width, height)
        {
            this.Width = width;
            this.B = b;
            this.C = c;
            this.Heigth = height;
        } 

        public override double CalculateArea()
        {
            return this.Heigth * this.Width / 2;
        }

        public override double CalculatePerimeter()
        {
            return this.Width + this.B + this.C;
        }        
    }
}
