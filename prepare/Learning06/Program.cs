using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of shapes
        Square square = new Square("Red", 4);
        Rectangle rectangle = new Rectangle("Blue", 3, 6);
        Circle circle = new Circle("Green", 5);

        // Add shapes to a list
        List<Shape> shapes = new List<Shape> { square, rectangle, circle };

        // Display color and area for each shape
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.Color}, Area: {shape.GetArea():F2}");
        }
    }
}
