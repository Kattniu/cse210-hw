public class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base(color) //Constructor, Usa base -color- para pasar color al constructor de la clase Shape.
    {
        _side = side;
    }

    public override double GetArea() // Implementa el método GetArea() de la clase Shape y calcula el área multiplicando _side por sí mismo (_side * _side).
    {
        return _side * _side;
    }
}
