namespace Problem_1.Shapes
{
    using System;

    public class ShapesMain
    {
        public static void Main()
        {
            IShape[] shapes = new IShape[]
            {
                new Circle(12.3),
                new Triangle(10, 10, 10, 10),
                new Rectangle(12.4, 12)
            };

            foreach (IShape shape in shapes)
            {
                Console.WriteLine("{0}: area: {1:F2}; perimeter: {2:F2}",
                    shape.GetType().Name, shape.CalculateArea(), shape.CalculatePerimeter());
            }

            Console.ReadKey();
        }        
    }
}
