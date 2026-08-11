public class ChecklistGoal : Goal
{
    private int _target;
    private int _amountCompleted;
    private int _bonus;

    public ChecklistGoal(
        string name,
        string description,
        int points,
        int target,
        int bonus)
        : base(name, description, points)
    {
        _target = target;
        _amountCompleted = 0;
        _bonus = bonus;
    }

    public ChecklistGoal(
        string name,
        string description,
        int points,
        int target,
        int bonus,
        int amountCompleted)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override int RecordEvent()
    {
        // Don't allow progress beyond the target.
        if (IsComplete())
        {
            return 0;
        }

        _amountCompleted++;

        int earnedPoints = GetPoints();

        // Give the bonus when the goal is completed.
        if (_amountCompleted == _target)
        {
            earnedPoints += _bonus;
        }

        return earnedPoints;
    }

    public override string GetDetailsString()
    {
        return $"{GetStatus()} {GetName()} ({GetDescription()}) " +
               $"-- Completed {_amountCompleted}/{_target} times";
    }

    public override string GetSaveString()
    {
        return $"Checklist|{GetName()}|{GetDescription()}|{GetPoints()}|" +
               $"{_target}|{_bonus}|{_amountCompleted}";
    }
}
