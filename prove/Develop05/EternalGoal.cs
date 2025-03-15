class EternalGoal : Goal
{
    public override bool IsComplete => false;

    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordProgress()
    {
        Console.WriteLine($"Recorded progress for '{_name}'. Gained {_points} points.");
    }

    public override string GetProgress()
    {
        return "[E]";
    }
}