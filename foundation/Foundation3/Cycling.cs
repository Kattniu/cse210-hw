public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int durationMinutes, double speed)
        : base(date, durationMinutes)
    {
        this.speed = speed;
    }

    public override double GetDistance() => (speed * durationMinutes) / 60;

    public override double GetSpeed() => speed;

    public override double GetPace() => 60 / speed;

    public override string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} Cycling ({durationMinutes} min): " +
               $"Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min/km";
    }
}
