class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction(); // 1/1
        Console.WriteLine(f1.GetFractionString()); // Muestra: 1/1
        Console.WriteLine(f1.GetDecimalValue());   // Muestra: 1.0

        Fraction f2 = new Fraction(5); // 5/1
        Console.WriteLine(f2.GetFractionString()); // Muestra: 5/1
        Console.WriteLine(f2.GetDecimalValue());   // Muestra: 5.0

        Fraction f3 = new Fraction(3, 4); // 3/4
        Console.WriteLine(f3.GetFractionString()); // Muestra: 3/4
        Console.WriteLine(f3.GetDecimalValue());   // Muestra: 0.75

        Fraction f4 = new Fraction(1, 3); // 1/3
        Console.WriteLine(f4.GetFractionString()); // Muestra: 1/3
        Console.WriteLine(f4.GetDecimalValue());   // Muestra: 0.333333...
    }
}
