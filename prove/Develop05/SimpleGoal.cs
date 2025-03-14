class SimpleGoal : Goal
{
    private bool _isComplete;
    public override bool IsComplete => _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordProgress()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Goal '{_name}' completed! Gained {_points} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{_name}' is already completed.");
        }
    }

    public override string GetProgress()
    {
        return _isComplete ? "[X]" : "[ ]";
    }
}