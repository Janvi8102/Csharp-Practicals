using System;

namespace Pr7_OCP

{
    public abstract class Shape
    {
        public abstract double Area();
    }
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }

    class Program
    {
        public static double Area(Shape shape)
        {
            if (shape == null)
            {
                throw new Exception("Can not find area");
            }
            return shape.Area();
        }
        static void Main(string[] args)
        {

            Rectangle obj = new Rectangle();
            obj.Height = 10;
            obj.Width = 20;
            Console.WriteLine(Area(obj));
            Circle obj1 = new Circle();
            obj1.Radius = 10;
            Console.WriteLine(Area(obj1));
        }
    }
}
