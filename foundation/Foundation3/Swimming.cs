public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int durationMinutes, int laps)
        : base(date, durationMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance() => (laps * 50) / 1000.0;

    public override double GetSpeed() => (GetDistance() / durationMinutes) * 60;

    public override double GetPace() => durationMinutes / GetDistance();

    public override string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} Swimming ({durationMinutes} min): " +
               $"Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min/km";
    }
}
