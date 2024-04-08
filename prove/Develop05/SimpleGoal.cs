public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete) : base (name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailString()
    {
        string completionMarker = _isComplete ? "[x]" : "[]";
    return $"{completionMarker} {_shortName} ({_description})";

    }
    public override string GetStringRepresentation()
    {
        return $"Simple Goal,{_shortName},{_description},{_points},{_isComplete}";
    }
}