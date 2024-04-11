
public class Swimming : Activity
{
    private double _laps;
    public Swimming(int length, int laps) : base(length)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return GetDistance() / (GetLength() / 60.0);
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}