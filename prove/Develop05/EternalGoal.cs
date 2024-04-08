public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {

    }

    public override int RecordEvent()
    {
        return _points;
    }
    public override bool IsComplete()
    {
        return true;
    }

    public override string GetDetailString()
    {
        return $"[] {_shortName} ({_description})";
    }
    public override string GetStringRepresentation()
    {
        return $"Eternal Goal:{_shortName},{_description},{_points}";
    }
}