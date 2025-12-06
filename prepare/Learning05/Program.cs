using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Rectangle rectangle = new Rectangle("green", 12.2, 13.2);
        Square square = new Square("red", 10);
        Circle circle = new Circle("pink", 10);

        shapes.Add(rectangle);
        shapes.Add(square);
        shapes.Add(circle);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"For the {color} shape, the area is {area}");
        }
    }
}