public class Swimming:Activity
{
    private int laps;
    public int Laps {get => laps;}
    public Swimming(DateTime date, int duration, int laps):base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        return (distance/Duration) * 60;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return Duration/distance;
    }
}

