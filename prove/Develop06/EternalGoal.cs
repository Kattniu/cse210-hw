using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) {}

    public override void RecordEvent()
    {
        Console.WriteLine($"¡Has registrado '{Name}' y ganaste {Points} puntos!");
    }

    public override string GetProgress()
    {
        return $"Progreso de '{Name}': siempre en progreso.";
    }
}
