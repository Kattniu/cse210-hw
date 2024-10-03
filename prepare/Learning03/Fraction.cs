using System;

public class Fraction
{
    private int _top;    // Numerador
    private int _bottom; // Denominador

    // Constructor por defecto que inicializa la fracción a 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor que acepta un número entero y lo usa como numerador (denominador = 1)
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor que acepta un numerador y un denominador
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Método que devuelve la fracción como una cadena (por ejemplo, "3/4")
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    // Método que devuelve el valor decimal de la fracción
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}
