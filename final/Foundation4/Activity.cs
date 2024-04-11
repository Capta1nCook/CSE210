public abstract class Activity
{
    private DateTime _date = DateTime.Now;
    private int _length;

    public Activity(int length)
    {
        _length = length;
    }
    public int GetLength()
    {
        return _length;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual void Display()
    {
        Console.WriteLine($"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_length} min) - Distance: {GetDistance()}, Speed: {GetSpeed()}, Pace: {GetPace()} min per mile");
    }
}