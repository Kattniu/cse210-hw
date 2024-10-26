using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) {}

    public override void RecordEvent()
    {
        IsComplete = true;
        Console.WriteLine($"¡Has completado el objetivo '{Name}' y ganaste {Points} puntos!");
    }

    public override string GetProgress()
    {
        return IsComplete ? $"'{Name}' está completo." : $"'{Name}' no está completo.";
    }
}
