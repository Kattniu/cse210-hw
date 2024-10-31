public class Running : Activity
{
    private double distance; // distance in kilometers

    public Running(DateTime date, int durationMinutes, double distance)
        : base(date, durationMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance() => distance;

    public override double GetSpeed() => (distance / durationMinutes) * 60;

    public override double GetPace() => durationMinutes / distance;

    public override string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} Running ({durationMinutes} min): " +
               $"Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min/km";
    }
}
