class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;
    public override bool IsComplete => _timesCompleted >= _targetCount;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _timesCompleted = 0;
    }

    public override void RecordProgress()
    {
        _timesCompleted++;
        int totalPoints = _points;
        if (_timesCompleted == _targetCount)
        {
            totalPoints += _bonusPoints;
            Console.WriteLine($"Goal '{_name}' fully completed! Bonus {_bonusPoints} points awarded!");
        }
        Console.WriteLine($"Progress recorded for '{_name}'. Gained {totalPoints} points.");
    }

    public override string GetProgress()
    {
        return $"[{_timesCompleted}/{_targetCount}]";
    }
}