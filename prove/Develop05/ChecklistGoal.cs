public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base (name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        _amountCompleted += 1;
        if (IsComplete() == true)
        {
            return _bonus;
        }
        else
        {
            return _points;
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailString()
    {
        if (_amountCompleted >= _target)
        {
            return $"[x] {_shortName} ({_description} -- Currently completed {_amountCompleted}/{_target})";
        }
        else
        {
            return $"[] {_shortName} ({_description} -- Currently completed {_amountCompleted}/{_target})";
        }
    }
    public override string GetStringRepresentation()
    {
        return $"Checklist Goal,{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}