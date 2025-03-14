class User
{
    private string _name;
    private List<Goal> _goals;
    private int _score;

    public User(string name)
    {
        _name = name;
        _goals = new List<Goal>();
        _score = 0;
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        Goal goal = _goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            goal.RecordProgress();
            _score += goal.Points;
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nUser Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goal.GetProgress()} {goal.Name} - {goal.Description}");
        }
        Console.WriteLine($"Total Score: {_score}\n");
    }
}