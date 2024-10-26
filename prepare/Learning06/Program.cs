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
        List<Shape> shapes = new List<Shape> { square, rectangle, circle };//la lista List<Shape> shapes puede almacenar cualquier objeto que derive de Shape (gracias al polimorfismo).

        // Display color and area for each shape
        foreach (Shape shape in shapes) // Usamos un foreach para recorrer cada Shape en shapes. Llamamos a shape.Color y shape.GetArea():F2 para mostrar el color y el área con dos decimales.
        {
            Console.WriteLine($"Shape Color: {shape.Color}, Area: {shape.GetArea():F2}");
        }
    }
}
