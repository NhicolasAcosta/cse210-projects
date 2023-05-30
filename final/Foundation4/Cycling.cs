public class Cycling : Activity
{
    private double speed;

    public double Speed { get => speed; }

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return (Duration / speed) * 60;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / (speed / Duration);
    }
}

