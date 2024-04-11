public class Cycling : Activity
{
    private int _speed;
    public Cycling(int length, int speed) : base(length)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return _speed * GetLength() / 60;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 /_speed;
    }
}