public class EternalGoal : Goal
{
    private int _timesCompleted;

    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _timesCompleted = 0;
    }

    public EternalGoal(
        string name,
        string description,
        int points,
        int timesCompleted)
        : base(name, description, points)
    {
        _timesCompleted = timesCompleted;
    }

    public override bool IsComplete()
    {
        // Eternal goals are never complete.
        return false;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        return GetPoints();
    }

    public override string GetDetailsString()
    {
        return $"{GetStatus()} {GetName()} ({GetDescription()}) " +
               $"-- Completed {_timesCompleted} times";
    }

    public override string GetSaveString()
    {
        return $"Eternal|{GetName()}|{GetDescription()}|{GetPoints()}|{_timesCompleted}";
    }
}
