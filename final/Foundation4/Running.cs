public class Running : Activity
{
    private int _distance; // in miles
    public Running(int length, int distance) : base(length)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return 60 / GetPace();
    }
    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }
}