public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;  // Campo privado

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonus = bonus;  // Asignar el valor a la variable privada
    }

    public override void RecordEvent()
    {
        if (!IsComplete)
        {
            _currentCount++;
            Console.WriteLine($"You completed a task in '{Name}'. You earned {Points} points. ({_currentCount}/{_targetCount})");

            if (_currentCount >= _targetCount)
            {
                IsComplete = true;
                Console.WriteLine($"Congratulations! You have completed the goal '{Name}'! You earned a bonus of {_bonus} points.");

            }
        }
        else
        {
           Console.WriteLine($"The goal '{Name}' is already complete.");

        }
    }

    public override string GetProgress()
    {
        return IsComplete
    ? $"'{Name}' is complete."
    : $"Progress for '{Name}': {_currentCount}/{_targetCount} completed.";

    }
}
