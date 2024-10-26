using System;

public abstract class Shape
{
    public string Color { get; set; }

    public Shape(string color) //n constructor que recibe el color y lo asigna a la propiedad Color.
    {
        Color = color;
    }

    public abstract double GetArea(); // Declara un método abstracto GetArea que devuelve un double y debe ser implementado en cada subclase (aquí no se calcula el área; solo se define el contrato para las subclases).
}
