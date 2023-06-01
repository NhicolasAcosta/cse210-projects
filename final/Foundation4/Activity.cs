public abstract class Activity
{
    private DateTime date;
    private int duration;
    public DateTime Date {get => date;}
    public int Duration {get => duration;}

    public Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        string activityType = GetType().Name;
        string dateStr = date.ToString("dd MMMM yyyy");
        string durationStr = duration + " min";
        string distanceStr = GetDistance().ToString("0.0");
        string speedStr = GetSpeed().ToString("0.0");
        string paceStr = GetPace().ToString("0.0");
        string summary = $"{dateStr} {activityType} ({durationStr}): ";
        summary += $"Distance: {distanceStr} miles, Speed: {speedStr} mph, Pace: {paceStr}";
        return summary;
    }
}

